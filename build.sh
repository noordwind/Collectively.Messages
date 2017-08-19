#!/bin/bash
cd src/Collectively.Messages
dotnet restore
dotnet pack --no-restore -o .