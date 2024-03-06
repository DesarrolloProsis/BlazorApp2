﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Models;

public partial class PropertyType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    [Unicode(false)]
    public string PropertyTypeName { get; set; }

    [InverseProperty("IdPropertyTypeNavigation")]
    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}