using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Home_Sys.DeviceClasses;

namespace Home_Sys
{
    public class FactoryPattern
    {
        // Services/DeviceFactory.cs
        public static class DeviceFactory
        {
            public static Device CreateDevice(string deviceType, int id, string name)
            {
                switch (deviceType.ToLower())
                {
                    case "light":
                        return new Light(id, name);
                    case "thermostat":
                        return new Thermostat(id, name);
                    case "camera":
                        return new Camera(id, name);
                    default:
                        throw new ArgumentException("Unknown device type");
                }
            }
        }
    }
}
