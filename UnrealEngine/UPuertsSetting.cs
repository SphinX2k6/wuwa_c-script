using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002676 RID: 9846
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Puerts.PuertsSetting")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UPuertsSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024942 RID: 149826 RVA: 0x003625E5 File Offset: 0x003607E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPuertsSetting._ClassPtr;
		}

		// Token: 0x06024943 RID: 149827 RVA: 0x003625F4 File Offset: 0x003607F4
		public UPuertsSetting() : this(BuiltinUtils.AllocNativeUObject(UPuertsSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024944 RID: 149828 RVA: 0x0036261C File Offset: 0x0036081C
		public UPuertsSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPuertsSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D07 RID: 36103
		// (get) Token: 0x06024945 RID: 149829 RVA: 0x0036264F File Offset: 0x0036084F
		// (set) Token: 0x06024946 RID: 149830 RVA: 0x00362663 File Offset: 0x00360863
		public unsafe string RootPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPuertsSetting.__PropertyOffset_RootPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPuertsSetting.__PropertyOffset_RootPath)), value);
			}
		}

		// Token: 0x17008D08 RID: 36104
		// (get) Token: 0x06024947 RID: 149831 RVA: 0x00362678 File Offset: 0x00360878
		// (set) Token: 0x06024948 RID: 149832 RVA: 0x00362688 File Offset: 0x00360888
		public unsafe bool AutoModeEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_AutoModeEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_AutoModeEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D09 RID: 36105
		// (get) Token: 0x06024949 RID: 149833 RVA: 0x00362699 File Offset: 0x00360899
		// (set) Token: 0x0602494A RID: 149834 RVA: 0x003626A9 File Offset: 0x003608A9
		public unsafe bool DebugEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_DebugEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_DebugEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D0A RID: 36106
		// (get) Token: 0x0602494B RID: 149835 RVA: 0x003626BA File Offset: 0x003608BA
		// (set) Token: 0x0602494C RID: 149836 RVA: 0x003626CA File Offset: 0x003608CA
		public unsafe int DebugPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_DebugPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_DebugPort) = value;
			}
		}

		// Token: 0x17008D0B RID: 36107
		// (get) Token: 0x0602494D RID: 149837 RVA: 0x003626DB File Offset: 0x003608DB
		// (set) Token: 0x0602494E RID: 149838 RVA: 0x003626EB File Offset: 0x003608EB
		public unsafe bool WaitDebugger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WaitDebugger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WaitDebugger) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D0C RID: 36108
		// (get) Token: 0x0602494F RID: 149839 RVA: 0x003626FC File Offset: 0x003608FC
		// (set) Token: 0x06024950 RID: 149840 RVA: 0x0036270C File Offset: 0x0036090C
		public unsafe double WaitDebuggerTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WaitDebuggerTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WaitDebuggerTimeout) = value;
			}
		}

		// Token: 0x17008D0D RID: 36109
		// (get) Token: 0x06024951 RID: 149841 RVA: 0x0036271D File Offset: 0x0036091D
		// (set) Token: 0x06024952 RID: 149842 RVA: 0x0036272D File Offset: 0x0036092D
		public unsafe int NumberOfJsEnv
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_NumberOfJsEnv);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_NumberOfJsEnv) = value;
			}
		}

		// Token: 0x17008D0E RID: 36110
		// (get) Token: 0x06024953 RID: 149843 RVA: 0x0036273E File Offset: 0x0036093E
		// (set) Token: 0x06024954 RID: 149844 RVA: 0x0036274E File Offset: 0x0036094E
		public unsafe bool WatchDisable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WatchDisable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_WatchDisable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D0F RID: 36111
		// (get) Token: 0x06024955 RID: 149845 RVA: 0x00362760 File Offset: 0x00360960
		// (set) Token: 0x06024956 RID: 149846 RVA: 0x00362799 File Offset: 0x00360999
		public TArray<string> IgnoreClassListOnDTS
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._IgnoreClassListOnDTS) == null)
				{
					result = (this._IgnoreClassListOnDTS = new TArray<string>(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_IgnoreClassListOnDTS, this));
				}
				return result;
			}
			set
			{
				this.IgnoreClassListOnDTS.CopyAssign(value);
			}
		}

		// Token: 0x17008D10 RID: 36112
		// (get) Token: 0x06024957 RID: 149847 RVA: 0x003627A8 File Offset: 0x003609A8
		// (set) Token: 0x06024958 RID: 149848 RVA: 0x003627E1 File Offset: 0x003609E1
		public TArray<string> IgnoreStructListOnDTS
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._IgnoreStructListOnDTS) == null)
				{
					result = (this._IgnoreStructListOnDTS = new TArray<string>(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_IgnoreStructListOnDTS, this));
				}
				return result;
			}
			set
			{
				this.IgnoreStructListOnDTS.CopyAssign(value);
			}
		}

		// Token: 0x17008D11 RID: 36113
		// (get) Token: 0x06024959 RID: 149849 RVA: 0x003627EF File Offset: 0x003609EF
		// (set) Token: 0x0602495A RID: 149850 RVA: 0x00362803 File Offset: 0x00360A03
		public unsafe string PreloadPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPuertsSetting.__PropertyOffset_PreloadPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPuertsSetting.__PropertyOffset_PreloadPath)), value);
			}
		}

		// Token: 0x17008D12 RID: 36114
		// (get) Token: 0x0602495B RID: 149851 RVA: 0x00362818 File Offset: 0x00360A18
		// (set) Token: 0x0602495C RID: 149852 RVA: 0x00362828 File Offset: 0x00360A28
		public unsafe bool EnableStackTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_EnableStackTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPuertsSetting.__PropertyOffset_EnableStackTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602495D RID: 149853 RVA: 0x00362839 File Offset: 0x00360A39
		static UPuertsSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Puerts.PuertsSetting");
		}

		// Token: 0x0602495E RID: 149854 RVA: 0x00362847 File Offset: 0x00360A47
		protected UPuertsSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A7B RID: 80507
		public new const string __ObjectPath = "/Script/Puerts.PuertsSetting";

		// Token: 0x04013A7C RID: 80508
		private static IntPtr _ClassPtr;

		// Token: 0x04013A7D RID: 80509
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A7E RID: 80510
		internal static int __PropertyOffset_RootPath;

		// Token: 0x04013A7F RID: 80511
		internal static int __PropertyOffset_AutoModeEnable;

		// Token: 0x04013A80 RID: 80512
		internal static int __PropertyOffset_DebugEnable;

		// Token: 0x04013A81 RID: 80513
		internal static int __PropertyOffset_DebugPort;

		// Token: 0x04013A82 RID: 80514
		internal static int __PropertyOffset_WaitDebugger;

		// Token: 0x04013A83 RID: 80515
		internal static int __PropertyOffset_WaitDebuggerTimeout;

		// Token: 0x04013A84 RID: 80516
		internal static int __PropertyOffset_NumberOfJsEnv;

		// Token: 0x04013A85 RID: 80517
		internal static int __PropertyOffset_WatchDisable;

		// Token: 0x04013A86 RID: 80518
		internal static int __PropertyOffset_IgnoreClassListOnDTS;

		// Token: 0x04013A87 RID: 80519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _IgnoreClassListOnDTS;

		// Token: 0x04013A88 RID: 80520
		internal static int __PropertyOffset_IgnoreStructListOnDTS;

		// Token: 0x04013A89 RID: 80521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _IgnoreStructListOnDTS;

		// Token: 0x04013A8A RID: 80522
		internal static int __PropertyOffset_PreloadPath;

		// Token: 0x04013A8B RID: 80523
		internal static int __PropertyOffset_EnableStackTrace;
	}
}
