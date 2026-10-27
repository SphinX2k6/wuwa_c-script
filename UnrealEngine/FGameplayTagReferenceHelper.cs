using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013E3 RID: 5091
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagReferenceHelper")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameplayTagReferenceHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060129CE RID: 76238 RVA: 0x001B63B8 File Offset: 0x001B45B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagReferenceHelper._ScriptStructPtr != 0) ? FGameplayTagReferenceHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagReferenceHelper", ref FGameplayTagReferenceHelper._ScriptStructPtr);
		}

		// Token: 0x060129CF RID: 76239 RVA: 0x001B63DC File Offset: 0x001B45DC
		public FGameplayTagReferenceHelper()
		{
		}

		// Token: 0x060129D0 RID: 76240 RVA: 0x001B63E4 File Offset: 0x001B45E4
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagReferenceHelper.StaticStruct();
		}

		// Token: 0x060129D1 RID: 76241 RVA: 0x001B63F0 File Offset: 0x001B45F0
		[NullableContext(2)]
		public FGameplayTagReferenceHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x001B63FA File Offset: 0x001B45FA
		public FGameplayTagReferenceHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x001B6405 File Offset: 0x001B4605
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagReferenceHelper(Pointer, false, true);
		}

		// Token: 0x060129D4 RID: 76244 RVA: 0x001B640F File Offset: 0x001B460F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagReferenceHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04009F1B RID: 40731
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagReferenceHelper";

		// Token: 0x04009F1C RID: 40732
		private static IntPtr _ScriptStructPtr;
	}
}
