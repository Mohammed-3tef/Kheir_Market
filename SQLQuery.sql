CREATE DATABASE Super_Market;
USE Super_Market;

-- Create User Table
CREATE TABLE [User] (
    [User_ID] INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(15),
    Address VARCHAR(255),
	Is_Admin BIT NOT NULL,
	[Password] VARCHAR(50) NOT NULL CHECK(LEN([Password]) >= 8)
);

-- Create Category Table
CREATE TABLE Category (
    Category_ID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

-- Create Product Table
CREATE TABLE [Product] (
    Product_ID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Category_ID INT FOREIGN KEY REFERENCES Category(Category_ID),
    Price DECIMAL(10, 2),
    Stock_Quantity INT DEFAULT(0)
);

-- Create Order Table
CREATE TABLE [Order] (
    Order_ID INT PRIMARY KEY,
    Customer_ID INT FOREIGN KEY REFERENCES [User]([User_ID]),
    Total_Amount DECIMAL(10, 2)
);

-- Create OrderDetails Table (Weak Entity)
CREATE TABLE OrderDetails (
    OrderDetails_ID INT PRIMARY KEY,
    Order_ID INT FOREIGN KEY REFERENCES [Order](Order_ID),
    Product_ID INT FOREIGN KEY REFERENCES [Product](Product_ID),
    Quantity INT
);

--USE master;
--DROP DATABASE Super_Market;