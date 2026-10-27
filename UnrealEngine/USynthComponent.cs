using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000385 RID: 901
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SynthComponent")]
	[UnrealStructLayout(1840, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1840)]
	public class USynthComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600319F RID: 12703 RVA: 0x0004CACC File Offset: 0x0004ACCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USynthComponent._ClassPtr;
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
		public USynthComponent() : this(BuiltinUtils.AllocNativeUObject(USynthComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0004CB00 File Offset: 0x0004AD00
		[NullableContext(1)]
		public USynthComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USynthComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x0004CB33 File Offset: 0x0004AD33
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x0004CB4C File Offset: 0x0004AD4C
		public unsafe bool bAutoDestroy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAutoDestroy) & USynthComponent.__PropertyMask_bAutoDestroy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAutoDestroy) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAutoDestroy) & ~USynthComponent.__PropertyMask_bAutoDestroy) | (value ? USynthComponent.__PropertyMask_bAutoDestroy : 0));
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x0004CB7C File Offset: 0x0004AD7C
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x0004CB95 File Offset: 0x0004AD95
		public unsafe bool bStopWhenOwnerDestroyed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & USynthComponent.__PropertyMask_bStopWhenOwnerDestroyed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bStopWhenOwnerDestroyed) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & ~USynthComponent.__PropertyMask_bStopWhenOwnerDestroyed) | (value ? USynthComponent.__PropertyMask_bStopWhenOwnerDestroyed : 0));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0004CBC5 File Offset: 0x0004ADC5
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0004CBDE File Offset: 0x0004ADDE
		public unsafe bool bAllowSpatialization
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAllowSpatialization) & USynthComponent.__PropertyMask_bAllowSpatialization) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAllowSpatialization) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bAllowSpatialization) & ~USynthComponent.__PropertyMask_bAllowSpatialization) | (value ? USynthComponent.__PropertyMask_bAllowSpatialization : 0));
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0004CC0E File Offset: 0x0004AE0E
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0004CC27 File Offset: 0x0004AE27
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOverrideAttenuation) & USynthComponent.__PropertyMask_bOverrideAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOverrideAttenuation) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOverrideAttenuation) & ~USynthComponent.__PropertyMask_bOverrideAttenuation) | (value ? USynthComponent.__PropertyMask_bOverrideAttenuation : 0));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0004CC57 File Offset: 0x0004AE57
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x0004CC70 File Offset: 0x0004AE70
		public unsafe bool bOutputToBusOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOutputToBusOnly) & USynthComponent.__PropertyMask_bOutputToBusOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOutputToBusOnly) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bOutputToBusOnly) & ~USynthComponent.__PropertyMask_bOutputToBusOnly) | (value ? USynthComponent.__PropertyMask_bOutputToBusOnly : 0));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0004CCA0 File Offset: 0x0004AEA0
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0004CCB4 File Offset: 0x0004AEB4
		public unsafe USoundAttenuation AttenuationSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_AttenuationSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0004CCCC File Offset: 0x0004AECC
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0004CD05 File Offset: 0x0004AF05
		[Nullable(1)]
		public FSoundAttenuationSettings AttenuationOverrides
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationSettings result;
				if ((result = this._AttenuationOverrides) == null)
				{
					result = (this._AttenuationOverrides = new FSoundAttenuationSettings(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_AttenuationOverrides, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_AttenuationOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0004CD26 File Offset: 0x0004AF26
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x0004CD3A File Offset: 0x0004AF3A
		public unsafe USoundConcurrency ConcurrencySettings_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundConcurrency>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_ConcurrencySettings_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_ConcurrencySettings_DEPRECATED, value);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x0004CD50 File Offset: 0x0004AF50
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x0004CD89 File Offset: 0x0004AF89
		[Nullable(1)]
		public TSet<USoundConcurrency> ConcurrencySet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<USoundConcurrency> result;
				if ((result = this._ConcurrencySet) == null)
				{
					result = (this._ConcurrencySet = new TSet<USoundConcurrency>(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_ConcurrencySet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ConcurrencySet.CopyAssign(value);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x0004CD97 File Offset: 0x0004AF97
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x0004CDAB File Offset: 0x0004AFAB
		public unsafe USoundClass SoundClass
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SoundClass);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SoundClass, value);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x0004CDC0 File Offset: 0x0004AFC0
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		public unsafe USoundEffectSourcePresetChain SourceEffectChain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSourcePresetChain>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SourceEffectChain);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SourceEffectChain, value);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0004CDE9 File Offset: 0x0004AFE9
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x0004CDFD File Offset: 0x0004AFFD
		public unsafe USoundSubmixBase SoundSubmix
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmixBase>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SoundSubmix);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_SoundSubmix, value);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x0004CE14 File Offset: 0x0004B014
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x0004CE4D File Offset: 0x0004B04D
		[Nullable(1)]
		public TArray<FSoundSubmixSendInfo> SoundSubmixSends
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSubmixSendInfo> result;
				if ((result = this._SoundSubmixSends) == null)
				{
					result = (this._SoundSubmixSends = new TArray<FSoundSubmixSendInfo>(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_SoundSubmixSends, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoundSubmixSends.CopyAssign(value);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0004CE5C File Offset: 0x0004B05C
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0004CE95 File Offset: 0x0004B095
		[Nullable(1)]
		public TArray<FSoundSourceBusSendInfo> BusSends
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSourceBusSendInfo> result;
				if ((result = this._BusSends) == null)
				{
					result = (this._BusSends = new TArray<FSoundSourceBusSendInfo>(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_BusSends, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BusSends.CopyAssign(value);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x0004CEA4 File Offset: 0x0004B0A4
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x0004CEDD File Offset: 0x0004B0DD
		[Nullable(1)]
		public TArray<FSoundSourceBusSendInfo> PreEffectBusSends
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSourceBusSendInfo> result;
				if ((result = this._PreEffectBusSends) == null)
				{
					result = (this._PreEffectBusSends = new TArray<FSoundSourceBusSendInfo>(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_PreEffectBusSends, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PreEffectBusSends.CopyAssign(value);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x0004CEEB File Offset: 0x0004B0EB
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x0004CF04 File Offset: 0x0004B104
		public unsafe bool bIsUISound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsUISound) & USynthComponent.__PropertyMask_bIsUISound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsUISound) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsUISound) & ~USynthComponent.__PropertyMask_bIsUISound) | (value ? USynthComponent.__PropertyMask_bIsUISound : 0));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x0004CF34 File Offset: 0x0004B134
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x0004CF4D File Offset: 0x0004B14D
		public unsafe bool bIsPreviewSound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsPreviewSound) & USynthComponent.__PropertyMask_bIsPreviewSound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsPreviewSound) = ((*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_bIsPreviewSound) & ~USynthComponent.__PropertyMask_bIsPreviewSound) | (value ? USynthComponent.__PropertyMask_bIsPreviewSound : 0));
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x0004CF7D File Offset: 0x0004B17D
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x0004CF8D File Offset: 0x0004B18D
		public unsafe int EnvelopeFollowerAttackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_EnvelopeFollowerAttackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_EnvelopeFollowerAttackTime) = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0004CF9E File Offset: 0x0004B19E
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x0004CFAE File Offset: 0x0004B1AE
		public unsafe int EnvelopeFollowerReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_EnvelopeFollowerReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_EnvelopeFollowerReleaseTime) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x0004CFF9 File Offset: 0x0004B1F9
		[Nullable(1)]
		public FOnSynthEnvelopeValue OnAudioEnvelopeValue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnSynthEnvelopeValue result;
				if ((result = this._OnAudioEnvelopeValue) == null)
				{
					result = (this._OnAudioEnvelopeValue = new FOnSynthEnvelopeValue(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_OnAudioEnvelopeValue, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USynthComponent.__PropertyOffset_OnAudioEnvelopeValue, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0004D01A File Offset: 0x0004B21A
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x0004D02E File Offset: 0x0004B22E
		public unsafe USynthSound Synth
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USynthSound>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_Synth);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_Synth, value);
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0004D043 File Offset: 0x0004B243
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0004D057 File Offset: 0x0004B257
		public unsafe UAudioComponent AudioComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_AudioComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthComponent.__PropertyOffset_AudioComponent, value);
			}
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0004D06C File Offset: 0x0004B26C
		public void Stop()
		{
			USynthComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x0004D079 File Offset: 0x0004B279
		public void Start()
		{
			USynthComponent.__Start_Internal(base.NativePtr);
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0004D086 File Offset: 0x0004B286
		public void SetVolumeMultiplier(float VolumeMultiplier)
		{
			USynthComponent.__SetVolumeMultiplier_Internal(base.NativePtr, VolumeMultiplier);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0004D094 File Offset: 0x0004B294
		public void SetSubmixSend(USoundSubmixBase Submix, float SendLevel)
		{
			USynthComponent.__SetSubmixSend_Internal(base.NativePtr, (Submix != null) ? Submix.NativePtr : IntPtr.Zero, SendLevel);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0004D0B2 File Offset: 0x0004B2B2
		public void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
		{
			USynthComponent.__SetLowPassFilterFrequency_Internal(base.NativePtr, InLowPassFilterFrequency);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
		{
			USynthComponent.__SetLowPassFilterEnabled_Internal(base.NativePtr, InLowPassFilterEnabled);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0004D0CE File Offset: 0x0004B2CE
		public bool IsPlaying()
		{
			return USynthComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x060031D5 RID: 12757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060031D6 RID: 12758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x060031D7 RID: 12759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumeMultiplier_Internal(IntPtr @this, float VolumeMultiplier);

		// Token: 0x060031D8 RID: 12760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixSend_Internal(IntPtr @this, IntPtr Submix, float SendLevel);

		// Token: 0x060031D9 RID: 12761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowPassFilterFrequency_Internal(IntPtr @this, float InLowPassFilterFrequency);

		// Token: 0x060031DA RID: 12762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowPassFilterEnabled_Internal(IntPtr @this, bool InLowPassFilterEnabled);

		// Token: 0x060031DB RID: 12763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x060031DC RID: 12764 RVA: 0x0004D0DB File Offset: 0x0004B2DB
		static USynthComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.SynthComponent");
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0004D0E9 File Offset: 0x0004B2E9
		protected USynthComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001599 RID: 5529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.SynthComponent";

		// Token: 0x0400159A RID: 5530
		private static IntPtr _ClassPtr;

		// Token: 0x0400159B RID: 5531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400159C RID: 5532
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x0400159D RID: 5533
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x0400159E RID: 5534
		internal static int __PropertyOffset_bStopWhenOwnerDestroyed;

		// Token: 0x0400159F RID: 5535
		internal static byte __PropertyMask_bStopWhenOwnerDestroyed;

		// Token: 0x040015A0 RID: 5536
		internal static int __PropertyOffset_bAllowSpatialization;

		// Token: 0x040015A1 RID: 5537
		internal static byte __PropertyMask_bAllowSpatialization;

		// Token: 0x040015A2 RID: 5538
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x040015A3 RID: 5539
		internal static byte __PropertyMask_bOverrideAttenuation;

		// Token: 0x040015A4 RID: 5540
		internal static int __PropertyOffset_bOutputToBusOnly;

		// Token: 0x040015A5 RID: 5541
		internal static byte __PropertyMask_bOutputToBusOnly;

		// Token: 0x040015A6 RID: 5542
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x040015A7 RID: 5543
		internal static int __PropertyOffset_AttenuationOverrides;

		// Token: 0x040015A8 RID: 5544
		private FSoundAttenuationSettings _AttenuationOverrides;

		// Token: 0x040015A9 RID: 5545
		internal static int __PropertyOffset_ConcurrencySettings_DEPRECATED;

		// Token: 0x040015AA RID: 5546
		internal static int __PropertyOffset_ConcurrencySet;

		// Token: 0x040015AB RID: 5547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USoundConcurrency> _ConcurrencySet;

		// Token: 0x040015AC RID: 5548
		internal static int __PropertyOffset_SoundClass;

		// Token: 0x040015AD RID: 5549
		internal static int __PropertyOffset_SourceEffectChain;

		// Token: 0x040015AE RID: 5550
		internal static int __PropertyOffset_SoundSubmix;

		// Token: 0x040015AF RID: 5551
		internal static int __PropertyOffset_SoundSubmixSends;

		// Token: 0x040015B0 RID: 5552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSubmixSendInfo> _SoundSubmixSends;

		// Token: 0x040015B1 RID: 5553
		internal static int __PropertyOffset_BusSends;

		// Token: 0x040015B2 RID: 5554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSourceBusSendInfo> _BusSends;

		// Token: 0x040015B3 RID: 5555
		internal static int __PropertyOffset_PreEffectBusSends;

		// Token: 0x040015B4 RID: 5556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSourceBusSendInfo> _PreEffectBusSends;

		// Token: 0x040015B5 RID: 5557
		internal static int __PropertyOffset_bIsUISound;

		// Token: 0x040015B6 RID: 5558
		internal static byte __PropertyMask_bIsUISound;

		// Token: 0x040015B7 RID: 5559
		internal static int __PropertyOffset_bIsPreviewSound;

		// Token: 0x040015B8 RID: 5560
		internal static byte __PropertyMask_bIsPreviewSound;

		// Token: 0x040015B9 RID: 5561
		internal static int __PropertyOffset_EnvelopeFollowerAttackTime;

		// Token: 0x040015BA RID: 5562
		internal static int __PropertyOffset_EnvelopeFollowerReleaseTime;

		// Token: 0x040015BB RID: 5563
		internal static int __PropertyOffset_OnAudioEnvelopeValue;

		// Token: 0x040015BC RID: 5564
		private FOnSynthEnvelopeValue _OnAudioEnvelopeValue;

		// Token: 0x040015BD RID: 5565
		internal static int __PropertyOffset_Synth;

		// Token: 0x040015BE RID: 5566
		internal static int __PropertyOffset_AudioComponent;
	}
}
