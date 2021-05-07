using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace kekFN
{
	// Token: 0x02000003 RID: 3
	internal class Class2
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000022F8 File Offset: 0x000004F8
		public static void Tester()
		{
			int num = 0;
			new char[62];
			char[] array = "".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % array.Length]);
			}
			Console.Title = (((stringBuilder != null) ? stringBuilder.ToString() : null) ?? "");
			new Thread(new ThreadStart(Class2.Tester)).Start();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002390 File Offset: 0x00000590
		public static void Print(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(sec);
			}
		}
	}
}
