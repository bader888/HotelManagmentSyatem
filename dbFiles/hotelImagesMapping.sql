select * from hotelImages

--add new 
alter PROCEDURE sp_AddNewHotelImageMapping   
    @hotelId int, 
    @imageId int,
    @NewHotelImageID INT OUTPUT
AS
BEGIN                       
    -- Check if the provided hotelId exists
    IF NOT EXISTS (SELECT 1 FROM Hotels WHERE HotelID = @hotelId)
    BEGIN
        -- Raise an error if hotelId does not exist
        RAISERROR('Hotel with the provided ID does not exist.', 16, 1);
        RETURN;
    END

    -- Check if the provided imageId exists
    IF NOT EXISTS (SELECT 1 FROM Images WHERE imgID = @imageId)
    BEGIN
        -- Raise an error if imageId does not exist
        RAISERROR('Image with the provided ID does not exist.', 16, 1);
        RETURN;
    END

    -- Insert the mapping into hotelImages table
    INSERT INTO hotelImages (hotelId, imageId) 
    VALUES (@hotelId, @imageId);

    -- Set the output parameter with the newly inserted ID
    SET @NewHotelImageID = SCOPE_IDENTITY();             
END

 
 
 EXEC sp_rename 'sp_AddNewPayment', 'sp_AddNewHotelImageMapping';


 --get  hotel images by hotelid
CREATE PROCEDURE sp_GetAllhotelImages @hotelID int
AS
BEGIN
SELECT * FROM hotelImages where hotelId = @hotelID;
END

--delete 
CREATE PROCEDURE sp_DeleteHotelImageByID 
@HotelImageID int 
AS
BEGIN
DELETE hotelImages  WHERE ID = @HotelImageID; 
END 
      
	  

--clear hotel images 
CREATE PROCEDURE sp_ClearHotelImagesByHotelID
@hotelID int 
AS
BEGIN
DELETE hotelImages  WHERE hotelId = @hotelID; 
END 


