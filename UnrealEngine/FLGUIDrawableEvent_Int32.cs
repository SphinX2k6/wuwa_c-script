using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200204D RID: 8269
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Int32")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Int32 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3F2 RID: 127986 RVA: 0x002E65BC File Offset: 0x002E47BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Int32._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Int32._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Int32", ref FLGUIDrawableEvent_Int32._ScriptStructPtr);
		}

		// Token: 0x0601F3F3 RID: 127987 RVA: 0x002E65E0 File Offset: 0x002E47E0
		public FLGUIDrawableEvent_Int32()
		{
		}

		// Token: 0x0601F3F4 RID: 127988 RVA: 0x002E65E8 File Offset: 0x002E47E8
		[NullableContext(1)]
		public FLGUIDrawableEvent_Int32(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3F5 RID: 127989 RVA: 0x002E65FE File Offset: 0x002E47FE
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Int32.StaticStruct();
		}

		// Token: 0x0601F3F6 RID: 127990 RVA: 0x002E660A File Offset: 0x002E480A
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int32(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3F7 RID: 127991 RVA: 0x002E6614 File Offset: 0x002E4814
		public FLGUIDrawableEvent_Int32(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3F8 RID: 127992 RVA: 0x002E661F File Offset: 0x002E481F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Int32(Pointer, false, true);
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x002E6629 File Offset: 0x002E4829
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Int32(Pointer, MemoryOwner);
		}

		// Token: 0x04010E87 RID: 69255
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int32";

		// Token: 0x04010E88 RID: 69256
		private static IntPtr _ScriptStructPtr;
	}
}
