using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200204C RID: 8268
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Int16")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Int16 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3EA RID: 127978 RVA: 0x002E6546 File Offset: 0x002E4746
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Int16._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Int16._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Int16", ref FLGUIDrawableEvent_Int16._ScriptStructPtr);
		}

		// Token: 0x0601F3EB RID: 127979 RVA: 0x002E656A File Offset: 0x002E476A
		public FLGUIDrawableEvent_Int16()
		{
		}

		// Token: 0x0601F3EC RID: 127980 RVA: 0x002E6572 File Offset: 0x002E4772
		[NullableContext(1)]
		public FLGUIDrawableEvent_Int16(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3ED RID: 127981 RVA: 0x002E6588 File Offset: 0x002E4788
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Int16.StaticStruct();
		}

		// Token: 0x0601F3EE RID: 127982 RVA: 0x002E6594 File Offset: 0x002E4794
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int16(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3EF RID: 127983 RVA: 0x002E659E File Offset: 0x002E479E
		public FLGUIDrawableEvent_Int16(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3F0 RID: 127984 RVA: 0x002E65A9 File Offset: 0x002E47A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Int16(Pointer, false, true);
		}

		// Token: 0x0601F3F1 RID: 127985 RVA: 0x002E65B3 File Offset: 0x002E47B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Int16(Pointer, MemoryOwner);
		}

		// Token: 0x04010E85 RID: 69253
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int16";

		// Token: 0x04010E86 RID: 69254
		private static IntPtr _ScriptStructPtr;
	}
}
