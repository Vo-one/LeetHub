1# Write your MySQL query statement below
2SELECT name
3FROM Customer
4WHERE referee_id IS NULL 
5   OR referee_id <> 2;