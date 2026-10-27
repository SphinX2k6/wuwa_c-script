using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002060 RID: 8288
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_UInt64")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_UInt64 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F492 RID: 128146 RVA: 0x002E7526 File Offset: 0x002E5726
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_UInt64._ScriptStructPtr != 0) ? FLGUIDrawableEvent_UInt64._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_UInt64", ref FLGUIDrawableEvent_UInt64._ScriptStructPtr);
		}

		// Token: 0x0601F493 RID: 128147 RVA: 0x002E754A File Offset: 0x002E574A
		public FLGUIDrawableEvent_UInt64()
		{
		}

		// Token: 0x0601F494 RID: 128148 RVA: 0x002E7552 File Offset: 0x002E5752
		[NullableContext(1)]
		public FLGUIDrawableEvent_UInt64(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F495 RID: 128149 RVA: 0x002E7568 File Offset: 0x002E5768
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_UInt64.StaticStruct();
		}

		// Token: 0x0601F496 RID: 128150 RVA: 0x002E7574 File Offset: 0x002E5774
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt64(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F497 RID: 128151 RVA: 0x002E757E File Offset: 0x002E577E
		public FLGUIDrawableEvent_UInt64(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F498 RID: 128152 RVA: 0x002E7589 File Offset: 0x002E5789
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_UInt64(Pointer, false, true);
		}

		// Token: 0x0601F499 RID: 128153 RVA: 0x002E7593 File Offset: 0x002E5793
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_UInt64(Pointer, MemoryOwner);
		}

		// Token: 0x04010EB5 RID: 69301
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt64";

		// Token: 0x04010EB6 RID: 69302
		private static IntPtr _ScriptStructPtr;
	}
}
