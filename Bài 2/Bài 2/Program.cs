using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLySach quanLySach = new QuanLySach();
            while(true)
            {
                Console.WriteLine("Quản Lý Sách ");
                Console.WriteLine("1. Thêm mới tài liệu");
                Console.WriteLine("2. Xóa tài liệu theo mã tài liệu");
                Console.WriteLine("3. Hiển thị thông tin tài liệu");
                Console.WriteLine("4. Tìm kiếm tài liệu theo loại");
                Console.WriteLine("5. Thoát chương trình");
                Console.WriteLine("mời bạn chọn một tác vụ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        quanLySach.ThemMoiTaiLieu();
                        break;
                    case 2:
                        Console.WriteLine("Mời bạn nhập mã tài liệu muốn xóa");
                        string maTaiLieu = Console.ReadLine();
                        quanLySach.XoaTaiLieuTheoMaTaiLieu(maTaiLieu);
                        break;
                    case 3:
                        quanLySach.HienThiThongTinVeTaiLieu();
                        break;
                    case 4:
                        Console.WriteLine("Mời bạn nhập loại tài liệu bạn muốn hiển thị (Báo,Tạp chí, Sách)");
                        string loai = Console.ReadLine();
                        quanLySach.TimKiemTaiLieuTheoLoai(loai);
                        break;
                    case 5: Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Bạn chọn không đúng tác vụ!!");
                        break;
                }
                Console.WriteLine();
            }    
        }
    }
}
