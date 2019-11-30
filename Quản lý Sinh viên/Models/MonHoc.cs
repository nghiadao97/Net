using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class MonHoc
    {
        [Key]
        public string MaMon { get; set; }

        public string TenMon { get; set; }

        public int SoTinChi { get; set; }

        public string MaKhoa { get; set; }
        [ForeignKey("Khoa")]
        public Khoa Khoa { get; set; }
    }
}
