using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001312 RID: 4882
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayTag")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UAbilityTask_WaitGameplayTag : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FE5 RID: 73701 RVA: 0x001A6AA6 File Offset: 0x001A4CA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayTag._ClassPtr;
		}

		// Token: 0x06011FE6 RID: 73702 RVA: 0x001A6AB4 File Offset: 0x001A4CB4
		public UAbilityTask_WaitGameplayTag() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FE7 RID: 73703 RVA: 0x001A6ADC File Offset: 0x001A4CDC
		[NullableContext(1)]
		public UAbilityTask_WaitGameplayTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x06011FE8 RID: 73704 RVA: 0x001A6B0F File Offset: 0x001A4D0F
		// (set) Token: 0x06011FE9 RID: 73705 RVA: 0x001A6B23 File Offset: 0x001A4D23
		[Nullable(2)]
		public unsafe UAbilitySystemComponent OptionalExternalTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayTag.__PropertyOffset_OptionalExternalTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayTag.__PropertyOffset_OptionalExternalTarget, value);
			}
		}

		// Token: 0x06011FEA RID: 73706 RVA: 0x001A6B38 File Offset: 0x001A4D38
		public void GameplayTagCallback(FGameplayTag Tag, int NewCount)
		{
			UAbilityTask_WaitGameplayTag.__GameplayTagCallback_Internal(base.NativePtr, Tag, NewCount);
		}

		// Token: 0x06011FEB RID: 73707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GameplayTagCallback_Internal(IntPtr @this, FGameplayTag Tag, int NewCount);

		// Token: 0x06011FEC RID: 73708 RVA: 0x001A6B47 File Offset: 0x001A4D47
		static UAbilityTask_WaitGameplayTag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayTag");
		}

		// Token: 0x06011FED RID: 73709 RVA: 0x001A6B55 File Offset: 0x001A4D55
		protected UAbilityTask_WaitGameplayTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099D9 RID: 39385
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayTag";

		// Token: 0x040099DA RID: 39386
		private static IntPtr _ClassPtr;

		// Token: 0x040099DB RID: 39387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099DC RID: 39388
		internal static int __PropertyOffset_OptionalExternalTarget;
	}
}
