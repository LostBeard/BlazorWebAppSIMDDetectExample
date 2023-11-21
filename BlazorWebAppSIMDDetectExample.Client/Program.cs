using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.WebWorkers;

namespace BlazorWebAppSIMDDetectExample.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // below line allows checking the debug console to see if the Blazor WASM app has loaded
            Console.WriteLine($"Program running");  
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            // for testing purposes. not needed for SIMD compat
            builder.Services.AddBlazorJSRuntime();
            // for testing purposes. not needed for SIMD compat
            builder.Services.AddWebWorkerService();
            // for testing purposes. not needed for SIMD compat
            builder.Services.AddSingleton<IMathsService, MathsService>();
#if DEBUG || true
            var host = builder.Build();
            var JS = host.Services.GetRequiredService<BlazorJSRuntime>();
            JS.Set("_testWorker", new ActionCallback<bool>(async (verbose) =>
            {
                var webWorkerService = host.Services.GetRequiredService<WebWorkerService>();
                var worker = await webWorkerService.GetWebWorker(verbose);
                var math = worker!.GetService<IMathsService>();
                var ret = await math.TestMultiSigMethod(100);
                Console.WriteLine(ret);
            }));
            await host.BlazorJSRunAsync();
#else
            await builder.Build().BlazorJSRunAsync();
#endif
        }
    }
}
