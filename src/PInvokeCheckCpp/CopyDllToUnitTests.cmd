set targetFileName=%1
set targetPath=%2
set solutionDir=%3
set platform=%4
set configuration=%5
if %platform%==Win32 set platformFolder=x86
if %platform%==x64 set platformFolder=x64
set unittest_bin=%3tests\PInvokeTests\bin\%platformFolder%\%configuration%\netcoreapp3.1
if exist "%2" if exist "%unittest_bin%" copy /y /v "%2" "%unittest_bin%\%1"




