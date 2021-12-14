REG ADD "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" /V AutoAdminLogon /T REG_SZ /D 1 /F
REG ADD "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" /V DefaultUserName /T REG_SZ /D __USERNAME__ /F
REG ADD "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" /V DefaultPassword /T REG_SZ /D __PASSWORD__ /F