using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200204F RID: 8271
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Int64")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Int64 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F403 RID: 128003 RVA: 0x002E6776 File Offset: 0x002E4976
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Int64._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Int64._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Int64", ref FLGUIDrawableEvent_Int64._ScriptStructPtr);
		}

		// Token: 0x0601F404 RID: 128004 RVA: 0x002E679A File Offset: 0x002E499A
		public FLGUIDrawableEvent_Int64()
		{
		}

		// Token: 0x0601F405 RID: 128005 RVA: 0x002E67A2 File Offset: 0x002E49A2
		[NullableContext(1)]
		public FLGUIDrawableEvent_Int64(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F406 RID: 128006 RVA: 0x002E67B8 File Offset: 0x002E49B8
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Int64.StaticStruct();
		}

		// Token: 0x0601F407 RID: 128007 RVA: 0x002E67C4 File Offset: 0x002E49C4
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int64(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F408 RID: 128008 RVA: 0x002E67CE File Offset: 0x002E49CE
		public FLGUIDrawableEvent_Int64(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F409 RID: 128009 RVA: 0x002E67D9 File Offset: 0x002E49D9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Int64(Pointer, false, true);
		}

		// Token: 0x0601F40A RID: 128010 RVA: 0x002E67E3 File Offset: 0x002E49E3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Int64(Pointer, MemoryOwner);
		}

		// Token: 0x04010E8C RID: 69260
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int64";

		// Token: 0x04010E8D RID: 69261
		private static IntPtr _ScriptStructPtr;
	}
}
