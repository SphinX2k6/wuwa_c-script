using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002052 RID: 8274
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_LinearColor")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_LinearColor : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F41C RID: 128028 RVA: 0x002E69A4 File Offset: 0x002E4BA4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_LinearColor._ScriptStructPtr != 0) ? FLGUIDrawableEvent_LinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_LinearColor", ref FLGUIDrawableEvent_LinearColor._ScriptStructPtr);
		}

		// Token: 0x0601F41D RID: 128029 RVA: 0x002E69C8 File Offset: 0x002E4BC8
		public FLGUIDrawableEvent_LinearColor()
		{
		}

		// Token: 0x0601F41E RID: 128030 RVA: 0x002E69D0 File Offset: 0x002E4BD0
		[NullableContext(1)]
		public FLGUIDrawableEvent_LinearColor(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F41F RID: 128031 RVA: 0x002E69E6 File Offset: 0x002E4BE6
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_LinearColor.StaticStruct();
		}

		// Token: 0x0601F420 RID: 128032 RVA: 0x002E69F2 File Offset: 0x002E4BF2
		[NullableContext(2)]
		public FLGUIDrawableEvent_LinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F421 RID: 128033 RVA: 0x002E69FC File Offset: 0x002E4BFC
		public FLGUIDrawableEvent_LinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F422 RID: 128034 RVA: 0x002E6A07 File Offset: 0x002E4C07
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_LinearColor(Pointer, false, true);
		}

		// Token: 0x0601F423 RID: 128035 RVA: 0x002E6A11 File Offset: 0x002E4C11
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_LinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x04010E93 RID: 69267
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_LinearColor";

		// Token: 0x04010E94 RID: 69268
		private static IntPtr _ScriptStructPtr;
	}
}
