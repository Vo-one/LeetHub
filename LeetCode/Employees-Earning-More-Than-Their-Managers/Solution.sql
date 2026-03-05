1# Write your MySQL query statement below
2select e.name as Employee 
3from Employee e
4join Employee m on e.managerId = m.id
5where e.salary > m.salary