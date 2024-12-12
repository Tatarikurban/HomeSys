using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using SmartHome.Services;
using static Home_Sys.DeviceClasses;
using static Home_Sys.SingletonPattern;

namespace Home_Sys
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Device>> GetDevices()
        {
            return SmartHomeSystem.Instance.GetDevices();
        }

        [HttpPost]
        public ActionResult<Device> AddDevice([FromBody] Device device)
        {
            SmartHomeSystem.Instance.AddDevice(device);
            return CreatedAtAction(nameof(GetDevices), new { id = device.Id }, device);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveDevice(int id)
        {
            SmartHomeSystem.Instance.RemoveDevice(id);
            return NoContent();
        }
    }
}
