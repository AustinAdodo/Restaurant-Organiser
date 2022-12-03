using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant_Menu_Organiser.Models;
using Restaurant_Menu_Organiser.Models.Approvals;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Models.Items;
using Restaurant_Menu_Organiser.Models.Notifications;
using Restaurant_Menu_Organiser.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu_Organiser.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Private readonly IUserResolver
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // keys of identity tables are mapped in OnModelCreating method of IdentityDbContext Class.
            base.OnModelCreating(modelBuilder);
            //creating intial seed data
            modelBuilder.seed();
            modelBuilder.seed1();
            ////solve issue with composite primary key on DisposableEmployeeData.
            //modelBuilder.Entity<DisposableEmployeeData>().HasKey(c =>new
            //{c.ReferenceId,c.EmployeeId });
        }
        public void AddCascadingObject(object RootEntity)
        {
            ChangeTracker.TrackGraph(
                RootEntity,
                node => node.Entry.State = !node.Entry.IsKeySet ? EntityState.Added : EntityState.Unchanged
                );
        }
        ///DBSET DECLARATION
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DisposableEmployeeData> DisposableEmployeesData { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderStatus> Orders { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
