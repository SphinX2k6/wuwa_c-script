using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002058 RID: 8280
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Quaternion")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Quaternion : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F44F RID: 128079 RVA: 0x002E6EF5 File Offset: 0x002E50F5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Quaternion._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Quaternion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Quaternion", ref FLGUIDrawableEvent_Quaternion._ScriptStructPtr);
		}

		// Token: 0x0601F450 RID: 128080 RVA: 0x002E6F19 File Offset: 0x002E5119
		public FLGUIDrawableEvent_Quaternion()
		{
		}

		// Token: 0x0601F451 RID: 128081 RVA: 0x002E6F21 File Offset: 0x002E5121
		[NullableContext(1)]
		public FLGUIDrawableEvent_Quaternion(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F452 RID: 128082 RVA: 0x002E6F37 File Offset: 0x002E5137
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Quaternion.StaticStruct();
		}

		// Token: 0x0601F453 RID: 128083 RVA: 0x002E6F43 File Offset: 0x002E5143
		[NullableContext(2)]
		public FLGUIDrawableEvent_Quaternion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F454 RID: 128084 RVA: 0x002E6F4D File Offset: 0x002E514D
		public FLGUIDrawableEvent_Quaternion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F455 RID: 128085 RVA: 0x002E6F58 File Offset: 0x002E5158
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Quaternion(Pointer, false, true);
		}

		// Token: 0x0601F456 RID: 128086 RVA: 0x002E6F62 File Offset: 0x002E5162
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Quaternion(Pointer, MemoryOwner);
		}

		// Token: 0x04010EA2 RID: 69282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Quaternion";

		// Token: 0x04010EA3 RID: 69283
		private static IntPtr _ScriptStructPtr;
	}
}
