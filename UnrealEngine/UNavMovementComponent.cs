using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024A RID: 586
	[UnrealObjectPath("/Script/Engine.NavMovementComponent")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public abstract class UNavMovementComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003289 RID: 12937 RVA: 0x000481F4 File Offset: 0x000463F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMovementComponent._ClassPtr;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x00048200 File Offset: 0x00046400
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x00048210 File Offset: 0x00046410
		public unsafe float FixedPathBrakingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_FixedPathBrakingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_FixedPathBrakingDistance) = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x00048221 File Offset: 0x00046421
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x0004823A File Offset: 0x0004643A
		public unsafe bool bUpdateNavAgentWithOwnersCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUpdateNavAgentWithOwnersCollision) & UNavMovementComponent.__PropertyMask_bUpdateNavAgentWithOwnersCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUpdateNavAgentWithOwnersCollision) = ((*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUpdateNavAgentWithOwnersCollision) & ~UNavMovementComponent.__PropertyMask_bUpdateNavAgentWithOwnersCollision) | (value ? UNavMovementComponent.__PropertyMask_bUpdateNavAgentWithOwnersCollision : 0));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x0004826A File Offset: 0x0004646A
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x00048283 File Offset: 0x00046483
		public unsafe bool bUseAccelerationForPaths
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseAccelerationForPaths) & UNavMovementComponent.__PropertyMask_bUseAccelerationForPaths) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseAccelerationForPaths) = ((*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseAccelerationForPaths) & ~UNavMovementComponent.__PropertyMask_bUseAccelerationForPaths) | (value ? UNavMovementComponent.__PropertyMask_bUseAccelerationForPaths : 0));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x000482B3 File Offset: 0x000464B3
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x000482CC File Offset: 0x000464CC
		public unsafe bool bUseFixedBrakingDistanceForPaths
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseFixedBrakingDistanceForPaths) & UNavMovementComponent.__PropertyMask_bUseFixedBrakingDistanceForPaths) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseFixedBrakingDistanceForPaths) = ((*(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_bUseFixedBrakingDistanceForPaths) & ~UNavMovementComponent.__PropertyMask_bUseFixedBrakingDistanceForPaths) | (value ? UNavMovementComponent.__PropertyMask_bUseFixedBrakingDistanceForPaths : 0));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000482FC File Offset: 0x000464FC
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x00048310 File Offset: 0x00046510
		[Nullable(2)]
		public unsafe UObject PathFollowingComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UNavMovementComponent.__PropertyOffset_PathFollowingComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavMovementComponent.__PropertyOffset_PathFollowingComp, value);
			}
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00048325 File Offset: 0x00046525
		public void StopMovementKeepPathing()
		{
			UNavMovementComponent.__StopMovementKeepPathing_Internal(base.NativePtr);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00048332 File Offset: 0x00046532
		public void StopActiveMovement()
		{
			UNavMovementComponent.__StopActiveMovement_Internal(base.NativePtr);
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x0004833F File Offset: 0x0004653F
		public bool IsSwimming()
		{
			return UNavMovementComponent.__IsSwimming_Internal(base.NativePtr);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0004834C File Offset: 0x0004654C
		public bool IsMovingOnGround()
		{
			return UNavMovementComponent.__IsMovingOnGround_Internal(base.NativePtr);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00048359 File Offset: 0x00046559
		public bool IsFlying()
		{
			return UNavMovementComponent.__IsFlying_Internal(base.NativePtr);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00048366 File Offset: 0x00046566
		public bool IsFalling()
		{
			return UNavMovementComponent.__IsFalling_Internal(base.NativePtr);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00048373 File Offset: 0x00046573
		public bool IsCrouching()
		{
			return UNavMovementComponent.__IsCrouching_Internal(base.NativePtr);
		}

		// Token: 0x0600329B RID: 12955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovementKeepPathing_Internal(IntPtr @this);

		// Token: 0x0600329C RID: 12956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopActiveMovement_Internal(IntPtr @this);

		// Token: 0x0600329D RID: 12957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSwimming_Internal(IntPtr @this);

		// Token: 0x0600329E RID: 12958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMovingOnGround_Internal(IntPtr @this);

		// Token: 0x0600329F RID: 12959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFlying_Internal(IntPtr @this);

		// Token: 0x060032A0 RID: 12960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFalling_Internal(IntPtr @this);

		// Token: 0x060032A1 RID: 12961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCrouching_Internal(IntPtr @this);

		// Token: 0x060032A2 RID: 12962 RVA: 0x00048380 File Offset: 0x00046580
		static UNavMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavMovementComponent");
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00048390 File Offset: 0x00046590
		protected UNavMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UNavMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000483B8 File Offset: 0x000465B8
		protected UNavMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011A4 RID: 4516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavMovementComponent";

		// Token: 0x040011A5 RID: 4517
		private static IntPtr _ClassPtr;

		// Token: 0x040011A6 RID: 4518
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040011A7 RID: 4519
		internal static int __PropertyOffset_FixedPathBrakingDistance;

		// Token: 0x040011A8 RID: 4520
		internal static int __PropertyOffset_bUpdateNavAgentWithOwnersCollision;

		// Token: 0x040011A9 RID: 4521
		internal static byte __PropertyMask_bUpdateNavAgentWithOwnersCollision;

		// Token: 0x040011AA RID: 4522
		internal static int __PropertyOffset_bUseAccelerationForPaths;

		// Token: 0x040011AB RID: 4523
		internal static byte __PropertyMask_bUseAccelerationForPaths;

		// Token: 0x040011AC RID: 4524
		internal static int __PropertyOffset_bUseFixedBrakingDistanceForPaths;

		// Token: 0x040011AD RID: 4525
		internal static byte __PropertyMask_bUseFixedBrakingDistanceForPaths;

		// Token: 0x040011AE RID: 4526
		internal static int __PropertyOffset_PathFollowingComp;
	}
}
