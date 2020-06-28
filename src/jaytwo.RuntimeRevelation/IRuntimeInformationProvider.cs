using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.RuntimeRevelation
{
    public interface IRuntimeInformationProvider
    {
        Architecture GetProcessArchitecture();

        OSPlatform GetOSPlatform();
    }
}
