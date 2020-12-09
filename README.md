# WebXR-plugin-for-Unity

This is a project based on Mozilla's [Unity WebXR Exporter](https://github.com/MozillaReality/unity-webxr-export)

## Getting started

- [WebXR-plugin-for-Unity](#webxr-plugin-for-unity)
  - [Getting started](#getting-started)
  - [Compatibility](#compatibility)
    - [Browser Compatibility](#browser-compatibility)
  - [Setting up a Unity project for WebXR](#setting-up-a-unity-project-for-webxr)
    - [First step](#first-step)
    - [Second step](#second-step)
    - [Third step](#third-step)
    - [Last step](#last-step)
  - [Plugin Input System](#plugin-input-system)
  - [License](#license)


## Compatibility

[unity-download]:                 https://unity3d.com/get-unity/download/archive
[unity-version-badge]:            https://img.shields.io/badge/Unity%20Editor%20Version-2019.4.4f1-green.svg
[![Github Release][unity-version-badge]][unity-download]

### Browser Compatibility

WebXR has limited support
| Platform | Browser       | Compatible headsets                                                                                                                      | Notes                                                                    |
| -------- | ------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------ |
| Desktop  | Firefox       | HTC Vive, HTC Vive Pro, HTC Vive Cosmos, Oculus Rift, Oculus Rift S, Oculus Quest(link), Windows Mixed Reality headsets (using Steam VR) | [Setup instructions](https://webvr.rocks/firefox)                        |
| Desktop  | Chrome Canary | HTC Vive, HTC Vive Pro, HTC Vive Cosmos, Oculus Rift, Oculus Rift S, Oculus Quest(link), Windows Mixed Reality headsets                  | Browser flags required. [Setup instructions](https://webvr.rocks/chrome) |

## Setting up a Unity project for WebXR
### First step

<img align="right" src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/1.png" width="360" >

 Download `V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage` from a [WebXR Plugin](WebXR%20Plugin/V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage) folder. <br /><br />
 Import `V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage`
 <br /><br />
Step by step: ` Assets / Import Package / Costom Package..`
<br />
 Import all package content.
<br />
 *Note: After package is imported you can chekout Demo Secene `WebXR` it is located `Assets / WebXR / Samples / Desert`.*
<br /> <br /> <br /> <br />

### Second step

<img align="right" src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/4.png" width="360" >
<br /> 
Open `Project Settings` under `Player`  find Standalone settings and open  `XR Settings` tab. Under XR Settings tab tick Virtual Reality Supported.
<br /> 
*Note: Add Virtual Reality SDKs if it is not done automatically and set `Single Pass` sterio rendering Mode.*
<br /> <br /> <br /><br /> <br /> <br /><br /> <br /> <br /> <br /> 

### Third step
 Open the `package manager` and find `XR Legacy Input Helpers` and install it.

 <br /><br /> <br /> <br /><br /> 
<img align="right" src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/6.png" width="360" >

 When `XR Legacy Input Helpers` is installed you need to set up inputs. To do that click `Assets / Seed XR Input Binddings`. This will generate all the necessary inputs.

 <br /><br /> <br /> <br /><br /> <br /> <br /><br /> <br /> <br /> <br /><br /><br /> <br /> <br /> <br /><br />
 
 ### Last step
<img align="right" src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/8.png" width="360" >

 Last step to prepare project for build is to open `Project Settings` under `Player`  find `Settings for WebGL` and open `Resolution and Presentation` tab. Select the `WebXR` in WebGL Template and also fill in all other required fields.
 <br /> <br /> 
 Now you are ready to create a project build! :) <br />
 *Note: Of course the Build platform must be selected WebGL!*
  <br /> <br />   <br /> <br /> 
 
## Plugin Input System

day by day

## License

As the base project used the Apache License, Version 2.0, we will continue with it.

Copyright 2017 - 2020 Mozilla Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0
