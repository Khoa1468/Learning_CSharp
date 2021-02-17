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
		static void Main(string[] args)
		{
			#region Bien
			int kieuSoNguyen = 10;
			float kieuSoThuc = 10.9f;
			string kieuChuoi = "Hello World!";
			bool kieuLuanLy = true;
			char kieuKyTu = 'K';

			#endregion

			Console.WriteLine(kieuSoNguyen);
			Console.WriteLine(kieuChuoi);

			Console.ReadKey(true);
		}
    }
}
