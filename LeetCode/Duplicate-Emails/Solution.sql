1# Write your MySQL query statement below
2select email as Email
3from Person group by email
4having count(*) >1
5