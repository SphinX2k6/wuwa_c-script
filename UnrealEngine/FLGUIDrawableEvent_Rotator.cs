using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200205A RID: 8282
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Rotator")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Rotator : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F460 RID: 128096 RVA: 0x002E70AE File Offset: 0x002E52AE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Rotator._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Rotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Rotator", ref FLGUIDrawableEvent_Rotator._ScriptStructPtr);
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x002E70D2 File Offset: 0x002E52D2
		public FLGUIDrawableEvent_Rotator()
		{
		}

		// Token: 0x0601F462 RID: 128098 RVA: 0x002E70DA File Offset: 0x002E52DA
		[NullableContext(1)]
		public FLGUIDrawableEvent_Rotator(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F463 RID: 128099 RVA: 0x002E70F0 File Offset: 0x002E52F0
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Rotator.StaticStruct();
		}

		// Token: 0x0601F464 RID: 128100 RVA: 0x002E70FC File Offset: 0x002E52FC
		[NullableContext(2)]
		public FLGUIDrawableEvent_Rotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F465 RID: 128101 RVA: 0x002E7106 File Offset: 0x002E5306
		public FLGUIDrawableEvent_Rotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F466 RID: 128102 RVA: 0x002E7111 File Offset: 0x002E5311
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Rotator(Pointer, false, true);
		}

		// Token: 0x0601F467 RID: 128103 RVA: 0x002E711B File Offset: 0x002E531B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Rotator(Pointer, MemoryOwner);
		}

		// Token: 0x04010EA7 RID: 69287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Rotator";

		// Token: 0x04010EA8 RID: 69288
		private static IntPtr _ScriptStructPtr;
	}
}
