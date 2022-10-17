USE SEN_381_Final_Project
GO

CREATE PROCEDURE spUpdateProvider
(
 @Company_ID int,
 @Provider_Name varchar(255),
 @_Location varchar(255),
 @_Address varchar(255),
 @_Status varchar(255)
)

AS

BEGIN

UPDATE provider_details
SET Company_ID = @Company_ID, Provider_Name = @Provider_Name, _Location = @_Location, _Address = @_Address, @_Status = _Status
WHERE Company_ID = @Company_ID

END