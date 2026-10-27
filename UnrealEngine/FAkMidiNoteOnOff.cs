using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000228 RID: 552
	[UnrealObjectPath("/Script/AkAudio.AkMidiNoteOnOff")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkMidiNoteOnOff : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x0003046F File Offset: 0x0002E66F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiNoteOnOff._ScriptStructPtr != 0) ? FAkMidiNoteOnOff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiNoteOnOff", ref FAkMidiNoteOnOff._ScriptStructPtr);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00030493 File Offset: 0x0002E693
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x000304A3 File Offset: 0x0002E6A3
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000304B4 File Offset: 0x0002E6B4
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x000304C4 File Offset: 0x0002E6C4
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

		// Token: 0x0600207C RID: 8316 RVA: 0x000304D5 File Offset: 0x0002E6D5
		public FAkMidiNoteOnOff()
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000304DD File Offset: 0x0002E6DD
		public FAkMidiNoteOnOff(byte Note, byte Velocity, EAkMidiEventType Type, byte Chan)
		{
			this.Note = Note;
			this.Velocity = Velocity;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00030502 File Offset: 0x0002E702
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiNoteOnOff.StaticStruct();
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0003050E File Offset: 0x0002E70E
		[NullableContext(2)]
		public FAkMidiNoteOnOff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00030518 File Offset: 0x0002E718
		public FAkMidiNoteOnOff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00030523 File Offset: 0x0002E723
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiNoteOnOff(Pointer, false, true);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0003052D File Offset: 0x0002E72D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiNoteOnOff(Pointer, MemoryOwner);
		}

		// Token: 0x04000AE7 RID: 2791
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiNoteOnOff";

		// Token: 0x04000AE8 RID: 2792
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AE9 RID: 2793
		internal static int __PropertyOffset_Note;

		// Token: 0x04000AEA RID: 2794
		internal static int __PropertyOffset_Velocity;
	}
}
