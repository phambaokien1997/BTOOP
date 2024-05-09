using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            while(true)
            {
                Console.WriteLine("Quản lý cán bộ");
                Console.WriteLine("1.Thêm một cán bộ");
                Console.WriteLine("2.Tìm kiếm cán bộ theo họ tên");
                Console.WriteLine("3.Hiện thôngtin về danh sách cán bộ");
                Console.WriteLine("4.Thoát chương trình ");
                Console.WriteLine("Chọn một tác vụ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: qlcb.ThemMoiCanBo();
                        break;
                    case 2:
                        Console.WriteLine("Nhập tên cán bộ muốn tìm vào đây");
                        string ten = Console.ReadLine();
                        qlcb.TimKiemTheoHoTen(ten);
                        break;
                    case 3:
                        qlcb.HienThiDanhSachCanBo();
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình!");
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ");
                        break;

                }
                Console.WriteLine();
                
            }    
        }
        
    }
}
