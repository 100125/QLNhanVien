namespace QLNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public long Id { get; set; }
        [Display(Name ="Ho va ten")]
        [Required]
        [StringLength(200)]

        public string HoVaTen { get; set; }
        [Display(Name = "Gioi Tinh")]
        public bool GioiTinh { get; set; }

        [StringLength(200)]
        [Display(Name = "Dia chi email")]
        public string Email { get; set; }

        [StringLength(20)]
        [Display(Name = "So dien thoai")]
        public string SoDienThoai { get; set; }

        [StringLength(20)]
        [Display(Name = "So can cuoc")]
        public string SoCanCuoc { get; set; }

        [StringLength(200)]
        [Display(Name = "Ten dang nhap")]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        [Display(Name = "Mat khau")]
        public string MatKhau { get; set; }
        [Display(Name = "Chuc vu")]
        public long? IdChucVu { get; set; }
        [Display(Name = "La quan tri vien")]
        public bool LaQuanTri { get; set; }
        [Display(Name = "La chuyen vien")]
        public bool LaChuyenVien { get; set; }
        [Display(Name = "La nhan vien")]
        public bool LaNhanVien { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
