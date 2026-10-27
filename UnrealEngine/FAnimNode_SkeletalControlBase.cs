using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FD RID: 765
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FAnimNode_SkeletalControlBase : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002BDD RID: 11229 RVA: 0x00042F14 File Offset: 0x00041114
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SkeletalControlBase._ScriptStructPtr != 0) ? FAnimNode_SkeletalControlBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase", ref FAnimNode_SkeletalControlBase._ScriptStructPtr);
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x00042F38 File Offset: 0x00041138
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x00042F7B File Offset: 0x0004117B
		public FComponentSpacePoseLink ComponentPose
		{
			get
			{
				base.FastCheckIsValid();
				FComponentSpacePoseLink result;
				if ((result = this._ComponentPose) == null)
				{
					result = (this._ComponentPose = new FComponentSpacePoseLink(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_ComponentPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentSpacePoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_ComponentPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x00042F9C File Offset: 0x0004119C
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x00042FAC File Offset: 0x000411AC
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x00042FBD File Offset: 0x000411BD
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00042FCD File Offset: 0x000411CD
		public unsafe int KuroLODMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_KuroLODMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_KuroLODMask) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x00042FDE File Offset: 0x000411DE
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00042FEE File Offset: 0x000411EE
		public unsafe float ActualAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_ActualAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_ActualAlpha) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x00042FFF File Offset: 0x000411FF
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x0004300F File Offset: 0x0004120F
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x00043020 File Offset: 0x00041220
		// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x00043030 File Offset: 0x00041230
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bAlphaBoolEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bAlphaBoolEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x00043041 File Offset: 0x00041241
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x00043051 File Offset: 0x00041251
		public unsafe bool bParallelEvalEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bParallelEvalEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bParallelEvalEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x00043062 File Offset: 0x00041262
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x00043072 File Offset: 0x00041272
		public unsafe bool bEnableOnMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bEnableOnMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_bEnableOnMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x00043083 File Offset: 0x00041283
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x00043093 File Offset: 0x00041293
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000430A4 File Offset: 0x000412A4
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x000430E7 File Offset: 0x000412E7
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x00043108 File Offset: 0x00041308
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0004314B File Offset: 0x0004134B
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0004316C File Offset: 0x0004136C
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x00043180 File Offset: 0x00041380
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x00043198 File Offset: 0x00041398
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x000431DB File Offset: 0x000413DB
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SkeletalControlBase.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000431FC File Offset: 0x000413FC
		public FAnimNode_SkeletalControlBase()
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00043204 File Offset: 0x00041404
		public FAnimNode_SkeletalControlBase(FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.ComponentPose = ComponentPose;
			this.LODThreshold = LODThreshold;
			this.KuroLODMask = KuroLODMask;
			this.ActualAlpha = ActualAlpha;
			this.AlphaInputType = AlphaInputType;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
			this.bParallelEvalEnabled = bParallelEvalEnabled;
			this.bEnableOnMobile = bEnableOnMobile;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0004327C File Offset: 0x0004147C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SkeletalControlBase.StaticStruct();
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00043288 File Offset: 0x00041488
		[NullableContext(2)]
		public FAnimNode_SkeletalControlBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00043292 File Offset: 0x00041492
		public FAnimNode_SkeletalControlBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0004329D File Offset: 0x0004149D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SkeletalControlBase(Pointer, false, true);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000432A7 File Offset: 0x000414A7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SkeletalControlBase(Pointer, MemoryOwner);
		}

		// Token: 0x040011E7 RID: 4583
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase";

		// Token: 0x040011E8 RID: 4584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011E9 RID: 4585
		internal static int __PropertyOffset_ComponentPose;

		// Token: 0x040011EA RID: 4586
		[Nullable(2)]
		private FComponentSpacePoseLink _ComponentPose;

		// Token: 0x040011EB RID: 4587
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x040011EC RID: 4588
		internal static int __PropertyOffset_KuroLODMask;

		// Token: 0x040011ED RID: 4589
		internal static int __PropertyOffset_ActualAlpha;

		// Token: 0x040011EE RID: 4590
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x040011EF RID: 4591
		internal static int __PropertyOffset_bAlphaBoolEnabled;

		// Token: 0x040011F0 RID: 4592
		internal static int __PropertyOffset_bParallelEvalEnabled;

		// Token: 0x040011F1 RID: 4593
		internal static int __PropertyOffset_bEnableOnMobile;

		// Token: 0x040011F2 RID: 4594
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040011F3 RID: 4595
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x040011F4 RID: 4596
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x040011F5 RID: 4597
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x040011F6 RID: 4598
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x040011F7 RID: 4599
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x040011F8 RID: 4600
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x040011F9 RID: 4601
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;
	}
}
