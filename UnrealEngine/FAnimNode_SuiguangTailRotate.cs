using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001622 RID: 5666
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_SuiguangTailRotate")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 392)]
	public class FAnimNode_SuiguangTailRotate : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060147BA RID: 83898 RVA: 0x001E2147 File Offset: 0x001E0347
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SuiguangTailRotate._ScriptStructPtr != 0) ? FAnimNode_SuiguangTailRotate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_SuiguangTailRotate", ref FAnimNode_SuiguangTailRotate._ScriptStructPtr);
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x060147BB RID: 83899 RVA: 0x001E216B File Offset: 0x001E036B
		// (set) Token: 0x060147BC RID: 83900 RVA: 0x001E217F File Offset: 0x001E037F
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x060147BD RID: 83901 RVA: 0x001E2194 File Offset: 0x001E0394
		// (set) Token: 0x060147BE RID: 83902 RVA: 0x001E21D7 File Offset: 0x001E03D7
		public TArray<FSuiguangTailBoneConfig> SuiguangTailBoneConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSuiguangTailBoneConfig> result;
				if ((result = this._SuiguangTailBoneConfig) == null)
				{
					result = (this._SuiguangTailBoneConfig = new TArray<FSuiguangTailBoneConfig>(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_SuiguangTailBoneConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuiguangTailBoneConfig.CopyAssign(value);
			}
		}

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x060147BF RID: 83903 RVA: 0x001E21E5 File Offset: 0x001E03E5
		// (set) Token: 0x060147C0 RID: 83904 RVA: 0x001E21F5 File Offset: 0x001E03F5
		public unsafe bool bRollBackToOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bRollBackToOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bRollBackToOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x060147C1 RID: 83905 RVA: 0x001E2206 File Offset: 0x001E0406
		// (set) Token: 0x060147C2 RID: 83906 RVA: 0x001E2216 File Offset: 0x001E0416
		public unsafe bool bStopRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bStopRoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bStopRoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x060147C3 RID: 83907 RVA: 0x001E2227 File Offset: 0x001E0427
		// (set) Token: 0x060147C4 RID: 83908 RVA: 0x001E2237 File Offset: 0x001E0437
		public unsafe bool bDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SuiguangTailRotate.__PropertyOffset_bDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x060147C5 RID: 83909 RVA: 0x001E2248 File Offset: 0x001E0448
		public FAnimNode_SuiguangTailRotate()
		{
		}

		// Token: 0x060147C6 RID: 83910 RVA: 0x001E2250 File Offset: 0x001E0450
		public FAnimNode_SuiguangTailRotate(FVector TargetLocation, TArray<FSuiguangTailBoneConfig> SuiguangTailBoneConfig, bool bRollBackToOrigin, bool bStopRoll, bool bDebug, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.TargetLocation = TargetLocation;
			this.SuiguangTailBoneConfig = SuiguangTailBoneConfig;
			this.bRollBackToOrigin = bRollBackToOrigin;
			this.bStopRoll = bStopRoll;
			this.bDebug = bDebug;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x060147C7 RID: 83911 RVA: 0x001E22F0 File Offset: 0x001E04F0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SuiguangTailRotate.StaticStruct();
		}

		// Token: 0x060147C8 RID: 83912 RVA: 0x001E22FC File Offset: 0x001E04FC
		[NullableContext(2)]
		public FAnimNode_SuiguangTailRotate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060147C9 RID: 83913 RVA: 0x001E2306 File Offset: 0x001E0506
		public FAnimNode_SuiguangTailRotate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060147CA RID: 83914 RVA: 0x001E2311 File Offset: 0x001E0511
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SuiguangTailRotate(Pointer, false, true);
		}

		// Token: 0x060147CB RID: 83915 RVA: 0x001E231B File Offset: 0x001E051B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SuiguangTailRotate(Pointer, MemoryOwner);
		}

		// Token: 0x0400B240 RID: 45632
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_SuiguangTailRotate";

		// Token: 0x0400B241 RID: 45633
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B242 RID: 45634
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x0400B243 RID: 45635
		internal static int __PropertyOffset_SuiguangTailBoneConfig;

		// Token: 0x0400B244 RID: 45636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSuiguangTailBoneConfig> _SuiguangTailBoneConfig;

		// Token: 0x0400B245 RID: 45637
		internal static int __PropertyOffset_bRollBackToOrigin;

		// Token: 0x0400B246 RID: 45638
		internal static int __PropertyOffset_bStopRoll;

		// Token: 0x0400B247 RID: 45639
		internal static int __PropertyOffset_bDebug;
	}
}
