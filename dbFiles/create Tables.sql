create table Facilities
(
ID int not null primary key  IDENTITY(1,1),
Name  varchar(70) not null,
IconUrl  varchar(max) null
);

INSERT INTO facilities (name)
VALUES 
    ('Parking'),
    ('Free WiFi'),
    ('Restaurant'),
    ('Pets allowed'),
    ('Room service'),
    ('24-hour front desk'),
    ('Fitness centre'),
    ('Non-smoking rooms'),
    ('Airport shuttle'),
    ('Family rooms'),
    ('Spa and wellness centre'),
    ('Wheelchair accessible'),
    ('Swimming Pool');
select * from Facilities


create table Hotels
(
hotelID int not null primary key  IDENTITY(1,1), 
name VARCHAR(100) NOT NULL,
rate DECIMAL(5, 2) null,
address VARCHAR(255) not null ,
description VARCHAR(MAX) null,
BreakfastIncluded BIT not null 
);


CREATE TABLE hotelFacilities (
	ID int primary key identity(1,1) not null,
    hotelId INT not null,
    facilityId INT not null, 
    FOREIGN KEY (hotelId) REFERENCES hotels(hotelID),
    FOREIGN KEY (facilityId) REFERENCES facilities(id)
);



create table Images
(
imgID  int primary key identity(1,1) not null,
imgUrl varchar(max) not null 
);

CREATE TABLE hotelImages (
	ID int primary key identity(1,1) not null,
    hotelId INT,
    imageId INT, 
    FOREIGN KEY (hotelId) REFERENCES hotels(hotelID),
    FOREIGN KEY (imageId) REFERENCES images(imgID)
);
