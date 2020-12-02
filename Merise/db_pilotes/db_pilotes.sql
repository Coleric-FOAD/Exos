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

CREATE TABLE avions 
(
	immat VARCHAR(3) NOT NULL,
    marque VARCHAR(50) NOT NULL,
    modele VARCHAR(50) NOT NULL,
	vitessemax INT,
    plafond INT,
    rayonaction INT,
    matricule INT,
    PRIMARY KEY (immat),
    FOREIGN KEY (matricule) REFERENCES pilotes(matricule)
);



INSERT INTO pilotes 
(matricule, grade, nom, datedenaissance) 
VALUES
 (1, 'Lieutenant', 'Toto', NULL),
 (2, 'Commandant', 'Titi', '1970-02-24');


INSERT INTO avions 
(immat, vitessemax, plafond, rayonaction, modele, marque, matricule) 
VALUES
 ('L33', 2200, 20000, 1500, 'Mirage 2000', 'Dassault', NULL),
 ('L34', 2200, 20000, 1500, 'Rafale', 'Dassault', NULL);




UPDATE avions SET matricule=1 WHERE immat='L33';
UPDATE avions SET matricule=2 WHERE immat='L34';

SELECT * FROM pilotes;
SELECT * FROM avions;

SELECT * FROM avions 
LEFT JOIN pilotes ON avions.matricule = pilotes.matricule

/*

*/