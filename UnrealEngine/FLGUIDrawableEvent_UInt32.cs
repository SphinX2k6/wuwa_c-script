using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200205F RID: 8287
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_UInt32")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_UInt32 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F48A RID: 128138 RVA: 0x002E74B0 File Offset: 0x002E56B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_UInt32._ScriptStructPtr != 0) ? FLGUIDrawableEvent_UInt32._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_UInt32", ref FLGUIDrawableEvent_UInt32._ScriptStructPtr);
		}

		// Token: 0x0601F48B RID: 128139 RVA: 0x002E74D4 File Offset: 0x002E56D4
		public FLGUIDrawableEvent_UInt32()
		{
		}

		// Token: 0x0601F48C RID: 128140 RVA: 0x002E74DC File Offset: 0x002E56DC
		[NullableContext(1)]
		public FLGUIDrawableEvent_UInt32(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F48D RID: 128141 RVA: 0x002E74F2 File Offset: 0x002E56F2
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_UInt32.StaticStruct();
		}

		// Token: 0x0601F48E RID: 128142 RVA: 0x002E74FE File Offset: 0x002E56FE
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt32(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F48F RID: 128143 RVA: 0x002E7508 File Offset: 0x002E5708
		public FLGUIDrawableEvent_UInt32(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F490 RID: 128144 RVA: 0x002E7513 File Offset: 0x002E5713
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_UInt32(Pointer, false, true);
		}

		// Token: 0x0601F491 RID: 128145 RVA: 0x002E751D File Offset: 0x002E571D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_UInt32(Pointer, MemoryOwner);
		}

		// Token: 0x04010EB3 RID: 69299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt32";

		// Token: 0x04010EB4 RID: 69300
		private static IntPtr _ScriptStructPtr;
	}
}
