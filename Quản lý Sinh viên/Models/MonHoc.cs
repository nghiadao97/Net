using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class MonHoc
    {
        [Key]
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
    }
}
