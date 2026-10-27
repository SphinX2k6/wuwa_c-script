using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001784 RID: 6020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainAsset")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UJacobiChainAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015A13 RID: 88595 RVA: 0x001FCE27 File Offset: 0x001FB027
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJacobiChainAsset._ClassPtr;
		}

		// Token: 0x06015A14 RID: 88596 RVA: 0x001FCE34 File Offset: 0x001FB034
		public UJacobiChainAsset() : this(BuiltinUtils.AllocNativeUObject(UJacobiChainAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015A15 RID: 88597 RVA: 0x001FCE5C File Offset: 0x001FB05C
		public UJacobiChainAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJacobiChainAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x06015A16 RID: 88598 RVA: 0x001FCE8F File Offset: 0x001FB08F
		// (set) Token: 0x06015A17 RID: 88599 RVA: 0x001FCE9F File Offset: 0x001FB09F
		public unsafe int FormatVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_FormatVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_FormatVersion) = value;
			}
		}

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x06015A18 RID: 88600 RVA: 0x001FCEB0 File Offset: 0x001FB0B0
		// (set) Token: 0x06015A19 RID: 88601 RVA: 0x001FCEC4 File Offset: 0x001FB0C4
		public unsafe string SourceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJacobiChainAsset.__PropertyOffset_SourceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJacobiChainAsset.__PropertyOffset_SourceName)), value);
			}
		}

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x06015A1A RID: 88602 RVA: 0x001FCED9 File Offset: 0x001FB0D9
		// (set) Token: 0x06015A1B RID: 88603 RVA: 0x001FCEED File Offset: 0x001FB0ED
		public unsafe string SourceSignature
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJacobiChainAsset.__PropertyOffset_SourceSignature)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJacobiChainAsset.__PropertyOffset_SourceSignature)), value);
			}
		}

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x06015A1C RID: 88604 RVA: 0x001FCF02 File Offset: 0x001FB102
		// (set) Token: 0x06015A1D RID: 88605 RVA: 0x001FCF16 File Offset: 0x001FB116
		public unsafe FVector SourceBoundsMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SourceBoundsMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SourceBoundsMin) = value;
			}
		}

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x06015A1E RID: 88606 RVA: 0x001FCF2B File Offset: 0x001FB12B
		// (set) Token: 0x06015A1F RID: 88607 RVA: 0x001FCF3F File Offset: 0x001FB13F
		public unsafe FVector SourceBoundsMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SourceBoundsMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SourceBoundsMax) = value;
			}
		}

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x06015A20 RID: 88608 RVA: 0x001FCF54 File Offset: 0x001FB154
		// (set) Token: 0x06015A21 RID: 88609 RVA: 0x001FCF64 File Offset: 0x001FB164
		public unsafe float FixedDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_FixedDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_FixedDeltaTime) = value;
			}
		}

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x06015A22 RID: 88610 RVA: 0x001FCF75 File Offset: 0x001FB175
		// (set) Token: 0x06015A23 RID: 88611 RVA: 0x001FCF85 File Offset: 0x001FB185
		public unsafe int Substeps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Substeps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Substeps) = value;
			}
		}

		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x06015A24 RID: 88612 RVA: 0x001FCF96 File Offset: 0x001FB196
		// (set) Token: 0x06015A25 RID: 88613 RVA: 0x001FCFA6 File Offset: 0x001FB1A6
		public unsafe int SolverIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SolverIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_SolverIterations) = value;
			}
		}

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x06015A26 RID: 88614 RVA: 0x001FCFB7 File Offset: 0x001FB1B7
		// (set) Token: 0x06015A27 RID: 88615 RVA: 0x001FCFCB File Offset: 0x001FB1CB
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x06015A28 RID: 88616 RVA: 0x001FCFE0 File Offset: 0x001FB1E0
		// (set) Token: 0x06015A29 RID: 88617 RVA: 0x001FCFF0 File Offset: 0x001FB1F0
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x06015A2A RID: 88618 RVA: 0x001FD001 File Offset: 0x001FB201
		// (set) Token: 0x06015A2B RID: 88619 RVA: 0x001FD011 File Offset: 0x001FB211
		public unsafe float VelocityDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_VelocityDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_VelocityDamping) = value;
			}
		}

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x06015A2C RID: 88620 RVA: 0x001FD024 File Offset: 0x001FB224
		// (set) Token: 0x06015A2D RID: 88621 RVA: 0x001FD05D File Offset: 0x001FB25D
		public TArray<FJacobiChainProperty> Properties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainProperty> result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new TArray<FJacobiChainProperty>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Properties, this));
				}
				return result;
			}
			set
			{
				this.Properties.CopyAssign(value);
			}
		}

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x06015A2E RID: 88622 RVA: 0x001FD06C File Offset: 0x001FB26C
		// (set) Token: 0x06015A2F RID: 88623 RVA: 0x001FD0A5 File Offset: 0x001FB2A5
		public TArray<FJacobiChainParticle> Particles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainParticle> result;
				if ((result = this._Particles) == null)
				{
					result = (this._Particles = new TArray<FJacobiChainParticle>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Particles, this));
				}
				return result;
			}
			set
			{
				this.Particles.CopyAssign(value);
			}
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x06015A30 RID: 88624 RVA: 0x001FD0B4 File Offset: 0x001FB2B4
		// (set) Token: 0x06015A31 RID: 88625 RVA: 0x001FD0ED File Offset: 0x001FB2ED
		public TArray<FJacobiChainDistanceConstraint> DistanceConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainDistanceConstraint> result;
				if ((result = this._DistanceConstraints) == null)
				{
					result = (this._DistanceConstraints = new TArray<FJacobiChainDistanceConstraint>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_DistanceConstraints, this));
				}
				return result;
			}
			set
			{
				this.DistanceConstraints.CopyAssign(value);
			}
		}

		// Token: 0x1700557B RID: 21883
		// (get) Token: 0x06015A32 RID: 88626 RVA: 0x001FD0FC File Offset: 0x001FB2FC
		// (set) Token: 0x06015A33 RID: 88627 RVA: 0x001FD135 File Offset: 0x001FB335
		public TArray<FJacobiChainAttachment> Attachments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainAttachment> result;
				if ((result = this._Attachments) == null)
				{
					result = (this._Attachments = new TArray<FJacobiChainAttachment>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_Attachments, this));
				}
				return result;
			}
			set
			{
				this.Attachments.CopyAssign(value);
			}
		}

		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x06015A34 RID: 88628 RVA: 0x001FD144 File Offset: 0x001FB344
		// (set) Token: 0x06015A35 RID: 88629 RVA: 0x001FD17D File Offset: 0x001FB37D
		public TArray<FJacobiChainRigidBody> RigidBodies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainRigidBody> result;
				if ((result = this._RigidBodies) == null)
				{
					result = (this._RigidBodies = new TArray<FJacobiChainRigidBody>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_RigidBodies, this));
				}
				return result;
			}
			set
			{
				this.RigidBodies.CopyAssign(value);
			}
		}

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x06015A36 RID: 88630 RVA: 0x001FD18C File Offset: 0x001FB38C
		// (set) Token: 0x06015A37 RID: 88631 RVA: 0x001FD1C5 File Offset: 0x001FB3C5
		public TArray<FJacobiChainStaticCollider> StaticColliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainStaticCollider> result;
				if ((result = this._StaticColliders) == null)
				{
					result = (this._StaticColliders = new TArray<FJacobiChainStaticCollider>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_StaticColliders, this));
				}
				return result;
			}
			set
			{
				this.StaticColliders.CopyAssign(value);
			}
		}

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x06015A38 RID: 88632 RVA: 0x001FD1D4 File Offset: 0x001FB3D4
		// (set) Token: 0x06015A39 RID: 88633 RVA: 0x001FD20D File Offset: 0x001FB40D
		public TArray<FJacobiChainVertexBinding> VertexBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainVertexBinding> result;
				if ((result = this._VertexBindings) == null)
				{
					result = (this._VertexBindings = new TArray<FJacobiChainVertexBinding>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_VertexBindings, this));
				}
				return result;
			}
			set
			{
				this.VertexBindings.CopyAssign(value);
			}
		}

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x06015A3A RID: 88634 RVA: 0x001FD21B File Offset: 0x001FB41B
		// (set) Token: 0x06015A3B RID: 88635 RVA: 0x001FD22B File Offset: 0x001FB42B
		public unsafe bool bHasOfflineWindAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_bHasOfflineWindAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_bHasOfflineWindAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x06015A3C RID: 88636 RVA: 0x001FD23C File Offset: 0x001FB43C
		// (set) Token: 0x06015A3D RID: 88637 RVA: 0x001FD24C File Offset: 0x001FB44C
		public unsafe float OfflineWindFramesPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindFramesPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindFramesPerSecond) = value;
			}
		}

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x06015A3E RID: 88638 RVA: 0x001FD25D File Offset: 0x001FB45D
		// (set) Token: 0x06015A3F RID: 88639 RVA: 0x001FD26D File Offset: 0x001FB46D
		public unsafe float OfflineWindDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindDuration) = value;
			}
		}

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x06015A40 RID: 88640 RVA: 0x001FD27E File Offset: 0x001FB47E
		// (set) Token: 0x06015A41 RID: 88641 RVA: 0x001FD28E File Offset: 0x001FB48E
		public unsafe int OfflineWindParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindParticleCount) = value;
			}
		}

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x06015A42 RID: 88642 RVA: 0x001FD2A0 File Offset: 0x001FB4A0
		// (set) Token: 0x06015A43 RID: 88643 RVA: 0x001FD2D9 File Offset: 0x001FB4D9
		public TArray<int> OfflineWindRigidParticleIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._OfflineWindRigidParticleIndices) == null)
				{
					result = (this._OfflineWindRigidParticleIndices = new TArray<int>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindRigidParticleIndices, this));
				}
				return result;
			}
			set
			{
				this.OfflineWindRigidParticleIndices.CopyAssign(value);
			}
		}

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x06015A44 RID: 88644 RVA: 0x001FD2E8 File Offset: 0x001FB4E8
		// (set) Token: 0x06015A45 RID: 88645 RVA: 0x001FD321 File Offset: 0x001FB521
		public TArray<FJacobiChainOfflineWindFrame> OfflineWindFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainOfflineWindFrame> result;
				if ((result = this._OfflineWindFrames) == null)
				{
					result = (this._OfflineWindFrames = new TArray<FJacobiChainOfflineWindFrame>(base.NativePtr + (IntPtr)UJacobiChainAsset.__PropertyOffset_OfflineWindFrames, this));
				}
				return result;
			}
			set
			{
				this.OfflineWindFrames.CopyAssign(value);
			}
		}

		// Token: 0x06015A46 RID: 88646 RVA: 0x001FD32F File Offset: 0x001FB52F
		static UJacobiChainAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.JacobiChainAsset");
		}

		// Token: 0x06015A47 RID: 88647 RVA: 0x001FD33D File Offset: 0x001FB53D
		protected UJacobiChainAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BCFF RID: 48383
		public new const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainAsset";

		// Token: 0x0400BD00 RID: 48384
		private static IntPtr _ClassPtr;

		// Token: 0x0400BD01 RID: 48385
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BD02 RID: 48386
		internal static int __PropertyOffset_FormatVersion;

		// Token: 0x0400BD03 RID: 48387
		internal static int __PropertyOffset_SourceName;

		// Token: 0x0400BD04 RID: 48388
		internal static int __PropertyOffset_SourceSignature;

		// Token: 0x0400BD05 RID: 48389
		internal static int __PropertyOffset_SourceBoundsMin;

		// Token: 0x0400BD06 RID: 48390
		internal static int __PropertyOffset_SourceBoundsMax;

		// Token: 0x0400BD07 RID: 48391
		internal static int __PropertyOffset_FixedDeltaTime;

		// Token: 0x0400BD08 RID: 48392
		internal static int __PropertyOffset_Substeps;

		// Token: 0x0400BD09 RID: 48393
		internal static int __PropertyOffset_SolverIterations;

		// Token: 0x0400BD0A RID: 48394
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BD0B RID: 48395
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400BD0C RID: 48396
		internal static int __PropertyOffset_VelocityDamping;

		// Token: 0x0400BD0D RID: 48397
		internal static int __PropertyOffset_Properties;

		// Token: 0x0400BD0E RID: 48398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainProperty> _Properties;

		// Token: 0x0400BD0F RID: 48399
		internal static int __PropertyOffset_Particles;

		// Token: 0x0400BD10 RID: 48400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainParticle> _Particles;

		// Token: 0x0400BD11 RID: 48401
		internal static int __PropertyOffset_DistanceConstraints;

		// Token: 0x0400BD12 RID: 48402
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainDistanceConstraint> _DistanceConstraints;

		// Token: 0x0400BD13 RID: 48403
		internal static int __PropertyOffset_Attachments;

		// Token: 0x0400BD14 RID: 48404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainAttachment> _Attachments;

		// Token: 0x0400BD15 RID: 48405
		internal static int __PropertyOffset_RigidBodies;

		// Token: 0x0400BD16 RID: 48406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainRigidBody> _RigidBodies;

		// Token: 0x0400BD17 RID: 48407
		internal static int __PropertyOffset_StaticColliders;

		// Token: 0x0400BD18 RID: 48408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainStaticCollider> _StaticColliders;

		// Token: 0x0400BD19 RID: 48409
		internal static int __PropertyOffset_VertexBindings;

		// Token: 0x0400BD1A RID: 48410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainVertexBinding> _VertexBindings;

		// Token: 0x0400BD1B RID: 48411
		internal static int __PropertyOffset_bHasOfflineWindAnimation;

		// Token: 0x0400BD1C RID: 48412
		internal static int __PropertyOffset_OfflineWindFramesPerSecond;

		// Token: 0x0400BD1D RID: 48413
		internal static int __PropertyOffset_OfflineWindDuration;

		// Token: 0x0400BD1E RID: 48414
		internal static int __PropertyOffset_OfflineWindParticleCount;

		// Token: 0x0400BD1F RID: 48415
		internal static int __PropertyOffset_OfflineWindRigidParticleIndices;

		// Token: 0x0400BD20 RID: 48416
		[Nullable(2)]
		private TArray<int> _OfflineWindRigidParticleIndices;

		// Token: 0x0400BD21 RID: 48417
		internal static int __PropertyOffset_OfflineWindFrames;

		// Token: 0x0400BD22 RID: 48418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainOfflineWindFrame> _OfflineWindFrames;
	}
}
