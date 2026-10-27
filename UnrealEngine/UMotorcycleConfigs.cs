using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F32 RID: 7986
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorcycleConfigs")]
	[UnrealStructLayout(1760, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1760)]
	public class UMotorcycleConfigs : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E616 RID: 124438 RVA: 0x002D2576 File Offset: 0x002D0776
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotorcycleConfigs._ClassPtr;
		}

		// Token: 0x0601E617 RID: 124439 RVA: 0x002D2584 File Offset: 0x002D0784
		public UMotorcycleConfigs() : this(BuiltinUtils.AllocNativeUObject(UMotorcycleConfigs.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E618 RID: 124440 RVA: 0x002D25AC File Offset: 0x002D07AC
		public UMotorcycleConfigs(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotorcycleConfigs.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170078CA RID: 30922
		// (get) Token: 0x0601E619 RID: 124441 RVA: 0x002D25DF File Offset: 0x002D07DF
		// (set) Token: 0x0601E61A RID: 124442 RVA: 0x002D25EF File Offset: 0x002D07EF
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x170078CB RID: 30923
		// (get) Token: 0x0601E61B RID: 124443 RVA: 0x002D2600 File Offset: 0x002D0800
		// (set) Token: 0x0601E61C RID: 124444 RVA: 0x002D2610 File Offset: 0x002D0810
		public unsafe float MotorAirFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorAirFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorAirFriction) = value;
			}
		}

		// Token: 0x170078CC RID: 30924
		// (get) Token: 0x0601E61D RID: 124445 RVA: 0x002D2621 File Offset: 0x002D0821
		// (set) Token: 0x0601E61E RID: 124446 RVA: 0x002D2635 File Offset: 0x002D0835
		public unsafe FVector MotorBodyAngularLengths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyAngularLengths);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyAngularLengths) = value;
			}
		}

		// Token: 0x170078CD RID: 30925
		// (get) Token: 0x0601E61F RID: 124447 RVA: 0x002D264C File Offset: 0x002D084C
		// (set) Token: 0x0601E620 RID: 124448 RVA: 0x002D2685 File Offset: 0x002D0885
		public FMotorFloatRange MotorBodyAngularRateInHitSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._MotorBodyAngularRateInHitSpeed) == null)
				{
					result = (this._MotorBodyAngularRateInHitSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyAngularRateInHitSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyAngularRateInHitSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078CE RID: 30926
		// (get) Token: 0x0601E621 RID: 124449 RVA: 0x002D26A6 File Offset: 0x002D08A6
		// (set) Token: 0x0601E622 RID: 124450 RVA: 0x002D26B6 File Offset: 0x002D08B6
		public unsafe float HangRotateWeakenWhenTwoWheelOnGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup) = value;
			}
		}

		// Token: 0x170078CF RID: 30927
		// (get) Token: 0x0601E623 RID: 124451 RVA: 0x002D26C8 File Offset: 0x002D08C8
		// (set) Token: 0x0601E624 RID: 124452 RVA: 0x002D2701 File Offset: 0x002D0901
		public FMotorHangConfigParams MotorFrontWheelHang
		{
			get
			{
				base.FastCheckIsValid();
				FMotorHangConfigParams result;
				if ((result = this._MotorFrontWheelHang) == null)
				{
					result = (this._MotorFrontWheelHang = new FMotorHangConfigParams(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorFrontWheelHang, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorHangConfigParams.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorFrontWheelHang, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D0 RID: 30928
		// (get) Token: 0x0601E625 RID: 124453 RVA: 0x002D2724 File Offset: 0x002D0924
		// (set) Token: 0x0601E626 RID: 124454 RVA: 0x002D275D File Offset: 0x002D095D
		public FMotorHangConfigParams MotorBackWheelHang
		{
			get
			{
				base.FastCheckIsValid();
				FMotorHangConfigParams result;
				if ((result = this._MotorBackWheelHang) == null)
				{
					result = (this._MotorBackWheelHang = new FMotorHangConfigParams(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBackWheelHang, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorHangConfigParams.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBackWheelHang, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D1 RID: 30929
		// (get) Token: 0x0601E627 RID: 124455 RVA: 0x002D2780 File Offset: 0x002D0980
		// (set) Token: 0x0601E628 RID: 124456 RVA: 0x002D27B9 File Offset: 0x002D09B9
		public FMotorContactPhysParams MotorBodyPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorBodyPhys) == null)
				{
					result = (this._MotorBodyPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBodyPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D2 RID: 30930
		// (get) Token: 0x0601E629 RID: 124457 RVA: 0x002D27DC File Offset: 0x002D09DC
		// (set) Token: 0x0601E62A RID: 124458 RVA: 0x002D2815 File Offset: 0x002D0A15
		public FMotorContactPhysParams MotorFrontWheelPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorFrontWheelPhys) == null)
				{
					result = (this._MotorFrontWheelPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorFrontWheelPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorFrontWheelPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D3 RID: 30931
		// (get) Token: 0x0601E62B RID: 124459 RVA: 0x002D2838 File Offset: 0x002D0A38
		// (set) Token: 0x0601E62C RID: 124460 RVA: 0x002D2871 File Offset: 0x002D0A71
		public FMotorContactPhysParams MotorBackWheelPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorBackWheelPhys) == null)
				{
					result = (this._MotorBackWheelPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBackWheelPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBackWheelPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D4 RID: 30932
		// (get) Token: 0x0601E62D RID: 124461 RVA: 0x002D2894 File Offset: 0x002D0A94
		// (set) Token: 0x0601E62E RID: 124462 RVA: 0x002D28CD File Offset: 0x002D0ACD
		public FMotorAccelConfig MotorAccelConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorAccelConfig result;
				if ((result = this._MotorAccelConfig) == null)
				{
					result = (this._MotorAccelConfig = new FMotorAccelConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorAccelConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorAccelConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorAccelConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D5 RID: 30933
		// (get) Token: 0x0601E62F RID: 124463 RVA: 0x002D28F0 File Offset: 0x002D0AF0
		// (set) Token: 0x0601E630 RID: 124464 RVA: 0x002D2929 File Offset: 0x002D0B29
		public FMotorBoostConfig MotorBoostConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._MotorBoostConfig) == null)
				{
					result = (this._MotorBoostConfig = new FMotorBoostConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBoostConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBoostConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D6 RID: 30934
		// (get) Token: 0x0601E631 RID: 124465 RVA: 0x002D294C File Offset: 0x002D0B4C
		// (set) Token: 0x0601E632 RID: 124466 RVA: 0x002D2985 File Offset: 0x002D0B85
		public FMotorBalanceConfig MotorBalanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBalanceConfig result;
				if ((result = this._MotorBalanceConfig) == null)
				{
					result = (this._MotorBalanceConfig = new FMotorBalanceConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBalanceConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBalanceConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBalanceConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D7 RID: 30935
		// (get) Token: 0x0601E633 RID: 124467 RVA: 0x002D29A8 File Offset: 0x002D0BA8
		// (set) Token: 0x0601E634 RID: 124468 RVA: 0x002D29E1 File Offset: 0x002D0BE1
		public FMotorBrakingTurnConfig MotorBrakingTurnConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBrakingTurnConfig result;
				if ((result = this._MotorBrakingTurnConfig) == null)
				{
					result = (this._MotorBrakingTurnConfig = new FMotorBrakingTurnConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBrakingTurnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBrakingTurnConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorBrakingTurnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D8 RID: 30936
		// (get) Token: 0x0601E635 RID: 124469 RVA: 0x002D2A04 File Offset: 0x002D0C04
		// (set) Token: 0x0601E636 RID: 124470 RVA: 0x002D2A3D File Offset: 0x002D0C3D
		public FMotorSoarConfig MotorSoarConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorSoarConfig result;
				if ((result = this._MotorSoarConfig) == null)
				{
					result = (this._MotorSoarConfig = new FMotorSoarConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorSoarConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorSoarConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorSoarConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078D9 RID: 30937
		// (get) Token: 0x0601E637 RID: 124471 RVA: 0x002D2A60 File Offset: 0x002D0C60
		// (set) Token: 0x0601E638 RID: 124472 RVA: 0x002D2A99 File Offset: 0x002D0C99
		public FMotorNewDriftConfig MotorNewDriftConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorNewDriftConfig result;
				if ((result = this._MotorNewDriftConfig) == null)
				{
					result = (this._MotorNewDriftConfig = new FMotorNewDriftConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorNewDriftConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorNewDriftConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorNewDriftConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078DA RID: 30938
		// (get) Token: 0x0601E639 RID: 124473 RVA: 0x002D2ABC File Offset: 0x002D0CBC
		// (set) Token: 0x0601E63A RID: 124474 RVA: 0x002D2AF5 File Offset: 0x002D0CF5
		public FMotorTurnConfig MotorTurnConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorTurnConfig result;
				if ((result = this._MotorTurnConfig) == null)
				{
					result = (this._MotorTurnConfig = new FMotorTurnConfig(base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorTurnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorTurnConfig.StaticStruct(), base.NativePtr + (IntPtr)UMotorcycleConfigs.__PropertyOffset_MotorTurnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E63B RID: 124475 RVA: 0x002D2B16 File Offset: 0x002D0D16
		static UMotorcycleConfigs()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.MotorcycleConfigs");
		}

		// Token: 0x0601E63C RID: 124476 RVA: 0x002D2B24 File Offset: 0x002D0D24
		protected UMotorcycleConfigs(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010628 RID: 67112
		public new const string __ObjectPath = "/Script/KuroVehicle.MotorcycleConfigs";

		// Token: 0x04010629 RID: 67113
		private static IntPtr _ClassPtr;

		// Token: 0x0401062A RID: 67114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401062B RID: 67115
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x0401062C RID: 67116
		internal static int __PropertyOffset_MotorAirFriction;

		// Token: 0x0401062D RID: 67117
		internal static int __PropertyOffset_MotorBodyAngularLengths;

		// Token: 0x0401062E RID: 67118
		internal static int __PropertyOffset_MotorBodyAngularRateInHitSpeed;

		// Token: 0x0401062F RID: 67119
		[Nullable(2)]
		private FMotorFloatRange _MotorBodyAngularRateInHitSpeed;

		// Token: 0x04010630 RID: 67120
		internal static int __PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup;

		// Token: 0x04010631 RID: 67121
		internal static int __PropertyOffset_MotorFrontWheelHang;

		// Token: 0x04010632 RID: 67122
		[Nullable(2)]
		private FMotorHangConfigParams _MotorFrontWheelHang;

		// Token: 0x04010633 RID: 67123
		internal static int __PropertyOffset_MotorBackWheelHang;

		// Token: 0x04010634 RID: 67124
		[Nullable(2)]
		private FMotorHangConfigParams _MotorBackWheelHang;

		// Token: 0x04010635 RID: 67125
		internal static int __PropertyOffset_MotorBodyPhys;

		// Token: 0x04010636 RID: 67126
		[Nullable(2)]
		private FMotorContactPhysParams _MotorBodyPhys;

		// Token: 0x04010637 RID: 67127
		internal static int __PropertyOffset_MotorFrontWheelPhys;

		// Token: 0x04010638 RID: 67128
		[Nullable(2)]
		private FMotorContactPhysParams _MotorFrontWheelPhys;

		// Token: 0x04010639 RID: 67129
		internal static int __PropertyOffset_MotorBackWheelPhys;

		// Token: 0x0401063A RID: 67130
		[Nullable(2)]
		private FMotorContactPhysParams _MotorBackWheelPhys;

		// Token: 0x0401063B RID: 67131
		internal static int __PropertyOffset_MotorAccelConfig;

		// Token: 0x0401063C RID: 67132
		[Nullable(2)]
		private FMotorAccelConfig _MotorAccelConfig;

		// Token: 0x0401063D RID: 67133
		internal static int __PropertyOffset_MotorBoostConfig;

		// Token: 0x0401063E RID: 67134
		[Nullable(2)]
		private FMotorBoostConfig _MotorBoostConfig;

		// Token: 0x0401063F RID: 67135
		internal static int __PropertyOffset_MotorBalanceConfig;

		// Token: 0x04010640 RID: 67136
		[Nullable(2)]
		private FMotorBalanceConfig _MotorBalanceConfig;

		// Token: 0x04010641 RID: 67137
		internal static int __PropertyOffset_MotorBrakingTurnConfig;

		// Token: 0x04010642 RID: 67138
		[Nullable(2)]
		private FMotorBrakingTurnConfig _MotorBrakingTurnConfig;

		// Token: 0x04010643 RID: 67139
		internal static int __PropertyOffset_MotorSoarConfig;

		// Token: 0x04010644 RID: 67140
		[Nullable(2)]
		private FMotorSoarConfig _MotorSoarConfig;

		// Token: 0x04010645 RID: 67141
		internal static int __PropertyOffset_MotorNewDriftConfig;

		// Token: 0x04010646 RID: 67142
		[Nullable(2)]
		private FMotorNewDriftConfig _MotorNewDriftConfig;

		// Token: 0x04010647 RID: 67143
		internal static int __PropertyOffset_MotorTurnConfig;

		// Token: 0x04010648 RID: 67144
		[Nullable(2)]
		private FMotorTurnConfig _MotorTurnConfig;
	}
}
