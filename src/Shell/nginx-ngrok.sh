# !/bin/bash
echo '开始启动nginx'
#docker run -d -p 8080:80 --name mynginx nginx
#docker run -d -p 3000:4040  -e NGROK_AUTH=24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp --link mynginx --name myngrok wernight/ngrok ngrok http mynginx:80
#docker run -d -p 3000:4040   --link mynginx --name myngrok wernight/ngrok ngrok http mynginx:80 #--authtoken 24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp 
#docker run -e NGROK_AUTHTOKEN=24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp -d -p 3000:4040 ngrok/ngrok http 8080
docker network create pkngroknet
docker run -d -p 6379:6379 --net pkngroknet --name myredis redis
docker run -d -p 4040:4040 --net pkngroknet --name ngrok -e NGROK_PROTOCOL="TCP" -e NGROK_AUTH="24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp" -e NGROK_PORT="myredis:6379" wernight/ngrok 
echo '启动完成'

