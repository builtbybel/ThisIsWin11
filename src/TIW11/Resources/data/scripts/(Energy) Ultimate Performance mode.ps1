###Microsoft added the “Ultimate Performance mode” power scheme to Windows 10 April 2018 Update to optimize the system’s performance, especially high-end PCs.###
###The “Ultimate Performance” power plan option may not be available on some systems, especially if you are using a laptop.###
###Requires -RunSilent

[reflection.assembly]::loadwithpartialname("System.Windows.Forms") | Out-Null 
$msgBoxInput = [System.Windows.Forms.MessageBox]::Show('Do you want to enable the Ultimate Performance power plan?','ThisIsWin11','YesNo','Question')

switch  ($msgBoxInput) {

  'Yes' {
  
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61 

[System.Windows.Forms.MessageBox]::Show('Power plan has been successfully enabled. Now open Settings and navigate to System > Power & sleep > Additional Power Settings and enable the Ultimate Performance power plan.')
 }

'No'{}

}
