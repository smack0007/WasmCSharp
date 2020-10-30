# WasmCSharp

My take on the [WasmAloneLab](https://github.com/praeclarum/WasmAloneLab) by
[@praeclarum](https://github.com/praeclarum). 

## Building

The project makes the assumption the the [mono-wasm SDK](https://github.com/mono/mono/blob/master/sdks/wasm/docs/getting-started/obtain-wasm-sdk.md)
is in the directory mono-wasm on the same level as this project. Can be changed
by editing the csproj file and changing the value of the `WasmSDKPath` variable.

Build the project with `dotnet build` or via Visual Studio and the `packager.exe`
from the mono-wasm SDK will be run and places the output in the `publish` directory.

## Run

There is a serve.cmd which uses [dotnet-serve](https://github.com/natemcmaster/dotnet-serve)
to spin up a web server for serving the output. After starting the server
go to http://localhost:8080 to see the output.

The example here only writes to "Hello World from WASM!" to the console.