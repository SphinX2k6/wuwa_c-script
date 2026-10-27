using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001618 RID: 5656
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroSlotLayeredBlend")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FAnimNode_KuroSlotLayeredBlend : FAnimNode_Slot, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060146EC RID: 83692 RVA: 0x001E0BE4 File Offset: 0x001DEDE4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroSlotLayeredBlend._ScriptStructPtr != 0) ? FAnimNode_KuroSlotLayeredBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroSlotLayeredBlend", ref FAnimNode_KuroSlotLayeredBlend._ScriptStructPtr);
		}

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x060146ED RID: 83693 RVA: 0x001E0C08 File Offset: 0x001DEE08
		// (set) Token: 0x060146EE RID: 83694 RVA: 0x001E0C4B File Offset: 0x001DEE4B
		public FInputBlendPose LayerSetup
		{
			get
			{
				base.FastCheckIsValid();
				FInputBlendPose result;
				if ((result = this._LayerSetup) == null)
				{
					result = (this._LayerSetup = new FInputBlendPose(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_LayerSetup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputBlendPose.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_LayerSetup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x060146EF RID: 83695 RVA: 0x001E0C6C File Offset: 0x001DEE6C
		// (set) Token: 0x060146F0 RID: 83696 RVA: 0x001E0C7C File Offset: 0x001DEE7C
		public unsafe bool bMeshSpaceRotationBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bMeshSpaceRotationBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bMeshSpaceRotationBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x060146F1 RID: 83697 RVA: 0x001E0C8D File Offset: 0x001DEE8D
		// (set) Token: 0x060146F2 RID: 83698 RVA: 0x001E0C9D File Offset: 0x001DEE9D
		public unsafe bool bMeshSpaceScaleBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bMeshSpaceScaleBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bMeshSpaceScaleBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x060146F3 RID: 83699 RVA: 0x001E0CAE File Offset: 0x001DEEAE
		// (set) Token: 0x060146F4 RID: 83700 RVA: 0x001E0CC2 File Offset: 0x001DEEC2
		[Nullable(0)]
		public unsafe TEnumAsByte<ECurveBlendOption> CurveBlendOption
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_CurveBlendOption);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_CurveBlendOption) = value;
			}
		}

		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x060146F5 RID: 83701 RVA: 0x001E0CD7 File Offset: 0x001DEED7
		// (set) Token: 0x060146F6 RID: 83702 RVA: 0x001E0CE7 File Offset: 0x001DEEE7
		public unsafe bool bBlendRootMotionBasedOnRootBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bBlendRootMotionBasedOnRootBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_bBlendRootMotionBasedOnRootBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x060146F7 RID: 83703 RVA: 0x001E0CF8 File Offset: 0x001DEEF8
		// (set) Token: 0x060146F8 RID: 83704 RVA: 0x001E0D08 File Offset: 0x001DEF08
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x060146F9 RID: 83705 RVA: 0x001E0D1C File Offset: 0x001DEF1C
		// (set) Token: 0x060146FA RID: 83706 RVA: 0x001E0D5F File Offset: 0x001DEF5F
		public TArray<FPerBoneBlendWeight> PerBoneBlendWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerBoneBlendWeight> result;
				if ((result = this._PerBoneBlendWeights) == null)
				{
					result = (this._PerBoneBlendWeights = new TArray<FPerBoneBlendWeight>(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_PerBoneBlendWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PerBoneBlendWeights.CopyAssign(value);
			}
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x060146FB RID: 83707 RVA: 0x001E0D6D File Offset: 0x001DEF6D
		// (set) Token: 0x060146FC RID: 83708 RVA: 0x001E0D81 File Offset: 0x001DEF81
		public unsafe FGuid SkeletonGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_SkeletonGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_SkeletonGuid) = value;
			}
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x060146FD RID: 83709 RVA: 0x001E0D96 File Offset: 0x001DEF96
		// (set) Token: 0x060146FE RID: 83710 RVA: 0x001E0DAA File Offset: 0x001DEFAA
		public unsafe FGuid VirtualBoneGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_VirtualBoneGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroSlotLayeredBlend.__PropertyOffset_VirtualBoneGuid) = value;
			}
		}

		// Token: 0x060146FF RID: 83711 RVA: 0x001E0DBF File Offset: 0x001DEFBF
		public FAnimNode_KuroSlotLayeredBlend()
		{
		}

		// Token: 0x06014700 RID: 83712 RVA: 0x001E0DC8 File Offset: 0x001DEFC8
		public FAnimNode_KuroSlotLayeredBlend(FInputBlendPose LayerSetup, bool bMeshSpaceRotationBlend, bool bMeshSpaceScaleBlend, [Nullable(0)] TEnumAsByte<ECurveBlendOption> CurveBlendOption, bool bBlendRootMotionBasedOnRootBone, int LODThreshold, TArray<FPerBoneBlendWeight> PerBoneBlendWeights, FGuid SkeletonGuid, FGuid VirtualBoneGuid, FPoseLink Source, FName SlotName, bool bAlwaysUpdateSourcePose)
		{
			this.LayerSetup = LayerSetup;
			this.bMeshSpaceRotationBlend = bMeshSpaceRotationBlend;
			this.bMeshSpaceScaleBlend = bMeshSpaceScaleBlend;
			this.CurveBlendOption = CurveBlendOption;
			this.bBlendRootMotionBasedOnRootBone = bBlendRootMotionBasedOnRootBone;
			this.LODThreshold = LODThreshold;
			this.PerBoneBlendWeights = PerBoneBlendWeights;
			this.SkeletonGuid = SkeletonGuid;
			this.VirtualBoneGuid = VirtualBoneGuid;
			base.Source = Source;
			base.SlotName = SlotName;
			base.bAlwaysUpdateSourcePose = bAlwaysUpdateSourcePose;
		}

		// Token: 0x06014701 RID: 83713 RVA: 0x001E0E38 File Offset: 0x001DF038
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroSlotLayeredBlend.StaticStruct();
		}

		// Token: 0x06014702 RID: 83714 RVA: 0x001E0E44 File Offset: 0x001DF044
		[NullableContext(2)]
		public FAnimNode_KuroSlotLayeredBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014703 RID: 83715 RVA: 0x001E0E4E File Offset: 0x001DF04E
		public FAnimNode_KuroSlotLayeredBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014704 RID: 83716 RVA: 0x001E0E59 File Offset: 0x001DF059
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroSlotLayeredBlend(Pointer, false, true);
		}

		// Token: 0x06014705 RID: 83717 RVA: 0x001E0E63 File Offset: 0x001DF063
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroSlotLayeredBlend(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1DC RID: 45532
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroSlotLayeredBlend";

		// Token: 0x0400B1DD RID: 45533
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1DE RID: 45534
		internal static int __PropertyOffset_LayerSetup;

		// Token: 0x0400B1DF RID: 45535
		[Nullable(2)]
		private FInputBlendPose _LayerSetup;

		// Token: 0x0400B1E0 RID: 45536
		internal static int __PropertyOffset_bMeshSpaceRotationBlend;

		// Token: 0x0400B1E1 RID: 45537
		internal static int __PropertyOffset_bMeshSpaceScaleBlend;

		// Token: 0x0400B1E2 RID: 45538
		internal static int __PropertyOffset_CurveBlendOption;

		// Token: 0x0400B1E3 RID: 45539
		internal static int __PropertyOffset_bBlendRootMotionBasedOnRootBone;

		// Token: 0x0400B1E4 RID: 45540
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x0400B1E5 RID: 45541
		internal static int __PropertyOffset_PerBoneBlendWeights;

		// Token: 0x0400B1E6 RID: 45542
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerBoneBlendWeight> _PerBoneBlendWeights;

		// Token: 0x0400B1E7 RID: 45543
		internal static int __PropertyOffset_SkeletonGuid;

		// Token: 0x0400B1E8 RID: 45544
		internal static int __PropertyOffset_VirtualBoneGuid;
	}
}
