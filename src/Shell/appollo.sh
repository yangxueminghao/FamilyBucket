# !/bin/bash
echo '开始启动appollo'
#分别启动配置服务、管理服务和web服务
docker run -d --name some-mysql2  -p 3307:3306 -e MYSQL_ROOT_PASSWORD=123456  mysql
#配置服务
docker run --net=host   -d -e SPRING_DATASOURCE_URL="jdbc:mysql://192.168.192.129:3307/ApolloConfigDB?characterEncoding=utf8&useSSL=false&allowPublicKeyRetrieval=true" -e SPRING_DATASOURCE_USERNAME=root -e SPRING_DATASOURCE_PASSWORD=123456 --name apollo-configservice apolloconfig/apollo-configservice
#管理服务
docker run --net=host  -d  -e SPRING_DATASOURCE_URL="jdbc:mysql://192.168.192.129:3307/ApolloConfigDB?characterEncoding=utf8&useSSL=false&allowPublicKeyRetrieval=true" -e SPRING_DATASOURCE_USERNAME=root -e SPRING_DATASOURCE_PASSWORD=123456  --name apollo-adminservice apolloconfig/apollo-adminservice
#web服务
docker run --net=host  -d  -e SPRING_DATASOURCE_URL="jdbc:mysql://192.168.192.129:3307/ApolloPortalDB?characterEncoding=utf8&useSSL=false&allowPublicKeyRetrieval=true" -e SPRING_DATASOURCE_USERNAME=root -e SPRING_DATASOURCE_PASSWORD=123456 --name apollo-portal  apolloconfig/apollo-portal
#用户名：apollo 密码：admin
echo '启动完成'

