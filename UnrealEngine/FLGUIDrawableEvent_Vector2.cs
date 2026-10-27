using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002063 RID: 8291
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Vector2")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Vector2 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4AB RID: 128171 RVA: 0x002E7756 File Offset: 0x002E5956
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Vector2._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Vector2._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Vector2", ref FLGUIDrawableEvent_Vector2._ScriptStructPtr);
		}

		// Token: 0x0601F4AC RID: 128172 RVA: 0x002E777A File Offset: 0x002E597A
		public FLGUIDrawableEvent_Vector2()
		{
		}

		// Token: 0x0601F4AD RID: 128173 RVA: 0x002E7782 File Offset: 0x002E5982
		[NullableContext(1)]
		public FLGUIDrawableEvent_Vector2(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F4AE RID: 128174 RVA: 0x002E7798 File Offset: 0x002E5998
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Vector2.StaticStruct();
		}

		// Token: 0x0601F4AF RID: 128175 RVA: 0x002E77A4 File Offset: 0x002E59A4
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector2(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4B0 RID: 128176 RVA: 0x002E77AE File Offset: 0x002E59AE
		public FLGUIDrawableEvent_Vector2(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4B1 RID: 128177 RVA: 0x002E77B9 File Offset: 0x002E59B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Vector2(Pointer, false, true);
		}

		// Token: 0x0601F4B2 RID: 128178 RVA: 0x002E77C3 File Offset: 0x002E59C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Vector2(Pointer, MemoryOwner);
		}

		// Token: 0x04010EBC RID: 69308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector2";

		// Token: 0x04010EBD RID: 69309
		private static IntPtr _ScriptStructPtr;
	}
}
