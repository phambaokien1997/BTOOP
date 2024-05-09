using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class ThuVien
    {
        private string maTaiLieu;
        private string tenNhaXuatBan;
        private int soBanPhatHanh;

        public string MaTaiLieu { get => maTaiLieu; set => maTaiLieu = value; }
        public string TenNhaXuatBan { get => tenNhaXuatBan; set => tenNhaXuatBan = value; }
        public int SoBanPhatHanh { get => soBanPhatHanh; set => soBanPhatHanh = value; }
        public ThuVien() { }
        public ThuVien(string matailieu, string tennhaxuatban, int sobanphathanh)
        {
            this.MaTaiLieu = matailieu;
            this.TenNhaXuatBan = tennhaxuatban;
            this.SoBanPhatHanh = sobanphathanh;
        }
        ~ThuVien () { }
        public override string ToString()
        {
            return $"Mã tài liệu : {this.MaTaiLieu}, Tên nhà xuất bản : {this.tenNhaXuatBan}, Số bản phát hành : {this.soBanPhatHanh}";
        }
    }
}
