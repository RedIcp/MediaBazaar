-- MySQL Script generated by MySQL Workbench
-- Fri Sep 24 18:28:00 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema dbi461266
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbi461266
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbi461266` DEFAULT CHARACTER SET utf8 ;
USE `dbi461266` ;

-- -----------------------------------------------------
-- Table `dbi461266`.`ProductType`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`ProductType` (
  `TypeID` INT NOT NULL AUTO_INCREMENT,
  ` ProductType` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`TypeID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Product`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Product` (
  `ProductID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Barcode` VARCHAR(45) NULL,
  `Type` VARCHAR(45) NOT NULL,
  `AmountInStore` INT NOT NULL DEFAULT 0,
  `AmountInDepot` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`ProductID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Schedule`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Schedule` (
  `Department` VARCHAR(45) NOT NULL,
  `Day` VARCHAR(45) NOT NULL,
  `Morning` INT NOT NULL DEFAULT 1,
  `Afternoon` INT NOT NULL DEFAULT 1,
  `Evening` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`Department`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Jobs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Jobs` (
  `JobID` INT NOT NULL AUTO_INCREMENT,
  `JobTitle` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`JobID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Contract`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Contract` (
  `ContractID` INT NOT NULL AUTO_INCREMENT,
  `EmployeeID` INT NOT NULL,
  `JodTitle` VARCHAR(45) NOT NULL,
  `WorkHoursPerWeek` INT NOT NULL,
  `SalaryPerHour` INT NOT NULL,
  `StartDate` DATE NOT NULL,
  `EndDate` DATE NULL,
  `ReasonForTermination` TEXT NULL,
  PRIMARY KEY (`ContractID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Atendance`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Atendance` (
  `AttendaceID` INT NOT NULL AUTO_INCREMENT,
  `EmployeeID` INT NOT NULL,
  `TimesScheduled` INT NOT NULL DEFAULT 0,
  `Present` INT NOT NULL DEFAULT 0,
  `AbsentWithoughtNotice` INT NOT NULL DEFAULT 0,
  `AbsentWithNotice` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`AttendaceID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbi461266`.`Employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbi461266`.`Employee` (
  `EmployeeID` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NOT NULL,
  `LastName` VARCHAR(45) NOT NULL,
  `UserName` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `BSN` INT NOT NULL,
  `Active` TINYINT NOT NULL,
  `Address` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  `PhoneNumber` INT NULL,
  `DateOfBirth` DATE NULL,
  PRIMARY KEY (`EmployeeID`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `dbi461266`.`ProductType`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbi461266`;
INSERT INTO `dbi461266`.`ProductType` ( ` ProductType`) VALUES ( 'KITCHEN AND HOME');
INSERT INTO `dbi461266`.`ProductType` ( ` ProductType`) VALUES ( 'PHOTO VIDEO AND NAVIGATION');
INSERT INTO `dbi461266`.`ProductType` ( ` ProductType`) VALUES ( 'SMARTHOME  APLIANCES');
INSERT INTO `dbi461266`.`ProductType` (` ProductType`) VALUES ( 'GAMING MUSIC AND COMPUTERS');

COMMIT;






-- -----------------------------------------------------
-- Data for table `dbi461266`.`Jobs`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbi461266`;
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'OWNER');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'SALESMANAGER');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'SALESEMPLOYEE');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'DEPOTMANAGER');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'DEPOTEMPLOYEE');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'OFFICEMANAGER');
INSERT INTO `dbi461266`.`Jobs` ( `JobTitle`) VALUES ( 'OFFICEEMPLOYEE');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbi461266`.`Contract`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbi461266`;
INSERT INTO `dbi461266`.`Contract` ( `EmployeeID`, `JodTitle`, `WorkHoursPerWeek`, `SalaryPerHour`, `StartDate`, `EndDate`, `ReasonForTermination`) VALUES ( 1, 'OWNER', 60, 125, '2020-12-12', NULL, NULL);

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbi461266`.`Atendance`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbi461266`;
INSERT INTO `dbi461266`.`Atendance` (`AttendaceID`, `EmployeeID`, `TimesScheduled`, `Present`, `AbsentWithoughtNotice`, `AbsentWithNotice`) VALUES (1, 1, 12, 12, 0, 0);

COMMIT;

-- -----------------------------------------------------
-- Conect table contract and employee
-- -----------------------------------------------------

ALTER TABLE `DBI461266`.`contract` 
ADD INDEX `employeeID_idx` (`employeeID` ASC);
;
ALTER TABLE `DBI461266`.`contract` 
ADD CONSTRAINT `employeeID`
  FOREIGN KEY (`employeeID`)
  REFERENCES `DBI461266`.`employee` (`employeeID`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
