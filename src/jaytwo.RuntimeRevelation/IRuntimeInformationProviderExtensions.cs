using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.RuntimeRevelation
{
    public static class IRuntimeInformationProviderExtensions
    {
        public static RuntimeInformation GetRuntimeInformation(this IRuntimeInformationProvider provider) => new RuntimeInformation(provider);
    }
}
