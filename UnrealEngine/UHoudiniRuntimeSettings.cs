using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001500 RID: 5376
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniRuntimeSettings")]
	[UnrealStructLayout(840, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 840)]
	public class UHoudiniRuntimeSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060137CC RID: 79820 RVA: 0x001CA664 File Offset: 0x001C8864
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniRuntimeSettings._ClassPtr;
		}

		// Token: 0x060137CD RID: 79821 RVA: 0x001CA670 File Offset: 0x001C8870
		public UHoudiniRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(UHoudiniRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060137CE RID: 79822 RVA: 0x001CA698 File Offset: 0x001C8898
		public UHoudiniRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x060137CF RID: 79823 RVA: 0x001CA6CB File Offset: 0x001C88CB
		// (set) Token: 0x060137D0 RID: 79824 RVA: 0x001CA6DF File Offset: 0x001C88DF
		[Nullable(0)]
		public unsafe TEnumAsByte<EHoudiniRuntimeSettingsSessionType> SessionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_SessionType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_SessionType) = value;
			}
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x060137D1 RID: 79825 RVA: 0x001CA6F4 File Offset: 0x001C88F4
		// (set) Token: 0x060137D2 RID: 79826 RVA: 0x001CA708 File Offset: 0x001C8908
		public unsafe string ServerHost
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerHost)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerHost)), value);
			}
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x060137D3 RID: 79827 RVA: 0x001CA71D File Offset: 0x001C891D
		// (set) Token: 0x060137D4 RID: 79828 RVA: 0x001CA72D File Offset: 0x001C892D
		public unsafe int ServerPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerPort) = value;
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x060137D5 RID: 79829 RVA: 0x001CA73E File Offset: 0x001C893E
		// (set) Token: 0x060137D6 RID: 79830 RVA: 0x001CA752 File Offset: 0x001C8952
		public unsafe string ServerPipeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerPipeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ServerPipeName)), value);
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x060137D7 RID: 79831 RVA: 0x001CA767 File Offset: 0x001C8967
		// (set) Token: 0x060137D8 RID: 79832 RVA: 0x001CA777 File Offset: 0x001C8977
		public unsafe bool bStartAutomaticServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bStartAutomaticServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bStartAutomaticServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x060137D9 RID: 79833 RVA: 0x001CA788 File Offset: 0x001C8988
		// (set) Token: 0x060137DA RID: 79834 RVA: 0x001CA798 File Offset: 0x001C8998
		public unsafe float AutomaticServerTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_AutomaticServerTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_AutomaticServerTimeout) = value;
			}
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x060137DB RID: 79835 RVA: 0x001CA7A9 File Offset: 0x001C89A9
		// (set) Token: 0x060137DC RID: 79836 RVA: 0x001CA7B9 File Offset: 0x001C89B9
		public unsafe bool bSyncWithHoudiniCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncWithHoudiniCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncWithHoudiniCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x060137DD RID: 79837 RVA: 0x001CA7CA File Offset: 0x001C89CA
		// (set) Token: 0x060137DE RID: 79838 RVA: 0x001CA7DA File Offset: 0x001C89DA
		public unsafe bool bCookUsingHoudiniTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bCookUsingHoudiniTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bCookUsingHoudiniTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x060137DF RID: 79839 RVA: 0x001CA7EB File Offset: 0x001C89EB
		// (set) Token: 0x060137E0 RID: 79840 RVA: 0x001CA7FB File Offset: 0x001C89FB
		public unsafe bool bSyncViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x060137E1 RID: 79841 RVA: 0x001CA80C File Offset: 0x001C8A0C
		// (set) Token: 0x060137E2 RID: 79842 RVA: 0x001CA81C File Offset: 0x001C8A1C
		public unsafe bool bSyncHoudiniViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncHoudiniViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncHoudiniViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x060137E3 RID: 79843 RVA: 0x001CA82D File Offset: 0x001C8A2D
		// (set) Token: 0x060137E4 RID: 79844 RVA: 0x001CA83D File Offset: 0x001C8A3D
		public unsafe bool bSyncUnrealViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncUnrealViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSyncUnrealViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x060137E5 RID: 79845 RVA: 0x001CA84E File Offset: 0x001C8A4E
		// (set) Token: 0x060137E6 RID: 79846 RVA: 0x001CA85E File Offset: 0x001C8A5E
		public unsafe bool bShowMultiAssetDialog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bShowMultiAssetDialog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bShowMultiAssetDialog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x060137E7 RID: 79847 RVA: 0x001CA86F File Offset: 0x001C8A6F
		// (set) Token: 0x060137E8 RID: 79848 RVA: 0x001CA87F File Offset: 0x001C8A7F
		public unsafe bool bPreferHdaMemoryCopyOverHdaSourceFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPreferHdaMemoryCopyOverHdaSourceFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPreferHdaMemoryCopyOverHdaSourceFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x060137E9 RID: 79849 RVA: 0x001CA890 File Offset: 0x001C8A90
		// (set) Token: 0x060137EA RID: 79850 RVA: 0x001CA8A0 File Offset: 0x001C8AA0
		public unsafe bool bPauseCookingOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPauseCookingOnStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPauseCookingOnStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x060137EB RID: 79851 RVA: 0x001CA8B1 File Offset: 0x001C8AB1
		// (set) Token: 0x060137EC RID: 79852 RVA: 0x001CA8C1 File Offset: 0x001C8AC1
		public unsafe bool bDisplaySlateCookingNotifications
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bDisplaySlateCookingNotifications) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bDisplaySlateCookingNotifications) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x060137ED RID: 79853 RVA: 0x001CA8D2 File Offset: 0x001C8AD2
		// (set) Token: 0x060137EE RID: 79854 RVA: 0x001CA8E6 File Offset: 0x001C8AE6
		public unsafe string DefaultTemporaryCookFolder
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultTemporaryCookFolder)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultTemporaryCookFolder)), value);
			}
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x060137EF RID: 79855 RVA: 0x001CA8FB File Offset: 0x001C8AFB
		// (set) Token: 0x060137F0 RID: 79856 RVA: 0x001CA90F File Offset: 0x001C8B0F
		public unsafe string DefaultBakeFolder
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultBakeFolder)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultBakeFolder)), value);
			}
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x060137F1 RID: 79857 RVA: 0x001CA924 File Offset: 0x001C8B24
		// (set) Token: 0x060137F2 RID: 79858 RVA: 0x001CA934 File Offset: 0x001C8B34
		public unsafe bool bEnableTheReferenceCountedInputSystem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableTheReferenceCountedInputSystem) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableTheReferenceCountedInputSystem) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x060137F3 RID: 79859 RVA: 0x001CA945 File Offset: 0x001C8B45
		// (set) Token: 0x060137F4 RID: 79860 RVA: 0x001CA955 File Offset: 0x001C8B55
		public unsafe bool MarshallingLandscapesUseDefaultUnrealScaling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesUseDefaultUnrealScaling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesUseDefaultUnrealScaling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x060137F5 RID: 79861 RVA: 0x001CA966 File Offset: 0x001C8B66
		// (set) Token: 0x060137F6 RID: 79862 RVA: 0x001CA976 File Offset: 0x001C8B76
		public unsafe bool MarshallingLandscapesUseFullResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesUseFullResolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesUseFullResolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x060137F7 RID: 79863 RVA: 0x001CA987 File Offset: 0x001C8B87
		// (set) Token: 0x060137F8 RID: 79864 RVA: 0x001CA997 File Offset: 0x001C8B97
		public unsafe bool MarshallingLandscapesForceMinMaxValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForceMinMaxValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForceMinMaxValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x060137F9 RID: 79865 RVA: 0x001CA9A8 File Offset: 0x001C8BA8
		// (set) Token: 0x060137FA RID: 79866 RVA: 0x001CA9B8 File Offset: 0x001C8BB8
		public unsafe float MarshallingLandscapesForcedMinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForcedMinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForcedMinValue) = value;
			}
		}

		// Token: 0x17004C45 RID: 19525
		// (get) Token: 0x060137FB RID: 79867 RVA: 0x001CA9C9 File Offset: 0x001C8BC9
		// (set) Token: 0x060137FC RID: 79868 RVA: 0x001CA9D9 File Offset: 0x001C8BD9
		public unsafe float MarshallingLandscapesForcedMaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForcedMaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingLandscapesForcedMaxValue) = value;
			}
		}

		// Token: 0x17004C46 RID: 19526
		// (get) Token: 0x060137FD RID: 79869 RVA: 0x001CA9EA File Offset: 0x001C8BEA
		// (set) Token: 0x060137FE RID: 79870 RVA: 0x001CA9FA File Offset: 0x001C8BFA
		public unsafe bool bAddRotAndScaleAttributesOnCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bAddRotAndScaleAttributesOnCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bAddRotAndScaleAttributesOnCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C47 RID: 19527
		// (get) Token: 0x060137FF RID: 79871 RVA: 0x001CAA0B File Offset: 0x001C8C0B
		// (set) Token: 0x06013800 RID: 79872 RVA: 0x001CAA1B File Offset: 0x001C8C1B
		public unsafe bool bUseLegacyInputCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseLegacyInputCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseLegacyInputCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x06013801 RID: 79873 RVA: 0x001CAA2C File Offset: 0x001C8C2C
		// (set) Token: 0x06013802 RID: 79874 RVA: 0x001CAA3C File Offset: 0x001C8C3C
		public unsafe float MarshallingSplineResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingSplineResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MarshallingSplineResolution) = value;
			}
		}

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x06013803 RID: 79875 RVA: 0x001CAA4D File Offset: 0x001C8C4D
		// (set) Token: 0x06013804 RID: 79876 RVA: 0x001CAA5D File Offset: 0x001C8C5D
		public unsafe bool bEnableProxyStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x06013805 RID: 79877 RVA: 0x001CAA6E File Offset: 0x001C8C6E
		// (set) Token: 0x06013806 RID: 79878 RVA: 0x001CAA7E File Offset: 0x001C8C7E
		public unsafe bool bShowDefaultMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bShowDefaultMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bShowDefaultMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x06013807 RID: 79879 RVA: 0x001CAA8F File Offset: 0x001C8C8F
		// (set) Token: 0x06013808 RID: 79880 RVA: 0x001CAA9F File Offset: 0x001C8C9F
		public unsafe bool bEnableProxyStaticMeshRefinementByTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementByTimer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementByTimer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x06013809 RID: 79881 RVA: 0x001CAAB0 File Offset: 0x001C8CB0
		// (set) Token: 0x0601380A RID: 79882 RVA: 0x001CAAC0 File Offset: 0x001C8CC0
		public unsafe float ProxyMeshAutoRefineTimeoutSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ProxyMeshAutoRefineTimeoutSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ProxyMeshAutoRefineTimeoutSeconds) = value;
			}
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x0601380B RID: 79883 RVA: 0x001CAAD1 File Offset: 0x001C8CD1
		// (set) Token: 0x0601380C RID: 79884 RVA: 0x001CAAE1 File Offset: 0x001C8CE1
		public unsafe bool bEnableProxyStaticMeshRefinementOnPreSaveWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorld) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorld) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x0601380D RID: 79885 RVA: 0x001CAAF2 File Offset: 0x001C8CF2
		// (set) Token: 0x0601380E RID: 79886 RVA: 0x001CAB02 File Offset: 0x001C8D02
		public unsafe bool bEnableProxyStaticMeshRefinementOnPreBeginPIE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIE) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x0601380F RID: 79887 RVA: 0x001CAB13 File Offset: 0x001C8D13
		// (set) Token: 0x06013810 RID: 79888 RVA: 0x001CAB2C File Offset: 0x001C8D2C
		public unsafe bool bDoubleSidedGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bDoubleSidedGeometry) & UHoudiniRuntimeSettings.__PropertyMask_bDoubleSidedGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bDoubleSidedGeometry) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bDoubleSidedGeometry) & ~UHoudiniRuntimeSettings.__PropertyMask_bDoubleSidedGeometry) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bDoubleSidedGeometry : 0));
			}
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x06013811 RID: 79889 RVA: 0x001CAB5C File Offset: 0x001C8D5C
		// (set) Token: 0x06013812 RID: 79890 RVA: 0x001CAB70 File Offset: 0x001C8D70
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniRuntimeSettings.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniRuntimeSettings.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x06013813 RID: 79891 RVA: 0x001CAB88 File Offset: 0x001C8D88
		// (set) Token: 0x06013814 RID: 79892 RVA: 0x001CABC1 File Offset: 0x001C8DC1
		public FBodyInstance DefaultBodyInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._DefaultBodyInstance) == null)
				{
					result = (this._DefaultBodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultBodyInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DefaultBodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x06013815 RID: 79893 RVA: 0x001CABE2 File Offset: 0x001C8DE2
		// (set) Token: 0x06013816 RID: 79894 RVA: 0x001CABF6 File Offset: 0x001C8DF6
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionTraceFlag> CollisionTraceFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CollisionTraceFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CollisionTraceFlag) = value;
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x06013817 RID: 79895 RVA: 0x001CAC0B File Offset: 0x001C8E0B
		// (set) Token: 0x06013818 RID: 79896 RVA: 0x001CAC1B File Offset: 0x001C8E1B
		public unsafe int LightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LightMapResolution) = value;
			}
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x06013819 RID: 79897 RVA: 0x001CAC2C File Offset: 0x001C8E2C
		// (set) Token: 0x0601381A RID: 79898 RVA: 0x001CAC3C File Offset: 0x001C8E3C
		public unsafe float LpvBiasMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LpvBiasMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LpvBiasMultiplier) = value;
			}
		}

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x0601381B RID: 79899 RVA: 0x001CAC4D File Offset: 0x001C8E4D
		// (set) Token: 0x0601381C RID: 79900 RVA: 0x001CAC5D File Offset: 0x001C8E5D
		public unsafe float GeneratedDistanceFieldResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_GeneratedDistanceFieldResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_GeneratedDistanceFieldResolutionScale) = value;
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x0601381D RID: 79901 RVA: 0x001CAC70 File Offset: 0x001C8E70
		// (set) Token: 0x0601381E RID: 79902 RVA: 0x001CACA9 File Offset: 0x001C8EA9
		public FWalkableSlopeOverride WalkableSlopeOverride
		{
			get
			{
				base.FastCheckIsValid();
				FWalkableSlopeOverride result;
				if ((result = this._WalkableSlopeOverride) == null)
				{
					result = (this._WalkableSlopeOverride = new FWalkableSlopeOverride(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_WalkableSlopeOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWalkableSlopeOverride.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_WalkableSlopeOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x0601381F RID: 79903 RVA: 0x001CACCA File Offset: 0x001C8ECA
		// (set) Token: 0x06013820 RID: 79904 RVA: 0x001CACDA File Offset: 0x001C8EDA
		public unsafe int LightMapCoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LightMapCoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_LightMapCoordinateIndex) = value;
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x06013821 RID: 79905 RVA: 0x001CACEB File Offset: 0x001C8EEB
		// (set) Token: 0x06013822 RID: 79906 RVA: 0x001CAD04 File Offset: 0x001C8F04
		public unsafe bool bUseMaximumStreamingTexelRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseMaximumStreamingTexelRatio) & UHoudiniRuntimeSettings.__PropertyMask_bUseMaximumStreamingTexelRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseMaximumStreamingTexelRatio) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseMaximumStreamingTexelRatio) & ~UHoudiniRuntimeSettings.__PropertyMask_bUseMaximumStreamingTexelRatio) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bUseMaximumStreamingTexelRatio : 0));
			}
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x06013823 RID: 79907 RVA: 0x001CAD34 File Offset: 0x001C8F34
		// (set) Token: 0x06013824 RID: 79908 RVA: 0x001CAD44 File Offset: 0x001C8F44
		public unsafe float StreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_StreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_StreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x06013825 RID: 79909 RVA: 0x001CAD55 File Offset: 0x001C8F55
		// (set) Token: 0x06013826 RID: 79910 RVA: 0x001CAD69 File Offset: 0x001C8F69
		[Nullable(2)]
		public unsafe UFoliageType_InstancedStaticMesh FoliageDefaultSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType_InstancedStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniRuntimeSettings.__PropertyOffset_FoliageDefaultSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniRuntimeSettings.__PropertyOffset_FoliageDefaultSettings, value);
			}
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x06013827 RID: 79911 RVA: 0x001CAD80 File Offset: 0x001C8F80
		// (set) Token: 0x06013828 RID: 79912 RVA: 0x001CADB9 File Offset: 0x001C8FB9
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x06013829 RID: 79913 RVA: 0x001CADC7 File Offset: 0x001C8FC7
		// (set) Token: 0x0601382A RID: 79914 RVA: 0x001CADD7 File Offset: 0x001C8FD7
		public unsafe bool bUseFullPrecisionUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseFullPrecisionUVs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseFullPrecisionUVs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x0601382B RID: 79915 RVA: 0x001CADE8 File Offset: 0x001C8FE8
		// (set) Token: 0x0601382C RID: 79916 RVA: 0x001CADF8 File Offset: 0x001C8FF8
		public unsafe int SrcLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_SrcLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_SrcLightmapIndex) = value;
			}
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x0601382D RID: 79917 RVA: 0x001CAE09 File Offset: 0x001C9009
		// (set) Token: 0x0601382E RID: 79918 RVA: 0x001CAE19 File Offset: 0x001C9019
		public unsafe int DstLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DstLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DstLightmapIndex) = value;
			}
		}

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x0601382F RID: 79919 RVA: 0x001CAE2A File Offset: 0x001C902A
		// (set) Token: 0x06013830 RID: 79920 RVA: 0x001CAE3A File Offset: 0x001C903A
		public unsafe int MinLightmapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MinLightmapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_MinLightmapResolution) = value;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x06013831 RID: 79921 RVA: 0x001CAE4B File Offset: 0x001C904B
		// (set) Token: 0x06013832 RID: 79922 RVA: 0x001CAE5B File Offset: 0x001C905B
		public unsafe bool bRemoveDegenerates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bRemoveDegenerates) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bRemoveDegenerates) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x06013833 RID: 79923 RVA: 0x001CAE6C File Offset: 0x001C906C
		// (set) Token: 0x06013834 RID: 79924 RVA: 0x001CAE80 File Offset: 0x001C9080
		[Nullable(0)]
		public unsafe TEnumAsByte<EHoudiniRuntimeSettingsRecomputeFlag> GenerateLightmapUVsFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_GenerateLightmapUVsFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_GenerateLightmapUVsFlag) = value;
			}
		}

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x06013835 RID: 79925 RVA: 0x001CAE95 File Offset: 0x001C9095
		// (set) Token: 0x06013836 RID: 79926 RVA: 0x001CAEA9 File Offset: 0x001C90A9
		[Nullable(0)]
		public unsafe TEnumAsByte<EHoudiniRuntimeSettingsRecomputeFlag> RecomputeNormalsFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_RecomputeNormalsFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_RecomputeNormalsFlag) = value;
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x06013837 RID: 79927 RVA: 0x001CAEBE File Offset: 0x001C90BE
		// (set) Token: 0x06013838 RID: 79928 RVA: 0x001CAED2 File Offset: 0x001C90D2
		[Nullable(0)]
		public unsafe TEnumAsByte<EHoudiniRuntimeSettingsRecomputeFlag> RecomputeTangentsFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_RecomputeTangentsFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_RecomputeTangentsFlag) = value;
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x06013839 RID: 79929 RVA: 0x001CAEE7 File Offset: 0x001C90E7
		// (set) Token: 0x0601383A RID: 79930 RVA: 0x001CAEF7 File Offset: 0x001C90F7
		public unsafe bool bUseMikkTSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseMikkTSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseMikkTSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x0601383B RID: 79931 RVA: 0x001CAF08 File Offset: 0x001C9108
		// (set) Token: 0x0601383C RID: 79932 RVA: 0x001CAF18 File Offset: 0x001C9118
		public unsafe bool bBuildAdjacencyBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bBuildAdjacencyBuffer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bBuildAdjacencyBuffer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x0601383D RID: 79933 RVA: 0x001CAF29 File Offset: 0x001C9129
		// (set) Token: 0x0601383E RID: 79934 RVA: 0x001CAF42 File Offset: 0x001C9142
		public unsafe bool bComputeWeightedNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bComputeWeightedNormals) & UHoudiniRuntimeSettings.__PropertyMask_bComputeWeightedNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bComputeWeightedNormals) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bComputeWeightedNormals) & ~UHoudiniRuntimeSettings.__PropertyMask_bComputeWeightedNormals) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bComputeWeightedNormals : 0));
			}
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x0601383F RID: 79935 RVA: 0x001CAF72 File Offset: 0x001C9172
		// (set) Token: 0x06013840 RID: 79936 RVA: 0x001CAF8B File Offset: 0x001C918B
		public unsafe bool bBuildReversedIndexBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bBuildReversedIndexBuffer) & UHoudiniRuntimeSettings.__PropertyMask_bBuildReversedIndexBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bBuildReversedIndexBuffer) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bBuildReversedIndexBuffer) & ~UHoudiniRuntimeSettings.__PropertyMask_bBuildReversedIndexBuffer) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bBuildReversedIndexBuffer : 0));
			}
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x06013841 RID: 79937 RVA: 0x001CAFBB File Offset: 0x001C91BB
		// (set) Token: 0x06013842 RID: 79938 RVA: 0x001CAFD4 File Offset: 0x001C91D4
		public unsafe bool bUseHighPrecisionTangentBasis
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & UHoudiniRuntimeSettings.__PropertyMask_bUseHighPrecisionTangentBasis) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & ~UHoudiniRuntimeSettings.__PropertyMask_bUseHighPrecisionTangentBasis) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bUseHighPrecisionTangentBasis : 0));
			}
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x06013843 RID: 79939 RVA: 0x001CB004 File Offset: 0x001C9204
		// (set) Token: 0x06013844 RID: 79940 RVA: 0x001CB014 File Offset: 0x001C9214
		public unsafe float DistanceFieldResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DistanceFieldResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DistanceFieldResolutionScale) = value;
			}
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x06013845 RID: 79941 RVA: 0x001CB025 File Offset: 0x001C9225
		// (set) Token: 0x06013846 RID: 79942 RVA: 0x001CB03E File Offset: 0x001C923E
		public unsafe bool bGenerateDistanceFieldAsIfTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & UHoudiniRuntimeSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & ~UHoudiniRuntimeSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided : 0));
			}
		}

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x06013847 RID: 79943 RVA: 0x001CB06E File Offset: 0x001C926E
		// (set) Token: 0x06013848 RID: 79944 RVA: 0x001CB087 File Offset: 0x001C9287
		public unsafe bool bSupportFaceRemap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSupportFaceRemap) & UHoudiniRuntimeSettings.__PropertyMask_bSupportFaceRemap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSupportFaceRemap) = ((*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bSupportFaceRemap) & ~UHoudiniRuntimeSettings.__PropertyMask_bSupportFaceRemap) | (value ? UHoudiniRuntimeSettings.__PropertyMask_bSupportFaceRemap : 0));
			}
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x06013849 RID: 79945 RVA: 0x001CB0B7 File Offset: 0x001C92B7
		// (set) Token: 0x0601384A RID: 79946 RVA: 0x001CB0C7 File Offset: 0x001C92C7
		public unsafe bool bPDGAsyncCommandletImportEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPDGAsyncCommandletImportEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bPDGAsyncCommandletImportEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x0601384B RID: 79947 RVA: 0x001CB0D8 File Offset: 0x001C92D8
		// (set) Token: 0x0601384C RID: 79948 RVA: 0x001CB0E8 File Offset: 0x001C92E8
		public unsafe bool bEnableBackwardCompatibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableBackwardCompatibility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bEnableBackwardCompatibility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x0601384D RID: 79949 RVA: 0x001CB0F9 File Offset: 0x001C92F9
		// (set) Token: 0x0601384E RID: 79950 RVA: 0x001CB109 File Offset: 0x001C9309
		public unsafe bool bAutomaticLegacyHDARebuild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bAutomaticLegacyHDARebuild) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bAutomaticLegacyHDARebuild) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x0601384F RID: 79951 RVA: 0x001CB11A File Offset: 0x001C931A
		// (set) Token: 0x06013850 RID: 79952 RVA: 0x001CB12A File Offset: 0x001C932A
		public unsafe bool bUseCustomHoudiniLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseCustomHoudiniLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_bUseCustomHoudiniLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x06013851 RID: 79953 RVA: 0x001CB13C File Offset: 0x001C933C
		// (set) Token: 0x06013852 RID: 79954 RVA: 0x001CB175 File Offset: 0x001C9375
		public FDirectoryPath CustomHoudiniLocation
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._CustomHoudiniLocation) == null)
				{
					result = (this._CustomHoudiniLocation = new FDirectoryPath(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CustomHoudiniLocation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CustomHoudiniLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x06013853 RID: 79955 RVA: 0x001CB196 File Offset: 0x001C9396
		// (set) Token: 0x06013854 RID: 79956 RVA: 0x001CB1AA File Offset: 0x001C93AA
		[Nullable(0)]
		public unsafe TEnumAsByte<EHoudiniExecutableType> HoudiniExecutable
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_HoudiniExecutable);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_HoudiniExecutable) = value;
			}
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x06013855 RID: 79957 RVA: 0x001CB1BF File Offset: 0x001C93BF
		// (set) Token: 0x06013856 RID: 79958 RVA: 0x001CB1CF File Offset: 0x001C93CF
		public unsafe int CookingThreadStackSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CookingThreadStackSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_CookingThreadStackSize) = value;
			}
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x06013857 RID: 79959 RVA: 0x001CB1E0 File Offset: 0x001C93E0
		// (set) Token: 0x06013858 RID: 79960 RVA: 0x001CB1F4 File Offset: 0x001C93F4
		public unsafe string HoudiniEnvironmentFiles
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_HoudiniEnvironmentFiles)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_HoudiniEnvironmentFiles)), value);
			}
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x06013859 RID: 79961 RVA: 0x001CB209 File Offset: 0x001C9409
		// (set) Token: 0x0601385A RID: 79962 RVA: 0x001CB21D File Offset: 0x001C941D
		public unsafe string OtlSearchPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_OtlSearchPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_OtlSearchPath)), value);
			}
		}

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x0601385B RID: 79963 RVA: 0x001CB232 File Offset: 0x001C9432
		// (set) Token: 0x0601385C RID: 79964 RVA: 0x001CB246 File Offset: 0x001C9446
		public unsafe string DsoSearchPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DsoSearchPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_DsoSearchPath)), value);
			}
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x0601385D RID: 79965 RVA: 0x001CB25B File Offset: 0x001C945B
		// (set) Token: 0x0601385E RID: 79966 RVA: 0x001CB26F File Offset: 0x001C946F
		public unsafe string ImageDsoSearchPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ImageDsoSearchPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_ImageDsoSearchPath)), value);
			}
		}

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x0601385F RID: 79967 RVA: 0x001CB284 File Offset: 0x001C9484
		// (set) Token: 0x06013860 RID: 79968 RVA: 0x001CB298 File Offset: 0x001C9498
		public unsafe string AudioDsoSearchPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_AudioDsoSearchPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniRuntimeSettings.__PropertyOffset_AudioDsoSearchPath)), value);
			}
		}

		// Token: 0x06013861 RID: 79969 RVA: 0x001CB2AD File Offset: 0x001C94AD
		static UHoudiniRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniRuntimeSettings");
		}

		// Token: 0x06013862 RID: 79970 RVA: 0x001CB2BB File Offset: 0x001C94BB
		protected UHoudiniRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A88F RID: 43151
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniRuntimeSettings";

		// Token: 0x0400A890 RID: 43152
		private static IntPtr _ClassPtr;

		// Token: 0x0400A891 RID: 43153
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A892 RID: 43154
		internal static int __PropertyOffset_SessionType;

		// Token: 0x0400A893 RID: 43155
		internal static int __PropertyOffset_ServerHost;

		// Token: 0x0400A894 RID: 43156
		internal static int __PropertyOffset_ServerPort;

		// Token: 0x0400A895 RID: 43157
		internal static int __PropertyOffset_ServerPipeName;

		// Token: 0x0400A896 RID: 43158
		internal static int __PropertyOffset_bStartAutomaticServer;

		// Token: 0x0400A897 RID: 43159
		internal static int __PropertyOffset_AutomaticServerTimeout;

		// Token: 0x0400A898 RID: 43160
		internal static int __PropertyOffset_bSyncWithHoudiniCook;

		// Token: 0x0400A899 RID: 43161
		internal static int __PropertyOffset_bCookUsingHoudiniTime;

		// Token: 0x0400A89A RID: 43162
		internal static int __PropertyOffset_bSyncViewport;

		// Token: 0x0400A89B RID: 43163
		internal static int __PropertyOffset_bSyncHoudiniViewport;

		// Token: 0x0400A89C RID: 43164
		internal static int __PropertyOffset_bSyncUnrealViewport;

		// Token: 0x0400A89D RID: 43165
		internal static int __PropertyOffset_bShowMultiAssetDialog;

		// Token: 0x0400A89E RID: 43166
		internal static int __PropertyOffset_bPreferHdaMemoryCopyOverHdaSourceFile;

		// Token: 0x0400A89F RID: 43167
		internal static int __PropertyOffset_bPauseCookingOnStart;

		// Token: 0x0400A8A0 RID: 43168
		internal static int __PropertyOffset_bDisplaySlateCookingNotifications;

		// Token: 0x0400A8A1 RID: 43169
		internal static int __PropertyOffset_DefaultTemporaryCookFolder;

		// Token: 0x0400A8A2 RID: 43170
		internal static int __PropertyOffset_DefaultBakeFolder;

		// Token: 0x0400A8A3 RID: 43171
		internal static int __PropertyOffset_bEnableTheReferenceCountedInputSystem;

		// Token: 0x0400A8A4 RID: 43172
		internal static int __PropertyOffset_MarshallingLandscapesUseDefaultUnrealScaling;

		// Token: 0x0400A8A5 RID: 43173
		internal static int __PropertyOffset_MarshallingLandscapesUseFullResolution;

		// Token: 0x0400A8A6 RID: 43174
		internal static int __PropertyOffset_MarshallingLandscapesForceMinMaxValues;

		// Token: 0x0400A8A7 RID: 43175
		internal static int __PropertyOffset_MarshallingLandscapesForcedMinValue;

		// Token: 0x0400A8A8 RID: 43176
		internal static int __PropertyOffset_MarshallingLandscapesForcedMaxValue;

		// Token: 0x0400A8A9 RID: 43177
		internal static int __PropertyOffset_bAddRotAndScaleAttributesOnCurves;

		// Token: 0x0400A8AA RID: 43178
		internal static int __PropertyOffset_bUseLegacyInputCurves;

		// Token: 0x0400A8AB RID: 43179
		internal static int __PropertyOffset_MarshallingSplineResolution;

		// Token: 0x0400A8AC RID: 43180
		internal static int __PropertyOffset_bEnableProxyStaticMesh;

		// Token: 0x0400A8AD RID: 43181
		internal static int __PropertyOffset_bShowDefaultMesh;

		// Token: 0x0400A8AE RID: 43182
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementByTimer;

		// Token: 0x0400A8AF RID: 43183
		internal static int __PropertyOffset_ProxyMeshAutoRefineTimeoutSeconds;

		// Token: 0x0400A8B0 RID: 43184
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorld;

		// Token: 0x0400A8B1 RID: 43185
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIE;

		// Token: 0x0400A8B2 RID: 43186
		internal static int __PropertyOffset_bDoubleSidedGeometry;

		// Token: 0x0400A8B3 RID: 43187
		internal static byte __PropertyMask_bDoubleSidedGeometry;

		// Token: 0x0400A8B4 RID: 43188
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x0400A8B5 RID: 43189
		internal static int __PropertyOffset_DefaultBodyInstance;

		// Token: 0x0400A8B6 RID: 43190
		[Nullable(2)]
		private FBodyInstance _DefaultBodyInstance;

		// Token: 0x0400A8B7 RID: 43191
		internal static int __PropertyOffset_CollisionTraceFlag;

		// Token: 0x0400A8B8 RID: 43192
		internal static int __PropertyOffset_LightMapResolution;

		// Token: 0x0400A8B9 RID: 43193
		internal static int __PropertyOffset_LpvBiasMultiplier;

		// Token: 0x0400A8BA RID: 43194
		internal static int __PropertyOffset_GeneratedDistanceFieldResolutionScale;

		// Token: 0x0400A8BB RID: 43195
		internal static int __PropertyOffset_WalkableSlopeOverride;

		// Token: 0x0400A8BC RID: 43196
		[Nullable(2)]
		private FWalkableSlopeOverride _WalkableSlopeOverride;

		// Token: 0x0400A8BD RID: 43197
		internal static int __PropertyOffset_LightMapCoordinateIndex;

		// Token: 0x0400A8BE RID: 43198
		internal static int __PropertyOffset_bUseMaximumStreamingTexelRatio;

		// Token: 0x0400A8BF RID: 43199
		internal static byte __PropertyMask_bUseMaximumStreamingTexelRatio;

		// Token: 0x0400A8C0 RID: 43200
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x0400A8C1 RID: 43201
		internal static int __PropertyOffset_FoliageDefaultSettings;

		// Token: 0x0400A8C2 RID: 43202
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x0400A8C3 RID: 43203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x0400A8C4 RID: 43204
		internal static int __PropertyOffset_bUseFullPrecisionUVs;

		// Token: 0x0400A8C5 RID: 43205
		internal static int __PropertyOffset_SrcLightmapIndex;

		// Token: 0x0400A8C6 RID: 43206
		internal static int __PropertyOffset_DstLightmapIndex;

		// Token: 0x0400A8C7 RID: 43207
		internal static int __PropertyOffset_MinLightmapResolution;

		// Token: 0x0400A8C8 RID: 43208
		internal static int __PropertyOffset_bRemoveDegenerates;

		// Token: 0x0400A8C9 RID: 43209
		internal static int __PropertyOffset_GenerateLightmapUVsFlag;

		// Token: 0x0400A8CA RID: 43210
		internal static int __PropertyOffset_RecomputeNormalsFlag;

		// Token: 0x0400A8CB RID: 43211
		internal static int __PropertyOffset_RecomputeTangentsFlag;

		// Token: 0x0400A8CC RID: 43212
		internal static int __PropertyOffset_bUseMikkTSpace;

		// Token: 0x0400A8CD RID: 43213
		internal static int __PropertyOffset_bBuildAdjacencyBuffer;

		// Token: 0x0400A8CE RID: 43214
		internal static int __PropertyOffset_bComputeWeightedNormals;

		// Token: 0x0400A8CF RID: 43215
		internal static byte __PropertyMask_bComputeWeightedNormals;

		// Token: 0x0400A8D0 RID: 43216
		internal static int __PropertyOffset_bBuildReversedIndexBuffer;

		// Token: 0x0400A8D1 RID: 43217
		internal static byte __PropertyMask_bBuildReversedIndexBuffer;

		// Token: 0x0400A8D2 RID: 43218
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis;

		// Token: 0x0400A8D3 RID: 43219
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis;

		// Token: 0x0400A8D4 RID: 43220
		internal static int __PropertyOffset_DistanceFieldResolutionScale;

		// Token: 0x0400A8D5 RID: 43221
		internal static int __PropertyOffset_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x0400A8D6 RID: 43222
		internal static byte __PropertyMask_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x0400A8D7 RID: 43223
		internal static int __PropertyOffset_bSupportFaceRemap;

		// Token: 0x0400A8D8 RID: 43224
		internal static byte __PropertyMask_bSupportFaceRemap;

		// Token: 0x0400A8D9 RID: 43225
		internal static int __PropertyOffset_bPDGAsyncCommandletImportEnabled;

		// Token: 0x0400A8DA RID: 43226
		internal static int __PropertyOffset_bEnableBackwardCompatibility;

		// Token: 0x0400A8DB RID: 43227
		internal static int __PropertyOffset_bAutomaticLegacyHDARebuild;

		// Token: 0x0400A8DC RID: 43228
		internal static int __PropertyOffset_bUseCustomHoudiniLocation;

		// Token: 0x0400A8DD RID: 43229
		internal static int __PropertyOffset_CustomHoudiniLocation;

		// Token: 0x0400A8DE RID: 43230
		[Nullable(2)]
		private FDirectoryPath _CustomHoudiniLocation;

		// Token: 0x0400A8DF RID: 43231
		internal static int __PropertyOffset_HoudiniExecutable;

		// Token: 0x0400A8E0 RID: 43232
		internal static int __PropertyOffset_CookingThreadStackSize;

		// Token: 0x0400A8E1 RID: 43233
		internal static int __PropertyOffset_HoudiniEnvironmentFiles;

		// Token: 0x0400A8E2 RID: 43234
		internal static int __PropertyOffset_OtlSearchPath;

		// Token: 0x0400A8E3 RID: 43235
		internal static int __PropertyOffset_DsoSearchPath;

		// Token: 0x0400A8E4 RID: 43236
		internal static int __PropertyOffset_ImageDsoSearchPath;

		// Token: 0x0400A8E5 RID: 43237
		internal static int __PropertyOffset_AudioDsoSearchPath;
	}
}
