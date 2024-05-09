using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class CanBo
    {
        private string hoTen;
        private int tuoi;
        private string gioiTinh;
        private string diaChi;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public CanBo()
        {

        }
        public CanBo(string hoten, int tuoi,string gioitinh, string diachi)
        {
            this.HoTen = hoten;
            this.Tuoi = tuoi;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
        }
        ~CanBo() { }
        public override string ToString()
        {
            return $"Họ tên: {this.HoTen}, Tuổi : {this.Tuoi}, Giới tính : {this.GioiTinh}, Địa chỉ : {this.DiaChi}";
        }

    }
}
