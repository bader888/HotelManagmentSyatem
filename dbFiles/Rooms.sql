
 ALTER TABLE rooms (
    room_id INT IDENTITY(1,1) PRIMARY KEY not null ,
    room_type_id INT REFERENCES RoomTypes(type_id) not null,
    room_status  TINYINT not null,
    room_rate DECIMAL(10, 2),
    room_description VARCHAR(MAX) not null,
    room_size TINYINT not null ,
    is_pet_friendly BIT not null,
    is_smoking_allowed BIT not null,
    number_of_people INT not null,
    room_view TINYINT  ,
    room_number INT UNIQUE not null, -- Assuming room number is unique
	number_of_beds INT not null -- Adding the number of beds in the room
);
 alter table rooms 
 alter column room_status tinyint


CREATE TABLE RoomTypes (
    type_id INT IDENTITY(1,1) PRIMARY KEY not null,
    type_name VARCHAR(50) not null,
    cost_per_night DECIMAL(10, 2) not null
);


CREATE TABLE RoomFacilities (
    id INT IDENTITY(1,1) PRIMARY KEY not null,
    room_id INT REFERENCES rooms(room_id) not null,
    facility_id INT REFERENCES facilities(ID) not null
);

--i created facility and images tablies in the bgn 



