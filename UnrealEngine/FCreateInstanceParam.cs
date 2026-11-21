using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200084B RID: 2123
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.CreateInstanceParam")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FCreateInstanceParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B8FA RID: 47354 RVA: 0x001282BA File Offset: 0x001264BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCreateInstanceParam._ScriptStructPtr != 0) ? FCreateInstanceParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TASdkPlugin.CreateInstanceParam", ref FCreateInstanceParam._ScriptStructPtr);
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x001282DE File Offset: 0x001264DE
		// (set) Token: 0x0600B8FC RID: 47356 RVA: 0x001282EE File Offset: 0x001264EE
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

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600B8FD RID: 47357 RVA: 0x001282FF File Offset: 0x001264FF
		// (set) Token: 0x0600B8FE RID: 47358 RVA: 0x00128313 File Offset: 0x00126513
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

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x00128328 File Offset: 0x00126528
		// (set) Token: 0x0600B900 RID: 47360 RVA: 0x0012833C File Offset: 0x0012653C
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

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600B901 RID: 47361 RVA: 0x00128351 File Offset: 0x00126551
		// (set) Token: 0x0600B902 RID: 47362 RVA: 0x00128365 File Offset: 0x00126565
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

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600B903 RID: 47363 RVA: 0x0012837A File Offset: 0x0012657A
		// (set) Token: 0x0600B904 RID: 47364 RVA: 0x0012838E File Offset: 0x0012658E
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

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600B905 RID: 47365 RVA: 0x001283A3 File Offset: 0x001265A3
		// (set) Token: 0x0600B906 RID: 47366 RVA: 0x001283B7 File Offset: 0x001265B7
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

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600B907 RID: 47367 RVA: 0x001283CC File Offset: 0x001265CC
		// (set) Token: 0x0600B908 RID: 47368 RVA: 0x001283E0 File Offset: 0x001265E0
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

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x001283F5 File Offset: 0x001265F5
		// (set) Token: 0x0600B90A RID: 47370 RVA: 0x00128405 File Offset: 0x00126605
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

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x00128416 File Offset: 0x00126616
		// (set) Token: 0x0600B90C RID: 47372 RVA: 0x00128426 File Offset: 0x00126626
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

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600B90D RID: 47373 RVA: 0x00128437 File Offset: 0x00126637
		// (set) Token: 0x0600B90E RID: 47374 RVA: 0x00128447 File Offset: 0x00126647
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

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600B90F RID: 47375 RVA: 0x00128458 File Offset: 0x00126658
		// (set) Token: 0x0600B910 RID: 47376 RVA: 0x00128468 File Offset: 0x00126668
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

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600B911 RID: 47377 RVA: 0x00128479 File Offset: 0x00126679
		// (set) Token: 0x0600B912 RID: 47378 RVA: 0x00128492 File Offset: 0x00126692
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

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x001284C2 File Offset: 0x001266C2
		// (set) Token: 0x0600B914 RID: 47380 RVA: 0x001284DB File Offset: 0x001266DB
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

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x0012850B File Offset: 0x0012670B
		// (set) Token: 0x0600B916 RID: 47382 RVA: 0x00128524 File Offset: 0x00126724
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

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x00128554 File Offset: 0x00126754
		// (set) Token: 0x0600B918 RID: 47384 RVA: 0x0012856D File Offset: 0x0012676D
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

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x0012859D File Offset: 0x0012679D
		// (set) Token: 0x0600B91A RID: 47386 RVA: 0x001285AD File Offset: 0x001267AD
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

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x001285BE File Offset: 0x001267BE
		// (set) Token: 0x0600B91C RID: 47388 RVA: 0x001285CE File Offset: 0x001267CE
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

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600B91D RID: 47389 RVA: 0x001285DF File Offset: 0x001267DF
		// (set) Token: 0x0600B91E RID: 47390 RVA: 0x001285EF File Offset: 0x001267EF
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

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x00128600 File Offset: 0x00126800
		// (set) Token: 0x0600B920 RID: 47392 RVA: 0x00128619 File Offset: 0x00126819
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

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x00128649 File Offset: 0x00126849
		// (set) Token: 0x0600B922 RID: 47394 RVA: 0x00128659 File Offset: 0x00126859
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

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600B923 RID: 47395 RVA: 0x0012866A File Offset: 0x0012686A
		// (set) Token: 0x0600B924 RID: 47396 RVA: 0x00128683 File Offset: 0x00126883
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

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600B925 RID: 47397 RVA: 0x001286B3 File Offset: 0x001268B3
		// (set) Token: 0x0600B926 RID: 47398 RVA: 0x001286C3 File Offset: 0x001268C3
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

		// Token: 0x0600B927 RID: 47399 RVA: 0x001286D4 File Offset: 0x001268D4
		public FCreateInstanceParam()
		{
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x001286DC File Offset: 0x001268DC
		protected override IntPtr GetUStructPtr()
		{
			return FCreateInstanceParam.StaticStruct();
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x001286E8 File Offset: 0x001268E8
		[NullableContext(2)]
		public FCreateInstanceParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x001286F2 File Offset: 0x001268F2
		public FCreateInstanceParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x001286FD File Offset: 0x001268FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCreateInstanceParam(Pointer, false, true);
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x00128707 File Offset: 0x00126907
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCreateInstanceParam(Pointer, MemoryOwner);
		}

		// Token: 0x04005405 RID: 21509
		public const string __ObjectPath = "/Script/TASdkPlugin.CreateInstanceParam";

		// Token: 0x04005406 RID: 21510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005407 RID: 21511
		internal static int __PropertyOffset_Index;

		// Token: 0x04005408 RID: 21512
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x04005409 RID: 21513
		internal static int __PropertyOffset_AppId;

		// Token: 0x0400540A RID: 21514
		internal static int __PropertyOffset_DistinctId;

		// Token: 0x0400540B RID: 21515
		internal static int __PropertyOffset_AccountId;

		// Token: 0x0400540C RID: 21516
		internal static int __PropertyOffset_LogDisplayName;

		// Token: 0x0400540D RID: 21517
		internal static int __PropertyOffset_SaveDBPath;

		// Token: 0x0400540E RID: 21518
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x0400540F RID: 21519
		internal static int __PropertyOffset_Mode;

		// Token: 0x04005410 RID: 21520
		internal static int __PropertyOffset_SaveMode;

		// Token: 0x04005411 RID: 21521
		internal static int __PropertyOffset_FlushTimeInterval;

		// Token: 0x04005412 RID: 21522
		internal static int __PropertyOffset_bUseUtf8;

		// Token: 0x04005413 RID: 21523
		internal static byte __PropertyMask_bUseUtf8;

		// Token: 0x04005414 RID: 21524
		internal static int __PropertyOffset_bLogInitEnable;

		// Token: 0x04005415 RID: 21525
		internal static byte __PropertyMask_bLogInitEnable;

		// Token: 0x04005416 RID: 21526
		internal static int __PropertyOffset_bImmediateSave;

		// Token: 0x04005417 RID: 21527
		internal static byte __PropertyMask_bImmediateSave;

		// Token: 0x04005418 RID: 21528
		internal static int __PropertyOffset_bRuntimeInstance;

		// Token: 0x04005419 RID: 21529
		internal static byte __PropertyMask_bRuntimeInstance;

		// Token: 0x0400541A RID: 21530
		internal static int __PropertyOffset_ExitWaitTime;

		// Token: 0x0400541B RID: 21531
		internal static int __PropertyOffset_MaxPendingLog;

		// Token: 0x0400541C RID: 21532
		internal static int __PropertyOffset_SendHttpTimeout;

		// Token: 0x0400541D RID: 21533
		internal static int __PropertyOffset_bExitFlush;

		// Token: 0x0400541E RID: 21534
		internal static byte __PropertyMask_bExitFlush;

		// Token: 0x0400541F RID: 21535
		internal static int __PropertyOffset_CalibrateIntervalTime;

		// Token: 0x04005420 RID: 21536
		internal static int __PropertyOffset_bCalibratedStopTimer;

		// Token: 0x04005421 RID: 21537
		internal static byte __PropertyMask_bCalibratedStopTimer;

		// Token: 0x04005422 RID: 21538
		internal static int __PropertyOffset_bEnableCompressPlusOneLen;
	}
}
