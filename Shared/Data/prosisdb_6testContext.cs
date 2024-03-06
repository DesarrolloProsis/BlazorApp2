﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using BlazorApp2.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Shared.Data;

public partial class prosisdb_6testContext : DbContext
{
    public prosisdb_6testContext(DbContextOptions<prosisdb_6testContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<Blob> Blobs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Description> Descriptions { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryFeatureDescription> InventoryFeatureDescriptions { get; set; }

    public virtual DbSet<Lessor> Lessors { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<PropertyType> PropertyTypes { get; set; }

    public virtual DbSet<ReceptionCertificate> ReceptionCertificates { get; set; }

    public virtual DbSet<ReceptionCertificateAreaService> ReceptionCertificateAreaServices { get; set; }

    public virtual DbSet<ReceptionCertificateType> ReceptionCertificateTypes { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<WeatherForecast1> WeatherForecasts1 { get; set; }

    public virtual DbSet<Weatherforecast> Weatherforecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Areas).HasConstraintName("FK_Areas_Customers");
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("((1))");
            entity.Property(e => e.FirstLogin).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.AspNetUsers).HasConstraintName("FK_AspNetUsers_IDCustomer");
        });

        modelBuilder.Entity<Blob>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Blobs).HasConstraintName("FK_Blobs_Customers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Customers).HasConstraintName("FK_Customers_IdUser");
        });

        modelBuilder.Entity<Description>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Descriptions).HasConstraintName("FK_Descriptions_Customers");
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Features).HasConstraintName("FK_Features_Customers");

            entity.HasMany(d => d.IdDescriptions).WithMany(p => p.IdFeatures)
                .UsingEntity<Dictionary<string, object>>(
                    "FeatureDescription",
                    r => r.HasOne<Description>().WithMany()
                        .HasForeignKey("IdDescription")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FeatureDescriptions_Descriptions"),
                    l => l.HasOne<Feature>().WithMany()
                        .HasForeignKey("IdFeature")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FeatureDescriptions_Features"),
                    j =>
                    {
                        j.HasKey("IdFeature", "IdDescription").HasName("PK_FeatureDescriptions_1");
                        j.ToTable("FeatureDescriptions");
                    });
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Inventories).HasConstraintName("FK_Inventories_Areas");

            entity.HasOne(d => d.IdReceptionCertificateNavigation).WithMany(p => p.Inventories).HasConstraintName("FK_Inventories_ReceptionCertificates");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Inventories).HasConstraintName("FK_Inventories_Services");

            entity.HasMany(d => d.IdBlobs).WithMany(p => p.IdInventories)
                .UsingEntity<Dictionary<string, object>>(
                    "InventoryBlob",
                    r => r.HasOne<Blob>().WithMany()
                        .HasForeignKey("IdBlob")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_InventoryBlobs_Blobs"),
                    l => l.HasOne<Inventory>().WithMany()
                        .HasForeignKey("IdInventory")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_InventoryBlobs_Inventories"),
                    j =>
                    {
                        j.HasKey("IdInventory", "IdBlob");
                        j.ToTable("InventoryBlobs");
                    });
        });

        modelBuilder.Entity<InventoryFeatureDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FeatureDescriptions");

            entity.HasOne(d => d.IdDescriptionNavigation).WithMany(p => p.InventoryFeatureDescriptions).HasConstraintName("FK_InventoryFeatureDescriptions_Descriptions");

            entity.HasOne(d => d.IdFeatureNavigation).WithMany(p => p.InventoryFeatureDescriptions).HasConstraintName("FK_InventoryFeatureDescriptions_Features");

            entity.HasOne(d => d.IdInventoryNavigation).WithMany(p => p.InventoryFeatureDescriptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InventoryFeatureDescriptions_Inventories");
        });

        modelBuilder.Entity<Lessor>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Lessors).HasConstraintName("FK_Lessors_Customers");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Properties).HasConstraintName("FK_Properties_Customers");

            entity.HasOne(d => d.IdLessorNavigation).WithMany(p => p.Properties).HasConstraintName("FK_Properties_Lessors");

            entity.HasOne(d => d.IdPropertyTypeNavigation).WithMany(p => p.Properties).HasConstraintName("FK_Property_IdPropertyType");
        });

        modelBuilder.Entity<ReceptionCertificate>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_Customers");

            entity.HasOne(d => d.IdLessorNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_Lessors");

            entity.HasOne(d => d.IdPropertyNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_Properties");

            entity.HasOne(d => d.IdTenantNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_Tenants");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_IdType");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ReceptionCertificates).HasConstraintName("FK_ReceptionCertificates_IdUser");
        });

        modelBuilder.Entity<ReceptionCertificateAreaService>(entity =>
        {
            entity.HasOne(d => d.IdReceptionCertificateNavigation).WithMany(p => p.ReceptionCertificateAreaServices).HasConstraintName("FK_ReceptionCertificateAreaServices_ReceptionCertificates");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Services).HasConstraintName("FK_Services_Customers");

            entity.HasMany(d => d.IdFeatures).WithMany(p => p.IdServices)
                .UsingEntity<Dictionary<string, object>>(
                    "ServiceFeature",
                    r => r.HasOne<Feature>().WithMany()
                        .HasForeignKey("IdFeature")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ServiceFeatures_Features"),
                    l => l.HasOne<Service>().WithMany()
                        .HasForeignKey("IdService")
                        .HasConstraintName("FK_ServiceFeatures_Services"),
                    j =>
                    {
                        j.HasKey("IdService", "IdFeature");
                        j.ToTable("ServiceFeatures");
                    });
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Subscriptions).HasConstraintName("FK_Subscriptions_Customers");
        });

        modelBuilder.Entity<Weatherforecast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WeatherforecastID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}