using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001406 RID: 5126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKTargetSettings")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public abstract class UGDKTargetSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012B17 RID: 76567 RVA: 0x001B8479 File Offset: 0x001B6679
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGDKTargetSettings._ClassPtr;
		}

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06012B18 RID: 76568 RVA: 0x001B8485 File Offset: 0x001B6685
		// (set) Token: 0x06012B19 RID: 76569 RVA: 0x001B8495 File Offset: 0x001B6695
		public unsafe bool bEnablePIXProfiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bEnablePIXProfiling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bEnablePIXProfiling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x06012B1A RID: 76570 RVA: 0x001B84A6 File Offset: 0x001B66A6
		// (set) Token: 0x06012B1B RID: 76571 RVA: 0x001B84B6 File Offset: 0x001B66B6
		public unsafe EGDKForegroundColor ApplicationForegroundColor
		{
			get
			{
				return (EGDKForegroundColor)(*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ApplicationForegroundColor));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ApplicationForegroundColor) = (byte)value;
			}
		}

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x06012B1C RID: 76572 RVA: 0x001B84C7 File Offset: 0x001B66C7
		// (set) Token: 0x06012B1D RID: 76573 RVA: 0x001B84DB File Offset: 0x001B66DB
		public unsafe FColor ApplicationBackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ApplicationBackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ApplicationBackgroundColor) = value;
			}
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06012B1E RID: 76574 RVA: 0x001B84F0 File Offset: 0x001B66F0
		// (set) Token: 0x06012B1F RID: 76575 RVA: 0x001B8529 File Offset: 0x001B6729
		public FGDKPackageStringResources CultureStringResources
		{
			get
			{
				base.FastCheckIsValid();
				FGDKPackageStringResources result;
				if ((result = this._CultureStringResources) == null)
				{
					result = (this._CultureStringResources = new FGDKPackageStringResources(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CultureStringResources, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGDKPackageStringResources.StaticStruct(), base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CultureStringResources, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06012B20 RID: 76576 RVA: 0x001B854A File Offset: 0x001B674A
		// (set) Token: 0x06012B21 RID: 76577 RVA: 0x001B855E File Offset: 0x001B675E
		public unsafe FGDKPackageImageResources CultureImageResources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CultureImageResources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CultureImageResources) = value;
			}
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x06012B22 RID: 76578 RVA: 0x001B8573 File Offset: 0x001B6773
		// (set) Token: 0x06012B23 RID: 76579 RVA: 0x001B8583 File Offset: 0x001B6783
		public unsafe bool bEnableAutoResourcePacks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bEnableAutoResourcePacks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bEnableAutoResourcePacks) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x06012B24 RID: 76580 RVA: 0x001B8594 File Offset: 0x001B6794
		// (set) Token: 0x06012B25 RID: 76581 RVA: 0x001B85CD File Offset: 0x001B67CD
		public TArray<FGDKLocalizedPackageResources> PerCultureResources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGDKLocalizedPackageResources> result;
				if ((result = this._PerCultureResources) == null)
				{
					result = (this._PerCultureResources = new TArray<FGDKLocalizedPackageResources>(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_PerCultureResources, this));
				}
				return result;
			}
			set
			{
				this.PerCultureResources.CopyAssign(value);
			}
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x06012B26 RID: 76582 RVA: 0x001B85DB File Offset: 0x001B67DB
		// (set) Token: 0x06012B27 RID: 76583 RVA: 0x001B85EB File Offset: 0x001B67EB
		public unsafe bool bRequireXboxLive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bRequireXboxLive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bRequireXboxLive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x06012B28 RID: 76584 RVA: 0x001B85FC File Offset: 0x001B67FC
		// (set) Token: 0x06012B29 RID: 76585 RVA: 0x001B8610 File Offset: 0x001B6810
		public unsafe string DefaultDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_DefaultDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_DefaultDisplayName)), value);
			}
		}

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06012B2A RID: 76586 RVA: 0x001B8625 File Offset: 0x001B6825
		// (set) Token: 0x06012B2B RID: 76587 RVA: 0x001B8639 File Offset: 0x001B6839
		public unsafe string PublisherDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PublisherDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PublisherDisplayName)), value);
			}
		}

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06012B2C RID: 76588 RVA: 0x001B864E File Offset: 0x001B684E
		// (set) Token: 0x06012B2D RID: 76589 RVA: 0x001B8662 File Offset: 0x001B6862
		public unsafe string TitleId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_TitleId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_TitleId)), value);
			}
		}

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06012B2E RID: 76590 RVA: 0x001B8677 File Offset: 0x001B6877
		// (set) Token: 0x06012B2F RID: 76591 RVA: 0x001B868B File Offset: 0x001B688B
		public unsafe string PrimaryServiceConfigId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PrimaryServiceConfigId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PrimaryServiceConfigId)), value);
			}
		}

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06012B30 RID: 76592 RVA: 0x001B86A0 File Offset: 0x001B68A0
		// (set) Token: 0x06012B31 RID: 76593 RVA: 0x001B86B4 File Offset: 0x001B68B4
		public unsafe string ProductId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ProductId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ProductId)), value);
			}
		}

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06012B32 RID: 76594 RVA: 0x001B86C9 File Offset: 0x001B68C9
		// (set) Token: 0x06012B33 RID: 76595 RVA: 0x001B86DD File Offset: 0x001B68DD
		public unsafe string ContentId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ContentId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ContentId)), value);
			}
		}

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06012B34 RID: 76596 RVA: 0x001B86F2 File Offset: 0x001B68F2
		// (set) Token: 0x06012B35 RID: 76597 RVA: 0x001B8706 File Offset: 0x001B6906
		public unsafe string StoreId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_StoreId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_StoreId)), value);
			}
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06012B36 RID: 76598 RVA: 0x001B871B File Offset: 0x001B691B
		// (set) Token: 0x06012B37 RID: 76599 RVA: 0x001B872F File Offset: 0x001B692F
		public unsafe string PackageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PackageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PackageName)), value);
			}
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06012B38 RID: 76600 RVA: 0x001B8744 File Offset: 0x001B6944
		// (set) Token: 0x06012B39 RID: 76601 RVA: 0x001B8758 File Offset: 0x001B6958
		public unsafe string PublisherName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PublisherName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PublisherName)), value);
			}
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06012B3A RID: 76602 RVA: 0x001B876D File Offset: 0x001B696D
		// (set) Token: 0x06012B3B RID: 76603 RVA: 0x001B8781 File Offset: 0x001B6981
		public unsafe string PackageVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PackageVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_PackageVersion)), value);
			}
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06012B3C RID: 76604 RVA: 0x001B8796 File Offset: 0x001B6996
		// (set) Token: 0x06012B3D RID: 76605 RVA: 0x001B87A6 File Offset: 0x001B69A6
		public unsafe bool bIncludeEngineVersionInPackageVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bIncludeEngineVersionInPackageVersion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bIncludeEngineVersionInPackageVersion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06012B3E RID: 76606 RVA: 0x001B87B7 File Offset: 0x001B69B7
		// (set) Token: 0x06012B3F RID: 76607 RVA: 0x001B87C7 File Offset: 0x001B69C7
		public unsafe bool bSubmissionValidatorExpirationError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bSubmissionValidatorExpirationError) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bSubmissionValidatorExpirationError) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06012B40 RID: 76608 RVA: 0x001B87D8 File Offset: 0x001B69D8
		// (set) Token: 0x06012B41 RID: 76609 RVA: 0x001B8811 File Offset: 0x001B6A11
		public TArray<FGDKIntelligentInstallChunk> IntelligentInstallChunk
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGDKIntelligentInstallChunk> result;
				if ((result = this._IntelligentInstallChunk) == null)
				{
					result = (this._IntelligentInstallChunk = new TArray<FGDKIntelligentInstallChunk>(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_IntelligentInstallChunk, this));
				}
				return result;
			}
			set
			{
				this.IntelligentInstallChunk.CopyAssign(value);
			}
		}

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06012B42 RID: 76610 RVA: 0x001B8820 File Offset: 0x001B6A20
		// (set) Token: 0x06012B43 RID: 76611 RVA: 0x001B8859 File Offset: 0x001B6A59
		public TArray<FGDKCustomChunkMapping> CustomChunkMapping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGDKCustomChunkMapping> result;
				if ((result = this._CustomChunkMapping) == null)
				{
					result = (this._CustomChunkMapping = new TArray<FGDKCustomChunkMapping>(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CustomChunkMapping, this));
				}
				return result;
			}
			set
			{
				this.CustomChunkMapping.CopyAssign(value);
			}
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06012B44 RID: 76612 RVA: 0x001B8867 File Offset: 0x001B6A67
		// (set) Token: 0x06012B45 RID: 76613 RVA: 0x001B8877 File Offset: 0x001B6A77
		public unsafe bool bSkipAppIdSuffixForShippingConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bSkipAppIdSuffixForShippingConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bSkipAppIdSuffixForShippingConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06012B46 RID: 76614 RVA: 0x001B8888 File Offset: 0x001B6A88
		// (set) Token: 0x06012B47 RID: 76615 RVA: 0x001B8898 File Offset: 0x001B6A98
		public unsafe bool bBlockGameDVR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bBlockGameDVR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bBlockGameDVR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06012B48 RID: 76616 RVA: 0x001B88A9 File Offset: 0x001B6AA9
		// (set) Token: 0x06012B49 RID: 76617 RVA: 0x001B88B9 File Offset: 0x001B6AB9
		public unsafe bool bBlockBroadcasting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bBlockBroadcasting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bBlockBroadcasting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06012B4A RID: 76618 RVA: 0x001B88CA File Offset: 0x001B6ACA
		// (set) Token: 0x06012B4B RID: 76619 RVA: 0x001B88DA File Offset: 0x001B6ADA
		public unsafe int AudioSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioSampleRate) = value;
			}
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06012B4C RID: 76620 RVA: 0x001B88EB File Offset: 0x001B6AEB
		// (set) Token: 0x06012B4D RID: 76621 RVA: 0x001B88FB File Offset: 0x001B6AFB
		public unsafe int AudioCallbackBufferFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioCallbackBufferFrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioCallbackBufferFrameSize) = value;
			}
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06012B4E RID: 76622 RVA: 0x001B890C File Offset: 0x001B6B0C
		// (set) Token: 0x06012B4F RID: 76623 RVA: 0x001B891C File Offset: 0x001B6B1C
		public unsafe int AudioNumBuffersToEnqueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioNumBuffersToEnqueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioNumBuffersToEnqueue) = value;
			}
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06012B50 RID: 76624 RVA: 0x001B892D File Offset: 0x001B6B2D
		// (set) Token: 0x06012B51 RID: 76625 RVA: 0x001B893D File Offset: 0x001B6B3D
		public unsafe int AudioMaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioMaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioMaxChannels) = value;
			}
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06012B52 RID: 76626 RVA: 0x001B894E File Offset: 0x001B6B4E
		// (set) Token: 0x06012B53 RID: 76627 RVA: 0x001B895E File Offset: 0x001B6B5E
		public unsafe int AudioNumSourceWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioNumSourceWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AudioNumSourceWorkers) = value;
			}
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06012B54 RID: 76628 RVA: 0x001B896F File Offset: 0x001B6B6F
		// (set) Token: 0x06012B55 RID: 76629 RVA: 0x001B8983 File Offset: 0x001B6B83
		public unsafe string SpatializationPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_SpatializationPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_SpatializationPlugin)), value);
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06012B56 RID: 76630 RVA: 0x001B8998 File Offset: 0x001B6B98
		// (set) Token: 0x06012B57 RID: 76631 RVA: 0x001B89AC File Offset: 0x001B6BAC
		public unsafe string ReverbPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ReverbPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_ReverbPlugin)), value);
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06012B58 RID: 76632 RVA: 0x001B89C1 File Offset: 0x001B6BC1
		// (set) Token: 0x06012B59 RID: 76633 RVA: 0x001B89D5 File Offset: 0x001B6BD5
		public unsafe string OcclusionPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_OcclusionPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGDKTargetSettings.__PropertyOffset_OcclusionPlugin)), value);
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06012B5A RID: 76634 RVA: 0x001B89EC File Offset: 0x001B6BEC
		// (set) Token: 0x06012B5B RID: 76635 RVA: 0x001B8A25 File Offset: 0x001B6C25
		public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRuntimeAudioCompressionOverrides result;
				if ((result = this._CompressionOverrides) == null)
				{
					result = (this._CompressionOverrides = new FPlatformRuntimeAudioCompressionOverrides(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CompressionOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformRuntimeAudioCompressionOverrides.StaticStruct(), base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CompressionOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06012B5C RID: 76636 RVA: 0x001B8A46 File Offset: 0x001B6C46
		// (set) Token: 0x06012B5D RID: 76637 RVA: 0x001B8A56 File Offset: 0x001B6C56
		public unsafe int ChunkSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ChunkSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_ChunkSizeKB) = value;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06012B5E RID: 76638 RVA: 0x001B8A67 File Offset: 0x001B6C67
		// (set) Token: 0x06012B5F RID: 76639 RVA: 0x001B8A77 File Offset: 0x001B6C77
		public unsafe bool bUseAudioStreamCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bUseAudioStreamCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bUseAudioStreamCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06012B60 RID: 76640 RVA: 0x001B8A88 File Offset: 0x001B6C88
		// (set) Token: 0x06012B61 RID: 76641 RVA: 0x001B8A98 File Offset: 0x001B6C98
		public unsafe int CacheSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CacheSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CacheSizeKB) = value;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06012B62 RID: 76642 RVA: 0x001B8AA9 File Offset: 0x001B6CA9
		// (set) Token: 0x06012B63 RID: 76643 RVA: 0x001B8AB9 File Offset: 0x001B6CB9
		public unsafe int MaxChunkSizeOverrideKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MaxChunkSizeOverrideKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MaxChunkSizeOverrideKB) = value;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06012B64 RID: 76644 RVA: 0x001B8ACA File Offset: 0x001B6CCA
		// (set) Token: 0x06012B65 RID: 76645 RVA: 0x001B8ADA File Offset: 0x001B6CDA
		public unsafe bool bResampleForDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bResampleForDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_bResampleForDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06012B66 RID: 76646 RVA: 0x001B8AEB File Offset: 0x001B6CEB
		// (set) Token: 0x06012B67 RID: 76647 RVA: 0x001B8AFB File Offset: 0x001B6CFB
		public unsafe float MaxSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MaxSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MaxSampleRate) = value;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06012B68 RID: 76648 RVA: 0x001B8B0C File Offset: 0x001B6D0C
		// (set) Token: 0x06012B69 RID: 76649 RVA: 0x001B8B1C File Offset: 0x001B6D1C
		public unsafe float HighSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_HighSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_HighSampleRate) = value;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06012B6A RID: 76650 RVA: 0x001B8B2D File Offset: 0x001B6D2D
		// (set) Token: 0x06012B6B RID: 76651 RVA: 0x001B8B3D File Offset: 0x001B6D3D
		public unsafe float MedSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MedSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MedSampleRate) = value;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06012B6C RID: 76652 RVA: 0x001B8B4E File Offset: 0x001B6D4E
		// (set) Token: 0x06012B6D RID: 76653 RVA: 0x001B8B5E File Offset: 0x001B6D5E
		public unsafe float LowSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_LowSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_LowSampleRate) = value;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06012B6E RID: 76654 RVA: 0x001B8B6F File Offset: 0x001B6D6F
		// (set) Token: 0x06012B6F RID: 76655 RVA: 0x001B8B7F File Offset: 0x001B6D7F
		public unsafe float MinSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MinSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_MinSampleRate) = value;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06012B70 RID: 76656 RVA: 0x001B8B90 File Offset: 0x001B6D90
		// (set) Token: 0x06012B71 RID: 76657 RVA: 0x001B8BA0 File Offset: 0x001B6DA0
		public unsafe float CompressionQualityModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CompressionQualityModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_CompressionQualityModifier) = value;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06012B72 RID: 76658 RVA: 0x001B8BB1 File Offset: 0x001B6DB1
		// (set) Token: 0x06012B73 RID: 76659 RVA: 0x001B8BC1 File Offset: 0x001B6DC1
		public unsafe float AutoStreamingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AutoStreamingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_AutoStreamingThreshold) = value;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06012B74 RID: 76660 RVA: 0x001B8BD2 File Offset: 0x001B6DD2
		// (set) Token: 0x06012B75 RID: 76661 RVA: 0x001B8BE2 File Offset: 0x001B6DE2
		public unsafe int SoundCueCookQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_SoundCueCookQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGDKTargetSettings.__PropertyOffset_SoundCueCookQualityIndex) = value;
			}
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x001B8BF3 File Offset: 0x001B6DF3
		static UGDKTargetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GDKPlatformEditor.GDKTargetSettings");
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x001B8C04 File Offset: 0x001B6E04
		protected UGDKTargetSettings() : this(BuiltinUtils.AllocNativeUObject(UGDKTargetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x001B8C2C File Offset: 0x001B6E2C
		protected UGDKTargetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009FE1 RID: 40929
		public new const string __ObjectPath = "/Script/GDKPlatformEditor.GDKTargetSettings";

		// Token: 0x04009FE2 RID: 40930
		private static IntPtr _ClassPtr;

		// Token: 0x04009FE3 RID: 40931
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009FE4 RID: 40932
		internal static int __PropertyOffset_bEnablePIXProfiling;

		// Token: 0x04009FE5 RID: 40933
		internal static int __PropertyOffset_ApplicationForegroundColor;

		// Token: 0x04009FE6 RID: 40934
		internal static int __PropertyOffset_ApplicationBackgroundColor;

		// Token: 0x04009FE7 RID: 40935
		internal static int __PropertyOffset_CultureStringResources;

		// Token: 0x04009FE8 RID: 40936
		[Nullable(2)]
		private FGDKPackageStringResources _CultureStringResources;

		// Token: 0x04009FE9 RID: 40937
		internal static int __PropertyOffset_CultureImageResources;

		// Token: 0x04009FEA RID: 40938
		internal static int __PropertyOffset_bEnableAutoResourcePacks;

		// Token: 0x04009FEB RID: 40939
		internal static int __PropertyOffset_PerCultureResources;

		// Token: 0x04009FEC RID: 40940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGDKLocalizedPackageResources> _PerCultureResources;

		// Token: 0x04009FED RID: 40941
		internal static int __PropertyOffset_bRequireXboxLive;

		// Token: 0x04009FEE RID: 40942
		internal static int __PropertyOffset_DefaultDisplayName;

		// Token: 0x04009FEF RID: 40943
		internal static int __PropertyOffset_PublisherDisplayName;

		// Token: 0x04009FF0 RID: 40944
		internal static int __PropertyOffset_TitleId;

		// Token: 0x04009FF1 RID: 40945
		internal static int __PropertyOffset_PrimaryServiceConfigId;

		// Token: 0x04009FF2 RID: 40946
		internal static int __PropertyOffset_ProductId;

		// Token: 0x04009FF3 RID: 40947
		internal static int __PropertyOffset_ContentId;

		// Token: 0x04009FF4 RID: 40948
		internal static int __PropertyOffset_StoreId;

		// Token: 0x04009FF5 RID: 40949
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04009FF6 RID: 40950
		internal static int __PropertyOffset_PublisherName;

		// Token: 0x04009FF7 RID: 40951
		internal static int __PropertyOffset_PackageVersion;

		// Token: 0x04009FF8 RID: 40952
		internal static int __PropertyOffset_bIncludeEngineVersionInPackageVersion;

		// Token: 0x04009FF9 RID: 40953
		internal static int __PropertyOffset_bSubmissionValidatorExpirationError;

		// Token: 0x04009FFA RID: 40954
		internal static int __PropertyOffset_IntelligentInstallChunk;

		// Token: 0x04009FFB RID: 40955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGDKIntelligentInstallChunk> _IntelligentInstallChunk;

		// Token: 0x04009FFC RID: 40956
		internal static int __PropertyOffset_CustomChunkMapping;

		// Token: 0x04009FFD RID: 40957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGDKCustomChunkMapping> _CustomChunkMapping;

		// Token: 0x04009FFE RID: 40958
		internal static int __PropertyOffset_bSkipAppIdSuffixForShippingConfig;

		// Token: 0x04009FFF RID: 40959
		internal static int __PropertyOffset_bBlockGameDVR;

		// Token: 0x0400A000 RID: 40960
		internal static int __PropertyOffset_bBlockBroadcasting;

		// Token: 0x0400A001 RID: 40961
		internal static int __PropertyOffset_AudioSampleRate;

		// Token: 0x0400A002 RID: 40962
		internal static int __PropertyOffset_AudioCallbackBufferFrameSize;

		// Token: 0x0400A003 RID: 40963
		internal static int __PropertyOffset_AudioNumBuffersToEnqueue;

		// Token: 0x0400A004 RID: 40964
		internal static int __PropertyOffset_AudioMaxChannels;

		// Token: 0x0400A005 RID: 40965
		internal static int __PropertyOffset_AudioNumSourceWorkers;

		// Token: 0x0400A006 RID: 40966
		internal static int __PropertyOffset_SpatializationPlugin;

		// Token: 0x0400A007 RID: 40967
		internal static int __PropertyOffset_ReverbPlugin;

		// Token: 0x0400A008 RID: 40968
		internal static int __PropertyOffset_OcclusionPlugin;

		// Token: 0x0400A009 RID: 40969
		internal static int __PropertyOffset_CompressionOverrides;

		// Token: 0x0400A00A RID: 40970
		[Nullable(2)]
		private FPlatformRuntimeAudioCompressionOverrides _CompressionOverrides;

		// Token: 0x0400A00B RID: 40971
		internal static int __PropertyOffset_ChunkSizeKB;

		// Token: 0x0400A00C RID: 40972
		internal static int __PropertyOffset_bUseAudioStreamCaching;

		// Token: 0x0400A00D RID: 40973
		internal static int __PropertyOffset_CacheSizeKB;

		// Token: 0x0400A00E RID: 40974
		internal static int __PropertyOffset_MaxChunkSizeOverrideKB;

		// Token: 0x0400A00F RID: 40975
		internal static int __PropertyOffset_bResampleForDevice;

		// Token: 0x0400A010 RID: 40976
		internal static int __PropertyOffset_MaxSampleRate;

		// Token: 0x0400A011 RID: 40977
		internal static int __PropertyOffset_HighSampleRate;

		// Token: 0x0400A012 RID: 40978
		internal static int __PropertyOffset_MedSampleRate;

		// Token: 0x0400A013 RID: 40979
		internal static int __PropertyOffset_LowSampleRate;

		// Token: 0x0400A014 RID: 40980
		internal static int __PropertyOffset_MinSampleRate;

		// Token: 0x0400A015 RID: 40981
		internal static int __PropertyOffset_CompressionQualityModifier;

		// Token: 0x0400A016 RID: 40982
		internal static int __PropertyOffset_AutoStreamingThreshold;

		// Token: 0x0400A017 RID: 40983
		internal static int __PropertyOffset_SoundCueCookQualityIndex;
	}
}
