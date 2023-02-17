--List all cities that have both Employees and Customers.
SELECT City
FROM (
  SELECT City, 'Employee' AS Type
  FROM Employees
  UNION ALL
  SELECT City, 'Customer' AS Type
  FROM Customers
) AS Combined
GROUP BY City
HAVING COUNT(DISTINCT Type) = 2;

--List all cities that have Customers but no Employee.
--a. use sub query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (
  SELECT DISTINCT City
  FROM Employees
)

--b. do not use sub query
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

--List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrderQuantity
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

-- List all Customer Cities that have at least two customers.
-- a. Use union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2
UNION
SELECT City
FROM Suppliers
GROUP BY City
HAVING COUNT(*) >= 2

--b.Using a sub-query
SELECT DISTINCT City
FROM Customers
WHERE City IN (
    SELECT City
    FROM Customers
    GROUP BY City
    HAVING COUNT(*) >= 2
)

-- List all Customer Cities that have ordered at least two different kinds of products.
SELECT City
FROM (
    SELECT C.City, COUNT(DISTINCT OD.ProductID) AS NumProducts
    FROM Customers AS C
    JOIN Orders AS O ON C.CustomerID = O.CustomerID
    JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
    GROUP BY C.City, O.CustomerID
    HAVING COUNT(DISTINCT OD.ProductID) >= 2
) AS T
GROUP BY City

--List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT C.CustomerID, C.CompanyName, O.ShipCity, C.City
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE O.ShipCity != C.City

--List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 P.ProductName, AVG(OD.UnitPrice) AS AvgPrice, C.City
FROM Products P INNER JOIN [Order Details] OD ON P.ProductID = OD.ProductID
INNER JOIN Orders O ON OD.OrderID = O.OrderID
INNER JOIN Customers AS C ON O.CustomerID = C.CustomerID
GROUP BY P.ProductName, C.City
ORDER BY SUM(OD.Quantity) DESC;

--List all cities that have never ordered something but we have employees there.
--a.Use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN (
    SELECT DISTINCT City
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
)

--b.Do not use sub-query
SELECT DISTINCT e.City
FROM Employees e LEFT JOIN Customers c ON e.City = c.City
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City IS NULL AND o.OrderID IS NULL

--List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT 
    TOP 1 COALESCE(emp_orders.city, emp_products.city) AS city
FROM 
    (SELECT 
        o.EmployeeID, c.City, COUNT(*) AS order_count
     FROM 
        Orders o 
        JOIN Customers c ON o.CustomerID = c.CustomerID 
     GROUP BY 
        o.EmployeeID, c.City) AS emp_orders
    LEFT JOIN 
    (SELECT 
        o.EmployeeID, c.City, SUM(od.Quantity) AS total_products_ordered
     FROM 
        Orders o 
        JOIN Customers c ON o.CustomerID = c.CustomerID 
        JOIN [Order Details] od ON o.OrderID = od.OrderID
     GROUP BY 
        o.EmployeeID, c.City) AS emp_products ON emp_orders.EmployeeID = emp_products.EmployeeID
GROUP BY 
    COALESCE(emp_orders.city, emp_products.city)
ORDER BY 
    MAX(COALESCE(emp_orders.order_count, 0)) DESC, 
    MAX(COALESCE(emp_products.total_products_ordered, 0)) DESC;

--How to remove duplicates from a table?

CREATE TABLE NewTable AS
SELECT DISTINCT * FROM MyTable;

SELECT COUNT(*) FROM NewTable;

DROP TABLE MyTable;

ALTER TABLE NewTable RENAME TO MyTable;
