using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002067 RID: 8295
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Vector4")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Vector4 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4CD RID: 128205 RVA: 0x002E7AC6 File Offset: 0x002E5CC6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Vector4._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Vector4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Vector4", ref FLGUIDrawableEvent_Vector4._ScriptStructPtr);
		}

		// Token: 0x0601F4CE RID: 128206 RVA: 0x002E7AEA File Offset: 0x002E5CEA
		public FLGUIDrawableEvent_Vector4()
		{
		}

		// Token: 0x0601F4CF RID: 128207 RVA: 0x002E7AF2 File Offset: 0x002E5CF2
		[NullableContext(1)]
		public FLGUIDrawableEvent_Vector4(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F4D0 RID: 128208 RVA: 0x002E7B08 File Offset: 0x002E5D08
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Vector4.StaticStruct();
		}

		// Token: 0x0601F4D1 RID: 128209 RVA: 0x002E7B14 File Offset: 0x002E5D14
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector4(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4D2 RID: 128210 RVA: 0x002E7B1E File Offset: 0x002E5D1E
		public FLGUIDrawableEvent_Vector4(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4D3 RID: 128211 RVA: 0x002E7B29 File Offset: 0x002E5D29
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Vector4(Pointer, false, true);
		}

		// Token: 0x0601F4D4 RID: 128212 RVA: 0x002E7B33 File Offset: 0x002E5D33
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Vector4(Pointer, MemoryOwner);
		}

		// Token: 0x04010EC6 RID: 69318
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector4";

		// Token: 0x04010EC7 RID: 69319
		private static IntPtr _ScriptStructPtr;
	}
}
