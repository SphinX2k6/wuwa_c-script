using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200203C RID: 8252
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLGUIDrawableEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F34E RID: 127822 RVA: 0x002E56AE File Offset: 0x002E38AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEvent._ScriptStructPtr != 0) ? FLGUIDrawableEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEvent", ref FLGUIDrawableEvent._ScriptStructPtr);
		}

		// Token: 0x17007BAB RID: 31659
		// (get) Token: 0x0601F34F RID: 127823 RVA: 0x002E56D4 File Offset: 0x002E38D4
		// (set) Token: 0x0601F350 RID: 127824 RVA: 0x002E5717 File Offset: 0x002E3917
		public TArray<FLGUIDrawableEventData> eventList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUIDrawableEventData> result;
				if ((result = this._eventList) == null)
				{
					result = (this._eventList = new TArray<FLGUIDrawableEventData>(base.NativePtr + (IntPtr)FLGUIDrawableEvent.__PropertyOffset_eventList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.eventList.CopyAssign(value);
			}
		}

		// Token: 0x17007BAC RID: 31660
		// (get) Token: 0x0601F351 RID: 127825 RVA: 0x002E5725 File Offset: 0x002E3925
		// (set) Token: 0x0601F352 RID: 127826 RVA: 0x002E5735 File Offset: 0x002E3935
		public unsafe LGUIDrawableEventParameterType supportParameterType
		{
			get
			{
				return (LGUIDrawableEventParameterType)(*(base.NativePtr + (IntPtr)FLGUIDrawableEvent.__PropertyOffset_supportParameterType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEvent.__PropertyOffset_supportParameterType) = (byte)value;
			}
		}

		// Token: 0x0601F353 RID: 127827 RVA: 0x002E5746 File Offset: 0x002E3946
		public FLGUIDrawableEvent()
		{
		}

		// Token: 0x0601F354 RID: 127828 RVA: 0x002E574E File Offset: 0x002E394E
		public FLGUIDrawableEvent(TArray<FLGUIDrawableEventData> eventList, LGUIDrawableEventParameterType supportParameterType)
		{
			this.eventList = eventList;
			this.supportParameterType = supportParameterType;
		}

		// Token: 0x0601F355 RID: 127829 RVA: 0x002E5764 File Offset: 0x002E3964
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEvent.StaticStruct();
		}

		// Token: 0x0601F356 RID: 127830 RVA: 0x002E5770 File Offset: 0x002E3970
		[NullableContext(2)]
		public FLGUIDrawableEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F357 RID: 127831 RVA: 0x002E577A File Offset: 0x002E397A
		public FLGUIDrawableEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F358 RID: 127832 RVA: 0x002E5785 File Offset: 0x002E3985
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEvent(Pointer, false, true);
		}

		// Token: 0x0601F359 RID: 127833 RVA: 0x002E578F File Offset: 0x002E398F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04010E35 RID: 69173
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent";

		// Token: 0x04010E36 RID: 69174
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010E37 RID: 69175
		internal static int __PropertyOffset_eventList;

		// Token: 0x04010E38 RID: 69176
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUIDrawableEventData> _eventList;

		// Token: 0x04010E39 RID: 69177
		internal static int __PropertyOffset_supportParameterType;
	}
}
