using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.RuntimeRevelation
{
    internal class RuntimeInformationProvider : IRuntimeInformationProvider
    {
#if NETSTANDARD
        public Architecture GetProcessArchitecture()
        {
            switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
            {
                case System.Runtime.InteropServices.Architecture.X86:
                    return Architecture.X86;
                case System.Runtime.InteropServices.Architecture.X64:
                    return Architecture.X64;
                case System.Runtime.InteropServices.Architecture.Arm:
                    return Architecture.ARM;
                case System.Runtime.InteropServices.Architecture.Arm64:
                    return Architecture.ARM64;
                default:
                    return Architecture.Unknown;
            }
        }

        public OSPlatform GetOSPlatform()
        {
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
            {
                return OSPlatform.Linux;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            {
                return OSPlatform.Windows;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                return OSPlatform.OSX;
            }
            else
            {
                return OSPlatform.Unknown;
            }
        }

#else
        public Architecture GetProcessArchitecture()
        {
            // help from: https://stackoverflow.com/a/25284569

            typeof(object).Module.GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine);

            switch (machine)
            {
                case ImageFileMachine.AMD64:
                case ImageFileMachine.IA64:
                    return Architecture.X64;

                case ImageFileMachine.I386:
                    return Architecture.X86;

                case ImageFileMachine.ARM:
                    if (System.Environment.Is64BitOperatingSystem)
                    {
                        return Architecture.ARM64;
                    }
                    else
                    {
                        return Architecture.ARM;
                    }

                default:
                    return Architecture.Unknown;
            }
        }

        public OSPlatform GetOSPlatform()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                    return OSPlatform.OSX;
                case PlatformID.Win32Windows:
                    return OSPlatform.Windows;
                case PlatformID.Unix:
                    return OSPlatform.Linux;
                default:
                    return OSPlatform.Unknown;
            }
        }
#endif
    }
}
