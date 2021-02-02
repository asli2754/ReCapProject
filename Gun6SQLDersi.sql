--Select
--ANSI standardı
  select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

  select * from Customers where city = 'Berlin'

  --case insensitive büyük küçük harf duyarsız sql kodları
  select * from Products where CategoryID = 1 or CategoryID=3

  select * from Products where CategoryID=1 and UnitPrice >=10
  --where filtreleme için kullanılır.

  select * from Products order by CategoryID, ProductName

   select * from Products order by UnitPrice desc -- azalaarak sıralar
   --order by sıralama için kullanılır.
   select * from Products where CategoryID=1 order by UnitPrice desc --

   select count(*) from Products -- Product tablosundaki dataların sayısını veriyor.

   select count(*) from Products where CategoryId = 2

   select count(*) Adet from Products where CategoryId = 2

   --hangi kategoride kaç farklı ID var
   select count(*) Adet from Products

   select CategoryID, count(*) from Products group by CategoryID

   --ürün sayısı 10'dan az olan kategorileri listele
   select CategoryID, count(*) from Products group by CategoryID having count(*)<10

   --önce her zaman where çalışır.
    select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10





