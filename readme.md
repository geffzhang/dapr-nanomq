# Dapr 和 Nanomq PubSub

[NanoMQ](https://nanomq.io/)是于2020年7月开始开发的边缘计算开源项目，是面向物联网边缘计算场景的下一代轻量级高性能**MQTT**消息服务器。

Github仓库地址: https://github.com/emqx/nanomq

Dapr 1.7 的 MQTT pubsub 正式Stable发布，本项目 用Dapr 的 Pubsub 服务，采用 MQTT 协议应用于物联网端， MQTT Broker 选用[Nanomq 0.66 LTS](https://www.emqx.com/zh/blog/nanomq-newsletter-202203)。

Docker 部署
docker run -d -p 1883:1883 -p 8883:8883 --name nanomq nanomq/nanomq:0.6.6 


