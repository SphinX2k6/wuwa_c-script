using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D2 RID: 722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KACreateInstanceParam")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKACreateInstanceParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E13 RID: 19987 RVA: 0x0006D2CA File Offset: 0x0006B4CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKACreateInstanceParam._ScriptStructPtr != 0) ? FKACreateInstanceParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KRDataAnalyticsPlugin.KACreateInstanceParam", ref FKACreateInstanceParam._ScriptStructPtr);
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x0006D2EE File Offset: 0x0006B4EE
		// (set) Token: 0x06004E15 RID: 19989 RVA: 0x0006D2FE File Offset: 0x0006B4FE
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

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x0006D30F File Offset: 0x0006B50F
		// (set) Token: 0x06004E17 RID: 19991 RVA: 0x0006D323 File Offset: 0x0006B523
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x0006D338 File Offset: 0x0006B538
		// (set) Token: 0x06004E19 RID: 19993 RVA: 0x0006D34C File Offset: 0x0006B54C
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

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06004E1A RID: 19994 RVA: 0x0006D361 File Offset: 0x0006B561
		// (set) Token: 0x06004E1B RID: 19995 RVA: 0x0006D375 File Offset: 0x0006B575
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x0006D38A File Offset: 0x0006B58A
		// (set) Token: 0x06004E1D RID: 19997 RVA: 0x0006D39E File Offset: 0x0006B59E
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

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06004E1E RID: 19998 RVA: 0x0006D3B3 File Offset: 0x0006B5B3
		// (set) Token: 0x06004E1F RID: 19999 RVA: 0x0006D3C7 File Offset: 0x0006B5C7
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

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x0006D3DC File Offset: 0x0006B5DC
		// (set) Token: 0x06004E21 RID: 20001 RVA: 0x0006D3F0 File Offset: 0x0006B5F0
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

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x0006D405 File Offset: 0x0006B605
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x0006D415 File Offset: 0x0006B615
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

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x0006D426 File Offset: 0x0006B626
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x0006D436 File Offset: 0x0006B636
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

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x0006D447 File Offset: 0x0006B647
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x0006D457 File Offset: 0x0006B657
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

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x0006D468 File Offset: 0x0006B668
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x0006D478 File Offset: 0x0006B678
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x0006D489 File Offset: 0x0006B689
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x0006D4A2 File Offset: 0x0006B6A2
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

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0006D4D2 File Offset: 0x0006B6D2
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x0006D4EB File Offset: 0x0006B6EB
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x0006D51B File Offset: 0x0006B71B
		// (set) Token: 0x06004E2F RID: 20015 RVA: 0x0006D534 File Offset: 0x0006B734
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

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x0006D564 File Offset: 0x0006B764
		// (set) Token: 0x06004E31 RID: 20017 RVA: 0x0006D57D File Offset: 0x0006B77D
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

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x0006D5AD File Offset: 0x0006B7AD
		// (set) Token: 0x06004E33 RID: 20019 RVA: 0x0006D5BD File Offset: 0x0006B7BD
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

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x0006D5CE File Offset: 0x0006B7CE
		// (set) Token: 0x06004E35 RID: 20021 RVA: 0x0006D5DE File Offset: 0x0006B7DE
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

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x0006D5EF File Offset: 0x0006B7EF
		// (set) Token: 0x06004E37 RID: 20023 RVA: 0x0006D5FF File Offset: 0x0006B7FF
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

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x0006D610 File Offset: 0x0006B810
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x0006D629 File Offset: 0x0006B829
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

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x0006D659 File Offset: 0x0006B859
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x0006D669 File Offset: 0x0006B869
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

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x0006D67A File Offset: 0x0006B87A
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x0006D693 File Offset: 0x0006B893
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

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0006D6C3 File Offset: 0x0006B8C3
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0006D6D3 File Offset: 0x0006B8D3
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

		// Token: 0x06004E40 RID: 20032 RVA: 0x0006D6E4 File Offset: 0x0006B8E4
		public FKACreateInstanceParam()
		{
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		protected override IntPtr GetUStructPtr()
		{
			return FKACreateInstanceParam.StaticStruct();
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		[NullableContext(2)]
		public FKACreateInstanceParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x0006D702 File Offset: 0x0006B902
		public FKACreateInstanceParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x0006D70D File Offset: 0x0006B90D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKACreateInstanceParam(Pointer, false, true);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0006D717 File Offset: 0x0006B917
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKACreateInstanceParam(Pointer, MemoryOwner);
		}

		// Token: 0x04001F46 RID: 8006
		public const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KACreateInstanceParam";

		// Token: 0x04001F47 RID: 8007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F48 RID: 8008
		internal static int __PropertyOffset_Index;

		// Token: 0x04001F49 RID: 8009
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x04001F4A RID: 8010
		internal static int __PropertyOffset_AppId;

		// Token: 0x04001F4B RID: 8011
		internal static int __PropertyOffset_DistinctId;

		// Token: 0x04001F4C RID: 8012
		internal static int __PropertyOffset_AccountId;

		// Token: 0x04001F4D RID: 8013
		internal static int __PropertyOffset_LogDisplayName;

		// Token: 0x04001F4E RID: 8014
		internal static int __PropertyOffset_SaveDBPath;

		// Token: 0x04001F4F RID: 8015
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x04001F50 RID: 8016
		internal static int __PropertyOffset_Mode;

		// Token: 0x04001F51 RID: 8017
		internal static int __PropertyOffset_SaveMode;

		// Token: 0x04001F52 RID: 8018
		internal static int __PropertyOffset_FlushTimeInterval;

		// Token: 0x04001F53 RID: 8019
		internal static int __PropertyOffset_bUseUtf8;

		// Token: 0x04001F54 RID: 8020
		internal static byte __PropertyMask_bUseUtf8;

		// Token: 0x04001F55 RID: 8021
		internal static int __PropertyOffset_bLogInitEnable;

		// Token: 0x04001F56 RID: 8022
		internal static byte __PropertyMask_bLogInitEnable;

		// Token: 0x04001F57 RID: 8023
		internal static int __PropertyOffset_bImmediateSave;

		// Token: 0x04001F58 RID: 8024
		internal static byte __PropertyMask_bImmediateSave;

		// Token: 0x04001F59 RID: 8025
		internal static int __PropertyOffset_bRuntimeInstance;

		// Token: 0x04001F5A RID: 8026
		internal static byte __PropertyMask_bRuntimeInstance;

		// Token: 0x04001F5B RID: 8027
		internal static int __PropertyOffset_ExitWaitTime;

		// Token: 0x04001F5C RID: 8028
		internal static int __PropertyOffset_MaxPendingLog;

		// Token: 0x04001F5D RID: 8029
		internal static int __PropertyOffset_SendHttpTimeout;

		// Token: 0x04001F5E RID: 8030
		internal static int __PropertyOffset_bExitFlush;

		// Token: 0x04001F5F RID: 8031
		internal static byte __PropertyMask_bExitFlush;

		// Token: 0x04001F60 RID: 8032
		internal static int __PropertyOffset_CalibrateIntervalTime;

		// Token: 0x04001F61 RID: 8033
		internal static int __PropertyOffset_bCalibratedStopTimer;

		// Token: 0x04001F62 RID: 8034
		internal static byte __PropertyMask_bCalibratedStopTimer;

		// Token: 0x04001F63 RID: 8035
		internal static int __PropertyOffset_bEnableCompressPlusOneLen;
	}
}
