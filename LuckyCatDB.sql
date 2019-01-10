USE master
GO

DROP DATABASE [LuckyCatDB]
GO

CREATE DATABASE [LuckyCatDB]
GO
USE LuckyCatDB; 
GO


CREATE TABLE [dbo].[Employees] (
    [EmployeeID]		INT					IDENTITY (1, 1)  NOT NULL,
	[EmployeeName]		VARCHAR (20)		NOT NULL,
	[Password]			VARCHAR (20)		NOT NULL,
    [Permission]		CHAR (1)			DEFAULT 'U' NOT NULL
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
);

/*
Created: Emerald		Last modified: Emerald
*/
CREATE TABLE [dbo].[Tables] (
	[TableName]			VARCHAR (20)		NOT NULL,
	[TableStatus]		VARCHAR (20)		NOT NULL,
    CONSTRAINT [PK_Tables] PRIMARY KEY ([TableName]),
);

/*
Created: Phoenix		Last modified: Phoenix
*/
CREATE TABLE [dbo].[Dishes] (
    [DishID]			INT					IDENTITY (1, 1)  NOT NULL,
	[DishName]			VARCHAR (20)		NOT NULL,
    [DishPrice]			DECIMAL (5, 2)		NOT NULL,
    CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED ([DishID] ASC),
);

/*
Created: Phoenix		Last modified: Emerald
*/
CREATE TABLE [dbo].[Orders] (
    [OrderID]			INT					IDENTITY (1, 1)  NOT NULL,
    [TableName]			VARCHAR (20)		NOT NULL,
    [EmployeeID]		INT					NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC),
	CONSTRAINT [FK_Orders_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

/*
Created: Phoenix		Last modified: Phoenix
*/
CREATE TABLE [dbo].[OrderDish] (
    [OrderID]			INT					NOT NULL,
    [DishID]			INT					NOT NULL,
    [Quantity]			TINYINT				NOT NULL,
	CONSTRAINT [FK_OrderDish_Dishes] FOREIGN KEY ([DishID]) REFERENCES [dbo].[Dishes] ([DishID]),
	CONSTRAINT [FK_OrderDish_Orders] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderID])
);

USE [LuckyCatDB]
GO

/* Insert to Employees Table
Created: Phoenix		Last modified: Emerald
*/
INSERT INTO [dbo].[Employees] ([EmployeeName],[Password],[Permission])
	VALUES ('Admin','admin','A');

INSERT INTO [dbo].[Employees] ([EmployeeName],[Password])
	VALUES ('Emerald','emerald');

/*
Created: Emerald		Last modified: Emerald
*/
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_01','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_02','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_03','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_04','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_05','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_06','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_07','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_08','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_09','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_10','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_11','empty');
INSERT INTO [dbo].[Tables] ([TableName],[TableStatus])
	VALUES ('TABLE_12','empty');

	
INSERT [dbo].[Dishes] ( [DishName], [DishPrice]) VALUES ( N'Rice', CAST(2.33 AS Decimal(5, 2)));
INSERT [dbo].[Dishes] ( [DishName], [DishPrice]) VALUES ( N'Chicken', CAST(3.45 AS Decimal(5, 2)));
INSERT [dbo].[Dishes] ( [DishName], [DishPrice]) VALUES ( N'Pork', CAST(4.31 AS Decimal(5, 2)));
INSERT [dbo].[Dishes] ( [DishName], [DishPrice]) VALUES ( N'Potato', CAST(1.21 AS Decimal(5, 2)));
INSERT [dbo].[Dishes] ( [DishName], [DishPrice]) VALUES ( N'Broccoli', CAST(2.20 AS Decimal(5, 2)));

