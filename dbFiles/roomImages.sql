use hotelms 

 CREATE TABLE roomimages (
    id INT PRIMARY KEY IDENTITY(1,1) not null,
    imagePath NVARCHAR(MAX) NOT NULL,
    roomID INT NOT NULL,
    FOREIGN KEY (roomID) REFERENCES rooms(room_id)
);

 -----------------------------------------
alter PROCEDURE AddRoomImages
    @RoomID INT,
    @ImagePaths NVARCHAR(MAX)
AS
BEGIN

    DECLARE @TempImagePaths TABLE
	(
		ImagePath NVARCHAR(MAX)
	);

    -- Split the comma-separated list of image paths into individual rows
    INSERT INTO @TempImagePaths (ImagePath)
    SELECT value FROM STRING_SPLIT(@ImagePaths, ',');

    -- Insert each image path into the roomimages table along with the room ID
    INSERT INTO roomimages (imagePath, roomID)
    SELECT ImagePath, @RoomID FROM @TempImagePaths;
END;

 ----------------------------------------- 
CREATE PROCEDURE DeleteRoomImageByID
    @ImageID INT
AS
BEGIN 
    -- Delete the room image by its ID
    DELETE FROM roomimages WHERE id = @ImageID;
END;
---------------------------------------------
CREATE PROCEDURE ClearImageRoom
	@RoomID int
as
begin
	delete from roomimages where roomID = @RoomID ;
end

---------------------------------------------
CREATE PROCEDURE GetRoomImagesByRoomID
    @RoomID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT imagePath
    FROM roomimages
    WHERE roomID = @RoomID;
END;
