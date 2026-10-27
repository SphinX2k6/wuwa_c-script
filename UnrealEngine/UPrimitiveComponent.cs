using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103D RID: 4157
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimitiveComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public abstract class UPrimitiveComponent : USceneComponent, IUnrealUObject, IUnrealObject, INavRelevantInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600E9D9 RID: 59865 RVA: 0x0015B711 File Offset: 0x00159911
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrimitiveComponent._ClassPtr;
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x0015B71D File Offset: 0x0015991D
		int INavRelevantInterface.InterfaceOffset()
		{
			return UPrimitiveComponent.__InterfaceOffset_INavRelevantInterface;
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x0015B724 File Offset: 0x00159924
		// (set) Token: 0x0600E9DC RID: 59868 RVA: 0x0015B734 File Offset: 0x00159934
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

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x0015B745 File Offset: 0x00159945
		// (set) Token: 0x0600E9DE RID: 59870 RVA: 0x0015B755 File Offset: 0x00159955
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

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x0015B766 File Offset: 0x00159966
		// (set) Token: 0x0600E9E0 RID: 59872 RVA: 0x0015B77F File Offset: 0x0015997F
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

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x0015B7AF File Offset: 0x001599AF
		// (set) Token: 0x0600E9E2 RID: 59874 RVA: 0x0015B7BF File Offset: 0x001599BF
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

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x0015B7D0 File Offset: 0x001599D0
		// (set) Token: 0x0600E9E4 RID: 59876 RVA: 0x0015B7E9 File Offset: 0x001599E9
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

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600E9E5 RID: 59877 RVA: 0x0015B819 File Offset: 0x00159A19
		// (set) Token: 0x0600E9E6 RID: 59878 RVA: 0x0015B829 File Offset: 0x00159A29
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

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x0015B83A File Offset: 0x00159A3A
		// (set) Token: 0x0600E9E8 RID: 59880 RVA: 0x0015B853 File Offset: 0x00159A53
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

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600E9E9 RID: 59881 RVA: 0x0015B883 File Offset: 0x00159A83
		// (set) Token: 0x0600E9EA RID: 59882 RVA: 0x0015B893 File Offset: 0x00159A93
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

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600E9EB RID: 59883 RVA: 0x0015B8A4 File Offset: 0x00159AA4
		// (set) Token: 0x0600E9EC RID: 59884 RVA: 0x0015B8B4 File Offset: 0x00159AB4
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

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x0015B8C5 File Offset: 0x00159AC5
		// (set) Token: 0x0600E9EE RID: 59886 RVA: 0x0015B8D5 File Offset: 0x00159AD5
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

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x0015B8E6 File Offset: 0x00159AE6
		// (set) Token: 0x0600E9F0 RID: 59888 RVA: 0x0015B8FA File Offset: 0x00159AFA
		[Nullable(0)]
		public unsafe TEnumAsByte<ESceneDepthPriorityGroup> DepthPriorityGroup
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_DepthPriorityGroup);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_DepthPriorityGroup) = value;
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x0015B90F File Offset: 0x00159B0F
		// (set) Token: 0x0600E9F2 RID: 59890 RVA: 0x0015B923 File Offset: 0x00159B23
		[Nullable(0)]
		public unsafe TEnumAsByte<ESceneDepthPriorityGroup> ViewOwnerDepthPriorityGroup
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ViewOwnerDepthPriorityGroup);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ViewOwnerDepthPriorityGroup) = value;
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x0015B938 File Offset: 0x00159B38
		// (set) Token: 0x0600E9F4 RID: 59892 RVA: 0x0015B94C File Offset: 0x00159B4C
		[Nullable(0)]
		public unsafe TEnumAsByte<EIndirectLightingCacheQuality> IndirectLightingCacheQuality
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IndirectLightingCacheQuality);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_IndirectLightingCacheQuality) = value;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x0015B961 File Offset: 0x00159B61
		// (set) Token: 0x0600E9F6 RID: 59894 RVA: 0x0015B971 File Offset: 0x00159B71
		public unsafe ELightmapType LightmapType
		{
			get
			{
				return (ELightmapType)(*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LightmapType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LightmapType) = (byte)value;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x0015B982 File Offset: 0x00159B82
		// (set) Token: 0x0600E9F8 RID: 59896 RVA: 0x0015B992 File Offset: 0x00159B92
		public unsafe EHLODBatchingPolicy HLODBatchingPolicy
		{
			get
			{
				return (EHLODBatchingPolicy)(*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_HLODBatchingPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_HLODBatchingPolicy) = (byte)value;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600E9F9 RID: 59897 RVA: 0x0015B9A3 File Offset: 0x00159BA3
		// (set) Token: 0x0600E9FA RID: 59898 RVA: 0x0015B9BC File Offset: 0x00159BBC
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

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600E9FB RID: 59899 RVA: 0x0015B9EC File Offset: 0x00159BEC
		// (set) Token: 0x0600E9FC RID: 59900 RVA: 0x0015BA05 File Offset: 0x00159C05
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

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x0015BA35 File Offset: 0x00159C35
		// (set) Token: 0x0600E9FE RID: 59902 RVA: 0x0015BA4E File Offset: 0x00159C4E
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

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600E9FF RID: 59903 RVA: 0x0015BA7E File Offset: 0x00159C7E
		// (set) Token: 0x0600EA00 RID: 59904 RVA: 0x0015BA97 File Offset: 0x00159C97
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

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600EA01 RID: 59905 RVA: 0x0015BAC7 File Offset: 0x00159CC7
		// (set) Token: 0x0600EA02 RID: 59906 RVA: 0x0015BAE0 File Offset: 0x00159CE0
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

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x0015BB10 File Offset: 0x00159D10
		// (set) Token: 0x0600EA04 RID: 59908 RVA: 0x0015BB29 File Offset: 0x00159D29
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

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x0015BB59 File Offset: 0x00159D59
		// (set) Token: 0x0600EA06 RID: 59910 RVA: 0x0015BB72 File Offset: 0x00159D72
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

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600EA07 RID: 59911 RVA: 0x0015BBA2 File Offset: 0x00159DA2
		// (set) Token: 0x0600EA08 RID: 59912 RVA: 0x0015BBBB File Offset: 0x00159DBB
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

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600EA09 RID: 59913 RVA: 0x0015BBEB File Offset: 0x00159DEB
		// (set) Token: 0x0600EA0A RID: 59914 RVA: 0x0015BC04 File Offset: 0x00159E04
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

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600EA0B RID: 59915 RVA: 0x0015BC34 File Offset: 0x00159E34
		// (set) Token: 0x0600EA0C RID: 59916 RVA: 0x0015BC4D File Offset: 0x00159E4D
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

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600EA0D RID: 59917 RVA: 0x0015BC7D File Offset: 0x00159E7D
		// (set) Token: 0x0600EA0E RID: 59918 RVA: 0x0015BC96 File Offset: 0x00159E96
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

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600EA0F RID: 59919 RVA: 0x0015BCC6 File Offset: 0x00159EC6
		// (set) Token: 0x0600EA10 RID: 59920 RVA: 0x0015BCDF File Offset: 0x00159EDF
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

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600EA11 RID: 59921 RVA: 0x0015BD0F File Offset: 0x00159F0F
		// (set) Token: 0x0600EA12 RID: 59922 RVA: 0x0015BD28 File Offset: 0x00159F28
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

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x0015BD58 File Offset: 0x00159F58
		// (set) Token: 0x0600EA14 RID: 59924 RVA: 0x0015BD71 File Offset: 0x00159F71
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

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x0015BDA1 File Offset: 0x00159FA1
		// (set) Token: 0x0600EA16 RID: 59926 RVA: 0x0015BDBA File Offset: 0x00159FBA
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

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x0015BDEA File Offset: 0x00159FEA
		// (set) Token: 0x0600EA18 RID: 59928 RVA: 0x0015BE03 File Offset: 0x0015A003
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

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600EA19 RID: 59929 RVA: 0x0015BE33 File Offset: 0x0015A033
		// (set) Token: 0x0600EA1A RID: 59930 RVA: 0x0015BE4C File Offset: 0x0015A04C
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

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x0015BE7C File Offset: 0x0015A07C
		// (set) Token: 0x0600EA1C RID: 59932 RVA: 0x0015BE95 File Offset: 0x0015A095
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

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600EA1D RID: 59933 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
		// (set) Token: 0x0600EA1E RID: 59934 RVA: 0x0015BEDE File Offset: 0x0015A0DE
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

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x0015BF0E File Offset: 0x0015A10E
		// (set) Token: 0x0600EA20 RID: 59936 RVA: 0x0015BF27 File Offset: 0x0015A127
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

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600EA21 RID: 59937 RVA: 0x0015BF57 File Offset: 0x0015A157
		// (set) Token: 0x0600EA22 RID: 59938 RVA: 0x0015BF70 File Offset: 0x0015A170
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

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x0015BFA0 File Offset: 0x0015A1A0
		// (set) Token: 0x0600EA24 RID: 59940 RVA: 0x0015BFB9 File Offset: 0x0015A1B9
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

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600EA25 RID: 59941 RVA: 0x0015BFE9 File Offset: 0x0015A1E9
		// (set) Token: 0x0600EA26 RID: 59942 RVA: 0x0015C002 File Offset: 0x0015A202
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

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600EA27 RID: 59943 RVA: 0x0015C032 File Offset: 0x0015A232
		// (set) Token: 0x0600EA28 RID: 59944 RVA: 0x0015C04B File Offset: 0x0015A24B
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

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x0015C07B File Offset: 0x0015A27B
		// (set) Token: 0x0600EA2A RID: 59946 RVA: 0x0015C094 File Offset: 0x0015A294
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

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x0015C0C4 File Offset: 0x0015A2C4
		// (set) Token: 0x0600EA2C RID: 59948 RVA: 0x0015C0DD File Offset: 0x0015A2DD
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

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x0015C10D File Offset: 0x0015A30D
		// (set) Token: 0x0600EA2E RID: 59950 RVA: 0x0015C126 File Offset: 0x0015A326
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

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600EA2F RID: 59951 RVA: 0x0015C156 File Offset: 0x0015A356
		// (set) Token: 0x0600EA30 RID: 59952 RVA: 0x0015C16F File Offset: 0x0015A36F
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

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x0015C19F File Offset: 0x0015A39F
		// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x0015C1B8 File Offset: 0x0015A3B8
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

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x0015C1E8 File Offset: 0x0015A3E8
		// (set) Token: 0x0600EA34 RID: 59956 RVA: 0x0015C1FC File Offset: 0x0015A3FC
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

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600EA35 RID: 59957 RVA: 0x0015C211 File Offset: 0x0015A411
		// (set) Token: 0x0600EA36 RID: 59958 RVA: 0x0015C221 File Offset: 0x0015A421
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

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x0015C232 File Offset: 0x0015A432
		// (set) Token: 0x0600EA38 RID: 59960 RVA: 0x0015C24B File Offset: 0x0015A44B
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

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x0015C27B File Offset: 0x0015A47B
		// (set) Token: 0x0600EA3A RID: 59962 RVA: 0x0015C294 File Offset: 0x0015A494
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

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x0015C2C4 File Offset: 0x0015A4C4
		// (set) Token: 0x0600EA3C RID: 59964 RVA: 0x0015C2DD File Offset: 0x0015A4DD
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

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600EA3D RID: 59965 RVA: 0x0015C30D File Offset: 0x0015A50D
		// (set) Token: 0x0600EA3E RID: 59966 RVA: 0x0015C326 File Offset: 0x0015A526
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

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x0015C356 File Offset: 0x0015A556
		// (set) Token: 0x0600EA40 RID: 59968 RVA: 0x0015C36F File Offset: 0x0015A56F
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x0015C39F File Offset: 0x0015A59F
		// (set) Token: 0x0600EA42 RID: 59970 RVA: 0x0015C3B8 File Offset: 0x0015A5B8
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

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600EA43 RID: 59971 RVA: 0x0015C3E8 File Offset: 0x0015A5E8
		// (set) Token: 0x0600EA44 RID: 59972 RVA: 0x0015C401 File Offset: 0x0015A601
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

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600EA45 RID: 59973 RVA: 0x0015C431 File Offset: 0x0015A631
		// (set) Token: 0x0600EA46 RID: 59974 RVA: 0x0015C44A File Offset: 0x0015A64A
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

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x0015C47A File Offset: 0x0015A67A
		// (set) Token: 0x0600EA48 RID: 59976 RVA: 0x0015C493 File Offset: 0x0015A693
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

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x0015C4C3 File Offset: 0x0015A6C3
		// (set) Token: 0x0600EA4A RID: 59978 RVA: 0x0015C4DC File Offset: 0x0015A6DC
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

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600EA4B RID: 59979 RVA: 0x0015C50C File Offset: 0x0015A70C
		// (set) Token: 0x0600EA4C RID: 59980 RVA: 0x0015C525 File Offset: 0x0015A725
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

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600EA4D RID: 59981 RVA: 0x0015C555 File Offset: 0x0015A755
		// (set) Token: 0x0600EA4E RID: 59982 RVA: 0x0015C56E File Offset: 0x0015A76E
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

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600EA4F RID: 59983 RVA: 0x0015C59E File Offset: 0x0015A79E
		// (set) Token: 0x0600EA50 RID: 59984 RVA: 0x0015C5B7 File Offset: 0x0015A7B7
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

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x0015C5E7 File Offset: 0x0015A7E7
		// (set) Token: 0x0600EA52 RID: 59986 RVA: 0x0015C600 File Offset: 0x0015A800
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

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x0015C630 File Offset: 0x0015A830
		// (set) Token: 0x0600EA54 RID: 59988 RVA: 0x0015C649 File Offset: 0x0015A849
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

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x0015C679 File Offset: 0x0015A879
		// (set) Token: 0x0600EA56 RID: 59990 RVA: 0x0015C692 File Offset: 0x0015A892
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

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x0015C6C2 File Offset: 0x0015A8C2
		// (set) Token: 0x0600EA58 RID: 59992 RVA: 0x0015C6DB File Offset: 0x0015A8DB
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

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x0015C70B File Offset: 0x0015A90B
		// (set) Token: 0x0600EA5A RID: 59994 RVA: 0x0015C724 File Offset: 0x0015A924
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

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x0015C754 File Offset: 0x0015A954
		// (set) Token: 0x0600EA5C RID: 59996 RVA: 0x0015C76D File Offset: 0x0015A96D
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

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x0015C79D File Offset: 0x0015A99D
		// (set) Token: 0x0600EA5E RID: 59998 RVA: 0x0015C7B6 File Offset: 0x0015A9B6
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

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x0015C7E6 File Offset: 0x0015A9E6
		// (set) Token: 0x0600EA60 RID: 60000 RVA: 0x0015C7FF File Offset: 0x0015A9FF
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

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x0015C82F File Offset: 0x0015AA2F
		// (set) Token: 0x0600EA62 RID: 60002 RVA: 0x0015C848 File Offset: 0x0015AA48
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

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600EA63 RID: 60003 RVA: 0x0015C878 File Offset: 0x0015AA78
		// (set) Token: 0x0600EA64 RID: 60004 RVA: 0x0015C891 File Offset: 0x0015AA91
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600EA65 RID: 60005 RVA: 0x0015C8C1 File Offset: 0x0015AAC1
		// (set) Token: 0x0600EA66 RID: 60006 RVA: 0x0015C8DA File Offset: 0x0015AADA
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

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x0015C90A File Offset: 0x0015AB0A
		// (set) Token: 0x0600EA68 RID: 60008 RVA: 0x0015C923 File Offset: 0x0015AB23
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

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x0015C953 File Offset: 0x0015AB53
		// (set) Token: 0x0600EA6A RID: 60010 RVA: 0x0015C96C File Offset: 0x0015AB6C
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

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x0015C99C File Offset: 0x0015AB9C
		// (set) Token: 0x0600EA6C RID: 60012 RVA: 0x0015C9B5 File Offset: 0x0015ABB5
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

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x0015C9E5 File Offset: 0x0015ABE5
		// (set) Token: 0x0600EA6E RID: 60014 RVA: 0x0015C9FE File Offset: 0x0015ABFE
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

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600EA6F RID: 60015 RVA: 0x0015CA2E File Offset: 0x0015AC2E
		// (set) Token: 0x0600EA70 RID: 60016 RVA: 0x0015CA47 File Offset: 0x0015AC47
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

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x0015CA77 File Offset: 0x0015AC77
		// (set) Token: 0x0600EA72 RID: 60018 RVA: 0x0015CA90 File Offset: 0x0015AC90
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

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x0015CAC0 File Offset: 0x0015ACC0
		// (set) Token: 0x0600EA74 RID: 60020 RVA: 0x0015CAD9 File Offset: 0x0015ACD9
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

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x0015CB09 File Offset: 0x0015AD09
		// (set) Token: 0x0600EA76 RID: 60022 RVA: 0x0015CB22 File Offset: 0x0015AD22
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

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x0015CB52 File Offset: 0x0015AD52
		// (set) Token: 0x0600EA78 RID: 60024 RVA: 0x0015CB6B File Offset: 0x0015AD6B
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

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600EA79 RID: 60025 RVA: 0x0015CB9B File Offset: 0x0015AD9B
		// (set) Token: 0x0600EA7A RID: 60026 RVA: 0x0015CBB4 File Offset: 0x0015ADB4
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

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x0015CBE4 File Offset: 0x0015ADE4
		// (set) Token: 0x0600EA7C RID: 60028 RVA: 0x0015CBFD File Offset: 0x0015ADFD
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

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x0015CC2D File Offset: 0x0015AE2D
		// (set) Token: 0x0600EA7E RID: 60030 RVA: 0x0015CC46 File Offset: 0x0015AE46
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

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600EA7F RID: 60031 RVA: 0x0015CC76 File Offset: 0x0015AE76
		// (set) Token: 0x0600EA80 RID: 60032 RVA: 0x0015CC8F File Offset: 0x0015AE8F
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

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x0015CCBF File Offset: 0x0015AEBF
		// (set) Token: 0x0600EA82 RID: 60034 RVA: 0x0015CCD8 File Offset: 0x0015AED8
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

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x0015CD08 File Offset: 0x0015AF08
		// (set) Token: 0x0600EA84 RID: 60036 RVA: 0x0015CD21 File Offset: 0x0015AF21
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

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x0015CD51 File Offset: 0x0015AF51
		// (set) Token: 0x0600EA86 RID: 60038 RVA: 0x0015CD6A File Offset: 0x0015AF6A
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

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x0015CD9A File Offset: 0x0015AF9A
		// (set) Token: 0x0600EA88 RID: 60040 RVA: 0x0015CDB3 File Offset: 0x0015AFB3
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

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600EA89 RID: 60041 RVA: 0x0015CDE3 File Offset: 0x0015AFE3
		// (set) Token: 0x0600EA8A RID: 60042 RVA: 0x0015CDFC File Offset: 0x0015AFFC
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

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600EA8B RID: 60043 RVA: 0x0015CE2C File Offset: 0x0015B02C
		// (set) Token: 0x0600EA8C RID: 60044 RVA: 0x0015CE45 File Offset: 0x0015B045
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

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x0015CE75 File Offset: 0x0015B075
		// (set) Token: 0x0600EA8E RID: 60046 RVA: 0x0015CE8E File Offset: 0x0015B08E
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

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x0015CEBE File Offset: 0x0015B0BE
		// (set) Token: 0x0600EA90 RID: 60048 RVA: 0x0015CED7 File Offset: 0x0015B0D7
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

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x0015CF07 File Offset: 0x0015B107
		// (set) Token: 0x0600EA92 RID: 60050 RVA: 0x0015CF20 File Offset: 0x0015B120
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

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x0015CF50 File Offset: 0x0015B150
		// (set) Token: 0x0600EA94 RID: 60052 RVA: 0x0015CF69 File Offset: 0x0015B169
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

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x0015CF99 File Offset: 0x0015B199
		// (set) Token: 0x0600EA96 RID: 60054 RVA: 0x0015CFB2 File Offset: 0x0015B1B2
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

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x0015CFE2 File Offset: 0x0015B1E2
		// (set) Token: 0x0600EA98 RID: 60056 RVA: 0x0015CFFB File Offset: 0x0015B1FB
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

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x0015D02B File Offset: 0x0015B22B
		// (set) Token: 0x0600EA9A RID: 60058 RVA: 0x0015D044 File Offset: 0x0015B244
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

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x0015D074 File Offset: 0x0015B274
		// (set) Token: 0x0600EA9C RID: 60060 RVA: 0x0015D08D File Offset: 0x0015B28D
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

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x0015D0BD File Offset: 0x0015B2BD
		// (set) Token: 0x0600EA9E RID: 60062 RVA: 0x0015D0D6 File Offset: 0x0015B2D6
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

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x0015D106 File Offset: 0x0015B306
		// (set) Token: 0x0600EAA0 RID: 60064 RVA: 0x0015D11F File Offset: 0x0015B31F
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

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x0015D14F File Offset: 0x0015B34F
		// (set) Token: 0x0600EAA2 RID: 60066 RVA: 0x0015D168 File Offset: 0x0015B368
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

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x0015D198 File Offset: 0x0015B398
		// (set) Token: 0x0600EAA4 RID: 60068 RVA: 0x0015D1B1 File Offset: 0x0015B3B1
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

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x0015D1E1 File Offset: 0x0015B3E1
		// (set) Token: 0x0600EAA6 RID: 60070 RVA: 0x0015D1FA File Offset: 0x0015B3FA
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

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x0015D22A File Offset: 0x0015B42A
		// (set) Token: 0x0600EAA8 RID: 60072 RVA: 0x0015D243 File Offset: 0x0015B443
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

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x0015D273 File Offset: 0x0015B473
		// (set) Token: 0x0600EAAA RID: 60074 RVA: 0x0015D287 File Offset: 0x0015B487
		[Nullable(0)]
		public unsafe TEnumAsByte<EHasCustomNavigableGeometry> bHasCustomNavigableGeometry
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasCustomNavigableGeometry);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_bHasCustomNavigableGeometry) = value;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600EAAB RID: 60075 RVA: 0x0015D29C File Offset: 0x0015B49C
		// (set) Token: 0x0600EAAC RID: 60076 RVA: 0x0015D2AC File Offset: 0x0015B4AC
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

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600EAAD RID: 60077 RVA: 0x0015D2C0 File Offset: 0x0015B4C0
		// (set) Token: 0x0600EAAE RID: 60078 RVA: 0x0015D2F9 File Offset: 0x0015B4F9
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

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x0015D31A File Offset: 0x0015B51A
		// (set) Token: 0x0600EAB0 RID: 60080 RVA: 0x0015D32E File Offset: 0x0015B52E
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

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600EAB1 RID: 60081 RVA: 0x0015D344 File Offset: 0x0015B544
		// (set) Token: 0x0600EAB2 RID: 60082 RVA: 0x0015D37D File Offset: 0x0015B57D
		public FLightingChannels LightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LightingChannels, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600EAB3 RID: 60083 RVA: 0x0015D3A0 File Offset: 0x0015B5A0
		// (set) Token: 0x0600EAB4 RID: 60084 RVA: 0x0015D3D9 File Offset: 0x0015B5D9
		public FLightingChannels ToonLightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._ToonLightingChannels) == null)
				{
					result = (this._ToonLightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ToonLightingChannels, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_ToonLightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x0015D3FA File Offset: 0x0015B5FA
		// (set) Token: 0x0600EAB6 RID: 60086 RVA: 0x0015D40A File Offset: 0x0015B60A
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

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x0015D41B File Offset: 0x0015B61B
		// (set) Token: 0x0600EAB8 RID: 60088 RVA: 0x0015D42B File Offset: 0x0015B62B
		public unsafe ERendererStencilMask CustomDepthStencilWriteMask
		{
			get
			{
				return (ERendererStencilMask)(*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomDepthStencilWriteMask));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomDepthStencilWriteMask) = (byte)value;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600EAB9 RID: 60089 RVA: 0x0015D43C File Offset: 0x0015B63C
		// (set) Token: 0x0600EABA RID: 60090 RVA: 0x0015D44C File Offset: 0x0015B64C
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

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600EABB RID: 60091 RVA: 0x0015D45D File Offset: 0x0015B65D
		// (set) Token: 0x0600EABC RID: 60092 RVA: 0x0015D46D File Offset: 0x0015B66D
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

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600EABD RID: 60093 RVA: 0x0015D47E File Offset: 0x0015B67E
		// (set) Token: 0x0600EABE RID: 60094 RVA: 0x0015D48E File Offset: 0x0015B68E
		public unsafe ERendererStencilMask MobileSceneCustomDepthStencilWriteMask
		{
			get
			{
				return (ERendererStencilMask)(*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileSceneCustomDepthStencilWriteMask));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_MobileSceneCustomDepthStencilWriteMask) = (byte)value;
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600EABF RID: 60095 RVA: 0x0015D4A0 File Offset: 0x0015B6A0
		// (set) Token: 0x0600EAC0 RID: 60096 RVA: 0x0015D4D9 File Offset: 0x0015B6D9
		public FCustomPrimitiveData CustomPrimitiveData
		{
			get
			{
				base.FastCheckIsValid();
				FCustomPrimitiveData result;
				if ((result = this._CustomPrimitiveData) == null)
				{
					result = (this._CustomPrimitiveData = new FCustomPrimitiveData(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomPrimitiveData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCustomPrimitiveData.StaticStruct(), base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomPrimitiveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x0015D4FC File Offset: 0x0015B6FC
		// (set) Token: 0x0600EAC2 RID: 60098 RVA: 0x0015D535 File Offset: 0x0015B735
		public FCustomPrimitiveData CustomPrimitiveDataInternal
		{
			get
			{
				base.FastCheckIsValid();
				FCustomPrimitiveData result;
				if ((result = this._CustomPrimitiveDataInternal) == null)
				{
					result = (this._CustomPrimitiveDataInternal = new FCustomPrimitiveData(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomPrimitiveDataInternal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCustomPrimitiveData.StaticStruct(), base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_CustomPrimitiveDataInternal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600EAC3 RID: 60099 RVA: 0x0015D556 File Offset: 0x0015B756
		// (set) Token: 0x0600EAC4 RID: 60100 RVA: 0x0015D566 File Offset: 0x0015B766
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

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600EAC5 RID: 60101 RVA: 0x0015D577 File Offset: 0x0015B777
		// (set) Token: 0x0600EAC6 RID: 60102 RVA: 0x0015D587 File Offset: 0x0015B787
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

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600EAC7 RID: 60103 RVA: 0x0015D598 File Offset: 0x0015B798
		// (set) Token: 0x0600EAC8 RID: 60104 RVA: 0x0015D5A8 File Offset: 0x0015B7A8
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

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600EAC9 RID: 60105 RVA: 0x0015D5B9 File Offset: 0x0015B7B9
		// (set) Token: 0x0600EACA RID: 60106 RVA: 0x0015D5C9 File Offset: 0x0015B7C9
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

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600EACB RID: 60107 RVA: 0x0015D5DC File Offset: 0x0015B7DC
		// (set) Token: 0x0600EACC RID: 60108 RVA: 0x0015D615 File Offset: 0x0015B815
		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URuntimeVirtualTexture> result;
				if ((result = this._RuntimeVirtualTextures) == null)
				{
					result = (this._RuntimeVirtualTextures = new TArray<URuntimeVirtualTexture>(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_RuntimeVirtualTextures, this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextures.CopyAssign(value);
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600EACD RID: 60109 RVA: 0x0015D623 File Offset: 0x0015B823
		// (set) Token: 0x0600EACE RID: 60110 RVA: 0x0015D633 File Offset: 0x0015B833
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

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600EACF RID: 60111 RVA: 0x0015D644 File Offset: 0x0015B844
		// (set) Token: 0x0600EAD0 RID: 60112 RVA: 0x0015D654 File Offset: 0x0015B854
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

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600EAD1 RID: 60113 RVA: 0x0015D665 File Offset: 0x0015B865
		// (set) Token: 0x0600EAD2 RID: 60114 RVA: 0x0015D675 File Offset: 0x0015B875
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

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600EAD3 RID: 60115 RVA: 0x0015D686 File Offset: 0x0015B886
		// (set) Token: 0x0600EAD4 RID: 60116 RVA: 0x0015D696 File Offset: 0x0015B896
		public unsafe ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
		{
			get
			{
				return (ERuntimeVirtualTextureMainPassType)(*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureRenderPassType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrimitiveComponent.__PropertyOffset_VirtualTextureRenderPassType) = (byte)value;
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x0015D6A7 File Offset: 0x0015B8A7
		// (set) Token: 0x0600EAD6 RID: 60118 RVA: 0x0015D6B7 File Offset: 0x0015B8B7
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

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600EAD7 RID: 60119 RVA: 0x0015D6C8 File Offset: 0x0015B8C8
		// (set) Token: 0x0600EAD8 RID: 60120 RVA: 0x0015D6D8 File Offset: 0x0015B8D8
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

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x0015D6E9 File Offset: 0x0015B8E9
		// (set) Token: 0x0600EADA RID: 60122 RVA: 0x0015D6F9 File Offset: 0x0015B8F9
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

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600EADB RID: 60123 RVA: 0x0015D70C File Offset: 0x0015B90C
		// (set) Token: 0x0600EADC RID: 60124 RVA: 0x0015D745 File Offset: 0x0015B945
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

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600EADD RID: 60125 RVA: 0x0015D754 File Offset: 0x0015B954
		// (set) Token: 0x0600EADE RID: 60126 RVA: 0x0015D78D File Offset: 0x0015B98D
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

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600EADF RID: 60127 RVA: 0x0015D79C File Offset: 0x0015B99C
		// (set) Token: 0x0600EAE0 RID: 60128 RVA: 0x0015D7D5 File Offset: 0x0015B9D5
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

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600EAE1 RID: 60129 RVA: 0x0015D7F8 File Offset: 0x0015B9F8
		// (set) Token: 0x0600EAE2 RID: 60130 RVA: 0x0015D831 File Offset: 0x0015BA31
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

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600EAE3 RID: 60131 RVA: 0x0015D854 File Offset: 0x0015BA54
		// (set) Token: 0x0600EAE4 RID: 60132 RVA: 0x0015D88D File Offset: 0x0015BA8D
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

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600EAE5 RID: 60133 RVA: 0x0015D8B0 File Offset: 0x0015BAB0
		// (set) Token: 0x0600EAE6 RID: 60134 RVA: 0x0015D8E9 File Offset: 0x0015BAE9
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

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600EAE7 RID: 60135 RVA: 0x0015D90C File Offset: 0x0015BB0C
		// (set) Token: 0x0600EAE8 RID: 60136 RVA: 0x0015D945 File Offset: 0x0015BB45
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

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600EAE9 RID: 60137 RVA: 0x0015D968 File Offset: 0x0015BB68
		// (set) Token: 0x0600EAEA RID: 60138 RVA: 0x0015D9A1 File Offset: 0x0015BBA1
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

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600EAEB RID: 60139 RVA: 0x0015D9C4 File Offset: 0x0015BBC4
		// (set) Token: 0x0600EAEC RID: 60140 RVA: 0x0015D9FD File Offset: 0x0015BBFD
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

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600EAED RID: 60141 RVA: 0x0015DA20 File Offset: 0x0015BC20
		// (set) Token: 0x0600EAEE RID: 60142 RVA: 0x0015DA59 File Offset: 0x0015BC59
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

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600EAEF RID: 60143 RVA: 0x0015DA7C File Offset: 0x0015BC7C
		// (set) Token: 0x0600EAF0 RID: 60144 RVA: 0x0015DAB5 File Offset: 0x0015BCB5
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

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600EAF1 RID: 60145 RVA: 0x0015DAD8 File Offset: 0x0015BCD8
		// (set) Token: 0x0600EAF2 RID: 60146 RVA: 0x0015DB11 File Offset: 0x0015BD11
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

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600EAF3 RID: 60147 RVA: 0x0015DB34 File Offset: 0x0015BD34
		// (set) Token: 0x0600EAF4 RID: 60148 RVA: 0x0015DB6D File Offset: 0x0015BD6D
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

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x0015DB90 File Offset: 0x0015BD90
		// (set) Token: 0x0600EAF6 RID: 60150 RVA: 0x0015DBC9 File Offset: 0x0015BDC9
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

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600EAF7 RID: 60151 RVA: 0x0015DBEC File Offset: 0x0015BDEC
		// (set) Token: 0x0600EAF8 RID: 60152 RVA: 0x0015DC25 File Offset: 0x0015BE25
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

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600EAF9 RID: 60153 RVA: 0x0015DC48 File Offset: 0x0015BE48
		// (set) Token: 0x0600EAFA RID: 60154 RVA: 0x0015DC81 File Offset: 0x0015BE81
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

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600EAFB RID: 60155 RVA: 0x0015DCA4 File Offset: 0x0015BEA4
		// (set) Token: 0x0600EAFC RID: 60156 RVA: 0x0015DCDD File Offset: 0x0015BEDD
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

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x0015DD00 File Offset: 0x0015BF00
		// (set) Token: 0x0600EAFE RID: 60158 RVA: 0x0015DD39 File Offset: 0x0015BF39
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

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x0015DD5A File Offset: 0x0015BF5A
		// (set) Token: 0x0600EB00 RID: 60160 RVA: 0x0015DD6E File Offset: 0x0015BF6E
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

		// Token: 0x0600EB01 RID: 60161 RVA: 0x0015DD83 File Offset: 0x0015BF83
		public bool WasRecentlyRendered(float Tolerance = 0.2f)
		{
			return UPrimitiveComponent.__WasRecentlyRendered_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x0015DD91 File Offset: 0x0015BF91
		public void WakeRigidBody(FName BoneName = default(FName))
		{
			UPrimitiveComponent.__WakeRigidBody_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x0015DD9F File Offset: 0x0015BF9F
		public void WakeAllRigidBodies()
		{
			UPrimitiveComponent.__WakeAllRigidBodies_Internal(base.NativePtr);
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x0015DDAC File Offset: 0x0015BFAC
		[NullableContext(2)]
		public void SetWalkableSlopeOverride(in FWalkableSlopeOverride NewOverride)
		{
			UPrimitiveComponent.__SetWalkableSlopeOverride_Internal(base.NativePtr, (NewOverride ?? new FWalkableSlopeOverride()).NativePtr);
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x0015DDC9 File Offset: 0x0015BFC9
		public void SetVolumeCullingActorFlag(bool NewValue)
		{
			UPrimitiveComponent.__SetVolumeCullingActorFlag_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x0015DDD7 File Offset: 0x0015BFD7
		[NullableContext(2)]
		public void SetUseOutlineStencilTestSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseOutlineStencilTestSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x0015DDF4 File Offset: 0x0015BFF4
		public void SetUseOutlineStencilTest(bool bValue)
		{
			UPrimitiveComponent.__SetUseOutlineStencilTest_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB08 RID: 60168 RVA: 0x0015DE02 File Offset: 0x0015C002
		public void SetUseMeshBlend(bool bValue)
		{
			UPrimitiveComponent.__SetUseMeshBlend_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x0015DE10 File Offset: 0x0015C010
		public void SetUseKuroOpacity(bool bValue)
		{
			UPrimitiveComponent.__SetUseKuroOpacity_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x0015DE1E File Offset: 0x0015C01E
		[NullableContext(2)]
		public void SetUseEnableBattleSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseEnableBattleSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x0015DE3B File Offset: 0x0015C03B
		[NullableContext(2)]
		public void SetUseEnableBattleMaskSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseEnableBattleMaskSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x0015DE58 File Offset: 0x0015C058
		public void SetUseEnableBattleMask(bool bValue)
		{
			UPrimitiveComponent.__SetUseEnableBattleMask_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x0015DE66 File Offset: 0x0015C066
		public void SetUseEnableBattle(bool bValue)
		{
			UPrimitiveComponent.__SetUseEnableBattle_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x0015DE74 File Offset: 0x0015C074
		public void SetUseCustomWPO(bool bValue)
		{
			UPrimitiveComponent.__SetUseCustomWPO_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x0015DE82 File Offset: 0x0015C082
		[NullableContext(2)]
		public void SetUseCustomAlphaTestSectionMask(bool UseSectionMask, TArray<int> SectionMasks)
		{
			UPrimitiveComponent.__SetUseCustomAlphaTestSectionMask_Internal(base.NativePtr, UseSectionMask, (SectionMasks ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600EB10 RID: 60176 RVA: 0x0015DE9F File Offset: 0x0015C09F
		public void SetUseCustomAlphaTest(bool bValue)
		{
			UPrimitiveComponent.__SetUseCustomAlphaTest_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x0015DEAD File Offset: 0x0015C0AD
		public void SetUseCCD(bool InUseCCD, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetUseCCD_Internal(base.NativePtr, InUseCCD, BoneName);
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x0015DEBC File Offset: 0x0015C0BC
		public void SetTranslucentSortPriority(int NewTranslucentSortPriority)
		{
			UPrimitiveComponent.__SetTranslucentSortPriority_Internal(base.NativePtr, NewTranslucentSortPriority);
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x0015DECA File Offset: 0x0015C0CA
		public void SetToonLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			UPrimitiveComponent.__SetToonLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x0015DEDA File Offset: 0x0015C0DA
		public void SetToonCustomStencilValue(int Value)
		{
			UPrimitiveComponent.__SetToonCustomStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x0015DEE8 File Offset: 0x0015C0E8
		public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
		{
			UPrimitiveComponent.__SetSingleSampleShadowFromStationaryLights_Internal(base.NativePtr, bNewSingleSampleShadowFromStationaryLights);
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x0015DEF6 File Offset: 0x0015C0F6
		public void SetSimulatePhysics(bool bSimulate)
		{
			UPrimitiveComponent.__SetSimulatePhysics_Internal(base.NativePtr, bSimulate);
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x0015DF04 File Offset: 0x0015C104
		public void SetSceneDissolveActive(bool bNewActive)
		{
			UPrimitiveComponent.__SetSceneDissolveActive_Internal(base.NativePtr, bNewActive);
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x0015DF12 File Offset: 0x0015C112
		public void SetRenderMobileSceneCustomDepth(bool bValue)
		{
			UPrimitiveComponent.__SetRenderMobileSceneCustomDepth_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x0015DF20 File Offset: 0x0015C120
		public void SetRenderKuroTrail(bool bValue)
		{
			UPrimitiveComponent.__SetRenderKuroTrail_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x0015DF2E File Offset: 0x0015C12E
		public void SetRenderInMainPass(bool bValue)
		{
			UPrimitiveComponent.__SetRenderInMainPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x0015DF3C File Offset: 0x0015C13C
		public void SetRenderInDataDistortionPass(bool bValue)
		{
			UPrimitiveComponent.__SetRenderInDataDistortionPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x0015DF4A File Offset: 0x0015C14A
		public void SetRenderInBurst(bool bInRenderInBurst)
		{
			UPrimitiveComponent.__SetRenderInBurst_Internal(base.NativePtr, bInRenderInBurst);
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x0015DF58 File Offset: 0x0015C158
		public void SetRenderCustomDepth(bool bValue)
		{
			UPrimitiveComponent.__SetRenderCustomDepth_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x0015DF66 File Offset: 0x0015C166
		public void SetReceivesDecals(bool bNewReceivesDecals)
		{
			UPrimitiveComponent.__SetReceivesDecals_Internal(base.NativePtr, bNewReceivesDecals);
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x0015DF74 File Offset: 0x0015C174
		public void SetPlanarReflectionRenderOffset(bool bEnable, FVector InOffsetWS)
		{
			UPrimitiveComponent.__SetPlanarReflectionRenderOffset_Internal(base.NativePtr, bEnable, InOffsetWS);
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x0015DF83 File Offset: 0x0015C183
		[NullableContext(2)]
		public void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
		{
			UPrimitiveComponent.__SetPhysMaterialOverride_Internal(base.NativePtr, (NewPhysMaterial != null) ? NewPhysMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x0015DFA0 File Offset: 0x0015C1A0
		public void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocityInRadians_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x0015DFB0 File Offset: 0x0015C1B0
		public void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocityInDegrees_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB23 RID: 60195 RVA: 0x0015DFC0 File Offset: 0x0015C1C0
		public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsMaxAngularVelocity_Internal(base.NativePtr, NewMaxAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB24 RID: 60196 RVA: 0x0015DFD0 File Offset: 0x0015C1D0
		public void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsLinearVelocity_Internal(base.NativePtr, NewVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x0015DFE0 File Offset: 0x0015C1E0
		public void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocityInRadians_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x0015DFF0 File Offset: 0x0015C1F0
		public void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x0015E000 File Offset: 0x0015C200
		public void SetPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent = false, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetPhysicsAngularVelocity_Internal(base.NativePtr, NewAngVel, bAddToCurrent, BoneName);
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x0015E010 File Offset: 0x0015C210
		public void SetOwnerNoSee(bool bNewOwnerNoSee)
		{
			UPrimitiveComponent.__SetOwnerNoSee_Internal(base.NativePtr, bNewOwnerNoSee);
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x0015E01E File Offset: 0x0015C21E
		public void SetOnlyVisibleInSceneCapture(bool bValue)
		{
			UPrimitiveComponent.__SetOnlyVisibleInSceneCapture_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x0015E02C File Offset: 0x0015C22C
		public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
		{
			UPrimitiveComponent.__SetOnlyOwnerSee_Internal(base.NativePtr, bNewOnlyOwnerSee);
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x0015E03A File Offset: 0x0015C23A
		public void SetNoVelocity(bool bInNoVelocity)
		{
			UPrimitiveComponent.__SetNoVelocity_Internal(base.NativePtr, bInNoVelocity);
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x0015E048 File Offset: 0x0015C248
		public void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
		{
			UPrimitiveComponent.__SetNotifyRigidBodyCollision_Internal(base.NativePtr, bNewNotifyRigidBodyCollision);
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x0015E056 File Offset: 0x0015C256
		public void SetMobileSceneCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
		{
			UPrimitiveComponent.__SetMobileSceneCustomDepthStencilWriteMask_Internal(base.NativePtr, WriteMaskBit);
		}

		// Token: 0x0600EB2E RID: 60206 RVA: 0x0015E064 File Offset: 0x0015C264
		public void SetMobileSceneCustomDepthStencilValue(int Value)
		{
			UPrimitiveComponent.__SetMobileSceneCustomDepthStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB2F RID: 60207 RVA: 0x0015E072 File Offset: 0x0015C272
		public void SetMeshShadingRate(EMaterialShadingRate InMeshShadingRate)
		{
			UPrimitiveComponent.__SetMeshShadingRate_Internal(base.NativePtr, InMeshShadingRate);
		}

		// Token: 0x0600EB30 RID: 60208 RVA: 0x0015E085 File Offset: 0x0015C285
		public void SetMeshBlendID(byte Value)
		{
			UPrimitiveComponent.__SetMeshBlendID_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB31 RID: 60209 RVA: 0x0015E093 File Offset: 0x0015C293
		[NullableContext(2)]
		public void SetMaterialByName(FName MaterialSlotName, UMaterialInterface Material)
		{
			UPrimitiveComponent.__SetMaterialByName_Internal(base.NativePtr, MaterialSlotName, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EB32 RID: 60210 RVA: 0x0015E0B1 File Offset: 0x0015C2B1
		[NullableContext(2)]
		public void SetMaterial(int ElementIndex, UMaterialInterface Material)
		{
			UPrimitiveComponent.__SetMaterial_Internal(base.NativePtr, ElementIndex, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x0015E0CF File Offset: 0x0015C2CF
		public void SetMassScale(FName BoneName = default(FName), float InMassScale = 1f)
		{
			UPrimitiveComponent.__SetMassScale_Internal(base.NativePtr, BoneName, InMassScale);
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x0015E0DE File Offset: 0x0015C2DE
		public void SetMassOverrideInKg(FName BoneName = default(FName), float MassInKg = 1f, bool bOverrideMass = true)
		{
			UPrimitiveComponent.__SetMassOverrideInKg_Internal(base.NativePtr, BoneName, MassInKg, bOverrideMass);
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x0015E0EE File Offset: 0x0015C2EE
		public void SetLinearDamping(float InDamping)
		{
			UPrimitiveComponent.__SetLinearDamping_Internal(base.NativePtr, InDamping);
		}

		// Token: 0x0600EB36 RID: 60214 RVA: 0x0015E0FC File Offset: 0x0015C2FC
		public void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			UPrimitiveComponent.__SetLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x0015E10C File Offset: 0x0015C30C
		public void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup)
		{
			UPrimitiveComponent.__SetLightAttachmentsAsGroup_Internal(base.NativePtr, bInLightAttachmentsAsGroup);
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x0015E11A File Offset: 0x0015C31A
		public void SetLGUISortPriority(int NewTranslucentSortPriority)
		{
			UPrimitiveComponent.__SetLGUISortPriority_Internal(base.NativePtr, NewTranslucentSortPriority);
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x0015E128 File Offset: 0x0015C328
		public void SetLGUIRenderAsMask(bool IsRenderAsMask)
		{
			UPrimitiveComponent.__SetLGUIRenderAsMask_Internal(base.NativePtr, IsRenderAsMask);
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x0015E136 File Offset: 0x0015C336
		public void SetLGUIReadMask(bool IsLGUIReadMask)
		{
			UPrimitiveComponent.__SetLGUIReadMask_Internal(base.NativePtr, IsLGUIReadMask);
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x0015E144 File Offset: 0x0015C344
		public void SetLGUIOverlay(bool IsLGUIOverlayIn)
		{
			UPrimitiveComponent.__SetLGUIOverlay_Internal(base.NativePtr, IsLGUIOverlayIn);
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x0015E152 File Offset: 0x0015C352
		public void SetLGUIBeforeUpScale(bool IsLGUIBeforeUpScale)
		{
			UPrimitiveComponent.__SetLGUIBeforeUpScale_Internal(base.NativePtr, IsLGUIBeforeUpScale);
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x0015E160 File Offset: 0x0015C360
		public void SetLGUIBeforeBloom(bool IsLGUIAfterBlur)
		{
			UPrimitiveComponent.__SetLGUIBeforeBloom_Internal(base.NativePtr, IsLGUIAfterBlur);
		}

		// Token: 0x0600EB3E RID: 60222 RVA: 0x0015E16E File Offset: 0x0015C36E
		public void SetLGUIAfterPP(bool IsLGUIAfterPPIn)
		{
			UPrimitiveComponent.__SetLGUIAfterPP_Internal(base.NativePtr, IsLGUIAfterPPIn);
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x0015E17C File Offset: 0x0015C37C
		public void SetLGUIAfterBlur(bool IsLGUIAfterBlur)
		{
			UPrimitiveComponent.__SetLGUIAfterBlur_Internal(base.NativePtr, IsLGUIAfterBlur);
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x0015E18A File Offset: 0x0015C38A
		public void SetLGUI(bool IsLGUIIn)
		{
			UPrimitiveComponent.__SetLGUI_Internal(base.NativePtr, IsLGUIIn);
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x0015E198 File Offset: 0x0015C398
		public void SetKuroOpacity(float Value)
		{
			UPrimitiveComponent.__SetKuroOpacity_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x0015E1A6 File Offset: 0x0015C3A6
		public void SetIsUIScenePrimitive(bool bValue)
		{
			UPrimitiveComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x0015E1B4 File Offset: 0x0015C3B4
		public void SetIsSpecialForLocalLightShadow(bool IsSpecial)
		{
			UPrimitiveComponent.__SetIsSpecialForLocalLightShadow_Internal(base.NativePtr, IsSpecial);
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x0015E1C2 File Offset: 0x0015C3C2
		public void SetIsKuroLandscape(bool InIsKuroLandscape)
		{
			UPrimitiveComponent.__SetIsKuroLandscape_Internal(base.NativePtr, InIsKuroLandscape);
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x0015E1D0 File Offset: 0x0015C3D0
		public void SetIsHiddenInUiSceneState(bool bValue)
		{
			UPrimitiveComponent.__SetIsHiddenInUiSceneState_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x0015E1DE File Offset: 0x0015C3DE
		public void SetIsCastShadowWhenInCaveOrIndoor(bool IsCastShadowWhenInCaveOrIndoor)
		{
			UPrimitiveComponent.__SetIsCastShadowWhenInCaveOrIndoor_Internal(base.NativePtr, IsCastShadowWhenInCaveOrIndoor);
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x0015E1EC File Offset: 0x0015C3EC
		public void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)
		{
			UPrimitiveComponent.__SetGenerateOverlapEvents_Internal(base.NativePtr, bInGenerateOverlapEvents);
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x0015E1FA File Offset: 0x0015C3FA
		public void SetFOVOverride(float NewFOV)
		{
			UPrimitiveComponent.__SetFOVOverride_Internal(base.NativePtr, NewFOV);
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x0015E208 File Offset: 0x0015C408
		public void SetForceCastShadowInRayTracing(bool NewForceCastShadowInRayTracing)
		{
			UPrimitiveComponent.__SetForceCastShadowInRayTracing_Internal(base.NativePtr, NewForceCastShadowInRayTracing);
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x0015E216 File Offset: 0x0015C416
		public void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup)
		{
			UPrimitiveComponent.__SetExcludeFromLightAttachmentGroup_Internal(base.NativePtr, bInExcludeFromLightAttachmentGroup);
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x0015E224 File Offset: 0x0015C424
		public void SetEnableGravity(bool bGravityEnabled)
		{
			UPrimitiveComponent.__SetEnableGravity_Internal(base.NativePtr, bGravityEnabled);
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x0015E234 File Offset: 0x0015C434
		public unsafe void SetDefaultCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector4_Internal(base.NativePtr, DataIndex, ptr);
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x0015E265 File Offset: 0x0015C465
		public void SetDefaultCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector3_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x0015E274 File Offset: 0x0015C474
		public void SetDefaultCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataVector2_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x0015E283 File Offset: 0x0015C483
		public void SetDefaultCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			UPrimitiveComponent.__SetDefaultCustomPrimitiveDataFloat_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x0015E292 File Offset: 0x0015C492
		public void SetDataDistortionCullRatio(float Value)
		{
			UPrimitiveComponent.__SetDataDistortionCullRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x0015E2A0 File Offset: 0x0015C4A0
		public unsafe void SetCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UPrimitiveComponent.__SetCustomPrimitiveDataVector4_Internal(base.NativePtr, DataIndex, ptr);
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x0015E2D1 File Offset: 0x0015C4D1
		public void SetCustomPrimitiveDataVector3(int DataIndex, FVector Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataVector3_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x0015E2E0 File Offset: 0x0015C4E0
		public void SetCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataVector2_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x0015E2EF File Offset: 0x0015C4EF
		public void SetCustomPrimitiveDataFloat(int DataIndex, float Value)
		{
			UPrimitiveComponent.__SetCustomPrimitiveDataFloat_Internal(base.NativePtr, DataIndex, Value);
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x0015E2FE File Offset: 0x0015C4FE
		public void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
		{
			UPrimitiveComponent.__SetCustomDepthStencilWriteMask_Internal(base.NativePtr, WriteMaskBit);
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x0015E30C File Offset: 0x0015C50C
		public void SetCustomDepthStencilValue(int Value)
		{
			UPrimitiveComponent.__SetCustomDepthStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x0015E31A File Offset: 0x0015C51A
		public void SetCustomCullFlag(byte NewFlag)
		{
			UPrimitiveComponent.__SetCustomCullFlag_Internal(base.NativePtr, NewFlag);
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x0015E328 File Offset: 0x0015C528
		public void SetCullDistance(float NewCullDistance)
		{
			UPrimitiveComponent.__SetCullDistance_Internal(base.NativePtr, NewCullDistance);
		}

		// Token: 0x0600EB59 RID: 60249 RVA: 0x0015E336 File Offset: 0x0015C536
		public void SetConstraintMode(EDOFMode ConstraintMode)
		{
			UPrimitiveComponent.__SetConstraintMode_Internal(base.NativePtr, ConstraintMode);
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x0015E349 File Offset: 0x0015C549
		[NullableContext(2)]
		public void SetCollisionResponseToChannels(in FCollisionResponseContainer NewReponses)
		{
			UPrimitiveComponent.__SetCollisionResponseToChannels_Internal(base.NativePtr, (NewReponses ?? new FCollisionResponseContainer()).NativePtr);
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x0015E366 File Offset: 0x0015C566
		public void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
		{
			UPrimitiveComponent.__SetCollisionResponseToChannel_Internal(base.NativePtr, Channel, NewResponse);
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x0015E37F File Offset: 0x0015C57F
		public void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
		{
			UPrimitiveComponent.__SetCollisionResponseToAllChannels_Internal(base.NativePtr, NewResponse);
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x0015E392 File Offset: 0x0015C592
		public void SetCollisionProfileName(FName InCollisionProfileName, bool bUpdateOverlaps = true)
		{
			UPrimitiveComponent.__SetCollisionProfileName_Internal(base.NativePtr, InCollisionProfileName, bUpdateOverlaps);
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x0015E3A1 File Offset: 0x0015C5A1
		public void SetCollisionObjectType(ECollisionChannel Channel)
		{
			UPrimitiveComponent.__SetCollisionObjectType_Internal(base.NativePtr, Channel);
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x0015E3B4 File Offset: 0x0015C5B4
		public void SetCollisionEnabled(ECollisionEnabled NewType)
		{
			UPrimitiveComponent.__SetCollisionEnabled_Internal(base.NativePtr, NewType);
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x0015E3C7 File Offset: 0x0015C5C7
		public void SetCenterOfMass(FVector CenterOfMassOffset, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__SetCenterOfMass_Internal(base.NativePtr, CenterOfMassOffset, BoneName);
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x0015E3D6 File Offset: 0x0015C5D6
		public void SetCastShadow(bool NewCastShadow)
		{
			UPrimitiveComponent.__SetCastShadow_Internal(base.NativePtr, NewCastShadow);
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x0015E3E4 File Offset: 0x0015C5E4
		public void SetCastInsetShadow(bool bInCastInsetShadow)
		{
			UPrimitiveComponent.__SetCastInsetShadow_Internal(base.NativePtr, bInCastInsetShadow);
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x0015E3F2 File Offset: 0x0015C5F2
		public void SetCastFarShadowOnMobile(bool NewValue)
		{
			UPrimitiveComponent.__SetCastFarShadowOnMobile_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x0015E400 File Offset: 0x0015C600
		public void SetCastFarShadow(bool NewValue)
		{
			UPrimitiveComponent.__SetCastFarShadow_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x0015E40E File Offset: 0x0015C60E
		public void SetBoundsScale(float NewBoundsScale = 1f)
		{
			UPrimitiveComponent.__SetBoundsScale_Internal(base.NativePtr, NewBoundsScale);
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x0015E41C File Offset: 0x0015C61C
		public void SetAngularDamping(float InDamping)
		{
			UPrimitiveComponent.__SetAngularDamping_Internal(base.NativePtr, InDamping);
		}

		// Token: 0x0600EB67 RID: 60263 RVA: 0x0015E42A File Offset: 0x0015C62A
		public void SetAllUseCCD(bool InUseCCD)
		{
			UPrimitiveComponent.__SetAllUseCCD_Internal(base.NativePtr, InUseCCD);
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x0015E438 File Offset: 0x0015C638
		public void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsLinearVelocity_Internal(base.NativePtr, NewVel, bAddToCurrent);
		}

		// Token: 0x0600EB69 RID: 60265 RVA: 0x0015E447 File Offset: 0x0015C647
		public void SetAllPhysicsAngularVelocityInRadians(in FVector NewAngVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsAngularVelocityInRadians_Internal(base.NativePtr, NewAngVel, bAddToCurrent);
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x0015E456 File Offset: 0x0015C656
		public void SetAllPhysicsAngularVelocityInDegrees(in FVector NewAngVel, bool bAddToCurrent = false)
		{
			UPrimitiveComponent.__SetAllPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, NewAngVel, bAddToCurrent);
		}

		// Token: 0x0600EB6B RID: 60267 RVA: 0x0015E465 File Offset: 0x0015C665
		public void SetAllMassScale(float InMassScale = 1f)
		{
			UPrimitiveComponent.__SetAllMassScale_Internal(base.NativePtr, InMassScale);
		}

		// Token: 0x0600EB6C RID: 60268 RVA: 0x0015E473 File Offset: 0x0015C673
		public FVector ScaleByMomentOfInertia(FVector InputVector, FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__ScaleByMomentOfInertia_Internal(base.NativePtr, InputVector, BoneName);
		}

		// Token: 0x0600EB6D RID: 60269 RVA: 0x0015E482 File Offset: 0x0015C682
		public void ResetCustomPrimitiveData()
		{
			UPrimitiveComponent.__ResetCustomPrimitiveData_Internal(base.NativePtr);
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x0015E48F File Offset: 0x0015C68F
		public void PutRigidBodyToSleep(FName BoneName = default(FName))
		{
			UPrimitiveComponent.__PutRigidBodyToSleep_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x0015E49D File Offset: 0x0015C69D
		public void KuroSetPassiveCollision(bool bPassiveCollision, bool bUpdateOverlaps = true)
		{
			UPrimitiveComponent.__KuroSetPassiveCollision_Internal(base.NativePtr, bPassiveCollision, bUpdateOverlaps);
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x0015E4AC File Offset: 0x0015C6AC
		public void KuroRemovePassiveProxyChannel(ECollisionChannel CollisionChannel)
		{
			UPrimitiveComponent.__KuroRemovePassiveProxyChannel_Internal(base.NativePtr, CollisionChannel);
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x0015E4BF File Offset: 0x0015C6BF
		public void KuroAddPassiveProxyChannel(ECollisionChannel CollisionChannel)
		{
			UPrimitiveComponent.__KuroAddPassiveProxyChannel_Internal(base.NativePtr, CollisionChannel);
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x0015E4D4 File Offset: 0x0015C6D4
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

		// Token: 0x0600EB73 RID: 60275 RVA: 0x0015E524 File Offset: 0x0015C724
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

		// Token: 0x0600EB74 RID: 60276 RVA: 0x0015E570 File Offset: 0x0015C770
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

		// Token: 0x0600EB75 RID: 60277 RVA: 0x0015E5BC File Offset: 0x0015C7BC
		public bool K2_IsQueryCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsQueryCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x0015E5C9 File Offset: 0x0015C7C9
		public bool K2_IsPhysicsCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsPhysicsCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600EB77 RID: 60279 RVA: 0x0015E5D6 File Offset: 0x0015C7D6
		public bool K2_IsCollisionEnabled()
		{
			return UPrimitiveComponent.__K2_IsCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x0015E5E4 File Offset: 0x0015C7E4
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

		// Token: 0x0600EB79 RID: 60281 RVA: 0x0015E630 File Offset: 0x0015C830
		public bool IsRenderKuroTrail()
		{
			return UPrimitiveComponent.__IsRenderKuroTrail_Internal(base.NativePtr);
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x0015E63D File Offset: 0x0015C83D
		[NullableContext(2)]
		public bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
		{
			return UPrimitiveComponent.__IsOverlappingComponent_Internal(base.NativePtr, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x0015E65A File Offset: 0x0015C85A
		[NullableContext(2)]
		public bool IsOverlappingActor(AActor Other)
		{
			return UPrimitiveComponent.__IsOverlappingActor_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x0015E677 File Offset: 0x0015C877
		public bool IsGravityEnabled()
		{
			return UPrimitiveComponent.__IsGravityEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600EB7D RID: 60285 RVA: 0x0015E684 File Offset: 0x0015C884
		public bool IsAnyRigidBodyAwake()
		{
			return UPrimitiveComponent.__IsAnyRigidBodyAwake_Internal(base.NativePtr);
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x0015E691 File Offset: 0x0015C891
		[NullableContext(2)]
		public void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
		{
			UPrimitiveComponent.__IgnoreComponentWhenMoving_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bShouldIgnore);
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x0015E6AF File Offset: 0x0015C8AF
		[NullableContext(2)]
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
		{
			UPrimitiveComponent.__IgnoreActorWhenMoving_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bShouldIgnore);
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x0015E6CD File Offset: 0x0015C8CD
		public FWalkableSlopeOverride GetWalkableSlopeOverride()
		{
			return new FWalkableSlopeOverride(UPrimitiveComponent.__GetWalkableSlopeOverride_Internal(base.NativePtr), null);
		}

		// Token: 0x0600EB81 RID: 60289 RVA: 0x0015E6E0 File Offset: 0x0015C8E0
		public bool GetVolumeCullingActorFlag()
		{
			return UPrimitiveComponent.__GetVolumeCullingActorFlag_Internal(base.NativePtr);
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x0015E6ED File Offset: 0x0015C8ED
		public FVector GetPhysicsLinearVelocityAtPoint(FVector Point, FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsLinearVelocityAtPoint_Internal(base.NativePtr, Point, BoneName);
		}

		// Token: 0x0600EB83 RID: 60291 RVA: 0x0015E6FC File Offset: 0x0015C8FC
		public FVector GetPhysicsLinearVelocity(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsLinearVelocity_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB84 RID: 60292 RVA: 0x0015E70A File Offset: 0x0015C90A
		public FVector GetPhysicsAngularVelocityInRadians(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocityInRadians_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x0015E718 File Offset: 0x0015C918
		public FVector GetPhysicsAngularVelocityInDegrees(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocityInDegrees_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x0015E726 File Offset: 0x0015C926
		public FVector GetPhysicsAngularVelocity(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetPhysicsAngularVelocity_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x0015E734 File Offset: 0x0015C934
		public void GetOverlappingComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutOverlappingComponents)
		{
			UPrimitiveComponent.__GetOverlappingComponents_Internal(base.NativePtr, (OutOverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x0015E751 File Offset: 0x0015C951
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

		// Token: 0x0600EB89 RID: 60297 RVA: 0x0015E774 File Offset: 0x0015C974
		public int GetNumMaterials()
		{
			return UPrimitiveComponent.__GetNumMaterials_Internal(base.NativePtr);
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x0015E784 File Offset: 0x0015C984
		[NullableContext(2)]
		public unsafe UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex, ref int SectionIndex)
		{
			fixed (int* ptr = &SectionIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UPrimitiveComponent.__GetMaterialFromCollisionFaceIndex_Internal(base.NativePtr, FaceIndex, ref SectionIndex));
			}
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x0015E7A8 File Offset: 0x0015C9A8
		[NullableContext(2)]
		public UMaterialInterface GetMaterial(int ElementIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UPrimitiveComponent.__GetMaterial_Internal(base.NativePtr, ElementIndex));
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x0015E7BB File Offset: 0x0015C9BB
		public float GetMassScale(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetMassScale_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x0015E7C9 File Offset: 0x0015C9C9
		public float GetMass()
		{
			return UPrimitiveComponent.__GetMass_Internal(base.NativePtr);
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x0015E7D6 File Offset: 0x0015C9D6
		public float GetLinearDamping()
		{
			return UPrimitiveComponent.__GetLinearDamping_Internal(base.NativePtr);
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x0015E7E3 File Offset: 0x0015C9E3
		public FVector GetInertiaTensor(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetInertiaTensor_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x0015E7F1 File Offset: 0x0015C9F1
		public bool GetGenerateOverlapEvents()
		{
			return UPrimitiveComponent.__GetGenerateOverlapEvents_Internal(base.NativePtr);
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x0015E7FE File Offset: 0x0015C9FE
		public float GetCustomPrimitiveDataByIndex(int index)
		{
			return UPrimitiveComponent.__GetCustomPrimitiveDataByIndex_Internal(base.NativePtr, index);
		}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x0015E80C File Offset: 0x0015CA0C
		[NullableContext(0)]
		public TEnumAsByte<ECollisionResponse> GetCollisionResponseToChannel(ECollisionChannel Channel)
		{
			return UPrimitiveComponent.__GetCollisionResponseToChannel_Internal(base.NativePtr, Channel);
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x0015E81F File Offset: 0x0015CA1F
		public FName GetCollisionProfileName()
		{
			return UPrimitiveComponent.__GetCollisionProfileName_Internal(base.NativePtr);
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x0015E82C File Offset: 0x0015CA2C
		[NullableContext(0)]
		public TEnumAsByte<ECollisionChannel> GetCollisionObjectType()
		{
			return UPrimitiveComponent.__GetCollisionObjectType_Internal(base.NativePtr);
		}

		// Token: 0x0600EB95 RID: 60309 RVA: 0x0015E839 File Offset: 0x0015CA39
		[NullableContext(0)]
		public TEnumAsByte<ECollisionEnabled> GetCollisionEnabled()
		{
			return UPrimitiveComponent.__GetCollisionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600EB96 RID: 60310 RVA: 0x0015E848 File Offset: 0x0015CA48
		public unsafe float GetClosestPointOnCollision(in FVector Point, ref FVector OutPointOnBody, FName BoneName = default(FName))
		{
			fixed (FVector* ptr = &OutPointOnBody)
			{
				void* ptr2 = (void*)ptr;
				return UPrimitiveComponent.__GetClosestPointOnCollision_Internal(base.NativePtr, Point, ref OutPointOnBody, BoneName);
			}
		}

		// Token: 0x0600EB97 RID: 60311 RVA: 0x0015E868 File Offset: 0x0015CA68
		public FVector GetCenterOfMass(FName BoneName = default(FName))
		{
			return UPrimitiveComponent.__GetCenterOfMass_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600EB98 RID: 60312 RVA: 0x0015E876 File Offset: 0x0015CA76
		public float GetAngularDamping()
		{
			return UPrimitiveComponent.__GetAngularDamping_Internal(base.NativePtr);
		}

		// Token: 0x0600EB99 RID: 60313 RVA: 0x0015E884 File Offset: 0x0015CA84
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

		// Token: 0x0600EB9A RID: 60314 RVA: 0x0015E8D0 File Offset: 0x0015CAD0
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex, UMaterialInterface SourceMaterial = null, FName OptionalName = default(FName))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateDynamicMaterialInstance_Internal(base.NativePtr, ElementIndex, (SourceMaterial != null) ? SourceMaterial.NativePtr : IntPtr.Zero, OptionalName));
		}

		// Token: 0x0600EB9B RID: 60315 RVA: 0x0015E8F4 File Offset: 0x0015CAF4
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex, UMaterialInterface Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateAndSetMaterialInstanceDynamicFromMaterial_Internal(base.NativePtr, ElementIndex, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x0015E917 File Offset: 0x0015CB17
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UPrimitiveComponent.__CreateAndSetMaterialInstanceDynamic_Internal(base.NativePtr, ElementIndex));
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x0015E92A File Offset: 0x0015CB2A
		public TArray<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents()
		{
			return new TArray<UPrimitiveComponent>(UPrimitiveComponent.__CopyArrayOfMoveIgnoreComponents_Internal(base.NativePtr), null);
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x0015E93D File Offset: 0x0015CB3D
		public TArray<AActor> CopyArrayOfMoveIgnoreActors()
		{
			return new TArray<AActor>(UPrimitiveComponent.__CopyArrayOfMoveIgnoreActors_Internal(base.NativePtr), null);
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x0015E950 File Offset: 0x0015CB50
		public void ClearMoveIgnoreComponents()
		{
			UPrimitiveComponent.__ClearMoveIgnoreComponents_Internal(base.NativePtr);
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x0015E95D File Offset: 0x0015CB5D
		public void ClearMoveIgnoreActors()
		{
			UPrimitiveComponent.__ClearMoveIgnoreActors_Internal(base.NativePtr);
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x0015E96A File Offset: 0x0015CB6A
		[NullableContext(2)]
		public bool CanCharacterStepUp(APawn Pawn)
		{
			return UPrimitiveComponent.__CanCharacterStepUp_Internal(base.NativePtr, (Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x0015E987 File Offset: 0x0015CB87
		public void AddTorqueInRadians(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorqueInRadians_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x0015E997 File Offset: 0x0015CB97
		public void AddTorqueInDegrees(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorqueInDegrees_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x0600EBA4 RID: 60324 RVA: 0x0015E9A7 File Offset: 0x0015CBA7
		public void AddTorque(FVector Torque, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddTorque_Internal(base.NativePtr, Torque, BoneName, bAccelChange);
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x0015E9B7 File Offset: 0x0015CBB7
		public void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange = false)
		{
			UPrimitiveComponent.__AddRadialImpulse_Internal(base.NativePtr, Origin, Radius, Strength, Falloff, bVelChange);
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x0015E9D0 File Offset: 0x0015CBD0
		public void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddRadialForce_Internal(base.NativePtr, Origin, Radius, Strength, Falloff, bAccelChange);
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x0015E9E9 File Offset: 0x0015CBE9
		public void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddImpulseAtLocation_Internal(base.NativePtr, Impulse, Location, BoneName);
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x0015E9F9 File Offset: 0x0015CBF9
		public void AddImpulse(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddImpulse_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x0015EA09 File Offset: 0x0015CC09
		public void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddForceAtLocationLocal_Internal(base.NativePtr, Force, Location, BoneName);
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x0015EA19 File Offset: 0x0015CC19
		public void AddForceAtLocation(FVector Force, FVector Location, FName BoneName = default(FName))
		{
			UPrimitiveComponent.__AddForceAtLocation_Internal(base.NativePtr, Force, Location, BoneName);
		}

		// Token: 0x0600EBAB RID: 60331 RVA: 0x0015EA29 File Offset: 0x0015CC29
		public void AddForce(FVector Force, FName BoneName = default(FName), bool bAccelChange = false)
		{
			UPrimitiveComponent.__AddForce_Internal(base.NativePtr, Force, BoneName, bAccelChange);
		}

		// Token: 0x0600EBAC RID: 60332 RVA: 0x0015EA39 File Offset: 0x0015CC39
		public void AddAngularImpulseInRadians(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulseInRadians_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x0015EA49 File Offset: 0x0015CC49
		public void AddAngularImpulseInDegrees(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulseInDegrees_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x0015EA59 File Offset: 0x0015CC59
		public void AddAngularImpulse(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false)
		{
			UPrimitiveComponent.__AddAngularImpulse_Internal(base.NativePtr, Impulse, BoneName, bVelChange);
		}

		// Token: 0x0600EBAF RID: 60335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRendered_Internal(IntPtr @this, float Tolerance);

		// Token: 0x0600EBB0 RID: 60336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WakeRigidBody_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EBB1 RID: 60337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WakeAllRigidBodies_Internal(IntPtr @this);

		// Token: 0x0600EBB2 RID: 60338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWalkableSlopeOverride_Internal(IntPtr @this, IntPtr NewOverride);

		// Token: 0x0600EBB3 RID: 60339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumeCullingActorFlag_Internal(IntPtr @this, bool NewValue);

		// Token: 0x0600EBB4 RID: 60340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseOutlineStencilTestSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x0600EBB5 RID: 60341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseOutlineStencilTest_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBB6 RID: 60342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseMeshBlend_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBB7 RID: 60343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseKuroOpacity_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBB8 RID: 60344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x0600EBB9 RID: 60345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleMaskSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x0600EBBA RID: 60346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattleMask_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBBB RID: 60347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseEnableBattle_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBBC RID: 60348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomWPO_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBBD RID: 60349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomAlphaTestSectionMask_Internal(IntPtr @this, bool UseSectionMask, IntPtr SectionMasks);

		// Token: 0x0600EBBE RID: 60350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomAlphaTest_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBBF RID: 60351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCCD_Internal(IntPtr @this, bool InUseCCD, FName BoneName);

		// Token: 0x0600EBC0 RID: 60352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTranslucentSortPriority_Internal(IntPtr @this, int NewTranslucentSortPriority);

		// Token: 0x0600EBC1 RID: 60353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x0600EBC2 RID: 60354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonCustomStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x0600EBC3 RID: 60355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSingleSampleShadowFromStationaryLights_Internal(IntPtr @this, bool bNewSingleSampleShadowFromStationaryLights);

		// Token: 0x0600EBC4 RID: 60356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulatePhysics_Internal(IntPtr @this, bool bSimulate);

		// Token: 0x0600EBC5 RID: 60357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneDissolveActive_Internal(IntPtr @this, bool bNewActive);

		// Token: 0x0600EBC6 RID: 60358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderMobileSceneCustomDepth_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBC7 RID: 60359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderKuroTrail_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBC8 RID: 60360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInMainPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBC9 RID: 60361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInDataDistortionPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBCA RID: 60362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInBurst_Internal(IntPtr @this, bool bInRenderInBurst);

		// Token: 0x0600EBCB RID: 60363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderCustomDepth_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBCC RID: 60364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceivesDecals_Internal(IntPtr @this, bool bNewReceivesDecals);

		// Token: 0x0600EBCD RID: 60365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlanarReflectionRenderOffset_Internal(IntPtr @this, bool bEnable, FVector InOffsetWS);

		// Token: 0x0600EBCE RID: 60366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysMaterialOverride_Internal(IntPtr @this, IntPtr NewPhysMaterial);

		// Token: 0x0600EBCF RID: 60367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocityInRadians_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD0 RID: 60368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocityInDegrees_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD1 RID: 60369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsMaxAngularVelocity_Internal(IntPtr @this, float NewMaxAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD2 RID: 60370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsLinearVelocity_Internal(IntPtr @this, FVector NewVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD3 RID: 60371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocityInRadians_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD4 RID: 60372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD5 RID: 60373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAngularVelocity_Internal(IntPtr @this, FVector NewAngVel, bool bAddToCurrent, FName BoneName);

		// Token: 0x0600EBD6 RID: 60374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerNoSee_Internal(IntPtr @this, bool bNewOwnerNoSee);

		// Token: 0x0600EBD7 RID: 60375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyVisibleInSceneCapture_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBD8 RID: 60376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyOwnerSee_Internal(IntPtr @this, bool bNewOnlyOwnerSee);

		// Token: 0x0600EBD9 RID: 60377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNoVelocity_Internal(IntPtr @this, bool bInNoVelocity);

		// Token: 0x0600EBDA RID: 60378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNotifyRigidBodyCollision_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision);

		// Token: 0x0600EBDB RID: 60379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileSceneCustomDepthStencilWriteMask_Internal(IntPtr @this, ERendererStencilMask WriteMaskBit);

		// Token: 0x0600EBDC RID: 60380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileSceneCustomDepthStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x0600EBDD RID: 60381
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshShadingRate_Internal(IntPtr @this, TEnumAsByte<EMaterialShadingRate> InMeshShadingRate);

		// Token: 0x0600EBDE RID: 60382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshBlendID_Internal(IntPtr @this, byte Value);

		// Token: 0x0600EBDF RID: 60383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialByName_Internal(IntPtr @this, FName MaterialSlotName, IntPtr Material);

		// Token: 0x0600EBE0 RID: 60384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Material);

		// Token: 0x0600EBE1 RID: 60385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMassScale_Internal(IntPtr @this, FName BoneName, float InMassScale);

		// Token: 0x0600EBE2 RID: 60386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMassOverrideInKg_Internal(IntPtr @this, FName BoneName, float MassInKg, bool bOverrideMass);

		// Token: 0x0600EBE3 RID: 60387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDamping_Internal(IntPtr @this, float InDamping);

		// Token: 0x0600EBE4 RID: 60388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x0600EBE5 RID: 60389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightAttachmentsAsGroup_Internal(IntPtr @this, bool bInLightAttachmentsAsGroup);

		// Token: 0x0600EBE6 RID: 60390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUISortPriority_Internal(IntPtr @this, int NewTranslucentSortPriority);

		// Token: 0x0600EBE7 RID: 60391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIRenderAsMask_Internal(IntPtr @this, bool IsRenderAsMask);

		// Token: 0x0600EBE8 RID: 60392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIReadMask_Internal(IntPtr @this, bool IsLGUIReadMask);

		// Token: 0x0600EBE9 RID: 60393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIOverlay_Internal(IntPtr @this, bool IsLGUIOverlayIn);

		// Token: 0x0600EBEA RID: 60394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIBeforeUpScale_Internal(IntPtr @this, bool IsLGUIBeforeUpScale);

		// Token: 0x0600EBEB RID: 60395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIBeforeBloom_Internal(IntPtr @this, bool IsLGUIAfterBlur);

		// Token: 0x0600EBEC RID: 60396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIAfterPP_Internal(IntPtr @this, bool IsLGUIAfterPPIn);

		// Token: 0x0600EBED RID: 60397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIAfterBlur_Internal(IntPtr @this, bool IsLGUIAfterBlur);

		// Token: 0x0600EBEE RID: 60398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUI_Internal(IntPtr @this, bool IsLGUIIn);

		// Token: 0x0600EBEF RID: 60399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOpacity_Internal(IntPtr @this, float Value);

		// Token: 0x0600EBF0 RID: 60400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBF1 RID: 60401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsSpecialForLocalLightShadow_Internal(IntPtr @this, bool IsSpecial);

		// Token: 0x0600EBF2 RID: 60402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsKuroLandscape_Internal(IntPtr @this, bool InIsKuroLandscape);

		// Token: 0x0600EBF3 RID: 60403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsHiddenInUiSceneState_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600EBF4 RID: 60404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCastShadowWhenInCaveOrIndoor_Internal(IntPtr @this, bool IsCastShadowWhenInCaveOrIndoor);

		// Token: 0x0600EBF5 RID: 60405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGenerateOverlapEvents_Internal(IntPtr @this, bool bInGenerateOverlapEvents);

		// Token: 0x0600EBF6 RID: 60406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFOVOverride_Internal(IntPtr @this, float NewFOV);

		// Token: 0x0600EBF7 RID: 60407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceCastShadowInRayTracing_Internal(IntPtr @this, bool NewForceCastShadowInRayTracing);

		// Token: 0x0600EBF8 RID: 60408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExcludeFromLightAttachmentGroup_Internal(IntPtr @this, bool bInExcludeFromLightAttachmentGroup);

		// Token: 0x0600EBF9 RID: 60409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableGravity_Internal(IntPtr @this, bool bGravityEnabled);

		// Token: 0x0600EBFA RID: 60410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector4_Internal(IntPtr @this, int DataIndex, in FVector4 Value);

		// Token: 0x0600EBFB RID: 60411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector3_Internal(IntPtr @this, int DataIndex, FVector Value);

		// Token: 0x0600EBFC RID: 60412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataVector2_Internal(IntPtr @this, int DataIndex, FVector2D Value);

		// Token: 0x0600EBFD RID: 60413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultCustomPrimitiveDataFloat_Internal(IntPtr @this, int DataIndex, float Value);

		// Token: 0x0600EBFE RID: 60414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDataDistortionCullRatio_Internal(IntPtr @this, float Value);

		// Token: 0x0600EBFF RID: 60415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector4_Internal(IntPtr @this, int DataIndex, in FVector4 Value);

		// Token: 0x0600EC00 RID: 60416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector3_Internal(IntPtr @this, int DataIndex, FVector Value);

		// Token: 0x0600EC01 RID: 60417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataVector2_Internal(IntPtr @this, int DataIndex, FVector2D Value);

		// Token: 0x0600EC02 RID: 60418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPrimitiveDataFloat_Internal(IntPtr @this, int DataIndex, float Value);

		// Token: 0x0600EC03 RID: 60419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomDepthStencilWriteMask_Internal(IntPtr @this, ERendererStencilMask WriteMaskBit);

		// Token: 0x0600EC04 RID: 60420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomDepthStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x0600EC05 RID: 60421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomCullFlag_Internal(IntPtr @this, byte NewFlag);

		// Token: 0x0600EC06 RID: 60422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCullDistance_Internal(IntPtr @this, float NewCullDistance);

		// Token: 0x0600EC07 RID: 60423
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintMode_Internal(IntPtr @this, TEnumAsByte<EDOFMode> ConstraintMode);

		// Token: 0x0600EC08 RID: 60424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannels_Internal(IntPtr @this, IntPtr NewReponses);

		// Token: 0x0600EC09 RID: 60425
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x0600EC0A RID: 60426
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToAllChannels_Internal(IntPtr @this, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x0600EC0B RID: 60427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionProfileName_Internal(IntPtr @this, FName InCollisionProfileName, bool bUpdateOverlaps);

		// Token: 0x0600EC0C RID: 60428
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionObjectType_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x0600EC0D RID: 60429
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionEnabled_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> NewType);

		// Token: 0x0600EC0E RID: 60430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterOfMass_Internal(IntPtr @this, FVector CenterOfMassOffset, FName BoneName);

		// Token: 0x0600EC0F RID: 60431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadow_Internal(IntPtr @this, bool NewCastShadow);

		// Token: 0x0600EC10 RID: 60432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastInsetShadow_Internal(IntPtr @this, bool bInCastInsetShadow);

		// Token: 0x0600EC11 RID: 60433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastFarShadowOnMobile_Internal(IntPtr @this, bool NewValue);

		// Token: 0x0600EC12 RID: 60434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastFarShadow_Internal(IntPtr @this, bool NewValue);

		// Token: 0x0600EC13 RID: 60435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundsScale_Internal(IntPtr @this, float NewBoundsScale);

		// Token: 0x0600EC14 RID: 60436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDamping_Internal(IntPtr @this, float InDamping);

		// Token: 0x0600EC15 RID: 60437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllUseCCD_Internal(IntPtr @this, bool InUseCCD);

		// Token: 0x0600EC16 RID: 60438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsLinearVelocity_Internal(IntPtr @this, FVector NewVel, bool bAddToCurrent);

		// Token: 0x0600EC17 RID: 60439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsAngularVelocityInRadians_Internal(IntPtr @this, in FVector NewAngVel, bool bAddToCurrent);

		// Token: 0x0600EC18 RID: 60440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, in FVector NewAngVel, bool bAddToCurrent);

		// Token: 0x0600EC19 RID: 60441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMassScale_Internal(IntPtr @this, float InMassScale);

		// Token: 0x0600EC1A RID: 60442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ScaleByMomentOfInertia_Internal(IntPtr @this, FVector InputVector, FName BoneName);

		// Token: 0x0600EC1B RID: 60443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetCustomPrimitiveData_Internal(IntPtr @this);

		// Token: 0x0600EC1C RID: 60444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PutRigidBodyToSleep_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC1D RID: 60445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSetPassiveCollision_Internal(IntPtr @this, bool bPassiveCollision, bool bUpdateOverlaps);

		// Token: 0x0600EC1E RID: 60446
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroRemovePassiveProxyChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> CollisionChannel);

		// Token: 0x0600EC1F RID: 60447
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroAddPassiveProxyChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> CollisionChannel);

		// Token: 0x0600EC20 RID: 60448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SphereTraceComponent_Internal(IntPtr @this, FVector TraceStart, FVector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600EC21 RID: 60449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SphereOverlapComponent_Internal(IntPtr @this, FVector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600EC22 RID: 60450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_LineTraceComponent_Internal(IntPtr @this, FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600EC23 RID: 60451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsQueryCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x0600EC24 RID: 60452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsPhysicsCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x0600EC25 RID: 60453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x0600EC26 RID: 60454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_BoxOverlapComponent_Internal(IntPtr @this, FVector InBoxCentre, FBox InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVector HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600EC27 RID: 60455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderKuroTrail_Internal(IntPtr @this);

		// Token: 0x0600EC28 RID: 60456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingComponent_Internal(IntPtr @this, IntPtr OtherComp);

		// Token: 0x0600EC29 RID: 60457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingActor_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x0600EC2A RID: 60458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGravityEnabled_Internal(IntPtr @this);

		// Token: 0x0600EC2B RID: 60459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyRigidBodyAwake_Internal(IntPtr @this);

		// Token: 0x0600EC2C RID: 60460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreComponentWhenMoving_Internal(IntPtr @this, IntPtr Component, bool bShouldIgnore);

		// Token: 0x0600EC2D RID: 60461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreActorWhenMoving_Internal(IntPtr @this, IntPtr Actor, bool bShouldIgnore);

		// Token: 0x0600EC2E RID: 60462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWalkableSlopeOverride_Internal(IntPtr @this);

		// Token: 0x0600EC2F RID: 60463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVolumeCullingActorFlag_Internal(IntPtr @this);

		// Token: 0x0600EC30 RID: 60464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsLinearVelocityAtPoint_Internal(IntPtr @this, FVector Point, FName BoneName);

		// Token: 0x0600EC31 RID: 60465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsLinearVelocity_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC32 RID: 60466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocityInRadians_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC33 RID: 60467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocityInDegrees_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC34 RID: 60468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPhysicsAngularVelocity_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC35 RID: 60469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr @this, IntPtr OutOverlappingComponents);

		// Token: 0x0600EC36 RID: 60470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingActors_Internal(IntPtr @this, IntPtr OverlappingActors, IntPtr ClassFilter);

		// Token: 0x0600EC37 RID: 60471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumMaterials_Internal(IntPtr @this);

		// Token: 0x0600EC38 RID: 60472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialFromCollisionFaceIndex_Internal(IntPtr @this, int FaceIndex, ref int SectionIndex);

		// Token: 0x0600EC39 RID: 60473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterial_Internal(IntPtr @this, int ElementIndex);

		// Token: 0x0600EC3A RID: 60474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMassScale_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC3B RID: 60475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMass_Internal(IntPtr @this);

		// Token: 0x0600EC3C RID: 60476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLinearDamping_Internal(IntPtr @this);

		// Token: 0x0600EC3D RID: 60477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInertiaTensor_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC3E RID: 60478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGenerateOverlapEvents_Internal(IntPtr @this);

		// Token: 0x0600EC3F RID: 60479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCustomPrimitiveDataByIndex_Internal(IntPtr @this, int index);

		// Token: 0x0600EC40 RID: 60480
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionResponse> __GetCollisionResponseToChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x0600EC41 RID: 60481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCollisionProfileName_Internal(IntPtr @this);

		// Token: 0x0600EC42 RID: 60482
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionChannel> __GetCollisionObjectType_Internal(IntPtr @this);

		// Token: 0x0600EC43 RID: 60483
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionEnabled> __GetCollisionEnabled_Internal(IntPtr @this);

		// Token: 0x0600EC44 RID: 60484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClosestPointOnCollision_Internal(IntPtr @this, in FVector Point, ref FVector OutPointOnBody, FName BoneName);

		// Token: 0x0600EC45 RID: 60485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCenterOfMass_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600EC46 RID: 60486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAngularDamping_Internal(IntPtr @this);

		// Token: 0x0600EC47 RID: 60487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_LineTraceComponent_Internal(IntPtr @this, FVectorDouble TraceStart, FVectorDouble TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, ref FVectorDouble HitLocation, ref FVector HitNormal, ref FName BoneName, IntPtr OutHit);

		// Token: 0x0600EC48 RID: 60488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this, int ElementIndex, IntPtr SourceMaterial, FName OptionalName);

		// Token: 0x0600EC49 RID: 60489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAndSetMaterialInstanceDynamicFromMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Parent);

		// Token: 0x0600EC4A RID: 60490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAndSetMaterialInstanceDynamic_Internal(IntPtr @this, int ElementIndex);

		// Token: 0x0600EC4B RID: 60491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyArrayOfMoveIgnoreComponents_Internal(IntPtr @this);

		// Token: 0x0600EC4C RID: 60492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyArrayOfMoveIgnoreActors_Internal(IntPtr @this);

		// Token: 0x0600EC4D RID: 60493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreComponents_Internal(IntPtr @this);

		// Token: 0x0600EC4E RID: 60494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreActors_Internal(IntPtr @this);

		// Token: 0x0600EC4F RID: 60495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStepUp_Internal(IntPtr @this, IntPtr Pawn);

		// Token: 0x0600EC50 RID: 60496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorqueInRadians_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x0600EC51 RID: 60497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorqueInDegrees_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x0600EC52 RID: 60498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTorque_Internal(IntPtr @this, FVector Torque, FName BoneName, bool bAccelChange);

		// Token: 0x0600EC53 RID: 60499
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRadialImpulse_Internal(IntPtr @this, FVector Origin, float Radius, float Strength, TEnumAsByte<ERadialImpulseFalloff> Falloff, bool bVelChange);

		// Token: 0x0600EC54 RID: 60500
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRadialForce_Internal(IntPtr @this, FVector Origin, float Radius, float Strength, TEnumAsByte<ERadialImpulseFalloff> Falloff, bool bAccelChange);

		// Token: 0x0600EC55 RID: 60501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulseAtLocation_Internal(IntPtr @this, FVector Impulse, FVector Location, FName BoneName);

		// Token: 0x0600EC56 RID: 60502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulse_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x0600EC57 RID: 60503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceAtLocationLocal_Internal(IntPtr @this, FVector Force, FVector Location, FName BoneName);

		// Token: 0x0600EC58 RID: 60504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceAtLocation_Internal(IntPtr @this, FVector Force, FVector Location, FName BoneName);

		// Token: 0x0600EC59 RID: 60505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForce_Internal(IntPtr @this, FVector Force, FName BoneName, bool bAccelChange);

		// Token: 0x0600EC5A RID: 60506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulseInRadians_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x0600EC5B RID: 60507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulseInDegrees_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x0600EC5C RID: 60508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAngularImpulse_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange);

		// Token: 0x0600EC5D RID: 60509 RVA: 0x0015EA69 File Offset: 0x0015CC69
		static UPrimitiveComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrimitiveComponent");
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x0015EA78 File Offset: 0x0015CC78
		protected UPrimitiveComponent() : this(BuiltinUtils.AllocNativeUObject(UPrimitiveComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EC5F RID: 60511 RVA: 0x0015EAA0 File Offset: 0x0015CCA0
		protected UPrimitiveComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007EF3 RID: 32499
		internal static int __InterfaceOffset_INavRelevantInterface;

		// Token: 0x04007EF4 RID: 32500
		public new const string __ObjectPath = "/Script/Engine.PrimitiveComponent";

		// Token: 0x04007EF5 RID: 32501
		private static IntPtr _ClassPtr;

		// Token: 0x04007EF6 RID: 32502
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007EF7 RID: 32503
		internal static int __PropertyOffset_MinDrawDistance;

		// Token: 0x04007EF8 RID: 32504
		internal static int __PropertyOffset_LDMaxDrawDistance;

		// Token: 0x04007EF9 RID: 32505
		internal static int __PropertyOffset_bVolumeCullingActor;

		// Token: 0x04007EFA RID: 32506
		internal static byte __PropertyMask_bVolumeCullingActor;

		// Token: 0x04007EFB RID: 32507
		internal static int __PropertyOffset_FOVOverride;

		// Token: 0x04007EFC RID: 32508
		internal static int __PropertyOffset_bUseKuroOpacity;

		// Token: 0x04007EFD RID: 32509
		internal static byte __PropertyMask_bUseKuroOpacity;

		// Token: 0x04007EFE RID: 32510
		internal static int __PropertyOffset_KuroOpacity;

		// Token: 0x04007EFF RID: 32511
		internal static int __PropertyOffset_bUseMeshBlend;

		// Token: 0x04007F00 RID: 32512
		internal static byte __PropertyMask_bUseMeshBlend;

		// Token: 0x04007F01 RID: 32513
		internal static int __PropertyOffset_MeshBlendID;

		// Token: 0x04007F02 RID: 32514
		internal static int __PropertyOffset_CachedMaxDrawDistance;

		// Token: 0x04007F03 RID: 32515
		internal static int __PropertyOffset_DataDistortionCullRatio;

		// Token: 0x04007F04 RID: 32516
		internal static int __PropertyOffset_DepthPriorityGroup;

		// Token: 0x04007F05 RID: 32517
		internal static int __PropertyOffset_ViewOwnerDepthPriorityGroup;

		// Token: 0x04007F06 RID: 32518
		internal static int __PropertyOffset_IndirectLightingCacheQuality;

		// Token: 0x04007F07 RID: 32519
		internal static int __PropertyOffset_LightmapType;

		// Token: 0x04007F08 RID: 32520
		internal static int __PropertyOffset_HLODBatchingPolicy;

		// Token: 0x04007F09 RID: 32521
		internal static int __PropertyOffset_bUseMaxLODAsImposter;

		// Token: 0x04007F0A RID: 32522
		internal static byte __PropertyMask_bUseMaxLODAsImposter;

		// Token: 0x04007F0B RID: 32523
		internal static int __PropertyOffset_bIsKuroLandscape;

		// Token: 0x04007F0C RID: 32524
		internal static byte __PropertyMask_bIsKuroLandscape;

		// Token: 0x04007F0D RID: 32525
		internal static int __PropertyOffset_bBatchImpostersAsInstances;

		// Token: 0x04007F0E RID: 32526
		internal static byte __PropertyMask_bBatchImpostersAsInstances;

		// Token: 0x04007F0F RID: 32527
		internal static int __PropertyOffset_bNeverDistanceCull;

		// Token: 0x04007F10 RID: 32528
		internal static byte __PropertyMask_bNeverDistanceCull;

		// Token: 0x04007F11 RID: 32529
		internal static int __PropertyOffset_bAlwaysCreatePhysicsState;

		// Token: 0x04007F12 RID: 32530
		internal static byte __PropertyMask_bAlwaysCreatePhysicsState;

		// Token: 0x04007F13 RID: 32531
		internal static int __PropertyOffset_bKuroPassiveCollision;

		// Token: 0x04007F14 RID: 32532
		internal static byte __PropertyMask_bKuroPassiveCollision;

		// Token: 0x04007F15 RID: 32533
		internal static int __PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x04007F16 RID: 32534
		internal static byte __PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x04007F17 RID: 32535
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x04007F18 RID: 32536
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x04007F19 RID: 32537
		internal static int __PropertyOffset_bAsyncOverlap;

		// Token: 0x04007F1A RID: 32538
		internal static byte __PropertyMask_bAsyncOverlap;

		// Token: 0x04007F1B RID: 32539
		internal static int __PropertyOffset_bKuroOverlapNotify;

		// Token: 0x04007F1C RID: 32540
		internal static byte __PropertyMask_bKuroOverlapNotify;

		// Token: 0x04007F1D RID: 32541
		internal static int __PropertyOffset_bReceivedAsyncOverlapResult;

		// Token: 0x04007F1E RID: 32542
		internal static byte __PropertyMask_bReceivedAsyncOverlapResult;

		// Token: 0x04007F1F RID: 32543
		internal static int __PropertyOffset_bMultiBodyOverlap;

		// Token: 0x04007F20 RID: 32544
		internal static byte __PropertyMask_bMultiBodyOverlap;

		// Token: 0x04007F21 RID: 32545
		internal static int __PropertyOffset_bTraceComplexOnMove;

		// Token: 0x04007F22 RID: 32546
		internal static byte __PropertyMask_bTraceComplexOnMove;

		// Token: 0x04007F23 RID: 32547
		internal static int __PropertyOffset_bReturnMaterialOnMove;

		// Token: 0x04007F24 RID: 32548
		internal static byte __PropertyMask_bReturnMaterialOnMove;

		// Token: 0x04007F25 RID: 32549
		internal static int __PropertyOffset_bUseViewOwnerDepthPriorityGroup;

		// Token: 0x04007F26 RID: 32550
		internal static byte __PropertyMask_bUseViewOwnerDepthPriorityGroup;

		// Token: 0x04007F27 RID: 32551
		internal static int __PropertyOffset_bAllowCullDistanceVolume;

		// Token: 0x04007F28 RID: 32552
		internal static byte __PropertyMask_bAllowCullDistanceVolume;

		// Token: 0x04007F29 RID: 32553
		internal static int __PropertyOffset_bHasMotionBlurVelocityMeshes;

		// Token: 0x04007F2A RID: 32554
		internal static byte __PropertyMask_bHasMotionBlurVelocityMeshes;

		// Token: 0x04007F2B RID: 32555
		internal static int __PropertyOffset_bVisibleInReflectionCaptures;

		// Token: 0x04007F2C RID: 32556
		internal static byte __PropertyMask_bVisibleInReflectionCaptures;

		// Token: 0x04007F2D RID: 32557
		internal static int __PropertyOffset_bVisibleInRealTimeSkyCaptures;

		// Token: 0x04007F2E RID: 32558
		internal static byte __PropertyMask_bVisibleInRealTimeSkyCaptures;

		// Token: 0x04007F2F RID: 32559
		internal static int __PropertyOffset_bVisibleInRayTracing;

		// Token: 0x04007F30 RID: 32560
		internal static byte __PropertyMask_bVisibleInRayTracing;

		// Token: 0x04007F31 RID: 32561
		internal static int __PropertyOffset_bForceVisibleInKuroRayTracing;

		// Token: 0x04007F32 RID: 32562
		internal static byte __PropertyMask_bForceVisibleInKuroRayTracing;

		// Token: 0x04007F33 RID: 32563
		internal static int __PropertyOffset_bRenderInMainPass;

		// Token: 0x04007F34 RID: 32564
		internal static byte __PropertyMask_bRenderInMainPass;

		// Token: 0x04007F35 RID: 32565
		internal static int __PropertyOffset_bRenderInDepthPass;

		// Token: 0x04007F36 RID: 32566
		internal static byte __PropertyMask_bRenderInDepthPass;

		// Token: 0x04007F37 RID: 32567
		internal static int __PropertyOffset_bForceOpaqueInPreZ_PC;

		// Token: 0x04007F38 RID: 32568
		internal static byte __PropertyMask_bForceOpaqueInPreZ_PC;

		// Token: 0x04007F39 RID: 32569
		internal static int __PropertyOffset_bRenderInCustomCapturePass;

		// Token: 0x04007F3A RID: 32570
		internal static byte __PropertyMask_bRenderInCustomCapturePass;

		// Token: 0x04007F3B RID: 32571
		internal static int __PropertyOffset_bRenderInDataDistortionPass;

		// Token: 0x04007F3C RID: 32572
		internal static byte __PropertyMask_bRenderInDataDistortionPass;

		// Token: 0x04007F3D RID: 32573
		internal static int __PropertyOffset_bOnlyVisibleInSceneCapture;

		// Token: 0x04007F3E RID: 32574
		internal static byte __PropertyMask_bOnlyVisibleInSceneCapture;

		// Token: 0x04007F3F RID: 32575
		internal static int __PropertyOffset_bUseCustomWPO;

		// Token: 0x04007F40 RID: 32576
		internal static byte __PropertyMask_bUseCustomWPO;

		// Token: 0x04007F41 RID: 32577
		internal static int __PropertyOffset_bEnablePlanarReflectionRenderOffset;

		// Token: 0x04007F42 RID: 32578
		internal static byte __PropertyMask_bEnablePlanarReflectionRenderOffset;

		// Token: 0x04007F43 RID: 32579
		internal static int __PropertyOffset_PlanarReflectionRenderOffsetWS;

		// Token: 0x04007F44 RID: 32580
		internal static int __PropertyOffset_CustomCullFlag;

		// Token: 0x04007F45 RID: 32581
		internal static int __PropertyOffset_bReceivesDecals;

		// Token: 0x04007F46 RID: 32582
		internal static byte __PropertyMask_bReceivesDecals;

		// Token: 0x04007F47 RID: 32583
		internal static int __PropertyOffset_bOwnerNoSee;

		// Token: 0x04007F48 RID: 32584
		internal static byte __PropertyMask_bOwnerNoSee;

		// Token: 0x04007F49 RID: 32585
		internal static int __PropertyOffset_bOnlyOwnerSee;

		// Token: 0x04007F4A RID: 32586
		internal static byte __PropertyMask_bOnlyOwnerSee;

		// Token: 0x04007F4B RID: 32587
		internal static int __PropertyOffset_bTreatAsBackgroundForOcclusion;

		// Token: 0x04007F4C RID: 32588
		internal static byte __PropertyMask_bTreatAsBackgroundForOcclusion;

		// Token: 0x04007F4D RID: 32589
		internal static int __PropertyOffset_bUseAsOccluder;

		// Token: 0x04007F4E RID: 32590
		internal static byte __PropertyMask_bUseAsOccluder;

		// Token: 0x04007F4F RID: 32591
		internal static int __PropertyOffset_bSelectable;

		// Token: 0x04007F50 RID: 32592
		internal static byte __PropertyMask_bSelectable;

		// Token: 0x04007F51 RID: 32593
		internal static int __PropertyOffset_bForceMipStreaming;

		// Token: 0x04007F52 RID: 32594
		internal static byte __PropertyMask_bForceMipStreaming;

		// Token: 0x04007F53 RID: 32595
		internal static int __PropertyOffset_bHasPerInstanceHitProxies;

		// Token: 0x04007F54 RID: 32596
		internal static byte __PropertyMask_bHasPerInstanceHitProxies;

		// Token: 0x04007F55 RID: 32597
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x04007F56 RID: 32598
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x04007F57 RID: 32599
		internal static int __PropertyOffset_ForceCastShadowInRayTracing;

		// Token: 0x04007F58 RID: 32600
		internal static byte __PropertyMask_ForceCastShadowInRayTracing;

		// Token: 0x04007F59 RID: 32601
		internal static int __PropertyOffset_CastRasterShadowInRayTracing;

		// Token: 0x04007F5A RID: 32602
		internal static byte __PropertyMask_CastRasterShadowInRayTracing;

		// Token: 0x04007F5B RID: 32603
		internal static int __PropertyOffset_MobileCastShadow;

		// Token: 0x04007F5C RID: 32604
		internal static byte __PropertyMask_MobileCastShadow;

		// Token: 0x04007F5D RID: 32605
		internal static int __PropertyOffset_IsSpecialForLocalLightShadow;

		// Token: 0x04007F5E RID: 32606
		internal static byte __PropertyMask_IsSpecialForLocalLightShadow;

		// Token: 0x04007F5F RID: 32607
		internal static int __PropertyOffset_IsUIScenePrimitive;

		// Token: 0x04007F60 RID: 32608
		internal static byte __PropertyMask_IsUIScenePrimitive;

		// Token: 0x04007F61 RID: 32609
		internal static int __PropertyOffset_IsHiddenInUiSceneState;

		// Token: 0x04007F62 RID: 32610
		internal static byte __PropertyMask_IsHiddenInUiSceneState;

		// Token: 0x04007F63 RID: 32611
		internal static int __PropertyOffset_bSceneDissolveActive;

		// Token: 0x04007F64 RID: 32612
		internal static byte __PropertyMask_bSceneDissolveActive;

		// Token: 0x04007F65 RID: 32613
		internal static int __PropertyOffset_bIsLGUIBeforeUpScale;

		// Token: 0x04007F66 RID: 32614
		internal static byte __PropertyMask_bIsLGUIBeforeUpScale;

		// Token: 0x04007F67 RID: 32615
		internal static int __PropertyOffset_bIsLGUIAfterBlur;

		// Token: 0x04007F68 RID: 32616
		internal static byte __PropertyMask_bIsLGUIAfterBlur;

		// Token: 0x04007F69 RID: 32617
		internal static int __PropertyOffset_bIsLGUIBeforeBloom;

		// Token: 0x04007F6A RID: 32618
		internal static byte __PropertyMask_bIsLGUIBeforeBloom;

		// Token: 0x04007F6B RID: 32619
		internal static int __PropertyOffset_bIsLGUIRenderAsMask;

		// Token: 0x04007F6C RID: 32620
		internal static byte __PropertyMask_bIsLGUIRenderAsMask;

		// Token: 0x04007F6D RID: 32621
		internal static int __PropertyOffset_bIsLGUIReadMask;

		// Token: 0x04007F6E RID: 32622
		internal static byte __PropertyMask_bIsLGUIReadMask;

		// Token: 0x04007F6F RID: 32623
		internal static int __PropertyOffset_bForbidCastToonShadow;

		// Token: 0x04007F70 RID: 32624
		internal static byte __PropertyMask_bForbidCastToonShadow;

		// Token: 0x04007F71 RID: 32625
		internal static int __PropertyOffset_bCastShadowWhenInCaveOrIndoor;

		// Token: 0x04007F72 RID: 32626
		internal static byte __PropertyMask_bCastShadowWhenInCaveOrIndoor;

		// Token: 0x04007F73 RID: 32627
		internal static int __PropertyOffset_bRenderKuroTrail;

		// Token: 0x04007F74 RID: 32628
		internal static byte __PropertyMask_bRenderKuroTrail;

		// Token: 0x04007F75 RID: 32629
		internal static int __PropertyOffset_bRenderHLOD;

		// Token: 0x04007F76 RID: 32630
		internal static byte __PropertyMask_bRenderHLOD;

		// Token: 0x04007F77 RID: 32631
		internal static int __PropertyOffset_bOverride_RenderInBurst;

		// Token: 0x04007F78 RID: 32632
		internal static byte __PropertyMask_bOverride_RenderInBurst;

		// Token: 0x04007F79 RID: 32633
		internal static int __PropertyOffset_bRenderInBurst;

		// Token: 0x04007F7A RID: 32634
		internal static byte __PropertyMask_bRenderInBurst;

		// Token: 0x04007F7B RID: 32635
		internal static int __PropertyOffset_bNoVelocity;

		// Token: 0x04007F7C RID: 32636
		internal static byte __PropertyMask_bNoVelocity;

		// Token: 0x04007F7D RID: 32637
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x04007F7E RID: 32638
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x04007F7F RID: 32639
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x04007F80 RID: 32640
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x04007F81 RID: 32641
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x04007F82 RID: 32642
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x04007F83 RID: 32643
		internal static int __PropertyOffset_bForceCastRaytracingShadow;

		// Token: 0x04007F84 RID: 32644
		internal static byte __PropertyMask_bForceCastRaytracingShadow;

		// Token: 0x04007F85 RID: 32645
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x04007F86 RID: 32646
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x04007F87 RID: 32647
		internal static int __PropertyOffset_bCastVolumetricTranslucentShadow;

		// Token: 0x04007F88 RID: 32648
		internal static byte __PropertyMask_bCastVolumetricTranslucentShadow;

		// Token: 0x04007F89 RID: 32649
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x04007F8A RID: 32650
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x04007F8B RID: 32651
		internal static int __PropertyOffset_bSelfShadowOnly;

		// Token: 0x04007F8C RID: 32652
		internal static byte __PropertyMask_bSelfShadowOnly;

		// Token: 0x04007F8D RID: 32653
		internal static int __PropertyOffset_bCastFarShadow;

		// Token: 0x04007F8E RID: 32654
		internal static byte __PropertyMask_bCastFarShadow;

		// Token: 0x04007F8F RID: 32655
		internal static int __PropertyOffset_bCastFarShadowOnMobile;

		// Token: 0x04007F90 RID: 32656
		internal static byte __PropertyMask_bCastFarShadowOnMobile;

		// Token: 0x04007F91 RID: 32657
		internal static int __PropertyOffset_bCastInsetShadow;

		// Token: 0x04007F92 RID: 32658
		internal static byte __PropertyMask_bCastInsetShadow;

		// Token: 0x04007F93 RID: 32659
		internal static int __PropertyOffset_bCastCinematicShadow;

		// Token: 0x04007F94 RID: 32660
		internal static byte __PropertyMask_bCastCinematicShadow;

		// Token: 0x04007F95 RID: 32661
		internal static int __PropertyOffset_bCastHiddenShadow;

		// Token: 0x04007F96 RID: 32662
		internal static byte __PropertyMask_bCastHiddenShadow;

		// Token: 0x04007F97 RID: 32663
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x04007F98 RID: 32664
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x04007F99 RID: 32665
		internal static int __PropertyOffset_bLightAsIfStatic_DEPRECATED;

		// Token: 0x04007F9A RID: 32666
		internal static byte __PropertyMask_bLightAsIfStatic_DEPRECATED;

		// Token: 0x04007F9B RID: 32667
		internal static int __PropertyOffset_bLightAttachmentsAsGroup;

		// Token: 0x04007F9C RID: 32668
		internal static byte __PropertyMask_bLightAttachmentsAsGroup;

		// Token: 0x04007F9D RID: 32669
		internal static int __PropertyOffset_bExcludeFromLightAttachmentGroup;

		// Token: 0x04007F9E RID: 32670
		internal static byte __PropertyMask_bExcludeFromLightAttachmentGroup;

		// Token: 0x04007F9F RID: 32671
		internal static int __PropertyOffset_bReceiveMobileCSMShadows;

		// Token: 0x04007FA0 RID: 32672
		internal static byte __PropertyMask_bReceiveMobileCSMShadows;

		// Token: 0x04007FA1 RID: 32673
		internal static int __PropertyOffset_bSingleSampleShadowFromStationaryLights;

		// Token: 0x04007FA2 RID: 32674
		internal static byte __PropertyMask_bSingleSampleShadowFromStationaryLights;

		// Token: 0x04007FA3 RID: 32675
		internal static int __PropertyOffset_bIgnoreRadialImpulse;

		// Token: 0x04007FA4 RID: 32676
		internal static byte __PropertyMask_bIgnoreRadialImpulse;

		// Token: 0x04007FA5 RID: 32677
		internal static int __PropertyOffset_bIgnoreRadialForce;

		// Token: 0x04007FA6 RID: 32678
		internal static byte __PropertyMask_bIgnoreRadialForce;

		// Token: 0x04007FA7 RID: 32679
		internal static int __PropertyOffset_bApplyImpulseOnDamage;

		// Token: 0x04007FA8 RID: 32680
		internal static byte __PropertyMask_bApplyImpulseOnDamage;

		// Token: 0x04007FA9 RID: 32681
		internal static int __PropertyOffset_bReplicatePhysicsToAutonomousProxy;

		// Token: 0x04007FAA RID: 32682
		internal static byte __PropertyMask_bReplicatePhysicsToAutonomousProxy;

		// Token: 0x04007FAB RID: 32683
		internal static int __PropertyOffset_bFillCollisionUnderneathForNavmesh;

		// Token: 0x04007FAC RID: 32684
		internal static byte __PropertyMask_bFillCollisionUnderneathForNavmesh;

		// Token: 0x04007FAD RID: 32685
		internal static int __PropertyOffset_AlwaysLoadOnClient;

		// Token: 0x04007FAE RID: 32686
		internal static byte __PropertyMask_AlwaysLoadOnClient;

		// Token: 0x04007FAF RID: 32687
		internal static int __PropertyOffset_AlwaysLoadOnServer;

		// Token: 0x04007FB0 RID: 32688
		internal static byte __PropertyMask_AlwaysLoadOnServer;

		// Token: 0x04007FB1 RID: 32689
		internal static int __PropertyOffset_bUseEditorCompositing;

		// Token: 0x04007FB2 RID: 32690
		internal static byte __PropertyMask_bUseEditorCompositing;

		// Token: 0x04007FB3 RID: 32691
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x04007FB4 RID: 32692
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x04007FB5 RID: 32693
		internal static int __PropertyOffset_bRenderMobileSceneCustomDepth;

		// Token: 0x04007FB6 RID: 32694
		internal static byte __PropertyMask_bRenderMobileSceneCustomDepth;

		// Token: 0x04007FB7 RID: 32695
		internal static int __PropertyOffset_bHasCustomNavigableGeometry;

		// Token: 0x04007FB8 RID: 32696
		internal static int __PropertyOffset_bCanCharacterStandOn;

		// Token: 0x04007FB9 RID: 32697
		internal static int __PropertyOffset_OnConveyBase;

		// Token: 0x04007FBA RID: 32698
		[Nullable(2)]
		private FComponentConveyBaseMovementSignature _OnConveyBase;

		// Token: 0x04007FBB RID: 32699
		internal static int __PropertyOffset_CanCharacterStepUpOn;

		// Token: 0x04007FBC RID: 32700
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x04007FBD RID: 32701
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x04007FBE RID: 32702
		internal static int __PropertyOffset_ToonLightingChannels;

		// Token: 0x04007FBF RID: 32703
		[Nullable(2)]
		private FLightingChannels _ToonLightingChannels;

		// Token: 0x04007FC0 RID: 32704
		internal static int __PropertyOffset_ToonCustomStencilValue;

		// Token: 0x04007FC1 RID: 32705
		internal static int __PropertyOffset_CustomDepthStencilWriteMask;

		// Token: 0x04007FC2 RID: 32706
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x04007FC3 RID: 32707
		internal static int __PropertyOffset_MobileSceneCustomDepthStencilValue;

		// Token: 0x04007FC4 RID: 32708
		internal static int __PropertyOffset_MobileSceneCustomDepthStencilWriteMask;

		// Token: 0x04007FC5 RID: 32709
		internal static int __PropertyOffset_CustomPrimitiveData;

		// Token: 0x04007FC6 RID: 32710
		[Nullable(2)]
		private FCustomPrimitiveData _CustomPrimitiveData;

		// Token: 0x04007FC7 RID: 32711
		internal static int __PropertyOffset_CustomPrimitiveDataInternal;

		// Token: 0x04007FC8 RID: 32712
		[Nullable(2)]
		private FCustomPrimitiveData _CustomPrimitiveDataInternal;

		// Token: 0x04007FC9 RID: 32713
		internal static int __PropertyOffset_ExposeToCinematicsCustomLightYaw;

		// Token: 0x04007FCA RID: 32714
		internal static int __PropertyOffset_ExposeToCinematicsCustomLightFactor;

		// Token: 0x04007FCB RID: 32715
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x04007FCC RID: 32716
		internal static int __PropertyOffset_VisibilityId;

		// Token: 0x04007FCD RID: 32717
		internal static int __PropertyOffset_RuntimeVirtualTextures;

		// Token: 0x04007FCE RID: 32718
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URuntimeVirtualTexture> _RuntimeVirtualTextures;

		// Token: 0x04007FCF RID: 32719
		internal static int __PropertyOffset_VirtualTextureLodBias;

		// Token: 0x04007FD0 RID: 32720
		internal static int __PropertyOffset_VirtualTextureCullMips;

		// Token: 0x04007FD1 RID: 32721
		internal static int __PropertyOffset_VirtualTextureMinCoverage;

		// Token: 0x04007FD2 RID: 32722
		internal static int __PropertyOffset_VirtualTextureRenderPassType;

		// Token: 0x04007FD3 RID: 32723
		internal static int __PropertyOffset_LpvBiasMultiplier;

		// Token: 0x04007FD4 RID: 32724
		internal static int __PropertyOffset_BoundsScale;

		// Token: 0x04007FD5 RID: 32725
		internal static int __PropertyOffset_bBindlessPrimitive;

		// Token: 0x04007FD6 RID: 32726
		internal static int __PropertyOffset_MoveIgnoreActors;

		// Token: 0x04007FD7 RID: 32727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _MoveIgnoreActors;

		// Token: 0x04007FD8 RID: 32728
		internal static int __PropertyOffset_MoveIgnoreComponents;

		// Token: 0x04007FD9 RID: 32729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _MoveIgnoreComponents;

		// Token: 0x04007FDA RID: 32730
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x04007FDB RID: 32731
		[Nullable(2)]
		private FBodyInstance _BodyInstance;

		// Token: 0x04007FDC RID: 32732
		internal static int __PropertyOffset_OnComponentHit;

		// Token: 0x04007FDD RID: 32733
		[Nullable(2)]
		private FComponentHitSignature _OnComponentHit;

		// Token: 0x04007FDE RID: 32734
		internal static int __PropertyOffset_OnComponentBeginOverlap;

		// Token: 0x04007FDF RID: 32735
		[Nullable(2)]
		private FComponentBeginOverlapSignature _OnComponentBeginOverlap;

		// Token: 0x04007FE0 RID: 32736
		internal static int __PropertyOffset_OnComponentBeginOverlapBlock;

		// Token: 0x04007FE1 RID: 32737
		[Nullable(2)]
		private FComponentBeginOverlapBlockSignature _OnComponentBeginOverlapBlock;

		// Token: 0x04007FE2 RID: 32738
		internal static int __PropertyOffset_OnComponentBeginOverlapNoGcAlloc;

		// Token: 0x04007FE3 RID: 32739
		[Nullable(2)]
		private FComponentBeginOverlapSignatureNoGcAlloc _OnComponentBeginOverlapNoGcAlloc;

		// Token: 0x04007FE4 RID: 32740
		internal static int __PropertyOffset_OnComponentEndOverlap;

		// Token: 0x04007FE5 RID: 32741
		[Nullable(2)]
		private FComponentEndOverlapSignature _OnComponentEndOverlap;

		// Token: 0x04007FE6 RID: 32742
		internal static int __PropertyOffset_OnComponentWake;

		// Token: 0x04007FE7 RID: 32743
		[Nullable(2)]
		private FComponentWakeSignature _OnComponentWake;

		// Token: 0x04007FE8 RID: 32744
		internal static int __PropertyOffset_OnComponentSleep;

		// Token: 0x04007FE9 RID: 32745
		[Nullable(2)]
		private FComponentSleepSignature _OnComponentSleep;

		// Token: 0x04007FEA RID: 32746
		internal static int __PropertyOffset_OnBeginCursorOver;

		// Token: 0x04007FEB RID: 32747
		[Nullable(2)]
		private FComponentBeginCursorOverSignature _OnBeginCursorOver;

		// Token: 0x04007FEC RID: 32748
		internal static int __PropertyOffset_OnEndCursorOver;

		// Token: 0x04007FED RID: 32749
		[Nullable(2)]
		private FComponentEndCursorOverSignature _OnEndCursorOver;

		// Token: 0x04007FEE RID: 32750
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x04007FEF RID: 32751
		[Nullable(2)]
		private FComponentOnClickedSignature _OnClicked;

		// Token: 0x04007FF0 RID: 32752
		internal static int __PropertyOffset_OnReleased;

		// Token: 0x04007FF1 RID: 32753
		[Nullable(2)]
		private FComponentOnReleasedSignature _OnReleased;

		// Token: 0x04007FF2 RID: 32754
		internal static int __PropertyOffset_OnInputTouchBegin;

		// Token: 0x04007FF3 RID: 32755
		[Nullable(2)]
		private FComponentOnInputTouchBeginSignature _OnInputTouchBegin;

		// Token: 0x04007FF4 RID: 32756
		internal static int __PropertyOffset_OnInputTouchEnd;

		// Token: 0x04007FF5 RID: 32757
		[Nullable(2)]
		private FComponentOnInputTouchEndSignature _OnInputTouchEnd;

		// Token: 0x04007FF6 RID: 32758
		internal static int __PropertyOffset_OnInputTouchEnter;

		// Token: 0x04007FF7 RID: 32759
		[Nullable(2)]
		private FComponentBeginTouchOverSignature _OnInputTouchEnter;

		// Token: 0x04007FF8 RID: 32760
		internal static int __PropertyOffset_OnInputTouchLeave;

		// Token: 0x04007FF9 RID: 32761
		[Nullable(2)]
		private FComponentEndTouchOverSignature _OnInputTouchLeave;

		// Token: 0x04007FFA RID: 32762
		internal static int __PropertyOffset_LODParentPrimitive;
	}
}
