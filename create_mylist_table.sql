-- Create mylist table for Azure SQL Database
-- This script creates a table with the required columns and constraints

CREATE TABLE mylist (
    id INT IDENTITY(1,1) PRIMARY KEY,
    item_name NVARCHAR(100) NOT NULL,
    created_at DATETIME DEFAULT GETDATE()
);