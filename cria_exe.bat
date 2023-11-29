"%~dp0\7z.exe" a HotAPP_Modelo.7z HotAPP_Modelo.zip
copy /b 7zsd_All_x64.sfx + config.txt + HotAPP_Modelo.7z HotAPP_Modelo_install.exe
