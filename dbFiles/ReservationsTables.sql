use hotelms  

CREATE TABLE reservation (
    reservationID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    customer_id INT,
    room_id INT,
    check_in_date DATE,
    check_out_date DATE,
    number_of_nights INT,
    special_request VARCHAR(MAX), -- optional
    arrived_time TIME, -- optional
    reservation_status TINYINT, -- enum (1-pending 2-confirmed 3-cancel 4-completed)
    reservation_date DATETIME DEFAULT GETDATE(), -- automatically created using GETDATE() method
    FOREIGN KEY (customer_id) REFERENCES customers(customerID), -- assuming there's a customer table
    FOREIGN KEY (room_id) REFERENCES Rooms(room_id) -- assuming there's a room table
);

 
