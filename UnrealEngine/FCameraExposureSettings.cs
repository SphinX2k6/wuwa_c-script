using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200090D RID: 2317
	[UnrealObjectPath("/Script/Engine.CameraExposureSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FCameraExposureSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007F60 RID: 32608 RVA: 0x000B69E2 File Offset: 0x000B4BE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraExposureSettings._ScriptStructPtr != 0) ? FCameraExposureSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraExposureSettings", ref FCameraExposureSettings._ScriptStructPtr);
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x000B6A06 File Offset: 0x000B4C06
		// (set) Token: 0x06007F62 RID: 32610 RVA: 0x000B6A1A File Offset: 0x000B4C1A
		public unsafe TEnumAsByte<EAutoExposureMethod> Method
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_Method);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_Method) = value;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06007F63 RID: 32611 RVA: 0x000B6A2F File Offset: 0x000B4C2F
		// (set) Token: 0x06007F64 RID: 32612 RVA: 0x000B6A3F File Offset: 0x000B4C3F
		public unsafe float LowPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_LowPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_LowPercent) = value;
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x000B6A50 File Offset: 0x000B4C50
		// (set) Token: 0x06007F66 RID: 32614 RVA: 0x000B6A60 File Offset: 0x000B4C60
		public unsafe float HighPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HighPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HighPercent) = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06007F67 RID: 32615 RVA: 0x000B6A71 File Offset: 0x000B4C71
		// (set) Token: 0x06007F68 RID: 32616 RVA: 0x000B6A81 File Offset: 0x000B4C81
		public unsafe float MinBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_MinBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_MinBrightness) = value;
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x000B6A92 File Offset: 0x000B4C92
		// (set) Token: 0x06007F6A RID: 32618 RVA: 0x000B6AA2 File Offset: 0x000B4CA2
		public unsafe float MaxBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_MaxBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_MaxBrightness) = value;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x000B6AB3 File Offset: 0x000B4CB3
		// (set) Token: 0x06007F6C RID: 32620 RVA: 0x000B6AC3 File Offset: 0x000B4CC3
		public unsafe float SpeedUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_SpeedUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_SpeedUp) = value;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x000B6AD4 File Offset: 0x000B4CD4
		// (set) Token: 0x06007F6E RID: 32622 RVA: 0x000B6AE4 File Offset: 0x000B4CE4
		public unsafe float SpeedDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_SpeedDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_SpeedDown) = value;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x000B6AF5 File Offset: 0x000B4CF5
		// (set) Token: 0x06007F70 RID: 32624 RVA: 0x000B6B05 File Offset: 0x000B4D05
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x000B6B16 File Offset: 0x000B4D16
		// (set) Token: 0x06007F72 RID: 32626 RVA: 0x000B6B2A File Offset: 0x000B4D2A
		[Nullable(2)]
		public unsafe UCurveFloat BiasCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FCameraExposureSettings.__PropertyOffset_BiasCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCameraExposureSettings.__PropertyOffset_BiasCurve, value);
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06007F73 RID: 32627 RVA: 0x000B6B3F File Offset: 0x000B4D3F
		// (set) Token: 0x06007F74 RID: 32628 RVA: 0x000B6B53 File Offset: 0x000B4D53
		[Nullable(2)]
		public unsafe UTexture MeterMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FCameraExposureSettings.__PropertyOffset_MeterMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCameraExposureSettings.__PropertyOffset_MeterMask, value);
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06007F75 RID: 32629 RVA: 0x000B6B68 File Offset: 0x000B4D68
		// (set) Token: 0x06007F76 RID: 32630 RVA: 0x000B6B78 File Offset: 0x000B4D78
		public unsafe float HistogramLogMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HistogramLogMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HistogramLogMin) = value;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x000B6B89 File Offset: 0x000B4D89
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x000B6B99 File Offset: 0x000B4D99
		public unsafe float HistogramLogMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HistogramLogMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_HistogramLogMax) = value;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06007F79 RID: 32633 RVA: 0x000B6BAA File Offset: 0x000B4DAA
		// (set) Token: 0x06007F7A RID: 32634 RVA: 0x000B6BBA File Offset: 0x000B4DBA
		public unsafe float CalibrationConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_CalibrationConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_CalibrationConstant) = value;
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06007F7B RID: 32635 RVA: 0x000B6BCB File Offset: 0x000B4DCB
		// (set) Token: 0x06007F7C RID: 32636 RVA: 0x000B6BE4 File Offset: 0x000B4DE4
		public unsafe bool ApplyPhysicalCameraExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_ApplyPhysicalCameraExposure) & FCameraExposureSettings.__PropertyMask_ApplyPhysicalCameraExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_ApplyPhysicalCameraExposure) = ((*(base.NativePtr + (IntPtr)FCameraExposureSettings.__PropertyOffset_ApplyPhysicalCameraExposure) & ~FCameraExposureSettings.__PropertyMask_ApplyPhysicalCameraExposure) | (value ? FCameraExposureSettings.__PropertyMask_ApplyPhysicalCameraExposure : 0));
			}
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x000B6C14 File Offset: 0x000B4E14
		public FCameraExposureSettings()
		{
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x000B6C1C File Offset: 0x000B4E1C
		[NullableContext(1)]
		public FCameraExposureSettings([Nullable(0)] TEnumAsByte<EAutoExposureMethod> Method, float LowPercent, float HighPercent, float MinBrightness, float MaxBrightness, float SpeedUp, float SpeedDown, float Bias, UCurveFloat BiasCurve, UTexture MeterMask, float HistogramLogMin, float HistogramLogMax, float CalibrationConstant, bool ApplyPhysicalCameraExposure)
		{
			this.Method = Method;
			this.LowPercent = LowPercent;
			this.HighPercent = HighPercent;
			this.MinBrightness = MinBrightness;
			this.MaxBrightness = MaxBrightness;
			this.SpeedUp = SpeedUp;
			this.SpeedDown = SpeedDown;
			this.Bias = Bias;
			this.BiasCurve = BiasCurve;
			this.MeterMask = MeterMask;
			this.HistogramLogMin = HistogramLogMin;
			this.HistogramLogMax = HistogramLogMax;
			this.CalibrationConstant = CalibrationConstant;
			this.ApplyPhysicalCameraExposure = ApplyPhysicalCameraExposure;
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x000B6C9C File Offset: 0x000B4E9C
		protected override IntPtr GetUStructPtr()
		{
			return FCameraExposureSettings.StaticStruct();
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x000B6CA8 File Offset: 0x000B4EA8
		[NullableContext(2)]
		public FCameraExposureSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x000B6CB2 File Offset: 0x000B4EB2
		public FCameraExposureSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x000B6CBD File Offset: 0x000B4EBD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraExposureSettings(Pointer, false, true);
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x000B6CC7 File Offset: 0x000B4EC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraExposureSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003D12 RID: 15634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraExposureSettings";

		// Token: 0x04003D13 RID: 15635
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D14 RID: 15636
		internal static int __PropertyOffset_Method;

		// Token: 0x04003D15 RID: 15637
		internal static int __PropertyOffset_LowPercent;

		// Token: 0x04003D16 RID: 15638
		internal static int __PropertyOffset_HighPercent;

		// Token: 0x04003D17 RID: 15639
		internal static int __PropertyOffset_MinBrightness;

		// Token: 0x04003D18 RID: 15640
		internal static int __PropertyOffset_MaxBrightness;

		// Token: 0x04003D19 RID: 15641
		internal static int __PropertyOffset_SpeedUp;

		// Token: 0x04003D1A RID: 15642
		internal static int __PropertyOffset_SpeedDown;

		// Token: 0x04003D1B RID: 15643
		internal static int __PropertyOffset_Bias;

		// Token: 0x04003D1C RID: 15644
		internal static int __PropertyOffset_BiasCurve;

		// Token: 0x04003D1D RID: 15645
		internal static int __PropertyOffset_MeterMask;

		// Token: 0x04003D1E RID: 15646
		internal static int __PropertyOffset_HistogramLogMin;

		// Token: 0x04003D1F RID: 15647
		internal static int __PropertyOffset_HistogramLogMax;

		// Token: 0x04003D20 RID: 15648
		internal static int __PropertyOffset_CalibrationConstant;

		// Token: 0x04003D21 RID: 15649
		internal static int __PropertyOffset_ApplyPhysicalCameraExposure;

		// Token: 0x04003D22 RID: 15650
		internal static byte __PropertyMask_ApplyPhysicalCameraExposure;
	}
}
