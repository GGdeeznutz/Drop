-- phpMyAdmin SQL Dump
-- version 3.2.0.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Sep 25, 2019 at 06:08 AM
-- Server version: 5.1.36
-- PHP Version: 5.3.0

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_garden_fresh_ar_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE IF NOT EXISTS `tbl_account` (
  `account_reg_no` varchar(20) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(30) NOT NULL,
  `level` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`account_reg_no`, `username`, `password`, `level`) VALUES
('123123', 'admin', '12345', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_billing`
--

CREATE TABLE IF NOT EXISTS `tbl_billing` (
  `billing_no` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL,
  `date_issued` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_billing`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_cash_sale`
--

CREATE TABLE IF NOT EXISTS `tbl_cash_sale` (
  `cash_payment_no` varchar(20) NOT NULL,
  `payment_no` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_cash_sale`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_classification`
--

CREATE TABLE IF NOT EXISTS `tbl_classification` (
  `classification_code` varchar(20) NOT NULL,
  `description` varchar(40) NOT NULL,
  PRIMARY KEY (`classification_code`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_classification`
--

INSERT INTO `tbl_classification` (`classification_code`, `description`) VALUES
('2409-2019-124335', 'boy navas'),
('1609-2019-084030', 'rewrw'),
('1109-2019-115310', 'gallon');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_credit`
--

CREATE TABLE IF NOT EXISTS `tbl_credit` (
  `credit_no` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL,
  `id_no` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_credit`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_credit_sales`
--

CREATE TABLE IF NOT EXISTS `tbl_credit_sales` (
  `credit_sales_no` varchar(29) NOT NULL,
  `payment_no` varchar(20) NOT NULL,
  `credit_no` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_credit_sales`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE IF NOT EXISTS `tbl_customer` (
  `id_no` varchar(20) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `address` varchar(50) NOT NULL,
  `contact_no` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`id_no`, `fname`, `lname`, `address`, `contact_no`) VALUES
('2323', 'qwe', 'qwe', 'qwe', '2323'),
('2309-2019-075316', 'vaguchay', 'vagucha', 'qwe', '3333');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment`
--

CREATE TABLE IF NOT EXISTS `tbl_payment` (
  `payment_no` varchar(20) NOT NULL,
  `payment_details` varchar(100) NOT NULL,
  `date` varchar(15) NOT NULL,
  `billing_no` varchar(20) NOT NULL,
  `sales_type_code` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_payment`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_entry`
--

CREATE TABLE IF NOT EXISTS `tbl_product_entry` (
  `product_entry_code` varchar(20) NOT NULL,
  `product_code` varchar(20) NOT NULL,
  `date` varchar(20) NOT NULL,
  `quantity` int(10) NOT NULL,
  `classification_code` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product_entry`
--

INSERT INTO `tbl_product_entry` (`product_entry_code`, `product_code`, `date`, `quantity`, `classification_code`) VALUES
('1809-2019-085337', '1109-2019-112239', '2019/09/18', 0, '1609-2019-084030'),
('1609-2019-170018', '1109-2019-105542', '2019/09/16', 0, '1109-2019-115310'),
('1609-2019-082824', '1109-2019-105451', '2019/09/16', 0, '1109-2019-115310'),
('1609-2019-082812', '1109-2019-112239', '2019/09/16', -11, '1109-2019-115310'),
('2509-2019-092731', '1109-2019-105451', '2019/09/25', 6, '2409-2019-124335');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_reg`
--

CREATE TABLE IF NOT EXISTS `tbl_product_reg` (
  `product_code` varchar(20) NOT NULL,
  `product_name` varchar(50) NOT NULL,
  `price` int(20) NOT NULL,
  PRIMARY KEY (`product_code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product_reg`
--

INSERT INTO `tbl_product_reg` (`product_code`, `product_name`, `price`) VALUES
('1109-2019-112239', 'w', 22),
('1109-2019-105451', 'water3', 2222),
('1109-2019-105542', 'q', 2),
('1609-2019-083939', 'water 2', 2324);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales`
--

CREATE TABLE IF NOT EXISTS `tbl_sales` (
  `inv_no` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `total_amount` float(7,2) DEFAULT NULL,
  `sales_type` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sales`
--

INSERT INTO `tbl_sales` (`inv_no`, `date`, `total_amount`, `sales_type`) VALUES
('2409-2019-121945-AAA', '0000-00-00', 55.00, 'cash'),
('2409-2019-122323-AAA', '2019-09-24', 0.00, 'cash'),
('2409-2019-124416-AAA', '2019-09-24', 0.00, 'cash'),
('2409-2019-130303-AAA', '2019-09-24', 46.00, 'cash');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales_entry`
--

CREATE TABLE IF NOT EXISTS `tbl_sales_entry` (
  `sales_entry_code` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL,
  `product_entry_code` varchar(20) NOT NULL,
  `quantity` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sales_entry`
--

INSERT INTO `tbl_sales_entry` (`sales_entry_code`, `inv_no`, `product_entry_code`, `quantity`) VALUES
('2309-2019-133734', '2309-2019-133734-AAA', '1609-2019-082812', 5),
('2309-2019-133734', '2309-2019-133734-AAA', '1609-2019-082824', 2),
('2309-2019-135424', '2309-2019-135424-AAA', '1609-2019-082824', 6),
('2309-2019-135622', '2309-2019-135621-AAA', '1609-2019-082812', 8),
('2309-2019-135716', '2309-2019-135715-AAA', '1809-2019-085337', 12),
('2309-2019-135900', '2309-2019-135900-AAA', '1609-2019-082812', 2),
('2309-2019-163812', '2309-2019-163811-AAA', '1609-2019-082824', 1),
('2409-2019-115638', '2409-2019-115638-EEE', '1809-2019-085337', 5),
('2409-2019-121651', '2409-2019-121651-AAA', '1809-2019-085337', 5),
('2409-2019-121856', '2409-2019-121855-AAA', '1809-2019-085337', 5),
('2409-2019-121856', '2409-2019-121855-AAA', '1609-2019-082812', 6),
('2409-2019-121946', '2409-2019-121945-AAA', '1609-2019-170018', 5),
('2409-2019-122323', '2409-2019-122323-AAA', '1609-2019-170018', 5),
('2409-2019-124416', '2409-2019-124416-AAA', '1809-2019-085337', 10),
('2409-2019-130303', '2409-2019-130303-AAA', '1609-2019-082812', 2),
('2409-2019-130303', '2409-2019-130303-AAA', '1609-2019-170018', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_temp`
--

CREATE TABLE IF NOT EXISTS `tbl_temp` (
  `sales_entry_code` varchar(20) NOT NULL,
  `inv_no` varchar(20) NOT NULL,
  `product_entry_code` varchar(20) NOT NULL,
  `quantity` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_temp`
--

INSERT INTO `tbl_temp` (`sales_entry_code`, `inv_no`, `product_entry_code`, `quantity`) VALUES
('2509-2019-140115', '2509-2019-140114-AAA', '2509-2019-092731', 30);
