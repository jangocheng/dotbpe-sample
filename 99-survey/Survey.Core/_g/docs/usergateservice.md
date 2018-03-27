[UserGateService] 无说明
--------------------------
	
## 服务定义


### [10001.31] 注册 
> UserGateService.Register  
> 注册  


#### HTTP调用
+ **接口地址** : /api/user/register  
+ **接口说明** : 注册用户  
+ **请求方式** : POST  



#### 请求参数

> [RegisterReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  password  |  string  |  密码  |   password   |



#### 响应参数


> [RegisterRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  user_id  |  int32  |  新增的用户ID  |   userId   |


### [10001.32] 登录 
> UserGateService.Login  
> 登录  


#### HTTP调用
+ **接口地址** : /api/gate/login  
+ **接口说明** : 用户登录  
+ **请求方式** : POST  



#### 请求参数

> [LoginReq]  登录请求消息

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  password  |  string  |  密码  |   password   |



#### 响应参数


> [LoginRsp]  登录响应消息

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  is_admin  |  bool  |  是否管理员  |   isAdmin   |
|  bpe_session_id  |  string  |  登录成功后的sessionId  |   bpeSessionId   |


### [10001.33] 修改用户信息 
> UserGateService.EditUser  
> 修改用户信息  


#### HTTP调用
+ **接口地址** : /api/user/save  
+ **接口说明** : 保存修改的用户信息  
+ **请求方式** : POST  



#### 请求参数

> [EditUserReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  old_password  |  string  |  旧密码  |   oldPassword   |
|  new_password  |  string  |  新密码  |   newPassword   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 响应参数


> [EditUserRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |


### [10001.34] 获取用户信息 
> UserGateService.CheckLogin  
> 获取用户信息  


#### HTTP调用
+ **接口地址** : /api/gate/check  
+ **接口说明** : 获取用户信息  
+ **请求方式** : GET  



#### 请求参数

> [CheckLoginReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |



#### 响应参数


> [GetUserRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  is_admin  |  bool  |  是否管理员  |   isAdmin   |




## 相关消息定义

### <span id="registerreq">[RegisterReq]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  password  |  string  |  密码  |   password   |


### <span id="registerrsp">[RegisterRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  user_id  |  int32  |  新增的用户ID  |   userId   |


### <span id="loginreq">[LoginReq]</span> 登录请求消息
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  password  |  string  |  密码  |   password   |


### <span id="loginrsp">[LoginRsp]</span> 登录响应消息
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  is_admin  |  bool  |  是否管理员  |   isAdmin   |
|  bpe_session_id  |  string  |  登录成功后的sessionId  |   bpeSessionId   |


### <span id="edituserreq">[EditUserReq]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  old_password  |  string  |  旧密码  |   oldPassword   |
|  new_password  |  string  |  新密码  |   newPassword   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |


### <span id="edituserrsp">[EditUserRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |


### <span id="checkloginreq">[CheckLoginReq]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |


### <span id="getuserrsp">[GetUserRsp]</span> 
| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  account  |  string  |  账号  |   account   |
|  full_name  |  string  |  姓名  |   fullName   |
|  is_admin  |  bool  |  是否管理员  |   isAdmin   |

