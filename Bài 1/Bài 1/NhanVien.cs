using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class NhanVien : CanBo
    {
        private string congViec;
        public string CongViec { get => congViec; set => congViec = value; }
        public NhanVien() { }
        public NhanVien(string hoten, int tuoi, string gioitinh, string diachi, string congviec) : base(hoten,tuoi,gioitinh,diachi)
        {
            this.CongViec=congviec;
        }
        ~NhanVien() { }
        public override string ToString()
        {
            return base.ToString() +$",Công việc : {this.CongViec}";
        }
    }
}
