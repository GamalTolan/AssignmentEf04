﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AssignmentEf04.Context;
using AssignmentEf04.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AssignmentEf04.Context.Configurations
{
    public partial class ProductSalesSummaryConfiguration : IEntityTypeConfiguration<ProductSalesSummary>
    {
        public void Configure(EntityTypeBuilder<ProductSalesSummary> entity)
        {
            entity.ToView("ProductSalesSummary");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductSalesSummary> entity);
    }
}
