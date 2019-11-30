using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class Khoa
    {
        [Key]
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
