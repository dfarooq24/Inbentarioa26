-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: inbentarioa26
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `gailua`
--

DROP TABLE IF EXISTS `gailua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gailua` (
  `id_gailu` int NOT NULL AUTO_INCREMENT,
  `marka` varchar(100) NOT NULL,
  `modelo` varchar(100) DEFAULT NULL,
  `erosketa_data` date DEFAULT NULL,
  `egoera` varchar(50) DEFAULT NULL,
  `mota` varchar(50) NOT NULL,
  `id_mintegia` int DEFAULT NULL,
  PRIMARY KEY (`id_gailu`),
  KEY `id_mintegia` (`id_mintegia`),
  CONSTRAINT `gailua_ibfk_1` FOREIGN KEY (`id_mintegia`) REFERENCES `mintegia` (`id_mintegia`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gailua`
--

LOCK TABLES `gailua` WRITE;
/*!40000 ALTER TABLE `gailua` DISABLE KEYS */;
INSERT INTO `gailua` VALUES (1,'HP','EliteBook','2022-05-10','aktibo','ordenagailua',1),(2,'Dell','OptiPlex','2021-03-15','aktibo','ordenagailua',1),(3,'Epson','XP-3100','2020-11-20','konpontzen','ordenagailua',2),(4,'Canon','MG2550','2019-07-01','apurtuta','inprimagailua',3);
/*!40000 ALTER TABLE `gailua` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-28 11:21:36
