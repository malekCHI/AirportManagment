using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        public virtual ICollection<Flight> Flights { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
       
        [StringLength(7)]
        public int PassportNumber { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public String EmailAddress { get; set; }
        [MinLength(3,ErrorMessage ="must be start with 3 cart")]
        [MaxLength(25, ErrorMessage = "and finish with 25 cart")]
        public FullName fullname { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        [Required(ErrorMessage = "Telephone Number Required")]
        [RegularExpression(@"^\(?([0-9]{8}$",ErrorMessage ="invalide phone number")]
        public String TelNumber { get; set; }
        public int Id { get; set; }

         public override string? ToString()
          {
           return this.BirthDate + " " + this.PassportNumber + " " + this.EmailAddress + " " + this.fullname.FirstName+ " " + this.fullname.LastName + " " + this.TelNumber;

          }

        public bool CheckProfile( String nom , String Prenom)
        {
                return this.fullname.FirstName == Prenom && this.fullname.LastName == nom;
          
        }

        public bool CheckProfile(String nom, String Prenom,String email)
        {
            return this.fullname.FirstName == Prenom && this.fullname.LastName == nom && this.EmailAddress == email;

        }

        public virtual void PassengerType()
        {
            Console.WriteLine("i'm a passenger");
        }

        public void UpperFullName()
        {
            throw new NotImplementedException();
        }
    }
}
