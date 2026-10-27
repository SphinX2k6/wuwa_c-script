using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002674 RID: 9844
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PS5PlatformEditor.PS5TargetSettings")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UPS5TargetSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248FA RID: 149754 RVA: 0x00361F89 File Offset: 0x00360189
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPS5TargetSettings._ClassPtr;
		}

		// Token: 0x060248FB RID: 149755 RVA: 0x00361F98 File Offset: 0x00360198
		public UPS5TargetSettings() : this(BuiltinUtils.AllocNativeUObject(UPS5TargetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060248FC RID: 149756 RVA: 0x00361FC0 File Offset: 0x003601C0
		public UPS5TargetSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPS5TargetSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008CEB RID: 36075
		// (get) Token: 0x060248FD RID: 149757 RVA: 0x00361FF3 File Offset: 0x003601F3
		// (set) Token: 0x060248FE RID: 149758 RVA: 0x00362003 File Offset: 0x00360203
		public unsafe int AudioSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioSampleRate) = value;
			}
		}

		// Token: 0x17008CEC RID: 36076
		// (get) Token: 0x060248FF RID: 149759 RVA: 0x00362014 File Offset: 0x00360214
		// (set) Token: 0x06024900 RID: 149760 RVA: 0x00362024 File Offset: 0x00360224
		public unsafe int AudioCallbackBufferFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioCallbackBufferFrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioCallbackBufferFrameSize) = value;
			}
		}

		// Token: 0x17008CED RID: 36077
		// (get) Token: 0x06024901 RID: 149761 RVA: 0x00362035 File Offset: 0x00360235
		// (set) Token: 0x06024902 RID: 149762 RVA: 0x00362045 File Offset: 0x00360245
		public unsafe int AudioNumBuffersToEnqueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioNumBuffersToEnqueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioNumBuffersToEnqueue) = value;
			}
		}

		// Token: 0x17008CEE RID: 36078
		// (get) Token: 0x06024903 RID: 149763 RVA: 0x00362056 File Offset: 0x00360256
		// (set) Token: 0x06024904 RID: 149764 RVA: 0x00362066 File Offset: 0x00360266
		public unsafe int AudioMaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioMaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioMaxChannels) = value;
			}
		}

		// Token: 0x17008CEF RID: 36079
		// (get) Token: 0x06024905 RID: 149765 RVA: 0x00362077 File Offset: 0x00360277
		// (set) Token: 0x06024906 RID: 149766 RVA: 0x00362087 File Offset: 0x00360287
		public unsafe int AudioNumSourceWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioNumSourceWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AudioNumSourceWorkers) = value;
			}
		}

		// Token: 0x17008CF0 RID: 36080
		// (get) Token: 0x06024907 RID: 149767 RVA: 0x00362098 File Offset: 0x00360298
		// (set) Token: 0x06024908 RID: 149768 RVA: 0x003620AC File Offset: 0x003602AC
		public unsafe string SpatializationPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_SpatializationPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_SpatializationPlugin)), value);
			}
		}

		// Token: 0x17008CF1 RID: 36081
		// (get) Token: 0x06024909 RID: 149769 RVA: 0x003620C1 File Offset: 0x003602C1
		// (set) Token: 0x0602490A RID: 149770 RVA: 0x003620D5 File Offset: 0x003602D5
		public unsafe string ReverbPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_ReverbPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_ReverbPlugin)), value);
			}
		}

		// Token: 0x17008CF2 RID: 36082
		// (get) Token: 0x0602490B RID: 149771 RVA: 0x003620EA File Offset: 0x003602EA
		// (set) Token: 0x0602490C RID: 149772 RVA: 0x003620FE File Offset: 0x003602FE
		public unsafe string OcclusionPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_OcclusionPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPS5TargetSettings.__PropertyOffset_OcclusionPlugin)), value);
			}
		}

		// Token: 0x17008CF3 RID: 36083
		// (get) Token: 0x0602490D RID: 149773 RVA: 0x00362113 File Offset: 0x00360313
		// (set) Token: 0x0602490E RID: 149774 RVA: 0x00362123 File Offset: 0x00360323
		public unsafe bool bUseHardwareAcceleratedConvolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bUseHardwareAcceleratedConvolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bUseHardwareAcceleratedConvolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CF4 RID: 36084
		// (get) Token: 0x0602490F RID: 149775 RVA: 0x00362134 File Offset: 0x00360334
		// (set) Token: 0x06024910 RID: 149776 RVA: 0x00362144 File Offset: 0x00360344
		public unsafe bool bEnableRayTracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bEnableRayTracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bEnableRayTracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CF5 RID: 36085
		// (get) Token: 0x06024911 RID: 149777 RVA: 0x00362155 File Offset: 0x00360355
		// (set) Token: 0x06024912 RID: 149778 RVA: 0x00362165 File Offset: 0x00360365
		public unsafe bool bEnableHFR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bEnableHFR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bEnableHFR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CF6 RID: 36086
		// (get) Token: 0x06024913 RID: 149779 RVA: 0x00362176 File Offset: 0x00360376
		// (set) Token: 0x06024914 RID: 149780 RVA: 0x00362186 File Offset: 0x00360386
		public unsafe bool bSupportsHDR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bSupportsHDR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bSupportsHDR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CF7 RID: 36087
		// (get) Token: 0x06024915 RID: 149781 RVA: 0x00362197 File Offset: 0x00360397
		// (set) Token: 0x06024916 RID: 149782 RVA: 0x003621A7 File Offset: 0x003603A7
		public unsafe int DebugDevelopmentKrakenCompressionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_DebugDevelopmentKrakenCompressionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_DebugDevelopmentKrakenCompressionLevel) = value;
			}
		}

		// Token: 0x17008CF8 RID: 36088
		// (get) Token: 0x06024917 RID: 149783 RVA: 0x003621B8 File Offset: 0x003603B8
		// (set) Token: 0x06024918 RID: 149784 RVA: 0x003621C8 File Offset: 0x003603C8
		public unsafe int TestShippingKrakenCompressionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_TestShippingKrakenCompressionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_TestShippingKrakenCompressionLevel) = value;
			}
		}

		// Token: 0x17008CF9 RID: 36089
		// (get) Token: 0x06024919 RID: 149785 RVA: 0x003621D9 File Offset: 0x003603D9
		// (set) Token: 0x0602491A RID: 149786 RVA: 0x003621E9 File Offset: 0x003603E9
		public unsafe int DistroKrakenCompressionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_DistroKrakenCompressionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_DistroKrakenCompressionLevel) = value;
			}
		}

		// Token: 0x17008CFA RID: 36090
		// (get) Token: 0x0602491B RID: 149787 RVA: 0x003621FC File Offset: 0x003603FC
		// (set) Token: 0x0602491C RID: 149788 RVA: 0x00362235 File Offset: 0x00360435
		public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRuntimeAudioCompressionOverrides result;
				if ((result = this._CompressionOverrides) == null)
				{
					result = (this._CompressionOverrides = new FPlatformRuntimeAudioCompressionOverrides(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CompressionOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformRuntimeAudioCompressionOverrides.StaticStruct(), base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CompressionOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008CFB RID: 36091
		// (get) Token: 0x0602491D RID: 149789 RVA: 0x00362256 File Offset: 0x00360456
		// (set) Token: 0x0602491E RID: 149790 RVA: 0x00362266 File Offset: 0x00360466
		public unsafe bool bUseAudioStreamCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bUseAudioStreamCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bUseAudioStreamCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CFC RID: 36092
		// (get) Token: 0x0602491F RID: 149791 RVA: 0x00362277 File Offset: 0x00360477
		// (set) Token: 0x06024920 RID: 149792 RVA: 0x00362287 File Offset: 0x00360487
		public unsafe int CacheSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CacheSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CacheSizeKB) = value;
			}
		}

		// Token: 0x17008CFD RID: 36093
		// (get) Token: 0x06024921 RID: 149793 RVA: 0x00362298 File Offset: 0x00360498
		// (set) Token: 0x06024922 RID: 149794 RVA: 0x003622A8 File Offset: 0x003604A8
		public unsafe int MaxChunkSizeOverrideKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MaxChunkSizeOverrideKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MaxChunkSizeOverrideKB) = value;
			}
		}

		// Token: 0x17008CFE RID: 36094
		// (get) Token: 0x06024923 RID: 149795 RVA: 0x003622B9 File Offset: 0x003604B9
		// (set) Token: 0x06024924 RID: 149796 RVA: 0x003622C9 File Offset: 0x003604C9
		public unsafe bool bResampleForDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bResampleForDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_bResampleForDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CFF RID: 36095
		// (get) Token: 0x06024925 RID: 149797 RVA: 0x003622DA File Offset: 0x003604DA
		// (set) Token: 0x06024926 RID: 149798 RVA: 0x003622EA File Offset: 0x003604EA
		public unsafe int SoundCueCookQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_SoundCueCookQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_SoundCueCookQualityIndex) = value;
			}
		}

		// Token: 0x17008D00 RID: 36096
		// (get) Token: 0x06024927 RID: 149799 RVA: 0x003622FB File Offset: 0x003604FB
		// (set) Token: 0x06024928 RID: 149800 RVA: 0x0036230B File Offset: 0x0036050B
		public unsafe float MaxSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MaxSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MaxSampleRate) = value;
			}
		}

		// Token: 0x17008D01 RID: 36097
		// (get) Token: 0x06024929 RID: 149801 RVA: 0x0036231C File Offset: 0x0036051C
		// (set) Token: 0x0602492A RID: 149802 RVA: 0x0036232C File Offset: 0x0036052C
		public unsafe float HighSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_HighSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_HighSampleRate) = value;
			}
		}

		// Token: 0x17008D02 RID: 36098
		// (get) Token: 0x0602492B RID: 149803 RVA: 0x0036233D File Offset: 0x0036053D
		// (set) Token: 0x0602492C RID: 149804 RVA: 0x0036234D File Offset: 0x0036054D
		public unsafe float MedSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MedSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MedSampleRate) = value;
			}
		}

		// Token: 0x17008D03 RID: 36099
		// (get) Token: 0x0602492D RID: 149805 RVA: 0x0036235E File Offset: 0x0036055E
		// (set) Token: 0x0602492E RID: 149806 RVA: 0x0036236E File Offset: 0x0036056E
		public unsafe float LowSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_LowSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_LowSampleRate) = value;
			}
		}

		// Token: 0x17008D04 RID: 36100
		// (get) Token: 0x0602492F RID: 149807 RVA: 0x0036237F File Offset: 0x0036057F
		// (set) Token: 0x06024930 RID: 149808 RVA: 0x0036238F File Offset: 0x0036058F
		public unsafe float MinSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MinSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_MinSampleRate) = value;
			}
		}

		// Token: 0x17008D05 RID: 36101
		// (get) Token: 0x06024931 RID: 149809 RVA: 0x003623A0 File Offset: 0x003605A0
		// (set) Token: 0x06024932 RID: 149810 RVA: 0x003623B0 File Offset: 0x003605B0
		public unsafe float CompressionQualityModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CompressionQualityModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_CompressionQualityModifier) = value;
			}
		}

		// Token: 0x17008D06 RID: 36102
		// (get) Token: 0x06024933 RID: 149811 RVA: 0x003623C1 File Offset: 0x003605C1
		// (set) Token: 0x06024934 RID: 149812 RVA: 0x003623D1 File Offset: 0x003605D1
		public unsafe float AutoStreamingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AutoStreamingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPS5TargetSettings.__PropertyOffset_AutoStreamingThreshold) = value;
			}
		}

		// Token: 0x06024935 RID: 149813 RVA: 0x003623E2 File Offset: 0x003605E2
		static UPS5TargetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PS5PlatformEditor.PS5TargetSettings");
		}

		// Token: 0x06024936 RID: 149814 RVA: 0x003623F0 File Offset: 0x003605F0
		protected UPS5TargetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A52 RID: 80466
		public new const string __ObjectPath = "/Script/PS5PlatformEditor.PS5TargetSettings";

		// Token: 0x04013A53 RID: 80467
		private static IntPtr _ClassPtr;

		// Token: 0x04013A54 RID: 80468
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A55 RID: 80469
		internal static int __PropertyOffset_AudioSampleRate;

		// Token: 0x04013A56 RID: 80470
		internal static int __PropertyOffset_AudioCallbackBufferFrameSize;

		// Token: 0x04013A57 RID: 80471
		internal static int __PropertyOffset_AudioNumBuffersToEnqueue;

		// Token: 0x04013A58 RID: 80472
		internal static int __PropertyOffset_AudioMaxChannels;

		// Token: 0x04013A59 RID: 80473
		internal static int __PropertyOffset_AudioNumSourceWorkers;

		// Token: 0x04013A5A RID: 80474
		internal static int __PropertyOffset_SpatializationPlugin;

		// Token: 0x04013A5B RID: 80475
		internal static int __PropertyOffset_ReverbPlugin;

		// Token: 0x04013A5C RID: 80476
		internal static int __PropertyOffset_OcclusionPlugin;

		// Token: 0x04013A5D RID: 80477
		internal static int __PropertyOffset_bUseHardwareAcceleratedConvolution;

		// Token: 0x04013A5E RID: 80478
		internal static int __PropertyOffset_bEnableRayTracing;

		// Token: 0x04013A5F RID: 80479
		internal static int __PropertyOffset_bEnableHFR;

		// Token: 0x04013A60 RID: 80480
		internal static int __PropertyOffset_bSupportsHDR;

		// Token: 0x04013A61 RID: 80481
		internal static int __PropertyOffset_DebugDevelopmentKrakenCompressionLevel;

		// Token: 0x04013A62 RID: 80482
		internal static int __PropertyOffset_TestShippingKrakenCompressionLevel;

		// Token: 0x04013A63 RID: 80483
		internal static int __PropertyOffset_DistroKrakenCompressionLevel;

		// Token: 0x04013A64 RID: 80484
		internal static int __PropertyOffset_CompressionOverrides;

		// Token: 0x04013A65 RID: 80485
		[Nullable(2)]
		private FPlatformRuntimeAudioCompressionOverrides _CompressionOverrides;

		// Token: 0x04013A66 RID: 80486
		internal static int __PropertyOffset_bUseAudioStreamCaching;

		// Token: 0x04013A67 RID: 80487
		internal static int __PropertyOffset_CacheSizeKB;

		// Token: 0x04013A68 RID: 80488
		internal static int __PropertyOffset_MaxChunkSizeOverrideKB;

		// Token: 0x04013A69 RID: 80489
		internal static int __PropertyOffset_bResampleForDevice;

		// Token: 0x04013A6A RID: 80490
		internal static int __PropertyOffset_SoundCueCookQualityIndex;

		// Token: 0x04013A6B RID: 80491
		internal static int __PropertyOffset_MaxSampleRate;

		// Token: 0x04013A6C RID: 80492
		internal static int __PropertyOffset_HighSampleRate;

		// Token: 0x04013A6D RID: 80493
		internal static int __PropertyOffset_MedSampleRate;

		// Token: 0x04013A6E RID: 80494
		internal static int __PropertyOffset_LowSampleRate;

		// Token: 0x04013A6F RID: 80495
		internal static int __PropertyOffset_MinSampleRate;

		// Token: 0x04013A70 RID: 80496
		internal static int __PropertyOffset_CompressionQualityModifier;

		// Token: 0x04013A71 RID: 80497
		internal static int __PropertyOffset_AutoStreamingThreshold;
	}
}
