using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C2 RID: 706
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGameplayAbilityLocalAnimMontage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x0006C466 File Offset: 0x0006A666
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityLocalAnimMontage._ScriptStructPtr != 0) ? FGameplayAbilityLocalAnimMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage", ref FGameplayAbilityLocalAnimMontage._ScriptStructPtr);
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x0006C48A File Offset: 0x0006A68A
		// (set) Token: 0x06004D7B RID: 19835 RVA: 0x0006C49E File Offset: 0x0006A69E
		public unsafe UAnimMontage AnimMontage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimMontage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimMontage, value);
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06004D7C RID: 19836 RVA: 0x0006C4B3 File Offset: 0x0006A6B3
		// (set) Token: 0x06004D7D RID: 19837 RVA: 0x0006C4C3 File Offset: 0x0006A6C3
		public unsafe bool PlayBit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PlayBit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityLocalAnimMontage.__PropertyOffset_PlayBit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		// (set) Token: 0x06004D7F RID: 19839 RVA: 0x0006C4E8 File Offset: 0x0006A6E8
		public unsafe UGameplayAbility AnimatingAbility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimatingAbility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityLocalAnimMontage.__PropertyOffset_AnimatingAbility, value);
			}
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x0006C4FD File Offset: 0x0006A6FD
		public FGameplayAbilityLocalAnimMontage()
		{
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x0006C505 File Offset: 0x0006A705
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityLocalAnimMontage.StaticStruct();
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x0006C511 File Offset: 0x0006A711
		public FGameplayAbilityLocalAnimMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x0006C51B File Offset: 0x0006A71B
		public FGameplayAbilityLocalAnimMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x0006C526 File Offset: 0x0006A726
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityLocalAnimMontage(Pointer, false, true);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x0006C530 File Offset: 0x0006A730
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityLocalAnimMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04001EE8 RID: 7912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityLocalAnimMontage";

		// Token: 0x04001EE9 RID: 7913
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EEA RID: 7914
		internal static int __PropertyOffset_AnimMontage;

		// Token: 0x04001EEB RID: 7915
		internal static int __PropertyOffset_PlayBit;

		// Token: 0x04001EEC RID: 7916
		internal static int __PropertyOffset_AnimatingAbility;
	}
}
