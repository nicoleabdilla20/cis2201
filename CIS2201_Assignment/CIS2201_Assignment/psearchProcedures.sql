SELECT * FROM [Hospital].[patients];

GO
CREATE PROCEDURE [Hospital].[searchPatient]  
@PatientsID VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
SELECT * FROM [Hospital].[patients] WHERE PatientsID = @PatientsID;
COMMIT TRANSACTION
END
GO

GO
CREATE PROCEDURE [Hospital].[searchPatientVisit]  
@PatientsID VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
SELECT * FROM [Hospital].[patientsVisits] WHERE PatientsID = @PatientsID;
COMMIT TRANSACTION
END
GO

SELECT * FROM [Hospital].[patientsVisits];