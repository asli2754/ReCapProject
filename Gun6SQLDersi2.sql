select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice >10

--Tablo isminde boşluk olduğunda köşeli parantez kullan!
select * from Products p inner join [Order Details]od
on p.ProductID = od.ProductID 

select * from [Order Details]

select * from Products p left join [Order Details]od
on p.ProductID = od.ProductID 

select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

--solda olup sağda olmayanları da getir.
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- bu müşteriler bizden ürün almamış.


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join orders o
on o.OrderID = od.OrderID