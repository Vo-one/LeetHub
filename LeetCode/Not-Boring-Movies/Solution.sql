1# Write your MySQL query statement below
2select *
3from Cinema
4where id % 2 = 1
5and description not like 'boring'
6order by rating  desc;