create database MVCCRUD
USE MVCCRUD
CREATE TABLE Hospital(
id INT identity PRIMARY KEY,
Nombre VARCHAR(100) NOT NULL,
Direccion VARCHAR(255),
Dui VARCHAR(10) UNIQUE NOT NULL
);
select * from Hospital


