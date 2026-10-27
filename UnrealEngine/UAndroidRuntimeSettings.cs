using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AA RID: 682
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.AndroidRuntimeSettings")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UAndroidRuntimeSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600259B RID: 9627 RVA: 0x00038D8B File Offset: 0x00036F8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAndroidRuntimeSettings._ClassPtr;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00038D98 File Offset: 0x00036F98
		public UAndroidRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(UAndroidRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00038DC0 File Offset: 0x00036FC0
		public UAndroidRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAndroidRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x00038DF3 File Offset: 0x00036FF3
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x00038E07 File Offset: 0x00037007
		public unsafe string PackageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_PackageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_PackageName)), value);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x00038E1C File Offset: 0x0003701C
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00038E2C File Offset: 0x0003702C
		public unsafe int StoreVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersion) = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x00038E3D File Offset: 0x0003703D
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x00038E4D File Offset: 0x0003704D
		public unsafe int StoreVersionOffsetArmV7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetArmV7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetArmV7) = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x00038E5E File Offset: 0x0003705E
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x00038E6E File Offset: 0x0003706E
		public unsafe int StoreVersionOffsetArm64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetArm64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetArm64) = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x00038E7F File Offset: 0x0003707F
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x00038E8F File Offset: 0x0003708F
		public unsafe int StoreVersionOffsetX8664
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetX8664);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_StoreVersionOffsetX8664) = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00038EA0 File Offset: 0x000370A0
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00038EB4 File Offset: 0x000370B4
		public unsafe string ApplicationDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ApplicationDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ApplicationDisplayName)), value);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x00038EC9 File Offset: 0x000370C9
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00038EDD File Offset: 0x000370DD
		public unsafe string VersionDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_VersionDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_VersionDisplayName)), value);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00038EF2 File Offset: 0x000370F2
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x00038F02 File Offset: 0x00037102
		public unsafe int MinSDKVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MinSDKVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MinSDKVersion) = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x00038F13 File Offset: 0x00037113
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x00038F23 File Offset: 0x00037123
		public unsafe int TargetSDKVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TargetSDKVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TargetSDKVersion) = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00038F34 File Offset: 0x00037134
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00038F48 File Offset: 0x00037148
		[Nullable(0)]
		public unsafe TEnumAsByte<EAndroidInstallLocation> InstallLocation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_InstallLocation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_InstallLocation) = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00038F5D File Offset: 0x0003715D
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00038F6D File Offset: 0x0003716D
		public unsafe bool bEnableGradle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableGradle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableGradle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00038F7E File Offset: 0x0003717E
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x00038F8E File Offset: 0x0003718E
		public unsafe bool bEnableLint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableLint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableLint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x00038F9F File Offset: 0x0003719F
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x00038FAF File Offset: 0x000371AF
		public unsafe bool bPackageDataInsideApk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bPackageDataInsideApk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bPackageDataInsideApk) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00038FC0 File Offset: 0x000371C0
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x00038FD0 File Offset: 0x000371D0
		public unsafe bool bCreateAllPlatformsInstall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bCreateAllPlatformsInstall) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bCreateAllPlatformsInstall) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x00038FE1 File Offset: 0x000371E1
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x00038FF1 File Offset: 0x000371F1
		public unsafe bool bDisableVerifyOBBOnStartUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bDisableVerifyOBBOnStartUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bDisableVerifyOBBOnStartUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x00039002 File Offset: 0x00037202
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x00039012 File Offset: 0x00037212
		public unsafe bool bForceSmallOBBFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bForceSmallOBBFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bForceSmallOBBFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x00039023 File Offset: 0x00037223
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x00039033 File Offset: 0x00037233
		public unsafe bool bAllowLargeOBBFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowLargeOBBFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowLargeOBBFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x00039044 File Offset: 0x00037244
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x00039054 File Offset: 0x00037254
		public unsafe bool bAllowPatchOBBFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowPatchOBBFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowPatchOBBFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x00039065 File Offset: 0x00037265
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x00039075 File Offset: 0x00037275
		public unsafe bool bAllowOverflowOBBFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowOverflowOBBFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowOverflowOBBFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x00039086 File Offset: 0x00037286
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x00039096 File Offset: 0x00037296
		public unsafe bool bUseExternalFilesDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseExternalFilesDir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseExternalFilesDir) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000390A7 File Offset: 0x000372A7
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x000390B7 File Offset: 0x000372B7
		public unsafe bool bPublicLogFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bPublicLogFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bPublicLogFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000390C8 File Offset: 0x000372C8
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x000390DC File Offset: 0x000372DC
		[Nullable(0)]
		public unsafe TEnumAsByte<EAndroidScreenOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000390F1 File Offset: 0x000372F1
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x00039101 File Offset: 0x00037301
		public unsafe float MaxAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxAspectRatio) = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x00039112 File Offset: 0x00037312
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x00039122 File Offset: 0x00037322
		public unsafe bool bUseDisplayCutout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseDisplayCutout) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseDisplayCutout) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00039133 File Offset: 0x00037333
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00039143 File Offset: 0x00037343
		public unsafe bool bRestoreNotificationsOnReboot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bRestoreNotificationsOnReboot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bRestoreNotificationsOnReboot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00039154 File Offset: 0x00037354
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x00039164 File Offset: 0x00037364
		public unsafe bool bFullScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bFullScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bFullScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x00039175 File Offset: 0x00037375
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x00039185 File Offset: 0x00037385
		public unsafe bool bEnableNewKeyboard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableNewKeyboard) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableNewKeyboard) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00039196 File Offset: 0x00037396
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x000391AA File Offset: 0x000373AA
		[Nullable(0)]
		public unsafe TEnumAsByte<EAndroidDepthBufferPreference> DepthBufferPreference
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_DepthBufferPreference);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_DepthBufferPreference) = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000391BF File Offset: 0x000373BF
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x000391CF File Offset: 0x000373CF
		public unsafe bool bValidateTextureFormats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bValidateTextureFormats) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bValidateTextureFormats) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000391E0 File Offset: 0x000373E0
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x000391F0 File Offset: 0x000373F0
		public unsafe bool bEnableBundle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableBundle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableBundle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x00039201 File Offset: 0x00037401
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x00039211 File Offset: 0x00037411
		public unsafe bool bEnableUniversalAPK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableUniversalAPK) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableUniversalAPK) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x00039222 File Offset: 0x00037422
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x00039232 File Offset: 0x00037432
		public unsafe bool bBundleABISplit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleABISplit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleABISplit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x00039243 File Offset: 0x00037443
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x00039253 File Offset: 0x00037453
		public unsafe bool bBundleLanguageSplit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleLanguageSplit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleLanguageSplit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x00039264 File Offset: 0x00037464
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00039274 File Offset: 0x00037474
		public unsafe bool bBundleDensitySplit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleDensitySplit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBundleDensitySplit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x00039288 File Offset: 0x00037488
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x000392C1 File Offset: 0x000374C1
		public TArray<string> ExtraManifestNodeTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraManifestNodeTags) == null)
				{
					result = (this._ExtraManifestNodeTags = new TArray<string>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraManifestNodeTags, this));
				}
				return result;
			}
			set
			{
				this.ExtraManifestNodeTags.CopyAssign(value);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000392D0 File Offset: 0x000374D0
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00039309 File Offset: 0x00037509
		public TArray<string> ExtraApplicationNodeTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraApplicationNodeTags) == null)
				{
					result = (this._ExtraApplicationNodeTags = new TArray<string>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraApplicationNodeTags, this));
				}
				return result;
			}
			set
			{
				this.ExtraApplicationNodeTags.CopyAssign(value);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x00039317 File Offset: 0x00037517
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x0003932B File Offset: 0x0003752B
		public unsafe string ExtraApplicationSettings
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraApplicationSettings)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraApplicationSettings)), value);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x00039340 File Offset: 0x00037540
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x00039379 File Offset: 0x00037579
		public TArray<string> ExtraActivityNodeTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraActivityNodeTags) == null)
				{
					result = (this._ExtraActivityNodeTags = new TArray<string>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraActivityNodeTags, this));
				}
				return result;
			}
			set
			{
				this.ExtraActivityNodeTags.CopyAssign(value);
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x00039387 File Offset: 0x00037587
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x0003939B File Offset: 0x0003759B
		public unsafe string ExtraActivitySettings
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraActivitySettings)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraActivitySettings)), value);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000393B0 File Offset: 0x000375B0
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x000393E9 File Offset: 0x000375E9
		public TArray<string> ExtraPermissions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraPermissions) == null)
				{
					result = (this._ExtraPermissions = new TArray<string>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ExtraPermissions, this));
				}
				return result;
			}
			set
			{
				this.ExtraPermissions.CopyAssign(value);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000393F7 File Offset: 0x000375F7
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00039407 File Offset: 0x00037607
		public unsafe bool bAndroidVoiceEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAndroidVoiceEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAndroidVoiceEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x00039418 File Offset: 0x00037618
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00039451 File Offset: 0x00037651
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EOculusMobileDevice>> PackageForOculusMobile
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EOculusMobileDevice>> result;
				if ((result = this._PackageForOculusMobile) == null)
				{
					result = (this._PackageForOculusMobile = new TArray<TEnumAsByte<EOculusMobileDevice>>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_PackageForOculusMobile, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.PackageForOculusMobile.CopyAssign(value);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x0003945F File Offset: 0x0003765F
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0003946F File Offset: 0x0003766F
		public unsafe bool bRemoveOSIG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bRemoveOSIG) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bRemoveOSIG) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00039480 File Offset: 0x00037680
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x000394B9 File Offset: 0x000376B9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EGoogleVRCaps>> GoogleVRCaps
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EGoogleVRCaps>> result;
				if ((result = this._GoogleVRCaps) == null)
				{
					result = (this._GoogleVRCaps = new TArray<TEnumAsByte<EGoogleVRCaps>>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GoogleVRCaps, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.GoogleVRCaps.CopyAssign(value);
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000394C7 File Offset: 0x000376C7
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x000394D7 File Offset: 0x000376D7
		public unsafe bool bGoogleVRSustainedPerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bGoogleVRSustainedPerformance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bGoogleVRSustainedPerformance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000394E8 File Offset: 0x000376E8
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000394FC File Offset: 0x000376FC
		public unsafe string KeyStore
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyStore)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyStore)), value);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x00039511 File Offset: 0x00037711
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x00039525 File Offset: 0x00037725
		public unsafe string KeyAlias
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyAlias)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyAlias)), value);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0003953A File Offset: 0x0003773A
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0003954E File Offset: 0x0003774E
		public unsafe string KeyStorePassword
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyStorePassword)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyStorePassword)), value);
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x00039563 File Offset: 0x00037763
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x00039577 File Offset: 0x00037777
		public unsafe string KeyPassword
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyPassword)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_KeyPassword)), value);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0003958C File Offset: 0x0003778C
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0003959C File Offset: 0x0003779C
		public unsafe bool bBuildForArmV7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForArmV7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForArmV7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000395AD File Offset: 0x000377AD
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x000395BD File Offset: 0x000377BD
		public unsafe bool bBuildForArm64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForArm64) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForArm64) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000395CE File Offset: 0x000377CE
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000395DE File Offset: 0x000377DE
		public unsafe bool bBuildForX8664
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForX8664) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForX8664) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000395EF File Offset: 0x000377EF
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000395FF File Offset: 0x000377FF
		public unsafe bool bBuildForES31
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForES31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildForES31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00039610 File Offset: 0x00037810
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x00039620 File Offset: 0x00037820
		public unsafe bool bSupportsVulkan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportsVulkan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportsVulkan) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00039631 File Offset: 0x00037831
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x00039641 File Offset: 0x00037841
		public unsafe bool bSupportsVulkanSM5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportsVulkanSM5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportsVulkanSM5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00039652 File Offset: 0x00037852
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x00039662 File Offset: 0x00037862
		public unsafe bool bAndroidOpenGLSupportsBackbufferSampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAndroidOpenGLSupportsBackbufferSampling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAndroidOpenGLSupportsBackbufferSampling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x00039673 File Offset: 0x00037873
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x00039683 File Offset: 0x00037883
		public unsafe bool bDetectVulkanByDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bDetectVulkanByDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bDetectVulkanByDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x00039694 File Offset: 0x00037894
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x000396A4 File Offset: 0x000378A4
		public unsafe bool bBuildWithHiddenSymbolVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildWithHiddenSymbolVisibility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBuildWithHiddenSymbolVisibility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000396B5 File Offset: 0x000378B5
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x000396C5 File Offset: 0x000378C5
		public unsafe bool bSaveSymbols
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSaveSymbols) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSaveSymbols) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000396D6 File Offset: 0x000378D6
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x000396E6 File Offset: 0x000378E6
		public unsafe bool bForceLDLinker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bForceLDLinker) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bForceLDLinker) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000396F7 File Offset: 0x000378F7
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x00039707 File Offset: 0x00037907
		public unsafe bool bEnableGooglePlaySupport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableGooglePlaySupport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableGooglePlaySupport) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x00039718 File Offset: 0x00037918
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x00039728 File Offset: 0x00037928
		public unsafe bool bUseGetAccounts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseGetAccounts) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseGetAccounts) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x00039739 File Offset: 0x00037939
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0003974D File Offset: 0x0003794D
		public unsafe string GamesAppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GamesAppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GamesAppID)), value);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x00039764 File Offset: 0x00037964
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0003979D File Offset: 0x0003799D
		public TArray<FGooglePlayAchievementMapping> AchievementMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGooglePlayAchievementMapping> result;
				if ((result = this._AchievementMap) == null)
				{
					result = (this._AchievementMap = new TArray<FGooglePlayAchievementMapping>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AchievementMap, this));
				}
				return result;
			}
			set
			{
				this.AchievementMap.CopyAssign(value);
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000397AC File Offset: 0x000379AC
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x000397E5 File Offset: 0x000379E5
		public TArray<FGooglePlayLeaderboardMapping> LeaderboardMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGooglePlayLeaderboardMapping> result;
				if ((result = this._LeaderboardMap) == null)
				{
					result = (this._LeaderboardMap = new TArray<FGooglePlayLeaderboardMapping>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_LeaderboardMap, this));
				}
				return result;
			}
			set
			{
				this.LeaderboardMap.CopyAssign(value);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000397F3 File Offset: 0x000379F3
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x00039803 File Offset: 0x00037A03
		public unsafe bool bEnableSnapshots
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableSnapshots) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bEnableSnapshots) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00039814 File Offset: 0x00037A14
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00039824 File Offset: 0x00037A24
		public unsafe bool bSupportAdMob
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportAdMob) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bSupportAdMob) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00039835 File Offset: 0x00037A35
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00039849 File Offset: 0x00037A49
		public unsafe string AdMobAdUnitID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AdMobAdUnitID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AdMobAdUnitID)), value);
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00039860 File Offset: 0x00037A60
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00039899 File Offset: 0x00037A99
		public TArray<string> AdMobAdUnitIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AdMobAdUnitIDs) == null)
				{
					result = (this._AdMobAdUnitIDs = new TArray<string>(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AdMobAdUnitIDs, this));
				}
				return result;
			}
			set
			{
				this.AdMobAdUnitIDs.CopyAssign(value);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x000398A7 File Offset: 0x00037AA7
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x000398BB File Offset: 0x00037ABB
		public unsafe string GooglePlayLicenseKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GooglePlayLicenseKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GooglePlayLicenseKey)), value);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000398D0 File Offset: 0x00037AD0
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x000398E4 File Offset: 0x00037AE4
		public unsafe string GCMClientSenderID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GCMClientSenderID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_GCMClientSenderID)), value);
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000398F9 File Offset: 0x00037AF9
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x00039909 File Offset: 0x00037B09
		public unsafe bool bShowLaunchImage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bShowLaunchImage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bShowLaunchImage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x0003991A File Offset: 0x00037B1A
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0003992A File Offset: 0x00037B2A
		public unsafe bool bAllowIMU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowIMU) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowIMU) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x0003993B File Offset: 0x00037B3B
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0003994B File Offset: 0x00037B4B
		public unsafe bool bAllowControllers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowControllers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bAllowControllers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x0003995C File Offset: 0x00037B5C
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0003996C File Offset: 0x00037B6C
		public unsafe bool bBlockAndroidKeysOnControllers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBlockAndroidKeysOnControllers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bBlockAndroidKeysOnControllers) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x0003997D File Offset: 0x00037B7D
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0003998D File Offset: 0x00037B8D
		public unsafe bool bControllersBlockDeviceFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bControllersBlockDeviceFeedback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bControllersBlockDeviceFeedback) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0003999E File Offset: 0x00037B9E
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x000399B2 File Offset: 0x00037BB2
		[Nullable(0)]
		public unsafe TEnumAsByte<EAndroidAudio> AndroidAudio
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AndroidAudio);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AndroidAudio) = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000399C7 File Offset: 0x00037BC7
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x000399D7 File Offset: 0x00037BD7
		public unsafe int AudioSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioSampleRate) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000399E8 File Offset: 0x00037BE8
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x000399F8 File Offset: 0x00037BF8
		public unsafe int AudioCallbackBufferFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00039A09 File Offset: 0x00037C09
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x00039A19 File Offset: 0x00037C19
		public unsafe int AudioNumBuffersToEnqueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue) = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x00039A2A File Offset: 0x00037C2A
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x00039A3A File Offset: 0x00037C3A
		public unsafe int AudioMaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioMaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioMaxChannels) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x00039A4B File Offset: 0x00037C4B
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x00039A5B File Offset: 0x00037C5B
		public unsafe int AudioNumSourceWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers) = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x00039A6C File Offset: 0x00037C6C
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x00039A80 File Offset: 0x00037C80
		public unsafe string SpatializationPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SpatializationPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SpatializationPlugin)), value);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00039A95 File Offset: 0x00037C95
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x00039AA9 File Offset: 0x00037CA9
		public unsafe string ReverbPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ReverbPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_ReverbPlugin)), value);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00039ABE File Offset: 0x00037CBE
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x00039AD2 File Offset: 0x00037CD2
		public unsafe string OcclusionPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_OcclusionPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_OcclusionPlugin)), value);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x00039AE8 File Offset: 0x00037CE8
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00039B21 File Offset: 0x00037D21
		public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRuntimeAudioCompressionOverrides result;
				if ((result = this._CompressionOverrides) == null)
				{
					result = (this._CompressionOverrides = new FPlatformRuntimeAudioCompressionOverrides(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CompressionOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformRuntimeAudioCompressionOverrides.StaticStruct(), base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CompressionOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00039B42 File Offset: 0x00037D42
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x00039B52 File Offset: 0x00037D52
		public unsafe bool bUseAudioStreamCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00039B63 File Offset: 0x00037D63
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00039B73 File Offset: 0x00037D73
		public unsafe int CacheSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CacheSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CacheSizeKB) = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x00039B84 File Offset: 0x00037D84
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x00039B94 File Offset: 0x00037D94
		public unsafe int MaxChunkSizeOverrideKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB) = value;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00039BA5 File Offset: 0x00037DA5
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x00039BB5 File Offset: 0x00037DB5
		public unsafe bool bResampleForDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bResampleForDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bResampleForDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x00039BC6 File Offset: 0x00037DC6
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00039BD6 File Offset: 0x00037DD6
		public unsafe int SoundCueCookQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex) = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x00039BE7 File Offset: 0x00037DE7
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00039BF7 File Offset: 0x00037DF7
		public unsafe float MaxSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaxSampleRate) = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x00039C08 File Offset: 0x00037E08
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00039C18 File Offset: 0x00037E18
		public unsafe float HighSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_HighSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_HighSampleRate) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00039C29 File Offset: 0x00037E29
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00039C39 File Offset: 0x00037E39
		public unsafe float MedSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MedSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MedSampleRate) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x00039C4A File Offset: 0x00037E4A
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00039C5A File Offset: 0x00037E5A
		public unsafe float LowSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_LowSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_LowSampleRate) = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x00039C6B File Offset: 0x00037E6B
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x00039C7B File Offset: 0x00037E7B
		public unsafe float MinSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MinSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MinSampleRate) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x00039C8C File Offset: 0x00037E8C
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x00039C9C File Offset: 0x00037E9C
		public unsafe float CompressionQualityModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CompressionQualityModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_CompressionQualityModifier) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x00039CAD File Offset: 0x00037EAD
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x00039CBD File Offset: 0x00037EBD
		public unsafe float AutoStreamingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AutoStreamingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AutoStreamingThreshold) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x00039CCE File Offset: 0x00037ECE
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x00039CE2 File Offset: 0x00037EE2
		[Nullable(0)]
		public unsafe TEnumAsByte<EAndroidGraphicsDebugger> AndroidGraphicsDebugger
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AndroidGraphicsDebugger);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_AndroidGraphicsDebugger) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x00039CF8 File Offset: 0x00037EF8
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x00039D31 File Offset: 0x00037F31
		public FDirectoryPath MaliGraphicsDebuggerPath
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._MaliGraphicsDebuggerPath) == null)
				{
					result = (this._MaliGraphicsDebuggerPath = new FDirectoryPath(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaliGraphicsDebuggerPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_MaliGraphicsDebuggerPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x00039D52 File Offset: 0x00037F52
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x00039D62 File Offset: 0x00037F62
		public unsafe bool bMultiTargetFormat_ETC2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ETC2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ETC2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00039D73 File Offset: 0x00037F73
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00039D83 File Offset: 0x00037F83
		public unsafe bool bMultiTargetFormat_DXT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_DXT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_DXT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00039D94 File Offset: 0x00037F94
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x00039DA4 File Offset: 0x00037FA4
		public unsafe bool bMultiTargetFormat_ASTC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ASTC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ASTC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x00039DB5 File Offset: 0x00037FB5
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x00039DC5 File Offset: 0x00037FC5
		public unsafe float TextureFormatPriority_ETC2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_ETC2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_ETC2) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00039DD6 File Offset: 0x00037FD6
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x00039DE6 File Offset: 0x00037FE6
		public unsafe float TextureFormatPriority_DXT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_DXT);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_DXT) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x00039DF7 File Offset: 0x00037FF7
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x00039E07 File Offset: 0x00038007
		public unsafe float TextureFormatPriority_ASTC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_ASTC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_TextureFormatPriority_ASTC) = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x00039E18 File Offset: 0x00038018
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x00039E2C File Offset: 0x0003802C
		public unsafe string SDKAPILevelOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SDKAPILevelOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_SDKAPILevelOverride)), value);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00039E41 File Offset: 0x00038041
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00039E55 File Offset: 0x00038055
		public unsafe string NDKAPILevelOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_NDKAPILevelOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_NDKAPILevelOverride)), value);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00039E6A File Offset: 0x0003806A
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x00039E7E File Offset: 0x0003807E
		public unsafe string BuildToolsOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_BuildToolsOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAndroidRuntimeSettings.__PropertyOffset_BuildToolsOverride)), value);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x00039E93 File Offset: 0x00038093
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x00039EA3 File Offset: 0x000380A3
		public unsafe bool bStreamLandscapeMeshLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bStreamLandscapeMeshLODs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAndroidRuntimeSettings.__PropertyOffset_bStreamLandscapeMeshLODs) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00039EB4 File Offset: 0x000380B4
		static UAndroidRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AndroidRuntimeSettings.AndroidRuntimeSettings");
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00039EC2 File Offset: 0x000380C2
		protected UAndroidRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E78 RID: 3704
		public new const string __ObjectPath = "/Script/AndroidRuntimeSettings.AndroidRuntimeSettings";

		// Token: 0x04000E79 RID: 3705
		private static IntPtr _ClassPtr;

		// Token: 0x04000E7A RID: 3706
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E7B RID: 3707
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04000E7C RID: 3708
		internal static int __PropertyOffset_StoreVersion;

		// Token: 0x04000E7D RID: 3709
		internal static int __PropertyOffset_StoreVersionOffsetArmV7;

		// Token: 0x04000E7E RID: 3710
		internal static int __PropertyOffset_StoreVersionOffsetArm64;

		// Token: 0x04000E7F RID: 3711
		internal static int __PropertyOffset_StoreVersionOffsetX8664;

		// Token: 0x04000E80 RID: 3712
		internal static int __PropertyOffset_ApplicationDisplayName;

		// Token: 0x04000E81 RID: 3713
		internal static int __PropertyOffset_VersionDisplayName;

		// Token: 0x04000E82 RID: 3714
		internal static int __PropertyOffset_MinSDKVersion;

		// Token: 0x04000E83 RID: 3715
		internal static int __PropertyOffset_TargetSDKVersion;

		// Token: 0x04000E84 RID: 3716
		internal static int __PropertyOffset_InstallLocation;

		// Token: 0x04000E85 RID: 3717
		internal static int __PropertyOffset_bEnableGradle;

		// Token: 0x04000E86 RID: 3718
		internal static int __PropertyOffset_bEnableLint;

		// Token: 0x04000E87 RID: 3719
		internal static int __PropertyOffset_bPackageDataInsideApk;

		// Token: 0x04000E88 RID: 3720
		internal static int __PropertyOffset_bCreateAllPlatformsInstall;

		// Token: 0x04000E89 RID: 3721
		internal static int __PropertyOffset_bDisableVerifyOBBOnStartUp;

		// Token: 0x04000E8A RID: 3722
		internal static int __PropertyOffset_bForceSmallOBBFiles;

		// Token: 0x04000E8B RID: 3723
		internal static int __PropertyOffset_bAllowLargeOBBFiles;

		// Token: 0x04000E8C RID: 3724
		internal static int __PropertyOffset_bAllowPatchOBBFile;

		// Token: 0x04000E8D RID: 3725
		internal static int __PropertyOffset_bAllowOverflowOBBFiles;

		// Token: 0x04000E8E RID: 3726
		internal static int __PropertyOffset_bUseExternalFilesDir;

		// Token: 0x04000E8F RID: 3727
		internal static int __PropertyOffset_bPublicLogFiles;

		// Token: 0x04000E90 RID: 3728
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04000E91 RID: 3729
		internal static int __PropertyOffset_MaxAspectRatio;

		// Token: 0x04000E92 RID: 3730
		internal static int __PropertyOffset_bUseDisplayCutout;

		// Token: 0x04000E93 RID: 3731
		internal static int __PropertyOffset_bRestoreNotificationsOnReboot;

		// Token: 0x04000E94 RID: 3732
		internal static int __PropertyOffset_bFullScreen;

		// Token: 0x04000E95 RID: 3733
		internal static int __PropertyOffset_bEnableNewKeyboard;

		// Token: 0x04000E96 RID: 3734
		internal static int __PropertyOffset_DepthBufferPreference;

		// Token: 0x04000E97 RID: 3735
		internal static int __PropertyOffset_bValidateTextureFormats;

		// Token: 0x04000E98 RID: 3736
		internal static int __PropertyOffset_bEnableBundle;

		// Token: 0x04000E99 RID: 3737
		internal static int __PropertyOffset_bEnableUniversalAPK;

		// Token: 0x04000E9A RID: 3738
		internal static int __PropertyOffset_bBundleABISplit;

		// Token: 0x04000E9B RID: 3739
		internal static int __PropertyOffset_bBundleLanguageSplit;

		// Token: 0x04000E9C RID: 3740
		internal static int __PropertyOffset_bBundleDensitySplit;

		// Token: 0x04000E9D RID: 3741
		internal static int __PropertyOffset_ExtraManifestNodeTags;

		// Token: 0x04000E9E RID: 3742
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraManifestNodeTags;

		// Token: 0x04000E9F RID: 3743
		internal static int __PropertyOffset_ExtraApplicationNodeTags;

		// Token: 0x04000EA0 RID: 3744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraApplicationNodeTags;

		// Token: 0x04000EA1 RID: 3745
		internal static int __PropertyOffset_ExtraApplicationSettings;

		// Token: 0x04000EA2 RID: 3746
		internal static int __PropertyOffset_ExtraActivityNodeTags;

		// Token: 0x04000EA3 RID: 3747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraActivityNodeTags;

		// Token: 0x04000EA4 RID: 3748
		internal static int __PropertyOffset_ExtraActivitySettings;

		// Token: 0x04000EA5 RID: 3749
		internal static int __PropertyOffset_ExtraPermissions;

		// Token: 0x04000EA6 RID: 3750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraPermissions;

		// Token: 0x04000EA7 RID: 3751
		internal static int __PropertyOffset_bAndroidVoiceEnabled;

		// Token: 0x04000EA8 RID: 3752
		internal static int __PropertyOffset_PackageForOculusMobile;

		// Token: 0x04000EA9 RID: 3753
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EOculusMobileDevice>> _PackageForOculusMobile;

		// Token: 0x04000EAA RID: 3754
		internal static int __PropertyOffset_bRemoveOSIG;

		// Token: 0x04000EAB RID: 3755
		internal static int __PropertyOffset_GoogleVRCaps;

		// Token: 0x04000EAC RID: 3756
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EGoogleVRCaps>> _GoogleVRCaps;

		// Token: 0x04000EAD RID: 3757
		internal static int __PropertyOffset_bGoogleVRSustainedPerformance;

		// Token: 0x04000EAE RID: 3758
		internal static int __PropertyOffset_KeyStore;

		// Token: 0x04000EAF RID: 3759
		internal static int __PropertyOffset_KeyAlias;

		// Token: 0x04000EB0 RID: 3760
		internal static int __PropertyOffset_KeyStorePassword;

		// Token: 0x04000EB1 RID: 3761
		internal static int __PropertyOffset_KeyPassword;

		// Token: 0x04000EB2 RID: 3762
		internal static int __PropertyOffset_bBuildForArmV7;

		// Token: 0x04000EB3 RID: 3763
		internal static int __PropertyOffset_bBuildForArm64;

		// Token: 0x04000EB4 RID: 3764
		internal static int __PropertyOffset_bBuildForX8664;

		// Token: 0x04000EB5 RID: 3765
		internal static int __PropertyOffset_bBuildForES31;

		// Token: 0x04000EB6 RID: 3766
		internal static int __PropertyOffset_bSupportsVulkan;

		// Token: 0x04000EB7 RID: 3767
		internal static int __PropertyOffset_bSupportsVulkanSM5;

		// Token: 0x04000EB8 RID: 3768
		internal static int __PropertyOffset_bAndroidOpenGLSupportsBackbufferSampling;

		// Token: 0x04000EB9 RID: 3769
		internal static int __PropertyOffset_bDetectVulkanByDefault;

		// Token: 0x04000EBA RID: 3770
		internal static int __PropertyOffset_bBuildWithHiddenSymbolVisibility;

		// Token: 0x04000EBB RID: 3771
		internal static int __PropertyOffset_bSaveSymbols;

		// Token: 0x04000EBC RID: 3772
		internal static int __PropertyOffset_bForceLDLinker;

		// Token: 0x04000EBD RID: 3773
		internal static int __PropertyOffset_bEnableGooglePlaySupport;

		// Token: 0x04000EBE RID: 3774
		internal static int __PropertyOffset_bUseGetAccounts;

		// Token: 0x04000EBF RID: 3775
		internal static int __PropertyOffset_GamesAppID;

		// Token: 0x04000EC0 RID: 3776
		internal static int __PropertyOffset_AchievementMap;

		// Token: 0x04000EC1 RID: 3777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGooglePlayAchievementMapping> _AchievementMap;

		// Token: 0x04000EC2 RID: 3778
		internal static int __PropertyOffset_LeaderboardMap;

		// Token: 0x04000EC3 RID: 3779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGooglePlayLeaderboardMapping> _LeaderboardMap;

		// Token: 0x04000EC4 RID: 3780
		internal static int __PropertyOffset_bEnableSnapshots;

		// Token: 0x04000EC5 RID: 3781
		internal static int __PropertyOffset_bSupportAdMob;

		// Token: 0x04000EC6 RID: 3782
		internal static int __PropertyOffset_AdMobAdUnitID;

		// Token: 0x04000EC7 RID: 3783
		internal static int __PropertyOffset_AdMobAdUnitIDs;

		// Token: 0x04000EC8 RID: 3784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AdMobAdUnitIDs;

		// Token: 0x04000EC9 RID: 3785
		internal static int __PropertyOffset_GooglePlayLicenseKey;

		// Token: 0x04000ECA RID: 3786
		internal static int __PropertyOffset_GCMClientSenderID;

		// Token: 0x04000ECB RID: 3787
		internal static int __PropertyOffset_bShowLaunchImage;

		// Token: 0x04000ECC RID: 3788
		internal static int __PropertyOffset_bAllowIMU;

		// Token: 0x04000ECD RID: 3789
		internal static int __PropertyOffset_bAllowControllers;

		// Token: 0x04000ECE RID: 3790
		internal static int __PropertyOffset_bBlockAndroidKeysOnControllers;

		// Token: 0x04000ECF RID: 3791
		internal static int __PropertyOffset_bControllersBlockDeviceFeedback;

		// Token: 0x04000ED0 RID: 3792
		internal static int __PropertyOffset_AndroidAudio;

		// Token: 0x04000ED1 RID: 3793
		internal static int __PropertyOffset_AudioSampleRate;

		// Token: 0x04000ED2 RID: 3794
		internal static int __PropertyOffset_AudioCallbackBufferFrameSize;

		// Token: 0x04000ED3 RID: 3795
		internal static int __PropertyOffset_AudioNumBuffersToEnqueue;

		// Token: 0x04000ED4 RID: 3796
		internal static int __PropertyOffset_AudioMaxChannels;

		// Token: 0x04000ED5 RID: 3797
		internal static int __PropertyOffset_AudioNumSourceWorkers;

		// Token: 0x04000ED6 RID: 3798
		internal static int __PropertyOffset_SpatializationPlugin;

		// Token: 0x04000ED7 RID: 3799
		internal static int __PropertyOffset_ReverbPlugin;

		// Token: 0x04000ED8 RID: 3800
		internal static int __PropertyOffset_OcclusionPlugin;

		// Token: 0x04000ED9 RID: 3801
		internal static int __PropertyOffset_CompressionOverrides;

		// Token: 0x04000EDA RID: 3802
		[Nullable(2)]
		private FPlatformRuntimeAudioCompressionOverrides _CompressionOverrides;

		// Token: 0x04000EDB RID: 3803
		internal static int __PropertyOffset_bUseAudioStreamCaching;

		// Token: 0x04000EDC RID: 3804
		internal static int __PropertyOffset_CacheSizeKB;

		// Token: 0x04000EDD RID: 3805
		internal static int __PropertyOffset_MaxChunkSizeOverrideKB;

		// Token: 0x04000EDE RID: 3806
		internal static int __PropertyOffset_bResampleForDevice;

		// Token: 0x04000EDF RID: 3807
		internal static int __PropertyOffset_SoundCueCookQualityIndex;

		// Token: 0x04000EE0 RID: 3808
		internal static int __PropertyOffset_MaxSampleRate;

		// Token: 0x04000EE1 RID: 3809
		internal static int __PropertyOffset_HighSampleRate;

		// Token: 0x04000EE2 RID: 3810
		internal static int __PropertyOffset_MedSampleRate;

		// Token: 0x04000EE3 RID: 3811
		internal static int __PropertyOffset_LowSampleRate;

		// Token: 0x04000EE4 RID: 3812
		internal static int __PropertyOffset_MinSampleRate;

		// Token: 0x04000EE5 RID: 3813
		internal static int __PropertyOffset_CompressionQualityModifier;

		// Token: 0x04000EE6 RID: 3814
		internal static int __PropertyOffset_AutoStreamingThreshold;

		// Token: 0x04000EE7 RID: 3815
		internal static int __PropertyOffset_AndroidGraphicsDebugger;

		// Token: 0x04000EE8 RID: 3816
		internal static int __PropertyOffset_MaliGraphicsDebuggerPath;

		// Token: 0x04000EE9 RID: 3817
		[Nullable(2)]
		private FDirectoryPath _MaliGraphicsDebuggerPath;

		// Token: 0x04000EEA RID: 3818
		internal static int __PropertyOffset_bMultiTargetFormat_ETC2;

		// Token: 0x04000EEB RID: 3819
		internal static int __PropertyOffset_bMultiTargetFormat_DXT;

		// Token: 0x04000EEC RID: 3820
		internal static int __PropertyOffset_bMultiTargetFormat_ASTC;

		// Token: 0x04000EED RID: 3821
		internal static int __PropertyOffset_TextureFormatPriority_ETC2;

		// Token: 0x04000EEE RID: 3822
		internal static int __PropertyOffset_TextureFormatPriority_DXT;

		// Token: 0x04000EEF RID: 3823
		internal static int __PropertyOffset_TextureFormatPriority_ASTC;

		// Token: 0x04000EF0 RID: 3824
		internal static int __PropertyOffset_SDKAPILevelOverride;

		// Token: 0x04000EF1 RID: 3825
		internal static int __PropertyOffset_NDKAPILevelOverride;

		// Token: 0x04000EF2 RID: 3826
		internal static int __PropertyOffset_BuildToolsOverride;

		// Token: 0x04000EF3 RID: 3827
		internal static int __PropertyOffset_bStreamLandscapeMeshLODs;
	}
}
