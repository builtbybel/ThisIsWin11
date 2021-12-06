###This script will reinstall all built-in modern apps in a single step. ###
###This command will take a few moments and will reinstall all built-in apps. If you receive any error message, ignore it. You may need to restart the computer to take effect.
Get-AppxPackage -allusers | foreach {Add-AppxPackage -register "$($_.InstallLocation)\appxmanifest.xml" -DisableDevelopmentMode}