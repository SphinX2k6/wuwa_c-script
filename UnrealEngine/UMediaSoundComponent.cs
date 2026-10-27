using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002299 RID: 8857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaSoundComponent")]
	[UnrealStructLayout(2384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2384)]
	public class UMediaSoundComponent : USynthComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B0F RID: 137999 RVA: 0x0031D1DA File Offset: 0x0031B3DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaSoundComponent._ClassPtr;
		}

		// Token: 0x06021B10 RID: 138000 RVA: 0x0031D1E8 File Offset: 0x0031B3E8
		public UMediaSoundComponent() : this(BuiltinUtils.AllocNativeUObject(UMediaSoundComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B11 RID: 138001 RVA: 0x0031D210 File Offset: 0x0031B410
		[NullableContext(1)]
		public UMediaSoundComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaSoundComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082C0 RID: 33472
		// (get) Token: 0x06021B12 RID: 138002 RVA: 0x0031D243 File Offset: 0x0031B443
		// (set) Token: 0x06021B13 RID: 138003 RVA: 0x0031D253 File Offset: 0x0031B453
		public unsafe EMediaSoundChannels Channels
		{
			get
			{
				return (EMediaSoundChannels)(*(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_Channels));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_Channels) = (int)value;
			}
		}

		// Token: 0x170082C1 RID: 33473
		// (get) Token: 0x06021B14 RID: 138004 RVA: 0x0031D264 File Offset: 0x0031B464
		// (set) Token: 0x06021B15 RID: 138005 RVA: 0x0031D274 File Offset: 0x0031B474
		public unsafe bool DynamicRateAdjustment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_DynamicRateAdjustment) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_DynamicRateAdjustment) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082C2 RID: 33474
		// (get) Token: 0x06021B16 RID: 138006 RVA: 0x0031D285 File Offset: 0x0031B485
		// (set) Token: 0x06021B17 RID: 138007 RVA: 0x0031D295 File Offset: 0x0031B495
		public unsafe float RateAdjustmentFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_RateAdjustmentFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_RateAdjustmentFactor) = value;
			}
		}

		// Token: 0x170082C3 RID: 33475
		// (get) Token: 0x06021B18 RID: 138008 RVA: 0x0031D2A6 File Offset: 0x0031B4A6
		// (set) Token: 0x06021B19 RID: 138009 RVA: 0x0031D2BA File Offset: 0x0031B4BA
		public unsafe FFloatRange RateAdjustmentRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_RateAdjustmentRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaSoundComponent.__PropertyOffset_RateAdjustmentRange) = value;
			}
		}

		// Token: 0x170082C4 RID: 33476
		// (get) Token: 0x06021B1A RID: 138010 RVA: 0x0031D2CF File Offset: 0x0031B4CF
		// (set) Token: 0x06021B1B RID: 138011 RVA: 0x0031D2E3 File Offset: 0x0031B4E3
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaSoundComponent.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaSoundComponent.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x06021B1C RID: 138012 RVA: 0x0031D2F8 File Offset: 0x0031B4F8
		public void SetSpectralAnalysisSettings(TArray<float> InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize = EMediaSoundComponentFFTSize.Medium_512)
		{
			UMediaSoundComponent.__SetSpectralAnalysisSettings_Internal(base.NativePtr, (InFrequenciesToAnalyze ?? new TArray<float>()).NativePtr, InFFTSize);
		}

		// Token: 0x06021B1D RID: 138013 RVA: 0x0031D315 File Offset: 0x0031B515
		public void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
		{
			UMediaSoundComponent.__SetMediaPlayer_Internal(base.NativePtr, (NewMediaPlayer != null) ? NewMediaPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021B1E RID: 138014 RVA: 0x0031D332 File Offset: 0x0031B532
		public void SetEnvelopeFollowingsettings(int AttackTimeMsec, int ReleaseTimeMsec)
		{
			UMediaSoundComponent.__SetEnvelopeFollowingsettings_Internal(base.NativePtr, AttackTimeMsec, ReleaseTimeMsec);
		}

		// Token: 0x06021B1F RID: 138015 RVA: 0x0031D341 File Offset: 0x0031B541
		public void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled)
		{
			UMediaSoundComponent.__SetEnableSpectralAnalysis_Internal(base.NativePtr, bInSpectralAnalysisEnabled);
		}

		// Token: 0x06021B20 RID: 138016 RVA: 0x0031D34F File Offset: 0x0031B54F
		public void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing)
		{
			UMediaSoundComponent.__SetEnableEnvelopeFollowing_Internal(base.NativePtr, bInEnvelopeFollowing);
		}

		// Token: 0x06021B21 RID: 138017 RVA: 0x0031D35D File Offset: 0x0031B55D
		[NullableContext(1)]
		public TArray<FMediaSoundComponentSpectralData> GetSpectralData()
		{
			return new TArray<FMediaSoundComponentSpectralData>(UMediaSoundComponent.__GetSpectralData_Internal(base.NativePtr), null);
		}

		// Token: 0x06021B22 RID: 138018 RVA: 0x0031D370 File Offset: 0x0031B570
		[NullableContext(1)]
		public TArray<FMediaSoundComponentSpectralData> GetNormalizedSpectralData()
		{
			return new TArray<FMediaSoundComponentSpectralData>(UMediaSoundComponent.__GetNormalizedSpectralData_Internal(base.NativePtr), null);
		}

		// Token: 0x06021B23 RID: 138019 RVA: 0x0031D383 File Offset: 0x0031B583
		public UMediaPlayer GetMediaPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(UMediaSoundComponent.__GetMediaPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06021B24 RID: 138020 RVA: 0x0031D395 File Offset: 0x0031B595
		public float GetEnvelopeValue()
		{
			return UMediaSoundComponent.__GetEnvelopeValue_Internal(base.NativePtr);
		}

		// Token: 0x06021B25 RID: 138021 RVA: 0x0031D3A2 File Offset: 0x0031B5A2
		public bool BP_GetAttenuationSettingsToApply(ref FSoundAttenuationSettings OutAttenuationSettings)
		{
			return UMediaSoundComponent.__BP_GetAttenuationSettingsToApply_Internal(base.NativePtr, (OutAttenuationSettings ?? new FSoundAttenuationSettings()).NativePtr);
		}

		// Token: 0x06021B26 RID: 138022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpectralAnalysisSettings_Internal(IntPtr @this, IntPtr InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize);

		// Token: 0x06021B27 RID: 138023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaPlayer_Internal(IntPtr @this, IntPtr NewMediaPlayer);

		// Token: 0x06021B28 RID: 138024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnvelopeFollowingsettings_Internal(IntPtr @this, int AttackTimeMsec, int ReleaseTimeMsec);

		// Token: 0x06021B29 RID: 138025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableSpectralAnalysis_Internal(IntPtr @this, bool bInSpectralAnalysisEnabled);

		// Token: 0x06021B2A RID: 138026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableEnvelopeFollowing_Internal(IntPtr @this, bool bInEnvelopeFollowing);

		// Token: 0x06021B2B RID: 138027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpectralData_Internal(IntPtr @this);

		// Token: 0x06021B2C RID: 138028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNormalizedSpectralData_Internal(IntPtr @this);

		// Token: 0x06021B2D RID: 138029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaPlayer_Internal(IntPtr @this);

		// Token: 0x06021B2E RID: 138030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEnvelopeValue_Internal(IntPtr @this);

		// Token: 0x06021B2F RID: 138031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_GetAttenuationSettingsToApply_Internal(IntPtr @this, IntPtr OutAttenuationSettings);

		// Token: 0x06021B30 RID: 138032 RVA: 0x0031D3BF File Offset: 0x0031B5BF
		static UMediaSoundComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaSoundComponent");
		}

		// Token: 0x06021B31 RID: 138033 RVA: 0x0031D3CD File Offset: 0x0031B5CD
		protected UMediaSoundComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FA1 RID: 73633
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaSoundComponent";

		// Token: 0x04011FA2 RID: 73634
		private static IntPtr _ClassPtr;

		// Token: 0x04011FA3 RID: 73635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FA4 RID: 73636
		internal static int __PropertyOffset_Channels;

		// Token: 0x04011FA5 RID: 73637
		internal static int __PropertyOffset_DynamicRateAdjustment;

		// Token: 0x04011FA6 RID: 73638
		internal static int __PropertyOffset_RateAdjustmentFactor;

		// Token: 0x04011FA7 RID: 73639
		internal static int __PropertyOffset_RateAdjustmentRange;

		// Token: 0x04011FA8 RID: 73640
		internal static int __PropertyOffset_MediaPlayer;
	}
}
