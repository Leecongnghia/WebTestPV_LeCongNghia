namespace WebTestPV_LeCongNghia.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebTestPV_LeCongNghia.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebTestPV_LeCongNghia.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebTestPV_LeCongNghia.Models.AppDbContext context)
        {
            var khoaHocs = new List<KhoaHoc>
        {
            new KhoaHoc { TenKhoaHoc = "Front End" },
            new KhoaHoc { TenKhoaHoc = "Back End" },
            new KhoaHoc { TenKhoaHoc = "Dotnet Core" }
        };

            context.KhoaHocs.AddRange(khoaHocs);
            context.SaveChanges();

            var MonHocs = new List<MonHoc>
        {
            new MonHoc { TenMonHoc = "Bootstrap", KhoaHocID = 1 },
            new MonHoc { TenMonHoc = "Angular JS", KhoaHocID = 1 },
            new MonHoc { TenMonHoc = "Angular", KhoaHocID = 1 },
            new MonHoc { TenMonHoc = "React JS", KhoaHocID = 1 },
            new MonHoc { TenMonHoc = "Dotnet", KhoaHocID = 2 },
            new MonHoc { TenMonHoc = "ASP NET", KhoaHocID = 2 },
            new MonHoc { TenMonHoc = "Net Core", KhoaHocID = 3 }
        };

            context.MonHocs.AddRange(MonHocs);
            context.SaveChanges();
        }
    }
}
