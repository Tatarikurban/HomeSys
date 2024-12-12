using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Home_Sys.DeviceClasses;

namespace Home_Sys
{
    public class SingletonPattern
    {
        // Services/SmartHomeSystem.cs
        public class SmartHomeSystem
        {
            private static SmartHomeSystem _instance;
            private List<Device> _devices;

            private SmartHomeSystem()
            {
                _devices = new List<Device>();
            }

            public static SmartHomeSystem Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new SmartHomeSystem();
                    }
                    return _instance;
                }
            }

            public void AddDevice(Device device)
            {
                _devices.Add(device);
            }

            public List<Device> GetDevices()
            {
                return _devices;
            }

            public Device GetDeviceById(int id)
            {
                return _devices.FirstOrDefault(d => d.Id == id);
            }

            public void RemoveDevice(int id)
            {
                var device = GetDeviceById(id);
                if (device != null)
                {
                    _devices.Remove(device);
                }
            }
        }
    }
}
