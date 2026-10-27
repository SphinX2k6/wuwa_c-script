using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D9 RID: 729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CCDIK")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FAnimNode_CCDIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060028F8 RID: 10488 RVA: 0x0003DCD4 File Offset: 0x0003BED4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CCDIK._ScriptStructPtr != 0) ? FAnimNode_CCDIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CCDIK", ref FAnimNode_CCDIK._ScriptStructPtr);
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		public unsafe FVector EffectorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorLocation) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x0003DD21 File Offset: 0x0003BF21
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0003DD35 File Offset: 0x0003BF35
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> EffectorLocationSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorLocationSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorLocationSpace) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0003DD8F File Offset: 0x0003BF8F
		public FBoneSocketTarget EffectorTarget
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSocketTarget result;
				if ((result = this._EffectorTarget) == null)
				{
					result = (this._EffectorTarget = new FBoneSocketTarget(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSocketTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_EffectorTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0003DDF3 File Offset: 0x0003BFF3
		public FBoneReference TipBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TipBone) == null)
				{
					result = (this._TipBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_TipBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_TipBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x0003DE14 File Offset: 0x0003C014
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x0003DE57 File Offset: 0x0003C057
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x0003DE78 File Offset: 0x0003C078
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x0003DE88 File Offset: 0x0003C088
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0003DE99 File Offset: 0x0003C099
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0003DEA9 File Offset: 0x0003C0A9
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0003DEBA File Offset: 0x0003C0BA
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0003DECA File Offset: 0x0003C0CA
		public unsafe bool bStartFromTail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_bStartFromTail) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_bStartFromTail) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0003DEDB File Offset: 0x0003C0DB
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x0003DEEB File Offset: 0x0003C0EB
		public unsafe bool bEnableRotationLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_bEnableRotationLimit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_bEnableRotationLimit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0003DEFC File Offset: 0x0003C0FC
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x0003DF3F File Offset: 0x0003C13F
		public TArray<float> RotationLimitPerJoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RotationLimitPerJoints) == null)
				{
					result = (this._RotationLimitPerJoints = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_CCDIK.__PropertyOffset_RotationLimitPerJoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimitPerJoints.CopyAssign(value);
			}
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0003DF4D File Offset: 0x0003C14D
		public FAnimNode_CCDIK()
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0003DF58 File Offset: 0x0003C158
		public FAnimNode_CCDIK(FVector EffectorLocation, [Nullable(0)] TEnumAsByte<EBoneControlSpace> EffectorLocationSpace, FBoneSocketTarget EffectorTarget, FBoneReference TipBone, FBoneReference RootBone, float Precision, int MaxIterations, bool bStartFromTail, bool bEnableRotationLimit, TArray<float> RotationLimitPerJoints, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.EffectorLocation = EffectorLocation;
			this.EffectorLocationSpace = EffectorLocationSpace;
			this.EffectorTarget = EffectorTarget;
			this.TipBone = TipBone;
			this.RootBone = RootBone;
			this.Precision = Precision;
			this.MaxIterations = MaxIterations;
			this.bStartFromTail = bStartFromTail;
			this.bEnableRotationLimit = bEnableRotationLimit;
			this.RotationLimitPerJoints = RotationLimitPerJoints;
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

		// Token: 0x0600290F RID: 10511 RVA: 0x0003E020 File Offset: 0x0003C220
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CCDIK.StaticStruct();
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0003E02C File Offset: 0x0003C22C
		[NullableContext(2)]
		public FAnimNode_CCDIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0003E036 File Offset: 0x0003C236
		public FAnimNode_CCDIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0003E041 File Offset: 0x0003C241
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CCDIK(Pointer, false, true);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0003E04B File Offset: 0x0003C24B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CCDIK(Pointer, MemoryOwner);
		}

		// Token: 0x04001061 RID: 4193
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CCDIK";

		// Token: 0x04001062 RID: 4194
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001063 RID: 4195
		internal static int __PropertyOffset_EffectorLocation;

		// Token: 0x04001064 RID: 4196
		internal static int __PropertyOffset_EffectorLocationSpace;

		// Token: 0x04001065 RID: 4197
		internal static int __PropertyOffset_EffectorTarget;

		// Token: 0x04001066 RID: 4198
		[Nullable(2)]
		private FBoneSocketTarget _EffectorTarget;

		// Token: 0x04001067 RID: 4199
		internal static int __PropertyOffset_TipBone;

		// Token: 0x04001068 RID: 4200
		[Nullable(2)]
		private FBoneReference _TipBone;

		// Token: 0x04001069 RID: 4201
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400106A RID: 4202
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x0400106B RID: 4203
		internal static int __PropertyOffset_Precision;

		// Token: 0x0400106C RID: 4204
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x0400106D RID: 4205
		internal static int __PropertyOffset_bStartFromTail;

		// Token: 0x0400106E RID: 4206
		internal static int __PropertyOffset_bEnableRotationLimit;

		// Token: 0x0400106F RID: 4207
		internal static int __PropertyOffset_RotationLimitPerJoints;

		// Token: 0x04001070 RID: 4208
		[Nullable(2)]
		private TArray<float> _RotationLimitPerJoints;
	}
}
