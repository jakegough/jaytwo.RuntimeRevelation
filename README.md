# jaytwo.RuntimeRevelation

[![NuGet version (jaytwo.RuntimeRevelation)](https://img.shields.io/nuget/v/jaytwo.RuntimeRevelation.svg?style=flat-square)](https://www.nuget.org/packages/jaytwo.RuntimeRevelation/)

Simplifying access to current platform and architecture information.

## Installation

Add the NuGet package

```
PM> Install-Package jaytwo.RuntimeRevelation
```

## Usage

```csharp
if (RuntimeInformation.Current.Platform == OSPlatform.Windows)
{
  // do the windows-only supported thing
}
else
{
  // do the cross-platform thing
}
```

---

Made with &hearts; by Jake
