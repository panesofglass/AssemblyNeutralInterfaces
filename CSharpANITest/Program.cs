using System;
using AssemblyNeutralInterfaces;

namespace CSharpANITest
{
    class Settings
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }

    class ReadonlySettings
    {
        public readonly string Name;
        public readonly string Version;

        public ReadonlySettings(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // These compile successfully but fail at runtime.
            Startup.Configure(new Settings { Name = "C# Test", Version = "1" });
            Startup.Configure(new ReadonlySettings("C# Readonly", "1"));
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
