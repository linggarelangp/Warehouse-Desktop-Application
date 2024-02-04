-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table warehouseapp.products
CREATE TABLE IF NOT EXISTS `products` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `productId` varchar(6) NOT NULL,
  `productName` varchar(30) NOT NULL,
  `productStock` bigint NOT NULL,
  `productUnit` varchar(10) NOT NULL,
  `productPrice` bigint NOT NULL,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `productId` (`productId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouseapp.products: ~8 rows (approximately)
REPLACE INTO `products` (`id`, `productId`, `productName`, `productStock`, `productUnit`, `productPrice`, `createdAt`, `updatedAt`) VALUES
	(1, 'PRO001', 'Kopi ABC Susu', 900, 'pcs', 3000, '2023-12-27 08:55:56', '2024-02-01 18:22:26'),
	(2, 'PRO002', 'Kopi Kapal Api', 1000, 'pcs', 3000, '2023-12-27 08:56:52', '2024-02-01 18:22:36'),
	(3, 'PRO003', 'Kopi Gajah', 3000, 'pcs', 3000, '2023-12-27 10:10:41', '2024-02-01 18:22:51'),
	(4, 'PRO004', 'Kopi ABC Moka', 2990, 'pcs', 3000, '2023-12-27 19:12:36', '2024-02-01 18:23:00'),
	(5, 'PRO005', 'Beras', 95, 'kg', 9000, '2023-12-27 19:50:14', '2024-02-01 18:23:10'),
	(6, 'PRO007', 'Tepung Terigu', 195, 'kg', 15000, '2023-12-27 19:52:15', '2024-02-01 18:23:18'),
	(7, 'PRO008', 'Kopi Gula Aren', 1000, 'pcs', 30000, '2023-12-27 19:54:57', '2024-02-01 18:23:26'),
	(12, 'PRO009', 'Roti Jala Mak Limah', 100, 'pcs', 6000, '2024-02-04 19:25:19', '2024-02-04 19:25:27');

-- Dumping structure for table warehouseapp.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `roleId` bigint NOT NULL,
  `rolename` varchar(20) NOT NULL,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `roleId` (`roleId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouseapp.roles: ~0 rows (approximately)
REPLACE INTO `roles` (`id`, `roleId`, `rolename`, `createdAt`, `updatedAt`) VALUES
	(1, 1, 'admin', '2023-12-14 17:49:24', '2023-12-14 18:05:19'),
	(2, 2, 'member', '2023-12-16 04:00:53', '2023-12-16 04:01:35');

-- Dumping structure for table warehouseapp.sequelizemeta
CREATE TABLE IF NOT EXISTS `sequelizemeta` (
  `name` varchar(255) COLLATE utf8mb3_unicode_ci NOT NULL,
  PRIMARY KEY (`name`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

-- Dumping data for table warehouseapp.sequelizemeta: ~4 rows (approximately)
REPLACE INTO `sequelizemeta` (`name`) VALUES
	('20231214073512-create-roles.js'),
	('20231214075820-create-users.js'),
	('20231221050213-create-products.js'),
	('20231229173705-create-transaction.js');

-- Dumping structure for table warehouseapp.transactions
CREATE TABLE IF NOT EXISTS `transactions` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `userId` char(36) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `username` text NOT NULL,
  `productId` varchar(6) NOT NULL,
  `productName` varchar(30) NOT NULL,
  `price` bigint NOT NULL,
  `amount` bigint NOT NULL,
  `unit` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `totalPrice` bigint NOT NULL,
  `status` varchar(10) NOT NULL,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouseapp.transactions: ~4 rows (approximately)
REPLACE INTO `transactions` (`id`, `userId`, `username`, `productId`, `productName`, `price`, `amount`, `unit`, `totalPrice`, `status`, `createdAt`, `updatedAt`) VALUES
	(1, '6dd42f1d-e151-44ea-b54f-b3d9a5ba9efc', 'Gillas Tanaraw', 'PRD001', 'Kopi ABC Susu', 3000, 100, 'pcs', 300000, 'Success', '2024-01-01 13:40:12', '2024-01-01 13:40:12'),
	(2, '6dd42f1d-e151-44ea-b54f-b3d9a5ba9efc', 'Gillas Tanaraw', 'PRD005', 'Beras', 9000, 5, 'kg', 45000, 'Success', '2024-01-01 15:56:43', '2024-01-01 15:56:43'),
	(3, 'ed87b3cd-2ac7-4070-a5cb-c85c2f95ff9e', 'Ryo Agata', 'PRD004', 'Kopi ABC Moka', 3000, 10, 'pcs', 30000, 'Success', '2024-01-01 17:58:26', '2024-01-01 17:58:26'),
	(4, 'ed87b3cd-2ac7-4070-a5cb-c85c2f95ff9e', 'Ryo Agata', 'PRD007', 'Tepung Terigu', 15000, 5, 'kg', 75000, 'Success', '2024-01-01 18:04:46', '2024-01-01 18:04:46');

-- Dumping structure for table warehouseapp.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `userId` char(36) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `roleId` bigint NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `fullname` text NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` text NOT NULL,
  `active` tinyint(1) NOT NULL,
  `refreshToken` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `userId` (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouseapp.users: ~4 rows (approximately)
REPLACE INTO `users` (`id`, `userId`, `roleId`, `firstname`, `lastname`, `fullname`, `username`, `password`, `active`, `refreshToken`, `createdAt`, `updatedAt`) VALUES
	(1, '860c7c51-8d12-4d8a-b935-8b91d746ee72', 1, 'Linggar', 'Elang', 'Linggar Elang', 'admin', '$2b$10$ehTuhnUE7Ycg75ndk0p7luHb0tB30vLtlxmDO4jYkFzYdjuDlLIbC', 1, 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MSwidXNlcklkIjoiODYwYzdjNTEtOGQxMi00ZDhhLWI5MzUtOGI5MWQ3NDZlZTcyIiwiZmlyc3RuYW1lIjoiTGluZ2dhciIsImxhc3RuYW1lIjoiRWxhbmciLCJmdWxsbmFtZSI6IkxpbmdnYXIgRWxhbmciLCJhY3RpdmUiOnRydWUsImlhdCI6MTcwNjgxMTkwOSwiZXhwIjoxNzA2ODU1MTA5fQ.X96l_mYDz_E-552Ywqo_8iOOQNckc2u2lMDtpfn1UL0', '2023-12-15 13:40:20', '2024-02-01 18:25:09'),
	(2, 'a9973cf2-c2d4-466e-ad9d-f51e0717ef49', 1, 'Linggar', 'Elang Pratama', 'Linggar Elang Pratama', 'admin2', '$2b$10$Au7C1.4PksfGGhQlQQPu7uKkvxaE2TiwNbX6NyI6CgvrNzkyoqZU2', 1, 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MiwidXNlcklkIjoiYTk5NzNjZjItYzJkNC00NjZlLWFkOWQtZjUxZTA3MTdlZjQ5IiwiZmlyc3RuYW1lIjoiTGluZ2dhciIsImxhc3RuYW1lIjoiRWxhbmcgUHJhdGFtYSIsImZ1bGxuYW1lIjoiTGluZ2dhciBFbGFuZyBQcmF0YW1hIiwiYWN0aXZlIjp0cnVlLCJpYXQiOjE3MDcwNzQ1NzIsImV4cCI6MTcwNzExNzc3Mn0.USkR-E2utkS3hBw6bqSk3UwlAdtb0CMnEimr7AYCMXw', '2023-12-21 19:11:41', '2024-02-04 19:22:52'),
	(3, '6dd42f1d-e151-44ea-b54f-b3d9a5ba9efc', 2, 'Gillas', 'Tanaraw', 'Gillas Tanaraw', 'user', '$2b$10$c5kl9lW99.KBUuMkEk3Cv.8pBp5Y7yMsMAS8D4cUJUqn059XFPTn6', 1, 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MywidXNlcklkIjoiNmRkNDJmMWQtZTE1MS00NGVhLWI1NGYtYjNkOWE1YmE5ZWZjIiwiZmlyc3RuYW1lIjoiR2lsbGFzIiwibGFzdG5hbWUiOiJUYW5hcmF3IiwiZnVsbG5hbWUiOiJHaWxsYXMgVGFuYXJhdyIsImFjdGl2ZSI6dHJ1ZSwiaWF0IjoxNzA3MDc0OTc0LCJleHAiOjE3MDcxMTgxNzR9.pnLcwLmx8h9WJtTPeMi1GX4RTuF2z-i32tZfjZUGtkg', '2023-12-31 15:12:39', '2024-02-04 19:29:34'),
	(4, 'ed87b3cd-2ac7-4070-a5cb-c85c2f95ff9e', 2, 'Ryo', 'Agata', 'Ryo Agata', 'ryo', '$2b$10$9HrAExIbgI8zcUj95m9YIOCZ5hHIjjcuw6uvKgSd9x7twJscA3eGi', 1, 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6NCwidXNlcklkIjoiZWQ4N2IzY2QtMmFjNy00MDcwLWE1Y2ItYzg1YzJmOTVmZjllIiwiZmlyc3RuYW1lIjoiUnlvIiwibGFzdG5hbWUiOiJBZ2F0YSIsImZ1bGxuYW1lIjoiUnlvIEFnYXRhIiwiYWN0aXZlIjp0cnVlLCJpYXQiOjE3MDY4MTE5OTksImV4cCI6MTcwNjg1NTE5OX0.lVXWkOSv0iB0TxkJg5XWQFo_S-aSYqwtE0K7ISAeYXw', '2024-01-01 17:57:29', '2024-02-01 18:26:39');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
