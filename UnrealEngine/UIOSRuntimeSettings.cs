using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015AC RID: 5548
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.IOSRuntimeSettings")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UIOSRuntimeSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013F81 RID: 81793 RVA: 0x001D5136 File Offset: 0x001D3336
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIOSRuntimeSettings._ClassPtr;
		}

		// Token: 0x06013F82 RID: 81794 RVA: 0x001D5144 File Offset: 0x001D3344
		public UIOSRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(UIOSRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013F83 RID: 81795 RVA: 0x001D516C File Offset: 0x001D336C
		public UIOSRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIOSRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06013F84 RID: 81796 RVA: 0x001D519F File Offset: 0x001D339F
		// (set) Token: 0x06013F85 RID: 81797 RVA: 0x001D51B8 File Offset: 0x001D33B8
		public unsafe bool bEnableGameCenterSupport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableGameCenterSupport) & UIOSRuntimeSettings.__PropertyMask_bEnableGameCenterSupport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableGameCenterSupport) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableGameCenterSupport) & ~UIOSRuntimeSettings.__PropertyMask_bEnableGameCenterSupport) | (value ? UIOSRuntimeSettings.__PropertyMask_bEnableGameCenterSupport : 0));
			}
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06013F86 RID: 81798 RVA: 0x001D51E8 File Offset: 0x001D33E8
		// (set) Token: 0x06013F87 RID: 81799 RVA: 0x001D5201 File Offset: 0x001D3401
		public unsafe bool bEnableCloudKitSupport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableCloudKitSupport) & UIOSRuntimeSettings.__PropertyMask_bEnableCloudKitSupport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableCloudKitSupport) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableCloudKitSupport) & ~UIOSRuntimeSettings.__PropertyMask_bEnableCloudKitSupport) | (value ? UIOSRuntimeSettings.__PropertyMask_bEnableCloudKitSupport : 0));
			}
		}

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06013F88 RID: 81800 RVA: 0x001D5231 File Offset: 0x001D3431
		// (set) Token: 0x06013F89 RID: 81801 RVA: 0x001D5241 File Offset: 0x001D3441
		public unsafe EIOSCloudKitSyncStrategy IOSCloudKitSyncStrategy
		{
			get
			{
				return (EIOSCloudKitSyncStrategy)(*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_IOSCloudKitSyncStrategy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_IOSCloudKitSyncStrategy) = (byte)value;
			}
		}

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x06013F8A RID: 81802 RVA: 0x001D5252 File Offset: 0x001D3452
		// (set) Token: 0x06013F8B RID: 81803 RVA: 0x001D526B File Offset: 0x001D346B
		public unsafe bool bEnableRemoteNotificationsSupport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableRemoteNotificationsSupport) & UIOSRuntimeSettings.__PropertyMask_bEnableRemoteNotificationsSupport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableRemoteNotificationsSupport) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableRemoteNotificationsSupport) & ~UIOSRuntimeSettings.__PropertyMask_bEnableRemoteNotificationsSupport) | (value ? UIOSRuntimeSettings.__PropertyMask_bEnableRemoteNotificationsSupport : 0));
			}
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x06013F8C RID: 81804 RVA: 0x001D529B File Offset: 0x001D349B
		// (set) Token: 0x06013F8D RID: 81805 RVA: 0x001D52B4 File Offset: 0x001D34B4
		public unsafe bool bEnableBackgroundFetch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableBackgroundFetch) & UIOSRuntimeSettings.__PropertyMask_bEnableBackgroundFetch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableBackgroundFetch) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableBackgroundFetch) & ~UIOSRuntimeSettings.__PropertyMask_bEnableBackgroundFetch) | (value ? UIOSRuntimeSettings.__PropertyMask_bEnableBackgroundFetch : 0));
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x06013F8E RID: 81806 RVA: 0x001D52E4 File Offset: 0x001D34E4
		// (set) Token: 0x06013F8F RID: 81807 RVA: 0x001D52F4 File Offset: 0x001D34F4
		public unsafe bool bSupportsMetal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsMetal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsMetal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x06013F90 RID: 81808 RVA: 0x001D5305 File Offset: 0x001D3505
		// (set) Token: 0x06013F91 RID: 81809 RVA: 0x001D5315 File Offset: 0x001D3515
		public unsafe bool bSupportsMetalMRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsMetalMRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsMetalMRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x06013F92 RID: 81810 RVA: 0x001D5326 File Offset: 0x001D3526
		// (set) Token: 0x06013F93 RID: 81811 RVA: 0x001D5336 File Offset: 0x001D3536
		public unsafe bool bSupportHighRefreshRates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportHighRefreshRates) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportHighRefreshRates) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x06013F94 RID: 81812 RVA: 0x001D5347 File Offset: 0x001D3547
		// (set) Token: 0x06013F95 RID: 81813 RVA: 0x001D5357 File Offset: 0x001D3557
		public unsafe bool bSupportIOSKeepWorkLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportIOSKeepWorkLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportIOSKeepWorkLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x06013F96 RID: 81814 RVA: 0x001D5368 File Offset: 0x001D3568
		// (set) Token: 0x06013F97 RID: 81815 RVA: 0x001D5378 File Offset: 0x001D3578
		public unsafe bool bCookPVRTCTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCookPVRTCTextures) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCookPVRTCTextures) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x06013F98 RID: 81816 RVA: 0x001D5389 File Offset: 0x001D3589
		// (set) Token: 0x06013F99 RID: 81817 RVA: 0x001D5399 File Offset: 0x001D3599
		public unsafe bool bCookASTCTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCookASTCTextures) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCookASTCTextures) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x06013F9A RID: 81818 RVA: 0x001D53AA File Offset: 0x001D35AA
		// (set) Token: 0x06013F9B RID: 81819 RVA: 0x001D53BA File Offset: 0x001D35BA
		public unsafe bool bBuildAsFramework
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bBuildAsFramework) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bBuildAsFramework) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06013F9C RID: 81820 RVA: 0x001D53CC File Offset: 0x001D35CC
		// (set) Token: 0x06013F9D RID: 81821 RVA: 0x001D5405 File Offset: 0x001D3605
		public FIOSBuildResourceDirectory WindowsMetalToolchainOverride
		{
			get
			{
				base.FastCheckIsValid();
				FIOSBuildResourceDirectory result;
				if ((result = this._WindowsMetalToolchainOverride) == null)
				{
					result = (this._WindowsMetalToolchainOverride = new FIOSBuildResourceDirectory(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_WindowsMetalToolchainOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIOSBuildResourceDirectory.StaticStruct(), base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_WindowsMetalToolchainOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06013F9E RID: 81822 RVA: 0x001D5426 File Offset: 0x001D3626
		// (set) Token: 0x06013F9F RID: 81823 RVA: 0x001D5436 File Offset: 0x001D3636
		public unsafe bool bGeneratedSYMFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGeneratedSYMFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGeneratedSYMFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x06013FA0 RID: 81824 RVA: 0x001D5447 File Offset: 0x001D3647
		// (set) Token: 0x06013FA1 RID: 81825 RVA: 0x001D5457 File Offset: 0x001D3657
		public unsafe bool bGeneratedSYMBundle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGeneratedSYMBundle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGeneratedSYMBundle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x06013FA2 RID: 81826 RVA: 0x001D5468 File Offset: 0x001D3668
		// (set) Token: 0x06013FA3 RID: 81827 RVA: 0x001D5478 File Offset: 0x001D3678
		public unsafe bool bGenerateCrashReportSymbols
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGenerateCrashReportSymbols) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGenerateCrashReportSymbols) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x06013FA4 RID: 81828 RVA: 0x001D5489 File Offset: 0x001D3689
		// (set) Token: 0x06013FA5 RID: 81829 RVA: 0x001D5499 File Offset: 0x001D3699
		public unsafe bool bGenerateXCArchive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGenerateXCArchive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGenerateXCArchive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x06013FA6 RID: 81830 RVA: 0x001D54AA File Offset: 0x001D36AA
		// (set) Token: 0x06013FA7 RID: 81831 RVA: 0x001D54BA File Offset: 0x001D36BA
		public unsafe bool bShipForBitcode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bShipForBitcode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bShipForBitcode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x06013FA8 RID: 81832 RVA: 0x001D54CB File Offset: 0x001D36CB
		// (set) Token: 0x06013FA9 RID: 81833 RVA: 0x001D54DB File Offset: 0x001D36DB
		public unsafe bool bEnableAdvertisingIdentifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableAdvertisingIdentifier) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableAdvertisingIdentifier) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x06013FAA RID: 81834 RVA: 0x001D54EC File Offset: 0x001D36EC
		// (set) Token: 0x06013FAB RID: 81835 RVA: 0x001D5500 File Offset: 0x001D3700
		public unsafe string AdditionalLinkerFlags
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalLinkerFlags)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalLinkerFlags)), value);
			}
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x06013FAC RID: 81836 RVA: 0x001D5515 File Offset: 0x001D3715
		// (set) Token: 0x06013FAD RID: 81837 RVA: 0x001D5529 File Offset: 0x001D3729
		public unsafe string AdditionalShippingLinkerFlags
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalShippingLinkerFlags)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalShippingLinkerFlags)), value);
			}
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x06013FAE RID: 81838 RVA: 0x001D553E File Offset: 0x001D373E
		// (set) Token: 0x06013FAF RID: 81839 RVA: 0x001D5552 File Offset: 0x001D3752
		public unsafe string RemoteServerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_RemoteServerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_RemoteServerName)), value);
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x06013FB0 RID: 81840 RVA: 0x001D5567 File Offset: 0x001D3767
		// (set) Token: 0x06013FB1 RID: 81841 RVA: 0x001D5577 File Offset: 0x001D3777
		public unsafe bool bUseRSync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRSync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRSync) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x06013FB2 RID: 81842 RVA: 0x001D5588 File Offset: 0x001D3788
		// (set) Token: 0x06013FB3 RID: 81843 RVA: 0x001D559C File Offset: 0x001D379C
		public unsafe string RSyncUsername
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_RSyncUsername)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_RSyncUsername)), value);
			}
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x06013FB4 RID: 81844 RVA: 0x001D55B4 File Offset: 0x001D37B4
		// (set) Token: 0x06013FB5 RID: 81845 RVA: 0x001D55ED File Offset: 0x001D37ED
		public FIOSBuildResourceDirectory DeltaCopyInstallPath
		{
			get
			{
				base.FastCheckIsValid();
				FIOSBuildResourceDirectory result;
				if ((result = this._DeltaCopyInstallPath) == null)
				{
					result = (this._DeltaCopyInstallPath = new FIOSBuildResourceDirectory(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_DeltaCopyInstallPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIOSBuildResourceDirectory.StaticStruct(), base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_DeltaCopyInstallPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x06013FB6 RID: 81846 RVA: 0x001D560E File Offset: 0x001D380E
		// (set) Token: 0x06013FB7 RID: 81847 RVA: 0x001D5622 File Offset: 0x001D3822
		public unsafe string SSHPrivateKeyLocation
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SSHPrivateKeyLocation)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SSHPrivateKeyLocation)), value);
			}
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x06013FB8 RID: 81848 RVA: 0x001D5638 File Offset: 0x001D3838
		// (set) Token: 0x06013FB9 RID: 81849 RVA: 0x001D5671 File Offset: 0x001D3871
		public FIOSBuildResourceFilePath SSHPrivateKeyOverridePath
		{
			get
			{
				base.FastCheckIsValid();
				FIOSBuildResourceFilePath result;
				if ((result = this._SSHPrivateKeyOverridePath) == null)
				{
					result = (this._SSHPrivateKeyOverridePath = new FIOSBuildResourceFilePath(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_SSHPrivateKeyOverridePath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIOSBuildResourceFilePath.StaticStruct(), base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_SSHPrivateKeyOverridePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x06013FBA RID: 81850 RVA: 0x001D5692 File Offset: 0x001D3892
		// (set) Token: 0x06013FBB RID: 81851 RVA: 0x001D56A2 File Offset: 0x001D38A2
		public unsafe bool bRunAsCurrentUser
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bRunAsCurrentUser) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bRunAsCurrentUser) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x06013FBC RID: 81852 RVA: 0x001D56B3 File Offset: 0x001D38B3
		// (set) Token: 0x06013FBD RID: 81853 RVA: 0x001D56C3 File Offset: 0x001D38C3
		public unsafe bool bGameSupportsMultipleActiveControllers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGameSupportsMultipleActiveControllers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bGameSupportsMultipleActiveControllers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x06013FBE RID: 81854 RVA: 0x001D56D4 File Offset: 0x001D38D4
		// (set) Token: 0x06013FBF RID: 81855 RVA: 0x001D56E4 File Offset: 0x001D38E4
		public unsafe bool bAllowRemoteRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAllowRemoteRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAllowRemoteRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x06013FC0 RID: 81856 RVA: 0x001D56F5 File Offset: 0x001D38F5
		// (set) Token: 0x06013FC1 RID: 81857 RVA: 0x001D5705 File Offset: 0x001D3905
		public unsafe bool bUseRemoteAsVirtualJoystick_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRemoteAsVirtualJoystick_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRemoteAsVirtualJoystick_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x06013FC2 RID: 81858 RVA: 0x001D5716 File Offset: 0x001D3916
		// (set) Token: 0x06013FC3 RID: 81859 RVA: 0x001D5726 File Offset: 0x001D3926
		public unsafe bool bUseRemoteAbsoluteDpadValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRemoteAbsoluteDpadValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseRemoteAbsoluteDpadValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x06013FC4 RID: 81860 RVA: 0x001D5737 File Offset: 0x001D3937
		// (set) Token: 0x06013FC5 RID: 81861 RVA: 0x001D5747 File Offset: 0x001D3947
		public unsafe bool bAllowControllers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAllowControllers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAllowControllers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x06013FC6 RID: 81862 RVA: 0x001D5758 File Offset: 0x001D3958
		// (set) Token: 0x06013FC7 RID: 81863 RVA: 0x001D5768 File Offset: 0x001D3968
		public unsafe bool bControllersBlockDeviceFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bControllersBlockDeviceFeedback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bControllersBlockDeviceFeedback) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x06013FC8 RID: 81864 RVA: 0x001D5779 File Offset: 0x001D3979
		// (set) Token: 0x06013FC9 RID: 81865 RVA: 0x001D5789 File Offset: 0x001D3989
		public unsafe bool bDisableMotionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bDisableMotionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bDisableMotionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x06013FCA RID: 81866 RVA: 0x001D579A File Offset: 0x001D399A
		// (set) Token: 0x06013FCB RID: 81867 RVA: 0x001D57B3 File Offset: 0x001D39B3
		public unsafe bool bSupportsPortraitOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsPortraitOrientation) & UIOSRuntimeSettings.__PropertyMask_bSupportsPortraitOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsPortraitOrientation) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsPortraitOrientation) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsPortraitOrientation) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsPortraitOrientation : 0));
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x06013FCC RID: 81868 RVA: 0x001D57E3 File Offset: 0x001D39E3
		// (set) Token: 0x06013FCD RID: 81869 RVA: 0x001D57FC File Offset: 0x001D39FC
		public unsafe bool bSupportsUpsideDownOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsUpsideDownOrientation) & UIOSRuntimeSettings.__PropertyMask_bSupportsUpsideDownOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsUpsideDownOrientation) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsUpsideDownOrientation) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsUpsideDownOrientation) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsUpsideDownOrientation : 0));
			}
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x06013FCE RID: 81870 RVA: 0x001D582C File Offset: 0x001D3A2C
		// (set) Token: 0x06013FCF RID: 81871 RVA: 0x001D5845 File Offset: 0x001D3A45
		public unsafe bool bSupportsLandscapeLeftOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeLeftOrientation) & UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeLeftOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeLeftOrientation) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeLeftOrientation) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeLeftOrientation) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeLeftOrientation : 0));
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x06013FD0 RID: 81872 RVA: 0x001D5875 File Offset: 0x001D3A75
		// (set) Token: 0x06013FD1 RID: 81873 RVA: 0x001D588E File Offset: 0x001D3A8E
		public unsafe bool bSupportsLandscapeRightOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeRightOrientation) & UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeRightOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeRightOrientation) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsLandscapeRightOrientation) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeRightOrientation) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsLandscapeRightOrientation : 0));
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x06013FD2 RID: 81874 RVA: 0x001D58BE File Offset: 0x001D3ABE
		// (set) Token: 0x06013FD3 RID: 81875 RVA: 0x001D58D7 File Offset: 0x001D3AD7
		public unsafe bool bSupportsITunesFileSharing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsITunesFileSharing) & UIOSRuntimeSettings.__PropertyMask_bSupportsITunesFileSharing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsITunesFileSharing) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsITunesFileSharing) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsITunesFileSharing) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsITunesFileSharing : 0));
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x06013FD4 RID: 81876 RVA: 0x001D5907 File Offset: 0x001D3B07
		// (set) Token: 0x06013FD5 RID: 81877 RVA: 0x001D5920 File Offset: 0x001D3B20
		public unsafe bool bSupportsFilesApp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsFilesApp) & UIOSRuntimeSettings.__PropertyMask_bSupportsFilesApp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsFilesApp) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsFilesApp) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsFilesApp) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsFilesApp : 0));
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x06013FD6 RID: 81878 RVA: 0x001D5950 File Offset: 0x001D3B50
		// (set) Token: 0x06013FD7 RID: 81879 RVA: 0x001D5960 File Offset: 0x001D3B60
		public unsafe EIOSLandscapeOrientation PreferredLandscapeOrientation
		{
			get
			{
				return (EIOSLandscapeOrientation)(*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_PreferredLandscapeOrientation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_PreferredLandscapeOrientation) = (byte)value;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x06013FD8 RID: 81880 RVA: 0x001D5971 File Offset: 0x001D3B71
		// (set) Token: 0x06013FD9 RID: 81881 RVA: 0x001D5985 File Offset: 0x001D3B85
		public unsafe string BundleDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleDisplayName)), value);
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x06013FDA RID: 81882 RVA: 0x001D599A File Offset: 0x001D3B9A
		// (set) Token: 0x06013FDB RID: 81883 RVA: 0x001D59AE File Offset: 0x001D3BAE
		public unsafe string BundleName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleName)), value);
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x06013FDC RID: 81884 RVA: 0x001D59C3 File Offset: 0x001D3BC3
		// (set) Token: 0x06013FDD RID: 81885 RVA: 0x001D59D7 File Offset: 0x001D3BD7
		public unsafe string BundleIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_BundleIdentifier)), value);
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x06013FDE RID: 81886 RVA: 0x001D59EC File Offset: 0x001D3BEC
		// (set) Token: 0x06013FDF RID: 81887 RVA: 0x001D5A00 File Offset: 0x001D3C00
		public unsafe string VersionInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_VersionInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_VersionInfo)), value);
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x06013FE0 RID: 81888 RVA: 0x001D5A15 File Offset: 0x001D3C15
		// (set) Token: 0x06013FE1 RID: 81889 RVA: 0x001D5A25 File Offset: 0x001D3C25
		public unsafe EPowerUsageFrameRateLock FrameRateLock
		{
			get
			{
				return (EPowerUsageFrameRateLock)(*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_FrameRateLock));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_FrameRateLock) = (byte)value;
			}
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x06013FE2 RID: 81890 RVA: 0x001D5A36 File Offset: 0x001D3C36
		// (set) Token: 0x06013FE3 RID: 81891 RVA: 0x001D5A46 File Offset: 0x001D3C46
		public unsafe bool bEnableDynamicMaxFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableDynamicMaxFPS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableDynamicMaxFPS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x06013FE4 RID: 81892 RVA: 0x001D5A57 File Offset: 0x001D3C57
		// (set) Token: 0x06013FE5 RID: 81893 RVA: 0x001D5A67 File Offset: 0x001D3C67
		public unsafe EIOSVersion MinimumiOSVersion
		{
			get
			{
				return (EIOSVersion)(*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MinimumiOSVersion));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MinimumiOSVersion) = (byte)value;
			}
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x06013FE6 RID: 81894 RVA: 0x001D5A78 File Offset: 0x001D3C78
		// (set) Token: 0x06013FE7 RID: 81895 RVA: 0x001D5A91 File Offset: 0x001D3C91
		public unsafe bool bSupportsIPad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPad) & UIOSRuntimeSettings.__PropertyMask_bSupportsIPad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPad) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPad) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsIPad) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsIPad : 0));
			}
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x06013FE8 RID: 81896 RVA: 0x001D5AC1 File Offset: 0x001D3CC1
		// (set) Token: 0x06013FE9 RID: 81897 RVA: 0x001D5ADA File Offset: 0x001D3CDA
		public unsafe bool bSupportsIPhone
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPhone) & UIOSRuntimeSettings.__PropertyMask_bSupportsIPhone) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPhone) = ((*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bSupportsIPhone) & ~UIOSRuntimeSettings.__PropertyMask_bSupportsIPhone) | (value ? UIOSRuntimeSettings.__PropertyMask_bSupportsIPhone : 0));
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x06013FEA RID: 81898 RVA: 0x001D5B0A File Offset: 0x001D3D0A
		// (set) Token: 0x06013FEB RID: 81899 RVA: 0x001D5B1E File Offset: 0x001D3D1E
		public unsafe string AdditionalPlistData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalPlistData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_AdditionalPlistData)), value);
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x06013FEC RID: 81900 RVA: 0x001D5B33 File Offset: 0x001D3D33
		// (set) Token: 0x06013FED RID: 81901 RVA: 0x001D5B43 File Offset: 0x001D3D43
		public unsafe bool bCustomLaunchscreenStoryboard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCustomLaunchscreenStoryboard) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bCustomLaunchscreenStoryboard) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x06013FEE RID: 81902 RVA: 0x001D5B54 File Offset: 0x001D3D54
		// (set) Token: 0x06013FEF RID: 81903 RVA: 0x001D5B64 File Offset: 0x001D3D64
		public unsafe bool bEnableFacebookSupport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableFacebookSupport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bEnableFacebookSupport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x06013FF0 RID: 81904 RVA: 0x001D5B75 File Offset: 0x001D3D75
		// (set) Token: 0x06013FF1 RID: 81905 RVA: 0x001D5B89 File Offset: 0x001D3D89
		public unsafe string FacebookAppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_FacebookAppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_FacebookAppID)), value);
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x06013FF2 RID: 81906 RVA: 0x001D5B9E File Offset: 0x001D3D9E
		// (set) Token: 0x06013FF3 RID: 81907 RVA: 0x001D5BB2 File Offset: 0x001D3DB2
		public unsafe string MobileProvision
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_MobileProvision)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_MobileProvision)), value);
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x06013FF4 RID: 81908 RVA: 0x001D5BC7 File Offset: 0x001D3DC7
		// (set) Token: 0x06013FF5 RID: 81909 RVA: 0x001D5BDB File Offset: 0x001D3DDB
		public unsafe string SigningCertificate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SigningCertificate)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SigningCertificate)), value);
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x06013FF6 RID: 81910 RVA: 0x001D5BF0 File Offset: 0x001D3DF0
		// (set) Token: 0x06013FF7 RID: 81911 RVA: 0x001D5C00 File Offset: 0x001D3E00
		public unsafe bool bAutomaticSigning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAutomaticSigning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bAutomaticSigning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x06013FF8 RID: 81912 RVA: 0x001D5C11 File Offset: 0x001D3E11
		// (set) Token: 0x06013FF9 RID: 81913 RVA: 0x001D5C25 File Offset: 0x001D3E25
		public unsafe string IOSTeamID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_IOSTeamID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_IOSTeamID)), value);
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x06013FFA RID: 81914 RVA: 0x001D5C3A File Offset: 0x001D3E3A
		// (set) Token: 0x06013FFB RID: 81915 RVA: 0x001D5C4E File Offset: 0x001D3E4E
		public unsafe string DevCenterUsername
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_DevCenterUsername)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_DevCenterUsername)), value);
			}
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x06013FFC RID: 81916 RVA: 0x001D5C63 File Offset: 0x001D3E63
		// (set) Token: 0x06013FFD RID: 81917 RVA: 0x001D5C77 File Offset: 0x001D3E77
		public unsafe string DevCenterPassword
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_DevCenterPassword)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_DevCenterPassword)), value);
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x06013FFE RID: 81918 RVA: 0x001D5C8C File Offset: 0x001D3E8C
		// (set) Token: 0x06013FFF RID: 81919 RVA: 0x001D5C9C File Offset: 0x001D3E9C
		public unsafe bool bDisableHTTPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bDisableHTTPS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bDisableHTTPS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x06014000 RID: 81920 RVA: 0x001D5CAD File Offset: 0x001D3EAD
		// (set) Token: 0x06014001 RID: 81921 RVA: 0x001D5CBD File Offset: 0x001D3EBD
		public unsafe byte MaxShaderLanguageVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxShaderLanguageVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxShaderLanguageVersion) = value;
			}
		}

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x06014002 RID: 81922 RVA: 0x001D5CCE File Offset: 0x001D3ECE
		// (set) Token: 0x06014003 RID: 81923 RVA: 0x001D5CDE File Offset: 0x001D3EDE
		public unsafe bool UseFastIntrinsics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_UseFastIntrinsics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_UseFastIntrinsics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06014004 RID: 81924 RVA: 0x001D5CEF File Offset: 0x001D3EEF
		// (set) Token: 0x06014005 RID: 81925 RVA: 0x001D5CFF File Offset: 0x001D3EFF
		public unsafe bool ForceFloats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_ForceFloats) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_ForceFloats) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x06014006 RID: 81926 RVA: 0x001D5D10 File Offset: 0x001D3F10
		// (set) Token: 0x06014007 RID: 81927 RVA: 0x001D5D20 File Offset: 0x001D3F20
		public unsafe bool EnableMathOptimisations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_EnableMathOptimisations) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_EnableMathOptimisations) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x06014008 RID: 81928 RVA: 0x001D5D31 File Offset: 0x001D3F31
		// (set) Token: 0x06014009 RID: 81929 RVA: 0x001D5D41 File Offset: 0x001D3F41
		public unsafe int IndirectArgumentTier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_IndirectArgumentTier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_IndirectArgumentTier) = value;
			}
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x0601400A RID: 81930 RVA: 0x001D5D52 File Offset: 0x001D3F52
		// (set) Token: 0x0601400B RID: 81931 RVA: 0x001D5D62 File Offset: 0x001D3F62
		public unsafe bool bUseIntegratedKeyboard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseIntegratedKeyboard) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseIntegratedKeyboard) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x0601400C RID: 81932 RVA: 0x001D5D73 File Offset: 0x001D3F73
		// (set) Token: 0x0601400D RID: 81933 RVA: 0x001D5D83 File Offset: 0x001D3F83
		public unsafe int AudioSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioSampleRate) = value;
			}
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x0601400E RID: 81934 RVA: 0x001D5D94 File Offset: 0x001D3F94
		// (set) Token: 0x0601400F RID: 81935 RVA: 0x001D5DA4 File Offset: 0x001D3FA4
		public unsafe int AudioCallbackBufferFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize) = value;
			}
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x06014010 RID: 81936 RVA: 0x001D5DB5 File Offset: 0x001D3FB5
		// (set) Token: 0x06014011 RID: 81937 RVA: 0x001D5DC5 File Offset: 0x001D3FC5
		public unsafe int AudioNumBuffersToEnqueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue) = value;
			}
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x06014012 RID: 81938 RVA: 0x001D5DD6 File Offset: 0x001D3FD6
		// (set) Token: 0x06014013 RID: 81939 RVA: 0x001D5DE6 File Offset: 0x001D3FE6
		public unsafe int AudioMaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioMaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioMaxChannels) = value;
			}
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x06014014 RID: 81940 RVA: 0x001D5DF7 File Offset: 0x001D3FF7
		// (set) Token: 0x06014015 RID: 81941 RVA: 0x001D5E07 File Offset: 0x001D4007
		public unsafe int AudioNumSourceWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers) = value;
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x06014016 RID: 81942 RVA: 0x001D5E18 File Offset: 0x001D4018
		// (set) Token: 0x06014017 RID: 81943 RVA: 0x001D5E2C File Offset: 0x001D402C
		public unsafe string SpatializationPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SpatializationPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_SpatializationPlugin)), value);
			}
		}

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x06014018 RID: 81944 RVA: 0x001D5E41 File Offset: 0x001D4041
		// (set) Token: 0x06014019 RID: 81945 RVA: 0x001D5E55 File Offset: 0x001D4055
		public unsafe string ReverbPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_ReverbPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_ReverbPlugin)), value);
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x0601401A RID: 81946 RVA: 0x001D5E6A File Offset: 0x001D406A
		// (set) Token: 0x0601401B RID: 81947 RVA: 0x001D5E7E File Offset: 0x001D407E
		public unsafe string OcclusionPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_OcclusionPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UIOSRuntimeSettings.__PropertyOffset_OcclusionPlugin)), value);
			}
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x0601401C RID: 81948 RVA: 0x001D5E94 File Offset: 0x001D4094
		// (set) Token: 0x0601401D RID: 81949 RVA: 0x001D5ECD File Offset: 0x001D40CD
		public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRuntimeAudioCompressionOverrides result;
				if ((result = this._CompressionOverrides) == null)
				{
					result = (this._CompressionOverrides = new FPlatformRuntimeAudioCompressionOverrides(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CompressionOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformRuntimeAudioCompressionOverrides.StaticStruct(), base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CompressionOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x0601401E RID: 81950 RVA: 0x001D5EEE File Offset: 0x001D40EE
		// (set) Token: 0x0601401F RID: 81951 RVA: 0x001D5EFE File Offset: 0x001D40FE
		public unsafe bool bUseAudioStreamCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06014020 RID: 81952 RVA: 0x001D5F0F File Offset: 0x001D410F
		// (set) Token: 0x06014021 RID: 81953 RVA: 0x001D5F1F File Offset: 0x001D411F
		public unsafe int CacheSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CacheSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CacheSizeKB) = value;
			}
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06014022 RID: 81954 RVA: 0x001D5F30 File Offset: 0x001D4130
		// (set) Token: 0x06014023 RID: 81955 RVA: 0x001D5F40 File Offset: 0x001D4140
		public unsafe int MaxChunkSizeOverrideKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB) = value;
			}
		}

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x06014024 RID: 81956 RVA: 0x001D5F51 File Offset: 0x001D4151
		// (set) Token: 0x06014025 RID: 81957 RVA: 0x001D5F61 File Offset: 0x001D4161
		public unsafe bool bResampleForDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bResampleForDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bResampleForDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06014026 RID: 81958 RVA: 0x001D5F72 File Offset: 0x001D4172
		// (set) Token: 0x06014027 RID: 81959 RVA: 0x001D5F82 File Offset: 0x001D4182
		public unsafe int SoundCueCookQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex) = value;
			}
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x06014028 RID: 81960 RVA: 0x001D5F93 File Offset: 0x001D4193
		// (set) Token: 0x06014029 RID: 81961 RVA: 0x001D5FA3 File Offset: 0x001D41A3
		public unsafe float MaxSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MaxSampleRate) = value;
			}
		}

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x0601402A RID: 81962 RVA: 0x001D5FB4 File Offset: 0x001D41B4
		// (set) Token: 0x0601402B RID: 81963 RVA: 0x001D5FC4 File Offset: 0x001D41C4
		public unsafe float HighSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_HighSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_HighSampleRate) = value;
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x0601402C RID: 81964 RVA: 0x001D5FD5 File Offset: 0x001D41D5
		// (set) Token: 0x0601402D RID: 81965 RVA: 0x001D5FE5 File Offset: 0x001D41E5
		public unsafe float MedSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MedSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MedSampleRate) = value;
			}
		}

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x0601402E RID: 81966 RVA: 0x001D5FF6 File Offset: 0x001D41F6
		// (set) Token: 0x0601402F RID: 81967 RVA: 0x001D6006 File Offset: 0x001D4206
		public unsafe float LowSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_LowSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_LowSampleRate) = value;
			}
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x06014030 RID: 81968 RVA: 0x001D6017 File Offset: 0x001D4217
		// (set) Token: 0x06014031 RID: 81969 RVA: 0x001D6027 File Offset: 0x001D4227
		public unsafe float MinSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MinSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_MinSampleRate) = value;
			}
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x06014032 RID: 81970 RVA: 0x001D6038 File Offset: 0x001D4238
		// (set) Token: 0x06014033 RID: 81971 RVA: 0x001D6048 File Offset: 0x001D4248
		public unsafe float CompressionQualityModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CompressionQualityModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_CompressionQualityModifier) = value;
			}
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x06014034 RID: 81972 RVA: 0x001D6059 File Offset: 0x001D4259
		// (set) Token: 0x06014035 RID: 81973 RVA: 0x001D6069 File Offset: 0x001D4269
		public unsafe float AutoStreamingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AutoStreamingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_AutoStreamingThreshold) = value;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x06014036 RID: 81974 RVA: 0x001D607A File Offset: 0x001D427A
		// (set) Token: 0x06014037 RID: 81975 RVA: 0x001D608A File Offset: 0x001D428A
		public unsafe bool bStreamLandscapeMeshLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bStreamLandscapeMeshLODs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIOSRuntimeSettings.__PropertyOffset_bStreamLandscapeMeshLODs) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014038 RID: 81976 RVA: 0x001D609B File Offset: 0x001D429B
		static UIOSRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/IOSRuntimeSettings.IOSRuntimeSettings");
		}

		// Token: 0x06014039 RID: 81977 RVA: 0x001D60A9 File Offset: 0x001D42A9
		protected UIOSRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AD76 RID: 44406
		public new const string __ObjectPath = "/Script/IOSRuntimeSettings.IOSRuntimeSettings";

		// Token: 0x0400AD77 RID: 44407
		private static IntPtr _ClassPtr;

		// Token: 0x0400AD78 RID: 44408
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AD79 RID: 44409
		internal static int __PropertyOffset_bEnableGameCenterSupport;

		// Token: 0x0400AD7A RID: 44410
		internal static byte __PropertyMask_bEnableGameCenterSupport;

		// Token: 0x0400AD7B RID: 44411
		internal static int __PropertyOffset_bEnableCloudKitSupport;

		// Token: 0x0400AD7C RID: 44412
		internal static byte __PropertyMask_bEnableCloudKitSupport;

		// Token: 0x0400AD7D RID: 44413
		internal static int __PropertyOffset_IOSCloudKitSyncStrategy;

		// Token: 0x0400AD7E RID: 44414
		internal static int __PropertyOffset_bEnableRemoteNotificationsSupport;

		// Token: 0x0400AD7F RID: 44415
		internal static byte __PropertyMask_bEnableRemoteNotificationsSupport;

		// Token: 0x0400AD80 RID: 44416
		internal static int __PropertyOffset_bEnableBackgroundFetch;

		// Token: 0x0400AD81 RID: 44417
		internal static byte __PropertyMask_bEnableBackgroundFetch;

		// Token: 0x0400AD82 RID: 44418
		internal static int __PropertyOffset_bSupportsMetal;

		// Token: 0x0400AD83 RID: 44419
		internal static int __PropertyOffset_bSupportsMetalMRT;

		// Token: 0x0400AD84 RID: 44420
		internal static int __PropertyOffset_bSupportHighRefreshRates;

		// Token: 0x0400AD85 RID: 44421
		internal static int __PropertyOffset_bSupportIOSKeepWorkLoad;

		// Token: 0x0400AD86 RID: 44422
		internal static int __PropertyOffset_bCookPVRTCTextures;

		// Token: 0x0400AD87 RID: 44423
		internal static int __PropertyOffset_bCookASTCTextures;

		// Token: 0x0400AD88 RID: 44424
		internal static int __PropertyOffset_bBuildAsFramework;

		// Token: 0x0400AD89 RID: 44425
		internal static int __PropertyOffset_WindowsMetalToolchainOverride;

		// Token: 0x0400AD8A RID: 44426
		[Nullable(2)]
		private FIOSBuildResourceDirectory _WindowsMetalToolchainOverride;

		// Token: 0x0400AD8B RID: 44427
		internal static int __PropertyOffset_bGeneratedSYMFile;

		// Token: 0x0400AD8C RID: 44428
		internal static int __PropertyOffset_bGeneratedSYMBundle;

		// Token: 0x0400AD8D RID: 44429
		internal static int __PropertyOffset_bGenerateCrashReportSymbols;

		// Token: 0x0400AD8E RID: 44430
		internal static int __PropertyOffset_bGenerateXCArchive;

		// Token: 0x0400AD8F RID: 44431
		internal static int __PropertyOffset_bShipForBitcode;

		// Token: 0x0400AD90 RID: 44432
		internal static int __PropertyOffset_bEnableAdvertisingIdentifier;

		// Token: 0x0400AD91 RID: 44433
		internal static int __PropertyOffset_AdditionalLinkerFlags;

		// Token: 0x0400AD92 RID: 44434
		internal static int __PropertyOffset_AdditionalShippingLinkerFlags;

		// Token: 0x0400AD93 RID: 44435
		internal static int __PropertyOffset_RemoteServerName;

		// Token: 0x0400AD94 RID: 44436
		internal static int __PropertyOffset_bUseRSync;

		// Token: 0x0400AD95 RID: 44437
		internal static int __PropertyOffset_RSyncUsername;

		// Token: 0x0400AD96 RID: 44438
		internal static int __PropertyOffset_DeltaCopyInstallPath;

		// Token: 0x0400AD97 RID: 44439
		[Nullable(2)]
		private FIOSBuildResourceDirectory _DeltaCopyInstallPath;

		// Token: 0x0400AD98 RID: 44440
		internal static int __PropertyOffset_SSHPrivateKeyLocation;

		// Token: 0x0400AD99 RID: 44441
		internal static int __PropertyOffset_SSHPrivateKeyOverridePath;

		// Token: 0x0400AD9A RID: 44442
		[Nullable(2)]
		private FIOSBuildResourceFilePath _SSHPrivateKeyOverridePath;

		// Token: 0x0400AD9B RID: 44443
		internal static int __PropertyOffset_bRunAsCurrentUser;

		// Token: 0x0400AD9C RID: 44444
		internal static int __PropertyOffset_bGameSupportsMultipleActiveControllers;

		// Token: 0x0400AD9D RID: 44445
		internal static int __PropertyOffset_bAllowRemoteRotation;

		// Token: 0x0400AD9E RID: 44446
		internal static int __PropertyOffset_bUseRemoteAsVirtualJoystick_DEPRECATED;

		// Token: 0x0400AD9F RID: 44447
		internal static int __PropertyOffset_bUseRemoteAbsoluteDpadValues;

		// Token: 0x0400ADA0 RID: 44448
		internal static int __PropertyOffset_bAllowControllers;

		// Token: 0x0400ADA1 RID: 44449
		internal static int __PropertyOffset_bControllersBlockDeviceFeedback;

		// Token: 0x0400ADA2 RID: 44450
		internal static int __PropertyOffset_bDisableMotionData;

		// Token: 0x0400ADA3 RID: 44451
		internal static int __PropertyOffset_bSupportsPortraitOrientation;

		// Token: 0x0400ADA4 RID: 44452
		internal static byte __PropertyMask_bSupportsPortraitOrientation;

		// Token: 0x0400ADA5 RID: 44453
		internal static int __PropertyOffset_bSupportsUpsideDownOrientation;

		// Token: 0x0400ADA6 RID: 44454
		internal static byte __PropertyMask_bSupportsUpsideDownOrientation;

		// Token: 0x0400ADA7 RID: 44455
		internal static int __PropertyOffset_bSupportsLandscapeLeftOrientation;

		// Token: 0x0400ADA8 RID: 44456
		internal static byte __PropertyMask_bSupportsLandscapeLeftOrientation;

		// Token: 0x0400ADA9 RID: 44457
		internal static int __PropertyOffset_bSupportsLandscapeRightOrientation;

		// Token: 0x0400ADAA RID: 44458
		internal static byte __PropertyMask_bSupportsLandscapeRightOrientation;

		// Token: 0x0400ADAB RID: 44459
		internal static int __PropertyOffset_bSupportsITunesFileSharing;

		// Token: 0x0400ADAC RID: 44460
		internal static byte __PropertyMask_bSupportsITunesFileSharing;

		// Token: 0x0400ADAD RID: 44461
		internal static int __PropertyOffset_bSupportsFilesApp;

		// Token: 0x0400ADAE RID: 44462
		internal static byte __PropertyMask_bSupportsFilesApp;

		// Token: 0x0400ADAF RID: 44463
		internal static int __PropertyOffset_PreferredLandscapeOrientation;

		// Token: 0x0400ADB0 RID: 44464
		internal static int __PropertyOffset_BundleDisplayName;

		// Token: 0x0400ADB1 RID: 44465
		internal static int __PropertyOffset_BundleName;

		// Token: 0x0400ADB2 RID: 44466
		internal static int __PropertyOffset_BundleIdentifier;

		// Token: 0x0400ADB3 RID: 44467
		internal static int __PropertyOffset_VersionInfo;

		// Token: 0x0400ADB4 RID: 44468
		internal static int __PropertyOffset_FrameRateLock;

		// Token: 0x0400ADB5 RID: 44469
		internal static int __PropertyOffset_bEnableDynamicMaxFPS;

		// Token: 0x0400ADB6 RID: 44470
		internal static int __PropertyOffset_MinimumiOSVersion;

		// Token: 0x0400ADB7 RID: 44471
		internal static int __PropertyOffset_bSupportsIPad;

		// Token: 0x0400ADB8 RID: 44472
		internal static byte __PropertyMask_bSupportsIPad;

		// Token: 0x0400ADB9 RID: 44473
		internal static int __PropertyOffset_bSupportsIPhone;

		// Token: 0x0400ADBA RID: 44474
		internal static byte __PropertyMask_bSupportsIPhone;

		// Token: 0x0400ADBB RID: 44475
		internal static int __PropertyOffset_AdditionalPlistData;

		// Token: 0x0400ADBC RID: 44476
		internal static int __PropertyOffset_bCustomLaunchscreenStoryboard;

		// Token: 0x0400ADBD RID: 44477
		internal static int __PropertyOffset_bEnableFacebookSupport;

		// Token: 0x0400ADBE RID: 44478
		internal static int __PropertyOffset_FacebookAppID;

		// Token: 0x0400ADBF RID: 44479
		internal static int __PropertyOffset_MobileProvision;

		// Token: 0x0400ADC0 RID: 44480
		internal static int __PropertyOffset_SigningCertificate;

		// Token: 0x0400ADC1 RID: 44481
		internal static int __PropertyOffset_bAutomaticSigning;

		// Token: 0x0400ADC2 RID: 44482
		internal static int __PropertyOffset_IOSTeamID;

		// Token: 0x0400ADC3 RID: 44483
		internal static int __PropertyOffset_DevCenterUsername;

		// Token: 0x0400ADC4 RID: 44484
		internal static int __PropertyOffset_DevCenterPassword;

		// Token: 0x0400ADC5 RID: 44485
		internal static int __PropertyOffset_bDisableHTTPS;

		// Token: 0x0400ADC6 RID: 44486
		internal static int __PropertyOffset_MaxShaderLanguageVersion;

		// Token: 0x0400ADC7 RID: 44487
		internal static int __PropertyOffset_UseFastIntrinsics;

		// Token: 0x0400ADC8 RID: 44488
		internal static int __PropertyOffset_ForceFloats;

		// Token: 0x0400ADC9 RID: 44489
		internal static int __PropertyOffset_EnableMathOptimisations;

		// Token: 0x0400ADCA RID: 44490
		internal static int __PropertyOffset_IndirectArgumentTier;

		// Token: 0x0400ADCB RID: 44491
		internal static int __PropertyOffset_bUseIntegratedKeyboard;

		// Token: 0x0400ADCC RID: 44492
		internal static int __PropertyOffset_AudioSampleRate;

		// Token: 0x0400ADCD RID: 44493
		internal static int __PropertyOffset_AudioCallbackBufferFrameSize;

		// Token: 0x0400ADCE RID: 44494
		internal static int __PropertyOffset_AudioNumBuffersToEnqueue;

		// Token: 0x0400ADCF RID: 44495
		internal static int __PropertyOffset_AudioMaxChannels;

		// Token: 0x0400ADD0 RID: 44496
		internal static int __PropertyOffset_AudioNumSourceWorkers;

		// Token: 0x0400ADD1 RID: 44497
		internal static int __PropertyOffset_SpatializationPlugin;

		// Token: 0x0400ADD2 RID: 44498
		internal static int __PropertyOffset_ReverbPlugin;

		// Token: 0x0400ADD3 RID: 44499
		internal static int __PropertyOffset_OcclusionPlugin;

		// Token: 0x0400ADD4 RID: 44500
		internal static int __PropertyOffset_CompressionOverrides;

		// Token: 0x0400ADD5 RID: 44501
		[Nullable(2)]
		private FPlatformRuntimeAudioCompressionOverrides _CompressionOverrides;

		// Token: 0x0400ADD6 RID: 44502
		internal static int __PropertyOffset_bUseAudioStreamCaching;

		// Token: 0x0400ADD7 RID: 44503
		internal static int __PropertyOffset_CacheSizeKB;

		// Token: 0x0400ADD8 RID: 44504
		internal static int __PropertyOffset_MaxChunkSizeOverrideKB;

		// Token: 0x0400ADD9 RID: 44505
		internal static int __PropertyOffset_bResampleForDevice;

		// Token: 0x0400ADDA RID: 44506
		internal static int __PropertyOffset_SoundCueCookQualityIndex;

		// Token: 0x0400ADDB RID: 44507
		internal static int __PropertyOffset_MaxSampleRate;

		// Token: 0x0400ADDC RID: 44508
		internal static int __PropertyOffset_HighSampleRate;

		// Token: 0x0400ADDD RID: 44509
		internal static int __PropertyOffset_MedSampleRate;

		// Token: 0x0400ADDE RID: 44510
		internal static int __PropertyOffset_LowSampleRate;

		// Token: 0x0400ADDF RID: 44511
		internal static int __PropertyOffset_MinSampleRate;

		// Token: 0x0400ADE0 RID: 44512
		internal static int __PropertyOffset_CompressionQualityModifier;

		// Token: 0x0400ADE1 RID: 44513
		internal static int __PropertyOffset_AutoStreamingThreshold;

		// Token: 0x0400ADE2 RID: 44514
		internal static int __PropertyOffset_bStreamLandscapeMeshLODs;
	}
}
