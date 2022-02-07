# !/bin/bash
echo '开始启动ngrok'
docker run --net=host -it ngrok/ngrok tcp --authtoken=24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp 3306
#docker run --net=host -e NGROK_AUTHTOKEN=24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp -it ngrok/ngrok tcp 3306
#docker run -it -v $(pwd)/ngrok.yml:/etc/ngrok.yml -e NGROK_CONFIG=/etc/ngrok.yml ngrok/ngrok:alpine http 80
echo '启动完成'