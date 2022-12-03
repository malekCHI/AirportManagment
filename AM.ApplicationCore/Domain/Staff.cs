using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public String Function { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        public override string? ToString()
        {
            return this.EmployementDate + " " + this.Function + " " + this.Salary;
        }

        public override void PassengerType()
        {
            Console.WriteLine( "I am a staff member");
        }
    }
}
