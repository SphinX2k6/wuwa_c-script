using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FA RID: 4858
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotion_Base")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UAbilityTask_ApplyRootMotion_Base : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E9D RID: 73373 RVA: 0x001A46D2 File Offset: 0x001A28D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotion_Base._ClassPtr;
		}

		// Token: 0x06011E9E RID: 73374 RVA: 0x001A46E0 File Offset: 0x001A28E0
		public UAbilityTask_ApplyRootMotion_Base() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotion_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E9F RID: 73375 RVA: 0x001A4708 File Offset: 0x001A2908
		[NullableContext(1)]
		public UAbilityTask_ApplyRootMotion_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotion_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x06011EA0 RID: 73376 RVA: 0x001A473B File Offset: 0x001A293B
		// (set) Token: 0x06011EA1 RID: 73377 RVA: 0x001A474F File Offset: 0x001A294F
		public unsafe FName ForceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_ForceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_ForceName) = value;
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x06011EA2 RID: 73378 RVA: 0x001A4764 File Offset: 0x001A2964
		// (set) Token: 0x06011EA3 RID: 73379 RVA: 0x001A4774 File Offset: 0x001A2974
		public unsafe ERootMotionFinishVelocityMode FinishVelocityMode
		{
			get
			{
				return (ERootMotionFinishVelocityMode)(*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishVelocityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishVelocityMode) = (byte)value;
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x06011EA4 RID: 73380 RVA: 0x001A4785 File Offset: 0x001A2985
		// (set) Token: 0x06011EA5 RID: 73381 RVA: 0x001A4799 File Offset: 0x001A2999
		public unsafe FVector FinishSetVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishSetVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishSetVelocity) = value;
			}
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x06011EA6 RID: 73382 RVA: 0x001A47AE File Offset: 0x001A29AE
		// (set) Token: 0x06011EA7 RID: 73383 RVA: 0x001A47BE File Offset: 0x001A29BE
		public unsafe float FinishClampVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishClampVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_FinishClampVelocity) = value;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x06011EA8 RID: 73384 RVA: 0x001A47CF File Offset: 0x001A29CF
		// (set) Token: 0x06011EA9 RID: 73385 RVA: 0x001A47E3 File Offset: 0x001A29E3
		[Nullable(2)]
		public unsafe UCharacterMovementComponent MovementComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCharacterMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_MovementComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotion_Base.__PropertyOffset_MovementComponent, value);
			}
		}

		// Token: 0x06011EAA RID: 73386 RVA: 0x001A47F8 File Offset: 0x001A29F8
		static UAbilityTask_ApplyRootMotion_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotion_Base");
		}

		// Token: 0x06011EAB RID: 73387 RVA: 0x001A4806 File Offset: 0x001A2A06
		protected UAbilityTask_ApplyRootMotion_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400993B RID: 39227
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotion_Base";

		// Token: 0x0400993C RID: 39228
		private static IntPtr _ClassPtr;

		// Token: 0x0400993D RID: 39229
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400993E RID: 39230
		internal static int __PropertyOffset_ForceName;

		// Token: 0x0400993F RID: 39231
		internal static int __PropertyOffset_FinishVelocityMode;

		// Token: 0x04009940 RID: 39232
		internal static int __PropertyOffset_FinishSetVelocity;

		// Token: 0x04009941 RID: 39233
		internal static int __PropertyOffset_FinishClampVelocity;

		// Token: 0x04009942 RID: 39234
		internal static int __PropertyOffset_MovementComponent;
	}
}
