using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001320 RID: 4896
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayEffectQuery")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FActiveGameplayEffectQuery : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601209E RID: 73886 RVA: 0x001A7C34 File Offset: 0x001A5E34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayEffectQuery._ScriptStructPtr != 0) ? FActiveGameplayEffectQuery._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayEffectQuery", ref FActiveGameplayEffectQuery._ScriptStructPtr);
		}

		// Token: 0x0601209F RID: 73887 RVA: 0x001A7C58 File Offset: 0x001A5E58
		public FActiveGameplayEffectQuery()
		{
		}

		// Token: 0x060120A0 RID: 73888 RVA: 0x001A7C60 File Offset: 0x001A5E60
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayEffectQuery.StaticStruct();
		}

		// Token: 0x060120A1 RID: 73889 RVA: 0x001A7C6C File Offset: 0x001A5E6C
		[NullableContext(2)]
		public FActiveGameplayEffectQuery(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120A2 RID: 73890 RVA: 0x001A7C76 File Offset: 0x001A5E76
		public FActiveGameplayEffectQuery(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120A3 RID: 73891 RVA: 0x001A7C81 File Offset: 0x001A5E81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayEffectQuery(Pointer, false, true);
		}

		// Token: 0x060120A4 RID: 73892 RVA: 0x001A7C8B File Offset: 0x001A5E8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayEffectQuery(Pointer, MemoryOwner);
		}

		// Token: 0x04009A2A RID: 39466
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffectQuery";

		// Token: 0x04009A2B RID: 39467
		private static IntPtr _ScriptStructPtr;
	}
}
