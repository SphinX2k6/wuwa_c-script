using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013EF RID: 5103
	[UnrealObjectPath("/Script/GameplayTasks.GameplayResourceSet")]
	[UnrealStructLayout(2, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FGameplayResourceSet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012A46 RID: 76358 RVA: 0x001B6E04 File Offset: 0x001B5004
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayResourceSet._ScriptStructPtr != 0) ? FGameplayResourceSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTasks.GameplayResourceSet", ref FGameplayResourceSet._ScriptStructPtr);
		}

		// Token: 0x06012A47 RID: 76359 RVA: 0x001B6E28 File Offset: 0x001B5028
		public FGameplayResourceSet()
		{
		}

		// Token: 0x06012A48 RID: 76360 RVA: 0x001B6E30 File Offset: 0x001B5030
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayResourceSet.StaticStruct();
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x001B6E3C File Offset: 0x001B503C
		[NullableContext(2)]
		public FGameplayResourceSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x001B6E46 File Offset: 0x001B5046
		public FGameplayResourceSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x001B6E51 File Offset: 0x001B5051
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayResourceSet(Pointer, false, true);
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x001B6E5B File Offset: 0x001B505B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayResourceSet(Pointer, MemoryOwner);
		}

		// Token: 0x04009F65 RID: 40805
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayResourceSet";

		// Token: 0x04009F66 RID: 40806
		private static IntPtr _ScriptStructPtr;
	}
}
