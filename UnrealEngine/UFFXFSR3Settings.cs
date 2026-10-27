using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012A9 RID: 4777
	[UnrealObjectPath("/Script/FFXFSR3Settings.FFXFSR3Settings")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UFFXFSR3Settings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060117CC RID: 71628 RVA: 0x0019ABBE File Offset: 0x00198DBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFFXFSR3Settings._ClassPtr;
		}

		// Token: 0x060117CD RID: 71629 RVA: 0x0019ABCC File Offset: 0x00198DCC
		public UFFXFSR3Settings() : this(BuiltinUtils.AllocNativeUObject(UFFXFSR3Settings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060117CE RID: 71630 RVA: 0x0019ABF4 File Offset: 0x00198DF4
		[NullableContext(1)]
		public UFFXFSR3Settings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFFXFSR3Settings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x060117CF RID: 71631 RVA: 0x0019AC27 File Offset: 0x00198E27
		// (set) Token: 0x060117D0 RID: 71632 RVA: 0x0019AC37 File Offset: 0x00198E37
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x060117D1 RID: 71633 RVA: 0x0019AC48 File Offset: 0x00198E48
		// (set) Token: 0x060117D2 RID: 71634 RVA: 0x0019AC58 File Offset: 0x00198E58
		public unsafe bool bAutoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bAutoExposure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bAutoExposure) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x060117D3 RID: 71635 RVA: 0x0019AC69 File Offset: 0x00198E69
		// (set) Token: 0x060117D4 RID: 71636 RVA: 0x0019AC79 File Offset: 0x00198E79
		public unsafe bool bEnabledInEditorViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bEnabledInEditorViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bEnabledInEditorViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x060117D5 RID: 71637 RVA: 0x0019AC8A File Offset: 0x00198E8A
		// (set) Token: 0x060117D6 RID: 71638 RVA: 0x0019AC9A File Offset: 0x00198E9A
		public unsafe bool bUseSSRExperimentalDenoiser
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUseSSRExperimentalDenoiser) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUseSSRExperimentalDenoiser) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x060117D7 RID: 71639 RVA: 0x0019ACAB File Offset: 0x00198EAB
		// (set) Token: 0x060117D8 RID: 71640 RVA: 0x0019ACBB File Offset: 0x00198EBB
		public unsafe bool bRHIBackend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bRHIBackend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bRHIBackend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x060117D9 RID: 71641 RVA: 0x0019ACCC File Offset: 0x00198ECC
		// (set) Token: 0x060117DA RID: 71642 RVA: 0x0019ACDC File Offset: 0x00198EDC
		public unsafe bool bD3D12Backend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12Backend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12Backend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x060117DB RID: 71643 RVA: 0x0019ACED File Offset: 0x00198EED
		// (set) Token: 0x060117DC RID: 71644 RVA: 0x0019ACFD File Offset: 0x00198EFD
		public unsafe bool bFrameGenEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bFrameGenEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bFrameGenEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x060117DD RID: 71645 RVA: 0x0019AD0E File Offset: 0x00198F0E
		// (set) Token: 0x060117DE RID: 71646 RVA: 0x0019AD1E File Offset: 0x00198F1E
		public unsafe bool bCaptureDebugUI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bCaptureDebugUI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bCaptureDebugUI) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x060117DF RID: 71647 RVA: 0x0019AD2F File Offset: 0x00198F2F
		// (set) Token: 0x060117E0 RID: 71648 RVA: 0x0019AD3F File Offset: 0x00198F3F
		public unsafe bool bUpdateGlobalFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUpdateGlobalFrameTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUpdateGlobalFrameTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x060117E1 RID: 71649 RVA: 0x0019AD50 File Offset: 0x00198F50
		// (set) Token: 0x060117E2 RID: 71650 RVA: 0x0019AD60 File Offset: 0x00198F60
		public unsafe bool bModifySlateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bModifySlateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bModifySlateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x060117E3 RID: 71651 RVA: 0x0019AD71 File Offset: 0x00198F71
		// (set) Token: 0x060117E4 RID: 71652 RVA: 0x0019AD81 File Offset: 0x00198F81
		public unsafe EFFXFSR3FrameGenUIMode UIMode
		{
			get
			{
				return (EFFXFSR3FrameGenUIMode)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_UIMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_UIMode) = (int)value;
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x060117E5 RID: 71653 RVA: 0x0019AD92 File Offset: 0x00198F92
		// (set) Token: 0x060117E6 RID: 71654 RVA: 0x0019ADA2 File Offset: 0x00198FA2
		public unsafe bool bUseDistortionTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUseDistortionTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bUseDistortionTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x060117E7 RID: 71655 RVA: 0x0019ADB3 File Offset: 0x00198FB3
		// (set) Token: 0x060117E8 RID: 71656 RVA: 0x0019ADC3 File Offset: 0x00198FC3
		public unsafe bool bD3D12AsyncInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12AsyncInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12AsyncInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x060117E9 RID: 71657 RVA: 0x0019ADD4 File Offset: 0x00198FD4
		// (set) Token: 0x060117EA RID: 71658 RVA: 0x0019ADE4 File Offset: 0x00198FE4
		public unsafe bool bD3D12AsyncPresent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12AsyncPresent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bD3D12AsyncPresent) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x060117EB RID: 71659 RVA: 0x0019ADF5 File Offset: 0x00198FF5
		// (set) Token: 0x060117EC RID: 71660 RVA: 0x0019AE05 File Offset: 0x00199005
		public unsafe EFFXFSR3PaceRHIFrameMode PaceMode
		{
			get
			{
				return (EFFXFSR3PaceRHIFrameMode)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_PaceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_PaceMode) = (int)value;
			}
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x060117ED RID: 71661 RVA: 0x0019AE16 File Offset: 0x00199016
		// (set) Token: 0x060117EE RID: 71662 RVA: 0x0019AE26 File Offset: 0x00199026
		public unsafe EFFXFSR3QualityMode QualityMode
		{
			get
			{
				return (EFFXFSR3QualityMode)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_QualityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_QualityMode) = (int)value;
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x060117EF RID: 71663 RVA: 0x0019AE37 File Offset: 0x00199037
		// (set) Token: 0x060117F0 RID: 71664 RVA: 0x0019AE47 File Offset: 0x00199047
		public unsafe EFFXFSR3HistoryFormat HistoryFormat
		{
			get
			{
				return (EFFXFSR3HistoryFormat)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_HistoryFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_HistoryFormat) = (int)value;
			}
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x060117F1 RID: 71665 RVA: 0x0019AE58 File Offset: 0x00199058
		// (set) Token: 0x060117F2 RID: 71666 RVA: 0x0019AE68 File Offset: 0x00199068
		public unsafe EFFXFSR3DeDitherMode DeDither
		{
			get
			{
				return (EFFXFSR3DeDitherMode)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_DeDither));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_DeDither) = (int)value;
			}
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x060117F3 RID: 71667 RVA: 0x0019AE79 File Offset: 0x00199079
		// (set) Token: 0x060117F4 RID: 71668 RVA: 0x0019AE89 File Offset: 0x00199089
		public unsafe float Sharpness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_Sharpness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_Sharpness) = value;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x060117F5 RID: 71669 RVA: 0x0019AE9A File Offset: 0x0019909A
		// (set) Token: 0x060117F6 RID: 71670 RVA: 0x0019AEAA File Offset: 0x001990AA
		public unsafe bool bAdjustMipBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bAdjustMipBias) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bAdjustMipBias) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x060117F7 RID: 71671 RVA: 0x0019AEBB File Offset: 0x001990BB
		// (set) Token: 0x060117F8 RID: 71672 RVA: 0x0019AECB File Offset: 0x001990CB
		public unsafe bool bForceVertexDeformationOutputsVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bForceVertexDeformationOutputsVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bForceVertexDeformationOutputsVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x060117F9 RID: 71673 RVA: 0x0019AEDC File Offset: 0x001990DC
		// (set) Token: 0x060117FA RID: 71674 RVA: 0x0019AEEC File Offset: 0x001990EC
		public unsafe EFFXFSR3LandscapeHISMMode ForceLandscapeHISMMobility
		{
			get
			{
				return (EFFXFSR3LandscapeHISMMode)(*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ForceLandscapeHISMMobility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ForceLandscapeHISMMobility) = (int)value;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x060117FB RID: 71675 RVA: 0x0019AEFD File Offset: 0x001990FD
		// (set) Token: 0x060117FC RID: 71676 RVA: 0x0019AF0D File Offset: 0x0019910D
		public unsafe float VelocityFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_VelocityFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_VelocityFactor) = value;
			}
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x060117FD RID: 71677 RVA: 0x0019AF1E File Offset: 0x0019911E
		// (set) Token: 0x060117FE RID: 71678 RVA: 0x0019AF2E File Offset: 0x0019912E
		public unsafe bool bReactiveMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bReactiveMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bReactiveMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x060117FF RID: 71679 RVA: 0x0019AF3F File Offset: 0x0019913F
		// (set) Token: 0x06011800 RID: 71680 RVA: 0x0019AF4F File Offset: 0x0019914F
		public unsafe float ReflectionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReflectionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReflectionScale) = value;
			}
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x06011801 RID: 71681 RVA: 0x0019AF60 File Offset: 0x00199160
		// (set) Token: 0x06011802 RID: 71682 RVA: 0x0019AF70 File Offset: 0x00199170
		public unsafe float ReflectionLuminanceBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReflectionLuminanceBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReflectionLuminanceBias) = value;
			}
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x06011803 RID: 71683 RVA: 0x0019AF81 File Offset: 0x00199181
		// (set) Token: 0x06011804 RID: 71684 RVA: 0x0019AF91 File Offset: 0x00199191
		public unsafe float RoughnessScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessScale) = value;
			}
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x06011805 RID: 71685 RVA: 0x0019AFA2 File Offset: 0x001991A2
		// (set) Token: 0x06011806 RID: 71686 RVA: 0x0019AFB2 File Offset: 0x001991B2
		public unsafe float RoughnessBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessBias) = value;
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x06011807 RID: 71687 RVA: 0x0019AFC3 File Offset: 0x001991C3
		// (set) Token: 0x06011808 RID: 71688 RVA: 0x0019AFD3 File Offset: 0x001991D3
		public unsafe float RoughnessMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_RoughnessMaxDistance) = value;
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x06011809 RID: 71689 RVA: 0x0019AFE4 File Offset: 0x001991E4
		// (set) Token: 0x0601180A RID: 71690 RVA: 0x0019AFF4 File Offset: 0x001991F4
		public unsafe bool bReactiveMaskRoughnessForceMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bReactiveMaskRoughnessForceMaxDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bReactiveMaskRoughnessForceMaxDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0601180B RID: 71691 RVA: 0x0019B005 File Offset: 0x00199205
		// (set) Token: 0x0601180C RID: 71692 RVA: 0x0019B015 File Offset: 0x00199215
		public unsafe float TranslucencyBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyBias) = value;
			}
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x0601180D RID: 71693 RVA: 0x0019B026 File Offset: 0x00199226
		// (set) Token: 0x0601180E RID: 71694 RVA: 0x0019B036 File Offset: 0x00199236
		public unsafe float TranslucencyLuminanceBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyLuminanceBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyLuminanceBias) = value;
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x0601180F RID: 71695 RVA: 0x0019B047 File Offset: 0x00199247
		// (set) Token: 0x06011810 RID: 71696 RVA: 0x0019B057 File Offset: 0x00199257
		public unsafe float TranslucencyMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_TranslucencyMaxDistance) = value;
			}
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x06011811 RID: 71697 RVA: 0x0019B068 File Offset: 0x00199268
		// (set) Token: 0x06011812 RID: 71698 RVA: 0x0019B07C File Offset: 0x0019927C
		public unsafe TEnumAsByte<EMaterialShadingModel> ReactiveShadingModelID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveShadingModelID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveShadingModelID) = value;
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x06011813 RID: 71699 RVA: 0x0019B091 File Offset: 0x00199291
		// (set) Token: 0x06011814 RID: 71700 RVA: 0x0019B0A1 File Offset: 0x001992A1
		public unsafe float ForceReactiveMaterialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ForceReactiveMaterialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ForceReactiveMaterialValue) = value;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x06011815 RID: 71701 RVA: 0x0019B0B2 File Offset: 0x001992B2
		// (set) Token: 0x06011816 RID: 71702 RVA: 0x0019B0C2 File Offset: 0x001992C2
		public unsafe float ReactiveHistoryTranslucencyBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTranslucencyBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTranslucencyBias) = value;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x06011817 RID: 71703 RVA: 0x0019B0D3 File Offset: 0x001992D3
		// (set) Token: 0x06011818 RID: 71704 RVA: 0x0019B0E3 File Offset: 0x001992E3
		public unsafe float ReactiveHistoryTranslucencyLumaBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTranslucencyLumaBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTranslucencyLumaBias) = value;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x06011819 RID: 71705 RVA: 0x0019B0F4 File Offset: 0x001992F4
		// (set) Token: 0x0601181A RID: 71706 RVA: 0x0019B104 File Offset: 0x00199304
		public unsafe float PreDOFTranslucencyScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_PreDOFTranslucencyScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_PreDOFTranslucencyScale) = value;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x0601181B RID: 71707 RVA: 0x0019B115 File Offset: 0x00199315
		// (set) Token: 0x0601181C RID: 71708 RVA: 0x0019B125 File Offset: 0x00199325
		public unsafe bool bPreDOFTranslucencyMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bPreDOFTranslucencyMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_bPreDOFTranslucencyMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x0601181D RID: 71709 RVA: 0x0019B136 File Offset: 0x00199336
		// (set) Token: 0x0601181E RID: 71710 RVA: 0x0019B146 File Offset: 0x00199346
		public unsafe float ReactiveMaskDeferredDecalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskDeferredDecalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskDeferredDecalScale) = value;
			}
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x0601181F RID: 71711 RVA: 0x0019B157 File Offset: 0x00199357
		// (set) Token: 0x06011820 RID: 71712 RVA: 0x0019B167 File Offset: 0x00199367
		public unsafe float ReactiveHistoryDeferredDecalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryDeferredDecalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryDeferredDecalScale) = value;
			}
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x06011821 RID: 71713 RVA: 0x0019B178 File Offset: 0x00199378
		// (set) Token: 0x06011822 RID: 71714 RVA: 0x0019B188 File Offset: 0x00199388
		public unsafe float ReactiveMaskTAAResponsiveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskTAAResponsiveValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskTAAResponsiveValue) = value;
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x06011823 RID: 71715 RVA: 0x0019B199 File Offset: 0x00199399
		// (set) Token: 0x06011824 RID: 71716 RVA: 0x0019B1A9 File Offset: 0x001993A9
		public unsafe float ReactiveHistoryTAAResponsiveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTAAResponsiveValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryTAAResponsiveValue) = value;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x06011825 RID: 71717 RVA: 0x0019B1BA File Offset: 0x001993BA
		// (set) Token: 0x06011826 RID: 71718 RVA: 0x0019B1CA File Offset: 0x001993CA
		public unsafe float ReactiveMaskCustomStencilScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskCustomStencilScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveMaskCustomStencilScale) = value;
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x06011827 RID: 71719 RVA: 0x0019B1DB File Offset: 0x001993DB
		// (set) Token: 0x06011828 RID: 71720 RVA: 0x0019B1EB File Offset: 0x001993EB
		public unsafe float ReactiveHistoryCustomStencilScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryCustomStencilScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_ReactiveHistoryCustomStencilScale) = value;
			}
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x06011829 RID: 71721 RVA: 0x0019B1FC File Offset: 0x001993FC
		// (set) Token: 0x0601182A RID: 71722 RVA: 0x0019B20C File Offset: 0x0019940C
		public unsafe int CustomStencilMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_CustomStencilMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_CustomStencilMask) = value;
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x0601182B RID: 71723 RVA: 0x0019B21D File Offset: 0x0019941D
		// (set) Token: 0x0601182C RID: 71724 RVA: 0x0019B22D File Offset: 0x0019942D
		public unsafe int CustomStencilShift
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_CustomStencilShift);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFXFSR3Settings.__PropertyOffset_CustomStencilShift) = value;
			}
		}

		// Token: 0x0601182D RID: 71725 RVA: 0x0019B23E File Offset: 0x0019943E
		static UFFXFSR3Settings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FFXFSR3Settings.FFXFSR3Settings");
		}

		// Token: 0x0601182E RID: 71726 RVA: 0x0019B24C File Offset: 0x0019944C
		protected UFFXFSR3Settings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095F1 RID: 38385
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FFXFSR3Settings.FFXFSR3Settings";

		// Token: 0x040095F2 RID: 38386
		private static IntPtr _ClassPtr;

		// Token: 0x040095F3 RID: 38387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040095F4 RID: 38388
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040095F5 RID: 38389
		internal static int __PropertyOffset_bAutoExposure;

		// Token: 0x040095F6 RID: 38390
		internal static int __PropertyOffset_bEnabledInEditorViewport;

		// Token: 0x040095F7 RID: 38391
		internal static int __PropertyOffset_bUseSSRExperimentalDenoiser;

		// Token: 0x040095F8 RID: 38392
		internal static int __PropertyOffset_bRHIBackend;

		// Token: 0x040095F9 RID: 38393
		internal static int __PropertyOffset_bD3D12Backend;

		// Token: 0x040095FA RID: 38394
		internal static int __PropertyOffset_bFrameGenEnabled;

		// Token: 0x040095FB RID: 38395
		internal static int __PropertyOffset_bCaptureDebugUI;

		// Token: 0x040095FC RID: 38396
		internal static int __PropertyOffset_bUpdateGlobalFrameTime;

		// Token: 0x040095FD RID: 38397
		internal static int __PropertyOffset_bModifySlateDeltaTime;

		// Token: 0x040095FE RID: 38398
		internal static int __PropertyOffset_UIMode;

		// Token: 0x040095FF RID: 38399
		internal static int __PropertyOffset_bUseDistortionTexture;

		// Token: 0x04009600 RID: 38400
		internal static int __PropertyOffset_bD3D12AsyncInterpolation;

		// Token: 0x04009601 RID: 38401
		internal static int __PropertyOffset_bD3D12AsyncPresent;

		// Token: 0x04009602 RID: 38402
		internal static int __PropertyOffset_PaceMode;

		// Token: 0x04009603 RID: 38403
		internal static int __PropertyOffset_QualityMode;

		// Token: 0x04009604 RID: 38404
		internal static int __PropertyOffset_HistoryFormat;

		// Token: 0x04009605 RID: 38405
		internal static int __PropertyOffset_DeDither;

		// Token: 0x04009606 RID: 38406
		internal static int __PropertyOffset_Sharpness;

		// Token: 0x04009607 RID: 38407
		internal static int __PropertyOffset_bAdjustMipBias;

		// Token: 0x04009608 RID: 38408
		internal static int __PropertyOffset_bForceVertexDeformationOutputsVelocity;

		// Token: 0x04009609 RID: 38409
		internal static int __PropertyOffset_ForceLandscapeHISMMobility;

		// Token: 0x0400960A RID: 38410
		internal static int __PropertyOffset_VelocityFactor;

		// Token: 0x0400960B RID: 38411
		internal static int __PropertyOffset_bReactiveMask;

		// Token: 0x0400960C RID: 38412
		internal static int __PropertyOffset_ReflectionScale;

		// Token: 0x0400960D RID: 38413
		internal static int __PropertyOffset_ReflectionLuminanceBias;

		// Token: 0x0400960E RID: 38414
		internal static int __PropertyOffset_RoughnessScale;

		// Token: 0x0400960F RID: 38415
		internal static int __PropertyOffset_RoughnessBias;

		// Token: 0x04009610 RID: 38416
		internal static int __PropertyOffset_RoughnessMaxDistance;

		// Token: 0x04009611 RID: 38417
		internal static int __PropertyOffset_bReactiveMaskRoughnessForceMaxDistance;

		// Token: 0x04009612 RID: 38418
		internal static int __PropertyOffset_TranslucencyBias;

		// Token: 0x04009613 RID: 38419
		internal static int __PropertyOffset_TranslucencyLuminanceBias;

		// Token: 0x04009614 RID: 38420
		internal static int __PropertyOffset_TranslucencyMaxDistance;

		// Token: 0x04009615 RID: 38421
		internal static int __PropertyOffset_ReactiveShadingModelID;

		// Token: 0x04009616 RID: 38422
		internal static int __PropertyOffset_ForceReactiveMaterialValue;

		// Token: 0x04009617 RID: 38423
		internal static int __PropertyOffset_ReactiveHistoryTranslucencyBias;

		// Token: 0x04009618 RID: 38424
		internal static int __PropertyOffset_ReactiveHistoryTranslucencyLumaBias;

		// Token: 0x04009619 RID: 38425
		internal static int __PropertyOffset_PreDOFTranslucencyScale;

		// Token: 0x0400961A RID: 38426
		internal static int __PropertyOffset_bPreDOFTranslucencyMax;

		// Token: 0x0400961B RID: 38427
		internal static int __PropertyOffset_ReactiveMaskDeferredDecalScale;

		// Token: 0x0400961C RID: 38428
		internal static int __PropertyOffset_ReactiveHistoryDeferredDecalScale;

		// Token: 0x0400961D RID: 38429
		internal static int __PropertyOffset_ReactiveMaskTAAResponsiveValue;

		// Token: 0x0400961E RID: 38430
		internal static int __PropertyOffset_ReactiveHistoryTAAResponsiveValue;

		// Token: 0x0400961F RID: 38431
		internal static int __PropertyOffset_ReactiveMaskCustomStencilScale;

		// Token: 0x04009620 RID: 38432
		internal static int __PropertyOffset_ReactiveHistoryCustomStencilScale;

		// Token: 0x04009621 RID: 38433
		internal static int __PropertyOffset_CustomStencilMask;

		// Token: 0x04009622 RID: 38434
		internal static int __PropertyOffset_CustomStencilShift;
	}
}
