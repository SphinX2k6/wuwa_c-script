using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200084B RID: 2123
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimUpdateRateParameters")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FAnimUpdateRateParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007257 RID: 29271 RVA: 0x000A3A64 File Offset: 0x000A1C64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimUpdateRateParameters._ScriptStructPtr != 0) ? FAnimUpdateRateParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimUpdateRateParameters", ref FAnimUpdateRateParameters._ScriptStructPtr);
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06007258 RID: 29272 RVA: 0x000A3A88 File Offset: 0x000A1C88
		// (set) Token: 0x06007259 RID: 29273 RVA: 0x000A3A98 File Offset: 0x000A1C98
		public unsafe EUpdateRateShiftBucket ShiftBucket
		{
			get
			{
				return (EUpdateRateShiftBucket)(*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_ShiftBucket));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_ShiftBucket) = (byte)value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600725A RID: 29274 RVA: 0x000A3AA9 File Offset: 0x000A1CA9
		// (set) Token: 0x0600725B RID: 29275 RVA: 0x000A3AC2 File Offset: 0x000A1CC2
		public unsafe bool bInterpolateSkippedFrames
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bInterpolateSkippedFrames) & FAnimUpdateRateParameters.__PropertyMask_bInterpolateSkippedFrames) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bInterpolateSkippedFrames) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bInterpolateSkippedFrames) & ~FAnimUpdateRateParameters.__PropertyMask_bInterpolateSkippedFrames) | (value ? FAnimUpdateRateParameters.__PropertyMask_bInterpolateSkippedFrames : 0));
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x000A3AF2 File Offset: 0x000A1CF2
		// (set) Token: 0x0600725D RID: 29277 RVA: 0x000A3B0B File Offset: 0x000A1D0B
		public unsafe bool bShouldUseLodMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseLodMap) & FAnimUpdateRateParameters.__PropertyMask_bShouldUseLodMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseLodMap) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseLodMap) & ~FAnimUpdateRateParameters.__PropertyMask_bShouldUseLodMap) | (value ? FAnimUpdateRateParameters.__PropertyMask_bShouldUseLodMap : 0));
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600725E RID: 29278 RVA: 0x000A3B3B File Offset: 0x000A1D3B
		// (set) Token: 0x0600725F RID: 29279 RVA: 0x000A3B54 File Offset: 0x000A1D54
		public unsafe bool bShouldUseDistanceMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseDistanceMap) & FAnimUpdateRateParameters.__PropertyMask_bShouldUseDistanceMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseDistanceMap) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseDistanceMap) & ~FAnimUpdateRateParameters.__PropertyMask_bShouldUseDistanceMap) | (value ? FAnimUpdateRateParameters.__PropertyMask_bShouldUseDistanceMap : 0));
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x000A3B84 File Offset: 0x000A1D84
		// (set) Token: 0x06007261 RID: 29281 RVA: 0x000A3B9D File Offset: 0x000A1D9D
		public unsafe bool bShouldUseMinLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseMinLod) & FAnimUpdateRateParameters.__PropertyMask_bShouldUseMinLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseMinLod) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bShouldUseMinLod) & ~FAnimUpdateRateParameters.__PropertyMask_bShouldUseMinLod) | (value ? FAnimUpdateRateParameters.__PropertyMask_bShouldUseMinLod : 0));
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x000A3BCD File Offset: 0x000A1DCD
		// (set) Token: 0x06007263 RID: 29283 RVA: 0x000A3BE6 File Offset: 0x000A1DE6
		public unsafe bool bSkipUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipUpdate) & FAnimUpdateRateParameters.__PropertyMask_bSkipUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipUpdate) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipUpdate) & ~FAnimUpdateRateParameters.__PropertyMask_bSkipUpdate) | (value ? FAnimUpdateRateParameters.__PropertyMask_bSkipUpdate : 0));
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06007264 RID: 29284 RVA: 0x000A3C16 File Offset: 0x000A1E16
		// (set) Token: 0x06007265 RID: 29285 RVA: 0x000A3C2F File Offset: 0x000A1E2F
		public unsafe bool bSkipEvaluation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipEvaluation) & FAnimUpdateRateParameters.__PropertyMask_bSkipEvaluation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipEvaluation) = ((*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_bSkipEvaluation) & ~FAnimUpdateRateParameters.__PropertyMask_bSkipEvaluation) | (value ? FAnimUpdateRateParameters.__PropertyMask_bSkipEvaluation : 0));
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06007266 RID: 29286 RVA: 0x000A3C5F File Offset: 0x000A1E5F
		// (set) Token: 0x06007267 RID: 29287 RVA: 0x000A3C6F File Offset: 0x000A1E6F
		public unsafe int UpdateRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_UpdateRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_UpdateRate) = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06007268 RID: 29288 RVA: 0x000A3C80 File Offset: 0x000A1E80
		// (set) Token: 0x06007269 RID: 29289 RVA: 0x000A3C90 File Offset: 0x000A1E90
		public unsafe int EvaluationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_EvaluationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_EvaluationRate) = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600726A RID: 29290 RVA: 0x000A3CA1 File Offset: 0x000A1EA1
		// (set) Token: 0x0600726B RID: 29291 RVA: 0x000A3CB1 File Offset: 0x000A1EB1
		public unsafe float TickedPoseOffestTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_TickedPoseOffestTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_TickedPoseOffestTime) = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600726C RID: 29292 RVA: 0x000A3CC2 File Offset: 0x000A1EC2
		// (set) Token: 0x0600726D RID: 29293 RVA: 0x000A3CD2 File Offset: 0x000A1ED2
		public unsafe float AdditionalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_AdditionalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_AdditionalTime) = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x000A3CE3 File Offset: 0x000A1EE3
		// (set) Token: 0x0600726F RID: 29295 RVA: 0x000A3CF3 File Offset: 0x000A1EF3
		public unsafe int BaseNonRenderedUpdateRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_BaseNonRenderedUpdateRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_BaseNonRenderedUpdateRate) = value;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x000A3D04 File Offset: 0x000A1F04
		// (set) Token: 0x06007271 RID: 29297 RVA: 0x000A3D14 File Offset: 0x000A1F14
		public unsafe int MaxEvalRateForInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_MaxEvalRateForInterpolation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_MaxEvalRateForInterpolation) = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x000A3D28 File Offset: 0x000A1F28
		// (set) Token: 0x06007273 RID: 29299 RVA: 0x000A3D6B File Offset: 0x000A1F6B
		public TArray<float> BaseVisibleDistanceFactorThesholds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BaseVisibleDistanceFactorThesholds) == null)
				{
					result = (this._BaseVisibleDistanceFactorThesholds = new TArray<float>(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_BaseVisibleDistanceFactorThesholds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BaseVisibleDistanceFactorThesholds.CopyAssign(value);
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x000A3D7C File Offset: 0x000A1F7C
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x000A3DBF File Offset: 0x000A1FBF
		public TMap<int, int> LODToFrameSkipMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._LODToFrameSkipMap) == null)
				{
					result = (this._LODToFrameSkipMap = new TMap<int, int>(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_LODToFrameSkipMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LODToFrameSkipMap.CopyAssign(value);
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06007276 RID: 29302 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		// (set) Token: 0x06007277 RID: 29303 RVA: 0x000A3E13 File Offset: 0x000A2013
		public TArray<float> BaseVisibleDistanceThresholds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BaseVisibleDistanceThresholds) == null)
				{
					result = (this._BaseVisibleDistanceThresholds = new TArray<float>(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_BaseVisibleDistanceThresholds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BaseVisibleDistanceThresholds.CopyAssign(value);
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06007278 RID: 29304 RVA: 0x000A3E24 File Offset: 0x000A2024
		// (set) Token: 0x06007279 RID: 29305 RVA: 0x000A3E67 File Offset: 0x000A2067
		public TArray<float> BaseVisibleScreenRatioThresholds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BaseVisibleScreenRatioThresholds) == null)
				{
					result = (this._BaseVisibleScreenRatioThresholds = new TArray<float>(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_BaseVisibleScreenRatioThresholds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BaseVisibleScreenRatioThresholds.CopyAssign(value);
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x000A3E75 File Offset: 0x000A2075
		// (set) Token: 0x0600727B RID: 29307 RVA: 0x000A3E85 File Offset: 0x000A2085
		public unsafe int SkippedUpdateFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_SkippedUpdateFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_SkippedUpdateFrames) = value;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600727C RID: 29308 RVA: 0x000A3E96 File Offset: 0x000A2096
		// (set) Token: 0x0600727D RID: 29309 RVA: 0x000A3EA6 File Offset: 0x000A20A6
		public unsafe int SkippedEvalFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_SkippedEvalFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimUpdateRateParameters.__PropertyOffset_SkippedEvalFrames) = value;
			}
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x000A3EB7 File Offset: 0x000A20B7
		public FAnimUpdateRateParameters()
		{
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x000A3EC0 File Offset: 0x000A20C0
		public FAnimUpdateRateParameters(EUpdateRateShiftBucket ShiftBucket, bool bInterpolateSkippedFrames, bool bShouldUseLodMap, bool bShouldUseDistanceMap, bool bShouldUseMinLod, bool bSkipUpdate, bool bSkipEvaluation, int UpdateRate, int EvaluationRate, float TickedPoseOffestTime, float AdditionalTime, int BaseNonRenderedUpdateRate, int MaxEvalRateForInterpolation, TArray<float> BaseVisibleDistanceFactorThesholds, TMap<int, int> LODToFrameSkipMap, TArray<float> BaseVisibleDistanceThresholds, TArray<float> BaseVisibleScreenRatioThresholds, int SkippedUpdateFrames, int SkippedEvalFrames)
		{
			this.ShiftBucket = ShiftBucket;
			this.bInterpolateSkippedFrames = bInterpolateSkippedFrames;
			this.bShouldUseLodMap = bShouldUseLodMap;
			this.bShouldUseDistanceMap = bShouldUseDistanceMap;
			this.bShouldUseMinLod = bShouldUseMinLod;
			this.bSkipUpdate = bSkipUpdate;
			this.bSkipEvaluation = bSkipEvaluation;
			this.UpdateRate = UpdateRate;
			this.EvaluationRate = EvaluationRate;
			this.TickedPoseOffestTime = TickedPoseOffestTime;
			this.AdditionalTime = AdditionalTime;
			this.BaseNonRenderedUpdateRate = BaseNonRenderedUpdateRate;
			this.MaxEvalRateForInterpolation = MaxEvalRateForInterpolation;
			this.BaseVisibleDistanceFactorThesholds = BaseVisibleDistanceFactorThesholds;
			this.LODToFrameSkipMap = LODToFrameSkipMap;
			this.BaseVisibleDistanceThresholds = BaseVisibleDistanceThresholds;
			this.BaseVisibleScreenRatioThresholds = BaseVisibleScreenRatioThresholds;
			this.SkippedUpdateFrames = SkippedUpdateFrames;
			this.SkippedEvalFrames = SkippedEvalFrames;
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x000A3F68 File Offset: 0x000A2168
		protected override IntPtr GetUStructPtr()
		{
			return FAnimUpdateRateParameters.StaticStruct();
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x000A3F74 File Offset: 0x000A2174
		[NullableContext(2)]
		public FAnimUpdateRateParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x000A3F7E File Offset: 0x000A217E
		public FAnimUpdateRateParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x000A3F89 File Offset: 0x000A2189
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimUpdateRateParameters(Pointer, false, true);
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x000A3F93 File Offset: 0x000A2193
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimUpdateRateParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040036E2 RID: 14050
		public const string __ObjectPath = "/Script/Engine.AnimUpdateRateParameters";

		// Token: 0x040036E3 RID: 14051
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036E4 RID: 14052
		internal static int __PropertyOffset_ShiftBucket;

		// Token: 0x040036E5 RID: 14053
		internal static int __PropertyOffset_bInterpolateSkippedFrames;

		// Token: 0x040036E6 RID: 14054
		internal static byte __PropertyMask_bInterpolateSkippedFrames;

		// Token: 0x040036E7 RID: 14055
		internal static int __PropertyOffset_bShouldUseLodMap;

		// Token: 0x040036E8 RID: 14056
		internal static byte __PropertyMask_bShouldUseLodMap;

		// Token: 0x040036E9 RID: 14057
		internal static int __PropertyOffset_bShouldUseDistanceMap;

		// Token: 0x040036EA RID: 14058
		internal static byte __PropertyMask_bShouldUseDistanceMap;

		// Token: 0x040036EB RID: 14059
		internal static int __PropertyOffset_bShouldUseMinLod;

		// Token: 0x040036EC RID: 14060
		internal static byte __PropertyMask_bShouldUseMinLod;

		// Token: 0x040036ED RID: 14061
		internal static int __PropertyOffset_bSkipUpdate;

		// Token: 0x040036EE RID: 14062
		internal static byte __PropertyMask_bSkipUpdate;

		// Token: 0x040036EF RID: 14063
		internal static int __PropertyOffset_bSkipEvaluation;

		// Token: 0x040036F0 RID: 14064
		internal static byte __PropertyMask_bSkipEvaluation;

		// Token: 0x040036F1 RID: 14065
		internal static int __PropertyOffset_UpdateRate;

		// Token: 0x040036F2 RID: 14066
		internal static int __PropertyOffset_EvaluationRate;

		// Token: 0x040036F3 RID: 14067
		internal static int __PropertyOffset_TickedPoseOffestTime;

		// Token: 0x040036F4 RID: 14068
		internal static int __PropertyOffset_AdditionalTime;

		// Token: 0x040036F5 RID: 14069
		internal static int __PropertyOffset_BaseNonRenderedUpdateRate;

		// Token: 0x040036F6 RID: 14070
		internal static int __PropertyOffset_MaxEvalRateForInterpolation;

		// Token: 0x040036F7 RID: 14071
		internal static int __PropertyOffset_BaseVisibleDistanceFactorThesholds;

		// Token: 0x040036F8 RID: 14072
		[Nullable(2)]
		private TArray<float> _BaseVisibleDistanceFactorThesholds;

		// Token: 0x040036F9 RID: 14073
		internal static int __PropertyOffset_LODToFrameSkipMap;

		// Token: 0x040036FA RID: 14074
		[Nullable(2)]
		private TMap<int, int> _LODToFrameSkipMap;

		// Token: 0x040036FB RID: 14075
		internal static int __PropertyOffset_BaseVisibleDistanceThresholds;

		// Token: 0x040036FC RID: 14076
		[Nullable(2)]
		private TArray<float> _BaseVisibleDistanceThresholds;

		// Token: 0x040036FD RID: 14077
		internal static int __PropertyOffset_BaseVisibleScreenRatioThresholds;

		// Token: 0x040036FE RID: 14078
		[Nullable(2)]
		private TArray<float> _BaseVisibleScreenRatioThresholds;

		// Token: 0x040036FF RID: 14079
		internal static int __PropertyOffset_SkippedUpdateFrames;

		// Token: 0x04003700 RID: 14080
		internal static int __PropertyOffset_SkippedEvalFrames;
	}
}
