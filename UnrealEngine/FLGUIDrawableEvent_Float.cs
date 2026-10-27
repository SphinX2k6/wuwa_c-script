using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200204A RID: 8266
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent_Float")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIDrawableEvent_Float : FLGUIDrawableEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F3D9 RID: 127961 RVA: 0x002E638E File Offset: 0x002E458E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent_Float._ScriptStructPtr != 0) ? FLGUIDrawableEvent_Float._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent_Float", ref FLGUIDrawableEvent_Float._ScriptStructPtr);
		}

		// Token: 0x0601F3DA RID: 127962 RVA: 0x002E63B2 File Offset: 0x002E45B2
		public FLGUIDrawableEvent_Float()
		{
		}

		// Token: 0x0601F3DB RID: 127963 RVA: 0x002E63BA File Offset: 0x002E45BA
		[NullableContext(1)]
		public FLGUIDrawableEvent_Float(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			base.eventList = eventList;
			base.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F3DC RID: 127964 RVA: 0x002E63D0 File Offset: 0x002E45D0
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent_Float.StaticStruct();
		}

		// Token: 0x0601F3DD RID: 127965 RVA: 0x002E63DC File Offset: 0x002E45DC
		[NullableContext(2)]
		public FLGUIDrawableEvent_Float(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3DE RID: 127966 RVA: 0x002E63E6 File Offset: 0x002E45E6
		public FLGUIDrawableEvent_Float(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3DF RID: 127967 RVA: 0x002E63F1 File Offset: 0x002E45F1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent_Float(Pointer, false, true);
		}

		// Token: 0x0601F3E0 RID: 127968 RVA: 0x002E63FB File Offset: 0x002E45FB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent_Float(Pointer, MemoryOwner);
		}

		// Token: 0x04010E80 RID: 69248
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Float";

		// Token: 0x04010E81 RID: 69249
		private static IntPtr _ScriptStructPtr;
	}
}
