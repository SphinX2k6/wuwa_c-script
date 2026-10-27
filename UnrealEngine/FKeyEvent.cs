using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002820 RID: 10272
	[UnrealObjectPath("/Script/SlateCore.KeyEvent")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKeyEvent : FInputEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262D4 RID: 156372 RVA: 0x0039EF27 File Offset: 0x0039D127
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKeyEvent._ScriptStructPtr != 0) ? FKeyEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.KeyEvent", ref FKeyEvent._ScriptStructPtr);
		}

		// Token: 0x060262D5 RID: 156373 RVA: 0x0039EF4B File Offset: 0x0039D14B
		public FKeyEvent()
		{
		}

		// Token: 0x060262D6 RID: 156374 RVA: 0x0039EF53 File Offset: 0x0039D153
		protected override IntPtr GetUStructPtr()
		{
			return FKeyEvent.StaticStruct();
		}

		// Token: 0x060262D7 RID: 156375 RVA: 0x0039EF5F File Offset: 0x0039D15F
		[NullableContext(2)]
		public FKeyEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262D8 RID: 156376 RVA: 0x0039EF69 File Offset: 0x0039D169
		public FKeyEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262D9 RID: 156377 RVA: 0x0039EF74 File Offset: 0x0039D174
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKeyEvent(Pointer, false, true);
		}

		// Token: 0x060262DA RID: 156378 RVA: 0x0039EF7E File Offset: 0x0039D17E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKeyEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E54 RID: 85588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.KeyEvent";

		// Token: 0x04014E55 RID: 85589
		private static IntPtr _ScriptStructPtr;
	}
}
