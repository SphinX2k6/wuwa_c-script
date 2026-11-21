using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051B RID: 1307
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeVerletComponent")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class URopeVerletComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A2C RID: 31276 RVA: 0x000B35FA File Offset: 0x000B17FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeVerletComponent._ClassPtr;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x000B3608 File Offset: 0x000B1808
		public URopeVerletComponent() : this(BuiltinUtils.AllocNativeUObject(URopeVerletComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x000B3630 File Offset: 0x000B1830
		public URopeVerletComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeVerletComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06007A2F RID: 31279 RVA: 0x000B3663 File Offset: 0x000B1863
		// (set) Token: 0x06007A30 RID: 31280 RVA: 0x000B3673 File Offset: 0x000B1873
		public unsafe int SegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_SegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_SegmentCount) = value;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06007A31 RID: 31281 RVA: 0x000B3684 File Offset: 0x000B1884
		// (set) Token: 0x06007A32 RID: 31282 RVA: 0x000B3698 File Offset: 0x000B1898
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06007A33 RID: 31283 RVA: 0x000B36AD File Offset: 0x000B18AD
		// (set) Token: 0x06007A34 RID: 31284 RVA: 0x000B36BD File Offset: 0x000B18BD
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06007A35 RID: 31285 RVA: 0x000B36CE File Offset: 0x000B18CE
		// (set) Token: 0x06007A36 RID: 31286 RVA: 0x000B36DE File Offset: 0x000B18DE
		public unsafe int ConstraintIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ConstraintIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ConstraintIterations) = value;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06007A37 RID: 31287 RVA: 0x000B36EF File Offset: 0x000B18EF
		// (set) Token: 0x06007A38 RID: 31288 RVA: 0x000B36FF File Offset: 0x000B18FF
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06007A39 RID: 31289 RVA: 0x000B3710 File Offset: 0x000B1910
		// (set) Token: 0x06007A3A RID: 31290 RVA: 0x000B3720 File Offset: 0x000B1920
		public unsafe bool bPinStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06007A3B RID: 31291 RVA: 0x000B3731 File Offset: 0x000B1931
		// (set) Token: 0x06007A3C RID: 31292 RVA: 0x000B3741 File Offset: 0x000B1941
		public unsafe bool bPinEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06007A3D RID: 31293 RVA: 0x000B3752 File Offset: 0x000B1952
		// (set) Token: 0x06007A3E RID: 31294 RVA: 0x000B3762 File Offset: 0x000B1962
		public unsafe bool bEnablePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bEnablePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bEnablePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06007A3F RID: 31295 RVA: 0x000B3773 File Offset: 0x000B1973
		// (set) Token: 0x06007A40 RID: 31296 RVA: 0x000B3783 File Offset: 0x000B1983
		public unsafe float MaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_MaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_MaxTimeStep) = value;
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06007A41 RID: 31297 RVA: 0x000B3794 File Offset: 0x000B1994
		// (set) Token: 0x06007A42 RID: 31298 RVA: 0x000B37A4 File Offset: 0x000B19A4
		public unsafe float VelocityAmplification
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_VelocityAmplification);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_VelocityAmplification) = value;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06007A43 RID: 31299 RVA: 0x000B37B5 File Offset: 0x000B19B5
		// (set) Token: 0x06007A44 RID: 31300 RVA: 0x000B37C5 File Offset: 0x000B19C5
		public unsafe float QuickStabilizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeThreshold) = value;
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06007A45 RID: 31301 RVA: 0x000B37D6 File Offset: 0x000B19D6
		// (set) Token: 0x06007A46 RID: 31302 RVA: 0x000B37E6 File Offset: 0x000B19E6
		public unsafe float QuickStabilizeDampingMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeDampingMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeDampingMultiplier) = value;
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06007A47 RID: 31303 RVA: 0x000B37F7 File Offset: 0x000B19F7
		// (set) Token: 0x06007A48 RID: 31304 RVA: 0x000B3807 File Offset: 0x000B1A07
		public unsafe float TensionPropagation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionPropagation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionPropagation) = value;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06007A49 RID: 31305 RVA: 0x000B3818 File Offset: 0x000B1A18
		// (set) Token: 0x06007A4A RID: 31306 RVA: 0x000B3828 File Offset: 0x000B1A28
		public unsafe float TensionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionStrength) = value;
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06007A4B RID: 31307 RVA: 0x000B3839 File Offset: 0x000B1A39
		// (set) Token: 0x06007A4C RID: 31308 RVA: 0x000B3849 File Offset: 0x000B1A49
		public unsafe bool bRenderChainLinks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bRenderChainLinks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bRenderChainLinks) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06007A4D RID: 31309 RVA: 0x000B385A File Offset: 0x000B1A5A
		// (set) Token: 0x06007A4E RID: 31310 RVA: 0x000B386E File Offset: 0x000B1A6E
		[Nullable(2)]
		public unsafe UStaticMesh ChainLinkMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainLinkMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainLinkMesh, value);
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06007A4F RID: 31311 RVA: 0x000B3883 File Offset: 0x000B1A83
		// (set) Token: 0x06007A50 RID: 31312 RVA: 0x000B3893 File Offset: 0x000B1A93
		public unsafe float ChainLinkSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkSpacing) = value;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06007A51 RID: 31313 RVA: 0x000B38A4 File Offset: 0x000B1AA4
		// (set) Token: 0x06007A52 RID: 31314 RVA: 0x000B38B8 File Offset: 0x000B1AB8
		public unsafe FVector ChainLinkScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkScale) = value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x000B38CD File Offset: 0x000B1ACD
		// (set) Token: 0x06007A54 RID: 31316 RVA: 0x000B38E1 File Offset: 0x000B1AE1
		public unsafe FRotator ChainLinkRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkRotationOffset) = value;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06007A55 RID: 31317 RVA: 0x000B38F6 File Offset: 0x000B1AF6
		// (set) Token: 0x06007A56 RID: 31318 RVA: 0x000B390A File Offset: 0x000B1B0A
		public unsafe FVector ChainLinkPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkPositionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkPositionOffset) = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06007A57 RID: 31319 RVA: 0x000B391F File Offset: 0x000B1B1F
		// (set) Token: 0x06007A58 RID: 31320 RVA: 0x000B392F File Offset: 0x000B1B2F
		public unsafe bool bAlternateLinkRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bAlternateLinkRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bAlternateLinkRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x000B3940 File Offset: 0x000B1B40
		// (set) Token: 0x06007A5A RID: 31322 RVA: 0x000B3950 File Offset: 0x000B1B50
		public unsafe float AlternateLinkRollDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_AlternateLinkRollDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_AlternateLinkRollDegrees) = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06007A5B RID: 31323 RVA: 0x000B3964 File Offset: 0x000B1B64
		// (set) Token: 0x06007A5C RID: 31324 RVA: 0x000B399D File Offset: 0x000B1B9D
		public TArray<float> RestLengths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RestLengths) == null)
				{
					result = (this._RestLengths = new TArray<float>(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_RestLengths, this));
				}
				return result;
			}
			set
			{
				this.RestLengths.CopyAssign(value);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x000B39AB File Offset: 0x000B1BAB
		// (set) Token: 0x06007A5E RID: 31326 RVA: 0x000B39BF File Offset: 0x000B1BBF
		public unsafe FVector ControlledStartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledStartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledStartPosition) = value;
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x000B39D4 File Offset: 0x000B1BD4
		// (set) Token: 0x06007A60 RID: 31328 RVA: 0x000B39E8 File Offset: 0x000B1BE8
		public unsafe FVector ControlledEndPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledEndPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledEndPosition) = value;
			}
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x000B39FD File Offset: 0x000B1BFD
		public void SimulatePhysics(float DeltaTime)
		{
			URopeVerletComponent.__SimulatePhysics_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x000B3A0B File Offset: 0x000B1C0B
		public void SetStartPosition(in FVector WorldPosition)
		{
			URopeVerletComponent.__SetStartPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x000B3A19 File Offset: 0x000B1C19
		public void SetParticlePosition(int ParticleIndex, in FVector WorldPosition)
		{
			URopeVerletComponent.__SetParticlePosition_Internal(base.NativePtr, ParticleIndex, WorldPosition);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x000B3A28 File Offset: 0x000B1C28
		public void SetEndPosition(in FVector WorldPosition)
		{
			URopeVerletComponent.__SetEndPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x000B3A36 File Offset: 0x000B1C36
		public void ResetRope()
		{
			URopeVerletComponent.__ResetRope_Internal(base.NativePtr);
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x000B3A43 File Offset: 0x000B1C43
		public void RefreshChainInstances()
		{
			URopeVerletComponent.__RefreshChainInstances_Internal(base.NativePtr);
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x000B3A50 File Offset: 0x000B1C50
		public void PinParticle(int ParticleIndex, bool bPin = true)
		{
			URopeVerletComponent.__PinParticle_Internal(base.NativePtr, ParticleIndex, bPin);
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x000B3A5F File Offset: 0x000B1C5F
		public void InitializeVerlet()
		{
			URopeVerletComponent.__InitializeVerlet_Internal(base.NativePtr);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x000B3A6C File Offset: 0x000B1C6C
		public FVector GetStartPosition()
		{
			return URopeVerletComponent.__GetStartPosition_Internal(base.NativePtr);
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x000B3A79 File Offset: 0x000B1C79
		public int GetParticleCount()
		{
			return URopeVerletComponent.__GetParticleCount_Internal(base.NativePtr);
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x000B3A86 File Offset: 0x000B1C86
		public FVector GetEndPosition()
		{
			return URopeVerletComponent.__GetEndPosition_Internal(base.NativePtr);
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x000B3A93 File Offset: 0x000B1C93
		[NullableContext(2)]
		public void ApplyDataAsset(URopeVerletDataAsset DataAsset)
		{
			URopeVerletComponent.__ApplyDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007A6D RID: 31341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimulatePhysics_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06007A6E RID: 31342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x06007A6F RID: 31343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParticlePosition_Internal(IntPtr @this, int ParticleIndex, in FVector WorldPosition);

		// Token: 0x06007A70 RID: 31344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x06007A71 RID: 31345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRope_Internal(IntPtr @this);

		// Token: 0x06007A72 RID: 31346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshChainInstances_Internal(IntPtr @this);

		// Token: 0x06007A73 RID: 31347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PinParticle_Internal(IntPtr @this, int ParticleIndex, bool bPin);

		// Token: 0x06007A74 RID: 31348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeVerlet_Internal(IntPtr @this);

		// Token: 0x06007A75 RID: 31349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartPosition_Internal(IntPtr @this);

		// Token: 0x06007A76 RID: 31350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParticleCount_Internal(IntPtr @this);

		// Token: 0x06007A77 RID: 31351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndPosition_Internal(IntPtr @this);

		// Token: 0x06007A78 RID: 31352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x06007A79 RID: 31353 RVA: 0x000B3AB0 File Offset: 0x000B1CB0
		static URopeVerletComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeVerletComponent");
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x000B3ABE File Offset: 0x000B1CBE
		protected URopeVerletComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033F6 RID: 13302
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeVerletComponent";

		// Token: 0x040033F7 RID: 13303
		private static IntPtr _ClassPtr;

		// Token: 0x040033F8 RID: 13304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033F9 RID: 13305
		internal static int __PropertyOffset_SegmentCount;

		// Token: 0x040033FA RID: 13306
		internal static int __PropertyOffset_Gravity;

		// Token: 0x040033FB RID: 13307
		internal static int __PropertyOffset_Damping;

		// Token: 0x040033FC RID: 13308
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x040033FD RID: 13309
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x040033FE RID: 13310
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x040033FF RID: 13311
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x04003400 RID: 13312
		internal static int __PropertyOffset_bEnablePhysics;

		// Token: 0x04003401 RID: 13313
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x04003402 RID: 13314
		internal static int __PropertyOffset_VelocityAmplification;

		// Token: 0x04003403 RID: 13315
		internal static int __PropertyOffset_QuickStabilizeThreshold;

		// Token: 0x04003404 RID: 13316
		internal static int __PropertyOffset_QuickStabilizeDampingMultiplier;

		// Token: 0x04003405 RID: 13317
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x04003406 RID: 13318
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x04003407 RID: 13319
		internal static int __PropertyOffset_bRenderChainLinks;

		// Token: 0x04003408 RID: 13320
		internal static int __PropertyOffset_ChainLinkMesh;

		// Token: 0x04003409 RID: 13321
		internal static int __PropertyOffset_ChainLinkSpacing;

		// Token: 0x0400340A RID: 13322
		internal static int __PropertyOffset_ChainLinkScale;

		// Token: 0x0400340B RID: 13323
		internal static int __PropertyOffset_ChainLinkRotationOffset;

		// Token: 0x0400340C RID: 13324
		internal static int __PropertyOffset_ChainLinkPositionOffset;

		// Token: 0x0400340D RID: 13325
		internal static int __PropertyOffset_bAlternateLinkRotation;

		// Token: 0x0400340E RID: 13326
		internal static int __PropertyOffset_AlternateLinkRollDegrees;

		// Token: 0x0400340F RID: 13327
		internal static int __PropertyOffset_RestLengths;

		// Token: 0x04003410 RID: 13328
		[Nullable(2)]
		private TArray<float> _RestLengths;

		// Token: 0x04003411 RID: 13329
		internal static int __PropertyOffset_ControlledStartPosition;

		// Token: 0x04003412 RID: 13330
		internal static int __PropertyOffset_ControlledEndPosition;
	}
}
