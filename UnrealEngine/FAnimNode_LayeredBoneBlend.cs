using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E3 RID: 739
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FAnimNode_LayeredBoneBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060029E0 RID: 10720 RVA: 0x0003F790 File Offset: 0x0003D990
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LayeredBoneBlend._ScriptStructPtr != 0) ? FAnimNode_LayeredBoneBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend", ref FAnimNode_LayeredBoneBlend._ScriptStructPtr);
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0003F7B4 File Offset: 0x0003D9B4
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0003F7F7 File Offset: 0x0003D9F7
		public FPoseLink BasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BasePose) == null)
				{
					result = (this._BasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_BasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_BasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0003F818 File Offset: 0x0003DA18
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0003F85B File Offset: 0x0003DA5B
		public TArray<FPoseLink> BlendPoses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseLink> result;
				if ((result = this._BlendPoses) == null)
				{
					result = (this._BlendPoses = new TArray<FPoseLink>(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_BlendPoses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendPoses.CopyAssign(value);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0003F86C File Offset: 0x0003DA6C
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0003F8AF File Offset: 0x0003DAAF
		public TArray<FInputBlendPose> LayerSetup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputBlendPose> result;
				if ((result = this._LayerSetup) == null)
				{
					result = (this._LayerSetup = new TArray<FInputBlendPose>(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_LayerSetup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerSetup.CopyAssign(value);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0003F8C0 File Offset: 0x0003DAC0
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0003F903 File Offset: 0x0003DB03
		public TArray<float> BlendWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BlendWeights) == null)
				{
					result = (this._BlendWeights = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_BlendWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendWeights.CopyAssign(value);
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x0003F911 File Offset: 0x0003DB11
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0003F921 File Offset: 0x0003DB21
		public unsafe bool bMeshSpaceRotationBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bMeshSpaceRotationBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bMeshSpaceRotationBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x0003F932 File Offset: 0x0003DB32
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x0003F942 File Offset: 0x0003DB42
		public unsafe bool bMeshSpaceScaleBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bMeshSpaceScaleBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bMeshSpaceScaleBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x0003F953 File Offset: 0x0003DB53
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x0003F967 File Offset: 0x0003DB67
		[Nullable(0)]
		public unsafe TEnumAsByte<ECurveBlendOption> CurveBlendOption
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_CurveBlendOption);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_CurveBlendOption) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x0003F97C File Offset: 0x0003DB7C
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0003F98C File Offset: 0x0003DB8C
		public unsafe bool bBlendRootMotionBasedOnRootBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bBlendRootMotionBasedOnRootBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bBlendRootMotionBasedOnRootBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x0003F99D File Offset: 0x0003DB9D
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x0003F9AD File Offset: 0x0003DBAD
		public unsafe bool bForceUpdateLinkedPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bForceUpdateLinkedPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_bForceUpdateLinkedPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0003F9BE File Offset: 0x0003DBBE
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0003F9CE File Offset: 0x0003DBCE
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x0003FA23 File Offset: 0x0003DC23
		public TArray<FPerBoneBlendWeight> PerBoneBlendWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerBoneBlendWeight> result;
				if ((result = this._PerBoneBlendWeights) == null)
				{
					result = (this._PerBoneBlendWeights = new TArray<FPerBoneBlendWeight>(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_PerBoneBlendWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PerBoneBlendWeights.CopyAssign(value);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0003FA31 File Offset: 0x0003DC31
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x0003FA45 File Offset: 0x0003DC45
		public unsafe FGuid SkeletonGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_SkeletonGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_SkeletonGuid) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x0003FA5A File Offset: 0x0003DC5A
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0003FA6E File Offset: 0x0003DC6E
		public unsafe FGuid VirtualBoneGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_VirtualBoneGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LayeredBoneBlend.__PropertyOffset_VirtualBoneGuid) = value;
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0003FA83 File Offset: 0x0003DC83
		public FAnimNode_LayeredBoneBlend()
		{
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		public FAnimNode_LayeredBoneBlend(FPoseLink BasePose, TArray<FPoseLink> BlendPoses, TArray<FInputBlendPose> LayerSetup, TArray<float> BlendWeights, bool bMeshSpaceRotationBlend, bool bMeshSpaceScaleBlend, [Nullable(0)] TEnumAsByte<ECurveBlendOption> CurveBlendOption, bool bBlendRootMotionBasedOnRootBone, bool bForceUpdateLinkedPose, int LODThreshold, TArray<FPerBoneBlendWeight> PerBoneBlendWeights, FGuid SkeletonGuid, FGuid VirtualBoneGuid)
		{
			this.BasePose = BasePose;
			this.BlendPoses = BlendPoses;
			this.LayerSetup = LayerSetup;
			this.BlendWeights = BlendWeights;
			this.bMeshSpaceRotationBlend = bMeshSpaceRotationBlend;
			this.bMeshSpaceScaleBlend = bMeshSpaceScaleBlend;
			this.CurveBlendOption = CurveBlendOption;
			this.bBlendRootMotionBasedOnRootBone = bBlendRootMotionBasedOnRootBone;
			this.bForceUpdateLinkedPose = bForceUpdateLinkedPose;
			this.LODThreshold = LODThreshold;
			this.PerBoneBlendWeights = PerBoneBlendWeights;
			this.SkeletonGuid = SkeletonGuid;
			this.VirtualBoneGuid = VirtualBoneGuid;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0003FB04 File Offset: 0x0003DD04
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LayeredBoneBlend.StaticStruct();
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0003FB10 File Offset: 0x0003DD10
		[NullableContext(2)]
		public FAnimNode_LayeredBoneBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0003FB1A File Offset: 0x0003DD1A
		public FAnimNode_LayeredBoneBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0003FB25 File Offset: 0x0003DD25
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LayeredBoneBlend(Pointer, false, true);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0003FB2F File Offset: 0x0003DD2F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LayeredBoneBlend(Pointer, MemoryOwner);
		}

		// Token: 0x040010E1 RID: 4321
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend";

		// Token: 0x040010E2 RID: 4322
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010E3 RID: 4323
		internal static int __PropertyOffset_BasePose;

		// Token: 0x040010E4 RID: 4324
		[Nullable(2)]
		private FPoseLink _BasePose;

		// Token: 0x040010E5 RID: 4325
		internal static int __PropertyOffset_BlendPoses;

		// Token: 0x040010E6 RID: 4326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseLink> _BlendPoses;

		// Token: 0x040010E7 RID: 4327
		internal static int __PropertyOffset_LayerSetup;

		// Token: 0x040010E8 RID: 4328
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputBlendPose> _LayerSetup;

		// Token: 0x040010E9 RID: 4329
		internal static int __PropertyOffset_BlendWeights;

		// Token: 0x040010EA RID: 4330
		[Nullable(2)]
		private TArray<float> _BlendWeights;

		// Token: 0x040010EB RID: 4331
		internal static int __PropertyOffset_bMeshSpaceRotationBlend;

		// Token: 0x040010EC RID: 4332
		internal static int __PropertyOffset_bMeshSpaceScaleBlend;

		// Token: 0x040010ED RID: 4333
		internal static int __PropertyOffset_CurveBlendOption;

		// Token: 0x040010EE RID: 4334
		internal static int __PropertyOffset_bBlendRootMotionBasedOnRootBone;

		// Token: 0x040010EF RID: 4335
		internal static int __PropertyOffset_bForceUpdateLinkedPose;

		// Token: 0x040010F0 RID: 4336
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x040010F1 RID: 4337
		internal static int __PropertyOffset_PerBoneBlendWeights;

		// Token: 0x040010F2 RID: 4338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerBoneBlendWeight> _PerBoneBlendWeights;

		// Token: 0x040010F3 RID: 4339
		internal static int __PropertyOffset_SkeletonGuid;

		// Token: 0x040010F4 RID: 4340
		internal static int __PropertyOffset_VirtualBoneGuid;
	}
}
