USE BaiTapMVCDB;
GO

-- ==========================
-- BÀI 1
-- ==========================

CREATE TABLE NgayTrongTuan
(
    DayNumber INT PRIMARY KEY,
    DayName NVARCHAR(30) NOT NULL,
    IsWeekend BIT NOT NULL
);
GO

INSERT INTO NgayTrongTuan(DayNumber, DayName, IsWeekend)
VALUES
(0, N'Chủ nhật', 1),
(1, N'Thứ hai', 0),
(2, N'Thứ ba', 0),
(3, N'Thứ tư', 0),
(4, N'Thứ năm', 0),
(5, N'Thứ sáu', 0),
(6, N'Thứ bảy', 1);
GO


-- ==========================
-- BÀI 2
-- ==========================

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);
GO

INSERT INTO Products(Name, Price)
VALUES
(N'Laptop Dell', 15000000),
(N'Chuột Logitech', 500000),
(N'Bàn phím cơ', 1200000),
(N'Màn hình Samsung', 4500000),
(N'Tai nghe Bluetooth', 800000);
GO