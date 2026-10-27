using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B0 RID: 1712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SendEvent")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_SendEvent : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B4B RID: 23371 RVA: 0x000830C4 File Offset: 0x000812C4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SendEvent._ScriptStructPtr != 0) ? FRigUnit_SendEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SendEvent", ref FRigUnit_SendEvent._ScriptStructPtr);
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x000830E8 File Offset: 0x000812E8
		// (set) Token: 0x06005B4D RID: 23373 RVA: 0x000830F8 File Offset: 0x000812F8
		public unsafe ERigEvent Event
		{
			get
			{
				return (ERigEvent)(*(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_Event));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_Event) = (byte)value;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x0008310C File Offset: 0x0008130C
		// (set) Token: 0x06005B4F RID: 23375 RVA: 0x0008314F File Offset: 0x0008134F
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x00083170 File Offset: 0x00081370
		// (set) Token: 0x06005B51 RID: 23377 RVA: 0x00083180 File Offset: 0x00081380
		public unsafe float OffsetInSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_OffsetInSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_OffsetInSeconds) = value;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x00083191 File Offset: 0x00081391
		// (set) Token: 0x06005B53 RID: 23379 RVA: 0x000831A1 File Offset: 0x000813A1
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x000831B2 File Offset: 0x000813B2
		// (set) Token: 0x06005B55 RID: 23381 RVA: 0x000831C2 File Offset: 0x000813C2
		public unsafe bool bOnlyDuringInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_bOnlyDuringInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SendEvent.__PropertyOffset_bOnlyDuringInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x000831D3 File Offset: 0x000813D3
		public FRigUnit_SendEvent()
		{
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x000831DB File Offset: 0x000813DB
		public FRigUnit_SendEvent(ERigEvent Event, FRigElementKey Item, float OffsetInSeconds, bool bEnable, bool bOnlyDuringInteraction, FControlRigExecuteContext ExecuteContext)
		{
			this.Event = Event;
			this.Item = Item;
			this.OffsetInSeconds = OffsetInSeconds;
			this.bEnable = bEnable;
			this.bOnlyDuringInteraction = bOnlyDuringInteraction;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00083210 File Offset: 0x00081410
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SendEvent.StaticStruct();
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x0008321C File Offset: 0x0008141C
		[NullableContext(2)]
		public FRigUnit_SendEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00083226 File Offset: 0x00081426
		public FRigUnit_SendEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00083231 File Offset: 0x00081431
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SendEvent(Pointer, false, true);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x0008323B File Offset: 0x0008143B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SendEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04002ABD RID: 10941
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SendEvent";

		// Token: 0x04002ABE RID: 10942
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002ABF RID: 10943
		internal static int __PropertyOffset_Event;

		// Token: 0x04002AC0 RID: 10944
		internal static int __PropertyOffset_Item;

		// Token: 0x04002AC1 RID: 10945
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002AC2 RID: 10946
		internal static int __PropertyOffset_OffsetInSeconds;

		// Token: 0x04002AC3 RID: 10947
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04002AC4 RID: 10948
		internal static int __PropertyOffset_bOnlyDuringInteraction;
	}
}
