using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038C RID: 908
	[UnrealObjectPath("/Script/AudioSynesthesia.ConstantQNRTSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UConstantQNRTSettings : UAudioSynesthesiaNRTSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003208 RID: 12808 RVA: 0x0004D425 File Offset: 0x0004B625
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConstantQNRTSettings._ClassPtr;
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0004D434 File Offset: 0x0004B634
		public UConstantQNRTSettings() : this(BuiltinUtils.AllocNativeUObject(UConstantQNRTSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0004D45C File Offset: 0x0004B65C
		[NullableContext(1)]
		public UConstantQNRTSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConstantQNRTSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x0004D48F File Offset: 0x0004B68F
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x0004D49F File Offset: 0x0004B69F
		public unsafe float StartingFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_StartingFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_StartingFrequency) = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x0004D4C0 File Offset: 0x0004B6C0
		public unsafe int NumBands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NumBands);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NumBands) = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x0004D4D1 File Offset: 0x0004B6D1
		// (set) Token: 0x06003210 RID: 12816 RVA: 0x0004D4E1 File Offset: 0x0004B6E1
		public unsafe float NumBandsPerOctave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NumBandsPerOctave);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NumBandsPerOctave) = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x0004D4F2 File Offset: 0x0004B6F2
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x0004D502 File Offset: 0x0004B702
		public unsafe float AnalysisPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_AnalysisPeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_AnalysisPeriod) = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x0004D513 File Offset: 0x0004B713
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x0004D523 File Offset: 0x0004B723
		public unsafe bool bDownmixToMono
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_bDownmixToMono) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_bDownmixToMono) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0004D534 File Offset: 0x0004B734
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0004D544 File Offset: 0x0004B744
		public unsafe EConstantQFFTSizeEnum FFTSize
		{
			get
			{
				return (EConstantQFFTSizeEnum)(*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_FFTSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_FFTSize) = (byte)value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x0004D555 File Offset: 0x0004B755
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x0004D565 File Offset: 0x0004B765
		public unsafe EFFTWindowType WindowType
		{
			get
			{
				return (EFFTWindowType)(*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_WindowType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_WindowType) = (byte)value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x0004D576 File Offset: 0x0004B776
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x0004D586 File Offset: 0x0004B786
		public unsafe EAudioSpectrumType SpectrumType
		{
			get
			{
				return (EAudioSpectrumType)(*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_SpectrumType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_SpectrumType) = (byte)value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x0004D597 File Offset: 0x0004B797
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x0004D5A7 File Offset: 0x0004B7A7
		public unsafe float BandWidthStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_BandWidthStretch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_BandWidthStretch) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x0004D5B8 File Offset: 0x0004B7B8
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		public unsafe EConstantQNormalizationEnum CQTNormalization
		{
			get
			{
				return (EConstantQNormalizationEnum)(*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_CQTNormalization));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_CQTNormalization) = (byte)value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x0004D5D9 File Offset: 0x0004B7D9
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x0004D5E9 File Offset: 0x0004B7E9
		public unsafe float NoiseFloorDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NoiseFloorDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UConstantQNRTSettings.__PropertyOffset_NoiseFloorDb) = value;
			}
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0004D5FA File Offset: 0x0004B7FA
		static UConstantQNRTSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.ConstantQNRTSettings");
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x0004D608 File Offset: 0x0004B808
		protected UConstantQNRTSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040015DB RID: 5595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.ConstantQNRTSettings";

		// Token: 0x040015DC RID: 5596
		private static IntPtr _ClassPtr;

		// Token: 0x040015DD RID: 5597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040015DE RID: 5598
		internal static int __PropertyOffset_StartingFrequency;

		// Token: 0x040015DF RID: 5599
		internal static int __PropertyOffset_NumBands;

		// Token: 0x040015E0 RID: 5600
		internal static int __PropertyOffset_NumBandsPerOctave;

		// Token: 0x040015E1 RID: 5601
		internal static int __PropertyOffset_AnalysisPeriod;

		// Token: 0x040015E2 RID: 5602
		internal static int __PropertyOffset_bDownmixToMono;

		// Token: 0x040015E3 RID: 5603
		internal static int __PropertyOffset_FFTSize;

		// Token: 0x040015E4 RID: 5604
		internal static int __PropertyOffset_WindowType;

		// Token: 0x040015E5 RID: 5605
		internal static int __PropertyOffset_SpectrumType;

		// Token: 0x040015E6 RID: 5606
		internal static int __PropertyOffset_BandWidthStretch;

		// Token: 0x040015E7 RID: 5607
		internal static int __PropertyOffset_CQTNormalization;

		// Token: 0x040015E8 RID: 5608
		internal static int __PropertyOffset_NoiseFloorDb;
	}
}
