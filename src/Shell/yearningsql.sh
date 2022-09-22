# !/bin/bash
echo '开始启动Yearning'
yum install git
git clone https://github.com/cookieY/Yearning.git ##没有git的需自行安装 yum install git
#进入install/yearning-docker-compose目录，然后启动即可：
cd Yearning/install/yearning-docker-compose
docker-compose up -d
echo '启动完成'

