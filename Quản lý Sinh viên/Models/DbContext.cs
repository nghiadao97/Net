using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class DbContext : dbContext
    {
        private DbContextOptions<MyDBContext> options;

        public DbContext(dbContextOptions option) : base(option)
        {

        }

        public DbContext(DbContextOptions<MyDBContext> options)
        {
            this.options = options;
        }

        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
    }
}
