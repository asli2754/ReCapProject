select * from Products

SELECT Products.ProductName AS UrunAdi,
SUM([Order Details].UnitPrice*[Order Details].Quantity) AS KazanilanToplamMiktar
from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID 
  inner join Orders
on Orders.OrderID = [Order Details].OrderID
group by ProductName
order by KazanilanToplamMiktar desc;

SELECT Products.ProductName AS Product  , 
SUM([Order Details].Quantity*Products.UnitPrice) AS TotalEarning 
FROM [Order Details] INNER JOIN Products
ON Products.ProductID=[Order Details].ProductID 
GROUP BY Products.ProductName
order by TotalEarning desc;

select ProductName as UrunAdi, sum((od.UnitPrice)*(od.Quantity)) as KazanilanToplamMiktar
from Products as p inner join [Order Details]  as od 

on  p.ProductID=od.ProductID

inner join Orders as o on od.OrderID=o.OrderID

group by ProductName
order by ProductName asc;