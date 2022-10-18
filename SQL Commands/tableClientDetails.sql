USE SEN_381_Final_Project
GO
CREATE TABLE client_details (
Call_Id int NOT NULL PRIMARY KEY,
Id_Number int,
Client_Name varchar(255),
Client_Lastname varchar(255),
Client_PhoneNumber varchar(255),
Main_Member varchar(255),
Family_Unit varchar(10),
Policy_Name varchar(255),
Policy_JoinDate date,
Policy_Type varchar(255),
Condition_Status varchar(5),
Medical_Condition varchar(255),
Hospital_Name varchar(255)
);