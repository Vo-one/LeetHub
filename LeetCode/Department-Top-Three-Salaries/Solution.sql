# Write your MySQL query statement below
select d.name as Department, t.name as Employee, salary as Salary
from (
    select *,
    DENSE_RANK() OVER (partition by departmentId ORDER BY salary DESC) AS RankBySalary 
    from Employee e
) t
join Department d on t.departmentId = d.id
where t.RankBySalary <= 3
