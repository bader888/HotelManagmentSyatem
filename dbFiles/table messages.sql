CREATE TABLE Messages
(
	messageID int primary key identity(1,1),
	MsgSubject varchar(50),
	MsgBody varchar(255)
)
 
 CREATE TABLE UserCustomerMessages (
    UserCustomerMessageID INT PRIMARY KEY IDENTITY(1,1),
    MsgID INT,
    UserID INT,
    CustomerID INT,
    FOREIGN KEY (MsgID) REFERENCES Messages(messageID), 
    FOREIGN KEY (UserID) REFERENCES Users(UserID),  
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)  
);


 


