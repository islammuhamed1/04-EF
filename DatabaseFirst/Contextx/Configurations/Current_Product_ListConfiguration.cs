﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DatabaseFirst.Contextx;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DatabaseFirst.Contextx.Configurations
{
    public partial class Current_Product_ListConfiguration : IEntityTypeConfiguration<Current_Product_List>
    {
        public void Configure(EntityTypeBuilder<Current_Product_List> entity)
        {
            entity.ToView("Current Product List");

            entity.Property(e => e.ProductID).ValueGeneratedOnAdd();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Current_Product_List> entity);
    }
}
