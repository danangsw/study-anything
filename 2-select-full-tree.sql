select node.name 
from personNested node, personNested parent
where node.l_container BETWEEN parent.l_container AND parent.r_container
AND parent.id = 1
