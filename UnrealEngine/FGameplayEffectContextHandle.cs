using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001384 RID: 4996
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectContextHandle")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayEffectContextHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012584 RID: 75140 RVA: 0x001AF284 File Offset: 0x001AD484
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectContextHandle._ScriptStructPtr != 0) ? FGameplayEffectContextHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectContextHandle", ref FGameplayEffectContextHandle._ScriptStructPtr);
		}

		// Token: 0x06012585 RID: 75141 RVA: 0x001AF2A8 File Offset: 0x001AD4A8
		public FGameplayEffectContextHandle()
		{
		}

		// Token: 0x06012586 RID: 75142 RVA: 0x001AF2B0 File Offset: 0x001AD4B0
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectContextHandle.StaticStruct();
		}

		// Token: 0x06012587 RID: 75143 RVA: 0x001AF2BC File Offset: 0x001AD4BC
		[NullableContext(2)]
		public FGameplayEffectContextHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x001AF2C6 File Offset: 0x001AD4C6
		public FGameplayEffectContextHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012589 RID: 75145 RVA: 0x001AF2D1 File Offset: 0x001AD4D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectContextHandle(Pointer, false, true);
		}

		// Token: 0x0601258A RID: 75146 RVA: 0x001AF2DB File Offset: 0x001AD4DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectContextHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009D25 RID: 40229
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectContextHandle";

		// Token: 0x04009D26 RID: 40230
		private static IntPtr _ScriptStructPtr;
	}
}
