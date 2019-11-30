using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class LopHocPhan
    {
        [Key]
        public string MaLHP { get; set; }

        public int NamHoc { get; set; }

        public string HocKy { get; set; }

        public float? DiemGK { get; set; }

        public float? DiemCuoiKy { get; set; }
        
        public string MaMon { get; set; }
        [ForeignKey("MonHoc")]
        public MonHoc MonHoc { get; set; }
    }
}
