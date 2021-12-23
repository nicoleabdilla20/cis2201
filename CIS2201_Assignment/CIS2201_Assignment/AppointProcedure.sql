CREATE TABLE [Hospital].[Appointments](

	[AppointmentID] INT IDENTITY NOT NULL,
	[PatientsID] VARCHAR(40) NOT NULL,
	[PatientsName] VARCHAR(40) NOT NULL,
	[PatientsSurname] VARCHAR(40) NOT NULL,
	[Doctor] VARCHAR(40) NOT NULL,
	[CreationDate] DATE,
	[ScheduledDate] DATE
);

GO
CREATE PROCEDURE [Hospital].[addAppointment]  
@PatientsID NVARCHAR(40), @PatientsName NVARCHAR(40), @PatientsSurname NVARCHAR(40), @Doctor VARCHAR(40), @CreationDate DATE, @ScheduledDate DATE
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[Appointments] (PatientsID, PatientsName, PatientsSurname, Doctor,  CreationDate, ScheduledDate)   
     VALUES (@PatientsID, @PatientsName, @PatientsSurname, @Doctor, @CreationDate, @ScheduledDate);
COMMIT TRANSACTION
END

SELECT * FROM [Hospital].[Appointments];