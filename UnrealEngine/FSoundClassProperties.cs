using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001129 RID: 4393
	[UnrealObjectPath("/Script/Engine.SoundClassProperties")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FSoundClassProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010120 RID: 65824 RVA: 0x0017AC46 File Offset: 0x00178E46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundClassProperties._ScriptStructPtr != 0) ? FSoundClassProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundClassProperties", ref FSoundClassProperties._ScriptStructPtr);
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x06010121 RID: 65825 RVA: 0x0017AC6A File Offset: 0x00178E6A
		// (set) Token: 0x06010122 RID: 65826 RVA: 0x0017AC7A File Offset: 0x00178E7A
		public unsafe float Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Volume) = value;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x06010123 RID: 65827 RVA: 0x0017AC8B File Offset: 0x00178E8B
		// (set) Token: 0x06010124 RID: 65828 RVA: 0x0017AC9B File Offset: 0x00178E9B
		public unsafe float Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Pitch) = value;
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06010125 RID: 65829 RVA: 0x0017ACAC File Offset: 0x00178EAC
		// (set) Token: 0x06010126 RID: 65830 RVA: 0x0017ACBC File Offset: 0x00178EBC
		public unsafe float LowPassFilterFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LowPassFilterFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LowPassFilterFrequency) = value;
			}
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06010127 RID: 65831 RVA: 0x0017ACCD File Offset: 0x00178ECD
		// (set) Token: 0x06010128 RID: 65832 RVA: 0x0017ACDD File Offset: 0x00178EDD
		public unsafe float AttenuationDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_AttenuationDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_AttenuationDistanceScale) = value;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06010129 RID: 65833 RVA: 0x0017ACEE File Offset: 0x00178EEE
		// (set) Token: 0x0601012A RID: 65834 RVA: 0x0017ACFE File Offset: 0x00178EFE
		public unsafe float StereoBleed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_StereoBleed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_StereoBleed) = value;
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0601012B RID: 65835 RVA: 0x0017AD0F File Offset: 0x00178F0F
		// (set) Token: 0x0601012C RID: 65836 RVA: 0x0017AD1F File Offset: 0x00178F1F
		public unsafe float LFEBleed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LFEBleed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LFEBleed) = value;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0601012D RID: 65837 RVA: 0x0017AD30 File Offset: 0x00178F30
		// (set) Token: 0x0601012E RID: 65838 RVA: 0x0017AD40 File Offset: 0x00178F40
		public unsafe float VoiceCenterChannelVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_VoiceCenterChannelVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_VoiceCenterChannelVolume) = value;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0601012F RID: 65839 RVA: 0x0017AD51 File Offset: 0x00178F51
		// (set) Token: 0x06010130 RID: 65840 RVA: 0x0017AD61 File Offset: 0x00178F61
		public unsafe float RadioFilterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_RadioFilterVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_RadioFilterVolume) = value;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x06010131 RID: 65841 RVA: 0x0017AD72 File Offset: 0x00178F72
		// (set) Token: 0x06010132 RID: 65842 RVA: 0x0017AD82 File Offset: 0x00178F82
		public unsafe float RadioFilterVolumeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_RadioFilterVolumeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_RadioFilterVolumeThreshold) = value;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06010133 RID: 65843 RVA: 0x0017AD93 File Offset: 0x00178F93
		// (set) Token: 0x06010134 RID: 65844 RVA: 0x0017ADAC File Offset: 0x00178FAC
		public unsafe bool bApplyEffects
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyEffects) & FSoundClassProperties.__PropertyMask_bApplyEffects) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyEffects) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyEffects) & ~FSoundClassProperties.__PropertyMask_bApplyEffects) | (value ? FSoundClassProperties.__PropertyMask_bApplyEffects : 0));
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06010135 RID: 65845 RVA: 0x0017ADDC File Offset: 0x00178FDC
		// (set) Token: 0x06010136 RID: 65846 RVA: 0x0017ADF5 File Offset: 0x00178FF5
		public unsafe bool bAlwaysPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bAlwaysPlay) & FSoundClassProperties.__PropertyMask_bAlwaysPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bAlwaysPlay) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bAlwaysPlay) & ~FSoundClassProperties.__PropertyMask_bAlwaysPlay) | (value ? FSoundClassProperties.__PropertyMask_bAlwaysPlay : 0));
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06010137 RID: 65847 RVA: 0x0017AE25 File Offset: 0x00179025
		// (set) Token: 0x06010138 RID: 65848 RVA: 0x0017AE3E File Offset: 0x0017903E
		public unsafe bool bIsUISound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsUISound) & FSoundClassProperties.__PropertyMask_bIsUISound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsUISound) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsUISound) & ~FSoundClassProperties.__PropertyMask_bIsUISound) | (value ? FSoundClassProperties.__PropertyMask_bIsUISound : 0));
			}
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06010139 RID: 65849 RVA: 0x0017AE6E File Offset: 0x0017906E
		// (set) Token: 0x0601013A RID: 65850 RVA: 0x0017AE87 File Offset: 0x00179087
		public unsafe bool bIsMusic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsMusic) & FSoundClassProperties.__PropertyMask_bIsMusic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsMusic) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bIsMusic) & ~FSoundClassProperties.__PropertyMask_bIsMusic) | (value ? FSoundClassProperties.__PropertyMask_bIsMusic : 0));
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0601013B RID: 65851 RVA: 0x0017AEB7 File Offset: 0x001790B7
		// (set) Token: 0x0601013C RID: 65852 RVA: 0x0017AED0 File Offset: 0x001790D0
		public unsafe bool bCenterChannelOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bCenterChannelOnly) & FSoundClassProperties.__PropertyMask_bCenterChannelOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bCenterChannelOnly) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bCenterChannelOnly) & ~FSoundClassProperties.__PropertyMask_bCenterChannelOnly) | (value ? FSoundClassProperties.__PropertyMask_bCenterChannelOnly : 0));
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0601013D RID: 65853 RVA: 0x0017AF00 File Offset: 0x00179100
		// (set) Token: 0x0601013E RID: 65854 RVA: 0x0017AF19 File Offset: 0x00179119
		public unsafe bool bApplyAmbientVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyAmbientVolumes) & FSoundClassProperties.__PropertyMask_bApplyAmbientVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyAmbientVolumes) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bApplyAmbientVolumes) & ~FSoundClassProperties.__PropertyMask_bApplyAmbientVolumes) | (value ? FSoundClassProperties.__PropertyMask_bApplyAmbientVolumes : 0));
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0601013F RID: 65855 RVA: 0x0017AF49 File Offset: 0x00179149
		// (set) Token: 0x06010140 RID: 65856 RVA: 0x0017AF62 File Offset: 0x00179162
		public unsafe bool bReverb
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bReverb) & FSoundClassProperties.__PropertyMask_bReverb) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bReverb) = ((*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_bReverb) & ~FSoundClassProperties.__PropertyMask_bReverb) | (value ? FSoundClassProperties.__PropertyMask_bReverb : 0));
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x06010141 RID: 65857 RVA: 0x0017AF92 File Offset: 0x00179192
		// (set) Token: 0x06010142 RID: 65858 RVA: 0x0017AFA2 File Offset: 0x001791A2
		public unsafe float Default2DReverbSendAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Default2DReverbSendAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_Default2DReverbSendAmount) = value;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06010143 RID: 65859 RVA: 0x0017AFB4 File Offset: 0x001791B4
		// (set) Token: 0x06010144 RID: 65860 RVA: 0x0017AFF7 File Offset: 0x001791F7
		[Nullable(1)]
		public FSoundModulationDefaultSettings ModulationSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDefaultSettings result;
				if ((result = this._ModulationSettings) == null)
				{
					result = (this._ModulationSettings = new FSoundModulationDefaultSettings(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_ModulationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDefaultSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_ModulationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x06010145 RID: 65861 RVA: 0x0017B018 File Offset: 0x00179218
		// (set) Token: 0x06010146 RID: 65862 RVA: 0x0017B02C File Offset: 0x0017922C
		public unsafe TEnumAsByte<EAudioOutputTarget> OutputTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_OutputTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_OutputTarget) = value;
			}
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x06010147 RID: 65863 RVA: 0x0017B041 File Offset: 0x00179241
		// (set) Token: 0x06010148 RID: 65864 RVA: 0x0017B051 File Offset: 0x00179251
		public unsafe ESoundWaveLoadingBehavior LoadingBehavior
		{
			get
			{
				return (ESoundWaveLoadingBehavior)(*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LoadingBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassProperties.__PropertyOffset_LoadingBehavior) = (byte)value;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x06010149 RID: 65865 RVA: 0x0017B062 File Offset: 0x00179262
		// (set) Token: 0x0601014A RID: 65866 RVA: 0x0017B076 File Offset: 0x00179276
		[Nullable(2)]
		public unsafe USoundSubmix DefaultSubmix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundClassProperties.__PropertyOffset_DefaultSubmix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundClassProperties.__PropertyOffset_DefaultSubmix, value);
			}
		}

		// Token: 0x0601014B RID: 65867 RVA: 0x0017B08B File Offset: 0x0017928B
		public FSoundClassProperties()
		{
		}

		// Token: 0x0601014C RID: 65868 RVA: 0x0017B094 File Offset: 0x00179294
		[NullableContext(1)]
		public FSoundClassProperties(float Volume, float Pitch, float LowPassFilterFrequency, float AttenuationDistanceScale, float StereoBleed, float LFEBleed, float VoiceCenterChannelVolume, float RadioFilterVolume, float RadioFilterVolumeThreshold, bool bApplyEffects, bool bAlwaysPlay, bool bIsUISound, bool bIsMusic, bool bCenterChannelOnly, bool bApplyAmbientVolumes, bool bReverb, float Default2DReverbSendAmount, FSoundModulationDefaultSettings ModulationSettings, [Nullable(0)] TEnumAsByte<EAudioOutputTarget> OutputTarget, ESoundWaveLoadingBehavior LoadingBehavior, USoundSubmix DefaultSubmix)
		{
			this.Volume = Volume;
			this.Pitch = Pitch;
			this.LowPassFilterFrequency = LowPassFilterFrequency;
			this.AttenuationDistanceScale = AttenuationDistanceScale;
			this.StereoBleed = StereoBleed;
			this.LFEBleed = LFEBleed;
			this.VoiceCenterChannelVolume = VoiceCenterChannelVolume;
			this.RadioFilterVolume = RadioFilterVolume;
			this.RadioFilterVolumeThreshold = RadioFilterVolumeThreshold;
			this.bApplyEffects = bApplyEffects;
			this.bAlwaysPlay = bAlwaysPlay;
			this.bIsUISound = bIsUISound;
			this.bIsMusic = bIsMusic;
			this.bCenterChannelOnly = bCenterChannelOnly;
			this.bApplyAmbientVolumes = bApplyAmbientVolumes;
			this.bReverb = bReverb;
			this.Default2DReverbSendAmount = Default2DReverbSendAmount;
			this.ModulationSettings = ModulationSettings;
			this.OutputTarget = OutputTarget;
			this.LoadingBehavior = LoadingBehavior;
			this.DefaultSubmix = DefaultSubmix;
		}

		// Token: 0x0601014D RID: 65869 RVA: 0x0017B14C File Offset: 0x0017934C
		protected override IntPtr GetUStructPtr()
		{
			return FSoundClassProperties.StaticStruct();
		}

		// Token: 0x0601014E RID: 65870 RVA: 0x0017B158 File Offset: 0x00179358
		[NullableContext(2)]
		public FSoundClassProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601014F RID: 65871 RVA: 0x0017B162 File Offset: 0x00179362
		public FSoundClassProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010150 RID: 65872 RVA: 0x0017B16D File Offset: 0x0017936D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundClassProperties(Pointer, false, true);
		}

		// Token: 0x06010151 RID: 65873 RVA: 0x0017B177 File Offset: 0x00179377
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundClassProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04008A38 RID: 35384
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundClassProperties";

		// Token: 0x04008A39 RID: 35385
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008A3A RID: 35386
		internal static int __PropertyOffset_Volume;

		// Token: 0x04008A3B RID: 35387
		internal static int __PropertyOffset_Pitch;

		// Token: 0x04008A3C RID: 35388
		internal static int __PropertyOffset_LowPassFilterFrequency;

		// Token: 0x04008A3D RID: 35389
		internal static int __PropertyOffset_AttenuationDistanceScale;

		// Token: 0x04008A3E RID: 35390
		internal static int __PropertyOffset_StereoBleed;

		// Token: 0x04008A3F RID: 35391
		internal static int __PropertyOffset_LFEBleed;

		// Token: 0x04008A40 RID: 35392
		internal static int __PropertyOffset_VoiceCenterChannelVolume;

		// Token: 0x04008A41 RID: 35393
		internal static int __PropertyOffset_RadioFilterVolume;

		// Token: 0x04008A42 RID: 35394
		internal static int __PropertyOffset_RadioFilterVolumeThreshold;

		// Token: 0x04008A43 RID: 35395
		internal static int __PropertyOffset_bApplyEffects;

		// Token: 0x04008A44 RID: 35396
		internal static byte __PropertyMask_bApplyEffects;

		// Token: 0x04008A45 RID: 35397
		internal static int __PropertyOffset_bAlwaysPlay;

		// Token: 0x04008A46 RID: 35398
		internal static byte __PropertyMask_bAlwaysPlay;

		// Token: 0x04008A47 RID: 35399
		internal static int __PropertyOffset_bIsUISound;

		// Token: 0x04008A48 RID: 35400
		internal static byte __PropertyMask_bIsUISound;

		// Token: 0x04008A49 RID: 35401
		internal static int __PropertyOffset_bIsMusic;

		// Token: 0x04008A4A RID: 35402
		internal static byte __PropertyMask_bIsMusic;

		// Token: 0x04008A4B RID: 35403
		internal static int __PropertyOffset_bCenterChannelOnly;

		// Token: 0x04008A4C RID: 35404
		internal static byte __PropertyMask_bCenterChannelOnly;

		// Token: 0x04008A4D RID: 35405
		internal static int __PropertyOffset_bApplyAmbientVolumes;

		// Token: 0x04008A4E RID: 35406
		internal static byte __PropertyMask_bApplyAmbientVolumes;

		// Token: 0x04008A4F RID: 35407
		internal static int __PropertyOffset_bReverb;

		// Token: 0x04008A50 RID: 35408
		internal static byte __PropertyMask_bReverb;

		// Token: 0x04008A51 RID: 35409
		internal static int __PropertyOffset_Default2DReverbSendAmount;

		// Token: 0x04008A52 RID: 35410
		internal static int __PropertyOffset_ModulationSettings;

		// Token: 0x04008A53 RID: 35411
		[Nullable(2)]
		private FSoundModulationDefaultSettings _ModulationSettings;

		// Token: 0x04008A54 RID: 35412
		internal static int __PropertyOffset_OutputTarget;

		// Token: 0x04008A55 RID: 35413
		internal static int __PropertyOffset_LoadingBehavior;

		// Token: 0x04008A56 RID: 35414
		internal static int __PropertyOffset_DefaultSubmix;
	}
}
