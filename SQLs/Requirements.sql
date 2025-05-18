-- Requirment A (the best seller product)
SELECT Top 10 
[Product].NAME AS Product_Name , COUNT(DISTINCT [ORDER_DETAILS].UID) AS Times_Bought 
FROM ORDER_DETAILS INNER JOIN PRODUCT  ON [ORDER_DETAILS].PID = [Product].PID
GROUP BY [Product].NAME
ORDER BY Times_Bought DESC;
go

-- VAR will be Used in the C#
DECLARE @Mnth INT = 2;
DECLARE @Year INT = 2025;

-- Requirment B (product with no customer in specific month)
SELECT [PRODUCT].NAME AS ProductName , DATENAME(MONTH, DATEFROMPARTS(@Year, @Mnth, 1)) AS [Month], @Year AS [Year]
FROM PRODUCT 
WHERE [PRODUCT].PID NOT IN (
    SELECT OD.PID
    FROM ORDER_DETAILS OD
    JOIN "ORDER" O ON OD.OID = O.OID
    WHERE MONTH(O.ORDER_DATE) = @Mnth AND YEAR(O.ORDER_DATE) = @Year
);
go

-- req 14

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



-- req 15

SELECT c.NAME AS Category,
    SUM(p.PRICE * od.QUANTITY) AS [Total Sales]
FROM CATEGORY c
JOIN DEPARTMENT d ON c.CID = d.CID
JOIN PRODUCT p ON d.DID = p.DID
JOIN ORDER_DETAILS od ON p.PID = od.PID
JOIN [ORDER] o ON od.ORDER_ID = o.OID
WHERE c.NAME IN ('Food', 'Electronic')
GROUP BY c.NAME;

-- req 16

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

