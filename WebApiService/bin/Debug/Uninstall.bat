@echo off
echo Ð¶ÔØwindows ·þÎñ
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u %cd%\WebApiService.exe
set "bb=;%cd%\ybhj;%cd%\bjq"
call set "aa=%%path:%bb%=%%"
setx path "%aa%" /m
pause