# !/bin/bash
echo '开始启动docker-compose'
#启动服务 bash docker-compose-mongodb.sh     sh docker-compose-mongodb.sh
docker-compose -f docker-compose-mongodb.yml up -d

#停止服务
#docker-compose -f docker-compose.yml stop

#停止并删除服务
#docker-compose -f docker-compose.yml down
echo '启动完成'

