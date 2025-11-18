<?php
session_start();

// Minden session változó törlése
$_SESSION = [];

// Session cookie törlése (ha van)
if (ini_get("session.use_cookies")) {
    $params = session_get_cookie_params();
    setcookie(
        session_name(),
        '',
        time() - 42000,
        $params["path"],
        $params["domain"],
        $params["secure"],
        $params["httponly"]
    );
}

// Session lezárása
session_destroy();

// Vissza a login oldalra
header("Location: partner_login.php");
exit;
