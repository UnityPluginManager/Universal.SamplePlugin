# UPM Sample Plugin
## Introduction
This repository serves to demonstrate how to create a simple plugin with [UPM](https://github.com/UnityPluginManager/PluginManager). It will display the name of the currently active scene in the top-left corner of the game window.

## Building
In order to build, you will need a copy of UnityEngine.dll  
This file can be found in the _Managed_ folder of any Unity game, or within Unity itself.

If you don't have a built Unity game on-hand, you can retrieve UnityEngine.dll from the following location:

(Unity Install Folder)/Editor/Data/Managed/UnityEngine.dll

You will also need a copy of PluginManager.dll, which can be obtained by building [UPM](https://github.com/UnityPluginManager/PluginManager).
 
After obtaining these files, place them in the _Managed_ folder present with the sample plugin source code. Then, if on Windows, execute `generate.bat` to create project files.

If not on Windows, follow the Protobuild project generation instructions for your platform.

From here, building the plugin should be as simple as compiling the generated solution file in your C# IDE of choice.

## Modifying the sample plugin
If you wish to use the sample plugin as a base for your own plugin, doing so is quite simple. You will only need to do the following:

* Edit the project name in _Build/Module.xml_
* Modify _Build/Projects/Plugin.xml_ to suit your needs
* Re-generate the solution
