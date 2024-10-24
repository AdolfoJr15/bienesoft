CREATE DATABASE  IF NOT EXISTS `bienesoft` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bienesoft`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: bienesoft
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Dumping data for table `apprentice`
--

LOCK TABLES `apprentice` WRITE;
/*!40000 ALTER TABLE `apprentice` DISABLE KEYS */;
INSERT INTO `apprentice` VALUES (1,'Pablo','3001573906','externo',12,'11111',''),(12,'Joao','3123990469','Externo',3,'121212',''),(20,'Pedro','3001573906','Externo',5,'151515','');
/*!40000 ALTER TABLE `apprentice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES (1,'argeol'),(12,'Pecuaria');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `attendant`
--

LOCK TABLES `attendant` WRITE;
/*!40000 ALTER TABLE `attendant` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Tolima');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES (2,2123222,32,'2024-12-12 00:00:00','2026-09-22 00:00:00'),(1212,2723143,34,'2024-10-04 00:00:00','2025-10-04 00:00:00');
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `locality`
--

LOCK TABLES `locality` WRITE;
/*!40000 ALTER TABLE `locality` DISABLE KEYS */;
INSERT INTO `locality` VALUES (1,'espinal','rural',1);
/*!40000 ALTER TABLE `locality` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `permission`
--

LOCK TABLES `permission` WRITE;
/*!40000 ALTER TABLE `permission` DISABLE KEYS */;
/*!40000 ALTER TABLE `permission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `program`
--

LOCK TABLES `program` WRITE;
/*!40000 ALTER TABLE `program` DISABLE KEYS */;
INSERT INTO `program` VALUES (1,'ADSO',1),(3,'argeol',2);
/*!40000 ALTER TABLE `program` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-23 15:33:33
