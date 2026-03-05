1# Write your MySQL query statement below
2select d.name as Department, e.name as Employee, e.salary as Salary 
3from Employee e
4join (
5    select departmentId, max(salary) as salary
6    from Employee
7    group by departmentId
8) t
9on e.departmentId = t.departmentId 
10and e.salary = t.salary
11join Department d
12on d.id = e.departmentId 