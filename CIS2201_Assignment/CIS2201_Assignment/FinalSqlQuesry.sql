
/*Creating the local scheme 'Hospital'*/
CREATE SCHEMA [Hospital]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating Public.patients...';  
GO  

/*Creating the tables that will handle the daata inputted by the user through the WinForms*/
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
CREATE TABLE [Hospital].[patientsVisits] ( 

    [VisitID]               INT IDENTITY PRIMARY KEY NOT NULL,
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
CREATE TABLE [Hospital].[Appointments](

	[AppointmentID] INT IDENTITY PRIMARY KEY NOT NULL,
	[PatientsID] VARCHAR(10) NOT NULL,
	[PatientsName] VARCHAR(40) NOT NULL,
	[PatientsSurname] VARCHAR(40) NOT NULL,
	[Doctor] VARCHAR(40) NOT NULL,
	[CreationDate] DATE,
	[ScheduledDate] DATE
);
GO
CREATE TABLE [Hospital].[staff] (  

    [StaffID]            VARCHAR(10) PRIMARY KEY NOT NULL,  
    [StaffName]          NVARCHAR (40) NOT NULL,  
    [StaffSurnameName]   NVARCHAR (40) NOT NULL,
    [StaffGender]        NVARCHAR (40) NOT NULL,  
    [StaffAge]           INT NOT NULL,
    [StaffDateOfBirth]   DATE NOT NULL,
    [StaffAddress]       VARCHAR(100) NOT NULL,
    [StaffEmail]         NVARCHAR (40) NOT NULL,
    [StaffPhoneNumber]   INT NOT NULL,
    [StaffBloodType]     VARCHAR(10),
    [StaffInsurance]     CHAR (1) NOT NULL,
    [StaffRole]          NVARCHAR (10) NOT NULL,
); 
GO
CREATE TABLE [Hospital].[staffDetails] (  

    [DetailsID]             INT IDENTITY PRIMARY KEY NOT NULL,
    [StaffID]               VARCHAR(10) NOT NULL,  
    [StaffName]             NVARCHAR (40) NOT NULL,  
    [StaffSurname]          NVARCHAR (40) NOT NULL,
    [StartOfContract]       DATE NOT NULL,
    [EndOfContract]         DATE NOT NULL,
    [TypeOfContract]        VARCHAR (40) NOT NULL,
    [NumberOfHours]         INT NOT NULL,
    [Bonus]                 VARCHAR (100) NOT NULL,

);
GO
CREATE TABLE [Hospital].[Medication] (

    [TypeOfMed]          NVARCHAR (40) NOT NULL,
    [NameOfMed]          NVARCHAR (40) NULL,
    [bloodType]          NVARCHAR (40) NULL,
    [stockAmount]        NVARCHAR (40) NOT NULL,
    [price]              NVARCHAR (40) NOT NULL,
    [requireMaintenance] VARCHAR(40)  NOT NULL
);
GO
CREATE TABLE [Hospital].[issue] (  

    [StaffID]       VARCHAR(10) PRIMARY KEY NOT NULL,  
    [StaffDate]     DATE NOT NULL,
    [Details]       VARCHAR(500) NOT NULL,
); 
GO
CREATE TABLE [Hospital].[login] (  

    [Username] NVARCHAR (40) NOT NULL,  
    [Password] NVARCHAR (40) NOT NULL
);  
GO

/*Inserting some data into the tables*/
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
GO
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES( '12431G', 'Ronald', 'Abela', 'Male', 40, '27.OCT.1981', 'Triq Ghar Dalam, Birzebuggia', 'ronald_abela@gmail.com', 79465623, 'O', 'X', 'Doctor');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('31435H', 'Elizabeth', 'Smith', 'Female', 38, '14.JUN.1983', 'Triq Gorg Borg Olivier, il-Mellieha','eliSmith20@gmail.com', 77162349, 'A', 'Z', 'Nurse');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('15343M', 'George', 'Williams', 'Male', 29,'04.JAN.1992', 'Triq idmejda, Hal Balzan', 'george_williams@gmail.com', 99118831,'B', 'Z', 'Therapist');
INSERT INTO [Hospital].[staff](StaffID, StaffName, StaffSurnameName, StaffGender, StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)
VALUES('4685G','David', 'Brown', 'Male', 30,'04.JAN.1993', '113, Triq is-Saghtar, St Paul Bay', 'brownDavid@gmail.com', 79798612, 'O', 'Y', 'Physicians');
GO
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '12431G', 'Ronald', 'Abela', '27.OCT.1981', '01.SEP.2023', 'Definite', 20, '200');
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '4685G','David', 'Brown', '27.OCT.2010', '01.SEP.2025', 'Indefinite', 40, '500');
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '15343M', 'George', 'Williams', '27.OCT.2009', '01.SEP.2030', 'Definite', 25, '155');
INSERT INTO [Hospital].[staffDetails](StaffID, StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)
VALUES( '31435H','Elizabeth', 'Smith', '27.OCT.2000', '01.SEP.2051', 'Indefinite', 30, '150');
SELECT * FROM [Hospital].[staffDetails];
GO
SELECT * FROM [Hospital].[patientsVisits];
GO
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Medicine', 'Caughing syrup', NULL, '175', '15',  'no');
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount, price, requireMaintenance)
VALUES('Blood Samples', NULL ,'B', '50', '6',  'yes' );
GO
INSERT INTO [Hospital].[issue](StaffID, StaffDate, Details)
VALUES( '12431', '27.OCT.2021', 'Staff Tab not opening');
INSERT INTO [Hospital].[issue](StaffID, StaffDate, Details)
VALUES('31435',  '14.DEC.2021', 'Staff not working');
GO
INSERT INTO [Hospital].[login](Username, Password)
VALUES('Admin', 'Test');
INSERT INTO [Hospital].[login](Username, Password)
VALUES('Ronald', 'Test01');
INSERT INTO [Hospital].[login](Username, Password)
VALUES('John', 'Test02');
GO

