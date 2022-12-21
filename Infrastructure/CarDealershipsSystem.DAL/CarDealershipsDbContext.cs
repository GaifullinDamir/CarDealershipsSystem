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
            entity.HasKey(e => e.IdBranch).HasName("PK__BRANCH__261C45A4844947A7");

            entity.ToTable("BRANCH");

            entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDRESS");
            entity.Property(e => e.BranchName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRANCH_NAME");
            entity.Property(e => e.IdHead).HasColumnName("ID_HEAD");

            entity.HasOne(d => d.IdHeadNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.IdHead)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH__ID_HEAD__30F848ED");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity.HasKey(e => e.IdBuyer).HasName("PK__BUYER__3D338BC7B4E6A20F");

            entity.ToTable("BUYER");

            entity.HasIndex(e => e.BuyerPhoneNumber, "UQ__BUYER__7FDA2467022EDB91").IsUnique();

            entity.Property(e => e.IdBuyer).HasColumnName("ID_BUYER");
            entity.Property(e => e.BuyerMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUYER_MIDDLENAME");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUYER_NAME");
            entity.Property(e => e.BuyerPassData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BUYER_PASS_DATA");
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
            entity.HasKey(e => e.IdCar).HasName("PK__CAR__2BF8FA1E679C4804");

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
                .HasConstraintName("FK__CAR__ID_BRANCH__4222D4EF");
        });

        modelBuilder.Entity<CarExemplar>(entity =>
        {
            entity.HasKey(e => e.VinNumber).HasName("PK__CAR_EXEM__B372A1A3494AE265");

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
                .HasConstraintName("FK__CAR_EXEMP__ID_CA__49C3F6B7");
        });

        modelBuilder.Entity<CarOrder>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("PK__CAR_ORDE__D23A8565189BA1D3");

            entity.ToTable("CAR_ORDER");

            entity.HasIndex(e => e.VinNumber, "UQ__CAR_ORDE__B372A1A2A3E8793C").IsUnique();

            entity.Property(e => e.IdOrder).HasColumnName("ID_ORDER");
            entity.Property(e => e.ContractDate)
                .HasColumnType("date")
                .HasColumnName("CONTRACT_DATE");
            entity.Property(e => e.IdBuyer).HasColumnName("ID_BUYER");
            entity.Property(e => e.IdMngr).HasColumnName("ID_MNGR");
            entity.Property(e => e.OrderAmount)
                .HasColumnType("money")
                .HasColumnName("ORDER_AMOUNT");
            entity.Property(e => e.VinNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN_NUMBER");

            entity.HasOne(d => d.IdBuyerNavigation).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.IdBuyer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__ID_BU__6477ECF3");

            entity.HasOne(d => d.IdMngrNavigation).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.IdMngr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__ID_MN__628FA481");

            entity.HasOne(d => d.VinNumberNavigation).WithOne(p => p.CarOrder)
                .HasForeignKey<CarOrder>(d => d.VinNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAR_ORDER__VIN_N__60A75C0F");
        });

        modelBuilder.Entity<Head>(entity =>
        {
            entity.HasKey(e => e.IdHead).HasName("PK__HEAD__7E14F79D57699D60");

            entity.ToTable("HEAD");

            entity.HasIndex(e => e.HeadLogin, "UQ__HEAD__0FF7269DE5550CDE").IsUnique();

            entity.HasIndex(e => e.HeadPhoneNumber, "UQ__HEAD__5F3A4AF4AEB72CCF").IsUnique();

            entity.HasIndex(e => e.HeadPassword, "UQ__HEAD__9D991639C427C5BA").IsUnique();

            entity.Property(e => e.IdHead).HasColumnName("ID_HEAD");
            entity.Property(e => e.HeadLogin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HEAD_LOGIN");
            entity.Property(e => e.HeadMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEAD_MIDDLENAME");
            entity.Property(e => e.HeadName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEAD_NAME");
            entity.Property(e => e.HeadPassData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HEAD_PASS_DATA");
            entity.Property(e => e.HeadPassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HEAD_PASSWORD");
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
            entity.HasKey(e => e.IdMngr).HasName("PK__MANAGER__41FAD97D76D99D3B");

            entity.ToTable("MANAGER");

            entity.HasIndex(e => e.ManagerLogin, "UQ__MANAGER__2F0AF86A390ECC2F").IsUnique();

            entity.HasIndex(e => e.ManagerPassword, "UQ__MANAGER__9FBE9539EEF75CD3").IsUnique();

            entity.HasIndex(e => e.MngrPhoneNumber, "UQ__MANAGER__AB6758BFF4E2EAD6").IsUnique();

            entity.Property(e => e.IdMngr).HasColumnName("ID_MNGR");
            entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");
            entity.Property(e => e.ManagerLogin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MANAGER_LOGIN");
            entity.Property(e => e.ManagerPassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MANAGER_PASSWORD");
            entity.Property(e => e.MngrMiddlename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MNGR_MIDDLENAME");
            entity.Property(e => e.MngrName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MNGR_NAME");
            entity.Property(e => e.MngrPassData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MNGR_PASS_DATA");
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
                .HasConstraintName("FK__MANAGER__ID_BRAN__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
