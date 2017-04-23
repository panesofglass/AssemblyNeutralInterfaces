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
        readonly string name;
        readonly string version;

        public ReadonlySettings(string name, string version)
        {
            this.name = name;
            this.version = version;
        }

        public string Name { get { return name; } }
        public string Version { get { return version; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Startup.Configure(new Settings { Name = "C# Test", Version = "1" });
            Startup.Configure(new ReadonlySettings("C# Readonly", "1"));
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
