/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.24-MariaDB : Database - sale_save
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`sale_save` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `sale_save`;

/*Table structure for table `categoria` */

DROP TABLE IF EXISTS `categoria`;

CREATE TABLE `categoria` (
  `Id_Categoria` int(11) NOT NULL,
  `Tipo_Categoria` varchar(25) NOT NULL,
  PRIMARY KEY (`Id_Categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `categoria` */

insert  into `categoria`(`Id_Categoria`,`Tipo_Categoria`) values 
(1,'Cocinas'),
(2,'Refrigeradores'),
(3,'Climatización'),
(4,'Microondas'),
(5,'Televisores'),
(6,'CuidadoPersonal');

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Direccion` varchar(180) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `Dni` int(11) NOT NULL,
  PRIMARY KEY (`Id_Cliente`),
  UNIQUE KEY `Id_Cliente` (`Id_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4;

/*Data for the table `cliente` */

insert  into `cliente`(`Id_Cliente`,`Nombre`,`Apellido`,`Direccion`,`Telefono`,`Dni`) values 
(46,'eduardo','Bautista','los olivos',999999999,72719),
(47,'claudio','bances','ate',1122333,72719),
(48,'ylem','Edwardson','ate',5566777,73737),
(49,'roberto','pit','newyork',5566777,32444),
(50,'lola','pit','berlin',787899,73737),
(51,'gonzalo','arrilucea','cielo',77777,78787),
(52,'jhon','eduardo','casa',5566777,32444);

/*Table structure for table `marca` */

DROP TABLE IF EXISTS `marca`;

CREATE TABLE `marca` (
  `Id_Marca` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`Id_Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `marca` */

insert  into `marca`(`Id_Marca`,`Nombre`) values 
(1,'Oster'),
(2,'Indurama'),
(3,'Samsung'),
(4,'Hyundai'),
(5,'LG'),
(6,'Chamoy'),
(7,'Papapu'),
(8,'Bosch'),
(9,'Mabe'),
(10,'Sole'),
(11,'Imaco'),
(12,'Miray'),
(13,'Beurer'),
(14,'Rotoplast'),
(15,'Panasonic'),
(16,'Xiaomi'),
(17,'Konzil'),
(18,'MelaScreen'),
(19,'Garnier'),
(20,'Kativa'),
(21,'OldSpice');

/*Table structure for table `productos` */

DROP TABLE IF EXISTS `productos`;

CREATE TABLE `productos` (
  `Id_Producto` int(11) NOT NULL,
  `Id_Categoria` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Descripcion` varchar(100) NOT NULL,
  `Precio` double NOT NULL,
  `Stock` int(11) NOT NULL,
  `Id_marca` int(11) NOT NULL,
  `Foto` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Id_Producto`),
  KEY `Id_Categoria` (`Id_Categoria`),
  KEY `Id_marca` (`Id_marca`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`Id_Categoria`) REFERENCES `categoria` (`Id_Categoria`),
  CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`Id_marca`) REFERENCES `marca` (`Id_Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `productos` */

insert  into `productos`(`Id_Producto`,`Id_Categoria`,`Nombre`,`Descripcion`,`Precio`,`Stock`,`Id_marca`,`Foto`) values 
(1,1,'Cocina a Gas INDURAMA 4 Quemadores FONTANA','Alto: 90 cm, Ancho: 49.5 cm y Profundidad: 57.2',659,10,2,'/img/Cocinas/22.jpg'),
(2,1,'Cocina a Gas BOSCH 4 Quemadores PRO425 Inox','cocina Alto: 94.3 cm, Ancho: 61 cm y Profundidad: 63.5 cmduradera',1219,12,8,'/img/Cocinas/23.jpg'),
(3,1,'Cocina a Gas MABE 4 Quemadores CMP6012AG0 Grafito','Alto: 92.5 cm, Ancho: 6 cm y Profundidad: 56 cm',750.69,12,9,'/img/Cocinas/24.jpg'),
(4,1,'Cocina a Gas SOLE 4 Quemadores SOLCO049 Negro','Alto: 5 cm, Ancho: 60 cm y Garantia: 1 año',865,14,10,'/img/Cocinas/25.jpg'),
(5,1,'Cocina a Gas SAMSUNG 6 Quemadores NX52T5311PS/PE S','Alto: 93.9 cm, Ancho: 76.7 cm y Profundidad: 0',1199,15,3,'/img/Cocinas/26.jpg'),
(6,2,'Refrigeradora OSTER 345L No Frost OS-PNFME21200BD ','Alto: 17 cm, Ancho: 59.5 cm y Profundidad: 68.5 cm',1799,10,1,'/img/Refrigeracion/11.jpg'),
(7,2,'Refrigeradora LG 254L No frost GT29WPPDC Plateado','Alto: 166.7 cm, Ancho: 55.5 cm y Profundidad: 63 cm',1849,11,5,'/img/Refrigeracion/12.jpg'),
(8,2,'Refrigeradora BLACKLINE SBS 401L No Frost SBS 4 Pu','Alto: 18 cm, Ancho: 79.5 cm y Profundidad: 70 cm',2549,12,2,'/img/Refrigeracion/13.jpg'),
(9,2,'Refrigeradora Samsung No Frost 602 L RS60T5200S9/P','Alto: 178 cm, Ancho: 91.2 cm y Capacidad total util: 602L',3799,40,3,'/img/Refrigeracion/14.jpg'),
(10,2,'Refrigeradora MABE 420L No Frost RMP420FLPG1 Grafi','Alto: 184 cm, Ancho: 67 cm y Capacidad total util: 404L',1799,20,9,'/img/Refrigeracion/15.jpg'),
(11,3,'Termo Radiador Imaco OFR - 11AO 11 Celdas','Alto: 66 cm, Ancho: 55.5 cm y Profundidad: 16 cm',379,30,11,'/img/Climatizacion/27.jpg'),
(12,3,'Ventilador Pedestal Miray 16\" VMP-742R','Timer de hasta 7 horas, Giratorio y Potencia: 40 W',169,20,12,'/img/Climatizacion/28.jpg'),
(13,3,'Filtros para Purificador Beurer LR500','Filtro de repuesto para purificador con sistema de filtrado de 3 capas.',549,15,13,'/img/Climatizacion/29.jpg'),
(14,3,'Terma Instantánea ROTOPLAS Prisma','Alto: 21 cm, Ancho: 27.6 cm y Profundidad: 8 cm',349,20,14,'/img/Climatizacion/30.jpg'),
(15,3,'Aire Acondicionado LG 24,000 BTU VM242C9','Tipo de panel: Led, Temporizador y Temperatura ajustable',3499,40,5,'/img/Climatizacion/31.jpg'),
(16,4,'Horno Microondas OSTER 20L POGYME3703M Gris','Alto: 25.9 cm, Ancho: 35.5 cm y Profundidad: 44',329,25,1,'/img/Microondas/17.jpg'),
(17,4,'Horno Microondas SAMSUNG 23L MG23J5133AG/PE','Garantia: 1 año, Capacidad: 23L y Potencia: 950W',499,40,3,'/img/Microondas/18.jpg'),
(18,4,'Horno Microondas BLACKLINE 30L D90N30AP-ZJ Platead','Alto: 30 cm, Ancho: 53.9 cm y Profundidad: 53.9',379,10,2,'/img/Microondas/19.jpg'),
(19,4,'Horno Microondas PANASONIC 25L NN-SB34HMRPK','Garantia: 1 año, Capacidad: 25L y Potencia: 800W',399,12,15,'/img/Microondas/20.jpg'),
(20,4,'Horno Microondas Digital MABE 20L HMM20PEE Blanco','Garantia: 1 año, Capacidad: 20L y Potencia: 700W',279,20,9,'/img/Microondas/21.jpg'),
(21,5,'Televisor HYUNDAI LED 40\'\' FHD Smart Tv HYLED4022A','Tecnología LED, Calidad de imagen FHD',769,11,4,'/img/Televisores/1.jpg'),
(22,5,'Televisor SAMSUNG LED 43\'\' FHD Smart Tv UN43T5202A','Tecnología LED, Calidad de imagen FHD',1099,10,3,'/img/Televisores/2.jpg'),
(23,5,'Televisor HYUNDAI LED 32\'\' HD Smart Tv HYLED3251Ai','Tecnología LED, Calidad de imagen FHD',529,26,4,'/img/Televisores/3.jpg'),
(24,5,'Televisor LG LED UHD 4K ThinQ AI 65UQ8050PSB (2022','Tecnología LED, Calidad de imagen FHD',2799,18,5,'/img/Televisores/4.jpg'),
(25,5,'Televisor XIAOMI LED 50\'\' Smart TV ELA4684LM','Tecnología LED, Calidad de imagen FHD',1399,18,16,'/img/Televisores/5.jpg'),
(26,6,'Crema Ligera Melascreen UV Ducray SPF 50 - Frasco ','Combate foto-envejecimiento. Para pieles normales a mixtas',101.2,40,18,'/img/Cuidado_Personal/32.jpg'),
(27,6,'Aceite de Argán KONZIL Tratamiento Frasco 75ml','Ideal para mantener un cabello sedoso e hidratado',24.2,48,17,'/img/Cuidado_Personal/33.jpg'),
(28,6,'Shampoo KATIVA Keratina + Acondicionador + Crema T','Ideal para el cuidado del cabello, Tratamiento nutritivo',52.9,16,20,'/img/Cuidado_Personal/34.jpg'),
(29,6,'Agua Micelar GARNIER SkinActive Todo en 1 Frasco 4','Diseñado por expertos para no dañar tu piel',30.9,20,19,'/img/Cuidado_Personal/35.jpg'),
(30,6,'Desodorante en Barra para Hombre OLD SPICE Fresh F','Probado por expertos para no dañar tu piel',20.9,11,21,'/img/Cuidado_Personal/36.jpg');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
