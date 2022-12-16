using System;
using System.Collections.Generic;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL;

public partial class CarDealershipsDbContext : DbContext
{
    public CarDealershipsDbContext()
    {
    }

    public CarDealershipsDbContext(DbContextOptions<CarDealershipsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Buyer> Buyers { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarExemplar> CarExemplars { get; set; }

    public virtual DbSet<CarOrder> CarOrders { get; set; }

    public virtual DbSet<Head> Heads { get; set; }



    public virtual DbSet<Manager> Managers { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-9S2AK2B9;Database=CarDealershipsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.IdBranch).HasName("PK__BRANCH__261C45A449526CA9");

            entity.ToTable("BRANCH");

            entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDRESS");
            entity.Property(e => e.BranchName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRANCH_NAME");
            entity.Property(e => e.HeadPassData).HasColumnName("HEAD_PASS_DATA");

            entity.HasOne(d => d.HeadPassDataNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.HeadPassData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH__HEAD_PAS__2E1BDC42");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity.HasKey(e => e.BuyerPassData).HasName("PK__BUYER__ABE081A1133CF006");

            entity.ToTable("BUYER");

            entity.HasIndex(e => e.BuyerPhoneNumber, "UQ__BUYER__7FDA2467078599A0").IsUnique();

            entity.Property(e => e.BuyerPassData)
                .ValueGeneratedNever()
                .HasColumnName("BUYER_PASS_DATA");
            entity.Property(e => e.BuyerMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUYER_MIDDLENAME");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUYER_NAME");
            entity.Property(e => e.BuyerPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BUYER_PHONE_NUMBER");
            entity.Property(e => e.BuyerSurname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUYER_SURNAME");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.IdCar).HasName("PK__CAR__2BF8FA1E27D97252");

            entity.ToTable("CAR");

            entity.Property(e => e.IdCar).HasColumnName("ID_CAR");
            entity.Property(e => e.BodyType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BODY_TYPE");
            entity.Property(e => e.Brand)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRAND");
            entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");
            entity.Property(e => e.Model)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODEL");


            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Cars)
                .HasForeignKey(d => d.IdBranch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR__ID_BRANCH__3B75D760");
        });

        modelBuilder.Entity<CarExemplar>(entity =>
        {
            entity.HasKey(e => e.VinNumber).HasName("PK__CAR_EXEM__B372A1A336820FDF");

            entity.ToTable("CAR_EXEMPLAR");

            entity.Property(e => e.VinNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN_NUMBER");
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.HorsePower).HasColumnName("HORSE_POWER");
            entity.Property(e => e.IdCar).HasColumnName("ID_CAR");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("PRICE");
            entity.Property(e => e.YearOfAssembly)
                .HasColumnType("date")
                .HasColumnName("YEAR_OF_ASSEMBLY");

            entity.HasOne(d => d.IdCarNavigation).WithMany(p => p.CarExemplars)
                .HasForeignKey(d => d.IdCar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_EXEMP__ID_CA__440B1D61");
        });

        modelBuilder.Entity<CarOrder>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("PK__CAR_ORDE__D23A85654B760AAC");

            entity.ToTable("CAR_ORDER");

            entity.HasIndex(e => e.VinNumber, "UQ__CAR_ORDE__B372A1A205396611").IsUnique();

            entity.Property(e => e.IdOrder).HasColumnName("ID_ORDER");
            entity.Property(e => e.BuyerPassData).HasColumnName("BUYER_PASS_DATA");
            entity.Property(e => e.ContractDate)
                .HasColumnType("date")
                .HasColumnName("CONTRACT_DATE");
            entity.Property(e => e.MngrPassData).HasColumnName("MNGR_PASS_DATA");
            entity.Property(e => e.OrderAmount)
                .HasColumnType("money")
                .HasColumnName("ORDER_AMOUNT");
            entity.Property(e => e.VinNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN_NUMBER");

            entity.HasOne(d => d.BuyerPassDataNavigation).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.BuyerPassData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__BUYER__5629CD9C");

            entity.HasOne(d => d.MngrPassDataNavigation).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.MngrPassData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__MNGR___5535A963");

            entity.HasOne(d => d.VinNumberNavigation).WithOne(p => p.CarOrder)
                .HasForeignKey<CarOrder>(d => d.VinNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__VIN_N__534D60F1");
        });

        modelBuilder.Entity<Head>(entity =>
        {
            entity.HasKey(e => e.HeadPassData).HasName("PK__HEAD__1DEAC2727813A270");

            entity.ToTable("HEAD");

            entity.HasIndex(e => e.HeadPhoneNumber, "UQ__HEAD__5F3A4AF4C94D8D5A").IsUnique();

            entity.Property(e => e.HeadPassData)
                .ValueGeneratedNever()
                .HasColumnName("HEAD_PASS_DATA");
            entity.Property(e => e.HeadMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEAD_MIDDLENAME");
            entity.Property(e => e.HeadName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEAD_NAME");
            entity.Property(e => e.HeadPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HEAD_PHONE_NUMBER");
            entity.Property(e => e.HeadSurname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEAD_SURNAME");
        });

        

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.MngrPassData).HasName("PK__MANAGER__91EE6294E91B2B1E");

            entity.ToTable("MANAGER");

            entity.HasIndex(e => e.MngrPhoneNumber, "UQ__MANAGER__AB6758BFF124EF66").IsUnique();

            entity.Property(e => e.MngrPassData)
                .ValueGeneratedNever()
                .HasColumnName("MNGR_PASS_DATA");
            entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");
            entity.Property(e => e.MngrMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MNGR_MIDDLENAME");
            entity.Property(e => e.MngrName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MNGR_NAME");
            entity.Property(e => e.MngrPayDate)
                .HasColumnType("date")
                .HasColumnName("MNGR_PAY_DATE");
            entity.Property(e => e.MngrPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MNGR_PHONE_NUMBER");
            entity.Property(e => e.MngrPrize)
                .HasColumnType("money")
                .HasColumnName("MNGR_PRIZE");
            entity.Property(e => e.MngrSalary)
                .HasColumnType("money")
                .HasColumnName("MNGR_SALARY");
            entity.Property(e => e.MngrSurname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MNGR_SURNAME");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Managers)
                .HasForeignKey(d => d.IdBranch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MANAGER__ID_BRAN__31EC6D26");
        });

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
