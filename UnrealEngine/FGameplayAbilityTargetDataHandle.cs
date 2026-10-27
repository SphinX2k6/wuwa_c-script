using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200135F RID: 4959
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetDataHandle")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGameplayAbilityTargetDataHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012308 RID: 74504 RVA: 0x001AB4B5 File Offset: 0x001A96B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetDataHandle._ScriptStructPtr != 0) ? FGameplayAbilityTargetDataHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetDataHandle", ref FGameplayAbilityTargetDataHandle._ScriptStructPtr);
		}

		// Token: 0x06012309 RID: 74505 RVA: 0x001AB4D9 File Offset: 0x001A96D9
		public FGameplayAbilityTargetDataHandle()
		{
		}

		// Token: 0x0601230A RID: 74506 RVA: 0x001AB4E1 File Offset: 0x001A96E1
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetDataHandle.StaticStruct();
		}

		// Token: 0x0601230B RID: 74507 RVA: 0x001AB4ED File Offset: 0x001A96ED
		[NullableContext(2)]
		public FGameplayAbilityTargetDataHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601230C RID: 74508 RVA: 0x001AB4F7 File Offset: 0x001A96F7
		public FGameplayAbilityTargetDataHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601230D RID: 74509 RVA: 0x001AB502 File Offset: 0x001A9702
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetDataHandle(Pointer, false, true);
		}

		// Token: 0x0601230E RID: 74510 RVA: 0x001AB50C File Offset: 0x001A970C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetDataHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009BE8 RID: 39912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetDataHandle";

		// Token: 0x04009BE9 RID: 39913
		private static IntPtr _ScriptStructPtr;
	}
}
