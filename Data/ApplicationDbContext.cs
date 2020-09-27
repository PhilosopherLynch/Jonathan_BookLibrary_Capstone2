using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
            .HasData(
                new Book
                { 
                    Id = 1,
                    Title = "Prince Caspian", 
                    Author = "C.S. Lewis", 
                    Genre = "Fantasy", 
                    Chapters = 15, 
                    YearOfPublish = new DateTime(1951, 10, 15), 
                    Completed = true,
                    UserId = "2845a7e7-b0cc-4500-a672-10d476d09ac4"
                },
                new Book
                { 
                    Id = 2, 
                    Title = "The Hobbit", 
                    Author = "J.R.R. Tolkien", 
                    Genre = "Fantasy", Chapters = 19, 
                    YearOfPublish = new DateTime(1939, 9, 21), 
                    Completed = true,
                    UserId = "2845a7e7-b0cc-4500-a672-10d476d09ac4"
                },
                new Book 
                { 
                    Id = 3, 
                    Title = "Starship Troopers", 
                    Author = "Robert A. Heinlin", 
                    Genre = "Sci-fi", 
                    Chapters = 14, 
                    YearOfPublish = new DateTime(1959, 11, 1), 
                    Completed = true,
                    UserId = "2845a7e7-b0cc-4500-a672-10d476d09ac4"
                },
                new Book 
                { 
                    Id = 4, 
                    Title = "Radical", 
                    Author = "Davic Platt", 
                    Genre = "Christian", 
                    Chapters = 9, 
                    YearOfPublish = new DateTime(2010, 4, 25), 
                    Completed = false,
                    UserId = "2845a7e7-b0cc-4500-a672-10d476d09ac4"
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
