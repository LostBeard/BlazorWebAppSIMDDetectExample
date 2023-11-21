# BlazorWebAppSIMDDetectExample

.Net 8 Blazor Web App version of [BlazorWASMSIMDDetectExample](https://github.com/LostBeard/BlazorWASMSIMDDetectExample)

 Blazor Web App with WebAssembly interactivity is the new adaptation of an ASP.Net Hosted Blazor WASM app in .Net 8 (formally known as Blazor United.)  

 "Blazor Web App" and "Blazor WebAssembly Standalone" use different runtimes loaded by "_framework/blazor.web.js" and "_framework/blazor.webassembly.js" respectively. The Blazor Web App runtime does not start a WASM environment automatically unlike the Blazor WASM runtime and also needs to be configured differently.

 Documentation on startup condifiguration:  
 [Runtime Startup](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/startup?view=aspnetcore-8.0#load-client-side-boot-resources)

 This repo demos SIMD detection and loading of a compatible project build so that the advantages of SIMD can be used when available and also allows the app to run when they are not.  

 Blazor Web App SIMD Detect Example (this repo)
 [BlazorWebAppSIMDDetectExample](https://github.com/LostBeard/BlazorWebAppSIMDDetectExample)

 Blazor WebAssembly Standalone SIMD Detect Example
 [BlazorWASMSIMDDetectExample](https://github.com/LostBeard/BlazorWASMSIMDDetectExample)
