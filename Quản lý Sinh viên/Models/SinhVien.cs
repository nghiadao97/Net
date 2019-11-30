﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quản_lý_Sinh_viên.Models
{
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int DienThoai { get; set; }
    }
}
