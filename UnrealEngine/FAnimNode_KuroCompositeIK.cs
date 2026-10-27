using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001610 RID: 5648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroCompositeIK")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class FAnimNode_KuroCompositeIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601461C RID: 83484 RVA: 0x001DF557 File Offset: 0x001DD757
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroCompositeIK._ScriptStructPtr != 0) ? FAnimNode_KuroCompositeIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroCompositeIK", ref FAnimNode_KuroCompositeIK._ScriptStructPtr);
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x0601461D RID: 83485 RVA: 0x001DF57C File Offset: 0x001DD77C
		// (set) Token: 0x0601461E RID: 83486 RVA: 0x001DF5BF File Offset: 0x001DD7BF
		public TArray<FKuroIKRequest> IKRequests
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroIKRequest> result;
				if ((result = this._IKRequests) == null)
				{
					result = (this._IKRequests = new TArray<FKuroIKRequest>(base.NativePtr + (IntPtr)FAnimNode_KuroCompositeIK.__PropertyOffset_IKRequests, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IKRequests.CopyAssign(value);
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x0601461F RID: 83487 RVA: 0x001DF5D0 File Offset: 0x001DD7D0
		// (set) Token: 0x06014620 RID: 83488 RVA: 0x001DF613 File Offset: 0x001DD813
		public TArray<FTransform> TargetTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._TargetTransforms) == null)
				{
					result = (this._TargetTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FAnimNode_KuroCompositeIK.__PropertyOffset_TargetTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x06014621 RID: 83489 RVA: 0x001DF621 File Offset: 0x001DD821
		// (set) Token: 0x06014622 RID: 83490 RVA: 0x001DF631 File Offset: 0x001DD831
		public unsafe bool bUseCachedBoneAsTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroCompositeIK.__PropertyOffset_bUseCachedBoneAsTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroCompositeIK.__PropertyOffset_bUseCachedBoneAsTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014623 RID: 83491 RVA: 0x001DF642 File Offset: 0x001DD842
		public FAnimNode_KuroCompositeIK()
		{
		}

		// Token: 0x06014624 RID: 83492 RVA: 0x001DF64C File Offset: 0x001DD84C
		public FAnimNode_KuroCompositeIK(TArray<FKuroIKRequest> IKRequests, TArray<FTransform> TargetTransforms, bool bUseCachedBoneAsTarget, bool bDebugDrawIterations, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.IKRequests = IKRequests;
			this.TargetTransforms = TargetTransforms;
			this.bUseCachedBoneAsTarget = bUseCachedBoneAsTarget;
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

		// Token: 0x06014625 RID: 83493 RVA: 0x001DF6DC File Offset: 0x001DD8DC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroCompositeIK.StaticStruct();
		}

		// Token: 0x06014626 RID: 83494 RVA: 0x001DF6E8 File Offset: 0x001DD8E8
		[NullableContext(2)]
		public FAnimNode_KuroCompositeIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014627 RID: 83495 RVA: 0x001DF6F2 File Offset: 0x001DD8F2
		public FAnimNode_KuroCompositeIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014628 RID: 83496 RVA: 0x001DF6FD File Offset: 0x001DD8FD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroCompositeIK(Pointer, false, true);
		}

		// Token: 0x06014629 RID: 83497 RVA: 0x001DF707 File Offset: 0x001DD907
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroCompositeIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B173 RID: 45427
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroCompositeIK";

		// Token: 0x0400B174 RID: 45428
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B175 RID: 45429
		internal static int __PropertyOffset_IKRequests;

		// Token: 0x0400B176 RID: 45430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroIKRequest> _IKRequests;

		// Token: 0x0400B177 RID: 45431
		internal static int __PropertyOffset_TargetTransforms;

		// Token: 0x0400B178 RID: 45432
		[Nullable(2)]
		private TArray<FTransform> _TargetTransforms;

		// Token: 0x0400B179 RID: 45433
		internal static int __PropertyOffset_bUseCachedBoneAsTarget;
	}
}
