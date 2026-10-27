using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D0 RID: 720
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ApplyLimits")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FAnimNode_ApplyLimits : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002846 RID: 10310 RVA: 0x0003C9B4 File Offset: 0x0003ABB4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ApplyLimits._ScriptStructPtr != 0) ? FAnimNode_ApplyLimits._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ApplyLimits", ref FAnimNode_ApplyLimits._ScriptStructPtr);
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x0003CA1B File Offset: 0x0003AC1B
		public TArray<FAngularRangeLimit> AngularRangeLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAngularRangeLimit> result;
				if ((result = this._AngularRangeLimits) == null)
				{
					result = (this._AngularRangeLimits = new TArray<FAngularRangeLimit>(base.NativePtr + (IntPtr)FAnimNode_ApplyLimits.__PropertyOffset_AngularRangeLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AngularRangeLimits.CopyAssign(value);
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x0003CA6F File Offset: 0x0003AC6F
		public TArray<FVector> AngularOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._AngularOffsets) == null)
				{
					result = (this._AngularOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)FAnimNode_ApplyLimits.__PropertyOffset_AngularOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AngularOffsets.CopyAssign(value);
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0003CA7D File Offset: 0x0003AC7D
		public FAnimNode_ApplyLimits()
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0003CA88 File Offset: 0x0003AC88
		public FAnimNode_ApplyLimits(TArray<FAngularRangeLimit> AngularRangeLimits, TArray<FVector> AngularOffsets, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.AngularRangeLimits = AngularRangeLimits;
			this.AngularOffsets = AngularOffsets;
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

		// Token: 0x0600284D RID: 10317 RVA: 0x0003CB10 File Offset: 0x0003AD10
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ApplyLimits.StaticStruct();
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0003CB1C File Offset: 0x0003AD1C
		[NullableContext(2)]
		public FAnimNode_ApplyLimits(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0003CB26 File Offset: 0x0003AD26
		public FAnimNode_ApplyLimits(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0003CB31 File Offset: 0x0003AD31
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ApplyLimits(Pointer, false, true);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0003CB3B File Offset: 0x0003AD3B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ApplyLimits(Pointer, MemoryOwner);
		}

		// Token: 0x04001005 RID: 4101
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ApplyLimits";

		// Token: 0x04001006 RID: 4102
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001007 RID: 4103
		internal static int __PropertyOffset_AngularRangeLimits;

		// Token: 0x04001008 RID: 4104
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAngularRangeLimit> _AngularRangeLimits;

		// Token: 0x04001009 RID: 4105
		internal static int __PropertyOffset_AngularOffsets;

		// Token: 0x0400100A RID: 4106
		[Nullable(2)]
		private TArray<FVector> _AngularOffsets;
	}
}
