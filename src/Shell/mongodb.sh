# !/bin/bash
echo '开始启动mongo'
docker run -d --network some-network --name some-mongo \
    -e MONGO_INITDB_ROOT_USERNAME=mongoadmin \
    -e MONGO_INITDB_ROOT_PASSWORD=secret \
    mongo
echo '启动完成'

