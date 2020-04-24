AnswerWithNumber
---


<p align="center">
  <img src="media/images/icon.png" />
</p>

&nbsp;

This is example app to show the [Microsoft AppCenter](https://appcenter.ms) functions in a real world application 🌍

Have fun with it 💕🦄

<p align="center">
  <img src="media/images/screenshot.png" />
</p>

📺 [Watch demonstration video (spoiler alarm for the answers!)](https://www.youtube.com/watch?v=3tDbkfS11rg&feature=youtu.be)
---

&nbsp;
 

Table of contents
---
- [🚀 Overview](#%f0%9f%9a%80-overview)
- [🏗 Build](#%f0%9f%8f%97-build)
  - [🧾 Documentation](#%f0%9f%a7%be-documentation)
  - [🤖 Android](#%f0%9f%a4%96-android)
  - [📱 iOS](#%f0%9f%93%b1-ios)
- [🚦 Test](#%f0%9f%9a%a6-test)
  - [🧾 Documentation](#%f0%9f%a7%be-documentation-1)
  - [🤖 Android](#%f0%9f%a4%96-android-1)
  - [📱 iOS](#%f0%9f%93%b1-ios-1)
- [🔀 Distribute](#%f0%9f%94%80-distribute)
  - [🧾 Documentation](#%f0%9f%a7%be-documentation-2)
- [📈 Diagnostics](#%f0%9f%93%88-diagnostics)
  - [🧾 Documentation](#%f0%9f%a7%be-documentation-3)
  - [💥 Crash](#%f0%9f%92%a5-crash)
  - [🚨 Error](#%f0%9f%9a%a8-error)
- [📊 Analytics](#%f0%9f%93%8a-analytics)
  - [🧾 Documentation](#%f0%9f%a7%be-documentation-4)
  - [🗺 Overview](#%f0%9f%97%ba-overview)
  - [🎆 Events](#%f0%9f%8e%86-events)

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
  <img src="media/images/build.png" alt="Build" style="width:300px;"/>
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

<img src="media/images/uitest_result1.png" alt="Test result 1" style="width:600px;"/>

&nbsp;

<img src="media/images/uitest_result2.png" alt="Test result 2" style="width:600px;"/>

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
You can made a crash if you enter `1337`... then you are a _l33t-h4xXor_!

There is a [issue](https://github.com/Suplanus/AnswerWithNumber/issues/3) created by AppCenter. There you can see the details of the crash.


<img src="media/images/diagnostics_crashes1.png" alt="Crashes 1" style="width:500px;"/>

## 🚨 Error
You can made a [`System.OverflowException`](https://docs.microsoft.com/de-de/dotnet/api/system.overflowexception) when you enter a too long number like `66666666666666666666666`. Then you see the error.

<img src="media/images/diagnostics_error1.png" alt="Error 1" style="width:300px;"/>

&nbsp;

<img src="media/images/diagnostics_error2.png" alt="Error 2" style="width:600px;"/>

&nbsp;

# 📊 Analytics

## 🧾 Documentation
- [AppCenter: Analytics](https://docs.microsoft.com/en-us/appcenter/analytics/)

## 🗺 Overview

<img src="media/images/analytics_overview.png" alt="Analytics overview" style="width:600px;"/>

&nbsp;

## 🎆 Events
This events are stored:
- **Difficulty**: If you fail, the level is logged
- **Highscore**: If you win, the time in seconds is logged

<img src="media/images/analytics_event1.png" alt="Analytics event 1" style="width:600px;"/>

&nbsp;

<img src="media/images/analytics_event2.png" alt="Analytics event 2" style="width:600px;"/>