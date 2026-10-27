using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027EA RID: 10218
	[UnrealObjectPath("/Script/SlateCore.AnalogInputEvent")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnalogInputEvent : FKeyEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602615F RID: 155999 RVA: 0x0039C454 File Offset: 0x0039A654
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnalogInputEvent._ScriptStructPtr != 0) ? FAnalogInputEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.AnalogInputEvent", ref FAnalogInputEvent._ScriptStructPtr);
		}

		// Token: 0x06026160 RID: 156000 RVA: 0x0039C478 File Offset: 0x0039A678
		public FAnalogInputEvent()
		{
		}

		// Token: 0x06026161 RID: 156001 RVA: 0x0039C480 File Offset: 0x0039A680
		protected override IntPtr GetUStructPtr()
		{
			return FAnalogInputEvent.StaticStruct();
		}

		// Token: 0x06026162 RID: 156002 RVA: 0x0039C48C File Offset: 0x0039A68C
		[NullableContext(2)]
		public FAnalogInputEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026163 RID: 156003 RVA: 0x0039C496 File Offset: 0x0039A696
		public FAnalogInputEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026164 RID: 156004 RVA: 0x0039C4A1 File Offset: 0x0039A6A1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnalogInputEvent(Pointer, false, true);
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x0039C4AB File Offset: 0x0039A6AB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnalogInputEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014CD4 RID: 85204
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.AnalogInputEvent";

		// Token: 0x04014CD5 RID: 85205
		private static IntPtr _ScriptStructPtr;
	}
}
