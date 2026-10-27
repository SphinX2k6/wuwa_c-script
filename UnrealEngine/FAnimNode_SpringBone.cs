using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000301 RID: 769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_SpringBone")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FAnimNode_SpringBone : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x00043844 File Offset: 0x00041A44
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SpringBone._ScriptStructPtr != 0) ? FAnimNode_SpringBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_SpringBone", ref FAnimNode_SpringBone._ScriptStructPtr);
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x00043868 File Offset: 0x00041A68
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x000438AB File Offset: 0x00041AAB
		public FBoneReference SpringBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SpringBone) == null)
				{
					result = (this._SpringBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000438CC File Offset: 0x00041ACC
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x000438DC File Offset: 0x00041ADC
		public unsafe float MaxDisplacement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_MaxDisplacement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_MaxDisplacement) = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000438ED File Offset: 0x00041AED
		// (set) Token: 0x06002C3D RID: 11325 RVA: 0x000438FD File Offset: 0x00041AFD
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x0004390E File Offset: 0x00041B0E
		// (set) Token: 0x06002C3F RID: 11327 RVA: 0x0004391E File Offset: 0x00041B1E
		public unsafe float SpringDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_SpringDamping) = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0004392F File Offset: 0x00041B2F
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0004393F File Offset: 0x00041B3F
		public unsafe float ErrorResetThresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_ErrorResetThresh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_ErrorResetThresh) = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x00043950 File Offset: 0x00041B50
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x00043969 File Offset: 0x00041B69
		public unsafe bool bLimitDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bLimitDisplacement) & FAnimNode_SpringBone.__PropertyMask_bLimitDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bLimitDisplacement) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bLimitDisplacement) & ~FAnimNode_SpringBone.__PropertyMask_bLimitDisplacement) | (value ? FAnimNode_SpringBone.__PropertyMask_bLimitDisplacement : 0));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00043999 File Offset: 0x00041B99
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x000439B2 File Offset: 0x00041BB2
		public unsafe bool bTranslateX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateX) & FAnimNode_SpringBone.__PropertyMask_bTranslateX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateX) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateX) & ~FAnimNode_SpringBone.__PropertyMask_bTranslateX) | (value ? FAnimNode_SpringBone.__PropertyMask_bTranslateX : 0));
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000439E2 File Offset: 0x00041BE2
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x000439FB File Offset: 0x00041BFB
		public unsafe bool bTranslateY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateY) & FAnimNode_SpringBone.__PropertyMask_bTranslateY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateY) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateY) & ~FAnimNode_SpringBone.__PropertyMask_bTranslateY) | (value ? FAnimNode_SpringBone.__PropertyMask_bTranslateY : 0));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00043A2B File Offset: 0x00041C2B
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x00043A44 File Offset: 0x00041C44
		public unsafe bool bTranslateZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateZ) & FAnimNode_SpringBone.__PropertyMask_bTranslateZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateZ) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bTranslateZ) & ~FAnimNode_SpringBone.__PropertyMask_bTranslateZ) | (value ? FAnimNode_SpringBone.__PropertyMask_bTranslateZ : 0));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x00043A74 File Offset: 0x00041C74
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x00043A8D File Offset: 0x00041C8D
		public unsafe bool bRotateX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateX) & FAnimNode_SpringBone.__PropertyMask_bRotateX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateX) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateX) & ~FAnimNode_SpringBone.__PropertyMask_bRotateX) | (value ? FAnimNode_SpringBone.__PropertyMask_bRotateX : 0));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x00043ABD File Offset: 0x00041CBD
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x00043AD6 File Offset: 0x00041CD6
		public unsafe bool bRotateY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateY) & FAnimNode_SpringBone.__PropertyMask_bRotateY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateY) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateY) & ~FAnimNode_SpringBone.__PropertyMask_bRotateY) | (value ? FAnimNode_SpringBone.__PropertyMask_bRotateY : 0));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00043B06 File Offset: 0x00041D06
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x00043B1F File Offset: 0x00041D1F
		public unsafe bool bRotateZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateZ) & FAnimNode_SpringBone.__PropertyMask_bRotateZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateZ) = ((*(base.NativePtr + (IntPtr)FAnimNode_SpringBone.__PropertyOffset_bRotateZ) & ~FAnimNode_SpringBone.__PropertyMask_bRotateZ) | (value ? FAnimNode_SpringBone.__PropertyMask_bRotateZ : 0));
			}
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00043B4F File Offset: 0x00041D4F
		public FAnimNode_SpringBone()
		{
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00043B58 File Offset: 0x00041D58
		public FAnimNode_SpringBone(FBoneReference SpringBone, float MaxDisplacement, float SpringStiffness, float SpringDamping, float ErrorResetThresh, bool bNoZSpring_DEPRECATED, bool bLimitDisplacement, bool bTranslateX, bool bTranslateY, bool bTranslateZ, bool bRotateX, bool bRotateY, bool bRotateZ, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SpringBone = SpringBone;
			this.MaxDisplacement = MaxDisplacement;
			this.SpringStiffness = SpringStiffness;
			this.SpringDamping = SpringDamping;
			this.ErrorResetThresh = ErrorResetThresh;
			this.bLimitDisplacement = bLimitDisplacement;
			this.bTranslateX = bTranslateX;
			this.bTranslateY = bTranslateY;
			this.bTranslateZ = bTranslateZ;
			this.bRotateX = bRotateX;
			this.bRotateY = bRotateY;
			this.bRotateZ = bRotateZ;
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

		// Token: 0x06002C52 RID: 11346 RVA: 0x00043C30 File Offset: 0x00041E30
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SpringBone.StaticStruct();
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00043C3C File Offset: 0x00041E3C
		[NullableContext(2)]
		public FAnimNode_SpringBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00043C46 File Offset: 0x00041E46
		public FAnimNode_SpringBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00043C51 File Offset: 0x00041E51
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SpringBone(Pointer, false, true);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00043C5B File Offset: 0x00041E5B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SpringBone(Pointer, MemoryOwner);
		}

		// Token: 0x04001215 RID: 4629
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_SpringBone";

		// Token: 0x04001216 RID: 4630
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001217 RID: 4631
		internal static int __PropertyOffset_SpringBone;

		// Token: 0x04001218 RID: 4632
		[Nullable(2)]
		private FBoneReference _SpringBone;

		// Token: 0x04001219 RID: 4633
		internal static int __PropertyOffset_MaxDisplacement;

		// Token: 0x0400121A RID: 4634
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x0400121B RID: 4635
		internal static int __PropertyOffset_SpringDamping;

		// Token: 0x0400121C RID: 4636
		internal static int __PropertyOffset_ErrorResetThresh;

		// Token: 0x0400121D RID: 4637
		internal static int __PropertyOffset_bLimitDisplacement;

		// Token: 0x0400121E RID: 4638
		internal static byte __PropertyMask_bLimitDisplacement;

		// Token: 0x0400121F RID: 4639
		internal static int __PropertyOffset_bTranslateX;

		// Token: 0x04001220 RID: 4640
		internal static byte __PropertyMask_bTranslateX;

		// Token: 0x04001221 RID: 4641
		internal static int __PropertyOffset_bTranslateY;

		// Token: 0x04001222 RID: 4642
		internal static byte __PropertyMask_bTranslateY;

		// Token: 0x04001223 RID: 4643
		internal static int __PropertyOffset_bTranslateZ;

		// Token: 0x04001224 RID: 4644
		internal static byte __PropertyMask_bTranslateZ;

		// Token: 0x04001225 RID: 4645
		internal static int __PropertyOffset_bRotateX;

		// Token: 0x04001226 RID: 4646
		internal static byte __PropertyMask_bRotateX;

		// Token: 0x04001227 RID: 4647
		internal static int __PropertyOffset_bRotateY;

		// Token: 0x04001228 RID: 4648
		internal static byte __PropertyMask_bRotateY;

		// Token: 0x04001229 RID: 4649
		internal static int __PropertyOffset_bRotateZ;

		// Token: 0x0400122A RID: 4650
		internal static byte __PropertyMask_bRotateZ;
	}
}
