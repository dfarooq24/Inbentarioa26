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
-- Table structure for table `ezabatutako_gailua`
--

DROP TABLE IF EXISTS `ezabatutako_gailua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ezabatutako_gailua` (
  `id_ezabatua` int NOT NULL AUTO_INCREMENT,
  `id_gailu_originala` int DEFAULT NULL,
  `marka` varchar(100) DEFAULT NULL,
  `modelo` varchar(100) DEFAULT NULL,
  `erosketa_data` date DEFAULT NULL,
  `egoera` varchar(50) DEFAULT NULL,
  `mota` varchar(50) DEFAULT NULL,
  `id_mintegia` int DEFAULT NULL,
  `ezabatze_data` datetime NOT NULL,
  PRIMARY KEY (`id_ezabatua`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ezabatutako_gailua`
--

LOCK TABLES `ezabatutako_gailua` WRITE;
/*!40000 ALTER TABLE `ezabatutako_gailua` DISABLE KEYS */;
INSERT INTO `ezabatutako_gailua` VALUES (1,5,'Lenovo','ThinkPad','2020-01-10','aktibo','ordenagailua',1,'2026-04-13 07:26:03'),(2,8,'zeopo','aerrewiy','2006-11-03','apurtuta','inprimagailua',1,'2026-04-13 10:53:38'),(3,7,'danipak','zepot','2001-06-28','aktibo','ordenagailua',1,'2026-04-13 10:53:43'),(4,9,'a','s','2026-04-13','aktibo','inprimagailua',2,'2026-04-13 10:54:10'),(5,10,'zepot','thinkfit','2001-09-11','aktibo','inprimagailua',1,'2026-04-13 12:09:36'),(6,6,'klk','proba11','2018-09-12','ez aktibo','imprimagailua',2,'2026-04-14 06:16:55'),(7,11,'aa','aw3','2026-04-14','apurtuta','inprimagailua',2,'2026-04-14 06:17:50'),(8,12,'a','a','2020-02-05','ezabatuta','ordenagailua',1,'2026-04-14 06:58:15'),(9,5,'probaa','proba11','2016-08-11','aktibo','ordenagailua',1,'2026-04-15 07:54:34'),(10,13,'a','a','2026-04-20','apurtuta','inprimagailua',3,'2026-04-20 10:40:17');
/*!40000 ALTER TABLE `ezabatutako_gailua` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-28 11:21:37
