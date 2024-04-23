use hotelms  
 
--find reservation
Create PROCEDURE sp_FindReservationsByID 
@ReservationsID int 
as 
begin 
  select * from reservations where reservationID = @ReservationsID ;
end
 
--add reservation 			
 alter PROCEDURE sp_AddNewReservation 
    @customer_id INT,
    @room_id INT,
    @check_in_date DATE,
    @check_out_date DATE,
    @number_of_nights INT,
    @special_request VARCHAR(255),
    @arrived_time TIME,
    @reservation_status TINYINT,
    @reservation_id INT OUTPUT
AS
BEGIN  
 
	  -- Check if the room exists
    IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @room_id)
    BEGIN
        THROW 51000, 'Room does not exist, AddReservation', 1;
        RETURN;
    END

    -- Check if the customer exists
    IF  NOT EXISTS (SELECT 1 FROM customers WHERE CustomerID = @customer_id)
    BEGIN
        THROW 51000, 'Customer does not exist, AddReservation', 1;
        RETURN;
    END
    -- Insert the new reservation into the reservations table
    INSERT INTO reservations (customer_id, room_id, check_in_date, check_out_date, number_of_nights, special_request, arrived_time, reservation_status, reservation_date)
    VALUES (@customer_id, @room_id, @check_in_date, @check_out_date, @number_of_nights, @special_request, @arrived_time, @reservation_status, GETDATE());

    -- Get the ID of the newly inserted reservation
    SET @reservation_id = SCOPE_IDENTITY(); 
	 
END

--UPDATE REERVATION
CREATE PROCEDURE sp_UpdateReservationByID 
    @p_reservation_id INT,
    @p_customer_id INT,
    @p_room_id INT,
    @p_check_in_date DATE,
    @p_check_out_date DATE,
    @p_number_of_nights INT,
    @p_special_request VARCHAR(255),
    @p_arrived_time TIME,
    @p_reservation_status TINYINT
AS
BEGIN 
        -- Check if the reservation exists
        IF NOT EXISTS (SELECT 1 FROM reservations WHERE reservationID = @p_reservation_id)
        BEGIN
            THROW 51000, 'Reservation does not exist, UpdateReservation', 1;
        END

        -- Check if the room exists
        IF NOT EXISTS (SELECT 1 FROM rooms WHERE room_id = @p_room_id)
        BEGIN
            THROW 51000, 'Room does not exist, UpdateReservation', 1;
        END

        -- Check if the customer exists
        IF NOT EXISTS (SELECT 1 FROM customers WHERE CustomerID = @p_customer_id)
        BEGIN
            THROW 51000, 'Customer does not exist, UpdateReservation', 1;
        END

        -- Update the reservation
        UPDATE reservations
        SET customer_id = @p_customer_id,
            room_id = @p_room_id,
            check_in_date = @p_check_in_date,
            check_out_date = @p_check_out_date,
            number_of_nights = @p_number_of_nights,
            special_request = @p_special_request,
            arrived_time = @p_arrived_time,
            reservation_status = @p_reservation_status
        WHERE reservationID = @p_reservation_id; 
END
 
--DELETE RESERVATION
CREATE PROCEDURE sp_DeleteReservationByID 
    @p_reservation_id INT
AS
BEGIN
    
        DELETE FROM reservations
        WHERE reservationID = @p_reservation_id; 
END;
 

 --FIND RESERVATION
 CREATE PROCEDURE sp_FindReservationByID
	@ReservationID int 
 as
 begin 

	select * from reservations where reservationID =  @ReservationID  
end

 
 --GET ALL RESERVATIONS
 create procedure sp_GetAllReservation 
 as
 begin
	select * from reservations
 end


 --RESERVATION STATUS
 --1-pending 2-cancel 3-confirmed 4-completed
 
 --CHECK CUSTOMER ROOM RESERVATION RESERVATION 
CREATE PROCEDURE sp_IsCustomerHavePendingReservationForRoomNumber
		@CustomerID int ,
		@RoomNumber int 
AS
BEGIN 
		select FOUND = 1 FROM ReservationRoom_view
		WHERE Customer_ID = @CustomerID AND reservation_status = 1 AND room_number = @RoomNumber 
END

 

 select * from Customers 