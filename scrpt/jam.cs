using System;
using System.Threading;
class program
{
	static void main()
	{
		int jam = 0;
		int menit = 0;
		int detik = 0;
		while (true) 
		{
			if (detik >= 60)
			{
				detik = detik = 0;
				menit = menit + 1;
			}
			else if (menit >= 60)
			{
				menit = menit = 0;
				jam = jam + 1;
			}
			else if (jam >= 24)
			{
				jam = jam = 0;
			}
			Console.WriteLine($"{jam} : {menit} : {detik}");
			Threading.Sleep(1.0);
		}
	}
}