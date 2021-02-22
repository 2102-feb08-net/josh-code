
CREATE SCHEMA VirtualPhoneStore;
GO

CREATE TABLE Products(
    ProductID INT IDENTITY, 
    ProductName  NVARCHAR(50) NOT NULL CHECK(LEN(ProductName) > 1),
    ProductPrice INT NOT NULL
CONSTRAINT Product_PK PRIMARY KEY(ProductID)
);

CREATE TABLE Customers(
    CustomerID INT IDENTITY,
    FirstName NVARCHAR(50) NOT NULL CHECK(LEN(FirstName) > 1),
    LastName NVARCHAR(50),
    CardNumber INT NOT NULL
CONSTRAINT Customers_PK PRIMARY KEY(CustomerID)
);

CREATE TABLE Orders(
    OrdersID INT IDENTITY,
    CustomerID INT NOT NULL,
    ProductID INT NOT NULL
CONSTRAINT Orders_PK PRIMARY KEY(OrdersID)
CONSTRAINT Customers_FK FOREIGN KEY(CustomerID)
REFERENCES Customers(CustomerID),
CONSTRAINT Product_FK FOREIGN KEY(ProductID)
REFERENCES Products(ProductID)
);

-- Values for Product Table
INSERT INTO Products VALUES ('Samsung Galaxy 2000TB', 200);
INSERT INTO Products VALUES ('Samsung Universe 3000TF', 300);
INSERT INTO Products VALUES ('iPhone XML', 1000);

-- Values for Orders Details Table
INSERT INTO Customers VALUES ('John', 'Hancok', 38);
INSERT INTO Customers VALUES ('George', 'Wershington', 47);
INSERT INTO Customers VALUES ('James', 'NotBond', 007);

-- Values for Orders Table
INSERT INTO Orders VALUES (1, 1);
INSERT INTO Orders VALUES (1, 2);
INSERT INTO Orders VALUES (3, 2);
INSERT INTO Orders VALUES (2, 3);

-- DML Exercises
-- Exercise 1
INSERT INTO Products VALUES ('iPhone', 200);

-- Exercise 2
INSERT INTO Customers VALUES ('Tina', 'Smith', 445566);

-- Exercise 3
INSERT INTO Orders VALUES ((SELECT Customers.CustomerID 
                            FROM Customers 
                            WHERE Customers.FirstName = 'Tina' 
                            AND Customers.LastName = 'Smith'), (SELECT Products.ProductID
                                                                FROM Products
                                                                WHERE Products.ProductName = 'iPhone'));

-- Exercise 4
SELECT Orders.*
FROM Orders
WHERE Orders.CustomerID = (SELECT Customers.CustomerID 
                            FROM Customers 
                            WHERE Customers.FirstName = 'Tina' 
                            AND Customers.LastName = 'Smith');

-- Exercise 5


-- Exercise 6
