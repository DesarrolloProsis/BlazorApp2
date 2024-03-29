﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Models;

public partial class Description
{
    [Key]
    public int Id { get; set; }

    public int? IdCustomer { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [ForeignKey("IdCustomer")]
    [InverseProperty("Descriptions")]
    public virtual Customer IdCustomerNavigation { get; set; }

    [InverseProperty("IdDescriptionNavigation")]
    public virtual ICollection<InventoryFeatureDescription> InventoryFeatureDescriptions { get; set; } = new List<InventoryFeatureDescription>();

    [ForeignKey("IdDescription")]
    [InverseProperty("IdDescriptions")]
    public virtual ICollection<Feature> IdFeatures { get; set; } = new List<Feature>();
}