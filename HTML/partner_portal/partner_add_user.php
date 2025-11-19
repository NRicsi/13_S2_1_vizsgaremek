<?php
session_start();
require_once "db.php";

// Ha nincs bejelentkezve → login
if (!isset($_SESSION['user_id'])) {
    header("Location: partner_login.php");
    exit;
}

$ceg_id = $_SESSION['ceg_id'];
$errors = [];
$success = "";

// Random jelszó generáló
function generatePassword($length = 12) {
    $chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    return substr(str_shuffle($chars), 0, $length);
}

// Form feldolgozás
if ($_SERVER["REQUEST_METHOD"] === "POST") {

    $nev   = trim($_POST['nev'] ?? '');
    $email = trim($_POST['email'] ?? '');

    if ($nev === "") $errors[] = "A név mező kötelező.";
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) $errors[] = "Érvénytelen email cím.";

    // Email már létezik?
    if (empty($errors)) {
        $stmt = $pdo->prepare("SELECT id FROM felhasznalok WHERE email = :email LIMIT 1");
        $stmt->execute(['email' => $email]);
        if ($stmt->fetch()) {
            $errors[] = "Ezzel az email címmel már létezik felhasználó.";
        }
    }

    if (empty($errors)) {

        // Automatikus jelszó generálása
        $password_plain = generatePassword(12);
        $password_hash  = password_hash($password_plain, PASSWORD_BCRYPT);

        // Felhasználó hozzáadása a céghez
        $stmt = $pdo->prepare("
            INSERT INTO felhasznalok (ceg_id, email, jelszo_hash, teljes_nev, aktiv)
            VALUES (:ceg_id, :email, :hash, :nev, 1)
        ");

        $stmt->execute([
            'ceg_id' => $ceg_id,
            'email'  => $email,
            'hash'   => $password_hash,
            'nev'    => $nev
        ]);

        $success = "Siker! Az új munkavállaló hozzáadva.<br>
                    <b>Email:</b> {$email}<br>
                    <b>Jelszó:</b> {$password_plain}<br><br>
                    Kérjük, küldje el neki az adatokat.";
    }
}
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Alkalmazott hozzáadása – ÚtdíjPro</title>

    <script src="https://cdn.tailwindcss.com"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.2/css/all.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap" rel="stylesheet">

    <style>
        :root {
            --color-primary: #0ea5e9;
            --color-secondary: #6366f1;
            --color-background: #030712;
            --color-surface: #0f172a;
            --color-text-base: #e2e8f0;
            --color-text-muted: #94a3b8;
            --color-border: rgba(56, 189, 248, 0.2);
        }
        body {
            font-family: 'Poppins', sans-serif;
            background: var(--color-background);
            color: var(--color-text-base);
        }
        .card {
            background: rgba(15, 23, 42, 0.65);
            border: 1px solid var(--color-border);
            backdrop-filter: blur(12px);
        }
        .input-box {
            background: rgba(30, 41, 59, 0.8);
            border: 1px solid var(--color-border);
            color: white;
        }
        .input-box:focus {
            border-color: var(--color-primary);
            outline: none;
        }
        .button-main {
            background: linear-gradient(90deg, var(--color-primary), var(--color-secondary));
            color: white;
        }
    </style>
</head>

<body class="p-6">

    <div class="max-w-xl mx-auto mt-10 card p-8 rounded-2xl shadow-xl">

        <h1 class="text-3xl font-semibold text-sky-300 mb-6">
            <i class="fas fa-user-plus mr-2"></i>Új alkalmazott hozzáadása
        </h1>

        <?php if (!empty($errors)): ?>
            <div class="mb-4 p-4 border border-red-500 bg-red-900/40 rounded-lg text-red-200">
                <ul class="list-disc ml-4">
                    <?php foreach ($errors as $e): ?>
                        <li><?php echo $e; ?></li>
                    <?php endforeach; ?>
                </ul>
            </div>
        <?php endif; ?>

        <?php if (!empty($success)): ?>
            <div class="mb-4 p-4 border border-green-500 bg-green-900/40 rounded-lg text-green-200">
                <?php echo $success; ?>
            </div>
        <?php endif; ?>

        <form method="POST" class="space-y-6">

            <div>
                <label class="text-sky-200 text-sm mb-1 block">Alkalmazott neve *</label>
                <input type="text" name="nev" class="input-box w-full p-3 rounded-lg"
                       placeholder="Pl. Kiss Péter" required>
            </div>

            <div>
                <label class="text-sky-200 text-sm mb-1 block">Email cím *</label>
                <input type="email" name="email" class="input-box w-full p-3 rounded-lg"
                       placeholder="valaki@ceg.hu" required>
            </div>

            <button type="submit"
                    class="button-main w-full py-3 rounded-lg font-semibold text-lg shadow-lg hover:scale-[1.02] transition">
                <i class="fas fa-plus-circle mr-2"></i>Felhasználó létrehozása
            </button>
        </form>

    </div>

</body>
</html>
