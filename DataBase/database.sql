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
-- Table structure for table `apprentice`
--

DROP TABLE IF EXISTS `apprentice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apprentice` (
  `Apprentice_Id` int NOT NULL AUTO_INCREMENT,
  `Apprentice_Name` varchar(100) NOT NULL,
  `Apprentice_Phone` varchar(15) NOT NULL,
  `Apprentice_Type` varchar(50) NOT NULL,
  `Session_Count` int NOT NULL,
  `Tok_JWT` varchar(100) NOT NULL,
  `Blockade` varchar(10) NOT NULL,
  PRIMARY KEY (`Apprentice_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apprentice`
--

LOCK TABLES `apprentice` WRITE;
/*!40000 ALTER TABLE `apprentice` DISABLE KEYS */;
INSERT INTO `apprentice` VALUES (1,'Pablo','3001573906','externo',12,'11111',''),(12,'Joao','3123990469','Externo',3,'121212',''),(20,'Pedro','3001573906','Externo',5,'151515','');
/*!40000 ALTER TABLE `apprentice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `area` (
  `Area_Id` int NOT NULL,
  `Area_Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Area_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES (1,'argeol'),(12,'Pecuaria');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attendant`
--

DROP TABLE IF EXISTS `attendant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendant` (
  `Attendant_Id` int NOT NULL,
  `Attendant_Name` varchar(45) NOT NULL,
  `Attendant_Surname` varchar(45) NOT NULL,
  `Attendant_Phone` int NOT NULL,
  `Attendant_Address` varchar(45) NOT NULL,
  `Attendant_Email` varchar(45) NOT NULL,
  `Attendant_Age` int NOT NULL,
  PRIMARY KEY (`Attendant_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendant`
--

LOCK TABLES `attendant` WRITE;
/*!40000 ALTER TABLE `attendant` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `Department_Id` int NOT NULL,
  `DepartmentName` varchar(255) NOT NULL,
  PRIMARY KEY (`Department_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Tolima');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `file`
--

DROP TABLE IF EXISTS `file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `file` (
  `File_Id` int NOT NULL AUTO_INCREMENT,
  `File_Number` int NOT NULL,
  `Apprentice_count` int NOT NULL,
  `Start_Date` datetime NOT NULL,
  `End_Date` datetime NOT NULL,
  PRIMARY KEY (`File_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1213 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES (2,2123222,32,'2024-12-12 00:00:00','2026-09-22 00:00:00'),(1212,2723143,34,'2024-10-04 00:00:00','2025-10-04 00:00:00');
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locality`
--

DROP TABLE IF EXISTS `locality`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locality` (
  `Locality_Id` int NOT NULL,
  `Nom_Locality` varchar(50) NOT NULL,
  `Tip_Locality` varchar(30) NOT NULL,
  `Id_Department` int NOT NULL,
  PRIMARY KEY (`Locality_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locality`
--

LOCK TABLES `locality` WRITE;
/*!40000 ALTER TABLE `locality` DISABLE KEYS */;
INSERT INTO `locality` VALUES (1,'espinal','rural',1);
/*!40000 ALTER TABLE `locality` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permission`
--

DROP TABLE IF EXISTS `permission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permission` (
  `Permission_Id` int NOT NULL AUTO_INCREMENT,
  `Apprentice_Id` int NOT NULL,
  `Departure_Date` datetime NOT NULL,
  `Entry_Date` datetime NOT NULL,
  `Application_Date` datetime NOT NULL,
  PRIMARY KEY (`Permission_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permission`
--

LOCK TABLES `permission` WRITE;
/*!40000 ALTER TABLE `permission` DISABLE KEYS */;
/*!40000 ALTER TABLE `permission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `program`
--

DROP TABLE IF EXISTS `program`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `program` (
  `Program_Id` int NOT NULL,
  `Program_Name` varchar(255) NOT NULL,
  `File_Id` int NOT NULL,
  PRIMARY KEY (`Program_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `program`
--

LOCK TABLES `program` WRITE;
/*!40000 ALTER TABLE `program` DISABLE KEYS */;
INSERT INTO `program` VALUES (1,'ADSO',1),(3,'argeol',2),(4,'tecnologia',2);
/*!40000 ALTER TABLE `program` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `User_Id` int NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `HashedPassword` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Salt` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `SessionCount` int NOT NULL DEFAULT '0',
  `TokJwt` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Blockade` bit(1) NOT NULL DEFAULT b'0',
  `UserType` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Asset` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`User_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'guiopinedaargeol79@gmailcom','$2a$11$LwgfDrNGwgfby729DMn/f.qSm8jrR482kD4eWJgUCdW7tq.PaEW7O','$2a$11$wk34anpVCoBeIAgi692SHe',0,'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyIjoiZ3Vpb3BpbmVkYWFyZ2VvbDc5QGdtYWlsY29tIiwibmJmIjoxNzI5OTc5OTIwLCJleHAiOjE3Mjk5ODM1MjAsImlhdCI6MTcyOTk3OTkyMH0.F3jC-4U8H0MrfL_iIApwGSLS-hhC0fhMZN-py3cbhR4',_binary '\0','admin',_binary ''),(2,'argeol@gmail.com','$2a$11$fF0aPXAKR0.e/W1LIlDYD.N3sCTrHm/PD/jUVI4RxOHS2ZVeiYiMK','$2a$11$SDKKWnW2Q7AcC2UCJpV3pe',2,'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyIjoiYXJnZW9sQGdtYWlsLmNvbSIsIm5iZiI6MTcyOTk3NzU4NSwiZXhwIjoxNzI5OTgxMTg1LCJpYXQiOjE3Mjk5Nzc1ODV9.Bz6tkO5qAPeJzqAlrXpNWsLvCfCxMLuwK23QFRZlS9c',_binary '','admin',_binary ''),(3,'guio@gmail.com','$2a$11$qk4l/U6yjR2vlGSigJZj8O87yh/XgGfWskg5.2tHF7QEp8Zgzvbbi','$2a$11$fH3atSdLdoRmOfaSHbWFT.',1,'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyIjoiZ3Vpb0BnbWFpbC5jb20iLCJuYmYiOjE3Mjk5ODAwMDUsImV4cCI6MTcyOTk4MzYwNSwiaWF0IjoxNzI5OTgwMDA1fQ.skOMocaja4CgCiUK9zmIYpVqVS_iIYNCkloLgCxO7bY',_binary '\0','aprendiz',_binary ''),(4,'user@example.com','$2a$11$fLXKciDMszDZVv63jaQUb.NfiKDHuYLZojsPJS3fCMQK51C/S2yk2','$2a$11$YPejzRmIyBEuOaLxqXpoOu',0,'',_binary '\0','string',_binary ''),(5,'user@example.com','$2a$11$BpexvpVxT7FJBfOVhVUhsuZ3W0F7ARS4nM9x9gPQUuZ2w0ouRnm2C','$2a$11$mO8hbtfKr27HI9tBYgk4V.',0,'',_binary '\0','string',_binary ''),(7,'argeol@gmail.com','$2a$11$Ik9T1svGR3sd1xHEEjpSlO8.YxjS3Jt6HjYXG/lr6yMTLgW86ocIq','$2a$11$loCzeV6dgUULvJ3YPFSmsO',2,'',_binary '','admin',_binary ''),(10,'guio@example.com','$2a$11$G9L1K/f8CCegnkfcVZYKPu4W6ocynG.qwlymCeV2IsOQXhAiD/OzO','$2a$11$uI5bt7WZKohtuIpsswmUbO',0,'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyIjoiZ3Vpb0BleGFtcGxlLmNvbSIsIm5iZiI6MTcyOTk4MTcxMCwiZXhwIjoxNzI5OTg1MzEwLCJpYXQiOjE3Mjk5ODE3MTB9.yzy_rPkpSv2Enbqw2TS0ydKAIYkOHWb_NGmLCDSUKwI',_binary '\0','string',_binary '');
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

-- Dump completed on 2024-10-26 17:34:26
