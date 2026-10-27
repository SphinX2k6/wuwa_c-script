using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F7 RID: 4855
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToActorForce")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UAbilityTask_ApplyRootMotionMoveToActorForce : UAbilityTask_ApplyRootMotion_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E38 RID: 73272 RVA: 0x001A3CE3 File Offset: 0x001A1EE3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotionMoveToActorForce._ClassPtr;
		}

		// Token: 0x06011E39 RID: 73273 RVA: 0x001A3CF0 File Offset: 0x001A1EF0
		public UAbilityTask_ApplyRootMotionMoveToActorForce() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionMoveToActorForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E3A RID: 73274 RVA: 0x001A3D18 File Offset: 0x001A1F18
		[NullableContext(1)]
		public UAbilityTask_ApplyRootMotionMoveToActorForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionMoveToActorForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x06011E3B RID: 73275 RVA: 0x001A3D4C File Offset: 0x001A1F4C
		// (set) Token: 0x06011E3C RID: 73276 RVA: 0x001A3D85 File Offset: 0x001A1F85
		[Nullable(1)]
		public FApplyRootMotionMoveToActorForceDelegate OnFinished
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionMoveToActorForceDelegate result;
				if ((result = this._OnFinished) == null)
				{
					result = (this._OnFinished = new FApplyRootMotionMoveToActorForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_OnFinished, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_OnFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x06011E3D RID: 73277 RVA: 0x001A3DA6 File Offset: 0x001A1FA6
		// (set) Token: 0x06011E3E RID: 73278 RVA: 0x001A3DBA File Offset: 0x001A1FBA
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x06011E3F RID: 73279 RVA: 0x001A3DCF File Offset: 0x001A1FCF
		// (set) Token: 0x06011E40 RID: 73280 RVA: 0x001A3DE3 File Offset: 0x001A1FE3
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x06011E41 RID: 73281 RVA: 0x001A3DF8 File Offset: 0x001A1FF8
		// (set) Token: 0x06011E42 RID: 73282 RVA: 0x001A3E0C File Offset: 0x001A200C
		public unsafe AActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x06011E43 RID: 73283 RVA: 0x001A3E21 File Offset: 0x001A2021
		// (set) Token: 0x06011E44 RID: 73284 RVA: 0x001A3E35 File Offset: 0x001A2035
		public unsafe FVector TargetLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLocationOffset) = value;
			}
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x06011E45 RID: 73285 RVA: 0x001A3E4A File Offset: 0x001A204A
		// (set) Token: 0x06011E46 RID: 73286 RVA: 0x001A3E5A File Offset: 0x001A205A
		public unsafe ERootMotionMoveToActorTargetOffsetType OffsetAlignment
		{
			get
			{
				return (ERootMotionMoveToActorTargetOffsetType)(*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_OffsetAlignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_OffsetAlignment) = (byte)value;
			}
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x06011E47 RID: 73287 RVA: 0x001A3E6B File Offset: 0x001A206B
		// (set) Token: 0x06011E48 RID: 73288 RVA: 0x001A3E7B File Offset: 0x001A207B
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x06011E49 RID: 73289 RVA: 0x001A3E8C File Offset: 0x001A208C
		// (set) Token: 0x06011E4A RID: 73290 RVA: 0x001A3E9C File Offset: 0x001A209C
		public unsafe bool bDisableDestinationReachedInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bDisableDestinationReachedInterrupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bDisableDestinationReachedInterrupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x06011E4B RID: 73291 RVA: 0x001A3EAD File Offset: 0x001A20AD
		// (set) Token: 0x06011E4C RID: 73292 RVA: 0x001A3EBD File Offset: 0x001A20BD
		public unsafe bool bSetNewMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bSetNewMovementMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bSetNewMovementMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x06011E4D RID: 73293 RVA: 0x001A3ECE File Offset: 0x001A20CE
		// (set) Token: 0x06011E4E RID: 73294 RVA: 0x001A3EE2 File Offset: 0x001A20E2
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> NewMovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_NewMovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_NewMovementMode) = value;
			}
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x06011E4F RID: 73295 RVA: 0x001A3EF7 File Offset: 0x001A20F7
		// (set) Token: 0x06011E50 RID: 73296 RVA: 0x001A3F07 File Offset: 0x001A2107
		public unsafe bool bRestrictSpeedToExpected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bRestrictSpeedToExpected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_bRestrictSpeedToExpected) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x06011E51 RID: 73297 RVA: 0x001A3F18 File Offset: 0x001A2118
		// (set) Token: 0x06011E52 RID: 73298 RVA: 0x001A3F2C File Offset: 0x001A212C
		public unsafe UCurveVector PathOffsetCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_PathOffsetCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x06011E53 RID: 73299 RVA: 0x001A3F41 File Offset: 0x001A2141
		// (set) Token: 0x06011E54 RID: 73300 RVA: 0x001A3F55 File Offset: 0x001A2155
		public unsafe UCurveFloat TimeMappingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TimeMappingCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TimeMappingCurve, value);
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x06011E55 RID: 73301 RVA: 0x001A3F6A File Offset: 0x001A216A
		// (set) Token: 0x06011E56 RID: 73302 RVA: 0x001A3F7E File Offset: 0x001A217E
		public unsafe UCurveFloat TargetLerpSpeedHorizontalCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLerpSpeedHorizontalCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLerpSpeedHorizontalCurve, value);
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x06011E57 RID: 73303 RVA: 0x001A3F93 File Offset: 0x001A2193
		// (set) Token: 0x06011E58 RID: 73304 RVA: 0x001A3FA7 File Offset: 0x001A21A7
		public unsafe UCurveFloat TargetLerpSpeedVerticalCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLerpSpeedVerticalCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToActorForce.__PropertyOffset_TargetLerpSpeedVerticalCurve, value);
			}
		}

		// Token: 0x06011E59 RID: 73305 RVA: 0x001A3FBC File Offset: 0x001A21BC
		public void OnTargetActorSwapped(AActor OriginalTarget, AActor NewTarget)
		{
			UAbilityTask_ApplyRootMotionMoveToActorForce.__OnTargetActorSwapped_Internal(base.NativePtr, (OriginalTarget != null) ? OriginalTarget.NativePtr : IntPtr.Zero, (NewTarget != null) ? NewTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011E5A RID: 73306 RVA: 0x001A3FE9 File Offset: 0x001A21E9
		public void OnRep_TargetLocation()
		{
			UAbilityTask_ApplyRootMotionMoveToActorForce.__OnRep_TargetLocation_Internal(base.NativePtr);
		}

		// Token: 0x06011E5B RID: 73307 RVA: 0x001A3FF8 File Offset: 0x001A21F8
		public static UAbilityTask_ApplyRootMotionMoveToActorForce ApplyRootMotionMoveToTargetDataActorForce(UGameplayAbility OwningAbility, FName TaskInstanceName, FGameplayAbilityTargetDataHandle TargetDataHandle, int TargetDataIndex, int TargetActorIndex, FVector TargetLocationOffset, ERootMotionMoveToActorTargetOffsetType OffsetAlignment, float Duration, UCurveFloat TargetLerpSpeedHorizontal, UCurveFloat TargetLerpSpeedVertical, bool bSetNewMovementMode, EMovementMode MovementMode, bool bRestrictSpeedToExpected, UCurveVector PathOffsetCurve, UCurveFloat TimeMappingCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bDisableDestinationReachedInterrupt)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionMoveToActorForce>(UAbilityTask_ApplyRootMotionMoveToActorForce.__ApplyRootMotionMoveToTargetDataActorForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, (TargetDataHandle ?? new FGameplayAbilityTargetDataHandle()).NativePtr, TargetDataIndex, TargetActorIndex, TargetLocationOffset, OffsetAlignment, Duration, (TargetLerpSpeedHorizontal != null) ? TargetLerpSpeedHorizontal.NativePtr : IntPtr.Zero, (TargetLerpSpeedVertical != null) ? TargetLerpSpeedVertical.NativePtr : IntPtr.Zero, bSetNewMovementMode, MovementMode, bRestrictSpeedToExpected, (PathOffsetCurve != null) ? PathOffsetCurve.NativePtr : IntPtr.Zero, (TimeMappingCurve != null) ? TimeMappingCurve.NativePtr : IntPtr.Zero, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish, bDisableDestinationReachedInterrupt));
		}

		// Token: 0x06011E5C RID: 73308 RVA: 0x001A4094 File Offset: 0x001A2294
		public static UAbilityTask_ApplyRootMotionMoveToActorForce ApplyRootMotionMoveToActorForce(UGameplayAbility OwningAbility, FName TaskInstanceName, AActor TargetActor, FVector TargetLocationOffset, ERootMotionMoveToActorTargetOffsetType OffsetAlignment, float Duration, UCurveFloat TargetLerpSpeedHorizontal, UCurveFloat TargetLerpSpeedVertical, bool bSetNewMovementMode, EMovementMode MovementMode, bool bRestrictSpeedToExpected, UCurveVector PathOffsetCurve, UCurveFloat TimeMappingCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bDisableDestinationReachedInterrupt)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionMoveToActorForce>(UAbilityTask_ApplyRootMotionMoveToActorForce.__ApplyRootMotionMoveToActorForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, (TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, TargetLocationOffset, OffsetAlignment, Duration, (TargetLerpSpeedHorizontal != null) ? TargetLerpSpeedHorizontal.NativePtr : IntPtr.Zero, (TargetLerpSpeedVertical != null) ? TargetLerpSpeedVertical.NativePtr : IntPtr.Zero, bSetNewMovementMode, MovementMode, bRestrictSpeedToExpected, (PathOffsetCurve != null) ? PathOffsetCurve.NativePtr : IntPtr.Zero, (TimeMappingCurve != null) ? TimeMappingCurve.NativePtr : IntPtr.Zero, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish, bDisableDestinationReachedInterrupt));
		}

		// Token: 0x06011E5D RID: 73309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetActorSwapped_Internal(IntPtr @this, IntPtr OriginalTarget, IntPtr NewTarget);

		// Token: 0x06011E5E RID: 73310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_TargetLocation_Internal(IntPtr @this);

		// Token: 0x06011E5F RID: 73311
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionMoveToTargetDataActorForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, IntPtr TargetDataHandle, int TargetDataIndex, int TargetActorIndex, FVector TargetLocationOffset, ERootMotionMoveToActorTargetOffsetType OffsetAlignment, float Duration, IntPtr TargetLerpSpeedHorizontal, IntPtr TargetLerpSpeedVertical, bool bSetNewMovementMode, TEnumAsByte<EMovementMode> MovementMode, bool bRestrictSpeedToExpected, IntPtr PathOffsetCurve, IntPtr TimeMappingCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bDisableDestinationReachedInterrupt);

		// Token: 0x06011E60 RID: 73312
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionMoveToActorForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, IntPtr TargetActor, FVector TargetLocationOffset, ERootMotionMoveToActorTargetOffsetType OffsetAlignment, float Duration, IntPtr TargetLerpSpeedHorizontal, IntPtr TargetLerpSpeedVertical, bool bSetNewMovementMode, TEnumAsByte<EMovementMode> MovementMode, bool bRestrictSpeedToExpected, IntPtr PathOffsetCurve, IntPtr TimeMappingCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bDisableDestinationReachedInterrupt);

		// Token: 0x06011E61 RID: 73313 RVA: 0x001A412C File Offset: 0x001A232C
		static UAbilityTask_ApplyRootMotionMoveToActorForce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToActorForce");
		}

		// Token: 0x06011E62 RID: 73314 RVA: 0x001A413A File Offset: 0x001A233A
		protected UAbilityTask_ApplyRootMotionMoveToActorForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009909 RID: 39177
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToActorForce";

		// Token: 0x0400990A RID: 39178
		private static IntPtr _ClassPtr;

		// Token: 0x0400990B RID: 39179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400990C RID: 39180
		internal static int __PropertyOffset_OnFinished;

		// Token: 0x0400990D RID: 39181
		private FApplyRootMotionMoveToActorForceDelegate _OnFinished;

		// Token: 0x0400990E RID: 39182
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x0400990F RID: 39183
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x04009910 RID: 39184
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x04009911 RID: 39185
		internal static int __PropertyOffset_TargetLocationOffset;

		// Token: 0x04009912 RID: 39186
		internal static int __PropertyOffset_OffsetAlignment;

		// Token: 0x04009913 RID: 39187
		internal static int __PropertyOffset_Duration;

		// Token: 0x04009914 RID: 39188
		internal static int __PropertyOffset_bDisableDestinationReachedInterrupt;

		// Token: 0x04009915 RID: 39189
		internal static int __PropertyOffset_bSetNewMovementMode;

		// Token: 0x04009916 RID: 39190
		internal static int __PropertyOffset_NewMovementMode;

		// Token: 0x04009917 RID: 39191
		internal static int __PropertyOffset_bRestrictSpeedToExpected;

		// Token: 0x04009918 RID: 39192
		internal static int __PropertyOffset_PathOffsetCurve;

		// Token: 0x04009919 RID: 39193
		internal static int __PropertyOffset_TimeMappingCurve;

		// Token: 0x0400991A RID: 39194
		internal static int __PropertyOffset_TargetLerpSpeedHorizontalCurve;

		// Token: 0x0400991B RID: 39195
		internal static int __PropertyOffset_TargetLerpSpeedVerticalCurve;
	}
}
