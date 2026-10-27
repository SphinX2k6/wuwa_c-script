using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200076C RID: 1900
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.Timespan")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTimespan : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063C4 RID: 25540 RVA: 0x0008F45E File Offset: 0x0008D65E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimespan._ScriptStructPtr != 0) ? FTimespan._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Timespan", ref FTimespan._ScriptStructPtr);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x0008F482 File Offset: 0x0008D682
		public FTimespan()
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x0008F48A File Offset: 0x0008D68A
		protected override IntPtr GetUStructPtr()
		{
			return FTimespan.StaticStruct();
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x0008F496 File Offset: 0x0008D696
		[NullableContext(2)]
		public FTimespan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		public FTimespan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x0008F4AB File Offset: 0x0008D6AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimespan(Pointer, false, true);
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x0008F4B5 File Offset: 0x0008D6B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimespan(Pointer, MemoryOwner);
		}

		// Token: 0x04002FD8 RID: 12248
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.Timespan";

		// Token: 0x04002FD9 RID: 12249
		private static IntPtr _ScriptStructPtr;
	}
}
