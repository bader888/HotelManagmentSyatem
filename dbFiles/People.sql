
--GET ALL
create PROCEDURE sp_GetAllPeople 
AS
BEGIN
SELECT PersonID as ID, 
NationalNo,
concat(firstName,' ',SecondName,' ',ThirdName,' ',LastName) as FullName,
DateOfBirth,
case when Gender = 1 then 'male' else 'female' end,
Address,
Phone,
Email,
dbo.GetCountryNamebyID(NationalityCountryID) as CountryName
FROM People;
END
 
CREATE FUNCTION GetCountryNamebyID (@CountryID INT)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @CountryName VARCHAR(50)
    SELECT @CountryName = CountryName FROM Countries WHERE CountryID = @CountryID
    RETURN @CountryName
END

 

--DELETE PERSON
CREATE PROCEDURE sp_DeletePersonByID 
@PersonID int 
AS
BEGIN
DELETE People  WHERE PersonID = @PersonID; 
END 

--ADD NEW PERSON
ALTER PROCEDURE sp_AddNewPayment   
@NationalNo nvarchar(50), 
@FirstName nvarchar(50), 
@SecondName nvarchar(50), 
@ThirdName nvarchar(50), 
@LastName nvarchar(50), 
@DateOfBirth datetime, 
@Gender tinyint, 
@Address nvarchar(255), 
@Phone nvarchar(20), 
@Email nvarchar(50), 
@NationalityCountryID int, 
@ImagePath nvarchar(250), 
@NewPersonID INT OUTPUT 
as
begin                                       
INSERT INTO People (
NationalNo, FirstName, SecondName, 
ThirdName, LastName, DateOfBirth, 
Gender, Address, Phone, 
Email, NationalityCountryID, ImagePath )
VALUES
(  
@NationalNo,@FirstName, @SecondName, 
@ThirdName, @LastName, @DateOfBirth, 
@Gender, @Address, @Phone, 
@Email, @NationalityCountryID, @ImagePath 
) ;
SET @newPersonID = SCOPE_IDENTITY();                           
end


--UPDATE PERSON INFO
CREATE PROCEDURE  sp_UpdatePersonByID 
@PersonID int,
@NationalNo nvarchar(50), 
@FirstName nvarchar(50), 
@SecondName nvarchar(50), 
@ThirdName nvarchar(50), 
@LastName nvarchar(50), 
@DateOfBirth datetime, 
@Gender tinyint, 
@Address nvarchar(255), 
@Phone nvarchar(20), 
@Email nvarchar(50), 
@NationalityCountryID int,
@ImagePath nvarchar(250)
as 
begin                  
UPDATE People SET  
NationalNo = @NationalNo, 
FirstName = @FirstName, 
SecondName = @SecondName, 
ThirdName = @ThirdName, 
LastName = @LastName, 
DateOfBirth = @DateOfBirth, 
Gender = @Gender, 
Address = @Address, 
Phone = @Phone, 
Email = @Email, 
NationalityCountryID = @NationalityCountryID, 
ImagePath = @ImagePath
WHERE PersonID = @PersonID
 end 

 
 --FIND PESON BY ID 
 CREATE PROCEDURE sp_FindPersonByID 
@PersonID int 
as 
begin 
  select * from People where PersonID = @PersonID ;
end

--FIND PESON BY NationalNo
 CREATE PROCEDURE sp_FindPersonByNationalNo
@NationalNo varchar(50) 
as 
begin 
  select * from People where @NationalNo = @NationalNo;
end
  

--check is person Exists by id 
CREATE PROCEDURE sp_IsPersonExist
@PersonID int 
as
begin 
select Found =1 from People where PersonID = @PersonID;
end 

--check is person Exists by NationalNO
CREATE PROCEDURE sp_IsPersonExistbyNationalNO
@NationalNo varchar(50)
as
begin 
select Found =1 from people where @NationalNo = @NationalNo;
end 


select * from people

--(((TEST)))---
select  dbo.GetCountryNamebyID(1) as countryname

exec sp_GetAllPeople

EXEC sp_DeletePersonByID(1) 
 
EXEC sp_FindPersonByID 1


DECLARE @DATE DATETIME  = GETDATE();
DECLARE @NEWpERSINid INT ; 
EXEC sp_AddNewPayment 
'N10',
'BADER',
'HAIDER',
'HUSSEN',
'HUSSEN',@DATE,
1,
'BASRA',
'00000'
,'EMAIL'
,1,'
PATH',
@NEWpERSINid  
 
 
DECLARE @DATE DATETIME  = GETDATE();
EXEC sp_UpdatePersonByID 1,'NEW','NEW',',EW','NEW','EW',@DATE,1,'PLA','NEW',
'MEW',1,'PLA'
  
  exec sp_IsPersonExist 2 

