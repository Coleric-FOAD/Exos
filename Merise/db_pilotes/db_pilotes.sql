
DROP DATABASE IF EXISTS db_pilotes; 

CREATE DATABASE IF NOT EXISTS db_pilotes DEFAULT CHARACTER SET 'utf8' collate 'utf8_general_ci';

USE db_pilotes;

CREATE TABLE pilotes 
(
	matricule INT,
	grade VARCHAR(20) NOT NULL,
    nom VARCHAR(50) NOT NULL,
    datedenaissance DATE NULL,
    PRIMARY KEY (matricule)
);


INSERT INTO pilotes 
(matricule, grade, nom, datedenaissance) 
VALUES
 (1, 'Lieutenant', 'Toto', NULL),
 (2, 'Commandant', 'Titi', '1970-02-24');


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

SELECT * FROM pilotes;
SELECT * FROM avions;
