CREATE DATABASE Information;

USE Information;

CREATE TABLE Roles 
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	NameOfRole NVARCHAR (25)
);

CREATE TABLE Country
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	NameOfCountry NVARCHAR (40)
);

CREATE TABLE Gender 
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	NameOfGender NVARCHAR (25)
);

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Id_role INT NOT NULL,
	Id_country INT NOT NULL,
	Id_gender INT NOT NULL,
	FirstName NVARCHAR (50),
	FOREIGN KEY (Id_role) REFERENCES Roles (Id),
	FOREIGN KEY (Id_country) REFERENCES Country (Id),
	FOREIGN KEY (Id_gender) REFERENCES Gender (Id)
);

INSERT INTO Roles (NameOfRole) VALUES ('Администратор'),
('Менеджер'), ('Клиент');

INSERT INTO Country (NameOfCountry) VALUES ('Россия'),
('Нидерланды'), ('Франция');

INSERT INTO Gender (NameOfGender) VALUES ('Мужской'),
('Женский');

