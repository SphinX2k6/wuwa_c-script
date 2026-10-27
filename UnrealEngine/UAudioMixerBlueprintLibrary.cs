using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000374 RID: 884
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.AudioMixerBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAudioMixerBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600306B RID: 12395 RVA: 0x0004AFEA File Offset: 0x000491EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioMixerBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0004AFF8 File Offset: 0x000491F8
		public UAudioMixerBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UAudioMixerBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0004B020 File Offset: 0x00049220
		[NullableContext(1)]
		public UAudioMixerBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioMixerBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600306E RID: 12398
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float TrimAudioCache(float InMegabytesToFree);

		// Token: 0x0600306F RID: 12399 RVA: 0x0004B054 File Offset: 0x00049254
		public unsafe static USoundWave StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, [Nullable(1)] string Name, [Nullable(1)] string Path, USoundSubmix SubmixToRecord = null, USoundWave ExistingSoundWaveToOverwrite = null)
		{
			FString fstring = FString.AllocTemp(Name);
			FString fstring2 = FString.AllocTemp(Path);
			USoundWave orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundWave>(UAudioMixerBlueprintLibrary.__StopRecordingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ExportType, fstring, fstring2, (SubmixToRecord != null) ? SubmixToRecord.NativePtr : IntPtr.Zero, (ExistingSoundWaveToOverwrite != null) ? ExistingSoundWaveToOverwrite.NativePtr : IntPtr.Zero));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0004B0C4 File Offset: 0x000492C4
		public static void StopAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
		{
			UAudioMixerBlueprintLibrary.__StopAudioBus_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AudioBus != null) ? AudioBus.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0004B0EB File Offset: 0x000492EB
		public static void StopAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToStopAnalyzing = null)
		{
			UAudioMixerBlueprintLibrary.__StopAnalyzingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixToStopAnalyzing != null) ? SubmixToStopAnalyzing.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x0004B112 File Offset: 0x00049312
		public static void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration, USoundSubmix SubmixToRecord = null)
		{
			UAudioMixerBlueprintLibrary.__StartRecordingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ExpectedDuration, (SubmixToRecord != null) ? SubmixToRecord.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0004B13A File Offset: 0x0004933A
		public static void StartAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
		{
			UAudioMixerBlueprintLibrary.__StartAudioBus_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AudioBus != null) ? AudioBus.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0004B161 File Offset: 0x00049361
		public static void StartAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToAnalyze = null, EFFTSize FFTSize = EFFTSize.DefaultSize, EFFTPeakInterpolationMethod InterpolationMethod = EFFTPeakInterpolationMethod.Linear, EFFTWindowType WindowType = EFFTWindowType.Hann, float HopSize = 0f, EAudioSpectrumType SpectrumType = EAudioSpectrumType.MagnitudeSpectrum)
		{
			UAudioMixerBlueprintLibrary.__StartAnalyzingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixToAnalyze != null) ? SubmixToAnalyze.NativePtr : IntPtr.Zero, FFTSize, InterpolationMethod, WindowType, HopSize, SpectrumType);
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0004B190 File Offset: 0x00049390
		public static void SetSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<USoundEffectSubmixPreset> SubmixEffectPresetChain, float FadeTimeSec)
		{
			UAudioMixerBlueprintLibrary.__SetSubmixEffectChainOverride_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero, (SubmixEffectPresetChain ?? new TArray<USoundEffectSubmixPreset>()).NativePtr, FadeTimeSec);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0004B1C7 File Offset: 0x000493C7
		public static void SetBypassSourceEffectChainEntry(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed)
		{
			UAudioMixerBlueprintLibrary.__SetBypassSourceEffectChainEntry_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PresetChain != null) ? PresetChain.NativePtr : IntPtr.Zero, EntryIndex, bBypassed);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0004B1F0 File Offset: 0x000493F0
		public static void ResumeRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause = null)
		{
			UAudioMixerBlueprintLibrary.__ResumeRecordingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixToPause != null) ? SubmixToPause.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0004B217 File Offset: 0x00049417
		public static void ReplaceSoundEffectSubmix(UObject WorldContextObject, USoundSubmix InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			UAudioMixerBlueprintLibrary.__ReplaceSoundEffectSubmix_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundSubmix != null) ? InSoundSubmix.NativePtr : IntPtr.Zero, SubmixChainIndex, (SubmixEffectPreset != null) ? SubmixEffectPreset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0004B24F File Offset: 0x0004944F
		public static void RemoveSubmixEffectPresetAtIndex(UObject WorldContextObject, USoundSubmix SoundSubmix, int SubmixChainIndex)
		{
			UAudioMixerBlueprintLibrary.__RemoveSubmixEffectPresetAtIndex_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero, SubmixChainIndex);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0004B277 File Offset: 0x00049477
		public static void RemoveSubmixEffectPreset(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			UAudioMixerBlueprintLibrary.__RemoveSubmixEffectPreset_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero, (SubmixEffectPreset != null) ? SubmixEffectPreset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0004B2AE File Offset: 0x000494AE
		public static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex)
		{
			UAudioMixerBlueprintLibrary.__RemoveSourceEffectFromPresetChain_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PresetChain != null) ? PresetChain.NativePtr : IntPtr.Zero, EntryIndex);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0004B2D6 File Offset: 0x000494D6
		public static void RemoveMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			UAudioMixerBlueprintLibrary.__RemoveMasterSubmixEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixEffectPreset != null) ? SubmixEffectPreset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0004B2FD File Offset: 0x000494FD
		public static void PrimeSoundForPlayback(USoundWave SoundWave, FOnSoundLoadComplete OnLoadCompletion)
		{
			UAudioMixerBlueprintLibrary.__PrimeSoundForPlayback_Internal((SoundWave != null) ? SoundWave.NativePtr : IntPtr.Zero, (OnLoadCompletion != null) ? OnLoadCompletion.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0004B321 File Offset: 0x00049521
		public static void PrimeSoundCueForPlayback(USoundCue SoundCue)
		{
			UAudioMixerBlueprintLibrary.__PrimeSoundCueForPlayback_Internal((SoundCue != null) ? SoundCue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0004B338 File Offset: 0x00049538
		public static void PauseRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause = null)
		{
			UAudioMixerBlueprintLibrary.__PauseRecordingOutput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixToPause != null) ? SubmixToPause.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0004B35F File Offset: 0x0004955F
		[NullableContext(1)]
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands = 10, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			return new TArray<FSoundSubmixSpectralAnalysisBandSettings>(UAudioMixerBlueprintLibrary.__MakePresetSpectralAnalysisBandSettings_Internal(InBandPresetType, InNumBands, InAttackTimeMsec, InReleaseTimeMsec), null);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0004B370 File Offset: 0x00049570
		[NullableContext(1)]
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones = 60, EMusicalNoteName InStartingMusicalNote = EMusicalNoteName.C, int InStartingOctave = 2, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			return new TArray<FSoundSubmixSpectralAnalysisBandSettings>(UAudioMixerBlueprintLibrary.__MakeMusicalSpectralAnalysisBandSettings_Internal(InNumSemitones, InStartingMusicalNote, InStartingOctave, InAttackTimeMsec, InReleaseTimeMsec), null);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0004B383 File Offset: 0x00049583
		[NullableContext(1)]
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands = 30, float InMinimumFrequency = 40f, float InMaximumFrequency = 16000f, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			return new TArray<FSoundSubmixSpectralAnalysisBandSettings>(UAudioMixerBlueprintLibrary.__MakeFullSpectrumSpectralAnalysisBandSettings_Internal(InNumBands, InMinimumFrequency, InMaximumFrequency, InAttackTimeMsec, InReleaseTimeMsec), null);
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0004B396 File Offset: 0x00049596
		public static bool IsAudioBusActive(UObject WorldContextObject, UAudioBus AudioBus)
		{
			return UAudioMixerBlueprintLibrary.__IsAudioBusActive_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AudioBus != null) ? AudioBus.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0004B3C0 File Offset: 0x000495C0
		public static void GetPhaseForFrequencies(UObject WorldContextObject, in TArray<float> Frequencies, ref TArray<float> Phases, USoundSubmix SubmixToAnalyze = null)
		{
			UAudioMixerBlueprintLibrary.__GetPhaseForFrequencies_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Frequencies ?? new TArray<float>()).NativePtr, (Phases ?? new TArray<float>()).NativePtr, (SubmixToAnalyze != null) ? SubmixToAnalyze.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0004B412 File Offset: 0x00049612
		public static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain)
		{
			return UAudioMixerBlueprintLibrary.__GetNumberOfEntriesInSourceEffectChain_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PresetChain != null) ? PresetChain.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x0004B43C File Offset: 0x0004963C
		public static void GetMagnitudeForFrequencies(UObject WorldContextObject, in TArray<float> Frequencies, ref TArray<float> Magnitudes, USoundSubmix SubmixToAnalyze = null)
		{
			UAudioMixerBlueprintLibrary.__GetMagnitudeForFrequencies_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Frequencies ?? new TArray<float>()).NativePtr, (Magnitudes ?? new TArray<float>()).NativePtr, (SubmixToAnalyze != null) ? SubmixToAnalyze.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0004B48E File Offset: 0x0004968E
		public static void ClearSubmixEffects(UObject WorldContextObject, USoundSubmix SoundSubmix)
		{
			UAudioMixerBlueprintLibrary.__ClearSubmixEffects_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0004B4B5 File Offset: 0x000496B5
		public static void ClearSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, float FadeTimeSec)
		{
			UAudioMixerBlueprintLibrary.__ClearSubmixEffectChainOverride_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero, FadeTimeSec);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x0004B4DD File Offset: 0x000496DD
		public static void ClearMasterSubmixEffects(UObject WorldContextObject)
		{
			UAudioMixerBlueprintLibrary.__ClearMasterSubmixEffects_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x0004B4F4 File Offset: 0x000496F4
		public static int AddSubmixEffect(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			return UAudioMixerBlueprintLibrary.__AddSubmixEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundSubmix != null) ? SoundSubmix.NativePtr : IntPtr.Zero, (SubmixEffectPreset != null) ? SubmixEffectPreset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0004B52B File Offset: 0x0004972B
		public static void AddSourceEffectToPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, FSourceEffectChainEntry Entry)
		{
			UAudioMixerBlueprintLibrary.__AddSourceEffectToPresetChain_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PresetChain != null) ? PresetChain.NativePtr : IntPtr.Zero, (Entry ?? new FSourceEffectChainEntry()).NativePtr);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x0004B561 File Offset: 0x00049761
		public static void AddMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			UAudioMixerBlueprintLibrary.__AddMasterSubmixEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SubmixEffectPreset != null) ? SubmixEffectPreset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600308D RID: 12429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StopRecordingOutput_Internal(IntPtr WorldContextObject, EAudioRecordingExportType ExportType, in FString Name, in FString Path, IntPtr SubmixToRecord, IntPtr ExistingSoundWaveToOverwrite);

		// Token: 0x0600308E RID: 12430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAudioBus_Internal(IntPtr WorldContextObject, IntPtr AudioBus);

		// Token: 0x0600308F RID: 12431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnalyzingOutput_Internal(IntPtr WorldContextObject, IntPtr SubmixToStopAnalyzing);

		// Token: 0x06003090 RID: 12432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartRecordingOutput_Internal(IntPtr WorldContextObject, float ExpectedDuration, IntPtr SubmixToRecord);

		// Token: 0x06003091 RID: 12433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAudioBus_Internal(IntPtr WorldContextObject, IntPtr AudioBus);

		// Token: 0x06003092 RID: 12434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAnalyzingOutput_Internal(IntPtr WorldContextObject, IntPtr SubmixToAnalyze, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType);

		// Token: 0x06003093 RID: 12435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixEffectChainOverride_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix, IntPtr SubmixEffectPresetChain, float FadeTimeSec);

		// Token: 0x06003094 RID: 12436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBypassSourceEffectChainEntry_Internal(IntPtr WorldContextObject, IntPtr PresetChain, int EntryIndex, bool bBypassed);

		// Token: 0x06003095 RID: 12437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeRecordingOutput_Internal(IntPtr WorldContextObject, IntPtr SubmixToPause);

		// Token: 0x06003096 RID: 12438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplaceSoundEffectSubmix_Internal(IntPtr WorldContextObject, IntPtr InSoundSubmix, int SubmixChainIndex, IntPtr SubmixEffectPreset);

		// Token: 0x06003097 RID: 12439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSubmixEffectPresetAtIndex_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix, int SubmixChainIndex);

		// Token: 0x06003098 RID: 12440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSubmixEffectPreset_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix, IntPtr SubmixEffectPreset);

		// Token: 0x06003099 RID: 12441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSourceEffectFromPresetChain_Internal(IntPtr WorldContextObject, IntPtr PresetChain, int EntryIndex);

		// Token: 0x0600309A RID: 12442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveMasterSubmixEffect_Internal(IntPtr WorldContextObject, IntPtr SubmixEffectPreset);

		// Token: 0x0600309B RID: 12443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrimeSoundForPlayback_Internal(IntPtr SoundWave, IntPtr OnLoadCompletion);

		// Token: 0x0600309C RID: 12444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrimeSoundCueForPlayback_Internal(IntPtr SoundCue);

		// Token: 0x0600309D RID: 12445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseRecordingOutput_Internal(IntPtr WorldContextObject, IntPtr SubmixToPause);

		// Token: 0x0600309E RID: 12446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakePresetSpectralAnalysisBandSettings_Internal(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands, int InAttackTimeMsec, int InReleaseTimeMsec);

		// Token: 0x0600309F RID: 12447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeMusicalSpectralAnalysisBandSettings_Internal(int InNumSemitones, EMusicalNoteName InStartingMusicalNote, int InStartingOctave, int InAttackTimeMsec, int InReleaseTimeMsec);

		// Token: 0x060030A0 RID: 12448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeFullSpectrumSpectralAnalysisBandSettings_Internal(int InNumBands, float InMinimumFrequency, float InMaximumFrequency, int InAttackTimeMsec, int InReleaseTimeMsec);

		// Token: 0x060030A1 RID: 12449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAudioBusActive_Internal(IntPtr WorldContextObject, IntPtr AudioBus);

		// Token: 0x060030A2 RID: 12450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPhaseForFrequencies_Internal(IntPtr WorldContextObject, IntPtr Frequencies, IntPtr Phases, IntPtr SubmixToAnalyze);

		// Token: 0x060030A3 RID: 12451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfEntriesInSourceEffectChain_Internal(IntPtr WorldContextObject, IntPtr PresetChain);

		// Token: 0x060030A4 RID: 12452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMagnitudeForFrequencies_Internal(IntPtr WorldContextObject, IntPtr Frequencies, IntPtr Magnitudes, IntPtr SubmixToAnalyze);

		// Token: 0x060030A5 RID: 12453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSubmixEffects_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix);

		// Token: 0x060030A6 RID: 12454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSubmixEffectChainOverride_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix, float FadeTimeSec);

		// Token: 0x060030A7 RID: 12455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMasterSubmixEffects_Internal(IntPtr WorldContextObject);

		// Token: 0x060030A8 RID: 12456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddSubmixEffect_Internal(IntPtr WorldContextObject, IntPtr SoundSubmix, IntPtr SubmixEffectPreset);

		// Token: 0x060030A9 RID: 12457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSourceEffectToPresetChain_Internal(IntPtr WorldContextObject, IntPtr PresetChain, IntPtr Entry);

		// Token: 0x060030AA RID: 12458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMasterSubmixEffect_Internal(IntPtr WorldContextObject, IntPtr SubmixEffectPreset);

		// Token: 0x060030AB RID: 12459 RVA: 0x0004B588 File Offset: 0x00049788
		static UAudioMixerBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.AudioMixerBlueprintLibrary");
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0004B596 File Offset: 0x00049796
		protected UAudioMixerBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400151E RID: 5406
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.AudioMixerBlueprintLibrary";

		// Token: 0x0400151F RID: 5407
		private static IntPtr _ClassPtr;

		// Token: 0x04001520 RID: 5408
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
