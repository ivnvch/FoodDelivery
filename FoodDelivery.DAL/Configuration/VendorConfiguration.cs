﻿using FoodDelivery.DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.DAL.Configuration
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendors").HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.OpeningTime)
               .HasConversion(x => x.ToString("t"), x => DateTime.ParseExact(x, "t", null));
            builder.Property(x => x.ClosingTime)
               .HasConversion(x => x.ToString("t"), x => DateTime.ParseExact(x, "t", null));
            builder.Property(x => x.TimeOfDelivery)
              .HasConversion(x => x.ToString("t"), x => DateTime.ParseExact(x, "t", null));
            builder.Property(x => x.Name)
                .HasMaxLength(20);
            builder.Property(x => x.Type)
                .HasMaxLength(15);
            builder.Property(x => x.CustomerRaiting)
               .HasMaxLength(5);
            builder.Property(x => x.Description)
                .HasMaxLength(200);
            builder.Property(x => x.Address)
                .HasMaxLength(100);
            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(13);
        }
    }
}
