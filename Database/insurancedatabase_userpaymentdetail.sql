-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: insurancedatabase
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `userpaymentdetail`
--

DROP TABLE IF EXISTS `userpaymentdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userpaymentdetail` (
  `PAYMENT_ID` int NOT NULL AUTO_INCREMENT,
  `USER_CARDNAME` varchar(255) NOT NULL,
  `USER_CARDNUMBER` bigint NOT NULL,
  `USER_CVV` int NOT NULL,
  `USER_CARDVALIDITY` varchar(5) NOT NULL,
  `USER_ID` int DEFAULT NULL,
  PRIMARY KEY (`PAYMENT_ID`),
  KEY `USER_ID` (`USER_ID`),
  CONSTRAINT `userpaymentdetail_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `usercredentials` (`USER_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userpaymentdetail`
--

LOCK TABLES `userpaymentdetail` WRITE;
/*!40000 ALTER TABLE `userpaymentdetail` DISABLE KEYS */;
INSERT INTO `userpaymentdetail` VALUES (1,'Rajesh Kumar',1234567890123457,123,'12/26',1),(2,'Sunita Gupta',2345678901234567,234,'11/25',2),(3,'Vikram Singh',3456789012345678,345,'10/24',3),(6,'Rajesh Khanna',2756489364735241,320,'04/25',1),(7,'Shivam Patwa',7685936472839465,450,'03/26',1),(8,'Bhavesh Reddy',7564892637465829,900,'05/29',1);
/*!40000 ALTER TABLE `userpaymentdetail` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-28 18:45:28
