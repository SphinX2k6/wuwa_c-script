using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F6 RID: 246
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.DateTime")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FDateTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x0001AE46 File Offset: 0x00019046
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDateTime._ScriptStructPtr != 0) ? FDateTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.DateTime", ref FDateTime._ScriptStructPtr);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0001AE6A File Offset: 0x0001906A
		public FDateTime()
		{
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0001AE72 File Offset: 0x00019072
		protected override IntPtr GetUStructPtr()
		{
			return FDateTime.StaticStruct();
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0001AE7E File Offset: 0x0001907E
		[NullableContext(2)]
		public FDateTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0001AE88 File Offset: 0x00019088
		public FDateTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0001AE93 File Offset: 0x00019093
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDateTime(Pointer, false, true);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0001AE9D File Offset: 0x0001909D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDateTime(Pointer, MemoryOwner);
		}

		// Token: 0x0400042E RID: 1070
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.DateTime";

		// Token: 0x0400042F RID: 1071
		private static IntPtr _ScriptStructPtr;
	}
}
