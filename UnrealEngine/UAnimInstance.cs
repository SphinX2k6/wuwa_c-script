using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000178 RID: 376
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimInstance")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UAnimInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016D4 RID: 5844 RVA: 0x00023971 File Offset: 0x00021B71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimInstance._ClassPtr;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00023980 File Offset: 0x00021B80
		public UAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000239A8 File Offset: 0x00021BA8
		[NullableContext(1)]
		public UAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x000239DB File Offset: 0x00021BDB
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x000239EF File Offset: 0x00021BEF
		public unsafe USkeleton CurrentSkeleton
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimInstance.__PropertyOffset_CurrentSkeleton);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimInstance.__PropertyOffset_CurrentSkeleton, value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00023A04 File Offset: 0x00021C04
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00023A18 File Offset: 0x00021C18
		[Nullable(0)]
		public unsafe TEnumAsByte<ERootMotionMode> RootMotionMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_RootMotionMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_RootMotionMode) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00023A2D File Offset: 0x00021C2D
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00023A46 File Offset: 0x00021C46
		public unsafe bool bUseMultiThreadedAnimationUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUseMultiThreadedAnimationUpdate) & UAnimInstance.__PropertyMask_bUseMultiThreadedAnimationUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUseMultiThreadedAnimationUpdate) = ((*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUseMultiThreadedAnimationUpdate) & ~UAnimInstance.__PropertyMask_bUseMultiThreadedAnimationUpdate) | (value ? UAnimInstance.__PropertyMask_bUseMultiThreadedAnimationUpdate : 0));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00023A76 File Offset: 0x00021C76
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00023A86 File Offset: 0x00021C86
		public unsafe bool bResultWithUnSafeThreadFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bResultWithUnSafeThreadFunction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bResultWithUnSafeThreadFunction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00023A97 File Offset: 0x00021C97
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00023AAB File Offset: 0x00021CAB
		public unsafe FName AnimOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimOrigin) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00023AC0 File Offset: 0x00021CC0
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00023AD9 File Offset: 0x00021CD9
		public unsafe bool bUsingCopyPoseFromMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUsingCopyPoseFromMesh) & UAnimInstance.__PropertyMask_bUsingCopyPoseFromMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUsingCopyPoseFromMesh) = ((*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bUsingCopyPoseFromMesh) & ~UAnimInstance.__PropertyMask_bUsingCopyPoseFromMesh) | (value ? UAnimInstance.__PropertyMask_bUsingCopyPoseFromMesh : 0));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00023B09 File Offset: 0x00021D09
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00023B22 File Offset: 0x00021D22
		public unsafe bool bReceiveNotifiesFromLinkedInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) & UAnimInstance.__PropertyMask_bReceiveNotifiesFromLinkedInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) = ((*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) & ~UAnimInstance.__PropertyMask_bReceiveNotifiesFromLinkedInstances) | (value ? UAnimInstance.__PropertyMask_bReceiveNotifiesFromLinkedInstances : 0));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00023B52 File Offset: 0x00021D52
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x00023B6B File Offset: 0x00021D6B
		public unsafe bool bPropagateNotifiesToLinkedInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bPropagateNotifiesToLinkedInstances) & UAnimInstance.__PropertyMask_bPropagateNotifiesToLinkedInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bPropagateNotifiesToLinkedInstances) = ((*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bPropagateNotifiesToLinkedInstances) & ~UAnimInstance.__PropertyMask_bPropagateNotifiesToLinkedInstances) | (value ? UAnimInstance.__PropertyMask_bPropagateNotifiesToLinkedInstances : 0));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x00023B9C File Offset: 0x00021D9C
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00023BD5 File Offset: 0x00021DD5
		[Nullable(1)]
		public TMap<FName, UAnimSequence> RibbonAnims
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UAnimSequence> result;
				if ((result = this._RibbonAnims) == null)
				{
					result = (this._RibbonAnims = new TMap<FName, UAnimSequence>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_RibbonAnims, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RibbonAnims.CopyAssign(value);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00023BE4 File Offset: 0x00021DE4
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x00023C1D File Offset: 0x00021E1D
		[Nullable(1)]
		public TMap<FName, TSoftObjectPtr<UAnimSequence>> SoftRibbonAnims
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TSoftObjectPtr<UAnimSequence>> result;
				if ((result = this._SoftRibbonAnims) == null)
				{
					result = (this._SoftRibbonAnims = new TMap<FName, TSoftObjectPtr<UAnimSequence>>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_SoftRibbonAnims, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftRibbonAnims.CopyAssign(value);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00023C2B File Offset: 0x00021E2B
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x00023C44 File Offset: 0x00021E44
		public unsafe bool bQueueMontageEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bQueueMontageEvents) & UAnimInstance.__PropertyMask_bQueueMontageEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bQueueMontageEvents) = ((*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bQueueMontageEvents) & ~UAnimInstance.__PropertyMask_bQueueMontageEvents) | (value ? UAnimInstance.__PropertyMask_bQueueMontageEvents : 0));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00023C74 File Offset: 0x00021E74
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00023C84 File Offset: 0x00021E84
		public unsafe bool bEnableAnimCurvesFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bEnableAnimCurvesFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bEnableAnimCurvesFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00023C98 File Offset: 0x00021E98
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00023CD1 File Offset: 0x00021ED1
		[Nullable(1)]
		public TArray<FName> AnimCurvesToFilter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AnimCurvesToFilter) == null)
				{
					result = (this._AnimCurvesToFilter = new TArray<FName>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimCurvesToFilter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimCurvesToFilter.CopyAssign(value);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00023CDF File Offset: 0x00021EDF
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x00023CEF File Offset: 0x00021EEF
		public unsafe bool bShouldRestoreAnimCurvesToFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bShouldRestoreAnimCurvesToFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bShouldRestoreAnimCurvesToFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00023D00 File Offset: 0x00021F00
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x00023D10 File Offset: 0x00021F10
		public unsafe bool bEnableAnimCurvesFilterBackup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bEnableAnimCurvesFilterBackup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bEnableAnimCurvesFilterBackup) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00023D24 File Offset: 0x00021F24
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00023D5D File Offset: 0x00021F5D
		[Nullable(1)]
		public TArray<FName> AnimCurvesToFilterBackup
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AnimCurvesToFilterBackup) == null)
				{
					result = (this._AnimCurvesToFilterBackup = new TArray<FName>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimCurvesToFilterBackup, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimCurvesToFilterBackup.CopyAssign(value);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00023D6B File Offset: 0x00021F6B
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x00023D7F File Offset: 0x00021F7F
		[Nullable(1)]
		public unsafe string DebugDestructText
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAnimInstance.__PropertyOffset_DebugDestructText)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAnimInstance.__PropertyOffset_DebugDestructText)), value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00023D94 File Offset: 0x00021F94
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x00023DCD File Offset: 0x00021FCD
		[Nullable(1)]
		public TSet<UAnimationAsset> SoftAssetsLoaded
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UAnimationAsset> result;
				if ((result = this._SoftAssetsLoaded) == null)
				{
					result = (this._SoftAssetsLoaded = new TSet<UAnimationAsset>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_SoftAssetsLoaded, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftAssetsLoaded.CopyAssign(value);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00023DDC File Offset: 0x00021FDC
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x00023E15 File Offset: 0x00022015
		[Nullable(1)]
		public FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMontageBlendingOutStartedMCDelegate result;
				if ((result = this._OnMontageBlendingOut) == null)
				{
					result = (this._OnMontageBlendingOut = new FOnMontageBlendingOutStartedMCDelegate(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageBlendingOut, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageBlendingOut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00023E38 File Offset: 0x00022038
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00023E71 File Offset: 0x00022071
		[Nullable(1)]
		public FOnMontageStartedMCDelegate OnMontageStarted
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMontageStartedMCDelegate result;
				if ((result = this._OnMontageStarted) == null)
				{
					result = (this._OnMontageStarted = new FOnMontageStartedMCDelegate(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageStarted, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageStarted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00023E94 File Offset: 0x00022094
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00023ECD File Offset: 0x000220CD
		[Nullable(1)]
		public FOnMontageEndedMCDelegate OnMontageEnded
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMontageEndedMCDelegate result;
				if ((result = this._OnMontageEnded) == null)
				{
					result = (this._OnMontageEnded = new FOnMontageEndedMCDelegate(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageEnded, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnMontageEnded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00023EF0 File Offset: 0x000220F0
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00023F29 File Offset: 0x00022129
		[Nullable(1)]
		public FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnAllMontageInstancesEndedMCDelegate result;
				if ((result = this._OnAllMontageInstancesEnded) == null)
				{
					result = (this._OnAllMontageInstancesEnded = new FOnAllMontageInstancesEndedMCDelegate(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnAllMontageInstancesEnded, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_OnAllMontageInstancesEnded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00023F4C File Offset: 0x0002214C
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x00023F85 File Offset: 0x00022185
		[Nullable(1)]
		public TArray<FAnimNotifyEvent> ActiveAnimNotifyState
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._ActiveAnimNotifyState) == null)
				{
					result = (this._ActiveAnimNotifyState = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_ActiveAnimNotifyState, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveAnimNotifyState.CopyAssign(value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00023F93 File Offset: 0x00022193
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x00023FA3 File Offset: 0x000221A3
		public unsafe int AnimAssetVariantIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimAssetVariantIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimAssetVariantIndex) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00023FB4 File Offset: 0x000221B4
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x00023FC4 File Offset: 0x000221C4
		public unsafe float AnimAssetVariantBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimAssetVariantBlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_AnimAssetVariantBlendTime) = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00023FD5 File Offset: 0x000221D5
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00023FE5 File Offset: 0x000221E5
		public unsafe bool bIsNetMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bIsNetMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_bIsNetMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00023FF6 File Offset: 0x000221F6
		public void UnlockAIResources(bool bUnlockMovement, bool UnlockAILogic)
		{
			UAnimInstance.__UnlockAIResources_Internal(base.NativePtr, bUnlockMovement, UnlockAILogic);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00024005 File Offset: 0x00022205
		public void UnlinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__UnlinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00024018 File Offset: 0x00022218
		public APawn TryGetPawnOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UAnimInstance.__TryGetPawnOwner_Internal(base.NativePtr));
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0002402A File Offset: 0x0002222A
		public bool SyncAnimStates(UAnimInstance Other)
		{
			return UAnimInstance.__SyncAnimStates_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00024047 File Offset: 0x00022247
		public void StopSlotAnimation(float InBlendOutTime = 0.25f, FName SlotNodeName = default(FName))
		{
			UAnimInstance.__StopSlotAnimation_Internal(base.NativePtr, InBlendOutTime, SlotNodeName);
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00024056 File Offset: 0x00022256
		public void SetStateOrdersReceivePending(TArray<int> Orders)
		{
			UAnimInstance.__SetStateOrdersReceivePending_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00024072 File Offset: 0x00022272
		public void SetStateMachineNetMode(bool isNetMode = false)
		{
			UAnimInstance.__SetStateMachineNetMode_Internal(base.NativePtr, isNetMode);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00024080 File Offset: 0x00022280
		public void SetRootMotionMode(ERootMotionMode Value)
		{
			UAnimInstance.__SetRootMotionMode_Internal(base.NativePtr, Value);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00024093 File Offset: 0x00022293
		public void SetReceiveNotifiesFromLinkedInstances(bool bSet)
		{
			UAnimInstance.__SetReceiveNotifiesFromLinkedInstances_Internal(base.NativePtr, bSet);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000240A1 File Offset: 0x000222A1
		public void SetPropagateNotifiesToLinkedInstances(bool bSet)
		{
			UAnimInstance.__SetPropagateNotifiesToLinkedInstances_Internal(base.NativePtr, bSet);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000240AF File Offset: 0x000222AF
		public void SetMorphTarget(FName MorphTargetName, float Value)
		{
			UAnimInstance.__SetMorphTarget_Internal(base.NativePtr, MorphTargetName, Value);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000240BE File Offset: 0x000222BE
		public void SetDelayAnimTime(float Time, float CollectPeriod)
		{
			UAnimInstance.__SetDelayAnimTime_Internal(base.NativePtr, Time, CollectPeriod);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000240CD File Offset: 0x000222CD
		public void SetAnimAssetVariantIndex(int InAnimAssetVariantIndex, float InBlendTime = 0f)
		{
			UAnimInstance.__SetAnimAssetVariantIndex_Internal(base.NativePtr, InAnimAssetVariantIndex, InBlendTime);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000240DC File Offset: 0x000222DC
		public void SavePoseSnapshot(FName SnapshotName)
		{
			UAnimInstance.__SavePoseSnapshot_Internal(base.NativePtr, SnapshotName);
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000240EA File Offset: 0x000222EA
		public void RemoveForceUpdateSlotNameWhenMontageBlend(FName SlotName)
		{
			UAnimInstance.__RemoveForceUpdateSlotNameWhenMontageBlend_Internal(base.NativePtr, SlotName);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000240F8 File Offset: 0x000222F8
		public UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset, FName SlotNodeName, float BlendInTime = 0.25f, float BlendOutTime = 0.25f, float InPlayRate = 1f, int LoopCount = 1, float BlendOutTriggerTime = -1f, float InTimeToStartMontageAt = 0f, bool bStopAllMontages = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UAnimInstance.__PlaySlotAnimationAsDynamicMontage_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount, BlendOutTriggerTime, InTimeToStartMontageAt, bStopAllMontages));
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00024133 File Offset: 0x00022333
		public float PlaySlotAnimation(UAnimSequenceBase Asset, FName SlotNodeName, float BlendInTime = 0.25f, float BlendOutTime = 0.25f, float InPlayRate = 1f, int LoopCount = 1)
		{
			return UAnimInstance.__PlaySlotAnimation_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00024158 File Offset: 0x00022358
		public void Montage_StopGroupByName(float InBlendOutTime, FName GroupName)
		{
			UAnimInstance.__Montage_StopGroupByName_Internal(base.NativePtr, InBlendOutTime, GroupName);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00024167 File Offset: 0x00022367
		public void Montage_Stop(float InBlendOutTime, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_Stop_Internal(base.NativePtr, InBlendOutTime, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00024185 File Offset: 0x00022385
		public void Montage_SetPosition(UAnimMontage Montage, float NewPosition)
		{
			UAnimInstance.__Montage_SetPosition_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, NewPosition);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000241A3 File Offset: 0x000223A3
		public void Montage_SetPlayRate(UAnimMontage Montage, float NewPlayRate = 1f)
		{
			UAnimInstance.__Montage_SetPlayRate_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, NewPlayRate);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000241C1 File Offset: 0x000223C1
		public void Montage_SetNextSection(FName SectionNameToChange, FName NextSection, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_SetNextSection_Internal(base.NativePtr, SectionNameToChange, NextSection, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000241E0 File Offset: 0x000223E0
		public void Montage_Resume(UAnimMontage Montage)
		{
			UAnimInstance.__Montage_Resume_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000241FD File Offset: 0x000223FD
		public float Montage_Play(UAnimMontage MontageToPlay, float InPlayRate = 1f, EMontagePlayReturnType ReturnValueType = EMontagePlayReturnType.MontageLength, float InTimeToStartMontageAt = 0f, bool bStopAllMontages = true)
		{
			return UAnimInstance.__Montage_Play_Internal(base.NativePtr, (MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero, InPlayRate, ReturnValueType, InTimeToStartMontageAt, bStopAllMontages);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00024220 File Offset: 0x00022420
		public void Montage_Pause(UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_Pause_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0002423D File Offset: 0x0002243D
		public void Montage_MuteAllMontage()
		{
			UAnimInstance.__Montage_MuteAllMontage_Internal(base.NativePtr);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0002424A File Offset: 0x0002244A
		public void Montage_JumpToSectionsEnd(FName SectionName, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_JumpToSectionsEnd_Internal(base.NativePtr, SectionName, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00024268 File Offset: 0x00022468
		public void Montage_JumpToSection(FName SectionName, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_JumpToSection_Internal(base.NativePtr, SectionName, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00024286 File Offset: 0x00022486
		public bool Montage_IsPlaying(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_IsPlaying_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000242A3 File Offset: 0x000224A3
		public bool Montage_IsActive(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_IsActive_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000242C0 File Offset: 0x000224C0
		public float Montage_GetPosition(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetPosition_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000242DD File Offset: 0x000224DD
		public float Montage_GetPlayRate(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetPlayRate_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x000242FA File Offset: 0x000224FA
		public bool Montage_GetIsStopped(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetIsStopped_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00024317 File Offset: 0x00022517
		public FName Montage_GetCurrentSection(UAnimMontage Montage = null)
		{
			return UAnimInstance.__Montage_GetCurrentSection_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00024334 File Offset: 0x00022534
		public float Montage_GetBlendTime(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetBlendTime_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00024351 File Offset: 0x00022551
		public void LockAIResources(bool bLockMovement, bool LockAILogic)
		{
			UAnimInstance.__LockAIResources_Internal(base.NativePtr, bLockMovement, LockAILogic);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00024360 File Offset: 0x00022560
		public void LinkAnimGraphByTag(FName InTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__LinkAnimGraphByTag_Internal(base.NativePtr, InTag, InClass._NativePtr);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00024374 File Offset: 0x00022574
		public void LinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__LinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00024387 File Offset: 0x00022587
		public bool IsSyncGroupBetweenMarkers(FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder = true)
		{
			return UAnimInstance.__IsSyncGroupBetweenMarkers_Internal(base.NativePtr, InSyncGroupName, PreviousMarker, NextMarker, bRespectMarkerOrder);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00024399 File Offset: 0x00022599
		public bool IsPlayingSlotAnimation(UAnimSequenceBase Asset, FName SlotNodeName)
		{
			return UAnimInstance.__IsPlayingSlotAnimation_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000243B7 File Offset: 0x000225B7
		public bool IsKuroForceFlying()
		{
			return UAnimInstance.__IsKuroForceFlying_Internal(base.NativePtr);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000243C4 File Offset: 0x000225C4
		public bool IsAnyMontagePlaying()
		{
			return UAnimInstance.__IsAnyMontagePlaying_Internal(base.NativePtr);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x000243D1 File Offset: 0x000225D1
		public bool HasMarkerBeenHitThisFrame(FName SyncGroup, FName MarkerName)
		{
			return UAnimInstance.__HasMarkerBeenHitThisFrame_Internal(base.NativePtr, SyncGroup, MarkerName);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000243E0 File Offset: 0x000225E0
		public bool HasKuroRootMotionAnim()
		{
			return UAnimInstance.__HasKuroRootMotionAnim_Internal(base.NativePtr);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000243F0 File Offset: 0x000225F0
		public unsafe bool GetTimeToClosestMarker(FName SyncGroup, FName MarkerName, ref float OutMarkerTime)
		{
			fixed (float* ptr = &OutMarkerTime)
			{
				void* ptr2 = (void*)ptr;
				return UAnimInstance.__GetTimeToClosestMarker_Internal(base.NativePtr, SyncGroup, MarkerName, ref OutMarkerTime);
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00024410 File Offset: 0x00022610
		public bool GetStateOrdersSendPending(ref TArray<int> Orders)
		{
			return UAnimInstance.__GetStateOrdersSendPending_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0002442D File Offset: 0x0002262D
		public float GetRelevantAnimTimeRemainingFraction(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeRemainingFraction_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0002443C File Offset: 0x0002263C
		public float GetRelevantAnimTimeRemaining(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeRemaining_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0002444B File Offset: 0x0002264B
		public float GetRelevantAnimTimeFraction(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeFraction_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0002445A File Offset: 0x0002265A
		public float GetRelevantAnimTime(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTime_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00024469 File Offset: 0x00022669
		public float GetRelevantAnimLength(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimLength_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00024478 File Offset: 0x00022678
		public bool GetReceiveNotifiesFromLinkedInstances()
		{
			return UAnimInstance.__GetReceiveNotifiesFromLinkedInstances_Internal(base.NativePtr);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00024485 File Offset: 0x00022685
		public bool GetPropagateNotifiesToLinkedInstances()
		{
			return UAnimInstance.__GetPropagateNotifiesToLinkedInstances_Internal(base.NativePtr);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00024492 File Offset: 0x00022692
		public USkeletalMeshComponent GetOwningComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UAnimInstance.__GetOwningComponent_Internal(base.NativePtr));
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000244A4 File Offset: 0x000226A4
		public AActor GetOwningActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAnimInstance.__GetOwningActor_Internal(base.NativePtr));
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000244B6 File Offset: 0x000226B6
		public void GetOriginStates(ref TArray<int> Orders)
		{
			UAnimInstance.__GetOriginStates_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000244D3 File Offset: 0x000226D3
		[NullableContext(1)]
		public string GetMainAnimsDebugText()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimInstance.__GetMainAnimsDebugText_Internal(base.NativePtr));
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000244E5 File Offset: 0x000226E5
		public float GetMainAnimsCurveValueWithDelta(FName CurveName, float DeltaTime, bool bRawDeltaTime = false, bool bCycleTimeIfLoop = false)
		{
			return UAnimInstance.__GetMainAnimsCurveValueWithDelta_Internal(base.NativePtr, CurveName, DeltaTime, bRawDeltaTime, bCycleTimeIfLoop);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000244F8 File Offset: 0x000226F8
		public void GetMainAnims(ref TArray<FName> Anims, ref TArray<float> Weights, ref TArray<float> CurrentTimes, ref TArray<float> PlayRates)
		{
			UAnimInstance.__GetMainAnims_Internal(base.NativePtr, (Anims ?? new TArray<FName>()).NativePtr, (Weights ?? new TArray<float>()).NativePtr, (CurrentTimes ?? new TArray<float>()).NativePtr, (PlayRates ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00024551 File Offset: 0x00022751
		public void GetLinkedAnimLayerInstancesByGroup(FName InGroup, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			UAnimInstance.__GetLinkedAnimLayerInstancesByGroup_Internal(base.NativePtr, InGroup, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0002456F File Offset: 0x0002276F
		public UAnimInstance GetLinkedAnimLayerInstanceByGroupAndClass(FName InGroup, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByGroupAndClass_Internal(base.NativePtr, InGroup, InClass._NativePtr));
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00024588 File Offset: 0x00022788
		public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByGroup_Internal(base.NativePtr, InGroup));
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0002459B File Offset: 0x0002279B
		public UAnimInstance GetLinkedAnimLayerInstanceByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000245B3 File Offset: 0x000227B3
		public void GetLinkedAnimGraphInstancesByTag(FName InTag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			UAnimInstance.__GetLinkedAnimGraphInstancesByTag_Internal(base.NativePtr, InTag, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000245D1 File Offset: 0x000227D1
		public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimGraphInstanceByTag_Internal(base.NativePtr, InTag));
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000245E4 File Offset: 0x000227E4
		public FTransform GetKuroCachedBoneTransform(FName Name)
		{
			return UAnimInstance.__GetKuroCachedBoneTransform_Internal(base.NativePtr, Name);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000245F2 File Offset: 0x000227F2
		public float GetInstanceTransitionTimeElapsedFraction(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionTimeElapsedFraction_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00024601 File Offset: 0x00022801
		public float GetInstanceTransitionTimeElapsed(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionTimeElapsed_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00024610 File Offset: 0x00022810
		public float GetInstanceTransitionCrossfadeDuration(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionCrossfadeDuration_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0002461F File Offset: 0x0002281F
		public float GetInstanceStateWeight(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetInstanceStateWeight_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0002462E File Offset: 0x0002282E
		public float GetInstanceMachineWeight(int MachineIndex)
		{
			return UAnimInstance.__GetInstanceMachineWeight_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0002463C File Offset: 0x0002283C
		public float GetInstanceCurrentStateElapsedTime(int MachineIndex)
		{
			return UAnimInstance.__GetInstanceCurrentStateElapsedTime_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0002464A File Offset: 0x0002284A
		public float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFromEndFraction_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00024658 File Offset: 0x00022858
		public float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFromEnd_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00024666 File Offset: 0x00022866
		public float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFraction_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00024674 File Offset: 0x00022874
		public float GetInstanceAssetPlayerTime(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTime_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00024682 File Offset: 0x00022882
		public float GetInstanceAssetPlayerLength(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerLength_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00024690 File Offset: 0x00022890
		public float GetCurveValue(FName CurveName)
		{
			return UAnimInstance.__GetCurveValue_Internal(base.NativePtr, CurveName);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0002469E File Offset: 0x0002289E
		public FName GetCurrentStateName(int MachineIndex)
		{
			return UAnimInstance.__GetCurrentStateName_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000246AC File Offset: 0x000228AC
		public UAnimMontage GetCurrentActiveMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UAnimInstance.__GetCurrentActiveMontage_Internal(base.NativePtr));
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000246BE File Offset: 0x000228BE
		[NullableContext(1)]
		public string GetAnimsDebugText()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimInstance.__GetAnimsDebugText_Internal(base.NativePtr));
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000246D0 File Offset: 0x000228D0
		public int GetAnimAssetVariantIndex()
		{
			return UAnimInstance.__GetAnimAssetVariantIndex_Internal(base.NativePtr);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000246DD File Offset: 0x000228DD
		public float GetAnimAssetVariantBlendTime()
		{
			return UAnimInstance.__GetAnimAssetVariantBlendTime_Internal(base.NativePtr);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000246EA File Offset: 0x000228EA
		public void GetAllCurveNames(ref TArray<FName> OutNames)
		{
			UAnimInstance.__GetAllCurveNames_Internal(base.NativePtr, (OutNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00024707 File Offset: 0x00022907
		public void GetActiveCurveNames(EAnimCurveType CurveType, ref TArray<FName> OutNames)
		{
			UAnimInstance.__GetActiveCurveNames_Internal(base.NativePtr, CurveType, (OutNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00024725 File Offset: 0x00022925
		public void ForceSetCurrentMontageBlendTime(float BlendTime, UAnimMontage Montage = null)
		{
			UAnimInstance.__ForceSetCurrentMontageBlendTime_Internal(base.NativePtr, BlendTime, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00024743 File Offset: 0x00022943
		[NullableContext(1)]
		public FRootMotionMovementParams ConsumeExtractedRootMotion(float Alpha)
		{
			return new FRootMotionMovementParams(UAnimInstance.__ConsumeExtractedRootMotion_Internal(base.NativePtr, Alpha), null);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00024757 File Offset: 0x00022957
		public void ClearStateOrdersSendPending()
		{
			UAnimInstance.__ClearStateOrdersSendPending_Internal(base.NativePtr);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00024764 File Offset: 0x00022964
		public void ClearStateOrdersReceivePending()
		{
			UAnimInstance.__ClearStateOrdersReceivePending_Internal(base.NativePtr);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00024771 File Offset: 0x00022971
		public void ClearMorphTargets()
		{
			UAnimInstance.__ClearMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0002477E File Offset: 0x0002297E
		public void ClearMontage()
		{
			UAnimInstance.__ClearMontage_Internal(base.NativePtr);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0002478B File Offset: 0x0002298B
		public float CalculateDirection(in FVector Velocity, in FRotator BaseRotation)
		{
			return UAnimInstance.__CalculateDirection_Internal(base.NativePtr, Velocity, BaseRotation);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0002479A File Offset: 0x0002299A
		public virtual void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			UAnimInstance.__BlueprintUpdateAnimation_Internal(base.NativePtr, DeltaTimeX);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000247A8 File Offset: 0x000229A8
		public virtual void BlueprintPostEvaluateAnimation()
		{
			UAnimInstance.__BlueprintPostEvaluateAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000247B5 File Offset: 0x000229B5
		public virtual void BlueprintLinkedAnimationLayersInitialized()
		{
			UAnimInstance.__BlueprintLinkedAnimationLayersInitialized_Internal(base.NativePtr);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000247C2 File Offset: 0x000229C2
		public virtual void BlueprintInitializeAnimation()
		{
			UAnimInstance.__BlueprintInitializeAnimation_Internal(base.NativePtr);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000247CF File Offset: 0x000229CF
		public virtual void BlueprintBeginPlay()
		{
			UAnimInstance.__BlueprintBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000247DC File Offset: 0x000229DC
		public void AddForceUpdateSlotNameWhenMontageBlend(FName SlotName)
		{
			UAnimInstance.__AddForceUpdateSlotNameWhenMontageBlend_Internal(base.NativePtr, SlotName);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000247EA File Offset: 0x000229EA
		public void AddDeltaForDelayAnim(float Delta)
		{
			UAnimInstance.__AddDeltaForDelayAnim_Internal(base.NativePtr, Delta);
		}

		// Token: 0x0600176E RID: 5998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAIResources_Internal(IntPtr @this, bool bUnlockMovement, bool UnlockAILogic);

		// Token: 0x0600176F RID: 5999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06001770 RID: 6000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TryGetPawnOwner_Internal(IntPtr @this);

		// Token: 0x06001771 RID: 6001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SyncAnimStates_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06001772 RID: 6002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSlotAnimation_Internal(IntPtr @this, float InBlendOutTime, FName SlotNodeName);

		// Token: 0x06001773 RID: 6003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateOrdersReceivePending_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x06001774 RID: 6004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateMachineNetMode_Internal(IntPtr @this, bool isNetMode);

		// Token: 0x06001775 RID: 6005
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRootMotionMode_Internal(IntPtr @this, TEnumAsByte<ERootMotionMode> Value);

		// Token: 0x06001776 RID: 6006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceiveNotifiesFromLinkedInstances_Internal(IntPtr @this, bool bSet);

		// Token: 0x06001777 RID: 6007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPropagateNotifiesToLinkedInstances_Internal(IntPtr @this, bool bSet);

		// Token: 0x06001778 RID: 6008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMorphTarget_Internal(IntPtr @this, FName MorphTargetName, float Value);

		// Token: 0x06001779 RID: 6009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelayAnimTime_Internal(IntPtr @this, float Time, float CollectPeriod);

		// Token: 0x0600177A RID: 6010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimAssetVariantIndex_Internal(IntPtr @this, int InAnimAssetVariantIndex, float InBlendTime);

		// Token: 0x0600177B RID: 6011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SavePoseSnapshot_Internal(IntPtr @this, FName SnapshotName);

		// Token: 0x0600177C RID: 6012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceUpdateSlotNameWhenMontageBlend_Internal(IntPtr @this, FName SlotName);

		// Token: 0x0600177D RID: 6013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlaySlotAnimationAsDynamicMontage_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt, bool bStopAllMontages);

		// Token: 0x0600177E RID: 6014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PlaySlotAnimation_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount);

		// Token: 0x0600177F RID: 6015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_StopGroupByName_Internal(IntPtr @this, float InBlendOutTime, FName GroupName);

		// Token: 0x06001780 RID: 6016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Stop_Internal(IntPtr @this, float InBlendOutTime, IntPtr Montage);

		// Token: 0x06001781 RID: 6017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetPosition_Internal(IntPtr @this, IntPtr Montage, float NewPosition);

		// Token: 0x06001782 RID: 6018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetPlayRate_Internal(IntPtr @this, IntPtr Montage, float NewPlayRate);

		// Token: 0x06001783 RID: 6019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetNextSection_Internal(IntPtr @this, FName SectionNameToChange, FName NextSection, IntPtr Montage);

		// Token: 0x06001784 RID: 6020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Resume_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06001785 RID: 6021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_Play_Internal(IntPtr @this, IntPtr MontageToPlay, float InPlayRate, EMontagePlayReturnType ReturnValueType, float InTimeToStartMontageAt, bool bStopAllMontages);

		// Token: 0x06001786 RID: 6022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Pause_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06001787 RID: 6023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_MuteAllMontage_Internal(IntPtr @this);

		// Token: 0x06001788 RID: 6024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_JumpToSectionsEnd_Internal(IntPtr @this, FName SectionName, IntPtr Montage);

		// Token: 0x06001789 RID: 6025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_JumpToSection_Internal(IntPtr @this, FName SectionName, IntPtr Montage);

		// Token: 0x0600178A RID: 6026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_IsPlaying_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x0600178B RID: 6027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_IsActive_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x0600178C RID: 6028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetPosition_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x0600178D RID: 6029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetPlayRate_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x0600178E RID: 6030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_GetIsStopped_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x0600178F RID: 6031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __Montage_GetCurrentSection_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06001790 RID: 6032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetBlendTime_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06001791 RID: 6033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAIResources_Internal(IntPtr @this, bool bLockMovement, bool LockAILogic);

		// Token: 0x06001792 RID: 6034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimGraphByTag_Internal(IntPtr @this, FName InTag, IntPtr InClass);

		// Token: 0x06001793 RID: 6035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06001794 RID: 6036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSyncGroupBetweenMarkers_Internal(IntPtr @this, FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder);

		// Token: 0x06001795 RID: 6037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingSlotAnimation_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName);

		// Token: 0x06001796 RID: 6038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsKuroForceFlying_Internal(IntPtr @this);

		// Token: 0x06001797 RID: 6039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyMontagePlaying_Internal(IntPtr @this);

		// Token: 0x06001798 RID: 6040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMarkerBeenHitThisFrame_Internal(IntPtr @this, FName SyncGroup, FName MarkerName);

		// Token: 0x06001799 RID: 6041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKuroRootMotionAnim_Internal(IntPtr @this);

		// Token: 0x0600179A RID: 6042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTimeToClosestMarker_Internal(IntPtr @this, FName SyncGroup, FName MarkerName, ref float OutMarkerTime);

		// Token: 0x0600179B RID: 6043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStateOrdersSendPending_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x0600179C RID: 6044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeRemainingFraction_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x0600179D RID: 6045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeRemaining_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x0600179E RID: 6046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeFraction_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x0600179F RID: 6047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTime_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x060017A0 RID: 6048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimLength_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x060017A1 RID: 6049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetReceiveNotifiesFromLinkedInstances_Internal(IntPtr @this);

		// Token: 0x060017A2 RID: 6050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPropagateNotifiesToLinkedInstances_Internal(IntPtr @this);

		// Token: 0x060017A3 RID: 6051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningComponent_Internal(IntPtr @this);

		// Token: 0x060017A4 RID: 6052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningActor_Internal(IntPtr @this);

		// Token: 0x060017A5 RID: 6053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOriginStates_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x060017A6 RID: 6054
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMainAnimsDebugText_Internal(IntPtr @this);

		// Token: 0x060017A7 RID: 6055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMainAnimsCurveValueWithDelta_Internal(IntPtr @this, FName CurveName, float DeltaTime, bool bRawDeltaTime, bool bCycleTimeIfLoop);

		// Token: 0x060017A8 RID: 6056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMainAnims_Internal(IntPtr @this, IntPtr Anims, IntPtr Weights, IntPtr CurrentTimes, IntPtr PlayRates);

		// Token: 0x060017A9 RID: 6057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimLayerInstancesByGroup_Internal(IntPtr @this, FName InGroup, IntPtr OutLinkedInstances);

		// Token: 0x060017AA RID: 6058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroupAndClass_Internal(IntPtr @this, FName InGroup, IntPtr InClass);

		// Token: 0x060017AB RID: 6059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroup_Internal(IntPtr @this, FName InGroup);

		// Token: 0x060017AC RID: 6060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x060017AD RID: 6061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimGraphInstancesByTag_Internal(IntPtr @this, FName InTag, IntPtr OutLinkedInstances);

		// Token: 0x060017AE RID: 6062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimGraphInstanceByTag_Internal(IntPtr @this, FName InTag);

		// Token: 0x060017AF RID: 6063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetKuroCachedBoneTransform_Internal(IntPtr @this, FName Name);

		// Token: 0x060017B0 RID: 6064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionTimeElapsedFraction_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x060017B1 RID: 6065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionTimeElapsed_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x060017B2 RID: 6066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionCrossfadeDuration_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x060017B3 RID: 6067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceStateWeight_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x060017B4 RID: 6068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceMachineWeight_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x060017B5 RID: 6069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceCurrentStateElapsedTime_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x060017B6 RID: 6070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFromEndFraction_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x060017B7 RID: 6071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFromEnd_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x060017B8 RID: 6072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFraction_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x060017B9 RID: 6073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTime_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x060017BA RID: 6074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerLength_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x060017BB RID: 6075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurveValue_Internal(IntPtr @this, FName CurveName);

		// Token: 0x060017BC RID: 6076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentStateName_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x060017BD RID: 6077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentActiveMontage_Internal(IntPtr @this);

		// Token: 0x060017BE RID: 6078
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAnimsDebugText_Internal(IntPtr @this);

		// Token: 0x060017BF RID: 6079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAnimAssetVariantIndex_Internal(IntPtr @this);

		// Token: 0x060017C0 RID: 6080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimAssetVariantBlendTime_Internal(IntPtr @this);

		// Token: 0x060017C1 RID: 6081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllCurveNames_Internal(IntPtr @this, IntPtr OutNames);

		// Token: 0x060017C2 RID: 6082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActiveCurveNames_Internal(IntPtr @this, EAnimCurveType CurveType, IntPtr OutNames);

		// Token: 0x060017C3 RID: 6083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceSetCurrentMontageBlendTime_Internal(IntPtr @this, float BlendTime, IntPtr Montage);

		// Token: 0x060017C4 RID: 6084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ConsumeExtractedRootMotion_Internal(IntPtr @this, float Alpha);

		// Token: 0x060017C5 RID: 6085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearStateOrdersSendPending_Internal(IntPtr @this);

		// Token: 0x060017C6 RID: 6086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearStateOrdersReceivePending_Internal(IntPtr @this);

		// Token: 0x060017C7 RID: 6087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMorphTargets_Internal(IntPtr @this);

		// Token: 0x060017C8 RID: 6088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMontage_Internal(IntPtr @this);

		// Token: 0x060017C9 RID: 6089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateDirection_Internal(IntPtr @this, in FVector Velocity, in FRotator BaseRotation);

		// Token: 0x060017CA RID: 6090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintUpdateAnimation_Internal(IntPtr @this, float DeltaTimeX);

		// Token: 0x060017CB RID: 6091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintPostEvaluateAnimation_Internal(IntPtr @this);

		// Token: 0x060017CC RID: 6092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintLinkedAnimationLayersInitialized_Internal(IntPtr @this);

		// Token: 0x060017CD RID: 6093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintInitializeAnimation_Internal(IntPtr @this);

		// Token: 0x060017CE RID: 6094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintBeginPlay_Internal(IntPtr @this);

		// Token: 0x060017CF RID: 6095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceUpdateSlotNameWhenMontageBlend_Internal(IntPtr @this, FName SlotName);

		// Token: 0x060017D0 RID: 6096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDeltaForDelayAnim_Internal(IntPtr @this, float Delta);

		// Token: 0x060017D1 RID: 6097 RVA: 0x000247F8 File Offset: 0x000229F8
		static UAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimInstance");
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00024806 File Offset: 0x00022A06
		protected UAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400074A RID: 1866
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimInstance";

		// Token: 0x0400074B RID: 1867
		private static IntPtr _ClassPtr;

		// Token: 0x0400074C RID: 1868
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400074D RID: 1869
		internal static int __PropertyOffset_CurrentSkeleton;

		// Token: 0x0400074E RID: 1870
		internal static int __PropertyOffset_RootMotionMode;

		// Token: 0x0400074F RID: 1871
		internal static int __PropertyOffset_bUseMultiThreadedAnimationUpdate;

		// Token: 0x04000750 RID: 1872
		internal static byte __PropertyMask_bUseMultiThreadedAnimationUpdate;

		// Token: 0x04000751 RID: 1873
		internal static int __PropertyOffset_bResultWithUnSafeThreadFunction;

		// Token: 0x04000752 RID: 1874
		internal static int __PropertyOffset_AnimOrigin;

		// Token: 0x04000753 RID: 1875
		internal static int __PropertyOffset_bUsingCopyPoseFromMesh;

		// Token: 0x04000754 RID: 1876
		internal static byte __PropertyMask_bUsingCopyPoseFromMesh;

		// Token: 0x04000755 RID: 1877
		internal static int __PropertyOffset_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x04000756 RID: 1878
		internal static byte __PropertyMask_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x04000757 RID: 1879
		internal static int __PropertyOffset_bPropagateNotifiesToLinkedInstances;

		// Token: 0x04000758 RID: 1880
		internal static byte __PropertyMask_bPropagateNotifiesToLinkedInstances;

		// Token: 0x04000759 RID: 1881
		internal static int __PropertyOffset_RibbonAnims;

		// Token: 0x0400075A RID: 1882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UAnimSequence> _RibbonAnims;

		// Token: 0x0400075B RID: 1883
		internal static int __PropertyOffset_SoftRibbonAnims;

		// Token: 0x0400075C RID: 1884
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FName, TSoftObjectPtr<UAnimSequence>> _SoftRibbonAnims;

		// Token: 0x0400075D RID: 1885
		internal static int __PropertyOffset_bQueueMontageEvents;

		// Token: 0x0400075E RID: 1886
		internal static byte __PropertyMask_bQueueMontageEvents;

		// Token: 0x0400075F RID: 1887
		internal static int __PropertyOffset_bEnableAnimCurvesFilter;

		// Token: 0x04000760 RID: 1888
		internal static int __PropertyOffset_AnimCurvesToFilter;

		// Token: 0x04000761 RID: 1889
		private TArray<FName> _AnimCurvesToFilter;

		// Token: 0x04000762 RID: 1890
		internal static int __PropertyOffset_bShouldRestoreAnimCurvesToFilter;

		// Token: 0x04000763 RID: 1891
		internal static int __PropertyOffset_bEnableAnimCurvesFilterBackup;

		// Token: 0x04000764 RID: 1892
		internal static int __PropertyOffset_AnimCurvesToFilterBackup;

		// Token: 0x04000765 RID: 1893
		private TArray<FName> _AnimCurvesToFilterBackup;

		// Token: 0x04000766 RID: 1894
		internal static int __PropertyOffset_DebugDestructText;

		// Token: 0x04000767 RID: 1895
		internal static int __PropertyOffset_SoftAssetsLoaded;

		// Token: 0x04000768 RID: 1896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UAnimationAsset> _SoftAssetsLoaded;

		// Token: 0x04000769 RID: 1897
		internal static int __PropertyOffset_OnMontageBlendingOut;

		// Token: 0x0400076A RID: 1898
		private FOnMontageBlendingOutStartedMCDelegate _OnMontageBlendingOut;

		// Token: 0x0400076B RID: 1899
		internal static int __PropertyOffset_OnMontageStarted;

		// Token: 0x0400076C RID: 1900
		private FOnMontageStartedMCDelegate _OnMontageStarted;

		// Token: 0x0400076D RID: 1901
		internal static int __PropertyOffset_OnMontageEnded;

		// Token: 0x0400076E RID: 1902
		private FOnMontageEndedMCDelegate _OnMontageEnded;

		// Token: 0x0400076F RID: 1903
		internal static int __PropertyOffset_OnAllMontageInstancesEnded;

		// Token: 0x04000770 RID: 1904
		private FOnAllMontageInstancesEndedMCDelegate _OnAllMontageInstancesEnded;

		// Token: 0x04000771 RID: 1905
		internal static int __PropertyOffset_ActiveAnimNotifyState;

		// Token: 0x04000772 RID: 1906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _ActiveAnimNotifyState;

		// Token: 0x04000773 RID: 1907
		internal static int __PropertyOffset_AnimAssetVariantIndex;

		// Token: 0x04000774 RID: 1908
		internal static int __PropertyOffset_AnimAssetVariantBlendTime;

		// Token: 0x04000775 RID: 1909
		internal static int __PropertyOffset_bIsNetMode;

		// Token: 0x02000966 RID: 2406
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04005892 RID: 22674
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
