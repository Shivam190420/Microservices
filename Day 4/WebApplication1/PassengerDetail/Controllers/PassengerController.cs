using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        static List<Passenger> Passengerlist = new List<Passenger>()
        {
            new Passenger {PassengerId = 100,PassengerName = "p1",PassengerPhone = 11111122 },
            new Passenger {PassengerId = 101,PassengerName = "p2",PassengerPhone = 22111133 },
            new Passenger {PassengerId = 102,PassengerName = "p3",PassengerPhone = 331111144 },
         };
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {
            return Passengerlist;
        }


        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            Passenger Obj = Passengerlist.Find(item => item.PassengerId == id);
            return Obj;
        }


        [HttpPost]
        public List<Passenger> Post([FromBody] Passenger obj)
        {
            Passengerlist.Add(obj);
            return Passengerlist;
        }

        [HttpPut("{id}")]
        public List<Passenger> Put([FromBody] Passenger newObj)
        {
            Passenger oldObj = Passengerlist.Find(item => item.PassengerId == newObj.PassengerId);
            Passengerlist.Remove(oldObj);
            Passengerlist.Add(newObj);
            return Passengerlist;
        }

        [HttpDelete("{id}")]
        public List<Passenger> Delete(int id)
        {
            Passenger obj = Passengerlist.Find(item => item.PassengerId == id);
            bool isRemoved = Passengerlist.Remove(obj);
            return Passengerlist;
        }

    }
}
