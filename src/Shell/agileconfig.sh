# !/bin/bash
echo '开始启动AgileConfig'
docker run -d --name agile_config -e adminConsole=true -e db:provider=sqlite -e db:conn="Data Source=agile_config.db" -p 8011:5000 kklldog/agile_config:latest 
#用户名：admin 密码：123456
echo '启动完成'

