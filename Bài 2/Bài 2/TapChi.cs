using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class TapChi : ThuVien
    {
        private int soPhatHanh;
        private int thangPhatHanh;

        public int SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public int ThangPhatHanh { get => thangPhatHanh; set => thangPhatHanh = value; }

        public TapChi() { }
        public TapChi(string matailieu, string tennhaxuatban, int sobanphathanh, int sophathanh, int thangphathanh) : base(matailieu,tennhaxuatban,sobanphathanh)
        {
            this.SoPhatHanh= sophathanh;
            this.ThangPhatHanh = thangphathanh;

        }
        ~TapChi() { }
        public override string ToString()
        {
            return base.ToString() + $", Số phát hành : {this.SoPhatHanh}, Tháng phát hành : {this.ThangPhatHanh}";
        }
    }
}
