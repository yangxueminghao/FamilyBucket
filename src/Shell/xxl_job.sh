# !/bin/bash
echo '开始启动xxljob'
docker run -d --link=some-mysql --name xxl-job-admin -p 8020:8080 -e PARAMS="--spring.datasource.url=jdbc:mysql://some-mysql:3306/xxl_job?Unicode=true&characterEncoding=UTF-8 --spring.datasource.username=root --spring.datasource.password=123456" -v /usr/local/xxl-job/admin/logs:/data/applogs --privileged=true xuxueli/xxl-job-admin:2.3.0
#用户名：admin 密码：123456
echo '启动完成'

