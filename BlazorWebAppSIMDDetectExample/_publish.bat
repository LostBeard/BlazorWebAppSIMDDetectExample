
REM Normal build with SIMD and BlazorWebAssemblyJiterpreter enabled
dotnet publish --nologo --configuration Release --output "bin\Publish"

REM Compatibility build with SIMD and BlazorWebAssemblyJiterpreter disabled
dotnet publish --nologo --no-restore --configuration ReleaseCompat --output "bin\PublishCompat"

REM Combine builds
REM Copy the 'wwwroot\_framework' folder contents from the 2nd build to 'wwwroot\_frameworkCompat' in the 1st build
xcopy /I /E /Y "bin\PublishCompat\wwwroot\_framework" "bin\Publish\wwwroot\_frameworkCompat"
