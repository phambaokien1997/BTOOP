using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class QLCB : CanBo
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public List<CanBo> DanhSachCanBo { get => danhSachCanBo; set => danhSachCanBo = value; }
        public void ThemMoiCanBo()
        {
            Console.WriteLine("Mời bạn nhập tên cán bộ:");
            string ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tuổi của cán bộ:");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập giới tính của cán bộ:");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập địa chỉ của cán bộ");
            string diachi = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập loại cán bộ 1: Công nhân, 2: Kỹ sư, 3 :Nhân viên");
            int loaiCB = int.Parse(Console.ReadLine());
            CanBo canBo = null;
            switch (loaiCB)
            {
                case 1:
                    Console.WriteLine("Mời bạn nhập bậc của công nhân:");
                    int bac = int.Parse(Console.ReadLine());
                    canBo = new CongNhan(ten, tuoi, gioitinh, diachi, bac);
                    break;
                case 2:
                    Console.WriteLine("Mời bạn nhập vào ngành đào tạo của kĩ sư:");
                    string nganhdaotao = Console.ReadLine();
                    canBo = new KySu(ten, tuoi, gioitinh, diachi, nganhdaotao);
                    break;
                case 3:
                    Console.WriteLine("Mời bạn nhập vào công việc của Nhân viên:");
                    string congviec = Console.ReadLine();
                    canBo = new NhanVien(ten, tuoi, gioitinh, diachi, congviec);
                    break;
            }
            danhSachCanBo.Add(canBo);
            Console.WriteLine("Thêm mới cán bộ thành công!!!");
        }
        public void TimKiemTheoHoTen(string ten)
        {
            int count = 0;
            foreach(var cb in danhSachCanBo)
            {
                if (cb.HoTen.Contains(ten))
                {
                    Console.WriteLine(cb);
                    count++;
                }    
               
            }    
            if (count == 0)
            {
                Console.WriteLine("Không tìm thấy tên cán bộ");
            } 
                
        }
        public void HienThiDanhSachCanBo()
        {
            foreach(var cb in danhSachCanBo)
            {
                Console.WriteLine(cb);
            }    
        }
    }

}
