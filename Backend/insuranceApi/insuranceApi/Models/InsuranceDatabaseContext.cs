using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace insuranceApi.Models;

public partial class InsuranceDatabaseContext : DbContext
{
    public InsuranceDatabaseContext()
    {
    }

    public InsuranceDatabaseContext(DbContextOptions<InsuranceDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PolicyDetail> PolicyDetails { get; set; }

    public virtual DbSet<UserCredential> UserCredentials { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<UserPaymentDetail> UserPaymentDetails { get; set; }

    public virtual DbSet<UserPolicy> UserPolicies { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PolicyDetail>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasName("PK__PolicyDe__90D231B2B6DB97F0");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
            entity.Property(e => e.PolicyInsurer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("POLICY_INSURER");
            entity.Property(e => e.PolicyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("POLICY_NAME");
            entity.Property(e => e.PolicyTpa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("POLICY_TPA");
        });

        modelBuilder.Entity<UserCredential>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserCred__F3BEEBFFE0B43FD7");

            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_PASSWORD");
            entity.Property(e => e.UserUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_USERNAME");
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserCompany)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("USER_COMPANY");
            entity.Property(e => e.UserEmployeeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_EMPLOYEEID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");

            //entity.HasOne(d => d.User).WithMany()
             //   .HasForeignKey(d => d.UserId)
               // .OnDelete(DeleteBehavior.ClientSetNull)
                //.HasConstraintName("FK__UserDetai__USER___5DCAEF64");
        });

        modelBuilder.Entity<UserPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__UserPaym__D2C4FF465DA002B4");

            entity.ToTable("UserPaymentDetail");

            entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");
            entity.Property(e => e.UserCardname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("USER_CARDNAME");
            entity.Property(e => e.UserCardnumber).HasColumnName("USER_CARDNUMBER");
            entity.Property(e => e.UserCardvalidity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_CARDVALIDITY");
            entity.Property(e => e.UserCvv).HasColumnName("USER_CVV");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

           // entity.HasOne(d => d.User).WithMany(p => p.UserPaymentDetails)
             //   .HasForeignKey(d => d.UserId)
               // .HasConstraintName("FK__UserPayme__USER___6B24EA82");
        });

        modelBuilder.Entity<UserPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserPolicy");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserPolicyfrom).HasColumnName("USER_POLICYFROM");
            entity.Property(e => e.UserPolicyto).HasColumnName("USER_POLICYTO");

            //entity.HasOne(d => d.Policy).WithMany()
              //  .HasForeignKey(d => d.PolicyId)
               // .OnDelete(DeleteBehavior.ClientSetNull)
                //.HasConstraintName("FK__UserPolic__POLIC__628FA481");

            //entity.HasOne(d => d.User).WithMany()
              //  .HasForeignKey(d => d.UserId)
                //.OnDelete(DeleteBehavior.ClientSetNull)
                //.HasConstraintName("FK__UserPolic__USER___619B8048");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
