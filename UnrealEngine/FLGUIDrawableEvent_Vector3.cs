using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002065 RID: 8293
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Vector3")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Vector3 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4BC RID: 128188 RVA: 0x002E790E File Offset: 0x002E5B0E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Vector3._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Vector3._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Vector3", ref FLGUIDrawableEvent_Vector3._ScriptStructPtr);
		}

		// Token: 0x0601F4BD RID: 128189 RVA: 0x002E7932 File Offset: 0x002E5B32
		public FLGUIDrawableEvent_Vector3()
		{
		}

		// Token: 0x0601F4BE RID: 128190 RVA: 0x002E793A File Offset: 0x002E5B3A
		[NullableContext(1)]
		public FLGUIDrawableEvent_Vector3(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F4BF RID: 128191 RVA: 0x002E7950 File Offset: 0x002E5B50
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Vector3.StaticStruct();
		}

		// Token: 0x0601F4C0 RID: 128192 RVA: 0x002E795C File Offset: 0x002E5B5C
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector3(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4C1 RID: 128193 RVA: 0x002E7966 File Offset: 0x002E5B66
		public FLGUIDrawableEvent_Vector3(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4C2 RID: 128194 RVA: 0x002E7971 File Offset: 0x002E5B71
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Vector3(Pointer, false, true);
		}

		// Token: 0x0601F4C3 RID: 128195 RVA: 0x002E797B File Offset: 0x002E5B7B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Vector3(Pointer, MemoryOwner);
		}

		// Token: 0x04010EC1 RID: 69313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector3";

		// Token: 0x04010EC2 RID: 69314
		private static IntPtr _ScriptStructPtr;
	}
}
