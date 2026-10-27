using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015DE RID: 5598
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KACreateInstanceParam")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKACreateInstanceParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142E8 RID: 82664 RVA: 0x001DA428 File Offset: 0x001D8628
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKACreateInstanceParam._ScriptStructPtr != 0) ? FKACreateInstanceParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KRDataAnalyticsPlugin.KACreateInstanceParam", ref FKACreateInstanceParam._ScriptStructPtr);
		}

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x060142E9 RID: 82665 RVA: 0x001DA44C File Offset: 0x001D864C
		// (set) Token: 0x060142EA RID: 82666 RVA: 0x001DA45C File Offset: 0x001D865C
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x060142EB RID: 82667 RVA: 0x001DA46D File Offset: 0x001D866D
		// (set) Token: 0x060142EC RID: 82668 RVA: 0x001DA481 File Offset: 0x001D8681
		public unsafe string ServerUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_ServerUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_ServerUrl)), value);
			}
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x060142ED RID: 82669 RVA: 0x001DA496 File Offset: 0x001D8696
		// (set) Token: 0x060142EE RID: 82670 RVA: 0x001DA4AA File Offset: 0x001D86AA
		public unsafe string AppId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_AppId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_AppId)), value);
			}
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x060142EF RID: 82671 RVA: 0x001DA4BF File Offset: 0x001D86BF
		// (set) Token: 0x060142F0 RID: 82672 RVA: 0x001DA4D3 File Offset: 0x001D86D3
		public unsafe string DistinctId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_DistinctId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_DistinctId)), value);
			}
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x060142F1 RID: 82673 RVA: 0x001DA4E8 File Offset: 0x001D86E8
		// (set) Token: 0x060142F2 RID: 82674 RVA: 0x001DA4FC File Offset: 0x001D86FC
		public unsafe string AccountId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_AccountId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_AccountId)), value);
			}
		}

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x060142F3 RID: 82675 RVA: 0x001DA511 File Offset: 0x001D8711
		// (set) Token: 0x060142F4 RID: 82676 RVA: 0x001DA525 File Offset: 0x001D8725
		public unsafe string LogDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_LogDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_LogDisplayName)), value);
			}
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x060142F5 RID: 82677 RVA: 0x001DA53A File Offset: 0x001D873A
		// (set) Token: 0x060142F6 RID: 82678 RVA: 0x001DA54E File Offset: 0x001D874E
		public unsafe string SaveDBPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_SaveDBPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKACreateInstanceParam.__PropertyOffset_SaveDBPath)), value);
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x060142F7 RID: 82679 RVA: 0x001DA563 File Offset: 0x001D8763
		// (set) Token: 0x060142F8 RID: 82680 RVA: 0x001DA573 File Offset: 0x001D8773
		public unsafe int MaxNumInBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_MaxNumInBatch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_MaxNumInBatch) = value;
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x060142F9 RID: 82681 RVA: 0x001DA584 File Offset: 0x001D8784
		// (set) Token: 0x060142FA RID: 82682 RVA: 0x001DA594 File Offset: 0x001D8794
		public unsafe KAMode Mode
		{
			get
			{
				return (KAMode)(*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x060142FB RID: 82683 RVA: 0x001DA5A5 File Offset: 0x001D87A5
		// (set) Token: 0x060142FC RID: 82684 RVA: 0x001DA5B5 File Offset: 0x001D87B5
		public unsafe EKASaveMode SaveMode
		{
			get
			{
				return (EKASaveMode)(*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_SaveMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_SaveMode) = (byte)value;
			}
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x060142FD RID: 82685 RVA: 0x001DA5C6 File Offset: 0x001D87C6
		// (set) Token: 0x060142FE RID: 82686 RVA: 0x001DA5D6 File Offset: 0x001D87D6
		public unsafe float FlushTimeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_FlushTimeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_FlushTimeInterval) = value;
			}
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x060142FF RID: 82687 RVA: 0x001DA5E7 File Offset: 0x001D87E7
		// (set) Token: 0x06014300 RID: 82688 RVA: 0x001DA600 File Offset: 0x001D8800
		public unsafe bool bUseUtf8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bUseUtf8) & FKACreateInstanceParam.__PropertyMask_bUseUtf8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bUseUtf8) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bUseUtf8) & ~FKACreateInstanceParam.__PropertyMask_bUseUtf8) | (value ? FKACreateInstanceParam.__PropertyMask_bUseUtf8 : 0));
			}
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x06014301 RID: 82689 RVA: 0x001DA630 File Offset: 0x001D8830
		// (set) Token: 0x06014302 RID: 82690 RVA: 0x001DA649 File Offset: 0x001D8849
		public unsafe bool bLogInitEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bLogInitEnable) & FKACreateInstanceParam.__PropertyMask_bLogInitEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bLogInitEnable) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bLogInitEnable) & ~FKACreateInstanceParam.__PropertyMask_bLogInitEnable) | (value ? FKACreateInstanceParam.__PropertyMask_bLogInitEnable : 0));
			}
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x06014303 RID: 82691 RVA: 0x001DA679 File Offset: 0x001D8879
		// (set) Token: 0x06014304 RID: 82692 RVA: 0x001DA692 File Offset: 0x001D8892
		public unsafe bool bImmediateSave
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bImmediateSave) & FKACreateInstanceParam.__PropertyMask_bImmediateSave) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bImmediateSave) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bImmediateSave) & ~FKACreateInstanceParam.__PropertyMask_bImmediateSave) | (value ? FKACreateInstanceParam.__PropertyMask_bImmediateSave : 0));
			}
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x06014305 RID: 82693 RVA: 0x001DA6C2 File Offset: 0x001D88C2
		// (set) Token: 0x06014306 RID: 82694 RVA: 0x001DA6DB File Offset: 0x001D88DB
		public unsafe bool bRuntimeInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bRuntimeInstance) & FKACreateInstanceParam.__PropertyMask_bRuntimeInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bRuntimeInstance) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bRuntimeInstance) & ~FKACreateInstanceParam.__PropertyMask_bRuntimeInstance) | (value ? FKACreateInstanceParam.__PropertyMask_bRuntimeInstance : 0));
			}
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x06014307 RID: 82695 RVA: 0x001DA70B File Offset: 0x001D890B
		// (set) Token: 0x06014308 RID: 82696 RVA: 0x001DA71B File Offset: 0x001D891B
		public unsafe float ExitWaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_ExitWaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_ExitWaitTime) = value;
			}
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x06014309 RID: 82697 RVA: 0x001DA72C File Offset: 0x001D892C
		// (set) Token: 0x0601430A RID: 82698 RVA: 0x001DA73C File Offset: 0x001D893C
		public unsafe int MaxPendingLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_MaxPendingLog);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_MaxPendingLog) = value;
			}
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x0601430B RID: 82699 RVA: 0x001DA74D File Offset: 0x001D894D
		// (set) Token: 0x0601430C RID: 82700 RVA: 0x001DA75D File Offset: 0x001D895D
		public unsafe float SendHttpTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_SendHttpTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_SendHttpTimeout) = value;
			}
		}

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x0601430D RID: 82701 RVA: 0x001DA76E File Offset: 0x001D896E
		// (set) Token: 0x0601430E RID: 82702 RVA: 0x001DA787 File Offset: 0x001D8987
		public unsafe bool bExitFlush
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bExitFlush) & FKACreateInstanceParam.__PropertyMask_bExitFlush) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bExitFlush) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bExitFlush) & ~FKACreateInstanceParam.__PropertyMask_bExitFlush) | (value ? FKACreateInstanceParam.__PropertyMask_bExitFlush : 0));
			}
		}

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x0601430F RID: 82703 RVA: 0x001DA7B7 File Offset: 0x001D89B7
		// (set) Token: 0x06014310 RID: 82704 RVA: 0x001DA7C7 File Offset: 0x001D89C7
		public unsafe float CalibrateIntervalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_CalibrateIntervalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_CalibrateIntervalTime) = value;
			}
		}

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06014311 RID: 82705 RVA: 0x001DA7D8 File Offset: 0x001D89D8
		// (set) Token: 0x06014312 RID: 82706 RVA: 0x001DA7F1 File Offset: 0x001D89F1
		public unsafe bool bCalibratedStopTimer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) & FKACreateInstanceParam.__PropertyMask_bCalibratedStopTimer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) = ((*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) & ~FKACreateInstanceParam.__PropertyMask_bCalibratedStopTimer) | (value ? FKACreateInstanceParam.__PropertyMask_bCalibratedStopTimer : 0));
			}
		}

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x06014313 RID: 82707 RVA: 0x001DA821 File Offset: 0x001D8A21
		// (set) Token: 0x06014314 RID: 82708 RVA: 0x001DA831 File Offset: 0x001D8A31
		public unsafe bool bEnableCompressPlusOneLen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bEnableCompressPlusOneLen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKACreateInstanceParam.__PropertyOffset_bEnableCompressPlusOneLen) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014315 RID: 82709 RVA: 0x001DA842 File Offset: 0x001D8A42
		public FKACreateInstanceParam()
		{
		}

		// Token: 0x06014316 RID: 82710 RVA: 0x001DA84C File Offset: 0x001D8A4C
		public FKACreateInstanceParam(int Index, string ServerUrl, string AppId, string DistinctId, string AccountId, string LogDisplayName, string SaveDBPath, int MaxNumInBatch, KAMode Mode, EKASaveMode SaveMode, float FlushTimeInterval, bool bUseUtf8, bool bLogInitEnable, bool bImmediateSave, bool bRuntimeInstance, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer, bool bEnableCompressPlusOneLen)
		{
			this.Index = Index;
			this.ServerUrl = ServerUrl;
			this.AppId = AppId;
			this.DistinctId = DistinctId;
			this.AccountId = AccountId;
			this.LogDisplayName = LogDisplayName;
			this.SaveDBPath = SaveDBPath;
			this.MaxNumInBatch = MaxNumInBatch;
			this.Mode = Mode;
			this.SaveMode = SaveMode;
			this.FlushTimeInterval = FlushTimeInterval;
			this.bUseUtf8 = bUseUtf8;
			this.bLogInitEnable = bLogInitEnable;
			this.bImmediateSave = bImmediateSave;
			this.bRuntimeInstance = bRuntimeInstance;
			this.ExitWaitTime = ExitWaitTime;
			this.MaxPendingLog = MaxPendingLog;
			this.SendHttpTimeout = SendHttpTimeout;
			this.bExitFlush = bExitFlush;
			this.CalibrateIntervalTime = CalibrateIntervalTime;
			this.bCalibratedStopTimer = bCalibratedStopTimer;
			this.bEnableCompressPlusOneLen = bEnableCompressPlusOneLen;
		}

		// Token: 0x06014317 RID: 82711 RVA: 0x001DA90C File Offset: 0x001D8B0C
		protected override IntPtr GetUStructPtr()
		{
			return FKACreateInstanceParam.StaticStruct();
		}

		// Token: 0x06014318 RID: 82712 RVA: 0x001DA918 File Offset: 0x001D8B18
		[NullableContext(2)]
		public FKACreateInstanceParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014319 RID: 82713 RVA: 0x001DA922 File Offset: 0x001D8B22
		public FKACreateInstanceParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601431A RID: 82714 RVA: 0x001DA92D File Offset: 0x001D8B2D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKACreateInstanceParam(Pointer, false, true);
		}

		// Token: 0x0601431B RID: 82715 RVA: 0x001DA937 File Offset: 0x001D8B37
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKACreateInstanceParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF9C RID: 44956
		public const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KACreateInstanceParam";

		// Token: 0x0400AF9D RID: 44957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF9E RID: 44958
		internal static int __PropertyOffset_Index;

		// Token: 0x0400AF9F RID: 44959
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x0400AFA0 RID: 44960
		internal static int __PropertyOffset_AppId;

		// Token: 0x0400AFA1 RID: 44961
		internal static int __PropertyOffset_DistinctId;

		// Token: 0x0400AFA2 RID: 44962
		internal static int __PropertyOffset_AccountId;

		// Token: 0x0400AFA3 RID: 44963
		internal static int __PropertyOffset_LogDisplayName;

		// Token: 0x0400AFA4 RID: 44964
		internal static int __PropertyOffset_SaveDBPath;

		// Token: 0x0400AFA5 RID: 44965
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x0400AFA6 RID: 44966
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400AFA7 RID: 44967
		internal static int __PropertyOffset_SaveMode;

		// Token: 0x0400AFA8 RID: 44968
		internal static int __PropertyOffset_FlushTimeInterval;

		// Token: 0x0400AFA9 RID: 44969
		internal static int __PropertyOffset_bUseUtf8;

		// Token: 0x0400AFAA RID: 44970
		internal static byte __PropertyMask_bUseUtf8;

		// Token: 0x0400AFAB RID: 44971
		internal static int __PropertyOffset_bLogInitEnable;

		// Token: 0x0400AFAC RID: 44972
		internal static byte __PropertyMask_bLogInitEnable;

		// Token: 0x0400AFAD RID: 44973
		internal static int __PropertyOffset_bImmediateSave;

		// Token: 0x0400AFAE RID: 44974
		internal static byte __PropertyMask_bImmediateSave;

		// Token: 0x0400AFAF RID: 44975
		internal static int __PropertyOffset_bRuntimeInstance;

		// Token: 0x0400AFB0 RID: 44976
		internal static byte __PropertyMask_bRuntimeInstance;

		// Token: 0x0400AFB1 RID: 44977
		internal static int __PropertyOffset_ExitWaitTime;

		// Token: 0x0400AFB2 RID: 44978
		internal static int __PropertyOffset_MaxPendingLog;

		// Token: 0x0400AFB3 RID: 44979
		internal static int __PropertyOffset_SendHttpTimeout;

		// Token: 0x0400AFB4 RID: 44980
		internal static int __PropertyOffset_bExitFlush;

		// Token: 0x0400AFB5 RID: 44981
		internal static byte __PropertyMask_bExitFlush;

		// Token: 0x0400AFB6 RID: 44982
		internal static int __PropertyOffset_CalibrateIntervalTime;

		// Token: 0x0400AFB7 RID: 44983
		internal static int __PropertyOffset_bCalibratedStopTimer;

		// Token: 0x0400AFB8 RID: 44984
		internal static byte __PropertyMask_bCalibratedStopTimer;

		// Token: 0x0400AFB9 RID: 44985
		internal static int __PropertyOffset_bEnableCompressPlusOneLen;
	}
}
