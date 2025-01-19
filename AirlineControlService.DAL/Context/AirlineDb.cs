using AirlineControlService.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace AirlineControlService.DAL.Context
{
    public class AirlineDb : DbContext
    {
        // DbSet для всех сущностей
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ParentChild> ParentChildren { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassChild> ClassChildren { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public AirlineDb(DbContextOptions<AirlineDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParentChild>()
                .HasKey(pc => new { pc.ParentId, pc.ChildId });

            modelBuilder.Entity<ParentChild>()
                .HasOne(pc => pc.Parent)
                .WithMany(p => p.ParentChildren)
                .HasForeignKey(pc => pc.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ParentChild>()
                .HasOne(pc => pc.Child)
                .WithMany(c => c.ParentChildren)
                .HasForeignKey(pc => pc.ChildId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassChild>()
                .HasKey(cc => new { cc.ClassId, cc.ChildId });

            modelBuilder.Entity<ClassChild>()
                .HasOne(cc => cc.Class)
                .WithMany(c => c.ClassChildren)
                .HasForeignKey(cc => cc.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassChild>()
                .HasOne(cc => cc.Child)
                .WithMany(c => c.ClassChildren)
                .HasForeignKey(cc => cc.ChildId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired(false);

            modelBuilder.Entity<Class>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Schedule>()
                .Property(s => s.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Attendance>()
                .Property(a => a.Description)
                .HasMaxLength(500);
        }
    }
}
