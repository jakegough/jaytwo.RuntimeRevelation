# jaytwo.RuntimeRevelation

<p align="center">
  <a href="https://jenkins.jaytwo.com/job/jaytwo.RuntimeRevelation/job/master/" alt="Build Status (master)">
    <img src="https://jenkins.jaytwo.com/buildStatus/icon?job=jaytwo.RuntimeRevelation%2Fmaster&subject=build%20(master)" /></a>
  <a href="https://jenkins.jaytwo.com/job/jaytwo.RuntimeRevelation/job/develop/" alt="Build Status (develop)">
    <img src="https://jenkins.jaytwo.com/buildStatus/icon?job=jaytwo.RuntimeRevelation%2Fdevelop&subject=build%20(develop)" /></a>
</p>

<p align="center">
  <a href="https://www.nuget.org/packages/jaytwo.RuntimeRevelation/" alt="NuGet Package jaytwo.RuntimeRevelation">
    <img src="https://img.shields.io/nuget/v/jaytwo.RuntimeRevelation.svg?logo=nuget&label=jaytwo.RuntimeRevelation" /></a>
  <a href="https://www.nuget.org/packages/jaytwo.RuntimeRevelation/" alt="NuGet Package jaytwo.RuntimeRevelation (beta)">
    <img src="https://img.shields.io/nuget/vpre/jaytwo.RuntimeRevelation.svg?logo=nuget&label=jaytwo.RuntimeRevelation" /></a>
</p>

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
