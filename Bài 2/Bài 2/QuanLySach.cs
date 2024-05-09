using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class QuanLySach 
    {
        private List<ThuVien> danhSachTrongThuVien = new List<ThuVien>();

        public List<ThuVien> DanhSachTrongThuVien { get => danhSachTrongThuVien; set => danhSachTrongThuVien = value; }

        public void ThemMoiTaiLieu()
        {  
                Console.WriteLine("Mời bạn nhập mã tài liệu :");
                string maTaiLieu = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tên nhà xuất bản : ");
                string tenNhaXuatBan = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập số bản phát hành :");
                int soBanPhatHanh = int.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn chọn loại tài liệu: 1. Sách, 2.Tạp chí, 3.Báo!!");
                int loaiTL = int.Parse(Console.ReadLine());

                ThuVien thuVien = null;
                switch (loaiTL)
                {
                    case 1:
                        Console.WriteLine("Mời bạn nhập tên tác giả ");
                        string tenTacGia = Console.ReadLine();
                        Console.WriteLine("Mời bạn nhập số trang ");
                        int soTrang = int.Parse(Console.ReadLine());
                        thuVien = new Sach(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, tenTacGia, soTrang);
                        break;
                    case 2:
                        Console.WriteLine("Mời bạn nhập số ngày phát hành :");
                        int soNgayPhatHanh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Mời bạn nhập tháng phát hành :");
                        int thangPhatHanh = int.Parse(Console.ReadLine());
                        thuVien = new TapChi(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, soNgayPhatHanh, thangPhatHanh);
                        break;
                    case 3:
                        Console.WriteLine("Mời bạn nhập vào ngày phát hành");
                        DateTime ngayPhatHanh = DateTime.Parse(Console.ReadLine());
                        thuVien = new Bao(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, ngayPhatHanh);
                        break;
                    default:
                        Console.WriteLine("Nhập cho đúng mục để chọn loại tài liệu:");
                        break;

                }
                DanhSachTrongThuVien.Add(thuVien);
                Console.WriteLine("Bạn đã thêm thành công một tài liệu.");
           
        }
        public void XoaTaiLieuTheoMaTaiLieu(string matailieu)
        {
            foreach (var tl in DanhSachTrongThuVien)
            {
                if (tl.MaTaiLieu.Contains(matailieu))
                {
                    DanhSachTrongThuVien.Remove(tl);
                }    
            }    
        }
        public void HienThiThongTinVeTaiLieu()
        {
            foreach(var tl in DanhSachTrongThuVien)
            {
                Console.WriteLine(tl);
            }    
        }
        public void TimKiemTaiLieuTheoLoai(string loai)
        {
            if (loai == "Sách")
            {
                Console.WriteLine("Danh sách sách trong thư viện là :");
                foreach (var tl in DanhSachTrongThuVien)
                {
                    if (tl is Sach)
                    {
                        Console.WriteLine(tl);
                    }
                }
            }  
            else if (loai == "Tạp chí")
            {
                Console.WriteLine("Danh sách Tạp chí trong thư viện là :");
                foreach (var tl in DanhSachTrongThuVien)
                {
                    if (tl is TapChi)
                    {
                        Console.WriteLine(tl);
                    }
                }
            }
            else if (loai == "Báo")
            {
                Console.WriteLine("Danh sách Báo trong thư viện là :");
                foreach (var tl in DanhSachTrongThuVien)
                {
                    if (tl is Bao)
                    {
                        Console.WriteLine(tl);
                    }
                }
            }    
            
        }
    }
}
