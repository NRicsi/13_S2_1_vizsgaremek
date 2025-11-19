<?php
session_start();

//minden session valtozo torlese
$_SESSION = [];

// session cookiek torlese
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

// session closeolasa
session_destroy();

// back a login oldalra
header("Location: partner_login.php");
exit;