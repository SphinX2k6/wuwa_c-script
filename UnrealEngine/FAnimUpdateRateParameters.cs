using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000184 RID: 388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimUpdateRateParameters")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FAnimUpdateRateParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x00025B5D File Offset: 0x00023D5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimUpdateRateParameters._ScriptStructPtr != 0) ? FAnimUpdateRateParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimUpdateRateParameters", ref FAnimUpdateRateParameters._ScriptStructPtr);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00025B81 File Offset: 0x00023D81
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x00025B9A File Offset: 0x00023D9A
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00025BCA File Offset: 0x00023DCA
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x00025BE3 File Offset: 0x00023DE3
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00025C13 File Offset: 0x00023E13
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x00025C2C File Offset: 0x00023E2C
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00025C5C File Offset: 0x00023E5C
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00025C75 File Offset: 0x00023E75
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00025CA5 File Offset: 0x00023EA5
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00025CBE File Offset: 0x00023EBE
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00025CEE File Offset: 0x00023EEE
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00025D07 File Offset: 0x00023F07
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00025D37 File Offset: 0x00023F37
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00025D47 File Offset: 0x00023F47
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00025D58 File Offset: 0x00023F58
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00025D68 File Offset: 0x00023F68
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00025D79 File Offset: 0x00023F79
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00025D89 File Offset: 0x00023F89
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00025D9A File Offset: 0x00023F9A
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00025DAA File Offset: 0x00023FAA
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00025DBB File Offset: 0x00023FBB
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00025DCB File Offset: 0x00023FCB
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00025DDC File Offset: 0x00023FDC
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00025DEC File Offset: 0x00023FEC
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00025E00 File Offset: 0x00024000
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00025E43 File Offset: 0x00024043
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00025E54 File Offset: 0x00024054
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00025E97 File Offset: 0x00024097
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00025EA8 File Offset: 0x000240A8
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x00025EEB File Offset: 0x000240EB
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00025EFC File Offset: 0x000240FC
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x00025F3F File Offset: 0x0002413F
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x00025F4D File Offset: 0x0002414D
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x00025F5D File Offset: 0x0002415D
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x00025F6E File Offset: 0x0002416E
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00025F7E File Offset: 0x0002417E
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

		// Token: 0x06001909 RID: 6409 RVA: 0x00025F8F File Offset: 0x0002418F
		public FAnimUpdateRateParameters()
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00025F97 File Offset: 0x00024197
		protected override IntPtr GetUStructPtr()
		{
			return FAnimUpdateRateParameters.StaticStruct();
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00025FA3 File Offset: 0x000241A3
		[NullableContext(2)]
		public FAnimUpdateRateParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00025FAD File Offset: 0x000241AD
		public FAnimUpdateRateParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00025FB8 File Offset: 0x000241B8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimUpdateRateParameters(Pointer, false, true);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00025FC2 File Offset: 0x000241C2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimUpdateRateParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040007E9 RID: 2025
		public const string __ObjectPath = "/Script/Engine.AnimUpdateRateParameters";

		// Token: 0x040007EA RID: 2026
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007EB RID: 2027
		internal static int __PropertyOffset_bInterpolateSkippedFrames;

		// Token: 0x040007EC RID: 2028
		internal static byte __PropertyMask_bInterpolateSkippedFrames;

		// Token: 0x040007ED RID: 2029
		internal static int __PropertyOffset_bShouldUseLodMap;

		// Token: 0x040007EE RID: 2030
		internal static byte __PropertyMask_bShouldUseLodMap;

		// Token: 0x040007EF RID: 2031
		internal static int __PropertyOffset_bShouldUseDistanceMap;

		// Token: 0x040007F0 RID: 2032
		internal static byte __PropertyMask_bShouldUseDistanceMap;

		// Token: 0x040007F1 RID: 2033
		internal static int __PropertyOffset_bShouldUseMinLod;

		// Token: 0x040007F2 RID: 2034
		internal static byte __PropertyMask_bShouldUseMinLod;

		// Token: 0x040007F3 RID: 2035
		internal static int __PropertyOffset_bSkipUpdate;

		// Token: 0x040007F4 RID: 2036
		internal static byte __PropertyMask_bSkipUpdate;

		// Token: 0x040007F5 RID: 2037
		internal static int __PropertyOffset_bSkipEvaluation;

		// Token: 0x040007F6 RID: 2038
		internal static byte __PropertyMask_bSkipEvaluation;

		// Token: 0x040007F7 RID: 2039
		internal static int __PropertyOffset_UpdateRate;

		// Token: 0x040007F8 RID: 2040
		internal static int __PropertyOffset_EvaluationRate;

		// Token: 0x040007F9 RID: 2041
		internal static int __PropertyOffset_TickedPoseOffestTime;

		// Token: 0x040007FA RID: 2042
		internal static int __PropertyOffset_AdditionalTime;

		// Token: 0x040007FB RID: 2043
		internal static int __PropertyOffset_BaseNonRenderedUpdateRate;

		// Token: 0x040007FC RID: 2044
		internal static int __PropertyOffset_MaxEvalRateForInterpolation;

		// Token: 0x040007FD RID: 2045
		internal static int __PropertyOffset_BaseVisibleDistanceFactorThesholds;

		// Token: 0x040007FE RID: 2046
		[Nullable(2)]
		private TArray<float> _BaseVisibleDistanceFactorThesholds;

		// Token: 0x040007FF RID: 2047
		internal static int __PropertyOffset_LODToFrameSkipMap;

		// Token: 0x04000800 RID: 2048
		[Nullable(2)]
		private TMap<int, int> _LODToFrameSkipMap;

		// Token: 0x04000801 RID: 2049
		internal static int __PropertyOffset_BaseVisibleDistanceThresholds;

		// Token: 0x04000802 RID: 2050
		[Nullable(2)]
		private TArray<float> _BaseVisibleDistanceThresholds;

		// Token: 0x04000803 RID: 2051
		internal static int __PropertyOffset_BaseVisibleScreenRatioThresholds;

		// Token: 0x04000804 RID: 2052
		[Nullable(2)]
		private TArray<float> _BaseVisibleScreenRatioThresholds;

		// Token: 0x04000805 RID: 2053
		internal static int __PropertyOffset_SkippedUpdateFrames;

		// Token: 0x04000806 RID: 2054
		internal static int __PropertyOffset_SkippedEvalFrames;
	}
}
