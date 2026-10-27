using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000226 RID: 550
	[UnrealObjectPath("/Script/AkAudio.AkMidiGeneric")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkMidiGeneric : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x000302E1 File Offset: 0x0002E4E1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiGeneric._ScriptStructPtr != 0) ? FAkMidiGeneric._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiGeneric", ref FAkMidiGeneric._ScriptStructPtr);
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x00030305 File Offset: 0x0002E505
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00030315 File Offset: 0x0002E515
		public unsafe byte Param1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiGeneric.__PropertyOffset_Param1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiGeneric.__PropertyOffset_Param1) = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00030326 File Offset: 0x0002E526
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00030336 File Offset: 0x0002E536
		public unsafe byte Param2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiGeneric.__PropertyOffset_Param2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiGeneric.__PropertyOffset_Param2) = value;
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00030347 File Offset: 0x0002E547
		public FAkMidiGeneric()
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0003034F File Offset: 0x0002E54F
		public FAkMidiGeneric(byte Param1, byte Param2, EAkMidiEventType Type, byte Chan)
		{
			this.Param1 = Param1;
			this.Param2 = Param2;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00030374 File Offset: 0x0002E574
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiGeneric.StaticStruct();
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00030380 File Offset: 0x0002E580
		[NullableContext(2)]
		public FAkMidiGeneric(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0003038A File Offset: 0x0002E58A
		public FAkMidiGeneric(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00030395 File Offset: 0x0002E595
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiGeneric(Pointer, false, true);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0003039F File Offset: 0x0002E59F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiGeneric(Pointer, MemoryOwner);
		}

		// Token: 0x04000ADF RID: 2783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiGeneric";

		// Token: 0x04000AE0 RID: 2784
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AE1 RID: 2785
		internal static int __PropertyOffset_Param1;

		// Token: 0x04000AE2 RID: 2786
		internal static int __PropertyOffset_Param2;
	}
}
