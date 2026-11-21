using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000C9 RID: 201
	[UnrealObjectPath("/Script/AkAudio.AkMidiNoteOnOff")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkMidiNoteOnOff : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x00017214 File Offset: 0x00015414
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiNoteOnOff._ScriptStructPtr != 0) ? FAkMidiNoteOnOff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiNoteOnOff", ref FAkMidiNoteOnOff._ScriptStructPtr);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00017238 File Offset: 0x00015438
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00017248 File Offset: 0x00015448
		public unsafe byte Note
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiNoteOnOff.__PropertyOffset_Note);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiNoteOnOff.__PropertyOffset_Note) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00017259 File Offset: 0x00015459
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00017269 File Offset: 0x00015469
		public unsafe byte Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiNoteOnOff.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiNoteOnOff.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0001727A File Offset: 0x0001547A
		public FAkMidiNoteOnOff()
		{
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00017282 File Offset: 0x00015482
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiNoteOnOff.StaticStruct();
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0001728E File Offset: 0x0001548E
		[NullableContext(2)]
		public FAkMidiNoteOnOff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00017298 File Offset: 0x00015498
		public FAkMidiNoteOnOff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000172A3 File Offset: 0x000154A3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiNoteOnOff(Pointer, false, true);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000172AD File Offset: 0x000154AD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiNoteOnOff(Pointer, MemoryOwner);
		}

		// Token: 0x040002EE RID: 750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiNoteOnOff";

		// Token: 0x040002EF RID: 751
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002F0 RID: 752
		internal static int __PropertyOffset_Note;

		// Token: 0x040002F1 RID: 753
		internal static int __PropertyOffset_Velocity;
	}
}
