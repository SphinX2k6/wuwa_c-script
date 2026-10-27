using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200205E RID: 8286
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_UInt16")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_UInt16 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F482 RID: 128130 RVA: 0x002E743A File Offset: 0x002E563A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_UInt16._ScriptStructPtr != 0) ? FLGUIDrawableEvent_UInt16._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_UInt16", ref FLGUIDrawableEvent_UInt16._ScriptStructPtr);
		}

		// Token: 0x0601F483 RID: 128131 RVA: 0x002E745E File Offset: 0x002E565E
		public FLGUIDrawableEvent_UInt16()
		{
		}

		// Token: 0x0601F484 RID: 128132 RVA: 0x002E7466 File Offset: 0x002E5666
		[NullableContext(1)]
		public FLGUIDrawableEvent_UInt16(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F485 RID: 128133 RVA: 0x002E747C File Offset: 0x002E567C
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_UInt16.StaticStruct();
		}

		// Token: 0x0601F486 RID: 128134 RVA: 0x002E7488 File Offset: 0x002E5688
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt16(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F487 RID: 128135 RVA: 0x002E7492 File Offset: 0x002E5692
		public FLGUIDrawableEvent_UInt16(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F488 RID: 128136 RVA: 0x002E749D File Offset: 0x002E569D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_UInt16(Pointer, false, true);
		}

		// Token: 0x0601F489 RID: 128137 RVA: 0x002E74A7 File Offset: 0x002E56A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_UInt16(Pointer, MemoryOwner);
		}

		// Token: 0x04010EB1 RID: 69297
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt16";

		// Token: 0x04010EB2 RID: 69298
		private static IntPtr _ScriptStructPtr;
	}
}
