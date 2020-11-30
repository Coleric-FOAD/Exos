
DROP DATABASE IF EXISTS db_pilotes; 

CREATE DATABASE IF NOT EXISTS db_pilotes DEFAULT CHARACTER SET 'utf8';

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


SELECT * FROM pilotes;


