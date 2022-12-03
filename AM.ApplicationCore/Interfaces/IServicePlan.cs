using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlan : IService<Plane>
    {
        //public void Add(Plane plane);
        //public void Remove(Plane plane);
        //public IList<Plane> GetAllPlanes();
        //public void Update(Plane plane);


        IList<Passenger> GetPassengers(Plane plane);
        IList<IGrouping<int, Flight>> GetFlights(int n);
        bool IsAvailablePlane(Flight flight, int n);
        void DeletePlanes();

    }

}
