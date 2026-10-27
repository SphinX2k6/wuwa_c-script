using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017C9 RID: 6089
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSSimpleCollision")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroCSSimpleCollision : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060164DD RID: 91357 RVA: 0x0020A106 File Offset: 0x00208306
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSSimpleCollision._ClassPtr;
		}

		// Token: 0x060164DE RID: 91358 RVA: 0x0020A114 File Offset: 0x00208314
		public AKuroCSSimpleCollision() : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060164DF RID: 91359 RVA: 0x0020A13C File Offset: 0x0020833C
		[NullableContext(1)]
		public AKuroCSSimpleCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x060164E0 RID: 91360 RVA: 0x0020A16F File Offset: 0x0020836F
		// (set) Token: 0x060164E1 RID: 91361 RVA: 0x0020A183 File Offset: 0x00208383
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x060164E2 RID: 91362 RVA: 0x0020A198 File Offset: 0x00208398
		// (set) Token: 0x060164E3 RID: 91363 RVA: 0x0020A1A8 File Offset: 0x002083A8
		public unsafe bool bEnableRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_bEnableRendering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_bEnableRendering) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x060164E4 RID: 91364 RVA: 0x0020A1B9 File Offset: 0x002083B9
		// (set) Token: 0x060164E5 RID: 91365 RVA: 0x0020A1CD File Offset: 0x002083CD
		public unsafe UTexture2D InputTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_InputTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_InputTexture, value);
			}
		}

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x060164E6 RID: 91366 RVA: 0x0020A1E2 File Offset: 0x002083E2
		// (set) Token: 0x060164E7 RID: 91367 RVA: 0x0020A1F6 File Offset: 0x002083F6
		public unsafe UTextureRenderTarget2D OutputRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_OutputRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_OutputRenderTarget, value);
			}
		}

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x060164E8 RID: 91368 RVA: 0x0020A20B File Offset: 0x0020840B
		// (set) Token: 0x060164E9 RID: 91369 RVA: 0x0020A21F File Offset: 0x0020841F
		public unsafe FVector PlayerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerPos) = value;
			}
		}

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x060164EA RID: 91370 RVA: 0x0020A234 File Offset: 0x00208434
		// (set) Token: 0x060164EB RID: 91371 RVA: 0x0020A248 File Offset: 0x00208448
		public unsafe UStaticMeshComponent TargetMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_TargetMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollision.__PropertyOffset_TargetMesh, value);
			}
		}

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x060164EC RID: 91372 RVA: 0x0020A25D File Offset: 0x0020845D
		// (set) Token: 0x060164ED RID: 91373 RVA: 0x0020A271 File Offset: 0x00208471
		public unsafe FVector PivotPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PivotPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PivotPos) = value;
			}
		}

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x060164EE RID: 91374 RVA: 0x0020A286 File Offset: 0x00208486
		// (set) Token: 0x060164EF RID: 91375 RVA: 0x0020A296 File Offset: 0x00208496
		public unsafe float CollisionRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CollisionRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CollisionRadiusScale) = value;
			}
		}

		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x060164F0 RID: 91376 RVA: 0x0020A2A7 File Offset: 0x002084A7
		// (set) Token: 0x060164F1 RID: 91377 RVA: 0x0020A2B7 File Offset: 0x002084B7
		public unsafe float PlayerPushRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerPushRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerPushRadius) = value;
			}
		}

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x060164F2 RID: 91378 RVA: 0x0020A2C8 File Offset: 0x002084C8
		// (set) Token: 0x060164F3 RID: 91379 RVA: 0x0020A2D8 File Offset: 0x002084D8
		public unsafe float ParticleMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_ParticleMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_ParticleMass) = value;
			}
		}

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x060164F4 RID: 91380 RVA: 0x0020A2E9 File Offset: 0x002084E9
		// (set) Token: 0x060164F5 RID: 91381 RVA: 0x0020A2F9 File Offset: 0x002084F9
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x060164F6 RID: 91382 RVA: 0x0020A30A File Offset: 0x0020850A
		// (set) Token: 0x060164F7 RID: 91383 RVA: 0x0020A31A File Offset: 0x0020851A
		public unsafe float PlayerForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_PlayerForceStrength) = value;
			}
		}

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x060164F8 RID: 91384 RVA: 0x0020A32B File Offset: 0x0020852B
		// (set) Token: 0x060164F9 RID: 91385 RVA: 0x0020A33B File Offset: 0x0020853B
		public unsafe float CollisionForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CollisionForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CollisionForceStrength) = value;
			}
		}

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x060164FA RID: 91386 RVA: 0x0020A34C File Offset: 0x0020854C
		// (set) Token: 0x060164FB RID: 91387 RVA: 0x0020A35C File Offset: 0x0020855C
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x060164FC RID: 91388 RVA: 0x0020A36D File Offset: 0x0020856D
		// (set) Token: 0x060164FD RID: 91389 RVA: 0x0020A37D File Offset: 0x0020857D
		public unsafe float MaxVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxVelocity) = value;
			}
		}

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x060164FE RID: 91390 RVA: 0x0020A38E File Offset: 0x0020858E
		// (set) Token: 0x060164FF RID: 91391 RVA: 0x0020A39E File Offset: 0x0020859E
		public unsafe float BuoyancyStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BuoyancyStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BuoyancyStrength) = value;
			}
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x06016500 RID: 91392 RVA: 0x0020A3AF File Offset: 0x002085AF
		// (set) Token: 0x06016501 RID: 91393 RVA: 0x0020A3BF File Offset: 0x002085BF
		public unsafe float BuoyancyDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BuoyancyDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BuoyancyDamping) = value;
			}
		}

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x06016502 RID: 91394 RVA: 0x0020A3D0 File Offset: 0x002085D0
		// (set) Token: 0x06016503 RID: 91395 RVA: 0x0020A3E0 File Offset: 0x002085E0
		public unsafe float WaveStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_WaveStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_WaveStrength) = value;
			}
		}

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x06016504 RID: 91396 RVA: 0x0020A3F1 File Offset: 0x002085F1
		// (set) Token: 0x06016505 RID: 91397 RVA: 0x0020A401 File Offset: 0x00208601
		public unsafe float WaveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_WaveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_WaveSpeed) = value;
			}
		}

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x06016506 RID: 91398 RVA: 0x0020A412 File Offset: 0x00208612
		// (set) Token: 0x06016507 RID: 91399 RVA: 0x0020A422 File Offset: 0x00208622
		public unsafe float GravityStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_GravityStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_GravityStrength) = value;
			}
		}

		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x06016508 RID: 91400 RVA: 0x0020A433 File Offset: 0x00208633
		// (set) Token: 0x06016509 RID: 91401 RVA: 0x0020A443 File Offset: 0x00208643
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x0601650A RID: 91402 RVA: 0x0020A454 File Offset: 0x00208654
		// (set) Token: 0x0601650B RID: 91403 RVA: 0x0020A464 File Offset: 0x00208664
		public unsafe float MomentOfInertia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MomentOfInertia);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MomentOfInertia) = value;
			}
		}

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x0601650C RID: 91404 RVA: 0x0020A475 File Offset: 0x00208675
		// (set) Token: 0x0601650D RID: 91405 RVA: 0x0020A485 File Offset: 0x00208685
		public unsafe float MaxAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxAngularVelocity) = value;
			}
		}

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x0601650E RID: 91406 RVA: 0x0020A496 File Offset: 0x00208696
		// (set) Token: 0x0601650F RID: 91407 RVA: 0x0020A4A6 File Offset: 0x002086A6
		public unsafe float MaxRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_MaxRotation) = value;
			}
		}

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x06016510 RID: 91408 RVA: 0x0020A4B7 File Offset: 0x002086B7
		// (set) Token: 0x06016511 RID: 91409 RVA: 0x0020A4C7 File Offset: 0x002086C7
		public unsafe float CentrifugalForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CentrifugalForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_CentrifugalForceStrength) = value;
			}
		}

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x06016512 RID: 91410 RVA: 0x0020A4D8 File Offset: 0x002086D8
		// (set) Token: 0x06016513 RID: 91411 RVA: 0x0020A4EC File Offset: 0x002086EC
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollision.__PropertyOffset_BoxExtent) = value;
			}
		}

		// Token: 0x06016514 RID: 91412 RVA: 0x0020A501 File Offset: 0x00208701
		public void StopSimulation()
		{
			AKuroCSSimpleCollision.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016515 RID: 91413 RVA: 0x0020A50E File Offset: 0x0020870E
		public void StartSimulation()
		{
			AKuroCSSimpleCollision.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016516 RID: 91414 RVA: 0x0020A51B File Offset: 0x0020871B
		public void ReleaseShaderManager()
		{
			AKuroCSSimpleCollision.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016517 RID: 91415 RVA: 0x0020A528 File Offset: 0x00208728
		public void InitShaderManager()
		{
			AKuroCSSimpleCollision.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016518 RID: 91416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06016519 RID: 91417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x0601651A RID: 91418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x0601651B RID: 91419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x0601651C RID: 91420 RVA: 0x0020A535 File Offset: 0x00208735
		static AKuroCSSimpleCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSSimpleCollision");
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x0020A543 File Offset: 0x00208743
		protected AKuroCSSimpleCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C210 RID: 49680
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSSimpleCollision";

		// Token: 0x0400C211 RID: 49681
		private static IntPtr _ClassPtr;

		// Token: 0x0400C212 RID: 49682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C213 RID: 49683
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C214 RID: 49684
		internal static int __PropertyOffset_bEnableRendering;

		// Token: 0x0400C215 RID: 49685
		internal static int __PropertyOffset_InputTexture;

		// Token: 0x0400C216 RID: 49686
		internal static int __PropertyOffset_OutputRenderTarget;

		// Token: 0x0400C217 RID: 49687
		internal static int __PropertyOffset_PlayerPos;

		// Token: 0x0400C218 RID: 49688
		internal static int __PropertyOffset_TargetMesh;

		// Token: 0x0400C219 RID: 49689
		internal static int __PropertyOffset_PivotPos;

		// Token: 0x0400C21A RID: 49690
		internal static int __PropertyOffset_CollisionRadiusScale;

		// Token: 0x0400C21B RID: 49691
		internal static int __PropertyOffset_PlayerPushRadius;

		// Token: 0x0400C21C RID: 49692
		internal static int __PropertyOffset_ParticleMass;

		// Token: 0x0400C21D RID: 49693
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400C21E RID: 49694
		internal static int __PropertyOffset_PlayerForceStrength;

		// Token: 0x0400C21F RID: 49695
		internal static int __PropertyOffset_CollisionForceStrength;

		// Token: 0x0400C220 RID: 49696
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x0400C221 RID: 49697
		internal static int __PropertyOffset_MaxVelocity;

		// Token: 0x0400C222 RID: 49698
		internal static int __PropertyOffset_BuoyancyStrength;

		// Token: 0x0400C223 RID: 49699
		internal static int __PropertyOffset_BuoyancyDamping;

		// Token: 0x0400C224 RID: 49700
		internal static int __PropertyOffset_WaveStrength;

		// Token: 0x0400C225 RID: 49701
		internal static int __PropertyOffset_WaveSpeed;

		// Token: 0x0400C226 RID: 49702
		internal static int __PropertyOffset_GravityStrength;

		// Token: 0x0400C227 RID: 49703
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x0400C228 RID: 49704
		internal static int __PropertyOffset_MomentOfInertia;

		// Token: 0x0400C229 RID: 49705
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x0400C22A RID: 49706
		internal static int __PropertyOffset_MaxRotation;

		// Token: 0x0400C22B RID: 49707
		internal static int __PropertyOffset_CentrifugalForceStrength;

		// Token: 0x0400C22C RID: 49708
		internal static int __PropertyOffset_BoxExtent;
	}
}
