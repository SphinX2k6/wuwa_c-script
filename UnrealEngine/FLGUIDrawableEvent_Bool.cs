using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002041 RID: 8257
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Bool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Bool : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F38D RID: 127885 RVA: 0x002E5C71 File Offset: 0x002E3E71
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Bool._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Bool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Bool", ref FLGUIDrawableEvent_Bool._ScriptStructPtr);
		}

		// Token: 0x0601F38E RID: 127886 RVA: 0x002E5C95 File Offset: 0x002E3E95
		public FLGUIDrawableEvent_Bool()
		{
		}

		// Token: 0x0601F38F RID: 127887 RVA: 0x002E5C9D File Offset: 0x002E3E9D
		[NullableContext(1)]
		public FLGUIDrawableEvent_Bool(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F390 RID: 127888 RVA: 0x002E5CB3 File Offset: 0x002E3EB3
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Bool.StaticStruct();
		}

		// Token: 0x0601F391 RID: 127889 RVA: 0x002E5CBF File Offset: 0x002E3EBF
		[NullableContext(2)]
		public FLGUIDrawableEvent_Bool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F392 RID: 127890 RVA: 0x002E5CC9 File Offset: 0x002E3EC9
		public FLGUIDrawableEvent_Bool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F393 RID: 127891 RVA: 0x002E5CD4 File Offset: 0x002E3ED4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Bool(Pointer, false, true);
		}

		// Token: 0x0601F394 RID: 127892 RVA: 0x002E5CDE File Offset: 0x002E3EDE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Bool(Pointer, MemoryOwner);
		}

		// Token: 0x04010E6A RID: 69226
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Bool";

		// Token: 0x04010E6B RID: 69227
		private static IntPtr _ScriptStructPtr;
	}
}
