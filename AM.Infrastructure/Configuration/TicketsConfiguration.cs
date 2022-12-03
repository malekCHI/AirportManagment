using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AM.Infrastructure.Configuration
{
    internal class TicketsConfiguration : IEntityTypeConfiguration<Ticket>
    {

        public void Configure(EntityTypeBuilder<Ticket> builder)
        {


            builder.HasKey(f => new { f.PassengerFk, f.FlightFk,f.numticket });

            builder
            .HasOne(f => f.Passenger)
                    .WithMany(b => b.Tickets)
                    .HasForeignKey(sc => sc.PassengerFk);

            builder
            .HasOne(f => f.Flight)
                    .WithMany(c => c.Tickets)
                    .HasForeignKey(sc => sc.FlightFk);
        }
    }
}
