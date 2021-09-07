using System;
using System.Text;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            var app = new App();
            app.Run();
        }

    }
}
