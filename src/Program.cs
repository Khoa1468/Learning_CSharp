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
		/// class Program là hàm chạy đầu tiên trong chương trình
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int num1 = 5;
			int num2 = int.Parse(Console.ReadLine());
			int sum = num1 + num2;

			Console.WriteLine(sum);

			Console.ReadKey(true);
		}
	}
}
