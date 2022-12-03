using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {


        public virtual ICollection<Plane> Planes { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed.")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public  PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public Plane(){}

        public Plane( int capacity, DateTime manufactureDate, PlaneType planetype)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            this.PlaneType = planetype;
        }

        public override string? ToString()
        {
            return this.Capacity + " " + this.ManufactureDate + " " + this.PlaneId + " " + this.PlaneType;
        }
    }
}
