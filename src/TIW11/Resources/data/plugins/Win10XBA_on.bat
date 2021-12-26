@echo off
reg add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\BootControl" /v "BootAnimation" /t REG_DWORD /d 1 /f
