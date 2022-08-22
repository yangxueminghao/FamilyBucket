# !/bin/bash
echo '开始启动rabbitMq'
#docker run -d --hostname my-vhost --name rabbit -e RABBITMQ_DEFAULT_USER=admin -e RABBITMQ_DEFAULT_PASS=admin -p 15672:15672  -p  5672:5672 -p 25672:25672  -p 61613:61613 -p 1883:1883 rabbitmq:management
#rabbitmq-plugins enable rabbitmq_delayed_message_exchange
docker run -d --hostname my-vhost -v /root/rabbitmq/plugins: --name rabbit -e RABBITMQ_DEFAULT_USER=admin -e RABBITMQ_DEFAULT_PASS=admin -p 15672:15672  -p  5672:5672 -p 25672:25672  -p 61613:61613 -p 1883:1883 rabbitmq:management
echo '启动完成'