using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMyers_Mod07_DelegatesAndInheritance
{
    class Program
    {
        public delegate void PauseHandler();

        static void Main(string[] args)
        {
            Program p = new Program();
            PauseHandler handler = p.Pause;

            List<ComputingDevice> computingDevices = new List<ComputingDevice>();
            computingDevices.Add(new Desktop(4, 3.2, 8, "SSD", "HDMI"));
            computingDevices.Add(new Server(16, 3.2, 128, "RAID", "Generic"));
            computingDevices.Add(new Tablet(2, 2.4, 2, "SSD", "Onboard"));

            foreach (ComputingDevice device in computingDevices)
            {
                device.Display();
            }

            handler();
            Console.ReadKey();
        }

        public void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
        }
    }

    class ComputingDevice
    {
        public string DeviceType { get; protected set; }
        public int Processors { get; set; }
        public double Clockspeed { get; set; }
        public int PhysicalMem { get; set; }
        public string StorageType { get; set; }
        public string DisplayType { get; set; }

        public ComputingDevice() { }
        public ComputingDevice(int processors, double clockspeed, int physicalMem, string storageType, string displayType)
        {
            DeviceType = string.Empty;
            Processors = processors;
            Clockspeed = clockspeed;
            PhysicalMem = physicalMem;
            StorageType = storageType;
            DisplayType = displayType;
        }

        public void Display()
        {
            Console.WriteLine("\n{0} \n# Processors: {1} \nClockspeed: {2} \nRAM: {3} \nStorage Type: {4}", this.DeviceType, this.Processors, this.Clockspeed, this.PhysicalMem, this.StorageType);
        }
    }

    class Desktop: ComputingDevice
    {
        public Desktop(int processors, double clockspeed, int physicalMem, string storageType, string displayType)
        {
            DeviceType = "DESKTOP";
            Processors = processors;
            Clockspeed = clockspeed;
            PhysicalMem = physicalMem;
            StorageType = storageType;
            DisplayType = displayType;
        }
    }

    class Server: ComputingDevice
    {
        public Server(int processors, double clockspeed, int physicalMem, string storageType, string displayType)
        {
            DeviceType = "SERVER";
            Processors = processors;
            Clockspeed = clockspeed;
            PhysicalMem = physicalMem;
            StorageType = storageType;
            DisplayType = displayType;
        }
    }

    class Tablet: ComputingDevice
    {
        public Tablet(int processors, double clockspeed, int physicalMem, string storageType, string displayType)
        {
            DeviceType = "TABLET";
            Processors = processors;
            Clockspeed = clockspeed;
            PhysicalMem = physicalMem;
            StorageType = storageType;
            DisplayType = displayType;
        }
    }
}
