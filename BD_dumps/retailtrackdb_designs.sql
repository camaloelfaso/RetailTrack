-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: retailtrackdb
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `designs`
--

DROP TABLE IF EXISTS `designs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `designs` (
  `Id` char(36) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Description` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ImageUrl` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Comision` decimal(65,30) NOT NULL DEFAULT '0.000000000000000000000000000000',
  `Price` decimal(65,30) NOT NULL DEFAULT '0.000000000000000000000000000000',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `designs`
--

LOCK TABLES `designs` WRITE;
/*!40000 ALTER TABLE `designs` DISABLE KEYS */;
INSERT INTO `designs` VALUES ('08dd1fae-3b82-4728-8c1e-63365a8f559d','Venya 1','','',0.000000000000000000000000000000,650.000000000000000000000000000000),('08dd1fae-3b82-47f1-85b5-35b08584d9e5','Venya 2','','',0.000000000000000000000000000000,750.000000000000000000000000000000),('08dd1fae-3b82-4800-84a6-bdf2b9c3826f','Manochuecca 1','','',0.000000000000000000000000000000,350.000000000000000000000000000000),('08dd1fae-3b82-480a-869b-52d1b27137a7','Mano hueca 2','','',100.000000000000000000000000000000,550.000000000000000000000000000000),('08dd1fae-3b82-4813-8d96-7a0a0bce4362','Fido','','',0.000000000000000000000000000000,450.000000000000000000000000000000),('08dd1fae-3b82-481f-8009-3001f613253d','Bazooka','','',0.000000000000000000000000000000,450.000000000000000000000000000000),('08dd1fae-3b82-4828-88b9-c3dfd7e53d33','Fake','','',0.000000000000000000000000000000,550.000000000000000000000000000000),('08dd1fae-3b82-4831-88a3-bea6583a14ab','Navidad','','',0.000000000000000000000000000000,350.000000000000000000000000000000),('08dd1fae-3b82-483a-8536-28b87192c39c','Nutria Vin','','',100.000000000000000000000000000000,650.000000000000000000000000000000),('08dd1fae-3b82-4843-85da-1bf9db5ba05b','Nutria Space','','',100.000000000000000000000000000000,650.000000000000000000000000000000),('08dd1fae-3b82-484c-825b-35231dda178d','Hongos','','',300.000000000000000000000000000000,650.000000000000000000000000000000),('08dd1fae-3b82-4854-8e08-eb26373c0725','Margarita','','',300.000000000000000000000000000000,650.000000000000000000000000000000),('08dd1fae-3b82-4860-840c-696eabcc0ed5','Mojando','','',0.000000000000000000000000000000,450.000000000000000000000000000000),('08dd1fae-3b82-4869-8ad6-606d45f70bb5','Moco','','',0.000000000000000000000000000000,450.000000000000000000000000000000),('08dd1fae-3b82-4872-87d9-062f7256fb4b','Bebe','','',0.000000000000000000000000000000,550.000000000000000000000000000000),('08dd1fae-3b82-487b-8158-9ff18045487d','Logo','','',0.000000000000000000000000000000,350.000000000000000000000000000000),('08dd1fae-3b82-4883-8a74-c654da6ab89f','Perro Flauta','','',0.000000000000000000000000000000,350.000000000000000000000000000000),('08dd1fae-3b82-488c-835e-24f5f1c68eaf','Amics','','',0.000000000000000000000000000000,450.000000000000000000000000000000),('08dd1fae-3b82-4896-8210-11fd84e3cd10','Eco','','',0.000000000000000000000000000000,350.000000000000000000000000000000),('08dd1fae-3b82-48a1-840a-09c3dbb56faa','Golf','','',0.000000000000000000000000000000,850.000000000000000000000000000000),('08dd1fae-3b82-48aa-81b1-9f2c3c6d83e1','Golf bordado','','',0.000000000000000000000000000000,850.000000000000000000000000000000),('08dd29ce-7514-4ad9-8f06-408543a06e15','sdafsd','asdfasdf','img/0f46c1c0-428b-4016-a3fc-5c8ae2e3c49d.jpg',0.000000000000000000000000000000,0.000000000000000000000000000000),('08dd52ad-f87c-4ab0-82f6-f61e7a03455a','monotrabajando','monotrvbaja','img/mono_trabajando.jpg',0.000000000000000000000000000000,0.000000000000000000000000000000);
/*!40000 ALTER TABLE `designs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-24 22:06:52
