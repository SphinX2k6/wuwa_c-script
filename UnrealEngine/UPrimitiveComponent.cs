using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200026F RID: 623
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimitiveComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public abstract class UPrimitiveComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003DBD RID: 15805 RVA: 0x00059029 File Offset: 0x00057229
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrimitiveComponent._ClassPtr;
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x00059035 File Offset: 0x00057235
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x00059045 File Offset: 0x00057245
		public unsafe float MinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MinDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MinDrawDistance) = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x00059056 File Offset: 0x00057256
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x00059066 File Offset: 0x00057266
		public unsafe float LDMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LDMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LDMaxDrawDistance) = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x00059077 File Offset: 0x00057277
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x00059090 File Offset: 0x00057290
		public unsafe bool bVolumeCullingActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVolumeCullingActor) & UPrimitiveComponent.__PropertyMask_bVolumeCullingActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVolumeCullingActor) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVolumeCullingActor) & ~UPrimitiveComponent.__PropertyMask_bVolumeCullingActor) | (value ? UPrimitiveComponent.__PropertyMask_bVolumeCullingActor : 0));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x000590C0 File Offset: 0x000572C0
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x000590D0 File Offset: 0x000572D0
		public unsafe float FOVOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_FOVOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_FOVOverride) = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x000590E1 File Offset: 0x000572E1
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x000590FA File Offset: 0x000572FA
		public unsafe bool bUseKuroOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseKuroOpacity) & UPrimitiveComponent.__PropertyMask_bUseKuroOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseKuroOpacity) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseKuroOpacity) & ~UPrimitiveComponent.__PropertyMask_bUseKuroOpacity) | (value ? UPrimitiveComponent.__PropertyMask_bUseKuroOpacity : 0));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x0005912A File Offset: 0x0005732A
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x0005913A File Offset: 0x0005733A
		public unsafe float KuroOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_KuroOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_KuroOpacity) = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x0005914B File Offset: 0x0005734B
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x00059164 File Offset: 0x00057364
		public unsafe bool bUseMeshBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMeshBlend) & UPrimitiveComponent.__PropertyMask_bUseMeshBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMeshBlend) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMeshBlend) & ~UPrimitiveComponent.__PropertyMask_bUseMeshBlend) | (value ? UPrimitiveComponent.__PropertyMask_bUseMeshBlend : 0));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x00059194 File Offset: 0x00057394
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x000591A4 File Offset: 0x000573A4
		public unsafe byte MeshBlendID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MeshBlendID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MeshBlendID) = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x000591B5 File Offset: 0x000573B5
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x000591C5 File Offset: 0x000573C5
		public unsafe float CachedMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CachedMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CachedMaxDrawDistance) = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x000591D6 File Offset: 0x000573D6
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x000591E6 File Offset: 0x000573E6
		public unsafe float DataDistortionCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_DataDistortionCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_DataDistortionCullRatio) = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x000591F7 File Offset: 0x000573F7
		// (set) Token: 0x06003DD3 RID: 15827 RVA: 0x00059210 File Offset: 0x00057410
		public unsafe bool bUseMaxLODAsImposter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMaxLODAsImposter) & UPrimitiveComponent.__PropertyMask_bUseMaxLODAsImposter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMaxLODAsImposter) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseMaxLODAsImposter) & ~UPrimitiveComponent.__PropertyMask_bUseMaxLODAsImposter) | (value ? UPrimitiveComponent.__PropertyMask_bUseMaxLODAsImposter : 0));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x00059240 File Offset: 0x00057440
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x00059259 File Offset: 0x00057459
		public unsafe bool bIsKuroLandscape
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsKuroLandscape) & UPrimitiveComponent.__PropertyMask_bIsKuroLandscape) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsKuroLandscape) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsKuroLandscape) & ~UPrimitiveComponent.__PropertyMask_bIsKuroLandscape) | (value ? UPrimitiveComponent.__PropertyMask_bIsKuroLandscape : 0));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x00059289 File Offset: 0x00057489
		// (set) Token: 0x06003DD7 RID: 15831 RVA: 0x000592A2 File Offset: 0x000574A2
		public unsafe bool bBatchImpostersAsInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bBatchImpostersAsInstances) & UPrimitiveComponent.__PropertyMask_bBatchImpostersAsInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bBatchImpostersAsInstances) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bBatchImpostersAsInstances) & ~UPrimitiveComponent.__PropertyMask_bBatchImpostersAsInstances) | (value ? UPrimitiveComponent.__PropertyMask_bBatchImpostersAsInstances : 0));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x000592D2 File Offset: 0x000574D2
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x000592EB File Offset: 0x000574EB
		public unsafe bool bNeverDistanceCull
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNeverDistanceCull) & UPrimitiveComponent.__PropertyMask_bNeverDistanceCull) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNeverDistanceCull) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNeverDistanceCull) & ~UPrimitiveComponent.__PropertyMask_bNeverDistanceCull) | (value ? UPrimitiveComponent.__PropertyMask_bNeverDistanceCull : 0));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0005931B File Offset: 0x0005751B
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x00059334 File Offset: 0x00057534
		public unsafe bool bAlwaysCreatePhysicsState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAlwaysCreatePhysicsState) & UPrimitiveComponent.__PropertyMask_bAlwaysCreatePhysicsState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAlwaysCreatePhysicsState) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAlwaysCreatePhysicsState) & ~UPrimitiveComponent.__PropertyMask_bAlwaysCreatePhysicsState) | (value ? UPrimitiveComponent.__PropertyMask_bAlwaysCreatePhysicsState : 0));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x00059364 File Offset: 0x00057564
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x0005937D File Offset: 0x0005757D
		public unsafe bool bKuroPassiveCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollision) & UPrimitiveComponent.__PropertyMask_bKuroPassiveCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollision) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollision) & ~UPrimitiveComponent.__PropertyMask_bKuroPassiveCollision) | (value ? UPrimitiveComponent.__PropertyMask_bKuroPassiveCollision : 0));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x000593AD File Offset: 0x000575AD
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x000593C6 File Offset: 0x000575C6
		public unsafe bool bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) & UPrimitiveComponent.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) & ~UPrimitiveComponent.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) | (value ? UPrimitiveComponent.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap : 0));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x000593F6 File Offset: 0x000575F6
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x0005940F File Offset: 0x0005760F
		public unsafe bool bGenerateOverlapEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bGenerateOverlapEvents) & UPrimitiveComponent.__PropertyMask_bGenerateOverlapEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bGenerateOverlapEvents) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bGenerateOverlapEvents) & ~UPrimitiveComponent.__PropertyMask_bGenerateOverlapEvents) | (value ? UPrimitiveComponent.__PropertyMask_bGenerateOverlapEvents : 0));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0005943F File Offset: 0x0005763F
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x00059458 File Offset: 0x00057658
		public unsafe bool bAsyncOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAsyncOverlap) & UPrimitiveComponent.__PropertyMask_bAsyncOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAsyncOverlap) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAsyncOverlap) & ~UPrimitiveComponent.__PropertyMask_bAsyncOverlap) | (value ? UPrimitiveComponent.__PropertyMask_bAsyncOverlap : 0));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00059488 File Offset: 0x00057688
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x000594A1 File Offset: 0x000576A1
		public unsafe bool bKuroOverlapNotify
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroOverlapNotify) & UPrimitiveComponent.__PropertyMask_bKuroOverlapNotify) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroOverlapNotify) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bKuroOverlapNotify) & ~UPrimitiveComponent.__PropertyMask_bKuroOverlapNotify) | (value ? UPrimitiveComponent.__PropertyMask_bKuroOverlapNotify : 0));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x000594D1 File Offset: 0x000576D1
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x000594EA File Offset: 0x000576EA
		public unsafe bool bReceivedAsyncOverlapResult
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivedAsyncOverlapResult) & UPrimitiveComponent.__PropertyMask_bReceivedAsyncOverlapResult) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivedAsyncOverlapResult) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivedAsyncOverlapResult) & ~UPrimitiveComponent.__PropertyMask_bReceivedAsyncOverlapResult) | (value ? UPrimitiveComponent.__PropertyMask_bReceivedAsyncOverlapResult : 0));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0005951A File Offset: 0x0005771A
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x00059533 File Offset: 0x00057733
		public unsafe bool bMultiBodyOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bMultiBodyOverlap) & UPrimitiveComponent.__PropertyMask_bMultiBodyOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bMultiBodyOverlap) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bMultiBodyOverlap) & ~UPrimitiveComponent.__PropertyMask_bMultiBodyOverlap) | (value ? UPrimitiveComponent.__PropertyMask_bMultiBodyOverlap : 0));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x00059563 File Offset: 0x00057763
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0005957C File Offset: 0x0005777C
		public unsafe bool bTraceComplexOnMove
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTraceComplexOnMove) & UPrimitiveComponent.__PropertyMask_bTraceComplexOnMove) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTraceComplexOnMove) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTraceComplexOnMove) & ~UPrimitiveComponent.__PropertyMask_bTraceComplexOnMove) | (value ? UPrimitiveComponent.__PropertyMask_bTraceComplexOnMove : 0));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x000595AC File Offset: 0x000577AC
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x000595C5 File Offset: 0x000577C5
		public unsafe bool bReturnMaterialOnMove
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReturnMaterialOnMove) & UPrimitiveComponent.__PropertyMask_bReturnMaterialOnMove) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReturnMaterialOnMove) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReturnMaterialOnMove) & ~UPrimitiveComponent.__PropertyMask_bReturnMaterialOnMove) | (value ? UPrimitiveComponent.__PropertyMask_bReturnMaterialOnMove : 0));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x000595F5 File Offset: 0x000577F5
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0005960E File Offset: 0x0005780E
		public unsafe bool bUseViewOwnerDepthPriorityGroup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseViewOwnerDepthPriorityGroup) & UPrimitiveComponent.__PropertyMask_bUseViewOwnerDepthPriorityGroup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseViewOwnerDepthPriorityGroup) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseViewOwnerDepthPriorityGroup) & ~UPrimitiveComponent.__PropertyMask_bUseViewOwnerDepthPriorityGroup) | (value ? UPrimitiveComponent.__PropertyMask_bUseViewOwnerDepthPriorityGroup : 0));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0005963E File Offset: 0x0005783E
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x00059657 File Offset: 0x00057857
		public unsafe bool bAllowCullDistanceVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAllowCullDistanceVolume) & UPrimitiveComponent.__PropertyMask_bAllowCullDistanceVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAllowCullDistanceVolume) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAllowCullDistanceVolume) & ~UPrimitiveComponent.__PropertyMask_bAllowCullDistanceVolume) | (value ? UPrimitiveComponent.__PropertyMask_bAllowCullDistanceVolume : 0));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00059687 File Offset: 0x00057887
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x000596A0 File Offset: 0x000578A0
		public unsafe bool bHasMotionBlurVelocityMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasMotionBlurVelocityMeshes) & UPrimitiveComponent.__PropertyMask_bHasMotionBlurVelocityMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasMotionBlurVelocityMeshes) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasMotionBlurVelocityMeshes) & ~UPrimitiveComponent.__PropertyMask_bHasMotionBlurVelocityMeshes) | (value ? UPrimitiveComponent.__PropertyMask_bHasMotionBlurVelocityMeshes : 0));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x000596D0 File Offset: 0x000578D0
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x000596E9 File Offset: 0x000578E9
		public unsafe bool bVisibleInReflectionCaptures
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInReflectionCaptures) & UPrimitiveComponent.__PropertyMask_bVisibleInReflectionCaptures) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInReflectionCaptures) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInReflectionCaptures) & ~UPrimitiveComponent.__PropertyMask_bVisibleInReflectionCaptures) | (value ? UPrimitiveComponent.__PropertyMask_bVisibleInReflectionCaptures : 0));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00059719 File Offset: 0x00057919
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x00059732 File Offset: 0x00057932
		public unsafe bool bVisibleInRealTimeSkyCaptures
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRealTimeSkyCaptures) & UPrimitiveComponent.__PropertyMask_bVisibleInRealTimeSkyCaptures) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRealTimeSkyCaptures) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRealTimeSkyCaptures) & ~UPrimitiveComponent.__PropertyMask_bVisibleInRealTimeSkyCaptures) | (value ? UPrimitiveComponent.__PropertyMask_bVisibleInRealTimeSkyCaptures : 0));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x00059762 File Offset: 0x00057962
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x0005977B File Offset: 0x0005797B
		public unsafe bool bVisibleInRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRayTracing) & UPrimitiveComponent.__PropertyMask_bVisibleInRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRayTracing) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bVisibleInRayTracing) & ~UPrimitiveComponent.__PropertyMask_bVisibleInRayTracing) | (value ? UPrimitiveComponent.__PropertyMask_bVisibleInRayTracing : 0));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x000597AB File Offset: 0x000579AB
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x000597C4 File Offset: 0x000579C4
		public unsafe bool bForceVisibleInKuroRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceVisibleInKuroRayTracing) & UPrimitiveComponent.__PropertyMask_bForceVisibleInKuroRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceVisibleInKuroRayTracing) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceVisibleInKuroRayTracing) & ~UPrimitiveComponent.__PropertyMask_bForceVisibleInKuroRayTracing) | (value ? UPrimitiveComponent.__PropertyMask_bForceVisibleInKuroRayTracing : 0));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x000597F4 File Offset: 0x000579F4
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x0005980D File Offset: 0x00057A0D
		public unsafe bool bRenderInMainPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInMainPass) & UPrimitiveComponent.__PropertyMask_bRenderInMainPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInMainPass) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInMainPass) & ~UPrimitiveComponent.__PropertyMask_bRenderInMainPass) | (value ? UPrimitiveComponent.__PropertyMask_bRenderInMainPass : 0));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x0005983D File Offset: 0x00057A3D
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x00059856 File Offset: 0x00057A56
		public unsafe bool bRenderInDepthPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDepthPass) & UPrimitiveComponent.__PropertyMask_bRenderInDepthPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDepthPass) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDepthPass) & ~UPrimitiveComponent.__PropertyMask_bRenderInDepthPass) | (value ? UPrimitiveComponent.__PropertyMask_bRenderInDepthPass : 0));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x00059886 File Offset: 0x00057A86
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x0005989F File Offset: 0x00057A9F
		public unsafe bool bForceOpaqueInPreZ_PC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceOpaqueInPreZ_PC) & UPrimitiveComponent.__PropertyMask_bForceOpaqueInPreZ_PC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceOpaqueInPreZ_PC) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceOpaqueInPreZ_PC) & ~UPrimitiveComponent.__PropertyMask_bForceOpaqueInPreZ_PC) | (value ? UPrimitiveComponent.__PropertyMask_bForceOpaqueInPreZ_PC : 0));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x000598CF File Offset: 0x00057ACF
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x000598E8 File Offset: 0x00057AE8
		public unsafe bool bRenderInCustomCapturePass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInCustomCapturePass) & UPrimitiveComponent.__PropertyMask_bRenderInCustomCapturePass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInCustomCapturePass) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInCustomCapturePass) & ~UPrimitiveComponent.__PropertyMask_bRenderInCustomCapturePass) | (value ? UPrimitiveComponent.__PropertyMask_bRenderInCustomCapturePass : 0));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00059918 File Offset: 0x00057B18
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00059931 File Offset: 0x00057B31
		public unsafe bool bRenderInDataDistortionPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDataDistortionPass) & UPrimitiveComponent.__PropertyMask_bRenderInDataDistortionPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDataDistortionPass) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInDataDistortionPass) & ~UPrimitiveComponent.__PropertyMask_bRenderInDataDistortionPass) | (value ? UPrimitiveComponent.__PropertyMask_bRenderInDataDistortionPass : 0));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00059961 File Offset: 0x00057B61
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0005997A File Offset: 0x00057B7A
		public unsafe bool bOnlyVisibleInSceneCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyVisibleInSceneCapture) & UPrimitiveComponent.__PropertyMask_bOnlyVisibleInSceneCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyVisibleInSceneCapture) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyVisibleInSceneCapture) & ~UPrimitiveComponent.__PropertyMask_bOnlyVisibleInSceneCapture) | (value ? UPrimitiveComponent.__PropertyMask_bOnlyVisibleInSceneCapture : 0));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x000599AA File Offset: 0x00057BAA
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x000599C3 File Offset: 0x00057BC3
		public unsafe bool bUseCustomWPO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseCustomWPO) & UPrimitiveComponent.__PropertyMask_bUseCustomWPO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseCustomWPO) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseCustomWPO) & ~UPrimitiveComponent.__PropertyMask_bUseCustomWPO) | (value ? UPrimitiveComponent.__PropertyMask_bUseCustomWPO : 0));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x000599F3 File Offset: 0x00057BF3
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x00059A0C File Offset: 0x00057C0C
		public unsafe bool bEnablePlanarReflectionRenderOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bEnablePlanarReflectionRenderOffset) & UPrimitiveComponent.__PropertyMask_bEnablePlanarReflectionRenderOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bEnablePlanarReflectionRenderOffset) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bEnablePlanarReflectionRenderOffset) & ~UPrimitiveComponent.__PropertyMask_bEnablePlanarReflectionRenderOffset) | (value ? UPrimitiveComponent.__PropertyMask_bEnablePlanarReflectionRenderOffset : 0));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x00059A3C File Offset: 0x00057C3C
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x00059A50 File Offset: 0x00057C50
		public unsafe FVector PlanarReflectionRenderOffsetWS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_PlanarReflectionRenderOffsetWS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_PlanarReflectionRenderOffsetWS) = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x00059A65 File Offset: 0x00057C65
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x00059A75 File Offset: 0x00057C75
		public unsafe byte CustomCullFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomCullFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomCullFlag) = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x00059A86 File Offset: 0x00057C86
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x00059A9F File Offset: 0x00057C9F
		public unsafe bool bReceivesDecals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivesDecals) & UPrimitiveComponent.__PropertyMask_bReceivesDecals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivesDecals) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceivesDecals) & ~UPrimitiveComponent.__PropertyMask_bReceivesDecals) | (value ? UPrimitiveComponent.__PropertyMask_bReceivesDecals : 0));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x00059ACF File Offset: 0x00057CCF
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x00059AE8 File Offset: 0x00057CE8
		public unsafe bool bOwnerNoSee
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOwnerNoSee) & UPrimitiveComponent.__PropertyMask_bOwnerNoSee) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOwnerNoSee) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOwnerNoSee) & ~UPrimitiveComponent.__PropertyMask_bOwnerNoSee) | (value ? UPrimitiveComponent.__PropertyMask_bOwnerNoSee : 0));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x00059B18 File Offset: 0x00057D18
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x00059B31 File Offset: 0x00057D31
		public unsafe bool bOnlyOwnerSee
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyOwnerSee) & UPrimitiveComponent.__PropertyMask_bOnlyOwnerSee) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyOwnerSee) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOnlyOwnerSee) & ~UPrimitiveComponent.__PropertyMask_bOnlyOwnerSee) | (value ? UPrimitiveComponent.__PropertyMask_bOnlyOwnerSee : 0));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x00059B61 File Offset: 0x00057D61
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x00059B7A File Offset: 0x00057D7A
		public unsafe bool bTreatAsBackgroundForOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTreatAsBackgroundForOcclusion) & UPrimitiveComponent.__PropertyMask_bTreatAsBackgroundForOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTreatAsBackgroundForOcclusion) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bTreatAsBackgroundForOcclusion) & ~UPrimitiveComponent.__PropertyMask_bTreatAsBackgroundForOcclusion) | (value ? UPrimitiveComponent.__PropertyMask_bTreatAsBackgroundForOcclusion : 0));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x00059BAA File Offset: 0x00057DAA
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00059BC3 File Offset: 0x00057DC3
		public unsafe bool bUseAsOccluder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseAsOccluder) & UPrimitiveComponent.__PropertyMask_bUseAsOccluder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseAsOccluder) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseAsOccluder) & ~UPrimitiveComponent.__PropertyMask_bUseAsOccluder) | (value ? UPrimitiveComponent.__PropertyMask_bUseAsOccluder : 0));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00059BF3 File Offset: 0x00057DF3
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x00059C0C File Offset: 0x00057E0C
		public unsafe bool bSelectable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelectable) & UPrimitiveComponent.__PropertyMask_bSelectable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelectable) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelectable) & ~UPrimitiveComponent.__PropertyMask_bSelectable) | (value ? UPrimitiveComponent.__PropertyMask_bSelectable : 0));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x00059C3C File Offset: 0x00057E3C
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00059C55 File Offset: 0x00057E55
		public unsafe bool bForceMipStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceMipStreaming) & UPrimitiveComponent.__PropertyMask_bForceMipStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceMipStreaming) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceMipStreaming) & ~UPrimitiveComponent.__PropertyMask_bForceMipStreaming) | (value ? UPrimitiveComponent.__PropertyMask_bForceMipStreaming : 0));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00059C85 File Offset: 0x00057E85
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00059C9E File Offset: 0x00057E9E
		public unsafe bool bHasPerInstanceHitProxies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasPerInstanceHitProxies) & UPrimitiveComponent.__PropertyMask_bHasPerInstanceHitProxies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasPerInstanceHitProxies) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasPerInstanceHitProxies) & ~UPrimitiveComponent.__PropertyMask_bHasPerInstanceHitProxies) | (value ? UPrimitiveComponent.__PropertyMask_bHasPerInstanceHitProxies : 0));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00059CCE File Offset: 0x00057ECE
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00059CE7 File Offset: 0x00057EE7
		public unsafe bool CastShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastShadow) & UPrimitiveComponent.__PropertyMask_CastShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastShadow) & ~UPrimitiveComponent.__PropertyMask_CastShadow) | (value ? UPrimitiveComponent.__PropertyMask_CastShadow : 0));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00059D17 File Offset: 0x00057F17
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x00059D30 File Offset: 0x00057F30
		public unsafe bool ForceCastShadowInRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ForceCastShadowInRayTracing) & UPrimitiveComponent.__PropertyMask_ForceCastShadowInRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ForceCastShadowInRayTracing) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ForceCastShadowInRayTracing) & ~UPrimitiveComponent.__PropertyMask_ForceCastShadowInRayTracing) | (value ? UPrimitiveComponent.__PropertyMask_ForceCastShadowInRayTracing : 0));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x00059D60 File Offset: 0x00057F60
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x00059D79 File Offset: 0x00057F79
		public unsafe bool CastRasterShadowInRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastRasterShadowInRayTracing) & UPrimitiveComponent.__PropertyMask_CastRasterShadowInRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastRasterShadowInRayTracing) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CastRasterShadowInRayTracing) & ~UPrimitiveComponent.__PropertyMask_CastRasterShadowInRayTracing) | (value ? UPrimitiveComponent.__PropertyMask_CastRasterShadowInRayTracing : 0));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00059DA9 File Offset: 0x00057FA9
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x00059DC2 File Offset: 0x00057FC2
		public unsafe bool MobileCastShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileCastShadow) & UPrimitiveComponent.__PropertyMask_MobileCastShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileCastShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileCastShadow) & ~UPrimitiveComponent.__PropertyMask_MobileCastShadow) | (value ? UPrimitiveComponent.__PropertyMask_MobileCastShadow : 0));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x00059DF2 File Offset: 0x00057FF2
		// (set) Token: 0x06003E29 RID: 15913 RVA: 0x00059E0B File Offset: 0x0005800B
		public unsafe bool IsSpecialForLocalLightShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsSpecialForLocalLightShadow) & UPrimitiveComponent.__PropertyMask_IsSpecialForLocalLightShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsSpecialForLocalLightShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsSpecialForLocalLightShadow) & ~UPrimitiveComponent.__PropertyMask_IsSpecialForLocalLightShadow) | (value ? UPrimitiveComponent.__PropertyMask_IsSpecialForLocalLightShadow : 0));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x00059E3B File Offset: 0x0005803B
		// (set) Token: 0x06003E2B RID: 15915 RVA: 0x00059E54 File Offset: 0x00058054
		public unsafe bool IsUIScenePrimitive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsUIScenePrimitive) & UPrimitiveComponent.__PropertyMask_IsUIScenePrimitive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsUIScenePrimitive) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsUIScenePrimitive) & ~UPrimitiveComponent.__PropertyMask_IsUIScenePrimitive) | (value ? UPrimitiveComponent.__PropertyMask_IsUIScenePrimitive : 0));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x00059E84 File Offset: 0x00058084
		// (set) Token: 0x06003E2D RID: 15917 RVA: 0x00059E9D File Offset: 0x0005809D
		public unsafe bool IsHiddenInUiSceneState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsHiddenInUiSceneState) & UPrimitiveComponent.__PropertyMask_IsHiddenInUiSceneState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsHiddenInUiSceneState) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IsHiddenInUiSceneState) & ~UPrimitiveComponent.__PropertyMask_IsHiddenInUiSceneState) | (value ? UPrimitiveComponent.__PropertyMask_IsHiddenInUiSceneState : 0));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003E2E RID: 15918 RVA: 0x00059ECD File Offset: 0x000580CD
		// (set) Token: 0x06003E2F RID: 15919 RVA: 0x00059EE6 File Offset: 0x000580E6
		public unsafe bool bSceneDissolveActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneDissolveActive) & UPrimitiveComponent.__PropertyMask_bSceneDissolveActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneDissolveActive) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneDissolveActive) & ~UPrimitiveComponent.__PropertyMask_bSceneDissolveActive) | (value ? UPrimitiveComponent.__PropertyMask_bSceneDissolveActive : 0));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x00059F16 File Offset: 0x00058116
		// (set) Token: 0x06003E31 RID: 15921 RVA: 0x00059F2F File Offset: 0x0005812F
		public unsafe bool bSceneColorClearActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneColorClearActive) & UPrimitiveComponent.__PropertyMask_bSceneColorClearActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneColorClearActive) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSceneColorClearActive) & ~UPrimitiveComponent.__PropertyMask_bSceneColorClearActive) | (value ? UPrimitiveComponent.__PropertyMask_bSceneColorClearActive : 0));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x00059F5F File Offset: 0x0005815F
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x00059F78 File Offset: 0x00058178
		public unsafe bool bIsLGUIBeforeUpScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeUpScale) & UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeUpScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeUpScale) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeUpScale) & ~UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeUpScale) | (value ? UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeUpScale : 0));
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x00059FA8 File Offset: 0x000581A8
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x00059FC1 File Offset: 0x000581C1
		public unsafe bool bIsLGUIAfterBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIAfterBlur) & UPrimitiveComponent.__PropertyMask_bIsLGUIAfterBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIAfterBlur) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIAfterBlur) & ~UPrimitiveComponent.__PropertyMask_bIsLGUIAfterBlur) | (value ? UPrimitiveComponent.__PropertyMask_bIsLGUIAfterBlur : 0));
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x00059FF1 File Offset: 0x000581F1
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x0005A00A File Offset: 0x0005820A
		public unsafe bool bIsLGUIBeforeBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeBloom) & UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeBloom) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIBeforeBloom) & ~UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeBloom) | (value ? UPrimitiveComponent.__PropertyMask_bIsLGUIBeforeBloom : 0));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x0005A03A File Offset: 0x0005823A
		// (set) Token: 0x06003E39 RID: 15929 RVA: 0x0005A053 File Offset: 0x00058253
		public unsafe bool bIsLGUIRenderAsMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIRenderAsMask) & UPrimitiveComponent.__PropertyMask_bIsLGUIRenderAsMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIRenderAsMask) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIRenderAsMask) & ~UPrimitiveComponent.__PropertyMask_bIsLGUIRenderAsMask) | (value ? UPrimitiveComponent.__PropertyMask_bIsLGUIRenderAsMask : 0));
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x0005A083 File Offset: 0x00058283
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x0005A09C File Offset: 0x0005829C
		public unsafe bool bIsLGUIReadMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIReadMask) & UPrimitiveComponent.__PropertyMask_bIsLGUIReadMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIReadMask) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIsLGUIReadMask) & ~UPrimitiveComponent.__PropertyMask_bIsLGUIReadMask) | (value ? UPrimitiveComponent.__PropertyMask_bIsLGUIReadMask : 0));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x0005A0CC File Offset: 0x000582CC
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x0005A0E5 File Offset: 0x000582E5
		public unsafe bool bForbidCastToonShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForbidCastToonShadow) & UPrimitiveComponent.__PropertyMask_bForbidCastToonShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForbidCastToonShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForbidCastToonShadow) & ~UPrimitiveComponent.__PropertyMask_bForbidCastToonShadow) | (value ? UPrimitiveComponent.__PropertyMask_bForbidCastToonShadow : 0));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x0005A115 File Offset: 0x00058315
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x0005A12E File Offset: 0x0005832E
		public unsafe bool bCastShadowWhenInCaveOrIndoor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowWhenInCaveOrIndoor) & UPrimitiveComponent.__PropertyMask_bCastShadowWhenInCaveOrIndoor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowWhenInCaveOrIndoor) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowWhenInCaveOrIndoor) & ~UPrimitiveComponent.__PropertyMask_bCastShadowWhenInCaveOrIndoor) | (value ? UPrimitiveComponent.__PropertyMask_bCastShadowWhenInCaveOrIndoor : 0));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x0005A15E File Offset: 0x0005835E
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x0005A177 File Offset: 0x00058377
		public unsafe bool bCastShadowInShadowCullVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowInShadowCullVolume) & UPrimitiveComponent.__PropertyMask_bCastShadowInShadowCullVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowInShadowCullVolume) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowInShadowCullVolume) & ~UPrimitiveComponent.__PropertyMask_bCastShadowInShadowCullVolume) | (value ? UPrimitiveComponent.__PropertyMask_bCastShadowInShadowCullVolume : 0));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x0005A1A7 File Offset: 0x000583A7
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x0005A1C0 File Offset: 0x000583C0
		public unsafe bool bRenderKuroTrail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderKuroTrail) & UPrimitiveComponent.__PropertyMask_bRenderKuroTrail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderKuroTrail) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderKuroTrail) & ~UPrimitiveComponent.__PropertyMask_bRenderKuroTrail) | (value ? UPrimitiveComponent.__PropertyMask_bRenderKuroTrail : 0));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x0005A1F0 File Offset: 0x000583F0
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x0005A209 File Offset: 0x00058409
		public unsafe bool bRenderHLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderHLOD) & UPrimitiveComponent.__PropertyMask_bRenderHLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderHLOD) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderHLOD) & ~UPrimitiveComponent.__PropertyMask_bRenderHLOD) | (value ? UPrimitiveComponent.__PropertyMask_bRenderHLOD : 0));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x0005A239 File Offset: 0x00058439
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x0005A252 File Offset: 0x00058452
		public unsafe bool bOverride_RenderInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOverride_RenderInBurst) & UPrimitiveComponent.__PropertyMask_bOverride_RenderInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOverride_RenderInBurst) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bOverride_RenderInBurst) & ~UPrimitiveComponent.__PropertyMask_bOverride_RenderInBurst) | (value ? UPrimitiveComponent.__PropertyMask_bOverride_RenderInBurst : 0));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0005A282 File Offset: 0x00058482
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x0005A29B File Offset: 0x0005849B
		public unsafe bool bRenderInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInBurst) & UPrimitiveComponent.__PropertyMask_bRenderInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInBurst) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderInBurst) & ~UPrimitiveComponent.__PropertyMask_bRenderInBurst) | (value ? UPrimitiveComponent.__PropertyMask_bRenderInBurst : 0));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x0005A2CB File Offset: 0x000584CB
		// (set) Token: 0x06003E4B RID: 15947 RVA: 0x0005A2E4 File Offset: 0x000584E4
		public unsafe bool bNoVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNoVelocity) & UPrimitiveComponent.__PropertyMask_bNoVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNoVelocity) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bNoVelocity) & ~UPrimitiveComponent.__PropertyMask_bNoVelocity) | (value ? UPrimitiveComponent.__PropertyMask_bNoVelocity : 0));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x0005A314 File Offset: 0x00058514
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x0005A32D File Offset: 0x0005852D
		public unsafe bool bAffectDynamicIndirectLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDynamicIndirectLighting) & UPrimitiveComponent.__PropertyMask_bAffectDynamicIndirectLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDynamicIndirectLighting) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDynamicIndirectLighting) & ~UPrimitiveComponent.__PropertyMask_bAffectDynamicIndirectLighting) | (value ? UPrimitiveComponent.__PropertyMask_bAffectDynamicIndirectLighting : 0));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x0005A35D File Offset: 0x0005855D
		// (set) Token: 0x06003E4F RID: 15951 RVA: 0x0005A376 File Offset: 0x00058576
		public unsafe bool bAffectDistanceFieldLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDistanceFieldLighting) & UPrimitiveComponent.__PropertyMask_bAffectDistanceFieldLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDistanceFieldLighting) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bAffectDistanceFieldLighting) & ~UPrimitiveComponent.__PropertyMask_bAffectDistanceFieldLighting) | (value ? UPrimitiveComponent.__PropertyMask_bAffectDistanceFieldLighting : 0));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003E50 RID: 15952 RVA: 0x0005A3A6 File Offset: 0x000585A6
		// (set) Token: 0x06003E51 RID: 15953 RVA: 0x0005A3BF File Offset: 0x000585BF
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastDynamicShadow) & UPrimitiveComponent.__PropertyMask_bCastDynamicShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastDynamicShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastDynamicShadow) & ~UPrimitiveComponent.__PropertyMask_bCastDynamicShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastDynamicShadow : 0));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x0005A3EF File Offset: 0x000585EF
		// (set) Token: 0x06003E53 RID: 15955 RVA: 0x0005A408 File Offset: 0x00058608
		public unsafe bool bForceCastRaytracingShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceCastRaytracingShadow) & UPrimitiveComponent.__PropertyMask_bForceCastRaytracingShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceCastRaytracingShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bForceCastRaytracingShadow) & ~UPrimitiveComponent.__PropertyMask_bForceCastRaytracingShadow) | (value ? UPrimitiveComponent.__PropertyMask_bForceCastRaytracingShadow : 0));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x0005A438 File Offset: 0x00058638
		// (set) Token: 0x06003E55 RID: 15957 RVA: 0x0005A451 File Offset: 0x00058651
		public unsafe bool bCastStaticShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastStaticShadow) & UPrimitiveComponent.__PropertyMask_bCastStaticShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastStaticShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastStaticShadow) & ~UPrimitiveComponent.__PropertyMask_bCastStaticShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastStaticShadow : 0));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003E56 RID: 15958 RVA: 0x0005A481 File Offset: 0x00058681
		// (set) Token: 0x06003E57 RID: 15959 RVA: 0x0005A49A File Offset: 0x0005869A
		public unsafe bool bCastVolumetricTranslucentShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastVolumetricTranslucentShadow) & UPrimitiveComponent.__PropertyMask_bCastVolumetricTranslucentShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastVolumetricTranslucentShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastVolumetricTranslucentShadow) & ~UPrimitiveComponent.__PropertyMask_bCastVolumetricTranslucentShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastVolumetricTranslucentShadow : 0));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x0005A4CA File Offset: 0x000586CA
		// (set) Token: 0x06003E59 RID: 15961 RVA: 0x0005A4E3 File Offset: 0x000586E3
		public unsafe bool bCastContactShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastContactShadow) & UPrimitiveComponent.__PropertyMask_bCastContactShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastContactShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastContactShadow) & ~UPrimitiveComponent.__PropertyMask_bCastContactShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastContactShadow : 0));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x0005A513 File Offset: 0x00058713
		// (set) Token: 0x06003E5B RID: 15963 RVA: 0x0005A52C File Offset: 0x0005872C
		public unsafe bool bSelfShadowOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelfShadowOnly) & UPrimitiveComponent.__PropertyMask_bSelfShadowOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelfShadowOnly) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSelfShadowOnly) & ~UPrimitiveComponent.__PropertyMask_bSelfShadowOnly) | (value ? UPrimitiveComponent.__PropertyMask_bSelfShadowOnly : 0));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x0005A55C File Offset: 0x0005875C
		// (set) Token: 0x06003E5D RID: 15965 RVA: 0x0005A575 File Offset: 0x00058775
		public unsafe bool bCastFarShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadow) & UPrimitiveComponent.__PropertyMask_bCastFarShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadow) & ~UPrimitiveComponent.__PropertyMask_bCastFarShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastFarShadow : 0));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x0005A5A5 File Offset: 0x000587A5
		// (set) Token: 0x06003E5F RID: 15967 RVA: 0x0005A5BE File Offset: 0x000587BE
		public unsafe bool bCastFarShadowOnMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadowOnMobile) & UPrimitiveComponent.__PropertyMask_bCastFarShadowOnMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadowOnMobile) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastFarShadowOnMobile) & ~UPrimitiveComponent.__PropertyMask_bCastFarShadowOnMobile) | (value ? UPrimitiveComponent.__PropertyMask_bCastFarShadowOnMobile : 0));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x0005A5EE File Offset: 0x000587EE
		// (set) Token: 0x06003E61 RID: 15969 RVA: 0x0005A607 File Offset: 0x00058807
		public unsafe bool bCastInsetShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastInsetShadow) & UPrimitiveComponent.__PropertyMask_bCastInsetShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastInsetShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastInsetShadow) & ~UPrimitiveComponent.__PropertyMask_bCastInsetShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastInsetShadow : 0));
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x0005A637 File Offset: 0x00058837
		// (set) Token: 0x06003E63 RID: 15971 RVA: 0x0005A650 File Offset: 0x00058850
		public unsafe bool bCastCinematicShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastCinematicShadow) & UPrimitiveComponent.__PropertyMask_bCastCinematicShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastCinematicShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastCinematicShadow) & ~UPrimitiveComponent.__PropertyMask_bCastCinematicShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastCinematicShadow : 0));
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x0005A680 File Offset: 0x00058880
		// (set) Token: 0x06003E65 RID: 15973 RVA: 0x0005A699 File Offset: 0x00058899
		public unsafe bool bCastHiddenShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastHiddenShadow) & UPrimitiveComponent.__PropertyMask_bCastHiddenShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastHiddenShadow) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastHiddenShadow) & ~UPrimitiveComponent.__PropertyMask_bCastHiddenShadow) | (value ? UPrimitiveComponent.__PropertyMask_bCastHiddenShadow : 0));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x0005A6C9 File Offset: 0x000588C9
		// (set) Token: 0x06003E67 RID: 15975 RVA: 0x0005A6E2 File Offset: 0x000588E2
		public unsafe bool bCastShadowAsTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowAsTwoSided) & UPrimitiveComponent.__PropertyMask_bCastShadowAsTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowAsTwoSided) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCastShadowAsTwoSided) & ~UPrimitiveComponent.__PropertyMask_bCastShadowAsTwoSided) | (value ? UPrimitiveComponent.__PropertyMask_bCastShadowAsTwoSided : 0));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003E68 RID: 15976 RVA: 0x0005A712 File Offset: 0x00058912
		// (set) Token: 0x06003E69 RID: 15977 RVA: 0x0005A72B File Offset: 0x0005892B
		public unsafe bool bLightAsIfStatic_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAsIfStatic_DEPRECATED) & UPrimitiveComponent.__PropertyMask_bLightAsIfStatic_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAsIfStatic_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAsIfStatic_DEPRECATED) & ~UPrimitiveComponent.__PropertyMask_bLightAsIfStatic_DEPRECATED) | (value ? UPrimitiveComponent.__PropertyMask_bLightAsIfStatic_DEPRECATED : 0));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003E6A RID: 15978 RVA: 0x0005A75B File Offset: 0x0005895B
		// (set) Token: 0x06003E6B RID: 15979 RVA: 0x0005A774 File Offset: 0x00058974
		public unsafe bool bLightAttachmentsAsGroup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAttachmentsAsGroup) & UPrimitiveComponent.__PropertyMask_bLightAttachmentsAsGroup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAttachmentsAsGroup) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bLightAttachmentsAsGroup) & ~UPrimitiveComponent.__PropertyMask_bLightAttachmentsAsGroup) | (value ? UPrimitiveComponent.__PropertyMask_bLightAttachmentsAsGroup : 0));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x0005A7A4 File Offset: 0x000589A4
		// (set) Token: 0x06003E6D RID: 15981 RVA: 0x0005A7BD File Offset: 0x000589BD
		public unsafe bool bExcludeFromLightAttachmentGroup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bExcludeFromLightAttachmentGroup) & UPrimitiveComponent.__PropertyMask_bExcludeFromLightAttachmentGroup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bExcludeFromLightAttachmentGroup) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bExcludeFromLightAttachmentGroup) & ~UPrimitiveComponent.__PropertyMask_bExcludeFromLightAttachmentGroup) | (value ? UPrimitiveComponent.__PropertyMask_bExcludeFromLightAttachmentGroup : 0));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x0005A7ED File Offset: 0x000589ED
		// (set) Token: 0x06003E6F RID: 15983 RVA: 0x0005A806 File Offset: 0x00058A06
		public unsafe bool bReceiveMobileCSMShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceiveMobileCSMShadows) & UPrimitiveComponent.__PropertyMask_bReceiveMobileCSMShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceiveMobileCSMShadows) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReceiveMobileCSMShadows) & ~UPrimitiveComponent.__PropertyMask_bReceiveMobileCSMShadows) | (value ? UPrimitiveComponent.__PropertyMask_bReceiveMobileCSMShadows : 0));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x0005A836 File Offset: 0x00058A36
		// (set) Token: 0x06003E71 RID: 15985 RVA: 0x0005A84F File Offset: 0x00058A4F
		public unsafe bool bSingleSampleShadowFromStationaryLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSingleSampleShadowFromStationaryLights) & UPrimitiveComponent.__PropertyMask_bSingleSampleShadowFromStationaryLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSingleSampleShadowFromStationaryLights) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bSingleSampleShadowFromStationaryLights) & ~UPrimitiveComponent.__PropertyMask_bSingleSampleShadowFromStationaryLights) | (value ? UPrimitiveComponent.__PropertyMask_bSingleSampleShadowFromStationaryLights : 0));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x0005A87F File Offset: 0x00058A7F
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x0005A898 File Offset: 0x00058A98
		public unsafe bool bIgnoreRadialImpulse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialImpulse) & UPrimitiveComponent.__PropertyMask_bIgnoreRadialImpulse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialImpulse) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialImpulse) & ~UPrimitiveComponent.__PropertyMask_bIgnoreRadialImpulse) | (value ? UPrimitiveComponent.__PropertyMask_bIgnoreRadialImpulse : 0));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x0005A8C8 File Offset: 0x00058AC8
		// (set) Token: 0x06003E75 RID: 15989 RVA: 0x0005A8E1 File Offset: 0x00058AE1
		public unsafe bool bIgnoreRadialForce
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialForce) & UPrimitiveComponent.__PropertyMask_bIgnoreRadialForce) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialForce) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bIgnoreRadialForce) & ~UPrimitiveComponent.__PropertyMask_bIgnoreRadialForce) | (value ? UPrimitiveComponent.__PropertyMask_bIgnoreRadialForce : 0));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x0005A911 File Offset: 0x00058B11
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x0005A92A File Offset: 0x00058B2A
		public unsafe bool bApplyImpulseOnDamage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bApplyImpulseOnDamage) & UPrimitiveComponent.__PropertyMask_bApplyImpulseOnDamage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bApplyImpulseOnDamage) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bApplyImpulseOnDamage) & ~UPrimitiveComponent.__PropertyMask_bApplyImpulseOnDamage) | (value ? UPrimitiveComponent.__PropertyMask_bApplyImpulseOnDamage : 0));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0005A95A File Offset: 0x00058B5A
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x0005A973 File Offset: 0x00058B73
		public unsafe bool bReplicatePhysicsToAutonomousProxy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReplicatePhysicsToAutonomousProxy) & UPrimitiveComponent.__PropertyMask_bReplicatePhysicsToAutonomousProxy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReplicatePhysicsToAutonomousProxy) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bReplicatePhysicsToAutonomousProxy) & ~UPrimitiveComponent.__PropertyMask_bReplicatePhysicsToAutonomousProxy) | (value ? UPrimitiveComponent.__PropertyMask_bReplicatePhysicsToAutonomousProxy : 0));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x0005A9A3 File Offset: 0x00058BA3
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x0005A9BC File Offset: 0x00058BBC
		public unsafe bool bFillCollisionUnderneathForNavmesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bFillCollisionUnderneathForNavmesh) & UPrimitiveComponent.__PropertyMask_bFillCollisionUnderneathForNavmesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bFillCollisionUnderneathForNavmesh) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bFillCollisionUnderneathForNavmesh) & ~UPrimitiveComponent.__PropertyMask_bFillCollisionUnderneathForNavmesh) | (value ? UPrimitiveComponent.__PropertyMask_bFillCollisionUnderneathForNavmesh : 0));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x0005A9EC File Offset: 0x00058BEC
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x0005AA05 File Offset: 0x00058C05
		public unsafe bool AlwaysLoadOnClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnClient) & UPrimitiveComponent.__PropertyMask_AlwaysLoadOnClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnClient) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnClient) & ~UPrimitiveComponent.__PropertyMask_AlwaysLoadOnClient) | (value ? UPrimitiveComponent.__PropertyMask_AlwaysLoadOnClient : 0));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x0005AA35 File Offset: 0x00058C35
		// (set) Token: 0x06003E7F RID: 15999 RVA: 0x0005AA4E File Offset: 0x00058C4E
		public unsafe bool AlwaysLoadOnServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnServer) & UPrimitiveComponent.__PropertyMask_AlwaysLoadOnServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnServer) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_AlwaysLoadOnServer) & ~UPrimitiveComponent.__PropertyMask_AlwaysLoadOnServer) | (value ? UPrimitiveComponent.__PropertyMask_AlwaysLoadOnServer : 0));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x0005AA7E File Offset: 0x00058C7E
		// (set) Token: 0x06003E81 RID: 16001 RVA: 0x0005AA97 File Offset: 0x00058C97
		public unsafe bool bUseEditorCompositing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseEditorCompositing) & UPrimitiveComponent.__PropertyMask_bUseEditorCompositing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseEditorCompositing) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bUseEditorCompositing) & ~UPrimitiveComponent.__PropertyMask_bUseEditorCompositing) | (value ? UPrimitiveComponent.__PropertyMask_bUseEditorCompositing : 0));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x0005AAC7 File Offset: 0x00058CC7
		// (set) Token: 0x06003E83 RID: 16003 RVA: 0x0005AAE0 File Offset: 0x00058CE0
		public unsafe bool bRenderCustomDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderCustomDepth) & UPrimitiveComponent.__PropertyMask_bRenderCustomDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderCustomDepth) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderCustomDepth) & ~UPrimitiveComponent.__PropertyMask_bRenderCustomDepth) | (value ? UPrimitiveComponent.__PropertyMask_bRenderCustomDepth : 0));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x0005AB10 File Offset: 0x00058D10
		// (set) Token: 0x06003E85 RID: 16005 RVA: 0x0005AB29 File Offset: 0x00058D29
		public unsafe bool bRenderMobileSceneCustomDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderMobileSceneCustomDepth) & UPrimitiveComponent.__PropertyMask_bRenderMobileSceneCustomDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderMobileSceneCustomDepth) = ((*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bRenderMobileSceneCustomDepth) & ~UPrimitiveComponent.__PropertyMask_bRenderMobileSceneCustomDepth) | (value ? UPrimitiveComponent.__PropertyMask_bRenderMobileSceneCustomDepth : 0));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x0005AB59 File Offset: 0x00058D59
		// (set) Token: 0x06003E87 RID: 16007 RVA: 0x0005AB69 File Offset: 0x00058D69
		public unsafe bool bCanCharacterStandOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCanCharacterStandOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bCanCharacterStandOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x0005AB7C File Offset: 0x00058D7C
		// (set) Token: 0x06003E89 RID: 16009 RVA: 0x0005ABB5 File Offset: 0x00058DB5
		public FComponentConveyBaseMovementSignature OnConveyBase
		{
			get
			{
				base.FastCheckIsValid();
				FComponentConveyBaseMovementSignature result;
				if ((result = this._OnConveyBase) == null)
				{
					result = (this._OnConveyBase = new FComponentConveyBaseMovementSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnConveyBase, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnConveyBase, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x0005ABD6 File Offset: 0x00058DD6
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x0005ABEA File Offset: 0x00058DEA
		[Nullable(0)]
		public unsafe TEnumAsByte<ECanBeCharacterBase> CanCharacterStepUpOn
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CanCharacterStepUpOn);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CanCharacterStepUpOn) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x0005ABFF File Offset: 0x00058DFF
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x0005AC0F File Offset: 0x00058E0F
		public unsafe int ToonCustomStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ToonCustomStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ToonCustomStencilValue) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x0005AC20 File Offset: 0x00058E20
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x0005AC30 File Offset: 0x00058E30
		public unsafe int CustomDepthStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomDepthStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomDepthStencilValue) = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x0005AC41 File Offset: 0x00058E41
		// (set) Token: 0x06003E91 RID: 16017 RVA: 0x0005AC51 File Offset: 0x00058E51
		public unsafe int MobileSceneCustomDepthStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileSceneCustomDepthStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileSceneCustomDepthStencilValue) = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06003E92 RID: 16018 RVA: 0x0005AC62 File Offset: 0x00058E62
		// (set) Token: 0x06003E93 RID: 16019 RVA: 0x0005AC72 File Offset: 0x00058E72
		public unsafe float ExposeToCinematicsCustomLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ExposeToCinematicsCustomLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ExposeToCinematicsCustomLightYaw) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x0005AC83 File Offset: 0x00058E83
		// (set) Token: 0x06003E95 RID: 16021 RVA: 0x0005AC93 File Offset: 0x00058E93
		public unsafe float ExposeToCinematicsCustomLightFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ExposeToCinematicsCustomLightFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ExposeToCinematicsCustomLightFactor) = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003E96 RID: 16022 RVA: 0x0005ACA4 File Offset: 0x00058EA4
		// (set) Token: 0x06003E97 RID: 16023 RVA: 0x0005ACB4 File Offset: 0x00058EB4
		public unsafe int TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_TranslucencySortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_TranslucencySortPriority) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x0005ACC5 File Offset: 0x00058EC5
		// (set) Token: 0x06003E99 RID: 16025 RVA: 0x0005ACD5 File Offset: 0x00058ED5
		public unsafe int VisibilityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VisibilityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VisibilityId) = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x0005ACE6 File Offset: 0x00058EE6
		// (set) Token: 0x06003E9B RID: 16027 RVA: 0x0005ACF6 File Offset: 0x00058EF6
		public unsafe sbyte VirtualTextureLodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureLodBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureLodBias) = (byte)value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x0005AD07 File Offset: 0x00058F07
		// (set) Token: 0x06003E9D RID: 16029 RVA: 0x0005AD17 File Offset: 0x00058F17
		public unsafe sbyte VirtualTextureCullMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureCullMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureCullMips) = (byte)value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x0005AD28 File Offset: 0x00058F28
		// (set) Token: 0x06003E9F RID: 16031 RVA: 0x0005AD38 File Offset: 0x00058F38
		public unsafe sbyte VirtualTextureMinCoverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureMinCoverage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureMinCoverage) = (byte)value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x0005AD49 File Offset: 0x00058F49
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x0005AD59 File Offset: 0x00058F59
		public unsafe float LpvBiasMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LpvBiasMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LpvBiasMultiplier) = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x0005AD6A File Offset: 0x00058F6A
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x0005AD7A File Offset: 0x00058F7A
		public unsafe float BoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_BoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_BoundsScale) = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x0005AD8B File Offset: 0x00058F8B
		// (set) Token: 0x06003EA5 RID: 16037 RVA: 0x0005AD9B File Offset: 0x00058F9B
		public unsafe bool bBindlessPrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bBindlessPrimitive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bBindlessPrimitive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x0005ADAC File Offset: 0x00058FAC
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x0005ADE5 File Offset: 0x00058FE5
		public TArray<AActor> MoveIgnoreActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._MoveIgnoreActors) == null)
				{
					result = (this._MoveIgnoreActors = new TArray<AActor>(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MoveIgnoreActors, this));
				}
				return result;
			}
			set
			{
				this.MoveIgnoreActors.CopyAssign(value);
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x0005AE2D File Offset: 0x0005902D
		public TArray<UPrimitiveComponent> MoveIgnoreComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._MoveIgnoreComponents) == null)
				{
					result = (this._MoveIgnoreComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MoveIgnoreComponents, this));
				}
				return result;
			}
			set
			{
				this.MoveIgnoreComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x0005AE3C File Offset: 0x0005903C
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x0005AE75 File Offset: 0x00059075
		public FBodyInstance BodyInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._BodyInstance) == null)
				{
					result = (this._BodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_BodyInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_BodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x0005AE98 File Offset: 0x00059098
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x0005AED1 File Offset: 0x000590D1
		public FComponentHitSignature OnComponentHit
		{
			get
			{
				base.FastCheckIsValid();
				FComponentHitSignature result;
				if ((result = this._OnComponentHit) == null)
				{
					result = (this._OnComponentHit = new FComponentHitSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentHit, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0005AEF4 File Offset: 0x000590F4
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x0005AF2D File Offset: 0x0005912D
		public FComponentBeginOverlapSignature OnComponentBeginOverlap
		{
			get
			{
				base.FastCheckIsValid();
				FComponentBeginOverlapSignature result;
				if ((result = this._OnComponentBeginOverlap) == null)
				{
					result = (this._OnComponentBeginOverlap = new FComponentBeginOverlapSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlap, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x0005AF50 File Offset: 0x00059150
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x0005AF89 File Offset: 0x00059189
		public FComponentBeginOverlapBlockSignature OnComponentBeginOverlapBlock
		{
			get
			{
				base.FastCheckIsValid();
				FComponentBeginOverlapBlockSignature result;
				if ((result = this._OnComponentBeginOverlapBlock) == null)
				{
					result = (this._OnComponentBeginOverlapBlock = new FComponentBeginOverlapBlockSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlapBlock, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlapBlock, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x0005AFAC File Offset: 0x000591AC
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x0005AFE5 File Offset: 0x000591E5
		public FComponentBeginOverlapSignatureNoGcAlloc OnComponentBeginOverlapNoGcAlloc
		{
			get
			{
				base.FastCheckIsValid();
				FComponentBeginOverlapSignatureNoGcAlloc result;
				if ((result = this._OnComponentBeginOverlapNoGcAlloc) == null)
				{
					result = (this._OnComponentBeginOverlapNoGcAlloc = new FComponentBeginOverlapSignatureNoGcAlloc(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlapNoGcAlloc, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentBeginOverlapNoGcAlloc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x0005B008 File Offset: 0x00059208
		// (set) Token: 0x06003EB5 RID: 16053 RVA: 0x0005B041 File Offset: 0x00059241
		public FComponentEndOverlapSignature OnComponentEndOverlap
		{
			get
			{
				base.FastCheckIsValid();
				FComponentEndOverlapSignature result;
				if ((result = this._OnComponentEndOverlap) == null)
				{
					result = (this._OnComponentEndOverlap = new FComponentEndOverlapSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentEndOverlap, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentEndOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x0005B064 File Offset: 0x00059264
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x0005B09D File Offset: 0x0005929D
		public FComponentWakeSignature OnComponentWake
		{
			get
			{
				base.FastCheckIsValid();
				FComponentWakeSignature result;
				if ((result = this._OnComponentWake) == null)
				{
					result = (this._OnComponentWake = new FComponentWakeSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentWake, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentWake, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x0005B0C0 File Offset: 0x000592C0
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x0005B0F9 File Offset: 0x000592F9
		public FComponentSleepSignature OnComponentSleep
		{
			get
			{
				base.FastCheckIsValid();
				FComponentSleepSignature result;
				if ((result = this._OnComponentSleep) == null)
				{
					result = (this._OnComponentSleep = new FComponentSleepSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentSleep, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnComponentSleep, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x0005B11C File Offset: 0x0005931C
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x0005B155 File Offset: 0x00059355
		public FComponentBeginCursorOverSignature OnBeginCursorOver
		{
			get
			{
				base.FastCheckIsValid();
				FComponentBeginCursorOverSignature result;
				if ((result = this._OnBeginCursorOver) == null)
				{
					result = (this._OnBeginCursorOver = new FComponentBeginCursorOverSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnBeginCursorOver, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnBeginCursorOver, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x0005B178 File Offset: 0x00059378
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x0005B1B1 File Offset: 0x000593B1
		public FComponentEndCursorOverSignature OnEndCursorOver
		{
			get
			{
				base.FastCheckIsValid();
				FComponentEndCursorOverSignature result;
				if ((result = this._OnEndCursorOver) == null)
				{
					result = (this._OnEndCursorOver = new FComponentEndCursorOverSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnEndCursorOver, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnEndCursorOver, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x0005B1D4 File Offset: 0x000593D4
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x0005B20D File Offset: 0x0005940D
		public FComponentOnClickedSignature OnClicked
		{
			get
			{
				base.FastCheckIsValid();
				FComponentOnClickedSignature result;
				if ((result = this._OnClicked) == null)
				{
					result = (this._OnClicked = new FComponentOnClickedSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x0005B230 File Offset: 0x00059430
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x0005B269 File Offset: 0x00059469
		public FComponentOnReleasedSignature OnReleased
		{
			get
			{
				base.FastCheckIsValid();
				FComponentOnReleasedSignature result;
				if ((result = this._OnReleased) == null)
				{
					result = (this._OnReleased = new FComponentOnReleasedSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnReleased, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnReleased, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x0005B28C File Offset: 0x0005948C
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x0005B2C5 File Offset: 0x000594C5
		public FComponentOnInputTouchBeginSignature OnInputTouchBegin
		{
			get
			{
				base.FastCheckIsValid();
				FComponentOnInputTouchBeginSignature result;
				if ((result = this._OnInputTouchBegin) == null)
				{
					result = (this._OnInputTouchBegin = new FComponentOnInputTouchBeginSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchBegin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0005B2E8 File Offset: 0x000594E8
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x0005B321 File Offset: 0x00059521
		public FComponentOnInputTouchEndSignature OnInputTouchEnd
		{
			get
			{
				base.FastCheckIsValid();
				FComponentOnInputTouchEndSignature result;
				if ((result = this._OnInputTouchEnd) == null)
				{
					result = (this._OnInputTouchEnd = new FComponentOnInputTouchEndSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x0005B344 File Offset: 0x00059544
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x0005B37D File Offset: 0x0005957D
		public FComponentBeginTouchOverSignature OnInputTouchEnter
		{
			get
			{
				base.FastCheckIsValid();
				FComponentBeginTouchOverSignature result;
				if ((result = this._OnInputTouchEnter) == null)
				{
					result = (this._OnInputTouchEnter = new FComponentBeginTouchOverSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchEnter, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchEnter, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x0005B3A0 File Offset: 0x000595A0
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x0005B3D9 File Offset: 0x000595D9
		public FComponentEndTouchOverSignature OnInputTouchLeave
		{
			get
			{
				base.FastCheckIsValid();
				FComponentEndTouchOverSignature result;
				if ((result = this._OnInputTouchLeave) == null)
				{
					result = (this._OnInputTouchLeave = new FComponentEndTouchOverSignature(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchLeave, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_OnInputTouchLeave, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x0005B3FA File Offset: 0x000595FA
		// (set) Token: 0x06003ECB RID: 16075 RVA: 0x0005B40E File Offset: 0x0005960E
		[Nullable(2)]
		public unsafe UPrimitiveComponent LODParentPrimitive
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPrimitiveComponent.__PropertyOffset_LODParentPrimitive);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPrimitiveComponent.__PropertyOffset_LODParentPrimitive, value);
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0005B423 File Offset: 0x00059623
		public bool WasRecentlyRendered(float Tolerance = 0.2f)
		{
			return UPrimitiveComponent.__WasRecentlyRendered_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0005B431 File Offset: 0x00059631
		public void WakeRigidBody(FName BoneName = default(FName))
		{
			UPrimitiveComponent.__WakeRigidBody_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0005B43F File Offset: 0x0005963F
		public void WakeAllRigidBodies()
		{
			UPrimitiveComponent.__WakeAllRigidBodies_Internal(base.NativePtr);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0005B44C File Offset: 0x0005964C
		public void SetVolumeCullingActorFlag(bool NewValue)
		{
			UPrimitiveComponent.__SetVolumeCullingActorFlag_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0005B45A File Offset: 0x0005965A
		[NullableContext(2)]
		public void SetUseOutlineStencilTestSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseOutlineStencilTestSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0005B477 File Offset: 0x00059677
		public void SetUseOutlineStencilTest(bool bValue)
		{
			UPrimitiveComponent.__SetUseOutlineStencilTest_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0005B485 File Offset: 0x00059685
		public void SetUseMeshBlend(bool bValue)
		{
			UPrimitiveComponent.__SetUseMeshBlend_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0005B493 File Offset: 0x00059693
		public void SetUseKuroOpacity(bool bValue)
		{
			UPrimitiveComponent.__SetUseKuroOpacity_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0005B4A1 File Offset: 0x000596A1
		[NullableContext(2)]
		public void SetUseEnableBattleSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseEnableBattleSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0005B4BE File Offset: 0x000596BE
		[NullableContext(2)]
		public void SetUseEnableBattleMaskSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseEnableBattleMaskSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0005B4DB File Offset: 0x000596DB
		public void SetUseEnableBattleMask(bool bValue)
		{
			UPrimitiveComponent.__SetUseEnableBattleMask_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0005B4E9 File Offset: 0x000596E9
		public void SetUseEnableBattle(bool bValue)
		{
			UPrimitiveComponent.__SetUseEnableBattle_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0005B4F7 File Offset: 0x000596F7
		public void SetUseCustomWPO(bool bValue)
		{
			UPrimitiveComponent.__SetUseCustomWPO_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0005B505 File Offset: 0x00059705
		[NullableContext(2)]
		public void SetUseCustomAlphaTestSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseCustomAlphaTestSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x0005B522 File Offset: 0x00059722
		public void SetUseCustomAlphaTest(bool bValue)
		{
			UPrimitiveComponent.__SetUseCustomAlphaTest_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0005B530 File Offset: 0x00059730
		public void SetUseCCD(bool InUseCCD, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetUseCCD_Internal(base.NativePtr, InUseCCD, BoneName);
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0005B53F File Offset: 0x0005973F
		public void SetTranslucentSortPriority(int NewTranslucentSortPriority)
		{
			UPrimitiveComponent.__SetTranslucentSortPriority_Internal(base.NativePtr, NewTranslucentSortPriority);
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0005B54D File Offset: 0x0005974D
		public void SetToonLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			UPrimitiveComponent.__SetToonLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x0005B55D File Offset: 0x0005975D
		public void SetToonCustomStencilValue(int Value)
		{
			UPrimitiveComponent.__SetToonCustomStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0005B56B File Offset: 0x0005976B
		public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
		{
			UPrimitiveComponent.__SetSingleSampleShadowFromStationaryLights_Internal(base.NativePtr, bNewSingleSampleShadowFromStationaryLights);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0005B579 File Offset: 0x00059779
		public void SetSimulatePhysics(bool bSimulate)
		{
			UPrimitiveComponent.__SetSimulatePhysics_Internal(base.NativePtr, bSimulate);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0005B587 File Offset: 0x00059787
		public void SetSceneDissolveActive(bool bNewActive)
		{
			UPrimitiveComponent.__SetSceneDissolveActive_Internal(base.NativePtr, bNewActive);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0005B595 File Offset: 0x00059795
		public void SetSceneColorClearActive(bool bNewActive)
		{
			UPrimitiveComponent.__SetSceneColorClearActive_Internal(base.NativePtr, bNewActive);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0005B5A3 File Offset: 0x000597A3
		public void SetRenderMobileSceneCustomDepth(bool bValue)
		{
			UPrimitiveComponent.__SetRenderMobileSceneCustomDepth_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0005B5B1 File Offset: 0x000597B1
		public void SetRenderKuroTrail(bool bValue)
		{
			UPrimitiveComponent.__SetRenderKuroTrail_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0005B5BF File Offset: 0x000597BF
		public void SetRenderInMainPass(bool bValue)
		{
			UPrimitiveComponent.__SetRenderInMainPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0005B5CD File Offset: 0x000597CD
		public void SetRenderInDataDistortionPass(bool bValue)
		{
			UPrimitiveComponent.__SetRenderInDataDistortionPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0005B5DB File Offset: 0x000597DB
		public void SetRenderInBurst(bool bInRenderInBurst)
		{
			UPrimitiveComponent.__SetRenderInBurst_Internal(base.NativePtr, bInRenderInBurst);
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0005B5E9 File Offset: 0x000597E9
		public void SetRenderCustomDepth(bool bValue)
		{
			UPrimitiveComponent.__SetRenderCustomDepth_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x0005B5F7 File Offset: 0x000597F7
		public void SetReceivesDecals(bool bNewReceivesDecals)
		{
			UPrimitiveComponent.__SetReceivesDecals_Internal(base.NativePtr, bNewReceivesDecals);
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0005B605 File Offset: 0x00059805
		public void SetPlanarReflectionRenderOffset(bool bEnable, FVector InOffsetWS)
		{
			UPrimitiveComponent.__SetPlanarReflectionRenderOffset_Internal(base.NativePtr, bEnable, InOffsetWS);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0005B614 File Offset: 0x00059814
		[NullableContext(2)]
		public void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
		{
			UPrimitiveComponent.__SetPhysMaterialOverride_Internal(base.NativePtr, (NewPhysMaterial != null) ? NewPhysMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0005B631 File Offset: 0x00059831
		public void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocityInRadians_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0005B641 File Offset: 0x00059841
		public void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocityInDegrees_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0005B651 File Offset: 0x00059851
		public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocity_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0005B661 File Offset: 0x00059861
		public void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsLinearVelocity_Internal(base.NativePtr, NewVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0005B671 File Offset: 0x00059871
		public void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocityInRadians_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0005B681 File Offset: 0x00059881
		public void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0005B691 File Offset: 0x00059891
		public void SetPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocity_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0005B6A1 File Offset: 0x000598A1
		public void SetOwnerNoSee(bool bNewOwnerNoSee)
		{
			UPrimitiveComponent.__SetOwnerNoSee_Internal(base.NativePtr, bNewOwnerNoSee);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0005B6AF File Offset: 0x000598AF
		public void SetOnlyVisibleInSceneCapture(bool bValue)
		{
			UPrimitiveComponent.__SetOnlyVisibleInSceneCapture_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0005B6BD File Offset: 0x000598BD
		public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
		{
			UPrimitiveComponent.__SetOnlyOwnerSee_Internal(base.NativePtr, bNewOnlyOwnerSee);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0005B6CB File Offset: 0x000598CB
		public void SetNoVelocity(bool bInNoVelocity)
		{
			UPrimitiveComponent.__SetNoVelocity_Internal(base.NativePtr, bInNoVelocity);
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0005B6D9 File Offset: 0x000598D9
		public void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
		{
			UPrimitiveComponent.__SetNotifyRigidBodyCollision_Internal(base.NativePtr, bNewNotifyRigidBodyCollision);
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0005B6E7 File Offset: 0x000598E7
		public void SetMobileSceneCustomDepthStencilValue(int Value)
		{
			UPrimitiveComponent.__SetMobileSceneCustomDepthStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0005B6F5 File Offset: 0x000598F5
		public void SetMeshShadingRate(EMaterialShadingRate InMeshShadingRate)
		{
			UPrimitiveComponent.__SetMeshShadingRate_Internal(base.NativePtr, InMeshShadingRate);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0005B708 File Offset: 0x00059908
		public void SetMeshBlendID(byte Value)
		{
			UPrimitiveComponent.__SetMeshBlendID_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0005B716 File Offset: 0x00059916
		[NullableContext(2)]
		public void SetMaterialByName(FName MaterialSlotName, UMaterialInterface Material)
		{
			UPrimitiveComponent.__SetMaterialByName_Internal(base.NativePtr, MaterialSlotName, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0005B734 File Offset: 0x00059934
		[NullableContext(2)]
		public void SetMaterial(int ElementIndex, UMaterialInterface Material)
		{
			UPrimitiveComponent.__SetMaterial_Internal(base.NativePtr, ElementIndex, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0005B752 File Offset: 0x00059952
		public void SetMassScale(FName BoneName = default(FName), float InMassScale = 1f)
		{
			UPrimitiveComponent.__SetMassScale_Internal(base.NativePtr, BoneName, InMassScale);
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0005B761 File Offset: 0x00059961
		public void SetMassOverrideInKg(FName BoneName = default(FName), float MassInKg = 1f, bool bOverrideMass = true)
		{
			UPrimitiveComponent.__SetMassOverrideInKg_Internal(base.NativePtr, BoneName, MassInKg, bOverrideMass);
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0005B771 File Offset: 0x00059971
		public void SetLinearDamping(float InDamping)
		{
			UPrimitiveComponent.__SetLinearDamping_Internal(base.NativePtr, InDamping);
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0005B77F File Offset: 0x0005997F
		public void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			UPrimitiveComponent.__SetLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0005B78F File Offset: 0x0005998F
		public void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup)
		{
			UPrimitiveComponent.__SetLightAttachmentsAsGroup_Internal(base.NativePtr, bInLightAttachmentsAsGroup);
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x0005B79D File Offset: 0x0005999D
		public void SetLGUISortPriority(int NewTranslucentSortPriority)
		{
			UPrimitiveComponent.__SetLGUISortPriority_Internal(base.NativePtr, NewTranslucentSortPriority);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x0005B7AB File Offset: 0x000599AB
		public void SetLGUIRenderAsMask(bool IsRenderAsMask)
		{
			UPrimitiveComponent.__SetLGUIRenderAsMask_Internal(base.NativePtr, IsRenderAsMask);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x0005B7B9 File Offset: 0x000599B9
		public void SetLGUIReadMask(bool IsLGUIReadMask)
		{
			UPrimitiveComponent.__SetLGUIReadMask_Internal(base.NativePtr, IsLGUIReadMask);
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x0005B7C7 File Offset: 0x000599C7
		public void SetLGUIOverlay(bool IsLGUIOverlayIn)
		{
			UPrimitiveComponent.__SetLGUIOverlay_Internal(base.NativePtr, IsLGUIOverlayIn);
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0005B7D5 File Offset: 0x000599D5
		public void SetLGUIBeforeUpScale(bool IsLGUIBeforeUpScale)
		{
			UPrimitiveComponent.__SetLGUIBeforeUpScale_Internal(base.NativePtr, IsLGUIBeforeUpScale);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0005B7E3 File Offset: 0x000599E3
		public void SetLGUIBeforeBloom(bool IsLGUIAfterBlur)
		{
			UPrimitiveComponent.__SetLGUIBeforeBloom_Internal(base.NativePtr, IsLGUIAfterBlur);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0005B7F1 File Offset: 0x000599F1
		public void SetLGUIAfterPP(bool IsLGUIAfterPPIn)
		{
			UPrimitiveComponent.__SetLGUIAfterPP_Internal(base.NativePtr, IsLGUIAfterPPIn);
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0005B7FF File Offset: 0x000599FF
		public void SetLGUIAfterBlur(bool IsLGUIAfterBlur)
		{
			UPrimitiveComponent.__SetLGUIAfterBlur_Internal(base.NativePtr, IsLGUIAfterBlur);
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0005B80D File Offset: 0x00059A0D
		public void SetLGUI(bool IsLGUIIn)
		{
			UPrimitiveComponent.__SetLGUI_Internal(base.NativePtr, IsLGUIIn);
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x0005B81B File Offset: 0x00059A1B
		public void SetKuroOpacity(float Value)
		{
			UPrimitiveComponent.__SetKuroOpacity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0005B829 File Offset: 0x00059A29
		public void SetIsUIScenePrimitive(bool bValue)
		{
			UPrimitiveComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0005B837 File Offset: 0x00059A37
		public void SetIsSpecialForLocalLightShadow(bool IsSpecial)
		{
			UPrimitiveComponent.__SetIsSpecialForLocalLightShadow_Internal(base.NativePtr, IsSpecial);
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0005B845 File Offset: 0x00059A45
		public void SetIsKuroLandscape(bool InIsKuroLandscape)
		{
			UPrimitiveComponent.__SetIsKuroLandscape_Internal(base.NativePtr, InIsKuroLandscape);
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0005B853 File Offset: 0x00059A53
		public void SetIsHiddenInUiSceneState(bool bValue)
		{
			UPrimitiveComponent.__SetIsHiddenInUiSceneState_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0005B861 File Offset: 0x00059A61
		public void SetIsCastShadowWhenInCaveOrIndoor(bool IsCastShadowWhenInCaveOrIndoor)
		{
			UPrimitiveComponent.__SetIsCastShadowWhenInCaveOrIndoor_Internal(base.NativePtr, IsCastShadowWhenInCaveOrIndoor);
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0005B86F File Offset: 0x00059A6F
		public void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)
		{
			UPrimitiveComponent.__SetGenerateOverlapEvents_Internal(base.NativePtr, bInGenerateOverlapEvents);
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0005B87D File Offset: 0x00059A7D
		public void SetFOVOverride(float NewFOV)
		{
			UPrimitiveComponent.__SetFOVOverride_Internal(base.NativePtr, NewFOV);
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0005B88B File Offset: 0x00059A8B
		public void SetForceCastShadowInRayTracing(bool NewForceCastShadowInRayTracing)
		{
			UPrimitiveComponent.__SetForceCastShadowInRayTracing_Internal(base.NativePtr, NewForceCastShadowInRayTracing);
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x0005B899 File Offset: 0x00059A99
		public void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup)
		{
			UPrimitiveComponent.__SetExcludeFromLightAttachmentGroup_Internal(base.NativePtr, bInExcludeFromLightAttachmentGroup);
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0005B8A7 File Offset: 0x00059AA7
		public void SetEnableGravity(bool bGravityEnabled)
		{
			UPrimitiveComponent.__SetEnableGravity_Internal(base.NativePtr, bGravityEnabled);
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0005B8B8 File Offset: 0x00059AB8
		public unsafe void SetDefaultCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector4_Internal(base.NativePtr, DataIndex, ptr);
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0005B8E9 File Offset: 0x00059AE9
		public void SetDefaultCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector3_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		public void SetDefaultCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector2_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0005B907 File Offset: 0x00059B07
		public void SetDefaultCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataFloat_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0005B916 File Offset: 0x00059B16
		public void SetDataDistortionCullRatio(float Value)
		{
			UPrimitiveComponent.__SetDataDistortionCullRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0005B924 File Offset: 0x00059B24
		public unsafe void SetCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UPrimitiveComponent.__SetCustomPrimitiveDataVector4_Internal(base.NativePtr, DataIndex, ptr);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0005B955 File Offset: 0x00059B55
		public void SetCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataVector3_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0005B964 File Offset: 0x00059B64
		public void SetCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataVector2_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x0005B973 File Offset: 0x00059B73
		public void SetCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataFloat_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0005B982 File Offset: 0x00059B82
		public void SetCustomDepthStencilValue(int Value)
		{
			UPrimitiveComponent.__SetCustomDepthStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0005B990 File Offset: 0x00059B90
		public void SetCustomCullFlag(byte NewFlag)
		{
			UPrimitiveComponent.__SetCustomCullFlag_Internal(base.NativePtr, NewFlag);
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0005B99E File Offset: 0x00059B9E
		public void SetCullDistance(float NewCullDistance)
		{
			UPrimitiveComponent.__SetCullDistance_Internal(base.NativePtr, NewCullDistance);
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0005B9AC File Offset: 0x00059BAC
		public void SetConstraintMode(EDOFMode ConstraintMode)
		{
			UPrimitiveComponent.__SetConstraintMode_Internal(base.NativePtr, ConstraintMode);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0005B9BF File Offset: 0x00059BBF
		[NullableContext(2)]
		public void SetCollisionResponseToChannels(in FCollisionResponseContainer NewReponses)
		{
			UPrimitiveComponent.__SetCollisionResponseToChannels_Internal(base.NativePtr, (NewReponses ?? new FCollisionResponseContainer()).NativePtr);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0005B9DC File Offset: 0x00059BDC
		public void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
		{
			UPrimitiveComponent.__SetCollisionResponseToChannel_Internal(base.NativePtr, Channel, NewResponse);
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0005B9F5 File Offset: 0x00059BF5
		public void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
		{
			UPrimitiveComponent.__SetCollisionResponseToAllChannels_Internal(base.NativePtr, NewResponse);
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0005BA08 File Offset: 0x00059C08
		public void SetCollisionProfileName(FName InCollisionProfileName, bool bUpdateOverlaps = true)
		{
			UPrimitiveComponent.__SetCollisionProfileName_Internal(base.NativePtr, InCollisionProfileName, bUpdateOverlaps);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0005BA17 File Offset: 0x00059C17
		public void SetCollisionObjectType(ECollisionChannel Channel)
		{
			UPrimitiveComponent.__SetCollisionObjectType_Internal(base.NativePtr, Channel);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0005BA2A File Offset: 0x00059C2A
		public void SetCollisionEnabled(ECollisionEnabled NewType)
		{
			UPrimitiveComponent.__SetCollisionEnabled_Internal(base.NativePtr, NewType);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0005BA3D File Offset: 0x00059C3D
		public void SetCenterOfMass(FVector CenterOfMassOffset, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetCenterOfMass_Internal(base.NativePtr, CenterOfMassOffset, BoneName);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0005BA4C File Offset: 0x00059C4C
		public void SetCastShadowInShadowCullVolume(bool bNewCastShadowInShadowCullVolume)
		{
			UPrimitiveComponent.__SetCastShadowInShadowCullVolume_Internal(base.NativePtr, bNewCastShadowInShadowCullVolume);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0005BA5A File Offset: 0x00059C5A
		public void SetCastShadow(bool NewCastShadow)
		{
			UPrimitiveComponent.__SetCastShadow_Internal(base.NativePtr, NewCastShadow);
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0005BA68 File Offset: 0x00059C68
		public void SetCastInsetShadow(bool bInCastInsetShadow)
		{
			UPrimitiveComponent.__SetCastInsetShadow_Internal(base.NativePtr, bInCastInsetShadow);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0005BA76 File Offset: 0x00059C76
		public void SetCastFarShadowOnMobile(bool NewValue)
		{
			UPrimitiveComponent.__SetCastFarShadowOnMobile_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x0005BA84 File Offset: 0x00059C84
		public void SetCastFarShadow(bool NewValue)
		{
			UPrimitiveComponent.__SetCastFarShadow_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x0005BA92 File Offset: 0x00059C92
		public void SetBoundsScale(float NewBoundsScale = 1f)
		{
			UPrimitiveComponent.__SetBoundsScale_Internal(base.NativePtr, NewBoundsScale);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0005BAA0 File Offset: 0x00059CA0
		public void SetAngularDamping(float InDamping)
		{
			UPrimitiveComponent.__SetAngularDamping_Internal(base.NativePtr, InDamping);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0005BAAE File Offset: 0x00059CAE
		public void SetAllUseCCD(bool InUseCCD)
		{
			UPrimitiveComponent.__SetAllUseCCD_Internal(base.NativePtr, InUseCCD);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0005BABC File Offset: 0x00059CBC
		public void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsLinearVelocity_Internal(base.NativePtr, NewVel, bAddToCurrent);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x0005BACB File Offset: 0x00059CCB
		public void SetAllPhysicsAngularVelocityInRadians(in FVector NewAngVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsAngularVelocityInRadians_Internal(base.NativePtr, NewAngVel, bAddToCurrent);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0005BADA File Offset: 0x00059CDA
		public void SetAllPhysicsAngularVelocityInDegrees(in FVector NewAngVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, NewAngVel, bAddToCurrent);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0005BAE9 File Offset: 0x00059CE9
		public void SetAllMassScale(float InMassScale = 1f)
		{
			UPrimitiveComponent.__SetAllMassScale_Internal(base.NativePtr, InMassScale);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0005BAF7 File Offset: 0x00059CF7
		public FVector ScaleByMomentOfInertia(FVector InputVector, FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__ScaleByMomentOfInertia_Internal(base.NativePtr, InputVector, BoneName);
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0005BB06 File Offset: 0x00059D06
		public void ResetCustomPrimitiveData()
		{
			UPrimitiveComponent.__ResetCustomPrimitiveData_Internal(base.NativePtr);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0005BB13 File Offset: 0x00059D13
		public void PutRigidBodyToSleep(FName BoneName = default(FName))
		{
			UPrimitiveComponent.__PutRigidBodyToSleep_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0005BB21 File Offset: 0x00059D21
		public void KuroSetPassiveCollision(bool bPassiveCollision, bool bUpdateOverlaps = true)
		{
			UPrimitiveComponent.__KuroSetPassiveCollision_Internal(base.NativePtr, bPassiveCollision, bUpdateOverlaps);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0005BB30 File Offset: 0x00059D30
		public void KuroRemovePassiveProxyChannel(ECollisionChannel CollisionChannel)
		{
			UPrimitiveComponent.__KuroRemovePassiveProxyChannel_Internal(base.NativePtr, CollisionChannel);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0005BB43 File Offset: 0x00059D43
		public void KuroAddPassiveProxyChannel(ECollisionChannel CollisionChannel)
		{
			UPrimitiveComponent.__KuroAddPassiveProxyChannel_Internal(base.NativePtr, CollisionChannel);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0005BB58 File Offset: 0x00059D58
		[NullableContext(2)]
		public unsafe bool K2_SphereTraceComponent(FVector TraceStart, FVector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			fixed (FVector* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &HitNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						return UPrimitiveComponent.__K2_SphereTraceComponent_Internal(base.NativePtr, TraceStart, TraceEnd, SphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace, ref HitLocation, ref HitNormal, ref BoneName, (OutHit ?? new FHitResult()).NativePtr);
					}
				}
			}
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0005BBA8 File Offset: 0x00059DA8
		[NullableContext(2)]
		public unsafe bool K2_SphereOverlapComponent(FVector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			fixed (FVector* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &HitNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						return UPrimitiveComponent.__K2_SphereOverlapComponent_Internal(base.NativePtr, InSphereCentre, InSphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace, ref HitLocation, ref HitNormal, ref BoneName, (OutHit ?? new FHitResult()).NativePtr);
					}
				}
			}
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0005BBF4 File Offset: 0x00059DF4
		[NullableContext(2)]
		public unsafe bool K2_LineTraceComponent(FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			fixed (FVector* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &HitNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						return UPrimitiveComponent.__K2_LineTraceComponent_Internal(base.NativePtr, TraceStart, TraceEnd, bTraceComplex, bShowTrace, bPersistentShowTrace, ref HitLocation, ref HitNormal, ref BoneName, (OutHit ?? new FHitResult()).NativePtr);
					}
				}
			}
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0005BC40 File Offset: 0x00059E40
		public bool K2_IsQueryCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsQueryCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0005BC4D File Offset: 0x00059E4D
		public bool K2_IsPhysicsCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsPhysicsCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0005BC5A File Offset: 0x00059E5A
		public bool K2_IsCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x0005BC68 File Offset: 0x00059E68
		[NullableContext(2)]
		public unsafe bool K2_BoxOverlapComponent(FVector InBoxCentre, FBox InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			fixed (FVector* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &HitNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						return UPrimitiveComponent.__K2_BoxOverlapComponent_Internal(base.NativePtr, InBoxCentre, InBox, bTraceComplex, bShowTrace, bPersistentShowTrace, ref HitLocation, ref HitNormal, ref BoneName, (OutHit ?? new FHitResult()).NativePtr);
					}
				}
			}
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0005BCB4 File Offset: 0x00059EB4
		public bool IsRenderKuroTrail()
		{
			return UPrimitiveComponent.__IsRenderKuroTrail_Internal(base.NativePtr);
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0005BCC1 File Offset: 0x00059EC1
		[NullableContext(2)]
		public bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
		{
			return UPrimitiveComponent.__IsOverlappingComponent_Internal(base.NativePtr, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x0005BCDE File Offset: 0x00059EDE
		[NullableContext(2)]
		public bool IsOverlappingActor(AActor Other)
		{
			return UPrimitiveComponent.__IsOverlappingActor_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0005BCFB File Offset: 0x00059EFB
		public bool IsGravityEnabled()
		{
			return UPrimitiveComponent.__IsGravityEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0005BD08 File Offset: 0x00059F08
		public bool IsAnyRigidBodyAwake()
		{
			return UPrimitiveComponent.__IsAnyRigidBodyAwake_Internal(base.NativePtr);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0005BD15 File Offset: 0x00059F15
		[NullableContext(2)]
		public void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
		{
			UPrimitiveComponent.__IgnoreComponentWhenMoving_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bShouldIgnore);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0005BD33 File Offset: 0x00059F33
		[NullableContext(2)]
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
		{
			UPrimitiveComponent.__IgnoreActorWhenMoving_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bShouldIgnore);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0005BD51 File Offset: 0x00059F51
		public bool GetVolumeCullingActorFlag()
		{
			return UPrimitiveComponent.__GetVolumeCullingActorFlag_Internal(base.NativePtr);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0005BD5E File Offset: 0x00059F5E
		public bool GetSceneColorClearActive()
		{
			return UPrimitiveComponent.__GetSceneColorClearActive_Internal(base.NativePtr);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0005BD6B File Offset: 0x00059F6B
		public FVector GetPhysicsLinearVelocityAtPoint(FVector Point, FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsLinearVelocityAtPoint_Internal(base.NativePtr, Point, BoneName);
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x0005BD7A File Offset: 0x00059F7A
		public FVector GetPhysicsLinearVelocity(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsLinearVelocity_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x0005BD88 File Offset: 0x00059F88
		public FVector GetPhysicsAngularVelocityInRadians(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocityInRadians_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0005BD96 File Offset: 0x00059F96
		public FVector GetPhysicsAngularVelocityInDegrees(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0005BDA4 File Offset: 0x00059FA4
		public FVector GetPhysicsAngularVelocity(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocity_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0005BDB2 File Offset: 0x00059FB2
		public void GetOverlappingComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutOverlappingComponents)
		{
			UPrimitiveComponent.__GetOverlappingComponents_Internal(base.NativePtr, (OutOverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0005BDCF File Offset: 0x00059FCF
		public void GetOverlappingActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OverlappingActors, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ClassFilter = default(TSubclassOf<AActor>))
		{
			UPrimitiveComponent.__GetOverlappingActors_Internal(base.NativePtr, (OverlappingActors ?? new TArray<AActor>()).NativePtr, ClassFilter._NativePtr);
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0005BDF2 File Offset: 0x00059FF2
		public int GetNumMaterials()
		{
			return UPrimitiveComponent.__GetNumMaterials_Internal(base.NativePtr);
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0005BE00 File Offset: 0x0005A000
		[NullableContext(2)]
		public unsafe UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex, ref int SectionIndex)
		{
			fixed (int* ptr = &SectionIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UPrimitiveComponent.__GetMaterialFromCollisionFaceIndex_Internal(base.NativePtr, FaceIndex, ref SectionIndex));
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0005BE24 File Offset: 0x0005A024
		[NullableContext(2)]
		public UMaterialInterface GetMaterial(int ElementIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UPrimitiveComponent.__GetMaterial_Internal(base.NativePtr, ElementIndex));
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0005BE37 File Offset: 0x0005A037
		public float GetMassScale(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetMassScale_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0005BE45 File Offset: 0x0005A045
		public float GetMass()
		{
			return UPrimitiveComponent.__GetMass_Internal(base.NativePtr);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0005BE52 File Offset: 0x0005A052
		public float GetLinearDamping()
		{
			return UPrimitiveComponent.__GetLinearDamping_Internal(base.NativePtr);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0005BE5F File Offset: 0x0005A05F
		public FVector GetInertiaTensor(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetInertiaTensor_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0005BE6D File Offset: 0x0005A06D
		public bool GetGenerateOverlapEvents()
		{
			return UPrimitiveComponent.__GetGenerateOverlapEvents_Internal(base.NativePtr);
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0005BE7A File Offset: 0x0005A07A
		public float GetCustomPrimitiveDataByIndex(int index)
		{
			return UPrimitiveComponent.__GetCustomPrimitiveDataByIndex_Internal(base.NativePtr, index);
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0005BE88 File Offset: 0x0005A088
		[NullableContext(0)]
		public TEnumAsByte<ECollisionResponse> GetCollisionResponseToChannel(ECollisionChannel Channel)
		{
			return UPrimitiveComponent.__GetCollisionResponseToChannel_Internal(base.NativePtr, Channel);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0005BE9B File Offset: 0x0005A09B
		public FName GetCollisionProfileName()
		{
			return UPrimitiveComponent.__GetCollisionProfileName_Internal(base.NativePtr);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x0005BEA8 File Offset: 0x0005A0A8
		[NullableContext(0)]
		public TEnumAsByte<ECollisionChannel> GetCollisionObjectType()
		{
			return UPrimitiveComponent.__GetCollisionObjectType_Internal(base.NativePtr);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0005BEB5 File Offset: 0x0005A0B5
		[NullableContext(0)]
		public TEnumAsByte<ECollisionEnabled> GetCollisionEnabled()
		{
			return UPrimitiveComponent.__GetCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
		public unsafe float GetClosestPointOnCollision(in FVector Point, ref FVector OutPointOnBody, FName BoneName = default(FName))
		{
			fixed (FVector* ptr = &OutPointOnBody)
			{
				void* ptr2 = (void*)ptr;
				return UPrimitiveComponent.__GetClosestPointOnCollision_Internal(base.NativePtr, Point, ref OutPointOnBody, BoneName);
			}
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x0005BEE4 File Offset: 0x0005A0E4
		public FVector GetCenterOfMass(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetCenterOfMass_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x0005BEF2 File Offset: 0x0005A0F2
		public float GetAngularDamping()
		{
			return UPrimitiveComponent.__GetAngularDamping_Internal(base.NativePtr);
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0005BF00 File Offset: 0x0005A100
		[NullableContext(2)]
		public unsafe bool D_K2_LineTraceComponent(FVectorDouble TraceStart, FVectorDouble TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVectorDouble HitLocation, ref FVector HitNormal, ref FName BoneName, ref FHitResult OutHit)
		{
			fixed (FVectorDouble* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &HitNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						return UPrimitiveComponent.__D_K2_LineTraceComponent_Internal(base.NativePtr, TraceStart, TraceEnd, bTraceComplex, bShowTrace, bPersistentShowTrace, ref HitLocation, ref HitNormal, ref BoneName, (OutHit ?? new FHitResult()).NativePtr);
					}
				}
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0005BF4C File Offset: 0x0005A14C
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex, UMaterialInterface SourceMaterial = null, FName OptionalName = default(FName))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateDynamicMaterialInstance_Internal(base.NativePtr, ElementIndex, (SourceMaterial != null) ? SourceMaterial.NativePtr : IntPtr.Zero, OptionalName));
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x0005BF70 File Offset: 0x0005A170
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex, UMaterialInterface Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateAndSetMaterialInstanceDynamicFromMaterial_Internal(base.NativePtr, ElementIndex, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0005BF93 File Offset: 0x0005A193
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateAndSetMaterialInstanceDynamic_Internal(base.NativePtr, ElementIndex));
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0005BFA6 File Offset: 0x0005A1A6
		public TArray<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents()
		{
			return new TArray<UPrimitiveComponent>(UPrimitiveComponent.__CopyArrayOfMoveIgnoreComponents_Internal(base.NativePtr), null);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0005BFB9 File Offset: 0x0005A1B9
		public TArray<AActor> CopyArrayOfMoveIgnoreActors()
		{
			return new TArray<AActor>(UPrimitiveComponent.__CopyArrayOfMoveIgnoreActors_Internal(base.NativePtr), null);
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0005BFCC File Offset: 0x0005A1CC
		public void ClearMoveIgnoreComponents()
		{
			UPrimitiveComponent.__ClearMoveIgnoreComponents_Internal(base.NativePtr);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0005BFD9 File Offset: 0x0005A1D9
		public void ClearMoveIgnoreActors()
		{
			UPrimitiveComponent.__ClearMoveIgnoreActors_Internal(base.NativePtr);
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x0005BFE6 File Offset: 0x0005A1E6
		[NullableContext(2)]
		public bool CanCharacterStepUp(APawn Pawn)
		{
			return UPrimitiveComponent.__CanCharacterStepUp_Internal(base.NativePtr, (Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x0005C003 File Offset: 0x0005A203
		public void AddTorqueInRadians(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorqueInRadians_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x0005C013 File Offset: 0x0005A213
		public void AddTorqueInDegrees(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorqueInDegrees_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0005C023 File Offset: 0x0005A223
		public void AddTorque(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorque_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x0005C033 File Offset: 0x0005A233
		public void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddImpulseAtLocation_Internal(base.NativePtr, Impulse, Location, BoneName);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0005C043 File Offset: 0x0005A243
		public void AddImpulse(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddImpulse_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0005C053 File Offset: 0x0005A253
		public void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddForceAtLocationLocal_Internal(base.NativePtr, Force, Location, BoneName);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0005C063 File Offset: 0x0005A263
		public void AddForceAtLocation(FVector Force, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddForceAtLocation_Internal(base.NativePtr, Force, Location, BoneName);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x0005C073 File Offset: 0x0005A273
		public void AddForce(FVector Force, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddForce_Internal(base.NativePtr, Force, BoneName, bAccelChange);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0005C083 File Offset: 0x0005A283
		public void AddAngularImpulseInRadians(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulseInRadians_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0005C093 File Offset: 0x0005A293
		public void AddAngularImpulseInDegrees(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulseInDegrees_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0005C0A3 File Offset: 0x0005A2A3
		public void AddAngularImpulse(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulse_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x06003F77 RID: 16247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRendered_Internal(IntPtr @this, float Tolerance);

		// Token: 0x06003F78 RID: 16248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WakeRigidBody_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003F79 RID: 16249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WakeAllRigidBodies_Internal(IntPtr @this);

		// Token: 0x06003F7A RID: 16250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumeCullingActorFlag_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06003F7B RID: 16251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseOutlineStencilTestSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x06003F7C RID: 16252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseOutlineStencilTest_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F7D RID: 16253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseMeshBlend_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F7E RID: 16254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseKuroOpacity_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F7F RID: 16255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x06003F80 RID: 16256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleMaskSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x06003F81 RID: 16257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleMask_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F82 RID: 16258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattle_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F83 RID: 16259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomWPO_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F84 RID: 16260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomAlphaTestSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x06003F85 RID: 16261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomAlphaTest_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F86 RID: 16262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCCD_Internal(IntPtr @this, bool InUseCCD, FName BoneName);

		// Token: 0x06003F87 RID: 16263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTranslucentSortPriority_Internal(IntPtr @this, int NewTranslucentSortPriority);

		// Token: 0x06003F88 RID: 16264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x06003F89 RID: 16265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonCustomStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x06003F8A RID: 16266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSingleSampleShadowFromStationaryLights_Internal(IntPtr @this, bool bNewSingleSampleShadowFromStationaryLights);

		// Token: 0x06003F8B RID: 16267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulatePhysics_Internal(IntPtr @this, bool bSimulate);

		// Token: 0x06003F8C RID: 16268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneDissolveActive_Internal(IntPtr @this, bool bNewActive);

		// Token: 0x06003F8D RID: 16269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneColorClearActive_Internal(IntPtr @this, bool bNewActive);

		// Token: 0x06003F8E RID: 16270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderMobileSceneCustomDepth_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F8F RID: 16271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderKuroTrail_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F90 RID: 16272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInMainPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F91 RID: 16273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInDataDistortionPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F92 RID: 16274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInBurst_Internal(IntPtr @this, bool bInRenderInBurst);

		// Token: 0x06003F93 RID: 16275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderCustomDepth_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003F94 RID: 16276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceivesDecals_Internal(IntPtr @this, bool bNewReceivesDecals);

		// Token: 0x06003F95 RID: 16277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlanarReflectionRenderOffset_Internal(IntPtr @this, bool bEnable, FVector InOffsetWS);

		// Token: 0x06003F96 RID: 16278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysMaterialOverride_Internal(IntPtr @this, IntPtr NewPhysMaterial);

		// Token: 0x06003F97 RID: 16279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocityInRadians_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F98 RID: 16280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocityInDegrees_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F99 RID: 16281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocity_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F9A RID: 16282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsLinearVelocity_Internal(IntPtr @this, FVector NewVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F9B RID: 16283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocityInRadians_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F9C RID: 16284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F9D RID: 16285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocity_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x06003F9E RID: 16286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerNoSee_Internal(IntPtr @this, bool bNewOwnerNoSee);

		// Token: 0x06003F9F RID: 16287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyVisibleInSceneCapture_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003FA0 RID: 16288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyOwnerSee_Internal(IntPtr @this, bool bNewOnlyOwnerSee);

		// Token: 0x06003FA1 RID: 16289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNoVelocity_Internal(IntPtr @this, bool bInNoVelocity);

		// Token: 0x06003FA2 RID: 16290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNotifyRigidBodyCollision_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision);

		// Token: 0x06003FA3 RID: 16291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileSceneCustomDepthStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x06003FA4 RID: 16292
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshShadingRate_Internal(IntPtr @this, TEnumAsByte<EMaterialShadingRate> InMeshShadingRate);

		// Token: 0x06003FA5 RID: 16293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshBlendID_Internal(IntPtr @this, byte Value);

		// Token: 0x06003FA6 RID: 16294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialByName_Internal(IntPtr @this, FName MaterialSlotName, IntPtr Material);

		// Token: 0x06003FA7 RID: 16295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Material);

		// Token: 0x06003FA8 RID: 16296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMassScale_Internal(IntPtr @this, FName BoneName, float InMassScale);

		// Token: 0x06003FA9 RID: 16297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMassOverrideInKg_Internal(IntPtr @this, FName BoneName, float MassInKg, bool bOverrideMass);

		// Token: 0x06003FAA RID: 16298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDamping_Internal(IntPtr @this, float InDamping);

		// Token: 0x06003FAB RID: 16299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x06003FAC RID: 16300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightAttachmentsAsGroup_Internal(IntPtr @this, bool bInLightAttachmentsAsGroup);

		// Token: 0x06003FAD RID: 16301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUISortPriority_Internal(IntPtr @this, int NewTranslucentSortPriority);

		// Token: 0x06003FAE RID: 16302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIRenderAsMask_Internal(IntPtr @this, bool IsRenderAsMask);

		// Token: 0x06003FAF RID: 16303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIReadMask_Internal(IntPtr @this, bool IsLGUIReadMask);

		// Token: 0x06003FB0 RID: 16304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIOverlay_Internal(IntPtr @this, bool IsLGUIOverlayIn);

		// Token: 0x06003FB1 RID: 16305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIBeforeUpScale_Internal(IntPtr @this, bool IsLGUIBeforeUpScale);

		// Token: 0x06003FB2 RID: 16306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIBeforeBloom_Internal(IntPtr @this, bool IsLGUIAfterBlur);

		// Token: 0x06003FB3 RID: 16307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIAfterPP_Internal(IntPtr @this, bool IsLGUIAfterPPIn);

		// Token: 0x06003FB4 RID: 16308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIAfterBlur_Internal(IntPtr @this, bool IsLGUIAfterBlur);

		// Token: 0x06003FB5 RID: 16309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUI_Internal(IntPtr @this, bool IsLGUIIn);

		// Token: 0x06003FB6 RID: 16310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOpacity_Internal(IntPtr @this, float Value);

		// Token: 0x06003FB7 RID: 16311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003FB8 RID: 16312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsSpecialForLocalLightShadow_Internal(IntPtr @this, bool IsSpecial);

		// Token: 0x06003FB9 RID: 16313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsKuroLandscape_Internal(IntPtr @this, bool InIsKuroLandscape);

		// Token: 0x06003FBA RID: 16314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsHiddenInUiSceneState_Internal(IntPtr @this, bool bValue);

		// Token: 0x06003FBB RID: 16315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCastShadowWhenInCaveOrIndoor_Internal(IntPtr @this, bool IsCastShadowWhenInCaveOrIndoor);

		// Token: 0x06003FBC RID: 16316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGenerateOverlapEvents_Internal(IntPtr @this, bool bInGenerateOverlapEvents);

		// Token: 0x06003FBD RID: 16317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFOVOverride_Internal(IntPtr @this, float NewFOV);

		// Token: 0x06003FBE RID: 16318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceCastShadowInRayTracing_Internal(IntPtr @this, bool NewForceCastShadowInRayTracing);

		// Token: 0x06003FBF RID: 16319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExcludeFromLightAttachmentGroup_Internal(IntPtr @this, bool bInExcludeFromLightAttachmentGroup);

		// Token: 0x06003FC0 RID: 16320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableGravity_Internal(IntPtr @this, bool bGravityEnabled);

		// Token: 0x06003FC1 RID: 16321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector4_Internal(IntPtr @this, int DataIndex, in FVector4 Value);

		// Token: 0x06003FC2 RID: 16322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector3_Internal(IntPtr @this, int DataIndex, FVector Value);

		// Token: 0x06003FC3 RID: 16323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector2_Internal(IntPtr @this, int DataIndex, FVector2D Value);

		// Token: 0x06003FC4 RID: 16324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataFloat_Internal(IntPtr @this, int DataIndex, float Value);

		// Token: 0x06003FC5 RID: 16325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDataDistortionCullRatio_Internal(IntPtr @this, float Value);

		// Token: 0x06003FC6 RID: 16326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector4_Internal(IntPtr @this, int DataIndex, in FVector4 Value);

		// Token: 0x06003FC7 RID: 16327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector3_Internal(IntPtr @this, int DataIndex, FVector Value);

		// Token: 0x06003FC8 RID: 16328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector2_Internal(IntPtr @this, int DataIndex, FVector2D Value);

		// Token: 0x06003FC9 RID: 16329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataFloat_Internal(IntPtr @this, int DataIndex, float Value);

		// Token: 0x06003FCA RID: 16330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomDepthStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x06003FCB RID: 16331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomCullFlag_Internal(IntPtr @this, byte NewFlag);

		// Token: 0x06003FCC RID: 16332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCullDistance_Internal(IntPtr @this, float NewCullDistance);

		// Token: 0x06003FCD RID: 16333
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintMode_Internal(IntPtr @this, TEnumAsByte<EDOFMode> ConstraintMode);

		// Token: 0x06003FCE RID: 16334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannels_Internal(IntPtr @this, IntPtr NewReponses);

		// Token: 0x06003FCF RID: 16335
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x06003FD0 RID: 16336
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToAllChannels_Internal(IntPtr @this, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x06003FD1 RID: 16337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionProfileName_Internal(IntPtr @this, FName InCollisionProfileName, bool bUpdateOverlaps);

		// Token: 0x06003FD2 RID: 16338
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionObjectType_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x06003FD3 RID: 16339
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionEnabled_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> NewType);

		// Token: 0x06003FD4 RID: 16340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterOfMass_Internal(IntPtr @this, FVector CenterOfMassOffset, FName BoneName);

		// Token: 0x06003FD5 RID: 16341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadowInShadowCullVolume_Internal(IntPtr @this, bool bNewCastShadowInShadowCullVolume);

		// Token: 0x06003FD6 RID: 16342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadow_Internal(IntPtr @this, bool NewCastShadow);

		// Token: 0x06003FD7 RID: 16343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastInsetShadow_Internal(IntPtr @this, bool bInCastInsetShadow);

		// Token: 0x06003FD8 RID: 16344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastFarShadowOnMobile_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06003FD9 RID: 16345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastFarShadow_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06003FDA RID: 16346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundsScale_Internal(IntPtr @this, float NewBoundsScale);

		// Token: 0x06003FDB RID: 16347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDamping_Internal(IntPtr @this, float InDamping);

		// Token: 0x06003FDC RID: 16348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllUseCCD_Internal(IntPtr @this, bool InUseCCD);

		// Token: 0x06003FDD RID: 16349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsLinearVelocity_Internal(IntPtr @this, FVector NewVel, bool bAddToCurrent);

		// Token: 0x06003FDE RID: 16350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsAngularVelocityInRadians_Internal(IntPtr @this, in FVector NewAngVel, bool bAddToCurrent);

		// Token: 0x06003FDF RID: 16351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, in FVector NewAngVel, bool bAddToCurrent);

		// Token: 0x06003FE0 RID: 16352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMassScale_Internal(IntPtr @this, float InMassScale);

		// Token: 0x06003FE1 RID: 16353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ScaleByMomentOfInertia_Internal(IntPtr @this, FVector InputVector, FName BoneName);

		// Token: 0x06003FE2 RID: 16354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetCustomPrimitiveData_Internal(IntPtr @this);

		// Token: 0x06003FE3 RID: 16355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PutRigidBodyToSleep_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003FE4 RID: 16356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSetPassiveCollision_Internal(IntPtr @this, bool bPassiveCollision, bool bUpdateOverlaps);

		// Token: 0x06003FE5 RID: 16357
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroRemovePassiveProxyChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> CollisionChannel);

		// Token: 0x06003FE6 RID: 16358
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroAddPassiveProxyChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> CollisionChannel);

		// Token: 0x06003FE7 RID: 16359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SphereTraceComponent_Internal(IntPtr @this, FVector TraceStart, FVector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x06003FE8 RID: 16360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SphereOverlapComponent_Internal(IntPtr @this, FVector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x06003FE9 RID: 16361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_LineTraceComponent_Internal(IntPtr @this, FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x06003FEA RID: 16362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsQueryCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x06003FEB RID: 16363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsPhysicsCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x06003FEC RID: 16364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x06003FED RID: 16365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_BoxOverlapComponent_Internal(IntPtr @this, FVector InBoxCentre, FBox InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x06003FEE RID: 16366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderKuroTrail_Internal(IntPtr @this);

		// Token: 0x06003FEF RID: 16367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingComponent_Internal(IntPtr @this, IntPtr OtherComp);

		// Token: 0x06003FF0 RID: 16368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingActor_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06003FF1 RID: 16369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGravityEnabled_Internal(IntPtr @this);

		// Token: 0x06003FF2 RID: 16370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyRigidBodyAwake_Internal(IntPtr @this);

		// Token: 0x06003FF3 RID: 16371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreComponentWhenMoving_Internal(IntPtr @this, IntPtr Component, bool bShouldIgnore);

		// Token: 0x06003FF4 RID: 16372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreActorWhenMoving_Internal(IntPtr @this, IntPtr Actor, bool bShouldIgnore);

		// Token: 0x06003FF5 RID: 16373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVolumeCullingActorFlag_Internal(IntPtr @this);

		// Token: 0x06003FF6 RID: 16374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSceneColorClearActive_Internal(IntPtr @this);

		// Token: 0x06003FF7 RID: 16375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsLinearVelocityAtPoint_Internal(IntPtr @this, FVector Point, FName BoneName);

		// Token: 0x06003FF8 RID: 16376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsLinearVelocity_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003FF9 RID: 16377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocityInRadians_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003FFA RID: 16378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003FFB RID: 16379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocity_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06003FFC RID: 16380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr @this, IntPtr OutOverlappingComponents);

		// Token: 0x06003FFD RID: 16381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingActors_Internal(IntPtr @this, IntPtr OverlappingActors, IntPtr ClassFilter);

		// Token: 0x06003FFE RID: 16382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumMaterials_Internal(IntPtr @this);

		// Token: 0x06003FFF RID: 16383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialFromCollisionFaceIndex_Internal(IntPtr @this, int FaceIndex, ref int SectionIndex);

		// Token: 0x06004000 RID: 16384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterial_Internal(IntPtr @this, int ElementIndex);

		// Token: 0x06004001 RID: 16385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMassScale_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004002 RID: 16386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMass_Internal(IntPtr @this);

		// Token: 0x06004003 RID: 16387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLinearDamping_Internal(IntPtr @this);

		// Token: 0x06004004 RID: 16388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInertiaTensor_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004005 RID: 16389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGenerateOverlapEvents_Internal(IntPtr @this);

		// Token: 0x06004006 RID: 16390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCustomPrimitiveDataByIndex_Internal(IntPtr @this, int index);

		// Token: 0x06004007 RID: 16391
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionResponse> __GetCollisionResponseToChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x06004008 RID: 16392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCollisionProfileName_Internal(IntPtr @this);

		// Token: 0x06004009 RID: 16393
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionChannel> __GetCollisionObjectType_Internal(IntPtr @this);

		// Token: 0x0600400A RID: 16394
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionEnabled> __GetCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x0600400B RID: 16395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClosestPointOnCollision_Internal(IntPtr @this, in FVector Point, ref FVector OutPointOnBody, FName BoneName);

		// Token: 0x0600400C RID: 16396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCenterOfMass_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600400D RID: 16397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAngularDamping_Internal(IntPtr @this);

		// Token: 0x0600400E RID: 16398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_LineTraceComponent_Internal(IntPtr @this, FVectorDouble TraceStart, FVectorDouble TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVectorDouble HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600400F RID: 16399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this, int ElementIndex, IntPtr SourceMaterial, FName OptionalName);

		// Token: 0x06004010 RID: 16400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAndSetMaterialInstanceDynamicFromMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Parent);

		// Token: 0x06004011 RID: 16401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAndSetMaterialInstanceDynamic_Internal(IntPtr @this, int ElementIndex);

		// Token: 0x06004012 RID: 16402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyArrayOfMoveIgnoreComponents_Internal(IntPtr @this);

		// Token: 0x06004013 RID: 16403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyArrayOfMoveIgnoreActors_Internal(IntPtr @this);

		// Token: 0x06004014 RID: 16404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreComponents_Internal(IntPtr @this);

		// Token: 0x06004015 RID: 16405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreActors_Internal(IntPtr @this);

		// Token: 0x06004016 RID: 16406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStepUp_Internal(IntPtr @this, IntPtr Pawn);

		// Token: 0x06004017 RID: 16407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorqueInRadians_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x06004018 RID: 16408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorqueInDegrees_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x06004019 RID: 16409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorque_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x0600401A RID: 16410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulseAtLocation_Internal(IntPtr @this, FVector Impulse, FVector Location, FName BoneName);

		// Token: 0x0600401B RID: 16411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulse_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x0600401C RID: 16412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceAtLocationLocal_Internal(IntPtr @this, FVector Force, FVector Location, FName BoneName);

		// Token: 0x0600401D RID: 16413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceAtLocation_Internal(IntPtr @this, FVector Force, FVector Location, FName BoneName);

		// Token: 0x0600401E RID: 16414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForce_Internal(IntPtr @this, FVector Force, FName BoneName, bool bAccelChange);

		// Token: 0x0600401F RID: 16415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulseInRadians_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x06004020 RID: 16416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulseInDegrees_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x06004021 RID: 16417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulse_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x06004022 RID: 16418 RVA: 0x0005C0B3 File Offset: 0x0005A2B3
		static UPrimitiveComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrimitiveComponent");
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x0005C0C4 File Offset: 0x0005A2C4
		protected UPrimitiveComponent() : this(BuiltinUtils.AllocNativeUObject(UPrimitiveComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		protected UPrimitiveComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400181F RID: 6175
		public new const string __ObjectPath = "/Script/Engine.PrimitiveComponent";

		// Token: 0x04001820 RID: 6176
		private static IntPtr _ClassPtr;

		// Token: 0x04001821 RID: 6177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001822 RID: 6178
		internal static int __PropertyOffset_MinDrawDistance;

		// Token: 0x04001823 RID: 6179
		internal static int __PropertyOffset_LDMaxDrawDistance;

		// Token: 0x04001824 RID: 6180
		internal static int __PropertyOffset_bVolumeCullingActor;

		// Token: 0x04001825 RID: 6181
		internal static byte __PropertyMask_bVolumeCullingActor;

		// Token: 0x04001826 RID: 6182
		internal static int __PropertyOffset_FOVOverride;

		// Token: 0x04001827 RID: 6183
		internal static int __PropertyOffset_bUseKuroOpacity;

		// Token: 0x04001828 RID: 6184
		internal static byte __PropertyMask_bUseKuroOpacity;

		// Token: 0x04001829 RID: 6185
		internal static int __PropertyOffset_KuroOpacity;

		// Token: 0x0400182A RID: 6186
		internal static int __PropertyOffset_bUseMeshBlend;

		// Token: 0x0400182B RID: 6187
		internal static byte __PropertyMask_bUseMeshBlend;

		// Token: 0x0400182C RID: 6188
		internal static int __PropertyOffset_MeshBlendID;

		// Token: 0x0400182D RID: 6189
		internal static int __PropertyOffset_CachedMaxDrawDistance;

		// Token: 0x0400182E RID: 6190
		internal static int __PropertyOffset_DataDistortionCullRatio;

		// Token: 0x0400182F RID: 6191
		internal static int __PropertyOffset_bUseMaxLODAsImposter;

		// Token: 0x04001830 RID: 6192
		internal static byte __PropertyMask_bUseMaxLODAsImposter;

		// Token: 0x04001831 RID: 6193
		internal static int __PropertyOffset_bIsKuroLandscape;

		// Token: 0x04001832 RID: 6194
		internal static byte __PropertyMask_bIsKuroLandscape;

		// Token: 0x04001833 RID: 6195
		internal static int __PropertyOffset_bBatchImpostersAsInstances;

		// Token: 0x04001834 RID: 6196
		internal static byte __PropertyMask_bBatchImpostersAsInstances;

		// Token: 0x04001835 RID: 6197
		internal static int __PropertyOffset_bNeverDistanceCull;

		// Token: 0x04001836 RID: 6198
		internal static byte __PropertyMask_bNeverDistanceCull;

		// Token: 0x04001837 RID: 6199
		internal static int __PropertyOffset_bAlwaysCreatePhysicsState;

		// Token: 0x04001838 RID: 6200
		internal static byte __PropertyMask_bAlwaysCreatePhysicsState;

		// Token: 0x04001839 RID: 6201
		internal static int __PropertyOffset_bKuroPassiveCollision;

		// Token: 0x0400183A RID: 6202
		internal static byte __PropertyMask_bKuroPassiveCollision;

		// Token: 0x0400183B RID: 6203
		internal static int __PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400183C RID: 6204
		internal static byte __PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400183D RID: 6205
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x0400183E RID: 6206
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x0400183F RID: 6207
		internal static int __PropertyOffset_bAsyncOverlap;

		// Token: 0x04001840 RID: 6208
		internal static byte __PropertyMask_bAsyncOverlap;

		// Token: 0x04001841 RID: 6209
		internal static int __PropertyOffset_bKuroOverlapNotify;

		// Token: 0x04001842 RID: 6210
		internal static byte __PropertyMask_bKuroOverlapNotify;

		// Token: 0x04001843 RID: 6211
		internal static int __PropertyOffset_bReceivedAsyncOverlapResult;

		// Token: 0x04001844 RID: 6212
		internal static byte __PropertyMask_bReceivedAsyncOverlapResult;

		// Token: 0x04001845 RID: 6213
		internal static int __PropertyOffset_bMultiBodyOverlap;

		// Token: 0x04001846 RID: 6214
		internal static byte __PropertyMask_bMultiBodyOverlap;

		// Token: 0x04001847 RID: 6215
		internal static int __PropertyOffset_bTraceComplexOnMove;

		// Token: 0x04001848 RID: 6216
		internal static byte __PropertyMask_bTraceComplexOnMove;

		// Token: 0x04001849 RID: 6217
		internal static int __PropertyOffset_bReturnMaterialOnMove;

		// Token: 0x0400184A RID: 6218
		internal static byte __PropertyMask_bReturnMaterialOnMove;

		// Token: 0x0400184B RID: 6219
		internal static int __PropertyOffset_bUseViewOwnerDepthPriorityGroup;

		// Token: 0x0400184C RID: 6220
		internal static byte __PropertyMask_bUseViewOwnerDepthPriorityGroup;

		// Token: 0x0400184D RID: 6221
		internal static int __PropertyOffset_bAllowCullDistanceVolume;

		// Token: 0x0400184E RID: 6222
		internal static byte __PropertyMask_bAllowCullDistanceVolume;

		// Token: 0x0400184F RID: 6223
		internal static int __PropertyOffset_bHasMotionBlurVelocityMeshes;

		// Token: 0x04001850 RID: 6224
		internal static byte __PropertyMask_bHasMotionBlurVelocityMeshes;

		// Token: 0x04001851 RID: 6225
		internal static int __PropertyOffset_bVisibleInReflectionCaptures;

		// Token: 0x04001852 RID: 6226
		internal static byte __PropertyMask_bVisibleInReflectionCaptures;

		// Token: 0x04001853 RID: 6227
		internal static int __PropertyOffset_bVisibleInRealTimeSkyCaptures;

		// Token: 0x04001854 RID: 6228
		internal static byte __PropertyMask_bVisibleInRealTimeSkyCaptures;

		// Token: 0x04001855 RID: 6229
		internal static int __PropertyOffset_bVisibleInRayTracing;

		// Token: 0x04001856 RID: 6230
		internal static byte __PropertyMask_bVisibleInRayTracing;

		// Token: 0x04001857 RID: 6231
		internal static int __PropertyOffset_bForceVisibleInKuroRayTracing;

		// Token: 0x04001858 RID: 6232
		internal static byte __PropertyMask_bForceVisibleInKuroRayTracing;

		// Token: 0x04001859 RID: 6233
		internal static int __PropertyOffset_bRenderInMainPass;

		// Token: 0x0400185A RID: 6234
		internal static byte __PropertyMask_bRenderInMainPass;

		// Token: 0x0400185B RID: 6235
		internal static int __PropertyOffset_bRenderInDepthPass;

		// Token: 0x0400185C RID: 6236
		internal static byte __PropertyMask_bRenderInDepthPass;

		// Token: 0x0400185D RID: 6237
		internal static int __PropertyOffset_bForceOpaqueInPreZ_PC;

		// Token: 0x0400185E RID: 6238
		internal static byte __PropertyMask_bForceOpaqueInPreZ_PC;

		// Token: 0x0400185F RID: 6239
		internal static int __PropertyOffset_bRenderInCustomCapturePass;

		// Token: 0x04001860 RID: 6240
		internal static byte __PropertyMask_bRenderInCustomCapturePass;

		// Token: 0x04001861 RID: 6241
		internal static int __PropertyOffset_bRenderInDataDistortionPass;

		// Token: 0x04001862 RID: 6242
		internal static byte __PropertyMask_bRenderInDataDistortionPass;

		// Token: 0x04001863 RID: 6243
		internal static int __PropertyOffset_bOnlyVisibleInSceneCapture;

		// Token: 0x04001864 RID: 6244
		internal static byte __PropertyMask_bOnlyVisibleInSceneCapture;

		// Token: 0x04001865 RID: 6245
		internal static int __PropertyOffset_bUseCustomWPO;

		// Token: 0x04001866 RID: 6246
		internal static byte __PropertyMask_bUseCustomWPO;

		// Token: 0x04001867 RID: 6247
		internal static int __PropertyOffset_bEnablePlanarReflectionRenderOffset;

		// Token: 0x04001868 RID: 6248
		internal static byte __PropertyMask_bEnablePlanarReflectionRenderOffset;

		// Token: 0x04001869 RID: 6249
		internal static int __PropertyOffset_PlanarReflectionRenderOffsetWS;

		// Token: 0x0400186A RID: 6250
		internal static int __PropertyOffset_CustomCullFlag;

		// Token: 0x0400186B RID: 6251
		internal static int __PropertyOffset_bReceivesDecals;

		// Token: 0x0400186C RID: 6252
		internal static byte __PropertyMask_bReceivesDecals;

		// Token: 0x0400186D RID: 6253
		internal static int __PropertyOffset_bOwnerNoSee;

		// Token: 0x0400186E RID: 6254
		internal static byte __PropertyMask_bOwnerNoSee;

		// Token: 0x0400186F RID: 6255
		internal static int __PropertyOffset_bOnlyOwnerSee;

		// Token: 0x04001870 RID: 6256
		internal static byte __PropertyMask_bOnlyOwnerSee;

		// Token: 0x04001871 RID: 6257
		internal static int __PropertyOffset_bTreatAsBackgroundForOcclusion;

		// Token: 0x04001872 RID: 6258
		internal static byte __PropertyMask_bTreatAsBackgroundForOcclusion;

		// Token: 0x04001873 RID: 6259
		internal static int __PropertyOffset_bUseAsOccluder;

		// Token: 0x04001874 RID: 6260
		internal static byte __PropertyMask_bUseAsOccluder;

		// Token: 0x04001875 RID: 6261
		internal static int __PropertyOffset_bSelectable;

		// Token: 0x04001876 RID: 6262
		internal static byte __PropertyMask_bSelectable;

		// Token: 0x04001877 RID: 6263
		internal static int __PropertyOffset_bForceMipStreaming;

		// Token: 0x04001878 RID: 6264
		internal static byte __PropertyMask_bForceMipStreaming;

		// Token: 0x04001879 RID: 6265
		internal static int __PropertyOffset_bHasPerInstanceHitProxies;

		// Token: 0x0400187A RID: 6266
		internal static byte __PropertyMask_bHasPerInstanceHitProxies;

		// Token: 0x0400187B RID: 6267
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x0400187C RID: 6268
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x0400187D RID: 6269
		internal static int __PropertyOffset_ForceCastShadowInRayTracing;

		// Token: 0x0400187E RID: 6270
		internal static byte __PropertyMask_ForceCastShadowInRayTracing;

		// Token: 0x0400187F RID: 6271
		internal static int __PropertyOffset_CastRasterShadowInRayTracing;

		// Token: 0x04001880 RID: 6272
		internal static byte __PropertyMask_CastRasterShadowInRayTracing;

		// Token: 0x04001881 RID: 6273
		internal static int __PropertyOffset_MobileCastShadow;

		// Token: 0x04001882 RID: 6274
		internal static byte __PropertyMask_MobileCastShadow;

		// Token: 0x04001883 RID: 6275
		internal static int __PropertyOffset_IsSpecialForLocalLightShadow;

		// Token: 0x04001884 RID: 6276
		internal static byte __PropertyMask_IsSpecialForLocalLightShadow;

		// Token: 0x04001885 RID: 6277
		internal static int __PropertyOffset_IsUIScenePrimitive;

		// Token: 0x04001886 RID: 6278
		internal static byte __PropertyMask_IsUIScenePrimitive;

		// Token: 0x04001887 RID: 6279
		internal static int __PropertyOffset_IsHiddenInUiSceneState;

		// Token: 0x04001888 RID: 6280
		internal static byte __PropertyMask_IsHiddenInUiSceneState;

		// Token: 0x04001889 RID: 6281
		internal static int __PropertyOffset_bSceneDissolveActive;

		// Token: 0x0400188A RID: 6282
		internal static byte __PropertyMask_bSceneDissolveActive;

		// Token: 0x0400188B RID: 6283
		internal static int __PropertyOffset_bSceneColorClearActive;

		// Token: 0x0400188C RID: 6284
		internal static byte __PropertyMask_bSceneColorClearActive;

		// Token: 0x0400188D RID: 6285
		internal static int __PropertyOffset_bIsLGUIBeforeUpScale;

		// Token: 0x0400188E RID: 6286
		internal static byte __PropertyMask_bIsLGUIBeforeUpScale;

		// Token: 0x0400188F RID: 6287
		internal static int __PropertyOffset_bIsLGUIAfterBlur;

		// Token: 0x04001890 RID: 6288
		internal static byte __PropertyMask_bIsLGUIAfterBlur;

		// Token: 0x04001891 RID: 6289
		internal static int __PropertyOffset_bIsLGUIBeforeBloom;

		// Token: 0x04001892 RID: 6290
		internal static byte __PropertyMask_bIsLGUIBeforeBloom;

		// Token: 0x04001893 RID: 6291
		internal static int __PropertyOffset_bIsLGUIRenderAsMask;

		// Token: 0x04001894 RID: 6292
		internal static byte __PropertyMask_bIsLGUIRenderAsMask;

		// Token: 0x04001895 RID: 6293
		internal static int __PropertyOffset_bIsLGUIReadMask;

		// Token: 0x04001896 RID: 6294
		internal static byte __PropertyMask_bIsLGUIReadMask;

		// Token: 0x04001897 RID: 6295
		internal static int __PropertyOffset_bForbidCastToonShadow;

		// Token: 0x04001898 RID: 6296
		internal static byte __PropertyMask_bForbidCastToonShadow;

		// Token: 0x04001899 RID: 6297
		internal static int __PropertyOffset_bCastShadowWhenInCaveOrIndoor;

		// Token: 0x0400189A RID: 6298
		internal static byte __PropertyMask_bCastShadowWhenInCaveOrIndoor;

		// Token: 0x0400189B RID: 6299
		internal static int __PropertyOffset_bCastShadowInShadowCullVolume;

		// Token: 0x0400189C RID: 6300
		internal static byte __PropertyMask_bCastShadowInShadowCullVolume;

		// Token: 0x0400189D RID: 6301
		internal static int __PropertyOffset_bRenderKuroTrail;

		// Token: 0x0400189E RID: 6302
		internal static byte __PropertyMask_bRenderKuroTrail;

		// Token: 0x0400189F RID: 6303
		internal static int __PropertyOffset_bRenderHLOD;

		// Token: 0x040018A0 RID: 6304
		internal static byte __PropertyMask_bRenderHLOD;

		// Token: 0x040018A1 RID: 6305
		internal static int __PropertyOffset_bOverride_RenderInBurst;

		// Token: 0x040018A2 RID: 6306
		internal static byte __PropertyMask_bOverride_RenderInBurst;

		// Token: 0x040018A3 RID: 6307
		internal static int __PropertyOffset_bRenderInBurst;

		// Token: 0x040018A4 RID: 6308
		internal static byte __PropertyMask_bRenderInBurst;

		// Token: 0x040018A5 RID: 6309
		internal static int __PropertyOffset_bNoVelocity;

		// Token: 0x040018A6 RID: 6310
		internal static byte __PropertyMask_bNoVelocity;

		// Token: 0x040018A7 RID: 6311
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x040018A8 RID: 6312
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x040018A9 RID: 6313
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x040018AA RID: 6314
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x040018AB RID: 6315
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x040018AC RID: 6316
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x040018AD RID: 6317
		internal static int __PropertyOffset_bForceCastRaytracingShadow;

		// Token: 0x040018AE RID: 6318
		internal static byte __PropertyMask_bForceCastRaytracingShadow;

		// Token: 0x040018AF RID: 6319
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x040018B0 RID: 6320
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x040018B1 RID: 6321
		internal static int __PropertyOffset_bCastVolumetricTranslucentShadow;

		// Token: 0x040018B2 RID: 6322
		internal static byte __PropertyMask_bCastVolumetricTranslucentShadow;

		// Token: 0x040018B3 RID: 6323
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x040018B4 RID: 6324
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x040018B5 RID: 6325
		internal static int __PropertyOffset_bSelfShadowOnly;

		// Token: 0x040018B6 RID: 6326
		internal static byte __PropertyMask_bSelfShadowOnly;

		// Token: 0x040018B7 RID: 6327
		internal static int __PropertyOffset_bCastFarShadow;

		// Token: 0x040018B8 RID: 6328
		internal static byte __PropertyMask_bCastFarShadow;

		// Token: 0x040018B9 RID: 6329
		internal static int __PropertyOffset_bCastFarShadowOnMobile;

		// Token: 0x040018BA RID: 6330
		internal static byte __PropertyMask_bCastFarShadowOnMobile;

		// Token: 0x040018BB RID: 6331
		internal static int __PropertyOffset_bCastInsetShadow;

		// Token: 0x040018BC RID: 6332
		internal static byte __PropertyMask_bCastInsetShadow;

		// Token: 0x040018BD RID: 6333
		internal static int __PropertyOffset_bCastCinematicShadow;

		// Token: 0x040018BE RID: 6334
		internal static byte __PropertyMask_bCastCinematicShadow;

		// Token: 0x040018BF RID: 6335
		internal static int __PropertyOffset_bCastHiddenShadow;

		// Token: 0x040018C0 RID: 6336
		internal static byte __PropertyMask_bCastHiddenShadow;

		// Token: 0x040018C1 RID: 6337
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x040018C2 RID: 6338
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x040018C3 RID: 6339
		internal static int __PropertyOffset_bLightAsIfStatic_DEPRECATED;

		// Token: 0x040018C4 RID: 6340
		internal static byte __PropertyMask_bLightAsIfStatic_DEPRECATED;

		// Token: 0x040018C5 RID: 6341
		internal static int __PropertyOffset_bLightAttachmentsAsGroup;

		// Token: 0x040018C6 RID: 6342
		internal static byte __PropertyMask_bLightAttachmentsAsGroup;

		// Token: 0x040018C7 RID: 6343
		internal static int __PropertyOffset_bExcludeFromLightAttachmentGroup;

		// Token: 0x040018C8 RID: 6344
		internal static byte __PropertyMask_bExcludeFromLightAttachmentGroup;

		// Token: 0x040018C9 RID: 6345
		internal static int __PropertyOffset_bReceiveMobileCSMShadows;

		// Token: 0x040018CA RID: 6346
		internal static byte __PropertyMask_bReceiveMobileCSMShadows;

		// Token: 0x040018CB RID: 6347
		internal static int __PropertyOffset_bSingleSampleShadowFromStationaryLights;

		// Token: 0x040018CC RID: 6348
		internal static byte __PropertyMask_bSingleSampleShadowFromStationaryLights;

		// Token: 0x040018CD RID: 6349
		internal static int __PropertyOffset_bIgnoreRadialImpulse;

		// Token: 0x040018CE RID: 6350
		internal static byte __PropertyMask_bIgnoreRadialImpulse;

		// Token: 0x040018CF RID: 6351
		internal static int __PropertyOffset_bIgnoreRadialForce;

		// Token: 0x040018D0 RID: 6352
		internal static byte __PropertyMask_bIgnoreRadialForce;

		// Token: 0x040018D1 RID: 6353
		internal static int __PropertyOffset_bApplyImpulseOnDamage;

		// Token: 0x040018D2 RID: 6354
		internal static byte __PropertyMask_bApplyImpulseOnDamage;

		// Token: 0x040018D3 RID: 6355
		internal static int __PropertyOffset_bReplicatePhysicsToAutonomousProxy;

		// Token: 0x040018D4 RID: 6356
		internal static byte __PropertyMask_bReplicatePhysicsToAutonomousProxy;

		// Token: 0x040018D5 RID: 6357
		internal static int __PropertyOffset_bFillCollisionUnderneathForNavmesh;

		// Token: 0x040018D6 RID: 6358
		internal static byte __PropertyMask_bFillCollisionUnderneathForNavmesh;

		// Token: 0x040018D7 RID: 6359
		internal static int __PropertyOffset_AlwaysLoadOnClient;

		// Token: 0x040018D8 RID: 6360
		internal static byte __PropertyMask_AlwaysLoadOnClient;

		// Token: 0x040018D9 RID: 6361
		internal static int __PropertyOffset_AlwaysLoadOnServer;

		// Token: 0x040018DA RID: 6362
		internal static byte __PropertyMask_AlwaysLoadOnServer;

		// Token: 0x040018DB RID: 6363
		internal static int __PropertyOffset_bUseEditorCompositing;

		// Token: 0x040018DC RID: 6364
		internal static byte __PropertyMask_bUseEditorCompositing;

		// Token: 0x040018DD RID: 6365
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x040018DE RID: 6366
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x040018DF RID: 6367
		internal static int __PropertyOffset_bRenderMobileSceneCustomDepth;

		// Token: 0x040018E0 RID: 6368
		internal static byte __PropertyMask_bRenderMobileSceneCustomDepth;

		// Token: 0x040018E1 RID: 6369
		internal static int __PropertyOffset_bCanCharacterStandOn;

		// Token: 0x040018E2 RID: 6370
		internal static int __PropertyOffset_OnConveyBase;

		// Token: 0x040018E3 RID: 6371
		[Nullable(2)]
		private FComponentConveyBaseMovementSignature _OnConveyBase;

		// Token: 0x040018E4 RID: 6372
		internal static int __PropertyOffset_CanCharacterStepUpOn;

		// Token: 0x040018E5 RID: 6373
		internal static int __PropertyOffset_ToonCustomStencilValue;

		// Token: 0x040018E6 RID: 6374
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x040018E7 RID: 6375
		internal static int __PropertyOffset_MobileSceneCustomDepthStencilValue;

		// Token: 0x040018E8 RID: 6376
		internal static int __PropertyOffset_ExposeToCinematicsCustomLightYaw;

		// Token: 0x040018E9 RID: 6377
		internal static int __PropertyOffset_ExposeToCinematicsCustomLightFactor;

		// Token: 0x040018EA RID: 6378
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x040018EB RID: 6379
		internal static int __PropertyOffset_VisibilityId;

		// Token: 0x040018EC RID: 6380
		internal static int __PropertyOffset_VirtualTextureLodBias;

		// Token: 0x040018ED RID: 6381
		internal static int __PropertyOffset_VirtualTextureCullMips;

		// Token: 0x040018EE RID: 6382
		internal static int __PropertyOffset_VirtualTextureMinCoverage;

		// Token: 0x040018EF RID: 6383
		internal static int __PropertyOffset_LpvBiasMultiplier;

		// Token: 0x040018F0 RID: 6384
		internal static int __PropertyOffset_BoundsScale;

		// Token: 0x040018F1 RID: 6385
		internal static int __PropertyOffset_bBindlessPrimitive;

		// Token: 0x040018F2 RID: 6386
		internal static int __PropertyOffset_MoveIgnoreActors;

		// Token: 0x040018F3 RID: 6387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _MoveIgnoreActors;

		// Token: 0x040018F4 RID: 6388
		internal static int __PropertyOffset_MoveIgnoreComponents;

		// Token: 0x040018F5 RID: 6389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _MoveIgnoreComponents;

		// Token: 0x040018F6 RID: 6390
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x040018F7 RID: 6391
		[Nullable(2)]
		private FBodyInstance _BodyInstance;

		// Token: 0x040018F8 RID: 6392
		internal static int __PropertyOffset_OnComponentHit;

		// Token: 0x040018F9 RID: 6393
		[Nullable(2)]
		private FComponentHitSignature _OnComponentHit;

		// Token: 0x040018FA RID: 6394
		internal static int __PropertyOffset_OnComponentBeginOverlap;

		// Token: 0x040018FB RID: 6395
		[Nullable(2)]
		private FComponentBeginOverlapSignature _OnComponentBeginOverlap;

		// Token: 0x040018FC RID: 6396
		internal static int __PropertyOffset_OnComponentBeginOverlapBlock;

		// Token: 0x040018FD RID: 6397
		[Nullable(2)]
		private FComponentBeginOverlapBlockSignature _OnComponentBeginOverlapBlock;

		// Token: 0x040018FE RID: 6398
		internal static int __PropertyOffset_OnComponentBeginOverlapNoGcAlloc;

		// Token: 0x040018FF RID: 6399
		[Nullable(2)]
		private FComponentBeginOverlapSignatureNoGcAlloc _OnComponentBeginOverlapNoGcAlloc;

		// Token: 0x04001900 RID: 6400
		internal static int __PropertyOffset_OnComponentEndOverlap;

		// Token: 0x04001901 RID: 6401
		[Nullable(2)]
		private FComponentEndOverlapSignature _OnComponentEndOverlap;

		// Token: 0x04001902 RID: 6402
		internal static int __PropertyOffset_OnComponentWake;

		// Token: 0x04001903 RID: 6403
		[Nullable(2)]
		private FComponentWakeSignature _OnComponentWake;

		// Token: 0x04001904 RID: 6404
		internal static int __PropertyOffset_OnComponentSleep;

		// Token: 0x04001905 RID: 6405
		[Nullable(2)]
		private FComponentSleepSignature _OnComponentSleep;

		// Token: 0x04001906 RID: 6406
		internal static int __PropertyOffset_OnBeginCursorOver;

		// Token: 0x04001907 RID: 6407
		[Nullable(2)]
		private FComponentBeginCursorOverSignature _OnBeginCursorOver;

		// Token: 0x04001908 RID: 6408
		internal static int __PropertyOffset_OnEndCursorOver;

		// Token: 0x04001909 RID: 6409
		[Nullable(2)]
		private FComponentEndCursorOverSignature _OnEndCursorOver;

		// Token: 0x0400190A RID: 6410
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x0400190B RID: 6411
		[Nullable(2)]
		private FComponentOnClickedSignature _OnClicked;

		// Token: 0x0400190C RID: 6412
		internal static int __PropertyOffset_OnReleased;

		// Token: 0x0400190D RID: 6413
		[Nullable(2)]
		private FComponentOnReleasedSignature _OnReleased;

		// Token: 0x0400190E RID: 6414
		internal static int __PropertyOffset_OnInputTouchBegin;

		// Token: 0x0400190F RID: 6415
		[Nullable(2)]
		private FComponentOnInputTouchBeginSignature _OnInputTouchBegin;

		// Token: 0x04001910 RID: 6416
		internal static int __PropertyOffset_OnInputTouchEnd;

		// Token: 0x04001911 RID: 6417
		[Nullable(2)]
		private FComponentOnInputTouchEndSignature _OnInputTouchEnd;

		// Token: 0x04001912 RID: 6418
		internal static int __PropertyOffset_OnInputTouchEnter;

		// Token: 0x04001913 RID: 6419
		[Nullable(2)]
		private FComponentBeginTouchOverSignature _OnInputTouchEnter;

		// Token: 0x04001914 RID: 6420
		internal static int __PropertyOffset_OnInputTouchLeave;

		// Token: 0x04001915 RID: 6421
		[Nullable(2)]
		private FComponentEndTouchOverSignature _OnInputTouchLeave;

		// Token: 0x04001916 RID: 6422
		internal static int __PropertyOffset_LODParentPrimitive;
	}
}
