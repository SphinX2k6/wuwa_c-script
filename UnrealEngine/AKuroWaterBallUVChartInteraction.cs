using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE2 RID: 7138
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallUVChartInteraction")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AKuroWaterBallUVChartInteraction : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B69B RID: 112283 RVA: 0x002862E8 File Offset: 0x002844E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWaterBallUVChartInteraction._ClassPtr;
		}

		// Token: 0x0601B69C RID: 112284 RVA: 0x002862F4 File Offset: 0x002844F4
		public AKuroWaterBallUVChartInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroWaterBallUVChartInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B69D RID: 112285 RVA: 0x0028631C File Offset: 0x0028451C
		[NullableContext(1)]
		public AKuroWaterBallUVChartInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWaterBallUVChartInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E29 RID: 28201
		// (get) Token: 0x0601B69E RID: 112286 RVA: 0x0028634F File Offset: 0x0028454F
		// (set) Token: 0x0601B69F RID: 112287 RVA: 0x00286363 File Offset: 0x00284563
		public unsafe USceneComponent RootScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RootScene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RootScene, value);
			}
		}

		// Token: 0x17006E2A RID: 28202
		// (get) Token: 0x0601B6A0 RID: 112288 RVA: 0x00286378 File Offset: 0x00284578
		// (set) Token: 0x0601B6A1 RID: 112289 RVA: 0x0028638C File Offset: 0x0028458C
		public unsafe UBoxComponent ActivationBounds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_ActivationBounds);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_ActivationBounds, value);
			}
		}

		// Token: 0x17006E2B RID: 28203
		// (get) Token: 0x0601B6A2 RID: 112290 RVA: 0x002863A1 File Offset: 0x002845A1
		// (set) Token: 0x0601B6A3 RID: 112291 RVA: 0x002863B5 File Offset: 0x002845B5
		public unsafe UStaticMeshComponent WaterMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_WaterMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_WaterMesh, value);
			}
		}

		// Token: 0x17006E2C RID: 28204
		// (get) Token: 0x0601B6A4 RID: 112292 RVA: 0x002863CA File Offset: 0x002845CA
		// (set) Token: 0x0601B6A5 RID: 112293 RVA: 0x002863DE File Offset: 0x002845DE
		public unsafe UTextureRenderTarget2D RT_WaveA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveA, value);
			}
		}

		// Token: 0x17006E2D RID: 28205
		// (get) Token: 0x0601B6A6 RID: 112294 RVA: 0x002863F3 File Offset: 0x002845F3
		// (set) Token: 0x0601B6A7 RID: 112295 RVA: 0x00286407 File Offset: 0x00284607
		public unsafe UTextureRenderTarget2D RT_WaveB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveB, value);
			}
		}

		// Token: 0x17006E2E RID: 28206
		// (get) Token: 0x0601B6A8 RID: 112296 RVA: 0x0028641C File Offset: 0x0028461C
		// (set) Token: 0x0601B6A9 RID: 112297 RVA: 0x0028642C File Offset: 0x0028462C
		public unsafe int TexSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_TexSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_TexSize) = value;
			}
		}

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x0601B6AA RID: 112298 RVA: 0x0028643D File Offset: 0x0028463D
		// (set) Token: 0x0601B6AB RID: 112299 RVA: 0x00286451 File Offset: 0x00284651
		public unsafe UTexture2D SeamIndex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_SeamIndex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_SeamIndex, value);
			}
		}

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x0601B6AC RID: 112300 RVA: 0x00286466 File Offset: 0x00284666
		// (set) Token: 0x0601B6AD RID: 112301 RVA: 0x0028647A File Offset: 0x0028467A
		public unsafe UTexture2D SeamLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_SeamLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_SeamLUT, value);
			}
		}

		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x0601B6AE RID: 112302 RVA: 0x0028648F File Offset: 0x0028468F
		// (set) Token: 0x0601B6AF RID: 112303 RVA: 0x002864A3 File Offset: 0x002846A3
		public unsafe UTexture2D PosRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_PosRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_PosRT, value);
			}
		}

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x0601B6B0 RID: 112304 RVA: 0x002864B8 File Offset: 0x002846B8
		// (set) Token: 0x0601B6B1 RID: 112305 RVA: 0x002864CC File Offset: 0x002846CC
		public unsafe UTextureRenderTarget2D RT_WaveNormal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveNormal);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_RT_WaveNormal, value);
			}
		}

		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x0601B6B2 RID: 112306 RVA: 0x002864E1 File Offset: 0x002846E1
		// (set) Token: 0x0601B6B3 RID: 112307 RVA: 0x002864F5 File Offset: 0x002846F5
		public unsafe UTexture2D MeshNormalTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_MeshNormalTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_MeshNormalTex, value);
			}
		}

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x0601B6B4 RID: 112308 RVA: 0x0028650A File Offset: 0x0028470A
		// (set) Token: 0x0601B6B5 RID: 112309 RVA: 0x0028651E File Offset: 0x0028471E
		public unsafe UTexture2D MeshTangentTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_MeshTangentTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallUVChartInteraction.__PropertyOffset_MeshTangentTex, value);
			}
		}

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x0601B6B6 RID: 112310 RVA: 0x00286533 File Offset: 0x00284733
		// (set) Token: 0x0601B6B7 RID: 112311 RVA: 0x00286543 File Offset: 0x00284743
		public unsafe float NormalSampleScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_NormalSampleScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_NormalSampleScale) = value;
			}
		}

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x0601B6B8 RID: 112312 RVA: 0x00286554 File Offset: 0x00284754
		// (set) Token: 0x0601B6B9 RID: 112313 RVA: 0x00286564 File Offset: 0x00284764
		public unsafe float NormalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_NormalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_NormalScale) = value;
			}
		}

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x0601B6BA RID: 112314 RVA: 0x00286575 File Offset: 0x00284775
		// (set) Token: 0x0601B6BB RID: 112315 RVA: 0x00286585 File Offset: 0x00284785
		public unsafe bool bNormalHeightGauss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalHeightGauss) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalHeightGauss) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E38 RID: 28216
		// (get) Token: 0x0601B6BC RID: 112316 RVA: 0x00286596 File Offset: 0x00284796
		// (set) Token: 0x0601B6BD RID: 112317 RVA: 0x002865A6 File Offset: 0x002847A6
		public unsafe bool bNormalGauss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGauss) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGauss) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E39 RID: 28217
		// (get) Token: 0x0601B6BE RID: 112318 RVA: 0x002865B7 File Offset: 0x002847B7
		// (set) Token: 0x0601B6BF RID: 112319 RVA: 0x002865C7 File Offset: 0x002847C7
		public unsafe bool bNormalGaussSeamOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGaussSeamOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGaussSeamOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E3A RID: 28218
		// (get) Token: 0x0601B6C0 RID: 112320 RVA: 0x002865D8 File Offset: 0x002847D8
		// (set) Token: 0x0601B6C1 RID: 112321 RVA: 0x002865E8 File Offset: 0x002847E8
		public unsafe bool bNormalGaussPrecise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGaussPrecise) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalGaussPrecise) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E3B RID: 28219
		// (get) Token: 0x0601B6C2 RID: 112322 RVA: 0x002865F9 File Offset: 0x002847F9
		// (set) Token: 0x0601B6C3 RID: 112323 RVA: 0x00286609 File Offset: 0x00284809
		public unsafe bool bNormalPad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalPad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bNormalPad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x0601B6C4 RID: 112324 RVA: 0x0028661A File Offset: 0x0028481A
		// (set) Token: 0x0601B6C5 RID: 112325 RVA: 0x0028662A File Offset: 0x0028482A
		public unsafe float SampleScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SampleScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SampleScale) = value;
			}
		}

		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x0601B6C6 RID: 112326 RVA: 0x0028663B File Offset: 0x0028483B
		// (set) Token: 0x0601B6C7 RID: 112327 RVA: 0x0028664B File Offset: 0x0028484B
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17006E3E RID: 28222
		// (get) Token: 0x0601B6C8 RID: 112328 RVA: 0x0028665C File Offset: 0x0028485C
		// (set) Token: 0x0601B6C9 RID: 112329 RVA: 0x0028666C File Offset: 0x0028486C
		public unsafe int SubSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SubSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SubSteps) = value;
			}
		}

		// Token: 0x17006E3F RID: 28223
		// (get) Token: 0x0601B6CA RID: 112330 RVA: 0x0028667D File Offset: 0x0028487D
		// (set) Token: 0x0601B6CB RID: 112331 RVA: 0x0028668D File Offset: 0x0028488D
		public unsafe float SimulationHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SimulationHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SimulationHz) = value;
			}
		}

		// Token: 0x17006E40 RID: 28224
		// (get) Token: 0x0601B6CC RID: 112332 RVA: 0x0028669E File Offset: 0x0028489E
		// (set) Token: 0x0601B6CD RID: 112333 RVA: 0x002866AE File Offset: 0x002848AE
		public unsafe float SimGaussianStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SimGaussianStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_SimGaussianStrength) = value;
			}
		}

		// Token: 0x17006E41 RID: 28225
		// (get) Token: 0x0601B6CE RID: 112334 RVA: 0x002866BF File Offset: 0x002848BF
		// (set) Token: 0x0601B6CF RID: 112335 RVA: 0x002866CF File Offset: 0x002848CF
		public unsafe float Feather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Feather);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Feather) = value;
			}
		}

		// Token: 0x17006E42 RID: 28226
		// (get) Token: 0x0601B6D0 RID: 112336 RVA: 0x002866E0 File Offset: 0x002848E0
		// (set) Token: 0x0601B6D1 RID: 112337 RVA: 0x002866F0 File Offset: 0x002848F0
		public unsafe float Decay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Decay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_Decay) = value;
			}
		}

		// Token: 0x17006E43 RID: 28227
		// (get) Token: 0x0601B6D2 RID: 112338 RVA: 0x00286701 File Offset: 0x00284901
		// (set) Token: 0x0601B6D3 RID: 112339 RVA: 0x00286711 File Offset: 0x00284911
		public unsafe float MinInjectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_MinInjectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_MinInjectDistance) = value;
			}
		}

		// Token: 0x17006E44 RID: 28228
		// (get) Token: 0x0601B6D4 RID: 112340 RVA: 0x00286722 File Offset: 0x00284922
		// (set) Token: 0x0601B6D5 RID: 112341 RVA: 0x00286732 File Offset: 0x00284932
		public unsafe float CharInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_CharInteractRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_CharInteractRadius) = value;
			}
		}

		// Token: 0x17006E45 RID: 28229
		// (get) Token: 0x0601B6D6 RID: 112342 RVA: 0x00286743 File Offset: 0x00284943
		// (set) Token: 0x0601B6D7 RID: 112343 RVA: 0x00286753 File Offset: 0x00284953
		public unsafe float InjectStrengthScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_InjectStrengthScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_InjectStrengthScale) = value;
			}
		}

		// Token: 0x17006E46 RID: 28230
		// (get) Token: 0x0601B6D8 RID: 112344 RVA: 0x00286764 File Offset: 0x00284964
		// (set) Token: 0x0601B6D9 RID: 112345 RVA: 0x00286774 File Offset: 0x00284974
		public unsafe float MaxSurfaceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_MaxSurfaceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_MaxSurfaceDistance) = value;
			}
		}

		// Token: 0x17006E47 RID: 28231
		// (get) Token: 0x0601B6DA RID: 112346 RVA: 0x00286785 File Offset: 0x00284985
		// (set) Token: 0x0601B6DB RID: 112347 RVA: 0x00286795 File Offset: 0x00284995
		public unsafe float FacingCullDot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_FacingCullDot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_FacingCullDot) = value;
			}
		}

		// Token: 0x17006E48 RID: 28232
		// (get) Token: 0x0601B6DC RID: 112348 RVA: 0x002867A6 File Offset: 0x002849A6
		// (set) Token: 0x0601B6DD RID: 112349 RVA: 0x002867B6 File Offset: 0x002849B6
		public unsafe bool bDebugDrawInteract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bDebugDrawInteract) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallUVChartInteraction.__PropertyOffset_bDebugDrawInteract) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B6DE RID: 112350 RVA: 0x002867C7 File Offset: 0x002849C7
		public bool IsSimulationActive()
		{
			return AKuroWaterBallUVChartInteraction.__IsSimulationActive_Internal(base.NativePtr);
		}

		// Token: 0x0601B6DF RID: 112351 RVA: 0x002867D4 File Offset: 0x002849D4
		public void InitData()
		{
			AKuroWaterBallUVChartInteraction.__InitData_Internal(base.NativePtr);
		}

		// Token: 0x0601B6E0 RID: 112352 RVA: 0x002867E1 File Offset: 0x002849E1
		public void EndWaterInteraction()
		{
			AKuroWaterBallUVChartInteraction.__EndWaterInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0601B6E1 RID: 112353 RVA: 0x002867EE File Offset: 0x002849EE
		public void ClearWave()
		{
			AKuroWaterBallUVChartInteraction.__ClearWave_Internal(base.NativePtr);
		}

		// Token: 0x0601B6E2 RID: 112354 RVA: 0x002867FB File Offset: 0x002849FB
		public void BeginWaterInteraction()
		{
			AKuroWaterBallUVChartInteraction.__BeginWaterInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x00286808 File Offset: 0x00284A08
		public void AddSphereInteractor(FVectorDouble Center, float Radius, float Strength = 0.6f)
		{
			AKuroWaterBallUVChartInteraction.__AddSphereInteractor_Internal(base.NativePtr, Center, Radius, Strength);
		}

		// Token: 0x0601B6E4 RID: 112356 RVA: 0x00286818 File Offset: 0x00284A18
		public void AddInteractors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWaterBallInteractor> Interactors)
		{
			AKuroWaterBallUVChartInteraction.__AddInteractors_Internal(base.NativePtr, (Interactors ?? new TArray<FWaterBallInteractor>()).NativePtr);
		}

		// Token: 0x0601B6E5 RID: 112357 RVA: 0x00286835 File Offset: 0x00284A35
		public void AddCapsuleInteractor(UCapsuleComponent Capsule, float Strength = 0.6f)
		{
			AKuroWaterBallUVChartInteraction.__AddCapsuleInteractor_Internal(base.NativePtr, (Capsule != null) ? Capsule.NativePtr : IntPtr.Zero, Strength);
		}

		// Token: 0x0601B6E6 RID: 112358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulationActive_Internal(IntPtr @this);

		// Token: 0x0601B6E7 RID: 112359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitData_Internal(IntPtr @this);

		// Token: 0x0601B6E8 RID: 112360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndWaterInteraction_Internal(IntPtr @this);

		// Token: 0x0601B6E9 RID: 112361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWave_Internal(IntPtr @this);

		// Token: 0x0601B6EA RID: 112362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginWaterInteraction_Internal(IntPtr @this);

		// Token: 0x0601B6EB RID: 112363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSphereInteractor_Internal(IntPtr @this, FVectorDouble Center, float Radius, float Strength);

		// Token: 0x0601B6EC RID: 112364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInteractors_Internal(IntPtr @this, IntPtr Interactors);

		// Token: 0x0601B6ED RID: 112365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCapsuleInteractor_Internal(IntPtr @this, IntPtr Capsule, float Strength);

		// Token: 0x0601B6EE RID: 112366 RVA: 0x00286853 File Offset: 0x00284A53
		static AKuroWaterBallUVChartInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallUVChartInteraction");
		}

		// Token: 0x0601B6EF RID: 112367 RVA: 0x00286861 File Offset: 0x00284A61
		protected AKuroWaterBallUVChartInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC11 RID: 60433
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallUVChartInteraction";

		// Token: 0x0400EC12 RID: 60434
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC13 RID: 60435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC14 RID: 60436
		internal static int __PropertyOffset_RootScene;

		// Token: 0x0400EC15 RID: 60437
		internal static int __PropertyOffset_ActivationBounds;

		// Token: 0x0400EC16 RID: 60438
		internal static int __PropertyOffset_WaterMesh;

		// Token: 0x0400EC17 RID: 60439
		internal static int __PropertyOffset_RT_WaveA;

		// Token: 0x0400EC18 RID: 60440
		internal static int __PropertyOffset_RT_WaveB;

		// Token: 0x0400EC19 RID: 60441
		internal static int __PropertyOffset_TexSize;

		// Token: 0x0400EC1A RID: 60442
		internal static int __PropertyOffset_SeamIndex;

		// Token: 0x0400EC1B RID: 60443
		internal static int __PropertyOffset_SeamLUT;

		// Token: 0x0400EC1C RID: 60444
		internal static int __PropertyOffset_PosRT;

		// Token: 0x0400EC1D RID: 60445
		internal static int __PropertyOffset_RT_WaveNormal;

		// Token: 0x0400EC1E RID: 60446
		internal static int __PropertyOffset_MeshNormalTex;

		// Token: 0x0400EC1F RID: 60447
		internal static int __PropertyOffset_MeshTangentTex;

		// Token: 0x0400EC20 RID: 60448
		internal static int __PropertyOffset_NormalSampleScale;

		// Token: 0x0400EC21 RID: 60449
		internal static int __PropertyOffset_NormalScale;

		// Token: 0x0400EC22 RID: 60450
		internal static int __PropertyOffset_bNormalHeightGauss;

		// Token: 0x0400EC23 RID: 60451
		internal static int __PropertyOffset_bNormalGauss;

		// Token: 0x0400EC24 RID: 60452
		internal static int __PropertyOffset_bNormalGaussSeamOnly;

		// Token: 0x0400EC25 RID: 60453
		internal static int __PropertyOffset_bNormalGaussPrecise;

		// Token: 0x0400EC26 RID: 60454
		internal static int __PropertyOffset_bNormalPad;

		// Token: 0x0400EC27 RID: 60455
		internal static int __PropertyOffset_SampleScale;

		// Token: 0x0400EC28 RID: 60456
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400EC29 RID: 60457
		internal static int __PropertyOffset_SubSteps;

		// Token: 0x0400EC2A RID: 60458
		internal static int __PropertyOffset_SimulationHz;

		// Token: 0x0400EC2B RID: 60459
		internal static int __PropertyOffset_SimGaussianStrength;

		// Token: 0x0400EC2C RID: 60460
		internal static int __PropertyOffset_Feather;

		// Token: 0x0400EC2D RID: 60461
		internal static int __PropertyOffset_Decay;

		// Token: 0x0400EC2E RID: 60462
		internal static int __PropertyOffset_MinInjectDistance;

		// Token: 0x0400EC2F RID: 60463
		internal static int __PropertyOffset_CharInteractRadius;

		// Token: 0x0400EC30 RID: 60464
		internal static int __PropertyOffset_InjectStrengthScale;

		// Token: 0x0400EC31 RID: 60465
		internal static int __PropertyOffset_MaxSurfaceDistance;

		// Token: 0x0400EC32 RID: 60466
		internal static int __PropertyOffset_FacingCullDot;

		// Token: 0x0400EC33 RID: 60467
		internal static int __PropertyOffset_bDebugDrawInteract;
	}
}
