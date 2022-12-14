-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Dec 14. 11:38
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `felhasznalokep`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `adatok`
--

CREATE TABLE `adatok` (
  `id` int(11) NOT NULL,
  `nev` varchar(255) NOT NULL,
  `szuletesidatum` varchar(255) NOT NULL,
  `profilkep` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `adatok`
--

INSERT INTO `adatok` (`id`, `nev`, `szuletesidatum`, `profilkep`) VALUES
(4, 'teszt', '2022. december 14., szerda', 'masodik.png'),
(5, 'teszt2', '2022. november 30., szerda', 'elso.png');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `adatok`
--
ALTER TABLE `adatok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `adatok`
--
ALTER TABLE `adatok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
