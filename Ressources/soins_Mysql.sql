-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 03 Octobre 2016 à 08:49
-- Version du serveur :  5.7.9
-- Version de PHP :  7.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `soins`
--

USE `soins`;

-- --------------------------------------------------------

--
-- Contenu de la table `dossier`
--

INSERT INTO `dossier` (`id`, `nom`, `prenom`, `datenaissance`) VALUES
(1, 'Robert', 'Jean', '1980-12-03'),
(2, 'Blanc', 'Sophie', '1995-02-14');


--
-- Contenu de la table `intervenant`
--

INSERT INTO `intervenant` (`id`, `nom`, `prenom`) VALUES
(1, 'Dr Intervun', 'Jean'),
(2, 'Dr Intervdeux', 'Martine'),
(3, 'Dr Intervtrois', 'Michel');

--
-- Contenu de la table `intervenantexterne`
--

INSERT INTO `intervenantexterne` (`id`, `specialite`, `adresse`, `tel`) VALUES
(2, 'cardiologue', 'Boulevard de Starsbourg 83000 Toulon', '04 94 94 94 94'),
(3, 'radiologue', 'Avenue de la république 83000 Toulon', '04 94 90 90 90');

--
-- Contenu de la table `prestation`
--

INSERT INTO `prestation` (`id`, `nom`, `dateprestation`, `iddossier`, `idintervenant`) VALUES
(1, 'Libelle Prestation 1', '2015-09-10 12:15:00', 1, 1),
(2, 'Libelle Prestation 3', '2015-09-01 14:00:00', 1, 2),
(3, 'Libelle Prestation 15', '2015-09-01 16:00:00', 1, 3),
(4, 'Libelle Prestation 17', '2015-09-01 18:00:00', 1, 3);



/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
