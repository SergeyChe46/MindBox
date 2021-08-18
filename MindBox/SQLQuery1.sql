SELECT *
FROM Product
LEFT JOIN Category
ON Products.Id = Category.Id
