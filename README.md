# WebApiService
使用OWIN托管webapi，windows服务承载 （.net framework4.0及以上）
应用场景：

服务使用c#加载各种动态链接库来处理事务，前端浏览器通过webapi请求得到结果，摒弃了另编写相应ocx控件，浏览器加载ocx控件来调用dll的传统方式。
实现了跨浏览器调用dll动态链接库
