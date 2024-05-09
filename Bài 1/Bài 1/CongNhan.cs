using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class CongNhan : CanBo
    {
        private int bac;

        public int Bac { get => bac; set => bac = value; }

        public CongNhan() { }
        public CongNhan(string hoten, int tuoi, string gioitinh, string diachi,int bac) : base(hoten,tuoi,gioitinh,diachi) 
        {
            this.Bac = bac;
        }
        ~CongNhan() { }
        public override string ToString()
        {
            return base.ToString() + $",Bậc : {this.Bac}";
        }
    }
}
