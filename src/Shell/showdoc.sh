# !/bin/bash
echo '开始启动baget'
# 原版官方镜像安装命令(中国大陆用户不建议直接使用原版镜像，可以用后面的加速镜像)
docker pull star7th/showdoc 

# 中国大陆镜像安装命令（安装后记得执行docker tag命令以进行重命名）
# docker pull registry.cn-shenzhen.aliyuncs.com/star7th/showdoc
# docker tag registry.cn-shenzhen.aliyuncs.com/star7th/showdoc:latest star7th/showdoc:latest 

##后续命令无论使用官方镜像还是加速镜像都需要执行

#新建存放showdoc数据的目录
mkdir -p /showdoc_data/html
chmod  -R 777 /showdoc_data
# 如果你是想把数据挂载到其他目录，比如说/data1，那么，可以在/data1目录下新建一个showdoc_data/目录，
# 然后在根目录的新建一个软链接/showdoc_data到/data1/showdoc_data
# 这样既能保持跟官方教程推荐的路径一致，又能达到自定义存储的目的.
# 根据以上命令操作的话，往后showdoc的数据都会存放在 /showdoc_data/html 目录下。
# 你可以打开 http://localhost:4999 来访问showdoc (localhost可改为你的服务器域名或者IP)。账户密码是showdoc/123456，登录后你便可以看到右上方的管理后台入口。建议登录后修改密码。
#启动showdoc容器
docker run -d --name showdoc --user=root --privileged=true -p 4999:80 \
-v /showdoc_data/html:/var/www/html/ star7th/showdoc
echo '启动完成'

 