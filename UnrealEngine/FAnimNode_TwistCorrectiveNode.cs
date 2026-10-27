using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000304 RID: 772
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_TwistCorrectiveNode")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FAnimNode_TwistCorrectiveNode : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C8F RID: 11407 RVA: 0x00044398 File Offset: 0x00042598
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TwistCorrectiveNode._ScriptStructPtr != 0) ? FAnimNode_TwistCorrectiveNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_TwistCorrectiveNode", ref FAnimNode_TwistCorrectiveNode._ScriptStructPtr);
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000443BC File Offset: 0x000425BC
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x000443FF File Offset: 0x000425FF
		public FReferenceBoneFrame BaseFrame
		{
			get
			{
				base.FastCheckIsValid();
				FReferenceBoneFrame result;
				if ((result = this._BaseFrame) == null)
				{
					result = (this._BaseFrame = new FReferenceBoneFrame(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_BaseFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReferenceBoneFrame.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_BaseFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x00044420 File Offset: 0x00042620
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x00044463 File Offset: 0x00042663
		public FReferenceBoneFrame TwistFrame
		{
			get
			{
				base.FastCheckIsValid();
				FReferenceBoneFrame result;
				if ((result = this._TwistFrame) == null)
				{
					result = (this._TwistFrame = new FReferenceBoneFrame(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_TwistFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReferenceBoneFrame.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_TwistFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x00044484 File Offset: 0x00042684
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x000444C7 File Offset: 0x000426C7
		public FAxis TwistPlaneNormalAxis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._TwistPlaneNormalAxis) == null)
				{
					result = (this._TwistPlaneNormalAxis = new FAxis(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_TwistPlaneNormalAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_TwistPlaneNormalAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000444E8 File Offset: 0x000426E8
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x000444F8 File Offset: 0x000426F8
		public unsafe float RangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RangeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RangeMax) = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x00044509 File Offset: 0x00042709
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x00044519 File Offset: 0x00042719
		public unsafe float RemappedMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RemappedMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RemappedMin) = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x0004452A File Offset: 0x0004272A
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0004453A File Offset: 0x0004273A
		public unsafe float RemappedMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RemappedMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_RemappedMax) = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x0004454C File Offset: 0x0004274C
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0004458F File Offset: 0x0004278F
		public FAnimCurveParam Curve
		{
			get
			{
				base.FastCheckIsValid();
				FAnimCurveParam result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FAnimCurveParam(base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimCurveParam.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwistCorrectiveNode.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000445B0 File Offset: 0x000427B0
		public FAnimNode_TwistCorrectiveNode()
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000445B8 File Offset: 0x000427B8
		public FAnimNode_TwistCorrectiveNode(FReferenceBoneFrame BaseFrame, FReferenceBoneFrame TwistFrame, FAxis TwistPlaneNormalAxis, float RangeMax, float RemappedMin, float RemappedMax, FAnimCurveParam Curve, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BaseFrame = BaseFrame;
			this.TwistFrame = TwistFrame;
			this.TwistPlaneNormalAxis = TwistPlaneNormalAxis;
			this.RangeMax = RangeMax;
			this.RemappedMin = RemappedMin;
			this.RemappedMax = RemappedMax;
			this.Curve = Curve;
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

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00044668 File Offset: 0x00042868
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TwistCorrectiveNode.StaticStruct();
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00044674 File Offset: 0x00042874
		[NullableContext(2)]
		public FAnimNode_TwistCorrectiveNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0004467E File Offset: 0x0004287E
		public FAnimNode_TwistCorrectiveNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00044689 File Offset: 0x00042889
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TwistCorrectiveNode(Pointer, false, true);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00044693 File Offset: 0x00042893
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TwistCorrectiveNode(Pointer, MemoryOwner);
		}

		// Token: 0x04001250 RID: 4688
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_TwistCorrectiveNode";

		// Token: 0x04001251 RID: 4689
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001252 RID: 4690
		internal static int __PropertyOffset_BaseFrame;

		// Token: 0x04001253 RID: 4691
		[Nullable(2)]
		private FReferenceBoneFrame _BaseFrame;

		// Token: 0x04001254 RID: 4692
		internal static int __PropertyOffset_TwistFrame;

		// Token: 0x04001255 RID: 4693
		[Nullable(2)]
		private FReferenceBoneFrame _TwistFrame;

		// Token: 0x04001256 RID: 4694
		internal static int __PropertyOffset_TwistPlaneNormalAxis;

		// Token: 0x04001257 RID: 4695
		[Nullable(2)]
		private FAxis _TwistPlaneNormalAxis;

		// Token: 0x04001258 RID: 4696
		internal static int __PropertyOffset_RangeMax;

		// Token: 0x04001259 RID: 4697
		internal static int __PropertyOffset_RemappedMin;

		// Token: 0x0400125A RID: 4698
		internal static int __PropertyOffset_RemappedMax;

		// Token: 0x0400125B RID: 4699
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400125C RID: 4700
		[Nullable(2)]
		private FAnimCurveParam _Curve;
	}
}
