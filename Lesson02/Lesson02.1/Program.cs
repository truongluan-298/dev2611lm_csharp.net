using System.Text;

namespace Lesson02._1
{
    internal class Program
    {
        /// <summary>
        /// chương trình đầu tiên: nhập tên và in lời chào
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên của bạn");
            string? name = Console.ReadLine();
            Console.WriteLine($"Xin chao {name}! Chào mừng đến .NET 10");
        }
    }
}
