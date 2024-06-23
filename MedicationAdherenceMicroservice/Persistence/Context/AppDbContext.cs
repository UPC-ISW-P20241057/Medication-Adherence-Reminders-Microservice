using MedicationAdherenceMicroservice.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Interval> Intervals { get; set; }
    public DbSet<Frequency> Frequencies { get; set; }
    
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

        builder.Entity<Medicine>().HasMany(p => p.Reminders)
            .WithOne(p => p.Medicine)
            .HasForeignKey(p => p.MedicineId);

        builder.Entity<Reminder>().HasOne(p => p.Interval)
            .WithOne(p => p.Reminder)
            .HasForeignKey<Interval>(p => p.ReminderId);
        
        builder.Entity<Reminder>().HasOne(p => p.Frequency)
            .WithOne(p => p.Reminder)
            .HasForeignKey<Frequency>(p => p.ReminderId);
    }
}