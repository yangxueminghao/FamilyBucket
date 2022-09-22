# !/bin/bash
echo '开始启动smtp4dev'
docker run -d -p 3000:80 -p 2525:25 rnwood/smtp4dev
echo '启动完成'

