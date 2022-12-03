using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {


        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(F => F.Passengers).WithMany(c => c.Flights).UsingEntity(i => i.ToTable("Reservation"));
            builder.HasOne(f => f.Plane).WithMany(p => p.Flights).HasForeignKey(p => p.planeId).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}