/*Creating the relational constraints between some of the tables*/
ALTER TABLE [Hospital].[patientsVisits] 
ADD CONSTRAINT patient_has_many_visits
FOREIGN KEY (PatientsID)
REFERENCES [Hospital].[patients](PatientsID)
GO
ALTER TABLE [Hospital].[Appointments] 
ADD CONSTRAINT patient_has_many_appointments
FOREIGN KEY (PatientsID)
REFERENCES [Hospital].[patients](PatientsID)
GO
ALTER TABLE [Hospital].[staffDetails] 
ADD CONSTRAINT staff_has_many_details
FOREIGN KEY (StaffID)
REFERENCES [Hospital].[staff](StaffID)
GO
/*Creating the stored procedures that will be used to handle data from the database*/
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
GO
CREATE PROCEDURE [Hospital].[addStaff]  
@StaffID VARCHAR(10), @StaffName NVARCHAR(40), @StaffSurnameName NVARCHAR(40), @StaffGender NVARCHAR(40), @StaffAge INT, @StaffDateOfBirth DATE, @StaffAddress VARCHAR(100), @StaffEmail NVARCHAR(40), @StaffPhoneNumber INT, @StaffBloodType VARCHAR(10), @StaffInsurance CHAR(1), @StaffRole NVARCHAR(10) 
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[staff] (StaffID, StaffName, StaffSurnameName, StaffGender,  StaffAge, StaffDateOfBirth, StaffAddress, StaffEmail, StaffPhoneNumber, StaffBloodType, StaffInsurance, StaffRole)   
     VALUES (@StaffID, @StaffName, @StaffSurnameName, @StaffGender, @StaffAge, @StaffDateOfBirth, @StaffAddress, @StaffEmail, @StaffPhoneNumber, @StaffBloodType, @StaffInsurance, @StaffRole);
COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [Hospital].[addStaffDetails]  
@StaffID VARCHAR(10), @StaffName  NVARCHAR (40), @StaffSurname  NVARCHAR (40),@StartOfContract  DATE, @EndOfContract DATE, @TypeOfContract VARCHAR(40), @NumberOfHours INT, @Bonus VARCHAR(10)
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[staffDetails] (StaffID,StaffName, StaffSurname, StartOfContract, EndOfContract, TypeOfContract, NumberOfHours, Bonus)   
     VALUES (@StaffID, @StaffName, @StaffSurname,@StartOfContract,@EndOfContract, @TypeOfContract,@NumberOfHours, @Bonus);
COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [Hospital].[addMedication]
	@TypeOfMed NVARCHAR(40), @NameOfMed NVARCHAR(40), @bloodType NVARCHAR(40), @stockAmount NVARCHAR(40), @price NVARCHAR(40), @requireMaintenance VARCHAR(40)
AS
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[Medication] (TypeOfMed, NameOfMed, bloodType, stockAmount,  price, requireMaintenance)   
     VALUES (@TypeOfMed, @NameOfMed, @bloodType, @stockAmount, @price, @requireMaintenance);
COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [Hospital].[addIssue]  
@StaffID VARCHAR(10), @StaffDate DATE, @Details VARCHAR(500)
AS  
BEGIN
BEGIN TRANSACTION  
INSERT INTO [Hospital].[issue] (StaffID, StaffDate, Details)   
     VALUES (@StaffID, @StaffDate, @Details);
COMMIT TRANSACTION
END
 
