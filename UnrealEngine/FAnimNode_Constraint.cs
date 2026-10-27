using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DA RID: 730
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_Constraint")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FAnimNode_Constraint : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x0003E054 File Offset: 0x0003C254
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Constraint._ScriptStructPtr != 0) ? FAnimNode_Constraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_Constraint", ref FAnimNode_Constraint._ScriptStructPtr);
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x0003E078 File Offset: 0x0003C278
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x0003E0BB File Offset: 0x0003C2BB
		public FBoneReference BoneToModify
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneToModify) == null)
				{
					result = (this._BoneToModify = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_Constraint.__PropertyOffset_BoneToModify, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Constraint.__PropertyOffset_BoneToModify, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x0003E0DC File Offset: 0x0003C2DC
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x0003E11F File Offset: 0x0003C31F
		public TArray<FConstraint> ConstraintSetup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraint> result;
				if ((result = this._ConstraintSetup) == null)
				{
					result = (this._ConstraintSetup = new TArray<FConstraint>(base.NativePtr + (IntPtr)FAnimNode_Constraint.__PropertyOffset_ConstraintSetup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConstraintSetup.CopyAssign(value);
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x0003E130 File Offset: 0x0003C330
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x0003E173 File Offset: 0x0003C373
		public TArray<float> ConstraintWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ConstraintWeights) == null)
				{
					result = (this._ConstraintWeights = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_Constraint.__PropertyOffset_ConstraintWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConstraintWeights.CopyAssign(value);
			}
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0003E181 File Offset: 0x0003C381
		public FAnimNode_Constraint()
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0003E18C File Offset: 0x0003C38C
		public FAnimNode_Constraint(FBoneReference BoneToModify, TArray<FConstraint> ConstraintSetup, TArray<float> ConstraintWeights, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneToModify = BoneToModify;
			this.ConstraintSetup = ConstraintSetup;
			this.ConstraintWeights = ConstraintWeights;
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

		// Token: 0x0600291D RID: 10525 RVA: 0x0003E21C File Offset: 0x0003C41C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Constraint.StaticStruct();
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0003E228 File Offset: 0x0003C428
		[NullableContext(2)]
		public FAnimNode_Constraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0003E232 File Offset: 0x0003C432
		public FAnimNode_Constraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x0003E23D File Offset: 0x0003C43D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Constraint(Pointer, false, true);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0003E247 File Offset: 0x0003C447
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Constraint(Pointer, MemoryOwner);
		}

		// Token: 0x04001071 RID: 4209
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_Constraint";

		// Token: 0x04001072 RID: 4210
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001073 RID: 4211
		internal static int __PropertyOffset_BoneToModify;

		// Token: 0x04001074 RID: 4212
		[Nullable(2)]
		private FBoneReference _BoneToModify;

		// Token: 0x04001075 RID: 4213
		internal static int __PropertyOffset_ConstraintSetup;

		// Token: 0x04001076 RID: 4214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraint> _ConstraintSetup;

		// Token: 0x04001077 RID: 4215
		internal static int __PropertyOffset_ConstraintWeights;

		// Token: 0x04001078 RID: 4216
		[Nullable(2)]
		private TArray<float> _ConstraintWeights;
	}
}
