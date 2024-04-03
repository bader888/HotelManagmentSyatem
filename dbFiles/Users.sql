
                     --ADD NEW 
CREATE PROCEDURE sp_AddNewUser 
 @PersonID int, 
 @UserName nvarchar(50), 
 @Password nvarchar(200), 
 @IsActive bit, 
 @Role tinyint, 
@NewUserID INT OUTPUT
as
begin  
INSERT INTO Users ( 
PersonID, 
UserName, 
Password, 
IsActive, 
Role 
) VALUES
(
@PersonID, 
@UserName, 
@Password, 
@IsActive, 
@Role 
) ;
SET @newUserID = SCOPE_IDENTITY();      
end

                     --UPDATE 
CREATE PROCEDURE  sp_UpdateUserByID 
 @UserID int,
 @PersonID int,
 @UserName nvarchar(50),
 @Password nvarchar(250),
 @IsActive bit,
 @Role tinyint
 as 
 begin       		
UPDATE Users SET  
PersonID = @PersonID, 
UserName = @UserName, 
Password = @Password, 
IsActive = @IsActive, 
Role = @Role 
WHERE UserID = @UserID
end 
                       
                     --DELETE 
 CREATE PROCEDURE sp_DeleteUserByID 
@UserID int 
AS
BEGIN
DELETE Users  WHERE UserID = @UserID; 
END 
                        
                       
                     --FIND 
create PROCEDURE sp_FindUserByID 
@UserID int 
as 
begin 
  select * from Users where UserID = @UserID ;
end
                        
                       
                     --GET ALL 
CREATE PROCEDURE sp_GetAllUsers 
AS
BEGIN
SELECT UserID as ID,
CONCAT(people.firstname,' ' ,people.SecondName,' ',people.ThirdName,' ' ,people.LastName) as FullName,
UserName,IsActive = case when IsActive = 0 then 'not active'
						 when IsActive = 1 then 'Active' end,
 Role = case when role = 1 then 'Admin'
			 when role = 2 then 'Manager'
			 when role = 3 then 'Reciption'
			 else  'Accounting' end
FROM Users inner join people on people.PersonID = users.PersonID;
END
                       
                     --IS EXISTS 
CREATE PROCEDURE sp_IsUserExist
 @UserID int 
 as
 begin 
 select Found =1 from Users where UserID = @UserID;
 end 
                     