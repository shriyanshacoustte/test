-- Sample usage of the mylist table
-- This script demonstrates how to insert and query data from the mylist table

-- Insert sample data
INSERT INTO mylist (item_name) VALUES 
    ('Buy groceries'),
    ('Complete project documentation'),
    ('Schedule team meeting');

-- Query all items
SELECT * FROM mylist ORDER BY created_at DESC;

-- Query specific item
SELECT id, item_name, created_at 
FROM mylist 
WHERE item_name LIKE '%project%';

-- Get count of items
SELECT COUNT(*) as total_items FROM mylist;