# !/bin/bash
echo '开始启动kafka'
docker pull wurstmeister/kafka
docker pull wurstmeister/zookeeper
docker pull sheepkiller/kafka-manager
docker run -d -t --name zookeeper -p 2181:2181 wurstmeister/zookeeper
docker run -d --name kafka -p 9092:9092 -e KAFKA_BROKER_ID=0 -e KAFKA_ZOOKEEPER_CONNECT=192.168.226.100:2181 -e KAFKA_ADVERTISED_LISTENERS=PLAINTEXT://192.168.226.100:9092 -e KAFKA_LISTENERS=PLAINTEXT://0.0.0.0:9092 -t wurstmeister/kafka
docker exec -it kafka /bin/bash
# /opt/kafka/bin/kafka-topics.sh --create --zookeeper 192.168.226.100:2181 --replication-factor 1 --partitions 1 --topic test_topic
# /opt/kafka/bin/kafka-console-consumer.sh --bootstrap-server 192.168.226.100:9092 --topic test_topic --from-beginning
# docker run -d --name kafka-manager -p 9000:9000 --link zookeeper:zookeeper --link kafka:kafka --env ZK_HOSTS=zookeeper:2181 sheepkiller/kafka-manager
echo '启动完成'

