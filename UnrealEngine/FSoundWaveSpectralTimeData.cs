using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001161 RID: 4449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundWaveSpectralTimeData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSoundWaveSpectralTimeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010426 RID: 66598 RVA: 0x0017F3EC File Offset: 0x0017D5EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveSpectralTimeData._ScriptStructPtr != 0) ? FSoundWaveSpectralTimeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveSpectralTimeData", ref FSoundWaveSpectralTimeData._ScriptStructPtr);
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x06010427 RID: 66599 RVA: 0x0017F410 File Offset: 0x0017D610
		// (set) Token: 0x06010428 RID: 66600 RVA: 0x0017F453 File Offset: 0x0017D653
		public TArray<FSoundWaveSpectralDataEntry> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundWaveSpectralDataEntry> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<FSoundWaveSpectralDataEntry>(base.NativePtr + (IntPtr)FSoundWaveSpectralTimeData.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x06010429 RID: 66601 RVA: 0x0017F461 File Offset: 0x0017D661
		// (set) Token: 0x0601042A RID: 66602 RVA: 0x0017F471 File Offset: 0x0017D671
		public unsafe float TimeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveSpectralTimeData.__PropertyOffset_TimeSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveSpectralTimeData.__PropertyOffset_TimeSec) = value;
			}
		}

		// Token: 0x0601042B RID: 66603 RVA: 0x0017F482 File Offset: 0x0017D682
		public FSoundWaveSpectralTimeData()
		{
		}

		// Token: 0x0601042C RID: 66604 RVA: 0x0017F48A File Offset: 0x0017D68A
		public FSoundWaveSpectralTimeData(TArray<FSoundWaveSpectralDataEntry> Data, float TimeSec)
		{
			this.Data = Data;
			this.TimeSec = TimeSec;
		}

		// Token: 0x0601042D RID: 66605 RVA: 0x0017F4A0 File Offset: 0x0017D6A0
		protected override IntPtr GetUStructPtr()
		{
			return FSoundWaveSpectralTimeData.StaticStruct();
		}

		// Token: 0x0601042E RID: 66606 RVA: 0x0017F4AC File Offset: 0x0017D6AC
		[NullableContext(2)]
		public FSoundWaveSpectralTimeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601042F RID: 66607 RVA: 0x0017F4B6 File Offset: 0x0017D6B6
		public FSoundWaveSpectralTimeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010430 RID: 66608 RVA: 0x0017F4C1 File Offset: 0x0017D6C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundWaveSpectralTimeData(Pointer, false, true);
		}

		// Token: 0x06010431 RID: 66609 RVA: 0x0017F4CB File Offset: 0x0017D6CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundWaveSpectralTimeData(Pointer, MemoryOwner);
		}

		// Token: 0x04008BF4 RID: 35828
		public const string __ObjectPath = "/Script/Engine.SoundWaveSpectralTimeData";

		// Token: 0x04008BF5 RID: 35829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BF6 RID: 35830
		internal static int __PropertyOffset_Data;

		// Token: 0x04008BF7 RID: 35831
		[Nullable(2)]
		private TArray<FSoundWaveSpectralDataEntry> _Data;

		// Token: 0x04008BF8 RID: 35832
		internal static int __PropertyOffset_TimeSec;
	}
}
