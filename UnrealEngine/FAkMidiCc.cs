using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000222 RID: 546
	[UnrealObjectPath("/Script/AkAudio.AkMidiCc")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkMidiCc : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x0002FB36 File Offset: 0x0002DD36
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiCc._ScriptStructPtr != 0) ? FAkMidiCc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiCc", ref FAkMidiCc._ScriptStructPtr);
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0002FB5A File Offset: 0x0002DD5A
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x0002FB6A File Offset: 0x0002DD6A
		public unsafe EAkMidiCcValues Cc
		{
			get
			{
				return (EAkMidiCcValues)(*(base.NativePtr + (IntPtr)FAkMidiCc.__PropertyOffset_Cc));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiCc.__PropertyOffset_Cc) = (byte)value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0002FB7B File Offset: 0x0002DD7B
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0002FB8B File Offset: 0x0002DD8B
		public unsafe byte Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiCc.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiCc.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0002FB9C File Offset: 0x0002DD9C
		public FAkMidiCc()
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0002FBA4 File Offset: 0x0002DDA4
		public FAkMidiCc(EAkMidiCcValues Cc, byte Value, EAkMidiEventType Type, byte Chan)
		{
			this.Cc = Cc;
			this.Value = Value;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0002FBC9 File Offset: 0x0002DDC9
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiCc.StaticStruct();
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0002FBD5 File Offset: 0x0002DDD5
		[NullableContext(2)]
		public FAkMidiCc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0002FBDF File Offset: 0x0002DDDF
		public FAkMidiCc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0002FBEA File Offset: 0x0002DDEA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiCc(Pointer, false, true);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiCc(Pointer, MemoryOwner);
		}

		// Token: 0x04000AC7 RID: 2759
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiCc";

		// Token: 0x04000AC8 RID: 2760
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AC9 RID: 2761
		internal static int __PropertyOffset_Cc;

		// Token: 0x04000ACA RID: 2762
		internal static int __PropertyOffset_Value;
	}
}
