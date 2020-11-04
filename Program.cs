using System;
using WebAssembly;

namespace WasmCSharp
{
    class Program
    {
        static void WasmMain()
        {
            Console.WriteLine("Hello World from WASM!");

            var app = Runtime.GetGlobalObject("App") as JSObject;
            app.Invoke("sayHello", "smack0007");
        }
    }
}
