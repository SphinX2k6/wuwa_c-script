using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000C7 RID: 199
	[UnrealObjectPath("/Script/AkAudio.AkMidiEventBase")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FAkMidiEventBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00016F46 File Offset: 0x00015146
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiEventBase._ScriptStructPtr != 0) ? FAkMidiEventBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiEventBase", ref FAkMidiEventBase._ScriptStructPtr);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00016F6A File Offset: 0x0001516A
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00016F7A File Offset: 0x0001517A
		public unsafe EAkMidiEventType Type
		{
			get
			{
				return (EAkMidiEventType)(*(base.NativePtr + (IntPtr)FAkMidiEventBase.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiEventBase.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00016F8B File Offset: 0x0001518B
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00016F9B File Offset: 0x0001519B
		public unsafe byte Chan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiEventBase.__PropertyOffset_Chan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiEventBase.__PropertyOffset_Chan) = value;
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00016FAC File Offset: 0x000151AC
		public FAkMidiEventBase()
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00016FB4 File Offset: 0x000151B4
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiEventBase.StaticStruct();
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00016FC0 File Offset: 0x000151C0
		[NullableContext(2)]
		public FAkMidiEventBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00016FCA File Offset: 0x000151CA
		public FAkMidiEventBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00016FD5 File Offset: 0x000151D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiEventBase(Pointer, false, true);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00016FDF File Offset: 0x000151DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiEventBase(Pointer, MemoryOwner);
		}

		// Token: 0x040002E3 RID: 739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkMidiEventBase";

		// Token: 0x040002E4 RID: 740
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002E5 RID: 741
		internal static int __PropertyOffset_Type;

		// Token: 0x040002E6 RID: 742
		internal static int __PropertyOffset_Chan;
	}
}
