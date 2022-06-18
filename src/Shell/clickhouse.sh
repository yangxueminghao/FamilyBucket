# !/bin/bash
echo '开始启动zookeeper'
docker run -d -p 2181:2181 -p 2888:2888 -p 3888:3888 --name zookeeper_node --restart always \
-v /usr/soft/zookeeper/data:/data \
-v /usr/soft/zookeeper/datalog:/datalog \
-v /usr/soft/zookeeper/logs:/logs \
-v /usr/soft/zookeeper/conf:/conf \
--network host  \
-e ZOO_MY_ID=1  zookeeper
echo '启动完成'

