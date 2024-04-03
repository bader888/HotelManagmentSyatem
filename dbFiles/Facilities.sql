use hotelms 

select * from Facilities

--get all
 CREATE PROCEDURE sp_GetAllFacilities 
AS
BEGIN
SELECT * FROM Facilities;
END      

 
--add new Facilitie
CREATE PROCEDURE sp_AddNewFacilitie 
@Name varchar(100),
@IconUrl varchar(max) ,
@NewFacilitieID INT OUTPUT
as
begin  
INSERT INTO Facilities (Name,IconUrl) VALUES (@Name, @IconUrl) ;
SET @newFacilitieID = SCOPE_IDENTITY();     
end

 
--delete 
CREATE PROCEDURE sp_DeleteFacilitieByID 
@FacilitieID int 
AS
BEGIN
DELETE Facilities  WHERE ID = @FacilitieID; 
END 


--update 
CREATE PROCEDURE  sp_UpdateFacilitieByID 
 @ID int,
 @Name varchar(100),
 @IconUrl varchar(max)
as 
begin                 		
UPDATE Facilities SET  
Name = @Name, 
IconUrl = @IconUrl
WHERE ID = @ID
end 

exec sp_UpdateFacilitieByID 1111,'chabge the facilitie.','this is the icon path'

