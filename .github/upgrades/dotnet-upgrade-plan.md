# .NET 9.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 9.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 9.0 upgrade.
3. Upgrade Problems/Problems.csproj to .NET 9.0
4. Upgrade UnitTest/UnitTest.csproj to .NET 9.0
5. Upgrade WebSite/WebSite.csproj to .NET 9.0
6. Run unit tests to validate upgrade in the projects listed below:
   - UnitTest/UnitTest.csproj

## Settings

### Aggregate NuGet packages modifications across all projects

| Package Name                                       | Current Version | New Version | Description                                   |
|:--------------------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.VisualStudio.Web.CodeGeneration.Design |     6.0.11      |   9.0.12    | Recommended for .NET 9.0                      |

### Project upgrade details

#### Problems/Problems.csproj modifications

Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### UnitTest/UnitTest.csproj modifications

Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### WebSite/WebSite.csproj modifications

Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

NuGet packages changes:
  - Microsoft.VisualStudio.Web.CodeGeneration.Design should be updated from `6.0.11` to `9.0.12` (*recommended for .NET 9.0*)