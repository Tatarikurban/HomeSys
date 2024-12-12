using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Sys
{
    public class DeviceClasses
    {
        // Models/Device.cs
        public abstract class Device
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Status { get; set; }

            protected Device(int id, string name)
            {
                Id = id;
                Name = name;
                Status = false; // Default status is off
            }

            public abstract void TurnOn();
            public abstract void TurnOff();
        }

        // Models/Light.cs
        public class Light : Device
        {
            public Light(int id, string name) : base(id, name) { }

            public override void TurnOn()
            {
                Status = true;
                Console.WriteLine($"{Name} is turned on.");
            }

            public override void TurnOff()
            {
                Status = false;
                Console.WriteLine($"{Name} is turned off.");
            }
        }

        // Models/Thermostat.cs
        public class Thermostat : Device
        {
            public int Temperature { get; set; }

            public Thermostat(int id, string name) : base(id, name)
            {
                Temperature = 22; // Default temperature
            }

            public override void TurnOn()
            {
                Status = true;
                Console.WriteLine($"{Name} is set to {Temperature}°C.");
            }

            public override void TurnOff()
            {
                Status = false;
                Console.WriteLine($"{Name} is turned off.");
            }
        }

        // Models/Camera.cs
        public class Camera : Device
        {
            public Camera(int id, string name) : base(id, name) { }

            public override void TurnOn()
            {
                Status = true;
                Console.WriteLine($"{Name} is recording.");
            }

            public override void TurnOff()
            {
                Status = false;
                Console.WriteLine($"{Name} is stopped.");
            }
        }
    }
}
