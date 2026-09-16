CREATE DATABASE P416
--DROP DATABASE P416
USE P416

CREATE TABLE Students(
Id int,
[Name] nvarchar(20),
Surname nvarchar(50),
Age int
)

EXEC sp_rename 'dbo.Students','Stu'
EXEC sp_rename 'Stu','Students'

ALTER TABLE Students ADD [Address] nvarchar(20)
ALTER TABLE Students DROP Column [Address]
--DROP TABLE Students

--DML
INSERT INTO Students VALUES(1,'Student1','Surname1',20)
INSERT INTO Students VALUES(2,'Student2','Surname2',20)
INSERT INTO Students VALUES(3,'Student3','Surname3',20)
--INSERT INTO Students VALUES
--(3,'Student4','Surname4',20),
--(4,'Student4','Surname4',20),
--(4,'Student4','Surname4',20)
INSERT INTO Students (Id, Name, Surname, Age)
SELECT 3, 'Student4', 'Surname4', 20
UNION ALL
SELECT 4, 'Student4', 'Surname4', 20
UNION ALL
SELECT 4, 'Student4', 'Surname4', 20;

--DQL
SELECT * FROM Students
SELECT Surname as Soyad, Name [Ad] From Students
SELECT * FROM Students WHERE Id=2 AND Name='Student2'
SELECT * FROM Students WHERE Id=2 OR Name='Student2'
SELECT * FROM Students WHERE Id>2
SELECT * FROM Students WHERE Name='Student2'

DELETE FROM Students WHERE Name LIKE 'L%'
DELETE FROM Students WHERE Name LIKE '%l'
DELETE FROM Students WHERE Name LIKE '%or%'
DELETE FROM Students

UPDATE Students SET Name='Filankes' WHERE Id=1