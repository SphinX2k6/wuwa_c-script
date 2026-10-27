using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200135E RID: 4958
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FGameplayAbilityTargetData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012301 RID: 74497 RVA: 0x001AB455 File Offset: 0x001A9655
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetData._ScriptStructPtr != 0) ? FGameplayAbilityTargetData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetData", ref FGameplayAbilityTargetData._ScriptStructPtr);
		}

		// Token: 0x06012302 RID: 74498 RVA: 0x001AB479 File Offset: 0x001A9679
		public FGameplayAbilityTargetData()
		{
		}

		// Token: 0x06012303 RID: 74499 RVA: 0x001AB481 File Offset: 0x001A9681
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetData.StaticStruct();
		}

		// Token: 0x06012304 RID: 74500 RVA: 0x001AB48D File Offset: 0x001A968D
		[NullableContext(2)]
		public FGameplayAbilityTargetData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012305 RID: 74501 RVA: 0x001AB497 File Offset: 0x001A9697
		public FGameplayAbilityTargetData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012306 RID: 74502 RVA: 0x001AB4A2 File Offset: 0x001A96A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetData(Pointer, false, true);
		}

		// Token: 0x06012307 RID: 74503 RVA: 0x001AB4AC File Offset: 0x001A96AC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetData(Pointer, MemoryOwner);
		}

		// Token: 0x04009BE6 RID: 39910
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetData";

		// Token: 0x04009BE7 RID: 39911
		private static IntPtr _ScriptStructPtr;
	}
}
