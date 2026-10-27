using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200115A RID: 4442
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundWave")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class USoundWave : USoundBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060103AD RID: 66477 RVA: 0x0017E9A2 File Offset: 0x0017CBA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundWave._ClassPtr;
		}

		// Token: 0x060103AE RID: 66478 RVA: 0x0017E9B0 File Offset: 0x0017CBB0
		public USoundWave() : this(BuiltinUtils.AllocNativeUObject(USoundWave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060103AF RID: 66479 RVA: 0x0017E9D8 File Offset: 0x0017CBD8
		public USoundWave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundWave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x060103B0 RID: 66480 RVA: 0x0017EA0B File Offset: 0x0017CC0B
		// (set) Token: 0x060103B1 RID: 66481 RVA: 0x0017EA1B File Offset: 0x0017CC1B
		public unsafe int CompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_CompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x060103B2 RID: 66482 RVA: 0x0017EA2C File Offset: 0x0017CC2C
		// (set) Token: 0x060103B3 RID: 66483 RVA: 0x0017EA3C File Offset: 0x0017CC3C
		public unsafe int StreamingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_StreamingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_StreamingPriority) = value;
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x060103B4 RID: 66484 RVA: 0x0017EA4D File Offset: 0x0017CC4D
		// (set) Token: 0x060103B5 RID: 66485 RVA: 0x0017EA5D File Offset: 0x0017CC5D
		public unsafe ESoundwaveSampleRateSettings SampleRateQuality
		{
			get
			{
				return (ESoundwaveSampleRateSettings)(*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SampleRateQuality));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SampleRateQuality) = (byte)value;
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x060103B6 RID: 66486 RVA: 0x0017EA6E File Offset: 0x0017CC6E
		// (set) Token: 0x060103B7 RID: 66487 RVA: 0x0017EA82 File Offset: 0x0017CC82
		[Nullable(0)]
		public unsafe TEnumAsByte<ESoundGroup> SoundGroup
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SoundGroup);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SoundGroup) = value;
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x060103B8 RID: 66488 RVA: 0x0017EA97 File Offset: 0x0017CC97
		// (set) Token: 0x060103B9 RID: 66489 RVA: 0x0017EAB0 File Offset: 0x0017CCB0
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bLooping) & USoundWave.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bLooping) & ~USoundWave.__PropertyMask_bLooping) | (value ? USoundWave.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x060103BA RID: 66490 RVA: 0x0017EAE0 File Offset: 0x0017CCE0
		// (set) Token: 0x060103BB RID: 66491 RVA: 0x0017EAF9 File Offset: 0x0017CCF9
		public unsafe bool bStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bStreaming) & USoundWave.__PropertyMask_bStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bStreaming) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bStreaming) & ~USoundWave.__PropertyMask_bStreaming) | (value ? USoundWave.__PropertyMask_bStreaming : 0));
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x060103BC RID: 66492 RVA: 0x0017EB29 File Offset: 0x0017CD29
		// (set) Token: 0x060103BD RID: 66493 RVA: 0x0017EB42 File Offset: 0x0017CD42
		public unsafe bool bSeekableStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSeekableStreaming) & USoundWave.__PropertyMask_bSeekableStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSeekableStreaming) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSeekableStreaming) & ~USoundWave.__PropertyMask_bSeekableStreaming) | (value ? USoundWave.__PropertyMask_bSeekableStreaming : 0));
			}
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x060103BE RID: 66494 RVA: 0x0017EB72 File Offset: 0x0017CD72
		// (set) Token: 0x060103BF RID: 66495 RVA: 0x0017EB82 File Offset: 0x0017CD82
		public unsafe ESoundWaveLoadingBehavior LoadingBehavior
		{
			get
			{
				return (ESoundWaveLoadingBehavior)(*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_LoadingBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_LoadingBehavior) = (byte)value;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x060103C0 RID: 66496 RVA: 0x0017EB93 File Offset: 0x0017CD93
		// (set) Token: 0x060103C1 RID: 66497 RVA: 0x0017EBAC File Offset: 0x0017CDAC
		public unsafe bool bMature
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bMature) & USoundWave.__PropertyMask_bMature) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bMature) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bMature) & ~USoundWave.__PropertyMask_bMature) | (value ? USoundWave.__PropertyMask_bMature : 0));
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x060103C2 RID: 66498 RVA: 0x0017EBDC File Offset: 0x0017CDDC
		// (set) Token: 0x060103C3 RID: 66499 RVA: 0x0017EBF5 File Offset: 0x0017CDF5
		public unsafe bool bManualWordWrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bManualWordWrap) & USoundWave.__PropertyMask_bManualWordWrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bManualWordWrap) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bManualWordWrap) & ~USoundWave.__PropertyMask_bManualWordWrap) | (value ? USoundWave.__PropertyMask_bManualWordWrap : 0));
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x060103C4 RID: 66500 RVA: 0x0017EC25 File Offset: 0x0017CE25
		// (set) Token: 0x060103C5 RID: 66501 RVA: 0x0017EC3E File Offset: 0x0017CE3E
		public unsafe bool bSingleLine
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSingleLine) & USoundWave.__PropertyMask_bSingleLine) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSingleLine) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bSingleLine) & ~USoundWave.__PropertyMask_bSingleLine) | (value ? USoundWave.__PropertyMask_bSingleLine : 0));
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x060103C6 RID: 66502 RVA: 0x0017EC6E File Offset: 0x0017CE6E
		// (set) Token: 0x060103C7 RID: 66503 RVA: 0x0017EC87 File Offset: 0x0017CE87
		public unsafe bool bIsAmbisonics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bIsAmbisonics) & USoundWave.__PropertyMask_bIsAmbisonics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundWave.__PropertyOffset_bIsAmbisonics) = ((*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_bIsAmbisonics) & ~USoundWave.__PropertyMask_bIsAmbisonics) | (value ? USoundWave.__PropertyMask_bIsAmbisonics : 0));
			}
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x060103C8 RID: 66504 RVA: 0x0017ECB8 File Offset: 0x0017CEB8
		// (set) Token: 0x060103C9 RID: 66505 RVA: 0x0017ECF1 File Offset: 0x0017CEF1
		public TArray<float> FrequenciesToAnalyze
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FrequenciesToAnalyze) == null)
				{
					result = (this._FrequenciesToAnalyze = new TArray<float>(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_FrequenciesToAnalyze, this));
				}
				return result;
			}
			set
			{
				this.FrequenciesToAnalyze.CopyAssign(value);
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x060103CA RID: 66506 RVA: 0x0017ED00 File Offset: 0x0017CF00
		// (set) Token: 0x060103CB RID: 66507 RVA: 0x0017ED39 File Offset: 0x0017CF39
		public TArray<FSoundWaveSpectralTimeData> CookedSpectralTimeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundWaveSpectralTimeData> result;
				if ((result = this._CookedSpectralTimeData) == null)
				{
					result = (this._CookedSpectralTimeData = new TArray<FSoundWaveSpectralTimeData>(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_CookedSpectralTimeData, this));
				}
				return result;
			}
			set
			{
				this.CookedSpectralTimeData.CopyAssign(value);
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x060103CC RID: 66508 RVA: 0x0017ED48 File Offset: 0x0017CF48
		// (set) Token: 0x060103CD RID: 66509 RVA: 0x0017ED81 File Offset: 0x0017CF81
		public TArray<FSoundWaveEnvelopeTimeData> CookedEnvelopeTimeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundWaveEnvelopeTimeData> result;
				if ((result = this._CookedEnvelopeTimeData) == null)
				{
					result = (this._CookedEnvelopeTimeData = new TArray<FSoundWaveEnvelopeTimeData>(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_CookedEnvelopeTimeData, this));
				}
				return result;
			}
			set
			{
				this.CookedEnvelopeTimeData.CopyAssign(value);
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x060103CE RID: 66510 RVA: 0x0017ED8F File Offset: 0x0017CF8F
		// (set) Token: 0x060103CF RID: 66511 RVA: 0x0017ED9F File Offset: 0x0017CF9F
		public unsafe int InitialChunkSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_InitialChunkSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_InitialChunkSize) = value;
			}
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x060103D0 RID: 66512 RVA: 0x0017EDB0 File Offset: 0x0017CFB0
		// (set) Token: 0x060103D1 RID: 66513 RVA: 0x0017EDC4 File Offset: 0x0017CFC4
		public unsafe string SpokenText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USoundWave.__PropertyOffset_SpokenText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USoundWave.__PropertyOffset_SpokenText)), value);
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x060103D2 RID: 66514 RVA: 0x0017EDD9 File Offset: 0x0017CFD9
		// (set) Token: 0x060103D3 RID: 66515 RVA: 0x0017EDE9 File Offset: 0x0017CFE9
		public unsafe float SubtitlePriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SubtitlePriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SubtitlePriority) = value;
			}
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x060103D4 RID: 66516 RVA: 0x0017EDFA File Offset: 0x0017CFFA
		// (set) Token: 0x060103D5 RID: 66517 RVA: 0x0017EE0A File Offset: 0x0017D00A
		public unsafe float Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_Volume) = value;
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x060103D6 RID: 66518 RVA: 0x0017EE1B File Offset: 0x0017D01B
		// (set) Token: 0x060103D7 RID: 66519 RVA: 0x0017EE2B File Offset: 0x0017D02B
		public unsafe float Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_Pitch) = value;
			}
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x060103D8 RID: 66520 RVA: 0x0017EE3C File Offset: 0x0017D03C
		// (set) Token: 0x060103D9 RID: 66521 RVA: 0x0017EE4C File Offset: 0x0017D04C
		public unsafe int NumChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_NumChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_NumChannels) = value;
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x060103DA RID: 66522 RVA: 0x0017EE5D File Offset: 0x0017D05D
		// (set) Token: 0x060103DB RID: 66523 RVA: 0x0017EE6D File Offset: 0x0017D06D
		public unsafe int SampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_SampleRate) = value;
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x060103DC RID: 66524 RVA: 0x0017EE80 File Offset: 0x0017D080
		// (set) Token: 0x060103DD RID: 66525 RVA: 0x0017EEB9 File Offset: 0x0017D0B9
		public TArray<FSubtitleCue> Subtitles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSubtitleCue> result;
				if ((result = this._Subtitles) == null)
				{
					result = (this._Subtitles = new TArray<FSubtitleCue>(base.NativePtr + (IntPtr)USoundWave.__PropertyOffset_Subtitles, this));
				}
				return result;
			}
			set
			{
				this.Subtitles.CopyAssign(value);
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x060103DE RID: 66526 RVA: 0x0017EEC7 File Offset: 0x0017D0C7
		// (set) Token: 0x060103DF RID: 66527 RVA: 0x0017EEDB File Offset: 0x0017D0DB
		[Nullable(2)]
		public unsafe UCurveTable Curves
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveTable>(base.NativePtr / (IntPtr)sizeof(void*) + USoundWave.__PropertyOffset_Curves);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundWave.__PropertyOffset_Curves, value);
			}
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x060103E0 RID: 66528 RVA: 0x0017EEF0 File Offset: 0x0017D0F0
		// (set) Token: 0x060103E1 RID: 66529 RVA: 0x0017EF04 File Offset: 0x0017D104
		[Nullable(2)]
		public unsafe UCurveTable InternalCurves
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveTable>(base.NativePtr / (IntPtr)sizeof(void*) + USoundWave.__PropertyOffset_InternalCurves);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundWave.__PropertyOffset_InternalCurves, value);
			}
		}

		// Token: 0x060103E2 RID: 66530 RVA: 0x0017EF19 File Offset: 0x0017D119
		static USoundWave()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundWave");
		}

		// Token: 0x060103E3 RID: 66531 RVA: 0x0017EF27 File Offset: 0x0017D127
		protected USoundWave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008BB2 RID: 35762
		public new const string __ObjectPath = "/Script/Engine.SoundWave";

		// Token: 0x04008BB3 RID: 35763
		private static IntPtr _ClassPtr;

		// Token: 0x04008BB4 RID: 35764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008BB5 RID: 35765
		internal static int __PropertyOffset_CompressionQuality;

		// Token: 0x04008BB6 RID: 35766
		internal static int __PropertyOffset_StreamingPriority;

		// Token: 0x04008BB7 RID: 35767
		internal static int __PropertyOffset_SampleRateQuality;

		// Token: 0x04008BB8 RID: 35768
		internal static int __PropertyOffset_SoundGroup;

		// Token: 0x04008BB9 RID: 35769
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04008BBA RID: 35770
		internal static byte __PropertyMask_bLooping;

		// Token: 0x04008BBB RID: 35771
		internal static int __PropertyOffset_bStreaming;

		// Token: 0x04008BBC RID: 35772
		internal static byte __PropertyMask_bStreaming;

		// Token: 0x04008BBD RID: 35773
		internal static int __PropertyOffset_bSeekableStreaming;

		// Token: 0x04008BBE RID: 35774
		internal static byte __PropertyMask_bSeekableStreaming;

		// Token: 0x04008BBF RID: 35775
		internal static int __PropertyOffset_LoadingBehavior;

		// Token: 0x04008BC0 RID: 35776
		internal static int __PropertyOffset_bMature;

		// Token: 0x04008BC1 RID: 35777
		internal static byte __PropertyMask_bMature;

		// Token: 0x04008BC2 RID: 35778
		internal static int __PropertyOffset_bManualWordWrap;

		// Token: 0x04008BC3 RID: 35779
		internal static byte __PropertyMask_bManualWordWrap;

		// Token: 0x04008BC4 RID: 35780
		internal static int __PropertyOffset_bSingleLine;

		// Token: 0x04008BC5 RID: 35781
		internal static byte __PropertyMask_bSingleLine;

		// Token: 0x04008BC6 RID: 35782
		internal static int __PropertyOffset_bIsAmbisonics;

		// Token: 0x04008BC7 RID: 35783
		internal static byte __PropertyMask_bIsAmbisonics;

		// Token: 0x04008BC8 RID: 35784
		internal static int __PropertyOffset_FrequenciesToAnalyze;

		// Token: 0x04008BC9 RID: 35785
		[Nullable(2)]
		private TArray<float> _FrequenciesToAnalyze;

		// Token: 0x04008BCA RID: 35786
		internal static int __PropertyOffset_CookedSpectralTimeData;

		// Token: 0x04008BCB RID: 35787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundWaveSpectralTimeData> _CookedSpectralTimeData;

		// Token: 0x04008BCC RID: 35788
		internal static int __PropertyOffset_CookedEnvelopeTimeData;

		// Token: 0x04008BCD RID: 35789
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundWaveEnvelopeTimeData> _CookedEnvelopeTimeData;

		// Token: 0x04008BCE RID: 35790
		internal static int __PropertyOffset_InitialChunkSize;

		// Token: 0x04008BCF RID: 35791
		internal static int __PropertyOffset_SpokenText;

		// Token: 0x04008BD0 RID: 35792
		internal static int __PropertyOffset_SubtitlePriority;

		// Token: 0x04008BD1 RID: 35793
		internal static int __PropertyOffset_Volume;

		// Token: 0x04008BD2 RID: 35794
		internal static int __PropertyOffset_Pitch;

		// Token: 0x04008BD3 RID: 35795
		internal static int __PropertyOffset_NumChannels;

		// Token: 0x04008BD4 RID: 35796
		internal static int __PropertyOffset_SampleRate;

		// Token: 0x04008BD5 RID: 35797
		internal static int __PropertyOffset_Subtitles;

		// Token: 0x04008BD6 RID: 35798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSubtitleCue> _Subtitles;

		// Token: 0x04008BD7 RID: 35799
		internal static int __PropertyOffset_Curves;

		// Token: 0x04008BD8 RID: 35800
		internal static int __PropertyOffset_InternalCurves;
	}
}
