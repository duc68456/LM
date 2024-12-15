-- Tạo cơ sở dữ liệu
CREATE DATABASE LibraryDB;

-- Sử dụng cơ sở dữ liệu vừa tạo
USE LibraryDB;

-- Tạo bảng Books
CREATE TABLE Books (
    BookId INT IDENTITY(1,1) PRIMARY KEY, -- Mã sách, tự tăng bắt đầu từ 1, tăng dần 1
    Title NVARCHAR(255) NOT NULL,         -- Tên sách
    Author NVARCHAR(255),                 -- Tác giả
    Category NVARCHAR(100)                -- Thể loại
);
DELETE FROM Books
DROP TABLE Books

-- Tạo bảng Readers
CREATE TABLE Readers (
    ReaderId INT IDENTITY(1,1) PRIMARY KEY,      -- Mã độc giả, khóa chính
    Name NVARCHAR(255) NOT NULL,   -- Tên độc giả
    Gender NVARCHAR(50),           -- Giới tính
    IDNumber NVARCHAR(20) NOT NULL -- Số CCCD
);
DELETE FROM Readers
DROP TABLE Readers

CREATE TABLE Borrowings (
    BorrowingId INT IDENTITY(1,1) PRIMARY KEY,  -- Mã giao dịch, tự tăng
    ReaderId INT NOT NULL,                      -- Mã độc giả, tham chiếu bảng Readers
    BookId INT NOT NULL,                        -- Mã sách, tham chiếu bảng Books
    BorrowDate DATETIME NOT NULL,               -- Ngày mượn
    ReturnDate DATETIME NULL,                   -- Ngày trả (có thể null)
	FOREIGN KEY (ReaderId) REFERENCES Readers(ReaderId) ON DELETE CASCADE,
	FOREIGN KEY (BookId) REFERENCES Books(BookId) ON DELETE CASCADE
);
DELETE FROM Borrowings
DROP TABLE Borrowings

