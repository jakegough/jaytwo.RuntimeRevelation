using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace jaytwo.RuntimeRevelation.Tests
{
    public class RuntimeInformationProviderTests
    {
        private readonly ITestOutputHelper _output;

        public RuntimeInformationProviderTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetOSPlatform_does_not_return_unknown()
        {
            // arrange
            var provider = new RuntimeInformationProvider();

            // act
            var osPlatform = provider.GetOSPlatform();

            // assert
            Assert.NotEqual(OSPlatform.Unknown, osPlatform);
        }

        [Fact]
        public void GetProcessArchitecture_does_not_return_unknown()
        {
            // arrange
            var provider = new RuntimeInformationProvider();

            // act
            var processArchitecture = provider.GetProcessArchitecture();

            // assert
            Assert.NotEqual(Architecture.Unknown, processArchitecture);
        }
    }
}
