using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001617 RID: 5655
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroRotateBonesToTarget")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 656)]
	public class FAnimNode_KuroRotateBonesToTarget : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060146D6 RID: 83670 RVA: 0x001E092C File Offset: 0x001DEB2C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroRotateBonesToTarget._ScriptStructPtr != 0) ? FAnimNode_KuroRotateBonesToTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroRotateBonesToTarget", ref FAnimNode_KuroRotateBonesToTarget._ScriptStructPtr);
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x060146D7 RID: 83671 RVA: 0x001E0950 File Offset: 0x001DEB50
		// (set) Token: 0x060146D8 RID: 83672 RVA: 0x001E0993 File Offset: 0x001DEB93
		public TArray<FKuroRotateBonePart> Parts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRotateBonePart> result;
				if ((result = this._Parts) == null)
				{
					result = (this._Parts = new TArray<FKuroRotateBonePart>(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_Parts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Parts.CopyAssign(value);
			}
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x060146D9 RID: 83673 RVA: 0x001E09A4 File Offset: 0x001DEBA4
		// (set) Token: 0x060146DA RID: 83674 RVA: 0x001E09E7 File Offset: 0x001DEBE7
		public FBoneReference BaseBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BaseBone) == null)
				{
					result = (this._BaseBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x060146DB RID: 83675 RVA: 0x001E0A08 File Offset: 0x001DEC08
		// (set) Token: 0x060146DC RID: 83676 RVA: 0x001E0A1C File Offset: 0x001DEC1C
		public unsafe FVector BaseForwardInBaseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseForwardInBaseBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseForwardInBaseBone) = value;
			}
		}

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x060146DD RID: 83677 RVA: 0x001E0A31 File Offset: 0x001DEC31
		// (set) Token: 0x060146DE RID: 83678 RVA: 0x001E0A45 File Offset: 0x001DEC45
		public unsafe FVector BaseUpInBaseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseUpInBaseBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_BaseUpInBaseBone) = value;
			}
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x060146DF RID: 83679 RVA: 0x001E0A5C File Offset: 0x001DEC5C
		// (set) Token: 0x060146E0 RID: 83680 RVA: 0x001E0A9F File Offset: 0x001DEC9F
		public TMap<string, float> ActivateBoneMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._ActivateBoneMap) == null)
				{
					result = (this._ActivateBoneMap = new TMap<string, float>(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_ActivateBoneMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActivateBoneMap.CopyAssign(value);
			}
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x060146E1 RID: 83681 RVA: 0x001E0AAD File Offset: 0x001DECAD
		// (set) Token: 0x060146E2 RID: 83682 RVA: 0x001E0AC1 File Offset: 0x001DECC1
		public unsafe FVector TargetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_TargetPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_TargetPosition) = value;
			}
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x060146E3 RID: 83683 RVA: 0x001E0AD6 File Offset: 0x001DECD6
		// (set) Token: 0x060146E4 RID: 83684 RVA: 0x001E0AE6 File Offset: 0x001DECE6
		public unsafe bool bDebugLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_bDebugLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRotateBonesToTarget.__PropertyOffset_bDebugLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x060146E5 RID: 83685 RVA: 0x001E0AF7 File Offset: 0x001DECF7
		public FAnimNode_KuroRotateBonesToTarget()
		{
		}

		// Token: 0x060146E6 RID: 83686 RVA: 0x001E0B00 File Offset: 0x001DED00
		public FAnimNode_KuroRotateBonesToTarget(TArray<FKuroRotateBonePart> Parts, FBoneReference BaseBone, FVector BaseForwardInBaseBone, FVector BaseUpInBaseBone, TMap<string, float> ActivateBoneMap, FVector TargetPosition, bool bDebugLog, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.Parts = Parts;
			this.BaseBone = BaseBone;
			this.BaseForwardInBaseBone = BaseForwardInBaseBone;
			this.BaseUpInBaseBone = BaseUpInBaseBone;
			this.ActivateBoneMap = ActivateBoneMap;
			this.TargetPosition = TargetPosition;
			this.bDebugLog = bDebugLog;
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

		// Token: 0x060146E7 RID: 83687 RVA: 0x001E0BB0 File Offset: 0x001DEDB0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroRotateBonesToTarget.StaticStruct();
		}

		// Token: 0x060146E8 RID: 83688 RVA: 0x001E0BBC File Offset: 0x001DEDBC
		[NullableContext(2)]
		public FAnimNode_KuroRotateBonesToTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060146E9 RID: 83689 RVA: 0x001E0BC6 File Offset: 0x001DEDC6
		public FAnimNode_KuroRotateBonesToTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060146EA RID: 83690 RVA: 0x001E0BD1 File Offset: 0x001DEDD1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroRotateBonesToTarget(Pointer, false, true);
		}

		// Token: 0x060146EB RID: 83691 RVA: 0x001E0BDB File Offset: 0x001DEDDB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroRotateBonesToTarget(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1D0 RID: 45520
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroRotateBonesToTarget";

		// Token: 0x0400B1D1 RID: 45521
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1D2 RID: 45522
		internal static int __PropertyOffset_Parts;

		// Token: 0x0400B1D3 RID: 45523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRotateBonePart> _Parts;

		// Token: 0x0400B1D4 RID: 45524
		internal static int __PropertyOffset_BaseBone;

		// Token: 0x0400B1D5 RID: 45525
		[Nullable(2)]
		private FBoneReference _BaseBone;

		// Token: 0x0400B1D6 RID: 45526
		internal static int __PropertyOffset_BaseForwardInBaseBone;

		// Token: 0x0400B1D7 RID: 45527
		internal static int __PropertyOffset_BaseUpInBaseBone;

		// Token: 0x0400B1D8 RID: 45528
		internal static int __PropertyOffset_ActivateBoneMap;

		// Token: 0x0400B1D9 RID: 45529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _ActivateBoneMap;

		// Token: 0x0400B1DA RID: 45530
		internal static int __PropertyOffset_TargetPosition;

		// Token: 0x0400B1DB RID: 45531
		internal static int __PropertyOffset_bDebugLog;
	}
}
