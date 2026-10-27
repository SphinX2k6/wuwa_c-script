using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001154 RID: 4436
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundSubmix")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class USoundSubmix : USoundSubmixWithParentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601033A RID: 66362 RVA: 0x0017E030 File Offset: 0x0017C230
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundSubmix._ClassPtr;
		}

		// Token: 0x0601033B RID: 66363 RVA: 0x0017E03C File Offset: 0x0017C23C
		public USoundSubmix() : this(BuiltinUtils.AllocNativeUObject(USoundSubmix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601033C RID: 66364 RVA: 0x0017E064 File Offset: 0x0017C264
		[NullableContext(1)]
		public USoundSubmix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundSubmix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0601033D RID: 66365 RVA: 0x0017E097 File Offset: 0x0017C297
		// (set) Token: 0x0601033E RID: 66366 RVA: 0x0017E0B0 File Offset: 0x0017C2B0
		public unsafe bool bMuteWhenBackgrounded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_bMuteWhenBackgrounded) & USoundSubmix.__PropertyMask_bMuteWhenBackgrounded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_bMuteWhenBackgrounded) = ((*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_bMuteWhenBackgrounded) & ~USoundSubmix.__PropertyMask_bMuteWhenBackgrounded) | (value ? USoundSubmix.__PropertyMask_bMuteWhenBackgrounded : 0));
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0601033F RID: 66367 RVA: 0x0017E0E0 File Offset: 0x0017C2E0
		// (set) Token: 0x06010340 RID: 66368 RVA: 0x0017E119 File Offset: 0x0017C319
		[Nullable(1)]
		public TArray<USoundEffectSubmixPreset> SubmixEffectChain
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USoundEffectSubmixPreset> result;
				if ((result = this._SubmixEffectChain) == null)
				{
					result = (this._SubmixEffectChain = new TArray<USoundEffectSubmixPreset>(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_SubmixEffectChain, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SubmixEffectChain.CopyAssign(value);
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x06010341 RID: 66369 RVA: 0x0017E127 File Offset: 0x0017C327
		// (set) Token: 0x06010342 RID: 66370 RVA: 0x0017E13B File Offset: 0x0017C33B
		public unsafe USoundfieldEncodingSettingsBase AmbisonicsPluginSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundfieldEncodingSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundSubmix.__PropertyOffset_AmbisonicsPluginSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundSubmix.__PropertyOffset_AmbisonicsPluginSettings, value);
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x06010343 RID: 66371 RVA: 0x0017E150 File Offset: 0x0017C350
		// (set) Token: 0x06010344 RID: 66372 RVA: 0x0017E160 File Offset: 0x0017C360
		public unsafe int EnvelopeFollowerAttackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_EnvelopeFollowerAttackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_EnvelopeFollowerAttackTime) = value;
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x06010345 RID: 66373 RVA: 0x0017E171 File Offset: 0x0017C371
		// (set) Token: 0x06010346 RID: 66374 RVA: 0x0017E181 File Offset: 0x0017C381
		public unsafe int EnvelopeFollowerReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_EnvelopeFollowerReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_EnvelopeFollowerReleaseTime) = value;
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x06010347 RID: 66375 RVA: 0x0017E192 File Offset: 0x0017C392
		// (set) Token: 0x06010348 RID: 66376 RVA: 0x0017E1A2 File Offset: 0x0017C3A2
		public unsafe EGainParamMode GainMode
		{
			get
			{
				return (EGainParamMode)(*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_GainMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_GainMode) = (byte)value;
			}
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x06010349 RID: 66377 RVA: 0x0017E1B3 File Offset: 0x0017C3B3
		// (set) Token: 0x0601034A RID: 66378 RVA: 0x0017E1C3 File Offset: 0x0017C3C3
		public unsafe float OutputVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_OutputVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_OutputVolume) = value;
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0601034B RID: 66379 RVA: 0x0017E1D4 File Offset: 0x0017C3D4
		// (set) Token: 0x0601034C RID: 66380 RVA: 0x0017E1E4 File Offset: 0x0017C3E4
		public unsafe float WetLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_WetLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_WetLevel) = value;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0601034D RID: 66381 RVA: 0x0017E1F5 File Offset: 0x0017C3F5
		// (set) Token: 0x0601034E RID: 66382 RVA: 0x0017E205 File Offset: 0x0017C405
		public unsafe float DryLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_DryLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_DryLevel) = value;
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0601034F RID: 66383 RVA: 0x0017E218 File Offset: 0x0017C418
		// (set) Token: 0x06010350 RID: 66384 RVA: 0x0017E251 File Offset: 0x0017C451
		[Nullable(1)]
		public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnSubmixRecordedFileDone result;
				if ((result = this._OnSubmixRecordedFileDone) == null)
				{
					result = (this._OnSubmixRecordedFileDone = new FOnSubmixRecordedFileDone(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_OnSubmixRecordedFileDone, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USoundSubmix.__PropertyOffset_OnSubmixRecordedFileDone, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06010351 RID: 66385 RVA: 0x0017E272 File Offset: 0x0017C472
		public void StopSpectralAnalysis(UObject WorldContextObject)
		{
			USoundSubmix.__StopSpectralAnalysis_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010352 RID: 66386 RVA: 0x0017E290 File Offset: 0x0017C490
		[NullableContext(1)]
		public unsafe void StopRecordingOutput([Nullable(2)] UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, [Nullable(2)] USoundWave ExistingSoundWaveToOverwrite = null)
		{
			FString fstring = FString.AllocTemp(Name);
			FString fstring2 = FString.AllocTemp(Path);
			USoundSubmix.__StopRecordingOutput_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ExportType, fstring, fstring2, (ExistingSoundWaveToOverwrite != null) ? ExistingSoundWaveToOverwrite.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06010353 RID: 66387 RVA: 0x0017E2F0 File Offset: 0x0017C4F0
		public void StopEnvelopeFollowing(UObject WorldContextObject)
		{
			USoundSubmix.__StopEnvelopeFollowing_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010354 RID: 66388 RVA: 0x0017E30D File Offset: 0x0017C50D
		public void StartSpectralAnalysis(UObject WorldContextObject, EFFTSize FFTSize = EFFTSize.DefaultSize, EFFTPeakInterpolationMethod InterpolationMethod = EFFTPeakInterpolationMethod.Linear, EFFTWindowType WindowType = EFFTWindowType.Hann, float HopSize = 0f, EAudioSpectrumType SpectrumType = EAudioSpectrumType.MagnitudeSpectrum)
		{
			USoundSubmix.__StartSpectralAnalysis_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, FFTSize, InterpolationMethod, WindowType, HopSize, SpectrumType);
		}

		// Token: 0x06010355 RID: 66389 RVA: 0x0017E332 File Offset: 0x0017C532
		public void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration)
		{
			USoundSubmix.__StartRecordingOutput_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ExpectedDuration);
		}

		// Token: 0x06010356 RID: 66390 RVA: 0x0017E350 File Offset: 0x0017C550
		public void StartEnvelopeFollowing(UObject WorldContextObject)
		{
			USoundSubmix.__StartEnvelopeFollowing_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010357 RID: 66391 RVA: 0x0017E36D File Offset: 0x0017C56D
		public void SetSubmixOutputVolume(UObject WorldContextObject, float InOutputVolume)
		{
			USoundSubmix.__SetSubmixOutputVolume_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InOutputVolume);
		}

		// Token: 0x06010358 RID: 66392 RVA: 0x0017E38B File Offset: 0x0017C58B
		public void RemoveSpectralAnalysisDelegate(UObject WorldContextObject, in FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FOnSubmixSpectralAnalysisBP fonSubmixSpectralAnalysisBP = OnSubmixSpectralAnalysisBP;
			USoundSubmix.__RemoveSpectralAnalysisDelegate_Internal(nativePtr, worldContextObject, (fonSubmixSpectralAnalysisBP != null) ? fonSubmixSpectralAnalysisBP.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06010359 RID: 66393 RVA: 0x0017E3B8 File Offset: 0x0017C5B8
		public void AddSpectralAnalysisDelegate(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings, in FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP, float UpdateRate = 10f, float DecibelNoiseFloor = -40f, bool bDoNormalize = true, bool bDoAutoRange = false, float AutoRangeAttackTime = 0.1f, float AutoRangeReleaseTime = 60f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (InBandSettings ?? new TArray<FSoundSubmixSpectralAnalysisBandSettings>()).NativePtr;
			FOnSubmixSpectralAnalysisBP fonSubmixSpectralAnalysisBP = OnSubmixSpectralAnalysisBP;
			USoundSubmix.__AddSpectralAnalysisDelegate_Internal(nativePtr, worldContextObject, nativePtr2, (fonSubmixSpectralAnalysisBP != null) ? fonSubmixSpectralAnalysisBP.NativePtr : ((IntPtr)0), UpdateRate, DecibelNoiseFloor, bDoNormalize, bDoAutoRange, AutoRangeAttackTime, AutoRangeReleaseTime);
		}

		// Token: 0x0601035A RID: 66394 RVA: 0x0017E40B File Offset: 0x0017C60B
		public void AddEnvelopeFollowerDelegate(UObject WorldContextObject, in FOnSubmixEnvelopeBP OnSubmixEnvelopeBP)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FOnSubmixEnvelopeBP fonSubmixEnvelopeBP = OnSubmixEnvelopeBP;
			USoundSubmix.__AddEnvelopeFollowerDelegate_Internal(nativePtr, worldContextObject, (fonSubmixEnvelopeBP != null) ? fonSubmixEnvelopeBP.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601035B RID: 66395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSpectralAnalysis_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x0601035C RID: 66396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopRecordingOutput_Internal(IntPtr @this, IntPtr WorldContextObject, EAudioRecordingExportType ExportType, in FString Name, in FString Path, IntPtr ExistingSoundWaveToOverwrite);

		// Token: 0x0601035D RID: 66397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopEnvelopeFollowing_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x0601035E RID: 66398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSpectralAnalysis_Internal(IntPtr @this, IntPtr WorldContextObject, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType);

		// Token: 0x0601035F RID: 66399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartRecordingOutput_Internal(IntPtr @this, IntPtr WorldContextObject, float ExpectedDuration);

		// Token: 0x06010360 RID: 66400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartEnvelopeFollowing_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x06010361 RID: 66401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixOutputVolume_Internal(IntPtr @this, IntPtr WorldContextObject, float InOutputVolume);

		// Token: 0x06010362 RID: 66402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSpectralAnalysisDelegate_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr OnSubmixSpectralAnalysisBP);

		// Token: 0x06010363 RID: 66403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSpectralAnalysisDelegate_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr InBandSettings, IntPtr OnSubmixSpectralAnalysisBP, float UpdateRate, float DecibelNoiseFloor, bool bDoNormalize, bool bDoAutoRange, float AutoRangeAttackTime, float AutoRangeReleaseTime);

		// Token: 0x06010364 RID: 66404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddEnvelopeFollowerDelegate_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr OnSubmixEnvelopeBP);

		// Token: 0x06010365 RID: 66405 RVA: 0x0017E437 File Offset: 0x0017C637
		static USoundSubmix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundSubmix");
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x0017E445 File Offset: 0x0017C645
		protected USoundSubmix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B81 RID: 35713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundSubmix";

		// Token: 0x04008B82 RID: 35714
		private static IntPtr _ClassPtr;

		// Token: 0x04008B83 RID: 35715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B84 RID: 35716
		internal static int __PropertyOffset_bMuteWhenBackgrounded;

		// Token: 0x04008B85 RID: 35717
		internal static byte __PropertyMask_bMuteWhenBackgrounded;

		// Token: 0x04008B86 RID: 35718
		internal static int __PropertyOffset_SubmixEffectChain;

		// Token: 0x04008B87 RID: 35719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundEffectSubmixPreset> _SubmixEffectChain;

		// Token: 0x04008B88 RID: 35720
		internal static int __PropertyOffset_AmbisonicsPluginSettings;

		// Token: 0x04008B89 RID: 35721
		internal static int __PropertyOffset_EnvelopeFollowerAttackTime;

		// Token: 0x04008B8A RID: 35722
		internal static int __PropertyOffset_EnvelopeFollowerReleaseTime;

		// Token: 0x04008B8B RID: 35723
		internal static int __PropertyOffset_GainMode;

		// Token: 0x04008B8C RID: 35724
		internal static int __PropertyOffset_OutputVolume;

		// Token: 0x04008B8D RID: 35725
		internal static int __PropertyOffset_WetLevel;

		// Token: 0x04008B8E RID: 35726
		internal static int __PropertyOffset_DryLevel;

		// Token: 0x04008B8F RID: 35727
		internal static int __PropertyOffset_OnSubmixRecordedFileDone;

		// Token: 0x04008B90 RID: 35728
		private FOnSubmixRecordedFileDone _OnSubmixRecordedFileDone;
	}
}
