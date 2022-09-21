# !/bin/bash
echo '开始启动smtp4dev'
docker run -p 3000:80 -p 2525:25 rnwood/smtp4dev:linux-amd64-3.1.0-ci0856
echo '启动完成'

