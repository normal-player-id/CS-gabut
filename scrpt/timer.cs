using System;
using System.Threading;

class Program
{

	static void Main()
	{
		int tunggu = 0;

		while (true)
		{
			Console.WriteLine("=timer=");
			Console.WriteLine("edit");
			Console.WriteLine("run");
			Console.WriteLine("[Keluar]");
			string jawab = Console.ReadLine();
			if (jawab == "edit")
			{
				Console.Write("jawab: ");
				int jawab_nilai = tunggu = int.Parse(Console.ReadLine());
				jawab_nilai = tunggu;
				Console.WriteLine("berhasil");
				Console.WriteLine($"int tunggu = {tunggu};");
			}
			else if (jawab == "run")
			{
				Console.WriteLine($"gua hjtung dari 0 sampai{tunggu - 1} setiap 1detik");
				for (int idk = 0; idk < tunggu; idk++)
				{
					Thread.Sleep(1000);
					Console.WriteLine(idk);
				}
				Console.WriteLine("tugas gua selesai nih");
			}
			else if (jawab == "keluar")
			break;
		}
	}
}
