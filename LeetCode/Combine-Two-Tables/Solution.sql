1SELECT 
2    p.firstName,
3    p.lastName,
4    a.city,
5    a.state
6FROM Person p
7LEFT JOIN Address a
8    ON p.personId = a.personId;