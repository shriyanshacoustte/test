# Database Schema

This directory contains SQL scripts for setting up the database schema.

## Tables

### mylist
A table to store list items with timestamps.

**Columns:**
- `id` (INT): Primary key with auto-increment (IDENTITY)
- `item_name` (NVARCHAR(100)): Name of the list item (NOT NULL)
- `created_at` (DATETIME): Creation timestamp (defaults to current date/time)

## Usage

To create the table in your Azure SQL Database, run:

```sql
-- Execute the create table script
@create_mylist_table.sql
```

Or copy and paste the contents of `create_mylist_table.sql` into your SQL management tool.