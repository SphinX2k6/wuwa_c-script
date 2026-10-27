using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002061 RID: 8289
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_UInt8")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_UInt8 : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F49A RID: 128154 RVA: 0x002E759C File Offset: 0x002E579C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_UInt8._ScriptStructPtr != 0) ? FLGUIDrawableEvent_UInt8._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_UInt8", ref FLGUIDrawableEvent_UInt8._ScriptStructPtr);
		}

		// Token: 0x0601F49B RID: 128155 RVA: 0x002E75C0 File Offset: 0x002E57C0
		public FLGUIDrawableEvent_UInt8()
		{
		}

		// Token: 0x0601F49C RID: 128156 RVA: 0x002E75C8 File Offset: 0x002E57C8
		[NullableContext(1)]
		public FLGUIDrawableEvent_UInt8(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F49D RID: 128157 RVA: 0x002E75DE File Offset: 0x002E57DE
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_UInt8.StaticStruct();
		}

		// Token: 0x0601F49E RID: 128158 RVA: 0x002E75EA File Offset: 0x002E57EA
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt8(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F49F RID: 128159 RVA: 0x002E75F4 File Offset: 0x002E57F4
		public FLGUIDrawableEvent_UInt8(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4A0 RID: 128160 RVA: 0x002E75FF File Offset: 0x002E57FF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_UInt8(Pointer, false, true);
		}

		// Token: 0x0601F4A1 RID: 128161 RVA: 0x002E7609 File Offset: 0x002E5809
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_UInt8(Pointer, MemoryOwner);
		}

		// Token: 0x04010EB7 RID: 69303
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt8";

		// Token: 0x04010EB8 RID: 69304
		private static IntPtr _ScriptStructPtr;
	}
}
