using System.Globalization;
using System.Text;

namespace Lesson2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            const decimal VatRate = 0.1m;
            var vn = new CultureInfo("vi-VN");
            Console.Write("Tên sản phẩm: ");
            string? tenSp = Console.ReadLine();
            Console.WriteLine("Đơn giá (VNĐ): ");
            decimal donGia;
            while (!decimal.TryParse(Console.ReadLine(), out donGia) || donGia <= 0)
                Console.WriteLine("Giá trị không hợp lệ, nhập lại :");
            Console.WriteLine("Số lượng: ");
            decimal soLuong;
            while (!decimal.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
                Console.WriteLine("Giá trị không hợp lệ, nhập lại :");

            // Tính toán
            decimal thanhTien = donGia * soLuong;
            decimal vat = thanhTien * VatRate;
            decimal tongCong = thanhTien + vat;

            // In hóa đơn
            Console.WriteLine("\n ======= HÓA ĐƠN ======");
            Console.WriteLine($" Sản phẩm : {tenSp}");
            Console.WriteLine(string.Format(vn,"Đơn giá: {0:N0} đ", donGia));
            Console.WriteLine($" Số lượng : {soLuong}");
            Console.WriteLine(string.Format(vn, "Thành tiền: {0:N0} đ", thanhTien));
            Console.WriteLine(string.Format(vn, "VAT 10%: {0:N0} đ", vat));
            Console.WriteLine(string.Format(vn, "Tổng cộng: {0:N0} đ", tongCong));
        }
    }
}
