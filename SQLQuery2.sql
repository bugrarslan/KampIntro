--Select
--ANSII
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where categoryId = 1 or categoryId = 3

select * from Products where categoryId = 1 and UnitPrice >= 10

select * from Products where categoryId = 1 order by UnitPrice Desc     --ascending/artan    --descending/düşen

select count(*) Adet from Products 

select categoryID, count(*)  from products where UnitPrice > 20 
group by CategoryID having count(*) < 10

select  Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

--DTO Data transformation object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

