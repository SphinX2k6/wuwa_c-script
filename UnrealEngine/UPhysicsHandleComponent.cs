using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025F RID: 607
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsHandleComponent")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UPhysicsHandleComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003401 RID: 13313 RVA: 0x0004A306 File Offset: 0x00048506
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsHandleComponent._ClassPtr;
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0004A314 File Offset: 0x00048514
		public UPhysicsHandleComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsHandleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0004A33C File Offset: 0x0004853C
		[NullableContext(1)]
		public UPhysicsHandleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsHandleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x0004A36F File Offset: 0x0004856F
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0004A383 File Offset: 0x00048583
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x0004A398 File Offset: 0x00048598
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x0004A3B1 File Offset: 0x000485B1
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x0004A3E1 File Offset: 0x000485E1
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x0004A3FA File Offset: 0x000485FA
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

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x0004A42A File Offset: 0x0004862A
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x0004A443 File Offset: 0x00048643
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

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x0004A473 File Offset: 0x00048673
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x0004A483 File Offset: 0x00048683
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x0004A494 File Offset: 0x00048694
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x0004A4A4 File Offset: 0x000486A4
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

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x0004A4B5 File Offset: 0x000486B5
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x0004A4C5 File Offset: 0x000486C5
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

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x0004A4D6 File Offset: 0x000486D6
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x0004A4E6 File Offset: 0x000486E6
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x0004A4F7 File Offset: 0x000486F7
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x0004A507 File Offset: 0x00048707
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

		// Token: 0x06003416 RID: 13334 RVA: 0x0004A518 File Offset: 0x00048718
		public void SetTargetRotation(FRotator NewRotation)
		{
			UPhysicsHandleComponent.__SetTargetRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0004A526 File Offset: 0x00048726
		public void SetTargetLocationAndRotation(FVector NewLocation, FRotator NewRotation)
		{
			UPhysicsHandleComponent.__SetTargetLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0004A535 File Offset: 0x00048735
		public void SetTargetLocation(FVector NewLocation)
		{
			UPhysicsHandleComponent.__SetTargetLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x0004A543 File Offset: 0x00048743
		public void SetLinearStiffness(float NewLinearStiffness)
		{
			UPhysicsHandleComponent.__SetLinearStiffness_Internal(base.NativePtr, NewLinearStiffness);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0004A551 File Offset: 0x00048751
		public void SetLinearDamping(float NewLinearDamping)
		{
			UPhysicsHandleComponent.__SetLinearDamping_Internal(base.NativePtr, NewLinearDamping);
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x0004A55F File Offset: 0x0004875F
		public void SetInterpolationSpeed(float NewInterpolationSpeed)
		{
			UPhysicsHandleComponent.__SetInterpolationSpeed_Internal(base.NativePtr, NewInterpolationSpeed);
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x0004A56D File Offset: 0x0004876D
		public void SetAngularStiffness(float NewAngularStiffness)
		{
			UPhysicsHandleComponent.__SetAngularStiffness_Internal(base.NativePtr, NewAngularStiffness);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x0004A57B File Offset: 0x0004877B
		public void SetAngularDamping(float NewAngularDamping)
		{
			UPhysicsHandleComponent.__SetAngularDamping_Internal(base.NativePtr, NewAngularDamping);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0004A589 File Offset: 0x00048789
		public void ReleaseComponent()
		{
			UPhysicsHandleComponent.__ReleaseComponent_Internal(base.NativePtr);
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x0004A596 File Offset: 0x00048796
		public void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component, FName InBoneName, FVector Location, FRotator Rotation)
		{
			UPhysicsHandleComponent.__GrabComponentAtLocationWithRotation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, Location, Rotation);
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0004A5B7 File Offset: 0x000487B7
		public void GrabComponentAtLocation(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation)
		{
			UPhysicsHandleComponent.__GrabComponentAtLocation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, GrabLocation);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0004A5D6 File Offset: 0x000487D6
		public void GrabComponent(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation, bool bConstrainRotation)
		{
			UPhysicsHandleComponent.__GrabComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, InBoneName, GrabLocation, bConstrainRotation);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0004A5F8 File Offset: 0x000487F8
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

		// Token: 0x06003423 RID: 13347 RVA: 0x0004A622 File Offset: 0x00048822
		public UPrimitiveComponent GetGrabbedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UPhysicsHandleComponent.__GetGrabbedComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003424 RID: 13348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetRotation_Internal(IntPtr @this, FRotator NewRotation);

		// Token: 0x06003425 RID: 13349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation);

		// Token: 0x06003426 RID: 13350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetLocation_Internal(IntPtr @this, FVector NewLocation);

		// Token: 0x06003427 RID: 13351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearStiffness_Internal(IntPtr @this, float NewLinearStiffness);

		// Token: 0x06003428 RID: 13352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDamping_Internal(IntPtr @this, float NewLinearDamping);

		// Token: 0x06003429 RID: 13353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInterpolationSpeed_Internal(IntPtr @this, float NewInterpolationSpeed);

		// Token: 0x0600342A RID: 13354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularStiffness_Internal(IntPtr @this, float NewAngularStiffness);

		// Token: 0x0600342B RID: 13355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDamping_Internal(IntPtr @this, float NewAngularDamping);

		// Token: 0x0600342C RID: 13356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseComponent_Internal(IntPtr @this);

		// Token: 0x0600342D RID: 13357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponentAtLocationWithRotation_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector Location, FRotator Rotation);

		// Token: 0x0600342E RID: 13358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponentAtLocation_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector GrabLocation);

		// Token: 0x0600342F RID: 13359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GrabComponent_Internal(IntPtr @this, IntPtr Component, FName InBoneName, FVector GrabLocation, bool bConstrainRotation);

		// Token: 0x06003430 RID: 13360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTargetLocationAndRotation_Internal(IntPtr @this, ref FVector TargetLocation, ref FRotator TargetRotation);

		// Token: 0x06003431 RID: 13361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrabbedComponent_Internal(IntPtr @this);

		// Token: 0x06003432 RID: 13362 RVA: 0x0004A634 File Offset: 0x00048834
		static UPhysicsHandleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsHandleComponent");
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x0004A642 File Offset: 0x00048842
		protected UPhysicsHandleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001209 RID: 4617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsHandleComponent";

		// Token: 0x0400120A RID: 4618
		private static IntPtr _ClassPtr;

		// Token: 0x0400120B RID: 4619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400120C RID: 4620
		internal static int __PropertyOffset_GrabbedComponent;

		// Token: 0x0400120D RID: 4621
		internal static int __PropertyOffset_bSoftAngularConstraint;

		// Token: 0x0400120E RID: 4622
		internal static byte __PropertyMask_bSoftAngularConstraint;

		// Token: 0x0400120F RID: 4623
		internal static int __PropertyOffset_bSoftLinearConstraint;

		// Token: 0x04001210 RID: 4624
		internal static byte __PropertyMask_bSoftLinearConstraint;

		// Token: 0x04001211 RID: 4625
		internal static int __PropertyOffset_bInterpolateTarget;

		// Token: 0x04001212 RID: 4626
		internal static byte __PropertyMask_bInterpolateTarget;

		// Token: 0x04001213 RID: 4627
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x04001214 RID: 4628
		internal static int __PropertyOffset_LinearStiffness;

		// Token: 0x04001215 RID: 4629
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x04001216 RID: 4630
		internal static int __PropertyOffset_AngularStiffness;

		// Token: 0x04001217 RID: 4631
		internal static int __PropertyOffset_InterpolationSpeed;
	}
}
