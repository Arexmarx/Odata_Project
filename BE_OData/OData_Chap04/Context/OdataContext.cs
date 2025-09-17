using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OData_Chap04.Entity;

namespace OData_Chap04.Context;

public partial class ODataContext : DbContext
{
    public ODataContext()
    {
    }

    public ODataContext(DbContextOptions<ODataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Confirmed> Confirmeds { get; set; }

    public virtual DbSet<DailyReport> DailyReports { get; set; }

    public virtual DbSet<Death> Deaths { get; set; }

    public virtual DbSet<Recovered> Recovereds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Confirmed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__confirme__3214EC07B4EB2CCE");

            entity.ToTable("confirmed");

            entity.HasIndex(e => new { e.CountryRegion, e.Date }, "IX_confirmed_country_date");

            entity.HasIndex(e => e.Date, "IX_confirmed_date");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
        });

        modelBuilder.Entity<DailyReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__daily_re__3214EC0735303913");

            entity.ToTable("daily_reports");

            entity.Property(e => e.Active).HasMaxLength(512);
            entity.Property(e => e.CaseFatalityRatio).HasColumnName("Case_Fatality_Ratio");
            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country_Region");
            entity.Property(e => e.Date).HasMaxLength(512);
            entity.Property(e => e.Fips).HasColumnName("FIPS");
            entity.Property(e => e.HospitalizationRate)
                .HasMaxLength(512)
                .HasColumnName("Hospitalization_Rate");
            entity.Property(e => e.IncidentRate).HasColumnName("Incident_Rate");
            entity.Property(e => e.Iso3)
                .HasMaxLength(512)
                .HasColumnName("ISO3");
            entity.Property(e => e.LastUpdate)
                .HasMaxLength(512)
                .HasColumnName("Last_Update");
            entity.Property(e => e.Long).HasColumnName("Long_");
            entity.Property(e => e.MortalityRate)
                .HasMaxLength(512)
                .HasColumnName("Mortality_Rate");
            entity.Property(e => e.PeopleHospitalized)
                .HasMaxLength(512)
                .HasColumnName("People_Hospitalized");
            entity.Property(e => e.PeopleTested)
                .HasMaxLength(512)
                .HasColumnName("People_Tested");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province_State");
            entity.Property(e => e.Recovered).HasMaxLength(512);
            entity.Property(e => e.TestingRate).HasColumnName("Testing_Rate");
            entity.Property(e => e.TotalTestResults).HasColumnName("Total_Test_Results");
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<Death>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__deaths__3214EC07F1083003");

            entity.ToTable("deaths");

            entity.HasIndex(e => new { e.CountryRegion, e.Date }, "IX_deaths_country_date");

            entity.HasIndex(e => e.Date, "IX_deaths_date");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
        });

        modelBuilder.Entity<Recovered>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__recovere__3214EC07D46CB707");

            entity.ToTable("recovered");

            entity.HasIndex(e => new { e.CountryRegion, e.Date }, "IX_deaths_country_date");

            entity.HasIndex(e => e.Date, "IX_recovered_date");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
