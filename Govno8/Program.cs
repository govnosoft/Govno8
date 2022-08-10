using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Govno8;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Marshal.PrelinkAll(typeof(Govno8_Main));
		Trace.AutoFlush = true;
		Trace.Listeners.Clear();
		Trace.Listeners.Add(new ConsoleTraceListener());
		Trace.Listeners.Add(new TextWriterTraceListener(System.IO.Path.GetFileNameWithoutExtension(typeof(Program).Assembly.GetName().Name) + ".log"));
		Process currentProcess = Process.GetCurrentProcess();
		currentProcess.PriorityClass = ProcessPriorityClass.High;
		Console.BackgroundColor = ConsoleColor.Black;
		Console.ForegroundColor = ConsoleColor.White;

		try
		{
			Govno8_Main.Mein();
		}
		catch (Exception value)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("client-crash.log", append: true))
				{
					streamWriter.WriteLine(value);
				}

			}
			catch
			{
			}
		}
	}
}