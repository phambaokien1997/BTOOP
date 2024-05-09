using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class Sach : ThuVien
    {
        private string tenTacGia;
        private int soTrang;

        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }

        public Sach() { }
        public Sach(string matailieu, string tennhaxuatban, int sobanphathanh, string tentacgia, int sotrang) : base (matailieu,tennhaxuatban,sobanphathanh)
        {
            this.TenTacGia = tentacgia;
            this.SoTrang = sotrang;
        }
        ~Sach() { }
        public override string ToString()
        {
            return base.ToString() + $",Tên tác giả : {this.TenTacGia}, Số trang : {this.SoTrang}";
        }
    }
}
