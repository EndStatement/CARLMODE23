-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 25, 2017 at 11:35 AM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ues_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentinfo`
--

CREATE TABLE `tblstudentinfo` (
  `stud_ID` int(11) NOT NULL,
  `lname` text NOT NULL,
  `fname` text NOT NULL,
  `mi` text NOT NULL,
  `bday` text NOT NULL,
  `weight` text NOT NULL,
  `height` text NOT NULL,
  `sex` text NOT NULL,
  `height2` text NOT NULL,
  `age` int(11) NOT NULL,
  `bmi` int(11) NOT NULL,
  `nut_stat` text NOT NULL,
  `height_for_age` text NOT NULL,
  `grade` text NOT NULL,
  `sec` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentinfo`
--

INSERT INTO `tblstudentinfo` (`stud_ID`, `lname`, `fname`, `mi`, `bday`, `weight`, `height`, `sex`, `height2`, `age`, `bmi`, `nut_stat`, `height_for_age`, `grade`, `sec`) VALUES
(1, 'AGDOY', 'SHAEMORE', 'G.', '09-08-05', '35', '1.44', '-Select Gender', '2.0736', 11, 17, 'Normal ', 'Normal', '6', 'CARLOS P. GARCIA'),
(2, 'AGRAVANTE', 'JOHN MICHAEL', '', '05-24-05', '30', '1.38', '-Select Gender-', '1.9044', 12, 16, 'Normal ', 'Normal', '6', 'RAMON MAGSAYSAY'),
(3, 'Allada', 'Aaron Jester', '', '06/13/06', '30', '1.46', 'M', '2.1316', 11, 14, 'Wasted', 'Normal', '6', 'Rodrigo R. Duterte'),
(4, 'Allegado', 'Nathaniel', '', '05/29/04', '40', '1.56', 'M', '2.4336', 13, 16, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(5, 'Ampatin', 'John Lester', '', '02/23/06', '35', '1.43', 'M', '2.0449', 11, 17, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(6, 'Ando', 'Denise Gabriel', 'C.', '07/17/06', '45', '1.42', 'M', '2.0164', 10, 22, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(7, 'Aquino', 'Elijah Miguel', 'L.', '02/09/06', '40', '1.48', 'M', '2.1904', 11, 18, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(8, 'Arboleda', 'Lenn Mark', '', '08/30/05', '33', '1.38', 'M', '1.9044', 11, 17, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(9, 'Articulo', 'Ezekiel Timmy', '', '05/05/06', '24', '1.3', 'M', '1.69', 11, 14, 'Normal ', 'Stunted', '6', 'Rodrigo R. Duterte'),
(10, 'Austria', 'Elijhay', 'D.', '12/13/05', '33', '1.5', 'M', '2.25', 11, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(11, 'Balansag', 'Kerby', 'M.', '07/30/06', '28', '1.37', 'M', '1.8769', 10, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(12, 'Baldevarona', 'Genesis', '', '11/18/05', '28', '1.38', 'M', '1.9044', 11, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(13, 'Ballatan', 'Jan Paolo', 'L.', '08/09/06', '28', '1.4', 'M', '1.96', 10, 14, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(14, 'Banuevo', 'Joshua', 'J.', '06/10/06', '22', '1.25', 'M', '1.5625', 11, 14, 'Wasted', 'Stunted', '6', 'Rodrigo R. Duterte'),
(15, 'Bartolay', 'Mckien', 'D.', '07/18/06', '35', '1.36', 'M', '1.8496', 10, 19, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(16, 'Baysa', 'Eugene', 'D.', '06/20/06', '37', '1.54', 'M', '2.3716', 10, 16, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(17, 'Bentir', 'Marvin Ace', 'P.', '07/19/06', '33', '1.33', 'M', '1.7689', 10, 19, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(18, 'Bianan ', 'Joshua', 'L.', '07/07/06', '24', '1.34', 'M', '1.7956', 10, 13, 'Wasted', 'Normal', '6', 'Rodrigo R. Duterte'),
(19, 'Bactolan', 'Genesi Matthew', '', '09/12/05', '28', '1.36', 'M', '1.8496', 11, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(20, 'Bonado', 'Lester', 'I.', '09/04/05', '46', '1.6', 'M', '2.56', 11, 18, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(21, 'Borquillo', 'Geisler', '', '03/05/06', '43', '1.45', 'M', '2.1025', 11, 20, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(22, 'Boto', 'Andrei Carl', 'P.', '02/15/07', '74', '1.53', 'M', '2.3409', 10, 32, 'Obese', 'Tall', '6', 'Rodrigo R. Duterte'),
(23, 'Bueno', 'Nathaniel', 'N.', '05/02/06', '40', '1.49', 'M', '2.2201', 11, 18, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(24, 'Cabangon', 'Ronald John', '', '07/16/05', '55', '1.45', 'M', '2.1025', 11, 26, 'Overweight', 'Normal', '6', 'Rodrigo R. Duterte'),
(25, 'CHONG', 'KURT JOHN', 'P', '06-01-06', '38', '1.43', 'M', '2.0449', 11, 19, 'Normal ', 'Normal', '6', '6'),
(26, 'ADRIANO JR.', 'CHRISTINE SAM', 'C.', '10-01-06', '30', '1.31', '-Select Gender', '1.7161', 10, 17, 'Normal ', 'Normal', '6', 'MANUEL L. QUEZON'),
(27, 'Agpaoa', 'Vennice Francine', '', '10/26/05', '31', '1.43', 'F', '2.0449', 11, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(28, 'Alcantara', 'Angel Mikaela', '', '01/21/06', '31', '1.47', 'F', '2.1609', 11, 14, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(29, 'Amat', 'Shanen Amber', 'N.', '10/15/05', '40', '1.42', 'F', '2.0164', 11, 20, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(30, 'Anasco', 'Mae Jane', 'G.', '04/05/06', '45', '1.53', 'F', '2.3409', 11, 19, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(31, 'Andujar', 'Anna Marie', '', '11/08/04', '37', '1.49', 'F', '2.2201', 12, 17, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(32, 'Anonuevo', 'Angelica', '', '01/12/06', '40', '1.49', 'F', '2.2201', 11, 18, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(33, 'Apolonio', 'Allysa Nicole', '', '10/08/05', '37', '1.5', 'F', '2.25', 11, 16, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(34, 'Asis', 'Lordelin', 'G.', '08/14/06', '26', '1.36', 'F', '1.8496', 10, 14, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(35, 'Austria', 'Chloe Loucelle', '', '07/23/06', '32', '1.36', 'F', '1.8496', 10, 17, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(36, 'Avila', 'Editha Elrene', 'S.', '10/20/06', '33', '1.49', 'F', '2.2201', 10, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(37, 'Bacunawa', 'Ashley Mae', 'D.', '10/12/05', '25', '1.38', 'F', '1.9044', 11, 13, 'Wasted', 'Normal', '6', 'Rodrigo R. Duterte'),
(38, 'Bagtong', 'Grazel Nathalie', '', '09/28/06', '33', '1.41', 'F', '1.9881', 10, 17, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(39, 'Balmes', 'Drew Shaye', '', '07/03/06', '35', '1.49', 'F', '2.2201', 10, 16, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(40, 'Basa', 'Jasmine Jade Melliza', '', '12/29/04', '36', '1.56', 'F', '2.4336', 12, 15, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(41, 'Begonia', 'Aaliyah Chelsea', '', '06/01/06', '38', '1.35', 'F', '1.8225', 11, 21, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(42, 'Bendol', 'Eliza', '', '04/24/06', '24', '1.35', 'F', '1.8225', 11, 13, 'Wasted', 'Normal', '6', 'Rodrigo R. Duterte'),
(43, 'Benedicto', 'Tricia Anne', '', '11/15/05', '45', '1.43', 'F', '2.0449', 11, 22, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(44, 'Bisnan', 'Racyll', 'D.', '06/25/06', '40', '1.5', 'F', '2.25', 10, 18, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(45, 'CABILES', 'JAMMARA PHYLLIS', 'g', '07-27-06', '40', '1.55', '-Select Gender', '2.4025', 10, 17, 'Normal ', 'Normal', '6', 'RODRIGO R. DUTERTE'),
(46, 'Cabiles', 'Jemima Penelope', '', '07/27/06', '46', '1.58', 'F', '2.4964', 10, 18, 'Normal ', 'Tall', '6', 'Rodrigo R. Duterte'),
(47, 'Cagals', 'Jonalyn', 'D.', '11/01/05', '30', '1.38', 'F', '1.9044', 11, 16, 'Normal ', 'Normal', '6', 'Rodrigo R. Duterte'),
(48, 'RODAJE', 'JAYVEE', 'G', '06-06-06', '-', '-', '-Select Gender', '-', 11, 0, '-', '-', '3', '3'),
(49, 'RODAJE', 'JAYVEEe', 'G', '06-06-06', '-', '-', '-Select Gender-', '-', 11, 0, '-', '-', '3', '3'),
(50, 'BUTLER', 'JIMMY', 'G:', '06-07-01', '-', '-', '-Select Gender', '-', 16, 0, '-', '-', '6', 'MANUEL L. QUEZON'),
(51, 'BUTLER', 'JIMMY', 'G:', '06-07-01', '-', '-', '-Select Gender', '-', 16, 0, '-', '-', '6', 'MANUEL L. QUEZON');

-- --------------------------------------------------------

--
-- Table structure for table `tbltemp`
--

CREATE TABLE `tbltemp` (
  `userName` text NOT NULL,
  `fullName` text NOT NULL,
  `userType` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `user_ID` int(11) NOT NULL,
  `userName` text NOT NULL,
  `userPass` text NOT NULL,
  `userType` text NOT NULL,
  `userFullN` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`user_ID`, `userName`, `userPass`, `userType`, `userFullN`) VALUES
(1, '1', '1', 'Admin', 'ADMIN'),
(2, 'carl', 'karen', 'User', 'Carl Patricio'),
(3, 'jimmy', '12345', 'User', 'Jimmy Boy Tabios'),
(4, 'ichan', '54321', 'User', 'Christian Magno'),
(5, 'mikmik', 'andrellcarlo', 'User', 'Mikaela Ferrer'),
(6, 'jimmyboy', 'tutut', 'User', 'Jimmy Butler');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblstudentinfo`
--
ALTER TABLE `tblstudentinfo`
  ADD PRIMARY KEY (`stud_ID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`user_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblstudentinfo`
--
ALTER TABLE `tblstudentinfo`
  MODIFY `stud_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;
--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `user_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
