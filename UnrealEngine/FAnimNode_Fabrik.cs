using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E1 RID: 737
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_Fabrik")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 624)]
	public class FAnimNode_Fabrik : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x0003F183 File Offset: 0x0003D383
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Fabrik._ScriptStructPtr != 0) ? FAnimNode_Fabrik._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_Fabrik", ref FAnimNode_Fabrik._ScriptStructPtr);
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x0003F1A7 File Offset: 0x0003D3A7
		// (set) Token: 0x060029B6 RID: 10678 RVA: 0x0003F1BB File Offset: 0x0003D3BB
		public unsafe FTransform EffectorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTransform) = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x0003F1D0 File Offset: 0x0003D3D0
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x0003F213 File Offset: 0x0003D413
		public FBoneSocketTarget EffectorTarget
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSocketTarget result;
				if ((result = this._EffectorTarget) == null)
				{
					result = (this._EffectorTarget = new FBoneSocketTarget(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSocketTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x0003F234 File Offset: 0x0003D434
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x0003F277 File Offset: 0x0003D477
		public FBoneReference TipBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TipBone) == null)
				{
					result = (this._TipBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_TipBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_TipBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0003F298 File Offset: 0x0003D498
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x0003F2DB File Offset: 0x0003D4DB
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x0003F2FC File Offset: 0x0003D4FC
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x0003F30C File Offset: 0x0003D50C
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x0003F31D File Offset: 0x0003D51D
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x0003F32D File Offset: 0x0003D52D
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x0003F33E File Offset: 0x0003D53E
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x0003F352 File Offset: 0x0003D552
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> EffectorTransformSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTransformSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorTransformSpace) = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x0003F367 File Offset: 0x0003D567
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x0003F37B File Offset: 0x0003D57B
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneRotationSource> EffectorRotationSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorRotationSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Fabrik.__PropertyOffset_EffectorRotationSource) = value;
			}
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0003F390 File Offset: 0x0003D590
		public FAnimNode_Fabrik()
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0003F398 File Offset: 0x0003D598
		public FAnimNode_Fabrik(FTransform EffectorTransform, FBoneSocketTarget EffectorTarget, FBoneReference TipBone, FBoneReference RootBone, float Precision, int MaxIterations, [Nullable(0)] TEnumAsByte<EBoneControlSpace> EffectorTransformSpace, [Nullable(0)] TEnumAsByte<EBoneRotationSource> EffectorRotationSource, bool bEnableDebugDraw, FBoneReference EffectorTransformBone_DEPRECATED, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.EffectorTransform = EffectorTransform;
			this.EffectorTarget = EffectorTarget;
			this.TipBone = TipBone;
			this.RootBone = RootBone;
			this.Precision = Precision;
			this.MaxIterations = MaxIterations;
			this.EffectorTransformSpace = EffectorTransformSpace;
			this.EffectorRotationSource = EffectorRotationSource;
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

		// Token: 0x060029C7 RID: 10695 RVA: 0x0003F450 File Offset: 0x0003D650
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Fabrik.StaticStruct();
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0003F45C File Offset: 0x0003D65C
		[NullableContext(2)]
		public FAnimNode_Fabrik(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0003F466 File Offset: 0x0003D666
		public FAnimNode_Fabrik(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0003F471 File Offset: 0x0003D671
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Fabrik(Pointer, false, true);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0003F47B File Offset: 0x0003D67B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Fabrik(Pointer, MemoryOwner);
		}

		// Token: 0x040010C7 RID: 4295
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_Fabrik";

		// Token: 0x040010C8 RID: 4296
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010C9 RID: 4297
		internal static int __PropertyOffset_EffectorTransform;

		// Token: 0x040010CA RID: 4298
		internal static int __PropertyOffset_EffectorTarget;

		// Token: 0x040010CB RID: 4299
		[Nullable(2)]
		private FBoneSocketTarget _EffectorTarget;

		// Token: 0x040010CC RID: 4300
		internal static int __PropertyOffset_TipBone;

		// Token: 0x040010CD RID: 4301
		[Nullable(2)]
		private FBoneReference _TipBone;

		// Token: 0x040010CE RID: 4302
		internal static int __PropertyOffset_RootBone;

		// Token: 0x040010CF RID: 4303
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x040010D0 RID: 4304
		internal static int __PropertyOffset_Precision;

		// Token: 0x040010D1 RID: 4305
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x040010D2 RID: 4306
		internal static int __PropertyOffset_EffectorTransformSpace;

		// Token: 0x040010D3 RID: 4307
		internal static int __PropertyOffset_EffectorRotationSource;
	}
}
