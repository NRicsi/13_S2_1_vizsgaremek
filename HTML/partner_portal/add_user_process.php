<?php
session_start();

if (!isset($_SESSION['user_id'], $_SESSION['ceg_id'])) {
    header("Location: partner_login.php");
    exit;
}

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    header("Location: partner_dashboard.php");
    exit;
}

require_once 'db.php'; // itt legyen benne a $pdo (PDO kapcsolat)

$ceg_id    = (int)$_SESSION['ceg_id'];
$full_name = trim($_POST['full_name'] ?? '');
$email     = trim($_POST['email'] ?? '');
$password  = $_POST['password'] ?? '';
$password2 = $_POST['password_confirm'] ?? '';

if ($full_name === '' || $email === '' || $password === '' || $password2 === '') {
    die('Hiba: minden mező kitöltése kötelező.');
}

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    die('Hiba: érvénytelen email cím.');
}

if ($password !== $password2) {
    die('Hiba: a két jelszó nem egyezik.');
}

// Email ütközés ellenőrzése
try {
    $stmt = $pdo->prepare("SELECT id FROM felhasznalok WHERE email = :email LIMIT 1");
    $stmt->execute(['email' => $email]);
    if ($stmt->fetch()) {
        die('Hiba: ezzel az email címmel már létezik felhasználó.');
    }

    // Jelszó hash
    $hash = password_hash($password, PASSWORD_BCRYPT);

    // Új user beszúrása a bejelentkezett céghez
    $insert = $pdo->prepare("
        INSERT INTO felhasznalok (ceg_id, email, jelszo_hash, teljes_nev, aktiv, created_at)
        VALUES (:ceg_id, :email, :hash, :nev, 1, NOW())
    ");
    $insert->execute([
        'ceg_id' => $ceg_id,
        'email'  => $email,
        'hash'   => $hash,
        'nev'    => $full_name
    ]);

    header("Location: partner_dashboard.php?msg=success_user_added#addUserContent");
    exit;

} catch (PDOException $e) {
    // Fejlesztéskor hasznos:
    // die('Adatbázis hiba: ' . $e->getMessage());
    die('Váratlan adatbázis hiba történt.');
}
