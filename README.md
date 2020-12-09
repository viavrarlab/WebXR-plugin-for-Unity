# WebXR-plugin-for-Unity

This is a project based on Mozilla's [Unity WebXR Exporter](https://github.com/MozillaReality/unity-webxr-export)

## Getting started

- [WebXR-plugin-for-Unity](#webxr-plugin-for-unity)
  - [Getting started](#getting-started)
  - [Compatibility](#compatibility)
    - [Browser Compatibility](#browser-compatibility)
  - [Setting up a Unity project for WebXR](#setting-up-a-unity-project-for-webxr)
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

* Download `V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage` from a [WebXR Plugin](WebXR%20Plugin/V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage) folder
* Import `V4WebXR-InputManager(WithWebXR)DaviisLV.unitypackage` <br>
Step by step: ` Assets / Import Package / Costom Package..`

<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/1.png" width="400" >

* Import all package content
<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/2.png" width="400" >

* After package is imported you can run test Secene `WebXR` it is located `Assets / WebXR / Samples / Desert `.

<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/3.png" width="400" >

* Open `Project Settings` under `Player`  find Standalone settings and open  `XR Settings` tab. Under XR Settings tab tick Virtual Reality Supported.<br>
Note: Add Virtual Reality SDKs if it is not done automatically and set `Single Pass` sterio rendering Mode.
<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/4.png" width="400" >

* Next step is to open the packet manager and find `XR Legacy Input Helpers` and install it.

<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/5.png" width="400" >

* When `XR Legacy Input Helpers` is installed you need to set up inputs. To do that click `Assets / Seed XR Input Binddings`. This will generate all the necessary inputs.
<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/6.png" width="400" >

* Last Step to create Build is 
<img src="https://github.com/viavrarlab/WebXR-plugin-for-Unity/blob/main/WebXR%20Plugin/images/8.png" width="400" >

## Plugin Input System

day by day

## License

As the base project used the Apache License, Version 2.0, we will continue with it.

Copyright 2017 - 2020 Mozilla Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0
