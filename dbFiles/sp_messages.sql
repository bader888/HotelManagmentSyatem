-- add new 
CREATE PROCEDURE sp_AddNewMessage
 @MsgSubject varchar, 
 @MsgBody varchar, 
 @MsgDate datetime, 
 @NewMessageID INT OUTPUT,
 @CustomerID int ,
 @UserID int
 as
 begin         
 INSERT INTO Messages
    ( 
		MsgSubject, 
		MsgBody, 
		MsgDate
	)
	VALUES
	(
		@MsgSubject, 
		@MsgBody, 
		@MsgDate 
	) ;
SET @newMessageID = SCOPE_IDENTITY();   

	insert into UserCustomerMessages
		(UserID, CustomerID, MsgID) 
	values
		(@UserID, @CustomerID,@NewMessageID); 
	
 end 


 alter procedure sp_GetAllMessagesForCustomerByID 
	 @CustomerID int 
 as
 begin
	if not exists ( select found = 1 from Customers where CustomerID = @CustomerID ) 
		begin
			RAISERROR ('the customer not found in the data base ,sp_GetAllMessagesForCustomerByID ', 16, 1);
			return ;
		end 
	 select * from UserCustomerMessages  where CustomerID =  @CustomerID
 end

