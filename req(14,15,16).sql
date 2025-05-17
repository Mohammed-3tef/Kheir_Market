
-- req 14

WITH MonthlyCustomerTotals AS (
    SELECT 
        U.UID,
        U.NAME AS CustomerName,
        YEAR(O.ORDER_DATE) AS OrderYear,
        MONTH(O.ORDER_DATE) AS OrderMonth,
        SUM(O.TOTAL_PRICE) AS TotalSpent
    FROM [ORDER] O
    JOIN ORDER_DETAILS OD ON O.OID = OD.OID
    JOIN [USER] U ON OD.UID = U.UID
    GROUP BY U.UID, U.NAME, YEAR(O.ORDER_DATE), MONTH(O.ORDER_DATE)
),
RankedCustomers AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY OrderYear, OrderMonth ORDER BY TotalSpent DESC) AS Rank
    FROM MonthlyCustomerTotals
)
SELECT 
    CustomerName,
    UID,
    TotalSpent,
    OrderMonth,
    OrderYear
FROM RankedCustomers
WHERE Rank = 1;



-- req 15

SELECT 
    c.NAME AS CATEGORY_NAME,
    SUM(p.PRICE * od.QUANTITY) AS TOTAL_SALES
FROM 
    CATEGORY c
JOIN DEPARTMENT d ON c.CID = d.CID
JOIN PRODUCT p ON d.DID = p.DID
JOIN ORDER_DETAILS od ON p.PID = od.PID
JOIN [ORDER] o ON od.ORDER_ID = o.OID
WHERE 
    c.NAME IN ('Food', 'Electronic')
GROUP BY 
    c.NAME;

-- req 16

SELECT 
    p.NAME AS PRODUCT_NAME,
    p.PID,
    d.NAME AS DEPARTMENT_NAME,
    c.NAME AS CATEGORY_NAME,
    co.NAME AS COMPANY_NAME,
    COUNT(od.UID) AS TOTAL_CUSTOMER_PURCHASES
FROM 
    PRODUCT p
JOIN DEPARTMENT d ON p.DID = d.DID
JOIN CATEGORY c ON d.CID = c.CID
JOIN COMPANY co ON p.COMPID = co.COMPID
LEFT JOIN ORDER_DETAILS od ON p.PID = od.PID
GROUP BY 
    p.PID, p.NAME, d.NAME, c.NAME, co.NAME

