using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000636 RID: 1590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorHangConfigParams")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMotorHangConfigParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B95 RID: 35733 RVA: 0x000D20D6 File Offset: 0x000D02D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorHangConfigParams._ScriptStructPtr != 0) ? FMotorHangConfigParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorHangConfigParams", ref FMotorHangConfigParams._ScriptStructPtr);
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06008B96 RID: 35734 RVA: 0x000D20FA File Offset: 0x000D02FA
		// (set) Token: 0x06008B97 RID: 35735 RVA: 0x000D210A File Offset: 0x000D030A
		public unsafe float MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_MaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_MaxDist) = value;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06008B98 RID: 35736 RVA: 0x000D211B File Offset: 0x000D031B
		// (set) Token: 0x06008B99 RID: 35737 RVA: 0x000D212B File Offset: 0x000D032B
		public unsafe float GPerCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_GPerCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_GPerCm) = value;
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06008B9A RID: 35738 RVA: 0x000D213C File Offset: 0x000D033C
		// (set) Token: 0x06008B9B RID: 35739 RVA: 0x000D217F File Offset: 0x000D037F
		public FMotorFloatRange Damping
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._Damping) == null)
				{
					result = (this._Damping = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_Damping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_Damping, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06008B9C RID: 35740 RVA: 0x000D21A0 File Offset: 0x000D03A0
		// (set) Token: 0x06008B9D RID: 35741 RVA: 0x000D21E3 File Offset: 0x000D03E3
		public FMotorFloatRange RotateDamping
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RotateDamping) == null)
				{
					result = (this._RotateDamping = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_RotateDamping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_RotateDamping, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06008B9E RID: 35742 RVA: 0x000D2204 File Offset: 0x000D0404
		// (set) Token: 0x06008B9F RID: 35743 RVA: 0x000D2218 File Offset: 0x000D0418
		public unsafe FVector LimitDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_LimitDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_LimitDirect) = value;
			}
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x000D222D File Offset: 0x000D042D
		public FMotorHangConfigParams()
		{
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x000D2235 File Offset: 0x000D0435
		protected override IntPtr GetUStructPtr()
		{
			return FMotorHangConfigParams.StaticStruct();
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x000D2241 File Offset: 0x000D0441
		[NullableContext(2)]
		public FMotorHangConfigParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x000D224B File Offset: 0x000D044B
		public FMotorHangConfigParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x000D2256 File Offset: 0x000D0456
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorHangConfigParams(Pointer, false, true);
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x000D2260 File Offset: 0x000D0460
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorHangConfigParams(Pointer, MemoryOwner);
		}

		// Token: 0x04003CA5 RID: 15525
		public const string __ObjectPath = "/Script/KuroVehicle.MotorHangConfigParams";

		// Token: 0x04003CA6 RID: 15526
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CA7 RID: 15527
		internal static int __PropertyOffset_MaxDist;

		// Token: 0x04003CA8 RID: 15528
		internal static int __PropertyOffset_GPerCm;

		// Token: 0x04003CA9 RID: 15529
		internal static int __PropertyOffset_Damping;

		// Token: 0x04003CAA RID: 15530
		[Nullable(2)]
		private FMotorFloatRange _Damping;

		// Token: 0x04003CAB RID: 15531
		internal static int __PropertyOffset_RotateDamping;

		// Token: 0x04003CAC RID: 15532
		[Nullable(2)]
		private FMotorFloatRange _RotateDamping;

		// Token: 0x04003CAD RID: 15533
		internal static int __PropertyOffset_LimitDirect;
	}
}
