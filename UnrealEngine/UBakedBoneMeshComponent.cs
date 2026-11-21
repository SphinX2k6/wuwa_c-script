using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000189 RID: 393
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshComponent")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class UBakedBoneMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001949 RID: 6473 RVA: 0x0002641A File Offset: 0x0002461A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneMeshComponent._ClassPtr;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00026428 File Offset: 0x00024628
		public UBakedBoneMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00026450 File Offset: 0x00024650
		[NullableContext(1)]
		public UBakedBoneMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00026483 File Offset: 0x00024683
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x00026493 File Offset: 0x00024693
		public unsafe bool bTransientInstanceData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bTransientInstanceData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bTransientInstanceData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x000264A4 File Offset: 0x000246A4
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x000264B4 File Offset: 0x000246B4
		public unsafe bool bEnableNoiseAnimStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableNoiseAnimStartTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableNoiseAnimStartTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000264C5 File Offset: 0x000246C5
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x000264D5 File Offset: 0x000246D5
		public unsafe bool bEnableFrameInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableFrameInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableFrameInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x000264E6 File Offset: 0x000246E6
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x000264F6 File Offset: 0x000246F6
		public unsafe bool bEnableBatcher
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableBatcher) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableBatcher) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00026507 File Offset: 0x00024707
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00026517 File Offset: 0x00024717
		public unsafe bool bEnableAnimControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableAnimControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableAnimControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00026528 File Offset: 0x00024728
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00026538 File Offset: 0x00024738
		public unsafe bool bEnableTransitionBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableTransitionBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableTransitionBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00026549 File Offset: 0x00024749
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00026559 File Offset: 0x00024759
		public unsafe bool bEnableMorphBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableMorphBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bEnableMorphBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0002656A File Offset: 0x0002476A
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0002657A File Offset: 0x0002477A
		public unsafe bool bRenderExtraMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bRenderExtraMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_bRenderExtraMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0002658B File Offset: 0x0002478B
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0002659B File Offset: 0x0002479B
		public unsafe float Debugtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_Debugtime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_Debugtime) = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000265AC File Offset: 0x000247AC
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x000265BC File Offset: 0x000247BC
		public unsafe float CrossFadeTimeTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_CrossFadeTimeTest);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_CrossFadeTimeTest) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000265CD File Offset: 0x000247CD
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x000265DD File Offset: 0x000247DD
		public unsafe int AnimArrayIndexTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_AnimArrayIndexTest);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_AnimArrayIndexTest) = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000265EE File Offset: 0x000247EE
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x000265FE File Offset: 0x000247FE
		public unsafe float InstanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_InstanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_InstanceScale) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0002660F File Offset: 0x0002480F
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00026623 File Offset: 0x00024823
		public unsafe FBoxSphereBounds CustomBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_CustomBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_CustomBounds) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00026638 File Offset: 0x00024838
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00026671 File Offset: 0x00024871
		[Nullable(1)]
		public TArray<int> SpecifiedUsedMaterialIndices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SpecifiedUsedMaterialIndices) == null)
				{
					result = (this._SpecifiedUsedMaterialIndices = new TArray<int>(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_SpecifiedUsedMaterialIndices, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SpecifiedUsedMaterialIndices.CopyAssign(value);
			}
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0002667F File Offset: 0x0002487F
		public void UpdateInstanceTransforms(in TArray<int> InstanceIndices, in TArray<FTransform> InTransforms)
		{
			UBakedBoneMeshComponent.__UpdateInstanceTransforms_Internal(base.NativePtr, (InstanceIndices ?? new TArray<int>()).NativePtr, (InTransforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000266AC File Offset: 0x000248AC
		public unsafe void UpdateInstanceTransform(int InstanceIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			UBakedBoneMeshComponent.__UpdateInstanceTransform_Internal(base.NativePtr, InstanceIndex, ptr);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000266E2 File Offset: 0x000248E2
		public void UpdateInstanceNoiseTexIndex(int InstanceIndex, int InNoiseTexIndex)
		{
			UBakedBoneMeshComponent.__UpdateInstanceNoiseTexIndex_Internal(base.NativePtr, InstanceIndex, InNoiseTexIndex);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000266F1 File Offset: 0x000248F1
		public void UpdateInstanceCustomData(int InstanceIndex, in TArray<float> InCustomData)
		{
			UBakedBoneMeshComponent.__UpdateInstanceCustomData_Internal(base.NativePtr, InstanceIndex, (InCustomData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0002670F File Offset: 0x0002490F
		public void UpdateInstanceAnimTexIndex(int InstanceIndex, int InAnimTexIndex, float StartTime = 0f, float CrossFadeTime = 0f, bool ForceUpdate = false, bool Loop = true)
		{
			UBakedBoneMeshComponent.__UpdateInstanceAnimTexIndex_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, StartTime, CrossFadeTime, ForceUpdate, Loop);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00026725 File Offset: 0x00024925
		public void UpdateGroupCustomData(int InGroupIndex, in TArray<float> InCustomData)
		{
			UBakedBoneMeshComponent.__UpdateGroupCustomData_Internal(base.NativePtr, InGroupIndex, (InCustomData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00026743 File Offset: 0x00024943
		public bool ShouldRenderUsingBatcher()
		{
			return UBakedBoneMeshComponent.__ShouldRenderUsingBatcher_Internal(base.NativePtr);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00026750 File Offset: 0x00024950
		public void SetSubSkeletalMeshesToInstanceGroup(int Index, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> InSkeletalMeshes)
		{
			UBakedBoneMeshComponent.__SetSubSkeletalMeshesToInstanceGroup_Internal(base.NativePtr, Index, (InSkeletalMeshes ?? new TArray<USkeletalMesh>()).NativePtr);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0002676E File Offset: 0x0002496E
		public void SetPlayRateToInstanceGroup(int Index, float InPlayRate)
		{
			UBakedBoneMeshComponent.__SetPlayRateToInstanceGroup_Internal(base.NativePtr, Index, InPlayRate);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0002677D File Offset: 0x0002497D
		public void SetPlayRateToInstance(int Index, float InPlayRate)
		{
			UBakedBoneMeshComponent.__SetPlayRateToInstance_Internal(base.NativePtr, Index, InPlayRate);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0002678C File Offset: 0x0002498C
		public void SetMainSkeletalMeshToInstanceGroup(int Index, USkeletalMesh InSkeletalMesh)
		{
			UBakedBoneMeshComponent.__SetMainSkeletalMeshToInstanceGroup_Internal(base.NativePtr, Index, (InSkeletalMesh != null) ? InSkeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000267AA File Offset: 0x000249AA
		public void SetCustomBounds(in FBoxSphereBounds InBounds)
		{
			UBakedBoneMeshComponent.__SetCustomBounds_Internal(base.NativePtr, InBounds);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000267B8 File Offset: 0x000249B8
		public void ResumeInstanceAnim(int InstanceIndex)
		{
			UBakedBoneMeshComponent.__ResumeInstanceAnim_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000267C6 File Offset: 0x000249C6
		public void ResetInstanceGroups(int InNum, bool bForcedInitRenderData = false)
		{
			UBakedBoneMeshComponent.__ResetInstanceGroups_Internal(base.NativePtr, InNum, bForcedInitRenderData);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000267D5 File Offset: 0x000249D5
		public bool RemoveInstance(int InstanceIndex)
		{
			return UBakedBoneMeshComponent.__RemoveInstance_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000267E3 File Offset: 0x000249E3
		public void RefreshRenderState()
		{
			UBakedBoneMeshComponent.__RefreshRenderState_Internal(base.NativePtr);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000267F0 File Offset: 0x000249F0
		public void PlayMontage(int InstanceIndex, int InAnimTexIndex, FName SectionName, float CrossFadeTime = 0f, bool Loop = true)
		{
			UBakedBoneMeshComponent.__PlayMontage_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, SectionName, CrossFadeTime, Loop);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00026804 File Offset: 0x00024A04
		public void PlayAnimOrMontage(int InstanceIndex, int InAnimTexIndex, float StartTime = 0f, float CrossFadeTime = 0f, bool Loop = true)
		{
			UBakedBoneMeshComponent.__PlayAnimOrMontage_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, StartTime, CrossFadeTime, Loop);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00026818 File Offset: 0x00024A18
		public void PlayAnim()
		{
			UBakedBoneMeshComponent.__PlayAnim_Internal(base.NativePtr);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00026825 File Offset: 0x00024A25
		public void PauseInstanceAnim(int InstanceIndex)
		{
			UBakedBoneMeshComponent.__PauseInstanceAnim_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00026833 File Offset: 0x00024A33
		public bool IsValidInstanceIndex(int InstanceIndex)
		{
			return UBakedBoneMeshComponent.__IsValidInstanceIndex_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00026841 File Offset: 0x00024A41
		public bool IsMontage(int InAnimIndex, int GroupId = 0)
		{
			return UBakedBoneMeshComponent.__IsMontage_Internal(base.NativePtr, InAnimIndex, GroupId);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00026850 File Offset: 0x00024A50
		public int GetNumInstances(int InGroupIndex = -1)
		{
			return UBakedBoneMeshComponent.__GetNumInstances_Internal(base.NativePtr, InGroupIndex);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0002685E File Offset: 0x00024A5E
		public int GetInstanceGroupId(int InstanceId)
		{
			return UBakedBoneMeshComponent.__GetInstanceGroupId_Internal(base.NativePtr, InstanceId);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0002686C File Offset: 0x00024A6C
		public float GetInstanceCurPlayTime(int InInstanceIndex)
		{
			return UBakedBoneMeshComponent.__GetInstanceCurPlayTime_Internal(base.NativePtr, InInstanceIndex);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0002687A File Offset: 0x00024A7A
		public float GetAnimTotalTime(int InAnimIndex, int GroupId = 0)
		{
			return UBakedBoneMeshComponent.__GetAnimTotalTime_Internal(base.NativePtr, InAnimIndex, GroupId);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00026889 File Offset: 0x00024A89
		public void EmptyInstanceIndexInfos()
		{
			UBakedBoneMeshComponent.__EmptyInstanceIndexInfos_Internal(base.NativePtr);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00026896 File Offset: 0x00024A96
		public int DefaultAddInstance(int InGroupIndex = 0)
		{
			return UBakedBoneMeshComponent.__DefaultAddInstance_Internal(base.NativePtr, InGroupIndex);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000268A4 File Offset: 0x00024AA4
		public void ClearInstanceData()
		{
			UBakedBoneMeshComponent.__ClearInstanceData_Internal(base.NativePtr);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000268B1 File Offset: 0x00024AB1
		public bool ChangeMaterialIndex(int InGroupIndex, int InMaterialIndex)
		{
			return UBakedBoneMeshComponent.__ChangeMaterialIndex_Internal(base.NativePtr, InGroupIndex, InMaterialIndex);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000268C0 File Offset: 0x00024AC0
		public int AddSubSkeletalMeshToInstanceGroup(int Index, USkeletalMesh InSubMesh)
		{
			return UBakedBoneMeshComponent.__AddSubSkeletalMeshToInstanceGroup_Internal(base.NativePtr, Index, (InSubMesh != null) ? InSubMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000268E0 File Offset: 0x00024AE0
		public unsafe bool AddSubMeshSocketToInstanceGroup(int Index, USkeletalMesh InSubMesh, in FName InSocketName, in FTransform InSocketTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InSocketTransform;
			fixed (FName* ptr2 = &InSocketName)
			{
				void* ptr3 = (void*)ptr2;
				return UBakedBoneMeshComponent.__AddSubMeshSocketToInstanceGroup_Internal(base.NativePtr, Index, (InSubMesh != null) ? InSubMesh.NativePtr : IntPtr.Zero, InSocketName, ptr);
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00026930 File Offset: 0x00024B30
		public unsafe void AddInstanceTransformToInstanceGroup(int InGroupIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			UBakedBoneMeshComponent.__AddInstanceTransformToInstanceGroup_Internal(base.NativePtr, InGroupIndex, ptr);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00026966 File Offset: 0x00024B66
		public bool AddInstanceIndexInfo(int InGroupIndex, int InSubIndex)
		{
			return UBakedBoneMeshComponent.__AddInstanceIndexInfo_Internal(base.NativePtr, InGroupIndex, InSubIndex);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00026978 File Offset: 0x00024B78
		public unsafe int AddInstance(int InGroupIndex, int InAnimIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return UBakedBoneMeshComponent.__AddInstance_Internal(base.NativePtr, InGroupIndex, InAnimIndex, ptr);
		}

		// Token: 0x0600198B RID: 6539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceTransforms_Internal(IntPtr @this, IntPtr InstanceIndices, IntPtr InTransforms);

		// Token: 0x0600198C RID: 6540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceTransform_Internal(IntPtr @this, int InstanceIndex, in FTransform InTransform);

		// Token: 0x0600198D RID: 6541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceNoiseTexIndex_Internal(IntPtr @this, int InstanceIndex, int InNoiseTexIndex);

		// Token: 0x0600198E RID: 6542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceCustomData_Internal(IntPtr @this, int InstanceIndex, IntPtr InCustomData);

		// Token: 0x0600198F RID: 6543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceAnimTexIndex_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, float StartTime, float CrossFadeTime, bool ForceUpdate, bool Loop);

		// Token: 0x06001990 RID: 6544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateGroupCustomData_Internal(IntPtr @this, int InGroupIndex, IntPtr InCustomData);

		// Token: 0x06001991 RID: 6545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldRenderUsingBatcher_Internal(IntPtr @this);

		// Token: 0x06001992 RID: 6546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubSkeletalMeshesToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSkeletalMeshes);

		// Token: 0x06001993 RID: 6547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRateToInstanceGroup_Internal(IntPtr @this, int Index, float InPlayRate);

		// Token: 0x06001994 RID: 6548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRateToInstance_Internal(IntPtr @this, int Index, float InPlayRate);

		// Token: 0x06001995 RID: 6549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMainSkeletalMeshToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSkeletalMesh);

		// Token: 0x06001996 RID: 6550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomBounds_Internal(IntPtr @this, in FBoxSphereBounds InBounds);

		// Token: 0x06001997 RID: 6551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeInstanceAnim_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x06001998 RID: 6552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInstanceGroups_Internal(IntPtr @this, int InNum, bool bForcedInitRenderData);

		// Token: 0x06001999 RID: 6553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveInstance_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0600199A RID: 6554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshRenderState_Internal(IntPtr @this);

		// Token: 0x0600199B RID: 6555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayMontage_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, FName SectionName, float CrossFadeTime, bool Loop);

		// Token: 0x0600199C RID: 6556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimOrMontage_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, float StartTime, float CrossFadeTime, bool Loop);

		// Token: 0x0600199D RID: 6557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnim_Internal(IntPtr @this);

		// Token: 0x0600199E RID: 6558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseInstanceAnim_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0600199F RID: 6559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidInstanceIndex_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x060019A0 RID: 6560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMontage_Internal(IntPtr @this, int InAnimIndex, int GroupId);

		// Token: 0x060019A1 RID: 6561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumInstances_Internal(IntPtr @this, int InGroupIndex);

		// Token: 0x060019A2 RID: 6562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInstanceGroupId_Internal(IntPtr @this, int InstanceId);

		// Token: 0x060019A3 RID: 6563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceCurPlayTime_Internal(IntPtr @this, int InInstanceIndex);

		// Token: 0x060019A4 RID: 6564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimTotalTime_Internal(IntPtr @this, int InAnimIndex, int GroupId);

		// Token: 0x060019A5 RID: 6565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EmptyInstanceIndexInfos_Internal(IntPtr @this);

		// Token: 0x060019A6 RID: 6566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __DefaultAddInstance_Internal(IntPtr @this, int InGroupIndex);

		// Token: 0x060019A7 RID: 6567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInstanceData_Internal(IntPtr @this);

		// Token: 0x060019A8 RID: 6568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ChangeMaterialIndex_Internal(IntPtr @this, int InGroupIndex, int InMaterialIndex);

		// Token: 0x060019A9 RID: 6569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddSubSkeletalMeshToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSubMesh);

		// Token: 0x060019AA RID: 6570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddSubMeshSocketToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSubMesh, in FName InSocketName, in FTransform InSocketTransform);

		// Token: 0x060019AB RID: 6571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceTransformToInstanceGroup_Internal(IntPtr @this, int InGroupIndex, in FTransform InTransform);

		// Token: 0x060019AC RID: 6572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddInstanceIndexInfo_Internal(IntPtr @this, int InGroupIndex, int InSubIndex);

		// Token: 0x060019AD RID: 6573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddInstance_Internal(IntPtr @this, int InGroupIndex, int InAnimIndex, in FTransform InTransform);

		// Token: 0x060019AE RID: 6574 RVA: 0x000269AF File Offset: 0x00024BAF
		static UBakedBoneMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMeshComponent");
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000269BD File Offset: 0x00024BBD
		protected UBakedBoneMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000820 RID: 2080
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMeshComponent";

		// Token: 0x04000821 RID: 2081
		private static IntPtr _ClassPtr;

		// Token: 0x04000822 RID: 2082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000823 RID: 2083
		internal static int __PropertyOffset_bTransientInstanceData;

		// Token: 0x04000824 RID: 2084
		internal static int __PropertyOffset_bEnableNoiseAnimStartTime;

		// Token: 0x04000825 RID: 2085
		internal static int __PropertyOffset_bEnableFrameInterpolation;

		// Token: 0x04000826 RID: 2086
		internal static int __PropertyOffset_bEnableBatcher;

		// Token: 0x04000827 RID: 2087
		internal static int __PropertyOffset_bEnableAnimControl;

		// Token: 0x04000828 RID: 2088
		internal static int __PropertyOffset_bEnableTransitionBlend;

		// Token: 0x04000829 RID: 2089
		internal static int __PropertyOffset_bEnableMorphBlend;

		// Token: 0x0400082A RID: 2090
		internal static int __PropertyOffset_bRenderExtraMaterials;

		// Token: 0x0400082B RID: 2091
		internal static int __PropertyOffset_Debugtime;

		// Token: 0x0400082C RID: 2092
		internal static int __PropertyOffset_CrossFadeTimeTest;

		// Token: 0x0400082D RID: 2093
		internal static int __PropertyOffset_AnimArrayIndexTest;

		// Token: 0x0400082E RID: 2094
		internal static int __PropertyOffset_InstanceScale;

		// Token: 0x0400082F RID: 2095
		internal static int __PropertyOffset_CustomBounds;

		// Token: 0x04000830 RID: 2096
		internal static int __PropertyOffset_SpecifiedUsedMaterialIndices;

		// Token: 0x04000831 RID: 2097
		private TArray<int> _SpecifiedUsedMaterialIndices;
	}
}
