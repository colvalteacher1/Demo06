using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo06.Models;

public partial class Colvalteacher4205w6Context : DbContext
{
    public Colvalteacher4205w6Context()
    {
    }

    public Colvalteacher4205w6Context(DbContextOptions<Colvalteacher4205w6Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Name=ConnectionStrings:OnlineMySqlDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Email, "uq_person_email").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Actif)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("actif");
            entity.Property(e => e.Age)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("age");
            entity.Property(e => e.DateNaissance)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date_naissance");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .HasColumnName("prenom");
            entity.Property(e => e.Ville)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ville");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
