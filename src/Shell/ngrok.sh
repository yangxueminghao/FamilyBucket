# !/bin/bash
echo '开始启动ngrok'
docker run --net=host -e NGROK_AUTHTOKEN=24m3m9usXH4U2KSdbWE7fZTwkvm_3MSyexVzL8dY3VukYkeBp -it ngrok/ngrok tcp 3306
echo '启动完成'