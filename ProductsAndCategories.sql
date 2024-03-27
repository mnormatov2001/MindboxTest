-- ������� ���������
CREATE TABLE Products (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    OtherData TEXT
);

-- ������� ���������
CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    OtherData TEXT
);

-- ������� ��� ����� ��������� � ��������� (��������� ������ �� ������)
CREATE TABLE ProductCategory (
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

-- ������ ��� ������ ���� ��� ���� �������� � ��� ���������
SELECT p.Name AS '��� ��������', ISNULL(c.Name, '-') AS '��� ���������'
FROM Products p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;