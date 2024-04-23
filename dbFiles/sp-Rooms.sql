alter PROCEDURE AddNewRoom
    @room_type_id INT,
    @room_status tinyint,
    @room_rate DECIMAL(10, 2),
    @room_description VARCHAR(MAX),
    @room_size tinyint,
    @is_pet_friendly BIT,
    @is_smoking_allowed BIT,
    @number_of_people INT,
    @room_view TINYINT,
    @room_number INT,
    @number_of_beds INT, 
    @NewRoomID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO rooms (room_type_id, room_status, room_rate, room_description, room_size, is_pet_friendly, is_smoking_allowed, number_of_people, room_view, room_number,number_of_beds)
    VALUES ( @room_type_id, @room_status, @room_rate,@room_description, @room_size, @is_pet_friendly, @is_smoking_allowed, @number_of_people, @room_view, @room_number,@number_of_beds);
	
    SET @NewRoomID = SCOPE_IDENTITY();
END; 
----------------------------------------------  
ALTER PROCEDURE UpdateRoom
    @room_id INT,
    @room_type_id INT,
    @room_status TINYINT,
    @room_rate DECIMAL(10, 2),
    @room_description VARCHAR(MAX),
    @room_size TINYINT,
    @is_pet_friendly BIT,
    @is_smoking_allowed BIT,
    @number_of_people INT,
    @room_view TINYINT,
    @room_number INT,
    @number_of_beds INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @room_id)
    BEGIN
        -- If room_id not found, throw an error
        THROW 51000, 'Room ID not found, UpdateRoom', 1;
        RETURN;
    END;

    -- If room_id exists, perform the update
    UPDATE rooms
    SET room_type_id = @room_type_id,
        room_status = @room_status,
        room_rate = @room_rate,
        room_description = @room_description,
        room_size = @room_size,
        is_pet_friendly = @is_pet_friendly,
        is_smoking_allowed = @is_smoking_allowed,
        number_of_people = @number_of_people,
        room_view = @room_view,
        room_number = @room_number,
        number_of_beds = @number_of_beds
    WHERE room_id = @room_id;
END

---------------------------------------------- 
ALTER PROCEDURE GetAllRooms
AS
BEGIN
    SET NOCOUNT ON; 
    SELECT room_id as ID, room_type_id as RoomType, 
	room_status  =CASE 
					WHEN room_status =  1 THEN 'Available' 
					WHEN room_status =  2 THEN 'Occupied'
					WHEN room_status =  3 THEN 'Reserved'
					WHEN room_status =  4 THEN 'Out of Service'
					WHEN room_status =  5 THEN 'Under Maintenance'
					WHEN room_status =  6 THEN 'Clean-up' 
					END  ,   
	room_rate as Rate, 
	room_description as RoomDescription, 
	room_size = CASE WHEN room_size = 1 THEN 'Small' 
					WHEN room_size =  2 THEN 'Medium'
					WHEN room_size =  3 THEN 'Large'
					END
					, is_pet_friendly = case 
					when is_pet_friendly = 1 
					then 'Yes' 
					else 'No' end , 
					is_smoking_allowed = case 
					when is_smoking_allowed = 1
					then 'Yes' 
					else 'No' end, 
					number_of_people,
					room_view = CASE 
					WHEN room_view = 1 THEN 'Balcony' 
					WHEN room_view =  2 THEN 'Garden'
					WHEN room_view =  3 THEN 'Pool'
					WHEN room_view =  4 THEN 'City'
					END, 
					room_number as RoomNumber
    FROM rooms;
END; 
---------------------------------------------- 
ALTER PROCEDURE DeleteRoomByID 
     @roomID int 
     AS
BEGIN
   IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @roomID)
    BEGIN
        -- If room_id not found, throw an error
        THROW 51000, 'Room ID not found, DeleteRoomByID', 1;
        RETURN;
    END;
	delete from RoomFacilities where room_id = @roomID;
	delete from roomimages where roomID =@roomID; 
    DELETE rooms  WHERE room_id = @roomID; 
END 
---------------------------------------------- 
ALTER PROCEDURE IsRoomAvailable  
@roomID int 
	as
begin 
 IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @roomID)
    BEGIN
        -- If room_id not found, throw an error
        THROW 51000, 'Room ID not found, IsRoomAvailable', 1;
        RETURN;
    END;

			Select isAvailable = 1 from rooms
			where room_status = 1 ;
	end
-------------------------------------------------
ALTER PROCEDURE ChangeRoomStatus 
@NewStatus tinyint,
@RoomID int 
as
begin
 IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @roomID)
    BEGIN
        -- If room_id not found, throw an error
        THROW 51000, 'Room ID not found, ChangeRoomStatus', 1;
        RETURN;
    END;

	update rooms
	set room_status = @NewStatus
	where room_id = @RoomID;
end 
------------------------------------------------- 
create PROCEDURE FindRoomByID 
	@RoomID int 
AS
BEGIN

  select * from Rooms where room_id = @RoomID ;

END
                        
 