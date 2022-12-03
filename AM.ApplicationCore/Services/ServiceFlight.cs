using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight: Service<Flight>,IServiceFlight
    {

        private readonly IUnitOfWork _unitOfWork;
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }















        //public Action<Plane> FlightDetailsDel;

        //public Func<string, double> DurationAverageDel;

        //public ServiceFlight()
        //{
        //    FlightDetailsDel = ShowFlightDetails;
        //    DurationAverageDel = DurationAverage;
        //}
        public List<Flight> Flights { get; set; }

        public List<DateTime> GetFlightsDates(string destination)
        {

            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {

                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }

            }
            return dates;


           //foreach (Flight date in Flights)
            //{
               // if (date.Destination==destination)
                //{
                  //  dates.Add(date.FlightDate);
                //}
                //return dates;
            //}


        }


        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if ((f.Destination == filterValue))
                        {
                            Console.WriteLine(f.ToString);
                        }
                    };
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))

                                  
                            Console.WriteLine(f.ToString);

                    };
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in Flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                           Console.WriteLine(f.ToString);
                    };
                    break;

                    default:
                    Console.WriteLine("error");
                    break;


            }
        }

        public void  ShowFlightDetails(Plane plane)
        {
            var query = from f in Flights where f.Plane == plane select new { f.FlightDate, f.Destination };
            foreach (var flight in query)
            {
                Console.WriteLine("Date="+flight.FlightDate+"Destination="+flight.Destination);
            }
            /*
            var query2 = Flights.Where(f=> f.Plane == plane).Select(f => f.FlightDate,f.Destination);
            foreach (var flight in query2)
            {
                Console.WriteLine("Date=" + flight.FlightDate + "Destination=" + flight.Destination);
            }*/
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query =from f in Flights
                       where DateTime.Compare(f.FlightDate,startDate) > 0 && (f.FlightDate - startDate).TotalDays > 0 select f;

            var query2 = Flights.Where(f => DateTime.Compare(f.FlightDate, startDate) > 0 && f.FlightDtate);

            return query.Count();
        }

        public double DurationAverage(string destination)
        {

            var query = ( from f in Flights
                        where f.Destination == destination
                        select  f.EstimatedDuration).Average();

            var query2 = Flights.Where(from => from.Destination == destination).Select (f => f.EstimatedDuration).Average();

            return query;
        }

        public List <Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending select f;

            var query2 = Flights.OrderByDescending(f => f.EstimatedDuration);

            return query.ToList();
        }

         public List <Traveller> SeniorTravellers(Flight flight)
        {
            var query = from t in flight.Passengers.OfType<Traveller>()
                        orderby t.BirthDate 
                        select t;

            var query2 = flight.Passengers.OfType<Traveller>().OrderBy(f => f.BirthDate);

                        return query.Take(3).ToList();
        }

        public void DestinationGroupedFlights()
        {
            var query = from f in Flights group f by f.Destination;
            var query2 = Flights.GroupBy(f => f.Destination);

            foreach(var groupe in query)
            {
                Console.WriteLine("Destination=" + groupe.Key);
                foreach(var f in groupe)
                {
                    Console.WriteLine("découlage:" +f.FlightDate);
                }
            }

        }

        public List<Flight> GetFlightDates(string destination)
        {
            throw new NotImplementedException();
        }

        public int ProgrammedFlightNumber2(DateTime date)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Flight> IServiceFlight.OrderedDurationFlights()
        {
            throw new NotImplementedException();
        }

        IEnumerable<string> IServiceFlight.SeniorTravellers(Flight flight)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IGrouping<string, Flight>> IServiceFlight.DestinationGroupedFlights()
        {
            throw new NotImplementedException();
        }

        List<DateTime> IServiceFlight.GetFlightDates(string destination)
        {
            throw new NotImplementedException();
        }
    }
}
