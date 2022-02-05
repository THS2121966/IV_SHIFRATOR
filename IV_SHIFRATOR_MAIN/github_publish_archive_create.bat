echo IV_GIT_RELEASE_CREATOR_STARTING...
echo IV_CREATING_FOLDERS...
MD .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
MD .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator\thirdparty
echo IV_CREATE_FOLDERS_COMPLETE!!!
echo IV_COPING_MAIN_PROGRAMM_AND_INCLUDES...
copy .\IV_Shifrator.exe .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
copy .\IVConsole.dll .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
copy .\Siticone.Desktop.UI.dll .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
copy .\Skybound.Gecko.dll .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
copy .\Skybound.Gecko.xml .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator
xcopy /s .\thirdparty .\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator\thirdparty
echo IV_COPIED_MAIN_PROGRAMM_AND_INCLUDES!!!
echo IV_ARCHIVE_MAIN_FOLDER_FOR_RELEASING_THAT...
"C:\Program Files\WinRAR\WinRAR.exe" a -ag -m5 ".\IV_SHIFRATOR_MAIN_GIT_Release\IV_Shifrator.rar" ".\IV_SHIFRATOR_MAIN_GIT_Release"
echo IV_MAIN_FOLDER_WAS_ARCHIVED!!!
pause
