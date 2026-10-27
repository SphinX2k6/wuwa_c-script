using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE1 RID: 7137
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallCubeInteraction")]
	[UnrealStructLayout(1640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1640)]
	public class AKuroWaterBallCubeInteraction : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B65A RID: 112218 RVA: 0x00285EDE File Offset: 0x002840DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWaterBallCubeInteraction._ClassPtr;
		}

		// Token: 0x0601B65B RID: 112219 RVA: 0x00285EEC File Offset: 0x002840EC
		public AKuroWaterBallCubeInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroWaterBallCubeInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B65C RID: 112220 RVA: 0x00285F14 File Offset: 0x00284114
		[NullableContext(1)]
		public AKuroWaterBallCubeInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWaterBallCubeInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E13 RID: 28179
		// (get) Token: 0x0601B65D RID: 112221 RVA: 0x00285F47 File Offset: 0x00284147
		// (set) Token: 0x0601B65E RID: 112222 RVA: 0x00285F5B File Offset: 0x0028415B
		public unsafe USceneComponent RootScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RootScene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RootScene, value);
			}
		}

		// Token: 0x17006E14 RID: 28180
		// (get) Token: 0x0601B65F RID: 112223 RVA: 0x00285F70 File Offset: 0x00284170
		// (set) Token: 0x0601B660 RID: 112224 RVA: 0x00285F84 File Offset: 0x00284184
		public unsafe UBoxComponent ActivationBounds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_ActivationBounds);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_ActivationBounds, value);
			}
		}

		// Token: 0x17006E15 RID: 28181
		// (get) Token: 0x0601B661 RID: 112225 RVA: 0x00285F99 File Offset: 0x00284199
		// (set) Token: 0x0601B662 RID: 112226 RVA: 0x00285FAD File Offset: 0x002841AD
		public unsafe UStaticMeshComponent BallMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_BallMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_BallMesh, value);
			}
		}

		// Token: 0x17006E16 RID: 28182
		// (get) Token: 0x0601B663 RID: 112227 RVA: 0x00285FC2 File Offset: 0x002841C2
		// (set) Token: 0x0601B664 RID: 112228 RVA: 0x00285FD6 File Offset: 0x002841D6
		public unsafe UTextureRenderTargetCube RT_WaveCubeA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RT_WaveCubeA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RT_WaveCubeA, value);
			}
		}

		// Token: 0x17006E17 RID: 28183
		// (get) Token: 0x0601B665 RID: 112229 RVA: 0x00285FEB File Offset: 0x002841EB
		// (set) Token: 0x0601B666 RID: 112230 RVA: 0x00285FFF File Offset: 0x002841FF
		public unsafe UTextureRenderTargetCube RT_WaveCubeB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RT_WaveCubeB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWaterBallCubeInteraction.__PropertyOffset_RT_WaveCubeB, value);
			}
		}

		// Token: 0x17006E18 RID: 28184
		// (get) Token: 0x0601B667 RID: 112231 RVA: 0x00286014 File Offset: 0x00284214
		// (set) Token: 0x0601B668 RID: 112232 RVA: 0x00286024 File Offset: 0x00284224
		public unsafe int CubeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_CubeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_CubeSize) = value;
			}
		}

		// Token: 0x17006E19 RID: 28185
		// (get) Token: 0x0601B669 RID: 112233 RVA: 0x00286035 File Offset: 0x00284235
		// (set) Token: 0x0601B66A RID: 112234 RVA: 0x00286045 File Offset: 0x00284245
		public unsafe float WaveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaveSpeed) = value;
			}
		}

		// Token: 0x17006E1A RID: 28186
		// (get) Token: 0x0601B66B RID: 112235 RVA: 0x00286056 File Offset: 0x00284256
		// (set) Token: 0x0601B66C RID: 112236 RVA: 0x00286066 File Offset: 0x00284266
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17006E1B RID: 28187
		// (get) Token: 0x0601B66D RID: 112237 RVA: 0x00286077 File Offset: 0x00284277
		// (set) Token: 0x0601B66E RID: 112238 RVA: 0x00286087 File Offset: 0x00284287
		public unsafe int SubSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_SubSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_SubSteps) = value;
			}
		}

		// Token: 0x17006E1C RID: 28188
		// (get) Token: 0x0601B66F RID: 112239 RVA: 0x00286098 File Offset: 0x00284298
		// (set) Token: 0x0601B670 RID: 112240 RVA: 0x002860A8 File Offset: 0x002842A8
		public unsafe float RingWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_RingWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_RingWidth) = value;
			}
		}

		// Token: 0x17006E1D RID: 28189
		// (get) Token: 0x0601B671 RID: 112241 RVA: 0x002860B9 File Offset: 0x002842B9
		// (set) Token: 0x0601B672 RID: 112242 RVA: 0x002860C9 File Offset: 0x002842C9
		public unsafe float HeightDisplacementRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_HeightDisplacementRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_HeightDisplacementRatio) = value;
			}
		}

		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x0601B673 RID: 112243 RVA: 0x002860DA File Offset: 0x002842DA
		// (set) Token: 0x0601B674 RID: 112244 RVA: 0x002860EA File Offset: 0x002842EA
		public unsafe float WaterBallAngStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaterBallAngStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaterBallAngStep) = value;
			}
		}

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x0601B675 RID: 112245 RVA: 0x002860FB File Offset: 0x002842FB
		// (set) Token: 0x0601B676 RID: 112246 RVA: 0x0028610B File Offset: 0x0028430B
		public unsafe float WaterBallNormalBump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaterBallNormalBump);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_WaterBallNormalBump) = value;
			}
		}

		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x0601B677 RID: 112247 RVA: 0x0028611C File Offset: 0x0028431C
		// (set) Token: 0x0601B678 RID: 112248 RVA: 0x0028612C File Offset: 0x0028432C
		public unsafe bool bEnableAutoRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_bEnableAutoRipple) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_bEnableAutoRipple) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x0601B679 RID: 112249 RVA: 0x0028613D File Offset: 0x0028433D
		// (set) Token: 0x0601B67A RID: 112250 RVA: 0x0028614D File Offset: 0x0028434D
		public unsafe float AutoRippleStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleStrength) = value;
			}
		}

		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x0601B67B RID: 112251 RVA: 0x0028615E File Offset: 0x0028435E
		// (set) Token: 0x0601B67C RID: 112252 RVA: 0x0028616E File Offset: 0x0028436E
		public unsafe float AutoRippleAngularRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleAngularRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleAngularRadius) = value;
			}
		}

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x0601B67D RID: 112253 RVA: 0x0028617F File Offset: 0x0028437F
		// (set) Token: 0x0601B67E RID: 112254 RVA: 0x0028618F File Offset: 0x0028438F
		public unsafe int AutoRipplePointsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRipplePointsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRipplePointsPerFrame) = value;
			}
		}

		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x0601B67F RID: 112255 RVA: 0x002861A0 File Offset: 0x002843A0
		// (set) Token: 0x0601B680 RID: 112256 RVA: 0x002861B0 File Offset: 0x002843B0
		public unsafe int AutoRippleInjectFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleInjectFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_AutoRippleInjectFrames) = value;
			}
		}

		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x0601B681 RID: 112257 RVA: 0x002861C1 File Offset: 0x002843C1
		// (set) Token: 0x0601B682 RID: 112258 RVA: 0x002861D1 File Offset: 0x002843D1
		public unsafe float MinInjectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_MinInjectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_MinInjectDistance) = value;
			}
		}

		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x0601B683 RID: 112259 RVA: 0x002861E2 File Offset: 0x002843E2
		// (set) Token: 0x0601B684 RID: 112260 RVA: 0x002861F2 File Offset: 0x002843F2
		public unsafe float CharInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_CharInteractRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_CharInteractRadius) = value;
			}
		}

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x0601B685 RID: 112261 RVA: 0x00286203 File Offset: 0x00284403
		// (set) Token: 0x0601B686 RID: 112262 RVA: 0x00286213 File Offset: 0x00284413
		public unsafe float MaxSurfaceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_MaxSurfaceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_MaxSurfaceDistance) = value;
			}
		}

		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x0601B687 RID: 112263 RVA: 0x00286224 File Offset: 0x00284424
		// (set) Token: 0x0601B688 RID: 112264 RVA: 0x00286234 File Offset: 0x00284434
		public unsafe bool bDebugDrawInteract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_bDebugDrawInteract) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWaterBallCubeInteraction.__PropertyOffset_bDebugDrawInteract) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B689 RID: 112265 RVA: 0x00286245 File Offset: 0x00284445
		public bool IsSimulationActive()
		{
			return AKuroWaterBallCubeInteraction.__IsSimulationActive_Internal(base.NativePtr);
		}

		// Token: 0x0601B68A RID: 112266 RVA: 0x00286252 File Offset: 0x00284452
		public void InitData()
		{
			AKuroWaterBallCubeInteraction.__InitData_Internal(base.NativePtr);
		}

		// Token: 0x0601B68B RID: 112267 RVA: 0x0028625F File Offset: 0x0028445F
		public void EndWaterInteraction()
		{
			AKuroWaterBallCubeInteraction.__EndWaterInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0601B68C RID: 112268 RVA: 0x0028626C File Offset: 0x0028446C
		public void ClearWave()
		{
			AKuroWaterBallCubeInteraction.__ClearWave_Internal(base.NativePtr);
		}

		// Token: 0x0601B68D RID: 112269 RVA: 0x00286279 File Offset: 0x00284479
		public void BeginWaterInteraction()
		{
			AKuroWaterBallCubeInteraction.__BeginWaterInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0601B68E RID: 112270 RVA: 0x00286286 File Offset: 0x00284486
		public void AddSphereInteractor(FVectorDouble Center, float Radius, float Strength = 0.85f)
		{
			AKuroWaterBallCubeInteraction.__AddSphereInteractor_Internal(base.NativePtr, Center, Radius, Strength);
		}

		// Token: 0x0601B68F RID: 112271 RVA: 0x00286296 File Offset: 0x00284496
		public void AddInteractors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWaterBallInteractor> Interactors)
		{
			AKuroWaterBallCubeInteraction.__AddInteractors_Internal(base.NativePtr, (Interactors ?? new TArray<FWaterBallInteractor>()).NativePtr);
		}

		// Token: 0x0601B690 RID: 112272 RVA: 0x002862B3 File Offset: 0x002844B3
		public void AddCapsuleInteractor(UCapsuleComponent Capsule, float Strength = 0.85f)
		{
			AKuroWaterBallCubeInteraction.__AddCapsuleInteractor_Internal(base.NativePtr, (Capsule != null) ? Capsule.NativePtr : IntPtr.Zero, Strength);
		}

		// Token: 0x0601B691 RID: 112273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulationActive_Internal(IntPtr @this);

		// Token: 0x0601B692 RID: 112274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitData_Internal(IntPtr @this);

		// Token: 0x0601B693 RID: 112275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndWaterInteraction_Internal(IntPtr @this);

		// Token: 0x0601B694 RID: 112276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWave_Internal(IntPtr @this);

		// Token: 0x0601B695 RID: 112277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginWaterInteraction_Internal(IntPtr @this);

		// Token: 0x0601B696 RID: 112278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSphereInteractor_Internal(IntPtr @this, FVectorDouble Center, float Radius, float Strength);

		// Token: 0x0601B697 RID: 112279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInteractors_Internal(IntPtr @this, IntPtr Interactors);

		// Token: 0x0601B698 RID: 112280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCapsuleInteractor_Internal(IntPtr @this, IntPtr Capsule, float Strength);

		// Token: 0x0601B699 RID: 112281 RVA: 0x002862D1 File Offset: 0x002844D1
		static AKuroWaterBallCubeInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallCubeInteraction");
		}

		// Token: 0x0601B69A RID: 112282 RVA: 0x002862DF File Offset: 0x002844DF
		protected AKuroWaterBallCubeInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBF8 RID: 60408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWaterBallCubeInteraction";

		// Token: 0x0400EBF9 RID: 60409
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBFA RID: 60410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBFB RID: 60411
		internal static int __PropertyOffset_RootScene;

		// Token: 0x0400EBFC RID: 60412
		internal static int __PropertyOffset_ActivationBounds;

		// Token: 0x0400EBFD RID: 60413
		internal static int __PropertyOffset_BallMesh;

		// Token: 0x0400EBFE RID: 60414
		internal static int __PropertyOffset_RT_WaveCubeA;

		// Token: 0x0400EBFF RID: 60415
		internal static int __PropertyOffset_RT_WaveCubeB;

		// Token: 0x0400EC00 RID: 60416
		internal static int __PropertyOffset_CubeSize;

		// Token: 0x0400EC01 RID: 60417
		internal static int __PropertyOffset_WaveSpeed;

		// Token: 0x0400EC02 RID: 60418
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400EC03 RID: 60419
		internal static int __PropertyOffset_SubSteps;

		// Token: 0x0400EC04 RID: 60420
		internal static int __PropertyOffset_RingWidth;

		// Token: 0x0400EC05 RID: 60421
		internal static int __PropertyOffset_HeightDisplacementRatio;

		// Token: 0x0400EC06 RID: 60422
		internal static int __PropertyOffset_WaterBallAngStep;

		// Token: 0x0400EC07 RID: 60423
		internal static int __PropertyOffset_WaterBallNormalBump;

		// Token: 0x0400EC08 RID: 60424
		internal static int __PropertyOffset_bEnableAutoRipple;

		// Token: 0x0400EC09 RID: 60425
		internal static int __PropertyOffset_AutoRippleStrength;

		// Token: 0x0400EC0A RID: 60426
		internal static int __PropertyOffset_AutoRippleAngularRadius;

		// Token: 0x0400EC0B RID: 60427
		internal static int __PropertyOffset_AutoRipplePointsPerFrame;

		// Token: 0x0400EC0C RID: 60428
		internal static int __PropertyOffset_AutoRippleInjectFrames;

		// Token: 0x0400EC0D RID: 60429
		internal static int __PropertyOffset_MinInjectDistance;

		// Token: 0x0400EC0E RID: 60430
		internal static int __PropertyOffset_CharInteractRadius;

		// Token: 0x0400EC0F RID: 60431
		internal static int __PropertyOffset_MaxSurfaceDistance;

		// Token: 0x0400EC10 RID: 60432
		internal static int __PropertyOffset_bDebugDrawInteract;
	}
}
