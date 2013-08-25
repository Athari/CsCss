Copy /Y ..\ReadMe.md ..\ReadMe.txt
NuGet Pack ..\Alba.CsCss\Alba.CsCss.csproj -Symbols -Build -Properties Configuration=Release
Del ..\ReadMe.txt
Pause
