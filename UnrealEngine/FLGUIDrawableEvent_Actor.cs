using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200203F RID: 8255
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Actor")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Actor : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F37C RID: 127868 RVA: 0x002E5AA3 File Offset: 0x002E3CA3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Actor._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Actor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Actor", ref FLGUIDrawableEvent_Actor._ScriptStructPtr);
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x002E5AC7 File Offset: 0x002E3CC7
		public FLGUIDrawableEvent_Actor()
		{
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x002E5ACF File Offset: 0x002E3CCF
		[NullableContext(1)]
		public FLGUIDrawableEvent_Actor(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F37F RID: 127871 RVA: 0x002E5AE5 File Offset: 0x002E3CE5
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Actor.StaticStruct();
		}

		// Token: 0x0601F380 RID: 127872 RVA: 0x002E5AF1 File Offset: 0x002E3CF1
		[NullableContext(2)]
		public FLGUIDrawableEvent_Actor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F381 RID: 127873 RVA: 0x002E5AFB File Offset: 0x002E3CFB
		public FLGUIDrawableEvent_Actor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F382 RID: 127874 RVA: 0x002E5B06 File Offset: 0x002E3D06
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Actor(Pointer, false, true);
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x002E5B10 File Offset: 0x002E3D10
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Actor(Pointer, MemoryOwner);
		}

		// Token: 0x04010E65 RID: 69221
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Actor";

		// Token: 0x04010E66 RID: 69222
		private static IntPtr _ScriptStructPtr;
	}
}
