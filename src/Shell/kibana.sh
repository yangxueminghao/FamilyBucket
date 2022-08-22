# !/bin/bash
echo '开始启动kibana'
docker run -d --name kibana --net somenetwork -p 5601:5601 kibana:7.16.2
#docker run -d --name kibana --link=elasticsearch:elasticsearch somenetwork -p 5601:5601 kibana:7.16.2
echo '启动完成'

