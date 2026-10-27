using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023F RID: 575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSettings")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class UAkSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x00031D40 File Offset: 0x0002FF40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSettings._ClassPtr;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00031D4C File Offset: 0x0002FF4C
		public UAkSettings() : this(BuiltinUtils.AllocNativeUObject(UAkSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00031D74 File Offset: 0x0002FF74
		public UAkSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x00031DA7 File Offset: 0x0002FFA7
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x00031DB7 File Offset: 0x0002FFB7
		public unsafe byte MaxSimultaneousReverbVolumes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_MaxSimultaneousReverbVolumes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_MaxSimultaneousReverbVolumes) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x00031DC8 File Offset: 0x0002FFC8
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x00031E01 File Offset: 0x00030001
		public FFilePath WwiseProjectPath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._WwiseProjectPath) == null)
				{
					result = (this._WwiseProjectPath = new FFilePath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseProjectPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseProjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00031E24 File Offset: 0x00030024
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x00031E5D File Offset: 0x0003005D
		public FDirectoryPath WwiseSoundDataFolder
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._WwiseSoundDataFolder) == null)
				{
					result = (this._WwiseSoundDataFolder = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseSoundDataFolder, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseSoundDataFolder, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x00031E80 File Offset: 0x00030080
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x00031EB9 File Offset: 0x000300B9
		public FDirectoryPath GeneratedSoundBanksFolder
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._GeneratedSoundBanksFolder) == null)
				{
					result = (this._GeneratedSoundBanksFolder = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_GeneratedSoundBanksFolder, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_GeneratedSoundBanksFolder, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x00031EDC File Offset: 0x000300DC
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00031F15 File Offset: 0x00030115
		public FDirectoryPath WwiseStagingDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._WwiseStagingDirectory) == null)
				{
					result = (this._WwiseStagingDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseStagingDirectory, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseStagingDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00031F36 File Offset: 0x00030136
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00031F46 File Offset: 0x00030146
		public unsafe bool bSoundBanksTransfered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bSoundBanksTransfered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bSoundBanksTransfered) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00031F57 File Offset: 0x00030157
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00031F67 File Offset: 0x00030167
		public unsafe bool bAssetsMigrated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAssetsMigrated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAssetsMigrated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00031F78 File Offset: 0x00030178
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00031F88 File Offset: 0x00030188
		public unsafe bool bProjectMigrated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bProjectMigrated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bProjectMigrated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00031F99 File Offset: 0x00030199
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00031FA9 File Offset: 0x000301A9
		public unsafe bool bAutoConnectToWAAPI_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAutoConnectToWAAPI_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAutoConnectToWAAPI_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00031FBA File Offset: 0x000301BA
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00031FCE File Offset: 0x000301CE
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> DefaultOcclusionCollisionChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultOcclusionCollisionChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultOcclusionCollisionChannel) = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00031FE3 File Offset: 0x000301E3
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00031FF7 File Offset: 0x000301F7
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> DefaultFitToGeometryCollisionChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultFitToGeometryCollisionChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultFitToGeometryCollisionChannel) = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0003200C File Offset: 0x0003020C
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00032045 File Offset: 0x00030245
		public TMap<TSoftObjectPtr<UPhysicalMaterial>, FAkGeometrySurfacePropertiesToMap> AkGeometryMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UPhysicalMaterial>, FAkGeometrySurfacePropertiesToMap> result;
				if ((result = this._AkGeometryMap) == null)
				{
					result = (this._AkGeometryMap = new TMap<TSoftObjectPtr<UPhysicalMaterial>, FAkGeometrySurfacePropertiesToMap>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AkGeometryMap, this));
				}
				return result;
			}
			set
			{
				this.AkGeometryMap.CopyAssign(value);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00032053 File Offset: 0x00030253
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00032063 File Offset: 0x00030263
		public unsafe float GlobalDecayAbsorption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_GlobalDecayAbsorption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_GlobalDecayAbsorption) = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00032074 File Offset: 0x00030274
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00032089 File Offset: 0x00030289
		public TSoftObjectPtr<UAkAuxBus> DefaultReverbAuxBus
		{
			get
			{
				return new TSoftObjectPtr<UAkAuxBus>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultReverbAuxBus, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DefaultReverbAuxBus, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000320B0 File Offset: 0x000302B0
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x000320E9 File Offset: 0x000302E9
		public TMap<float, TSoftObjectPtr<UAkAuxBus>> EnvironmentDecayAuxBusMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<float, TSoftObjectPtr<UAkAuxBus>> result;
				if ((result = this._EnvironmentDecayAuxBusMap) == null)
				{
					result = (this._EnvironmentDecayAuxBusMap = new TMap<float, TSoftObjectPtr<UAkAuxBus>>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_EnvironmentDecayAuxBusMap, this));
				}
				return result;
			}
			set
			{
				this.EnvironmentDecayAuxBusMap.CopyAssign(value);
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000320F7 File Offset: 0x000302F7
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0003210B File Offset: 0x0003030B
		public unsafe string HFDampingName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_HFDampingName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_HFDampingName)), value);
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00032120 File Offset: 0x00030320
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x00032134 File Offset: 0x00030334
		public unsafe string DecayEstimateName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_DecayEstimateName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_DecayEstimateName)), value);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00032149 File Offset: 0x00030349
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x0003215D File Offset: 0x0003035D
		public unsafe string TimeToFirstReflectionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_TimeToFirstReflectionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_TimeToFirstReflectionName)), value);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00032172 File Offset: 0x00030372
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00032187 File Offset: 0x00030387
		public TSoftObjectPtr<UAkRtpc> HFDampingRTPC
		{
			get
			{
				return new TSoftObjectPtr<UAkRtpc>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_HFDampingRTPC, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_HFDampingRTPC, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x000321AC File Offset: 0x000303AC
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x000321C1 File Offset: 0x000303C1
		public TSoftObjectPtr<UAkRtpc> DecayEstimateRTPC
		{
			get
			{
				return new TSoftObjectPtr<UAkRtpc>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DecayEstimateRTPC, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_DecayEstimateRTPC, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000321E6 File Offset: 0x000303E6
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x000321FB File Offset: 0x000303FB
		public TSoftObjectPtr<UAkRtpc> TimeToFirstReflectionRTPC
		{
			get
			{
				return new TSoftObjectPtr<UAkRtpc>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_TimeToFirstReflectionRTPC, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_TimeToFirstReflectionRTPC, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00032220 File Offset: 0x00030420
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00032235 File Offset: 0x00030435
		public TSoftObjectPtr<UAkAudioEvent> AudioInputEvent
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AudioInputEvent, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AudioInputEvent, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x0003225C File Offset: 0x0003045C
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00032295 File Offset: 0x00030495
		public TMap<FGuid, FAkAcousticTextureParams> AcousticTextureParamsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FAkAcousticTextureParams> result;
				if ((result = this._AcousticTextureParamsMap) == null)
				{
					result = (this._AcousticTextureParamsMap = new TMap<FGuid, FAkAcousticTextureParams>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AcousticTextureParamsMap, this));
				}
				return result;
			}
			set
			{
				this.AcousticTextureParamsMap.CopyAssign(value);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000322A3 File Offset: 0x000304A3
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x000322B3 File Offset: 0x000304B3
		public unsafe bool SplitSwitchContainerMedia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_SplitSwitchContainerMedia) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_SplitSwitchContainerMedia) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000322C4 File Offset: 0x000304C4
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x000322D4 File Offset: 0x000304D4
		public unsafe bool SplitMediaPerFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_SplitMediaPerFolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_SplitMediaPerFolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000322E5 File Offset: 0x000304E5
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x000322F5 File Offset: 0x000304F5
		public unsafe bool UseEventBasedPackaging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_UseEventBasedPackaging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_UseEventBasedPackaging) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00032306 File Offset: 0x00030506
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x0003231A File Offset: 0x0003051A
		public unsafe string CommandletCommitMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_CommandletCommitMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_CommandletCommitMessage)), value);
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x00032330 File Offset: 0x00030530
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00032369 File Offset: 0x00030569
		public TMap<string, string> UnrealCultureToWwiseCulture
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._UnrealCultureToWwiseCulture) == null)
				{
					result = (this._UnrealCultureToWwiseCulture = new TMap<string, string>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_UnrealCultureToWwiseCulture, this));
				}
				return result;
			}
			set
			{
				this.UnrealCultureToWwiseCulture.CopyAssign(value);
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00032377 File Offset: 0x00030577
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0003238B File Offset: 0x0003058B
		public unsafe string DefaultAssetCreationPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_DefaultAssetCreationPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettings.__PropertyOffset_DefaultAssetCreationPath)), value);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000323A0 File Offset: 0x000305A0
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x000323B5 File Offset: 0x000305B5
		public TSoftObjectPtr<UAkInitBank> InitBank
		{
			get
			{
				return new TSoftObjectPtr<UAkInitBank>(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_InitBank, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_InitBank, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000323DA File Offset: 0x000305DA
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000323EA File Offset: 0x000305EA
		public unsafe EAkUnrealAudioRouting AudioRouting
		{
			get
			{
				return (EAkUnrealAudioRouting)(*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AudioRouting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AudioRouting) = (int)value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000323FB File Offset: 0x000305FB
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x0003240B File Offset: 0x0003060B
		public unsafe bool bWwiseSoundEngineEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bWwiseSoundEngineEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bWwiseSoundEngineEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x0003241C File Offset: 0x0003061C
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0003242C File Offset: 0x0003062C
		public unsafe bool bWwiseAudioLinkEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bWwiseAudioLinkEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bWwiseAudioLinkEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0003243D File Offset: 0x0003063D
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x0003244D File Offset: 0x0003064D
		public unsafe bool bAkAudioMixerEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAkAudioMixerEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bAkAudioMixerEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x0003245E File Offset: 0x0003065E
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0003246E File Offset: 0x0003066E
		public unsafe bool AskedToUseNewAssetManagement_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AskedToUseNewAssetManagement_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_AskedToUseNewAssetManagement_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0003247F File Offset: 0x0003067F
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0003248F File Offset: 0x0003068F
		public unsafe bool bEnableMultiCoreRendering_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bEnableMultiCoreRendering_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_bEnableMultiCoreRendering_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x000324A0 File Offset: 0x000306A0
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x000324B0 File Offset: 0x000306B0
		public unsafe bool MigratedEnableMultiCoreRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_MigratedEnableMultiCoreRendering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_MigratedEnableMultiCoreRendering) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000324C1 File Offset: 0x000306C1
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x000324D1 File Offset: 0x000306D1
		public unsafe bool FixupRedirectorsDuringMigration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_FixupRedirectorsDuringMigration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_FixupRedirectorsDuringMigration) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000324E4 File Offset: 0x000306E4
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x0003251D File Offset: 0x0003071D
		public FDirectoryPath WwiseWindowsInstallationPath_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._WwiseWindowsInstallationPath_DEPRECATED) == null)
				{
					result = (this._WwiseWindowsInstallationPath_DEPRECATED = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseWindowsInstallationPath_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseWindowsInstallationPath_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00032540 File Offset: 0x00030740
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x00032579 File Offset: 0x00030779
		public FFilePath WwiseMacInstallationPath_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._WwiseMacInstallationPath_DEPRECATED) == null)
				{
					result = (this._WwiseMacInstallationPath_DEPRECATED = new FFilePath(base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseMacInstallationPath_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettings.__PropertyOffset_WwiseMacInstallationPath_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0003259A File Offset: 0x0003079A
		static UAkSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSettings");
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000325A8 File Offset: 0x000307A8
		protected UAkSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B66 RID: 2918
		public new const string __ObjectPath = "/Script/AkAudio.AkSettings";

		// Token: 0x04000B67 RID: 2919
		private static IntPtr _ClassPtr;

		// Token: 0x04000B68 RID: 2920
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B69 RID: 2921
		internal static int __PropertyOffset_MaxSimultaneousReverbVolumes;

		// Token: 0x04000B6A RID: 2922
		internal static int __PropertyOffset_WwiseProjectPath;

		// Token: 0x04000B6B RID: 2923
		[Nullable(2)]
		private FFilePath _WwiseProjectPath;

		// Token: 0x04000B6C RID: 2924
		internal static int __PropertyOffset_WwiseSoundDataFolder;

		// Token: 0x04000B6D RID: 2925
		[Nullable(2)]
		private FDirectoryPath _WwiseSoundDataFolder;

		// Token: 0x04000B6E RID: 2926
		internal static int __PropertyOffset_GeneratedSoundBanksFolder;

		// Token: 0x04000B6F RID: 2927
		[Nullable(2)]
		private FDirectoryPath _GeneratedSoundBanksFolder;

		// Token: 0x04000B70 RID: 2928
		internal static int __PropertyOffset_WwiseStagingDirectory;

		// Token: 0x04000B71 RID: 2929
		[Nullable(2)]
		private FDirectoryPath _WwiseStagingDirectory;

		// Token: 0x04000B72 RID: 2930
		internal static int __PropertyOffset_bSoundBanksTransfered;

		// Token: 0x04000B73 RID: 2931
		internal static int __PropertyOffset_bAssetsMigrated;

		// Token: 0x04000B74 RID: 2932
		internal static int __PropertyOffset_bProjectMigrated;

		// Token: 0x04000B75 RID: 2933
		internal static int __PropertyOffset_bAutoConnectToWAAPI_DEPRECATED;

		// Token: 0x04000B76 RID: 2934
		internal static int __PropertyOffset_DefaultOcclusionCollisionChannel;

		// Token: 0x04000B77 RID: 2935
		internal static int __PropertyOffset_DefaultFitToGeometryCollisionChannel;

		// Token: 0x04000B78 RID: 2936
		internal static int __PropertyOffset_AkGeometryMap;

		// Token: 0x04000B79 RID: 2937
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UPhysicalMaterial>, FAkGeometrySurfacePropertiesToMap> _AkGeometryMap;

		// Token: 0x04000B7A RID: 2938
		internal static int __PropertyOffset_GlobalDecayAbsorption;

		// Token: 0x04000B7B RID: 2939
		internal static int __PropertyOffset_DefaultReverbAuxBus;

		// Token: 0x04000B7C RID: 2940
		internal static int __PropertyOffset_EnvironmentDecayAuxBusMap;

		// Token: 0x04000B7D RID: 2941
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<float, TSoftObjectPtr<UAkAuxBus>> _EnvironmentDecayAuxBusMap;

		// Token: 0x04000B7E RID: 2942
		internal static int __PropertyOffset_HFDampingName;

		// Token: 0x04000B7F RID: 2943
		internal static int __PropertyOffset_DecayEstimateName;

		// Token: 0x04000B80 RID: 2944
		internal static int __PropertyOffset_TimeToFirstReflectionName;

		// Token: 0x04000B81 RID: 2945
		internal static int __PropertyOffset_HFDampingRTPC;

		// Token: 0x04000B82 RID: 2946
		internal static int __PropertyOffset_DecayEstimateRTPC;

		// Token: 0x04000B83 RID: 2947
		internal static int __PropertyOffset_TimeToFirstReflectionRTPC;

		// Token: 0x04000B84 RID: 2948
		internal static int __PropertyOffset_AudioInputEvent;

		// Token: 0x04000B85 RID: 2949
		internal static int __PropertyOffset_AcousticTextureParamsMap;

		// Token: 0x04000B86 RID: 2950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, FAkAcousticTextureParams> _AcousticTextureParamsMap;

		// Token: 0x04000B87 RID: 2951
		internal static int __PropertyOffset_SplitSwitchContainerMedia;

		// Token: 0x04000B88 RID: 2952
		internal static int __PropertyOffset_SplitMediaPerFolder;

		// Token: 0x04000B89 RID: 2953
		internal static int __PropertyOffset_UseEventBasedPackaging;

		// Token: 0x04000B8A RID: 2954
		internal static int __PropertyOffset_CommandletCommitMessage;

		// Token: 0x04000B8B RID: 2955
		internal static int __PropertyOffset_UnrealCultureToWwiseCulture;

		// Token: 0x04000B8C RID: 2956
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _UnrealCultureToWwiseCulture;

		// Token: 0x04000B8D RID: 2957
		internal static int __PropertyOffset_DefaultAssetCreationPath;

		// Token: 0x04000B8E RID: 2958
		internal static int __PropertyOffset_InitBank;

		// Token: 0x04000B8F RID: 2959
		internal static int __PropertyOffset_AudioRouting;

		// Token: 0x04000B90 RID: 2960
		internal static int __PropertyOffset_bWwiseSoundEngineEnabled;

		// Token: 0x04000B91 RID: 2961
		internal static int __PropertyOffset_bWwiseAudioLinkEnabled;

		// Token: 0x04000B92 RID: 2962
		internal static int __PropertyOffset_bAkAudioMixerEnabled;

		// Token: 0x04000B93 RID: 2963
		internal static int __PropertyOffset_AskedToUseNewAssetManagement_DEPRECATED;

		// Token: 0x04000B94 RID: 2964
		internal static int __PropertyOffset_bEnableMultiCoreRendering_DEPRECATED;

		// Token: 0x04000B95 RID: 2965
		internal static int __PropertyOffset_MigratedEnableMultiCoreRendering;

		// Token: 0x04000B96 RID: 2966
		internal static int __PropertyOffset_FixupRedirectorsDuringMigration;

		// Token: 0x04000B97 RID: 2967
		internal static int __PropertyOffset_WwiseWindowsInstallationPath_DEPRECATED;

		// Token: 0x04000B98 RID: 2968
		[Nullable(2)]
		private FDirectoryPath _WwiseWindowsInstallationPath_DEPRECATED;

		// Token: 0x04000B99 RID: 2969
		internal static int __PropertyOffset_WwiseMacInstallationPath_DEPRECATED;

		// Token: 0x04000B9A RID: 2970
		[Nullable(2)]
		private FFilePath _WwiseMacInstallationPath_DEPRECATED;
	}
}
