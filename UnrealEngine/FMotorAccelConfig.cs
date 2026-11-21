using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000632 RID: 1586
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorAccelConfig")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FMotorAccelConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B25 RID: 35621 RVA: 0x000D1536 File Offset: 0x000CF736
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorAccelConfig._ScriptStructPtr != 0) ? FMotorAccelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorAccelConfig", ref FMotorAccelConfig._ScriptStructPtr);
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06008B26 RID: 35622 RVA: 0x000D155A File Offset: 0x000CF75A
		// (set) Token: 0x06008B27 RID: 35623 RVA: 0x000D156A File Offset: 0x000CF76A
		public unsafe bool bDoubleDrive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_bDoubleDrive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_bDoubleDrive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x000D157C File Offset: 0x000CF77C
		// (set) Token: 0x06008B29 RID: 35625 RVA: 0x000D15BF File Offset: 0x000CF7BF
		public FMotorFloatRange BackWheelRate
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._BackWheelRate) == null)
				{
					result = (this._BackWheelRate = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackWheelRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackWheelRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x000D15E0 File Offset: 0x000CF7E0
		// (set) Token: 0x06008B2B RID: 35627 RVA: 0x000D15F0 File Offset: 0x000CF7F0
		public unsafe float NormalDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_NormalDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_NormalDrag) = value;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06008B2C RID: 35628 RVA: 0x000D1601 File Offset: 0x000CF801
		// (set) Token: 0x06008B2D RID: 35629 RVA: 0x000D1611 File Offset: 0x000CF811
		public unsafe float FrontWheelBrakingDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelBrakingDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelBrakingDrag) = value;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x000D1622 File Offset: 0x000CF822
		// (set) Token: 0x06008B2F RID: 35631 RVA: 0x000D1632 File Offset: 0x000CF832
		public unsafe float BackWheelBrakingDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackWheelBrakingDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackWheelBrakingDrag) = value;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06008B30 RID: 35632 RVA: 0x000D1643 File Offset: 0x000CF843
		// (set) Token: 0x06008B31 RID: 35633 RVA: 0x000D1653 File Offset: 0x000CF853
		public unsafe float DragNormalNoInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_DragNormalNoInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_DragNormalNoInput) = value;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x000D1664 File Offset: 0x000CF864
		// (set) Token: 0x06008B33 RID: 35635 RVA: 0x000D1674 File Offset: 0x000CF874
		public unsafe float BackMoveBrakingDragAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackMoveBrakingDragAbs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackMoveBrakingDragAbs) = value;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x000D1685 File Offset: 0x000CF885
		// (set) Token: 0x06008B35 RID: 35637 RVA: 0x000D1695 File Offset: 0x000CF895
		public unsafe float BackMoveBrakingDragRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackMoveBrakingDragRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_BackMoveBrakingDragRate) = value;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x000D16A8 File Offset: 0x000CF8A8
		// (set) Token: 0x06008B37 RID: 35639 RVA: 0x000D16EB File Offset: 0x000CF8EB
		public FMotorFloatRange PowerAccel
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._PowerAccel) == null)
				{
					result = (this._PowerAccel = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_PowerAccel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_PowerAccel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x000D170C File Offset: 0x000CF90C
		// (set) Token: 0x06008B39 RID: 35641 RVA: 0x000D171C File Offset: 0x000CF91C
		public unsafe float MaxTimeLengthWhenNoSupport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxTimeLengthWhenNoSupport);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxTimeLengthWhenNoSupport) = value;
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x000D172D File Offset: 0x000CF92D
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x000D173D File Offset: 0x000CF93D
		public unsafe float RotateAccelNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelNormal) = value;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x000D1750 File Offset: 0x000CF950
		// (set) Token: 0x06008B3D RID: 35645 RVA: 0x000D1793 File Offset: 0x000CF993
		public FMotorFloatRange TurnSpeedNormal
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedNormal) == null)
				{
					result = (this._TurnSpeedNormal = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedNormal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06008B3E RID: 35646 RVA: 0x000D17B4 File Offset: 0x000CF9B4
		// (set) Token: 0x06008B3F RID: 35647 RVA: 0x000D17F7 File Offset: 0x000CF9F7
		public FMotorFloatRange TurnSpeedRateNormal
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedRateNormal) == null)
				{
					result = (this._TurnSpeedRateNormal = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateNormal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06008B40 RID: 35648 RVA: 0x000D1818 File Offset: 0x000CFA18
		// (set) Token: 0x06008B41 RID: 35649 RVA: 0x000D1828 File Offset: 0x000CFA28
		public unsafe float RotateAccelFrontBraking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelFrontBraking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelFrontBraking) = value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x000D183C File Offset: 0x000CFA3C
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x000D187F File Offset: 0x000CFA7F
		public FMotorFloatRange TurnSpeedFrontBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedFrontBraking) == null)
				{
					result = (this._TurnSpeedFrontBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedFrontBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedFrontBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x000D18A0 File Offset: 0x000CFAA0
		// (set) Token: 0x06008B45 RID: 35653 RVA: 0x000D18E3 File Offset: 0x000CFAE3
		public FMotorFloatRange TurnSpeedRateFrontBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedRateFrontBraking) == null)
				{
					result = (this._TurnSpeedRateFrontBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateFrontBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateFrontBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x000D1904 File Offset: 0x000CFB04
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x000D1914 File Offset: 0x000CFB14
		public unsafe float RotateAccelBackMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelBackMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelBackMove) = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x000D1928 File Offset: 0x000CFB28
		// (set) Token: 0x06008B49 RID: 35657 RVA: 0x000D196B File Offset: 0x000CFB6B
		public FMotorFloatRange TurnSpeedBackMove
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedBackMove) == null)
				{
					result = (this._TurnSpeedBackMove = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedBackMove, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedBackMove, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x000D198C File Offset: 0x000CFB8C
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x000D19CF File Offset: 0x000CFBCF
		public FMotorFloatRange FrontWheelPressureRateIncreaseBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._FrontWheelPressureRateIncreaseBackBraking) == null)
				{
					result = (this._FrontWheelPressureRateIncreaseBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelPressureRateIncreaseBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelPressureRateIncreaseBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x000D19F0 File Offset: 0x000CFBF0
		// (set) Token: 0x06008B4D RID: 35661 RVA: 0x000D1A33 File Offset: 0x000CFC33
		public FMotorFloatRange FrontWheelAccelRateBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._FrontWheelAccelRateBackBraking) == null)
				{
					result = (this._FrontWheelAccelRateBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelAccelRateBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_FrontWheelAccelRateBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x000D1A54 File Offset: 0x000CFC54
		// (set) Token: 0x06008B4F RID: 35663 RVA: 0x000D1A97 File Offset: 0x000CFC97
		public FMotorFloatRange RotateAccelBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RotateAccelBackBraking) == null)
				{
					result = (this._RotateAccelBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06008B50 RID: 35664 RVA: 0x000D1AB8 File Offset: 0x000CFCB8
		// (set) Token: 0x06008B51 RID: 35665 RVA: 0x000D1AFB File Offset: 0x000CFCFB
		public FMotorFloatRange RotateAccelRateBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RotateAccelRateBackBraking) == null)
				{
					result = (this._RotateAccelRateBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelRateBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_RotateAccelRateBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x000D1B1C File Offset: 0x000CFD1C
		// (set) Token: 0x06008B53 RID: 35667 RVA: 0x000D1B5F File Offset: 0x000CFD5F
		public FMotorFloatRange TurnSpeedBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedBackBraking) == null)
				{
					result = (this._TurnSpeedBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06008B54 RID: 35668 RVA: 0x000D1B80 File Offset: 0x000CFD80
		// (set) Token: 0x06008B55 RID: 35669 RVA: 0x000D1BC3 File Offset: 0x000CFDC3
		public FMotorFloatRange TurnSpeedRateBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._TurnSpeedRateBackBraking) == null)
				{
					result = (this._TurnSpeedRateBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_TurnSpeedRateBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06008B56 RID: 35670 RVA: 0x000D1BE4 File Offset: 0x000CFDE4
		// (set) Token: 0x06008B57 RID: 35671 RVA: 0x000D1BF4 File Offset: 0x000CFDF4
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06008B58 RID: 35672 RVA: 0x000D1C05 File Offset: 0x000CFE05
		// (set) Token: 0x06008B59 RID: 35673 RVA: 0x000D1C15 File Offset: 0x000CFE15
		public unsafe float MaxBackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxBackSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxBackSpeed) = value;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x000D1C26 File Offset: 0x000CFE26
		// (set) Token: 0x06008B5B RID: 35675 RVA: 0x000D1C36 File Offset: 0x000CFE36
		public unsafe float MaxSpeedInTurn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxSpeedInTurn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorAccelConfig.__PropertyOffset_MaxSpeedInTurn) = value;
			}
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x000D1C47 File Offset: 0x000CFE47
		public FMotorAccelConfig()
		{
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x000D1C4F File Offset: 0x000CFE4F
		protected override IntPtr GetUStructPtr()
		{
			return FMotorAccelConfig.StaticStruct();
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x000D1C5B File Offset: 0x000CFE5B
		[NullableContext(2)]
		public FMotorAccelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x000D1C65 File Offset: 0x000CFE65
		public FMotorAccelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x000D1C70 File Offset: 0x000CFE70
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorAccelConfig(Pointer, false, true);
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x000D1C7A File Offset: 0x000CFE7A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorAccelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003C60 RID: 15456
		public const string __ObjectPath = "/Script/KuroVehicle.MotorAccelConfig";

		// Token: 0x04003C61 RID: 15457
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C62 RID: 15458
		internal static int __PropertyOffset_bDoubleDrive;

		// Token: 0x04003C63 RID: 15459
		internal static int __PropertyOffset_BackWheelRate;

		// Token: 0x04003C64 RID: 15460
		[Nullable(2)]
		private FMotorFloatRange _BackWheelRate;

		// Token: 0x04003C65 RID: 15461
		internal static int __PropertyOffset_NormalDrag;

		// Token: 0x04003C66 RID: 15462
		internal static int __PropertyOffset_FrontWheelBrakingDrag;

		// Token: 0x04003C67 RID: 15463
		internal static int __PropertyOffset_BackWheelBrakingDrag;

		// Token: 0x04003C68 RID: 15464
		internal static int __PropertyOffset_DragNormalNoInput;

		// Token: 0x04003C69 RID: 15465
		internal static int __PropertyOffset_BackMoveBrakingDragAbs;

		// Token: 0x04003C6A RID: 15466
		internal static int __PropertyOffset_BackMoveBrakingDragRate;

		// Token: 0x04003C6B RID: 15467
		internal static int __PropertyOffset_PowerAccel;

		// Token: 0x04003C6C RID: 15468
		[Nullable(2)]
		private FMotorFloatRange _PowerAccel;

		// Token: 0x04003C6D RID: 15469
		internal static int __PropertyOffset_MaxTimeLengthWhenNoSupport;

		// Token: 0x04003C6E RID: 15470
		internal static int __PropertyOffset_RotateAccelNormal;

		// Token: 0x04003C6F RID: 15471
		internal static int __PropertyOffset_TurnSpeedNormal;

		// Token: 0x04003C70 RID: 15472
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedNormal;

		// Token: 0x04003C71 RID: 15473
		internal static int __PropertyOffset_TurnSpeedRateNormal;

		// Token: 0x04003C72 RID: 15474
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateNormal;

		// Token: 0x04003C73 RID: 15475
		internal static int __PropertyOffset_RotateAccelFrontBraking;

		// Token: 0x04003C74 RID: 15476
		internal static int __PropertyOffset_TurnSpeedFrontBraking;

		// Token: 0x04003C75 RID: 15477
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedFrontBraking;

		// Token: 0x04003C76 RID: 15478
		internal static int __PropertyOffset_TurnSpeedRateFrontBraking;

		// Token: 0x04003C77 RID: 15479
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateFrontBraking;

		// Token: 0x04003C78 RID: 15480
		internal static int __PropertyOffset_RotateAccelBackMove;

		// Token: 0x04003C79 RID: 15481
		internal static int __PropertyOffset_TurnSpeedBackMove;

		// Token: 0x04003C7A RID: 15482
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedBackMove;

		// Token: 0x04003C7B RID: 15483
		internal static int __PropertyOffset_FrontWheelPressureRateIncreaseBackBraking;

		// Token: 0x04003C7C RID: 15484
		[Nullable(2)]
		private FMotorFloatRange _FrontWheelPressureRateIncreaseBackBraking;

		// Token: 0x04003C7D RID: 15485
		internal static int __PropertyOffset_FrontWheelAccelRateBackBraking;

		// Token: 0x04003C7E RID: 15486
		[Nullable(2)]
		private FMotorFloatRange _FrontWheelAccelRateBackBraking;

		// Token: 0x04003C7F RID: 15487
		internal static int __PropertyOffset_RotateAccelBackBraking;

		// Token: 0x04003C80 RID: 15488
		[Nullable(2)]
		private FMotorFloatRange _RotateAccelBackBraking;

		// Token: 0x04003C81 RID: 15489
		internal static int __PropertyOffset_RotateAccelRateBackBraking;

		// Token: 0x04003C82 RID: 15490
		[Nullable(2)]
		private FMotorFloatRange _RotateAccelRateBackBraking;

		// Token: 0x04003C83 RID: 15491
		internal static int __PropertyOffset_TurnSpeedBackBraking;

		// Token: 0x04003C84 RID: 15492
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedBackBraking;

		// Token: 0x04003C85 RID: 15493
		internal static int __PropertyOffset_TurnSpeedRateBackBraking;

		// Token: 0x04003C86 RID: 15494
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateBackBraking;

		// Token: 0x04003C87 RID: 15495
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x04003C88 RID: 15496
		internal static int __PropertyOffset_MaxBackSpeed;

		// Token: 0x04003C89 RID: 15497
		internal static int __PropertyOffset_MaxSpeedInTurn;
	}
}
