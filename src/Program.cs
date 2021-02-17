using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
	class Program
	{
		/// <summary>
		/// Hàm chạy đầu tiện khi chương trình đc biên dịch
		/// </summary>
		/// <param name="args"></param>
		static void Khoa(string[] args)
		{
            #region Console.Write()

            Console.Write("Hello");
            Console.Write(10);
            Console.Write(10.9f);
            Console.Write(false);

            #endregion

            #region Console.WriteLine()

            // Console.WriteLine("Hello");
            // Console.WriteLine(10);
            // Console.WriteLine(10.9f);
            // Console.WriteLine(true);

            #endregion

            Console.ReadKey();
		}
    }
}
