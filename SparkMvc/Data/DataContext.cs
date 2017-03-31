using SparkMvc.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks; 
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SparkMvc.Data
{ 
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Contact> Contacts { get; set; } 

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}