using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001386 RID: 4998
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectCustomApplicationRequirement")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UGameplayEffectCustomApplicationRequirement : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601259B RID: 75163 RVA: 0x001AF475 File Offset: 0x001AD675
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffectCustomApplicationRequirement._ClassPtr;
		}

		// Token: 0x0601259C RID: 75164 RVA: 0x001AF481 File Offset: 0x001AD681
		[NullableContext(2)]
		public virtual bool CanApplyGameplayEffect(UGameplayEffect GameplayEffect, in FGameplayEffectSpec Spec, UAbilitySystemComponent ASC)
		{
			return UGameplayEffectCustomApplicationRequirement.__CanApplyGameplayEffect_Internal(base.NativePtr, (GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero, (Spec ?? new FGameplayEffectSpec()).NativePtr, (ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601259D RID: 75165 RVA: 0x001AF4BE File Offset: 0x001AD6BE
		[NullableContext(2)]
		protected virtual bool CanApplyGameplayEffect_Implementation(UGameplayEffect GameplayEffect, in FGameplayEffectSpec Spec, UAbilitySystemComponent ASC)
		{
			return UGameplayEffectCustomApplicationRequirement.__CanApplyGameplayEffect_Implementation_Internal(base.NativePtr, (GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero, (Spec ?? new FGameplayEffectSpec()).NativePtr, (ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601259E RID: 75166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanApplyGameplayEffect_Internal(IntPtr @this, IntPtr GameplayEffect, IntPtr Spec, IntPtr ASC);

		// Token: 0x0601259F RID: 75167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanApplyGameplayEffect_Implementation_Internal(IntPtr @this, IntPtr GameplayEffect, IntPtr Spec, IntPtr ASC);

		// Token: 0x060125A0 RID: 75168 RVA: 0x001AF4FB File Offset: 0x001AD6FB
		static UGameplayEffectCustomApplicationRequirement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffectCustomApplicationRequirement");
		}

		// Token: 0x060125A1 RID: 75169 RVA: 0x001AF50C File Offset: 0x001AD70C
		protected UGameplayEffectCustomApplicationRequirement() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectCustomApplicationRequirement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060125A2 RID: 75170 RVA: 0x001AF534 File Offset: 0x001AD734
		protected UGameplayEffectCustomApplicationRequirement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009D2F RID: 40239
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectCustomApplicationRequirement";

		// Token: 0x04009D30 RID: 40240
		private static IntPtr _ClassPtr;

		// Token: 0x04009D31 RID: 40241
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02002E43 RID: 11843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 712)]
		protected ref struct __CanApplyGameplayEffect_FunctionParams
		{
			// Token: 0x040168FA RID: 92410
			[FieldOffset(0)]
			public IntPtr GameplayEffect;

			// Token: 0x040168FB RID: 92411
			[FieldOffset(8)]
			public byte Spec;

			// Token: 0x040168FC RID: 92412
			[FieldOffset(696)]
			public IntPtr ASC;

			// Token: 0x040168FD RID: 92413
			[FieldOffset(704)]
			public bool __Result;
		}
	}
}
