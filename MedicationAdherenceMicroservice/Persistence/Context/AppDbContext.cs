using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Interval> Intervals { get; set; }
    public DbSet<Frequency> Frequencies { get; set; }
    public DbSet<ConflictingMedicines> ConflictingMedicinesDbSet { get; set; }
    
    public DbSet<CompletedAlarm> CompletedAlarms { get; set; }
    public DbSet<MissedAlarm> MissedAlarms { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Medicine>().ToTable("Medicines");
        builder.Entity<Medicine>().HasKey(p => p.Id);
        builder.Entity<Medicine>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Medicine>().Property(p => p.Name).IsRequired();
        builder.Entity<Medicine>().Property(p => p.Type).IsRequired();
        
        builder.Entity<Reminder>().ToTable("Reminders");
        builder.Entity<Reminder>().HasKey(p => p.Id);
        builder.Entity<Reminder>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Reminder>().Property(p => p.CreatedDate).IsRequired();
        builder.Entity<Reminder>().Property(p => p.MedicineId).IsRequired();
        builder.Entity<Reminder>().Property(p => p.UserId).IsRequired();
        
        builder.Entity<Interval>().ToTable("Intervals");
        builder.Entity<Interval>().HasKey(p => p.Id);
        builder.Entity<Interval>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Interval>().Property(p => p.IntervalType).IsRequired();
        builder.Entity<Interval>().Property(p => p.Value).IsRequired();
        builder.Entity<Interval>().Property(p => p.ReminderId).IsRequired();
        
        builder.Entity<Frequency>().ToTable("Frequencies");
        builder.Entity<Frequency>().HasKey(p => p.Id);
        builder.Entity<Frequency>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Frequency>().Property(p => p.FrequencyType).IsRequired();
        builder.Entity<Frequency>().Property(p => p.Times).IsRequired();
        builder.Entity<Frequency>().Property(p => p.ReminderId).IsRequired();

        builder.Entity<ConflictingMedicines>().ToTable("ConflictingMedicines");
        builder.Entity<ConflictingMedicines>().HasKey(p => p.Id);
        builder.Entity<ConflictingMedicines>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<ConflictingMedicines>().Property(p => p.Medicine1Id).IsRequired();
        builder.Entity<ConflictingMedicines>().Property(p => p.Medicine1Name).IsRequired();
        builder.Entity<ConflictingMedicines>().Property(p => p.Medicine2Id).IsRequired();
        builder.Entity<ConflictingMedicines>().Property(p => p.Medicine2Name).IsRequired();

        builder.Entity<CompletedAlarm>().ToTable("CompletedAlarms");
        builder.Entity<CompletedAlarm>().HasKey(p => p.Id);
        builder.Entity<CompletedAlarm>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<CompletedAlarm>().Property(p => p.MedicineName).IsRequired();
        builder.Entity<CompletedAlarm>().Property(p => p.ActivateDateString).IsRequired();
        builder.Entity<CompletedAlarm>().Property(p => p.ActivateHour).IsRequired();
        builder.Entity<CompletedAlarm>().Property(p => p.ActivateMinute).IsRequired();
        builder.Entity<CompletedAlarm>().Property(p => p.UserId).IsRequired();
        
        builder.Entity<MissedAlarm>().ToTable("MissedAlarms");
        builder.Entity<MissedAlarm>().HasKey(p => p.Id);
        builder.Entity<MissedAlarm>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<MissedAlarm>().Property(p => p.MedicineName).IsRequired();
        builder.Entity<MissedAlarm>().Property(p => p.ActivateDateString).IsRequired();
        builder.Entity<MissedAlarm>().Property(p => p.ActivateHour).IsRequired();
        builder.Entity<MissedAlarm>().Property(p => p.ActivateMinute).IsRequired();
        builder.Entity<MissedAlarm>().Property(p => p.UserId).IsRequired();
        
        builder.Entity<Medicine>().HasMany(p => p.Reminders)
            .WithOne(p => p.Medicine)
            .HasForeignKey(p => p.MedicineId);

        builder.Entity<Reminder>().HasOne(p => p.Interval)
            .WithOne(p => p.Reminder)
            .HasForeignKey<Interval>(p => p.ReminderId);
        
        builder.Entity<Reminder>().HasOne(p => p.Frequency)
            .WithOne(p => p.Reminder)
            .HasForeignKey<Frequency>(p => p.ReminderId);

        /*builder.Entity<Medicine>().HasMany(p => p.ConflictedMedicines)
            .WithMany(p => p.ConflictedMedicines)
            .UsingEntity<ConflictingMedicines>(
                l => l.HasOne<Medicine>(e => e.Medicine1)
                    .WithMany()
                    .HasForeignKey(e => e.Medicine1Id),
                r => r.HasOne<Medicine>(r => r.Medicine2)
                    .WithMany()
                    .HasForeignKey(e => e.Medicine2Id));*/
        
        builder.UseSnakeCaseNamingConvention();
    }
}