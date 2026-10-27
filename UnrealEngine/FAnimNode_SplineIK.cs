using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000300 RID: 768
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_SplineIK")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 768)]
	public class FAnimNode_SplineIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C17 RID: 11287 RVA: 0x00043481 File Offset: 0x00041681
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SplineIK._ScriptStructPtr != 0) ? FAnimNode_SplineIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_SplineIK", ref FAnimNode_SplineIK._ScriptStructPtr);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x000434A8 File Offset: 0x000416A8
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x000434EB File Offset: 0x000416EB
		public FBoneReference StartBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._StartBone) == null)
				{
					result = (this._StartBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_StartBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_StartBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0004350C File Offset: 0x0004170C
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0004354F File Offset: 0x0004174F
		public FBoneReference EndBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._EndBone) == null)
				{
					result = (this._EndBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_EndBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_EndBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x00043570 File Offset: 0x00041770
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00043580 File Offset: 0x00041780
		public unsafe ESplineBoneAxis BoneAxis
		{
			get
			{
				return (ESplineBoneAxis)(*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_BoneAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_BoneAxis) = (byte)value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00043591 File Offset: 0x00041791
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x000435A1 File Offset: 0x000417A1
		public unsafe bool bAutoCalculateSpline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_bAutoCalculateSpline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_bAutoCalculateSpline) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x000435B2 File Offset: 0x000417B2
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x000435C2 File Offset: 0x000417C2
		public unsafe int PointCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_PointCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_PointCount) = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x000435D4 File Offset: 0x000417D4
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x00043617 File Offset: 0x00041817
		public TArray<FTransform> ControlPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._ControlPoints) == null)
				{
					result = (this._ControlPoints = new TArray<FTransform>(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_ControlPoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControlPoints.CopyAssign(value);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00043625 File Offset: 0x00041825
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x00043635 File Offset: 0x00041835
		public unsafe float Roll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Roll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Roll) = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x00043646 File Offset: 0x00041846
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x00043656 File Offset: 0x00041856
		public unsafe float TwistStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistStart) = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x00043667 File Offset: 0x00041867
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x00043677 File Offset: 0x00041877
		public unsafe float TwistEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistEnd) = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x00043688 File Offset: 0x00041888
		// (set) Token: 0x06002C2B RID: 11307 RVA: 0x000436CB File Offset: 0x000418CB
		public FAlphaBlend TwistBlend
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._TwistBlend) == null)
				{
					result = (this._TwistBlend = new FAlphaBlend(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_TwistBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x000436EC File Offset: 0x000418EC
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x000436FC File Offset: 0x000418FC
		public unsafe float Stretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Stretch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Stretch) = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x0004370D File Offset: 0x0004190D
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x0004371D File Offset: 0x0004191D
		public unsafe float Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SplineIK.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0004372E File Offset: 0x0004192E
		public FAnimNode_SplineIK()
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00043738 File Offset: 0x00041938
		public FAnimNode_SplineIK(FBoneReference StartBone, FBoneReference EndBone, ESplineBoneAxis BoneAxis, bool bAutoCalculateSpline, int PointCount, TArray<FTransform> ControlPoints, float Roll, float TwistStart, float TwistEnd, FAlphaBlend TwistBlend, float Stretch, float Offset, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.BoneAxis = BoneAxis;
			this.bAutoCalculateSpline = bAutoCalculateSpline;
			this.PointCount = PointCount;
			this.ControlPoints = ControlPoints;
			this.Roll = Roll;
			this.TwistStart = TwistStart;
			this.TwistEnd = TwistEnd;
			this.TwistBlend = TwistBlend;
			this.Stretch = Stretch;
			this.Offset = Offset;
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

		// Token: 0x06002C32 RID: 11314 RVA: 0x00043810 File Offset: 0x00041A10
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SplineIK.StaticStruct();
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0004381C File Offset: 0x00041A1C
		[NullableContext(2)]
		public FAnimNode_SplineIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00043826 File Offset: 0x00041A26
		public FAnimNode_SplineIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00043831 File Offset: 0x00041A31
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SplineIK(Pointer, false, true);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0004383B File Offset: 0x00041A3B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SplineIK(Pointer, MemoryOwner);
		}

		// Token: 0x04001203 RID: 4611
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_SplineIK";

		// Token: 0x04001204 RID: 4612
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001205 RID: 4613
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04001206 RID: 4614
		[Nullable(2)]
		private FBoneReference _StartBone;

		// Token: 0x04001207 RID: 4615
		internal static int __PropertyOffset_EndBone;

		// Token: 0x04001208 RID: 4616
		[Nullable(2)]
		private FBoneReference _EndBone;

		// Token: 0x04001209 RID: 4617
		internal static int __PropertyOffset_BoneAxis;

		// Token: 0x0400120A RID: 4618
		internal static int __PropertyOffset_bAutoCalculateSpline;

		// Token: 0x0400120B RID: 4619
		internal static int __PropertyOffset_PointCount;

		// Token: 0x0400120C RID: 4620
		internal static int __PropertyOffset_ControlPoints;

		// Token: 0x0400120D RID: 4621
		[Nullable(2)]
		private TArray<FTransform> _ControlPoints;

		// Token: 0x0400120E RID: 4622
		internal static int __PropertyOffset_Roll;

		// Token: 0x0400120F RID: 4623
		internal static int __PropertyOffset_TwistStart;

		// Token: 0x04001210 RID: 4624
		internal static int __PropertyOffset_TwistEnd;

		// Token: 0x04001211 RID: 4625
		internal static int __PropertyOffset_TwistBlend;

		// Token: 0x04001212 RID: 4626
		[Nullable(2)]
		private FAlphaBlend _TwistBlend;

		// Token: 0x04001213 RID: 4627
		internal static int __PropertyOffset_Stretch;

		// Token: 0x04001214 RID: 4628
		internal static int __PropertyOffset_Offset;
	}
}
