using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public  class Flight
    {
        public int FlightId { get; set; }
        public String Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        //declario champs planeid baadik naamil foreign key f champs taa  jointure
        public int planeId { get; set; }
        [ForeignKey("planeId")]
        public virtual Plane Plane { get; set; }
        public bool FlightDtate { get; internal set; }
        public string Airline { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public override string? ToString()
        {
            return this.Destination + " " + this.Departure + " " + this.FlightDate + " " + this.FlightId + " " + this.EffectiveArrival + " " + this.EstimatedDuration;
        }

       


    }
}
