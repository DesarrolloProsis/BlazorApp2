﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Models;

public partial class Inventory
{
    [Key]
    public int Id { get; set; }

    public int? IdReceptionCertificate { get; set; }

    public int? IdService { get; set; }

    public int? IdArea { get; set; }

    [StringLength(50)]
    public string Comment { get; set; }

    public int? IdBlob { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [ForeignKey("IdArea")]
    [InverseProperty("Inventories")]
    public virtual Area IdAreaNavigation { get; set; }

    [ForeignKey("IdReceptionCertificate")]
    [InverseProperty("Inventories")]
    public virtual ReceptionCertificate IdReceptionCertificateNavigation { get; set; }

    [ForeignKey("IdService")]
    [InverseProperty("Inventories")]
    public virtual Service IdServiceNavigation { get; set; }

    [InverseProperty("IdInventoryNavigation")]
    public virtual ICollection<InventoryFeatureDescription> InventoryFeatureDescriptions { get; set; } = new List<InventoryFeatureDescription>();

    [ForeignKey("IdInventory")]
    [InverseProperty("IdInventories")]
    public virtual ICollection<Blob> IdBlobs { get; set; } = new List<Blob>();
}