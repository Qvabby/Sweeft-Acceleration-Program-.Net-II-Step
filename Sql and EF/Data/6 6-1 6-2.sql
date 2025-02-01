--დავალება  6
CREATE DATABASE MakingScienceSweeftAccelerationDb

USE MakingScienceSweeftAccelerationDb

--6.1
-- Create Teacher Table
CREATE TABLE TeacherTb (
	TeacherID INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	Gender NVARCHAR(10),
	Subject NVARCHAR(50)
)
-- Create Pupils Table
CREATE TABLE PupilTb (
    PupilID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Gender NVARCHAR(10),
    Class NVARCHAR(20)
);	
-- Many-to-Many Relationship
CREATE TABLE TeacherPupilTb(
	TeacherID INT FOREIGN KEY REFERENCES TeacherTb(TeacherID),
	PupilID INT FOREIGN KEY REFERENCES PupilTb(PupilID),
	PRIMARY KEY (TeacherID, PupilID)
)

-- Insert Teachers
INSERT INTO TeacherTb (FirstName, LastName, Gender, Subject)
VALUES ('Giorgi', 'Kokhreidze', 'Male', 'Python'),
       ('Gulnara', 'Arvicidze', 'Female', 'Python'),
	   ('Mzia', 'Todua', 'Female', 'Mathematics');

-- Insert Pupils
INSERT INTO PupilTb (FirstName, LastName, Gender, Class)
VALUES ('Giorgi', 'Salukvadze', 'Male', '11'),
       ('Jemal', 'Kvaracxkhelia', 'Male', '12');

-- Create relationships
INSERT INTO TeacherPupilTb (TeacherID, PupilID)
VALUES (1, 3),
       (1, 2),
       (2, 1);

-- 6.2
SELECT DISTINCT t.*
FROM TeacherTb t
INNER JOIN TeacherPupilTb tp ON t.TeacherID = tp.TeacherID
INNER JOIN PupilTb p ON tp.PupilID = p.PupilID
WHERE p.FirstName = 'Giorgi';