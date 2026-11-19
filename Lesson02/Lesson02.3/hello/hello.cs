using Humanizer;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine($"Hôm nay là {DateTime.Now: dd/MM/yyyy HH:mm:ss}");
Console.WriteLine($"Đang chạy trên {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

Console.WriteLine("hello world".Titleize());
Console.WriteLine(DateTime.Now.AddHours(-3).Humanize());