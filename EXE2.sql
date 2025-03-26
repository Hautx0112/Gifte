CREATE DATABASE GiftShopDB;
USE GiftShopDB;

-- Bảng người dùng (UserAccount)
CREATE TABLE UserAccount (
    UserAccountID INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL,
    Phone NVARCHAR(50) NOT NULL,
    EmployeeCode NVARCHAR(50) NOT NULL,
    RoleId INT NOT NULL,
    RequestCode NVARCHAR(50) NULL,
    CreatedDate DATETIME NULL DEFAULT GETDATE(),
    ApplicationCode NVARCHAR(50) NULL,
    CreatedBy NVARCHAR(50) NULL,
    ModifiedDate DATETIME NULL,
    ModifiedBy NVARCHAR(50) NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

-- Bảng sản phẩm (Products)
CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    ImageURL NVARCHAR(255),
    Category NVARCHAR(50),
    Stock INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Bảng giỏ hàng (Cart)
CREATE TABLE Cart (
    CartId INT PRIMARY KEY IDENTITY(1,1),
    UserAccountID INT,
    ProductId INT,
    Quantity INT CHECK (Quantity > 0),
    AddedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserAccountID) REFERENCES UserAccount(UserAccountID),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

-- Bảng đơn hàng (Orders)
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    UserAccountID INT,
    TotalPrice DECIMAL(10, 2),
    DeliveryAddress NVARCHAR(MAX),
    PaymentStatus NVARCHAR(50) DEFAULT 'Pending',
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserAccountID) REFERENCES UserAccount(UserAccountID)
);

-- Bảng chi tiết đơn hàng (OrderDetails)
CREATE TABLE OrderDetails (
    OrderDetailId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT,
    ProductId INT,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

-- Bảng thanh toán (Payments)
CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT,
    PaymentMethod NVARCHAR(50),
    Amount DECIMAL(10, 2),
    PaymentDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);

-- Bảng yêu thích (Favorites)
CREATE TABLE Favorites (
    FavoriteId INT PRIMARY KEY IDENTITY(1,1),
    UserAccountID INT,
    ProductId INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserAccountID) REFERENCES UserAccount(UserAccountID),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

-- Bảng tùy chỉnh sản phẩm (Customizations)
CREATE TABLE Customizations (
    CustomizationId INT PRIMARY KEY IDENTITY(1,1),
    OrderDetailId INT,
    CustomText NVARCHAR(MAX),
    ImageURL NVARCHAR(255),
    FOREIGN KEY (OrderDetailId) REFERENCES OrderDetails(OrderDetailId)
);
