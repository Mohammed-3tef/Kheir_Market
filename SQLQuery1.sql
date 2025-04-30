CREATE DATABASE Super_Market;
USE Super_Market;

-- Create Customer Table
CREATE TABLE Customer (
    Customer_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(15),
    Address VARCHAR(255),
    Freq_Num INT
);

-- Create Admin Table
CREATE TABLE [Admin] (
    Admin_ID INT PRIMARY KEY,
    Name VARCHAR(100),
	Phone VARCHAR(15),
    Address VARCHAR(255)
);

-- Create Category Table
CREATE TABLE Category (
    Category_ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Create Product Table
CREATE TABLE [Product] (
    Product_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Category_ID INT FOREIGN KEY REFERENCES Category(Category_ID),
    Price DECIMAL(10, 2),
    Stock_Quantity INT
);

-- Create Order Table
CREATE TABLE [Order] (
    Order_ID INT PRIMARY KEY,
    Customer_ID INT,
    Total_Amount DECIMAL(10, 2),
    FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID)
);

-- Create OrderDetails Table (Weak Entity)
CREATE TABLE OrderDetails (
    OrderDetails_ID INT PRIMARY KEY,
    Order_ID INT,
    Product_ID INT,
    Quantity INT,
    FOREIGN KEY (Order_ID) REFERENCES [Order](Order_ID),
    FOREIGN KEY (Product_ID) REFERENCES [Product](Product_ID)
);