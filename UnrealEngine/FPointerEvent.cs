using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002824 RID: 10276
	[UnrealObjectPath("/Script/SlateCore.PointerEvent")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FPointerEvent : FInputEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262F0 RID: 156400 RVA: 0x0039F124 File Offset: 0x0039D324
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointerEvent._ScriptStructPtr != 0) ? FPointerEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.PointerEvent", ref FPointerEvent._ScriptStructPtr);
		}

		// Token: 0x060262F1 RID: 156401 RVA: 0x0039F148 File Offset: 0x0039D348
		public FPointerEvent()
		{
		}

		// Token: 0x060262F2 RID: 156402 RVA: 0x0039F150 File Offset: 0x0039D350
		protected override IntPtr GetUStructPtr()
		{
			return FPointerEvent.StaticStruct();
		}

		// Token: 0x060262F3 RID: 156403 RVA: 0x0039F15C File Offset: 0x0039D35C
		[NullableContext(2)]
		public FPointerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262F4 RID: 156404 RVA: 0x0039F166 File Offset: 0x0039D366
		public FPointerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262F5 RID: 156405 RVA: 0x0039F171 File Offset: 0x0039D371
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointerEvent(Pointer, false, true);
		}

		// Token: 0x060262F6 RID: 156406 RVA: 0x0039F17B File Offset: 0x0039D37B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointerEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E60 RID: 85600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.PointerEvent";

		// Token: 0x04014E61 RID: 85601
		private static IntPtr _ScriptStructPtr;
	}
}
