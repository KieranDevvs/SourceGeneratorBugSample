# SourceGeneratorBugSample
A demo project to reproduce a bug with C# source generators.

Steps to reproduce:
1) Install the .NET compiler platform SDK (described in this post: http://stevetalkscode.co.uk/debug-source-generators-with-vs2019-1610)
2) Clone this repository and open it in visual studio 2019 version 16.11.1.
3) Build the solution and find no build errors.
4) Set the `SourceGenerator` project to be the startup project.
5) Debug the project.
6) See error.
![image](https://user-images.githubusercontent.com/21192520/130372360-36123d0f-9276-4036-9757-2c09e8f1642c.png)
7) Open the `SomeLibrary` csproj file and remove `<FrameworkReference Include="Microsoft.AspNetCore.App" />`.
8) Debug the project again, this time no error will show and the project will successfully execute with the debugger attached.

This also appears to occour with dependencies that arent in nuget (I cant confirm this easily).
