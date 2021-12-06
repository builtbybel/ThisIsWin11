###This script allows you to remove unwanted Apps that come with Windows within a GUI. ###
###Press <CTRL> if you want to select and remove mutliple apps at the same time ###
###INFO: Provisoned apps are applications that Windows will attempt to reinstall during updates, or when a new user account is made. If you remove these you will have to install them manually through the Store app when making new accounts.
Get-AppxProvisionedPackage -online | Out-GridView -PassThru | Remove-AppxProvisionedPackage -online