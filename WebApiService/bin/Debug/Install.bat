@echo off
echo 安装windows 服务
echo %cd%
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe %cd%\WebApiService.exe
echo 设置动态库路径
setx path "%path%;%cd%\ybhj;%cd%\bjq" /m
net start webapiservice
pause