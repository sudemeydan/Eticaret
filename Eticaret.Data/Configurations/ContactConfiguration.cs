﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Data.Configurations
{
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
    
public void Configure(EntityTypeBuilder<Contact> builder)
        {

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50); 
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Message).IsRequired().HasMaxLength(500);
        }
    }
}
