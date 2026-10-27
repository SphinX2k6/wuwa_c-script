using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7E RID: 3710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialOutput")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UMaterialExpressionVolumetricAdvancedMaterialOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C609 RID: 50697 RVA: 0x0011EDC2 File Offset: 0x0011CFC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVolumetricAdvancedMaterialOutput._ClassPtr;
		}

		// Token: 0x0600C60A RID: 50698 RVA: 0x0011EDD0 File Offset: 0x0011CFD0
		public UMaterialExpressionVolumetricAdvancedMaterialOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVolumetricAdvancedMaterialOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x0011EDF8 File Offset: 0x0011CFF8
		public UMaterialExpressionVolumetricAdvancedMaterialOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVolumetricAdvancedMaterialOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600C60C RID: 50700 RVA: 0x0011EE2C File Offset: 0x0011D02C
		// (set) Token: 0x0600C60D RID: 50701 RVA: 0x0011EE65 File Offset: 0x0011D065
		public FExpressionInput PhaseG
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PhaseG) == null)
				{
					result = (this._PhaseG = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseG, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseG, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x0011EE88 File Offset: 0x0011D088
		// (set) Token: 0x0600C60F RID: 50703 RVA: 0x0011EEC1 File Offset: 0x0011D0C1
		public FExpressionInput PhaseG2
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PhaseG2) == null)
				{
					result = (this._PhaseG2 = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseG2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseG2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600C610 RID: 50704 RVA: 0x0011EEE4 File Offset: 0x0011D0E4
		// (set) Token: 0x0600C611 RID: 50705 RVA: 0x0011EF1D File Offset: 0x0011D11D
		public FExpressionInput PhaseBlend
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PhaseBlend) == null)
				{
					result = (this._PhaseBlend = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseBlend, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PhaseBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600C612 RID: 50706 RVA: 0x0011EF40 File Offset: 0x0011D140
		// (set) Token: 0x0600C613 RID: 50707 RVA: 0x0011EF79 File Offset: 0x0011D179
		public FExpressionInput MultiScatteringContribution
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MultiScatteringContribution) == null)
				{
					result = (this._MultiScatteringContribution = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringContribution, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringContribution, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600C614 RID: 50708 RVA: 0x0011EF9C File Offset: 0x0011D19C
		// (set) Token: 0x0600C615 RID: 50709 RVA: 0x0011EFD5 File Offset: 0x0011D1D5
		public FExpressionInput MultiScatteringOcclusion
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MultiScatteringOcclusion) == null)
				{
					result = (this._MultiScatteringOcclusion = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringOcclusion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringOcclusion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600C616 RID: 50710 RVA: 0x0011EFF8 File Offset: 0x0011D1F8
		// (set) Token: 0x0600C617 RID: 50711 RVA: 0x0011F031 File Offset: 0x0011D231
		public FExpressionInput MultiScatteringEccentricity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MultiScatteringEccentricity) == null)
				{
					result = (this._MultiScatteringEccentricity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringEccentricity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringEccentricity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600C618 RID: 50712 RVA: 0x0011F054 File Offset: 0x0011D254
		// (set) Token: 0x0600C619 RID: 50713 RVA: 0x0011F08D File Offset: 0x0011D28D
		public FExpressionInput ConservativeDensity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ConservativeDensity) == null)
				{
					result = (this._ConservativeDensity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConservativeDensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConservativeDensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600C61A RID: 50714 RVA: 0x0011F0AE File Offset: 0x0011D2AE
		// (set) Token: 0x0600C61B RID: 50715 RVA: 0x0011F0BE File Offset: 0x0011D2BE
		public unsafe float ConstPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseG) = value;
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600C61C RID: 50716 RVA: 0x0011F0CF File Offset: 0x0011D2CF
		// (set) Token: 0x0600C61D RID: 50717 RVA: 0x0011F0DF File Offset: 0x0011D2DF
		public unsafe float ConstPhaseG2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseG2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseG2) = value;
			}
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600C61E RID: 50718 RVA: 0x0011F0F0 File Offset: 0x0011D2F0
		// (set) Token: 0x0600C61F RID: 50719 RVA: 0x0011F100 File Offset: 0x0011D300
		public unsafe float ConstPhaseBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstPhaseBlend) = value;
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600C620 RID: 50720 RVA: 0x0011F111 File Offset: 0x0011D311
		// (set) Token: 0x0600C621 RID: 50721 RVA: 0x0011F121 File Offset: 0x0011D321
		public unsafe bool PerSamplePhaseEvaluation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PerSamplePhaseEvaluation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_PerSamplePhaseEvaluation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600C622 RID: 50722 RVA: 0x0011F132 File Offset: 0x0011D332
		// (set) Token: 0x0600C623 RID: 50723 RVA: 0x0011F142 File Offset: 0x0011D342
		public unsafe uint MultiScatteringApproximationOctaveCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringApproximationOctaveCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_MultiScatteringApproximationOctaveCount) = (int)value;
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600C624 RID: 50724 RVA: 0x0011F153 File Offset: 0x0011D353
		// (set) Token: 0x0600C625 RID: 50725 RVA: 0x0011F163 File Offset: 0x0011D363
		public unsafe float ConstMultiScatteringContribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringContribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringContribution) = value;
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600C626 RID: 50726 RVA: 0x0011F174 File Offset: 0x0011D374
		// (set) Token: 0x0600C627 RID: 50727 RVA: 0x0011F184 File Offset: 0x0011D384
		public unsafe float ConstMultiScatteringOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringOcclusion) = value;
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600C628 RID: 50728 RVA: 0x0011F195 File Offset: 0x0011D395
		// (set) Token: 0x0600C629 RID: 50729 RVA: 0x0011F1A5 File Offset: 0x0011D3A5
		public unsafe float ConstMultiScatteringEccentricity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringEccentricity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_ConstMultiScatteringEccentricity) = value;
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x0011F1B6 File Offset: 0x0011D3B6
		// (set) Token: 0x0600C62B RID: 50731 RVA: 0x0011F1C6 File Offset: 0x0011D3C6
		public unsafe bool bGroundContribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bGroundContribution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bGroundContribution) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600C62C RID: 50732 RVA: 0x0011F1D7 File Offset: 0x0011D3D7
		// (set) Token: 0x0600C62D RID: 50733 RVA: 0x0011F1E7 File Offset: 0x0011D3E7
		public unsafe bool bGrayScaleMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bGrayScaleMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bGrayScaleMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600C62E RID: 50734 RVA: 0x0011F1F8 File Offset: 0x0011D3F8
		// (set) Token: 0x0600C62F RID: 50735 RVA: 0x0011F208 File Offset: 0x0011D408
		public unsafe bool bRayMarchVolumeShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bRayMarchVolumeShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVolumetricAdvancedMaterialOutput.__PropertyOffset_bRayMarchVolumeShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x0011F219 File Offset: 0x0011D419
		static UMaterialExpressionVolumetricAdvancedMaterialOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialOutput");
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x0011F227 File Offset: 0x0011D427
		protected UMaterialExpressionVolumetricAdvancedMaterialOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069FB RID: 27131
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialOutput";

		// Token: 0x040069FC RID: 27132
		private static IntPtr _ClassPtr;

		// Token: 0x040069FD RID: 27133
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069FE RID: 27134
		internal static int __PropertyOffset_PhaseG;

		// Token: 0x040069FF RID: 27135
		[Nullable(2)]
		private FExpressionInput _PhaseG;

		// Token: 0x04006A00 RID: 27136
		internal static int __PropertyOffset_PhaseG2;

		// Token: 0x04006A01 RID: 27137
		[Nullable(2)]
		private FExpressionInput _PhaseG2;

		// Token: 0x04006A02 RID: 27138
		internal static int __PropertyOffset_PhaseBlend;

		// Token: 0x04006A03 RID: 27139
		[Nullable(2)]
		private FExpressionInput _PhaseBlend;

		// Token: 0x04006A04 RID: 27140
		internal static int __PropertyOffset_MultiScatteringContribution;

		// Token: 0x04006A05 RID: 27141
		[Nullable(2)]
		private FExpressionInput _MultiScatteringContribution;

		// Token: 0x04006A06 RID: 27142
		internal static int __PropertyOffset_MultiScatteringOcclusion;

		// Token: 0x04006A07 RID: 27143
		[Nullable(2)]
		private FExpressionInput _MultiScatteringOcclusion;

		// Token: 0x04006A08 RID: 27144
		internal static int __PropertyOffset_MultiScatteringEccentricity;

		// Token: 0x04006A09 RID: 27145
		[Nullable(2)]
		private FExpressionInput _MultiScatteringEccentricity;

		// Token: 0x04006A0A RID: 27146
		internal static int __PropertyOffset_ConservativeDensity;

		// Token: 0x04006A0B RID: 27147
		[Nullable(2)]
		private FExpressionInput _ConservativeDensity;

		// Token: 0x04006A0C RID: 27148
		internal static int __PropertyOffset_ConstPhaseG;

		// Token: 0x04006A0D RID: 27149
		internal static int __PropertyOffset_ConstPhaseG2;

		// Token: 0x04006A0E RID: 27150
		internal static int __PropertyOffset_ConstPhaseBlend;

		// Token: 0x04006A0F RID: 27151
		internal static int __PropertyOffset_PerSamplePhaseEvaluation;

		// Token: 0x04006A10 RID: 27152
		internal static int __PropertyOffset_MultiScatteringApproximationOctaveCount;

		// Token: 0x04006A11 RID: 27153
		internal static int __PropertyOffset_ConstMultiScatteringContribution;

		// Token: 0x04006A12 RID: 27154
		internal static int __PropertyOffset_ConstMultiScatteringOcclusion;

		// Token: 0x04006A13 RID: 27155
		internal static int __PropertyOffset_ConstMultiScatteringEccentricity;

		// Token: 0x04006A14 RID: 27156
		internal static int __PropertyOffset_bGroundContribution;

		// Token: 0x04006A15 RID: 27157
		internal static int __PropertyOffset_bGrayScaleMaterial;

		// Token: 0x04006A16 RID: 27158
		internal static int __PropertyOffset_bRayMarchVolumeShadow;
	}
}
