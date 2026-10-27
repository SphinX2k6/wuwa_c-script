using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D6 RID: 726
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FAnimNode_BlendSpaceEvaluator : FAnimNode_BlendSpacePlayer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x0003D26C File Offset: 0x0003B46C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendSpaceEvaluator._ScriptStructPtr != 0) ? FAnimNode_BlendSpaceEvaluator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator", ref FAnimNode_BlendSpaceEvaluator._ScriptStructPtr);
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0003D290 File Offset: 0x0003B490
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x0003D2A0 File Offset: 0x0003B4A0
		public unsafe float NormalizedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpaceEvaluator.__PropertyOffset_NormalizedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpaceEvaluator.__PropertyOffset_NormalizedTime) = value;
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0003D2B1 File Offset: 0x0003B4B1
		public FAnimNode_BlendSpaceEvaluator()
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0003D2BC File Offset: 0x0003B4BC
		[NullableContext(1)]
		public FAnimNode_BlendSpaceEvaluator(float NormalizedTime, float X, float Y, float Z, float PlayRate, bool bLoop, bool bResetPlayTimeWhenBlendSpaceChanges, float StartPosition, UBlendSpaceBase BlendSpace, bool bLockInput, EKuroBlendSpaceLockInputType LockInputType, UBlendSpaceBase PreviousBlendSpace, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.NormalizedTime = NormalizedTime;
			base.X = X;
			base.Y = Y;
			base.Z = Z;
			base.PlayRate = PlayRate;
			base.bLoop = bLoop;
			base.bResetPlayTimeWhenBlendSpaceChanges = bResetPlayTimeWhenBlendSpaceChanges;
			base.StartPosition = StartPosition;
			base.BlendSpace = BlendSpace;
			base.bLockInput = bLockInput;
			base.LockInputType = LockInputType;
			base.PreviousBlendSpace = PreviousBlendSpace;
			base.GroupName = GroupName;
			base.GroupRole = GroupRole;
			base.GroupScope = GroupScope;
			base.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			base.BlendWeight = BlendWeight;
			base.InternalTimeAccumulator = InternalTimeAccumulator;
			base.CachedSequenceLength = CachedSequenceLength;
			base.CachedRateScale = CachedRateScale;
			base.bUseSoftRef = bUseSoftRef;
			base.AnimationName = AnimationName;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0003D37C File Offset: 0x0003B57C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendSpaceEvaluator.StaticStruct();
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0003D388 File Offset: 0x0003B588
		[NullableContext(2)]
		public FAnimNode_BlendSpaceEvaluator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0003D392 File Offset: 0x0003B592
		public FAnimNode_BlendSpaceEvaluator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0003D39D File Offset: 0x0003B59D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendSpaceEvaluator(Pointer, false, true);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0003D3A7 File Offset: 0x0003B5A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendSpaceEvaluator(Pointer, MemoryOwner);
		}

		// Token: 0x0400102D RID: 4141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator";

		// Token: 0x0400102E RID: 4142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400102F RID: 4143
		internal static int __PropertyOffset_NormalizedTime;
	}
}
