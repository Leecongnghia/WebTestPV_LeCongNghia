using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebTestPV_LeCongNghia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        { }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }

        
    }
}