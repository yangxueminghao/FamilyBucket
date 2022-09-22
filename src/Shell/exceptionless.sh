# !/bin/bash
echo '开始启动exceptionless'
docker run -d --name exceptionless1 -p 6002:80  exceptionless/exceptionless
echo '启动完成'

