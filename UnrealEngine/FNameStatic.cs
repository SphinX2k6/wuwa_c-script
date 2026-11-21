using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace UnrealEngine
{
	// Token: 0x02000888 RID: 2184
	public class FNameStatic
	{
		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x0012E262 File Offset: 0x0012C462
		public static FName OnActorBeginOverlap
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_0, 0, 19);
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600BD5D RID: 48477 RVA: 0x0012E271 File Offset: 0x0012C471
		public static FName OnActorEndOverlap
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_1, 19, 17);
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600BD5E RID: 48478 RVA: 0x0012E281 File Offset: 0x0012C481
		public static FName OnActorHit
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_2, 36, 10);
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x0600BD5F RID: 48479 RVA: 0x0012E291 File Offset: 0x0012C491
		public static FName OnBeginCursorOver
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_3, 46, 17);
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x0012E2A1 File Offset: 0x0012C4A1
		public static FName OnClicked
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_4, 63, 9);
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600BD61 RID: 48481 RVA: 0x0012E2B1 File Offset: 0x0012C4B1
		public static FName OnComponentActivated
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_5, 72, 20);
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x0012E2C1 File Offset: 0x0012C4C1
		public static FName OnComponentBeginOverlap
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_6, 92, 23);
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600BD63 RID: 48483 RVA: 0x0012E2D1 File Offset: 0x0012C4D1
		public static FName OnComponentBeginOverlapBlock
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_7, 115, 28);
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x0012E2E1 File Offset: 0x0012C4E1
		public static FName OnComponentBeginOverlapNoGcAlloc
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_8, 143, 32);
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0600BD65 RID: 48485 RVA: 0x0012E2F4 File Offset: 0x0012C4F4
		public static FName OnComponentDeactivated
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_9, 175, 22);
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x0012E307 File Offset: 0x0012C507
		public static FName OnComponentEndOverlap
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_10, 197, 21);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600BD67 RID: 48487 RVA: 0x0012E31A File Offset: 0x0012C51A
		public static FName OnComponentHit
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_11, 218, 14);
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x0012E32D File Offset: 0x0012C52D
		public static FName OnComponentSleep
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_12, 232, 16);
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600BD69 RID: 48489 RVA: 0x0012E340 File Offset: 0x0012C540
		public static FName OnComponentWake
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_13, 248, 15);
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x0012E353 File Offset: 0x0012C553
		public static FName OnConveyBase
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_14, 263, 12);
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x0012E366 File Offset: 0x0012C566
		public static FName OnDestroyed
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_15, 275, 11);
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x0012E379 File Offset: 0x0012C579
		public static FName OnEndCursorOver
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_16, 286, 15);
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600BD6D RID: 48493 RVA: 0x0012E38C File Offset: 0x0012C58C
		public static FName OnEndPlay
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_17, 301, 9);
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x0012E39F File Offset: 0x0012C59F
		public static FName OnInputTouchBegin
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_18, 310, 17);
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x0012E3B2 File Offset: 0x0012C5B2
		public static FName OnInputTouchEnd
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_19, 327, 15);
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x0012E3C5 File Offset: 0x0012C5C5
		public static FName OnInputTouchEnter
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_20, 342, 17);
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0600BD71 RID: 48497 RVA: 0x0012E3D8 File Offset: 0x0012C5D8
		public static FName OnInputTouchLeave
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_21, 359, 17);
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x0012E3EB File Offset: 0x0012C5EB
		public static FName OnPreDestroyed
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_22, 376, 14);
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600BD73 RID: 48499 RVA: 0x0012E3FE File Offset: 0x0012C5FE
		public static FName OnReleased
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_23, 390, 10);
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600BD74 RID: 48500 RVA: 0x0012E411 File Offset: 0x0012C611
		public static FName SparseMulti1
		{
			get
			{
				return FNameStatic.GetLazyAnsi(ref FNameStatic.__Index_24, 400, 12);
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x0600BD75 RID: 48501 RVA: 0x0012E424 File Offset: 0x0012C624
		private unsafe static ReadOnlySpan<byte> NameInitUtf16
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.6E340B9CFFB37A989CA544E6BB780A2C78901D3FB33738768511A30617AFA01D), 0);
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x0012E431 File Offset: 0x0012C631
		private unsafe static ReadOnlySpan<byte> NameLazyUtf16
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.6E340B9CFFB37A989CA544E6BB780A2C78901D3FB33738768511A30617AFA01D), 0);
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600BD77 RID: 48503 RVA: 0x0012E43E File Offset: 0x0012C63E
		private unsafe static ReadOnlySpan<byte> NameInitAnsi
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.6E340B9CFFB37A989CA544E6BB780A2C78901D3FB33738768511A30617AFA01D), 0);
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600BD78 RID: 48504 RVA: 0x0012E44B File Offset: 0x0012C64B
		private unsafe static ReadOnlySpan<byte> NameLazyAnsi
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.C821B4362BFDA56DEDB7B385DCD991F62348D182C2AC0B1C4BD03FA2B7167D25), 412);
			}
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x0012E45C File Offset: 0x0012C65C
		unsafe static FNameStatic()
		{
			int num = 1;
			List<FName> list = new List<FName>(num);
			CollectionsMarshal.SetCount<FName>(list, num);
			Span<FName> span = CollectionsMarshal.AsSpan<FName>(list);
			int index = 0;
			*span[index] = FName.NAME_None;
			FNameStatic.LazyNames = list;
			ReadOnlySpan<byte> nameInitUtf = FNameStatic.NameInitUtf16;
			ReadOnlySpan<byte> nameInitAnsi = FNameStatic.NameInitAnsi;
			new Span<char>(stackalloc byte[(UIntPtr)2048], 1024);
		}

		// Token: 0x0600BD7A RID: 48506 RVA: 0x0012E4B8 File Offset: 0x0012C6B8
		private static FName GetLazyAnsi(ref ushort index, int offset, ushort length)
		{
			if (index != 0)
			{
				return FNameStatic.LazyNames[(int)index];
			}
			FName fname = new FName(FNameStatic.NameLazyAnsi.Slice(offset, (int)length));
			FNameStatic.LazyNames.Add(fname);
			index = (ushort)(FNameStatic.LazyNames.Count - 1);
			return fname;
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x0012E508 File Offset: 0x0012C708
		private unsafe static FName GetLazyUtf16(ref ushort index, int offset, ushort length)
		{
			if (index != 0)
			{
				return FNameStatic.LazyNames[(int)index];
			}
			Span<char> buffer = new Span<char>(stackalloc byte[(UIntPtr)2048], 1024);
			FName fname = new FName(FNameStatic.ToUtf16(FNameStatic.NameLazyUtf16.Slice(offset, (int)length), buffer));
			FNameStatic.LazyNames.Add(fname);
			index = (ushort)(FNameStatic.LazyNames.Count - 1);
			return fname;
		}

		// Token: 0x0600BD7C RID: 48508 RVA: 0x0012E570 File Offset: 0x0012C770
		private static ReadOnlySpan<char> ToUtf16(ReadOnlySpan<byte> utf8, Span<char> buffer)
		{
			int chars = Encoding.UTF8.GetChars(utf8, buffer);
			return buffer.Slice(0, chars);
		}

		// Token: 0x0400567C RID: 22140
		private static ushort __Index_0;

		// Token: 0x0400567D RID: 22141
		private static ushort __Index_1;

		// Token: 0x0400567E RID: 22142
		private static ushort __Index_2;

		// Token: 0x0400567F RID: 22143
		private static ushort __Index_3;

		// Token: 0x04005680 RID: 22144
		private static ushort __Index_4;

		// Token: 0x04005681 RID: 22145
		private static ushort __Index_5;

		// Token: 0x04005682 RID: 22146
		private static ushort __Index_6;

		// Token: 0x04005683 RID: 22147
		private static ushort __Index_7;

		// Token: 0x04005684 RID: 22148
		private static ushort __Index_8;

		// Token: 0x04005685 RID: 22149
		private static ushort __Index_9;

		// Token: 0x04005686 RID: 22150
		private static ushort __Index_10;

		// Token: 0x04005687 RID: 22151
		private static ushort __Index_11;

		// Token: 0x04005688 RID: 22152
		private static ushort __Index_12;

		// Token: 0x04005689 RID: 22153
		private static ushort __Index_13;

		// Token: 0x0400568A RID: 22154
		private static ushort __Index_14;

		// Token: 0x0400568B RID: 22155
		private static ushort __Index_15;

		// Token: 0x0400568C RID: 22156
		private static ushort __Index_16;

		// Token: 0x0400568D RID: 22157
		private static ushort __Index_17;

		// Token: 0x0400568E RID: 22158
		private static ushort __Index_18;

		// Token: 0x0400568F RID: 22159
		private static ushort __Index_19;

		// Token: 0x04005690 RID: 22160
		private static ushort __Index_20;

		// Token: 0x04005691 RID: 22161
		private static ushort __Index_21;

		// Token: 0x04005692 RID: 22162
		private static ushort __Index_22;

		// Token: 0x04005693 RID: 22163
		private static ushort __Index_23;

		// Token: 0x04005694 RID: 22164
		private static ushort __Index_24;

		// Token: 0x04005695 RID: 22165
		private static List<FName> LazyNames;
	}
}
