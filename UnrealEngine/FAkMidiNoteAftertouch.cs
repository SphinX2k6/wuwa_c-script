using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000227 RID: 551
	[UnrealObjectPath("/Script/AkAudio.AkMidiNoteAftertouch")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkMidiNoteAftertouch : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600206B RID: 8299 RVA: 0x000303A8 File Offset: 0x0002E5A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiNoteAftertouch._ScriptStructPtr != 0) ? FAkMidiNoteAftertouch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiNoteAftertouch", ref FAkMidiNoteAftertouch._ScriptStructPtr);
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000303CC File Offset: 0x0002E5CC
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x000303DC File Offset: 0x0002E5DC
		public unsafe byte Note
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiNoteAftertouch.__PropertyOffset_Note);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiNoteAftertouch.__PropertyOffset_Note) = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000303ED File Offset: 0x0002E5ED
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x000303FD File Offset: 0x0002E5FD
		public unsafe byte Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiNoteAftertouch.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiNoteAftertouch.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0003040E File Offset: 0x0002E60E
		public FAkMidiNoteAftertouch()
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00030416 File Offset: 0x0002E616
		public FAkMidiNoteAftertouch(byte Note, byte Value, EAkMidiEventType Type, byte Chan)
		{
			this.Note = Note;
			this.Value = Value;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0003043B File Offset: 0x0002E63B
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiNoteAftertouch.StaticStruct();
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00030447 File Offset: 0x0002E647
		[NullableContext(2)]
		public FAkMidiNoteAftertouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00030451 File Offset: 0x0002E651
		public FAkMidiNoteAftertouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0003045C File Offset: 0x0002E65C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiNoteAftertouch(Pointer, false, true);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00030466 File Offset: 0x0002E666
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiNoteAftertouch(Pointer, MemoryOwner);
		}

		// Token: 0x04000AE3 RID: 2787
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiNoteAftertouch";

		// Token: 0x04000AE4 RID: 2788
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AE5 RID: 2789
		internal static int __PropertyOffset_Note;

		// Token: 0x04000AE6 RID: 2790
		internal static int __PropertyOffset_Value;
	}
}
