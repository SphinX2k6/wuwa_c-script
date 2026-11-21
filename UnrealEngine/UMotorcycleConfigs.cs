using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000634 RID: 1588
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorcycleConfigs")]
	[UnrealStructLayout(1760, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1760)]
	public class UMotorcycleConfigs : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B6F RID: 35695 RVA: 0x000D1D4E File Offset: 0x000CFF4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotorcycleConfigs._ClassPtr;
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x000D1D5C File Offset: 0x000CFF5C
		public UMotorcycleConfigs() : this(BuiltinUtils.AllocNativeUObject(UMotorcycleConfigs.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x000D1D84 File Offset: 0x000CFF84
		public UMotorcycleConfigs(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotorcycleConfigs.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x000D1DB7 File Offset: 0x000CFFB7
		// (set) Token: 0x06008B73 RID: 35699 RVA: 0x000D1DC7 File Offset: 0x000CFFC7
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

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x000D1DD8 File Offset: 0x000CFFD8
		// (set) Token: 0x06008B75 RID: 35701 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
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

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06008B76 RID: 35702 RVA: 0x000D1DF9 File Offset: 0x000CFFF9
		// (set) Token: 0x06008B77 RID: 35703 RVA: 0x000D1E0D File Offset: 0x000D000D
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

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008B78 RID: 35704 RVA: 0x000D1E24 File Offset: 0x000D0024
		// (set) Token: 0x06008B79 RID: 35705 RVA: 0x000D1E5D File Offset: 0x000D005D
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

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06008B7A RID: 35706 RVA: 0x000D1E7E File Offset: 0x000D007E
		// (set) Token: 0x06008B7B RID: 35707 RVA: 0x000D1E8E File Offset: 0x000D008E
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

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008B7C RID: 35708 RVA: 0x000D1EA0 File Offset: 0x000D00A0
		// (set) Token: 0x06008B7D RID: 35709 RVA: 0x000D1ED9 File Offset: 0x000D00D9
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

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x000D1EFC File Offset: 0x000D00FC
		// (set) Token: 0x06008B7F RID: 35711 RVA: 0x000D1F35 File Offset: 0x000D0135
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

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06008B80 RID: 35712 RVA: 0x000D1F58 File Offset: 0x000D0158
		// (set) Token: 0x06008B81 RID: 35713 RVA: 0x000D1F91 File Offset: 0x000D0191
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

		// Token: 0x06008B82 RID: 35714 RVA: 0x000D1FB2 File Offset: 0x000D01B2
		static UMotorcycleConfigs()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.MotorcycleConfigs");
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x000D1FC0 File Offset: 0x000D01C0
		protected UMotorcycleConfigs(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C8F RID: 15503
		public new const string __ObjectPath = "/Script/KuroVehicle.MotorcycleConfigs";

		// Token: 0x04003C90 RID: 15504
		private static IntPtr _ClassPtr;

		// Token: 0x04003C91 RID: 15505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003C92 RID: 15506
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04003C93 RID: 15507
		internal static int __PropertyOffset_MotorAirFriction;

		// Token: 0x04003C94 RID: 15508
		internal static int __PropertyOffset_MotorBodyAngularLengths;

		// Token: 0x04003C95 RID: 15509
		internal static int __PropertyOffset_MotorBodyAngularRateInHitSpeed;

		// Token: 0x04003C96 RID: 15510
		[Nullable(2)]
		private FMotorFloatRange _MotorBodyAngularRateInHitSpeed;

		// Token: 0x04003C97 RID: 15511
		internal static int __PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup;

		// Token: 0x04003C98 RID: 15512
		internal static int __PropertyOffset_MotorFrontWheelHang;

		// Token: 0x04003C99 RID: 15513
		[Nullable(2)]
		private FMotorHangConfigParams _MotorFrontWheelHang;

		// Token: 0x04003C9A RID: 15514
		internal static int __PropertyOffset_MotorBackWheelHang;

		// Token: 0x04003C9B RID: 15515
		[Nullable(2)]
		private FMotorHangConfigParams _MotorBackWheelHang;

		// Token: 0x04003C9C RID: 15516
		internal static int __PropertyOffset_MotorAccelConfig;

		// Token: 0x04003C9D RID: 15517
		[Nullable(2)]
		private FMotorAccelConfig _MotorAccelConfig;
	}
}
