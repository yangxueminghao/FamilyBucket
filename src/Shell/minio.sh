# !/bin/bash
echo '开始启动minio'
docker run -p 9000:9000 -p 9001:9001 \
  -e "MINIO_ROOT_USER=AKIAIOSFODNN7EXAMPLE" \
  -e "MINIO_ROOT_PASSWORD=wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY" \
  minio/minio server /data --console-address ":9001"
echo '启动完成'

