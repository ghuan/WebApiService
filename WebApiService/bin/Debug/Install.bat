@echo off
echo ��װwindows ����
echo %cd%
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe %cd%\WebApiService.exe
echo ���ö�̬��·��
setx path "%path%;%cd%\ybhj;%cd%\bjq" /m
net start webapiservice
pause