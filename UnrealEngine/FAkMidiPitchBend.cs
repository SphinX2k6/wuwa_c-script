using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000229 RID: 553
	[UnrealObjectPath("/Script/AkAudio.AkMidiPitchBend")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAkMidiPitchBend : FAkMidiEventBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00030536 File Offset: 0x0002E736
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMidiPitchBend._ScriptStructPtr != 0) ? FAkMidiPitchBend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMidiPitchBend", ref FAkMidiPitchBend._ScriptStructPtr);
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x0003055A File Offset: 0x0002E75A
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x0003056A File Offset: 0x0002E76A
		public unsafe byte ValueLsb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_ValueLsb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_ValueLsb) = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x0003057B File Offset: 0x0002E77B
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x0003058B File Offset: 0x0002E78B
		public unsafe byte ValueMsb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_ValueMsb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_ValueMsb) = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0003059C File Offset: 0x0002E79C
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x000305AC File Offset: 0x0002E7AC
		public unsafe int FullValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_FullValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMidiPitchBend.__PropertyOffset_FullValue) = value;
			}
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000305BD File Offset: 0x0002E7BD
		public FAkMidiPitchBend()
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000305C5 File Offset: 0x0002E7C5
		public FAkMidiPitchBend(byte ValueLsb, byte ValueMsb, int FullValue, EAkMidiEventType Type, byte Chan)
		{
			this.ValueLsb = ValueLsb;
			this.ValueMsb = ValueMsb;
			this.FullValue = FullValue;
			base.Type = Type;
			base.Chan = Chan;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000305F2 File Offset: 0x0002E7F2
		protected override IntPtr GetUStructPtr()
		{
			return FAkMidiPitchBend.StaticStruct();
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000305FE File Offset: 0x0002E7FE
		[NullableContext(2)]
		public FAkMidiPitchBend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00030608 File Offset: 0x0002E808
		public FAkMidiPitchBend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00030613 File Offset: 0x0002E813
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMidiPitchBend(Pointer, false, true);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0003061D File Offset: 0x0002E81D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMidiPitchBend(Pointer, MemoryOwner);
		}

		// Token: 0x04000AEB RID: 2795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMidiPitchBend";

		// Token: 0x04000AEC RID: 2796
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AED RID: 2797
		internal static int __PropertyOffset_ValueLsb;

		// Token: 0x04000AEE RID: 2798
		internal static int __PropertyOffset_ValueMsb;

		// Token: 0x04000AEF RID: 2799
		internal static int __PropertyOffset_FullValue;
	}
}
