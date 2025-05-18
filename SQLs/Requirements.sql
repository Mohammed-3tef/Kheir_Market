Use Super_Market;

-------- I. Most Purchased Product: Retrieve the product with the highest customer count. 

SELECT Top 10 
[Product].NAME AS Product_Name , COUNT(DISTINCT [ORDER_DETAILS].UID) AS Times_Bought 
FROM ORDER_DETAILS INNER JOIN PRODUCT  ON [ORDER_DETAILS].PID = [Product].PID
GROUP BY [Product].NAME
ORDER BY Times_Bought DESC;
go

-------- II. Unsold Products by Month: Identify products with no sales in a specified month. 

DECLARE @Mnth INT = 2;
DECLARE @Year INT = 2025;

SELECT [PRODUCT].NAME AS ProductName , DATENAME(MONTH, DATEFROMPARTS(@Year, @Mnth, 1)) AS [Month], @Year AS [Year]
FROM PRODUCT 
WHERE [PRODUCT].PID NOT IN (
    SELECT OD.PID
    FROM ORDER_DETAILS OD
    JOIN "ORDER" O ON OD.OID = O.OID
    WHERE MONTH(O.ORDER_DATE) = @Mnth AND YEAR(O.ORDER_DATE) = @Year
);
go

-------- III. Inactive Customers: Identify customers inactive for the past year. 

SELECT 
	U.UID AS [User ID], U.NAME AS [Name], U.EMAIL AS [Email], U.PHONE AS [Phone Number]
FROM [USER] U
JOIN [ORDER_DETAILS] OD ON OD.UID = U.UID
JOIN [ORDER] O ON O.OID = OD.OID
WHERE NOT EXISTS (
    SELECT *
    FROM [ORDER] O2
    JOIN [ORDER_DETAILS] OD2 ON O2.OID = OD2.OID
    WHERE OD2.UID = U.UID
      AND YEAR(O2.ORDER_DATE) = 2024
);

-------- IV. Top Purchasing Customer: Identify the customer with the highest monthly purchase. 

WITH MonthlyCustomerTotals AS (
    SELECT U.UID AS [Customer ID], U.NAME AS [Customer Name],
        YEAR(O.ORDER_DATE) AS [Order Year],
        MONTH(O.ORDER_DATE) AS [Order Month],
        SUM(O.TOTAL_PRICE) AS [Total Spent]
    FROM [ORDER] O
    JOIN ORDER_DETAILS OD ON O.OID = OD.OID
    JOIN [USER] U ON OD.UID = U.UID
    GROUP BY U.UID, U.NAME, YEAR(O.ORDER_DATE), MONTH(O.ORDER_DATE)
),
RankedCustomers AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY [Order Year], [Order Month] ORDER BY [Total Spent] DESC) AS Rank
    FROM MonthlyCustomerTotals
)
SELECT 
    [Customer ID], [Customer Name],
    [Total Spent], [Order Month],
    [Order Year]
FROM RankedCustomers
WHERE Rank = 1;

-------- V. Sales Comparison: Compare sales between food and electronic products.

SELECT c.NAME AS Category,
    SUM(p.PRICE * od.QUANTITY) AS [Total Sales]
FROM CATEGORY c
JOIN DEPARTMENT d ON c.CID = d.CID
JOIN PRODUCT p ON d.DID = p.DID
JOIN ORDER_DETAILS od ON p.PID = od.PID
JOIN [ORDER] o ON od.ORDER_ID = o.OID
WHERE c.NAME IN ('Food', 'Electronic')
GROUP BY c.NAME;

-------- VI. Product Purchase Summary: Retrieve product details with customer purchase counts.

SELECT 
    p.PID AS [ID],
    p.NAME AS [Name],
    d.NAME AS Department,
    c.NAME AS Category,
    co.NAME AS Company,
    COUNT(od.UID) AS [Total Customer Purchases]
FROM PRODUCT p
JOIN DEPARTMENT d ON p.DID = d.DID
JOIN CATEGORY c ON d.CID = c.CID
JOIN COMPANY co ON p.COMPID = co.COMPID
LEFT JOIN ORDER_DETAILS od ON p.PID = od.PID
GROUP BY p.PID, p.NAME, d.NAME, c.NAME, co.NAME

