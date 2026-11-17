using System.Globalization;
using System.Text;

namespace Lesson01._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string? maNhanVien = "NV000001";
            string? tenNhanVien = "Trương Thành Luân";
            DateTime? ngaySinh = new DateTime(1992, 08, 29);
            string? diaChi = "Đại Mỗ, Hà Nội";
            string? dienThoai = "098231153";
            string? email = "luan.tkt.5@gmail.com";

            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine("Mã nhân viên: " + maNhanVien);
            Console.WriteLine("Mã nhân viên: " + tenNhanVien);
            Console.WriteLine("Ngày sinh: " + ngaySinh?.ToString("dd/MM/yyyy"));
            Console.WriteLine("Địa chỉ: " + diaChi);
            Console.WriteLine("Điện thoại: " + dienThoai);
            Console.WriteLine("Email: " + email);
        }
    }
}
