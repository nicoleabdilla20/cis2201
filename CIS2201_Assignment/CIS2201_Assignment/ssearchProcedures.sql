SELECT * FROM [Hospital].[staff];

GO
CREATE PROCEDURE [Hospital].[searchStaff]  
@StaffID VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID;
COMMIT TRANSACTION
END
GO

GO
CREATE PROCEDURE [Hospital].[searchStaffDetails]  
@StaffID VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID;
COMMIT TRANSACTION
END
GO

SELECT * FROM [Hospital].[staffDetails];