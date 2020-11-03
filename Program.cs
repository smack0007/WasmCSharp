using System;
using WebAssembly;

namespace WasmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void WasmMain()
        {
            Console.WriteLine("Hello World from WASM!");

            Runtime.InvokeJS("sayHello();");
        }
    }
}
