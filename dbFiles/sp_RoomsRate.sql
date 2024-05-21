CREATE TABLE RoomsRate
(
    rateID int PRIMARY KEY IDENTITY(1,1),
    roomID int,
    customerID int,
    description varchar(255),
    score decimal,
    CONSTRAINT FK_Room FOREIGN KEY (roomID) REFERENCES Rooms(room_id),
    CONSTRAINT FK_Customer FOREIGN KEY (customerID) REFERENCES Customers(customerID)
);

 --add new roomRate
CREATE PROCEDURE sp_AddRoomsRate
    @roomID int,
    @customerID int,
    @description varchar(255),
    @score decimal,
    @newRateID int OUTPUT
AS
BEGIN
    -- Check if the room exists
    IF NOT EXISTS (SELECT 1 FROM Rooms WHERE room_id = @roomID)
    BEGIN
        RAISERROR ('RoomID does not exist. AddRoomsRate', 16, 1)
        RETURN
    END

    -- Check if the customer exists
    IF NOT EXISTS (SELECT 1 FROM Customers WHERE customerID = @customerID)
    BEGIN
        RAISERROR ('CustomerID does not exist. AddRoomsRate', 16, 1)
        RETURN
    END

    -- Insert the new RoomsRate record
    INSERT INTO RoomsRate (roomID, customerID, description, score)
    VALUES (@roomID, @customerID, @description, @score)

    -- Get the new rateID
    SET @newRateID = SCOPE_IDENTITY()
END

--update roomRate
CREATE PROCEDURE sp_UpdateRoomsRate
    @rateID int,
    @roomID int,
    @customerID int,
    @description varchar(255),
    @score decimal
AS
BEGIN
    -- Check if the rateID exists
    IF NOT EXISTS (SELECT 1 FROM RoomsRate WHERE rateID = @rateID)
    BEGIN
        RAISERROR ('rateID does not exist. sp_UpdateRoomsRate', 16, 1);
        RETURN;
    END

    -- Check if the room exists
    IF NOT EXISTS (SELECT 1 FROM Rooms WHERE room_id = @roomID)
    BEGIN
        RAISERROR ('RoomID does not exist. sp_UpdateRoomsRate', 16, 1);
        RETURN;
    END

    -- Check if the customer exists
    IF NOT EXISTS (SELECT 1 FROM Customers WHERE customerID = @customerID)
    BEGIN
        RAISERROR ('CustomerID does not exist. sp_UpdateRoomsRate', 16, 1);
        RETURN;
    END

    -- Update the RoomsRate record
    UPDATE RoomsRate
    SET roomID = @roomID,
        customerID = @customerID,
        description = @description,
        score = @score
    WHERE rateID = @rateID;
 
END;


--get all 
CREATE PROCEDURE sp_GetAllRoomsRate
AS
BEGIN  
 
 select * from RoomsRate 

END
	
 
 