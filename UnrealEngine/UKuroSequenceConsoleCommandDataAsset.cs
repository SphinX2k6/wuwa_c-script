using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200063F RID: 1599
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroSequenceConsoleCommandDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C9D RID: 35997 RVA: 0x000D3A51 File Offset: 0x000D1C51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceConsoleCommandDataAsset._ClassPtr;
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x000D3A60 File Offset: 0x000D1C60
		public UKuroSequenceConsoleCommandDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceConsoleCommandDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x000D3A88 File Offset: 0x000D1C88
		public UKuroSequenceConsoleCommandDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceConsoleCommandDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x000D3ABC File Offset: 0x000D1CBC
		// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x000D3AF5 File Offset: 0x000D1CF5
		public TArray<string> ConsoleCommands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ConsoleCommands) == null)
				{
					result = (this._ConsoleCommands = new TArray<string>(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_ConsoleCommands, this));
				}
				return result;
			}
			set
			{
				this.ConsoleCommands.CopyAssign(value);
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x000D3B04 File Offset: 0x000D1D04
		// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x000D3B3D File Offset: 0x000D1D3D
		public TArray<string> GlobalConsoleCommands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._GlobalConsoleCommands) == null)
				{
					result = (this._GlobalConsoleCommands = new TArray<string>(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_GlobalConsoleCommands, this));
				}
				return result;
			}
			set
			{
				this.GlobalConsoleCommands.CopyAssign(value);
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x000D3B4C File Offset: 0x000D1D4C
		// (set) Token: 0x06008CA5 RID: 36005 RVA: 0x000D3B85 File Offset: 0x000D1D85
		public TArray<string> MobileConsoleCommands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MobileConsoleCommands) == null)
				{
					result = (this._MobileConsoleCommands = new TArray<string>(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_MobileConsoleCommands, this));
				}
				return result;
			}
			set
			{
				this.MobileConsoleCommands.CopyAssign(value);
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x000D3B94 File Offset: 0x000D1D94
		// (set) Token: 0x06008CA7 RID: 36007 RVA: 0x000D3BCD File Offset: 0x000D1DCD
		public TArray<string> GlobalMobileConsoleCommands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._GlobalMobileConsoleCommands) == null)
				{
					result = (this._GlobalMobileConsoleCommands = new TArray<string>(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_GlobalMobileConsoleCommands, this));
				}
				return result;
			}
			set
			{
				this.GlobalMobileConsoleCommands.CopyAssign(value);
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x000D3BDB File Offset: 0x000D1DDB
		// (set) Token: 0x06008CA9 RID: 36009 RVA: 0x000D3BEB File Offset: 0x000D1DEB
		public unsafe bool bMobileLowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_bMobileLowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_bMobileLowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x000D3BFC File Offset: 0x000D1DFC
		// (set) Token: 0x06008CAB RID: 36011 RVA: 0x000D3C0C File Offset: 0x000D1E0C
		public unsafe float MobileLowStreamingScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_MobileLowStreamingScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequenceConsoleCommandDataAsset.__PropertyOffset_MobileLowStreamingScale) = value;
			}
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x000D3C1D File Offset: 0x000D1E1D
		static UKuroSequenceConsoleCommandDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset");
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x000D3C2B File Offset: 0x000D1E2B
		protected UKuroSequenceConsoleCommandDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D42 RID: 15682
		public new const string __ObjectPath = "/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset";

		// Token: 0x04003D43 RID: 15683
		private static IntPtr _ClassPtr;

		// Token: 0x04003D44 RID: 15684
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D45 RID: 15685
		internal static int __PropertyOffset_ConsoleCommands;

		// Token: 0x04003D46 RID: 15686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ConsoleCommands;

		// Token: 0x04003D47 RID: 15687
		internal static int __PropertyOffset_GlobalConsoleCommands;

		// Token: 0x04003D48 RID: 15688
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _GlobalConsoleCommands;

		// Token: 0x04003D49 RID: 15689
		internal static int __PropertyOffset_MobileConsoleCommands;

		// Token: 0x04003D4A RID: 15690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MobileConsoleCommands;

		// Token: 0x04003D4B RID: 15691
		internal static int __PropertyOffset_GlobalMobileConsoleCommands;

		// Token: 0x04003D4C RID: 15692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _GlobalMobileConsoleCommands;

		// Token: 0x04003D4D RID: 15693
		internal static int __PropertyOffset_bMobileLowStreaming;

		// Token: 0x04003D4E RID: 15694
		internal static int __PropertyOffset_MobileLowStreamingScale;
	}
}
