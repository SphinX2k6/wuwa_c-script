using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EB RID: 747
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_MorphTargetSinglePlayer")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FAnimNode_MorphTargetSinglePlayer : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A85 RID: 10885 RVA: 0x000409BF File Offset: 0x0003EBBF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MorphTargetSinglePlayer._ScriptStructPtr != 0) ? FAnimNode_MorphTargetSinglePlayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_MorphTargetSinglePlayer", ref FAnimNode_MorphTargetSinglePlayer._ScriptStructPtr);
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000409E4 File Offset: 0x0003EBE4
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00040A27 File Offset: 0x0003EC27
		public FPoseLink InputPose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._InputPose) == null)
				{
					result = (this._InputPose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_InputPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_InputPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x00040A48 File Offset: 0x0003EC48
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x00040A58 File Offset: 0x0003EC58
		public unsafe bool bEnableNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_bEnableNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_bEnableNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x00040A69 File Offset: 0x0003EC69
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x00040A79 File Offset: 0x0003EC79
		public unsafe bool bPlayback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_bPlayback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_bPlayback) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x00040A8C File Offset: 0x0003EC8C
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x00040ACF File Offset: 0x0003ECCF
		public TArray<string> MorphTargetsToPlay
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MorphTargetsToPlay) == null)
				{
					result = (this._MorphTargetsToPlay = new TArray<string>(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_MorphTargetsToPlay, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphTargetsToPlay.CopyAssign(value);
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x00040ADD File Offset: 0x0003ECDD
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x00040AED File Offset: 0x0003ECED
		public unsafe float TimeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_TimeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_TimeDuration) = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x00040AFE File Offset: 0x0003ECFE
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x00040B12 File Offset: 0x0003ED12
		public unsafe FVector2D WeightRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_WeightRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MorphTargetSinglePlayer.__PropertyOffset_WeightRange) = value;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00040B27 File Offset: 0x0003ED27
		public FAnimNode_MorphTargetSinglePlayer()
		{
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00040B2F File Offset: 0x0003ED2F
		public FAnimNode_MorphTargetSinglePlayer(FPoseLink InputPose, bool bEnableNode, bool bPlayback, TArray<string> MorphTargetsToPlay, float TimeDuration, FVector2D WeightRange)
		{
			this.InputPose = InputPose;
			this.bEnableNode = bEnableNode;
			this.bPlayback = bPlayback;
			this.MorphTargetsToPlay = MorphTargetsToPlay;
			this.TimeDuration = TimeDuration;
			this.WeightRange = WeightRange;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00040B64 File Offset: 0x0003ED64
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MorphTargetSinglePlayer.StaticStruct();
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00040B70 File Offset: 0x0003ED70
		[NullableContext(2)]
		public FAnimNode_MorphTargetSinglePlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00040B7A File Offset: 0x0003ED7A
		public FAnimNode_MorphTargetSinglePlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x00040B85 File Offset: 0x0003ED85
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MorphTargetSinglePlayer(Pointer, false, true);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00040B8F File Offset: 0x0003ED8F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MorphTargetSinglePlayer(Pointer, MemoryOwner);
		}

		// Token: 0x04001139 RID: 4409
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_MorphTargetSinglePlayer";

		// Token: 0x0400113A RID: 4410
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400113B RID: 4411
		internal static int __PropertyOffset_InputPose;

		// Token: 0x0400113C RID: 4412
		[Nullable(2)]
		private FPoseLink _InputPose;

		// Token: 0x0400113D RID: 4413
		internal static int __PropertyOffset_bEnableNode;

		// Token: 0x0400113E RID: 4414
		internal static int __PropertyOffset_bPlayback;

		// Token: 0x0400113F RID: 4415
		internal static int __PropertyOffset_MorphTargetsToPlay;

		// Token: 0x04001140 RID: 4416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MorphTargetsToPlay;

		// Token: 0x04001141 RID: 4417
		internal static int __PropertyOffset_TimeDuration;

		// Token: 0x04001142 RID: 4418
		internal static int __PropertyOffset_WeightRange;
	}
}
