using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Control;

namespace Govno8;

[CompilationMapping(SourceConstructFlags.Module)]
public static class Govno8
{
	public static int SCREEN_WIDTH
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		get
		{
			return 64;
		}
	}

	public static int SCREEN_HEIGHT
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		get
		{
			return 32;
		}
	}

	public static int SCALE
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		get
		{
			return 16;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static Random Random
	{
		get
		{
			return Govno8_Main.random_0;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static Govno8.DoubleBufferForm Form
	{
		get
		{
			return Govno8_Main.doubleBufferForm_0;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte[] Memory
	{
		get
		{
			return Govno8_Main.byte_0;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static ushort PC
	{
		get
		{
			return Govno8_Main.ushort_0;
		}
		set
		{
			Govno8_Main.ushort_0 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static string RomName
	{
		get
		{
			return Govno8_Main.string_0;
		}
		set
		{
			Govno8_Main.string_0 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static OpenFileDialog OpenBinDialog
	{
		get
		{
			return Govno8_Main.openFileDialog_0;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte[] Fontset
	{
		get
		{
			return Govno8_Main.byte_1;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static ushort Opcode
	{
		get
		{
			return Govno8_Main.ushort_1;
		}
		set
		{
			Govno8_Main.ushort_1 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte[] Vx
	{
		get
		{
			return Govno8_Main.byte_2;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static ushort I
	{
		get
		{
			return Govno8_Main.ushort_2;
		}
		set
		{
			Govno8_Main.ushort_2 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static ushort[] Stack
	{
		get
		{
			return Govno8_Main.ushort_3;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static ushort SP
	{
		get
		{
			return Govno8_Main.ushort_4;
		}
		set
		{
			Govno8_Main.ushort_4 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte[] Keys
	{
		get
		{
			return Govno8_Main.byte_3;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte[] Screen
	{
		get
		{
			return Govno8_Main.byte_4;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte DelayTimer
	{
		get
		{
			return Govno8_Main.byte_5;
		}
		set
		{
			Govno8_Main.byte_5 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static byte SoundTimer
	{
		get
		{
			return Govno8_Main.byte_6;
		}
		set
		{
			Govno8_Main.byte_6 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static DateTime DelayAndSoundTimersClock
	{
		get
		{
			return Govno8_Main.dateTime_0;
		}
		set
		{
			Govno8_Main.dateTime_0 = value;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static DateTime ExecutionClock
	{
		get
		{
			return Govno8_Main.dateTime_1;
		}
		set
		{
			Govno8_Main.dateTime_1 = value;
		}
	}

	public static void OnKeyPress(KeyEventArgs args)
	{
		Keys keyCode = args.KeyCode;
		switch (keyCode)
		{
			case System.Windows.Forms.Keys.D1:
				Govno8.Keys[1] = 1;
				return;
			case System.Windows.Forms.Keys.D2:
				Govno8.Keys[2] = 1;
				return;
			case System.Windows.Forms.Keys.D3:
				Govno8.Keys[3] = 1;
				return;
			case System.Windows.Forms.Keys.D4:
				Govno8.Keys[12] = 1;
				return;
			default:
				switch (keyCode)
				{
					case System.Windows.Forms.Keys.A:
						Govno8.Keys[7] = 1;
						return;
					default:
						switch (keyCode)
						{
							case System.Windows.Forms.Keys.C:
								Govno8.Keys[11] = 1;
								return;
							case System.Windows.Forms.Keys.D:
								Govno8.Keys[9] = 1;
								return;
							case System.Windows.Forms.Keys.E:
								Govno8.Keys[6] = 1;
								return;
							case System.Windows.Forms.Keys.F:
								Govno8.Keys[14] = 1;
								return;
							default:
								switch (keyCode)
								{
									case System.Windows.Forms.Keys.Q:
										Govno8.Keys[4] = 1;
										return;
									case System.Windows.Forms.Keys.R:
										Govno8.Keys[13] = 1;
										return;
									case System.Windows.Forms.Keys.S:
										Govno8.Keys[8] = 1;
										return;
									default:
										switch (keyCode)
										{
											case System.Windows.Forms.Keys.V:
												Govno8.Keys[15] = 1;
												return;
											case System.Windows.Forms.Keys.W:
												Govno8.Keys[5] = 1;
												return;
											case System.Windows.Forms.Keys.X:
												Govno8.Keys[0] = 1;
												return;
											default:
												switch (keyCode)
												{
													case System.Windows.Forms.Keys.Z:
														Govno8.Keys[10] = 1;
														return;
													default:
														return;
												}
										}
								}
						}
				}
		}
	}

	public static void OnKeyUp(KeyEventArgs args)
	{
		Keys keyCode = args.KeyCode;
		switch (keyCode)
		{
			case System.Windows.Forms.Keys.D1:
				Govno8.Keys[1] = 0;
				return;
			case System.Windows.Forms.Keys.D2:
				Govno8.Keys[2] = 0;
				return;
			case System.Windows.Forms.Keys.D3:
				Govno8.Keys[3] = 0;
				return;
			case System.Windows.Forms.Keys.D4:
				Govno8.Keys[12] = 0;
				return;
			default:
				switch (keyCode)
				{
					case System.Windows.Forms.Keys.A:
						Govno8.Keys[7] = 0;
						return;
					default:
						switch (keyCode)
						{
							case System.Windows.Forms.Keys.C:
								Govno8.Keys[11] = 0;
								return;
							case System.Windows.Forms.Keys.D:
								Govno8.Keys[9] = 0;
								return;
							case System.Windows.Forms.Keys.E:
								Govno8.Keys[6] = 0;
								return;
							case System.Windows.Forms.Keys.F:
								Govno8.Keys[14] = 0;
								return;
							default:
								switch (keyCode)
								{
									case System.Windows.Forms.Keys.Q:
										Govno8.Keys[4] = 0;
										return;
									case System.Windows.Forms.Keys.R:
										Govno8.Keys[13] = 0;
										return;
									case System.Windows.Forms.Keys.S:
										Govno8.Keys[8] = 0;
										return;
									default:
										switch (keyCode)
										{
											case System.Windows.Forms.Keys.V:
												Govno8.Keys[15] = 0;
												return;
											case System.Windows.Forms.Keys.W:
												Govno8.Keys[5] = 0;
												return;
											case System.Windows.Forms.Keys.X:
												Govno8.Keys[0] = 0;
												return;
											default:
												switch (keyCode)
												{
													case System.Windows.Forms.Keys.Z:
														Govno8.Keys[10] = 0;
														return;
													default:
														return;
												}
										}
								}
						}
				}
		}
	}

	public static void Draw(PaintEventArgs args)
	{
		SolidBrush solidBrush = new(Color.White);
		FSharpList<int> fsharpList = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(0, 1, 31)));
		for (FSharpList<int> fsharpList2 = fsharpList.TailOrNull; fsharpList2 != null; fsharpList2 = fsharpList.TailOrNull)
		{
			int headOrDefault = fsharpList.HeadOrDefault;
			FSharpList<int> fsharpList3 = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(0, 1, 63)));
			for (FSharpList<int> fsharpList4 = fsharpList3.TailOrNull; fsharpList4 != null; fsharpList4 = fsharpList3.TailOrNull)
			{
				int headOrDefault2 = fsharpList3.HeadOrDefault;
				if (Govno8.Screen[headOrDefault2 + headOrDefault * 64] != 0)
				{
					args.Graphics.FillRectangle(solidBrush, headOrDefault2 * 16, headOrDefault * 16, 16, 16);
				}
				fsharpList3 = fsharpList4;
			}
			fsharpList = fsharpList2;
		}
		solidBrush.Dispose();
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static FSharpAsync<Unit> Loop
	{
		get
		{
			return Govno8_Main.fsharpAsync_0;
		}
	}

	[CompilerGenerated]
	internal static void Smethod_0(Unit unitVar)
	{
		switch (Govno8.Opcode & 15)
		{
			case 0:
				{
					byte[] vx = Govno8.Vx;
					ushort num = (ushort)(Opcode & 3840);
					int num2 = (int)((ushort)((uint)num >> 8));
					byte[] vx2 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					vx[num2] = vx2[(int)((ushort)((uint)num >> 4))];
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 1:
				{
					byte[] vx3 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 3840);
					int num3 = (int)((ushort)((uint)num >> 8));
					byte[] vx4 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b = vx4[(int)((ushort)((uint)num >> 8))];
					byte[] vx5 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					vx3[num3] = (byte)(b | vx5[(int)(ushort)((uint)num >> 4)]);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 2:
				{
					byte[] vx6 = Govno8.Vx;
					ushort num = (ushort)(Opcode & 3840);
					int num4 = (int)((ushort)((uint)num >> 8));
					byte[] vx7 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b2 = vx7[(int)((ushort)((uint)num >> 8))];
					byte[] vx8 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					vx6[num4] = (byte)(b2 & vx8[(int)(ushort)((uint)num >> 4)]);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 3:
				{
					byte[] vx9 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 3840);
					int num5 = (int)((ushort)((uint)num >> 8));
					byte[] vx10 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b3 = vx10[(int)((ushort)((uint)num >> 8))];
					byte[] vx11 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					vx9[num5] = (byte)(b3 ^ vx11[(int)(ushort)((uint)num >> 4)]);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 4:
				{
					byte[] vx12 = Govno8.Vx;
					ushort num6 = (ushort)(Govno8.Opcode & 3840);
					ushort num7 = (ushort)vx12[(int)((ushort)((uint)num6 >> 8))];
					byte[] vx13 = Govno8.Vx;
					ushort num8 = (ushort)(Govno8.Opcode & 240);
					num6 = (ushort)vx13[(int)((ushort)((uint)num8 >> 4))];
					ushort num = (ushort)(num7 + num6);
					if (num > 255)
					{
						Govno8.Vx[15] = 1;
					}
					else
					{
						Govno8.Vx[15] = 0;
					}
					byte[] vx14 = Govno8.Vx;
					num7 = (ushort)(Govno8.Opcode & 3840);
					vx14[(int)((ushort)((uint)num7 >> 8))] = (byte)num;
					num7 = Govno8.PC;
					Govno8.PC = (ushort)(num7 + 2);
					return;
				}
			case 5:
				{
					byte[] vx15 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 240);
					byte b4 = vx15[(int)((ushort)((uint)num >> 4))];
					byte[] vx16 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					if (b4 > vx16[(int)((ushort)((uint)num >> 8))])
					{
						Govno8.Vx[15] = 0;
					}
					else
					{
						Govno8.Vx[15] = 1;
					}
					byte[] vx17 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					int num9 = (int)((ushort)((uint)num >> 8));
					byte[] vx18 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b5 = vx18[(int)((ushort)((uint)num >> 8))];
					byte[] vx19 = Govno8.Vx;
					num = (ushort)(Opcode & 240);
					byte b6 = vx19[(int)((ushort)((uint)num >> 4))];
					vx17[num9] = (byte)(b5 - b6);
					num = Govno8.PC;
					PC = (ushort)(num + 2);
					return;
				}
			case 6:
				{
					byte[] vx20 = Govno8.Vx;
					int num10 = 15;
					byte[] vx21 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 3840);
					vx20[num10] = (byte)(vx21[(int)((ushort)((uint)num >> 8))] & 1);
					byte[] vx22 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					int num11 = (int)((ushort)((uint)num >> 8));
					byte[] vx23 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b5 = vx23[(int)((ushort)((uint)num >> 8))];
					vx22[num11] = (byte)((uint)b5 >> 1);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 7:
				{
					byte[] vx24 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 3840);
					byte b7 = vx24[(int)((ushort)((uint)num >> 8))];
					byte[] vx25 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					if (b7 > vx25[(int)((ushort)((uint)num >> 4))])
					{
						Govno8.Vx[15] = 0;
					}
					else
					{
						Govno8.Vx[15] = 1;
					}
					byte[] vx26 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					int num12 = (int)((ushort)((uint)num >> 8));
					byte[] vx27 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 240);
					byte b5 = vx27[(int)((ushort)((uint)num >> 4))];
					byte[] vx28 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					byte b6 = vx28[(int)((ushort)((uint)num >> 8))];
					vx26[num12] = (byte)(b5 - b6);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			case 8:
				{
					byte[] vx29 = Govno8.Vx;
					int num13 = 15;
					byte[] vx30 = Govno8.Vx;
					ushort num = (ushort)(Govno8.Opcode & 3840);
					byte b5 = (byte)(vx30[(int)(ushort)((uint)num >> 8)] & 128);
					vx29[num13] = (byte)((uint)b5 >> 7);
					byte[] vx31 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					int num14 = (int)((ushort)((uint)num >> 8));
					byte[] vx32 = Govno8.Vx;
					num = (ushort)(Govno8.Opcode & 3840);
					b5 = vx32[(int)((ushort)((uint)num >> 8))];
					vx31[num14] = (byte)(b5 << 1);
					num = Govno8.PC;
					Govno8.PC = (ushort)(num + 2);
					return;
				}
			default:
				MessageBox.Show(string.Format("Unhandled opcode 0x{0:X4}", Govno8.Opcode), "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(1);
				return;
		}
	}

	[CompilerGenerated]
	internal static void Smethod_1(Unit unitVar)
	{
		byte[] vx = Govno8.Vx;
		ushort num = (ushort)(Govno8.Opcode & 3840);
		byte b = vx[(int)((ushort)((uint)num >> 8))];
		byte[] vx2 = Govno8.Vx;
		num = (ushort)(Govno8.Opcode & 240);
		byte b2 = vx2[(int)((ushort)((uint)num >> 4))];
		byte b3 = (byte)(Govno8.Opcode & 15);
		Govno8.Vx[15] = 0;
		FSharpList<int> fsharpList = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(0, 1, (int)b3 - 1)));
		for (FSharpList<int> fsharpList2 = fsharpList.TailOrNull; fsharpList2 != null; fsharpList2 = fsharpList.TailOrNull)
		{
			int headOrDefault = fsharpList.HeadOrDefault;
			byte b4 = Govno8.Memory[(int)Govno8.I + headOrDefault];
			byte b5 = 128;
			FSharpList<int> fsharpList3 = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(0, 1, 7)));
			for (FSharpList<int> fsharpList4 = fsharpList3.TailOrNull; fsharpList4 != null; fsharpList4 = fsharpList3.TailOrNull)
			{
				int headOrDefault2 = fsharpList3.HeadOrDefault;
				int num2 = (int)b + headOrDefault2 + ((int)b2 + headOrDefault) * 64;
				if (num2 < Govno8.Screen.Length)
				{
					byte b6 = Govno8.Screen[num2];
					if ((b4 & b5) > 0)
					{
						if (b6 == 1)
						{
							Govno8.Vx[15] = 1;
						}
						Govno8.Screen[(int)b + headOrDefault2 + ((int)b2 + headOrDefault) * 64] = (byte)(b6 ^ 1);
					}
					byte b7 = b5;
					b5 = (byte)((uint)b7 >> 1);
				}
				fsharpList3 = fsharpList4;
			}
			fsharpList = fsharpList2;
		}
		Govno8.Form.Invalidate();
		num = Govno8.PC;
		Govno8.PC = (ushort)(num + 2);
	}

	[CompilerGenerated]
	internal static void Smethod_2(Unit unitVar)
	{
		ushort num = (ushort)(Govno8.Opcode & 255);
		switch (num)
		{
			case 7:
				{
					byte[] vx = Govno8.Vx;
					ushort num2 = (ushort)(Govno8.Opcode & 3840);
					vx[(int)((ushort)((uint)num2 >> 8))] = Govno8.DelayTimer;
					num2 = Govno8.PC;
					Govno8.PC = (ushort)(num2 + 2);
					return;
				}
			default:
				switch (num)
				{
					case 10:
						{
							FSharpList<int> fsharpList = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(0, 1, Govno8.Keys.Length - 1)));
							for (FSharpList<int> fsharpList2 = fsharpList.TailOrNull; fsharpList2 != null; fsharpList2 = fsharpList.TailOrNull)
							{
								int num3 = fsharpList.HeadOrDefault;
								if (Govno8.Keys[num3] == 1)
								{
									byte[] vx2 = Govno8.Vx;
									ushort num2 = (ushort)(Govno8.Opcode & 3840);
									vx2[(int)((ushort)((uint)num2 >> 8))] = Govno8.Keys[num3];
									num2 = Govno8.PC;
									Govno8.PC = (ushort)(num2 + 2);
								}
								fsharpList = fsharpList2;
							}
							return;
						}
					default:
						switch (num)
						{
							case 21:
								{
									byte[] vx3 = Govno8.Vx;
									ushort num2 = (ushort)(Govno8.Opcode & 3840);
									Govno8.DelayTimer = vx3[(int)((ushort)((uint)num2 >> 8))];
									num2 = Govno8.PC;
									Govno8.PC = (ushort)(num2 + 2);
									return;
								}
							default:
								switch (num)
								{
									case 24:
										{
											byte[] vx4 = Govno8.Vx;
											ushort num2 = (ushort)(Govno8.Opcode & 3840);
											Govno8.SoundTimer = vx4[(int)((ushort)((uint)num2 >> 8))];
											num2 = Govno8.PC;
											Govno8.PC = (ushort)(num2 + 2);
											return;
										}
									default:
										switch (num)
										{
											case 30:
												{
													uint num4 = (uint)Govno8.I;
													byte[] vx5 = Govno8.Vx;
													ushort num2 = (ushort)(Govno8.Opcode & 3840);
													uint num5 = num4 + (uint)vx5[(int)((ushort)((uint)num2 >> 8))];
													if (num5 > 65535U)
													{
														Govno8.Vx[15] = 1;
													}
													else
													{
														Govno8.Vx[15] = 0;
													}
													Govno8.I = (ushort)num5;
													num2 = Govno8.PC;
													Govno8.PC = (ushort)(num2 + 2);
													return;
												}
											default:
												switch (num)
												{
													case 41:
														{
															byte[] vx6 = Govno8.Vx;
															ushort num6 = (ushort)(Govno8.Opcode & 3840);
															byte b = vx6[(int)((ushort)((uint)num6 >> 8))];
															ushort num2 = (ushort)(b * 5);
															Govno8.I = (ushort)(0 + num2);
															num2 = Govno8.PC;
															Govno8.PC = (ushort)(num2 + 2);
															return;
														}
													default:
														switch (num)
														{
															case 51:
																{
																	byte[] memory = Govno8.Memory;
																	int num7 = (int)Govno8.I;
																	byte[] vx7 = Govno8.Vx;
																	ushort num2 = (ushort)(Opcode & 3840);
																	byte b = vx7[(int)((ushort)((uint)num2 >> 8))];
																	memory[num7] = (byte)(b / 100);
																	byte[] memory2 = Govno8.Memory;
																	int num8 = (int)Govno8.I + 1;
																	byte[] vx8 = Govno8.Vx;
																	num2 = (ushort)(Govno8.Opcode & 3840);
																	byte b2 = vx8[(int)((ushort)((uint)num2 >> 8))];
																	b = (byte)(b2 / 10);
																	memory2[num8] = (byte)(b % 10);
																	byte[] memory3 = Govno8.Memory;
																	int num9 = (int)Govno8.I + 2;
																	byte[] vx9 = Govno8.Vx;
																	num2 = (ushort)(Govno8.Opcode & 3840);
																	b2 = vx9[(int)((ushort)((uint)num2 >> 8))];
																	b = (byte)(b2 % 100);
																	memory3[num9] = (byte)(b % 10);
																	num2 = Govno8.PC;
																	Govno8.PC = (ushort)(num2 + 2);
																	return;
																}
															default:
																switch (num)
																{
																	case 85:
																		{
																			int num10 = 0;
																			int num11 = 1;
																			ushort num2 = (ushort)(Govno8.Opcode & 3840);
																			FSharpList<int> fsharpList = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(num10, num11, (int)((ushort)((uint)num2 >> 8)))));
																			for (FSharpList<int> fsharpList2 = fsharpList.TailOrNull; fsharpList2 != null; fsharpList2 = fsharpList.TailOrNull)
																			{
																				int num3 = fsharpList.HeadOrDefault;
																				Govno8.Memory[(int)Govno8.I + num3] = Govno8.Vx[num3];
																				fsharpList = fsharpList2;
																			}
																			num2 = Govno8.PC;
																			Govno8.PC = (ushort)(num2 + 2);
																			return;
																		}
																	default:
																		switch (num)
																		{
																			case 101:
																				{
																					int num12 = 0;
																					int num13 = 1;
																					ushort num2 = (ushort)(Opcode & 3840);
																					FSharpList<int> fsharpList = SeqModule.ToList<int>(Operators.CreateSequence<int>(Operators.OperatorIntrinsics.RangeInt32(num12, num13, (int)((ushort)((uint)num2 >> 8)))));
																					for (FSharpList<int> fsharpList2 = fsharpList.TailOrNull; fsharpList2 != null; fsharpList2 = fsharpList.TailOrNull)
																					{
																						int num3 = fsharpList.HeadOrDefault;
																						Govno8.Vx[num3] = Govno8.Memory[(int)Govno8.I + num3];
																						fsharpList = fsharpList2;
																					}
																					num2 = Govno8.PC;
																					Govno8.PC = (ushort)(num2 + 2);
																					return;
																				}
																			default:
																				MessageBox.Show(string.Format("Unhandled opcode 0x{0:X4}", Govno8.Opcode), "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																				Environment.Exit(1);
																				return;
																		}
																}
														}
												}
										}
								}
						}
				}
		}
	}

	[CompilerGenerated]
	internal static FSharpAsync<Unit> Smethod_3(Unit unitVar)
	{
		Govno8.ExecutionClock = DateTime.Now;
		ushort num = (ushort)Govno8.Memory[(int)Govno8.PC];
		Govno8.Opcode = (ushort)((ushort)(num << 8) | Govno8.Memory[(int)Govno8.PC + 1]);
		num = (ushort)(Govno8.Opcode & 61440);
		switch (num)
		{
			case 0:
				{
					ushort num2 = (ushort)(Govno8.Opcode & 255);
					switch (num2)
					{
						case 224:
							{
								ArrayModule.IterateIndexed<byte>(Govno8.Class1.class1_0, Govno8.Screen);
								ushort num3 = Govno8.PC;
								Govno8.PC = (ushort)(num3 + 2);
								break;
							}
						default:
							switch (num2)
							{
								case 238:
									{
										ushort num3 = Govno8.SP;
										Govno8.SP = (ushort)(num3 - 1);
										Govno8.PC = Govno8.Stack[(int)Govno8.SP];
										num3 = Govno8.PC;
										Govno8.PC = (ushort)(num3 + 2);
										break;
									}
								default:
									MessageBox.Show(string.Format("Unhandled opcode 0x{0:X4}", Govno8.Opcode), "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Environment.Exit(1);
									break;
							}
							break;
					}
					break;
				}
			default:
				switch (num)
				{
					case 4096:
						Govno8.PC = (ushort)(Govno8.Opcode & 4095);
						break;
					default:
						switch (num)
						{
							case 8192:
								{
									Govno8.Stack[(int)Govno8.SP] = Govno8.PC;
									ushort num2 = Govno8.SP;
									Govno8.SP = (ushort)(num2 + 1);
									Govno8.PC = (ushort)(Opcode & 4095);
									break;
								}
							default:
								switch (num)
								{
									case 12288:
										{
											byte[] vx = Govno8.Vx;
											ushort num2 = (ushort)(Govno8.Opcode & 3840);
											if (vx[(int)((ushort)((uint)num2 >> 8))] == (byte)(Govno8.Opcode & 255))
											{
												num2 = Govno8.PC;
												Govno8.PC = (ushort)(num2 + 4);
											}
											else
											{
												num2 = Govno8.PC;
												Govno8.PC = (ushort)(num2 + 2);
											}
											break;
										}
									default:
										switch (num)
										{
											case 16384:
												{
													byte[] vx2 = Govno8.Vx;
													ushort num2 = (ushort)(Govno8.Opcode & 3840);
													if (vx2[(int)((ushort)((uint)num2 >> 8))] != (byte)(Govno8.Opcode & 255))
													{
														num2 = Govno8.PC;
														Govno8.PC = (ushort)(num2 + 4);
													}
													else
													{
														num2 = Govno8.PC;
														Govno8.PC = (ushort)(num2 + 2);
													}
													break;
												}
											default:
												switch (num)
												{
													case 20480:
														{
															byte[] vx3 = Govno8.Vx;
															ushort num2 = (ushort)(Govno8.Opcode & 3840);
															byte b = vx3[(int)((ushort)((uint)num2 >> 8))];
															byte[] vx4 = Govno8.Vx;
															num2 = (ushort)(Govno8.Opcode & 240);
															if (b == vx4[(int)((ushort)((uint)num2 >> 4))])
															{
																num2 = Govno8.PC;
																Govno8.PC = (ushort)(num2 + 4);
															}
															else
															{
																num2 = Govno8.PC;
																Govno8.PC = (ushort)(num2 + 2);
															}
															break;
														}
													default:
														switch (num)
														{
															case 24576:
																{
																	byte[] vx5 = Govno8.Vx;
																	ushort num2 = (ushort)(Govno8.Opcode & 3840);
																	vx5[(int)((ushort)((uint)num2 >> 8))] = (byte)(Govno8.Opcode & 255);
																	num2 = Govno8.PC;
																	Govno8.PC = (ushort)(num2 + 2);
																	break;
																}
															default:
																switch (num)
																{
																	case 28672:
																		{
																			byte[] vx6 = Govno8.Vx;
																			ushort num2 = (ushort)(Govno8.Opcode & 3840);
																			int num4 = (int)((ushort)((uint)num2 >> 8));
																			byte[] vx7 = Govno8.Vx;
																			num2 = (ushort)(Govno8.Opcode & 3840);
																			byte b2 = vx7[(int)((ushort)((uint)num2 >> 8))];
																			byte b3 = (byte)(Govno8.Opcode & 255);
																			vx6[num4] = (byte)(b2 + b3);
																			num2 = Govno8.PC;
																			Govno8.PC = (ushort)(num2 + 2);
																			break;
																		}
																	default:
																		switch (num)
																		{
																			case 32768:
																				Govno8.Smethod_0(null);
																				break;
																			default:
																				switch (num)
																				{
																					case 36864:
																						{
																							byte[] vx8 = Govno8.Vx;
																							ushort num2 = (ushort)(Opcode & 3840);
																							byte b4 = vx8[(int)((ushort)((uint)num2 >> 8))];
																							byte[] vx9 = Govno8.Vx;
																							num2 = (ushort)(Govno8.Opcode & 240);
																							if (b4 != vx9[(int)((ushort)((uint)num2 >> 4))])
																							{
																								num2 = Govno8.PC;
																								Govno8.PC = (ushort)(num2 + 4);
																							}
																							else
																							{
																								num2 = Govno8.PC;
																								Govno8.PC = (ushort)(num2 + 2);
																							}
																							break;
																						}
																					default:
																						switch (num)
																						{
																							case 40960:
																								{
																									Govno8.I = (ushort)(Govno8.Opcode & 4095);
																									ushort num2 = Govno8.PC;
																									Govno8.PC = (ushort)(num2 + 2);
																									break;
																								}
																							default:
																								switch (num)
																								{
																									case 45056:
																										{
																											ushort num2 = (ushort)(Govno8.Opcode & 4095);
																											ushort num3 = (ushort)Govno8.Vx[0];
																											Govno8.PC = (ushort)(num2 + num3);
																											break;
																										}
																									default:
																										switch (num)
																										{
																											case 49152:
																												{
																													byte[] vx10 = Govno8.Vx;
																													ushort num2 = (ushort)(Govno8.Opcode & 3840);
																													vx10[(int)((ushort)((uint)num2 >> 8))] = (byte)((byte)Govno8.Random.Next() & (byte)(Govno8.Opcode & 255));
																													num2 = Govno8.PC;
																													Govno8.PC = (ushort)(num2 + 2);
																													break;
																												}
																											default:
																												switch (num)
																												{
																													case 53248:
																														Govno8.Smethod_1(null);
																														break;
																													default:
																														switch (num)
																														{
																															case 57344:
																																{
																																	ushort num2 = (ushort)(Govno8.Opcode & 255);
																																	switch (num2)
																																	{
																																		case 158:
																																			{
																																				byte[] keys = Govno8.Keys;
																																				byte[] vx11 = Govno8.Vx;
																																				ushort num3 = (ushort)(Govno8.Opcode & 3840);
																																				if (keys[(int)vx11[(int)((ushort)((uint)num3 >> 8))]] != 0)
																																				{
																																					num3 = Govno8.PC;
																																					Govno8.PC = (ushort)(num3 + 4);
																																				}
																																				else
																																				{
																																					num3 = Govno8.PC;
																																					Govno8.PC = (ushort)(num3 + 2);
																																				}
																																				break;
																																			}
																																		default:
																																			switch (num2)
																																			{
																																				case 161:
																																					{
																																						byte[] keys2 = Govno8.Keys;
																																						byte[] vx12 = Govno8.Vx;
																																						ushort num3 = (ushort)(Govno8.Opcode & 3840);
																																						if (keys2[(int)vx12[(int)((ushort)((uint)num3 >> 8))]] == 0)
																																						{
																																							num3 = Govno8.PC;
																																							Govno8.PC = (ushort)(num3 + 4);
																																						}
																																						else
																																						{
																																							num3 = Govno8.PC;
																																							Govno8.PC = (ushort)(num3 + 2);
																																						}
																																						break;
																																					}
																																				default:
																																					MessageBox.Show(string.Format("Unhandled opcode 0x{0:X4}", Govno8.Opcode), "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																																					Environment.Exit(1);
																																					break;
																																			}
																																			break;
																																	}
																																	break;
																																}
																															default:
																																switch (num)
																																{
																																	case 61440:
																																		Govno8.Smethod_2(null);
																																		break;
																																	default:
																																		MessageBox.Show(string.Format("Unhandled opcode 0x{0:X4}", Govno8.Opcode), "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
																																		Environment.Exit(1);
																																		break;
																																}
																																break;
																														}
																														break;
																												}
																												break;
																										}
																										break;
																								}
																								break;
																						}
																						break;
																				}
																				break;
																		}
																		break;
																}
																break;
														}
														break;
												}
												break;
										}
										break;
								}
								break;
						}
						break;
				}
				break;
		}
		return ExtraTopLevelOperators.DefaultAsyncBuilder.Zero();
	}

	static Govno8()
	{
		Govno8_Main.int_0 = 0;
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static PID.Struct0 struct0_0;

	[CompilationMapping(SourceConstructFlags.ObjectType)]
	[Serializable]
	public class DoubleBufferForm : Form
	{
		public DoubleBufferForm()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}
	}

	[Serializable]
	internal sealed class Class0 : FSharpFunc<Unit, bool>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class0()
		{
		}

		public override bool Invoke(Unit unitVar)
		{
			return true;
		}

		internal static readonly Govno8.Class0 class0_0 = new();
	}

	[Serializable]
	internal sealed class Class1 : OptimizedClosures.FSharpFunc<int, byte, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class1()
		{
		}

		public override Unit Invoke(int i, byte e)
		{
			Govno8.Screen[i] = 0;
			return null;
		}

		internal static readonly Govno8.Class1 class1_0 = new();
	}

	[Serializable]
	internal sealed class Class2 : FSharpFunc<Unit, FSharpAsync<Unit>>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class2()
		{
		}

		public override FSharpAsync<Unit> Invoke(Unit unitVar)
		{
			if ((DateTime.Now - Govno8.ExecutionClock).Milliseconds >= 1)
			{
				return Govno8.Smethod_3(null);
			}
			return ExtraTopLevelOperators.DefaultAsyncBuilder.Zero();
		}

		internal static readonly Govno8.Class2 class2_0 = new();
	}

	[Serializable]
	internal sealed class Class3 : FSharpFunc<Unit, FSharpAsync<Unit>>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class3(FSharpAsync<Unit> computation2)
		{
			this.computation2 = computation2;
		}

		public override FSharpAsync<Unit> Invoke(Unit unitVar0)
		{
			return this.computation2;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public FSharpAsync<Unit> computation2;
	}

	[Serializable]
	internal sealed class Class4 : FSharpFunc<AsyncActivation<Unit>, AsyncReturn>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class4(FSharpAsync<Unit> computation1, FSharpFunc<Unit, FSharpAsync<Unit>> part2)
		{
			this.computation1 = computation1;
			this.part2 = part2;
		}

		public override AsyncReturn Invoke(AsyncActivation<Unit> ctxt)
		{
			return AsyncPrimitives.Bind<Unit, Unit>(ctxt, this.computation1, this.part2);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		public FSharpAsync<Unit> computation1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		public FSharpFunc<Unit, FSharpAsync<Unit>> part2;
	}

	[Serializable]
	internal sealed class Class5 : FSharpFunc<Unit, FSharpAsync<Unit>>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class5()
		{
		}

		public override FSharpAsync<Unit> Invoke(Unit unitVar)
		{
			FSharpAsync<Unit> fsharpAsync;
			if ((DateTime.Now - Govno8.DelayAndSoundTimersClock).Milliseconds >= 16)
			{
				Govno8.DelayAndSoundTimersClock = DateTime.Now;
				if (Govno8.SoundTimer > 0)
				{
					if (Govno8.SoundTimer == 1)
					{
						Console.Beep();
					}
					byte b = Govno8.SoundTimer;
					Govno8.SoundTimer = (byte)(b - 1);
				}
				if (Govno8.DelayTimer > 0)
				{
					byte b = Govno8.DelayTimer;
					Govno8.DelayTimer = (byte)(b - 1);
				}
				fsharpAsync = ExtraTopLevelOperators.DefaultAsyncBuilder.Zero();
			}
			else
			{
				fsharpAsync = ExtraTopLevelOperators.DefaultAsyncBuilder.Zero();
			}
			FSharpAsync<Unit> fsharpAsync2 = fsharpAsync;
			FSharpAsync<Unit> fsharpAsync3 = ExtraTopLevelOperators.DefaultAsyncBuilder.Delay<Unit>(Govno8.Class2.class2_0);
			FSharpFunc<Unit, FSharpAsync<Unit>> fsharpFunc = new Govno8.Class3(fsharpAsync3);
			return AsyncPrimitives.MakeAsync<Unit>(new Govno8.Class4(fsharpAsync2, fsharpFunc));
		}

		internal static readonly Govno8.Class5 class5_0 = new();
	}

	[Serializable]
	internal sealed class Class6 : FSharpFunc<Unit, FSharpAsync<Unit>>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class6()
		{
		}

		public override FSharpAsync<Unit> Invoke(Unit unitVar)
		{
			return ExtraTopLevelOperators.DefaultAsyncBuilder.While(Govno8.Class0.class0_0, ExtraTopLevelOperators.DefaultAsyncBuilder.Delay<Unit>(Govno8.Class5.class5_0));
		}

		internal static readonly Govno8.Class6 class6_0 = new();
	}

	[Serializable]
	internal sealed class Class7 : FSharpFunc<EventHandler, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class7()
		{
		}

		public override Unit Invoke(EventHandler eventDelegate)
		{
			Govno8.Form.Load += eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class7 class7_0 = new();
	}

	[Serializable]
	internal sealed class Class8 : FSharpFunc<EventHandler, Unit>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class8()
		{
		}

		public override Unit Invoke(EventHandler eventDelegate)
		{
			Govno8.Form.Load -= eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class8 class8_0 = new();
	}

	[CompilationMapping(SourceConstructFlags.Closure)]
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	internal sealed class Class9
	{
		public Class9(FSharpFunc<object, FSharpFunc<EventArgs, Unit>> callback)
		{
			this.callback = callback;
		}

		internal void Invoke(object sender, EventArgs e)
		{
			FSharpFunc<object, EventArgs>.InvokeFast<Unit>(this.callback, sender, e);
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public FSharpFunc<object, FSharpFunc<EventArgs, Unit>> callback;
	}

	[Serializable]
	internal sealed class Class10 : FSharpFunc<FSharpFunc<object, FSharpFunc<EventArgs, Unit>>, EventHandler>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class10()
		{
		}

		public override EventHandler Invoke(FSharpFunc<object, FSharpFunc<EventArgs, Unit>> callback)
		{
			return new EventHandler(new Govno8.Class9(callback).Invoke);
		}

		internal static readonly Govno8.Class10 class10_0 = new();
	}

	[Serializable]
	internal sealed class Class11 : FSharpFunc<EventArgs, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class11()
		{
		}

		public override Unit Invoke(EventArgs e)
		{
			Govno8.Form.BackColor = Color.Black;
			FSharpAsync.Start(Govno8.Loop, null);
			return null;
		}

		internal static readonly Govno8.Class11 class11_0 = new();
	}

	[Serializable]
	internal sealed class Class12 : FSharpFunc<PaintEventHandler, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class12()
		{
		}

		public override Unit Invoke(PaintEventHandler eventDelegate)
		{
			Govno8.Form.Paint += eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class12 class12_0 = new();
	}

	[Serializable]
	internal sealed class Class13 : FSharpFunc<PaintEventHandler, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class13()
		{
		}

		public override Unit Invoke(PaintEventHandler eventDelegate)
		{
			Govno8.Form.Paint -= eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class13 class13_0 = new();
	}

	[CompilationMapping(SourceConstructFlags.Closure)]
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	internal sealed class Class14
	{
		public Class14(FSharpFunc<object, FSharpFunc<PaintEventArgs, Unit>> callback)
		{
			this.callback = callback;
		}

		internal void Invoke(object sender, PaintEventArgs e)
		{
			FSharpFunc<object, PaintEventArgs>.InvokeFast<Unit>(this.callback, sender, e);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		public FSharpFunc<object, FSharpFunc<PaintEventArgs, Unit>> callback;
	}

	[Serializable]
	internal sealed class Class15 : FSharpFunc<FSharpFunc<object, FSharpFunc<PaintEventArgs, Unit>>, PaintEventHandler>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class15()
		{
		}

		public override PaintEventHandler Invoke(FSharpFunc<object, FSharpFunc<PaintEventArgs, Unit>> callback)
		{
			return new PaintEventHandler(new Govno8.Class14(callback).Invoke);
		}

		internal static readonly Govno8.Class15 class15_0 = new();
	}

	[Serializable]
	internal sealed class Class16 : FSharpFunc<PaintEventArgs, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class16()
		{
		}

		public override Unit Invoke(PaintEventArgs args)
		{
			Govno8.Draw(args);
			return null;
		}

		internal static readonly Govno8.Class16 class16_0 = new();
	}

	[Serializable]
	internal sealed class Class17 : FSharpFunc<KeyEventHandler, Unit>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class17()
		{
		}

		public override Unit Invoke(KeyEventHandler eventDelegate)
		{
			Govno8.Form.KeyDown += eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class17 class17_0 = new();
	}

	[Serializable]
	internal sealed class Class18 : FSharpFunc<KeyEventHandler, Unit>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class18()
		{
		}

		public override Unit Invoke(KeyEventHandler eventDelegate)
		{
			Govno8.Form.KeyDown -= eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class18 class18_0 = new();
	}

	[CompilationMapping(SourceConstructFlags.Closure)]
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	internal sealed class Class19
	{
		public Class19(FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback)
		{
			this.callback = callback;
		}

		internal void Invoke(object sender, KeyEventArgs e)
		{
			FSharpFunc<object, KeyEventArgs>.InvokeFast<Unit>(this.callback, sender, e);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		public FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback;
	}

	[Serializable]
	internal sealed class Class20 : FSharpFunc<FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>>, KeyEventHandler>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class20()
		{
		}

		public override KeyEventHandler Invoke(FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback)
		{
			return new KeyEventHandler(new Govno8.Class19(callback).Invoke);
		}

		internal static readonly Govno8.Class20 class20_0 = new();
	}

	[Serializable]
	internal sealed class Class21 : FSharpFunc<KeyEventArgs, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class21()
		{
		}

		public override Unit Invoke(KeyEventArgs args)
		{
			Govno8.OnKeyPress(args);
			return null;
		}

		internal static readonly Govno8.Class21 class21_0 = new();
	}

	[Serializable]
	internal sealed class Class22 : FSharpFunc<KeyEventHandler, Unit>
	{
		[DebuggerNonUserCode]
		[CompilerGenerated]
		internal Class22()
		{
		}

		public override Unit Invoke(KeyEventHandler eventDelegate)
		{
			Govno8.Form.KeyUp += eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class22 class22_0 = new();
	}

	[Serializable]
	internal sealed class Class23 : FSharpFunc<KeyEventHandler, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class23()
		{
		}

		public override Unit Invoke(KeyEventHandler eventDelegate)
		{
			Govno8.Form.KeyUp -= eventDelegate;
			return null;
		}

		internal static readonly Govno8.Class23 class23_0 = new();
	}

	[CompilationMapping(SourceConstructFlags.Closure)]
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	internal sealed class Class24
	{
		public Class24(FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback)
		{
			this.callback = callback;
		}

		internal void Invoke(object sender, KeyEventArgs e)
		{
			FSharpFunc<object, KeyEventArgs>.InvokeFast<Unit>(this.callback, sender, e);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		public FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback;
	}

	[Serializable]
	internal sealed class Class25 : FSharpFunc<FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>>, KeyEventHandler>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class25()
		{
		}

		public override KeyEventHandler Invoke(FSharpFunc<object, FSharpFunc<KeyEventArgs, Unit>> callback)
		{
			return new KeyEventHandler(new Govno8.Class24(callback).Invoke);
		}

		internal static readonly Govno8.Class25 class25_0 = new();
	}

	[Serializable]
	internal sealed class Class26 : FSharpFunc<KeyEventArgs, Unit>
	{
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Class26()
		{
		}

		public override Unit Invoke(KeyEventArgs args)
		{
			Govno8.OnKeyUp(args);
			return null;
		}

		internal static readonly Govno8.Class26 class26_0 = new();
	}
}