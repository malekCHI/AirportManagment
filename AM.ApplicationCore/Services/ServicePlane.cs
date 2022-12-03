using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlan
    {

        private readonly IUnitOfWork _unitOfWork;
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeletePlanes()
        {
            throw new NotImplementedException();
        }

        public IList<IGrouping<int, Flight>> GetFlights(int n)
        {
            throw new NotImplementedException();
        }

        public IList<Passenger> GetPassengers(Plane plane)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            throw new NotImplementedException();
        }






        //private IGenericRepository<Plane> genericRepository;
        //private IUnitOfWork unitOfWork;

        //public ServicePlane(IUnitOfWork unitOfWork)
        //{
        //    this.unitOfWork = unitOfWork;
        //}
        //public ServicePlane(IGenericRepository<Plane> genericRepository)
        //{
        //    this.genericRepository = genericRepository;
        //}
        //public void Add(Plane plane)
        //{
        //   // unitOfWork.Repository<Plane>().Add(plane);
        //}

        //public IList<Plane> GetAllPlanes()
        //{
        //    return unitOfWork.Repository<Plane>().GetAll().ToList();  
        //}

        //public void Remove(Plane plane)
        //{
        //    unitOfWork.Repository<Plane>().Delete(plane); }

        //public void Update(Plane plane)
        //{
        //    throw new NotImplementedException();
        //}
    }
}






