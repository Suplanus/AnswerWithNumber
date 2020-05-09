#!/usr/bin/env bash

echo "---"
echo "Start build script..."
echo "Arguments for updating:"
echo " - AppCenterAndroidSecret: $APPCENTER_ANDROID_SECRET"
echo " - AppCenterIosSecret: $APPCENTER_IOS_SECRET"
echo "---"

# Replace
IdFile=$BUILD_REPOSITORY_LOCALPATH/src/AnswerWithNumber/AnswerWithNumber/Model/AppSecretsCloud.cs
sed -i '' "s/AppCenterAndroidSecret/$APPCENTER_ANDROID_SECRET/g" $IdFile
sed -i '' "s/AppCenterIosSecret/$APPCENTER_IOS_SECRET/g" $IdFile

# Print out file for reference
echo "---"
cat $IdFile
echo "---"
echo "End build script"
