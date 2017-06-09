﻿using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.EntitiesConfiguration
{
   public  class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table configurations
            ToTable("Cliente");
            HasKey(c => c.ClienteId);
            //Property(c => c.Placa).IsRequired().HasMaxLength(15);

            //Relationships Configurations

        }
    }
}
