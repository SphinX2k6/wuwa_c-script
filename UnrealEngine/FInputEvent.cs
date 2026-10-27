using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200281F RID: 10271
	[UnrealObjectPath("/Script/SlateCore.InputEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInputEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262CD RID: 156365 RVA: 0x0039EEC7 File Offset: 0x0039D0C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputEvent._ScriptStructPtr != 0) ? FInputEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.InputEvent", ref FInputEvent._ScriptStructPtr);
		}

		// Token: 0x060262CE RID: 156366 RVA: 0x0039EEEB File Offset: 0x0039D0EB
		public FInputEvent()
		{
		}

		// Token: 0x060262CF RID: 156367 RVA: 0x0039EEF3 File Offset: 0x0039D0F3
		protected override IntPtr GetUStructPtr()
		{
			return FInputEvent.StaticStruct();
		}

		// Token: 0x060262D0 RID: 156368 RVA: 0x0039EEFF File Offset: 0x0039D0FF
		[NullableContext(2)]
		public FInputEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262D1 RID: 156369 RVA: 0x0039EF09 File Offset: 0x0039D109
		public FInputEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262D2 RID: 156370 RVA: 0x0039EF14 File Offset: 0x0039D114
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputEvent(Pointer, false, true);
		}

		// Token: 0x060262D3 RID: 156371 RVA: 0x0039EF1E File Offset: 0x0039D11E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E52 RID: 85586
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.InputEvent";

		// Token: 0x04014E53 RID: 85587
		private static IntPtr _ScriptStructPtr;
	}
}
