﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TechnoCraftSchool_Model;

namespace TechnoCraft_School.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public string AvtarProfile { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("School", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            return new ApplicationDbContext();
        }

        /*Institute Models*/
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }

        /*Academic Models*/
        public DbSet<Course> Courses { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Class> Classes { get; set; }

        /*Student*/
        public DbSet<Students> Students { get; set; }
        public DbSet<Student_Status> Student_Status { get; set; }

        /*Admission Models*/
        public DbSet<Admissions> Admissions { get; set; }
        public DbSet<Admission_Additional_Info> Admission_Additional_Infos { get; set; }
        public DbSet<Guardian_Details> Guardian_Details { get; set; }
        public DbSet<Last_Attended_Details> Last_Attended_Details { get; set; }

        /* Subject models*/
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectAssign> SubjectAssigns { get; set; }
        public DbSet<SubjectAllocation> SubjectAllocations { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Application Master Tables
            //modelBuilder.Entity<IdentityUser>().ToTable("Users", "dbo");
            //modelBuilder.Entity<IdentityRole>().ToTable("Roles", "dbo");
            modelBuilder.Entity<IdentityUser>().ToTable("Users","dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles","dbo");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles","dbo");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims","dbo");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins","dbo");
            
            modelBuilder.Entity<Institute>().ToTable("Institution", "dbo");
            modelBuilder.Entity<AcademicYear>().ToTable("AcademicYears", "dbo");

            modelBuilder.Entity<Course>().ToTable("Courses", "dbo");
            modelBuilder.Entity<Standard>().ToTable("Standards", "dbo");
            modelBuilder.Entity<Division>().ToTable("Divisions", "dbo");
            modelBuilder.Entity<Class>().ToTable("Classes", "dbo");
            modelBuilder.Entity<Students>().ToTable("Students", "dbo");

            // Subject
            modelBuilder.Entity<Subject>().ToTable("Subjects", "dbo");
            modelBuilder.Entity<SubjectAssign>().ToTable("SubjectAssign", "dbo");
            modelBuilder.Entity<SubjectAllocation>().ToTable("SubjectAllocation", "dbo");


            modelBuilder.Entity<Admissions>().ToTable("Admissions", "dbo");
            modelBuilder.Entity<Admission_Additional_Info>().ToTable("Admission_Additional_Info", "dbo");
            modelBuilder.Entity<Guardian_Details>().ToTable("Guardian_Details", "dbo");
            modelBuilder.Entity<Last_Attended_Details>().ToTable("Last_Attended_Details", "dbo");


            //Course -> Standard one to many relation
            modelBuilder.Entity<Course>().HasMany(c => c.Standards).WithRequired(c => c.Course);//.WillCascadeOnDelete();

            //Standard -> Division one to many relation
            modelBuilder.Entity<Standard>().HasMany(s => s.Classes).WithRequired(s => s.Standards);//.WillCascadeOnDelete();

            //Classes -> Batch one to many relation
            modelBuilder.Entity<Class>().HasMany(c => c.Divisions).WithRequired(c => c.Classs);//.WillCascadeOnDelete();

            //Admission -> (Admission_Additional_Info,Guardian_Details,Last_Attended_Details one to one relation
            modelBuilder.Entity<Admissions>().HasOptional(aai => aai.Admission_Additional_Infos).WithRequired(a => a.Admission);
            modelBuilder.Entity<Admissions>().HasOptional(gd => gd.Guardian_Details).WithRequired(a => a.Admissions);
            modelBuilder.Entity<Admissions>().HasOptional(lad => lad.Last_Attended_Details).WithRequired(a => a.Admissionsl);
        }

    }
}