using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.RuntimeRevelation.Tests
{
    public class IRuntimeInformationProviderExtensionsTests
    {
        [Fact]
        public void GetRuntimeInformation_works()
        {
            // arrange
            var provider = new RuntimeInformationProvider();

            // act
            var runtimeInformation = provider.GetRuntimeInformation();

            // assert
            Assert.Equal(provider.GetOSPlatform(), runtimeInformation.Platform);
            Assert.Equal(provider.GetProcessArchitecture(), runtimeInformation.ProcessArchitecture);
        }
    }
}
