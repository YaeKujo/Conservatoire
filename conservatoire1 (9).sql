-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 01 juin 2023 à 23:34
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `conservatoire1`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE `admin` (
  `login` varchar(100) NOT NULL,
  `mdp` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`login`, `mdp`) VALUES
('RH_01', '7n6p8;DA5qyU&*');

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE `eleve` (
  `IDELEVE` int(11) NOT NULL,
  `BOURSE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`IDELEVE`, `BOURSE`) VALUES
(71, 3),
(72, 1),
(75, 2),
(76, 2),
(77, 3),
(78, 2),
(82, 1),
(84, 1);

-- --------------------------------------------------------

--
-- Structure de la table `heure`
--

CREATE TABLE `heure` (
  `TRANCHE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `heure`
--

INSERT INTO `heure` (`TRANCHE`) VALUES
('10h'),
('11h'),
('12h'),
('14h'),
('15h'),
('16h'),
('17h'),
('18h'),
('8h'),
('9h');

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE `inscription` (
  `IDPROF` int(11) NOT NULL,
  `IDELEVE` int(11) NOT NULL,
  `NUMSEANCE` int(11) NOT NULL,
  `DATEINSCRIPTION` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`IDPROF`, `IDELEVE`, `NUMSEANCE`, `DATEINSCRIPTION`) VALUES
(73, 71, 1, '2023-02-05'),
(73, 76, 3, '2023-04-02'),
(73, 82, 2, '2023-02-16'),
(78, 82, 1, '2023-05-29'),
(79, 71, 3, '2023-03-01'),
(79, 71, 4, '2023-05-05'),
(79, 72, 2, '2023-05-29'),
(79, 75, 4, '2023-05-24'),
(79, 76, 2, '2023-05-29');

-- --------------------------------------------------------

--
-- Structure de la table `instrument`
--

CREATE TABLE `instrument` (
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `instrument`
--

INSERT INTO `instrument` (`LIBELLE`) VALUES
('Batterie'),
('Guitare'),
('piano'),
('Saxophone'),
('Trompette'),
('Violon');

-- --------------------------------------------------------

--
-- Structure de la table `jour`
--

CREATE TABLE `jour` (
  `JOUR` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `jour`
--

INSERT INTO `jour` (`JOUR`) VALUES
('Jeudi'),
('Lundi'),
('Mardi'),
('Mercredi'),
('Samedi'),
('Vendredi');

-- --------------------------------------------------------

--
-- Structure de la table `niveau`
--

CREATE TABLE `niveau` (
  `NIVEAU` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `niveau`
--

INSERT INTO `niveau` (`NIVEAU`) VALUES
(1),
(2),
(3);

-- --------------------------------------------------------

--
-- Structure de la table `payer`
--

CREATE TABLE `payer` (
  `IDPROF` int(11) NOT NULL,
  `IDELEVE` int(11) NOT NULL,
  `NUMSEANCE` int(11) NOT NULL,
  `LIBELLE` char(32) NOT NULL,
  `DATEPAIEMENT` char(32) DEFAULT NULL,
  `PAYE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `payer`
--

INSERT INTO `payer` (`IDPROF`, `IDELEVE`, `NUMSEANCE`, `LIBELLE`, `DATEPAIEMENT`, `PAYE`) VALUES
(0, 71, 0, 'trim1', '2023-05-30 17:21:14', 1),
(0, 75, 0, 'trim1', '2023-05-30 17:21:22', 1),
(0, 76, 0, 'trim2', '2023-05-30 17:31:55', 1);

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `ID` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `TEL` int(11) DEFAULT NULL,
  `MAIL` char(32) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`ID`, `NOM`, `PRENOM`, `TEL`, `MAIL`, `ADRESSE`) VALUES
(69, 'Uzumaki', 'Naruto', 768566953, 'uzumaki@gmail.com', '18 rue du rocher'),
(71, 'Kurosaki', 'Ichigo', 768566953, 'ichi@gmail.com', '45 rue du donjon'),
(72, 'Midoriya', 'Izuku', 686953245, 'izuku@gmail.com', '16 rue de Paris'),
(73, 'Sensei', 'Koro', 768566953, 'koro@gmail.com', '12 rue de l\'espace'),
(74, 'Hatake', 'Kakashi', 768566953, 'hatake@gmail.com', '18 rue de la fontaine'),
(75, 'Haruno', 'Sakura', 768566953, 'Sakura@gmail.com', '18 rue de la montagne'),
(76, 'Yeager', 'Eren', 768566953, 'eren@gmail.com', '27 rue du mur'),
(77, 'Monkey D', 'Luffy', 768566953, 'Lulu@gmail.com', '1 rue de East Blue'),
(78, 'Umino', 'Iruka', 768566953, 'Iruka@gmail.com', '1 rue du fossée'),
(79, 'Satoru', 'Gojo', 768566953, 'Gojo@gmail.com', '27 rue de Shibuya'),
(80, 'Maito', 'Gaï', 768566953, 'maito@gmail.com', '87 rue de la joie'),
(81, 'Baitiche', 'Sarah', 768566953, 's.baitiche@gmail.com', '22 voie des moulins sud'),
(82, 'AISSAOUI', 'Yasmine', 5638979, 'YAYA@gmail.com', '13 rue du chateau'),
(84, 'Boumaaz', 'Rayan', 767051707, 'RAYOU@gmail.com', '15 voie de Marseille'),
(96, 'Baitiche', 'Sarah', 767051707, 'S.Baitiche13@gmail.com', '22 VOIE DES MOULINS SUD'),
(111, 'Ahmed', 'Laam', 767051707, 'LaamAhmed@gmail.com', '13 rue de gentilly');

-- --------------------------------------------------------

--
-- Structure de la table `prof`
--

CREATE TABLE `prof` (
  `IDPROF` int(11) NOT NULL,
  `INSTRUMENT` char(32) NOT NULL,
  `SALAIRE` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `prof`
--

INSERT INTO `prof` (`IDPROF`, `INSTRUMENT`, `SALAIRE`) VALUES
(73, 'Batterie', 4.00),
(78, 'Violon', 3.00),
(79, 'piano', 5.00),
(80, 'Saxophone', 5.00),
(96, 'piano', 999.99),
(111, 'piano', 999.99);

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

CREATE TABLE `seance` (
  `IDPROF` int(11) NOT NULL,
  `NUMSEANCE` int(11) NOT NULL,
  `TRANCHE` char(32) NOT NULL,
  `JOUR` char(32) NOT NULL,
  `NIVEAU` int(11) NOT NULL,
  `CAPACITE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `seance`
--

INSERT INTO `seance` (`IDPROF`, `NUMSEANCE`, `TRANCHE`, `JOUR`, `NIVEAU`, `CAPACITE`) VALUES
(73, 4, '11h', 'Lundi', 1, 6),
(73, 6, '10h', 'Mercredi', 2, 6),
(78, 1, '18h', 'Vendredi', 2, 6),
(79, 2, '14h', 'Mardi', 3, 10),
(80, 3, '12h', 'Mercredi', 2, 5),
(96, 5, '18h', 'Vendredi', 1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `trim`
--

CREATE TABLE `trim` (
  `LIBELLE` char(32) NOT NULL,
  `DATEFIN` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `trim`
--

INSERT INTO `trim` (`LIBELLE`, `DATEFIN`) VALUES
('trim1', '31/03/2023'),
('trim2', '30/06/2023'),
('trim3', '30/09/2023'),
('trim4', '31/12/2023');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD PRIMARY KEY (`IDELEVE`);

--
-- Index pour la table `heure`
--
ALTER TABLE `heure`
  ADD PRIMARY KEY (`TRANCHE`);

--
-- Index pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD PRIMARY KEY (`IDPROF`,`IDELEVE`,`NUMSEANCE`),
  ADD KEY `I_FK_INSCRIPTION_ELEVE` (`IDELEVE`),
  ADD KEY `I_FK_INSCRIPTION_SEANCE` (`IDPROF`,`NUMSEANCE`),
  ADD KEY `fk_numSeance` (`NUMSEANCE`);

--
-- Index pour la table `instrument`
--
ALTER TABLE `instrument`
  ADD PRIMARY KEY (`LIBELLE`);

--
-- Index pour la table `jour`
--
ALTER TABLE `jour`
  ADD PRIMARY KEY (`JOUR`);

--
-- Index pour la table `niveau`
--
ALTER TABLE `niveau`
  ADD PRIMARY KEY (`NIVEAU`),
  ADD KEY `NIVEAU` (`NIVEAU`);

--
-- Index pour la table `payer`
--
ALTER TABLE `payer`
  ADD PRIMARY KEY (`IDPROF`,`IDELEVE`,`NUMSEANCE`,`LIBELLE`),
  ADD KEY `I_FK_PAYER_INSCRIPTION` (`IDPROF`,`IDELEVE`,`NUMSEANCE`),
  ADD KEY `I_FK_PAYER_TRIM` (`LIBELLE`),
  ADD KEY `fk_paye_eleve` (`IDELEVE`),
  ADD KEY `fk_paye_numSeance` (`NUMSEANCE`);

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `prof`
--
ALTER TABLE `prof`
  ADD PRIMARY KEY (`IDPROF`),
  ADD KEY `I_FK_PROF_INSTRUMENT` (`INSTRUMENT`);

--
-- Index pour la table `seance`
--
ALTER TABLE `seance`
  ADD PRIMARY KEY (`IDPROF`,`NUMSEANCE`),
  ADD KEY `I_FK_SEANCE_JOUR` (`JOUR`),
  ADD KEY `I_FK_SEANCE_NIVEAU` (`NIVEAU`),
  ADD KEY `I_FK_SEANCE_PROF` (`IDPROF`),
  ADD KEY `fk_tranche` (`TRANCHE`),
  ADD KEY `NUMSEANCE` (`NUMSEANCE`);

--
-- Index pour la table `trim`
--
ALTER TABLE `trim`
  ADD PRIMARY KEY (`LIBELLE`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `personne`
--
ALTER TABLE `personne`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `fk_idEleve` FOREIGN KEY (`IDELEVE`) REFERENCES `personne` (`ID`);

--
-- Contraintes pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `fk_insc_eleve` FOREIGN KEY (`IDELEVE`) REFERENCES `eleve` (`IDELEVE`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_inscr_prof` FOREIGN KEY (`IDPROF`) REFERENCES `prof` (`IDPROF`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_numSeance` FOREIGN KEY (`NUMSEANCE`) REFERENCES `seance` (`NUMSEANCE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `payer`
--
ALTER TABLE `payer`
  ADD CONSTRAINT `fk_paye_eleve` FOREIGN KEY (`IDELEVE`) REFERENCES `eleve` (`IDELEVE`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_paye_lib` FOREIGN KEY (`LIBELLE`) REFERENCES `trim` (`LIBELLE`);

--
-- Contraintes pour la table `prof`
--
ALTER TABLE `prof`
  ADD CONSTRAINT `fk_idProf` FOREIGN KEY (`IDPROF`) REFERENCES `personne` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_refInstrument` FOREIGN KEY (`INSTRUMENT`) REFERENCES `instrument` (`LIBELLE`);

--
-- Contraintes pour la table `seance`
--
ALTER TABLE `seance`
  ADD CONSTRAINT `fk_jour` FOREIGN KEY (`JOUR`) REFERENCES `jour` (`JOUR`),
  ADD CONSTRAINT `fk_prof` FOREIGN KEY (`IDPROF`) REFERENCES `prof` (`IDPROF`),
  ADD CONSTRAINT `fk_tranche` FOREIGN KEY (`TRANCHE`) REFERENCES `heure` (`TRANCHE`),
  ADD CONSTRAINT `seance_ibfk_1` FOREIGN KEY (`NIVEAU`) REFERENCES `niveau` (`NIVEAU`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
