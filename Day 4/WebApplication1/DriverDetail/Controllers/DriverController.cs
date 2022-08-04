using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        static List<Driver> driverlist = new List<Driver>()
        {
            new Driver {DriverId = 100,DriverName = "Jones",DriverPhone = 11111111 },
            new Driver {DriverId = 101,DriverName = "Ben",DriverPhone = 22111111 },
            new Driver {DriverId = 102,DriverName = "Joseph",DriverPhone = 33111111 },
         };
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return driverlist;
        }

        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            Driver Obj = driverlist.Find(item => item.DriverId == id);
            return Obj;
        }


        [HttpPost]
        public List<Driver> Post([FromBody] Driver obj)
        {
            driverlist.Add(obj);
            return driverlist;
        }

        [HttpPut("{id}")]
        public List<Driver> Put([FromBody] Driver newObj)
        {
            Driver oldObj = driverlist.Find(item => item.DriverId == newObj.DriverId);
            driverlist.Remove(oldObj);
            driverlist.Add(newObj);
            return driverlist;
        }

        [HttpDelete("{id}")]
        public List<Driver> Delete(int id)
        {
            Driver obj = driverlist.Find(item => item.DriverId == id);
            bool isRemoved = driverlist.Remove(obj);
            return driverlist;
        }
    }
}
