USE SEN_381_Final_Project

GO

CREATE PROCEDURE spAddPolicy
(
	@Company_ID int,
	@Provider_Name varchar(255),
	@_Location varchar(255),
	@_Address varchar(255),
	@_Status varchar(50)
)

AS

BEGIN

INSERT INTO provider_details
VALUES(@Company_ID, @Provider_Name, @_Location, @_Address, @_Status)

END

