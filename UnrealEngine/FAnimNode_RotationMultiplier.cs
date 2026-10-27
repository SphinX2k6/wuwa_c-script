using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F9 RID: 761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RotationMultiplier")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FAnimNode_RotationMultiplier : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B81 RID: 11137 RVA: 0x0004244E File Offset: 0x0004064E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RotationMultiplier._ScriptStructPtr != 0) ? FAnimNode_RotationMultiplier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RotationMultiplier", ref FAnimNode_RotationMultiplier._ScriptStructPtr);
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x00042474 File Offset: 0x00040674
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x000424B7 File Offset: 0x000406B7
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000424D8 File Offset: 0x000406D8
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0004251B File Offset: 0x0004071B
		public FBoneReference SourceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SourceBone) == null)
				{
					result = (this._SourceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_SourceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_SourceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0004253C File Offset: 0x0004073C
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0004254C File Offset: 0x0004074C
		public unsafe float Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0004255D File Offset: 0x0004075D
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x00042571 File Offset: 0x00040771
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneAxis> RotationAxisToRefer
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_RotationAxisToRefer);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_RotationAxisToRefer) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x00042586 File Offset: 0x00040786
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00042596 File Offset: 0x00040796
		public unsafe bool bIsAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_bIsAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationMultiplier.__PropertyOffset_bIsAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000425A7 File Offset: 0x000407A7
		public FAnimNode_RotationMultiplier()
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000425B0 File Offset: 0x000407B0
		public FAnimNode_RotationMultiplier(FBoneReference TargetBone, FBoneReference SourceBone, float Multiplier, [Nullable(0)] TEnumAsByte<EBoneAxis> RotationAxisToRefer, bool bIsAdditive, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.TargetBone = TargetBone;
			this.SourceBone = SourceBone;
			this.Multiplier = Multiplier;
			this.RotationAxisToRefer = RotationAxisToRefer;
			this.bIsAdditive = bIsAdditive;
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

		// Token: 0x06002B8E RID: 11150 RVA: 0x00042650 File Offset: 0x00040850
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RotationMultiplier.StaticStruct();
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0004265C File Offset: 0x0004085C
		[NullableContext(2)]
		public FAnimNode_RotationMultiplier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00042666 File Offset: 0x00040866
		public FAnimNode_RotationMultiplier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00042671 File Offset: 0x00040871
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RotationMultiplier(Pointer, false, true);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x0004267B File Offset: 0x0004087B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RotationMultiplier(Pointer, MemoryOwner);
		}

		// Token: 0x040011B7 RID: 4535
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RotationMultiplier";

		// Token: 0x040011B8 RID: 4536
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011B9 RID: 4537
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x040011BA RID: 4538
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x040011BB RID: 4539
		internal static int __PropertyOffset_SourceBone;

		// Token: 0x040011BC RID: 4540
		[Nullable(2)]
		private FBoneReference _SourceBone;

		// Token: 0x040011BD RID: 4541
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x040011BE RID: 4542
		internal static int __PropertyOffset_RotationAxisToRefer;

		// Token: 0x040011BF RID: 4543
		internal static int __PropertyOffset_bIsAdditive;
	}
}
