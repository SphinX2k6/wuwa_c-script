using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FAD RID: 8109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroSequenceConsoleCommandDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC3C RID: 126012 RVA: 0x002DBBAD File Offset: 0x002D9DAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceConsoleCommandDataAsset._ClassPtr;
		}

		// Token: 0x0601EC3D RID: 126013 RVA: 0x002DBBBC File Offset: 0x002D9DBC
		public UKuroSequenceConsoleCommandDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceConsoleCommandDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC3E RID: 126014 RVA: 0x002DBBE4 File Offset: 0x002D9DE4
		public UKuroSequenceConsoleCommandDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceConsoleCommandDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A8C RID: 31372
		// (get) Token: 0x0601EC3F RID: 126015 RVA: 0x002DBC18 File Offset: 0x002D9E18
		// (set) Token: 0x0601EC40 RID: 126016 RVA: 0x002DBC51 File Offset: 0x002D9E51
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

		// Token: 0x17007A8D RID: 31373
		// (get) Token: 0x0601EC41 RID: 126017 RVA: 0x002DBC60 File Offset: 0x002D9E60
		// (set) Token: 0x0601EC42 RID: 126018 RVA: 0x002DBC99 File Offset: 0x002D9E99
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

		// Token: 0x17007A8E RID: 31374
		// (get) Token: 0x0601EC43 RID: 126019 RVA: 0x002DBCA8 File Offset: 0x002D9EA8
		// (set) Token: 0x0601EC44 RID: 126020 RVA: 0x002DBCE1 File Offset: 0x002D9EE1
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

		// Token: 0x17007A8F RID: 31375
		// (get) Token: 0x0601EC45 RID: 126021 RVA: 0x002DBCF0 File Offset: 0x002D9EF0
		// (set) Token: 0x0601EC46 RID: 126022 RVA: 0x002DBD29 File Offset: 0x002D9F29
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

		// Token: 0x17007A90 RID: 31376
		// (get) Token: 0x0601EC47 RID: 126023 RVA: 0x002DBD37 File Offset: 0x002D9F37
		// (set) Token: 0x0601EC48 RID: 126024 RVA: 0x002DBD47 File Offset: 0x002D9F47
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

		// Token: 0x17007A91 RID: 31377
		// (get) Token: 0x0601EC49 RID: 126025 RVA: 0x002DBD58 File Offset: 0x002D9F58
		// (set) Token: 0x0601EC4A RID: 126026 RVA: 0x002DBD68 File Offset: 0x002D9F68
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

		// Token: 0x0601EC4B RID: 126027 RVA: 0x002DBD79 File Offset: 0x002D9F79
		static UKuroSequenceConsoleCommandDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset");
		}

		// Token: 0x0601EC4C RID: 126028 RVA: 0x002DBD87 File Offset: 0x002D9F87
		protected UKuroSequenceConsoleCommandDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A21 RID: 68129
		public new const string __ObjectPath = "/Script/LevelSequence.KuroSequenceConsoleCommandDataAsset";

		// Token: 0x04010A22 RID: 68130
		private static IntPtr _ClassPtr;

		// Token: 0x04010A23 RID: 68131
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A24 RID: 68132
		internal static int __PropertyOffset_ConsoleCommands;

		// Token: 0x04010A25 RID: 68133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ConsoleCommands;

		// Token: 0x04010A26 RID: 68134
		internal static int __PropertyOffset_GlobalConsoleCommands;

		// Token: 0x04010A27 RID: 68135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _GlobalConsoleCommands;

		// Token: 0x04010A28 RID: 68136
		internal static int __PropertyOffset_MobileConsoleCommands;

		// Token: 0x04010A29 RID: 68137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MobileConsoleCommands;

		// Token: 0x04010A2A RID: 68138
		internal static int __PropertyOffset_GlobalMobileConsoleCommands;

		// Token: 0x04010A2B RID: 68139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _GlobalMobileConsoleCommands;

		// Token: 0x04010A2C RID: 68140
		internal static int __PropertyOffset_bMobileLowStreaming;

		// Token: 0x04010A2D RID: 68141
		internal static int __PropertyOffset_MobileLowStreamingScale;
	}
}
