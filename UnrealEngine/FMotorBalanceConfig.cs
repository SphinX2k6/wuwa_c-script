using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F2C RID: 7980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorBalanceConfig")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FMotorBalanceConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E58C RID: 124300 RVA: 0x002D1928 File Offset: 0x002CFB28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorBalanceConfig._ScriptStructPtr != 0) ? FMotorBalanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorBalanceConfig", ref FMotorBalanceConfig._ScriptStructPtr);
		}

		// Token: 0x1700789D RID: 30877
		// (get) Token: 0x0601E58D RID: 124301 RVA: 0x002D194C File Offset: 0x002CFB4C
		// (set) Token: 0x0601E58E RID: 124302 RVA: 0x002D195C File Offset: 0x002CFB5C
		public unsafe float AirBalanceDecreaseRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDecreaseRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDecreaseRate) = value;
			}
		}

		// Token: 0x1700789E RID: 30878
		// (get) Token: 0x0601E58F RID: 124303 RVA: 0x002D1970 File Offset: 0x002CFB70
		// (set) Token: 0x0601E590 RID: 124304 RVA: 0x002D19B3 File Offset: 0x002CFBB3
		public FMotorFloatRange AirBalanceDegSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._AirBalanceDegSpeed) == null)
				{
					result = (this._AirBalanceDegSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDegSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDegSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700789F RID: 30879
		// (get) Token: 0x0601E591 RID: 124305 RVA: 0x002D19D4 File Offset: 0x002CFBD4
		// (set) Token: 0x0601E592 RID: 124306 RVA: 0x002D19E4 File Offset: 0x002CFBE4
		public unsafe float AirBalanceDegMinTargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDegMinTargetOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirBalanceDegMinTargetOffset) = value;
			}
		}

		// Token: 0x170078A0 RID: 30880
		// (get) Token: 0x0601E593 RID: 124307 RVA: 0x002D19F5 File Offset: 0x002CFBF5
		// (set) Token: 0x0601E594 RID: 124308 RVA: 0x002D1A05 File Offset: 0x002CFC05
		public unsafe float OneWheelBalanceDecreaseRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_OneWheelBalanceDecreaseRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_OneWheelBalanceDecreaseRate) = value;
			}
		}

		// Token: 0x170078A1 RID: 30881
		// (get) Token: 0x0601E595 RID: 124309 RVA: 0x002D1A18 File Offset: 0x002CFC18
		// (set) Token: 0x0601E596 RID: 124310 RVA: 0x002D1A5B File Offset: 0x002CFC5B
		public FMotorFloatRange OneWheelBalanceDegSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._OneWheelBalanceDegSpeed) == null)
				{
					result = (this._OneWheelBalanceDegSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_OneWheelBalanceDegSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_OneWheelBalanceDegSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078A2 RID: 30882
		// (get) Token: 0x0601E597 RID: 124311 RVA: 0x002D1A7C File Offset: 0x002CFC7C
		// (set) Token: 0x0601E598 RID: 124312 RVA: 0x002D1A8C File Offset: 0x002CFC8C
		public unsafe float TwoWheelBalanceDecreaseRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_TwoWheelBalanceDecreaseRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_TwoWheelBalanceDecreaseRate) = value;
			}
		}

		// Token: 0x170078A3 RID: 30883
		// (get) Token: 0x0601E599 RID: 124313 RVA: 0x002D1A9D File Offset: 0x002CFC9D
		// (set) Token: 0x0601E59A RID: 124314 RVA: 0x002D1AAD File Offset: 0x002CFCAD
		public unsafe float TwoWheelBalanceDegSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_TwoWheelBalanceDegSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_TwoWheelBalanceDegSpeed) = value;
			}
		}

		// Token: 0x170078A4 RID: 30884
		// (get) Token: 0x0601E59B RID: 124315 RVA: 0x002D1ABE File Offset: 0x002CFCBE
		// (set) Token: 0x0601E59C RID: 124316 RVA: 0x002D1AD2 File Offset: 0x002CFCD2
		public unsafe FRotator NormalBalanceRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_NormalBalanceRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_NormalBalanceRotator) = value;
			}
		}

		// Token: 0x170078A5 RID: 30885
		// (get) Token: 0x0601E59D RID: 124317 RVA: 0x002D1AE7 File Offset: 0x002CFCE7
		// (set) Token: 0x0601E59E RID: 124318 RVA: 0x002D1AF7 File Offset: 0x002CFCF7
		public unsafe float VerticalBalanceDecreaseRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_VerticalBalanceDecreaseRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_VerticalBalanceDecreaseRate) = value;
			}
		}

		// Token: 0x170078A6 RID: 30886
		// (get) Token: 0x0601E59F RID: 124319 RVA: 0x002D1B08 File Offset: 0x002CFD08
		// (set) Token: 0x0601E5A0 RID: 124320 RVA: 0x002D1B18 File Offset: 0x002CFD18
		public unsafe float FloorNormalLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorNormalLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorNormalLerpSpeed) = value;
			}
		}

		// Token: 0x170078A7 RID: 30887
		// (get) Token: 0x0601E5A1 RID: 124321 RVA: 0x002D1B2C File Offset: 0x002CFD2C
		// (set) Token: 0x0601E5A2 RID: 124322 RVA: 0x002D1B6F File Offset: 0x002CFD6F
		public FMotorFloatRange BodyIncline
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._BodyIncline) == null)
				{
					result = (this._BodyIncline = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyIncline, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyIncline, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078A8 RID: 30888
		// (get) Token: 0x0601E5A3 RID: 124323 RVA: 0x002D1B90 File Offset: 0x002CFD90
		// (set) Token: 0x0601E5A4 RID: 124324 RVA: 0x002D1BD3 File Offset: 0x002CFDD3
		public FMotorFloatRange BodyInclineBackMove
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._BodyInclineBackMove) == null)
				{
					result = (this._BodyInclineBackMove = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineBackMove, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineBackMove, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078A9 RID: 30889
		// (get) Token: 0x0601E5A5 RID: 124325 RVA: 0x002D1BF4 File Offset: 0x002CFDF4
		// (set) Token: 0x0601E5A6 RID: 124326 RVA: 0x002D1C04 File Offset: 0x002CFE04
		public unsafe float BodyInclineDegSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegSpeed) = value;
			}
		}

		// Token: 0x170078AA RID: 30890
		// (get) Token: 0x0601E5A7 RID: 124327 RVA: 0x002D1C15 File Offset: 0x002CFE15
		// (set) Token: 0x0601E5A8 RID: 124328 RVA: 0x002D1C25 File Offset: 0x002CFE25
		public unsafe float BodyInclineDegRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegRate) = value;
			}
		}

		// Token: 0x170078AB RID: 30891
		// (get) Token: 0x0601E5A9 RID: 124329 RVA: 0x002D1C38 File Offset: 0x002CFE38
		// (set) Token: 0x0601E5AA RID: 124330 RVA: 0x002D1C7B File Offset: 0x002CFE7B
		public FMotorFloatRange BodyInclineBackBraking
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._BodyInclineBackBraking) == null)
				{
					result = (this._BodyInclineBackBraking = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineBackBraking, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineBackBraking, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078AC RID: 30892
		// (get) Token: 0x0601E5AB RID: 124331 RVA: 0x002D1C9C File Offset: 0x002CFE9C
		// (set) Token: 0x0601E5AC RID: 124332 RVA: 0x002D1CAC File Offset: 0x002CFEAC
		public unsafe float BodyInclineDegSpeedBackBraking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegSpeedBackBraking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegSpeedBackBraking) = value;
			}
		}

		// Token: 0x170078AD RID: 30893
		// (get) Token: 0x0601E5AD RID: 124333 RVA: 0x002D1CBD File Offset: 0x002CFEBD
		// (set) Token: 0x0601E5AE RID: 124334 RVA: 0x002D1CCD File Offset: 0x002CFECD
		public unsafe float BodyInclineDegRateBackBraking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegRateBackBraking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_BodyInclineDegRateBackBraking) = value;
			}
		}

		// Token: 0x170078AE RID: 30894
		// (get) Token: 0x0601E5AF RID: 124335 RVA: 0x002D1CE0 File Offset: 0x002CFEE0
		// (set) Token: 0x0601E5B0 RID: 124336 RVA: 0x002D1D23 File Offset: 0x002CFF23
		public FMotorFloatRange FloorUpRateBySpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._FloorUpRateBySpeed) == null)
				{
					result = (this._FloorUpRateBySpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorUpRateBySpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorUpRateBySpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078AF RID: 30895
		// (get) Token: 0x0601E5B1 RID: 124337 RVA: 0x002D1D44 File Offset: 0x002CFF44
		// (set) Token: 0x0601E5B2 RID: 124338 RVA: 0x002D1D87 File Offset: 0x002CFF87
		public FMotorFloatRange FloorUpRateByZ
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._FloorUpRateByZ) == null)
				{
					result = (this._FloorUpRateByZ = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorUpRateByZ, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_FloorUpRateByZ, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078B0 RID: 30896
		// (get) Token: 0x0601E5B3 RID: 124339 RVA: 0x002D1DA8 File Offset: 0x002CFFA8
		// (set) Token: 0x0601E5B4 RID: 124340 RVA: 0x002D1DEB File Offset: 0x002CFFEB
		public FMotorFloatRange AirInputControlRotateRate
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._AirInputControlRotateRate) == null)
				{
					result = (this._AirInputControlRotateRate = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078B1 RID: 30897
		// (get) Token: 0x0601E5B5 RID: 124341 RVA: 0x002D1E0C File Offset: 0x002D000C
		// (set) Token: 0x0601E5B6 RID: 124342 RVA: 0x002D1E20 File Offset: 0x002D0020
		public unsafe FVector AirInputControlRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateSpeed) = value;
			}
		}

		// Token: 0x170078B2 RID: 30898
		// (get) Token: 0x0601E5B7 RID: 124343 RVA: 0x002D1E35 File Offset: 0x002D0035
		// (set) Token: 0x0601E5B8 RID: 124344 RVA: 0x002D1E49 File Offset: 0x002D0049
		public unsafe FVector2D AirInputControlRotateLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBalanceConfig.__PropertyOffset_AirInputControlRotateLimit) = value;
			}
		}

		// Token: 0x0601E5B9 RID: 124345 RVA: 0x002D1E5E File Offset: 0x002D005E
		public FMotorBalanceConfig()
		{
		}

		// Token: 0x0601E5BA RID: 124346 RVA: 0x002D1E68 File Offset: 0x002D0068
		public FMotorBalanceConfig(float AirBalanceDecreaseRate, FMotorFloatRange AirBalanceDegSpeed, float AirBalanceDegMinTargetOffset, float OneWheelBalanceDecreaseRate, FMotorFloatRange OneWheelBalanceDegSpeed, float TwoWheelBalanceDecreaseRate, float TwoWheelBalanceDegSpeed, FRotator NormalBalanceRotator, float VerticalBalanceDecreaseRate, float FloorNormalLerpSpeed, FMotorFloatRange BodyIncline, FMotorFloatRange BodyInclineBackMove, float BodyInclineDegSpeed, float BodyInclineDegRate, FMotorFloatRange BodyInclineBackBraking, float BodyInclineDegSpeedBackBraking, float BodyInclineDegRateBackBraking, FMotorFloatRange FloorUpRateBySpeed, FMotorFloatRange FloorUpRateByZ, FMotorFloatRange AirInputControlRotateRate, FVector AirInputControlRotateSpeed, FVector2D AirInputControlRotateLimit)
		{
			this.AirBalanceDecreaseRate = AirBalanceDecreaseRate;
			this.AirBalanceDegSpeed = AirBalanceDegSpeed;
			this.AirBalanceDegMinTargetOffset = AirBalanceDegMinTargetOffset;
			this.OneWheelBalanceDecreaseRate = OneWheelBalanceDecreaseRate;
			this.OneWheelBalanceDegSpeed = OneWheelBalanceDegSpeed;
			this.TwoWheelBalanceDecreaseRate = TwoWheelBalanceDecreaseRate;
			this.TwoWheelBalanceDegSpeed = TwoWheelBalanceDegSpeed;
			this.NormalBalanceRotator = NormalBalanceRotator;
			this.VerticalBalanceDecreaseRate = VerticalBalanceDecreaseRate;
			this.FloorNormalLerpSpeed = FloorNormalLerpSpeed;
			this.BodyIncline = BodyIncline;
			this.BodyInclineBackMove = BodyInclineBackMove;
			this.BodyInclineDegSpeed = BodyInclineDegSpeed;
			this.BodyInclineDegRate = BodyInclineDegRate;
			this.BodyInclineBackBraking = BodyInclineBackBraking;
			this.BodyInclineDegSpeedBackBraking = BodyInclineDegSpeedBackBraking;
			this.BodyInclineDegRateBackBraking = BodyInclineDegRateBackBraking;
			this.FloorUpRateBySpeed = FloorUpRateBySpeed;
			this.FloorUpRateByZ = FloorUpRateByZ;
			this.AirInputControlRotateRate = AirInputControlRotateRate;
			this.AirInputControlRotateSpeed = AirInputControlRotateSpeed;
			this.AirInputControlRotateLimit = AirInputControlRotateLimit;
		}

		// Token: 0x0601E5BB RID: 124347 RVA: 0x002D1F28 File Offset: 0x002D0128
		protected override IntPtr GetUStructPtr()
		{
			return FMotorBalanceConfig.StaticStruct();
		}

		// Token: 0x0601E5BC RID: 124348 RVA: 0x002D1F34 File Offset: 0x002D0134
		[NullableContext(2)]
		public FMotorBalanceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E5BD RID: 124349 RVA: 0x002D1F3E File Offset: 0x002D013E
		public FMotorBalanceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E5BE RID: 124350 RVA: 0x002D1F49 File Offset: 0x002D0149
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorBalanceConfig(Pointer, false, true);
		}

		// Token: 0x0601E5BF RID: 124351 RVA: 0x002D1F53 File Offset: 0x002D0153
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorBalanceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040105E6 RID: 67046
		public const string __ObjectPath = "/Script/KuroVehicle.MotorBalanceConfig";

		// Token: 0x040105E7 RID: 67047
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105E8 RID: 67048
		internal static int __PropertyOffset_AirBalanceDecreaseRate;

		// Token: 0x040105E9 RID: 67049
		internal static int __PropertyOffset_AirBalanceDegSpeed;

		// Token: 0x040105EA RID: 67050
		[Nullable(2)]
		private FMotorFloatRange _AirBalanceDegSpeed;

		// Token: 0x040105EB RID: 67051
		internal static int __PropertyOffset_AirBalanceDegMinTargetOffset;

		// Token: 0x040105EC RID: 67052
		internal static int __PropertyOffset_OneWheelBalanceDecreaseRate;

		// Token: 0x040105ED RID: 67053
		internal static int __PropertyOffset_OneWheelBalanceDegSpeed;

		// Token: 0x040105EE RID: 67054
		[Nullable(2)]
		private FMotorFloatRange _OneWheelBalanceDegSpeed;

		// Token: 0x040105EF RID: 67055
		internal static int __PropertyOffset_TwoWheelBalanceDecreaseRate;

		// Token: 0x040105F0 RID: 67056
		internal static int __PropertyOffset_TwoWheelBalanceDegSpeed;

		// Token: 0x040105F1 RID: 67057
		internal static int __PropertyOffset_NormalBalanceRotator;

		// Token: 0x040105F2 RID: 67058
		internal static int __PropertyOffset_VerticalBalanceDecreaseRate;

		// Token: 0x040105F3 RID: 67059
		internal static int __PropertyOffset_FloorNormalLerpSpeed;

		// Token: 0x040105F4 RID: 67060
		internal static int __PropertyOffset_BodyIncline;

		// Token: 0x040105F5 RID: 67061
		[Nullable(2)]
		private FMotorFloatRange _BodyIncline;

		// Token: 0x040105F6 RID: 67062
		internal static int __PropertyOffset_BodyInclineBackMove;

		// Token: 0x040105F7 RID: 67063
		[Nullable(2)]
		private FMotorFloatRange _BodyInclineBackMove;

		// Token: 0x040105F8 RID: 67064
		internal static int __PropertyOffset_BodyInclineDegSpeed;

		// Token: 0x040105F9 RID: 67065
		internal static int __PropertyOffset_BodyInclineDegRate;

		// Token: 0x040105FA RID: 67066
		internal static int __PropertyOffset_BodyInclineBackBraking;

		// Token: 0x040105FB RID: 67067
		[Nullable(2)]
		private FMotorFloatRange _BodyInclineBackBraking;

		// Token: 0x040105FC RID: 67068
		internal static int __PropertyOffset_BodyInclineDegSpeedBackBraking;

		// Token: 0x040105FD RID: 67069
		internal static int __PropertyOffset_BodyInclineDegRateBackBraking;

		// Token: 0x040105FE RID: 67070
		internal static int __PropertyOffset_FloorUpRateBySpeed;

		// Token: 0x040105FF RID: 67071
		[Nullable(2)]
		private FMotorFloatRange _FloorUpRateBySpeed;

		// Token: 0x04010600 RID: 67072
		internal static int __PropertyOffset_FloorUpRateByZ;

		// Token: 0x04010601 RID: 67073
		[Nullable(2)]
		private FMotorFloatRange _FloorUpRateByZ;

		// Token: 0x04010602 RID: 67074
		internal static int __PropertyOffset_AirInputControlRotateRate;

		// Token: 0x04010603 RID: 67075
		[Nullable(2)]
		private FMotorFloatRange _AirInputControlRotateRate;

		// Token: 0x04010604 RID: 67076
		internal static int __PropertyOffset_AirInputControlRotateSpeed;

		// Token: 0x04010605 RID: 67077
		internal static int __PropertyOffset_AirInputControlRotateLimit;
	}
}
