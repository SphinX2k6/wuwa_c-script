using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200292E RID: 10542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TriggerEffect.MultiplePositionVibrationMode")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMultiplePositionVibrationMode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602700E RID: 159758 RVA: 0x003B79EC File Offset: 0x003B5BEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMultiplePositionVibrationMode._ScriptStructPtr != 0) ? FMultiplePositionVibrationMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.MultiplePositionVibrationMode", ref FMultiplePositionVibrationMode._ScriptStructPtr);
		}

		// Token: 0x17009620 RID: 38432
		// (get) Token: 0x0602700F RID: 159759 RVA: 0x003B7A10 File Offset: 0x003B5C10
		// (set) Token: 0x06027010 RID: 159760 RVA: 0x003B7A20 File Offset: 0x003B5C20
		public unsafe byte Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMultiplePositionVibrationMode.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMultiplePositionVibrationMode.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17009621 RID: 38433
		// (get) Token: 0x06027011 RID: 159761 RVA: 0x003B7A34 File Offset: 0x003B5C34
		// (set) Token: 0x06027012 RID: 159762 RVA: 0x003B7A77 File Offset: 0x003B5C77
		public TArray<byte> Amplitude
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Amplitude) == null)
				{
					result = (this._Amplitude = new TArray<byte>(base.NativePtr + (IntPtr)FMultiplePositionVibrationMode.__PropertyOffset_Amplitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Amplitude.CopyAssign(value);
			}
		}

		// Token: 0x06027013 RID: 159763 RVA: 0x003B7A85 File Offset: 0x003B5C85
		public FMultiplePositionVibrationMode()
		{
		}

		// Token: 0x06027014 RID: 159764 RVA: 0x003B7A8D File Offset: 0x003B5C8D
		public FMultiplePositionVibrationMode(byte Frequency, TArray<byte> Amplitude)
		{
			this.Frequency = Frequency;
			this.Amplitude = Amplitude;
		}

		// Token: 0x06027015 RID: 159765 RVA: 0x003B7AA3 File Offset: 0x003B5CA3
		protected override IntPtr GetUStructPtr()
		{
			return FMultiplePositionVibrationMode.StaticStruct();
		}

		// Token: 0x06027016 RID: 159766 RVA: 0x003B7AAF File Offset: 0x003B5CAF
		[NullableContext(2)]
		public FMultiplePositionVibrationMode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027017 RID: 159767 RVA: 0x003B7AB9 File Offset: 0x003B5CB9
		public FMultiplePositionVibrationMode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027018 RID: 159768 RVA: 0x003B7AC4 File Offset: 0x003B5CC4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMultiplePositionVibrationMode(Pointer, false, true);
		}

		// Token: 0x06027019 RID: 159769 RVA: 0x003B7ACE File Offset: 0x003B5CCE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMultiplePositionVibrationMode(Pointer, MemoryOwner);
		}

		// Token: 0x040156E5 RID: 87781
		public const string __ObjectPath = "/Script/TriggerEffect.MultiplePositionVibrationMode";

		// Token: 0x040156E6 RID: 87782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156E7 RID: 87783
		internal static int __PropertyOffset_Frequency;

		// Token: 0x040156E8 RID: 87784
		internal static int __PropertyOffset_Amplitude;

		// Token: 0x040156E9 RID: 87785
		[Nullable(2)]
		private TArray<byte> _Amplitude;
	}
}
