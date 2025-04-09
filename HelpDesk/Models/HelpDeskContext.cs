using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Models;

public partial class HelpDeskContext : DbContext
{
    public HelpDeskContext()
    {
    }

    public HelpDeskContext(DbContextOptions<HelpDeskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<HestoryReq> HestoryReqs { get; set; }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Requrst> Reqursts { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Suplier> Supliers { get; set; }

    public virtual DbSet<TypesReq> TypesReqs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-O3T36JC; Trusted_Connection=True; Database=HelpDesk; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAd).HasName("PK__Admins__014829359392583B");

            entity.Property(e => e.IdAd).HasColumnName("id_ad");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HestoryReq>(entity =>
        {
            entity.HasKey(e => e.IdHs).HasName("PK__HestoryR__00B7E64FBA05AD60");

            entity.ToTable("HestoryReq");

            entity.Property(e => e.IdHs).HasColumnName("id_hs");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.Datee)
                .HasColumnType("date")
                .HasColumnName("datee");
            entity.Property(e => e.IdPrior).HasColumnName("id_prior");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdSupe).HasColumnName("id_supe");
            entity.Property(e => e.IdTypeReq).HasColumnName("id_type_req");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdPriorNavigation).WithMany(p => p.HestoryReqs)
                .HasForeignKey(d => d.IdPrior)
                .HasConstraintName("FK__HestoryRe__id_pr__4CA06362");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.HestoryReqs)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__HestoryRe__id_st__4D94879B");

            entity.HasOne(d => d.IdSupeNavigation).WithMany(p => p.HestoryReqs)
                .HasForeignKey(d => d.IdSupe)
                .HasConstraintName("FK__HestoryRe__id_su__49C3F6B7");

            entity.HasOne(d => d.IdTypeReqNavigation).WithMany(p => p.HestoryReqs)
                .HasForeignKey(d => d.IdTypeReq)
                .HasConstraintName("FK__HestoryRe__id_ty__4BAC3F29");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.HestoryReqs)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__HestoryRe__id_us__4AB81AF0");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.IdPr).HasName("PK__Priority__0148A34EA6815580");

            entity.ToTable("Priority");

            entity.Property(e => e.IdPr).HasColumnName("id_pr");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Requrst>(entity =>
        {
            entity.HasKey(e => e.IdReq).HasName("PK__Requrst__6ABE6F0633D10C75");

            entity.ToTable("Requrst");

            entity.Property(e => e.IdReq).HasColumnName("id_req");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.Datee)
                .HasColumnType("date")
                .HasColumnName("datee");
            entity.Property(e => e.IdPrior).HasColumnName("id_prior");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdSupe).HasColumnName("id_supe");
            entity.Property(e => e.IdTypeReq).HasColumnName("id_type_req");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdPriorNavigation).WithMany(p => p.Reqursts)
                .HasForeignKey(d => d.IdPrior)
                .HasConstraintName("FK__Requrst__id_prio__45F365D3");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Reqursts)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Requrst__id_stat__46E78A0C");

            entity.HasOne(d => d.IdSupeNavigation).WithMany(p => p.Reqursts)
                .HasForeignKey(d => d.IdSupe)
                .HasConstraintName("FK__Requrst__id_supe__4316F928");

            entity.HasOne(d => d.IdTypeReqNavigation).WithMany(p => p.Reqursts)
                .HasForeignKey(d => d.IdTypeReq)
                .HasConstraintName("FK__Requrst__id_type__44FF419A");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Reqursts)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__Requrst__id_user__440B1D61");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdSt).HasName("PK__Status__014858EBA696F2C8");

            entity.ToTable("Status");

            entity.Property(e => e.IdSt).HasColumnName("id_st");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Suplier>(entity =>
        {
            entity.HasKey(e => e.IdSup).HasName("PK__Supliers__6D6C23223B039236");

            entity.Property(e => e.IdSup).HasColumnName("id_sup");
            entity.Property(e => e.Login)
                .HasMaxLength(200)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .HasColumnName("password");
        });

        modelBuilder.Entity<TypesReq>(entity =>
        {
            entity.HasKey(e => e.IdT).HasName("PK__Types_re__9DB7D2E9EB0CA4C5");

            entity.ToTable("Types_req");

            entity.Property(e => e.IdT).HasColumnName("id_t");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUs).HasName("PK__Users__014848A550F805C5");

            entity.Property(e => e.IdUs).HasColumnName("id_us");
            entity.Property(e => e.Laba)
                .HasMaxLength(180)
                .HasColumnName("laba");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(150)
                .HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
