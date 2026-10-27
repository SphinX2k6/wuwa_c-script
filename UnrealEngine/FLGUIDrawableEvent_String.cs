using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200205C RID: 8284
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_String")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_String : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F471 RID: 128113 RVA: 0x002E7266 File Offset: 0x002E5466
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_String._ScriptStructPtr != 0) ? FLGUIDrawableEvent_String._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_String", ref FLGUIDrawableEvent_String._ScriptStructPtr);
		}

		// Token: 0x0601F472 RID: 128114 RVA: 0x002E728A File Offset: 0x002E548A
		public FLGUIDrawableEvent_String()
		{
		}

		// Token: 0x0601F473 RID: 128115 RVA: 0x002E7292 File Offset: 0x002E5492
		[NullableContext(1)]
		public FLGUIDrawableEvent_String(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F474 RID: 128116 RVA: 0x002E72A8 File Offset: 0x002E54A8
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_String.StaticStruct();
		}

		// Token: 0x0601F475 RID: 128117 RVA: 0x002E72B4 File Offset: 0x002E54B4
		[NullableContext(2)]
		public FLGUIDrawableEvent_String(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F476 RID: 128118 RVA: 0x002E72BE File Offset: 0x002E54BE
		public FLGUIDrawableEvent_String(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F477 RID: 128119 RVA: 0x002E72C9 File Offset: 0x002E54C9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_String(Pointer, false, true);
		}

		// Token: 0x0601F478 RID: 128120 RVA: 0x002E72D3 File Offset: 0x002E54D3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_String(Pointer, MemoryOwner);
		}

		// Token: 0x04010EAC RID: 69292
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_String";

		// Token: 0x04010EAD RID: 69293
		private static IntPtr _ScriptStructPtr;
	}
}
