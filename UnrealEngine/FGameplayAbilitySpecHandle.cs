using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C3 RID: 707
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpecHandle")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FGameplayAbilitySpecHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D86 RID: 19846 RVA: 0x0006C539 File Offset: 0x0006A739
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpecHandle._ScriptStructPtr != 0) ? FGameplayAbilitySpecHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpecHandle", ref FGameplayAbilitySpecHandle._ScriptStructPtr);
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x0006C55D File Offset: 0x0006A75D
		// (set) Token: 0x06004D88 RID: 19848 RVA: 0x0006C56D File Offset: 0x0006A76D
		public unsafe int Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandle.__PropertyOffset_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandle.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x0006C57E File Offset: 0x0006A77E
		public FGameplayAbilitySpecHandle()
		{
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x0006C586 File Offset: 0x0006A786
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpecHandle.StaticStruct();
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x0006C592 File Offset: 0x0006A792
		[NullableContext(2)]
		public FGameplayAbilitySpecHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x0006C59C File Offset: 0x0006A79C
		public FGameplayAbilitySpecHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x0006C5A7 File Offset: 0x0006A7A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpecHandle(Pointer, false, true);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x0006C5B1 File Offset: 0x0006A7B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpecHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04001EED RID: 7917
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpecHandle";

		// Token: 0x04001EEE RID: 7918
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EEF RID: 7919
		internal static int __PropertyOffset_Handle;
	}
}
