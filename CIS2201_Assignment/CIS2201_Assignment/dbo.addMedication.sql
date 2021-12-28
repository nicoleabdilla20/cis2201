CREATE PROCEDURE [dbo].[addMedication]
	@TypeOfMed NVARCHAR(40), @NameOfMed NVARCHAR(40), @stockAmount NVARCHAR(40), @price NVARCHAR(40), @requireMaintenance BIT
AS
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, stockAmount,  price, requireMaintenance)   
     VALUES (@TypeOfMed, @NameOfMed, @stockAmount, @price, @requireMaintenance);
COMMIT TRANSACTION
END