using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079B RID: 1947
	[UnrealObjectPath("/Script/EngineSettings.GameNetworkManagerSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGameNetworkManagerSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006568 RID: 25960 RVA: 0x000916CE File Offset: 0x0008F8CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameNetworkManagerSettings._ClassPtr;
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x000916DC File Offset: 0x0008F8DC
		public UGameNetworkManagerSettings() : this(BuiltinUtils.AllocNativeUObject(UGameNetworkManagerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00091704 File Offset: 0x0008F904
		[NullableContext(1)]
		public UGameNetworkManagerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameNetworkManagerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x00091737 File Offset: 0x0008F937
		// (set) Token: 0x0600656C RID: 25964 RVA: 0x00091747 File Offset: 0x0008F947
		public unsafe int MinDynamicBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_MinDynamicBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_MinDynamicBandwidth) = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x00091758 File Offset: 0x0008F958
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x00091768 File Offset: 0x0008F968
		public unsafe int MaxDynamicBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_MaxDynamicBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_MaxDynamicBandwidth) = value;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x00091779 File Offset: 0x0008F979
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x00091789 File Offset: 0x0008F989
		public unsafe int TotalNetBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_TotalNetBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_TotalNetBandwidth) = value;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x0009179A File Offset: 0x0008F99A
		// (set) Token: 0x06006572 RID: 25970 RVA: 0x000917AA File Offset: 0x0008F9AA
		public unsafe int BadPingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_BadPingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_BadPingThreshold) = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x000917BB File Offset: 0x0008F9BB
		// (set) Token: 0x06006574 RID: 25972 RVA: 0x000917D4 File Offset: 0x0008F9D4
		public unsafe bool bIsStandbyCheckingEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_bIsStandbyCheckingEnabled) & UGameNetworkManagerSettings.__PropertyMask_bIsStandbyCheckingEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_bIsStandbyCheckingEnabled) = ((*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_bIsStandbyCheckingEnabled) & ~UGameNetworkManagerSettings.__PropertyMask_bIsStandbyCheckingEnabled) | (value ? UGameNetworkManagerSettings.__PropertyMask_bIsStandbyCheckingEnabled : 0));
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06006575 RID: 25973 RVA: 0x00091804 File Offset: 0x0008FA04
		// (set) Token: 0x06006576 RID: 25974 RVA: 0x00091814 File Offset: 0x0008FA14
		public unsafe float StandbyRxCheatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_StandbyRxCheatTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_StandbyRxCheatTime) = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x00091825 File Offset: 0x0008FA25
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x00091835 File Offset: 0x0008FA35
		public unsafe float StandbyTxCheatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_StandbyTxCheatTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_StandbyTxCheatTime) = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x00091846 File Offset: 0x0008FA46
		// (set) Token: 0x0600657A RID: 25978 RVA: 0x00091856 File Offset: 0x0008FA56
		public unsafe float PercentMissingForRxStandby
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentMissingForRxStandby);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentMissingForRxStandby) = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x00091867 File Offset: 0x0008FA67
		// (set) Token: 0x0600657C RID: 25980 RVA: 0x00091877 File Offset: 0x0008FA77
		public unsafe float PercentMissingForTxStandby
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentMissingForTxStandby);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentMissingForTxStandby) = value;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x00091888 File Offset: 0x0008FA88
		// (set) Token: 0x0600657E RID: 25982 RVA: 0x00091898 File Offset: 0x0008FA98
		public unsafe float PercentForBadPing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentForBadPing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_PercentForBadPing) = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x000918A9 File Offset: 0x0008FAA9
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x000918B9 File Offset: 0x0008FAB9
		public unsafe float JoinInProgressStandbyWaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_JoinInProgressStandbyWaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameNetworkManagerSettings.__PropertyOffset_JoinInProgressStandbyWaitTime) = value;
			}
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x000918CA File Offset: 0x0008FACA
		static UGameNetworkManagerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.GameNetworkManagerSettings");
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x000918D8 File Offset: 0x0008FAD8
		protected UGameNetworkManagerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003134 RID: 12596
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/EngineSettings.GameNetworkManagerSettings";

		// Token: 0x04003135 RID: 12597
		private static IntPtr _ClassPtr;

		// Token: 0x04003136 RID: 12598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003137 RID: 12599
		internal static int __PropertyOffset_MinDynamicBandwidth;

		// Token: 0x04003138 RID: 12600
		internal static int __PropertyOffset_MaxDynamicBandwidth;

		// Token: 0x04003139 RID: 12601
		internal static int __PropertyOffset_TotalNetBandwidth;

		// Token: 0x0400313A RID: 12602
		internal static int __PropertyOffset_BadPingThreshold;

		// Token: 0x0400313B RID: 12603
		internal static int __PropertyOffset_bIsStandbyCheckingEnabled;

		// Token: 0x0400313C RID: 12604
		internal static byte __PropertyMask_bIsStandbyCheckingEnabled;

		// Token: 0x0400313D RID: 12605
		internal static int __PropertyOffset_StandbyRxCheatTime;

		// Token: 0x0400313E RID: 12606
		internal static int __PropertyOffset_StandbyTxCheatTime;

		// Token: 0x0400313F RID: 12607
		internal static int __PropertyOffset_PercentMissingForRxStandby;

		// Token: 0x04003140 RID: 12608
		internal static int __PropertyOffset_PercentMissingForTxStandby;

		// Token: 0x04003141 RID: 12609
		internal static int __PropertyOffset_PercentForBadPing;

		// Token: 0x04003142 RID: 12610
		internal static int __PropertyOffset_JoinInProgressStandbyWaitTime;
	}
}
