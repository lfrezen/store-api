CREATE PROCEDURE spGetCustomerOrdersCount
	@Document CHAR(11)
AS
	SELECT CASE WHEN EXISTS (
		SELECT c.[Id],
			   CONCAT(c.[FirstName], ' ', c.[LastName]) as [Name],
			   [Document]
		FROM [Customer] c
			INNER JOIN [Order] o 
				ON o.[CustomerId] = c.[Id]
		WHERE [Document] = @Document
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END