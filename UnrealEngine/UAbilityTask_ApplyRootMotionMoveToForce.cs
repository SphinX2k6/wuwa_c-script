using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F8 RID: 4856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToForce")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAbilityTask_ApplyRootMotionMoveToForce : UAbilityTask_ApplyRootMotion_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E63 RID: 73315 RVA: 0x001A4143 File Offset: 0x001A2343
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotionMoveToForce._ClassPtr;
		}

		// Token: 0x06011E64 RID: 73316 RVA: 0x001A4150 File Offset: 0x001A2350
		public UAbilityTask_ApplyRootMotionMoveToForce() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionMoveToForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E65 RID: 73317 RVA: 0x001A4178 File Offset: 0x001A2378
		public UAbilityTask_ApplyRootMotionMoveToForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionMoveToForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x06011E66 RID: 73318 RVA: 0x001A41AC File Offset: 0x001A23AC
		// (set) Token: 0x06011E67 RID: 73319 RVA: 0x001A41E5 File Offset: 0x001A23E5
		public FApplyRootMotionMoveToForceDelegate OnTimedOut
		{
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionMoveToForceDelegate result;
				if ((result = this._OnTimedOut) == null)
				{
					result = (this._OnTimedOut = new FApplyRootMotionMoveToForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_OnTimedOut, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_OnTimedOut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x06011E68 RID: 73320 RVA: 0x001A4208 File Offset: 0x001A2408
		// (set) Token: 0x06011E69 RID: 73321 RVA: 0x001A4241 File Offset: 0x001A2441
		public FApplyRootMotionMoveToForceDelegate OnTimedOutAndDestinationReached
		{
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionMoveToForceDelegate result;
				if ((result = this._OnTimedOutAndDestinationReached) == null)
				{
					result = (this._OnTimedOutAndDestinationReached = new FApplyRootMotionMoveToForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_OnTimedOutAndDestinationReached, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_OnTimedOutAndDestinationReached, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x06011E6A RID: 73322 RVA: 0x001A4262 File Offset: 0x001A2462
		// (set) Token: 0x06011E6B RID: 73323 RVA: 0x001A4276 File Offset: 0x001A2476
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x06011E6C RID: 73324 RVA: 0x001A428B File Offset: 0x001A248B
		// (set) Token: 0x06011E6D RID: 73325 RVA: 0x001A429F File Offset: 0x001A249F
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x06011E6E RID: 73326 RVA: 0x001A42B4 File Offset: 0x001A24B4
		// (set) Token: 0x06011E6F RID: 73327 RVA: 0x001A42C4 File Offset: 0x001A24C4
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x06011E70 RID: 73328 RVA: 0x001A42D5 File Offset: 0x001A24D5
		// (set) Token: 0x06011E71 RID: 73329 RVA: 0x001A42E5 File Offset: 0x001A24E5
		public unsafe bool bSetNewMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_bSetNewMovementMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_bSetNewMovementMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x06011E72 RID: 73330 RVA: 0x001A42F6 File Offset: 0x001A24F6
		// (set) Token: 0x06011E73 RID: 73331 RVA: 0x001A430A File Offset: 0x001A250A
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> NewMovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_NewMovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_NewMovementMode) = value;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x06011E74 RID: 73332 RVA: 0x001A431F File Offset: 0x001A251F
		// (set) Token: 0x06011E75 RID: 73333 RVA: 0x001A432F File Offset: 0x001A252F
		public unsafe bool bRestrictSpeedToExpected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_bRestrictSpeedToExpected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_bRestrictSpeedToExpected) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x06011E76 RID: 73334 RVA: 0x001A4340 File Offset: 0x001A2540
		// (set) Token: 0x06011E77 RID: 73335 RVA: 0x001A4354 File Offset: 0x001A2554
		[Nullable(2)]
		public unsafe UCurveVector PathOffsetCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_PathOffsetCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionMoveToForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x06011E78 RID: 73336 RVA: 0x001A436C File Offset: 0x001A256C
		[NullableContext(2)]
		public static UAbilityTask_ApplyRootMotionMoveToForce ApplyRootMotionMoveToForce(UGameplayAbility OwningAbility, FName TaskInstanceName, FVector TargetLocation, float Duration, bool bSetNewMovementMode, EMovementMode MovementMode, bool bRestrictSpeedToExpected, UCurveVector PathOffsetCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionMoveToForce>(UAbilityTask_ApplyRootMotionMoveToForce.__ApplyRootMotionMoveToForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, TargetLocation, Duration, bSetNewMovementMode, MovementMode, bRestrictSpeedToExpected, (PathOffsetCurve != null) ? PathOffsetCurve.NativePtr : IntPtr.Zero, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish));
		}

		// Token: 0x06011E79 RID: 73337
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionMoveToForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, FVector TargetLocation, float Duration, bool bSetNewMovementMode, TEnumAsByte<EMovementMode> MovementMode, bool bRestrictSpeedToExpected, IntPtr PathOffsetCurve, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish);

		// Token: 0x06011E7A RID: 73338 RVA: 0x001A43B9 File Offset: 0x001A25B9
		static UAbilityTask_ApplyRootMotionMoveToForce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToForce");
		}

		// Token: 0x06011E7B RID: 73339 RVA: 0x001A43C7 File Offset: 0x001A25C7
		protected UAbilityTask_ApplyRootMotionMoveToForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400991C RID: 39196
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionMoveToForce";

		// Token: 0x0400991D RID: 39197
		private static IntPtr _ClassPtr;

		// Token: 0x0400991E RID: 39198
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400991F RID: 39199
		internal static int __PropertyOffset_OnTimedOut;

		// Token: 0x04009920 RID: 39200
		[Nullable(2)]
		private FApplyRootMotionMoveToForceDelegate _OnTimedOut;

		// Token: 0x04009921 RID: 39201
		internal static int __PropertyOffset_OnTimedOutAndDestinationReached;

		// Token: 0x04009922 RID: 39202
		[Nullable(2)]
		private FApplyRootMotionMoveToForceDelegate _OnTimedOutAndDestinationReached;

		// Token: 0x04009923 RID: 39203
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04009924 RID: 39204
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x04009925 RID: 39205
		internal static int __PropertyOffset_Duration;

		// Token: 0x04009926 RID: 39206
		internal static int __PropertyOffset_bSetNewMovementMode;

		// Token: 0x04009927 RID: 39207
		internal static int __PropertyOffset_NewMovementMode;

		// Token: 0x04009928 RID: 39208
		internal static int __PropertyOffset_bRestrictSpeedToExpected;

		// Token: 0x04009929 RID: 39209
		internal static int __PropertyOffset_PathOffsetCurve;
	}
}
