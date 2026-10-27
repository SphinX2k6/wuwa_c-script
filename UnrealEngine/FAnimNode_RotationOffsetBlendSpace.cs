using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FA RID: 762
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpace")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FAnimNode_RotationOffsetBlendSpace : FAnimNode_BlendSpacePlayer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B93 RID: 11155 RVA: 0x00042684 File Offset: 0x00040884
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RotationOffsetBlendSpace._ScriptStructPtr != 0) ? FAnimNode_RotationOffsetBlendSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpace", ref FAnimNode_RotationOffsetBlendSpace._ScriptStructPtr);
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000426A8 File Offset: 0x000408A8
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x000426EB File Offset: 0x000408EB
		public FPoseLink BasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BasePose) == null)
				{
					result = (this._BasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_BasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_BasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x0004270C File Offset: 0x0004090C
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x0004271C File Offset: 0x0004091C
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x0004272D File Offset: 0x0004092D
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x0004273D File Offset: 0x0004093D
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x00042750 File Offset: 0x00040950
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x00042793 File Offset: 0x00040993
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000427B4 File Offset: 0x000409B4
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x000427F7 File Offset: 0x000409F7
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x00042818 File Offset: 0x00040A18
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x0004282C File Offset: 0x00040A2C
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x00042844 File Offset: 0x00040A44
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x00042887 File Offset: 0x00040A87
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000428A8 File Offset: 0x00040AA8
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x000428B8 File Offset: 0x00040AB8
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000428C9 File Offset: 0x00040AC9
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x000428D9 File Offset: 0x00040AD9
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_bAlphaBoolEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotationOffsetBlendSpace.__PropertyOffset_bAlphaBoolEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000428EA File Offset: 0x00040AEA
		public FAnimNode_RotationOffsetBlendSpace()
		{
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000428F4 File Offset: 0x00040AF4
		public FAnimNode_RotationOffsetBlendSpace(FPoseLink BasePose, int LODThreshold, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, float X, float Y, float Z, float PlayRate, bool bLoop, bool bResetPlayTimeWhenBlendSpaceChanges, float StartPosition, UBlendSpaceBase BlendSpace, bool bLockInput, EKuroBlendSpaceLockInputType LockInputType, UBlendSpaceBase PreviousBlendSpace, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.BasePose = BasePose;
			this.LODThreshold = LODThreshold;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
			this.AlphaInputType = AlphaInputType;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
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

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000429F4 File Offset: 0x00040BF4
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RotationOffsetBlendSpace.StaticStruct();
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00042A00 File Offset: 0x00040C00
		[NullableContext(2)]
		public FAnimNode_RotationOffsetBlendSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00042A0A File Offset: 0x00040C0A
		public FAnimNode_RotationOffsetBlendSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00042A15 File Offset: 0x00040C15
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RotationOffsetBlendSpace(Pointer, false, true);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00042A1F File Offset: 0x00040C1F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RotationOffsetBlendSpace(Pointer, MemoryOwner);
		}

		// Token: 0x040011C0 RID: 4544
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpace";

		// Token: 0x040011C1 RID: 4545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011C2 RID: 4546
		internal static int __PropertyOffset_BasePose;

		// Token: 0x040011C3 RID: 4547
		[Nullable(2)]
		private FPoseLink _BasePose;

		// Token: 0x040011C4 RID: 4548
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x040011C5 RID: 4549
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040011C6 RID: 4550
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x040011C7 RID: 4551
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x040011C8 RID: 4552
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x040011C9 RID: 4553
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x040011CA RID: 4554
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x040011CB RID: 4555
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x040011CC RID: 4556
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;

		// Token: 0x040011CD RID: 4557
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x040011CE RID: 4558
		internal static int __PropertyOffset_bAlphaBoolEnabled;
	}
}
