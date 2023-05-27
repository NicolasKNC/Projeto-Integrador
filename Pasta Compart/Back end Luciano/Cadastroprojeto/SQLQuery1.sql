Create database TestToys;
Create table Registration (ID INT IDENTITY(1,1) Primary Key,
Username Varchar(100), Password Varchar(100),
Email Varchar(100), isActive INT);

SELECT * FROM Registration;