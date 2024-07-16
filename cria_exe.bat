"%~dp0\7z.exe" a HotAPP_Modelo_FluentUI.7z HotAPP_Modelo_FluentUI.zip
copy /b 7zsd_All_x64.sfx + config.txt + HotAPP_Modelo_FluentUI.7z HotAPP_Modelo_FluentUI_install.exe
