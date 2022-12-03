using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public void ShowFlightDetails(Plane p);
        public void GetFlights(string filterType, string filterValue);
        public int ProgrammedFlightNumber(DateTime startDate);
        public IEnumerable<Flight> OrderedDurationFlights();
        public IEnumerable<String> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
        public List<DateTime> GetFlightDates(String destination);
        public int ProgrammedFlightNumber2(DateTime date);
        public Double DurationAverage(String destination);




    }
}
