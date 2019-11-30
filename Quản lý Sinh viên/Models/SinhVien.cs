using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }

        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        public string DienThoai { get; set; }

        public string MaLopHP { get; set; }
        [ForeignKey("MaLHP")]
        public LopHocPhan LopHocPhan { get; set; }

        public string MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public Khoa Khoa { get; set; }



    }
}
