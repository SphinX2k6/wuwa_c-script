using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001392 RID: 5010
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectSpecHandle")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameplayEffectSpecHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012674 RID: 75380 RVA: 0x001B0D43 File Offset: 0x001AEF43
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectSpecHandle._ScriptStructPtr != 0) ? FGameplayEffectSpecHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectSpecHandle", ref FGameplayEffectSpecHandle._ScriptStructPtr);
		}

		// Token: 0x06012675 RID: 75381 RVA: 0x001B0D67 File Offset: 0x001AEF67
		public FGameplayEffectSpecHandle()
		{
		}

		// Token: 0x06012676 RID: 75382 RVA: 0x001B0D6F File Offset: 0x001AEF6F
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectSpecHandle.StaticStruct();
		}

		// Token: 0x06012677 RID: 75383 RVA: 0x001B0D7B File Offset: 0x001AEF7B
		[NullableContext(2)]
		public FGameplayEffectSpecHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012678 RID: 75384 RVA: 0x001B0D85 File Offset: 0x001AEF85
		public FGameplayEffectSpecHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x001B0D90 File Offset: 0x001AEF90
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectSpecHandle(Pointer, false, true);
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x001B0D9A File Offset: 0x001AEF9A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectSpecHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009DB0 RID: 40368
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectSpecHandle";

		// Token: 0x04009DB1 RID: 40369
		private static IntPtr _ScriptStructPtr;
	}
}
