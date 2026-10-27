using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000223 RID: 547
	[UnrealObjectPath("/Script/AkAudio.AkMidiChannelAftertouch")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FAkMidiChannelAftertouch : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600203A RID: 8250 RVA: 0x0002FBFD File Offset: 0x0002DDFD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiChannelAftertouch._ScriptStructPtr != 0) ? FAkMidiChannelAftertouch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiChannelAftertouch", ref FAkMidiChannelAftertouch._ScriptStructPtr);
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0002FC21 File Offset: 0x0002DE21
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x0002FC31 File Offset: 0x0002DE31
		public unsafe byte Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiChannelAftertouch.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiChannelAftertouch.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0002FC42 File Offset: 0x0002DE42
		public FAkMidiChannelAftertouch()
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0002FC4A File Offset: 0x0002DE4A
		public FAkMidiChannelAftertouch(byte Value, EAkMidiEventType Type, byte Chan)
		{
			this.Value = Value;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0002FC67 File Offset: 0x0002DE67
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiChannelAftertouch.StaticStruct();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0002FC73 File Offset: 0x0002DE73
		[NullableContext(2)]
		public FAkMidiChannelAftertouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0002FC7D File Offset: 0x0002DE7D
		public FAkMidiChannelAftertouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0002FC88 File Offset: 0x0002DE88
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiChannelAftertouch(Pointer, false, true);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0002FC92 File Offset: 0x0002DE92
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiChannelAftertouch(Pointer, MemoryOwner);
		}

		// Token: 0x04000ACB RID: 2763
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiChannelAftertouch";

		// Token: 0x04000ACC RID: 2764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000ACD RID: 2765
		internal static int __PropertyOffset_Value;
	}
}
