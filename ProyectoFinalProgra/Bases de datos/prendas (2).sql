-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-12-2024 a las 02:10:42
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
-- Estructura de tabla para la tabla `prendas`
--

CREATE TABLE `prendas` (
  `id` int(11) NOT NULL,
  `producto` varchar(30) NOT NULL,
  `imagen` varchar(30) NOT NULL,
  `precio` double NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `Existencias` int(11) NOT NULL,
  `imagen2` varchar(30) NOT NULL,
  `color` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `prendas`
--

INSERT INTO `prendas` (`id`, `producto`, `imagen`, `precio`, `Descripcion`, `Existencias`, `imagen2`, `color`) VALUES
(1112, 'Traje de Hombre Café ', 'sacocafeM.jpg ', 4560.9, 'Está diseñado para destacar tu estilo \r\nformal con un toque moderno. Fabricado \r\ncon materiales de alta calidad, cuenta \r\ncon un corte Slim Fit que resalta la \r\nsilueta.', 8, 'sacocafeM.jpg ', 'caf'),
(1113, 'Traje de Hombre Gris Oscuro ', 'sacogrisM.jpg ', 3610.8, 'El saco con un diseño tradicional \r\ncon solapa delgada, bolsillos discretos \r\ny un cierre de dos botones. El pantalón\r\ntiene una caída perfecta y con ajuste \r\npreciso.', 2, 'sacogrisM.jpg ', 'gri'),
(1233, 'saco', 'saco2.jpg', 1200.9, 'Saco negro para fiestas\r\nperfecto para verse formal y casual', 8, 'sacomod.jpg', 'neg'),
(1234, 'Pantalón de Vestir', 'pantalonA1.jpg ', 720.6, 'Este pantalón de vestir para hombre \r\ncombina comodidad y estilo. Con un \r\ncorte clásico y un ajuste recto, \r\nbrinda una apariencia estilizada \r\ny moderna. ', 5, 'pantalonA3.jpg', 'Azu'),
(3456, 'Pantalón Casual ', 'pantalonC1.jpg ', 567, 'Este pantalón casual para hombre es \r\nperfecta por la comodidad. Con un \r\ncorte recto y un diseño de líneas limpias,\r\nes ideal tanto para el día a día como para\r\nuna reunión.', 10, 'pantalonC3.jpg', 'Bei'),
(8943, 'Zapatos Oxford Clásico', 'oxford.jpg ', 870, 'Los zapatos Oxford para caballero \r\ncombina la elegancia clásica con\r\nuna calidad excepcional ideal \r\npara ocasiones formales.', 10, 'oxford.jpg ', 'Neg');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `prendas`
--
ALTER TABLE `prendas`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
