﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEf04.Models;

public partial class CustomerDemographic
{
    [Key]
    [StringLength(10)]
    public string CustomerTypeID { get; set; }

    [Column(TypeName = "ntext")]
    public string CustomerDesc { get; set; }

    [ForeignKey("CustomerTypeID")]
    [InverseProperty("CustomerTypes")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}