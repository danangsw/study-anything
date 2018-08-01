-- Select semua leaf nodes di pohon keluarga (dimana node tersebut tidak memiliki anak) dengan mengunakan query LEFT JOIN.
SELECT p1.name as 'Leaf Node'
FROM person p1
LEFT JOIN person p2 ON p1.id = p2.parent_id
WHERE p2.id is null
