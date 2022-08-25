version: '3'
services:
  apollo-configservice:
    image: apolloconfig/apollo-configservice
    container_name: apollo-configservice
    ports:
      - "8080:8080"
    environment:     
      JAVA_OPTS: "-Deureka.instance.homePageUrl=http://192.168.192.130:8080"
      SPRING_DATASOURCE_URL: 'jdbc:mysql://192.168.192.129:3306/ApolloConfigDB?characterEncoding=utf8'
      SPRING_DATASOURCE_USERNAME: 'root'
      SPRING_DATASOURCE_PASSWORD: '123456'    

  apollo-adminservice:
    image: apolloconfig/apollo-adminservice
    container_name: apollo-adminservice
    ports:
      - "8090:8090"    
    environment:      
      JAVA_OPTS: "-Deureka.instance.homePageUrl=http://192.168.192.130:8090"
      SPRING_DATASOURCE_URL: 'jdbc:mysql://192.168.192.129:3306/ApolloConfigDB?characterEncoding=utf8'
      SPRING_DATASOURCE_USERNAME: 'root'
      SPRING_DATASOURCE_PASSWORD: '123456'   

  apollo-portal:
    image: apolloconfig/apollo-portal:1.7.0
    container_name: apollo-portal
    ports:
      - "8070:8070"   
    environment:      
      DS_URL: "jdbc:mysql://192.168.192.129:3306/ApolloPortalDB?characterEncoding=utf8"      
      DS_USERNAME: "root"     
      DS_PASSWORD: "123456"
      SERVER_SERVLET_CONTEXT_PATH: "/apollo"
    depends_on:
      - apollo-adminservice
##
##eureka.service.url	default	http://192.168.192.130:8080/eureka/	Eureka服务Url，多个service以英文逗号分隔	0	0	default	2022-08-22 17:15:09		2022-08-25 13:43:22
##查看docker网关 ifconfig
##查看容器的ip
#docker inspect 容器ID
##添加ip段或者ip到白名单
##firewall-cmd  --zone=trusted --add-source=172.17.0.1/16 --permanent
##firewall-cmd --reload
##修改好配置文件后依次启动

#apollo-portal/config/apollo-env.properties  dev.meta: http://192.168.192.130:8080

##apollo-configservice:8080  查看startup.sh修改端口防止端口被占用

##apollo-portal:8070  

##apollo-adminservice：8090

##安装Apollo并解决报错问题

##用户名/密码：apollo/admin