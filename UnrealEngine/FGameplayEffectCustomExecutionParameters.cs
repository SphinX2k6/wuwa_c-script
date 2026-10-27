using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001388 RID: 5000
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectCustomExecutionParameters")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FGameplayEffectCustomExecutionParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125B3 RID: 75187 RVA: 0x001AF6F1 File Offset: 0x001AD8F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectCustomExecutionParameters._ScriptStructPtr != 0) ? FGameplayEffectCustomExecutionParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectCustomExecutionParameters", ref FGameplayEffectCustomExecutionParameters._ScriptStructPtr);
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x001AF715 File Offset: 0x001AD915
		public FGameplayEffectCustomExecutionParameters()
		{
		}

		// Token: 0x060125B5 RID: 75189 RVA: 0x001AF71D File Offset: 0x001AD91D
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectCustomExecutionParameters.StaticStruct();
		}

		// Token: 0x060125B6 RID: 75190 RVA: 0x001AF729 File Offset: 0x001AD929
		[NullableContext(2)]
		public FGameplayEffectCustomExecutionParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060125B7 RID: 75191 RVA: 0x001AF733 File Offset: 0x001AD933
		public FGameplayEffectCustomExecutionParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x001AF73E File Offset: 0x001AD93E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectCustomExecutionParameters(Pointer, false, true);
		}

		// Token: 0x060125B9 RID: 75193 RVA: 0x001AF748 File Offset: 0x001AD948
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectCustomExecutionParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04009D3C RID: 40252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectCustomExecutionParameters";

		// Token: 0x04009D3D RID: 40253
		private static IntPtr _ScriptStructPtr;
	}
}
