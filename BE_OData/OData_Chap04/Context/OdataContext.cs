using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OData_Chap04.Entity;

namespace OData_Chap04.Context;

public partial class OdataContext : DbContext
{
    public OdataContext()
    {
    }

    public OdataContext(DbContextOptions<OdataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Confirmed> Confirmeds { get; set; }

    public virtual DbSet<DailyReport> DailyReports { get; set; }

    public virtual DbSet<Death> Deaths { get; set; }

    public virtual DbSet<Required> Requireds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Confirmed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("confirmed");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
            entity.Property(e => e._101020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/10/20");
            entity.Property(e => e._101120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/11/20");
            entity.Property(e => e._10120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/1/20");
            entity.Property(e => e._101220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/12/20");
            entity.Property(e => e._101320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/13/20");
            entity.Property(e => e._101420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/14/20");
            entity.Property(e => e._101520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/15/20");
            entity.Property(e => e._101620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/16/20");
            entity.Property(e => e._101720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/17/20");
            entity.Property(e => e._101820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/18/20");
            entity.Property(e => e._101920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/19/20");
            entity.Property(e => e._102020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/20/20");
            entity.Property(e => e._102120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/21/20");
            entity.Property(e => e._10220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/2/20");
            entity.Property(e => e._102220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/22/20");
            entity.Property(e => e._102320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/23/20");
            entity.Property(e => e._102420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/24/20");
            entity.Property(e => e._102520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/25/20");
            entity.Property(e => e._102620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/26/20");
            entity.Property(e => e._102720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/27/20");
            entity.Property(e => e._102820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/28/20");
            entity.Property(e => e._102920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/29/20");
            entity.Property(e => e._103020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/30/20");
            entity.Property(e => e._103120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/31/20");
            entity.Property(e => e._10320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/3/20");
            entity.Property(e => e._10420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/4/20");
            entity.Property(e => e._10520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/5/20");
            entity.Property(e => e._10620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/6/20");
            entity.Property(e => e._10720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/7/20");
            entity.Property(e => e._10820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/8/20");
            entity.Property(e => e._10920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/9/20");
            entity.Property(e => e._11023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/10/23");
            entity.Property(e => e._111020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/10/20");
            entity.Property(e => e._111120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/11/20");
            entity.Property(e => e._11120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/1/20");
            entity.Property(e => e._111220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/12/20");
            entity.Property(e => e._11123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/11/23");
            entity.Property(e => e._111320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/13/20");
            entity.Property(e => e._111420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/14/20");
            entity.Property(e => e._111520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/15/20");
            entity.Property(e => e._111620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/16/20");
            entity.Property(e => e._111720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/17/20");
            entity.Property(e => e._111820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/18/20");
            entity.Property(e => e._111920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/19/20");
            entity.Property(e => e._112020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/20/20");
            entity.Property(e => e._112120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/21/20");
            entity.Property(e => e._11220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/2/20");
            entity.Property(e => e._112220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/22/20");
            entity.Property(e => e._11223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/12/23");
            entity.Property(e => e._1123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/1/23");
            entity.Property(e => e._112320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/23/20");
            entity.Property(e => e._112420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/24/20");
            entity.Property(e => e._112520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/25/20");
            entity.Property(e => e._112620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/26/20");
            entity.Property(e => e._112720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/27/20");
            entity.Property(e => e._112820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/28/20");
            entity.Property(e => e._112920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/29/20");
            entity.Property(e => e._113020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/30/20");
            entity.Property(e => e._11320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/3/20");
            entity.Property(e => e._11323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/13/23");
            entity.Property(e => e._11420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/4/20");
            entity.Property(e => e._11423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/14/23");
            entity.Property(e => e._11520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/5/20");
            entity.Property(e => e._11523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/15/23");
            entity.Property(e => e._11620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/6/20");
            entity.Property(e => e._11623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/16/23");
            entity.Property(e => e._11720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/7/20");
            entity.Property(e => e._11723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/17/23");
            entity.Property(e => e._11820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/8/20");
            entity.Property(e => e._11823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/18/23");
            entity.Property(e => e._11920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/9/20");
            entity.Property(e => e._11923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/19/23");
            entity.Property(e => e._12023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/20/23");
            entity.Property(e => e._121020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/10/20");
            entity.Property(e => e._121120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/11/20");
            entity.Property(e => e._12120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/1/20");
            entity.Property(e => e._121220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/12/20");
            entity.Property(e => e._12123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/21/23");
            entity.Property(e => e._121320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/13/20");
            entity.Property(e => e._121420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/14/20");
            entity.Property(e => e._121520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/15/20");
            entity.Property(e => e._121620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/16/20");
            entity.Property(e => e._121720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/17/20");
            entity.Property(e => e._121820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/18/20");
            entity.Property(e => e._121920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/19/20");
            entity.Property(e => e._122020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/20/20");
            entity.Property(e => e._122120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/21/20");
            entity.Property(e => e._12220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/20");
            entity.Property(e => e._122201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/2/20");
            entity.Property(e => e._122220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/22/20");
            entity.Property(e => e._12223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/23");
            entity.Property(e => e._1223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/2/23");
            entity.Property(e => e._122320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/23/20");
            entity.Property(e => e._122420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/24/20");
            entity.Property(e => e._122520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/25/20");
            entity.Property(e => e._122620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/26/20");
            entity.Property(e => e._122720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/27/20");
            entity.Property(e => e._122820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/28/20");
            entity.Property(e => e._122920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/29/20");
            entity.Property(e => e._123020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/30/20");
            entity.Property(e => e._123120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/31/20");
            entity.Property(e => e._12320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/20");
            entity.Property(e => e._123201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/3/20");
            entity.Property(e => e._12323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/23");
            entity.Property(e => e._12420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/20");
            entity.Property(e => e._124201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/4/20");
            entity.Property(e => e._12423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/23");
            entity.Property(e => e._12520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/20");
            entity.Property(e => e._125201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/5/20");
            entity.Property(e => e._12523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/23");
            entity.Property(e => e._12620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/20");
            entity.Property(e => e._126201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/6/20");
            entity.Property(e => e._12623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/23");
            entity.Property(e => e._12720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/20");
            entity.Property(e => e._127201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/7/20");
            entity.Property(e => e._12723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/23");
            entity.Property(e => e._12820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/20");
            entity.Property(e => e._128201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/8/20");
            entity.Property(e => e._12823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/23");
            entity.Property(e => e._12920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/20");
            entity.Property(e => e._129201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/9/20");
            entity.Property(e => e._12923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/23");
            entity.Property(e => e._13020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/20");
            entity.Property(e => e._13023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/23");
            entity.Property(e => e._13120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/20");
            entity.Property(e => e._13123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/23");
            entity.Property(e => e._1323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/3/23");
            entity.Property(e => e._1423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/4/23");
            entity.Property(e => e._1523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/5/23");
            entity.Property(e => e._1623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/6/23");
            entity.Property(e => e._1723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/7/23");
            entity.Property(e => e._1823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/8/23");
            entity.Property(e => e._1923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/9/23");
            entity.Property(e => e._21020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/20");
            entity.Property(e => e._21023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/23");
            entity.Property(e => e._21120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/20");
            entity.Property(e => e._21123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/23");
            entity.Property(e => e._2120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/20");
            entity.Property(e => e._21220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/20");
            entity.Property(e => e._21223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/23");
            entity.Property(e => e._2123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/23");
            entity.Property(e => e._21320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/20");
            entity.Property(e => e._21323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/23");
            entity.Property(e => e._21420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/20");
            entity.Property(e => e._21423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/23");
            entity.Property(e => e._21520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/20");
            entity.Property(e => e._21523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/23");
            entity.Property(e => e._21620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/20");
            entity.Property(e => e._21623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/23");
            entity.Property(e => e._21720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/20");
            entity.Property(e => e._21723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/23");
            entity.Property(e => e._21820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/20");
            entity.Property(e => e._21823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/23");
            entity.Property(e => e._21920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/20");
            entity.Property(e => e._21923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/23");
            entity.Property(e => e._22020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/20");
            entity.Property(e => e._22023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/23");
            entity.Property(e => e._22120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/20");
            entity.Property(e => e._22123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/23");
            entity.Property(e => e._2220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/20");
            entity.Property(e => e._22220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/20");
            entity.Property(e => e._22223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/23");
            entity.Property(e => e._2223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/23");
            entity.Property(e => e._22320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/20");
            entity.Property(e => e._22323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/23");
            entity.Property(e => e._22420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/20");
            entity.Property(e => e._22423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/23");
            entity.Property(e => e._22520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/20");
            entity.Property(e => e._22523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/23");
            entity.Property(e => e._22620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/20");
            entity.Property(e => e._22623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/23");
            entity.Property(e => e._22720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/20");
            entity.Property(e => e._22723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/23");
            entity.Property(e => e._22820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/20");
            entity.Property(e => e._22823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/23");
            entity.Property(e => e._22920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/29/20");
            entity.Property(e => e._2320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/20");
            entity.Property(e => e._2323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/23");
            entity.Property(e => e._2420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/20");
            entity.Property(e => e._2423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/23");
            entity.Property(e => e._2520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/20");
            entity.Property(e => e._2523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/23");
            entity.Property(e => e._2620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/20");
            entity.Property(e => e._2623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/23");
            entity.Property(e => e._2720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/20");
            entity.Property(e => e._2723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/23");
            entity.Property(e => e._2820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/20");
            entity.Property(e => e._2823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/23");
            entity.Property(e => e._2920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/20");
            entity.Property(e => e._2923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/23");
            entity.Property(e => e._31020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/10/20");
            entity.Property(e => e._31120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/11/20");
            entity.Property(e => e._3120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/20");
            entity.Property(e => e._31220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/12/20");
            entity.Property(e => e._3123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/23");
            entity.Property(e => e._31320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/13/20");
            entity.Property(e => e._31420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/14/20");
            entity.Property(e => e._31520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/15/20");
            entity.Property(e => e._31620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/16/20");
            entity.Property(e => e._31720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/17/20");
            entity.Property(e => e._31820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/18/20");
            entity.Property(e => e._31920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/19/20");
            entity.Property(e => e._32020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/20/20");
            entity.Property(e => e._32120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/21/20");
            entity.Property(e => e._3220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/20");
            entity.Property(e => e._32220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/22/20");
            entity.Property(e => e._3223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/23");
            entity.Property(e => e._32320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/23/20");
            entity.Property(e => e._32420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/24/20");
            entity.Property(e => e._32520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/25/20");
            entity.Property(e => e._32620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/26/20");
            entity.Property(e => e._32720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/27/20");
            entity.Property(e => e._32820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/28/20");
            entity.Property(e => e._32920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/29/20");
            entity.Property(e => e._33020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/30/20");
            entity.Property(e => e._33120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/31/20");
            entity.Property(e => e._3320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/20");
            entity.Property(e => e._3323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/23");
            entity.Property(e => e._3420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/20");
            entity.Property(e => e._3423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/23");
            entity.Property(e => e._3520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/20");
            entity.Property(e => e._3523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/23");
            entity.Property(e => e._3620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/20");
            entity.Property(e => e._3623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/23");
            entity.Property(e => e._3720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/20");
            entity.Property(e => e._3723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/23");
            entity.Property(e => e._3820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/20");
            entity.Property(e => e._3823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/23");
            entity.Property(e => e._3920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/20");
            entity.Property(e => e._3923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/23");
            entity.Property(e => e._41020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/10/20");
            entity.Property(e => e._41120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/11/20");
            entity.Property(e => e._4120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/1/20");
            entity.Property(e => e._41220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/12/20");
            entity.Property(e => e._41320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/13/20");
            entity.Property(e => e._41420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/14/20");
            entity.Property(e => e._41520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/15/20");
            entity.Property(e => e._41620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/16/20");
            entity.Property(e => e._41720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/17/20");
            entity.Property(e => e._41820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/18/20");
            entity.Property(e => e._41920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/19/20");
            entity.Property(e => e._42020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/20/20");
            entity.Property(e => e._42120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/21/20");
            entity.Property(e => e._4220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/2/20");
            entity.Property(e => e._42220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/22/20");
            entity.Property(e => e._42320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/23/20");
            entity.Property(e => e._42420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/24/20");
            entity.Property(e => e._42520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/25/20");
            entity.Property(e => e._42620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/26/20");
            entity.Property(e => e._42720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/27/20");
            entity.Property(e => e._42820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/28/20");
            entity.Property(e => e._42920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/29/20");
            entity.Property(e => e._43020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/30/20");
            entity.Property(e => e._4320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/3/20");
            entity.Property(e => e._4420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/4/20");
            entity.Property(e => e._4520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/5/20");
            entity.Property(e => e._4620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/6/20");
            entity.Property(e => e._4720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/7/20");
            entity.Property(e => e._4820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/8/20");
            entity.Property(e => e._4920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/9/20");
            entity.Property(e => e._51020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/10/20");
            entity.Property(e => e._51120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/11/20");
            entity.Property(e => e._5120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/1/20");
            entity.Property(e => e._51220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/12/20");
            entity.Property(e => e._51320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/13/20");
            entity.Property(e => e._51420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/14/20");
            entity.Property(e => e._51520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/15/20");
            entity.Property(e => e._51620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/16/20");
            entity.Property(e => e._51720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/17/20");
            entity.Property(e => e._51820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/18/20");
            entity.Property(e => e._51920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/19/20");
            entity.Property(e => e._52020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/20/20");
            entity.Property(e => e._52120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/21/20");
            entity.Property(e => e._5220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/2/20");
            entity.Property(e => e._52220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/22/20");
            entity.Property(e => e._52320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/23/20");
            entity.Property(e => e._52420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/24/20");
            entity.Property(e => e._52520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/25/20");
            entity.Property(e => e._52620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/26/20");
            entity.Property(e => e._52720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/27/20");
            entity.Property(e => e._52820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/28/20");
            entity.Property(e => e._52920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/29/20");
            entity.Property(e => e._53020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/30/20");
            entity.Property(e => e._53120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/31/20");
            entity.Property(e => e._5320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/3/20");
            entity.Property(e => e._5420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/4/20");
            entity.Property(e => e._5520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/5/20");
            entity.Property(e => e._5620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/6/20");
            entity.Property(e => e._5720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/7/20");
            entity.Property(e => e._5820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/8/20");
            entity.Property(e => e._5920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/9/20");
            entity.Property(e => e._61020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/10/20");
            entity.Property(e => e._61120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/11/20");
            entity.Property(e => e._6120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/1/20");
            entity.Property(e => e._61220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/12/20");
            entity.Property(e => e._61320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/13/20");
            entity.Property(e => e._61420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/14/20");
            entity.Property(e => e._61520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/15/20");
            entity.Property(e => e._61620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/16/20");
            entity.Property(e => e._61720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/17/20");
            entity.Property(e => e._61820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/18/20");
            entity.Property(e => e._61920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/19/20");
            entity.Property(e => e._62020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/20/20");
            entity.Property(e => e._62120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/21/20");
            entity.Property(e => e._6220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/2/20");
            entity.Property(e => e._62220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/22/20");
            entity.Property(e => e._62320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/23/20");
            entity.Property(e => e._62420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/24/20");
            entity.Property(e => e._62520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/25/20");
            entity.Property(e => e._62620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/26/20");
            entity.Property(e => e._62720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/27/20");
            entity.Property(e => e._62820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/28/20");
            entity.Property(e => e._62920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/29/20");
            entity.Property(e => e._63020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/30/20");
            entity.Property(e => e._6320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/3/20");
            entity.Property(e => e._6420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/4/20");
            entity.Property(e => e._6520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/5/20");
            entity.Property(e => e._6620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/6/20");
            entity.Property(e => e._6720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/7/20");
            entity.Property(e => e._6820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/8/20");
            entity.Property(e => e._6920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/9/20");
            entity.Property(e => e._71020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/10/20");
            entity.Property(e => e._71120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/11/20");
            entity.Property(e => e._7120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/1/20");
            entity.Property(e => e._71220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/12/20");
            entity.Property(e => e._71320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/13/20");
            entity.Property(e => e._71420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/14/20");
            entity.Property(e => e._71520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/15/20");
            entity.Property(e => e._71620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/16/20");
            entity.Property(e => e._71720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/17/20");
            entity.Property(e => e._71820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/18/20");
            entity.Property(e => e._71920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/19/20");
            entity.Property(e => e._72020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/20/20");
            entity.Property(e => e._72120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/21/20");
            entity.Property(e => e._7220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/2/20");
            entity.Property(e => e._72220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/22/20");
            entity.Property(e => e._72320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/23/20");
            entity.Property(e => e._72420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/24/20");
            entity.Property(e => e._72520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/25/20");
            entity.Property(e => e._72620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/26/20");
            entity.Property(e => e._72720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/27/20");
            entity.Property(e => e._72820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/28/20");
            entity.Property(e => e._72920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/29/20");
            entity.Property(e => e._73020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/30/20");
            entity.Property(e => e._73120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/31/20");
            entity.Property(e => e._7320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/3/20");
            entity.Property(e => e._7420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/4/20");
            entity.Property(e => e._7520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/5/20");
            entity.Property(e => e._7620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/6/20");
            entity.Property(e => e._7720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/7/20");
            entity.Property(e => e._7820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/8/20");
            entity.Property(e => e._7920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/9/20");
            entity.Property(e => e._81020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/10/20");
            entity.Property(e => e._81120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/11/20");
            entity.Property(e => e._8120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/1/20");
            entity.Property(e => e._81220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/12/20");
            entity.Property(e => e._81320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/13/20");
            entity.Property(e => e._81420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/14/20");
            entity.Property(e => e._81520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/15/20");
            entity.Property(e => e._81620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/16/20");
            entity.Property(e => e._81720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/17/20");
            entity.Property(e => e._81820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/18/20");
            entity.Property(e => e._81920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/19/20");
            entity.Property(e => e._82020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/20/20");
            entity.Property(e => e._82120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/21/20");
            entity.Property(e => e._8220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/2/20");
            entity.Property(e => e._82220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/22/20");
            entity.Property(e => e._82320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/23/20");
            entity.Property(e => e._82420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/24/20");
            entity.Property(e => e._82520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/25/20");
            entity.Property(e => e._82620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/26/20");
            entity.Property(e => e._82720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/27/20");
            entity.Property(e => e._82820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/28/20");
            entity.Property(e => e._82920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/29/20");
            entity.Property(e => e._83020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/30/20");
            entity.Property(e => e._83120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/31/20");
            entity.Property(e => e._8320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/3/20");
            entity.Property(e => e._8420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/4/20");
            entity.Property(e => e._8520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/5/20");
            entity.Property(e => e._8620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/6/20");
            entity.Property(e => e._8720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/7/20");
            entity.Property(e => e._8820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/8/20");
            entity.Property(e => e._8920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/9/20");
            entity.Property(e => e._91020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/10/20");
            entity.Property(e => e._91120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/11/20");
            entity.Property(e => e._9120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/1/20");
            entity.Property(e => e._91220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/12/20");
            entity.Property(e => e._91320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/13/20");
            entity.Property(e => e._91420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/14/20");
            entity.Property(e => e._91520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/15/20");
            entity.Property(e => e._91620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/16/20");
            entity.Property(e => e._91720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/17/20");
            entity.Property(e => e._91820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/18/20");
            entity.Property(e => e._91920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/19/20");
            entity.Property(e => e._92020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/20/20");
            entity.Property(e => e._92120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/21/20");
            entity.Property(e => e._9220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/2/20");
            entity.Property(e => e._92220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/22/20");
            entity.Property(e => e._92320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/23/20");
            entity.Property(e => e._92420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/24/20");
            entity.Property(e => e._92520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/25/20");
            entity.Property(e => e._92620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/26/20");
            entity.Property(e => e._92720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/27/20");
            entity.Property(e => e._92820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/28/20");
            entity.Property(e => e._92920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/29/20");
            entity.Property(e => e._93020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/30/20");
            entity.Property(e => e._9320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/3/20");
            entity.Property(e => e._9420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/4/20");
            entity.Property(e => e._9520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/5/20");
            entity.Property(e => e._9620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/6/20");
            entity.Property(e => e._9720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/7/20");
            entity.Property(e => e._9820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/8/20");
            entity.Property(e => e._9920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/9/20");
        });

        modelBuilder.Entity<DailyReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("daily_reports");

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
            entity
                .HasNoKey()
                .ToTable("deaths");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
            entity.Property(e => e._101020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/10/20");
            entity.Property(e => e._101120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/11/20");
            entity.Property(e => e._10120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/1/20");
            entity.Property(e => e._101220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/12/20");
            entity.Property(e => e._101320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/13/20");
            entity.Property(e => e._101420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/14/20");
            entity.Property(e => e._101520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/15/20");
            entity.Property(e => e._101620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/16/20");
            entity.Property(e => e._101720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/17/20");
            entity.Property(e => e._101820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/18/20");
            entity.Property(e => e._101920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/19/20");
            entity.Property(e => e._102020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/20/20");
            entity.Property(e => e._102120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/21/20");
            entity.Property(e => e._10220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/2/20");
            entity.Property(e => e._102220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/22/20");
            entity.Property(e => e._102320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/23/20");
            entity.Property(e => e._102420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/24/20");
            entity.Property(e => e._102520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/25/20");
            entity.Property(e => e._102620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/26/20");
            entity.Property(e => e._102720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/27/20");
            entity.Property(e => e._102820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/28/20");
            entity.Property(e => e._102920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/29/20");
            entity.Property(e => e._103020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/30/20");
            entity.Property(e => e._103120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/31/20");
            entity.Property(e => e._10320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/3/20");
            entity.Property(e => e._10420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/4/20");
            entity.Property(e => e._10520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/5/20");
            entity.Property(e => e._10620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/6/20");
            entity.Property(e => e._10720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/7/20");
            entity.Property(e => e._10820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/8/20");
            entity.Property(e => e._10920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/9/20");
            entity.Property(e => e._11023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/10/23");
            entity.Property(e => e._111020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/10/20");
            entity.Property(e => e._111120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/11/20");
            entity.Property(e => e._11120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/1/20");
            entity.Property(e => e._111220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/12/20");
            entity.Property(e => e._11123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/11/23");
            entity.Property(e => e._111320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/13/20");
            entity.Property(e => e._111420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/14/20");
            entity.Property(e => e._111520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/15/20");
            entity.Property(e => e._111620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/16/20");
            entity.Property(e => e._111720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/17/20");
            entity.Property(e => e._111820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/18/20");
            entity.Property(e => e._111920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/19/20");
            entity.Property(e => e._112020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/20/20");
            entity.Property(e => e._112120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/21/20");
            entity.Property(e => e._11220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/2/20");
            entity.Property(e => e._112220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/22/20");
            entity.Property(e => e._11223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/12/23");
            entity.Property(e => e._1123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/1/23");
            entity.Property(e => e._112320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/23/20");
            entity.Property(e => e._112420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/24/20");
            entity.Property(e => e._112520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/25/20");
            entity.Property(e => e._112620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/26/20");
            entity.Property(e => e._112720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/27/20");
            entity.Property(e => e._112820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/28/20");
            entity.Property(e => e._112920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/29/20");
            entity.Property(e => e._113020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/30/20");
            entity.Property(e => e._11320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/3/20");
            entity.Property(e => e._11323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/13/23");
            entity.Property(e => e._11420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/4/20");
            entity.Property(e => e._11423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/14/23");
            entity.Property(e => e._11520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/5/20");
            entity.Property(e => e._11523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/15/23");
            entity.Property(e => e._11620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/6/20");
            entity.Property(e => e._11623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/16/23");
            entity.Property(e => e._11720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/7/20");
            entity.Property(e => e._11723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/17/23");
            entity.Property(e => e._11820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/8/20");
            entity.Property(e => e._11823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/18/23");
            entity.Property(e => e._11920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/9/20");
            entity.Property(e => e._11923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/19/23");
            entity.Property(e => e._12023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/20/23");
            entity.Property(e => e._121020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/10/20");
            entity.Property(e => e._121120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/11/20");
            entity.Property(e => e._12120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/1/20");
            entity.Property(e => e._121220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/12/20");
            entity.Property(e => e._12123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/21/23");
            entity.Property(e => e._121320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/13/20");
            entity.Property(e => e._121420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/14/20");
            entity.Property(e => e._121520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/15/20");
            entity.Property(e => e._121620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/16/20");
            entity.Property(e => e._121720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/17/20");
            entity.Property(e => e._121820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/18/20");
            entity.Property(e => e._121920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/19/20");
            entity.Property(e => e._122020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/20/20");
            entity.Property(e => e._122120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/21/20");
            entity.Property(e => e._12220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/20");
            entity.Property(e => e._122201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/2/20");
            entity.Property(e => e._122220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/22/20");
            entity.Property(e => e._12223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/23");
            entity.Property(e => e._1223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/2/23");
            entity.Property(e => e._122320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/23/20");
            entity.Property(e => e._122420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/24/20");
            entity.Property(e => e._122520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/25/20");
            entity.Property(e => e._122620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/26/20");
            entity.Property(e => e._122720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/27/20");
            entity.Property(e => e._122820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/28/20");
            entity.Property(e => e._122920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/29/20");
            entity.Property(e => e._123020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/30/20");
            entity.Property(e => e._123120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/31/20");
            entity.Property(e => e._12320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/20");
            entity.Property(e => e._123201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/3/20");
            entity.Property(e => e._12323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/23");
            entity.Property(e => e._12420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/20");
            entity.Property(e => e._124201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/4/20");
            entity.Property(e => e._12423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/23");
            entity.Property(e => e._12520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/20");
            entity.Property(e => e._125201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/5/20");
            entity.Property(e => e._12523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/23");
            entity.Property(e => e._12620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/20");
            entity.Property(e => e._126201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/6/20");
            entity.Property(e => e._12623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/23");
            entity.Property(e => e._12720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/20");
            entity.Property(e => e._127201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/7/20");
            entity.Property(e => e._12723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/23");
            entity.Property(e => e._12820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/20");
            entity.Property(e => e._128201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/8/20");
            entity.Property(e => e._12823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/23");
            entity.Property(e => e._12920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/20");
            entity.Property(e => e._129201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/9/20");
            entity.Property(e => e._12923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/23");
            entity.Property(e => e._13020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/20");
            entity.Property(e => e._13023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/23");
            entity.Property(e => e._13120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/20");
            entity.Property(e => e._13123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/23");
            entity.Property(e => e._1323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/3/23");
            entity.Property(e => e._1423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/4/23");
            entity.Property(e => e._1523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/5/23");
            entity.Property(e => e._1623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/6/23");
            entity.Property(e => e._1723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/7/23");
            entity.Property(e => e._1823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/8/23");
            entity.Property(e => e._1923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/9/23");
            entity.Property(e => e._21020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/20");
            entity.Property(e => e._21023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/23");
            entity.Property(e => e._21120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/20");
            entity.Property(e => e._21123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/23");
            entity.Property(e => e._2120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/20");
            entity.Property(e => e._21220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/20");
            entity.Property(e => e._21223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/23");
            entity.Property(e => e._2123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/23");
            entity.Property(e => e._21320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/20");
            entity.Property(e => e._21323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/23");
            entity.Property(e => e._21420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/20");
            entity.Property(e => e._21423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/23");
            entity.Property(e => e._21520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/20");
            entity.Property(e => e._21523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/23");
            entity.Property(e => e._21620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/20");
            entity.Property(e => e._21623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/23");
            entity.Property(e => e._21720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/20");
            entity.Property(e => e._21723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/23");
            entity.Property(e => e._21820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/20");
            entity.Property(e => e._21823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/23");
            entity.Property(e => e._21920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/20");
            entity.Property(e => e._21923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/23");
            entity.Property(e => e._22020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/20");
            entity.Property(e => e._22023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/23");
            entity.Property(e => e._22120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/20");
            entity.Property(e => e._22123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/23");
            entity.Property(e => e._2220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/20");
            entity.Property(e => e._22220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/20");
            entity.Property(e => e._22223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/23");
            entity.Property(e => e._2223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/23");
            entity.Property(e => e._22320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/20");
            entity.Property(e => e._22323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/23");
            entity.Property(e => e._22420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/20");
            entity.Property(e => e._22423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/23");
            entity.Property(e => e._22520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/20");
            entity.Property(e => e._22523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/23");
            entity.Property(e => e._22620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/20");
            entity.Property(e => e._22623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/23");
            entity.Property(e => e._22720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/20");
            entity.Property(e => e._22723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/23");
            entity.Property(e => e._22820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/20");
            entity.Property(e => e._22823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/23");
            entity.Property(e => e._22920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/29/20");
            entity.Property(e => e._2320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/20");
            entity.Property(e => e._2323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/23");
            entity.Property(e => e._2420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/20");
            entity.Property(e => e._2423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/23");
            entity.Property(e => e._2520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/20");
            entity.Property(e => e._2523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/23");
            entity.Property(e => e._2620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/20");
            entity.Property(e => e._2623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/23");
            entity.Property(e => e._2720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/20");
            entity.Property(e => e._2723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/23");
            entity.Property(e => e._2820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/20");
            entity.Property(e => e._2823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/23");
            entity.Property(e => e._2920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/20");
            entity.Property(e => e._2923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/23");
            entity.Property(e => e._31020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/10/20");
            entity.Property(e => e._31120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/11/20");
            entity.Property(e => e._3120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/20");
            entity.Property(e => e._31220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/12/20");
            entity.Property(e => e._3123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/23");
            entity.Property(e => e._31320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/13/20");
            entity.Property(e => e._31420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/14/20");
            entity.Property(e => e._31520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/15/20");
            entity.Property(e => e._31620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/16/20");
            entity.Property(e => e._31720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/17/20");
            entity.Property(e => e._31820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/18/20");
            entity.Property(e => e._31920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/19/20");
            entity.Property(e => e._32020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/20/20");
            entity.Property(e => e._32120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/21/20");
            entity.Property(e => e._3220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/20");
            entity.Property(e => e._32220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/22/20");
            entity.Property(e => e._3223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/23");
            entity.Property(e => e._32320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/23/20");
            entity.Property(e => e._32420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/24/20");
            entity.Property(e => e._32520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/25/20");
            entity.Property(e => e._32620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/26/20");
            entity.Property(e => e._32720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/27/20");
            entity.Property(e => e._32820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/28/20");
            entity.Property(e => e._32920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/29/20");
            entity.Property(e => e._33020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/30/20");
            entity.Property(e => e._33120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/31/20");
            entity.Property(e => e._3320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/20");
            entity.Property(e => e._3323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/23");
            entity.Property(e => e._3420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/20");
            entity.Property(e => e._3423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/23");
            entity.Property(e => e._3520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/20");
            entity.Property(e => e._3523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/23");
            entity.Property(e => e._3620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/20");
            entity.Property(e => e._3623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/23");
            entity.Property(e => e._3720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/20");
            entity.Property(e => e._3723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/23");
            entity.Property(e => e._3820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/20");
            entity.Property(e => e._3823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/23");
            entity.Property(e => e._3920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/20");
            entity.Property(e => e._3923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/23");
            entity.Property(e => e._41020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/10/20");
            entity.Property(e => e._41120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/11/20");
            entity.Property(e => e._4120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/1/20");
            entity.Property(e => e._41220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/12/20");
            entity.Property(e => e._41320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/13/20");
            entity.Property(e => e._41420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/14/20");
            entity.Property(e => e._41520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/15/20");
            entity.Property(e => e._41620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/16/20");
            entity.Property(e => e._41720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/17/20");
            entity.Property(e => e._41820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/18/20");
            entity.Property(e => e._41920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/19/20");
            entity.Property(e => e._42020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/20/20");
            entity.Property(e => e._42120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/21/20");
            entity.Property(e => e._4220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/2/20");
            entity.Property(e => e._42220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/22/20");
            entity.Property(e => e._42320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/23/20");
            entity.Property(e => e._42420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/24/20");
            entity.Property(e => e._42520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/25/20");
            entity.Property(e => e._42620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/26/20");
            entity.Property(e => e._42720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/27/20");
            entity.Property(e => e._42820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/28/20");
            entity.Property(e => e._42920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/29/20");
            entity.Property(e => e._43020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/30/20");
            entity.Property(e => e._4320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/3/20");
            entity.Property(e => e._4420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/4/20");
            entity.Property(e => e._4520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/5/20");
            entity.Property(e => e._4620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/6/20");
            entity.Property(e => e._4720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/7/20");
            entity.Property(e => e._4820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/8/20");
            entity.Property(e => e._4920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/9/20");
            entity.Property(e => e._51020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/10/20");
            entity.Property(e => e._51120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/11/20");
            entity.Property(e => e._5120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/1/20");
            entity.Property(e => e._51220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/12/20");
            entity.Property(e => e._51320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/13/20");
            entity.Property(e => e._51420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/14/20");
            entity.Property(e => e._51520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/15/20");
            entity.Property(e => e._51620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/16/20");
            entity.Property(e => e._51720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/17/20");
            entity.Property(e => e._51820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/18/20");
            entity.Property(e => e._51920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/19/20");
            entity.Property(e => e._52020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/20/20");
            entity.Property(e => e._52120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/21/20");
            entity.Property(e => e._5220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/2/20");
            entity.Property(e => e._52220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/22/20");
            entity.Property(e => e._52320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/23/20");
            entity.Property(e => e._52420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/24/20");
            entity.Property(e => e._52520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/25/20");
            entity.Property(e => e._52620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/26/20");
            entity.Property(e => e._52720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/27/20");
            entity.Property(e => e._52820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/28/20");
            entity.Property(e => e._52920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/29/20");
            entity.Property(e => e._53020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/30/20");
            entity.Property(e => e._53120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/31/20");
            entity.Property(e => e._5320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/3/20");
            entity.Property(e => e._5420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/4/20");
            entity.Property(e => e._5520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/5/20");
            entity.Property(e => e._5620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/6/20");
            entity.Property(e => e._5720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/7/20");
            entity.Property(e => e._5820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/8/20");
            entity.Property(e => e._5920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/9/20");
            entity.Property(e => e._61020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/10/20");
            entity.Property(e => e._61120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/11/20");
            entity.Property(e => e._6120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/1/20");
            entity.Property(e => e._61220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/12/20");
            entity.Property(e => e._61320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/13/20");
            entity.Property(e => e._61420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/14/20");
            entity.Property(e => e._61520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/15/20");
            entity.Property(e => e._61620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/16/20");
            entity.Property(e => e._61720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/17/20");
            entity.Property(e => e._61820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/18/20");
            entity.Property(e => e._61920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/19/20");
            entity.Property(e => e._62020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/20/20");
            entity.Property(e => e._62120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/21/20");
            entity.Property(e => e._6220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/2/20");
            entity.Property(e => e._62220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/22/20");
            entity.Property(e => e._62320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/23/20");
            entity.Property(e => e._62420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/24/20");
            entity.Property(e => e._62520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/25/20");
            entity.Property(e => e._62620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/26/20");
            entity.Property(e => e._62720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/27/20");
            entity.Property(e => e._62820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/28/20");
            entity.Property(e => e._62920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/29/20");
            entity.Property(e => e._63020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/30/20");
            entity.Property(e => e._6320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/3/20");
            entity.Property(e => e._6420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/4/20");
            entity.Property(e => e._6520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/5/20");
            entity.Property(e => e._6620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/6/20");
            entity.Property(e => e._6720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/7/20");
            entity.Property(e => e._6820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/8/20");
            entity.Property(e => e._6920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/9/20");
            entity.Property(e => e._71020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/10/20");
            entity.Property(e => e._71120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/11/20");
            entity.Property(e => e._7120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/1/20");
            entity.Property(e => e._71220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/12/20");
            entity.Property(e => e._71320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/13/20");
            entity.Property(e => e._71420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/14/20");
            entity.Property(e => e._71520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/15/20");
            entity.Property(e => e._71620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/16/20");
            entity.Property(e => e._71720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/17/20");
            entity.Property(e => e._71820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/18/20");
            entity.Property(e => e._71920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/19/20");
            entity.Property(e => e._72020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/20/20");
            entity.Property(e => e._72120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/21/20");
            entity.Property(e => e._7220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/2/20");
            entity.Property(e => e._72220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/22/20");
            entity.Property(e => e._72320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/23/20");
            entity.Property(e => e._72420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/24/20");
            entity.Property(e => e._72520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/25/20");
            entity.Property(e => e._72620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/26/20");
            entity.Property(e => e._72720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/27/20");
            entity.Property(e => e._72820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/28/20");
            entity.Property(e => e._72920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/29/20");
            entity.Property(e => e._73020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/30/20");
            entity.Property(e => e._73120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/31/20");
            entity.Property(e => e._7320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/3/20");
            entity.Property(e => e._7420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/4/20");
            entity.Property(e => e._7520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/5/20");
            entity.Property(e => e._7620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/6/20");
            entity.Property(e => e._7720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/7/20");
            entity.Property(e => e._7820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/8/20");
            entity.Property(e => e._7920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/9/20");
            entity.Property(e => e._81020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/10/20");
            entity.Property(e => e._81120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/11/20");
            entity.Property(e => e._8120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/1/20");
            entity.Property(e => e._81220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/12/20");
            entity.Property(e => e._81320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/13/20");
            entity.Property(e => e._81420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/14/20");
            entity.Property(e => e._81520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/15/20");
            entity.Property(e => e._81620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/16/20");
            entity.Property(e => e._81720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/17/20");
            entity.Property(e => e._81820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/18/20");
            entity.Property(e => e._81920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/19/20");
            entity.Property(e => e._82020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/20/20");
            entity.Property(e => e._82120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/21/20");
            entity.Property(e => e._8220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/2/20");
            entity.Property(e => e._82220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/22/20");
            entity.Property(e => e._82320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/23/20");
            entity.Property(e => e._82420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/24/20");
            entity.Property(e => e._82520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/25/20");
            entity.Property(e => e._82620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/26/20");
            entity.Property(e => e._82720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/27/20");
            entity.Property(e => e._82820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/28/20");
            entity.Property(e => e._82920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/29/20");
            entity.Property(e => e._83020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/30/20");
            entity.Property(e => e._83120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/31/20");
            entity.Property(e => e._8320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/3/20");
            entity.Property(e => e._8420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/4/20");
            entity.Property(e => e._8520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/5/20");
            entity.Property(e => e._8620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/6/20");
            entity.Property(e => e._8720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/7/20");
            entity.Property(e => e._8820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/8/20");
            entity.Property(e => e._8920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/9/20");
            entity.Property(e => e._91020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/10/20");
            entity.Property(e => e._91120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/11/20");
            entity.Property(e => e._9120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/1/20");
            entity.Property(e => e._91220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/12/20");
            entity.Property(e => e._91320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/13/20");
            entity.Property(e => e._91420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/14/20");
            entity.Property(e => e._91520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/15/20");
            entity.Property(e => e._91620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/16/20");
            entity.Property(e => e._91720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/17/20");
            entity.Property(e => e._91820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/18/20");
            entity.Property(e => e._91920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/19/20");
            entity.Property(e => e._92020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/20/20");
            entity.Property(e => e._92120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/21/20");
            entity.Property(e => e._9220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/2/20");
            entity.Property(e => e._92220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/22/20");
            entity.Property(e => e._92320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/23/20");
            entity.Property(e => e._92420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/24/20");
            entity.Property(e => e._92520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/25/20");
            entity.Property(e => e._92620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/26/20");
            entity.Property(e => e._92720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/27/20");
            entity.Property(e => e._92820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/28/20");
            entity.Property(e => e._92920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/29/20");
            entity.Property(e => e._93020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/30/20");
            entity.Property(e => e._9320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/3/20");
            entity.Property(e => e._9420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/4/20");
            entity.Property(e => e._9520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/5/20");
            entity.Property(e => e._9620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/6/20");
            entity.Property(e => e._9720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/7/20");
            entity.Property(e => e._9820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/8/20");
            entity.Property(e => e._9920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/9/20");
        });

        modelBuilder.Entity<Required>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("required");

            entity.Property(e => e.CountryRegion)
                .HasMaxLength(512)
                .HasColumnName("Country/Region");
            entity.Property(e => e.ProvinceState)
                .HasMaxLength(512)
                .HasColumnName("Province/State");
            entity.Property(e => e._101020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/10/20");
            entity.Property(e => e._101120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/11/20");
            entity.Property(e => e._10120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/1/20");
            entity.Property(e => e._101220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/12/20");
            entity.Property(e => e._101320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/13/20");
            entity.Property(e => e._101420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/14/20");
            entity.Property(e => e._101520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/15/20");
            entity.Property(e => e._101620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/16/20");
            entity.Property(e => e._101720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/17/20");
            entity.Property(e => e._101820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/18/20");
            entity.Property(e => e._101920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/19/20");
            entity.Property(e => e._102020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/20/20");
            entity.Property(e => e._102120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/21/20");
            entity.Property(e => e._10220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/2/20");
            entity.Property(e => e._102220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/22/20");
            entity.Property(e => e._102320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/23/20");
            entity.Property(e => e._102420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/24/20");
            entity.Property(e => e._102520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/25/20");
            entity.Property(e => e._102620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/26/20");
            entity.Property(e => e._102720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/27/20");
            entity.Property(e => e._102820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/28/20");
            entity.Property(e => e._102920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/29/20");
            entity.Property(e => e._103020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/30/20");
            entity.Property(e => e._103120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/31/20");
            entity.Property(e => e._10320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/3/20");
            entity.Property(e => e._10420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/4/20");
            entity.Property(e => e._10520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/5/20");
            entity.Property(e => e._10620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/6/20");
            entity.Property(e => e._10720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/7/20");
            entity.Property(e => e._10820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/8/20");
            entity.Property(e => e._10920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("10/9/20");
            entity.Property(e => e._11023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/10/23");
            entity.Property(e => e._111020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/10/20");
            entity.Property(e => e._111120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/11/20");
            entity.Property(e => e._11120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/1/20");
            entity.Property(e => e._111220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/12/20");
            entity.Property(e => e._11123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/11/23");
            entity.Property(e => e._111320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/13/20");
            entity.Property(e => e._111420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/14/20");
            entity.Property(e => e._111520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/15/20");
            entity.Property(e => e._111620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/16/20");
            entity.Property(e => e._111720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/17/20");
            entity.Property(e => e._111820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/18/20");
            entity.Property(e => e._111920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/19/20");
            entity.Property(e => e._112020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/20/20");
            entity.Property(e => e._112120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/21/20");
            entity.Property(e => e._11220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/2/20");
            entity.Property(e => e._112220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/22/20");
            entity.Property(e => e._11223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/12/23");
            entity.Property(e => e._1123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/1/23");
            entity.Property(e => e._112320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/23/20");
            entity.Property(e => e._112420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/24/20");
            entity.Property(e => e._112520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/25/20");
            entity.Property(e => e._112620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/26/20");
            entity.Property(e => e._112720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/27/20");
            entity.Property(e => e._112820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/28/20");
            entity.Property(e => e._112920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/29/20");
            entity.Property(e => e._113020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/30/20");
            entity.Property(e => e._11320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/3/20");
            entity.Property(e => e._11323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/13/23");
            entity.Property(e => e._11420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/4/20");
            entity.Property(e => e._11423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/14/23");
            entity.Property(e => e._11520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/5/20");
            entity.Property(e => e._11523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/15/23");
            entity.Property(e => e._11620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/6/20");
            entity.Property(e => e._11623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/16/23");
            entity.Property(e => e._11720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/7/20");
            entity.Property(e => e._11723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/17/23");
            entity.Property(e => e._11820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/8/20");
            entity.Property(e => e._11823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/18/23");
            entity.Property(e => e._11920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("11/9/20");
            entity.Property(e => e._11923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/19/23");
            entity.Property(e => e._12023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/20/23");
            entity.Property(e => e._121020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/10/20");
            entity.Property(e => e._121120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/11/20");
            entity.Property(e => e._12120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/1/20");
            entity.Property(e => e._121220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/12/20");
            entity.Property(e => e._12123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/21/23");
            entity.Property(e => e._121320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/13/20");
            entity.Property(e => e._121420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/14/20");
            entity.Property(e => e._121520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/15/20");
            entity.Property(e => e._121620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/16/20");
            entity.Property(e => e._121720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/17/20");
            entity.Property(e => e._121820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/18/20");
            entity.Property(e => e._121920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/19/20");
            entity.Property(e => e._122020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/20/20");
            entity.Property(e => e._122120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/21/20");
            entity.Property(e => e._12220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/20");
            entity.Property(e => e._122201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/2/20");
            entity.Property(e => e._122220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/22/20");
            entity.Property(e => e._12223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/22/23");
            entity.Property(e => e._1223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/2/23");
            entity.Property(e => e._122320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/23/20");
            entity.Property(e => e._122420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/24/20");
            entity.Property(e => e._122520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/25/20");
            entity.Property(e => e._122620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/26/20");
            entity.Property(e => e._122720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/27/20");
            entity.Property(e => e._122820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/28/20");
            entity.Property(e => e._122920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/29/20");
            entity.Property(e => e._123020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/30/20");
            entity.Property(e => e._123120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/31/20");
            entity.Property(e => e._12320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/20");
            entity.Property(e => e._123201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/3/20");
            entity.Property(e => e._12323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/23/23");
            entity.Property(e => e._12420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/20");
            entity.Property(e => e._124201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/4/20");
            entity.Property(e => e._12423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/24/23");
            entity.Property(e => e._12520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/20");
            entity.Property(e => e._125201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/5/20");
            entity.Property(e => e._12523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/25/23");
            entity.Property(e => e._12620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/20");
            entity.Property(e => e._126201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/6/20");
            entity.Property(e => e._12623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/26/23");
            entity.Property(e => e._12720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/20");
            entity.Property(e => e._127201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/7/20");
            entity.Property(e => e._12723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/27/23");
            entity.Property(e => e._12820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/20");
            entity.Property(e => e._128201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/8/20");
            entity.Property(e => e._12823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/28/23");
            entity.Property(e => e._12920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/20");
            entity.Property(e => e._129201)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("12/9/20");
            entity.Property(e => e._12923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/29/23");
            entity.Property(e => e._13020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/20");
            entity.Property(e => e._13023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/30/23");
            entity.Property(e => e._13120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/20");
            entity.Property(e => e._13123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/31/23");
            entity.Property(e => e._1323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/3/23");
            entity.Property(e => e._1423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/4/23");
            entity.Property(e => e._1523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/5/23");
            entity.Property(e => e._1623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/6/23");
            entity.Property(e => e._1723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/7/23");
            entity.Property(e => e._1823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/8/23");
            entity.Property(e => e._1923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("1/9/23");
            entity.Property(e => e._21020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/20");
            entity.Property(e => e._21023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/10/23");
            entity.Property(e => e._21120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/20");
            entity.Property(e => e._21123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/11/23");
            entity.Property(e => e._2120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/20");
            entity.Property(e => e._21220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/20");
            entity.Property(e => e._21223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/12/23");
            entity.Property(e => e._2123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/1/23");
            entity.Property(e => e._21320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/20");
            entity.Property(e => e._21323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/13/23");
            entity.Property(e => e._21420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/20");
            entity.Property(e => e._21423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/14/23");
            entity.Property(e => e._21520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/20");
            entity.Property(e => e._21523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/15/23");
            entity.Property(e => e._21620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/20");
            entity.Property(e => e._21623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/16/23");
            entity.Property(e => e._21720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/20");
            entity.Property(e => e._21723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/17/23");
            entity.Property(e => e._21820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/20");
            entity.Property(e => e._21823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/18/23");
            entity.Property(e => e._21920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/20");
            entity.Property(e => e._21923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/19/23");
            entity.Property(e => e._22020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/20");
            entity.Property(e => e._22023)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/20/23");
            entity.Property(e => e._22120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/20");
            entity.Property(e => e._22123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/21/23");
            entity.Property(e => e._2220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/20");
            entity.Property(e => e._22220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/20");
            entity.Property(e => e._22223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/22/23");
            entity.Property(e => e._2223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/2/23");
            entity.Property(e => e._22320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/20");
            entity.Property(e => e._22323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/23/23");
            entity.Property(e => e._22420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/20");
            entity.Property(e => e._22423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/24/23");
            entity.Property(e => e._22520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/20");
            entity.Property(e => e._22523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/25/23");
            entity.Property(e => e._22620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/20");
            entity.Property(e => e._22623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/26/23");
            entity.Property(e => e._22720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/20");
            entity.Property(e => e._22723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/27/23");
            entity.Property(e => e._22820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/20");
            entity.Property(e => e._22823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/28/23");
            entity.Property(e => e._22920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/29/20");
            entity.Property(e => e._2320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/20");
            entity.Property(e => e._2323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/3/23");
            entity.Property(e => e._2420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/20");
            entity.Property(e => e._2423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/4/23");
            entity.Property(e => e._2520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/20");
            entity.Property(e => e._2523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/5/23");
            entity.Property(e => e._2620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/20");
            entity.Property(e => e._2623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/6/23");
            entity.Property(e => e._2720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/20");
            entity.Property(e => e._2723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/7/23");
            entity.Property(e => e._2820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/20");
            entity.Property(e => e._2823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/8/23");
            entity.Property(e => e._2920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/20");
            entity.Property(e => e._2923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("2/9/23");
            entity.Property(e => e._31020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/10/20");
            entity.Property(e => e._31120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/11/20");
            entity.Property(e => e._3120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/20");
            entity.Property(e => e._31220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/12/20");
            entity.Property(e => e._3123)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/1/23");
            entity.Property(e => e._31320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/13/20");
            entity.Property(e => e._31420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/14/20");
            entity.Property(e => e._31520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/15/20");
            entity.Property(e => e._31620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/16/20");
            entity.Property(e => e._31720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/17/20");
            entity.Property(e => e._31820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/18/20");
            entity.Property(e => e._31920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/19/20");
            entity.Property(e => e._32020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/20/20");
            entity.Property(e => e._32120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/21/20");
            entity.Property(e => e._3220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/20");
            entity.Property(e => e._32220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/22/20");
            entity.Property(e => e._3223)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/2/23");
            entity.Property(e => e._32320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/23/20");
            entity.Property(e => e._32420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/24/20");
            entity.Property(e => e._32520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/25/20");
            entity.Property(e => e._32620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/26/20");
            entity.Property(e => e._32720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/27/20");
            entity.Property(e => e._32820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/28/20");
            entity.Property(e => e._32920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/29/20");
            entity.Property(e => e._33020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/30/20");
            entity.Property(e => e._33120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/31/20");
            entity.Property(e => e._3320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/20");
            entity.Property(e => e._3323)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/3/23");
            entity.Property(e => e._3420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/20");
            entity.Property(e => e._3423)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/4/23");
            entity.Property(e => e._3520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/20");
            entity.Property(e => e._3523)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/5/23");
            entity.Property(e => e._3620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/20");
            entity.Property(e => e._3623)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/6/23");
            entity.Property(e => e._3720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/20");
            entity.Property(e => e._3723)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/7/23");
            entity.Property(e => e._3820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/20");
            entity.Property(e => e._3823)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/8/23");
            entity.Property(e => e._3920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/20");
            entity.Property(e => e._3923)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("3/9/23");
            entity.Property(e => e._41020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/10/20");
            entity.Property(e => e._41120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/11/20");
            entity.Property(e => e._4120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/1/20");
            entity.Property(e => e._41220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/12/20");
            entity.Property(e => e._41320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/13/20");
            entity.Property(e => e._41420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/14/20");
            entity.Property(e => e._41520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/15/20");
            entity.Property(e => e._41620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/16/20");
            entity.Property(e => e._41720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/17/20");
            entity.Property(e => e._41820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/18/20");
            entity.Property(e => e._41920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/19/20");
            entity.Property(e => e._42020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/20/20");
            entity.Property(e => e._42120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/21/20");
            entity.Property(e => e._4220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/2/20");
            entity.Property(e => e._42220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/22/20");
            entity.Property(e => e._42320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/23/20");
            entity.Property(e => e._42420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/24/20");
            entity.Property(e => e._42520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/25/20");
            entity.Property(e => e._42620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/26/20");
            entity.Property(e => e._42720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/27/20");
            entity.Property(e => e._42820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/28/20");
            entity.Property(e => e._42920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/29/20");
            entity.Property(e => e._43020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/30/20");
            entity.Property(e => e._4320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/3/20");
            entity.Property(e => e._4420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/4/20");
            entity.Property(e => e._4520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/5/20");
            entity.Property(e => e._4620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/6/20");
            entity.Property(e => e._4720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/7/20");
            entity.Property(e => e._4820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/8/20");
            entity.Property(e => e._4920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("4/9/20");
            entity.Property(e => e._51020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/10/20");
            entity.Property(e => e._51120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/11/20");
            entity.Property(e => e._5120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/1/20");
            entity.Property(e => e._51220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/12/20");
            entity.Property(e => e._51320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/13/20");
            entity.Property(e => e._51420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/14/20");
            entity.Property(e => e._51520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/15/20");
            entity.Property(e => e._51620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/16/20");
            entity.Property(e => e._51720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/17/20");
            entity.Property(e => e._51820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/18/20");
            entity.Property(e => e._51920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/19/20");
            entity.Property(e => e._52020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/20/20");
            entity.Property(e => e._52120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/21/20");
            entity.Property(e => e._5220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/2/20");
            entity.Property(e => e._52220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/22/20");
            entity.Property(e => e._52320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/23/20");
            entity.Property(e => e._52420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/24/20");
            entity.Property(e => e._52520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/25/20");
            entity.Property(e => e._52620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/26/20");
            entity.Property(e => e._52720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/27/20");
            entity.Property(e => e._52820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/28/20");
            entity.Property(e => e._52920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/29/20");
            entity.Property(e => e._53020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/30/20");
            entity.Property(e => e._53120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/31/20");
            entity.Property(e => e._5320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/3/20");
            entity.Property(e => e._5420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/4/20");
            entity.Property(e => e._5520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/5/20");
            entity.Property(e => e._5620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/6/20");
            entity.Property(e => e._5720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/7/20");
            entity.Property(e => e._5820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/8/20");
            entity.Property(e => e._5920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("5/9/20");
            entity.Property(e => e._61020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/10/20");
            entity.Property(e => e._61120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/11/20");
            entity.Property(e => e._6120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/1/20");
            entity.Property(e => e._61220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/12/20");
            entity.Property(e => e._61320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/13/20");
            entity.Property(e => e._61420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/14/20");
            entity.Property(e => e._61520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/15/20");
            entity.Property(e => e._61620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/16/20");
            entity.Property(e => e._61720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/17/20");
            entity.Property(e => e._61820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/18/20");
            entity.Property(e => e._61920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/19/20");
            entity.Property(e => e._62020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/20/20");
            entity.Property(e => e._62120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/21/20");
            entity.Property(e => e._6220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/2/20");
            entity.Property(e => e._62220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/22/20");
            entity.Property(e => e._62320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/23/20");
            entity.Property(e => e._62420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/24/20");
            entity.Property(e => e._62520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/25/20");
            entity.Property(e => e._62620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/26/20");
            entity.Property(e => e._62720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/27/20");
            entity.Property(e => e._62820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/28/20");
            entity.Property(e => e._62920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/29/20");
            entity.Property(e => e._63020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/30/20");
            entity.Property(e => e._6320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/3/20");
            entity.Property(e => e._6420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/4/20");
            entity.Property(e => e._6520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/5/20");
            entity.Property(e => e._6620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/6/20");
            entity.Property(e => e._6720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/7/20");
            entity.Property(e => e._6820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/8/20");
            entity.Property(e => e._6920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("6/9/20");
            entity.Property(e => e._71020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/10/20");
            entity.Property(e => e._71120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/11/20");
            entity.Property(e => e._7120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/1/20");
            entity.Property(e => e._71220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/12/20");
            entity.Property(e => e._71320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/13/20");
            entity.Property(e => e._71420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/14/20");
            entity.Property(e => e._71520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/15/20");
            entity.Property(e => e._71620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/16/20");
            entity.Property(e => e._71720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/17/20");
            entity.Property(e => e._71820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/18/20");
            entity.Property(e => e._71920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/19/20");
            entity.Property(e => e._72020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/20/20");
            entity.Property(e => e._72120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/21/20");
            entity.Property(e => e._7220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/2/20");
            entity.Property(e => e._72220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/22/20");
            entity.Property(e => e._72320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/23/20");
            entity.Property(e => e._72420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/24/20");
            entity.Property(e => e._72520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/25/20");
            entity.Property(e => e._72620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/26/20");
            entity.Property(e => e._72720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/27/20");
            entity.Property(e => e._72820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/28/20");
            entity.Property(e => e._72920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/29/20");
            entity.Property(e => e._73020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/30/20");
            entity.Property(e => e._73120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/31/20");
            entity.Property(e => e._7320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/3/20");
            entity.Property(e => e._7420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/4/20");
            entity.Property(e => e._7520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/5/20");
            entity.Property(e => e._7620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/6/20");
            entity.Property(e => e._7720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/7/20");
            entity.Property(e => e._7820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/8/20");
            entity.Property(e => e._7920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("7/9/20");
            entity.Property(e => e._81020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/10/20");
            entity.Property(e => e._81120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/11/20");
            entity.Property(e => e._8120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/1/20");
            entity.Property(e => e._81220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/12/20");
            entity.Property(e => e._81320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/13/20");
            entity.Property(e => e._81420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/14/20");
            entity.Property(e => e._81520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/15/20");
            entity.Property(e => e._81620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/16/20");
            entity.Property(e => e._81720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/17/20");
            entity.Property(e => e._81820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/18/20");
            entity.Property(e => e._81920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/19/20");
            entity.Property(e => e._82020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/20/20");
            entity.Property(e => e._82120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/21/20");
            entity.Property(e => e._8220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/2/20");
            entity.Property(e => e._82220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/22/20");
            entity.Property(e => e._82320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/23/20");
            entity.Property(e => e._82420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/24/20");
            entity.Property(e => e._82520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/25/20");
            entity.Property(e => e._82620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/26/20");
            entity.Property(e => e._82720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/27/20");
            entity.Property(e => e._82820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/28/20");
            entity.Property(e => e._82920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/29/20");
            entity.Property(e => e._83020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/30/20");
            entity.Property(e => e._83120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/31/20");
            entity.Property(e => e._8320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/3/20");
            entity.Property(e => e._8420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/4/20");
            entity.Property(e => e._8520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/5/20");
            entity.Property(e => e._8620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/6/20");
            entity.Property(e => e._8720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/7/20");
            entity.Property(e => e._8820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/8/20");
            entity.Property(e => e._8920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("8/9/20");
            entity.Property(e => e._91020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/10/20");
            entity.Property(e => e._91120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/11/20");
            entity.Property(e => e._9120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/1/20");
            entity.Property(e => e._91220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/12/20");
            entity.Property(e => e._91320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/13/20");
            entity.Property(e => e._91420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/14/20");
            entity.Property(e => e._91520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/15/20");
            entity.Property(e => e._91620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/16/20");
            entity.Property(e => e._91720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/17/20");
            entity.Property(e => e._91820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/18/20");
            entity.Property(e => e._91920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/19/20");
            entity.Property(e => e._92020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/20/20");
            entity.Property(e => e._92120)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/21/20");
            entity.Property(e => e._9220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/2/20");
            entity.Property(e => e._92220)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/22/20");
            entity.Property(e => e._92320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/23/20");
            entity.Property(e => e._92420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/24/20");
            entity.Property(e => e._92520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/25/20");
            entity.Property(e => e._92620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/26/20");
            entity.Property(e => e._92720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/27/20");
            entity.Property(e => e._92820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/28/20");
            entity.Property(e => e._92920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/29/20");
            entity.Property(e => e._93020)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/30/20");
            entity.Property(e => e._9320)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/3/20");
            entity.Property(e => e._9420)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/4/20");
            entity.Property(e => e._9520)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/5/20");
            entity.Property(e => e._9620)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/6/20");
            entity.Property(e => e._9720)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/7/20");
            entity.Property(e => e._9820)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/8/20");
            entity.Property(e => e._9920)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("9/9/20");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
