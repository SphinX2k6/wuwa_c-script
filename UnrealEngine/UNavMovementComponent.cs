using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE2 RID: 3810
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavMovementComponent")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public abstract class UNavMovementComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE6B RID: 52843 RVA: 0x0012D459 File Offset: 0x0012B659
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMovementComponent._ClassPtr;
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600CE6C RID: 52844 RVA: 0x0012D468 File Offset: 0x0012B668
		// (set) Token: 0x0600CE6D RID: 52845 RVA: 0x0012D4A1 File Offset: 0x0012B6A1
		public FNavAgentProperties NavAgentProps
		{
			get
			{
				base.FastCheckIsValid();
				FNavAgentProperties result;
				if ((result = this._NavAgentProps) == null)
				{
					result = (this._NavAgentProps = new FNavAgentProperties(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_NavAgentProps, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentProperties.StaticStruct(), base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_NavAgentProps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600CE6E RID: 52846 RVA: 0x0012D4C2 File Offset: 0x0012B6C2
		// (set) Token: 0x0600CE6F RID: 52847 RVA: 0x0012D4D2 File Offset: 0x0012B6D2
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

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600CE70 RID: 52848 RVA: 0x0012D4E3 File Offset: 0x0012B6E3
		// (set) Token: 0x0600CE71 RID: 52849 RVA: 0x0012D4FC File Offset: 0x0012B6FC
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

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600CE72 RID: 52850 RVA: 0x0012D52C File Offset: 0x0012B72C
		// (set) Token: 0x0600CE73 RID: 52851 RVA: 0x0012D545 File Offset: 0x0012B745
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

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600CE74 RID: 52852 RVA: 0x0012D575 File Offset: 0x0012B775
		// (set) Token: 0x0600CE75 RID: 52853 RVA: 0x0012D58E File Offset: 0x0012B78E
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

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600CE76 RID: 52854 RVA: 0x0012D5C0 File Offset: 0x0012B7C0
		// (set) Token: 0x0600CE77 RID: 52855 RVA: 0x0012D5F9 File Offset: 0x0012B7F9
		public FMovementProperties MovementState
		{
			get
			{
				base.FastCheckIsValid();
				FMovementProperties result;
				if ((result = this._MovementState) == null)
				{
					result = (this._MovementState = new FMovementProperties(base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_MovementState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovementProperties.StaticStruct(), base.NativePtr + (IntPtr)UNavMovementComponent.__PropertyOffset_MovementState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600CE78 RID: 52856 RVA: 0x0012D61A File Offset: 0x0012B81A
		// (set) Token: 0x0600CE79 RID: 52857 RVA: 0x0012D62E File Offset: 0x0012B82E
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

		// Token: 0x0600CE7A RID: 52858 RVA: 0x0012D643 File Offset: 0x0012B843
		public void StopMovementKeepPathing()
		{
			UNavMovementComponent.__StopMovementKeepPathing_Internal(base.NativePtr);
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x0012D650 File Offset: 0x0012B850
		public void StopActiveMovement()
		{
			UNavMovementComponent.__StopActiveMovement_Internal(base.NativePtr);
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x0012D65D File Offset: 0x0012B85D
		public bool IsSwimming()
		{
			return UNavMovementComponent.__IsSwimming_Internal(base.NativePtr);
		}

		// Token: 0x0600CE7D RID: 52861 RVA: 0x0012D66A File Offset: 0x0012B86A
		public bool IsMovingOnGround()
		{
			return UNavMovementComponent.__IsMovingOnGround_Internal(base.NativePtr);
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x0012D677 File Offset: 0x0012B877
		public bool IsFlying()
		{
			return UNavMovementComponent.__IsFlying_Internal(base.NativePtr);
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x0012D684 File Offset: 0x0012B884
		public bool IsFalling()
		{
			return UNavMovementComponent.__IsFalling_Internal(base.NativePtr);
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x0012D691 File Offset: 0x0012B891
		public bool IsCrouching()
		{
			return UNavMovementComponent.__IsCrouching_Internal(base.NativePtr);
		}

		// Token: 0x0600CE81 RID: 52865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovementKeepPathing_Internal(IntPtr @this);

		// Token: 0x0600CE82 RID: 52866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopActiveMovement_Internal(IntPtr @this);

		// Token: 0x0600CE83 RID: 52867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSwimming_Internal(IntPtr @this);

		// Token: 0x0600CE84 RID: 52868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMovingOnGround_Internal(IntPtr @this);

		// Token: 0x0600CE85 RID: 52869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFlying_Internal(IntPtr @this);

		// Token: 0x0600CE86 RID: 52870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFalling_Internal(IntPtr @this);

		// Token: 0x0600CE87 RID: 52871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCrouching_Internal(IntPtr @this);

		// Token: 0x0600CE88 RID: 52872 RVA: 0x0012D69E File Offset: 0x0012B89E
		static UNavMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavMovementComponent");
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		protected UNavMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UNavMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x0012D6D4 File Offset: 0x0012B8D4
		protected UNavMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F53 RID: 28499
		public new const string __ObjectPath = "/Script/Engine.NavMovementComponent";

		// Token: 0x04006F54 RID: 28500
		private static IntPtr _ClassPtr;

		// Token: 0x04006F55 RID: 28501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F56 RID: 28502
		internal static int __PropertyOffset_NavAgentProps;

		// Token: 0x04006F57 RID: 28503
		[Nullable(2)]
		private FNavAgentProperties _NavAgentProps;

		// Token: 0x04006F58 RID: 28504
		internal static int __PropertyOffset_FixedPathBrakingDistance;

		// Token: 0x04006F59 RID: 28505
		internal static int __PropertyOffset_bUpdateNavAgentWithOwnersCollision;

		// Token: 0x04006F5A RID: 28506
		internal static byte __PropertyMask_bUpdateNavAgentWithOwnersCollision;

		// Token: 0x04006F5B RID: 28507
		internal static int __PropertyOffset_bUseAccelerationForPaths;

		// Token: 0x04006F5C RID: 28508
		internal static byte __PropertyMask_bUseAccelerationForPaths;

		// Token: 0x04006F5D RID: 28509
		internal static int __PropertyOffset_bUseFixedBrakingDistanceForPaths;

		// Token: 0x04006F5E RID: 28510
		internal static byte __PropertyMask_bUseFixedBrakingDistanceForPaths;

		// Token: 0x04006F5F RID: 28511
		internal static int __PropertyOffset_MovementState;

		// Token: 0x04006F60 RID: 28512
		[Nullable(2)]
		private FMovementProperties _MovementState;

		// Token: 0x04006F61 RID: 28513
		internal static int __PropertyOffset_PathFollowingComp;
	}
}
