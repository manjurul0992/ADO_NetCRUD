// this syntex some thing misssing bak file best option for run
CREATE DATABASE BCB
Go

USE BCB
GO
CREATE TABLE players
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	run INT NOT NULL
)
GO
SELECT * FROM players
INSERT INTO players(name,run) VALUES('Shakib',52) 

CREATE TABLE MatchFormat
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL
)
GO
SELECT id,name FROM MatchFormat
INSERT INTO MatchFormat(name) VALUES ('TEST')
INSERT INTO MatchFormat(name) VALUES ('ODI')
INSERT INTO MatchFormat(name) VALUES ('T20')
INSERT INTO MatchFormat(name) VALUES ('T10')

CREATE TABLE prize
(
	playerId INT,
	MatchFormatId INT,
	prize MONEY,
	PRIMARY KEY(playerId,MatchFormatId) 
)
GO
CREATE TABLE users
(
	userId INT PRIMARY KEY IDENTITY,
	userName NVARCHAR(50) NOT NULL UNIQUE,
	fullName NVARCHAR(50) NOT NULL,
	email NVARCHAR(30) NOT NULL,
	contactNo NVARCHAR(30) NOT NULL,
	userPassword NVARCHAR(50) NOT NULL
)
GO
SELECT * FROM users where userName='syed' and userPassword='1234'
GO
INSERT INTO users(userName,fullName,email,contactNo,userPassword) VALUES('Syed','Syed Manjurul','syed@gmail.com','01743560992','1234')
GO
CREATE TABLE coachs
(
	coachId INT PRIMARY KEY IDENTITY,
	coachName NVARCHAR(50) NOT NULL,
	coachContact NVARCHAR(20) NOT NULL,
	coachEmail NVARCHAR(30) NOT NULL,
	coachSalary MONEY NOT NULL,
	picture VARBINARY(MAX) NULL,
	MatchFormatId INT REFERENCES MatchFormat(id)
)
GO
SELECT id,name FROM players
GO
SELECT * FRom coachs
GO

SELECT coachName,coachContact,coachEmail,coachSalary,picture,MatchFormatId FROM coachs
Go
INSERT INTO coachs(coachName,coachContact,coachEmail,coachSalary,picture,MatchFormatId) VALUES('Hatura','01743560992','haru@gmail.com','picture','1')
GO
SELECT c.coachId,c.coachName,c.coachContact,c.coachContact,c.picture,m.name FROM coachs c INNER JOIN MatchFormat m ON c.MatchFormatId=m.id