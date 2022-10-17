USE SEN_381_Final_Project
GO

CREATE PROCEDURE spDeleteProvider
(
 @Company_ID int
)

AS

BEGIN

DELETE FROM provider_details
WHERE Company_ID = @Company_ID

END