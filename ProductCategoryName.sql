--Используем CategoryID в таблице Categories, 
--тк у нас может быть больше одной строки по одной категории,
--и PrimaryKey вероятно будет RowID
SELECT p.ProductName, c.CategoryName 
FROM Products p
LEFT JOIN Categories c ON p.CategoryID = c.CategoryID
