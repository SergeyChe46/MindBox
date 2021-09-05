SELECT Products.Name, Caregories.Name
FROM Products, Categories
WHERE Products.CategoryId = Categories.Id
