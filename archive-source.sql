-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 26, 2020 at 12:21 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `archive-source`
--

-- --------------------------------------------------------

--
-- Table structure for table `escuela`
--

CREATE TABLE `escuela` (
  `id_escuela` int(11) NOT NULL,
  `id_estudio` int(11) NOT NULL,
  `cod_nino` varchar(7) NOT NULL,
  `Estado` tinyint(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `estudio`
--

CREATE TABLE `estudio` (
  `id_estudio` int(11) NOT NULL,
  `NombreEscuela` varchar(50) NOT NULL,
  `img_notas` varchar(255) NOT NULL,
  `Grado` varchar(20) NOT NULL,
  `Turno` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `familia`
--

CREATE TABLE `familia` (
  `id_familia` varchar(5) NOT NULL,
  `ApellidoFamiliar` varchar(40) NOT NULL,
  `Direccion` varchar(50) NOT NULL,
  `Telefono` varchar(9) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grado`
--

CREATE TABLE `grado` (
  `id_grado` int(11) NOT NULL,
  `NombreGrado` varchar(40) NOT NULL,
  `RangoMinimo` int(11) NOT NULL,
  `RangoMaximo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `historial`
--

CREATE TABLE `historial` (
  `id_historial` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `temperatura` double NOT NULL,
  `peso` double NOT NULL,
  `talla` double NOT NULL,
  `PresionArterial` double NOT NULL,
  `IMC` double NOT NULL,
  `Consultador` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `historialclinico`
--

CREATE TABLE `historialclinico` (
  `id_historialClinico` int(11) NOT NULL,
  `id_historial` int(11) NOT NULL,
  `cod_nino` varchar(7) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `main`
--

CREATE TABLE `main` (
  `id_admin` int(11) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Contra` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `main`
--

INSERT INTO `main` (`id_admin`, `Usuario`, `Nombre`, `Contra`) VALUES
(1, 'admin', 'Administrador', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `medicamentos`
--

CREATE TABLE `medicamentos` (
  `id_medicamento` int(11) NOT NULL,
  `cod_nino` varchar(7) NOT NULL,
  `DescripcionMedicamento` text NOT NULL,
  `Monto` double NOT NULL,
  `NombreTutor` varchar(40) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `miembrosfamiliares`
--

CREATE TABLE `miembrosfamiliares` (
  `Cod_nino` varchar(7) NOT NULL,
  `id_familia` int(11) NOT NULL,
  `Nombre` varchar(40) NOT NULL,
  `Apellido` varchar(40) NOT NULL,
  `Edad` int(11) NOT NULL,
  `Sexo` varchar(10) NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `id_tutor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `regalo`
--

CREATE TABLE `regalo` (
  `id_regalo` int(11) NOT NULL,
  `cod_nino` varchar(7) NOT NULL,
  `id_tipoRegalo` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Monto` double NOT NULL,
  `Clase regalo` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sub`
--

CREATE TABLE `sub` (
  `id_tutor` int(11) NOT NULL,
  `Usuario` varchar(25) NOT NULL,
  `Nombre` varchar(40) NOT NULL,
  `Apellido` varchar(40) NOT NULL,
  `Telefono` varchar(9) NOT NULL,
  `Correo` varchar(30) NOT NULL,
  `Contra` varchar(25) NOT NULL,
  `id_admin` int(11) NOT NULL,
  `id_grado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tiporegalo`
--

CREATE TABLE `tiporegalo` (
  `id_tipoRegalo` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `escuela`
--
ALTER TABLE `escuela`
  ADD PRIMARY KEY (`id_escuela`),
  ADD KEY `id_estudio` (`id_estudio`),
  ADD KEY `cod_nino` (`cod_nino`);

--
-- Indexes for table `estudio`
--
ALTER TABLE `estudio`
  ADD PRIMARY KEY (`id_estudio`);

--
-- Indexes for table `familia`
--
ALTER TABLE `familia`
  ADD PRIMARY KEY (`id_familia`);

--
-- Indexes for table `grado`
--
ALTER TABLE `grado`
  ADD PRIMARY KEY (`id_grado`);

--
-- Indexes for table `historial`
--
ALTER TABLE `historial`
  ADD PRIMARY KEY (`id_historial`);

--
-- Indexes for table `historialclinico`
--
ALTER TABLE `historialclinico`
  ADD PRIMARY KEY (`id_historialClinico`),
  ADD KEY `id_historial` (`id_historial`),
  ADD KEY `cod_nino` (`cod_nino`);

--
-- Indexes for table `main`
--
ALTER TABLE `main`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `medicamentos`
--
ALTER TABLE `medicamentos`
  ADD PRIMARY KEY (`id_medicamento`),
  ADD KEY `cod_nino` (`cod_nino`);

--
-- Indexes for table `miembrosfamiliares`
--
ALTER TABLE `miembrosfamiliares`
  ADD PRIMARY KEY (`Cod_nino`),
  ADD KEY `id_tutor` (`id_tutor`),
  ADD KEY `id_familia` (`id_familia`);

--
-- Indexes for table `regalo`
--
ALTER TABLE `regalo`
  ADD PRIMARY KEY (`id_regalo`),
  ADD KEY `id_tipoRegalo` (`id_tipoRegalo`),
  ADD KEY `cod_nino` (`cod_nino`);

--
-- Indexes for table `sub`
--
ALTER TABLE `sub`
  ADD PRIMARY KEY (`id_tutor`),
  ADD KEY `id_admin` (`id_admin`),
  ADD KEY `id_grado` (`id_grado`);

--
-- Indexes for table `tiporegalo`
--
ALTER TABLE `tiporegalo`
  ADD PRIMARY KEY (`id_tipoRegalo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `escuela`
--
ALTER TABLE `escuela`
  MODIFY `id_escuela` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `grado`
--
ALTER TABLE `grado`
  MODIFY `id_grado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `historial`
--
ALTER TABLE `historial`
  MODIFY `id_historial` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `historialclinico`
--
ALTER TABLE `historialclinico`
  MODIFY `id_historialClinico` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `main`
--
ALTER TABLE `main`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `medicamentos`
--
ALTER TABLE `medicamentos`
  MODIFY `id_medicamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `regalo`
--
ALTER TABLE `regalo`
  MODIFY `id_regalo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sub`
--
ALTER TABLE `sub`
  MODIFY `id_tutor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tiporegalo`
--
ALTER TABLE `tiporegalo`
  MODIFY `id_tipoRegalo` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
