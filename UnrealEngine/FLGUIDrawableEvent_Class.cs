using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002043 RID: 8259
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Class")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Class : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F39E RID: 127902 RVA: 0x002E5E2A File Offset: 0x002E402A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Class._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Class._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Class", ref FLGUIDrawableEvent_Class._ScriptStructPtr);
		}

		// Token: 0x0601F39F RID: 127903 RVA: 0x002E5E4E File Offset: 0x002E404E
		public FLGUIDrawableEvent_Class()
		{
		}

		// Token: 0x0601F3A0 RID: 127904 RVA: 0x002E5E56 File Offset: 0x002E4056
		[NullableContext(1)]
		public FLGUIDrawableEvent_Class(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3A1 RID: 127905 RVA: 0x002E5E6C File Offset: 0x002E406C
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Class.StaticStruct();
		}

		// Token: 0x0601F3A2 RID: 127906 RVA: 0x002E5E78 File Offset: 0x002E4078
		[NullableContext(2)]
		public FLGUIDrawableEvent_Class(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3A3 RID: 127907 RVA: 0x002E5E82 File Offset: 0x002E4082
		public FLGUIDrawableEvent_Class(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3A4 RID: 127908 RVA: 0x002E5E8D File Offset: 0x002E408D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Class(Pointer, false, true);
		}

		// Token: 0x0601F3A5 RID: 127909 RVA: 0x002E5E97 File Offset: 0x002E4097
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Class(Pointer, MemoryOwner);
		}

		// Token: 0x04010E6F RID: 69231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Class";

		// Token: 0x04010E70 RID: 69232
		private static IntPtr _ScriptStructPtr;
	}
}
