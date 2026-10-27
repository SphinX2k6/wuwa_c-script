using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000795 RID: 1941
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.ConsoleSettings")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UConsoleSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006516 RID: 25878 RVA: 0x00090EDD File Offset: 0x0008F0DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConsoleSettings._ClassPtr;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x00090EEC File Offset: 0x0008F0EC
		public UConsoleSettings() : this(BuiltinUtils.AllocNativeUObject(UConsoleSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00090F14 File Offset: 0x0008F114
		public UConsoleSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConsoleSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x00090F47 File Offset: 0x0008F147
		// (set) Token: 0x0600651A RID: 25882 RVA: 0x00090F57 File Offset: 0x0008F157
		public unsafe int MaxScrollbackSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_MaxScrollbackSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_MaxScrollbackSize) = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x00090F68 File Offset: 0x0008F168
		// (set) Token: 0x0600651C RID: 25884 RVA: 0x00090FA1 File Offset: 0x0008F1A1
		public TArray<FAutoCompleteCommand> ManualAutoCompleteList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAutoCompleteCommand> result;
				if ((result = this._ManualAutoCompleteList) == null)
				{
					result = (this._ManualAutoCompleteList = new TArray<FAutoCompleteCommand>(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_ManualAutoCompleteList, this));
				}
				return result;
			}
			set
			{
				this.ManualAutoCompleteList.CopyAssign(value);
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x00090FB0 File Offset: 0x0008F1B0
		// (set) Token: 0x0600651E RID: 25886 RVA: 0x00090FE9 File Offset: 0x0008F1E9
		public TArray<string> AutoCompleteMapPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AutoCompleteMapPaths) == null)
				{
					result = (this._AutoCompleteMapPaths = new TArray<string>(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteMapPaths, this));
				}
				return result;
			}
			set
			{
				this.AutoCompleteMapPaths.CopyAssign(value);
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x00090FF7 File Offset: 0x0008F1F7
		// (set) Token: 0x06006520 RID: 25888 RVA: 0x00091007 File Offset: 0x0008F207
		public unsafe float BackgroundOpacityPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_BackgroundOpacityPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_BackgroundOpacityPercentage) = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06006521 RID: 25889 RVA: 0x00091018 File Offset: 0x0008F218
		// (set) Token: 0x06006522 RID: 25890 RVA: 0x00091028 File Offset: 0x0008F228
		public unsafe bool bOrderTopToBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_bOrderTopToBottom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_bOrderTopToBottom) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06006523 RID: 25891 RVA: 0x00091039 File Offset: 0x0008F239
		// (set) Token: 0x06006524 RID: 25892 RVA: 0x00091049 File Offset: 0x0008F249
		public unsafe bool bDisplayHelpInAutoComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_bDisplayHelpInAutoComplete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_bDisplayHelpInAutoComplete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06006525 RID: 25893 RVA: 0x0009105A File Offset: 0x0008F25A
		// (set) Token: 0x06006526 RID: 25894 RVA: 0x0009106E File Offset: 0x0008F26E
		public unsafe FColor InputColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_InputColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_InputColor) = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x00091083 File Offset: 0x0008F283
		// (set) Token: 0x06006528 RID: 25896 RVA: 0x00091097 File Offset: 0x0008F297
		public unsafe FColor HistoryColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_HistoryColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_HistoryColor) = value;
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06006529 RID: 25897 RVA: 0x000910AC File Offset: 0x0008F2AC
		// (set) Token: 0x0600652A RID: 25898 RVA: 0x000910C0 File Offset: 0x0008F2C0
		public unsafe FColor AutoCompleteCommandColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteCommandColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteCommandColor) = value;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600652B RID: 25899 RVA: 0x000910D5 File Offset: 0x0008F2D5
		// (set) Token: 0x0600652C RID: 25900 RVA: 0x000910E9 File Offset: 0x0008F2E9
		public unsafe FColor AutoCompleteCVarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteCVarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteCVarColor) = value;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x000910FE File Offset: 0x0008F2FE
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x00091112 File Offset: 0x0008F312
		public unsafe FColor AutoCompleteFadedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteFadedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConsoleSettings.__PropertyOffset_AutoCompleteFadedColor) = value;
			}
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00091127 File Offset: 0x0008F327
		static UConsoleSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.ConsoleSettings");
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00091135 File Offset: 0x0008F335
		protected UConsoleSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030F5 RID: 12533
		public new const string __ObjectPath = "/Script/EngineSettings.ConsoleSettings";

		// Token: 0x040030F6 RID: 12534
		private static IntPtr _ClassPtr;

		// Token: 0x040030F7 RID: 12535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030F8 RID: 12536
		internal static int __PropertyOffset_MaxScrollbackSize;

		// Token: 0x040030F9 RID: 12537
		internal static int __PropertyOffset_ManualAutoCompleteList;

		// Token: 0x040030FA RID: 12538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAutoCompleteCommand> _ManualAutoCompleteList;

		// Token: 0x040030FB RID: 12539
		internal static int __PropertyOffset_AutoCompleteMapPaths;

		// Token: 0x040030FC RID: 12540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AutoCompleteMapPaths;

		// Token: 0x040030FD RID: 12541
		internal static int __PropertyOffset_BackgroundOpacityPercentage;

		// Token: 0x040030FE RID: 12542
		internal static int __PropertyOffset_bOrderTopToBottom;

		// Token: 0x040030FF RID: 12543
		internal static int __PropertyOffset_bDisplayHelpInAutoComplete;

		// Token: 0x04003100 RID: 12544
		internal static int __PropertyOffset_InputColor;

		// Token: 0x04003101 RID: 12545
		internal static int __PropertyOffset_HistoryColor;

		// Token: 0x04003102 RID: 12546
		internal static int __PropertyOffset_AutoCompleteCommandColor;

		// Token: 0x04003103 RID: 12547
		internal static int __PropertyOffset_AutoCompleteCVarColor;

		// Token: 0x04003104 RID: 12548
		internal static int __PropertyOffset_AutoCompleteFadedColor;
	}
}
