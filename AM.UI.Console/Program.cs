// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.Net.Mail;
using AM.Infrastructure;
using AM.ApplicationCore.Interfaces;

//Console.WriteLine("Hello, World!");


////Passenger p1= new Passenger { FirstName="malek",LastName="chiha" , EmailAddress = "malekchiha@esprit.tn" };
////Passenger p2 = new Passenger { FirstName = "ni", LastName = "lakhal " };
////Console.WriteLine(p2);
////Console.WriteLine(p1);

//Passenger p = new Passenger();
//p.PassengerType();
//Staff staff = new Staff();
//staff.PassengerType();
//Traveller traveller = new Traveller();
//traveller.PassengerType();

//ServiceFlight flight = new ServiceFlight();
//flight.Flights = TestData.listFlights;

////sf.FlightDetailsDel(TestData.BoingPlane);

//// parti test taa date w destination ne9sa

////Passenger p3 = new Passenger { FirstName = "malek", LastName = "chiha" };
////p1.UpperFullName();
////Console.WriteLine(p1.FirstName + " " + p1.LastName);

//flight.Flights= TestData.listFlights;
//flight.FlightDetailsDel(TestData.BoingPlane); 



//AMContext context = new AMContext();
//context.Flights.Add(TestData.flight2);
//context.SaveChanges();
//Console.WriteLine(context.Flights.First());

//AMContext context = new AMContext();
//GenericRepository<Plane> gn = new GenericRepository<Plane>(context);
//ServicePlane sp = new ServicePlane(gn);
//sp.Add(TestData.BoingPlane);
//gn.SubmitChanges();

//AMContext context = new AMContext();
//IUnitOfWork un = new UnitOfWork(context, typeof(GenericRepository<>));
//ServicePlane service = new ServicePlane(un);
//service.Add(TestData.BoingPlane);
//service.Add(TestData.Airbusplane);
//service.Commit();
//un.Save();
