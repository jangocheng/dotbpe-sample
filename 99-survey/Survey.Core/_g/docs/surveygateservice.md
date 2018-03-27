SurveyGateService
--------------------------
	问卷服务
	
## 1. Service Definition


### 1.1 SurveyGateService.SaveQPaper 
> 10000.11 
> 保存问卷
我是第二行的注释  


#### HTTP调用
+ **接口地址** : /api/qpaper/save  
+ **接口说明** : 保存问卷信息  
+ **请求方式** : POST  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.1.1 Request


[SaveQPaperReq]  保存问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |



#### 1.1.2 Response



[SaveQPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |


### 1.2 SurveyGateService.QueryQPaperList 
> 10000.12 
> 获取问卷列表  


#### HTTP调用
+ **接口地址** : /api/qpaper/query  
+ **接口说明** : 查询列表  
+ **请求方式** : ALL  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.2.1 Request


[QueryQPaperReq]  查询问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |



#### 1.2.2 Response



[QPaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |


### 1.3 SurveyGateService.GetQPaper 
> 10000.13 
> 获取问卷详情  


#### HTTP调用
+ **接口地址** : /api/qpaper/simple  
+ **接口说明** : 获取问卷信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.3.1 Request


[GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 1.3.2 Response



[QPaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |


### 1.4 SurveyGateService.GetQPaperFull 
> 10000.14 
> 获取问卷完整消息  


#### HTTP调用
+ **接口地址** : /api/qpaper/get  
+ **接口说明** : 获取问卷详情信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.4.1 Request


[GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 1.4.2 Response



### 1.5 SurveyGateService.SaveAPaper 
> 10000.21 
> 保存问卷  


#### HTTP调用
+ **接口地址** : /api/apaper/save  
+ **接口说明** : 保存答卷信息  
+ **请求方式** : POST  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.5.1 Request


[SaveAPaperReq]  什么字段都没有，请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |



#### 1.5.2 Response



[SaveAPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |


### 1.6 SurveyGateService.QueryAPaperList 
> 10000.22 
> 获取答卷列表  


#### HTTP调用
+ **接口地址** : /api/apaper/query  
+ **接口说明** : 查询答卷信息  
+ **请求方式** : ALL  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.6.1 Request


[QueryAPaperReq]  查询问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qtext  |  string  |  主题 模糊搜索  |   qtext   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  page  |  int32  |  分页索引  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |
|  check_role  |  bool  |  检查角色  |   checkRole   |



#### 1.6.2 Response



[APaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |


### 1.7 SurveyGateService.GetAPaper 
> 10000.23 
> 获取答卷消息  


#### HTTP调用
+ **接口地址** : /api/apaper/get  
+ **接口说明** : 获取答卷信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.7.1 Request


[GetAPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |



#### 1.7.2 Response



[APaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |


### 1.8 SurveyGateService.GetAPaperSta 
> 10000.24 
> 获取答卷统计  


#### HTTP调用
+ **接口地址** : /api/qpaper/sta  
+ **接口说明** : 获取问卷统计信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.8.1 Request


[GetQPaperStaReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |



#### 1.8.2 Response



[QPaperStaRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |




## 2. Message Definition

### <span id="saveqpaperreq">SaveQPaperReq</span> 
> 保存问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |

### <span id="saveqpaperrsp">SaveQPaperRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |

### <span id="queryqpaperreq">QueryQPaperReq</span> 
> 查询问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |

### <span id="qpaperlistrsp">QPaperListRsp</span> 
> 查询问卷的列表  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |

### <span id="getqpaperreq">GetQPaperReq</span> 
> 获取单个问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |

### <span id="qpaperrsp">QPaperRsp</span> 
> 包括单个问卷信息的响应  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |

### <span id="saveapaperreq">SaveAPaperReq</span> 
> 什么字段都没有，请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |

### <span id="saveapaperrsp">SaveAPaperRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |

### <span id="queryapaperreq">QueryAPaperReq</span> 
> 查询问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qtext  |  string  |  主题 模糊搜索  |   qtext   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  page  |  int32  |  分页索引  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |
|  check_role  |  bool  |  检查角色  |   checkRole   |

### <span id="apaperlistrsp">APaperListRsp</span> 
> 查询问卷的列表  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |

### <span id="getapaperreq">GetAPaperReq</span> 
> 获取单个问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |

### <span id="apaperrsp">APaperRsp</span> 
> 包括单个问卷信息的响应  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |

### <span id="getqpaperstareq">GetQPaperStaReq</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |

### <span id="qpaperstarsp">QPaperStaRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |
