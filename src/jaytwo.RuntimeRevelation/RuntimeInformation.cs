using System;

namespace jaytwo.RuntimeRevelation
{
    public class RuntimeInformation
    {
        private static Lazy<RuntimeInformation> _lazyCurrent = new Lazy<RuntimeInformation>(() => new RuntimeInformationProvider().GetRuntimeInformation());

        public RuntimeInformation(IRuntimeInformationProvider runtimeInformationProvider)
            : this(runtimeInformationProvider.GetOSPlatform(), runtimeInformationProvider.GetProcessArchitecture())
        {
        }

        public RuntimeInformation(OSPlatform platform, Architecture processArchitecture)
        {
            Platform = platform;
            ProcessArchitecture = processArchitecture;
        }

        public static RuntimeInformation Current => _lazyCurrent.Value;

        public OSPlatform Platform { get; }

        public Architecture ProcessArchitecture { get; }

        public override string ToString()
        {
            var platform = Platform == OSPlatform.Unknown ? $"{Platform} {nameof(OSPlatform)}" : $"{Platform}";
            var processArchitecture = ProcessArchitecture == Architecture.Unknown ? $"{ProcessArchitecture} {nameof(Architecture)}" : $"{ProcessArchitecture}";

            return $"{platform} on {processArchitecture}";
        }
    }
}
