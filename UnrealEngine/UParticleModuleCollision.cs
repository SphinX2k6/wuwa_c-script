using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5D RID: 3933
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleCollision")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UParticleModuleCollision : UParticleModuleCollisionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D45C RID: 54364 RVA: 0x00137EBF File Offset: 0x001360BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleCollision._ClassPtr;
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x00137ECC File Offset: 0x001360CC
		public UParticleModuleCollision() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x00137EF4 File Offset: 0x001360F4
		public UParticleModuleCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600D45F RID: 54367 RVA: 0x00137F28 File Offset: 0x00136128
		// (set) Token: 0x0600D460 RID: 54368 RVA: 0x00137F61 File Offset: 0x00136161
		public FRawDistributionVector DampingFactor
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._DampingFactor) == null)
				{
					result = (this._DampingFactor = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DampingFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DampingFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600D461 RID: 54369 RVA: 0x00137F84 File Offset: 0x00136184
		// (set) Token: 0x0600D462 RID: 54370 RVA: 0x00137FBD File Offset: 0x001361BD
		public FRawDistributionVector DampingFactorRotation
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._DampingFactorRotation) == null)
				{
					result = (this._DampingFactorRotation = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DampingFactorRotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DampingFactorRotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600D463 RID: 54371 RVA: 0x00137FE0 File Offset: 0x001361E0
		// (set) Token: 0x0600D464 RID: 54372 RVA: 0x00138019 File Offset: 0x00136219
		public FRawDistributionFloat MaxCollisions
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._MaxCollisions) == null)
				{
					result = (this._MaxCollisions = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_MaxCollisions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_MaxCollisions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600D465 RID: 54373 RVA: 0x0013803A File Offset: 0x0013623A
		// (set) Token: 0x0600D466 RID: 54374 RVA: 0x0013804E File Offset: 0x0013624E
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleCollisionComplete> CollisionCompletionOption
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_CollisionCompletionOption);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_CollisionCompletionOption) = value;
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600D467 RID: 54375 RVA: 0x00138064 File Offset: 0x00136264
		// (set) Token: 0x0600D468 RID: 54376 RVA: 0x0013809D File Offset: 0x0013629D
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> CollisionTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._CollisionTypes) == null)
				{
					result = (this._CollisionTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_CollisionTypes, this));
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
				this.CollisionTypes.CopyAssign(value);
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600D469 RID: 54377 RVA: 0x001380AB File Offset: 0x001362AB
		// (set) Token: 0x0600D46A RID: 54378 RVA: 0x001380C4 File Offset: 0x001362C4
		public unsafe bool bApplyPhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bApplyPhysics) & UParticleModuleCollision.__PropertyMask_bApplyPhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bApplyPhysics) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bApplyPhysics) & ~UParticleModuleCollision.__PropertyMask_bApplyPhysics) | (value ? UParticleModuleCollision.__PropertyMask_bApplyPhysics : 0));
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600D46B RID: 54379 RVA: 0x001380F4 File Offset: 0x001362F4
		// (set) Token: 0x0600D46C RID: 54380 RVA: 0x0013810D File Offset: 0x0013630D
		public unsafe bool bIgnoreTriggerVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreTriggerVolumes) & UParticleModuleCollision.__PropertyMask_bIgnoreTriggerVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreTriggerVolumes) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreTriggerVolumes) & ~UParticleModuleCollision.__PropertyMask_bIgnoreTriggerVolumes) | (value ? UParticleModuleCollision.__PropertyMask_bIgnoreTriggerVolumes : 0));
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600D46D RID: 54381 RVA: 0x00138140 File Offset: 0x00136340
		// (set) Token: 0x0600D46E RID: 54382 RVA: 0x00138179 File Offset: 0x00136379
		public FRawDistributionFloat ParticleMass
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._ParticleMass) == null)
				{
					result = (this._ParticleMass = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_ParticleMass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_ParticleMass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600D46F RID: 54383 RVA: 0x0013819A File Offset: 0x0013639A
		// (set) Token: 0x0600D470 RID: 54384 RVA: 0x001381AA File Offset: 0x001363AA
		public unsafe float DirScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DirScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DirScalar) = value;
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600D471 RID: 54385 RVA: 0x001381BB File Offset: 0x001363BB
		// (set) Token: 0x0600D472 RID: 54386 RVA: 0x001381D4 File Offset: 0x001363D4
		public unsafe bool bPawnsDoNotDecrementCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bPawnsDoNotDecrementCount) & UParticleModuleCollision.__PropertyMask_bPawnsDoNotDecrementCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bPawnsDoNotDecrementCount) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bPawnsDoNotDecrementCount) & ~UParticleModuleCollision.__PropertyMask_bPawnsDoNotDecrementCount) | (value ? UParticleModuleCollision.__PropertyMask_bPawnsDoNotDecrementCount : 0));
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600D473 RID: 54387 RVA: 0x00138204 File Offset: 0x00136404
		// (set) Token: 0x0600D474 RID: 54388 RVA: 0x0013821D File Offset: 0x0013641D
		public unsafe bool bOnlyVerticalNormalsDecrementCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bOnlyVerticalNormalsDecrementCount) & UParticleModuleCollision.__PropertyMask_bOnlyVerticalNormalsDecrementCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bOnlyVerticalNormalsDecrementCount) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bOnlyVerticalNormalsDecrementCount) & ~UParticleModuleCollision.__PropertyMask_bOnlyVerticalNormalsDecrementCount) | (value ? UParticleModuleCollision.__PropertyMask_bOnlyVerticalNormalsDecrementCount : 0));
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600D475 RID: 54389 RVA: 0x0013824D File Offset: 0x0013644D
		// (set) Token: 0x0600D476 RID: 54390 RVA: 0x0013825D File Offset: 0x0013645D
		public unsafe float VerticalFudgeFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_VerticalFudgeFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_VerticalFudgeFactor) = value;
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600D477 RID: 54391 RVA: 0x00138270 File Offset: 0x00136470
		// (set) Token: 0x0600D478 RID: 54392 RVA: 0x001382A9 File Offset: 0x001364A9
		public FRawDistributionFloat DelayAmount
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._DelayAmount) == null)
				{
					result = (this._DelayAmount = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DelayAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_DelayAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600D479 RID: 54393 RVA: 0x001382CA File Offset: 0x001364CA
		// (set) Token: 0x0600D47A RID: 54394 RVA: 0x001382E3 File Offset: 0x001364E3
		public unsafe bool bDropDetail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bDropDetail) & UParticleModuleCollision.__PropertyMask_bDropDetail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bDropDetail) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bDropDetail) & ~UParticleModuleCollision.__PropertyMask_bDropDetail) | (value ? UParticleModuleCollision.__PropertyMask_bDropDetail : 0));
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600D47B RID: 54395 RVA: 0x00138313 File Offset: 0x00136513
		// (set) Token: 0x0600D47C RID: 54396 RVA: 0x0013832C File Offset: 0x0013652C
		public unsafe bool bCollideOnlyIfVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bCollideOnlyIfVisible) & UParticleModuleCollision.__PropertyMask_bCollideOnlyIfVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bCollideOnlyIfVisible) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bCollideOnlyIfVisible) & ~UParticleModuleCollision.__PropertyMask_bCollideOnlyIfVisible) | (value ? UParticleModuleCollision.__PropertyMask_bCollideOnlyIfVisible : 0));
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600D47D RID: 54397 RVA: 0x0013835C File Offset: 0x0013655C
		// (set) Token: 0x0600D47E RID: 54398 RVA: 0x00138375 File Offset: 0x00136575
		public unsafe bool bIgnoreSourceActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreSourceActor) & UParticleModuleCollision.__PropertyMask_bIgnoreSourceActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreSourceActor) = ((*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_bIgnoreSourceActor) & ~UParticleModuleCollision.__PropertyMask_bIgnoreSourceActor) | (value ? UParticleModuleCollision.__PropertyMask_bIgnoreSourceActor : 0));
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600D47F RID: 54399 RVA: 0x001383A5 File Offset: 0x001365A5
		// (set) Token: 0x0600D480 RID: 54400 RVA: 0x001383B5 File Offset: 0x001365B5
		public unsafe float MaxCollisionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_MaxCollisionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollision.__PropertyOffset_MaxCollisionDistance) = value;
			}
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x001383C6 File Offset: 0x001365C6
		static UParticleModuleCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleCollision");
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x001383D4 File Offset: 0x001365D4
		protected UParticleModuleCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007242 RID: 29250
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleCollision";

		// Token: 0x04007243 RID: 29251
		private static IntPtr _ClassPtr;

		// Token: 0x04007244 RID: 29252
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007245 RID: 29253
		internal static int __PropertyOffset_DampingFactor;

		// Token: 0x04007246 RID: 29254
		[Nullable(2)]
		private FRawDistributionVector _DampingFactor;

		// Token: 0x04007247 RID: 29255
		internal static int __PropertyOffset_DampingFactorRotation;

		// Token: 0x04007248 RID: 29256
		[Nullable(2)]
		private FRawDistributionVector _DampingFactorRotation;

		// Token: 0x04007249 RID: 29257
		internal static int __PropertyOffset_MaxCollisions;

		// Token: 0x0400724A RID: 29258
		[Nullable(2)]
		private FRawDistributionFloat _MaxCollisions;

		// Token: 0x0400724B RID: 29259
		internal static int __PropertyOffset_CollisionCompletionOption;

		// Token: 0x0400724C RID: 29260
		internal static int __PropertyOffset_CollisionTypes;

		// Token: 0x0400724D RID: 29261
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _CollisionTypes;

		// Token: 0x0400724E RID: 29262
		internal static int __PropertyOffset_bApplyPhysics;

		// Token: 0x0400724F RID: 29263
		internal static byte __PropertyMask_bApplyPhysics;

		// Token: 0x04007250 RID: 29264
		internal static int __PropertyOffset_bIgnoreTriggerVolumes;

		// Token: 0x04007251 RID: 29265
		internal static byte __PropertyMask_bIgnoreTriggerVolumes;

		// Token: 0x04007252 RID: 29266
		internal static int __PropertyOffset_ParticleMass;

		// Token: 0x04007253 RID: 29267
		[Nullable(2)]
		private FRawDistributionFloat _ParticleMass;

		// Token: 0x04007254 RID: 29268
		internal static int __PropertyOffset_DirScalar;

		// Token: 0x04007255 RID: 29269
		internal static int __PropertyOffset_bPawnsDoNotDecrementCount;

		// Token: 0x04007256 RID: 29270
		internal static byte __PropertyMask_bPawnsDoNotDecrementCount;

		// Token: 0x04007257 RID: 29271
		internal static int __PropertyOffset_bOnlyVerticalNormalsDecrementCount;

		// Token: 0x04007258 RID: 29272
		internal static byte __PropertyMask_bOnlyVerticalNormalsDecrementCount;

		// Token: 0x04007259 RID: 29273
		internal static int __PropertyOffset_VerticalFudgeFactor;

		// Token: 0x0400725A RID: 29274
		internal static int __PropertyOffset_DelayAmount;

		// Token: 0x0400725B RID: 29275
		[Nullable(2)]
		private FRawDistributionFloat _DelayAmount;

		// Token: 0x0400725C RID: 29276
		internal static int __PropertyOffset_bDropDetail;

		// Token: 0x0400725D RID: 29277
		internal static byte __PropertyMask_bDropDetail;

		// Token: 0x0400725E RID: 29278
		internal static int __PropertyOffset_bCollideOnlyIfVisible;

		// Token: 0x0400725F RID: 29279
		internal static byte __PropertyMask_bCollideOnlyIfVisible;

		// Token: 0x04007260 RID: 29280
		internal static int __PropertyOffset_bIgnoreSourceActor;

		// Token: 0x04007261 RID: 29281
		internal static byte __PropertyMask_bIgnoreSourceActor;

		// Token: 0x04007262 RID: 29282
		internal static int __PropertyOffset_MaxCollisionDistance;
	}
}
