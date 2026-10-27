using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002056 RID: 8278
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_PointerEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_PointerEvent : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F43E RID: 128062 RVA: 0x002E6D29 File Offset: 0x002E4F29
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_PointerEvent._ScriptStructPtr != 0) ? FLGUIDrawableEvent_PointerEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_PointerEvent", ref FLGUIDrawableEvent_PointerEvent._ScriptStructPtr);
		}

		// Token: 0x0601F43F RID: 128063 RVA: 0x002E6D4D File Offset: 0x002E4F4D
		public FLGUIDrawableEvent_PointerEvent()
		{
		}

		// Token: 0x0601F440 RID: 128064 RVA: 0x002E6D55 File Offset: 0x002E4F55
		[NullableContext(1)]
		public FLGUIDrawableEvent_PointerEvent(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F441 RID: 128065 RVA: 0x002E6D6B File Offset: 0x002E4F6B
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_PointerEvent.StaticStruct();
		}

		// Token: 0x0601F442 RID: 128066 RVA: 0x002E6D77 File Offset: 0x002E4F77
		[NullableContext(2)]
		public FLGUIDrawableEvent_PointerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F443 RID: 128067 RVA: 0x002E6D81 File Offset: 0x002E4F81
		public FLGUIDrawableEvent_PointerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F444 RID: 128068 RVA: 0x002E6D8C File Offset: 0x002E4F8C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_PointerEvent(Pointer, false, true);
		}

		// Token: 0x0601F445 RID: 128069 RVA: 0x002E6D96 File Offset: 0x002E4F96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_PointerEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04010E9D RID: 69277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_PointerEvent";

		// Token: 0x04010E9E RID: 69278
		private static IntPtr _ScriptStructPtr;
	}
}
