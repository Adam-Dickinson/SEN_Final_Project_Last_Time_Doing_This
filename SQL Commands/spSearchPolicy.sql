USE SEN_381_Final_Project

GO

CREATE PROCEDURE spSearchPolicy
(
	@Provider_Name varchar(255)
)

AS
BEGIN

SELECT * FROM provider_details
WHERE Provider_Name = @Provider_Name
END
