namespace Lesson02._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //1. nullable
            int? soLuong = null;
            string? ghiChu = null;
            string ten = "Luân";

            int n = soLuong ?? 0;
            int len = ghiChu?.Length ?? 0;
            ghiChu ??= "Không có";
            Console.WriteLine($"n ={n}, len = {len}, ghiChu = {ghiChu}");
            if (ten is not null)
                Console.WriteLine(ten.ToUpper());
            //2. Boxing và unboxxing
            int num = 42;
            object boxed = num;
            int back = (int)boxed;
            Console.WriteLine($"num = {num}, boxed = {boxed}, back = {back}");
            try
            {
                long sai = (long)boxed;
                Console.WriteLine(sai);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Lỗi : {ex.GetType().Name}");
            }
            long dung = (int)boxed;
            Console.WriteLine($"Ép đúng cách : {dung}");

            //3. Giá trị mặc định
            int d1 = default;
            bool d2 = default;
            string? d3 = default;
            string d3Text = d3 ?? "null";
            string d4 = default(DateTime).ToString("yyyy-MM-dd");
            Console.WriteLine($"{d1} | {d2} | {d3Text} | {d4}");
        }
    }
}
