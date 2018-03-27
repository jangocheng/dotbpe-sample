HTTP API 接口文档一览  
--------------------------  
## 1 接口说明  
### 1.1 公共参数  
	绝大多数接口中都包含公共参数，公共参数有App内置传递，公共参数如下所示 
|  字段名  |  类型  |  注释  |  
| ------------ | ------------ | ------------ |  
|  client_ip  |  string  |  用户端IP，服务自动获取，传递也无效   |  
|  identity  |  string  |  用户标识，服务自动获取，传递也无效  |  
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递，HEAD中传递X-REQUEST-ID 传递，不传则自动创建  |  


以上为DotBPE默认建议的公共参数，建议在接口入参定义，不同项目还需定义额外的公共参数，如手机App客户端项目，如下表格说是

|  字段名  |  类型  |  注释  |  
| ------------ | ------------ | ------------ |  
|  device_os  |  string  |  设备操作系统,例如ios9.3  |  
|  src_code  |  int32  |  客户端来源 4=Android 6 =h5 7=web 8=iso 11=window客户端  |  
|  app_version_code  |  int32  |  app版本（纯数字类型）  |  
|  device_manufacturer  |  string  |  设置制造商  |  
|  device_manuid  |  string  |  设备型号  |  
   


### 1.2 返回格式  
> 所有的http接口都包括固定的返回格式，如下所示 

```json
 {"returnCode": 0,"returnMessage": "success","data": {}} 
``` 

其中data 节点中的数据为返回的业务数据，调用者通过`return_code` 来判断是否调用正确 

##  2 服务一览表  


### 2.0 [SurveyGateService] 问卷服务
| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | SaveQPaper |  10000.11  |  /api/qpaper/save  |  保存问卷  |
| 2 | QueryQPaperList |  10000.12  |  /api/qpaper/query  |  获取问卷列表  |
| 3 | GetQPaper |  10000.13  |  /api/qpaper/simple  |  获取问卷详情  |
| 4 | GetQPaperFull |  10000.14  |  /api/qpaper/get  |  获取问卷完整消息  |
| 5 | SaveAPaper |  10000.21  |  /api/apaper/save  |  保存问卷  |
| 6 | QueryAPaperList |  10000.22  |  /api/apaper/query  |  获取答卷列表  |
| 7 | GetAPaper |  10000.23  |  /api/apaper/get  |  获取答卷消息  |
| 8 | GetAPaperSta |  10000.24  |  /api/qpaper/sta  |  获取答卷统计  |

### 2.1 [UserGateService] 无说明
| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | Register |  10001.31  |  /api/user/register  |  注册  |
| 2 | Login |  10001.32  |  /api/gate/login  |  登录  |
| 3 | EditUser |  10001.33  |  /api/user/save  |  修改用户信息  |
| 4 | CheckLogin |  10001.34  |  /api/gate/check  |  获取用户信息  |
