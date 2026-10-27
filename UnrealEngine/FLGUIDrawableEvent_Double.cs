using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002047 RID: 8263
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Double")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Double : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3C0 RID: 127936 RVA: 0x002E619A File Offset: 0x002E439A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Double._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Double._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Double", ref FLGUIDrawableEvent_Double._ScriptStructPtr);
		}

		// Token: 0x0601F3C1 RID: 127937 RVA: 0x002E61BE File Offset: 0x002E43BE
		public FLGUIDrawableEvent_Double()
		{
		}

		// Token: 0x0601F3C2 RID: 127938 RVA: 0x002E61C6 File Offset: 0x002E43C6
		[NullableContext(1)]
		public FLGUIDrawableEvent_Double(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3C3 RID: 127939 RVA: 0x002E61DC File Offset: 0x002E43DC
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Double.StaticStruct();
		}

		// Token: 0x0601F3C4 RID: 127940 RVA: 0x002E61E8 File Offset: 0x002E43E8
		[NullableContext(2)]
		public FLGUIDrawableEvent_Double(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3C5 RID: 127941 RVA: 0x002E61F2 File Offset: 0x002E43F2
		public FLGUIDrawableEvent_Double(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3C6 RID: 127942 RVA: 0x002E61FD File Offset: 0x002E43FD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Double(Pointer, false, true);
		}

		// Token: 0x0601F3C7 RID: 127943 RVA: 0x002E6207 File Offset: 0x002E4407
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Double(Pointer, MemoryOwner);
		}

		// Token: 0x04010E79 RID: 69241
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Double";

		// Token: 0x04010E7A RID: 69242
		private static IntPtr _ScriptStructPtr;
	}
}
