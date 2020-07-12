using System;
using System.Collections.Generic;
using System.Text;
using Cet322_FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cet322_FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext        
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
