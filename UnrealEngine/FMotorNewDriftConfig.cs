using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F36 RID: 7990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorNewDriftConfig")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FMotorNewDriftConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E677 RID: 124535 RVA: 0x002D2FC6 File Offset: 0x002D11C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorNewDriftConfig._ScriptStructPtr != 0) ? FMotorNewDriftConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorNewDriftConfig", ref FMotorNewDriftConfig._ScriptStructPtr);
		}

		// Token: 0x170078EC RID: 30956
		// (get) Token: 0x0601E678 RID: 124536 RVA: 0x002D2FEA File Offset: 0x002D11EA
		// (set) Token: 0x0601E679 RID: 124537 RVA: 0x002D2FFA File Offset: 0x002D11FA
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170078ED RID: 30957
		// (get) Token: 0x0601E67A RID: 124538 RVA: 0x002D300C File Offset: 0x002D120C
		// (set) Token: 0x0601E67B RID: 124539 RVA: 0x002D304F File Offset: 0x002D124F
		public FMotorFloatRange DragByKeyTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._DragByKeyTime) == null)
				{
					result = (this._DragByKeyTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_DragByKeyTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_DragByKeyTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078EE RID: 30958
		// (get) Token: 0x0601E67C RID: 124540 RVA: 0x002D3070 File Offset: 0x002D1270
		// (set) Token: 0x0601E67D RID: 124541 RVA: 0x002D30B3 File Offset: 0x002D12B3
		public FMotorFloatRange PowerByKeyTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._PowerByKeyTime) == null)
				{
					result = (this._PowerByKeyTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_PowerByKeyTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_PowerByKeyTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078EF RID: 30959
		// (get) Token: 0x0601E67E RID: 124542 RVA: 0x002D30D4 File Offset: 0x002D12D4
		// (set) Token: 0x0601E67F RID: 124543 RVA: 0x002D3117 File Offset: 0x002D1317
		public FMotorFloatRange MaxSpeedByKeyTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._MaxSpeedByKeyTime) == null)
				{
					result = (this._MaxSpeedByKeyTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_MaxSpeedByKeyTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_MaxSpeedByKeyTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F0 RID: 30960
		// (get) Token: 0x0601E680 RID: 124544 RVA: 0x002D3138 File Offset: 0x002D1338
		// (set) Token: 0x0601E681 RID: 124545 RVA: 0x002D317B File Offset: 0x002D137B
		public FMotorFloatRange RotateSpeedRateByKeyTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RotateSpeedRateByKeyTime) == null)
				{
					result = (this._RotateSpeedRateByKeyTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RotateSpeedRateByKeyTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RotateSpeedRateByKeyTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F1 RID: 30961
		// (get) Token: 0x0601E682 RID: 124546 RVA: 0x002D319C File Offset: 0x002D139C
		// (set) Token: 0x0601E683 RID: 124547 RVA: 0x002D31DF File Offset: 0x002D13DF
		public FMotorFloatRange SlideDragWeakenByExitDriftTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SlideDragWeakenByExitDriftTime) == null)
				{
					result = (this._SlideDragWeakenByExitDriftTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_SlideDragWeakenByExitDriftTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_SlideDragWeakenByExitDriftTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F2 RID: 30962
		// (get) Token: 0x0601E684 RID: 124548 RVA: 0x002D3200 File Offset: 0x002D1400
		// (set) Token: 0x0601E685 RID: 124549 RVA: 0x002D3243 File Offset: 0x002D1443
		public FMotorFloatRange DriftToNormalBlendByExitDriftTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._DriftToNormalBlendByExitDriftTime) == null)
				{
					result = (this._DriftToNormalBlendByExitDriftTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_DriftToNormalBlendByExitDriftTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_DriftToNormalBlendByExitDriftTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F3 RID: 30963
		// (get) Token: 0x0601E686 RID: 124550 RVA: 0x002D3264 File Offset: 0x002D1464
		// (set) Token: 0x0601E687 RID: 124551 RVA: 0x002D32A7 File Offset: 0x002D14A7
		public FMotorFloatRange RotateSpeedRateByExitDriftTime
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RotateSpeedRateByExitDriftTime) == null)
				{
					result = (this._RotateSpeedRateByExitDriftTime = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RotateSpeedRateByExitDriftTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RotateSpeedRateByExitDriftTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F4 RID: 30964
		// (get) Token: 0x0601E688 RID: 124552 RVA: 0x002D32C8 File Offset: 0x002D14C8
		// (set) Token: 0x0601E689 RID: 124553 RVA: 0x002D32D8 File Offset: 0x002D14D8
		public unsafe float ExitDriftYInputCorrectionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ExitDriftYInputCorrectionDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ExitDriftYInputCorrectionDuration) = value;
			}
		}

		// Token: 0x170078F5 RID: 30965
		// (get) Token: 0x0601E68A RID: 124554 RVA: 0x002D32EC File Offset: 0x002D14EC
		// (set) Token: 0x0601E68B RID: 124555 RVA: 0x002D332F File Offset: 0x002D152F
		public FMotorFloatRange ExitDriftYInputCorrectionByAngle
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._ExitDriftYInputCorrectionByAngle) == null)
				{
					result = (this._ExitDriftYInputCorrectionByAngle = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ExitDriftYInputCorrectionByAngle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ExitDriftYInputCorrectionByAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F6 RID: 30966
		// (get) Token: 0x0601E68C RID: 124556 RVA: 0x002D3350 File Offset: 0x002D1550
		// (set) Token: 0x0601E68D RID: 124557 RVA: 0x002D3360 File Offset: 0x002D1560
		public unsafe float ConsecutiveDriftTimeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ConsecutiveDriftTimeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ConsecutiveDriftTimeThreshold) = value;
			}
		}

		// Token: 0x170078F7 RID: 30967
		// (get) Token: 0x0601E68E RID: 124558 RVA: 0x002D3374 File Offset: 0x002D1574
		// (set) Token: 0x0601E68F RID: 124559 RVA: 0x002D33B7 File Offset: 0x002D15B7
		public FMotorFloatRange ConsecutiveDriftExtraAccel
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._ConsecutiveDriftExtraAccel) == null)
				{
					result = (this._ConsecutiveDriftExtraAccel = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ConsecutiveDriftExtraAccel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_ConsecutiveDriftExtraAccel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F8 RID: 30968
		// (get) Token: 0x0601E690 RID: 124560 RVA: 0x002D33D8 File Offset: 0x002D15D8
		// (set) Token: 0x0601E691 RID: 124561 RVA: 0x002D341B File Offset: 0x002D161B
		public FMotorFloatRange RollAngleNonDrift
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RollAngleNonDrift) == null)
				{
					result = (this._RollAngleNonDrift = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RollAngleNonDrift, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RollAngleNonDrift, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170078F9 RID: 30969
		// (get) Token: 0x0601E692 RID: 124562 RVA: 0x002D343C File Offset: 0x002D163C
		// (set) Token: 0x0601E693 RID: 124563 RVA: 0x002D347F File Offset: 0x002D167F
		public FMotorFloatRange RollAngleInDrift
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._RollAngleInDrift) == null)
				{
					result = (this._RollAngleInDrift = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RollAngleInDrift, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorNewDriftConfig.__PropertyOffset_RollAngleInDrift, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E694 RID: 124564 RVA: 0x002D34A0 File Offset: 0x002D16A0
		public FMotorNewDriftConfig()
		{
		}

		// Token: 0x0601E695 RID: 124565 RVA: 0x002D34A8 File Offset: 0x002D16A8
		public FMotorNewDriftConfig(bool bEnable, FMotorFloatRange DragByKeyTime, FMotorFloatRange PowerByKeyTime, FMotorFloatRange MaxSpeedByKeyTime, FMotorFloatRange RotateSpeedRateByKeyTime, FMotorFloatRange SlideDragWeakenByExitDriftTime, FMotorFloatRange DriftToNormalBlendByExitDriftTime, FMotorFloatRange RotateSpeedRateByExitDriftTime, float ExitDriftYInputCorrectionDuration, FMotorFloatRange ExitDriftYInputCorrectionByAngle, float ConsecutiveDriftTimeThreshold, FMotorFloatRange ConsecutiveDriftExtraAccel, FMotorFloatRange RollAngleNonDrift, FMotorFloatRange RollAngleInDrift)
		{
			this.bEnable = bEnable;
			this.DragByKeyTime = DragByKeyTime;
			this.PowerByKeyTime = PowerByKeyTime;
			this.MaxSpeedByKeyTime = MaxSpeedByKeyTime;
			this.RotateSpeedRateByKeyTime = RotateSpeedRateByKeyTime;
			this.SlideDragWeakenByExitDriftTime = SlideDragWeakenByExitDriftTime;
			this.DriftToNormalBlendByExitDriftTime = DriftToNormalBlendByExitDriftTime;
			this.RotateSpeedRateByExitDriftTime = RotateSpeedRateByExitDriftTime;
			this.ExitDriftYInputCorrectionDuration = ExitDriftYInputCorrectionDuration;
			this.ExitDriftYInputCorrectionByAngle = ExitDriftYInputCorrectionByAngle;
			this.ConsecutiveDriftTimeThreshold = ConsecutiveDriftTimeThreshold;
			this.ConsecutiveDriftExtraAccel = ConsecutiveDriftExtraAccel;
			this.RollAngleNonDrift = RollAngleNonDrift;
			this.RollAngleInDrift = RollAngleInDrift;
		}

		// Token: 0x0601E696 RID: 124566 RVA: 0x002D3528 File Offset: 0x002D1728
		protected override IntPtr GetUStructPtr()
		{
			return FMotorNewDriftConfig.StaticStruct();
		}

		// Token: 0x0601E697 RID: 124567 RVA: 0x002D3534 File Offset: 0x002D1734
		[NullableContext(2)]
		public FMotorNewDriftConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E698 RID: 124568 RVA: 0x002D353E File Offset: 0x002D173E
		public FMotorNewDriftConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E699 RID: 124569 RVA: 0x002D3549 File Offset: 0x002D1749
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorNewDriftConfig(Pointer, false, true);
		}

		// Token: 0x0601E69A RID: 124570 RVA: 0x002D3553 File Offset: 0x002D1753
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorNewDriftConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010662 RID: 67170
		public const string __ObjectPath = "/Script/KuroVehicle.MotorNewDriftConfig";

		// Token: 0x04010663 RID: 67171
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010664 RID: 67172
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04010665 RID: 67173
		internal static int __PropertyOffset_DragByKeyTime;

		// Token: 0x04010666 RID: 67174
		[Nullable(2)]
		private FMotorFloatRange _DragByKeyTime;

		// Token: 0x04010667 RID: 67175
		internal static int __PropertyOffset_PowerByKeyTime;

		// Token: 0x04010668 RID: 67176
		[Nullable(2)]
		private FMotorFloatRange _PowerByKeyTime;

		// Token: 0x04010669 RID: 67177
		internal static int __PropertyOffset_MaxSpeedByKeyTime;

		// Token: 0x0401066A RID: 67178
		[Nullable(2)]
		private FMotorFloatRange _MaxSpeedByKeyTime;

		// Token: 0x0401066B RID: 67179
		internal static int __PropertyOffset_RotateSpeedRateByKeyTime;

		// Token: 0x0401066C RID: 67180
		[Nullable(2)]
		private FMotorFloatRange _RotateSpeedRateByKeyTime;

		// Token: 0x0401066D RID: 67181
		internal static int __PropertyOffset_SlideDragWeakenByExitDriftTime;

		// Token: 0x0401066E RID: 67182
		[Nullable(2)]
		private FMotorFloatRange _SlideDragWeakenByExitDriftTime;

		// Token: 0x0401066F RID: 67183
		internal static int __PropertyOffset_DriftToNormalBlendByExitDriftTime;

		// Token: 0x04010670 RID: 67184
		[Nullable(2)]
		private FMotorFloatRange _DriftToNormalBlendByExitDriftTime;

		// Token: 0x04010671 RID: 67185
		internal static int __PropertyOffset_RotateSpeedRateByExitDriftTime;

		// Token: 0x04010672 RID: 67186
		[Nullable(2)]
		private FMotorFloatRange _RotateSpeedRateByExitDriftTime;

		// Token: 0x04010673 RID: 67187
		internal static int __PropertyOffset_ExitDriftYInputCorrectionDuration;

		// Token: 0x04010674 RID: 67188
		internal static int __PropertyOffset_ExitDriftYInputCorrectionByAngle;

		// Token: 0x04010675 RID: 67189
		[Nullable(2)]
		private FMotorFloatRange _ExitDriftYInputCorrectionByAngle;

		// Token: 0x04010676 RID: 67190
		internal static int __PropertyOffset_ConsecutiveDriftTimeThreshold;

		// Token: 0x04010677 RID: 67191
		internal static int __PropertyOffset_ConsecutiveDriftExtraAccel;

		// Token: 0x04010678 RID: 67192
		[Nullable(2)]
		private FMotorFloatRange _ConsecutiveDriftExtraAccel;

		// Token: 0x04010679 RID: 67193
		internal static int __PropertyOffset_RollAngleNonDrift;

		// Token: 0x0401067A RID: 67194
		[Nullable(2)]
		private FMotorFloatRange _RollAngleNonDrift;

		// Token: 0x0401067B RID: 67195
		internal static int __PropertyOffset_RollAngleInDrift;

		// Token: 0x0401067C RID: 67196
		[Nullable(2)]
		private FMotorFloatRange _RollAngleInDrift;
	}
}
