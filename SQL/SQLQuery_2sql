--How many products can you find in the Production.Product table?
SELECT COUNT(*) AS TotalNumOfRows
FROM Production.Product;

--a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(ProductSubcategoryID) AS ProductCount
FROM Production.Product

/*How many Products reside in each SubCategory? Write a query to display the results with the following titles.
ProductSubcategoryID CountedProducts*/
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

--How many products that do not have a product subcategory.
SELECT COUNT(*) as 'ProductCount'
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

--Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS TotalQuantity
FROM Production.ProductInventory;

--Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

--Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT Shelf, ProductID, SUM(Quantity) as TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 AND Shelf NOT LIKE 'N/A'
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;

--Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE LocationID = 10;

-- Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf;

--Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf  NOT LIKE 'N/A'
GROUP BY ProductID, Shelf

--List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--JOIN

-- Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

-- Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada');

--NorthWind Database

-- List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductName
FROM Products p INNER JOIN [Order Details] od  ON p.ProductID = od.ProductID
JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(year, -25, GETDATE())

--List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) as TotalQuantity
FROM [Order Details] od INNER JOIN Orders o ON od.OrderID = o.OrderID 
GROUP BY ShipPostalCode
ORDER BY TotalQuantity DESC

--List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) as TotalQuantity
FROM [Order Details] od INNER JOIN Orders o ON od.OrderID = o.OrderID 
WHERE o.OrderDate >= DATEADD(year, -25, GETDATE())
GROUP BY ShipPostalCode
ORDER BY TotalQuantity DESC

--List all city names and number of customers in that city.     
SELECT City, COUNT(*) as CustomerCount
FROM Customers
GROUP BY City

--List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(*) as CustomerCount
FROM Customers
GROUP BY City
HAVING COUNT(*) > 2

--List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.ContactName, o.OrderDate
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'

--  List the names of all customers with most recent order dates
SELECT C.ContactName, MAX(O.OrderDate) as RecentOrderDate
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.ContactName
ORDER BY RecentOrderDate DESC

--Display the names of all customers  along with the  count of products they bought
SELECT C.ContactName, COUNT(O.OrderID) as ProductCount
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID
INNER JOIN [Order Details] Od ON O.OrderID = Od.OrderID
GROUP BY C.ContactName

--Display the customer ids who bought more than 100 Products with count of products.
SELECT O.CustomerID, COUNT(Od.ProductID) as ProductCount
FROM Orders O INNER JOIN [Order Details] Od ON O.OrderID = Od.OrderID
GROUP BY O.CustomerID
HAVING COUNT(Od.ProductID) > 100

--List all of the possible ways that suppliers can ship their products. Display the results as below
SELECT Su.CompanyName as [Supplier Company Name], Sh.CompanyName as [Shipping Company Name]
FROM Suppliers su JOIN Shippers sh ON Su.SupplierID = Sh.ShipperID

--Display the products order each day. Show Order date and Product Name.
SELECT O.OrderDate, P.ProductName
FROM Orders O INNER JOIN [Order Details] Od ON O.OrderID = Od.OrderID
INNER JOIN Products p ON Od.ProductID = P.ProductID
ORDER BY O.OrderDate

--Displays pairs of employees who have the same job title.
SELECT e1.EmployeeID, e1.Title, e2.EmployeeID, e2.Title
FROM Employees e1 INNER JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID
ORDER BY e1.Title

--Display all the Managers who have more than 2 employees reporting to them.
SELECT e1.FirstName + ' ' + e1.LastName AS ManagerName, COUNT(*) AS NumberOfEmployees
FROM Employees e1 INNER JOIN Employees e2 ON e1.EmployeeID = e2.ReportsTo
GROUP BY e1.FirstName, e1.LastName
HAVING COUNT(*) > 2

--Display the customers and suppliers by city. The results should have the following columns
SELECT City, CompanyName AS Name, ContactName, 'Customer' AS Type
FROM Customers
UNION ALL
SELECT City, CompanyName, ContactName, 'Supplier' AS Type
FROM Suppliers
ORDER BY City, Name

































