﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Models;

[Index("ReferenceNumber", Name = "UQ_ReferenceNumber", IsUnique = true)]
public partial class ReceptionCertificate
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Contract { get; set; }

    public int? IdLessor { get; set; }

    public int? IdTenant { get; set; }

    public int? IdProperty { get; set; }

    public int? IdCustomer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string ContractNumber { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Notes { get; set; }

    [StringLength(450)]
    public string IdUser { get; set; }

    public int? IdType { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string ReferenceNumber { get; set; }

    public int? IdReceptionCertificate { get; set; }

    [ForeignKey("IdCustomer")]
    [InverseProperty("ReceptionCertificates")]
    public virtual Customer IdCustomerNavigation { get; set; }

    [ForeignKey("IdLessor")]
    [InverseProperty("ReceptionCertificates")]
    public virtual Lessor IdLessorNavigation { get; set; }

    [ForeignKey("IdProperty")]
    [InverseProperty("ReceptionCertificates")]
    public virtual Property IdPropertyNavigation { get; set; }

    [ForeignKey("IdTenant")]
    [InverseProperty("ReceptionCertificates")]
    public virtual Tenant IdTenantNavigation { get; set; }

    [ForeignKey("IdType")]
    [InverseProperty("ReceptionCertificates")]
    public virtual ReceptionCertificateType IdTypeNavigation { get; set; }

    [ForeignKey("IdUser")]
    [InverseProperty("ReceptionCertificates")]
    public virtual AspNetUser IdUserNavigation { get; set; }

    [InverseProperty("IdReceptionCertificateNavigation")]
    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    [InverseProperty("IdReceptionCertificateNavigation")]
    public virtual ICollection<ReceptionCertificateAreaService> ReceptionCertificateAreaServices { get; set; } = new List<ReceptionCertificateAreaService>();
}