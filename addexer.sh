#!/bin/bash
dotnet new classlib -o $1
mv $1/Class1.cs $1/$1.cs
dotnet sln add $1/$1.csproj

dotnet new nunit -o $1.Tests
dotnet sln add $1.Tests/$1.Tests.csproj
cd $1.Tests
dotnet add reference ../$1/$1.csproj
mv UnitTest1.cs $1.Tests.cs
cd ..

