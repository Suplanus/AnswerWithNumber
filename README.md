# AnswerWithNumber

<p align="center">
  <img src="media/images/icon.png" />
</p>

&nbsp;

This is example app to show the [Microsoft AppCenter](https://appcenter.ms) functions in a real world application 🌍

Have fun with it 💕🦄

 &nbsp; 
 
<p align="center">
  <img src="media/images/screenshot.png" />
</p>

&nbsp;

## Build

### Status

| Plattform | Branch | Status |
|-----------|--------|--------|
| **Android**   | Dev    | [![Build status](https://build.appcenter.ms/v0.1/apps/72ebc886-01e9-4f5d-9a83-a39dcc9e3913/branches/dev/badge)](https://appcenter.ms)   |
|           | Master | [![Build status](https://build.appcenter.ms/v0.1/apps/72ebc886-01e9-4f5d-9a83-a39dcc9e3913/branches/master/badge)](https://appcenter.ms)   |
| **iOS**       | Dev    | [![Build status](https://build.appcenter.ms/v0.1/apps/44b1eeb7-d793-42f2-b4a7-e0a1f6119b81/branches/dev/badge)](https://appcenter.ms)   |
|           | Master | [![Build status](https://build.appcenter.ms/v0.1/apps/44b1eeb7-d793-42f2-b4a7-e0a1f6119b81/branches/master/badge)](https://appcenter.ms)   |

&nbsp;

## Diagnostics

### Crash
You can made a crash if you enter `1337`... then you are a _l33t-h4xXor_ 👩‍💻

### Error
You can made a [`System.OverflowException`](https://docs.microsoft.com/de-de/dotnet/api/system.overflowexception) when you enter a too long number... Then you see the crash 💥

&nbsp;

## Analytics
This events are stored:
- **Difficulty**: If you fail, the level and the answer is logged
- **Highscore**: If you win, the time is logged

&nbsp;

## Test

Run test on AppCenter via commandline 🔴🟢

![](media/images/test_result.png)

### iOS

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-iOS" --devices "Suplanus/storedeviceset-ios" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.ipa" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```

### Android

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-Android" --devices "Suplanus/storedeviceset-android" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.apk" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```