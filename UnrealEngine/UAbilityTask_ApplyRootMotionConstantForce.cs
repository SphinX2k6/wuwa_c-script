using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F5 RID: 4853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotionConstantForce")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UAbilityTask_ApplyRootMotionConstantForce : UAbilityTask_ApplyRootMotion_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E04 RID: 73220 RVA: 0x001A380D File Offset: 0x001A1A0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotionConstantForce._ClassPtr;
		}

		// Token: 0x06011E05 RID: 73221 RVA: 0x001A381C File Offset: 0x001A1A1C
		public UAbilityTask_ApplyRootMotionConstantForce() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionConstantForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E06 RID: 73222 RVA: 0x001A3844 File Offset: 0x001A1A44
		public UAbilityTask_ApplyRootMotionConstantForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionConstantForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x06011E07 RID: 73223 RVA: 0x001A3878 File Offset: 0x001A1A78
		// (set) Token: 0x06011E08 RID: 73224 RVA: 0x001A38B1 File Offset: 0x001A1AB1
		public FApplyRootMotionConstantForceDelegate OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionConstantForceDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FApplyRootMotionConstantForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x06011E09 RID: 73225 RVA: 0x001A38D2 File Offset: 0x001A1AD2
		// (set) Token: 0x06011E0A RID: 73226 RVA: 0x001A38E6 File Offset: 0x001A1AE6
		public unsafe FVector WorldDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_WorldDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_WorldDirection) = value;
			}
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06011E0B RID: 73227 RVA: 0x001A38FB File Offset: 0x001A1AFB
		// (set) Token: 0x06011E0C RID: 73228 RVA: 0x001A390B File Offset: 0x001A1B0B
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06011E0D RID: 73229 RVA: 0x001A391C File Offset: 0x001A1B1C
		// (set) Token: 0x06011E0E RID: 73230 RVA: 0x001A392C File Offset: 0x001A1B2C
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06011E0F RID: 73231 RVA: 0x001A393D File Offset: 0x001A1B3D
		// (set) Token: 0x06011E10 RID: 73232 RVA: 0x001A394D File Offset: 0x001A1B4D
		public unsafe bool bIsAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_bIsAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_bIsAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06011E11 RID: 73233 RVA: 0x001A395E File Offset: 0x001A1B5E
		// (set) Token: 0x06011E12 RID: 73234 RVA: 0x001A3972 File Offset: 0x001A1B72
		[Nullable(2)]
		public unsafe UCurveFloat StrengthOverTime
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_StrengthOverTime);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_StrengthOverTime, value);
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x06011E13 RID: 73235 RVA: 0x001A3987 File Offset: 0x001A1B87
		// (set) Token: 0x06011E14 RID: 73236 RVA: 0x001A3997 File Offset: 0x001A1B97
		public unsafe bool bEnableGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_bEnableGravity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionConstantForce.__PropertyOffset_bEnableGravity) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011E15 RID: 73237 RVA: 0x001A39A8 File Offset: 0x001A1BA8
		[NullableContext(2)]
		public static UAbilityTask_ApplyRootMotionConstantForce ApplyRootMotionConstantForce(UGameplayAbility OwningAbility, FName TaskInstanceName, FVector WorldDirection, float Strength, float Duration, bool bIsAdditive, UCurveFloat StrengthOverTime, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bEnableGravity)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionConstantForce>(UAbilityTask_ApplyRootMotionConstantForce.__ApplyRootMotionConstantForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, WorldDirection, Strength, Duration, bIsAdditive, (StrengthOverTime != null) ? StrengthOverTime.NativePtr : IntPtr.Zero, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish, bEnableGravity));
		}

		// Token: 0x06011E16 RID: 73238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionConstantForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, FVector WorldDirection, float Strength, float Duration, bool bIsAdditive, IntPtr StrengthOverTime, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, bool bEnableGravity);

		// Token: 0x06011E17 RID: 73239 RVA: 0x001A39F0 File Offset: 0x001A1BF0
		static UAbilityTask_ApplyRootMotionConstantForce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionConstantForce");
		}

		// Token: 0x06011E18 RID: 73240 RVA: 0x001A39FE File Offset: 0x001A1BFE
		protected UAbilityTask_ApplyRootMotionConstantForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040098EF RID: 39151
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionConstantForce";

		// Token: 0x040098F0 RID: 39152
		private static IntPtr _ClassPtr;

		// Token: 0x040098F1 RID: 39153
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040098F2 RID: 39154
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x040098F3 RID: 39155
		[Nullable(2)]
		private FApplyRootMotionConstantForceDelegate _OnFinish;

		// Token: 0x040098F4 RID: 39156
		internal static int __PropertyOffset_WorldDirection;

		// Token: 0x040098F5 RID: 39157
		internal static int __PropertyOffset_Strength;

		// Token: 0x040098F6 RID: 39158
		internal static int __PropertyOffset_Duration;

		// Token: 0x040098F7 RID: 39159
		internal static int __PropertyOffset_bIsAdditive;

		// Token: 0x040098F8 RID: 39160
		internal static int __PropertyOffset_StrengthOverTime;

		// Token: 0x040098F9 RID: 39161
		internal static int __PropertyOffset_bEnableGravity;
	}
}
