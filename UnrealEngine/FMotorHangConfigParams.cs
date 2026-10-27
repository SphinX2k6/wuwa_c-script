using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F34 RID: 7988
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorHangConfigParams")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMotorHangConfigParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E64F RID: 124495 RVA: 0x002D2C67 File Offset: 0x002D0E67
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorHangConfigParams._ScriptStructPtr != 0) ? FMotorHangConfigParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorHangConfigParams", ref FMotorHangConfigParams._ScriptStructPtr);
		}

		// Token: 0x170078E0 RID: 30944
		// (get) Token: 0x0601E650 RID: 124496 RVA: 0x002D2C8B File Offset: 0x002D0E8B
		// (set) Token: 0x0601E651 RID: 124497 RVA: 0x002D2C9B File Offset: 0x002D0E9B
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

		// Token: 0x170078E1 RID: 30945
		// (get) Token: 0x0601E652 RID: 124498 RVA: 0x002D2CAC File Offset: 0x002D0EAC
		// (set) Token: 0x0601E653 RID: 124499 RVA: 0x002D2CBC File Offset: 0x002D0EBC
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

		// Token: 0x170078E2 RID: 30946
		// (get) Token: 0x0601E654 RID: 124500 RVA: 0x002D2CD0 File Offset: 0x002D0ED0
		// (set) Token: 0x0601E655 RID: 124501 RVA: 0x002D2D13 File Offset: 0x002D0F13
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

		// Token: 0x170078E3 RID: 30947
		// (get) Token: 0x0601E656 RID: 124502 RVA: 0x002D2D34 File Offset: 0x002D0F34
		// (set) Token: 0x0601E657 RID: 124503 RVA: 0x002D2D77 File Offset: 0x002D0F77
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

		// Token: 0x170078E4 RID: 30948
		// (get) Token: 0x0601E658 RID: 124504 RVA: 0x002D2D98 File Offset: 0x002D0F98
		// (set) Token: 0x0601E659 RID: 124505 RVA: 0x002D2DA8 File Offset: 0x002D0FA8
		public unsafe EHangLimitType LimitType
		{
			get
			{
				return (EHangLimitType)(*(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_LimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorHangConfigParams.__PropertyOffset_LimitType) = (byte)value;
			}
		}

		// Token: 0x170078E5 RID: 30949
		// (get) Token: 0x0601E65A RID: 124506 RVA: 0x002D2DB9 File Offset: 0x002D0FB9
		// (set) Token: 0x0601E65B RID: 124507 RVA: 0x002D2DCD File Offset: 0x002D0FCD
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

		// Token: 0x0601E65C RID: 124508 RVA: 0x002D2DE2 File Offset: 0x002D0FE2
		public FMotorHangConfigParams()
		{
		}

		// Token: 0x0601E65D RID: 124509 RVA: 0x002D2DEA File Offset: 0x002D0FEA
		public FMotorHangConfigParams(float MaxDist, float GPerCm, FMotorFloatRange Damping, FMotorFloatRange RotateDamping, EHangLimitType LimitType, FVector LimitDirect)
		{
			this.MaxDist = MaxDist;
			this.GPerCm = GPerCm;
			this.Damping = Damping;
			this.RotateDamping = RotateDamping;
			this.LimitType = LimitType;
			this.LimitDirect = LimitDirect;
		}

		// Token: 0x0601E65E RID: 124510 RVA: 0x002D2E1F File Offset: 0x002D101F
		protected override IntPtr GetUStructPtr()
		{
			return FMotorHangConfigParams.StaticStruct();
		}

		// Token: 0x0601E65F RID: 124511 RVA: 0x002D2E2B File Offset: 0x002D102B
		[NullableContext(2)]
		public FMotorHangConfigParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E660 RID: 124512 RVA: 0x002D2E35 File Offset: 0x002D1035
		public FMotorHangConfigParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E661 RID: 124513 RVA: 0x002D2E40 File Offset: 0x002D1040
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorHangConfigParams(Pointer, false, true);
		}

		// Token: 0x0601E662 RID: 124514 RVA: 0x002D2E4A File Offset: 0x002D104A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorHangConfigParams(Pointer, MemoryOwner);
		}

		// Token: 0x04010650 RID: 67152
		public const string __ObjectPath = "/Script/KuroVehicle.MotorHangConfigParams";

		// Token: 0x04010651 RID: 67153
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010652 RID: 67154
		internal static int __PropertyOffset_MaxDist;

		// Token: 0x04010653 RID: 67155
		internal static int __PropertyOffset_GPerCm;

		// Token: 0x04010654 RID: 67156
		internal static int __PropertyOffset_Damping;

		// Token: 0x04010655 RID: 67157
		[Nullable(2)]
		private FMotorFloatRange _Damping;

		// Token: 0x04010656 RID: 67158
		internal static int __PropertyOffset_RotateDamping;

		// Token: 0x04010657 RID: 67159
		[Nullable(2)]
		private FMotorFloatRange _RotateDamping;

		// Token: 0x04010658 RID: 67160
		internal static int __PropertyOffset_LimitType;

		// Token: 0x04010659 RID: 67161
		internal static int __PropertyOffset_LimitDirect;
	}
}
