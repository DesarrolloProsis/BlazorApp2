﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Models;

public partial class ReceptionCertificateAreaService
{
    [Key]
    public int Id { get; set; }

    public int? IdArea { get; set; }

    public int? IdService { get; set; }

    public int? IdReceptionCertificate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Notes { get; set; }

    [ForeignKey("IdReceptionCertificate")]
    [InverseProperty("ReceptionCertificateAreaServices")]
    public virtual ReceptionCertificate IdReceptionCertificateNavigation { get; set; }
}