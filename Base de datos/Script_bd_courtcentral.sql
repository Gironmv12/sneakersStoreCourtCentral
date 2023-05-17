-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema CourtCentral
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema CourtCentral
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `CourtCentral` DEFAULT CHARACTER SET utf8 ;
USE `CourtCentral` ;

-- -----------------------------------------------------
-- Table `CourtCentral`.`PRODUCTOS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`PRODUCTOS` (
  `id_productos` INT NOT NULL AUTO_INCREMENT,
  `Nombre_del_producto` VARCHAR(45) NOT NULL,
  `Talla` INT NULL,
  `Precio_del_producto` DECIMAL(7,2) NOT NULL,
  `Cantidad` INT NULL,
  PRIMARY KEY (`id_productos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`Clientes` (
  `id_Clientes` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `RFC` VARCHAR(13) NOT NULL,
  `CURP` VARCHAR(18) NOT NULL,
  `Telefono` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  `Direccion` VARCHAR(45) NULL,
  `ClienteDescuento` INT NULL,
  PRIMARY KEY (`id_Clientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`Ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`Ventas` (
  `id_Venta` INT NOT NULL AUTO_INCREMENT,
  `Cantidad` INT NULL,
  `Fecha_venta` DATE NULL,
  `Precio_venta` DECIMAL(10,2) NULL,
  `Clientes_id_Clientes` INT NOT NULL,
  PRIMARY KEY (`id_Venta`),
  INDEX `fk_Ventas_Clientes1_idx` (`Clientes_id_Clientes` ASC) VISIBLE,
  CONSTRAINT `fk_Ventas_Clientes1`
    FOREIGN KEY (`Clientes_id_Clientes`)
    REFERENCES `CourtCentral`.`Clientes` (`id_Clientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`DetalleVenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`DetalleVenta` (
  `PrecioProducto` DECIMAL(10,2) NULL,
  `Fecha` DATE NULL,
  `Cantidad` INT NULL,
  `PRODUCTOS_id_productos` INT NOT NULL,
  `Ventas_id_Venta` INT NOT NULL,
  INDEX `fk_DetalleVenta_PRODUCTOS_idx` (`PRODUCTOS_id_productos` ASC) VISIBLE,
  INDEX `fk_DetalleVenta_Ventas1_idx` (`Ventas_id_Venta` ASC) VISIBLE,
  CONSTRAINT `fk_DetalleVenta_PRODUCTOS`
    FOREIGN KEY (`PRODUCTOS_id_productos`)
    REFERENCES `CourtCentral`.`PRODUCTOS` (`id_productos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetalleVenta_Ventas1`
    FOREIGN KEY (`Ventas_id_Venta`)
    REFERENCES `CourtCentral`.`Ventas` (`id_Venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`Usuarios` (
  `id_usuarios` INT NOT NULL AUTO_INCREMENT,
  `Nombre_Usuario` VARCHAR(45) NOT NULL,
  `Password_Usuario` VARCHAR(45) NULL,
  PRIMARY KEY (`id_usuarios`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`Proveedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`Proveedores` (
  `id_Proveedor` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Direccion` VARCHAR(250) NULL,
  `Telefono` VARCHAR(45) NULL,
  `Email` VARCHAR(250) NULL,
  PRIMARY KEY (`id_Proveedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`PedidosProveedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`PedidosProveedores` (
  `id_orden` INT NOT NULL AUTO_INCREMENT,
  `Fecha_Orden` DATE NULL,
  `Proveedores_id_Proveedor` INT NOT NULL,
  PRIMARY KEY (`id_orden`),
  INDEX `fk_PedidosProveedores_Proveedores1_idx` (`Proveedores_id_Proveedor` ASC) VISIBLE,
  CONSTRAINT `fk_PedidosProveedores_Proveedores1`
    FOREIGN KEY (`Proveedores_id_Proveedor`)
    REFERENCES `CourtCentral`.`Proveedores` (`id_Proveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CourtCentral`.`DetalleSuministro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CourtCentral`.`DetalleSuministro` (
  `PRODUCTOS_id_productos` INT NOT NULL,
  `PedidosProveedores_id_orden` INT NOT NULL,
  `Proveedores_id_Proveedor` INT NOT NULL,
  PRIMARY KEY (`PRODUCTOS_id_productos`, `Proveedores_id_Proveedor`),
  INDEX `fk_DetalleSuministro_PedidosProveedores1_idx` (`PedidosProveedores_id_orden` ASC) VISIBLE,
  CONSTRAINT `fk_DetalleSuministro_PRODUCTOS1`
    FOREIGN KEY (`PRODUCTOS_id_productos`)
    REFERENCES `CourtCentral`.`PRODUCTOS` (`id_productos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetalleSuministro_PedidosProveedores1`
    FOREIGN KEY (`PedidosProveedores_id_orden`)
    REFERENCES `CourtCentral`.`PedidosProveedores` (`id_orden`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
