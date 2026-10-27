using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F3 RID: 4851
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public abstract class UAbilityTask : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011DF0 RID: 73200 RVA: 0x001A36A7 File Offset: 0x001A18A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask._ClassPtr;
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x06011DF1 RID: 73201 RVA: 0x001A36B3 File Offset: 0x001A18B3
		// (set) Token: 0x06011DF2 RID: 73202 RVA: 0x001A36C7 File Offset: 0x001A18C7
		public unsafe UGameplayAbility Ability
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask.__PropertyOffset_Ability);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask.__PropertyOffset_Ability, value);
			}
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x06011DF3 RID: 73203 RVA: 0x001A36DC File Offset: 0x001A18DC
		// (set) Token: 0x06011DF4 RID: 73204 RVA: 0x001A36F0 File Offset: 0x001A18F0
		public unsafe UAbilitySystemComponent AbilitySystemComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask.__PropertyOffset_AbilitySystemComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask.__PropertyOffset_AbilitySystemComponent, value);
			}
		}

		// Token: 0x06011DF5 RID: 73205 RVA: 0x001A3705 File Offset: 0x001A1905
		static UAbilityTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask");
		}

		// Token: 0x06011DF6 RID: 73206 RVA: 0x001A3714 File Offset: 0x001A1914
		protected UAbilityTask() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011DF7 RID: 73207 RVA: 0x001A373C File Offset: 0x001A193C
		protected UAbilityTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040098E6 RID: 39142
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask";

		// Token: 0x040098E7 RID: 39143
		private static IntPtr _ClassPtr;

		// Token: 0x040098E8 RID: 39144
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040098E9 RID: 39145
		internal static int __PropertyOffset_Ability;

		// Token: 0x040098EA RID: 39146
		internal static int __PropertyOffset_AbilitySystemComponent;
	}
}
