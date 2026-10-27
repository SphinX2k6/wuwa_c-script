using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200115C RID: 4444
	[UnrealObjectPath("/Script/Engine.SoundWaveEnvelopeTimeData")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSoundWaveEnvelopeTimeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060103F2 RID: 66546 RVA: 0x0017F018 File Offset: 0x0017D218
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveEnvelopeTimeData._ScriptStructPtr != 0) ? FSoundWaveEnvelopeTimeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveEnvelopeTimeData", ref FSoundWaveEnvelopeTimeData._ScriptStructPtr);
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x060103F3 RID: 66547 RVA: 0x0017F03C File Offset: 0x0017D23C
		// (set) Token: 0x060103F4 RID: 66548 RVA: 0x0017F04C File Offset: 0x0017D24C
		public unsafe float Amplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveEnvelopeTimeData.__PropertyOffset_Amplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveEnvelopeTimeData.__PropertyOffset_Amplitude) = value;
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x060103F5 RID: 66549 RVA: 0x0017F05D File Offset: 0x0017D25D
		// (set) Token: 0x060103F6 RID: 66550 RVA: 0x0017F06D File Offset: 0x0017D26D
		public unsafe float TimeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveEnvelopeTimeData.__PropertyOffset_TimeSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveEnvelopeTimeData.__PropertyOffset_TimeSec) = value;
			}
		}

		// Token: 0x060103F7 RID: 66551 RVA: 0x0017F07E File Offset: 0x0017D27E
		public FSoundWaveEnvelopeTimeData()
		{
		}

		// Token: 0x060103F8 RID: 66552 RVA: 0x0017F086 File Offset: 0x0017D286
		public FSoundWaveEnvelopeTimeData(float Amplitude, float TimeSec)
		{
			this.Amplitude = Amplitude;
			this.TimeSec = TimeSec;
		}

		// Token: 0x060103F9 RID: 66553 RVA: 0x0017F09C File Offset: 0x0017D29C
		protected override IntPtr GetUStructPtr()
		{
			return FSoundWaveEnvelopeTimeData.StaticStruct();
		}

		// Token: 0x060103FA RID: 66554 RVA: 0x0017F0A8 File Offset: 0x0017D2A8
		[NullableContext(2)]
		public FSoundWaveEnvelopeTimeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060103FB RID: 66555 RVA: 0x0017F0B2 File Offset: 0x0017D2B2
		public FSoundWaveEnvelopeTimeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060103FC RID: 66556 RVA: 0x0017F0BD File Offset: 0x0017D2BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundWaveEnvelopeTimeData(Pointer, false, true);
		}

		// Token: 0x060103FD RID: 66557 RVA: 0x0017F0C7 File Offset: 0x0017D2C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundWaveEnvelopeTimeData(Pointer, MemoryOwner);
		}

		// Token: 0x04008BDE RID: 35806
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundWaveEnvelopeTimeData";

		// Token: 0x04008BDF RID: 35807
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BE0 RID: 35808
		internal static int __PropertyOffset_Amplitude;

		// Token: 0x04008BE1 RID: 35809
		internal static int __PropertyOffset_TimeSec;
	}
}
