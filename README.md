# AnswerWithNumber

This is example app to show the [Microsoft AppCenter](https://appcenter.ms) functions in a real world application 🌍

Have fun with it 💕

&nbsp;

<div style="text-align:center"><img src="Images/icon.png" /></div>

 &nbsp; 
 
<div style="text-align:center"><img src="Images/screenshot.png" /></div>

&nbsp;

## Run test on AppCenter

### iOS

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-iOS" --devices "Suplanus/storedeviceset-ios" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.ipa" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```

### Android

```shell
appcenter test run uitest --app "Suplanus/AnswerWithNumber-Android" --devices "Suplanus/storedeviceset-android" --app-path "/Users/moz/Documents/GitHub/AnswerWithNumber/appcenter/AnswerWithNumber.apk" --test-series "master" --locale "de_DE" --build-dir "/Users/$USER/Documents/GitHub/AnswerWithNumber/src/AnswerWithNumber/AnswerWithNumber.UITest/bin/Debug" --uitest-tools-dir "/Users/$USER/.nuget/packages/xamarin.uitest/3.0.7/tools/"
```