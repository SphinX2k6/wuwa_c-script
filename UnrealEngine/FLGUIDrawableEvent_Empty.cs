using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002048 RID: 8264
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Empty")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Empty : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3C8 RID: 127944 RVA: 0x002E6210 File Offset: 0x002E4410
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Empty._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Empty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Empty", ref FLGUIDrawableEvent_Empty._ScriptStructPtr);
		}

		// Token: 0x0601F3C9 RID: 127945 RVA: 0x002E6234 File Offset: 0x002E4434
		public FLGUIDrawableEvent_Empty()
		{
		}

		// Token: 0x0601F3CA RID: 127946 RVA: 0x002E623C File Offset: 0x002E443C
		[NullableContext(1)]
		public FLGUIDrawableEvent_Empty(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3CB RID: 127947 RVA: 0x002E6252 File Offset: 0x002E4452
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Empty.StaticStruct();
		}

		// Token: 0x0601F3CC RID: 127948 RVA: 0x002E625E File Offset: 0x002E445E
		[NullableContext(2)]
		public FLGUIDrawableEvent_Empty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x002E6268 File Offset: 0x002E4468
		public FLGUIDrawableEvent_Empty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x002E6273 File Offset: 0x002E4473
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Empty(Pointer, false, true);
		}

		// Token: 0x0601F3CF RID: 127951 RVA: 0x002E627D File Offset: 0x002E447D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Empty(Pointer, MemoryOwner);
		}

		// Token: 0x04010E7B RID: 69243
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Empty";

		// Token: 0x04010E7C RID: 69244
		private static IntPtr _ScriptStructPtr;
	}
}
