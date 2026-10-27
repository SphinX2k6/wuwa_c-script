using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000224 RID: 548
	[UnrealObjectPath("/Script/AkAudio.AkMidiEventBase")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FAkMidiEventBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002044 RID: 8260 RVA: 0x0002FC9B File Offset: 0x0002DE9B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiEventBase._ScriptStructPtr != 0) ? FAkMidiEventBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiEventBase", ref FAkMidiEventBase._ScriptStructPtr);
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0002FCBF File Offset: 0x0002DEBF
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x0002FCCF File Offset: 0x0002DECF
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0002FCE0 File Offset: 0x0002DEE0
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x0002FCF0 File Offset: 0x0002DEF0
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

		// Token: 0x06002049 RID: 8265 RVA: 0x0002FD01 File Offset: 0x0002DF01
		public FAkMidiEventBase()
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0002FD09 File Offset: 0x0002DF09
		public FAkMidiEventBase(EAkMidiEventType Type, byte Chan)
		{
			this.Type = Type;
			this.Chan = Chan;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0002FD1F File Offset: 0x0002DF1F
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiEventBase.StaticStruct();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0002FD2B File Offset: 0x0002DF2B
		[NullableContext(2)]
		public FAkMidiEventBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0002FD35 File Offset: 0x0002DF35
		public FAkMidiEventBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0002FD40 File Offset: 0x0002DF40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiEventBase(Pointer, false, true);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0002FD4A File Offset: 0x0002DF4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiEventBase(Pointer, MemoryOwner);
		}

		// Token: 0x04000ACE RID: 2766
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkMidiEventBase";

		// Token: 0x04000ACF RID: 2767
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AD0 RID: 2768
		internal static int __PropertyOffset_Type;

		// Token: 0x04000AD1 RID: 2769
		internal static int __PropertyOffset_Chan;
	}
}
