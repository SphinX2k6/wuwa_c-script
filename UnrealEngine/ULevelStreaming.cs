using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D38 RID: 3384
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelStreaming")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public abstract class ULevelStreaming : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B536 RID: 46390 RVA: 0x00102790 File Offset: 0x00100990
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreaming._ClassPtr;
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600B537 RID: 46391 RVA: 0x0010279C File Offset: 0x0010099C
		// (set) Token: 0x0600B538 RID: 46392 RVA: 0x001027B1 File Offset: 0x001009B1
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_WorldAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_WorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600B539 RID: 46393 RVA: 0x001027D6 File Offset: 0x001009D6
		// (set) Token: 0x0600B53A RID: 46394 RVA: 0x001027E6 File Offset: 0x001009E6
		public unsafe int StreamingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_StreamingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_StreamingPriority) = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600B53B RID: 46395 RVA: 0x001027F7 File Offset: 0x001009F7
		// (set) Token: 0x0600B53C RID: 46396 RVA: 0x0010280B File Offset: 0x00100A0B
		public unsafe FName PackageNameToLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_PackageNameToLoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_PackageNameToLoad) = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600B53D RID: 46397 RVA: 0x00102820 File Offset: 0x00100A20
		// (set) Token: 0x0600B53E RID: 46398 RVA: 0x00102859 File Offset: 0x00100A59
		public TArray<FName> LODPackageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._LODPackageNames) == null)
				{
					result = (this._LODPackageNames = new TArray<FName>(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LODPackageNames, this));
				}
				return result;
			}
			set
			{
				this.LODPackageNames.CopyAssign(value);
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600B53F RID: 46399 RVA: 0x00102867 File Offset: 0x00100A67
		// (set) Token: 0x0600B540 RID: 46400 RVA: 0x0010287B File Offset: 0x00100A7B
		public unsafe FTransform LevelTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelTransform) = value;
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600B541 RID: 46401 RVA: 0x00102890 File Offset: 0x00100A90
		// (set) Token: 0x0600B542 RID: 46402 RVA: 0x001028A0 File Offset: 0x00100AA0
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600B543 RID: 46403 RVA: 0x001028B1 File Offset: 0x00100AB1
		// (set) Token: 0x0600B544 RID: 46404 RVA: 0x001028C1 File Offset: 0x00100AC1
		public unsafe int LevelLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelLODIndex) = value;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600B545 RID: 46405 RVA: 0x001028D2 File Offset: 0x00100AD2
		// (set) Token: 0x0600B546 RID: 46406 RVA: 0x001028EB File Offset: 0x00100AEB
		public unsafe bool bShouldBeVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) & ULevelStreaming.__PropertyMask_bShouldBeVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) & ~ULevelStreaming.__PropertyMask_bShouldBeVisible) | (value ? ULevelStreaming.__PropertyMask_bShouldBeVisible : 0));
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600B547 RID: 46407 RVA: 0x0010291B File Offset: 0x00100B1B
		// (set) Token: 0x0600B548 RID: 46408 RVA: 0x00102934 File Offset: 0x00100B34
		public unsafe bool bShouldBeLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) & ULevelStreaming.__PropertyMask_bShouldBeLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) & ~ULevelStreaming.__PropertyMask_bShouldBeLoaded) | (value ? ULevelStreaming.__PropertyMask_bShouldBeLoaded : 0));
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600B549 RID: 46409 RVA: 0x00102964 File Offset: 0x00100B64
		// (set) Token: 0x0600B54A RID: 46410 RVA: 0x0010297D File Offset: 0x00100B7D
		public unsafe bool bLocked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) & ULevelStreaming.__PropertyMask_bLocked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) & ~ULevelStreaming.__PropertyMask_bLocked) | (value ? ULevelStreaming.__PropertyMask_bLocked : 0));
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600B54B RID: 46411 RVA: 0x001029AD File Offset: 0x00100BAD
		// (set) Token: 0x0600B54C RID: 46412 RVA: 0x001029C6 File Offset: 0x00100BC6
		public unsafe bool bIsStatic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) & ULevelStreaming.__PropertyMask_bIsStatic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) & ~ULevelStreaming.__PropertyMask_bIsStatic) | (value ? ULevelStreaming.__PropertyMask_bIsStatic : 0));
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600B54D RID: 46413 RVA: 0x001029F6 File Offset: 0x00100BF6
		// (set) Token: 0x0600B54E RID: 46414 RVA: 0x00102A0F File Offset: 0x00100C0F
		public unsafe bool bShouldBlockOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) & ULevelStreaming.__PropertyMask_bShouldBlockOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) & ~ULevelStreaming.__PropertyMask_bShouldBlockOnLoad) | (value ? ULevelStreaming.__PropertyMask_bShouldBlockOnLoad : 0));
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600B54F RID: 46415 RVA: 0x00102A3F File Offset: 0x00100C3F
		// (set) Token: 0x0600B550 RID: 46416 RVA: 0x00102A58 File Offset: 0x00100C58
		public unsafe bool bShouldBlockOnUnload
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) & ULevelStreaming.__PropertyMask_bShouldBlockOnUnload) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) & ~ULevelStreaming.__PropertyMask_bShouldBlockOnUnload) | (value ? ULevelStreaming.__PropertyMask_bShouldBlockOnUnload : 0));
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600B551 RID: 46417 RVA: 0x00102A88 File Offset: 0x00100C88
		// (set) Token: 0x0600B552 RID: 46418 RVA: 0x00102AA1 File Offset: 0x00100CA1
		public unsafe bool bDisableDistanceStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) & ULevelStreaming.__PropertyMask_bDisableDistanceStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) & ~ULevelStreaming.__PropertyMask_bDisableDistanceStreaming) | (value ? ULevelStreaming.__PropertyMask_bDisableDistanceStreaming : 0));
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600B553 RID: 46419 RVA: 0x00102AD1 File Offset: 0x00100CD1
		// (set) Token: 0x0600B554 RID: 46420 RVA: 0x00102AEA File Offset: 0x00100CEA
		public unsafe bool bDrawOnLevelStatusMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) & ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) & ~ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap) | (value ? ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap : 0));
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600B555 RID: 46421 RVA: 0x00102B1A File Offset: 0x00100D1A
		// (set) Token: 0x0600B556 RID: 46422 RVA: 0x00102B2E File Offset: 0x00100D2E
		public unsafe FLinearColor LevelColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelColor) = value;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600B557 RID: 46423 RVA: 0x00102B44 File Offset: 0x00100D44
		// (set) Token: 0x0600B558 RID: 46424 RVA: 0x00102B7D File Offset: 0x00100D7D
		public TArray<ALevelStreamingVolume> EditorStreamingVolumes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALevelStreamingVolume> result;
				if ((result = this._EditorStreamingVolumes) == null)
				{
					result = (this._EditorStreamingVolumes = new TArray<ALevelStreamingVolume>(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_EditorStreamingVolumes, this));
				}
				return result;
			}
			set
			{
				this.EditorStreamingVolumes.CopyAssign(value);
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x00102B8B File Offset: 0x00100D8B
		// (set) Token: 0x0600B55A RID: 46426 RVA: 0x00102B9B File Offset: 0x00100D9B
		public unsafe float MinTimeBetweenVolumeUnloadRequests
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_MinTimeBetweenVolumeUnloadRequests);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_MinTimeBetweenVolumeUnloadRequests) = value;
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600B55B RID: 46427 RVA: 0x00102BAC File Offset: 0x00100DAC
		// (set) Token: 0x0600B55C RID: 46428 RVA: 0x00102BE5 File Offset: 0x00100DE5
		public FLevelStreamingLoadedStatus OnLevelLoaded
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingLoadedStatus result;
				if ((result = this._OnLevelLoaded) == null)
				{
					result = (this._OnLevelLoaded = new FLevelStreamingLoadedStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelLoaded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelLoaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600B55D RID: 46429 RVA: 0x00102C08 File Offset: 0x00100E08
		// (set) Token: 0x0600B55E RID: 46430 RVA: 0x00102C41 File Offset: 0x00100E41
		public FLevelStreamingLoadedStatus OnLevelUnloaded
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingLoadedStatus result;
				if ((result = this._OnLevelUnloaded) == null)
				{
					result = (this._OnLevelUnloaded = new FLevelStreamingLoadedStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelUnloaded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelUnloaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x00102C64 File Offset: 0x00100E64
		// (set) Token: 0x0600B560 RID: 46432 RVA: 0x00102C9D File Offset: 0x00100E9D
		public FLevelStreamingVisibilityStatus OnLevelShown
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingVisibilityStatus result;
				if ((result = this._OnLevelShown) == null)
				{
					result = (this._OnLevelShown = new FLevelStreamingVisibilityStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelShown, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelShown, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x00102CC0 File Offset: 0x00100EC0
		// (set) Token: 0x0600B562 RID: 46434 RVA: 0x00102CF9 File Offset: 0x00100EF9
		public FLevelStreamingVisibilityStatus OnLevelHidden
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingVisibilityStatus result;
				if ((result = this._OnLevelHidden) == null)
				{
					result = (this._OnLevelHidden = new FLevelStreamingVisibilityStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelHidden, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelHidden, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600B563 RID: 46435 RVA: 0x00102D1A File Offset: 0x00100F1A
		// (set) Token: 0x0600B564 RID: 46436 RVA: 0x00102D2E File Offset: 0x00100F2E
		[Nullable(2)]
		public unsafe ULevel LoadedLevel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_LoadedLevel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_LoadedLevel, value);
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600B565 RID: 46437 RVA: 0x00102D43 File Offset: 0x00100F43
		// (set) Token: 0x0600B566 RID: 46438 RVA: 0x00102D57 File Offset: 0x00100F57
		[Nullable(2)]
		public unsafe ULevel PendingUnloadLevel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_PendingUnloadLevel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_PendingUnloadLevel, value);
			}
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x00102D6C File Offset: 0x00100F6C
		public bool ShouldBeLoaded()
		{
			return ULevelStreaming.__ShouldBeLoaded_Internal(base.NativePtr);
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x00102D79 File Offset: 0x00100F79
		public void SetShouldBeVisible(bool bInShouldBeVisible)
		{
			ULevelStreaming.__SetShouldBeVisible_Internal(base.NativePtr, bInShouldBeVisible);
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x00102D87 File Offset: 0x00100F87
		public void SetShouldBeLoaded(bool bInShouldBeLoaded)
		{
			ULevelStreaming.__SetShouldBeLoaded_Internal(base.NativePtr, bInShouldBeLoaded);
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x00102D95 File Offset: 0x00100F95
		public void SetPriority(int NewPriority)
		{
			ULevelStreaming.__SetPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x00102DA3 File Offset: 0x00100FA3
		public void SetLevelLODIndex(int LODIndex)
		{
			ULevelStreaming.__SetLevelLODIndex_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x00102DB1 File Offset: 0x00100FB1
		public void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval)
		{
			ULevelStreaming.__SetIsRequestingUnloadAndRemoval_Internal(base.NativePtr, bInIsRequestingUnloadAndRemoval);
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x00102DBF File Offset: 0x00100FBF
		public bool IsStreamingStatePending()
		{
			return ULevelStreaming.__IsStreamingStatePending_Internal(base.NativePtr);
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x00102DCC File Offset: 0x00100FCC
		public bool IsLevelVisible()
		{
			return ULevelStreaming.__IsLevelVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x00102DD9 File Offset: 0x00100FD9
		public bool IsLevelLoaded()
		{
			return ULevelStreaming.__IsLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x00102DE6 File Offset: 0x00100FE6
		public FName GetWorldAssetPackageFName()
		{
			return ULevelStreaming.__GetWorldAssetPackageFName_Internal(base.NativePtr);
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x00102DF3 File Offset: 0x00100FF3
		[NullableContext(2)]
		public ULevel GetLoadedLevel()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(ULevelStreaming.__GetLoadedLevel_Internal(base.NativePtr));
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x00102E05 File Offset: 0x00101005
		[NullableContext(2)]
		public ALevelScriptActor GetLevelScriptActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelScriptActor>(ULevelStreaming.__GetLevelScriptActor_Internal(base.NativePtr));
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x00102E17 File Offset: 0x00101017
		public bool GetIsRequestingUnloadAndRemoval()
		{
			return ULevelStreaming.__GetIsRequestingUnloadAndRemoval_Internal(base.NativePtr);
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x00102E24 File Offset: 0x00101024
		[return: Nullable(2)]
		public unsafe ULevelStreaming CreateInstance(string UniqueInstanceName)
		{
			FString fstring = FString.AllocTemp(UniqueInstanceName);
			ULevelStreaming orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreaming>(ULevelStreaming.__CreateInstance_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B575 RID: 46453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldBeLoaded_Internal(IntPtr @this);

		// Token: 0x0600B576 RID: 46454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBeVisible_Internal(IntPtr @this, bool bInShouldBeVisible);

		// Token: 0x0600B577 RID: 46455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBeLoaded_Internal(IntPtr @this, bool bInShouldBeLoaded);

		// Token: 0x0600B578 RID: 46456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, int NewPriority);

		// Token: 0x0600B579 RID: 46457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLevelLODIndex_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600B57A RID: 46458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsRequestingUnloadAndRemoval_Internal(IntPtr @this, bool bInIsRequestingUnloadAndRemoval);

		// Token: 0x0600B57B RID: 46459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingStatePending_Internal(IntPtr @this);

		// Token: 0x0600B57C RID: 46460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelVisible_Internal(IntPtr @this);

		// Token: 0x0600B57D RID: 46461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelLoaded_Internal(IntPtr @this);

		// Token: 0x0600B57E RID: 46462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetWorldAssetPackageFName_Internal(IntPtr @this);

		// Token: 0x0600B57F RID: 46463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedLevel_Internal(IntPtr @this);

		// Token: 0x0600B580 RID: 46464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelScriptActor_Internal(IntPtr @this);

		// Token: 0x0600B581 RID: 46465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsRequestingUnloadAndRemoval_Internal(IntPtr @this);

		// Token: 0x0600B582 RID: 46466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr @this, in FString UniqueInstanceName);

		// Token: 0x0600B583 RID: 46467 RVA: 0x00102E53 File Offset: 0x00101053
		static ULevelStreaming()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreaming");
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x00102E64 File Offset: 0x00101064
		protected ULevelStreaming() : this(BuiltinUtils.AllocNativeUObject(ULevelStreaming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x00102E8C File Offset: 0x0010108C
		protected ULevelStreaming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F3E RID: 24382
		public new const string __ObjectPath = "/Script/Engine.LevelStreaming";

		// Token: 0x04005F3F RID: 24383
		private static IntPtr _ClassPtr;

		// Token: 0x04005F40 RID: 24384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005F41 RID: 24385
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x04005F42 RID: 24386
		internal static int __PropertyOffset_StreamingPriority;

		// Token: 0x04005F43 RID: 24387
		internal static int __PropertyOffset_PackageNameToLoad;

		// Token: 0x04005F44 RID: 24388
		internal static int __PropertyOffset_LODPackageNames;

		// Token: 0x04005F45 RID: 24389
		[Nullable(2)]
		private TArray<FName> _LODPackageNames;

		// Token: 0x04005F46 RID: 24390
		internal static int __PropertyOffset_LevelTransform;

		// Token: 0x04005F47 RID: 24391
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x04005F48 RID: 24392
		internal static int __PropertyOffset_LevelLODIndex;

		// Token: 0x04005F49 RID: 24393
		internal static int __PropertyOffset_bShouldBeVisible;

		// Token: 0x04005F4A RID: 24394
		internal static byte __PropertyMask_bShouldBeVisible;

		// Token: 0x04005F4B RID: 24395
		internal static int __PropertyOffset_bShouldBeLoaded;

		// Token: 0x04005F4C RID: 24396
		internal static byte __PropertyMask_bShouldBeLoaded;

		// Token: 0x04005F4D RID: 24397
		internal static int __PropertyOffset_bLocked;

		// Token: 0x04005F4E RID: 24398
		internal static byte __PropertyMask_bLocked;

		// Token: 0x04005F4F RID: 24399
		internal static int __PropertyOffset_bIsStatic;

		// Token: 0x04005F50 RID: 24400
		internal static byte __PropertyMask_bIsStatic;

		// Token: 0x04005F51 RID: 24401
		internal static int __PropertyOffset_bShouldBlockOnLoad;

		// Token: 0x04005F52 RID: 24402
		internal static byte __PropertyMask_bShouldBlockOnLoad;

		// Token: 0x04005F53 RID: 24403
		internal static int __PropertyOffset_bShouldBlockOnUnload;

		// Token: 0x04005F54 RID: 24404
		internal static byte __PropertyMask_bShouldBlockOnUnload;

		// Token: 0x04005F55 RID: 24405
		internal static int __PropertyOffset_bDisableDistanceStreaming;

		// Token: 0x04005F56 RID: 24406
		internal static byte __PropertyMask_bDisableDistanceStreaming;

		// Token: 0x04005F57 RID: 24407
		internal static int __PropertyOffset_bDrawOnLevelStatusMap;

		// Token: 0x04005F58 RID: 24408
		internal static byte __PropertyMask_bDrawOnLevelStatusMap;

		// Token: 0x04005F59 RID: 24409
		internal static int __PropertyOffset_LevelColor;

		// Token: 0x04005F5A RID: 24410
		internal static int __PropertyOffset_EditorStreamingVolumes;

		// Token: 0x04005F5B RID: 24411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALevelStreamingVolume> _EditorStreamingVolumes;

		// Token: 0x04005F5C RID: 24412
		internal static int __PropertyOffset_MinTimeBetweenVolumeUnloadRequests;

		// Token: 0x04005F5D RID: 24413
		internal static int __PropertyOffset_OnLevelLoaded;

		// Token: 0x04005F5E RID: 24414
		[Nullable(2)]
		private FLevelStreamingLoadedStatus _OnLevelLoaded;

		// Token: 0x04005F5F RID: 24415
		internal static int __PropertyOffset_OnLevelUnloaded;

		// Token: 0x04005F60 RID: 24416
		[Nullable(2)]
		private FLevelStreamingLoadedStatus _OnLevelUnloaded;

		// Token: 0x04005F61 RID: 24417
		internal static int __PropertyOffset_OnLevelShown;

		// Token: 0x04005F62 RID: 24418
		[Nullable(2)]
		private FLevelStreamingVisibilityStatus _OnLevelShown;

		// Token: 0x04005F63 RID: 24419
		internal static int __PropertyOffset_OnLevelHidden;

		// Token: 0x04005F64 RID: 24420
		[Nullable(2)]
		private FLevelStreamingVisibilityStatus _OnLevelHidden;

		// Token: 0x04005F65 RID: 24421
		internal static int __PropertyOffset_LoadedLevel;

		// Token: 0x04005F66 RID: 24422
		internal static int __PropertyOffset_PendingUnloadLevel;
	}
}
