using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002051 RID: 8273
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Int8")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Int8 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F414 RID: 128020 RVA: 0x002E692E File Offset: 0x002E4B2E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Int8._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Int8._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Int8", ref FLGUIDrawableEvent_Int8._ScriptStructPtr);
		}

		// Token: 0x0601F415 RID: 128021 RVA: 0x002E6952 File Offset: 0x002E4B52
		public FLGUIDrawableEvent_Int8()
		{
		}

		// Token: 0x0601F416 RID: 128022 RVA: 0x002E695A File Offset: 0x002E4B5A
		[NullableContext(1)]
		public FLGUIDrawableEvent_Int8(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F417 RID: 128023 RVA: 0x002E6970 File Offset: 0x002E4B70
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Int8.StaticStruct();
		}

		// Token: 0x0601F418 RID: 128024 RVA: 0x002E697C File Offset: 0x002E4B7C
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int8(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F419 RID: 128025 RVA: 0x002E6986 File Offset: 0x002E4B86
		public FLGUIDrawableEvent_Int8(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F41A RID: 128026 RVA: 0x002E6991 File Offset: 0x002E4B91
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Int8(Pointer, false, true);
		}

		// Token: 0x0601F41B RID: 128027 RVA: 0x002E699B File Offset: 0x002E4B9B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Int8(Pointer, MemoryOwner);
		}

		// Token: 0x04010E91 RID: 69265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int8";

		// Token: 0x04010E92 RID: 69266
		private static IntPtr _ScriptStructPtr;
	}
}
