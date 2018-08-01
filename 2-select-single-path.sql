select parent.name
from personNested node, personNested parent
where node.l_container between parent.l_container and parent.r_container
and node.id = 22
order by node.l_container
