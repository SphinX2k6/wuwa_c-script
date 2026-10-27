using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002F6 RID: 758
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ResetRoot")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FAnimNode_ResetRoot : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B37 RID: 11063 RVA: 0x00041BD6 File Offset: 0x0003FDD6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ResetRoot._ScriptStructPtr != 0) ? FAnimNode_ResetRoot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ResetRoot", ref FAnimNode_ResetRoot._ScriptStructPtr);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00041BFA File Offset: 0x0003FDFA
		public FAnimNode_ResetRoot()
		{
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00041C04 File Offset: 0x0003FE04
		[NullableContext(1)]
		public FAnimNode_ResetRoot(FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
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

		// Token: 0x06002B3A RID: 11066 RVA: 0x00041C7C File Offset: 0x0003FE7C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ResetRoot.StaticStruct();
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00041C88 File Offset: 0x0003FE88
		[NullableContext(2)]
		public FAnimNode_ResetRoot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00041C92 File Offset: 0x0003FE92
		public FAnimNode_ResetRoot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00041C9D File Offset: 0x0003FE9D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ResetRoot(Pointer, false, true);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00041CA7 File Offset: 0x0003FEA7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ResetRoot(Pointer, MemoryOwner);
		}

		// Token: 0x0400118E RID: 4494
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ResetRoot";

		// Token: 0x0400118F RID: 4495
		private static IntPtr _ScriptStructPtr;
	}
}
