###When performing a fresh installation of Windows, it is also preferable that every application and utility installed is also fresh and new.###
###1. Install Windows Package Manager (Winget) using this GitHub link: https://github.com/microsoft/winget-cli/releases (Package Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle)###
###2. Run this script which will install 7-Zip, IrfanView, Firefox, VLC Media Player, CCleaner###
###3. If you prefer other apps, then you can create your own essentials for your new Windows device on this page https://winstall.app

winget install --id=IrfanSkiljan.IrfanView -e  ; winget install --id=VideoLAN.VLC -e  ; winget install --id=Mozilla.Firefox -e  ; winget install --id=7zip.7zip -e  ; winget install --id=Piriform.CCleaner -e 