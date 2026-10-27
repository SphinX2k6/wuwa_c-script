using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087E RID: 2174
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshComponent")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class UBakedBoneMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007669 RID: 30313 RVA: 0x000A9D92 File Offset: 0x000A7F92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneMeshComponent._ClassPtr;
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
		public UBakedBoneMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x000A9DC8 File Offset: 0x000A7FC8
		public UBakedBoneMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x000A9DFB File Offset: 0x000A7FFB
		// (set) Token: 0x0600766D RID: 30317 RVA: 0x000A9E0B File Offset: 0x000A800B
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

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x000A9E1C File Offset: 0x000A801C
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x000A9E2C File Offset: 0x000A802C
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

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x000A9E3D File Offset: 0x000A803D
		// (set) Token: 0x06007671 RID: 30321 RVA: 0x000A9E4D File Offset: 0x000A804D
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

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x000A9E5E File Offset: 0x000A805E
		// (set) Token: 0x06007673 RID: 30323 RVA: 0x000A9E6E File Offset: 0x000A806E
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

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x000A9E7F File Offset: 0x000A807F
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x000A9E8F File Offset: 0x000A808F
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

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x000A9EA0 File Offset: 0x000A80A0
		// (set) Token: 0x06007677 RID: 30327 RVA: 0x000A9EB0 File Offset: 0x000A80B0
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

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x000A9EC1 File Offset: 0x000A80C1
		// (set) Token: 0x06007679 RID: 30329 RVA: 0x000A9ED1 File Offset: 0x000A80D1
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

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x000A9EE2 File Offset: 0x000A80E2
		// (set) Token: 0x0600767B RID: 30331 RVA: 0x000A9EF2 File Offset: 0x000A80F2
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

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x000A9F03 File Offset: 0x000A8103
		// (set) Token: 0x0600767D RID: 30333 RVA: 0x000A9F13 File Offset: 0x000A8113
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

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600767E RID: 30334 RVA: 0x000A9F24 File Offset: 0x000A8124
		// (set) Token: 0x0600767F RID: 30335 RVA: 0x000A9F34 File Offset: 0x000A8134
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

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06007680 RID: 30336 RVA: 0x000A9F45 File Offset: 0x000A8145
		// (set) Token: 0x06007681 RID: 30337 RVA: 0x000A9F55 File Offset: 0x000A8155
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

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x000A9F66 File Offset: 0x000A8166
		// (set) Token: 0x06007683 RID: 30339 RVA: 0x000A9F76 File Offset: 0x000A8176
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

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x000A9F87 File Offset: 0x000A8187
		// (set) Token: 0x06007685 RID: 30341 RVA: 0x000A9F9B File Offset: 0x000A819B
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

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x000A9FB0 File Offset: 0x000A81B0
		// (set) Token: 0x06007687 RID: 30343 RVA: 0x000A9FE9 File Offset: 0x000A81E9
		public TArray<UBakedBoneMeshInstanceGroup> InstanceGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBakedBoneMeshInstanceGroup> result;
				if ((result = this._InstanceGroups) == null)
				{
					result = (this._InstanceGroups = new TArray<UBakedBoneMeshInstanceGroup>(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_InstanceGroups, this));
				}
				return result;
			}
			set
			{
				this.InstanceGroups.CopyAssign(value);
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x000A9FF8 File Offset: 0x000A81F8
		// (set) Token: 0x06007689 RID: 30345 RVA: 0x000AA031 File Offset: 0x000A8231
		public TArray<FInstanceIndexInfo> InstanceIndexInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInstanceIndexInfo> result;
				if ((result = this._InstanceIndexInfos) == null)
				{
					result = (this._InstanceIndexInfos = new TArray<FInstanceIndexInfo>(base.NativePtr + (IntPtr)UBakedBoneMeshComponent.__PropertyOffset_InstanceIndexInfos, this));
				}
				return result;
			}
			set
			{
				this.InstanceIndexInfos.CopyAssign(value);
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x000AA040 File Offset: 0x000A8240
		// (set) Token: 0x0600768B RID: 30347 RVA: 0x000AA079 File Offset: 0x000A8279
		public TArray<int> SpecifiedUsedMaterialIndices
		{
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
			set
			{
				this.SpecifiedUsedMaterialIndices.CopyAssign(value);
			}
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x000AA087 File Offset: 0x000A8287
		[NullableContext(2)]
		public void UpdateInstanceTransforms(in TArray<int> InstanceIndices, in TArray<FTransform> InTransforms)
		{
			UBakedBoneMeshComponent.__UpdateInstanceTransforms_Internal(base.NativePtr, (InstanceIndices ?? new TArray<int>()).NativePtr, (InTransforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x000AA0B4 File Offset: 0x000A82B4
		public unsafe void UpdateInstanceTransform(int InstanceIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			UBakedBoneMeshComponent.__UpdateInstanceTransform_Internal(base.NativePtr, InstanceIndex, ptr);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x000AA0EA File Offset: 0x000A82EA
		public void UpdateInstanceNoiseTexIndex(int InstanceIndex, int InNoiseTexIndex)
		{
			UBakedBoneMeshComponent.__UpdateInstanceNoiseTexIndex_Internal(base.NativePtr, InstanceIndex, InNoiseTexIndex);
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x000AA0F9 File Offset: 0x000A82F9
		[NullableContext(2)]
		public void UpdateInstanceCustomData(int InstanceIndex, in TArray<float> InCustomData)
		{
			UBakedBoneMeshComponent.__UpdateInstanceCustomData_Internal(base.NativePtr, InstanceIndex, (InCustomData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x000AA117 File Offset: 0x000A8317
		public void UpdateInstanceAnimTexIndex(int InstanceIndex, int InAnimTexIndex, float StartTime = 0f, float CrossFadeTime = 0f, bool ForceUpdate = false, bool Loop = true)
		{
			UBakedBoneMeshComponent.__UpdateInstanceAnimTexIndex_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, StartTime, CrossFadeTime, ForceUpdate, Loop);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x000AA12D File Offset: 0x000A832D
		[NullableContext(2)]
		public void UpdateGroupCustomData(int InGroupIndex, in TArray<float> InCustomData)
		{
			UBakedBoneMeshComponent.__UpdateGroupCustomData_Internal(base.NativePtr, InGroupIndex, (InCustomData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x000AA14B File Offset: 0x000A834B
		public bool ShouldRenderUsingBatcher()
		{
			return UBakedBoneMeshComponent.__ShouldRenderUsingBatcher_Internal(base.NativePtr);
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x000AA158 File Offset: 0x000A8358
		public void SetSubSkeletalMeshesToInstanceGroup(int Index, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> InSkeletalMeshes)
		{
			UBakedBoneMeshComponent.__SetSubSkeletalMeshesToInstanceGroup_Internal(base.NativePtr, Index, (InSkeletalMeshes ?? new TArray<USkeletalMesh>()).NativePtr);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x000AA176 File Offset: 0x000A8376
		public void SetPlayRateToInstanceGroup(int Index, float InPlayRate)
		{
			UBakedBoneMeshComponent.__SetPlayRateToInstanceGroup_Internal(base.NativePtr, Index, InPlayRate);
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x000AA185 File Offset: 0x000A8385
		public void SetPlayRateToInstance(int Index, float InPlayRate)
		{
			UBakedBoneMeshComponent.__SetPlayRateToInstance_Internal(base.NativePtr, Index, InPlayRate);
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x000AA194 File Offset: 0x000A8394
		[NullableContext(2)]
		public void SetMainSkeletalMeshToInstanceGroup(int Index, USkeletalMesh InSkeletalMesh)
		{
			UBakedBoneMeshComponent.__SetMainSkeletalMeshToInstanceGroup_Internal(base.NativePtr, Index, (InSkeletalMesh != null) ? InSkeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x000AA1B2 File Offset: 0x000A83B2
		public void SetCustomBounds(in FBoxSphereBounds InBounds)
		{
			UBakedBoneMeshComponent.__SetCustomBounds_Internal(base.NativePtr, InBounds);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x000AA1C0 File Offset: 0x000A83C0
		public void ResumeInstanceAnim(int InstanceIndex)
		{
			UBakedBoneMeshComponent.__ResumeInstanceAnim_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x000AA1CE File Offset: 0x000A83CE
		public void ResetInstanceGroups(int InNum, bool bForcedInitRenderData = false)
		{
			UBakedBoneMeshComponent.__ResetInstanceGroups_Internal(base.NativePtr, InNum, bForcedInitRenderData);
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x000AA1DD File Offset: 0x000A83DD
		public bool RemoveInstance(int InstanceIndex)
		{
			return UBakedBoneMeshComponent.__RemoveInstance_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x000AA1EB File Offset: 0x000A83EB
		public void RefreshRenderState()
		{
			UBakedBoneMeshComponent.__RefreshRenderState_Internal(base.NativePtr);
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x000AA1F8 File Offset: 0x000A83F8
		public void PlayMontage(int InstanceIndex, int InAnimTexIndex, FName SectionName, float CrossFadeTime = 0f, bool Loop = true)
		{
			UBakedBoneMeshComponent.__PlayMontage_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, SectionName, CrossFadeTime, Loop);
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x000AA20C File Offset: 0x000A840C
		public void PlayAnimOrMontage(int InstanceIndex, int InAnimTexIndex, float StartTime = 0f, float CrossFadeTime = 0f, bool Loop = true)
		{
			UBakedBoneMeshComponent.__PlayAnimOrMontage_Internal(base.NativePtr, InstanceIndex, InAnimTexIndex, StartTime, CrossFadeTime, Loop);
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x000AA220 File Offset: 0x000A8420
		public void PlayAnim()
		{
			UBakedBoneMeshComponent.__PlayAnim_Internal(base.NativePtr);
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x000AA22D File Offset: 0x000A842D
		public void PauseInstanceAnim(int InstanceIndex)
		{
			UBakedBoneMeshComponent.__PauseInstanceAnim_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x000AA23B File Offset: 0x000A843B
		public bool IsValidInstanceIndex(int InstanceIndex)
		{
			return UBakedBoneMeshComponent.__IsValidInstanceIndex_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x000AA249 File Offset: 0x000A8449
		public bool IsMontage(int InAnimIndex, int GroupId = 0)
		{
			return UBakedBoneMeshComponent.__IsMontage_Internal(base.NativePtr, InAnimIndex, GroupId);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x000AA258 File Offset: 0x000A8458
		public int GetNumInstances(int InGroupIndex = -1)
		{
			return UBakedBoneMeshComponent.__GetNumInstances_Internal(base.NativePtr, InGroupIndex);
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x000AA266 File Offset: 0x000A8466
		public int GetInstanceGroupId(int InstanceId)
		{
			return UBakedBoneMeshComponent.__GetInstanceGroupId_Internal(base.NativePtr, InstanceId);
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x000AA274 File Offset: 0x000A8474
		public float GetInstanceCurPlayTime(int InInstanceIndex)
		{
			return UBakedBoneMeshComponent.__GetInstanceCurPlayTime_Internal(base.NativePtr, InInstanceIndex);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x000AA282 File Offset: 0x000A8482
		public float GetAnimTotalTime(int InAnimIndex, int GroupId = 0)
		{
			return UBakedBoneMeshComponent.__GetAnimTotalTime_Internal(base.NativePtr, InAnimIndex, GroupId);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x000AA291 File Offset: 0x000A8491
		public void EmptyInstanceIndexInfos()
		{
			UBakedBoneMeshComponent.__EmptyInstanceIndexInfos_Internal(base.NativePtr);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x000AA29E File Offset: 0x000A849E
		public int DefaultAddInstance(int InGroupIndex = 0)
		{
			return UBakedBoneMeshComponent.__DefaultAddInstance_Internal(base.NativePtr, InGroupIndex);
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x000AA2AC File Offset: 0x000A84AC
		public void ClearInstanceData()
		{
			UBakedBoneMeshComponent.__ClearInstanceData_Internal(base.NativePtr);
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x000AA2B9 File Offset: 0x000A84B9
		public bool ChangeMaterialIndex(int InGroupIndex, int InMaterialIndex)
		{
			return UBakedBoneMeshComponent.__ChangeMaterialIndex_Internal(base.NativePtr, InGroupIndex, InMaterialIndex);
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x000AA2C8 File Offset: 0x000A84C8
		[NullableContext(2)]
		public int AddSubSkeletalMeshToInstanceGroup(int Index, USkeletalMesh InSubMesh)
		{
			return UBakedBoneMeshComponent.__AddSubSkeletalMeshToInstanceGroup_Internal(base.NativePtr, Index, (InSubMesh != null) ? InSubMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x000AA2E8 File Offset: 0x000A84E8
		[NullableContext(2)]
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

		// Token: 0x060076AC RID: 30380 RVA: 0x000AA338 File Offset: 0x000A8538
		public unsafe void AddInstanceTransformToInstanceGroup(int InGroupIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			UBakedBoneMeshComponent.__AddInstanceTransformToInstanceGroup_Internal(base.NativePtr, InGroupIndex, ptr);
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x000AA36E File Offset: 0x000A856E
		public bool AddInstanceIndexInfo(int InGroupIndex, int InSubIndex)
		{
			return UBakedBoneMeshComponent.__AddInstanceIndexInfo_Internal(base.NativePtr, InGroupIndex, InSubIndex);
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x000AA380 File Offset: 0x000A8580
		public unsafe int AddInstance(int InGroupIndex, int InAnimIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return UBakedBoneMeshComponent.__AddInstance_Internal(base.NativePtr, InGroupIndex, InAnimIndex, ptr);
		}

		// Token: 0x060076AF RID: 30383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceTransforms_Internal(IntPtr @this, IntPtr InstanceIndices, IntPtr InTransforms);

		// Token: 0x060076B0 RID: 30384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceTransform_Internal(IntPtr @this, int InstanceIndex, in FTransform InTransform);

		// Token: 0x060076B1 RID: 30385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceNoiseTexIndex_Internal(IntPtr @this, int InstanceIndex, int InNoiseTexIndex);

		// Token: 0x060076B2 RID: 30386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceCustomData_Internal(IntPtr @this, int InstanceIndex, IntPtr InCustomData);

		// Token: 0x060076B3 RID: 30387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInstanceAnimTexIndex_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, float StartTime, float CrossFadeTime, bool ForceUpdate, bool Loop);

		// Token: 0x060076B4 RID: 30388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateGroupCustomData_Internal(IntPtr @this, int InGroupIndex, IntPtr InCustomData);

		// Token: 0x060076B5 RID: 30389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldRenderUsingBatcher_Internal(IntPtr @this);

		// Token: 0x060076B6 RID: 30390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubSkeletalMeshesToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSkeletalMeshes);

		// Token: 0x060076B7 RID: 30391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRateToInstanceGroup_Internal(IntPtr @this, int Index, float InPlayRate);

		// Token: 0x060076B8 RID: 30392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRateToInstance_Internal(IntPtr @this, int Index, float InPlayRate);

		// Token: 0x060076B9 RID: 30393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMainSkeletalMeshToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSkeletalMesh);

		// Token: 0x060076BA RID: 30394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomBounds_Internal(IntPtr @this, in FBoxSphereBounds InBounds);

		// Token: 0x060076BB RID: 30395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeInstanceAnim_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x060076BC RID: 30396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInstanceGroups_Internal(IntPtr @this, int InNum, bool bForcedInitRenderData);

		// Token: 0x060076BD RID: 30397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveInstance_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x060076BE RID: 30398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshRenderState_Internal(IntPtr @this);

		// Token: 0x060076BF RID: 30399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayMontage_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, FName SectionName, float CrossFadeTime, bool Loop);

		// Token: 0x060076C0 RID: 30400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimOrMontage_Internal(IntPtr @this, int InstanceIndex, int InAnimTexIndex, float StartTime, float CrossFadeTime, bool Loop);

		// Token: 0x060076C1 RID: 30401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnim_Internal(IntPtr @this);

		// Token: 0x060076C2 RID: 30402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseInstanceAnim_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x060076C3 RID: 30403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidInstanceIndex_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x060076C4 RID: 30404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMontage_Internal(IntPtr @this, int InAnimIndex, int GroupId);

		// Token: 0x060076C5 RID: 30405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumInstances_Internal(IntPtr @this, int InGroupIndex);

		// Token: 0x060076C6 RID: 30406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInstanceGroupId_Internal(IntPtr @this, int InstanceId);

		// Token: 0x060076C7 RID: 30407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceCurPlayTime_Internal(IntPtr @this, int InInstanceIndex);

		// Token: 0x060076C8 RID: 30408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimTotalTime_Internal(IntPtr @this, int InAnimIndex, int GroupId);

		// Token: 0x060076C9 RID: 30409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EmptyInstanceIndexInfos_Internal(IntPtr @this);

		// Token: 0x060076CA RID: 30410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __DefaultAddInstance_Internal(IntPtr @this, int InGroupIndex);

		// Token: 0x060076CB RID: 30411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInstanceData_Internal(IntPtr @this);

		// Token: 0x060076CC RID: 30412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ChangeMaterialIndex_Internal(IntPtr @this, int InGroupIndex, int InMaterialIndex);

		// Token: 0x060076CD RID: 30413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddSubSkeletalMeshToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSubMesh);

		// Token: 0x060076CE RID: 30414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddSubMeshSocketToInstanceGroup_Internal(IntPtr @this, int Index, IntPtr InSubMesh, in FName InSocketName, in FTransform InSocketTransform);

		// Token: 0x060076CF RID: 30415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceTransformToInstanceGroup_Internal(IntPtr @this, int InGroupIndex, in FTransform InTransform);

		// Token: 0x060076D0 RID: 30416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddInstanceIndexInfo_Internal(IntPtr @this, int InGroupIndex, int InSubIndex);

		// Token: 0x060076D1 RID: 30417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddInstance_Internal(IntPtr @this, int InGroupIndex, int InAnimIndex, in FTransform InTransform);

		// Token: 0x060076D2 RID: 30418 RVA: 0x000AA3B7 File Offset: 0x000A85B7
		static UBakedBoneMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMeshComponent");
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x000AA3C5 File Offset: 0x000A85C5
		protected UBakedBoneMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003901 RID: 14593
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMeshComponent";

		// Token: 0x04003902 RID: 14594
		private static IntPtr _ClassPtr;

		// Token: 0x04003903 RID: 14595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003904 RID: 14596
		internal static int __PropertyOffset_bTransientInstanceData;

		// Token: 0x04003905 RID: 14597
		internal static int __PropertyOffset_bEnableNoiseAnimStartTime;

		// Token: 0x04003906 RID: 14598
		internal static int __PropertyOffset_bEnableFrameInterpolation;

		// Token: 0x04003907 RID: 14599
		internal static int __PropertyOffset_bEnableBatcher;

		// Token: 0x04003908 RID: 14600
		internal static int __PropertyOffset_bEnableAnimControl;

		// Token: 0x04003909 RID: 14601
		internal static int __PropertyOffset_bEnableTransitionBlend;

		// Token: 0x0400390A RID: 14602
		internal static int __PropertyOffset_bEnableMorphBlend;

		// Token: 0x0400390B RID: 14603
		internal static int __PropertyOffset_bRenderExtraMaterials;

		// Token: 0x0400390C RID: 14604
		internal static int __PropertyOffset_Debugtime;

		// Token: 0x0400390D RID: 14605
		internal static int __PropertyOffset_CrossFadeTimeTest;

		// Token: 0x0400390E RID: 14606
		internal static int __PropertyOffset_AnimArrayIndexTest;

		// Token: 0x0400390F RID: 14607
		internal static int __PropertyOffset_InstanceScale;

		// Token: 0x04003910 RID: 14608
		internal static int __PropertyOffset_CustomBounds;

		// Token: 0x04003911 RID: 14609
		internal static int __PropertyOffset_InstanceGroups;

		// Token: 0x04003912 RID: 14610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBakedBoneMeshInstanceGroup> _InstanceGroups;

		// Token: 0x04003913 RID: 14611
		internal static int __PropertyOffset_InstanceIndexInfos;

		// Token: 0x04003914 RID: 14612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInstanceIndexInfo> _InstanceIndexInfos;

		// Token: 0x04003915 RID: 14613
		internal static int __PropertyOffset_SpecifiedUsedMaterialIndices;

		// Token: 0x04003916 RID: 14614
		[Nullable(2)]
		private TArray<int> _SpecifiedUsedMaterialIndices;
	}
}
