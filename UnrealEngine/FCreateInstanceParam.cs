using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028F7 RID: 10487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.CreateInstanceParam")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FCreateInstanceParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026E40 RID: 159296 RVA: 0x003B53B2 File Offset: 0x003B35B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCreateInstanceParam._ScriptStructPtr != 0) ? FCreateInstanceParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TASdkPlugin.CreateInstanceParam", ref FCreateInstanceParam._ScriptStructPtr);
		}

		// Token: 0x170095CE RID: 38350
		// (get) Token: 0x06026E41 RID: 159297 RVA: 0x003B53D6 File Offset: 0x003B35D6
		// (set) Token: 0x06026E42 RID: 159298 RVA: 0x003B53E6 File Offset: 0x003B35E6
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x170095CF RID: 38351
		// (get) Token: 0x06026E43 RID: 159299 RVA: 0x003B53F7 File Offset: 0x003B35F7
		// (set) Token: 0x06026E44 RID: 159300 RVA: 0x003B540B File Offset: 0x003B360B
		public unsafe string ServerUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_ServerUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_ServerUrl)), value);
			}
		}

		// Token: 0x170095D0 RID: 38352
		// (get) Token: 0x06026E45 RID: 159301 RVA: 0x003B5420 File Offset: 0x003B3620
		// (set) Token: 0x06026E46 RID: 159302 RVA: 0x003B5434 File Offset: 0x003B3634
		public unsafe string AppId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_AppId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_AppId)), value);
			}
		}

		// Token: 0x170095D1 RID: 38353
		// (get) Token: 0x06026E47 RID: 159303 RVA: 0x003B5449 File Offset: 0x003B3649
		// (set) Token: 0x06026E48 RID: 159304 RVA: 0x003B545D File Offset: 0x003B365D
		public unsafe string DistinctId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_DistinctId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_DistinctId)), value);
			}
		}

		// Token: 0x170095D2 RID: 38354
		// (get) Token: 0x06026E49 RID: 159305 RVA: 0x003B5472 File Offset: 0x003B3672
		// (set) Token: 0x06026E4A RID: 159306 RVA: 0x003B5486 File Offset: 0x003B3686
		public unsafe string AccountId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_AccountId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_AccountId)), value);
			}
		}

		// Token: 0x170095D3 RID: 38355
		// (get) Token: 0x06026E4B RID: 159307 RVA: 0x003B549B File Offset: 0x003B369B
		// (set) Token: 0x06026E4C RID: 159308 RVA: 0x003B54AF File Offset: 0x003B36AF
		public unsafe string LogDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_LogDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_LogDisplayName)), value);
			}
		}

		// Token: 0x170095D4 RID: 38356
		// (get) Token: 0x06026E4D RID: 159309 RVA: 0x003B54C4 File Offset: 0x003B36C4
		// (set) Token: 0x06026E4E RID: 159310 RVA: 0x003B54D8 File Offset: 0x003B36D8
		public unsafe string SaveDBPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_SaveDBPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCreateInstanceParam.__PropertyOffset_SaveDBPath)), value);
			}
		}

		// Token: 0x170095D5 RID: 38357
		// (get) Token: 0x06026E4F RID: 159311 RVA: 0x003B54ED File Offset: 0x003B36ED
		// (set) Token: 0x06026E50 RID: 159312 RVA: 0x003B54FD File Offset: 0x003B36FD
		public unsafe int MaxNumInBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_MaxNumInBatch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_MaxNumInBatch) = value;
			}
		}

		// Token: 0x170095D6 RID: 38358
		// (get) Token: 0x06026E51 RID: 159313 RVA: 0x003B550E File Offset: 0x003B370E
		// (set) Token: 0x06026E52 RID: 159314 RVA: 0x003B551E File Offset: 0x003B371E
		public unsafe TAMode Mode
		{
			get
			{
				return (TAMode)(*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170095D7 RID: 38359
		// (get) Token: 0x06026E53 RID: 159315 RVA: 0x003B552F File Offset: 0x003B372F
		// (set) Token: 0x06026E54 RID: 159316 RVA: 0x003B553F File Offset: 0x003B373F
		public unsafe ESaveMode SaveMode
		{
			get
			{
				return (ESaveMode)(*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_SaveMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_SaveMode) = (byte)value;
			}
		}

		// Token: 0x170095D8 RID: 38360
		// (get) Token: 0x06026E55 RID: 159317 RVA: 0x003B5550 File Offset: 0x003B3750
		// (set) Token: 0x06026E56 RID: 159318 RVA: 0x003B5560 File Offset: 0x003B3760
		public unsafe float FlushTimeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_FlushTimeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_FlushTimeInterval) = value;
			}
		}

		// Token: 0x170095D9 RID: 38361
		// (get) Token: 0x06026E57 RID: 159319 RVA: 0x003B5571 File Offset: 0x003B3771
		// (set) Token: 0x06026E58 RID: 159320 RVA: 0x003B558A File Offset: 0x003B378A
		public unsafe bool bUseUtf8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bUseUtf8) & FCreateInstanceParam.__PropertyMask_bUseUtf8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bUseUtf8) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bUseUtf8) & ~FCreateInstanceParam.__PropertyMask_bUseUtf8) | (value ? FCreateInstanceParam.__PropertyMask_bUseUtf8 : 0));
			}
		}

		// Token: 0x170095DA RID: 38362
		// (get) Token: 0x06026E59 RID: 159321 RVA: 0x003B55BA File Offset: 0x003B37BA
		// (set) Token: 0x06026E5A RID: 159322 RVA: 0x003B55D3 File Offset: 0x003B37D3
		public unsafe bool bLogInitEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bLogInitEnable) & FCreateInstanceParam.__PropertyMask_bLogInitEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bLogInitEnable) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bLogInitEnable) & ~FCreateInstanceParam.__PropertyMask_bLogInitEnable) | (value ? FCreateInstanceParam.__PropertyMask_bLogInitEnable : 0));
			}
		}

		// Token: 0x170095DB RID: 38363
		// (get) Token: 0x06026E5B RID: 159323 RVA: 0x003B5603 File Offset: 0x003B3803
		// (set) Token: 0x06026E5C RID: 159324 RVA: 0x003B561C File Offset: 0x003B381C
		public unsafe bool bImmediateSave
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bImmediateSave) & FCreateInstanceParam.__PropertyMask_bImmediateSave) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bImmediateSave) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bImmediateSave) & ~FCreateInstanceParam.__PropertyMask_bImmediateSave) | (value ? FCreateInstanceParam.__PropertyMask_bImmediateSave : 0));
			}
		}

		// Token: 0x170095DC RID: 38364
		// (get) Token: 0x06026E5D RID: 159325 RVA: 0x003B564C File Offset: 0x003B384C
		// (set) Token: 0x06026E5E RID: 159326 RVA: 0x003B5665 File Offset: 0x003B3865
		public unsafe bool bRuntimeInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bRuntimeInstance) & FCreateInstanceParam.__PropertyMask_bRuntimeInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bRuntimeInstance) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bRuntimeInstance) & ~FCreateInstanceParam.__PropertyMask_bRuntimeInstance) | (value ? FCreateInstanceParam.__PropertyMask_bRuntimeInstance : 0));
			}
		}

		// Token: 0x170095DD RID: 38365
		// (get) Token: 0x06026E5F RID: 159327 RVA: 0x003B5695 File Offset: 0x003B3895
		// (set) Token: 0x06026E60 RID: 159328 RVA: 0x003B56A5 File Offset: 0x003B38A5
		public unsafe float ExitWaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_ExitWaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_ExitWaitTime) = value;
			}
		}

		// Token: 0x170095DE RID: 38366
		// (get) Token: 0x06026E61 RID: 159329 RVA: 0x003B56B6 File Offset: 0x003B38B6
		// (set) Token: 0x06026E62 RID: 159330 RVA: 0x003B56C6 File Offset: 0x003B38C6
		public unsafe int MaxPendingLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_MaxPendingLog);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_MaxPendingLog) = value;
			}
		}

		// Token: 0x170095DF RID: 38367
		// (get) Token: 0x06026E63 RID: 159331 RVA: 0x003B56D7 File Offset: 0x003B38D7
		// (set) Token: 0x06026E64 RID: 159332 RVA: 0x003B56E7 File Offset: 0x003B38E7
		public unsafe float SendHttpTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_SendHttpTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_SendHttpTimeout) = value;
			}
		}

		// Token: 0x170095E0 RID: 38368
		// (get) Token: 0x06026E65 RID: 159333 RVA: 0x003B56F8 File Offset: 0x003B38F8
		// (set) Token: 0x06026E66 RID: 159334 RVA: 0x003B5711 File Offset: 0x003B3911
		public unsafe bool bExitFlush
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bExitFlush) & FCreateInstanceParam.__PropertyMask_bExitFlush) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bExitFlush) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bExitFlush) & ~FCreateInstanceParam.__PropertyMask_bExitFlush) | (value ? FCreateInstanceParam.__PropertyMask_bExitFlush : 0));
			}
		}

		// Token: 0x170095E1 RID: 38369
		// (get) Token: 0x06026E67 RID: 159335 RVA: 0x003B5741 File Offset: 0x003B3941
		// (set) Token: 0x06026E68 RID: 159336 RVA: 0x003B5751 File Offset: 0x003B3951
		public unsafe float CalibrateIntervalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_CalibrateIntervalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_CalibrateIntervalTime) = value;
			}
		}

		// Token: 0x170095E2 RID: 38370
		// (get) Token: 0x06026E69 RID: 159337 RVA: 0x003B5762 File Offset: 0x003B3962
		// (set) Token: 0x06026E6A RID: 159338 RVA: 0x003B577B File Offset: 0x003B397B
		public unsafe bool bCalibratedStopTimer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) & FCreateInstanceParam.__PropertyMask_bCalibratedStopTimer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) = ((*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bCalibratedStopTimer) & ~FCreateInstanceParam.__PropertyMask_bCalibratedStopTimer) | (value ? FCreateInstanceParam.__PropertyMask_bCalibratedStopTimer : 0));
			}
		}

		// Token: 0x170095E3 RID: 38371
		// (get) Token: 0x06026E6B RID: 159339 RVA: 0x003B57AB File Offset: 0x003B39AB
		// (set) Token: 0x06026E6C RID: 159340 RVA: 0x003B57BB File Offset: 0x003B39BB
		public unsafe bool bEnableCompressPlusOneLen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bEnableCompressPlusOneLen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCreateInstanceParam.__PropertyOffset_bEnableCompressPlusOneLen) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026E6D RID: 159341 RVA: 0x003B57CC File Offset: 0x003B39CC
		public FCreateInstanceParam()
		{
		}

		// Token: 0x06026E6E RID: 159342 RVA: 0x003B57D4 File Offset: 0x003B39D4
		public FCreateInstanceParam(int Index, string ServerUrl, string AppId, string DistinctId, string AccountId, string LogDisplayName, string SaveDBPath, int MaxNumInBatch, TAMode Mode, ESaveMode SaveMode, float FlushTimeInterval, bool bUseUtf8, bool bLogInitEnable, bool bImmediateSave, bool bRuntimeInstance, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer, bool bEnableCompressPlusOneLen)
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

		// Token: 0x06026E6F RID: 159343 RVA: 0x003B5894 File Offset: 0x003B3A94
		protected override IntPtr GetUStructPtr()
		{
			return FCreateInstanceParam.StaticStruct();
		}

		// Token: 0x06026E70 RID: 159344 RVA: 0x003B58A0 File Offset: 0x003B3AA0
		[NullableContext(2)]
		public FCreateInstanceParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E71 RID: 159345 RVA: 0x003B58AA File Offset: 0x003B3AAA
		public FCreateInstanceParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E72 RID: 159346 RVA: 0x003B58B5 File Offset: 0x003B3AB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCreateInstanceParam(Pointer, false, true);
		}

		// Token: 0x06026E73 RID: 159347 RVA: 0x003B58BF File Offset: 0x003B3ABF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCreateInstanceParam(Pointer, MemoryOwner);
		}

		// Token: 0x040155A0 RID: 87456
		public const string __ObjectPath = "/Script/TASdkPlugin.CreateInstanceParam";

		// Token: 0x040155A1 RID: 87457
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155A2 RID: 87458
		internal static int __PropertyOffset_Index;

		// Token: 0x040155A3 RID: 87459
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x040155A4 RID: 87460
		internal static int __PropertyOffset_AppId;

		// Token: 0x040155A5 RID: 87461
		internal static int __PropertyOffset_DistinctId;

		// Token: 0x040155A6 RID: 87462
		internal static int __PropertyOffset_AccountId;

		// Token: 0x040155A7 RID: 87463
		internal static int __PropertyOffset_LogDisplayName;

		// Token: 0x040155A8 RID: 87464
		internal static int __PropertyOffset_SaveDBPath;

		// Token: 0x040155A9 RID: 87465
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x040155AA RID: 87466
		internal static int __PropertyOffset_Mode;

		// Token: 0x040155AB RID: 87467
		internal static int __PropertyOffset_SaveMode;

		// Token: 0x040155AC RID: 87468
		internal static int __PropertyOffset_FlushTimeInterval;

		// Token: 0x040155AD RID: 87469
		internal static int __PropertyOffset_bUseUtf8;

		// Token: 0x040155AE RID: 87470
		internal static byte __PropertyMask_bUseUtf8;

		// Token: 0x040155AF RID: 87471
		internal static int __PropertyOffset_bLogInitEnable;

		// Token: 0x040155B0 RID: 87472
		internal static byte __PropertyMask_bLogInitEnable;

		// Token: 0x040155B1 RID: 87473
		internal static int __PropertyOffset_bImmediateSave;

		// Token: 0x040155B2 RID: 87474
		internal static byte __PropertyMask_bImmediateSave;

		// Token: 0x040155B3 RID: 87475
		internal static int __PropertyOffset_bRuntimeInstance;

		// Token: 0x040155B4 RID: 87476
		internal static byte __PropertyMask_bRuntimeInstance;

		// Token: 0x040155B5 RID: 87477
		internal static int __PropertyOffset_ExitWaitTime;

		// Token: 0x040155B6 RID: 87478
		internal static int __PropertyOffset_MaxPendingLog;

		// Token: 0x040155B7 RID: 87479
		internal static int __PropertyOffset_SendHttpTimeout;

		// Token: 0x040155B8 RID: 87480
		internal static int __PropertyOffset_bExitFlush;

		// Token: 0x040155B9 RID: 87481
		internal static byte __PropertyMask_bExitFlush;

		// Token: 0x040155BA RID: 87482
		internal static int __PropertyOffset_CalibrateIntervalTime;

		// Token: 0x040155BB RID: 87483
		internal static int __PropertyOffset_bCalibratedStopTimer;

		// Token: 0x040155BC RID: 87484
		internal static byte __PropertyMask_bCalibratedStopTimer;

		// Token: 0x040155BD RID: 87485
		internal static int __PropertyOffset_bEnableCompressPlusOneLen;
	}
}
