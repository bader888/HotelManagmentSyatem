use HotelMS 

CREATE TABLE Customers
(
    CustomerID int PRIMARY KEY IDENTITY(1,1),
    PersonID int FOREIGN KEY REFERENCES People(PersonID),
    Email varchar(50), -- Specify the maximum length for varchar columns
    Password varchar(100) -- Specify the maximum length for varchar columns
);

 
select * from Customers
 -- add new 
 alter PROCEDURE sp_AddNewCustomer
@PersonID int, 
@Email varchar(100), 
@Password varchar(255), 
@NewCustomerID INT OUTPUT
                        as
                        begin  
                        begin try
                        --change this line
                        if not exists(select found = 1 from People where PersonID = @PersonID)
                        	BEGIN
                        	RAISERROR('THE Person ID NOT FOUNF IN THE DATABASE, sp_AddNewCustomer',2,1)
                        	END; 
                         
                        
 INSERT INTO Customers ( 
PersonID, 
Email, 
Password 
) VALUES (  
@PersonID, 
@Email, 
@Password 
) ;
 SET @newCustomerID = SCOPE_IDENTITY();   
end try
begin catch
 DECLARE @ErrorMessage NVARCHAR(4000);
		set @newCustomerID = -1 ;  
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();
		
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
end catch  
end



CREATE PROCEDURE sp_IsCustomerExist
                     @CustomerID int 
                     as
                     begin 
                     select Found =1 from Customers where CustomerID = @CustomerID;
                     end 
                     



					 CREATE PROCEDURE sp_IsCustomerExistbyEmail
                     @Email varchar(50) 
                     as
                     begin 
                     select Found =1 from Customers where Email = @Email;
                     end 
                     


CREATE PROCEDURE  sp_UpdateCustomerByID 
 @CustomerID int,
 @PersonID int,
 @Email varchar(100),
 @Password varchar(255) 
                 as 
                 begin  
                 	begin try 
                    
                       --change this line
                 	  if not exists (select 1 from People where PersonID = @PersonID)
                 		begin 
                 			raiserror('the Person not found in the database, sp_UpdateCustomerByID',1,1)
                 			return ;
                 		end
                 		
 UPDATE Customers SET  
PersonID = @PersonID, 
Email = @Email, 
Password = @Password
WHERE CustomerID = @CustomerID
                 	
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



create PROCEDURE  sp_CustomerLogin
    @Email VARCHAR(50),
    @Password VARCHAR(200)
AS
BEGIN
    DECLARE @UserID INT

    -- Check if username and password match
    SELECT found = 1    FROM Customers
    WHERE Email = @Email AND Password = @Password
	 
END

select * from Customers