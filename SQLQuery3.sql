
-- ProductID tutar
select ProductID ,
SUM(UnitPrice*(1.0- Discount)*Quantity) as "Kazanılan Toplam Miktar" 
from [Order Details] 
GROUP BY ProductID 

-- ProductName tutar
select Products.ProductName ,
SUM([Order Details].UnitPrice*(1.0- [Order Details].Discount)*[Order Details].Quantity) as "Kazanılan Toplam Miktar" 
from Products inner join [Order Details]
on Products.ProductID=[Order Details].ProductID inner join ORDERS 
on Orders.OrderID=[Order Details].OrderID
GROUP BY Products.ProductName order by  ProductName

-- Order toplam tutar
select OrderID ,SUM( UnitPrice*(1.0- Discount)*Quantity) as "Kazanılan Toplam Miktar"  from [Order Details] GROUP BY OrderID

--Yükleme Yeri bazında toplam tutar
select ShipName,
SUM([Order Details].UnitPrice*(1.0- [Order Details].Discount)*[Order Details].Quantity) as "Kazanılan Toplam Miktar" 
from [Order Details] inner join orders
on orders.OrderID=[Order Details].OrderID 
GROUP BY ShipName
