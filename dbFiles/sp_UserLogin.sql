USE [HotelMS]
GO
/****** Object:  StoredProcedure [dbo].[sp_UserLogin]    Script Date: 4/7/2024 1:54:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_UserLogin]
    @Username VARCHAR(50),
    @Password VARCHAR(200)
AS
BEGIN
    DECLARE @UserID INT

    -- Check if username and password match
    SELECT @UserID = UserID
    FROM Users
    WHERE UserName = @Username AND Password = @Password

    -- If user is found
    IF @UserID IS NOT NULL
    BEGIN
        -- Insert login record
        INSERT INTO UserLogins (UserID, LoginTime)
        VALUES (@UserID, GETDATE())

        -- Return success
        SELECT 1 AS LoginSuccess
    END
    ELSE
    BEGIN
        -- Return failure
        SELECT 0 AS LoginSuccess
    END
END

