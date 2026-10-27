using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D5A RID: 3418
	[UnrealObjectPath("/Script/Engine.LightmassWorldInfoSettings")]
	[UnrealStructLayout(76, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 76)]
	public class FLightmassWorldInfoSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B86E RID: 47214 RVA: 0x001067E5 File Offset: 0x001049E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassWorldInfoSettings._ScriptStructPtr != 0) ? FLightmassWorldInfoSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassWorldInfoSettings", ref FLightmassWorldInfoSettings._ScriptStructPtr);
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x00106809 File Offset: 0x00104A09
		// (set) Token: 0x0600B870 RID: 47216 RVA: 0x00106819 File Offset: 0x00104A19
		public unsafe float StaticLightingLevelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_StaticLightingLevelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_StaticLightingLevelScale) = value;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x0010682A File Offset: 0x00104A2A
		// (set) Token: 0x0600B872 RID: 47218 RVA: 0x0010683A File Offset: 0x00104A3A
		public unsafe int NumIndirectLightingBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_NumIndirectLightingBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_NumIndirectLightingBounces) = value;
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x0010684B File Offset: 0x00104A4B
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x0010685B File Offset: 0x00104A5B
		public unsafe int NumSkyLightingBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_NumSkyLightingBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_NumSkyLightingBounces) = value;
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x0010686C File Offset: 0x00104A6C
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x0010687C File Offset: 0x00104A7C
		public unsafe float IndirectLightingQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectLightingQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectLightingQuality) = value;
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x0010688D File Offset: 0x00104A8D
		// (set) Token: 0x0600B878 RID: 47224 RVA: 0x0010689D File Offset: 0x00104A9D
		public unsafe float IndirectLightingSmoothness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectLightingSmoothness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectLightingSmoothness) = value;
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x001068AE File Offset: 0x00104AAE
		// (set) Token: 0x0600B87A RID: 47226 RVA: 0x001068C2 File Offset: 0x00104AC2
		public unsafe FColor EnvironmentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EnvironmentColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EnvironmentColor) = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x001068D7 File Offset: 0x00104AD7
		// (set) Token: 0x0600B87C RID: 47228 RVA: 0x001068E7 File Offset: 0x00104AE7
		public unsafe float EnvironmentIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EnvironmentIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EnvironmentIntensity) = value;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x001068F8 File Offset: 0x00104AF8
		// (set) Token: 0x0600B87E RID: 47230 RVA: 0x00106908 File Offset: 0x00104B08
		public unsafe float EmissiveBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EmissiveBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_EmissiveBoost) = value;
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600B87F RID: 47231 RVA: 0x00106919 File Offset: 0x00104B19
		// (set) Token: 0x0600B880 RID: 47232 RVA: 0x00106929 File Offset: 0x00104B29
		public unsafe float DiffuseBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_DiffuseBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_DiffuseBoost) = value;
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600B881 RID: 47233 RVA: 0x0010693A File Offset: 0x00104B3A
		// (set) Token: 0x0600B882 RID: 47234 RVA: 0x0010694E File Offset: 0x00104B4E
		public unsafe TEnumAsByte<EVolumeLightingMethod> VolumeLightingMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumeLightingMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumeLightingMethod) = value;
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x00106963 File Offset: 0x00104B63
		// (set) Token: 0x0600B884 RID: 47236 RVA: 0x0010697C File Offset: 0x00104B7C
		public unsafe bool bUseAmbientOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bUseAmbientOcclusion) & FLightmassWorldInfoSettings.__PropertyMask_bUseAmbientOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bUseAmbientOcclusion) = ((*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bUseAmbientOcclusion) & ~FLightmassWorldInfoSettings.__PropertyMask_bUseAmbientOcclusion) | (value ? FLightmassWorldInfoSettings.__PropertyMask_bUseAmbientOcclusion : 0));
			}
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x001069AC File Offset: 0x00104BAC
		// (set) Token: 0x0600B886 RID: 47238 RVA: 0x001069C5 File Offset: 0x00104BC5
		public unsafe bool bGenerateAmbientOcclusionMaterialMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bGenerateAmbientOcclusionMaterialMask) & FLightmassWorldInfoSettings.__PropertyMask_bGenerateAmbientOcclusionMaterialMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bGenerateAmbientOcclusionMaterialMask) = ((*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bGenerateAmbientOcclusionMaterialMask) & ~FLightmassWorldInfoSettings.__PropertyMask_bGenerateAmbientOcclusionMaterialMask) | (value ? FLightmassWorldInfoSettings.__PropertyMask_bGenerateAmbientOcclusionMaterialMask : 0));
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x001069F5 File Offset: 0x00104BF5
		// (set) Token: 0x0600B888 RID: 47240 RVA: 0x00106A0E File Offset: 0x00104C0E
		public unsafe bool bVisualizeMaterialDiffuse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeMaterialDiffuse) & FLightmassWorldInfoSettings.__PropertyMask_bVisualizeMaterialDiffuse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeMaterialDiffuse) = ((*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeMaterialDiffuse) & ~FLightmassWorldInfoSettings.__PropertyMask_bVisualizeMaterialDiffuse) | (value ? FLightmassWorldInfoSettings.__PropertyMask_bVisualizeMaterialDiffuse : 0));
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x00106A3E File Offset: 0x00104C3E
		// (set) Token: 0x0600B88A RID: 47242 RVA: 0x00106A57 File Offset: 0x00104C57
		public unsafe bool bVisualizeAmbientOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeAmbientOcclusion) & FLightmassWorldInfoSettings.__PropertyMask_bVisualizeAmbientOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeAmbientOcclusion) = ((*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bVisualizeAmbientOcclusion) & ~FLightmassWorldInfoSettings.__PropertyMask_bVisualizeAmbientOcclusion) | (value ? FLightmassWorldInfoSettings.__PropertyMask_bVisualizeAmbientOcclusion : 0));
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x00106A87 File Offset: 0x00104C87
		// (set) Token: 0x0600B88C RID: 47244 RVA: 0x00106AA0 File Offset: 0x00104CA0
		public unsafe bool bCompressLightmaps
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bCompressLightmaps) & FLightmassWorldInfoSettings.__PropertyMask_bCompressLightmaps) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bCompressLightmaps) = ((*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_bCompressLightmaps) & ~FLightmassWorldInfoSettings.__PropertyMask_bCompressLightmaps) | (value ? FLightmassWorldInfoSettings.__PropertyMask_bCompressLightmaps : 0));
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600B88D RID: 47245 RVA: 0x00106AD0 File Offset: 0x00104CD0
		// (set) Token: 0x0600B88E RID: 47246 RVA: 0x00106AE0 File Offset: 0x00104CE0
		public unsafe float VolumetricLightmapDetailCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapDetailCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapDetailCellSize) = value;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600B88F RID: 47247 RVA: 0x00106AF1 File Offset: 0x00104CF1
		// (set) Token: 0x0600B890 RID: 47248 RVA: 0x00106B01 File Offset: 0x00104D01
		public unsafe float VolumetricLightmapMaximumBrickMemoryMb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapMaximumBrickMemoryMb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapMaximumBrickMemoryMb) = value;
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600B891 RID: 47249 RVA: 0x00106B12 File Offset: 0x00104D12
		// (set) Token: 0x0600B892 RID: 47250 RVA: 0x00106B22 File Offset: 0x00104D22
		public unsafe float VolumetricLightmapSphericalHarmonicSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapSphericalHarmonicSmoothing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumetricLightmapSphericalHarmonicSmoothing) = value;
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600B893 RID: 47251 RVA: 0x00106B33 File Offset: 0x00104D33
		// (set) Token: 0x0600B894 RID: 47252 RVA: 0x00106B43 File Offset: 0x00104D43
		public unsafe float VolumeLightSamplePlacementScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumeLightSamplePlacementScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_VolumeLightSamplePlacementScale) = value;
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600B895 RID: 47253 RVA: 0x00106B54 File Offset: 0x00104D54
		// (set) Token: 0x0600B896 RID: 47254 RVA: 0x00106B64 File Offset: 0x00104D64
		public unsafe float DirectIlluminationOcclusionFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_DirectIlluminationOcclusionFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_DirectIlluminationOcclusionFraction) = value;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x00106B75 File Offset: 0x00104D75
		// (set) Token: 0x0600B898 RID: 47256 RVA: 0x00106B85 File Offset: 0x00104D85
		public unsafe float IndirectIlluminationOcclusionFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectIlluminationOcclusionFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_IndirectIlluminationOcclusionFraction) = value;
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x00106B96 File Offset: 0x00104D96
		// (set) Token: 0x0600B89A RID: 47258 RVA: 0x00106BA6 File Offset: 0x00104DA6
		public unsafe float OcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_OcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_OcclusionExponent) = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x00106BB7 File Offset: 0x00104DB7
		// (set) Token: 0x0600B89C RID: 47260 RVA: 0x00106BC7 File Offset: 0x00104DC7
		public unsafe float FullyOccludedSamplesFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_FullyOccludedSamplesFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_FullyOccludedSamplesFraction) = value;
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x00106BD8 File Offset: 0x00104DD8
		// (set) Token: 0x0600B89E RID: 47262 RVA: 0x00106BE8 File Offset: 0x00104DE8
		public unsafe float MaxOcclusionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_MaxOcclusionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassWorldInfoSettings.__PropertyOffset_MaxOcclusionDistance) = value;
			}
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x00106BF9 File Offset: 0x00104DF9
		public FLightmassWorldInfoSettings()
		{
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x00106C04 File Offset: 0x00104E04
		public FLightmassWorldInfoSettings(float StaticLightingLevelScale, int NumIndirectLightingBounces, int NumSkyLightingBounces, float IndirectLightingQuality, float IndirectLightingSmoothness, FColor EnvironmentColor, float EnvironmentIntensity, float EmissiveBoost, float DiffuseBoost, TEnumAsByte<EVolumeLightingMethod> VolumeLightingMethod, bool bUseAmbientOcclusion, bool bGenerateAmbientOcclusionMaterialMask, bool bVisualizeMaterialDiffuse, bool bVisualizeAmbientOcclusion, bool bCompressLightmaps, float VolumetricLightmapDetailCellSize, float VolumetricLightmapMaximumBrickMemoryMb, float VolumetricLightmapSphericalHarmonicSmoothing, float VolumeLightSamplePlacementScale, float DirectIlluminationOcclusionFraction, float IndirectIlluminationOcclusionFraction, float OcclusionExponent, float FullyOccludedSamplesFraction, float MaxOcclusionDistance)
		{
			this.StaticLightingLevelScale = StaticLightingLevelScale;
			this.NumIndirectLightingBounces = NumIndirectLightingBounces;
			this.NumSkyLightingBounces = NumSkyLightingBounces;
			this.IndirectLightingQuality = IndirectLightingQuality;
			this.IndirectLightingSmoothness = IndirectLightingSmoothness;
			this.EnvironmentColor = EnvironmentColor;
			this.EnvironmentIntensity = EnvironmentIntensity;
			this.EmissiveBoost = EmissiveBoost;
			this.DiffuseBoost = DiffuseBoost;
			this.VolumeLightingMethod = VolumeLightingMethod;
			this.bUseAmbientOcclusion = bUseAmbientOcclusion;
			this.bGenerateAmbientOcclusionMaterialMask = bGenerateAmbientOcclusionMaterialMask;
			this.bVisualizeMaterialDiffuse = bVisualizeMaterialDiffuse;
			this.bVisualizeAmbientOcclusion = bVisualizeAmbientOcclusion;
			this.bCompressLightmaps = bCompressLightmaps;
			this.VolumetricLightmapDetailCellSize = VolumetricLightmapDetailCellSize;
			this.VolumetricLightmapMaximumBrickMemoryMb = VolumetricLightmapMaximumBrickMemoryMb;
			this.VolumetricLightmapSphericalHarmonicSmoothing = VolumetricLightmapSphericalHarmonicSmoothing;
			this.VolumeLightSamplePlacementScale = VolumeLightSamplePlacementScale;
			this.DirectIlluminationOcclusionFraction = DirectIlluminationOcclusionFraction;
			this.IndirectIlluminationOcclusionFraction = IndirectIlluminationOcclusionFraction;
			this.OcclusionExponent = OcclusionExponent;
			this.FullyOccludedSamplesFraction = FullyOccludedSamplesFraction;
			this.MaxOcclusionDistance = MaxOcclusionDistance;
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x00106CD4 File Offset: 0x00104ED4
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassWorldInfoSettings.StaticStruct();
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x00106CE0 File Offset: 0x00104EE0
		[NullableContext(2)]
		public FLightmassWorldInfoSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x00106CEA File Offset: 0x00104EEA
		public FLightmassWorldInfoSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x00106CF5 File Offset: 0x00104EF5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassWorldInfoSettings(Pointer, false, true);
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x00106CFF File Offset: 0x00104EFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassWorldInfoSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040060A7 RID: 24743
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightmassWorldInfoSettings";

		// Token: 0x040060A8 RID: 24744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040060A9 RID: 24745
		internal static int __PropertyOffset_StaticLightingLevelScale;

		// Token: 0x040060AA RID: 24746
		internal static int __PropertyOffset_NumIndirectLightingBounces;

		// Token: 0x040060AB RID: 24747
		internal static int __PropertyOffset_NumSkyLightingBounces;

		// Token: 0x040060AC RID: 24748
		internal static int __PropertyOffset_IndirectLightingQuality;

		// Token: 0x040060AD RID: 24749
		internal static int __PropertyOffset_IndirectLightingSmoothness;

		// Token: 0x040060AE RID: 24750
		internal static int __PropertyOffset_EnvironmentColor;

		// Token: 0x040060AF RID: 24751
		internal static int __PropertyOffset_EnvironmentIntensity;

		// Token: 0x040060B0 RID: 24752
		internal static int __PropertyOffset_EmissiveBoost;

		// Token: 0x040060B1 RID: 24753
		internal static int __PropertyOffset_DiffuseBoost;

		// Token: 0x040060B2 RID: 24754
		internal static int __PropertyOffset_VolumeLightingMethod;

		// Token: 0x040060B3 RID: 24755
		internal static int __PropertyOffset_bUseAmbientOcclusion;

		// Token: 0x040060B4 RID: 24756
		internal static byte __PropertyMask_bUseAmbientOcclusion;

		// Token: 0x040060B5 RID: 24757
		internal static int __PropertyOffset_bGenerateAmbientOcclusionMaterialMask;

		// Token: 0x040060B6 RID: 24758
		internal static byte __PropertyMask_bGenerateAmbientOcclusionMaterialMask;

		// Token: 0x040060B7 RID: 24759
		internal static int __PropertyOffset_bVisualizeMaterialDiffuse;

		// Token: 0x040060B8 RID: 24760
		internal static byte __PropertyMask_bVisualizeMaterialDiffuse;

		// Token: 0x040060B9 RID: 24761
		internal static int __PropertyOffset_bVisualizeAmbientOcclusion;

		// Token: 0x040060BA RID: 24762
		internal static byte __PropertyMask_bVisualizeAmbientOcclusion;

		// Token: 0x040060BB RID: 24763
		internal static int __PropertyOffset_bCompressLightmaps;

		// Token: 0x040060BC RID: 24764
		internal static byte __PropertyMask_bCompressLightmaps;

		// Token: 0x040060BD RID: 24765
		internal static int __PropertyOffset_VolumetricLightmapDetailCellSize;

		// Token: 0x040060BE RID: 24766
		internal static int __PropertyOffset_VolumetricLightmapMaximumBrickMemoryMb;

		// Token: 0x040060BF RID: 24767
		internal static int __PropertyOffset_VolumetricLightmapSphericalHarmonicSmoothing;

		// Token: 0x040060C0 RID: 24768
		internal static int __PropertyOffset_VolumeLightSamplePlacementScale;

		// Token: 0x040060C1 RID: 24769
		internal static int __PropertyOffset_DirectIlluminationOcclusionFraction;

		// Token: 0x040060C2 RID: 24770
		internal static int __PropertyOffset_IndirectIlluminationOcclusionFraction;

		// Token: 0x040060C3 RID: 24771
		internal static int __PropertyOffset_OcclusionExponent;

		// Token: 0x040060C4 RID: 24772
		internal static int __PropertyOffset_FullyOccludedSamplesFraction;

		// Token: 0x040060C5 RID: 24773
		internal static int __PropertyOffset_MaxOcclusionDistance;
	}
}
