# !/bin/bash 
echo '开始启动grafana'
docker run -d --name=grafana -p 3000:3000 grafana/grafana
echo '启动完成'
# admin/admin ngrok.exe tcp 192.168.192.129:3306

