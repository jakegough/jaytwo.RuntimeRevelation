using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace jaytwo.RuntimeRevelation.Tests
{
    public class RuntimeInformationTests
    {
        private readonly ITestOutputHelper _output;

        public RuntimeInformationTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(OSPlatform.Unknown, Architecture.Unknown)]
        [InlineData(OSPlatform.Linux, Architecture.ARM)]
        public void Constructor_works(OSPlatform platform, Architecture processArchitecture)
        {
            // arrange

            // act
            var runtimeInformation = new RuntimeInformation(platform, processArchitecture);

            // assert
            _output.WriteLine(runtimeInformation.ToString());
            Assert.Equal(platform, runtimeInformation.Platform);
            Assert.Equal(processArchitecture, runtimeInformation.ProcessArchitecture);
        }

        [Fact]
        public void Current_works()
        {
            // arrange

            // act
            var runtimeInformation = RuntimeInformation.Current;

            // assert
            _output.WriteLine(runtimeInformation.ToString());
            Assert.NotEqual(OSPlatform.Unknown, runtimeInformation.Platform);
            Assert.NotEqual(Architecture.Unknown, runtimeInformation.ProcessArchitecture);
        }

        [Theory]
        [InlineData(OSPlatform.Unknown, Architecture.Unknown, "Unknown OSPlatform on Unknown Architecture")]
        [InlineData(OSPlatform.Windows, Architecture.X64, "Windows on X64")]
        [InlineData(OSPlatform.OSX, Architecture.X64, "OSX on X64")]
        [InlineData(OSPlatform.Linux, Architecture.ARM, "Linux on ARM")]
        [InlineData(OSPlatform.Linux, Architecture.ARM64, "Linux on ARM64")]
        [InlineData(OSPlatform.Linux, Architecture.X64, "Linux on X64")]
        [InlineData(OSPlatform.Linux, Architecture.X86, "Linux on X86")]
        public void ToString_works(OSPlatform platform, Architecture processArchitecture, string expected)
        {
            // arrange
            var runtimeInformation = new RuntimeInformation(platform, processArchitecture);

            // act
            var toString = runtimeInformation.ToString();

            // assert
            Assert.Equal(expected, toString);
        }
    }
}
