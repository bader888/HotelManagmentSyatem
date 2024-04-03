use HotelMS
CREATE TABLE people (
    PersonID INT PRIMARY KEY ,
    NationalNo NVARCHAR(20),
    FirstName NVARCHAR(20),
    SecondName NVARCHAR(20),
    ThirdName NVARCHAR(20),
    LastName NVARCHAR(20) NOT NULL,
    DateOfBirth DATETIME,
    Gender TINYINT,
    Address NVARCHAR(500),
    Phone NVARCHAR(20),
    Email NVARCHAR(50),
    NationalityCountryID INT,
    ImagePath NVARCHAR(250),
    FOREIGN KEY (NationalityCountryID) REFERENCES Countries(CountryID)
);



 CREATE TABLE users (
    UserID INT PRIMARY KEY identity(1,1),
    PersonID INT,
    UserName NVARCHAR(20),
    Password NVARCHAR(200),
    IsActive BIT,
    Role tinyint
);

ALTER TABLE users
ADD CONSTRAINT FK_PersonID FOREIGN KEY (PersonID) REFERENCES people(PersonID);

 
 
 

 


