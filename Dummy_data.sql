USE Super_Market;
GO

-- Clean existing data
DELETE FROM ORDER_DETAILS;
DELETE FROM [ORDER];
DELETE FROM STOCK;
DELETE FROM PRODUCT;
DELETE FROM DEPARTMENT;
DELETE FROM COMPANY;
DELETE FROM CATEGORY;
DELETE FROM [USER];
GO

-- USERS
INSERT INTO [USER] (UID, NAME, EMAIL, PHONE, ADDRESS, IS_ADMIN, PASSWORD) VALUES
(1, 'Ahmed Ali', 'ahmed@example.com', '01111111111', 'Cairo, Egypt', 0, 'password1'),
(2, 'Sara Youssef', 'sara@example.com', '01222222222', 'Giza, Egypt', 0, 'password2'),
(3, 'Omar Hassan', 'omar@example.com', '01033333333', 'Alexandria, Egypt', 0, 'password3');
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
INSERT INTO [ORDER] (OID, TOTAL_PRICE, ORDER_DATE) VALUES
(101, 150.0, '2025-01-15'),
(102, 60.0,  '2025-01-20'),
(103, 90.0,  '2025-02-05'),
(104, 120.0, '2025-02-10'),
(105, 200.0, '2025-02-18'),
(106, 8000.0, '2025-03-01');
GO

INSERT INTO ORDER_DETAILS (OID, PID, UID, ORDER_ID, QUANTITY) VALUES
(101, 1, 1, 101, 2),   -- Ahmed buys 2 Rice
(102, 2, 2, 102, 2),   -- Sara buys 2 Sugar
(103, 3, 1, 103, 3),   -- Ahmed buys 3 Milk
(104, 4, 2, 104, 1),   -- Sara buys 1 Microwave
(105, 1, 3, 105, 4),   -- Omar buys 4 Rice
(106, 5, 3, 106, 2);   -- Omar buys 2 TVs
GO
