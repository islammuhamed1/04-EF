﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DatabaseFirst.Contextx;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DatabaseFirst.Contextx.Configurations
{
    public partial class Products_by_CategoryConfiguration : IEntityTypeConfiguration<Products_by_Category>
    {
        public void Configure(EntityTypeBuilder<Products_by_Category> entity)
        {
            entity.ToView("Products by Category");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Products_by_Category> entity);
    }
}
