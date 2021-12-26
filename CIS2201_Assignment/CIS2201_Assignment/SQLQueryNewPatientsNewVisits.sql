CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  
CREATE TABLE [Hospital].[patients] (  
    [PatientsID]            VARCHAR(10) PRIMARY KEY NOT NULL,  
    [PatientsName]          NVARCHAR (40) NOT NULL,  
    [PatientsSurnameName]   NVARCHAR (40) NOT NULL,
    [PatientsGender]        NVARCHAR (40) NOT NULL,  
    [PatientsAge]           INT NOT NULL,
    [PatientsDateOfBirth]   DATE NOT NULL,
    [PatientsAddress]       VARCHAR(100) NOT NULL,
    [PatientsTelephone]     INT NOT NULL,
    [PatientsBloodType]     VARCHAR(10) NOT NULL,
    [PatientsAllergies]     VARCHAR(10),
    [PatientsInsurance]     CHAR (1) NOT NULL
);  
GO
ALTER TABLE [Hospital].[patients]
ALTER COLUMN [PatientsAllergies]     VARCHAR(10);
GO
INSERT INTO [Hospital].[patients](PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)
VALUES('11467G', 'Jhon', 'Brown', 'Male', 45,'27.OCT.1976', '45, Main Road, Rabat Gozo', 21556894, 'O', NULL, 'X');
INSERT INTO [Hospital].[patients](PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)
VALUES('12487H', 'Emma', 'Cutajar', 'Female', 22,'11.MAY.1999', '188, Triq Il-Wied, Qrendi Malta', 21545765, 'A', NULL, 'Z');
INSERT INTO [Hospital].[patients](PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)
VALUES('22431G', 'Colin', 'Debrincat', 'Male', 27,'27.FEB.1997', '9, Triq il-Madliena, Swieqi Malta', 23822910, 'B', 'Food', 'Y');
INSERT INTO [Hospital].[patients](PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)
VALUES('11301M', 'Stephanie', 'Zammit', 'Female', 35,'2.JAN.1986', '68, Triq tal-Marġa, Rabat Malta', 21356789, 'O', NULL, 'Z');
INSERT INTO [Hospital].[patients](PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)
VALUES('13445G', 'Joan', 'Attard', 'Female', 41,'7.AUG.1980', '43, Triq it-Tigrija, Rabat Gozo', 23557689, 'AB', NULL, 'X');
GO
DELETE FROM [Hospital].[patients]
WHERE [PatientsID] = '22431G';
GO
SELECT * FROM [Hospital].[patients];
GO
CREATE TABLE [Hospital].[patientsVisits] (  
    [PatientsID]            VARCHAR(10) NOT NULL,  
    [PatientsName]          VARCHAR(10) NOT NULL,
    [PatientsSurname]       VARCHAR(10) NOT NULL,
    [RecentVisitDate]       DATE NOT NULL,
    [RecentVisitDoctor]     VARCHAR (40) NOT NULL,
    [RecentVisitSummary]    VARCHAR (100),  
    [OtherVisitDate]        DATE NOT NULL,
    [OtherVisitDoctor]      VARCHAR (40) NOT NULL,
    [OtherVisitSummary]     VARCHAR (100) 
); 
GO
ALTER TABLE [Hospital].[patientsVisits]
ALTER COLUMN [PatientsID] VARCHAR(10) NOT NULL;
GO
INSERT INTO [Hospital].[patientsVisits](PatientsID,PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)
VALUES('11467G', 'Jhon', 'Brown', '27.OCT.2020', 'Dr.Camilleri', 'Broken Arm.','5.SEP.2010', 'Dr.Grech', 'Food poisoning.');
INSERT INTO [Hospital].[patientsVisits](PatientsID,PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)
VALUES('12487H', 'Emma', 'Cutajar', '11.JUN.2021', 'Dr.Grech', 'Fractured Leg.','11.AUG.2009', 'Dr.Zammit', 'Broken Leg.');
INSERT INTO [Hospital].[patientsVisits](PatientsID,PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)
VALUES('22431G', 'Colin', 'Debrincat', '5.DEC.2021', 'Dr.Camillerri', 'Allergic reaction to nuts.', '11.JAN.2019', 'Dr.Grech', 'Head wound from fall.');
INSERT INTO [Hospital].[patientsVisits](PatientsID,PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)
VALUES('11301M', 'Stephanie', 'Zammit', '14.APR.2020', 'Dr.Zammit', 'Severe burns.','14.SEP.2015', 'Dr.Camilleri', 'Broken thumb.');
INSERT INTO [Hospital].[patientsVisits](PatientsID,PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)
VALUES('13445G', 'Joan', 'Attard', '2.JUL.2021', 'Dr.Camillerri', 'Food poisoning', '9.OCT.2017', 'Dr.Grech', 'Dislocated shoulder from fall');

SELECT * FROM [Hospital].[patientsVisits];

GO
CREATE PROCEDURE [Hospital].[addPatient]  
@PatientsID VARCHAR(10), @PatientsName NVARCHAR(40), @PatientsSurnameName NVARCHAR(40), @PatientsGender NVARCHAR(40), @PatientsAge INT, @PatientsDateOfBirth DATE, @PatientsAddress VARCHAR(100), @PatientsTelephone INT, @PatientsBloodType VARCHAR(10), @PatientsAllergies VARCHAR(10), @PatientsInsurance CHAR(1)
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[patients] (PatientsID, PatientsName, PatientsSurnameName, PatientsGender, PatientsAge,  PatientsDateOfBirth, PatientsAddress, PatientsTelephone, PatientsBloodType, PatientsAllergies, PatientsInsurance)   
     VALUES (@PatientsID, @PatientsName, @PatientsSurnameName, @PatientsGender, @PatientsAge, @PatientsDateOfBirth, @PatientsAddress, @PatientsTelephone, @PatientsBloodType, @PatientsAllergies, @PatientsInsurance);
COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [Hospital].[addPatientVisit]  
@PatientsID VARCHAR(10), @PatientsName VARCHAR(10), @PatientsSurname VARCHAR(10), @RecentVisitDate DATE, @RecentVisitDoctor VARCHAR(40), @RecentVisitSummary VARCHAR(100), @OtherVisitDate DATE, @OtherVisitDoctor VARCHAR(40), @OtherVisitSummary VARCHAR(100)
AS
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[patientsVisits] (PatientsID, PatientsName, PatientsSurname, RecentVisitDate, RecentVisitDoctor, RecentVisitSummary, OtherVisitDate, OtherVisitDoctor, OtherVisitSummary)   
     VALUES(@PatientsID, @PatientsName, @PatientsSurname, @RecentVisitDate, @RecentVisitDoctor, @RecentVisitSummary, @OtherVisitDate, @OtherVisitDoctor, @OtherVisitSummary);
COMMIT TRANSACTION
END


