 declare @newid int ;
 exec sp_AddNewHotel 'grand',null,'basra','best hotel ever',1, @newid

 --add new hotel
 alter PROCEDURE
 sp_AddNewHotel  
@name varchar(50), 
@rate decimal, 
@address varchar(255), 
@description varchar(255), 
@BreakfastIncluded bit, 
@NewhotelID INT OUTPUT
as
begin             
INSERT INTO hotels ( 
name, 
rate, 
address, 
description, 
BreakfastIncluded 
) VALUES (
@name, 
@rate, 
@address, 
@description, 
@BreakfastIncluded 
) ;
SET @newhotelID = SCOPE_IDENTITY();end
 
--delete hotel 
ALTER PROCEDURE sp_DeleteHotelByID 
@hotelID int 
AS
BEGIN
 
if  exists(select found =  1 from hotels where hotelID = @hotelID) 
	 DELETE hotels  WHERE hotelID = @hotelID; 
 else
  
RAISERROR('the hotel not found with provided id', 16, 1);
 return ; 
END 
           
EXEC sp_DeleteHotelByID 3 
 
--UPDATE HOTEL 
alter PROCEDURE  sp_UpdatehHotelByID 
 @hotelID int,
 @name varchar (50),
 @rate decimal,
 @address varchar (255),
 @description varchar (max),
 @BreakfastIncluded bit 
 AS
 begin   
  
 UPDATE hotels SET   
name = @name, 
rate = @rate, 
address = @address, 
description = @description, 
BreakfastIncluded = @BreakfastIncluded
WHERE hotelID = @hotelID; 
  
end 

 exec sp_UpdatehHotelByID 2,'basra hotel',80,'iraq','bagad',0

 select * from hotels

--get all hotels 
CREATE PROCEDURE sp_GetAllHotels 
 AS
 BEGIN
	 SELECT * FROM hotels;
 END
  
 --is exists hotel by id 
CREATE PROCEDURE sp_IshotelExist
@hotelID int 
as
begin 
begin try  
if not exists (select found = 1 from hotels where hotelID = @hotelID)
begin 
	raiserror('the hotels not fount in the database,sp_UpdatehHotelByID ',16,1)
	return ;
end 
    select Found = 1 from hotels where hotelID = 2;
end try 
begin catch
declare @ErrorMsg varchar(2000) ;
declare @ErrorSevierty int ;
declare @ErrorState int ;

set @ErrorMsg = ERROR_MESSAGE();
set @ErrorSevierty = ERROR_NUMBER();
set @ErrorState = ERROR_STATE();
raiserror(@ErrorMsg,@ErrorSevierty, @ErrorState);
end catch 
end 
                     
 


--find hotel by id 
ALTER PROCEDURE sp_FindHotelByID 
@HotelID int 
as 
begin 
  if exists (select 1 from Hotels where HotelID = @HotelID)
    select * from Hotels where HotelID = @HotelID;
  else
    begin
      -- Raise an error if no hotel is found
      RAISERROR('No hotel found with the provided HotelID.', 16, 1);
      RETURN; -- Exit the procedure
    end
end;
                        
						select * from hotels