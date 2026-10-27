using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200161E RID: 5662
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_SightLock")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 592)]
	public class FAnimNode_SightLock : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014770 RID: 83824 RVA: 0x001E19A8 File Offset: 0x001DFBA8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SightLock._ScriptStructPtr != 0) ? FAnimNode_SightLock._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_SightLock", ref FAnimNode_SightLock._ScriptStructPtr);
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x06014771 RID: 83825 RVA: 0x001E19CC File Offset: 0x001DFBCC
		// (set) Token: 0x06014772 RID: 83826 RVA: 0x001E19DC File Offset: 0x001DFBDC
		public unsafe int Increment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_Increment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_Increment) = value;
			}
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x06014773 RID: 83827 RVA: 0x001E19ED File Offset: 0x001DFBED
		// (set) Token: 0x06014774 RID: 83828 RVA: 0x001E19FD File Offset: 0x001DFBFD
		public unsafe SightLockMode Mode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x06014775 RID: 83829 RVA: 0x001E1A0E File Offset: 0x001DFC0E
		// (set) Token: 0x06014776 RID: 83830 RVA: 0x001E1A22 File Offset: 0x001DFC22
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightDirectInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightDirectInSightBone) = value;
			}
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x06014777 RID: 83831 RVA: 0x001E1A37 File Offset: 0x001DFC37
		// (set) Token: 0x06014778 RID: 83832 RVA: 0x001E1A4B File Offset: 0x001DFC4B
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_UpAxisInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_UpAxisInSightBone) = value;
			}
		}

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x06014779 RID: 83833 RVA: 0x001E1A60 File Offset: 0x001DFC60
		// (set) Token: 0x0601477A RID: 83834 RVA: 0x001E1A74 File Offset: 0x001DFC74
		public unsafe FVector SightBoneBaseEuler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneBaseEuler);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneBaseEuler) = value;
			}
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x0601477B RID: 83835 RVA: 0x001E1A89 File Offset: 0x001DFC89
		// (set) Token: 0x0601477C RID: 83836 RVA: 0x001E1A99 File Offset: 0x001DFC99
		public unsafe float AssistRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_AssistRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_AssistRatio) = value;
			}
		}

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x0601477D RID: 83837 RVA: 0x001E1AAC File Offset: 0x001DFCAC
		// (set) Token: 0x0601477E RID: 83838 RVA: 0x001E1AEF File Offset: 0x001DFCEF
		public TArray<float> SightBoneLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._SightBoneLimit) == null)
				{
					result = (this._SightBoneLimit = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SightBoneLimit.CopyAssign(value);
			}
		}

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x0601477F RID: 83839 RVA: 0x001E1AFD File Offset: 0x001DFCFD
		// (set) Token: 0x06014780 RID: 83840 RVA: 0x001E1B0D File Offset: 0x001DFD0D
		public unsafe bool SightBoneLimitOnRefPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneLimitOnRefPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneLimitOnRefPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x06014781 RID: 83841 RVA: 0x001E1B1E File Offset: 0x001DFD1E
		// (set) Token: 0x06014782 RID: 83842 RVA: 0x001E1B2E File Offset: 0x001DFD2E
		public unsafe float AssistLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_AssistLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_AssistLimit) = value;
			}
		}

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x06014783 RID: 83843 RVA: 0x001E1B3F File Offset: 0x001DFD3F
		// (set) Token: 0x06014784 RID: 83844 RVA: 0x001E1B53 File Offset: 0x001DFD53
		public unsafe FVector TargetDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_TargetDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_TargetDirect) = value;
			}
		}

		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x06014785 RID: 83845 RVA: 0x001E1B68 File Offset: 0x001DFD68
		// (set) Token: 0x06014786 RID: 83846 RVA: 0x001E1B7C File Offset: 0x001DFD7C
		public unsafe FName SightBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_SightBoneName) = value;
			}
		}

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x06014787 RID: 83847 RVA: 0x001E1B91 File Offset: 0x001DFD91
		// (set) Token: 0x06014788 RID: 83848 RVA: 0x001E1BA5 File Offset: 0x001DFDA5
		public unsafe FName BeginBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_BeginBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_BeginBoneName) = value;
			}
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x06014789 RID: 83849 RVA: 0x001E1BBA File Offset: 0x001DFDBA
		// (set) Token: 0x0601478A RID: 83850 RVA: 0x001E1BCE File Offset: 0x001DFDCE
		public unsafe FName EndBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_EndBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SightLock.__PropertyOffset_EndBoneName) = value;
			}
		}

		// Token: 0x0601478B RID: 83851 RVA: 0x001E1BE3 File Offset: 0x001DFDE3
		public FAnimNode_SightLock()
		{
		}

		// Token: 0x0601478C RID: 83852 RVA: 0x001E1BEC File Offset: 0x001DFDEC
		public FAnimNode_SightLock(int Increment, SightLockMode Mode, FVector SightDirectInSightBone, FVector UpAxisInSightBone, FVector SightBoneBaseEuler, float AssistRatio, TArray<float> SightBoneLimit, bool SightBoneLimitOnRefPose, float AssistLimit, FVector TargetDirect, FName SightBoneName, FName BeginBoneName, FName EndBoneName, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.Increment = Increment;
			this.Mode = Mode;
			this.SightDirectInSightBone = SightDirectInSightBone;
			this.UpAxisInSightBone = UpAxisInSightBone;
			this.SightBoneBaseEuler = SightBoneBaseEuler;
			this.AssistRatio = AssistRatio;
			this.SightBoneLimit = SightBoneLimit;
			this.SightBoneLimitOnRefPose = SightBoneLimitOnRefPose;
			this.AssistLimit = AssistLimit;
			this.TargetDirect = TargetDirect;
			this.SightBoneName = SightBoneName;
			this.BeginBoneName = BeginBoneName;
			this.EndBoneName = EndBoneName;
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

		// Token: 0x0601478D RID: 83853 RVA: 0x001E1CCC File Offset: 0x001DFECC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SightLock.StaticStruct();
		}

		// Token: 0x0601478E RID: 83854 RVA: 0x001E1CD8 File Offset: 0x001DFED8
		[NullableContext(2)]
		public FAnimNode_SightLock(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601478F RID: 83855 RVA: 0x001E1CE2 File Offset: 0x001DFEE2
		public FAnimNode_SightLock(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014790 RID: 83856 RVA: 0x001E1CED File Offset: 0x001DFEED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SightLock(Pointer, false, true);
		}

		// Token: 0x06014791 RID: 83857 RVA: 0x001E1CF7 File Offset: 0x001DFEF7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SightLock(Pointer, MemoryOwner);
		}

		// Token: 0x0400B21C RID: 45596
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_SightLock";

		// Token: 0x0400B21D RID: 45597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B21E RID: 45598
		internal static int __PropertyOffset_Increment;

		// Token: 0x0400B21F RID: 45599
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400B220 RID: 45600
		internal static int __PropertyOffset_SightDirectInSightBone;

		// Token: 0x0400B221 RID: 45601
		internal static int __PropertyOffset_UpAxisInSightBone;

		// Token: 0x0400B222 RID: 45602
		internal static int __PropertyOffset_SightBoneBaseEuler;

		// Token: 0x0400B223 RID: 45603
		internal static int __PropertyOffset_AssistRatio;

		// Token: 0x0400B224 RID: 45604
		internal static int __PropertyOffset_SightBoneLimit;

		// Token: 0x0400B225 RID: 45605
		[Nullable(2)]
		private TArray<float> _SightBoneLimit;

		// Token: 0x0400B226 RID: 45606
		internal static int __PropertyOffset_SightBoneLimitOnRefPose;

		// Token: 0x0400B227 RID: 45607
		internal static int __PropertyOffset_AssistLimit;

		// Token: 0x0400B228 RID: 45608
		internal static int __PropertyOffset_TargetDirect;

		// Token: 0x0400B229 RID: 45609
		internal static int __PropertyOffset_SightBoneName;

		// Token: 0x0400B22A RID: 45610
		internal static int __PropertyOffset_BeginBoneName;

		// Token: 0x0400B22B RID: 45611
		internal static int __PropertyOffset_EndBoneName;
	}
}
