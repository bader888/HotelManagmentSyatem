------------------------------------------------------------
alter PROCEDURE AddNewRoomFacility
    @RoomID INT,
    @FacilitiesIDs varchar(max)
AS
BEGIN
	--REMOVE THE OLD IMAGES FROM THE ROOMFACILITIES
	delete RoomFacilities where Room_ID = @RoomID
	 
	DECLARE @TemFacilitiesIDs TABLE
	(
		FacilityID NVARCHAR(50)
	);
	 
    -- Split the comma-separated list of image paths into individual rows
    INSERT INTO @TemFacilitiesIDs (FacilityID)
    SELECT value FROM STRING_SPLIT(@FacilitiesIDs, ',');


	--Insert each image path into the roomimages table along with the room ID
    INSERT INTO RoomFacilities (Facility_ID, Room_ID)
    SELECT FacilityID, @RoomID FROM @TemFacilitiesIDs;
  
END; 
 
------------------------------------------------------------ 
 CREATE PROCEDURE UpdateRoomFacilityByID
    @ID INT,
    @RoomID INT,
    @FacilityID INT
AS
BEGIN
   
    UPDATE RoomFacilities
    SET room_id = @RoomID,
    facility_id = @FacilityID
    WHERE id = @ID;
END;
------------------------------------------------------------ 
 CREATE PROCEDURE DeleteRoomFacilityByID 
@RoomFacilityID int 
AS
BEGIN

	DELETE RoomFacilities  WHERE id = @RoomFacilityID; 

END ;
------------------------------------------------------------  
 alter PROCEDURE GetRoomFacilitiesByRoomID
    @RoomID INT
AS
BEGIN
    SET NOCOUNT ON;
select * from 
(
	SELECT RoomFacilities.id, rooms.room_id, Facilities.Name, Facilities.IconUrl,facility_id
	FROM rooms 
	INNER JOIN  RoomFacilities ON rooms.room_id = RoomFacilities.room_id 
	INNER JOIN  Facilities ON RoomFacilities.facility_id = Facilities.ID
)r1
where room_id = @RoomID ; 
END;
------------------------------------------------------------   
CREATE PROCEDURE IsRoomFacilityExistForRoomID
@FacilityID int,
@RoomID int 
as
begin 
	select Found = 1 from RoomFacilities 
	where facility_id = @FacilityID and room_id = @RoomID;
end 
  
 