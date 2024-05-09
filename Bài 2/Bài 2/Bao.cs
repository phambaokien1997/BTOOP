using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class Bao : ThuVien
    {
        private DateTime ngayPhatHanh;

        public DateTime NgayPhatHanh { get => ngayPhatHanh; set => ngayPhatHanh = value; }
        public Bao() { }
        public Bao(string matailieu, string tennhaxuatban, int sobanphathanh, DateTime ngayphathanh) : base (matailieu,tennhaxuatban,sobanphathanh)
        {
            this.NgayPhatHanh = ngayphathanh;
        }
        ~Bao() { }
        public override string ToString()
        {
            return base.ToString() + $",Ngày phát hành : {this.NgayPhatHanh.ToString("dd/MM/yyyy")}" ;
        }
    }
}
