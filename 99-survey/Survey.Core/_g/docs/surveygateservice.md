[SurveyGateService] 问卷服务
--------------------------
	问卷服务
## 服务定义


### [10000.11] 保存问卷 
> SurveyGateService.SaveQPaper  
> 保存问卷
我是第二行的注释  


#### HTTP调用
+ **接口地址** : /api/qpaper/save  
+ **接口说明** : 保存问卷信息  
+ **请求方式** : POST  



#### 请求参数

> [SaveQPaperReq]  保存问卷的请求

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



#### 响应参数


> [SaveQPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |


### [10000.12] 获取问卷列表 
> SurveyGateService.QueryQPaperList  
> 获取问卷列表  


#### HTTP调用
+ **接口地址** : /api/qpaper/query  
+ **接口说明** : 查询列表  
+ **请求方式** : ALL  



#### 请求参数

> [QueryQPaperReq]  查询问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |



#### 响应参数


> [QPaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |


### [10000.13] 获取问卷详情 
> SurveyGateService.GetQPaper  
> 获取问卷详情  


#### HTTP调用
+ **接口地址** : /api/qpaper/simple  
+ **接口说明** : 获取问卷信息  
+ **请求方式** : GET  



#### 请求参数

> [GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 响应参数


> [QPaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |


### [10000.14] 获取问卷完整消息 
> SurveyGateService.GetQPaperFull  
> 获取问卷完整消息  


#### HTTP调用
+ **接口地址** : /api/qpaper/get  
+ **接口说明** : 获取问卷详情信息  
+ **请求方式** : GET  



#### 请求参数

> [GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 响应参数


### [10000.21] 保存问卷 
> SurveyGateService.SaveAPaper  
> 保存问卷  


#### HTTP调用
+ **接口地址** : /api/apaper/save  
+ **接口说明** : 保存答卷信息  
+ **请求方式** : POST  



#### 请求参数

> [SaveAPaperReq]  什么字段都没有，请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |



#### 响应参数


> [SaveAPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |


### [10000.22] 获取答卷列表 
> SurveyGateService.QueryAPaperList  
> 获取答卷列表  


#### HTTP调用
+ **接口地址** : /api/apaper/query  
+ **接口说明** : 查询答卷信息  
+ **请求方式** : ALL  



#### 请求参数

> [QueryAPaperReq]  查询问卷的请求

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



#### 响应参数


> [APaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |


### [10000.23] 获取答卷消息 
> SurveyGateService.GetAPaper  
> 获取答卷消息  


#### HTTP调用
+ **接口地址** : /api/apaper/get  
+ **接口说明** : 获取答卷信息  
+ **请求方式** : GET  



#### 请求参数

> [GetAPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |



#### 响应参数


> [APaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |


### [10000.24] 获取答卷统计 
> SurveyGateService.GetAPaperSta  
> 获取答卷统计  


#### HTTP调用
+ **接口地址** : /api/qpaper/sta  
+ **接口说明** : 获取问卷统计信息  
+ **请求方式** : GET  



#### 请求参数

> [GetQPaperStaReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |



#### 响应参数


> [QPaperStaRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |




## 相关消息定义

### <span id="saveqpaperreq">[SaveQPaperReq]</span> 保存问卷的请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |


### <span id="saveqpaperrsp">[SaveQPaperRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |


### <span id="queryqpaperreq">[QueryQPaperReq]</span> 查询问卷的请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |


### <span id="qpaperlistrsp">[QPaperListRsp]</span> 查询问卷的列表
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |


### <span id="getqpaperreq">[GetQPaperReq]</span> 获取单个问卷的请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |


### <span id="qpaperrsp">[QPaperRsp]</span> 包括单个问卷信息的响应
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |


### <span id="saveapaperreq">[SaveAPaperReq]</span> 什么字段都没有，请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |


### <span id="saveapaperrsp">[SaveAPaperRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |


### <span id="queryapaperreq">[QueryAPaperReq]</span> 查询问卷的请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qtext  |  string  |  主题 模糊搜索  |   qtext   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  page  |  int32  |  分页索引  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |
|  check_role  |  bool  |  检查角色  |   checkRole   |


### <span id="apaperlistrsp">[APaperListRsp]</span> 查询问卷的列表
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |


### <span id="getapaperreq">[GetAPaperReq]</span> 获取单个问卷的请求
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |


### <span id="apaperrsp">[APaperRsp]</span> 包括单个问卷信息的响应
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |


### <span id="getqpaperstareq">[GetQPaperStaReq]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |


### <span id="qpaperstarsp">[QPaperStaRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |

