using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001670 RID: 5744
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_SpineSettings")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FKuroQuadrupedIK_SpineSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014D21 RID: 85281 RVA: 0x001E9DA1 File Offset: 0x001E7FA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_SpineSettings._ScriptStructPtr != 0) ? FKuroQuadrupedIK_SpineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_SpineSettings", ref FKuroQuadrupedIK_SpineSettings._ScriptStructPtr);
		}

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x06014D22 RID: 85282 RVA: 0x001E9DC5 File Offset: 0x001E7FC5
		// (set) Token: 0x06014D23 RID: 85283 RVA: 0x001E9DD5 File Offset: 0x001E7FD5
		public unsafe float SpineTraceInvterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceInvterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceInvterval) = value;
			}
		}

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x06014D24 RID: 85284 RVA: 0x001E9DE6 File Offset: 0x001E7FE6
		// (set) Token: 0x06014D25 RID: 85285 RVA: 0x001E9DF6 File Offset: 0x001E7FF6
		public unsafe EKuroQuadrupedIK_TraceType SpineTraceType
		{
			get
			{
				return (EKuroQuadrupedIK_TraceType)(*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceType) = (byte)value;
			}
		}

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x06014D26 RID: 85286 RVA: 0x001E9E07 File Offset: 0x001E8007
		// (set) Token: 0x06014D27 RID: 85287 RVA: 0x001E9E17 File Offset: 0x001E8017
		public unsafe float SpineSphereTraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineSphereTraceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineSphereTraceRadius) = value;
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x06014D28 RID: 85288 RVA: 0x001E9E28 File Offset: 0x001E8028
		// (set) Token: 0x06014D29 RID: 85289 RVA: 0x001E9E38 File Offset: 0x001E8038
		public unsafe bool SpineTraceComplex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceComplex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceComplex) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x06014D2A RID: 85290 RVA: 0x001E9E4C File Offset: 0x001E804C
		// (set) Token: 0x06014D2B RID: 85291 RVA: 0x001E9E8F File Offset: 0x001E808F
		public FRuntimeFloatCurve SpineTraceComplexCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._SpineTraceComplexCurve) == null)
				{
					result = (this._SpineTraceComplexCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceComplexCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceComplexCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x06014D2C RID: 85292 RVA: 0x001E9EB0 File Offset: 0x001E80B0
		// (set) Token: 0x06014D2D RID: 85293 RVA: 0x001E9EC0 File Offset: 0x001E80C0
		public unsafe bool SpineTraceAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x06014D2E RID: 85294 RVA: 0x001E9ED1 File Offset: 0x001E80D1
		// (set) Token: 0x06014D2F RID: 85295 RVA: 0x001E9EE1 File Offset: 0x001E80E1
		public unsafe float SpineLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineLerpSpeed) = value;
			}
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x06014D30 RID: 85296 RVA: 0x001E9EF2 File Offset: 0x001E80F2
		// (set) Token: 0x06014D31 RID: 85297 RVA: 0x001E9F02 File Offset: 0x001E8102
		public unsafe float SpineTraceLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineTraceLerpSpeed) = value;
			}
		}

		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x06014D32 RID: 85298 RVA: 0x001E9F14 File Offset: 0x001E8114
		// (set) Token: 0x06014D33 RID: 85299 RVA: 0x001E9F57 File Offset: 0x001E8157
		public FRuntimeFloatCurve AccurateSpineToFeetCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._AccurateSpineToFeetCurve) == null)
				{
					result = (this._AccurateSpineToFeetCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_AccurateSpineToFeetCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_AccurateSpineToFeetCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x06014D34 RID: 85300 RVA: 0x001E9F78 File Offset: 0x001E8178
		// (set) Token: 0x06014D35 RID: 85301 RVA: 0x001E9F88 File Offset: 0x001E8188
		public unsafe float SpineLocationLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineLocationLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineLocationLerpSpeed) = value;
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x06014D36 RID: 85302 RVA: 0x001E9F99 File Offset: 0x001E8199
		// (set) Token: 0x06014D37 RID: 85303 RVA: 0x001E9FA9 File Offset: 0x001E81A9
		public unsafe float SpineRotationLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineRotationLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_SpineRotationLerpSpeed) = value;
			}
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x06014D38 RID: 85304 RVA: 0x001E9FBA File Offset: 0x001E81BA
		// (set) Token: 0x06014D39 RID: 85305 RVA: 0x001E9FCA File Offset: 0x001E81CA
		public unsafe float Spine_FABRIK_Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_Precision) = value;
			}
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x06014D3A RID: 85306 RVA: 0x001E9FDB File Offset: 0x001E81DB
		// (set) Token: 0x06014D3B RID: 85307 RVA: 0x001E9FEB File Offset: 0x001E81EB
		public unsafe int Spine_FABRIK_MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MaxIterations) = value;
			}
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x06014D3C RID: 85308 RVA: 0x001E9FFC File Offset: 0x001E81FC
		// (set) Token: 0x06014D3D RID: 85309 RVA: 0x001EA00C File Offset: 0x001E820C
		public unsafe float Spine_FABRIK_MinStretchRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MinStretchRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MinStretchRatio) = value;
			}
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x06014D3E RID: 85310 RVA: 0x001EA01D File Offset: 0x001E821D
		// (set) Token: 0x06014D3F RID: 85311 RVA: 0x001EA02D File Offset: 0x001E822D
		public unsafe float Spine_FABRIK_MaxStretchRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MaxStretchRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_Spine_FABRIK_MaxStretchRatio) = value;
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x06014D40 RID: 85312 RVA: 0x001EA03E File Offset: 0x001E823E
		// (set) Token: 0x06014D41 RID: 85313 RVA: 0x001EA04E File Offset: 0x001E824E
		public unsafe float HeadStabilizationAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_HeadStabilizationAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_HeadStabilizationAlpha) = value;
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x06014D42 RID: 85314 RVA: 0x001EA05F File Offset: 0x001E825F
		// (set) Token: 0x06014D43 RID: 85315 RVA: 0x001EA06F File Offset: 0x001E826F
		public unsafe float TailStabilizationAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_TailStabilizationAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_TailStabilizationAlpha) = value;
			}
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x06014D44 RID: 85316 RVA: 0x001EA080 File Offset: 0x001E8280
		// (set) Token: 0x06014D45 RID: 85317 RVA: 0x001EA090 File Offset: 0x001E8290
		public unsafe float ThighStabilizationAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ThighStabilizationAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ThighStabilizationAlpha) = value;
			}
		}

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x06014D46 RID: 85318 RVA: 0x001EA0A1 File Offset: 0x001E82A1
		// (set) Token: 0x06014D47 RID: 85319 RVA: 0x001EA0B1 File Offset: 0x001E82B1
		public unsafe float PelvisDipHeightAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisDipHeightAdaptive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisDipHeightAdaptive) = value;
			}
		}

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x06014D48 RID: 85320 RVA: 0x001EA0C2 File Offset: 0x001E82C2
		// (set) Token: 0x06014D49 RID: 85321 RVA: 0x001EA0D2 File Offset: 0x001E82D2
		public unsafe float PelvisMaxDipHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisMaxDipHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisMaxDipHeight) = value;
			}
		}

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x06014D4A RID: 85322 RVA: 0x001EA0E4 File Offset: 0x001E82E4
		// (set) Token: 0x06014D4B RID: 85323 RVA: 0x001EA127 File Offset: 0x001E8327
		public FRuntimeFloatCurve PelvisDipHeight_MultiplierCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._PelvisDipHeight_MultiplierCurve) == null)
				{
					result = (this._PelvisDipHeight_MultiplierCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisDipHeight_MultiplierCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisDipHeight_MultiplierCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x06014D4C RID: 85324 RVA: 0x001EA148 File Offset: 0x001E8348
		// (set) Token: 0x06014D4D RID: 85325 RVA: 0x001EA158 File Offset: 0x001E8358
		public unsafe float PelvisExtraDipHeight_UpSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisExtraDipHeight_UpSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisExtraDipHeight_UpSlope) = value;
			}
		}

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x06014D4E RID: 85326 RVA: 0x001EA169 File Offset: 0x001E8369
		// (set) Token: 0x06014D4F RID: 85327 RVA: 0x001EA179 File Offset: 0x001E8379
		public unsafe float PelvisExtraDipHeight_DownSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisExtraDipHeight_DownSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisExtraDipHeight_DownSlope) = value;
			}
		}

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x06014D50 RID: 85328 RVA: 0x001EA18A File Offset: 0x001E838A
		// (set) Token: 0x06014D51 RID: 85329 RVA: 0x001EA19A File Offset: 0x001E839A
		public unsafe float PelvisTwoFeetDiffDipMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisTwoFeetDiffDipMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisTwoFeetDiffDipMultiplier) = value;
			}
		}

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x06014D52 RID: 85330 RVA: 0x001EA1AB File Offset: 0x001E83AB
		// (set) Token: 0x06014D53 RID: 85331 RVA: 0x001EA1BB File Offset: 0x001E83BB
		public unsafe float PelvisAnimatedToSolved_Z_Lerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisAnimatedToSolved_Z_Lerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisAnimatedToSolved_Z_Lerp) = value;
			}
		}

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x06014D54 RID: 85332 RVA: 0x001EA1CC File Offset: 0x001E83CC
		// (set) Token: 0x06014D55 RID: 85333 RVA: 0x001EA1DC File Offset: 0x001E83DC
		public unsafe float PelvisRotationIntensity_Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisRotationIntensity_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisRotationIntensity_Pitch) = value;
			}
		}

		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x06014D56 RID: 85334 RVA: 0x001EA1ED File Offset: 0x001E83ED
		// (set) Token: 0x06014D57 RID: 85335 RVA: 0x001EA1FD File Offset: 0x001E83FD
		public unsafe float PelvisRotationIntensity_Roll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisRotationIntensity_Roll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_PelvisRotationIntensity_Roll) = value;
			}
		}

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x06014D58 RID: 85336 RVA: 0x001EA20E File Offset: 0x001E840E
		// (set) Token: 0x06014D59 RID: 85337 RVA: 0x001EA21E File Offset: 0x001E841E
		public unsafe float ChestDipHeightAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestDipHeightAdaptive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestDipHeightAdaptive) = value;
			}
		}

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x06014D5A RID: 85338 RVA: 0x001EA22F File Offset: 0x001E842F
		// (set) Token: 0x06014D5B RID: 85339 RVA: 0x001EA23F File Offset: 0x001E843F
		public unsafe float ChestMaxDipHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestMaxDipHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestMaxDipHeight) = value;
			}
		}

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x06014D5C RID: 85340 RVA: 0x001EA250 File Offset: 0x001E8450
		// (set) Token: 0x06014D5D RID: 85341 RVA: 0x001EA293 File Offset: 0x001E8493
		public FRuntimeFloatCurve ChestDipHeight_MultiplierCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._ChestDipHeight_MultiplierCurve) == null)
				{
					result = (this._ChestDipHeight_MultiplierCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestDipHeight_MultiplierCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestDipHeight_MultiplierCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x06014D5E RID: 85342 RVA: 0x001EA2B4 File Offset: 0x001E84B4
		// (set) Token: 0x06014D5F RID: 85343 RVA: 0x001EA2C4 File Offset: 0x001E84C4
		public unsafe float ChestExtraDipHeight_UpSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestExtraDipHeight_UpSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestExtraDipHeight_UpSlope) = value;
			}
		}

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x06014D60 RID: 85344 RVA: 0x001EA2D5 File Offset: 0x001E84D5
		// (set) Token: 0x06014D61 RID: 85345 RVA: 0x001EA2E5 File Offset: 0x001E84E5
		public unsafe float ChestExtraDipHeight_DownSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestExtraDipHeight_DownSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestExtraDipHeight_DownSlope) = value;
			}
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x06014D62 RID: 85346 RVA: 0x001EA2F6 File Offset: 0x001E84F6
		// (set) Token: 0x06014D63 RID: 85347 RVA: 0x001EA306 File Offset: 0x001E8506
		public unsafe float ChestInfluenceByPelvisAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestInfluenceByPelvisAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestInfluenceByPelvisAlpha) = value;
			}
		}

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x06014D64 RID: 85348 RVA: 0x001EA317 File Offset: 0x001E8517
		// (set) Token: 0x06014D65 RID: 85349 RVA: 0x001EA327 File Offset: 0x001E8527
		public unsafe float ChestTwoFeetDiffDipMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestTwoFeetDiffDipMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestTwoFeetDiffDipMultiplier) = value;
			}
		}

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x06014D66 RID: 85350 RVA: 0x001EA338 File Offset: 0x001E8538
		// (set) Token: 0x06014D67 RID: 85351 RVA: 0x001EA348 File Offset: 0x001E8548
		public unsafe float ChestAnimatedToSolved_Z_Lerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestAnimatedToSolved_Z_Lerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestAnimatedToSolved_Z_Lerp) = value;
			}
		}

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x06014D68 RID: 85352 RVA: 0x001EA359 File Offset: 0x001E8559
		// (set) Token: 0x06014D69 RID: 85353 RVA: 0x001EA369 File Offset: 0x001E8569
		public unsafe float ChestRotationIntensity_Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestRotationIntensity_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestRotationIntensity_Pitch) = value;
			}
		}

		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x06014D6A RID: 85354 RVA: 0x001EA37A File Offset: 0x001E857A
		// (set) Token: 0x06014D6B RID: 85355 RVA: 0x001EA38A File Offset: 0x001E858A
		public unsafe float ChestRotationIntensity_Roll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestRotationIntensity_Roll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_SpineSettings.__PropertyOffset_ChestRotationIntensity_Roll) = value;
			}
		}

		// Token: 0x06014D6C RID: 85356 RVA: 0x001EA39B File Offset: 0x001E859B
		public FKuroQuadrupedIK_SpineSettings()
		{
		}

		// Token: 0x06014D6D RID: 85357 RVA: 0x001EA3A4 File Offset: 0x001E85A4
		public FKuroQuadrupedIK_SpineSettings(float SpineTraceInvterval, EKuroQuadrupedIK_TraceType SpineTraceType, float SpineSphereTraceRadius, bool SpineTraceComplex, FRuntimeFloatCurve SpineTraceComplexCurve, bool SpineTraceAsync, float SpineLerpSpeed, float SpineTraceLerpSpeed, FRuntimeFloatCurve AccurateSpineToFeetCurve, float SpineLocationLerpSpeed, float SpineRotationLerpSpeed, float Spine_FABRIK_Precision, int Spine_FABRIK_MaxIterations, float Spine_FABRIK_MinStretchRatio, float Spine_FABRIK_MaxStretchRatio, float HeadStabilizationAlpha, float TailStabilizationAlpha, float ThighStabilizationAlpha, float PelvisDipHeightAdaptive, float PelvisMaxDipHeight, FRuntimeFloatCurve PelvisDipHeight_MultiplierCurve, float PelvisExtraDipHeight_UpSlope, float PelvisExtraDipHeight_DownSlope, float PelvisTwoFeetDiffDipMultiplier, float PelvisAnimatedToSolved_Z_Lerp, float PelvisRotationIntensity_Pitch, float PelvisRotationIntensity_Roll, float ChestDipHeightAdaptive, float ChestMaxDipHeight, FRuntimeFloatCurve ChestDipHeight_MultiplierCurve, float ChestExtraDipHeight_UpSlope, float ChestExtraDipHeight_DownSlope, float ChestInfluenceByPelvisAlpha, float ChestTwoFeetDiffDipMultiplier, float ChestAnimatedToSolved_Z_Lerp, float ChestRotationIntensity_Pitch, float ChestRotationIntensity_Roll)
		{
			this.SpineTraceInvterval = SpineTraceInvterval;
			this.SpineTraceType = SpineTraceType;
			this.SpineSphereTraceRadius = SpineSphereTraceRadius;
			this.SpineTraceComplex = SpineTraceComplex;
			this.SpineTraceComplexCurve = SpineTraceComplexCurve;
			this.SpineTraceAsync = SpineTraceAsync;
			this.SpineLerpSpeed = SpineLerpSpeed;
			this.SpineTraceLerpSpeed = SpineTraceLerpSpeed;
			this.AccurateSpineToFeetCurve = AccurateSpineToFeetCurve;
			this.SpineLocationLerpSpeed = SpineLocationLerpSpeed;
			this.SpineRotationLerpSpeed = SpineRotationLerpSpeed;
			this.Spine_FABRIK_Precision = Spine_FABRIK_Precision;
			this.Spine_FABRIK_MaxIterations = Spine_FABRIK_MaxIterations;
			this.Spine_FABRIK_MinStretchRatio = Spine_FABRIK_MinStretchRatio;
			this.Spine_FABRIK_MaxStretchRatio = Spine_FABRIK_MaxStretchRatio;
			this.HeadStabilizationAlpha = HeadStabilizationAlpha;
			this.TailStabilizationAlpha = TailStabilizationAlpha;
			this.ThighStabilizationAlpha = ThighStabilizationAlpha;
			this.PelvisDipHeightAdaptive = PelvisDipHeightAdaptive;
			this.PelvisMaxDipHeight = PelvisMaxDipHeight;
			this.PelvisDipHeight_MultiplierCurve = PelvisDipHeight_MultiplierCurve;
			this.PelvisExtraDipHeight_UpSlope = PelvisExtraDipHeight_UpSlope;
			this.PelvisExtraDipHeight_DownSlope = PelvisExtraDipHeight_DownSlope;
			this.PelvisTwoFeetDiffDipMultiplier = PelvisTwoFeetDiffDipMultiplier;
			this.PelvisAnimatedToSolved_Z_Lerp = PelvisAnimatedToSolved_Z_Lerp;
			this.PelvisRotationIntensity_Pitch = PelvisRotationIntensity_Pitch;
			this.PelvisRotationIntensity_Roll = PelvisRotationIntensity_Roll;
			this.ChestDipHeightAdaptive = ChestDipHeightAdaptive;
			this.ChestMaxDipHeight = ChestMaxDipHeight;
			this.ChestDipHeight_MultiplierCurve = ChestDipHeight_MultiplierCurve;
			this.ChestExtraDipHeight_UpSlope = ChestExtraDipHeight_UpSlope;
			this.ChestExtraDipHeight_DownSlope = ChestExtraDipHeight_DownSlope;
			this.ChestInfluenceByPelvisAlpha = ChestInfluenceByPelvisAlpha;
			this.ChestTwoFeetDiffDipMultiplier = ChestTwoFeetDiffDipMultiplier;
			this.ChestAnimatedToSolved_Z_Lerp = ChestAnimatedToSolved_Z_Lerp;
			this.ChestRotationIntensity_Pitch = ChestRotationIntensity_Pitch;
			this.ChestRotationIntensity_Roll = ChestRotationIntensity_Roll;
		}

		// Token: 0x06014D6E RID: 85358 RVA: 0x001EA4DC File Offset: 0x001E86DC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_SpineSettings.StaticStruct();
		}

		// Token: 0x06014D6F RID: 85359 RVA: 0x001EA4E8 File Offset: 0x001E86E8
		[NullableContext(2)]
		public FKuroQuadrupedIK_SpineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014D70 RID: 85360 RVA: 0x001EA4F2 File Offset: 0x001E86F2
		public FKuroQuadrupedIK_SpineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014D71 RID: 85361 RVA: 0x001EA4FD File Offset: 0x001E86FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_SpineSettings(Pointer, false, true);
		}

		// Token: 0x06014D72 RID: 85362 RVA: 0x001EA507 File Offset: 0x001E8707
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_SpineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B596 RID: 46486
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_SpineSettings";

		// Token: 0x0400B597 RID: 46487
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B598 RID: 46488
		internal static int __PropertyOffset_SpineTraceInvterval;

		// Token: 0x0400B599 RID: 46489
		internal static int __PropertyOffset_SpineTraceType;

		// Token: 0x0400B59A RID: 46490
		internal static int __PropertyOffset_SpineSphereTraceRadius;

		// Token: 0x0400B59B RID: 46491
		internal static int __PropertyOffset_SpineTraceComplex;

		// Token: 0x0400B59C RID: 46492
		internal static int __PropertyOffset_SpineTraceComplexCurve;

		// Token: 0x0400B59D RID: 46493
		[Nullable(2)]
		private FRuntimeFloatCurve _SpineTraceComplexCurve;

		// Token: 0x0400B59E RID: 46494
		internal static int __PropertyOffset_SpineTraceAsync;

		// Token: 0x0400B59F RID: 46495
		internal static int __PropertyOffset_SpineLerpSpeed;

		// Token: 0x0400B5A0 RID: 46496
		internal static int __PropertyOffset_SpineTraceLerpSpeed;

		// Token: 0x0400B5A1 RID: 46497
		internal static int __PropertyOffset_AccurateSpineToFeetCurve;

		// Token: 0x0400B5A2 RID: 46498
		[Nullable(2)]
		private FRuntimeFloatCurve _AccurateSpineToFeetCurve;

		// Token: 0x0400B5A3 RID: 46499
		internal static int __PropertyOffset_SpineLocationLerpSpeed;

		// Token: 0x0400B5A4 RID: 46500
		internal static int __PropertyOffset_SpineRotationLerpSpeed;

		// Token: 0x0400B5A5 RID: 46501
		internal static int __PropertyOffset_Spine_FABRIK_Precision;

		// Token: 0x0400B5A6 RID: 46502
		internal static int __PropertyOffset_Spine_FABRIK_MaxIterations;

		// Token: 0x0400B5A7 RID: 46503
		internal static int __PropertyOffset_Spine_FABRIK_MinStretchRatio;

		// Token: 0x0400B5A8 RID: 46504
		internal static int __PropertyOffset_Spine_FABRIK_MaxStretchRatio;

		// Token: 0x0400B5A9 RID: 46505
		internal static int __PropertyOffset_HeadStabilizationAlpha;

		// Token: 0x0400B5AA RID: 46506
		internal static int __PropertyOffset_TailStabilizationAlpha;

		// Token: 0x0400B5AB RID: 46507
		internal static int __PropertyOffset_ThighStabilizationAlpha;

		// Token: 0x0400B5AC RID: 46508
		internal static int __PropertyOffset_PelvisDipHeightAdaptive;

		// Token: 0x0400B5AD RID: 46509
		internal static int __PropertyOffset_PelvisMaxDipHeight;

		// Token: 0x0400B5AE RID: 46510
		internal static int __PropertyOffset_PelvisDipHeight_MultiplierCurve;

		// Token: 0x0400B5AF RID: 46511
		[Nullable(2)]
		private FRuntimeFloatCurve _PelvisDipHeight_MultiplierCurve;

		// Token: 0x0400B5B0 RID: 46512
		internal static int __PropertyOffset_PelvisExtraDipHeight_UpSlope;

		// Token: 0x0400B5B1 RID: 46513
		internal static int __PropertyOffset_PelvisExtraDipHeight_DownSlope;

		// Token: 0x0400B5B2 RID: 46514
		internal static int __PropertyOffset_PelvisTwoFeetDiffDipMultiplier;

		// Token: 0x0400B5B3 RID: 46515
		internal static int __PropertyOffset_PelvisAnimatedToSolved_Z_Lerp;

		// Token: 0x0400B5B4 RID: 46516
		internal static int __PropertyOffset_PelvisRotationIntensity_Pitch;

		// Token: 0x0400B5B5 RID: 46517
		internal static int __PropertyOffset_PelvisRotationIntensity_Roll;

		// Token: 0x0400B5B6 RID: 46518
		internal static int __PropertyOffset_ChestDipHeightAdaptive;

		// Token: 0x0400B5B7 RID: 46519
		internal static int __PropertyOffset_ChestMaxDipHeight;

		// Token: 0x0400B5B8 RID: 46520
		internal static int __PropertyOffset_ChestDipHeight_MultiplierCurve;

		// Token: 0x0400B5B9 RID: 46521
		[Nullable(2)]
		private FRuntimeFloatCurve _ChestDipHeight_MultiplierCurve;

		// Token: 0x0400B5BA RID: 46522
		internal static int __PropertyOffset_ChestExtraDipHeight_UpSlope;

		// Token: 0x0400B5BB RID: 46523
		internal static int __PropertyOffset_ChestExtraDipHeight_DownSlope;

		// Token: 0x0400B5BC RID: 46524
		internal static int __PropertyOffset_ChestInfluenceByPelvisAlpha;

		// Token: 0x0400B5BD RID: 46525
		internal static int __PropertyOffset_ChestTwoFeetDiffDipMultiplier;

		// Token: 0x0400B5BE RID: 46526
		internal static int __PropertyOffset_ChestAnimatedToSolved_Z_Lerp;

		// Token: 0x0400B5BF RID: 46527
		internal static int __PropertyOffset_ChestRotationIntensity_Pitch;

		// Token: 0x0400B5C0 RID: 46528
		internal static int __PropertyOffset_ChestRotationIntensity_Roll;
	}
}
