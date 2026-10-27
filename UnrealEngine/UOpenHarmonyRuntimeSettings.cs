using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262A RID: 9770
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OpenHarmonyRuntimeSettings.OpenHarmonyRuntimeSettings")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UOpenHarmonyRuntimeSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024527 RID: 148775 RVA: 0x0035C8A0 File Offset: 0x0035AAA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpenHarmonyRuntimeSettings._ClassPtr;
		}

		// Token: 0x06024528 RID: 148776 RVA: 0x0035C8AC File Offset: 0x0035AAAC
		public UOpenHarmonyRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(UOpenHarmonyRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024529 RID: 148777 RVA: 0x0035C8D4 File Offset: 0x0035AAD4
		public UOpenHarmonyRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpenHarmonyRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BDF RID: 35807
		// (get) Token: 0x0602452A RID: 148778 RVA: 0x0035C907 File Offset: 0x0035AB07
		// (set) Token: 0x0602452B RID: 148779 RVA: 0x0035C91B File Offset: 0x0035AB1B
		public unsafe string PackageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_PackageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_PackageName)), value);
			}
		}

		// Token: 0x17008BE0 RID: 35808
		// (get) Token: 0x0602452C RID: 148780 RVA: 0x0035C930 File Offset: 0x0035AB30
		// (set) Token: 0x0602452D RID: 148781 RVA: 0x0035C944 File Offset: 0x0035AB44
		public unsafe string AppName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AppName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AppName)), value);
			}
		}

		// Token: 0x17008BE1 RID: 35809
		// (get) Token: 0x0602452E RID: 148782 RVA: 0x0035C959 File Offset: 0x0035AB59
		// (set) Token: 0x0602452F RID: 148783 RVA: 0x0035C969 File Offset: 0x0035AB69
		public unsafe int VersionCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_VersionCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_VersionCode) = value;
			}
		}

		// Token: 0x17008BE2 RID: 35810
		// (get) Token: 0x06024530 RID: 148784 RVA: 0x0035C97A File Offset: 0x0035AB7A
		// (set) Token: 0x06024531 RID: 148785 RVA: 0x0035C98A File Offset: 0x0035AB8A
		public unsafe bool bBuildForArmV7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForArmV7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForArmV7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE3 RID: 35811
		// (get) Token: 0x06024532 RID: 148786 RVA: 0x0035C99B File Offset: 0x0035AB9B
		// (set) Token: 0x06024533 RID: 148787 RVA: 0x0035C9AB File Offset: 0x0035ABAB
		public unsafe bool bBuildForArm64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForArm64) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForArm64) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE4 RID: 35812
		// (get) Token: 0x06024534 RID: 148788 RVA: 0x0035C9BC File Offset: 0x0035ABBC
		// (set) Token: 0x06024535 RID: 148789 RVA: 0x0035C9CC File Offset: 0x0035ABCC
		public unsafe bool bBuildForX8664
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForX8664) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForX8664) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE5 RID: 35813
		// (get) Token: 0x06024536 RID: 148790 RVA: 0x0035C9DD File Offset: 0x0035ABDD
		// (set) Token: 0x06024537 RID: 148791 RVA: 0x0035C9ED File Offset: 0x0035ABED
		public unsafe bool bBuildForES31
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForES31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bBuildForES31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE6 RID: 35814
		// (get) Token: 0x06024538 RID: 148792 RVA: 0x0035C9FE File Offset: 0x0035ABFE
		// (set) Token: 0x06024539 RID: 148793 RVA: 0x0035CA0E File Offset: 0x0035AC0E
		public unsafe bool bSupportsVulkan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bSupportsVulkan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bSupportsVulkan) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE7 RID: 35815
		// (get) Token: 0x0602453A RID: 148794 RVA: 0x0035CA1F File Offset: 0x0035AC1F
		// (set) Token: 0x0602453B RID: 148795 RVA: 0x0035CA2F File Offset: 0x0035AC2F
		public unsafe bool bSupportsVulkanSM5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bSupportsVulkanSM5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bSupportsVulkanSM5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE8 RID: 35816
		// (get) Token: 0x0602453C RID: 148796 RVA: 0x0035CA40 File Offset: 0x0035AC40
		// (set) Token: 0x0602453D RID: 148797 RVA: 0x0035CA50 File Offset: 0x0035AC50
		public unsafe bool bShowLaunchImage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bShowLaunchImage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bShowLaunchImage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BE9 RID: 35817
		// (get) Token: 0x0602453E RID: 148798 RVA: 0x0035CA61 File Offset: 0x0035AC61
		// (set) Token: 0x0602453F RID: 148799 RVA: 0x0035CA75 File Offset: 0x0035AC75
		public unsafe string CertPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CertPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CertPath)), value);
			}
		}

		// Token: 0x17008BEA RID: 35818
		// (get) Token: 0x06024540 RID: 148800 RVA: 0x0035CA8A File Offset: 0x0035AC8A
		// (set) Token: 0x06024541 RID: 148801 RVA: 0x0035CA9E File Offset: 0x0035AC9E
		public unsafe string StorePassword
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_StorePassword)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_StorePassword)), value);
			}
		}

		// Token: 0x17008BEB RID: 35819
		// (get) Token: 0x06024542 RID: 148802 RVA: 0x0035CAB3 File Offset: 0x0035ACB3
		// (set) Token: 0x06024543 RID: 148803 RVA: 0x0035CAC3 File Offset: 0x0035ACC3
		public unsafe bool bEnableNewKeyboard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bEnableNewKeyboard) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bEnableNewKeyboard) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BEC RID: 35820
		// (get) Token: 0x06024544 RID: 148804 RVA: 0x0035CAD4 File Offset: 0x0035ACD4
		// (set) Token: 0x06024545 RID: 148805 RVA: 0x0035CAE8 File Offset: 0x0035ACE8
		[Nullable(0)]
		public unsafe TEnumAsByte<EOpenHarmonyScreenOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x17008BED RID: 35821
		// (get) Token: 0x06024546 RID: 148806 RVA: 0x0035CAFD File Offset: 0x0035ACFD
		// (set) Token: 0x06024547 RID: 148807 RVA: 0x0035CB11 File Offset: 0x0035AD11
		public unsafe string KeyAlias
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_KeyAlias)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_KeyAlias)), value);
			}
		}

		// Token: 0x17008BEE RID: 35822
		// (get) Token: 0x06024548 RID: 148808 RVA: 0x0035CB26 File Offset: 0x0035AD26
		// (set) Token: 0x06024549 RID: 148809 RVA: 0x0035CB3A File Offset: 0x0035AD3A
		public unsafe string KeyPassword
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_KeyPassword)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_KeyPassword)), value);
			}
		}

		// Token: 0x17008BEF RID: 35823
		// (get) Token: 0x0602454A RID: 148810 RVA: 0x0035CB4F File Offset: 0x0035AD4F
		// (set) Token: 0x0602454B RID: 148811 RVA: 0x0035CB63 File Offset: 0x0035AD63
		public unsafe string Profile
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_Profile)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_Profile)), value);
			}
		}

		// Token: 0x17008BF0 RID: 35824
		// (get) Token: 0x0602454C RID: 148812 RVA: 0x0035CB78 File Offset: 0x0035AD78
		// (set) Token: 0x0602454D RID: 148813 RVA: 0x0035CB8C File Offset: 0x0035AD8C
		public unsafe string SignAlg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SignAlg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SignAlg)), value);
			}
		}

		// Token: 0x17008BF1 RID: 35825
		// (get) Token: 0x0602454E RID: 148814 RVA: 0x0035CBA1 File Offset: 0x0035ADA1
		// (set) Token: 0x0602454F RID: 148815 RVA: 0x0035CBB5 File Offset: 0x0035ADB5
		public unsafe string StoreFile
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_StoreFile)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_StoreFile)), value);
			}
		}

		// Token: 0x17008BF2 RID: 35826
		// (get) Token: 0x06024550 RID: 148816 RVA: 0x0035CBCA File Offset: 0x0035ADCA
		// (set) Token: 0x06024551 RID: 148817 RVA: 0x0035CBDA File Offset: 0x0035ADDA
		public unsafe bool bMultiTargetFormat_ETC2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ETC2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ETC2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BF3 RID: 35827
		// (get) Token: 0x06024552 RID: 148818 RVA: 0x0035CBEB File Offset: 0x0035ADEB
		// (set) Token: 0x06024553 RID: 148819 RVA: 0x0035CBFB File Offset: 0x0035ADFB
		public unsafe bool bMultiTargetFormat_DXT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_DXT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_DXT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BF4 RID: 35828
		// (get) Token: 0x06024554 RID: 148820 RVA: 0x0035CC0C File Offset: 0x0035AE0C
		// (set) Token: 0x06024555 RID: 148821 RVA: 0x0035CC1C File Offset: 0x0035AE1C
		public unsafe bool bMultiTargetFormat_ASTC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ASTC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bMultiTargetFormat_ASTC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BF5 RID: 35829
		// (get) Token: 0x06024556 RID: 148822 RVA: 0x0035CC2D File Offset: 0x0035AE2D
		// (set) Token: 0x06024557 RID: 148823 RVA: 0x0035CC3D File Offset: 0x0035AE3D
		public unsafe float TextureFormatPriority_ETC2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_ETC2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_ETC2) = value;
			}
		}

		// Token: 0x17008BF6 RID: 35830
		// (get) Token: 0x06024558 RID: 148824 RVA: 0x0035CC4E File Offset: 0x0035AE4E
		// (set) Token: 0x06024559 RID: 148825 RVA: 0x0035CC5E File Offset: 0x0035AE5E
		public unsafe float TextureFormatPriority_DXT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_DXT);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_DXT) = value;
			}
		}

		// Token: 0x17008BF7 RID: 35831
		// (get) Token: 0x0602455A RID: 148826 RVA: 0x0035CC6F File Offset: 0x0035AE6F
		// (set) Token: 0x0602455B RID: 148827 RVA: 0x0035CC7F File Offset: 0x0035AE7F
		public unsafe float TextureFormatPriority_ASTC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_ASTC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_TextureFormatPriority_ASTC) = value;
			}
		}

		// Token: 0x17008BF8 RID: 35832
		// (get) Token: 0x0602455C RID: 148828 RVA: 0x0035CC90 File Offset: 0x0035AE90
		// (set) Token: 0x0602455D RID: 148829 RVA: 0x0035CCA0 File Offset: 0x0035AEA0
		public unsafe int AudioSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioSampleRate) = value;
			}
		}

		// Token: 0x17008BF9 RID: 35833
		// (get) Token: 0x0602455E RID: 148830 RVA: 0x0035CCB1 File Offset: 0x0035AEB1
		// (set) Token: 0x0602455F RID: 148831 RVA: 0x0035CCC1 File Offset: 0x0035AEC1
		public unsafe int AudioCallbackBufferFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioCallbackBufferFrameSize) = value;
			}
		}

		// Token: 0x17008BFA RID: 35834
		// (get) Token: 0x06024560 RID: 148832 RVA: 0x0035CCD2 File Offset: 0x0035AED2
		// (set) Token: 0x06024561 RID: 148833 RVA: 0x0035CCE2 File Offset: 0x0035AEE2
		public unsafe int AudioNumBuffersToEnqueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioNumBuffersToEnqueue) = value;
			}
		}

		// Token: 0x17008BFB RID: 35835
		// (get) Token: 0x06024562 RID: 148834 RVA: 0x0035CCF3 File Offset: 0x0035AEF3
		// (set) Token: 0x06024563 RID: 148835 RVA: 0x0035CD03 File Offset: 0x0035AF03
		public unsafe int AudioMaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioMaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioMaxChannels) = value;
			}
		}

		// Token: 0x17008BFC RID: 35836
		// (get) Token: 0x06024564 RID: 148836 RVA: 0x0035CD14 File Offset: 0x0035AF14
		// (set) Token: 0x06024565 RID: 148837 RVA: 0x0035CD24 File Offset: 0x0035AF24
		public unsafe int AudioNumSourceWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AudioNumSourceWorkers) = value;
			}
		}

		// Token: 0x17008BFD RID: 35837
		// (get) Token: 0x06024566 RID: 148838 RVA: 0x0035CD35 File Offset: 0x0035AF35
		// (set) Token: 0x06024567 RID: 148839 RVA: 0x0035CD49 File Offset: 0x0035AF49
		public unsafe string SpatializationPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SpatializationPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SpatializationPlugin)), value);
			}
		}

		// Token: 0x17008BFE RID: 35838
		// (get) Token: 0x06024568 RID: 148840 RVA: 0x0035CD5E File Offset: 0x0035AF5E
		// (set) Token: 0x06024569 RID: 148841 RVA: 0x0035CD72 File Offset: 0x0035AF72
		public unsafe string ReverbPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_ReverbPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_ReverbPlugin)), value);
			}
		}

		// Token: 0x17008BFF RID: 35839
		// (get) Token: 0x0602456A RID: 148842 RVA: 0x0035CD87 File Offset: 0x0035AF87
		// (set) Token: 0x0602456B RID: 148843 RVA: 0x0035CD9B File Offset: 0x0035AF9B
		public unsafe string OcclusionPlugin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_OcclusionPlugin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_OcclusionPlugin)), value);
			}
		}

		// Token: 0x17008C00 RID: 35840
		// (get) Token: 0x0602456C RID: 148844 RVA: 0x0035CDB0 File Offset: 0x0035AFB0
		// (set) Token: 0x0602456D RID: 148845 RVA: 0x0035CDE9 File Offset: 0x0035AFE9
		public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRuntimeAudioCompressionOverrides result;
				if ((result = this._CompressionOverrides) == null)
				{
					result = (this._CompressionOverrides = new FPlatformRuntimeAudioCompressionOverrides(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CompressionOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformRuntimeAudioCompressionOverrides.StaticStruct(), base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CompressionOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008C01 RID: 35841
		// (get) Token: 0x0602456E RID: 148846 RVA: 0x0035CE0A File Offset: 0x0035B00A
		// (set) Token: 0x0602456F RID: 148847 RVA: 0x0035CE1A File Offset: 0x0035B01A
		public unsafe bool bUseAudioStreamCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bUseAudioStreamCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C02 RID: 35842
		// (get) Token: 0x06024570 RID: 148848 RVA: 0x0035CE2B File Offset: 0x0035B02B
		// (set) Token: 0x06024571 RID: 148849 RVA: 0x0035CE3B File Offset: 0x0035B03B
		public unsafe int CacheSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CacheSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CacheSizeKB) = value;
			}
		}

		// Token: 0x17008C03 RID: 35843
		// (get) Token: 0x06024572 RID: 148850 RVA: 0x0035CE4C File Offset: 0x0035B04C
		// (set) Token: 0x06024573 RID: 148851 RVA: 0x0035CE5C File Offset: 0x0035B05C
		public unsafe int MaxChunkSizeOverrideKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MaxChunkSizeOverrideKB) = value;
			}
		}

		// Token: 0x17008C04 RID: 35844
		// (get) Token: 0x06024574 RID: 148852 RVA: 0x0035CE6D File Offset: 0x0035B06D
		// (set) Token: 0x06024575 RID: 148853 RVA: 0x0035CE7D File Offset: 0x0035B07D
		public unsafe bool bResampleForDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bResampleForDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_bResampleForDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C05 RID: 35845
		// (get) Token: 0x06024576 RID: 148854 RVA: 0x0035CE8E File Offset: 0x0035B08E
		// (set) Token: 0x06024577 RID: 148855 RVA: 0x0035CE9E File Offset: 0x0035B09E
		public unsafe int SoundCueCookQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_SoundCueCookQualityIndex) = value;
			}
		}

		// Token: 0x17008C06 RID: 35846
		// (get) Token: 0x06024578 RID: 148856 RVA: 0x0035CEAF File Offset: 0x0035B0AF
		// (set) Token: 0x06024579 RID: 148857 RVA: 0x0035CEBF File Offset: 0x0035B0BF
		public unsafe float MaxSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MaxSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MaxSampleRate) = value;
			}
		}

		// Token: 0x17008C07 RID: 35847
		// (get) Token: 0x0602457A RID: 148858 RVA: 0x0035CED0 File Offset: 0x0035B0D0
		// (set) Token: 0x0602457B RID: 148859 RVA: 0x0035CEE0 File Offset: 0x0035B0E0
		public unsafe float HighSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_HighSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_HighSampleRate) = value;
			}
		}

		// Token: 0x17008C08 RID: 35848
		// (get) Token: 0x0602457C RID: 148860 RVA: 0x0035CEF1 File Offset: 0x0035B0F1
		// (set) Token: 0x0602457D RID: 148861 RVA: 0x0035CF01 File Offset: 0x0035B101
		public unsafe float MedSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MedSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MedSampleRate) = value;
			}
		}

		// Token: 0x17008C09 RID: 35849
		// (get) Token: 0x0602457E RID: 148862 RVA: 0x0035CF12 File Offset: 0x0035B112
		// (set) Token: 0x0602457F RID: 148863 RVA: 0x0035CF22 File Offset: 0x0035B122
		public unsafe float LowSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_LowSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_LowSampleRate) = value;
			}
		}

		// Token: 0x17008C0A RID: 35850
		// (get) Token: 0x06024580 RID: 148864 RVA: 0x0035CF33 File Offset: 0x0035B133
		// (set) Token: 0x06024581 RID: 148865 RVA: 0x0035CF43 File Offset: 0x0035B143
		public unsafe float MinSampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MinSampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_MinSampleRate) = value;
			}
		}

		// Token: 0x17008C0B RID: 35851
		// (get) Token: 0x06024582 RID: 148866 RVA: 0x0035CF54 File Offset: 0x0035B154
		// (set) Token: 0x06024583 RID: 148867 RVA: 0x0035CF64 File Offset: 0x0035B164
		public unsafe float CompressionQualityModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CompressionQualityModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_CompressionQualityModifier) = value;
			}
		}

		// Token: 0x17008C0C RID: 35852
		// (get) Token: 0x06024584 RID: 148868 RVA: 0x0035CF75 File Offset: 0x0035B175
		// (set) Token: 0x06024585 RID: 148869 RVA: 0x0035CF85 File Offset: 0x0035B185
		public unsafe float AutoStreamingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AutoStreamingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenHarmonyRuntimeSettings.__PropertyOffset_AutoStreamingThreshold) = value;
			}
		}

		// Token: 0x06024586 RID: 148870 RVA: 0x0035CF96 File Offset: 0x0035B196
		static UOpenHarmonyRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpenHarmonyRuntimeSettings.OpenHarmonyRuntimeSettings");
		}

		// Token: 0x06024587 RID: 148871 RVA: 0x0035CFA4 File Offset: 0x0035B1A4
		protected UOpenHarmonyRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040137CC RID: 79820
		public new const string __ObjectPath = "/Script/OpenHarmonyRuntimeSettings.OpenHarmonyRuntimeSettings";

		// Token: 0x040137CD RID: 79821
		private static IntPtr _ClassPtr;

		// Token: 0x040137CE RID: 79822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040137CF RID: 79823
		internal static int __PropertyOffset_PackageName;

		// Token: 0x040137D0 RID: 79824
		internal static int __PropertyOffset_AppName;

		// Token: 0x040137D1 RID: 79825
		internal static int __PropertyOffset_VersionCode;

		// Token: 0x040137D2 RID: 79826
		internal static int __PropertyOffset_bBuildForArmV7;

		// Token: 0x040137D3 RID: 79827
		internal static int __PropertyOffset_bBuildForArm64;

		// Token: 0x040137D4 RID: 79828
		internal static int __PropertyOffset_bBuildForX8664;

		// Token: 0x040137D5 RID: 79829
		internal static int __PropertyOffset_bBuildForES31;

		// Token: 0x040137D6 RID: 79830
		internal static int __PropertyOffset_bSupportsVulkan;

		// Token: 0x040137D7 RID: 79831
		internal static int __PropertyOffset_bSupportsVulkanSM5;

		// Token: 0x040137D8 RID: 79832
		internal static int __PropertyOffset_bShowLaunchImage;

		// Token: 0x040137D9 RID: 79833
		internal static int __PropertyOffset_CertPath;

		// Token: 0x040137DA RID: 79834
		internal static int __PropertyOffset_StorePassword;

		// Token: 0x040137DB RID: 79835
		internal static int __PropertyOffset_bEnableNewKeyboard;

		// Token: 0x040137DC RID: 79836
		internal static int __PropertyOffset_Orientation;

		// Token: 0x040137DD RID: 79837
		internal static int __PropertyOffset_KeyAlias;

		// Token: 0x040137DE RID: 79838
		internal static int __PropertyOffset_KeyPassword;

		// Token: 0x040137DF RID: 79839
		internal static int __PropertyOffset_Profile;

		// Token: 0x040137E0 RID: 79840
		internal static int __PropertyOffset_SignAlg;

		// Token: 0x040137E1 RID: 79841
		internal static int __PropertyOffset_StoreFile;

		// Token: 0x040137E2 RID: 79842
		internal static int __PropertyOffset_bMultiTargetFormat_ETC2;

		// Token: 0x040137E3 RID: 79843
		internal static int __PropertyOffset_bMultiTargetFormat_DXT;

		// Token: 0x040137E4 RID: 79844
		internal static int __PropertyOffset_bMultiTargetFormat_ASTC;

		// Token: 0x040137E5 RID: 79845
		internal static int __PropertyOffset_TextureFormatPriority_ETC2;

		// Token: 0x040137E6 RID: 79846
		internal static int __PropertyOffset_TextureFormatPriority_DXT;

		// Token: 0x040137E7 RID: 79847
		internal static int __PropertyOffset_TextureFormatPriority_ASTC;

		// Token: 0x040137E8 RID: 79848
		internal static int __PropertyOffset_AudioSampleRate;

		// Token: 0x040137E9 RID: 79849
		internal static int __PropertyOffset_AudioCallbackBufferFrameSize;

		// Token: 0x040137EA RID: 79850
		internal static int __PropertyOffset_AudioNumBuffersToEnqueue;

		// Token: 0x040137EB RID: 79851
		internal static int __PropertyOffset_AudioMaxChannels;

		// Token: 0x040137EC RID: 79852
		internal static int __PropertyOffset_AudioNumSourceWorkers;

		// Token: 0x040137ED RID: 79853
		internal static int __PropertyOffset_SpatializationPlugin;

		// Token: 0x040137EE RID: 79854
		internal static int __PropertyOffset_ReverbPlugin;

		// Token: 0x040137EF RID: 79855
		internal static int __PropertyOffset_OcclusionPlugin;

		// Token: 0x040137F0 RID: 79856
		internal static int __PropertyOffset_CompressionOverrides;

		// Token: 0x040137F1 RID: 79857
		[Nullable(2)]
		private FPlatformRuntimeAudioCompressionOverrides _CompressionOverrides;

		// Token: 0x040137F2 RID: 79858
		internal static int __PropertyOffset_bUseAudioStreamCaching;

		// Token: 0x040137F3 RID: 79859
		internal static int __PropertyOffset_CacheSizeKB;

		// Token: 0x040137F4 RID: 79860
		internal static int __PropertyOffset_MaxChunkSizeOverrideKB;

		// Token: 0x040137F5 RID: 79861
		internal static int __PropertyOffset_bResampleForDevice;

		// Token: 0x040137F6 RID: 79862
		internal static int __PropertyOffset_SoundCueCookQualityIndex;

		// Token: 0x040137F7 RID: 79863
		internal static int __PropertyOffset_MaxSampleRate;

		// Token: 0x040137F8 RID: 79864
		internal static int __PropertyOffset_HighSampleRate;

		// Token: 0x040137F9 RID: 79865
		internal static int __PropertyOffset_MedSampleRate;

		// Token: 0x040137FA RID: 79866
		internal static int __PropertyOffset_LowSampleRate;

		// Token: 0x040137FB RID: 79867
		internal static int __PropertyOffset_MinSampleRate;

		// Token: 0x040137FC RID: 79868
		internal static int __PropertyOffset_CompressionQualityModifier;

		// Token: 0x040137FD RID: 79869
		internal static int __PropertyOffset_AutoStreamingThreshold;
	}
}
