select * from hotelFacilities 

--add new
ALTER PROCEDURE sp_AddNewHotelFacilitieMapping 
    @hotelId int, 
    @facilityId int, 
    @NewHotelFacilitiesID INT OUTPUT
AS
BEGIN
    -- Check if the provided hotelId exists
    IF NOT EXISTS (SELECT 1 FROM Hotels WHERE HotelID = @hotelId)
    BEGIN
        -- Raise an error if hotelId does not exist
        RAISERROR('Hotel with the provided ID does not exist.', 16, 1);
        RETURN;
    END

    -- Check if the provided facilityId exists
    IF NOT EXISTS (SELECT 1 FROM Facilities WHERE ID = @facilityId)
    BEGIN
        -- Raise an error if facilityId does not exist
        RAISERROR('Facility with the provided ID does not exist.', 16, 1);
        RETURN;
    END

    -- Insert the mapping into hotelFacilities table
    INSERT INTO hotelFacilities (hotelId, facilityId) 
    VALUES (@hotelId, @facilityId);

    -- Set the output parameter with the newly inserted ID
    SET @NewHotelFacilitiesID = SCOPE_IDENTITY();     
END

EXEC sp_rename 'sp_AddNewPayment', 'sp_AddNewHotelFacilitieMapping';


--delete
CREATE PROCEDURE sp_DeleteHotelFacilitiesByID 
@HotelFacilitiesID int  
AS
BEGIN
DELETE hotelFacilities  WHERE ID = @HotelFacilitiesID; 
END 
                 
				 
				 select * from Hotels	
				 
				 select * from Facilities

				 select * from hotelFacilities