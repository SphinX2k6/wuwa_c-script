using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F17 RID: 7959
	[UnrealObjectPath("/Script/KuroUtility.XboxMultiplayerEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxMultiplayerEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E334 RID: 123700 RVA: 0x002CE643 File Offset: 0x002CC843
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxMultiplayerEvent._ScriptStructPtr != 0) ? FXboxMultiplayerEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxMultiplayerEvent", ref FXboxMultiplayerEvent._ScriptStructPtr);
		}

		// Token: 0x170077F1 RID: 30705
		// (get) Token: 0x0601E335 RID: 123701 RVA: 0x002CE667 File Offset: 0x002CC867
		// (set) Token: 0x0601E336 RID: 123702 RVA: 0x002CE677 File Offset: 0x002CC877
		public unsafe bool bValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_bValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_bValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077F2 RID: 30706
		// (get) Token: 0x0601E337 RID: 123703 RVA: 0x002CE688 File Offset: 0x002CC888
		// (set) Token: 0x0601E338 RID: 123704 RVA: 0x002CE698 File Offset: 0x002CC898
		public unsafe int EventType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_EventType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_EventType) = value;
			}
		}

		// Token: 0x170077F3 RID: 30707
		// (get) Token: 0x0601E339 RID: 123705 RVA: 0x002CE6A9 File Offset: 0x002CC8A9
		// (set) Token: 0x0601E33A RID: 123706 RVA: 0x002CE6B9 File Offset: 0x002CC8B9
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170077F4 RID: 30708
		// (get) Token: 0x0601E33B RID: 123707 RVA: 0x002CE6CA File Offset: 0x002CC8CA
		// (set) Token: 0x0601E33C RID: 123708 RVA: 0x002CE6DA File Offset: 0x002CC8DA
		public unsafe int SessionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_SessionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_SessionType) = value;
			}
		}

		// Token: 0x170077F5 RID: 30709
		// (get) Token: 0x0601E33D RID: 123709 RVA: 0x002CE6EB File Offset: 0x002CC8EB
		// (set) Token: 0x0601E33E RID: 123710 RVA: 0x002CE6FB File Offset: 0x002CC8FB
		public unsafe long EventArgsHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_EventArgsHandle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerEvent.__PropertyOffset_EventArgsHandle) = value;
			}
		}

		// Token: 0x0601E33F RID: 123711 RVA: 0x002CE70C File Offset: 0x002CC90C
		public FXboxMultiplayerEvent()
		{
		}

		// Token: 0x0601E340 RID: 123712 RVA: 0x002CE714 File Offset: 0x002CC914
		public FXboxMultiplayerEvent(bool bValid, int EventType, int Result, int SessionType, long EventArgsHandle)
		{
			this.bValid = bValid;
			this.EventType = EventType;
			this.Result = Result;
			this.SessionType = SessionType;
			this.EventArgsHandle = EventArgsHandle;
		}

		// Token: 0x0601E341 RID: 123713 RVA: 0x002CE741 File Offset: 0x002CC941
		protected override IntPtr GetUStructPtr()
		{
			return FXboxMultiplayerEvent.StaticStruct();
		}

		// Token: 0x0601E342 RID: 123714 RVA: 0x002CE74D File Offset: 0x002CC94D
		[NullableContext(2)]
		public FXboxMultiplayerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E343 RID: 123715 RVA: 0x002CE757 File Offset: 0x002CC957
		public FXboxMultiplayerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E344 RID: 123716 RVA: 0x002CE762 File Offset: 0x002CC962
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxMultiplayerEvent(Pointer, false, true);
		}

		// Token: 0x0601E345 RID: 123717 RVA: 0x002CE76C File Offset: 0x002CC96C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxMultiplayerEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040104D0 RID: 66768
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxMultiplayerEvent";

		// Token: 0x040104D1 RID: 66769
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104D2 RID: 66770
		internal static int __PropertyOffset_bValid;

		// Token: 0x040104D3 RID: 66771
		internal static int __PropertyOffset_EventType;

		// Token: 0x040104D4 RID: 66772
		internal static int __PropertyOffset_Result;

		// Token: 0x040104D5 RID: 66773
		internal static int __PropertyOffset_SessionType;

		// Token: 0x040104D6 RID: 66774
		internal static int __PropertyOffset_EventArgsHandle;
	}
}
