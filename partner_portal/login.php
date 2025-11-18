<?php
// login.php
session_start();
require_once 'db.php';

$error = '';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $email    = trim($_POST['email'] ?? '');
    $password = $_POST['password'] ?? '';

    if ($email === '' || $password === '') {
        $error = 'Kérjük, töltse ki az email és jelszó mezőket!';
    } else {
        $stmt = $pdo->prepare("
            SELECT id, ceg_id, email, jelszo_hash, teljes_nev, aktiv
            FROM felhasznalok
            WHERE email = :email
            LIMIT 1
        ");
        $stmt->execute(['email' => $email]);
        $user = $stmt->fetch();

        if ($user && (int)$user['aktiv'] === 1 && password_verify($password, $user['jelszo_hash'])) {
            // Sikeres bejelentkezés – session adatok
            $_SESSION['user_id']   = $user['id'];
            $_SESSION['ceg_id']    = $user['ceg_id'];
            $_SESSION['user_name'] = $user['teljes_nev'] ?: $user['email'];

            header('Location: partner_dashboard.php');
            exit;
        } else {
            $error = 'Hibás email cím vagy jelszó, vagy a felhasználó inaktív.';
        }
    }
}
?>
