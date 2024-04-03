select * from Images
--add new
CREATE PROCEDURE sp_AddNewImage
@imgUrl varchar(max),
@NewImageID INT OUTPUT
as
begin   
INSERT INTO Images (imgUrl) VALUES (@imgUrl);
SET @newImageID = SCOPE_IDENTITY();     
end


--delete
CREATE PROCEDURE sp_DeleteImageByID 
@ImageID int 
AS
BEGIN
DELETE Images  WHERE imgID = @ImageID; 
END 



                        
