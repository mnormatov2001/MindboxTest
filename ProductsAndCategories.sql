-- Таблица продуктов
CREATE TABLE Products (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    OtherData TEXT
);

-- Таблица категорий
CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    OtherData TEXT
);

-- Таблица для связи продуктов и категорий (отношение многие ко многим)
CREATE TABLE ProductCategory (
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

-- запрос для выбора всех пар «Имя продукта – Имя категории»
SELECT p.Name AS 'Имя продукта', ISNULL(c.Name, '-') AS 'Имя категории'
FROM Products p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;
