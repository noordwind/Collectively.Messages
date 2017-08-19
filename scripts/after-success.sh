#!/bin/bash
cd src/Collectively.Messages
dotnet pack /p:PackageVersion=2.0.$TRAVIS_BUILD_NUMBER --no-restore -o .

case "$TRAVIS_BRANCH" in
  "master")
    echo Uploading MyGet package build using branch $TRAVIS_BRANCH
    dotnet nuget push *.nupkg -k $MYGET_API_KEY -s https://www.myget.org/F/collectively/api/v2/package
    ;;
  "develop")
    echo Triggering MyGet package build using branch $TRAVIS_BRANCH
    dotnet nuget push *.nupkg -k $MYGET_DEV_API_KEY -s https://www.myget.org/F/collectively-dev/api/v2/package
    ;;    
esac