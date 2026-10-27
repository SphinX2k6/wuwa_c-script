using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002E4 RID: 740
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_LegIK")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FAnimNode_LegIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A02 RID: 10754 RVA: 0x0003FB38 File Offset: 0x0003DD38
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LegIK._ScriptStructPtr != 0) ? FAnimNode_LegIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_LegIK", ref FAnimNode_LegIK._ScriptStructPtr);
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0003FB5C File Offset: 0x0003DD5C
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0003FB6C File Offset: 0x0003DD6C
		public unsafe float ReachPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LegIK.__PropertyOffset_ReachPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LegIK.__PropertyOffset_ReachPrecision) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0003FB7D File Offset: 0x0003DD7D
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0003FB8D File Offset: 0x0003DD8D
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LegIK.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LegIK.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0003FBE3 File Offset: 0x0003DDE3
		public TArray<FAnimLegIKDefinition> LegsDefinition
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimLegIKDefinition> result;
				if ((result = this._LegsDefinition) == null)
				{
					result = (this._LegsDefinition = new TArray<FAnimLegIKDefinition>(base.NativePtr + (IntPtr)FAnimNode_LegIK.__PropertyOffset_LegsDefinition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LegsDefinition.CopyAssign(value);
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x0003FBF1 File Offset: 0x0003DDF1
		public FAnimNode_LegIK()
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0003FBFC File Offset: 0x0003DDFC
		public FAnimNode_LegIK(float ReachPrecision, int MaxIterations, TArray<FAnimLegIKDefinition> LegsDefinition, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.ReachPrecision = ReachPrecision;
			this.MaxIterations = MaxIterations;
			this.LegsDefinition = LegsDefinition;
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

		// Token: 0x06002A0B RID: 10763 RVA: 0x0003FC8C File Offset: 0x0003DE8C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LegIK.StaticStruct();
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0003FC98 File Offset: 0x0003DE98
		[NullableContext(2)]
		public FAnimNode_LegIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0003FCA2 File Offset: 0x0003DEA2
		public FAnimNode_LegIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0003FCAD File Offset: 0x0003DEAD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LegIK(Pointer, false, true);
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x0003FCB7 File Offset: 0x0003DEB7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LegIK(Pointer, MemoryOwner);
		}

		// Token: 0x040010F5 RID: 4341
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_LegIK";

		// Token: 0x040010F6 RID: 4342
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010F7 RID: 4343
		internal static int __PropertyOffset_ReachPrecision;

		// Token: 0x040010F8 RID: 4344
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x040010F9 RID: 4345
		internal static int __PropertyOffset_LegsDefinition;

		// Token: 0x040010FA RID: 4346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimLegIKDefinition> _LegsDefinition;
	}
}
