using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Control;
using Microsoft.FSharp.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace Govno8;
internal static class Govno8_Main
{
	public static void Mein()
	{
		Govno8_Main.random_0 = new Random();
		Govno8_Main.doubleBufferForm_0 = new Govno8.DoubleBufferForm();
		Govno8_Main.byte_0 = ArrayModule.Create<byte>(4096, 0);
		Govno8_Main.ushort_0 = 512;
		Govno8_Main.string_0 = string.Empty;
		Govno8_Main.openFileDialog_0 = new OpenFileDialog();
		Govno8.OpenBinDialog.Title = "Open Chip-8 ROM File";
		Govno8.OpenBinDialog.Filter = "Chip-8 ROM Files|*.ch8|All files|*.*";
		switch (Govno8.OpenBinDialog.ShowDialog())
		{
			case DialogResult.OK:
				{
					byte[] array = File.ReadAllBytes(Govno8.OpenBinDialog.FileName);
					if (array.Length != 0 && array.Length <= 3583)
					{
						Govno8.RomName = Govno8.OpenBinDialog.FileName;
						array.CopyTo(Govno8.Memory, (int)Govno8.PC);
					}
					else
					{
						MessageBox.Show("Invalid ROM file", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(1);
					}
					break;
				}
			default:
				Environment.Exit(1);
				break;
		}
		Govno8_Main.byte_1 = new byte[]
		{
				240, 144, 144, 144, 240, 32, 96, 32, 32, 112,
				240, 16, 240, 128, 240, 240, 16, 240, 16, 240,
				144, 144, 240, 16, 16, 240, 128, 240, 16, 240,
				240, 128, 240, 144, 240, 240, 16, 32, 64, 64,
				240, 144, 240, 144, 240, 240, 144, 240, 16, 240,
				240, 144, 240, 144, 144, 224, 144, 224, 144, 224,
				240, 128, 128, 128, 240, 224, 144, 144, 144, 224,
				240, 128, 240, 128, 240, 240, 128, 240, 128, 128
		};
		Govno8.Fontset.CopyTo(Govno8.Memory, 0);
		Govno8_Main.ushort_1 = 0;
		Govno8_Main.byte_2 = ArrayModule.Create<byte>(16, 0);
		Govno8_Main.ushort_2 = 0;
		Govno8_Main.ushort_3 = ArrayModule.Create<ushort>(16, 0);
		Govno8_Main.ushort_4 = 0;
		Govno8_Main.byte_3 = ArrayModule.Create<byte>(16, 0);
		Govno8_Main.byte_4 = ArrayModule.Create<byte>(2048, 0);
		Govno8_Main.byte_5 = 0;
		Govno8_Main.byte_6 = 0;
		Govno8_Main.dateTime_0 = DateTime.Now;
		Govno8_Main.dateTime_1 = DateTime.Now;
		Govno8_Main.fsharpAsync_0 = ExtraTopLevelOperators.DefaultAsyncBuilder.Delay<Unit>(Govno8.Class6.class6_0);
		Govno8.Form.ClientSize = new Size(1024, 512);
		CommonExtensions.AddToObservable<EventArgs>(Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.CreateEvent<EventHandler, EventArgs>(Govno8.Class7.class7_0, Govno8.Class8.class8_0, Govno8.Class10.class10_0), Govno8.Class11.class11_0);
		CommonExtensions.AddToObservable<PaintEventArgs>(Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.CreateEvent<PaintEventHandler, PaintEventArgs>(Govno8.Class12.class12_0, Govno8.Class13.class13_0, Govno8.Class15.class15_0), Govno8.Class16.class16_0);
		CommonExtensions.AddToObservable<KeyEventArgs>(Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.CreateEvent<KeyEventHandler, KeyEventArgs>(Govno8.Class17.class17_0, Govno8.Class18.class18_0, Govno8.Class20.class20_0), Govno8.Class21.class21_0);
		CommonExtensions.AddToObservable<KeyEventArgs>(Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.CreateEvent<KeyEventHandler, KeyEventArgs>(Govno8.Class22.class22_0, Govno8.Class23.class23_0, Govno8.Class25.class25_0), Govno8.Class26.class26_0);
		Govno8.Form.Text = string.Format("{0} - Chip-F Emulator", Govno8.RomName);
		Govno8.Form.MaximizeBox = false;
		Govno8.Form.FormBorderStyle = FormBorderStyle.FixedSingle;
		Application.Run(Govno8.Form);
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static Random random_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static Govno8.DoubleBufferForm doubleBufferForm_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte[] byte_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static ushort ushort_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static OpenFileDialog openFileDialog_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte[] byte_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static ushort ushort_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte[] byte_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static ushort ushort_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static ushort[] ushort_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static ushort ushort_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte[] byte_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte[] byte_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte byte_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static byte byte_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static DateTime dateTime_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static DateTime dateTime_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static FSharpAsync<Unit> fsharpAsync_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal static int int_0;
}