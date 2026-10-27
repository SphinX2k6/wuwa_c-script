using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200166A RID: 5738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_BasicSettings")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 312)]
	public class FKuroQuadrupedIK_BasicSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014C90 RID: 85136 RVA: 0x001E9144 File Offset: 0x001E7344
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_BasicSettings._ScriptStructPtr != 0) ? FKuroQuadrupedIK_BasicSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_BasicSettings", ref FKuroQuadrupedIK_BasicSettings._ScriptStructPtr);
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x06014C91 RID: 85137 RVA: 0x001E9168 File Offset: 0x001E7368
		// (set) Token: 0x06014C92 RID: 85138 RVA: 0x001E9178 File Offset: 0x001E7378
		public unsafe bool SpineEnableSolver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_SpineEnableSolver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_SpineEnableSolver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x06014C93 RID: 85139 RVA: 0x001E9189 File Offset: 0x001E7389
		// (set) Token: 0x06014C94 RID: 85140 RVA: 0x001E9199 File Offset: 0x001E7399
		public unsafe bool FeetEnableSolver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetEnableSolver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetEnableSolver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x06014C95 RID: 85141 RVA: 0x001E91AA File Offset: 0x001E73AA
		// (set) Token: 0x06014C96 RID: 85142 RVA: 0x001E91BA File Offset: 0x001E73BA
		public unsafe bool MovingBaseCompensationEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MovingBaseCompensationEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MovingBaseCompensationEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x06014C97 RID: 85143 RVA: 0x001E91CB File Offset: 0x001E73CB
		// (set) Token: 0x06014C98 RID: 85144 RVA: 0x001E91DB File Offset: 0x001E73DB
		public unsafe float TraceUpperHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceUpperHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceUpperHeight) = value;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x06014C99 RID: 85145 RVA: 0x001E91EC File Offset: 0x001E73EC
		// (set) Token: 0x06014C9A RID: 85146 RVA: 0x001E91FC File Offset: 0x001E73FC
		public unsafe float TraceDownwardHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceDownwardHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceDownwardHeight) = value;
			}
		}

		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x06014C9B RID: 85147 RVA: 0x001E920D File Offset: 0x001E740D
		// (set) Token: 0x06014C9C RID: 85148 RVA: 0x001E921D File Offset: 0x001E741D
		public unsafe bool TraceWaterSurface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceWaterSurface) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_TraceWaterSurface) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x06014C9D RID: 85149 RVA: 0x001E922E File Offset: 0x001E742E
		// (set) Token: 0x06014C9E RID: 85150 RVA: 0x001E923E File Offset: 0x001E743E
		public unsafe bool FeetEnableTracePredict
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetEnableTracePredict) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetEnableTracePredict) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x06014C9F RID: 85151 RVA: 0x001E924F File Offset: 0x001E744F
		// (set) Token: 0x06014CA0 RID: 85152 RVA: 0x001E925F File Offset: 0x001E745F
		public unsafe float FeetTracePredictScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetTracePredictScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetTracePredictScale) = value;
			}
		}

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x06014CA1 RID: 85153 RVA: 0x001E9270 File Offset: 0x001E7470
		// (set) Token: 0x06014CA2 RID: 85154 RVA: 0x001E92B3 File Offset: 0x001E74B3
		public FRuntimeFloatCurve FeetTraceOriginWeightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._FeetTraceOriginWeightCurve) == null)
				{
					result = (this._FeetTraceOriginWeightCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetTraceOriginWeightCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_FeetTraceOriginWeightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x06014CA3 RID: 85155 RVA: 0x001E92D4 File Offset: 0x001E74D4
		// (set) Token: 0x06014CA4 RID: 85156 RVA: 0x001E92E4 File Offset: 0x001E74E4
		public unsafe float MaximumPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MaximumPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MaximumPitch) = value;
			}
		}

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x06014CA5 RID: 85157 RVA: 0x001E92F5 File Offset: 0x001E74F5
		// (set) Token: 0x06014CA6 RID: 85158 RVA: 0x001E9305 File Offset: 0x001E7505
		public unsafe float MinimumPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MinimumPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MinimumPitch) = value;
			}
		}

		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x06014CA7 RID: 85159 RVA: 0x001E9316 File Offset: 0x001E7516
		// (set) Token: 0x06014CA8 RID: 85160 RVA: 0x001E9326 File Offset: 0x001E7526
		public unsafe float MaximumRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MaximumRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MaximumRoll) = value;
			}
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x06014CA9 RID: 85161 RVA: 0x001E9337 File Offset: 0x001E7537
		// (set) Token: 0x06014CAA RID: 85162 RVA: 0x001E9347 File Offset: 0x001E7547
		public unsafe float MinimumRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MinimumRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_MinimumRoll) = value;
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x06014CAB RID: 85163 RVA: 0x001E9358 File Offset: 0x001E7558
		// (set) Token: 0x06014CAC RID: 85164 RVA: 0x001E939B File Offset: 0x001E759B
		public FRuntimeFloatCurve Lerp_MultipilerCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Lerp_MultipilerCurve) == null)
				{
					result = (this._Lerp_MultipilerCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_Lerp_MultipilerCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_BasicSettings.__PropertyOffset_Lerp_MultipilerCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06014CAD RID: 85165 RVA: 0x001E93BC File Offset: 0x001E75BC
		public FKuroQuadrupedIK_BasicSettings()
		{
		}

		// Token: 0x06014CAE RID: 85166 RVA: 0x001E93C4 File Offset: 0x001E75C4
		public FKuroQuadrupedIK_BasicSettings(bool SpineEnableSolver, bool FeetEnableSolver, bool MovingBaseCompensationEnable, float TraceUpperHeight, float TraceDownwardHeight, bool TraceWaterSurface, bool FeetEnableTracePredict, float FeetTracePredictScale, FRuntimeFloatCurve FeetTraceOriginWeightCurve, float MaximumPitch, float MinimumPitch, float MaximumRoll, float MinimumRoll, FRuntimeFloatCurve Lerp_MultipilerCurve)
		{
			this.SpineEnableSolver = SpineEnableSolver;
			this.FeetEnableSolver = FeetEnableSolver;
			this.MovingBaseCompensationEnable = MovingBaseCompensationEnable;
			this.TraceUpperHeight = TraceUpperHeight;
			this.TraceDownwardHeight = TraceDownwardHeight;
			this.TraceWaterSurface = TraceWaterSurface;
			this.FeetEnableTracePredict = FeetEnableTracePredict;
			this.FeetTracePredictScale = FeetTracePredictScale;
			this.FeetTraceOriginWeightCurve = FeetTraceOriginWeightCurve;
			this.MaximumPitch = MaximumPitch;
			this.MinimumPitch = MinimumPitch;
			this.MaximumRoll = MaximumRoll;
			this.MinimumRoll = MinimumRoll;
			this.Lerp_MultipilerCurve = Lerp_MultipilerCurve;
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x001E9444 File Offset: 0x001E7644
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_BasicSettings.StaticStruct();
		}

		// Token: 0x06014CB0 RID: 85168 RVA: 0x001E9450 File Offset: 0x001E7650
		[NullableContext(2)]
		public FKuroQuadrupedIK_BasicSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014CB1 RID: 85169 RVA: 0x001E945A File Offset: 0x001E765A
		public FKuroQuadrupedIK_BasicSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014CB2 RID: 85170 RVA: 0x001E9465 File Offset: 0x001E7665
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_BasicSettings(Pointer, false, true);
		}

		// Token: 0x06014CB3 RID: 85171 RVA: 0x001E946F File Offset: 0x001E766F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_BasicSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B550 RID: 46416
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_BasicSettings";

		// Token: 0x0400B551 RID: 46417
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B552 RID: 46418
		internal static int __PropertyOffset_SpineEnableSolver;

		// Token: 0x0400B553 RID: 46419
		internal static int __PropertyOffset_FeetEnableSolver;

		// Token: 0x0400B554 RID: 46420
		internal static int __PropertyOffset_MovingBaseCompensationEnable;

		// Token: 0x0400B555 RID: 46421
		internal static int __PropertyOffset_TraceUpperHeight;

		// Token: 0x0400B556 RID: 46422
		internal static int __PropertyOffset_TraceDownwardHeight;

		// Token: 0x0400B557 RID: 46423
		internal static int __PropertyOffset_TraceWaterSurface;

		// Token: 0x0400B558 RID: 46424
		internal static int __PropertyOffset_FeetEnableTracePredict;

		// Token: 0x0400B559 RID: 46425
		internal static int __PropertyOffset_FeetTracePredictScale;

		// Token: 0x0400B55A RID: 46426
		internal static int __PropertyOffset_FeetTraceOriginWeightCurve;

		// Token: 0x0400B55B RID: 46427
		[Nullable(2)]
		private FRuntimeFloatCurve _FeetTraceOriginWeightCurve;

		// Token: 0x0400B55C RID: 46428
		internal static int __PropertyOffset_MaximumPitch;

		// Token: 0x0400B55D RID: 46429
		internal static int __PropertyOffset_MinimumPitch;

		// Token: 0x0400B55E RID: 46430
		internal static int __PropertyOffset_MaximumRoll;

		// Token: 0x0400B55F RID: 46431
		internal static int __PropertyOffset_MinimumRoll;

		// Token: 0x0400B560 RID: 46432
		internal static int __PropertyOffset_Lerp_MultipilerCurve;

		// Token: 0x0400B561 RID: 46433
		[Nullable(2)]
		private FRuntimeFloatCurve _Lerp_MultipilerCurve;
	}
}
