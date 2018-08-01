-- Mendapatkan single path dari sebuah node
SELECT p1.name as lv1, p2.name as lvl2, p3.name as lvl3, p4.name as lvl4, p5.name as lvl5, p6.name as lvl6  , p7.name as lvl7  , p8.name as lvl8  , p9.name as lvl9 
FROM person p1
LEFT JOIN person p2 ON p1.id = p2.parent_id
LEFT JOIN person p3 ON p2.id = p3.parent_id
LEFT JOIN person p4 ON p3.id = p4.parent_id
LEFT JOIN person p5 ON p4.id = p5.parent_id
LEFT JOIN person p6 ON p5.id = p6.parent_id
LEFT JOIN person p7 ON p6.id = p7.parent_id
LEFT JOIN person p8 ON p7.id = p8.parent_id
LEFT JOIN person p9 ON p8.id = p9.parent_id
WHERE p1.id = 1 AND p9.name LIKE 'Lalu bin Dani'
