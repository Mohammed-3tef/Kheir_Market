

USE Super_Market;
GO

-- Clean existing data
DELETE FROM ORDER_DETAILS;
DELETE FROM [ORDER];
DELETE FROM PRODUCT;
DELETE FROM STOCK;
DELETE FROM DEPARTMENT;
DELETE FROM COMPANY;
DELETE FROM CATEGORY;
DELETE FROM [USER];
GO

-- USERS
INSERT INTO [USER] (UID, NAME, EMAIL, PHONE, ADDRESS, IS_ADMIN, PASSWORD) VALUES
(1, 'Ahmed Ali', 'ahmed123445@gmail.com', '01111111111', '25st Kaser El Nile, Sadat , Cairo', 0, '!Pass12345'),
(2, 'Sara Youssef', 'sara2355@yahoo.com', '01222222222', '165st Tahrir, Dokki , Giza ', 0, '!Pass21345'),
(3, 'Omar Hassan', 'omar2025@gmail.com', '01033333333', '144st Abaza, Semoha , Alexandria', 0, '!Pass31245'),
(0, 'Admin', 'fcaicu.assignments@gmail.com', '01234567890', '13st Tahrir, Dokki, Giza', 1, '!Admin12345');
GO

-- CATEGORIES
INSERT INTO CATEGORY (CID, NAME) VALUES
(1, 'Food'),
(2, 'Electronics');
GO

-- COMPANIES
INSERT INTO COMPANY (COMPID, CATE_ID, NAME, COUNTRY) VALUES
(1, 1, 'Nestle', 'Egypt'),
(2, 2, 'Samsung', 'South Korea'),
(3, 2, 'Sony', 'Japan');
GO

-- DEPARTMENTS
INSERT INTO DEPARTMENT (DID, CID, NAME) VALUES
(1, 1, 'Groceries'),
(2, 2, 'Appliances');
GO

-- STOCK first (before PRODUCT)
INSERT INTO STOCK (PROD_ID, PRODUCT_QUANTITY) VALUES
(1, 100),
(2, 200),
(3, 150),
(4, 20),
(5, 15);
GO

-- PRODUCTS
INSERT INTO PRODUCT (PID, DID, SID, COMPID, NAME, PRICE) VALUES
(1, 1, 1, 1, 'Rice', 50.0),
(2, 1, 1, 1, 'Sugar', 30.0),
(3, 1, 1, 1, 'Milk', 20.0),
(4, 2, 2, 2, 'Microwave', 1500.0),
(5, 2, 2, 3, 'TV', 4000.0);
GO

-- ORDERS
INSERT INTO [ORDER] (TOTAL_PRICE, ORDER_DATE) VALUES
(150.0, '2025-01-15'),
(60.0,  '2025-01-20'),
(90.0,  '2025-02-05'),
(120.0, '2025-02-10'),
(200.0, '2025-02-18'),
(8000.0, '2025-03-01');
GO

DECLARE @Order1 int, @Order2 int, @Order3 int, @Order4 int, @Order5 int, @Order6 int;

SELECT @Order1 = OID FROM [ORDER] WHERE TOTAL_PRICE = 150.0 AND ORDER_DATE = '2025-01-15';
SELECT @Order2 = OID FROM [ORDER] WHERE TOTAL_PRICE = 60.0 AND ORDER_DATE = '2025-01-20';
SELECT @Order3 = OID FROM [ORDER] WHERE TOTAL_PRICE = 90.0 AND ORDER_DATE = '2025-02-05';
SELECT @Order4 = OID FROM [ORDER] WHERE TOTAL_PRICE = 120.0 AND ORDER_DATE = '2025-02-10';
SELECT @Order5 = OID FROM [ORDER] WHERE TOTAL_PRICE = 200.0 AND ORDER_DATE = '2025-02-18';
SELECT @Order6 = OID FROM [ORDER] WHERE TOTAL_PRICE = 8000.0 AND ORDER_DATE = '2025-03-01';

INSERT INTO ORDER_DETAILS (OID, PID, UID, ORDER_ID, QUANTITY) VALUES
(@Order1, 1, 1, @Order1, 2),   -- Ahmed buys 2 Rice
(@Order2, 2, 2, @Order2, 2),   -- Sara buys 2 Sugar
(@Order3, 3, 1, @Order3, 3),   -- Ahmed buys 3 Milk
(@Order4, 4, 2, @Order4, 1),   -- Sara buys 1 Microwave
(@Order5, 1, 3, @Order5, 4),   -- Omar buys 4 Rice
(@Order6, 5, 3, @Order6, 2);   -- Omar buys 2 TVs
GO