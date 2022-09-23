# !/bin/bash
echo '开始启动Yearning'
yum install git
git clone https://github.com/cookieY/Yearning.git ##没有git的需自行安装 yum install git
#进入install/yearning-docker-compose目录，然后启动即可：
cd Yearning/install/yearning-docker-compose
docker-compose up -d
#docker run -d --link=some-mysql -it -p8000:8000 -e MYSQL_USER=root -e MYSQL_ADDR=some-mysql:3306 -e MYSQL_PASSWORD=123456 -e MYSQL_DB=yearning   zhangsean/yearning
#docker exec -it 102 /bin/sh
#CMD ["/bin/sh"] ./Yearning install
#docker run -d -it  -p8000:8000 --link=some-mysql -e IS_DOCKER=is_docker -e SECRET_KEY=dbcjqheupqjsuwsm  -e MYSQL_USER=root -e MYSQL_ADDR=some-mysql:3306 -e MYSQL_PASSWORD=123456  -e MYSQL_DB=Yearning chaiyd/yearning
# 默认账号：admin，默认密码：Yearning_admin  全部设置保存
# 页面左侧
# 工单信息填写，其中数据库，工单说明为必填。
# 当选择对应数据表之后点击获取表结构按钮将会展示该数据表字段及索引信息
# 定时执行 该功能依赖Yearning所部署服务器上本地时间，请将服务器时间与本地使用时间保持一致，否则将会出现错误。同时，由于Yearning并未依赖其他第三方定时服务，如在定时执行时间之前Yearning崩溃/重启将会丢失定时信息导致工单无法执行。
# 当是否回滚选项选择为 是 时，该工单提交的SQL语句执行时如果该数据库开启binlog则会自动生成对应的回滚语句并保存。
# 页面右侧
# # 右上SQL编辑框 请将需要提交的SQL语句填写入该编辑框内，鼠标右键菜单中选择 SQL检测 按钮进行SQL语句检测或通过 SQL美化 按钮进行SQL语句美化
# 右下审核结果区域 当点击 SQL检测 按钮后该区域将会展示该SQL语句的检测结果。
# TIP

# 当焦点处于编辑器中时，可以采用Ctrl/Cmd + E 快捷键触发SQL检测
# 当焦点处于编辑器中时，可以采用Ctrl/Cmd + B 快捷键触发SQL美化
# 同时该编辑器支持常用文本快捷键
# 提交按钮只有在检测语句 错误等级 均为0时才会激活
echo '启动完成'

