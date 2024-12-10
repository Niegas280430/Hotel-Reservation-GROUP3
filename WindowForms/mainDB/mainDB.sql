CREATE DATABASE [mainDB]

USE [mainDB]

CREATE TABLE tbFeedback (

[Comments] varchar(MAX), 
[Date] DATE, 
[Rating] int

)


CREATE TABLE [BookInfo] (
loginID int NOT NULL PRIMARY KEY,
firstname varchar(50), 
lastname varchar(50), 
email varchar(100), 
phone varchar(100), 
checkin date, 
checkout date
)