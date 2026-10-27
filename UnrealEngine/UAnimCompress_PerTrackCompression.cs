using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FA RID: 2042
	[UnrealObjectPath("/Script/Engine.AnimCompress_PerTrackCompression")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UAnimCompress_PerTrackCompression : UAnimCompress_RemoveLinearKeys, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CD6 RID: 27862 RVA: 0x0009CAD2 File Offset: 0x0009ACD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_PerTrackCompression._ClassPtr;
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x0009CAE0 File Offset: 0x0009ACE0
		public UAnimCompress_PerTrackCompression() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_PerTrackCompression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0009CB08 File Offset: 0x0009AD08
		[NullableContext(1)]
		public UAnimCompress_PerTrackCompression(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_PerTrackCompression.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x0009CB3B File Offset: 0x0009AD3B
		// (set) Token: 0x06006CDA RID: 27866 RVA: 0x0009CB4B File Offset: 0x0009AD4B
		public unsafe float MaxZeroingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxZeroingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxZeroingThreshold) = value;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x0009CB5C File Offset: 0x0009AD5C
		// (set) Token: 0x06006CDC RID: 27868 RVA: 0x0009CB6C File Offset: 0x0009AD6C
		public unsafe float MaxPosDiffBitwise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxPosDiffBitwise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxPosDiffBitwise) = value;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06006CDD RID: 27869 RVA: 0x0009CB7D File Offset: 0x0009AD7D
		// (set) Token: 0x06006CDE RID: 27870 RVA: 0x0009CB8D File Offset: 0x0009AD8D
		public unsafe float MaxAngleDiffBitwise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxAngleDiffBitwise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxAngleDiffBitwise) = value;
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06006CDF RID: 27871 RVA: 0x0009CB9E File Offset: 0x0009AD9E
		// (set) Token: 0x06006CE0 RID: 27872 RVA: 0x0009CBAE File Offset: 0x0009ADAE
		public unsafe float MaxScaleDiffBitwise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxScaleDiffBitwise);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxScaleDiffBitwise) = value;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x0009CBC0 File Offset: 0x0009ADC0
		// (set) Token: 0x06006CE2 RID: 27874 RVA: 0x0009CBF9 File Offset: 0x0009ADF9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<AnimationCompressionFormat>> AllowedRotationFormats
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<AnimationCompressionFormat>> result;
				if ((result = this._AllowedRotationFormats) == null)
				{
					result = (this._AllowedRotationFormats = new TArray<TEnumAsByte<AnimationCompressionFormat>>(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_AllowedRotationFormats, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.AllowedRotationFormats.CopyAssign(value);
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06006CE3 RID: 27875 RVA: 0x0009CC08 File Offset: 0x0009AE08
		// (set) Token: 0x06006CE4 RID: 27876 RVA: 0x0009CC41 File Offset: 0x0009AE41
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<AnimationCompressionFormat>> AllowedTranslationFormats
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<AnimationCompressionFormat>> result;
				if ((result = this._AllowedTranslationFormats) == null)
				{
					result = (this._AllowedTranslationFormats = new TArray<TEnumAsByte<AnimationCompressionFormat>>(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_AllowedTranslationFormats, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.AllowedTranslationFormats.CopyAssign(value);
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x0009CC50 File Offset: 0x0009AE50
		// (set) Token: 0x06006CE6 RID: 27878 RVA: 0x0009CC89 File Offset: 0x0009AE89
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<AnimationCompressionFormat>> AllowedScaleFormats
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<AnimationCompressionFormat>> result;
				if ((result = this._AllowedScaleFormats) == null)
				{
					result = (this._AllowedScaleFormats = new TArray<TEnumAsByte<AnimationCompressionFormat>>(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_AllowedScaleFormats, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.AllowedScaleFormats.CopyAssign(value);
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06006CE7 RID: 27879 RVA: 0x0009CC97 File Offset: 0x0009AE97
		// (set) Token: 0x06006CE8 RID: 27880 RVA: 0x0009CCB0 File Offset: 0x0009AEB0
		public unsafe bool bResampleAnimation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bResampleAnimation) & UAnimCompress_PerTrackCompression.__PropertyMask_bResampleAnimation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bResampleAnimation) = ((*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bResampleAnimation) & ~UAnimCompress_PerTrackCompression.__PropertyMask_bResampleAnimation) | (value ? UAnimCompress_PerTrackCompression.__PropertyMask_bResampleAnimation : 0));
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x0009CCE0 File Offset: 0x0009AEE0
		// (set) Token: 0x06006CEA RID: 27882 RVA: 0x0009CCF0 File Offset: 0x0009AEF0
		public unsafe float ResampledFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ResampledFramerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ResampledFramerate) = value;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06006CEB RID: 27883 RVA: 0x0009CD01 File Offset: 0x0009AF01
		// (set) Token: 0x06006CEC RID: 27884 RVA: 0x0009CD11 File Offset: 0x0009AF11
		public unsafe int MinKeysForResampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MinKeysForResampling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MinKeysForResampling) = value;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06006CED RID: 27885 RVA: 0x0009CD22 File Offset: 0x0009AF22
		// (set) Token: 0x06006CEE RID: 27886 RVA: 0x0009CD3B File Offset: 0x0009AF3B
		public unsafe bool bUseAdaptiveError
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError) & UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError) = ((*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError) & ~UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError) | (value ? UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError : 0));
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06006CEF RID: 27887 RVA: 0x0009CD6B File Offset: 0x0009AF6B
		// (set) Token: 0x06006CF0 RID: 27888 RVA: 0x0009CD84 File Offset: 0x0009AF84
		public unsafe bool bUseOverrideForEndEffectors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseOverrideForEndEffectors) & UAnimCompress_PerTrackCompression.__PropertyMask_bUseOverrideForEndEffectors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseOverrideForEndEffectors) = ((*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseOverrideForEndEffectors) & ~UAnimCompress_PerTrackCompression.__PropertyMask_bUseOverrideForEndEffectors) | (value ? UAnimCompress_PerTrackCompression.__PropertyMask_bUseOverrideForEndEffectors : 0));
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06006CF1 RID: 27889 RVA: 0x0009CDB4 File Offset: 0x0009AFB4
		// (set) Token: 0x06006CF2 RID: 27890 RVA: 0x0009CDC4 File Offset: 0x0009AFC4
		public unsafe int TrackHeightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_TrackHeightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_TrackHeightBias) = value;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06006CF3 RID: 27891 RVA: 0x0009CDD5 File Offset: 0x0009AFD5
		// (set) Token: 0x06006CF4 RID: 27892 RVA: 0x0009CDE5 File Offset: 0x0009AFE5
		public unsafe float ParentingDivisor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ParentingDivisor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ParentingDivisor) = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06006CF5 RID: 27893 RVA: 0x0009CDF6 File Offset: 0x0009AFF6
		// (set) Token: 0x06006CF6 RID: 27894 RVA: 0x0009CE06 File Offset: 0x0009B006
		public unsafe float ParentingDivisorExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ParentingDivisorExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ParentingDivisorExponent) = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06006CF7 RID: 27895 RVA: 0x0009CE17 File Offset: 0x0009B017
		// (set) Token: 0x06006CF8 RID: 27896 RVA: 0x0009CE30 File Offset: 0x0009B030
		public unsafe bool bUseAdaptiveError2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError2) & UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError2) = ((*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_bUseAdaptiveError2) & ~UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError2) | (value ? UAnimCompress_PerTrackCompression.__PropertyMask_bUseAdaptiveError2 : 0));
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x0009CE60 File Offset: 0x0009B060
		// (set) Token: 0x06006CFA RID: 27898 RVA: 0x0009CE70 File Offset: 0x0009B070
		public unsafe float RotationErrorSourceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_RotationErrorSourceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_RotationErrorSourceRatio) = value;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x0009CE81 File Offset: 0x0009B081
		// (set) Token: 0x06006CFC RID: 27900 RVA: 0x0009CE91 File Offset: 0x0009B091
		public unsafe float TranslationErrorSourceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_TranslationErrorSourceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_TranslationErrorSourceRatio) = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x0009CEA2 File Offset: 0x0009B0A2
		// (set) Token: 0x06006CFE RID: 27902 RVA: 0x0009CEB2 File Offset: 0x0009B0B2
		public unsafe float ScaleErrorSourceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ScaleErrorSourceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_ScaleErrorSourceRatio) = value;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x0009CEC3 File Offset: 0x0009B0C3
		// (set) Token: 0x06006D00 RID: 27904 RVA: 0x0009CED3 File Offset: 0x0009B0D3
		public unsafe float MaxErrorPerTrackRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxErrorPerTrackRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_MaxErrorPerTrackRatio) = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x0009CEE4 File Offset: 0x0009B0E4
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x0009CEF4 File Offset: 0x0009B0F4
		public unsafe float PerturbationProbeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_PerturbationProbeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_PerTrackCompression.__PropertyOffset_PerturbationProbeSize) = value;
			}
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x0009CF05 File Offset: 0x0009B105
		static UAnimCompress_PerTrackCompression()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_PerTrackCompression");
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x0009CF13 File Offset: 0x0009B113
		protected UAnimCompress_PerTrackCompression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003485 RID: 13445
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_PerTrackCompression";

		// Token: 0x04003486 RID: 13446
		private static IntPtr _ClassPtr;

		// Token: 0x04003487 RID: 13447
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003488 RID: 13448
		internal static int __PropertyOffset_MaxZeroingThreshold;

		// Token: 0x04003489 RID: 13449
		internal static int __PropertyOffset_MaxPosDiffBitwise;

		// Token: 0x0400348A RID: 13450
		internal static int __PropertyOffset_MaxAngleDiffBitwise;

		// Token: 0x0400348B RID: 13451
		internal static int __PropertyOffset_MaxScaleDiffBitwise;

		// Token: 0x0400348C RID: 13452
		internal static int __PropertyOffset_AllowedRotationFormats;

		// Token: 0x0400348D RID: 13453
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<AnimationCompressionFormat>> _AllowedRotationFormats;

		// Token: 0x0400348E RID: 13454
		internal static int __PropertyOffset_AllowedTranslationFormats;

		// Token: 0x0400348F RID: 13455
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<AnimationCompressionFormat>> _AllowedTranslationFormats;

		// Token: 0x04003490 RID: 13456
		internal static int __PropertyOffset_AllowedScaleFormats;

		// Token: 0x04003491 RID: 13457
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<AnimationCompressionFormat>> _AllowedScaleFormats;

		// Token: 0x04003492 RID: 13458
		internal static int __PropertyOffset_bResampleAnimation;

		// Token: 0x04003493 RID: 13459
		internal static byte __PropertyMask_bResampleAnimation;

		// Token: 0x04003494 RID: 13460
		internal static int __PropertyOffset_ResampledFramerate;

		// Token: 0x04003495 RID: 13461
		internal static int __PropertyOffset_MinKeysForResampling;

		// Token: 0x04003496 RID: 13462
		internal static int __PropertyOffset_bUseAdaptiveError;

		// Token: 0x04003497 RID: 13463
		internal static byte __PropertyMask_bUseAdaptiveError;

		// Token: 0x04003498 RID: 13464
		internal static int __PropertyOffset_bUseOverrideForEndEffectors;

		// Token: 0x04003499 RID: 13465
		internal static byte __PropertyMask_bUseOverrideForEndEffectors;

		// Token: 0x0400349A RID: 13466
		internal static int __PropertyOffset_TrackHeightBias;

		// Token: 0x0400349B RID: 13467
		internal static int __PropertyOffset_ParentingDivisor;

		// Token: 0x0400349C RID: 13468
		internal static int __PropertyOffset_ParentingDivisorExponent;

		// Token: 0x0400349D RID: 13469
		internal static int __PropertyOffset_bUseAdaptiveError2;

		// Token: 0x0400349E RID: 13470
		internal static byte __PropertyMask_bUseAdaptiveError2;

		// Token: 0x0400349F RID: 13471
		internal static int __PropertyOffset_RotationErrorSourceRatio;

		// Token: 0x040034A0 RID: 13472
		internal static int __PropertyOffset_TranslationErrorSourceRatio;

		// Token: 0x040034A1 RID: 13473
		internal static int __PropertyOffset_ScaleErrorSourceRatio;

		// Token: 0x040034A2 RID: 13474
		internal static int __PropertyOffset_MaxErrorPerTrackRatio;

		// Token: 0x040034A3 RID: 13475
		internal static int __PropertyOffset_PerturbationProbeSize;
	}
}
