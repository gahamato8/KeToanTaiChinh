using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeToanTaiChinh
{
    public class KT_Data
    {

    }
    public class Person
    {
        public string ho_ten { get; set; } = default;
        public string ma_so { get; set; } = default;
        public DateTime ngay_sinh { get; set; }
        public string gioi_tinh { get; set; } = default;
        public string so_dien_thoai { get; set; } = default;
        public string tinh_thanh_pho { get; set; } = default;
        public string quan_huyen { get; set; } = default;
        public string phuong_xa { get; set; } = default;
        public string so_nha_duong { get; set; } = default;

    }
    public class KhoiLop
    {
        public int ma_khoi { get; set; }
        public string ma_khoi_bo { get; set; } = default;
        public string ten_khoi { get; set; } = default;
        public KhoiLop Clone()
        {
            return new KhoiLop
            {
                ma_khoi = this.ma_khoi,
                ma_khoi_bo = this.ma_khoi_bo,
                ten_khoi = this.ten_khoi
            };
        }
    }
    public class LopHoc
    {
        public int ma_lop { get; set; }
        public string ma_lop_bo { get; set; } = default;
        public string ten_lop { get; set; } = default;
        public string ma_khoi { get; set; } = default;
        //public int hoc_ky { get; set; } = default!;
        //public string loai_lop { get; set; } = default!;
        public string buoi_hoc { get; set; } = default;
        //public string link_phong_hoc { get; set; } = default!;
        public string khoi_lop { get; set; } = default;
        public LopHoc Clone()
        {
            return new LopHoc()
            {
                ma_lop = this.ma_lop,
                ma_lop_bo = this.ma_lop_bo,
                ten_lop = this.ten_lop,
                ma_khoi = this.ma_khoi,
                //hoc_ky = this.hoc_ky,
                //loai_lop = this.loai_lop,
                buoi_hoc = this.buoi_hoc,
                //link_phong_hoc = this.link_phong_hoc,
                khoi_lop = this.khoi_lop
            };
        }

    }
    public class HocSinh : Person
    {
        [Key]
        public string ma_hoc_sinh { get; set; } = default;
        public int id_hoc_sinh_so { get; set; }
        public string ma_so_dinh_danh_ca_nhan { get; set; } = default;
        public string trang_thai_hoc_sinh { get; set; } = default;
        public string trang_thai_hoc_tap { get; set; } = default;
        public string hinh_thuc_hoc_tap { get; set; } = default;
        public string ten_phu_huynh { get; set; } = default;
        public string face_id { get; set; } = default;
        public string dia_chi { get; set; } = default;
        public int ma_lop { get; set; } = default;
        public string ten_lop { get; set; } = default;
        public int ma_truong_bo { get; set; } = default;
        public int ma_khoi { get; set; } = default;
        public HocSinh Clone()
        {
            return new HocSinh()
            {
                ma_hoc_sinh = this.ma_hoc_sinh,
                id_hoc_sinh_so = this.id_hoc_sinh_so,
                ma_so_dinh_danh_ca_nhan = this.ma_so_dinh_danh_ca_nhan,
                ma_lop = this.ma_lop,
                trang_thai_hoc_sinh = this.trang_thai_hoc_sinh,
                trang_thai_hoc_tap = this.trang_thai_hoc_tap,
                hinh_thuc_hoc_tap = this.hinh_thuc_hoc_tap,
                ten_phu_huynh = this.ten_phu_huynh,
                face_id = this.face_id,
                dia_chi = this.dia_chi,
                ho_ten = this.ho_ten,
                ma_so = this.ma_so,
                ngay_sinh = this.ngay_sinh,
                gioi_tinh = this.gioi_tinh,
                so_dien_thoai = this.so_dien_thoai,
                ma_truong_bo = this.ma_truong_bo,
                ma_khoi = this.ma_khoi,
            };
        }

    }
}
