# latvanyossagokdb-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2020. Dec 08. 09:05
-- Kiszolgáló verziója: 10.4.10-MariaDB
-- PHP verzió: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `latvanyossagokdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `latvanyossagok`
--

DROP TABLE IF EXISTS `latvanyossagok`;
CREATE TABLE IF NOT EXISTS `latvanyossagok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(512) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(512) COLLATE utf8_hungarian_ci NOT NULL,
  `ar` int(11) NOT NULL DEFAULT 0,
  `varos_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `varos_id` (`varos_id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `latvanyossagok`
--

INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES
(14, 'awsd', 'assa', 12, 4),
(15, 'asd', 'asd', 12300, 5),
(16, 'qwe', '123', 0, 5),
(17, 'asdwa', 'dawsd', 12, 4),
(18, 'asdwa', 'dawsd', 0, 4),
(19, 'waasd', 'awsd', 1200, 4),
(20, 'Kicsi kacsa', 'Kicsi a kacsa', 1200, 1),
(22, 'Alma puvilás', 'wasd', 1200, 5),
(28, 'ads', 'elso', 1329, 8),
(29, 'sss', 'aaaa', 1111, 5),
(31, 'aaaaaaaaa', 'ssssssssss', 1200, 3);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

DROP TABLE IF EXISTS `varosok`;
CREATE TABLE IF NOT EXISTS `varosok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(512) COLLATE utf8_hungarian_ci NOT NULL,
  `lakossag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `varosok`
--

INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES
(3, 'Pécs', 100),
(8, 'Wasd', 850),
(9, 'asd', 1200),
(10, 'wwww', 853);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
