@ECHO OFF
PUSHD %~dp0\publish

dotnet-serve -p 8080 -o

POPD