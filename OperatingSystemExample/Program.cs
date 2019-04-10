using System;

namespace OperatingSystemExample
{
    // ????????? 이거 왜 에러뜸?
    // [System.Runtime.InteropServices.ComVisible(true)]
    // [System.Serializable]
    // public sealed class OperatingSystem : ICloneable , System.Runtime.Serialization.ISerializable
    // {

    // }
    class Program
    {
        static void Main(string[] args)
        {
            var os = Environment.OSVersion;
            Console.WriteLine("Current OS Information:\n");
            Console.WriteLine("Platform: {0:G}", os.Platform);
            Console.WriteLine("Version String: {0}", os.VersionString);
            Console.WriteLine("Version Information:");
            Console.WriteLine("   Major: {0}", os.Version.Major);
            Console.WriteLine("   Minor: {0}", os.Version.Minor);
            Console.WriteLine("Service Pack: '{0}'", os.ServicePack);
        }
    }
}
