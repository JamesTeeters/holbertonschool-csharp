#!/usr/bin/env bash
# Script that initializes and builds a new C# project inside a folder titled 1-new_project

# Create folder and enter it
mkdir -p 1-new_project; cd 1-new_project
dotnet new console
sleep 3
dotnet build
cd ..
