using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200022A RID: 554
	[UnrealObjectPath("/Script/AkAudio.AkMidiProgramChange")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FAkMidiProgramChange : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002091 RID: 8337 RVA: 0x00030626 File Offset: 0x0002E826
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiProgramChange._ScriptStructPtr != 0) ? FAkMidiProgramChange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiProgramChange", ref FAkMidiProgramChange._ScriptStructPtr);
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0003064A File Offset: 0x0002E84A
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x0003065A File Offset: 0x0002E85A
		public unsafe byte ProgramNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiProgramChange.__PropertyOffset_ProgramNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiProgramChange.__PropertyOffset_ProgramNum) = value;
			}
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0003066B File Offset: 0x0002E86B
		public FAkMidiProgramChange()
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00030673 File Offset: 0x0002E873
		public FAkMidiProgramChange(byte ProgramNum, EAkMidiEventType Type, byte Chan)
		{
			this.ProgramNum = ProgramNum;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00030690 File Offset: 0x0002E890
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiProgramChange.StaticStruct();
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0003069C File Offset: 0x0002E89C
		[NullableContext(2)]
		public FAkMidiProgramChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000306A6 File Offset: 0x0002E8A6
		public FAkMidiProgramChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000306B1 File Offset: 0x0002E8B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiProgramChange(Pointer, false, true);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000306BB File Offset: 0x0002E8BB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiProgramChange(Pointer, MemoryOwner);
		}

		// Token: 0x04000AF0 RID: 2800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiProgramChange";

		// Token: 0x04000AF1 RID: 2801
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AF2 RID: 2802
		internal static int __PropertyOffset_ProgramNum;
	}
}
