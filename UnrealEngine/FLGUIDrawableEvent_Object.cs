using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002054 RID: 8276
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Object")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Object : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F42D RID: 128045 RVA: 0x002E6B5E File Offset: 0x002E4D5E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Object._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Object._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Object", ref FLGUIDrawableEvent_Object._ScriptStructPtr);
		}

		// Token: 0x0601F42E RID: 128046 RVA: 0x002E6B82 File Offset: 0x002E4D82
		public FLGUIDrawableEvent_Object()
		{
		}

		// Token: 0x0601F42F RID: 128047 RVA: 0x002E6B8A File Offset: 0x002E4D8A
		[NullableContext(1)]
		public FLGUIDrawableEvent_Object(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F430 RID: 128048 RVA: 0x002E6BA0 File Offset: 0x002E4DA0
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Object.StaticStruct();
		}

		// Token: 0x0601F431 RID: 128049 RVA: 0x002E6BAC File Offset: 0x002E4DAC
		[NullableContext(2)]
		public FLGUIDrawableEvent_Object(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F432 RID: 128050 RVA: 0x002E6BB6 File Offset: 0x002E4DB6
		public FLGUIDrawableEvent_Object(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F433 RID: 128051 RVA: 0x002E6BC1 File Offset: 0x002E4DC1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Object(Pointer, false, true);
		}

		// Token: 0x0601F434 RID: 128052 RVA: 0x002E6BCB File Offset: 0x002E4DCB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Object(Pointer, MemoryOwner);
		}

		// Token: 0x04010E98 RID: 69272
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Object";

		// Token: 0x04010E99 RID: 69273
		private static IntPtr _ScriptStructPtr;
	}
}
