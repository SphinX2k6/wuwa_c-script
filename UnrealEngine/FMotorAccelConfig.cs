using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F2B RID: 7979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorAccelConfig")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FMotorAccelConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E54E RID: 124238 RVA: 0x002D10F2 File Offset: 0x002CF2F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorAccelConfig._ScriptStructPtr != 0) ? FMotorAccelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorAccelConfig", ref FMotorAccelConfig._ScriptStructPtr);
		}

		// Token: 0x17007882 RID: 30850
		// (get) Token: 0x0601E54F RID: 124239 RVA: 0x002D1116 File Offset: 0x002CF316
		// (set) Token: 0x0601E550 RID: 124240 RVA: 0x002D1126 File Offset: 0x002CF326
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

		// Token: 0x17007883 RID: 30851
		// (get) Token: 0x0601E551 RID: 124241 RVA: 0x002D1138 File Offset: 0x002CF338
		// (set) Token: 0x0601E552 RID: 124242 RVA: 0x002D117B File Offset: 0x002CF37B
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

		// Token: 0x17007884 RID: 30852
		// (get) Token: 0x0601E553 RID: 124243 RVA: 0x002D119C File Offset: 0x002CF39C
		// (set) Token: 0x0601E554 RID: 124244 RVA: 0x002D11AC File Offset: 0x002CF3AC
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

		// Token: 0x17007885 RID: 30853
		// (get) Token: 0x0601E555 RID: 124245 RVA: 0x002D11BD File Offset: 0x002CF3BD
		// (set) Token: 0x0601E556 RID: 124246 RVA: 0x002D11CD File Offset: 0x002CF3CD
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

		// Token: 0x17007886 RID: 30854
		// (get) Token: 0x0601E557 RID: 124247 RVA: 0x002D11DE File Offset: 0x002CF3DE
		// (set) Token: 0x0601E558 RID: 124248 RVA: 0x002D11EE File Offset: 0x002CF3EE
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

		// Token: 0x17007887 RID: 30855
		// (get) Token: 0x0601E559 RID: 124249 RVA: 0x002D11FF File Offset: 0x002CF3FF
		// (set) Token: 0x0601E55A RID: 124250 RVA: 0x002D120F File Offset: 0x002CF40F
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

		// Token: 0x17007888 RID: 30856
		// (get) Token: 0x0601E55B RID: 124251 RVA: 0x002D1220 File Offset: 0x002CF420
		// (set) Token: 0x0601E55C RID: 124252 RVA: 0x002D1230 File Offset: 0x002CF430
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

		// Token: 0x17007889 RID: 30857
		// (get) Token: 0x0601E55D RID: 124253 RVA: 0x002D1241 File Offset: 0x002CF441
		// (set) Token: 0x0601E55E RID: 124254 RVA: 0x002D1251 File Offset: 0x002CF451
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

		// Token: 0x1700788A RID: 30858
		// (get) Token: 0x0601E55F RID: 124255 RVA: 0x002D1264 File Offset: 0x002CF464
		// (set) Token: 0x0601E560 RID: 124256 RVA: 0x002D12A7 File Offset: 0x002CF4A7
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

		// Token: 0x1700788B RID: 30859
		// (get) Token: 0x0601E561 RID: 124257 RVA: 0x002D12C8 File Offset: 0x002CF4C8
		// (set) Token: 0x0601E562 RID: 124258 RVA: 0x002D12D8 File Offset: 0x002CF4D8
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

		// Token: 0x1700788C RID: 30860
		// (get) Token: 0x0601E563 RID: 124259 RVA: 0x002D12E9 File Offset: 0x002CF4E9
		// (set) Token: 0x0601E564 RID: 124260 RVA: 0x002D12F9 File Offset: 0x002CF4F9
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

		// Token: 0x1700788D RID: 30861
		// (get) Token: 0x0601E565 RID: 124261 RVA: 0x002D130C File Offset: 0x002CF50C
		// (set) Token: 0x0601E566 RID: 124262 RVA: 0x002D134F File Offset: 0x002CF54F
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

		// Token: 0x1700788E RID: 30862
		// (get) Token: 0x0601E567 RID: 124263 RVA: 0x002D1370 File Offset: 0x002CF570
		// (set) Token: 0x0601E568 RID: 124264 RVA: 0x002D13B3 File Offset: 0x002CF5B3
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

		// Token: 0x1700788F RID: 30863
		// (get) Token: 0x0601E569 RID: 124265 RVA: 0x002D13D4 File Offset: 0x002CF5D4
		// (set) Token: 0x0601E56A RID: 124266 RVA: 0x002D13E4 File Offset: 0x002CF5E4
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

		// Token: 0x17007890 RID: 30864
		// (get) Token: 0x0601E56B RID: 124267 RVA: 0x002D13F8 File Offset: 0x002CF5F8
		// (set) Token: 0x0601E56C RID: 124268 RVA: 0x002D143B File Offset: 0x002CF63B
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

		// Token: 0x17007891 RID: 30865
		// (get) Token: 0x0601E56D RID: 124269 RVA: 0x002D145C File Offset: 0x002CF65C
		// (set) Token: 0x0601E56E RID: 124270 RVA: 0x002D149F File Offset: 0x002CF69F
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

		// Token: 0x17007892 RID: 30866
		// (get) Token: 0x0601E56F RID: 124271 RVA: 0x002D14C0 File Offset: 0x002CF6C0
		// (set) Token: 0x0601E570 RID: 124272 RVA: 0x002D14D0 File Offset: 0x002CF6D0
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

		// Token: 0x17007893 RID: 30867
		// (get) Token: 0x0601E571 RID: 124273 RVA: 0x002D14E4 File Offset: 0x002CF6E4
		// (set) Token: 0x0601E572 RID: 124274 RVA: 0x002D1527 File Offset: 0x002CF727
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

		// Token: 0x17007894 RID: 30868
		// (get) Token: 0x0601E573 RID: 124275 RVA: 0x002D1548 File Offset: 0x002CF748
		// (set) Token: 0x0601E574 RID: 124276 RVA: 0x002D158B File Offset: 0x002CF78B
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

		// Token: 0x17007895 RID: 30869
		// (get) Token: 0x0601E575 RID: 124277 RVA: 0x002D15AC File Offset: 0x002CF7AC
		// (set) Token: 0x0601E576 RID: 124278 RVA: 0x002D15EF File Offset: 0x002CF7EF
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

		// Token: 0x17007896 RID: 30870
		// (get) Token: 0x0601E577 RID: 124279 RVA: 0x002D1610 File Offset: 0x002CF810
		// (set) Token: 0x0601E578 RID: 124280 RVA: 0x002D1653 File Offset: 0x002CF853
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

		// Token: 0x17007897 RID: 30871
		// (get) Token: 0x0601E579 RID: 124281 RVA: 0x002D1674 File Offset: 0x002CF874
		// (set) Token: 0x0601E57A RID: 124282 RVA: 0x002D16B7 File Offset: 0x002CF8B7
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

		// Token: 0x17007898 RID: 30872
		// (get) Token: 0x0601E57B RID: 124283 RVA: 0x002D16D8 File Offset: 0x002CF8D8
		// (set) Token: 0x0601E57C RID: 124284 RVA: 0x002D171B File Offset: 0x002CF91B
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

		// Token: 0x17007899 RID: 30873
		// (get) Token: 0x0601E57D RID: 124285 RVA: 0x002D173C File Offset: 0x002CF93C
		// (set) Token: 0x0601E57E RID: 124286 RVA: 0x002D177F File Offset: 0x002CF97F
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

		// Token: 0x1700789A RID: 30874
		// (get) Token: 0x0601E57F RID: 124287 RVA: 0x002D17A0 File Offset: 0x002CF9A0
		// (set) Token: 0x0601E580 RID: 124288 RVA: 0x002D17B0 File Offset: 0x002CF9B0
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

		// Token: 0x1700789B RID: 30875
		// (get) Token: 0x0601E581 RID: 124289 RVA: 0x002D17C1 File Offset: 0x002CF9C1
		// (set) Token: 0x0601E582 RID: 124290 RVA: 0x002D17D1 File Offset: 0x002CF9D1
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

		// Token: 0x1700789C RID: 30876
		// (get) Token: 0x0601E583 RID: 124291 RVA: 0x002D17E2 File Offset: 0x002CF9E2
		// (set) Token: 0x0601E584 RID: 124292 RVA: 0x002D17F2 File Offset: 0x002CF9F2
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

		// Token: 0x0601E585 RID: 124293 RVA: 0x002D1803 File Offset: 0x002CFA03
		public FMotorAccelConfig()
		{
		}

		// Token: 0x0601E586 RID: 124294 RVA: 0x002D180C File Offset: 0x002CFA0C
		public FMotorAccelConfig(bool bDoubleDrive, FMotorFloatRange BackWheelRate, float NormalDrag, float FrontWheelBrakingDrag, float BackWheelBrakingDrag, float DragNormalNoInput, float BackMoveBrakingDragAbs, float BackMoveBrakingDragRate, FMotorFloatRange PowerAccel, float MaxTimeLengthWhenNoSupport, float RotateAccelNormal, FMotorFloatRange TurnSpeedNormal, FMotorFloatRange TurnSpeedRateNormal, float RotateAccelFrontBraking, FMotorFloatRange TurnSpeedFrontBraking, FMotorFloatRange TurnSpeedRateFrontBraking, float RotateAccelBackMove, FMotorFloatRange TurnSpeedBackMove, FMotorFloatRange FrontWheelPressureRateIncreaseBackBraking, FMotorFloatRange FrontWheelAccelRateBackBraking, FMotorFloatRange RotateAccelBackBraking, FMotorFloatRange RotateAccelRateBackBraking, FMotorFloatRange TurnSpeedBackBraking, FMotorFloatRange TurnSpeedRateBackBraking, float MaxSpeed, float MaxBackSpeed, float MaxSpeedInTurn)
		{
			this.bDoubleDrive = bDoubleDrive;
			this.BackWheelRate = BackWheelRate;
			this.NormalDrag = NormalDrag;
			this.FrontWheelBrakingDrag = FrontWheelBrakingDrag;
			this.BackWheelBrakingDrag = BackWheelBrakingDrag;
			this.DragNormalNoInput = DragNormalNoInput;
			this.BackMoveBrakingDragAbs = BackMoveBrakingDragAbs;
			this.BackMoveBrakingDragRate = BackMoveBrakingDragRate;
			this.PowerAccel = PowerAccel;
			this.MaxTimeLengthWhenNoSupport = MaxTimeLengthWhenNoSupport;
			this.RotateAccelNormal = RotateAccelNormal;
			this.TurnSpeedNormal = TurnSpeedNormal;
			this.TurnSpeedRateNormal = TurnSpeedRateNormal;
			this.RotateAccelFrontBraking = RotateAccelFrontBraking;
			this.TurnSpeedFrontBraking = TurnSpeedFrontBraking;
			this.TurnSpeedRateFrontBraking = TurnSpeedRateFrontBraking;
			this.RotateAccelBackMove = RotateAccelBackMove;
			this.TurnSpeedBackMove = TurnSpeedBackMove;
			this.FrontWheelPressureRateIncreaseBackBraking = FrontWheelPressureRateIncreaseBackBraking;
			this.FrontWheelAccelRateBackBraking = FrontWheelAccelRateBackBraking;
			this.RotateAccelBackBraking = RotateAccelBackBraking;
			this.RotateAccelRateBackBraking = RotateAccelRateBackBraking;
			this.TurnSpeedBackBraking = TurnSpeedBackBraking;
			this.TurnSpeedRateBackBraking = TurnSpeedRateBackBraking;
			this.MaxSpeed = MaxSpeed;
			this.MaxBackSpeed = MaxBackSpeed;
			this.MaxSpeedInTurn = MaxSpeedInTurn;
		}

		// Token: 0x0601E587 RID: 124295 RVA: 0x002D18F4 File Offset: 0x002CFAF4
		protected override IntPtr GetUStructPtr()
		{
			return FMotorAccelConfig.StaticStruct();
		}

		// Token: 0x0601E588 RID: 124296 RVA: 0x002D1900 File Offset: 0x002CFB00
		[NullableContext(2)]
		public FMotorAccelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E589 RID: 124297 RVA: 0x002D190A File Offset: 0x002CFB0A
		public FMotorAccelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E58A RID: 124298 RVA: 0x002D1915 File Offset: 0x002CFB15
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorAccelConfig(Pointer, false, true);
		}

		// Token: 0x0601E58B RID: 124299 RVA: 0x002D191F File Offset: 0x002CFB1F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorAccelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040105BC RID: 67004
		public const string __ObjectPath = "/Script/KuroVehicle.MotorAccelConfig";

		// Token: 0x040105BD RID: 67005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105BE RID: 67006
		internal static int __PropertyOffset_bDoubleDrive;

		// Token: 0x040105BF RID: 67007
		internal static int __PropertyOffset_BackWheelRate;

		// Token: 0x040105C0 RID: 67008
		[Nullable(2)]
		private FMotorFloatRange _BackWheelRate;

		// Token: 0x040105C1 RID: 67009
		internal static int __PropertyOffset_NormalDrag;

		// Token: 0x040105C2 RID: 67010
		internal static int __PropertyOffset_FrontWheelBrakingDrag;

		// Token: 0x040105C3 RID: 67011
		internal static int __PropertyOffset_BackWheelBrakingDrag;

		// Token: 0x040105C4 RID: 67012
		internal static int __PropertyOffset_DragNormalNoInput;

		// Token: 0x040105C5 RID: 67013
		internal static int __PropertyOffset_BackMoveBrakingDragAbs;

		// Token: 0x040105C6 RID: 67014
		internal static int __PropertyOffset_BackMoveBrakingDragRate;

		// Token: 0x040105C7 RID: 67015
		internal static int __PropertyOffset_PowerAccel;

		// Token: 0x040105C8 RID: 67016
		[Nullable(2)]
		private FMotorFloatRange _PowerAccel;

		// Token: 0x040105C9 RID: 67017
		internal static int __PropertyOffset_MaxTimeLengthWhenNoSupport;

		// Token: 0x040105CA RID: 67018
		internal static int __PropertyOffset_RotateAccelNormal;

		// Token: 0x040105CB RID: 67019
		internal static int __PropertyOffset_TurnSpeedNormal;

		// Token: 0x040105CC RID: 67020
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedNormal;

		// Token: 0x040105CD RID: 67021
		internal static int __PropertyOffset_TurnSpeedRateNormal;

		// Token: 0x040105CE RID: 67022
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateNormal;

		// Token: 0x040105CF RID: 67023
		internal static int __PropertyOffset_RotateAccelFrontBraking;

		// Token: 0x040105D0 RID: 67024
		internal static int __PropertyOffset_TurnSpeedFrontBraking;

		// Token: 0x040105D1 RID: 67025
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedFrontBraking;

		// Token: 0x040105D2 RID: 67026
		internal static int __PropertyOffset_TurnSpeedRateFrontBraking;

		// Token: 0x040105D3 RID: 67027
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateFrontBraking;

		// Token: 0x040105D4 RID: 67028
		internal static int __PropertyOffset_RotateAccelBackMove;

		// Token: 0x040105D5 RID: 67029
		internal static int __PropertyOffset_TurnSpeedBackMove;

		// Token: 0x040105D6 RID: 67030
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedBackMove;

		// Token: 0x040105D7 RID: 67031
		internal static int __PropertyOffset_FrontWheelPressureRateIncreaseBackBraking;

		// Token: 0x040105D8 RID: 67032
		[Nullable(2)]
		private FMotorFloatRange _FrontWheelPressureRateIncreaseBackBraking;

		// Token: 0x040105D9 RID: 67033
		internal static int __PropertyOffset_FrontWheelAccelRateBackBraking;

		// Token: 0x040105DA RID: 67034
		[Nullable(2)]
		private FMotorFloatRange _FrontWheelAccelRateBackBraking;

		// Token: 0x040105DB RID: 67035
		internal static int __PropertyOffset_RotateAccelBackBraking;

		// Token: 0x040105DC RID: 67036
		[Nullable(2)]
		private FMotorFloatRange _RotateAccelBackBraking;

		// Token: 0x040105DD RID: 67037
		internal static int __PropertyOffset_RotateAccelRateBackBraking;

		// Token: 0x040105DE RID: 67038
		[Nullable(2)]
		private FMotorFloatRange _RotateAccelRateBackBraking;

		// Token: 0x040105DF RID: 67039
		internal static int __PropertyOffset_TurnSpeedBackBraking;

		// Token: 0x040105E0 RID: 67040
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedBackBraking;

		// Token: 0x040105E1 RID: 67041
		internal static int __PropertyOffset_TurnSpeedRateBackBraking;

		// Token: 0x040105E2 RID: 67042
		[Nullable(2)]
		private FMotorFloatRange _TurnSpeedRateBackBraking;

		// Token: 0x040105E3 RID: 67043
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x040105E4 RID: 67044
		internal static int __PropertyOffset_MaxBackSpeed;

		// Token: 0x040105E5 RID: 67045
		internal static int __PropertyOffset_MaxSpeedInTurn;
	}
}
