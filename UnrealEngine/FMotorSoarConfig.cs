using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F38 RID: 7992
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorSoarConfig")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FMotorSoarConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E6AB RID: 124587 RVA: 0x002D3761 File Offset: 0x002D1961
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorSoarConfig._ScriptStructPtr != 0) ? FMotorSoarConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorSoarConfig", ref FMotorSoarConfig._ScriptStructPtr);
		}

		// Token: 0x170078FE RID: 30974
		// (get) Token: 0x0601E6AC RID: 124588 RVA: 0x002D3788 File Offset: 0x002D1988
		// (set) Token: 0x0601E6AD RID: 124589 RVA: 0x002D37CB File Offset: 0x002D19CB
		public FMotorCurveRange SpeedToMaxPitch
		{
			get
			{
				base.FastCheckIsValid();
				FMotorCurveRange result;
				if ((result = this._SpeedToMaxPitch) == null)
				{
					result = (this._SpeedToMaxPitch = new FMotorCurveRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToMaxPitch, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorCurveRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToMaxPitch, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078FF RID: 30975
		// (get) Token: 0x0601E6AE RID: 124590 RVA: 0x002D37EC File Offset: 0x002D19EC
		// (set) Token: 0x0601E6AF RID: 124591 RVA: 0x002D37FC File Offset: 0x002D19FC
		public unsafe float MinPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_MinPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_MinPitch) = value;
			}
		}

		// Token: 0x17007900 RID: 30976
		// (get) Token: 0x0601E6B0 RID: 124592 RVA: 0x002D3810 File Offset: 0x002D1A10
		// (set) Token: 0x0601E6B1 RID: 124593 RVA: 0x002D3853 File Offset: 0x002D1A53
		public FMotorCurveRange PitchToMaxSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorCurveRange result;
				if ((result = this._PitchToMaxSpeed) == null)
				{
					result = (this._PitchToMaxSpeed = new FMotorCurveRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchToMaxSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorCurveRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchToMaxSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007901 RID: 30977
		// (get) Token: 0x0601E6B2 RID: 124594 RVA: 0x002D3874 File Offset: 0x002D1A74
		// (set) Token: 0x0601E6B3 RID: 124595 RVA: 0x002D3884 File Offset: 0x002D1A84
		public unsafe float BalancePitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_BalancePitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_BalancePitch) = value;
			}
		}

		// Token: 0x17007902 RID: 30978
		// (get) Token: 0x0601E6B4 RID: 124596 RVA: 0x002D3895 File Offset: 0x002D1A95
		// (set) Token: 0x0601E6B5 RID: 124597 RVA: 0x002D38A5 File Offset: 0x002D1AA5
		public unsafe float BalanceTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_BalanceTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_BalanceTolerance) = value;
			}
		}

		// Token: 0x17007903 RID: 30979
		// (get) Token: 0x0601E6B6 RID: 124598 RVA: 0x002D38B8 File Offset: 0x002D1AB8
		// (set) Token: 0x0601E6B7 RID: 124599 RVA: 0x002D38FB File Offset: 0x002D1AFB
		public FMotorFloatRange PitchToAccel
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._PitchToAccel) == null)
				{
					result = (this._PitchToAccel = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchToAccel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchToAccel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007904 RID: 30980
		// (get) Token: 0x0601E6B8 RID: 124600 RVA: 0x002D391C File Offset: 0x002D1B1C
		// (set) Token: 0x0601E6B9 RID: 124601 RVA: 0x002D395F File Offset: 0x002D1B5F
		public FMotorFloatRange SpeedToPitchUpSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToPitchUpSpeed) == null)
				{
					result = (this._SpeedToPitchUpSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchUpSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchUpSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007905 RID: 30981
		// (get) Token: 0x0601E6BA RID: 124602 RVA: 0x002D3980 File Offset: 0x002D1B80
		// (set) Token: 0x0601E6BB RID: 124603 RVA: 0x002D39C3 File Offset: 0x002D1BC3
		public FMotorFloatRange SpeedToPitchUpRate
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToPitchUpRate) == null)
				{
					result = (this._SpeedToPitchUpRate = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchUpRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchUpRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007906 RID: 30982
		// (get) Token: 0x0601E6BC RID: 124604 RVA: 0x002D39E4 File Offset: 0x002D1BE4
		// (set) Token: 0x0601E6BD RID: 124605 RVA: 0x002D3A27 File Offset: 0x002D1C27
		public FMotorFloatRange SpeedToPitchDownSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToPitchDownSpeed) == null)
				{
					result = (this._SpeedToPitchDownSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchDownSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchDownSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007907 RID: 30983
		// (get) Token: 0x0601E6BE RID: 124606 RVA: 0x002D3A48 File Offset: 0x002D1C48
		// (set) Token: 0x0601E6BF RID: 124607 RVA: 0x002D3A58 File Offset: 0x002D1C58
		public unsafe float PitchDownEnhanceNoInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchDownEnhanceNoInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_PitchDownEnhanceNoInput) = value;
			}
		}

		// Token: 0x17007908 RID: 30984
		// (get) Token: 0x0601E6C0 RID: 124608 RVA: 0x002D3A6C File Offset: 0x002D1C6C
		// (set) Token: 0x0601E6C1 RID: 124609 RVA: 0x002D3AAF File Offset: 0x002D1CAF
		public FMotorFloatRange SpeedToPitchDownRate
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToPitchDownRate) == null)
				{
					result = (this._SpeedToPitchDownRate = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchDownRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToPitchDownRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007909 RID: 30985
		// (get) Token: 0x0601E6C2 RID: 124610 RVA: 0x002D3AD0 File Offset: 0x002D1CD0
		// (set) Token: 0x0601E6C3 RID: 124611 RVA: 0x002D3B13 File Offset: 0x002D1D13
		public FMotorFloatRange SpeedToYawSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToYawSpeed) == null)
				{
					result = (this._SpeedToYawSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToYawSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToYawSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700790A RID: 30986
		// (get) Token: 0x0601E6C4 RID: 124612 RVA: 0x002D3B34 File Offset: 0x002D1D34
		// (set) Token: 0x0601E6C5 RID: 124613 RVA: 0x002D3B77 File Offset: 0x002D1D77
		public FMotorFloatRange SpeedToYawRate
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SpeedToYawRate) == null)
				{
					result = (this._SpeedToYawRate = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToYawRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SpeedToYawRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700790B RID: 30987
		// (get) Token: 0x0601E6C6 RID: 124614 RVA: 0x002D3B98 File Offset: 0x002D1D98
		// (set) Token: 0x0601E6C7 RID: 124615 RVA: 0x002D3BA8 File Offset: 0x002D1DA8
		public unsafe float SideResist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SideResist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_SideResist) = value;
			}
		}

		// Token: 0x1700790C RID: 30988
		// (get) Token: 0x0601E6C8 RID: 124616 RVA: 0x002D3BB9 File Offset: 0x002D1DB9
		// (set) Token: 0x0601E6C9 RID: 124617 RVA: 0x002D3BC9 File Offset: 0x002D1DC9
		public unsafe float ForwardFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ForwardFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ForwardFriction) = value;
			}
		}

		// Token: 0x1700790D RID: 30989
		// (get) Token: 0x0601E6CA RID: 124618 RVA: 0x002D3BDA File Offset: 0x002D1DDA
		// (set) Token: 0x0601E6CB RID: 124619 RVA: 0x002D3BEA File Offset: 0x002D1DEA
		public unsafe float ExitSoarDelayAngleThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ExitSoarDelayAngleThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ExitSoarDelayAngleThreshold) = value;
			}
		}

		// Token: 0x1700790E RID: 30990
		// (get) Token: 0x0601E6CC RID: 124620 RVA: 0x002D3BFB File Offset: 0x002D1DFB
		// (set) Token: 0x0601E6CD RID: 124621 RVA: 0x002D3C0F File Offset: 0x002D1E0F
		public unsafe FFloatRange ExitSoarDelayTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ExitSoarDelayTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_ExitSoarDelayTimeRange) = value;
			}
		}

		// Token: 0x1700790F RID: 30991
		// (get) Token: 0x0601E6CE RID: 124622 RVA: 0x002D3C24 File Offset: 0x002D1E24
		// (set) Token: 0x0601E6CF RID: 124623 RVA: 0x002D3C34 File Offset: 0x002D1E34
		public unsafe float HitReboundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_HitReboundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorSoarConfig.__PropertyOffset_HitReboundFriction) = value;
			}
		}

		// Token: 0x0601E6D0 RID: 124624 RVA: 0x002D3C45 File Offset: 0x002D1E45
		public FMotorSoarConfig()
		{
		}

		// Token: 0x0601E6D1 RID: 124625 RVA: 0x002D3C50 File Offset: 0x002D1E50
		public FMotorSoarConfig(FMotorCurveRange SpeedToMaxPitch, float MinPitch, FMotorCurveRange PitchToMaxSpeed, float BalancePitch, float BalanceTolerance, FMotorFloatRange PitchToAccel, FMotorFloatRange SpeedToPitchUpSpeed, FMotorFloatRange SpeedToPitchUpRate, FMotorFloatRange SpeedToPitchDownSpeed, float PitchDownEnhanceNoInput, FMotorFloatRange SpeedToPitchDownRate, FMotorFloatRange SpeedToYawSpeed, FMotorFloatRange SpeedToYawRate, float SideResist, float ForwardFriction, float ExitSoarDelayAngleThreshold, FFloatRange ExitSoarDelayTimeRange, float HitReboundFriction)
		{
			this.SpeedToMaxPitch = SpeedToMaxPitch;
			this.MinPitch = MinPitch;
			this.PitchToMaxSpeed = PitchToMaxSpeed;
			this.BalancePitch = BalancePitch;
			this.BalanceTolerance = BalanceTolerance;
			this.PitchToAccel = PitchToAccel;
			this.SpeedToPitchUpSpeed = SpeedToPitchUpSpeed;
			this.SpeedToPitchUpRate = SpeedToPitchUpRate;
			this.SpeedToPitchDownSpeed = SpeedToPitchDownSpeed;
			this.PitchDownEnhanceNoInput = PitchDownEnhanceNoInput;
			this.SpeedToPitchDownRate = SpeedToPitchDownRate;
			this.SpeedToYawSpeed = SpeedToYawSpeed;
			this.SpeedToYawRate = SpeedToYawRate;
			this.SideResist = SideResist;
			this.ForwardFriction = ForwardFriction;
			this.ExitSoarDelayAngleThreshold = ExitSoarDelayAngleThreshold;
			this.ExitSoarDelayTimeRange = ExitSoarDelayTimeRange;
			this.HitReboundFriction = HitReboundFriction;
		}

		// Token: 0x0601E6D2 RID: 124626 RVA: 0x002D3CF0 File Offset: 0x002D1EF0
		protected override IntPtr GetUStructPtr()
		{
			return FMotorSoarConfig.StaticStruct();
		}

		// Token: 0x0601E6D3 RID: 124627 RVA: 0x002D3CFC File Offset: 0x002D1EFC
		[NullableContext(2)]
		public FMotorSoarConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E6D4 RID: 124628 RVA: 0x002D3D06 File Offset: 0x002D1F06
		public FMotorSoarConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E6D5 RID: 124629 RVA: 0x002D3D11 File Offset: 0x002D1F11
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorSoarConfig(Pointer, false, true);
		}

		// Token: 0x0601E6D6 RID: 124630 RVA: 0x002D3D1B File Offset: 0x002D1F1B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorSoarConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010687 RID: 67207
		public const string __ObjectPath = "/Script/KuroVehicle.MotorSoarConfig";

		// Token: 0x04010688 RID: 67208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010689 RID: 67209
		internal static int __PropertyOffset_SpeedToMaxPitch;

		// Token: 0x0401068A RID: 67210
		[Nullable(2)]
		private FMotorCurveRange _SpeedToMaxPitch;

		// Token: 0x0401068B RID: 67211
		internal static int __PropertyOffset_MinPitch;

		// Token: 0x0401068C RID: 67212
		internal static int __PropertyOffset_PitchToMaxSpeed;

		// Token: 0x0401068D RID: 67213
		[Nullable(2)]
		private FMotorCurveRange _PitchToMaxSpeed;

		// Token: 0x0401068E RID: 67214
		internal static int __PropertyOffset_BalancePitch;

		// Token: 0x0401068F RID: 67215
		internal static int __PropertyOffset_BalanceTolerance;

		// Token: 0x04010690 RID: 67216
		internal static int __PropertyOffset_PitchToAccel;

		// Token: 0x04010691 RID: 67217
		[Nullable(2)]
		private FMotorFloatRange _PitchToAccel;

		// Token: 0x04010692 RID: 67218
		internal static int __PropertyOffset_SpeedToPitchUpSpeed;

		// Token: 0x04010693 RID: 67219
		[Nullable(2)]
		private FMotorFloatRange _SpeedToPitchUpSpeed;

		// Token: 0x04010694 RID: 67220
		internal static int __PropertyOffset_SpeedToPitchUpRate;

		// Token: 0x04010695 RID: 67221
		[Nullable(2)]
		private FMotorFloatRange _SpeedToPitchUpRate;

		// Token: 0x04010696 RID: 67222
		internal static int __PropertyOffset_SpeedToPitchDownSpeed;

		// Token: 0x04010697 RID: 67223
		[Nullable(2)]
		private FMotorFloatRange _SpeedToPitchDownSpeed;

		// Token: 0x04010698 RID: 67224
		internal static int __PropertyOffset_PitchDownEnhanceNoInput;

		// Token: 0x04010699 RID: 67225
		internal static int __PropertyOffset_SpeedToPitchDownRate;

		// Token: 0x0401069A RID: 67226
		[Nullable(2)]
		private FMotorFloatRange _SpeedToPitchDownRate;

		// Token: 0x0401069B RID: 67227
		internal static int __PropertyOffset_SpeedToYawSpeed;

		// Token: 0x0401069C RID: 67228
		[Nullable(2)]
		private FMotorFloatRange _SpeedToYawSpeed;

		// Token: 0x0401069D RID: 67229
		internal static int __PropertyOffset_SpeedToYawRate;

		// Token: 0x0401069E RID: 67230
		[Nullable(2)]
		private FMotorFloatRange _SpeedToYawRate;

		// Token: 0x0401069F RID: 67231
		internal static int __PropertyOffset_SideResist;

		// Token: 0x040106A0 RID: 67232
		internal static int __PropertyOffset_ForwardFriction;

		// Token: 0x040106A1 RID: 67233
		internal static int __PropertyOffset_ExitSoarDelayAngleThreshold;

		// Token: 0x040106A2 RID: 67234
		internal static int __PropertyOffset_ExitSoarDelayTimeRange;

		// Token: 0x040106A3 RID: 67235
		internal static int __PropertyOffset_HitReboundFriction;
	}
}
