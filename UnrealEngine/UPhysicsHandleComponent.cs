using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE5 RID: 4069
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsHandleComponent")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UPhysicsHandleComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC12 RID: 56338 RVA: 0x00144165 File Offset: 0x00142365
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsHandleComponent._ClassPtr;
		}

		// Token: 0x0600DC13 RID: 56339 RVA: 0x00144174 File Offset: 0x00142374
		public UPhysicsHandleComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsHandleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC14 RID: 56340 RVA: 0x0014419C File Offset: 0x0014239C
		[NullableContext(1)]
		public UPhysicsHandleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsHandleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600DC15 RID: 56341 RVA: 0x001441CF File Offset: 0x001423CF
		// (set) Token: 0x0600DC16 RID: 56342 RVA: 0x001441E3 File Offset: 0x001423E3
		public unsafe UPrimitiveComponent GrabbedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsHandleComponent.__PropertyOffset_GrabbedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsHandleComponent.__PropertyOffset_GrabbedComponent, value);
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600DC17 RID: 56343 RVA: 0x001441F8 File Offset: 0x001423F8
		// (set) Token: 0x0600DC18 RID: 56344 RVA: 0x00144211 File Offset: 0x00142411
		public unsafe bool bSoftAngularConstraint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftAngularConstraint) & UPhysicsHandleComponent.__PropertyMask_bSoftAngularConstraint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftAngularConstraint) = ((*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftAngularConstraint) & ~UPhysicsHandleComponent.__PropertyMask_bSoftAngularConstraint) | (value ? UPhysicsHandleComponent.__PropertyMask_bSoftAngularConstraint : 0));
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600DC19 RID: 56345 RVA: 0x00144241 File Offset: 0x00142441
		// (set) Token: 0x0600DC1A RID: 56346 RVA: 0x0014425A File Offset: 0x0014245A
		public unsafe bool bSoftLinearConstraint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftLinearConstraint) & UPhysicsHandleComponent.__PropertyMask_bSoftLinearConstraint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftLinearConstraint) = ((*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bSoftLinearConstraint) & ~UPhysicsHandleComponent.__PropertyMask_bSoftLinearConstraint) | (value ? UPhysicsHandleComponent.__PropertyMask_bSoftLinearConstraint : 0));
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600DC1B RID: 56347 RVA: 0x0014428A File Offset: 0x0014248A
		// (set) Token: 0x0600DC1C RID: 56348 RVA: 0x001442A3 File Offset: 0x001424A3
		public unsafe bool bInterpolateTarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bInterpolateTarget) & UPhysicsHandleComponent.__PropertyMask_bInterpolateTarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bInterpolateTarget) = ((*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_bInterpolateTarget) & ~UPhysicsHandleComponent.__PropertyMask_bInterpolateTarget) | (value ? UPhysicsHandleComponent.__PropertyMask_bInterpolateTarget : 0));
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600DC1D RID: 56349 RVA: 0x001442D3 File Offset: 0x001424D3
		// (set) Token: 0x0600DC1E RID: 56350 RVA: 0x001442E3 File Offset: 0x001424E3
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600DC1F RID: 56351 RVA: 0x001442F4 File Offset: 0x001424F4
		// (set) Token: 0x0600DC20 RID: 56352 RVA: 0x00144304 File Offset: 0x00142504
		public unsafe float LinearStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_LinearStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_LinearStiffness) = value;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x00144315 File Offset: 0x00142515
		// (set) Token: 0x0600DC22 RID: 56354 RVA: 0x00144325 File Offset: 0x00142525
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600DC23 RID: 56355 RVA: 0x00144336 File Offset: 0x00142536
		// (set) Token: 0x0600DC24 RID: 56356 RVA: 0x00144346 File Offset: 0x00142546
		public unsafe float AngularStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_AngularStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_AngularStiffness) = value;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600DC25 RID: 56357 RVA: 0x00144357 File Offset: 0x00142557
		// (set) Token: 0x0600DC26 RID: 56358 RVA: 0x00144367 File Offset: 0x00142567
		public unsafe float InterpolationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_InterpolationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsHandleComponent.__PropertyOffset_InterpolationSpeed) = value;
			}
		}

		// Token: 0x0600DC27 RID: 56359 RVA: 0x00144378 File Offset: 0x00142578
		public void SetTargetRotation(FRotator NewRotation)
		{
			UPhysicsHandleComponent.__SetTargetRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x00144386 File Offset: 0x00142586
		public void SetTargetLocationAndRotation(FVector NewLocation, FRotator NewRotation)
		{
			UPhysicsHandleComponent.__SetTargetLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x0600DC29 RID: 56361 RVA: 0x00144395 File Offset: 0x00142595
		public void SetTargetLocation(FVector NewLocation)
		{
			UPhysicsHandleComponent.__SetTargetLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x0600DC2A RID: 56362 RVA: 0x001443A3 File Offset: 0x001425A3
		public void SetLinearStiffness(float NewLinearStiffness)
		{
			UPhysicsHandleComponent.__SetLinearStiffness_Internal(base.NativePtr, NewLinearStiffness);
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x001443B1 File Offset: 0x001425B1
		public void SetLinearDamping(float NewLinearDamping)
		{
			UPhysicsHandleComponent.__SetLinearDamping_Internal(base.NativePtr, NewLinearDamping);
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x001443BF File Offset: 0x001425BF
		public void SetInterpolationSpeed(float NewInterpolationSpeed)
		{
			UPhysicsHandleComponent.__SetInterpolationSpeed_Internal(base.NativePtr, NewInterpolationSpeed);
		}

		// Token: 0x0600DC2D RID: 56365 RVA: 0x001443CD File Offset: 0x001425CD
		public void SetAngularStiffness(float NewAngularStiffness)
		{
			UPhysicsHandleComponent.__SetAngularStiffness_Internal(base.NativePtr, NewAngularStiffness);
		}

		// Token: 0x0600DC2E RID: 56366 RVA: 0x001443DB File Offset: 0x001425DB
		public void SetAngularDamping(float NewAngularDamping)
		{
			UPhysicsHandleComponent.__SetAngularDamping_Internal(base.NativePtr, NewAngularDamping);
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x001443E9 File Offset: 0x001425E9
		public void ReleaseComponent()
		{
			UPhysicsHandleComponent.__ReleaseComponent_Internal(base.NativePtr);
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x001443F6 File Offset: 0x001425F6
		public void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component, FName InBoneName, FVector Location, FRotator Rotation)
		{
			UPhysicsHandleComponent.__GrabComponentAtLocationWithRotation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, Location, Rotation);
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x00144417 File Offset: 0x00142617
		public void GrabComponentAtLocation(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation)
		{
			UPhysicsHandleComponent.__GrabComponentAtLocation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, GrabLocation);
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x00144436 File Offset: 0x00142636
		public void GrabComponent(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation, bool bConstrainRotation)
		{
			UPhysicsHandleComponent.__GrabComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, GrabLocation, bConstrainRotation);
		}

		// Token: 0x0600DC33 RID: 56371 RVA: 0x00144458 File Offset: 0x00142658
		public unsafe void GetTargetLocationAndRotation(ref FVector TargetLocation, ref FRotator TargetRotation)
		{
			fixed (FVector* ptr = &TargetLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &TargetRotation)
				{
					void* ptr4 = (void*)ptr3;
					UPhysicsHandleComponent.__GetTargetLocationAndRotation_Internal(base.NativePtr, ref TargetLocation, ref TargetRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x00144482 File Offset: 0x00142682
		public UPrimitiveComponent GetGrabbedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UPhysicsHandleComponent.__GetGrabbedComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600DC35 RID: 56373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetRotation_Internal(IntPtr @this, FRotator NewRotation);

		// Token: 0x0600DC36 RID: 56374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation);

		// Token: 0x0600DC37 RID: 56375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetLocation_Internal(IntPtr @this, FVector NewLocation);

		// Token: 0x0600DC38 RID: 56376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearStiffness_Internal(IntPtr @this, float NewLinearStiffness);

		// Token: 0x0600DC39 RID: 56377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDamping_Internal(IntPtr @this, float NewLinearDamping);

		// Token: 0x0600DC3A RID: 56378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInterpolationSpeed_Internal(IntPtr @this, float NewInterpolationSpeed);

		// Token: 0x0600DC3B RID: 56379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularStiffness_Internal(IntPtr @this, float NewAngularStiffness);

		// Token: 0x0600DC3C RID: 56380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDamping_Internal(IntPtr @this, float NewAngularDamping);

		// Token: 0x0600DC3D RID: 56381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseComponent_Internal(IntPtr @this);

		// Token: 0x0600DC3E RID: 56382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponentAtLocationWithRotation_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector Location, FRotator Rotation);

		// Token: 0x0600DC3F RID: 56383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponentAtLocation_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector GrabLocation);

		// Token: 0x0600DC40 RID: 56384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponent_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector GrabLocation, bool bConstrainRotation);

		// Token: 0x0600DC41 RID: 56385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTargetLocationAndRotation_Internal(IntPtr @this, ref FVector TargetLocation, ref FRotator TargetRotation);

		// Token: 0x0600DC42 RID: 56386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrabbedComponent_Internal(IntPtr @this);

		// Token: 0x0600DC43 RID: 56387 RVA: 0x00144494 File Offset: 0x00142694
		static UPhysicsHandleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsHandleComponent");
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x001444A2 File Offset: 0x001426A2
		protected UPhysicsHandleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076F4 RID: 30452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsHandleComponent";

		// Token: 0x040076F5 RID: 30453
		private static IntPtr _ClassPtr;

		// Token: 0x040076F6 RID: 30454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076F7 RID: 30455
		internal static int __PropertyOffset_GrabbedComponent;

		// Token: 0x040076F8 RID: 30456
		internal static int __PropertyOffset_bSoftAngularConstraint;

		// Token: 0x040076F9 RID: 30457
		internal static byte __PropertyMask_bSoftAngularConstraint;

		// Token: 0x040076FA RID: 30458
		internal static int __PropertyOffset_bSoftLinearConstraint;

		// Token: 0x040076FB RID: 30459
		internal static byte __PropertyMask_bSoftLinearConstraint;

		// Token: 0x040076FC RID: 30460
		internal static int __PropertyOffset_bInterpolateTarget;

		// Token: 0x040076FD RID: 30461
		internal static byte __PropertyMask_bInterpolateTarget;

		// Token: 0x040076FE RID: 30462
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x040076FF RID: 30463
		internal static int __PropertyOffset_LinearStiffness;

		// Token: 0x04007700 RID: 30464
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x04007701 RID: 30465
		internal static int __PropertyOffset_AngularStiffness;

		// Token: 0x04007702 RID: 30466
		internal static int __PropertyOffset_InterpolationSpeed;
	}
}
