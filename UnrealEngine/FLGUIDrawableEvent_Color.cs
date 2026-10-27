using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002045 RID: 8261
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Color")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Color : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3AF RID: 127919 RVA: 0x002E5FE2 File Offset: 0x002E41E2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Color._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Color._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Color", ref FLGUIDrawableEvent_Color._ScriptStructPtr);
		}

		// Token: 0x0601F3B0 RID: 127920 RVA: 0x002E6006 File Offset: 0x002E4206
		public FLGUIDrawableEvent_Color()
		{
		}

		// Token: 0x0601F3B1 RID: 127921 RVA: 0x002E600E File Offset: 0x002E420E
		[NullableContext(1)]
		public FLGUIDrawableEvent_Color(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3B2 RID: 127922 RVA: 0x002E6024 File Offset: 0x002E4224
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Color.StaticStruct();
		}

		// Token: 0x0601F3B3 RID: 127923 RVA: 0x002E6030 File Offset: 0x002E4230
		[NullableContext(2)]
		public FLGUIDrawableEvent_Color(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3B4 RID: 127924 RVA: 0x002E603A File Offset: 0x002E423A
		public FLGUIDrawableEvent_Color(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3B5 RID: 127925 RVA: 0x002E6045 File Offset: 0x002E4245
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Color(Pointer, false, true);
		}

		// Token: 0x0601F3B6 RID: 127926 RVA: 0x002E604F File Offset: 0x002E424F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Color(Pointer, MemoryOwner);
		}

		// Token: 0x04010E74 RID: 69236
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Color";

		// Token: 0x04010E75 RID: 69237
		private static IntPtr _ScriptStructPtr;
	}
}
