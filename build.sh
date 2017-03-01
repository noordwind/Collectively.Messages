#!/bin/bash
dotnet restore --source "https://api.nuget.org/v3/index.json"
dotnet pack "Collectively.Messages" -o .
