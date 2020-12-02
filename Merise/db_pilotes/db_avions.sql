DROP DATABASE IF EXISTS db_avions; 

CREATE DATABASE IF NOT EXISTS db_avions DEFAULT CHARACTER SET 'utf8';

USE db_avions;

CREATE TABLE avions 
(
	immat VARCHAR(20) NOT NULL,
	vitessemax INT,
    plafond INT,
    rayonaction INT,
    modele VARCHAR(20) NOT NULL,
    marque VARCHAR(20) NOT NULL,
    PRIMARY KEY (immat)
);


INSERT INTO avions 
(immat, vitessemax, plafond, rayonaction, modele, marque) 
VALUES
 ('L33', 2200, 20000, 1500, 'Mirage 2000', 'Dassault'),
 ('L34', 2200, 20000, 1500, 'Rafale', 'Dassault');


SELECT * FROM avions;