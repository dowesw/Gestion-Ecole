-- phpMyAdmin SQL Dump
-- version 3.4.10.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 13, 2015 at 02:29 PM
-- Server version: 5.5.20
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gestion_ecole`
--

-- --------------------------------------------------------

--
-- Table structure for table `batiment`
--

CREATE TABLE IF NOT EXISTS `batiment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `classe`
--

CREATE TABLE IF NOT EXISTS `classe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  `montant` double NOT NULL DEFAULT '0',
  `batiment` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `batiment` (`batiment`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `eleve`
--

CREATE TABLE IF NOT EXISTS `eleve` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `matricule` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `date_naissance` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `matricule` (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `niveau_scolaire`
--

CREATE TABLE IF NOT EXISTS `niveau_scolaire` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `annee_scolaire` int(11) NOT NULL,
  `eleve` int(11) NOT NULL,
  `classe` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `eleve` (`eleve`),
  KEY `classe` (`classe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `paiement`
--

CREATE TABLE IF NOT EXISTS `paiement` (
  `id` int(11) NOT NULL,
  `date_paiement` date NOT NULL,
  `montant` double NOT NULL DEFAULT '0',
  `eleve` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `eleve` (`eleve`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classe`
--
ALTER TABLE `classe`
  ADD CONSTRAINT `classe_ibfk_2` FOREIGN KEY (`batiment`) REFERENCES `batiment` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `niveau_scolaire`
--
ALTER TABLE `niveau_scolaire`
  ADD CONSTRAINT `niveau_scolaire_ibfk_2` FOREIGN KEY (`classe`) REFERENCES `classe` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `niveau_scolaire_ibfk_1` FOREIGN KEY (`eleve`) REFERENCES `eleve` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `paiement`
--
ALTER TABLE `paiement`
  ADD CONSTRAINT `paiement_ibfk_2` FOREIGN KEY (`eleve`) REFERENCES `eleve` (`id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
