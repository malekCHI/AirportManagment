using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public  class Ticket
    {
        public int numticket { get; set; }
        public int PassengerFk { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int FlightFk { get; set; }
        public virtual Flight Flight { get; set; }
        public float Prix { get; set; }
        public String siege { get; set; }
        public Boolean vip { get; set; }


    }
}
