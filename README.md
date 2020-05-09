AnswerWithNumber
---


<p align="center">
  <img src="media/images/icon.png" />
</p>

&nbsp;

This is an example app to showcase the [Microsoft AppCenter](https://appcenter.ms) functions in a real world application 🌍

Have fun with it 💕🦄

<p align="center">
  <img src="media/images/screenshot.png" />
</p>

📺 [Watch demonstration video (spoiler alarm for the answers!)](https://www.youtube.com/watch?v=3tDbkfS11rg&feature=youtu.be)
---

&nbsp;
 

Table of contents
---
- [🚀 Overview](#-overview)
- [🏗 Build](#-build)
  - [🧾 Documentation](#-documentation)
  - [🤖 Android](#-android)
  - [📱 iOS](#-ios)
- [🚦 Test](#-test)
  - [🧾 Documentation](#-documentation-1)
  - [🤖 Android](#-android-1)
  - [📱 iOS](#-ios-1)
- [🔀 Distribute](#-distribute)
  - [🧾 Documentation](#-documentation-2)
- [📈 Diagnostics](#-diagnostics)
  - [🧾 Documentation](#-documentation-3)
  - [💥 Crash](#-crash)
  - [🚨 Error](#-error)
- [📊 Analytics](#-analytics)
  - [🧾 Documentation](#-documentation-4)
  - [🗺 Overview](#-overview)
  - [🎆 Events](#-events)

&nbsp;
---
&nbsp;

# 🚀 Overview

![Setup: Overview](media/images/setup_overview.png)


# 🏗 Build

## 🧾 Documentation
- [AppCenter: Build](https://docs.microsoft.com/en-us/appcenter/build/) 
- [Custom Build scripts](https://montemagno.com/vs-app-center-custom-build-scripts-for-production-apps/)

<p>
  <img src="media/images/build.png" alt="Build" style="width:200px;"/>
</p>

## 🤖 Android

|Branch | Status |
|--------|--------|
| Dev    | ![Build status dev Android](https://build.appcenter.ms/v0.1/apps/72ebc886-01e9-4f5d-9a83-a39dcc9e3913/branches/dev/badge)   |
| Master | ![Build status master Android](https://build.appcenter.ms/v0.1/apps/72ebc886-01e9-4f5d-9a83-a39dcc9e3913/branches/master/badge)  |

## 📱 iOS

|Branch | Status |
|--------|--------|
| Dev    | ![Build status dev iOS](https://build.appcenter.ms/v0.1/apps/44b1eeb7-d793-42f2-b4a7-e0a1f6119b81/branches/dev/badge)   |
| Master | ![Build status master iOS](https://build.appcenter.ms/v0.1/apps/44b1eeb7-d793-42f2-b4a7-e0a1f6119b81/branches/master/badge)   |

&nbsp;

# 🚦 Test

## 🧾 Documentation
- [AppCenter: Test](https://docs.microsoft.com/en-us/appcenter/test-cloud/)

Run test on AppCenter via commandline

<p>
  <img src="media/images/uitest_result1.png" alt="Test result 1" style="width:600px;"/>
</p>

&nbsp;

<p>
  <img src="media/images/uitest_result2.png" alt="Test result 2" style="width:600px;"/>
</p>

## 🤖 Android

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-Android" --devices "Suplanus/storedeviceset-android" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.apk" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```

## 📱 iOS

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-iOS" --devices "Suplanus/storedeviceset-ios" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.ipa" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```

# 🔀 Distribute

## 🧾 Documentation
- [AppCenter: Distribution](https://docs.microsoft.com/en-us/appcenter/distribution/)


# 📈 Diagnostics

## 🧾 Documentation
- [AppCenter: Diagnostics](https://docs.microsoft.com/en-us/appcenter/diagnostics/)

## 💥 Crash
You can trigger a crash by entering `1337`... then you are a _l33t-h4xXor_!

[This is an issue](https://github.com/Suplanus/AnswerWithNumber/issues/3) created by AppCenter. There you can see the details of the crash.

<p>
  <img src="media/images/diagnostics_crashes1.png" alt="Crashes 1" style="width:500px;"/>
</p>

## 🚨 Error
You can trigger a [`System.OverflowException`](https://docs.microsoft.com/de-de/dotnet/api/system.overflowexception) by entering a large number like `66666666666666666666666`. Then you see the error.

<p>
  <img src="media/images/diagnostics_error1.png" alt="Error 1" style="width:300px;"/>
</p>

&nbsp;

<p>
  <img src="media/images/diagnostics_error2.png" alt="Error 2" style="width:600px;"/>
</p>

&nbsp;

# 📊 Analytics

## 🧾 Documentation
- [AppCenter: Analytics](https://docs.microsoft.com/en-us/appcenter/analytics/)

## 🗺 Overview

<p>
  <img src="media/images/analytics_overview.png" alt="Analytics overview" style="width:600px;"/>
</p>

&nbsp;

## 🎆 Events
These events are stored:
- **Difficulty**: If you fail, the level is logged
- **Highscore**: If you win, the time in seconds is logged

<p>
  <img src="media/images/analytics_event1.png" alt="Analytics event 1" style="width:600px;"/>
</p>

&nbsp;

<p>
  <img src="media/images/analytics_event2.png" alt="Analytics event 2" style="width:600px;"/>
</p>
