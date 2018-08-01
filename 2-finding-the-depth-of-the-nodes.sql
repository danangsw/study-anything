SELECT node.id, node.name, (count(parent.name) - 1) lvl
FROM personNested AS node,
        personNested AS parent
WHERE node.l_container BETWEEN parent.l_container AND parent.r_container
GROUP BY node.name, node.l_container, node.id
ORDER BY node.l_container;
