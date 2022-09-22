# !/bin/bash
echo '开始启动Yearning'
yum install git
git clone https://github.com/cookieY/Yearning.git ##没有git的需自行安装 yum install git
#进入install/yearning-docker-compose目录，然后启动即可：
cd Yearning/install/yearning-docker-compose
docker-compose up -d
#docker run -d --link=some-mysql -it -p8000:8000 -e MYSQL_USER=root -e MYSQL_ADDR=some-mysql:3306 -e MYSQL_PASSWORD=123456 -e MYSQL_DB=yearning   zhangsean/yearning
echo '启动完成'

