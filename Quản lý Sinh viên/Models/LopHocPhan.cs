using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class LopHocPhan
    {
        [Key]
        public int MaLHP { get; set; }
        public int NamHoc { get; set; }
        public int HocKy { get; set; }
        public string Mon { get; set; }
        public int DiemGK { get; set; }
        public int DiemCuoiKy { get; set; }
    }
}
