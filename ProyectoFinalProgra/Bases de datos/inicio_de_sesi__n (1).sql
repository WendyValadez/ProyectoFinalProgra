-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-12-2024 a las 02:10:31
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `kingsman`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inicio de sesión`
--

CREATE TABLE `inicio de sesión` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Cuenta` varchar(30) NOT NULL,
  `Contraseña` varchar(30) NOT NULL,
  `Monto` double(10,2) NOT NULL,
  `ID_tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `inicio de sesión`
--

INSERT INTO `inicio de sesión` (`ID`, `Nombre`, `Cuenta`, `Contraseña`, `Monto`, `ID_tipo`) VALUES
(0, 'Invitado', 'Invitado', 'kingsman', 0.00, 0),
(280227, 'Cesar Ortiz ', 'CesarOr', 'cesaryael', 0.00, 0),
(302413, 'Wendy Herrera', 'WendyH', 'wivh', 0.00, 0),
(453204, 'Frida Martinez', 'Admin', 'frida12', 0.00, 1),
(521395, 'Yasmin Trinidad', 'Yasmin09', 'jessy12', 0.00, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `inicio de sesión`
--
ALTER TABLE `inicio de sesión`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
