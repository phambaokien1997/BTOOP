using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class KySu : CanBo
    {
        private string nganhDaoTao;

        public string NganhDaoTao { get => nganhDaoTao; set => nganhDaoTao = value; }
        public KySu() { }
        public KySu(string hoten, int tuoi, string gioitinh, string diachi,string nganhdaotao) : base(hoten,tuoi,gioitinh,diachi)
        {
            this.NganhDaoTao=nganhdaotao;
        }
        ~KySu() { }
        public override string ToString()
        {
            return base.ToString() + $",Ngành đào tạo : {this.NganhDaoTao}";
        }
    }
}
