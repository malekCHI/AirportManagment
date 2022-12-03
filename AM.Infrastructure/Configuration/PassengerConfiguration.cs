using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AM.Infrastructure.Configuration
{
    internal class PassengerConfiguration
    : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasDiscriminator<String>("IsTravller").HasValue("1")
                .HasValue<Staff>("2").HasValue("0");

            builder.OwnsOne(c => c.fullname,
                 myadd =>
                 {
                     myadd.
                     Property(f => f.FirstName).HasColumnName("passfirstname").HasMaxLength(30);
                     myadd.Property(f => f.LastName).HasColumnName("passlastname").IsRequired();
                 });

        }  

    }
}
