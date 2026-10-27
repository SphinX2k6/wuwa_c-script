using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BF1 RID: 3057
	[UnrealObjectPath("/Script/Engine.FOscillator")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FFOscillator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096D6 RID: 38614 RVA: 0x000D72BA File Offset: 0x000D54BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFOscillator._ScriptStructPtr != 0) ? FFOscillator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FOscillator", ref FFOscillator._ScriptStructPtr);
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x060096D7 RID: 38615 RVA: 0x000D72DE File Offset: 0x000D54DE
		// (set) Token: 0x060096D8 RID: 38616 RVA: 0x000D72EE File Offset: 0x000D54EE
		public unsafe float Amplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Amplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Amplitude) = value;
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x000D72FF File Offset: 0x000D54FF
		// (set) Token: 0x060096DA RID: 38618 RVA: 0x000D730F File Offset: 0x000D550F
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x000D7320 File Offset: 0x000D5520
		// (set) Token: 0x060096DC RID: 38620 RVA: 0x000D7334 File Offset: 0x000D5534
		public unsafe TEnumAsByte<EInitialOscillatorOffset> InitialOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_InitialOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_InitialOffset) = value;
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x000D7349 File Offset: 0x000D5549
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x000D7359 File Offset: 0x000D5559
		public unsafe EOscillatorWaveform Waveform
		{
			get
			{
				return (EOscillatorWaveform)(*(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Waveform));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFOscillator.__PropertyOffset_Waveform) = (byte)value;
			}
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x000D736A File Offset: 0x000D556A
		public FFOscillator()
		{
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x000D7372 File Offset: 0x000D5572
		public FFOscillator(float Amplitude, float Frequency, TEnumAsByte<EInitialOscillatorOffset> InitialOffset, EOscillatorWaveform Waveform)
		{
			this.Amplitude = Amplitude;
			this.Frequency = Frequency;
			this.InitialOffset = InitialOffset;
			this.Waveform = Waveform;
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x000D7397 File Offset: 0x000D5597
		protected override IntPtr GetUStructPtr()
		{
			return FFOscillator.StaticStruct();
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x000D73A3 File Offset: 0x000D55A3
		[NullableContext(2)]
		public FFOscillator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x000D73AD File Offset: 0x000D55AD
		public FFOscillator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x000D73B8 File Offset: 0x000D55B8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFOscillator(Pointer, false, true);
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x000D73C2 File Offset: 0x000D55C2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFOscillator(Pointer, MemoryOwner);
		}

		// Token: 0x0400549C RID: 21660
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FOscillator";

		// Token: 0x0400549D RID: 21661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400549E RID: 21662
		internal static int __PropertyOffset_Amplitude;

		// Token: 0x0400549F RID: 21663
		internal static int __PropertyOffset_Frequency;

		// Token: 0x040054A0 RID: 21664
		internal static int __PropertyOffset_InitialOffset;

		// Token: 0x040054A1 RID: 21665
		internal static int __PropertyOffset_Waveform;
	}
}
