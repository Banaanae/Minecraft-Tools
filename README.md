# Minecraft-Tools

Random C# minecraft tools

### Building

##### Windows

- Make sure you have [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159) installed.
- Using Command Prompt `cd` into the directory where you have the `.cs` file saved
- Copy and paste in `C:\"Program Files (x86)"\MSBuild\14.0\Bin\csc.exe /t:exe /out:ExeFileName.exe CsFileName.cs`. Make sure you replace ExeFileName and CsFileName with their respective file names. (ExeFileName can be anything)
- Open the directory where the `.cs` file is and there should be a `.exe` file there with the name you specified.
- Run it and your file is now built!
