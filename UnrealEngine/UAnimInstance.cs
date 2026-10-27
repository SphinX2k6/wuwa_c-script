using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080A RID: 2058
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimInstance")]
	[UnrealStructLayout(2160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2160)]
	public class UAnimInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D9E RID: 28062 RVA: 0x0009DB37 File Offset: 0x0009BD37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimInstance._ClassPtr;
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x0009DB44 File Offset: 0x0009BD44
		public UAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x0009DB6C File Offset: 0x0009BD6C
		[NullableContext(1)]
		public UAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06006DA1 RID: 28065 RVA: 0x0009DB9F File Offset: 0x0009BD9F
		// (set) Token: 0x06006DA2 RID: 28066 RVA: 0x0009DBB3 File Offset: 0x0009BDB3
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

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06006DA3 RID: 28067 RVA: 0x0009DBC8 File Offset: 0x0009BDC8
		// (set) Token: 0x06006DA4 RID: 28068 RVA: 0x0009DBDC File Offset: 0x0009BDDC
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

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x0009DBF1 File Offset: 0x0009BDF1
		// (set) Token: 0x06006DA6 RID: 28070 RVA: 0x0009DC0A File Offset: 0x0009BE0A
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

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x0009DC3A File Offset: 0x0009BE3A
		// (set) Token: 0x06006DA8 RID: 28072 RVA: 0x0009DC4A File Offset: 0x0009BE4A
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

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x0009DC5B File Offset: 0x0009BE5B
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x0009DC6F File Offset: 0x0009BE6F
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

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x0009DC84 File Offset: 0x0009BE84
		// (set) Token: 0x06006DAC RID: 28076 RVA: 0x0009DC9D File Offset: 0x0009BE9D
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

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x0009DCCD File Offset: 0x0009BECD
		// (set) Token: 0x06006DAE RID: 28078 RVA: 0x0009DCE6 File Offset: 0x0009BEE6
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06006DAF RID: 28079 RVA: 0x0009DD16 File Offset: 0x0009BF16
		// (set) Token: 0x06006DB0 RID: 28080 RVA: 0x0009DD2F File Offset: 0x0009BF2F
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

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06006DB1 RID: 28081 RVA: 0x0009DD60 File Offset: 0x0009BF60
		// (set) Token: 0x06006DB2 RID: 28082 RVA: 0x0009DD99 File Offset: 0x0009BF99
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

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x0009DDA8 File Offset: 0x0009BFA8
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x0009DDE1 File Offset: 0x0009BFE1
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

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0009DDEF File Offset: 0x0009BFEF
		// (set) Token: 0x06006DB6 RID: 28086 RVA: 0x0009DE08 File Offset: 0x0009C008
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

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06006DB7 RID: 28087 RVA: 0x0009DE38 File Offset: 0x0009C038
		// (set) Token: 0x06006DB8 RID: 28088 RVA: 0x0009DE48 File Offset: 0x0009C048
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

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x0009DE5C File Offset: 0x0009C05C
		// (set) Token: 0x06006DBA RID: 28090 RVA: 0x0009DE95 File Offset: 0x0009C095
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

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06006DBB RID: 28091 RVA: 0x0009DEA3 File Offset: 0x0009C0A3
		// (set) Token: 0x06006DBC RID: 28092 RVA: 0x0009DEB3 File Offset: 0x0009C0B3
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

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
		// (set) Token: 0x06006DBE RID: 28094 RVA: 0x0009DED4 File Offset: 0x0009C0D4
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06006DBF RID: 28095 RVA: 0x0009DEE8 File Offset: 0x0009C0E8
		// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x0009DF21 File Offset: 0x0009C121
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

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x0009DF2F File Offset: 0x0009C12F
		// (set) Token: 0x06006DC2 RID: 28098 RVA: 0x0009DF43 File Offset: 0x0009C143
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

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x0009DF58 File Offset: 0x0009C158
		// (set) Token: 0x06006DC4 RID: 28100 RVA: 0x0009DF91 File Offset: 0x0009C191
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x0009DFA0 File Offset: 0x0009C1A0
		// (set) Token: 0x06006DC6 RID: 28102 RVA: 0x0009DFD9 File Offset: 0x0009C1D9
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

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06006DC7 RID: 28103 RVA: 0x0009DFFC File Offset: 0x0009C1FC
		// (set) Token: 0x06006DC8 RID: 28104 RVA: 0x0009E035 File Offset: 0x0009C235
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x0009E058 File Offset: 0x0009C258
		// (set) Token: 0x06006DCA RID: 28106 RVA: 0x0009E091 File Offset: 0x0009C291
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

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x0009E0B4 File Offset: 0x0009C2B4
		// (set) Token: 0x06006DCC RID: 28108 RVA: 0x0009E0ED File Offset: 0x0009C2ED
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

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x0009E110 File Offset: 0x0009C310
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x0009E149 File Offset: 0x0009C349
		[Nullable(1)]
		public FAnimNotifyQueue NotifyQueue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAnimNotifyQueue result;
				if ((result = this._NotifyQueue) == null)
				{
					result = (this._NotifyQueue = new FAnimNotifyQueue(base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_NotifyQueue, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimNotifyQueue.StaticStruct(), base.NativePtr + (IntPtr)UAnimInstance.__PropertyOffset_NotifyQueue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x0009E16C File Offset: 0x0009C36C
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x0009E1A5 File Offset: 0x0009C3A5
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x0009E1B3 File Offset: 0x0009C3B3
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x0009E1C3 File Offset: 0x0009C3C3
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

		// Token: 0x06006DD3 RID: 28115 RVA: 0x0009E1D4 File Offset: 0x0009C3D4
		public void UnlockAIResources(bool bUnlockMovement, bool UnlockAILogic)
		{
			UAnimInstance.__UnlockAIResources_Internal(base.NativePtr, bUnlockMovement, UnlockAILogic);
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x0009E1E3 File Offset: 0x0009C3E3
		public void UnlinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__UnlinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0009E1F6 File Offset: 0x0009C3F6
		public APawn TryGetPawnOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UAnimInstance.__TryGetPawnOwner_Internal(base.NativePtr));
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x0009E208 File Offset: 0x0009C408
		public bool SyncAnimStates(UAnimInstance Other)
		{
			return UAnimInstance.__SyncAnimStates_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x0009E225 File Offset: 0x0009C425
		public void StopSlotAnimation(float InBlendOutTime = 0.25f, FName SlotNodeName = default(FName))
		{
			UAnimInstance.__StopSlotAnimation_Internal(base.NativePtr, InBlendOutTime, SlotNodeName);
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x0009E234 File Offset: 0x0009C434
		public void SnapshotPose(ref FPoseSnapshot Snapshot)
		{
			UAnimInstance.__SnapshotPose_Internal(base.NativePtr, (Snapshot ?? new FPoseSnapshot()).NativePtr);
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x0009E251 File Offset: 0x0009C451
		public void SetStateOrdersReceivePending(TArray<int> Orders)
		{
			UAnimInstance.__SetStateOrdersReceivePending_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x0009E26D File Offset: 0x0009C46D
		public void SetStateMachineNetMode(bool isNetMode = false)
		{
			UAnimInstance.__SetStateMachineNetMode_Internal(base.NativePtr, isNetMode);
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x0009E27B File Offset: 0x0009C47B
		public void SetRootMotionMode(ERootMotionMode Value)
		{
			UAnimInstance.__SetRootMotionMode_Internal(base.NativePtr, Value);
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x0009E28E File Offset: 0x0009C48E
		public void SetReceiveNotifiesFromLinkedInstances(bool bSet)
		{
			UAnimInstance.__SetReceiveNotifiesFromLinkedInstances_Internal(base.NativePtr, bSet);
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x0009E29C File Offset: 0x0009C49C
		public void SetPropagateNotifiesToLinkedInstances(bool bSet)
		{
			UAnimInstance.__SetPropagateNotifiesToLinkedInstances_Internal(base.NativePtr, bSet);
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x0009E2AA File Offset: 0x0009C4AA
		public void SetMorphTarget(FName MorphTargetName, float Value)
		{
			UAnimInstance.__SetMorphTarget_Internal(base.NativePtr, MorphTargetName, Value);
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x0009E2B9 File Offset: 0x0009C4B9
		public void SetDelayAnimTime(float Time, float CollectPeriod)
		{
			UAnimInstance.__SetDelayAnimTime_Internal(base.NativePtr, Time, CollectPeriod);
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0009E2C8 File Offset: 0x0009C4C8
		public void SavePoseSnapshot(FName SnapshotName)
		{
			UAnimInstance.__SavePoseSnapshot_Internal(base.NativePtr, SnapshotName);
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x0009E2D6 File Offset: 0x0009C4D6
		public void ResetDynamics(ETeleportType InTeleportType)
		{
			UAnimInstance.__ResetDynamics_Internal(base.NativePtr, InTeleportType);
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x0009E2E4 File Offset: 0x0009C4E4
		public void RemoveForceUpdateSlotNameWhenMontageBlend(FName SlotName)
		{
			UAnimInstance.__RemoveForceUpdateSlotNameWhenMontageBlend_Internal(base.NativePtr, SlotName);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0009E2F4 File Offset: 0x0009C4F4
		public UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset, FName SlotNodeName, float BlendInTime = 0.25f, float BlendOutTime = 0.25f, float InPlayRate = 1f, int LoopCount = 1, float BlendOutTriggerTime = -1f, float InTimeToStartMontageAt = 0f, bool bStopAllMontages = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UAnimInstance.__PlaySlotAnimationAsDynamicMontage_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount, BlendOutTriggerTime, InTimeToStartMontageAt, bStopAllMontages));
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0009E32F File Offset: 0x0009C52F
		public float PlaySlotAnimation(UAnimSequenceBase Asset, FName SlotNodeName, float BlendInTime = 0.25f, float BlendOutTime = 0.25f, float InPlayRate = 1f, int LoopCount = 1)
		{
			return UAnimInstance.__PlaySlotAnimation_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName, BlendInTime, BlendOutTime, InPlayRate, LoopCount);
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x0009E354 File Offset: 0x0009C554
		public void Montage_StopGroupByName(float InBlendOutTime, FName GroupName)
		{
			UAnimInstance.__Montage_StopGroupByName_Internal(base.NativePtr, InBlendOutTime, GroupName);
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0009E363 File Offset: 0x0009C563
		public void Montage_Stop(float InBlendOutTime, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_Stop_Internal(base.NativePtr, InBlendOutTime, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x0009E381 File Offset: 0x0009C581
		public void Montage_SetPosition(UAnimMontage Montage, float NewPosition)
		{
			UAnimInstance.__Montage_SetPosition_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, NewPosition);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x0009E39F File Offset: 0x0009C59F
		public void Montage_SetPlayRate(UAnimMontage Montage, float NewPlayRate = 1f)
		{
			UAnimInstance.__Montage_SetPlayRate_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, NewPlayRate);
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x0009E3BD File Offset: 0x0009C5BD
		public void Montage_SetNextSection(FName SectionNameToChange, FName NextSection, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_SetNextSection_Internal(base.NativePtr, SectionNameToChange, NextSection, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x0009E3DC File Offset: 0x0009C5DC
		public void Montage_Resume(UAnimMontage Montage)
		{
			UAnimInstance.__Montage_Resume_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x0009E3F9 File Offset: 0x0009C5F9
		public float Montage_Play(UAnimMontage MontageToPlay, float InPlayRate = 1f, EMontagePlayReturnType ReturnValueType = EMontagePlayReturnType.MontageLength, float InTimeToStartMontageAt = 0f, bool bStopAllMontages = true)
		{
			return UAnimInstance.__Montage_Play_Internal(base.NativePtr, (MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero, InPlayRate, ReturnValueType, InTimeToStartMontageAt, bStopAllMontages);
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x0009E41C File Offset: 0x0009C61C
		public void Montage_Pause(UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_Pause_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x0009E439 File Offset: 0x0009C639
		public void Montage_MuteAllMontage()
		{
			UAnimInstance.__Montage_MuteAllMontage_Internal(base.NativePtr);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0009E446 File Offset: 0x0009C646
		public void Montage_JumpToSectionsEnd(FName SectionName, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_JumpToSectionsEnd_Internal(base.NativePtr, SectionName, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x0009E464 File Offset: 0x0009C664
		public void Montage_JumpToSection(FName SectionName, UAnimMontage Montage = null)
		{
			UAnimInstance.__Montage_JumpToSection_Internal(base.NativePtr, SectionName, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x0009E482 File Offset: 0x0009C682
		public bool Montage_IsPlaying(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_IsPlaying_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x0009E49F File Offset: 0x0009C69F
		public bool Montage_IsActive(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_IsActive_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x0009E4BC File Offset: 0x0009C6BC
		public float Montage_GetPosition(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetPosition_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x0009E4D9 File Offset: 0x0009C6D9
		public float Montage_GetPlayRate(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetPlayRate_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x0009E4F6 File Offset: 0x0009C6F6
		public bool Montage_GetIsStopped(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetIsStopped_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x0009E513 File Offset: 0x0009C713
		public FName Montage_GetCurrentSection(UAnimMontage Montage = null)
		{
			return UAnimInstance.__Montage_GetCurrentSection_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x0009E530 File Offset: 0x0009C730
		public float Montage_GetBlendTime(UAnimMontage Montage)
		{
			return UAnimInstance.__Montage_GetBlendTime_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x0009E54D File Offset: 0x0009C74D
		public void LockAIResources(bool bLockMovement, bool LockAILogic)
		{
			UAnimInstance.__LockAIResources_Internal(base.NativePtr, bLockMovement, LockAILogic);
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x0009E55C File Offset: 0x0009C75C
		public void LinkAnimGraphByTag(FName InTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__LinkAnimGraphByTag_Internal(base.NativePtr, InTag, InClass._NativePtr);
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x0009E570 File Offset: 0x0009C770
		public void LinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			UAnimInstance.__LinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x0009E583 File Offset: 0x0009C783
		public bool IsSyncGroupBetweenMarkers(FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder = true)
		{
			return UAnimInstance.__IsSyncGroupBetweenMarkers_Internal(base.NativePtr, InSyncGroupName, PreviousMarker, NextMarker, bRespectMarkerOrder);
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x0009E595 File Offset: 0x0009C795
		public bool IsPlayingSlotAnimation(UAnimSequenceBase Asset, FName SlotNodeName)
		{
			return UAnimInstance.__IsPlayingSlotAnimation_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero, SlotNodeName);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x0009E5B3 File Offset: 0x0009C7B3
		public bool IsKuroForceFlying()
		{
			return UAnimInstance.__IsKuroForceFlying_Internal(base.NativePtr);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x0009E5C0 File Offset: 0x0009C7C0
		public bool IsAnyMontagePlaying()
		{
			return UAnimInstance.__IsAnyMontagePlaying_Internal(base.NativePtr);
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x0009E5CD File Offset: 0x0009C7CD
		public bool HasMarkerBeenHitThisFrame(FName SyncGroup, FName MarkerName)
		{
			return UAnimInstance.__HasMarkerBeenHitThisFrame_Internal(base.NativePtr, SyncGroup, MarkerName);
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x0009E5DC File Offset: 0x0009C7DC
		public bool HasKuroRootMotionAnim()
		{
			return UAnimInstance.__HasKuroRootMotionAnim_Internal(base.NativePtr);
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		public unsafe bool GetTimeToClosestMarker(FName SyncGroup, FName MarkerName, ref float OutMarkerTime)
		{
			fixed (float* ptr = &OutMarkerTime)
			{
				void* ptr2 = (void*)ptr;
				return UAnimInstance.__GetTimeToClosestMarker_Internal(base.NativePtr, SyncGroup, MarkerName, ref OutMarkerTime);
			}
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x0009E60C File Offset: 0x0009C80C
		[NullableContext(1)]
		public FMarkerSyncAnimPosition GetSyncGroupPosition(FName InSyncGroupName)
		{
			return new FMarkerSyncAnimPosition(UAnimInstance.__GetSyncGroupPosition_Internal(base.NativePtr, InSyncGroupName), null);
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x0009E620 File Offset: 0x0009C820
		public bool GetStateOrdersSendPending(ref TArray<int> Orders)
		{
			return UAnimInstance.__GetStateOrdersSendPending_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x0009E63D File Offset: 0x0009C83D
		public float GetRelevantAnimTimeRemainingFraction(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeRemainingFraction_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x0009E64C File Offset: 0x0009C84C
		public float GetRelevantAnimTimeRemaining(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeRemaining_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x0009E65B File Offset: 0x0009C85B
		public float GetRelevantAnimTimeFraction(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTimeFraction_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x0009E66A File Offset: 0x0009C86A
		public float GetRelevantAnimTime(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimTime_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x0009E679 File Offset: 0x0009C879
		public float GetRelevantAnimLength(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetRelevantAnimLength_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x0009E688 File Offset: 0x0009C888
		public bool GetReceiveNotifiesFromLinkedInstances()
		{
			return UAnimInstance.__GetReceiveNotifiesFromLinkedInstances_Internal(base.NativePtr);
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x0009E695 File Offset: 0x0009C895
		public bool GetPropagateNotifiesToLinkedInstances()
		{
			return UAnimInstance.__GetPropagateNotifiesToLinkedInstances_Internal(base.NativePtr);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x0009E6A2 File Offset: 0x0009C8A2
		public USkeletalMeshComponent GetOwningComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UAnimInstance.__GetOwningComponent_Internal(base.NativePtr));
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x0009E6B4 File Offset: 0x0009C8B4
		public AActor GetOwningActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAnimInstance.__GetOwningActor_Internal(base.NativePtr));
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x0009E6C6 File Offset: 0x0009C8C6
		public void GetOriginStates(ref TArray<int> Orders)
		{
			UAnimInstance.__GetOriginStates_Internal(base.NativePtr, (Orders ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x0009E6E3 File Offset: 0x0009C8E3
		[NullableContext(1)]
		public string GetMainAnimsDebugText()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimInstance.__GetMainAnimsDebugText_Internal(base.NativePtr));
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x0009E6F5 File Offset: 0x0009C8F5
		public float GetMainAnimsCurveValueWithDelta(FName CurveName, float DeltaTime, bool bRawDeltaTime = false, bool bCycleTimeIfLoop = false)
		{
			return UAnimInstance.__GetMainAnimsCurveValueWithDelta_Internal(base.NativePtr, CurveName, DeltaTime, bRawDeltaTime, bCycleTimeIfLoop);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x0009E708 File Offset: 0x0009C908
		public void GetMainAnims(ref TArray<FName> Anims, ref TArray<float> Weights, ref TArray<float> CurrentTimes, ref TArray<float> PlayRates)
		{
			UAnimInstance.__GetMainAnims_Internal(base.NativePtr, (Anims ?? new TArray<FName>()).NativePtr, (Weights ?? new TArray<float>()).NativePtr, (CurrentTimes ?? new TArray<float>()).NativePtr, (PlayRates ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0009E761 File Offset: 0x0009C961
		public void GetLinkedAnimLayerInstancesByGroup(FName InGroup, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			UAnimInstance.__GetLinkedAnimLayerInstancesByGroup_Internal(base.NativePtr, InGroup, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x0009E77F File Offset: 0x0009C97F
		public UAnimInstance GetLinkedAnimLayerInstanceByGroupAndClass(FName InGroup, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByGroupAndClass_Internal(base.NativePtr, InGroup, InClass._NativePtr));
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x0009E798 File Offset: 0x0009C998
		public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByGroup_Internal(base.NativePtr, InGroup));
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x0009E7AB File Offset: 0x0009C9AB
		public UAnimInstance GetLinkedAnimLayerInstanceByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimLayerInstanceByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x0009E7C3 File Offset: 0x0009C9C3
		public void GetLinkedAnimGraphInstancesByTag(FName InTag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			UAnimInstance.__GetLinkedAnimGraphInstancesByTag_Internal(base.NativePtr, InTag, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x0009E7E1 File Offset: 0x0009C9E1
		public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(UAnimInstance.__GetLinkedAnimGraphInstanceByTag_Internal(base.NativePtr, InTag));
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x0009E7F4 File Offset: 0x0009C9F4
		public FTransform GetKuroCachedBoneTransform(FName Name)
		{
			return UAnimInstance.__GetKuroCachedBoneTransform_Internal(base.NativePtr, Name);
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x0009E802 File Offset: 0x0009CA02
		public float GetInstanceTransitionTimeElapsedFraction(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionTimeElapsedFraction_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x0009E811 File Offset: 0x0009CA11
		public float GetInstanceTransitionTimeElapsed(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionTimeElapsed_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x0009E820 File Offset: 0x0009CA20
		public float GetInstanceTransitionCrossfadeDuration(int MachineIndex, int TransitionIndex)
		{
			return UAnimInstance.__GetInstanceTransitionCrossfadeDuration_Internal(base.NativePtr, MachineIndex, TransitionIndex);
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x0009E82F File Offset: 0x0009CA2F
		public float GetInstanceStateWeight(int MachineIndex, int StateIndex)
		{
			return UAnimInstance.__GetInstanceStateWeight_Internal(base.NativePtr, MachineIndex, StateIndex);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x0009E83E File Offset: 0x0009CA3E
		public float GetInstanceMachineWeight(int MachineIndex)
		{
			return UAnimInstance.__GetInstanceMachineWeight_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x0009E84C File Offset: 0x0009CA4C
		public float GetInstanceCurrentStateElapsedTime(int MachineIndex)
		{
			return UAnimInstance.__GetInstanceCurrentStateElapsedTime_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x0009E85A File Offset: 0x0009CA5A
		public float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFromEndFraction_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x0009E868 File Offset: 0x0009CA68
		public float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFromEnd_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x0009E876 File Offset: 0x0009CA76
		public float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTimeFraction_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x0009E884 File Offset: 0x0009CA84
		public float GetInstanceAssetPlayerTime(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerTime_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x0009E892 File Offset: 0x0009CA92
		public float GetInstanceAssetPlayerLength(int AssetPlayerIndex)
		{
			return UAnimInstance.__GetInstanceAssetPlayerLength_Internal(base.NativePtr, AssetPlayerIndex);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		public float GetCurveValue(FName CurveName)
		{
			return UAnimInstance.__GetCurveValue_Internal(base.NativePtr, CurveName);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x0009E8AE File Offset: 0x0009CAAE
		public FName GetCurrentStateName(int MachineIndex)
		{
			return UAnimInstance.__GetCurrentStateName_Internal(base.NativePtr, MachineIndex);
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x0009E8BC File Offset: 0x0009CABC
		public UAnimMontage GetCurrentActiveMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UAnimInstance.__GetCurrentActiveMontage_Internal(base.NativePtr));
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x0009E8CE File Offset: 0x0009CACE
		[NullableContext(1)]
		public string GetAnimsDebugText()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimInstance.__GetAnimsDebugText_Internal(base.NativePtr));
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x0009E8E0 File Offset: 0x0009CAE0
		public void GetAllCurveNames(ref TArray<FName> OutNames)
		{
			UAnimInstance.__GetAllCurveNames_Internal(base.NativePtr, (OutNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x0009E8FD File Offset: 0x0009CAFD
		public void GetActiveCurveNames(EAnimCurveType CurveType, ref TArray<FName> OutNames)
		{
			UAnimInstance.__GetActiveCurveNames_Internal(base.NativePtr, CurveType, (OutNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0009E91B File Offset: 0x0009CB1B
		public void ForceSetCurrentMontageBlendTime(float BlendTime, UAnimMontage Montage = null)
		{
			UAnimInstance.__ForceSetCurrentMontageBlendTime_Internal(base.NativePtr, BlendTime, (Montage != null) ? Montage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x0009E939 File Offset: 0x0009CB39
		[NullableContext(1)]
		public FRootMotionMovementParams ConsumeExtractedRootMotion(float Alpha)
		{
			return new FRootMotionMovementParams(UAnimInstance.__ConsumeExtractedRootMotion_Internal(base.NativePtr, Alpha), null);
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x0009E94D File Offset: 0x0009CB4D
		public void ClearStateOrdersSendPending()
		{
			UAnimInstance.__ClearStateOrdersSendPending_Internal(base.NativePtr);
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x0009E95A File Offset: 0x0009CB5A
		public void ClearStateOrdersReceivePending()
		{
			UAnimInstance.__ClearStateOrdersReceivePending_Internal(base.NativePtr);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x0009E967 File Offset: 0x0009CB67
		public void ClearMorphTargets()
		{
			UAnimInstance.__ClearMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x0009E974 File Offset: 0x0009CB74
		public void ClearMontage()
		{
			UAnimInstance.__ClearMontage_Internal(base.NativePtr);
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x0009E981 File Offset: 0x0009CB81
		public float CalculateDirection(in FVector Velocity, in FRotator BaseRotation)
		{
			return UAnimInstance.__CalculateDirection_Internal(base.NativePtr, Velocity, BaseRotation);
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x0009E990 File Offset: 0x0009CB90
		public virtual void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			UAnimInstance.__BlueprintUpdateAnimation_Internal(base.NativePtr, DeltaTimeX);
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x0009E99E File Offset: 0x0009CB9E
		public virtual void BlueprintPostEvaluateAnimation()
		{
			UAnimInstance.__BlueprintPostEvaluateAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x0009E9AB File Offset: 0x0009CBAB
		public virtual void BlueprintLinkedAnimationLayersInitialized()
		{
			UAnimInstance.__BlueprintLinkedAnimationLayersInitialized_Internal(base.NativePtr);
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x0009E9B8 File Offset: 0x0009CBB8
		public virtual void BlueprintInitializeAnimation()
		{
			UAnimInstance.__BlueprintInitializeAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x0009E9C5 File Offset: 0x0009CBC5
		public virtual void BlueprintBeginPlay()
		{
			UAnimInstance.__BlueprintBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x0009E9D2 File Offset: 0x0009CBD2
		public void AddForceUpdateSlotNameWhenMontageBlend(FName SlotName)
		{
			UAnimInstance.__AddForceUpdateSlotNameWhenMontageBlend_Internal(base.NativePtr, SlotName);
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		public void AddDeltaForDelayAnim(float Delta)
		{
			UAnimInstance.__AddDeltaForDelayAnim_Internal(base.NativePtr, Delta);
		}

		// Token: 0x06006E36 RID: 28214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAIResources_Internal(IntPtr @this, bool bUnlockMovement, bool UnlockAILogic);

		// Token: 0x06006E37 RID: 28215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06006E38 RID: 28216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TryGetPawnOwner_Internal(IntPtr @this);

		// Token: 0x06006E39 RID: 28217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SyncAnimStates_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06006E3A RID: 28218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSlotAnimation_Internal(IntPtr @this, float InBlendOutTime, FName SlotNodeName);

		// Token: 0x06006E3B RID: 28219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapshotPose_Internal(IntPtr @this, IntPtr Snapshot);

		// Token: 0x06006E3C RID: 28220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateOrdersReceivePending_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x06006E3D RID: 28221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateMachineNetMode_Internal(IntPtr @this, bool isNetMode);

		// Token: 0x06006E3E RID: 28222
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRootMotionMode_Internal(IntPtr @this, TEnumAsByte<ERootMotionMode> Value);

		// Token: 0x06006E3F RID: 28223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReceiveNotifiesFromLinkedInstances_Internal(IntPtr @this, bool bSet);

		// Token: 0x06006E40 RID: 28224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPropagateNotifiesToLinkedInstances_Internal(IntPtr @this, bool bSet);

		// Token: 0x06006E41 RID: 28225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMorphTarget_Internal(IntPtr @this, FName MorphTargetName, float Value);

		// Token: 0x06006E42 RID: 28226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelayAnimTime_Internal(IntPtr @this, float Time, float CollectPeriod);

		// Token: 0x06006E43 RID: 28227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SavePoseSnapshot_Internal(IntPtr @this, FName SnapshotName);

		// Token: 0x06006E44 RID: 28228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetDynamics_Internal(IntPtr @this, ETeleportType InTeleportType);

		// Token: 0x06006E45 RID: 28229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceUpdateSlotNameWhenMontageBlend_Internal(IntPtr @this, FName SlotName);

		// Token: 0x06006E46 RID: 28230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlaySlotAnimationAsDynamicMontage_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt, bool bStopAllMontages);

		// Token: 0x06006E47 RID: 28231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PlaySlotAnimation_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount);

		// Token: 0x06006E48 RID: 28232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_StopGroupByName_Internal(IntPtr @this, float InBlendOutTime, FName GroupName);

		// Token: 0x06006E49 RID: 28233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Stop_Internal(IntPtr @this, float InBlendOutTime, IntPtr Montage);

		// Token: 0x06006E4A RID: 28234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetPosition_Internal(IntPtr @this, IntPtr Montage, float NewPosition);

		// Token: 0x06006E4B RID: 28235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetPlayRate_Internal(IntPtr @this, IntPtr Montage, float NewPlayRate);

		// Token: 0x06006E4C RID: 28236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_SetNextSection_Internal(IntPtr @this, FName SectionNameToChange, FName NextSection, IntPtr Montage);

		// Token: 0x06006E4D RID: 28237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Resume_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E4E RID: 28238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_Play_Internal(IntPtr @this, IntPtr MontageToPlay, float InPlayRate, EMontagePlayReturnType ReturnValueType, float InTimeToStartMontageAt, bool bStopAllMontages);

		// Token: 0x06006E4F RID: 28239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_Pause_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E50 RID: 28240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_MuteAllMontage_Internal(IntPtr @this);

		// Token: 0x06006E51 RID: 28241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_JumpToSectionsEnd_Internal(IntPtr @this, FName SectionName, IntPtr Montage);

		// Token: 0x06006E52 RID: 28242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Montage_JumpToSection_Internal(IntPtr @this, FName SectionName, IntPtr Montage);

		// Token: 0x06006E53 RID: 28243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_IsPlaying_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E54 RID: 28244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_IsActive_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E55 RID: 28245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetPosition_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E56 RID: 28246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetPlayRate_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E57 RID: 28247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Montage_GetIsStopped_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E58 RID: 28248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __Montage_GetCurrentSection_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E59 RID: 28249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Montage_GetBlendTime_Internal(IntPtr @this, IntPtr Montage);

		// Token: 0x06006E5A RID: 28250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAIResources_Internal(IntPtr @this, bool bLockMovement, bool LockAILogic);

		// Token: 0x06006E5B RID: 28251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimGraphByTag_Internal(IntPtr @this, FName InTag, IntPtr InClass);

		// Token: 0x06006E5C RID: 28252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06006E5D RID: 28253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSyncGroupBetweenMarkers_Internal(IntPtr @this, FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder);

		// Token: 0x06006E5E RID: 28254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingSlotAnimation_Internal(IntPtr @this, IntPtr Asset, FName SlotNodeName);

		// Token: 0x06006E5F RID: 28255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsKuroForceFlying_Internal(IntPtr @this);

		// Token: 0x06006E60 RID: 28256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyMontagePlaying_Internal(IntPtr @this);

		// Token: 0x06006E61 RID: 28257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMarkerBeenHitThisFrame_Internal(IntPtr @this, FName SyncGroup, FName MarkerName);

		// Token: 0x06006E62 RID: 28258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKuroRootMotionAnim_Internal(IntPtr @this);

		// Token: 0x06006E63 RID: 28259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTimeToClosestMarker_Internal(IntPtr @this, FName SyncGroup, FName MarkerName, ref float OutMarkerTime);

		// Token: 0x06006E64 RID: 28260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSyncGroupPosition_Internal(IntPtr @this, FName InSyncGroupName);

		// Token: 0x06006E65 RID: 28261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStateOrdersSendPending_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x06006E66 RID: 28262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeRemainingFraction_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E67 RID: 28263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeRemaining_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E68 RID: 28264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTimeFraction_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E69 RID: 28265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimTime_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E6A RID: 28266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRelevantAnimLength_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E6B RID: 28267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetReceiveNotifiesFromLinkedInstances_Internal(IntPtr @this);

		// Token: 0x06006E6C RID: 28268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPropagateNotifiesToLinkedInstances_Internal(IntPtr @this);

		// Token: 0x06006E6D RID: 28269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningComponent_Internal(IntPtr @this);

		// Token: 0x06006E6E RID: 28270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningActor_Internal(IntPtr @this);

		// Token: 0x06006E6F RID: 28271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOriginStates_Internal(IntPtr @this, IntPtr Orders);

		// Token: 0x06006E70 RID: 28272
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMainAnimsDebugText_Internal(IntPtr @this);

		// Token: 0x06006E71 RID: 28273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMainAnimsCurveValueWithDelta_Internal(IntPtr @this, FName CurveName, float DeltaTime, bool bRawDeltaTime, bool bCycleTimeIfLoop);

		// Token: 0x06006E72 RID: 28274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMainAnims_Internal(IntPtr @this, IntPtr Anims, IntPtr Weights, IntPtr CurrentTimes, IntPtr PlayRates);

		// Token: 0x06006E73 RID: 28275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimLayerInstancesByGroup_Internal(IntPtr @this, FName InGroup, IntPtr OutLinkedInstances);

		// Token: 0x06006E74 RID: 28276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroupAndClass_Internal(IntPtr @this, FName InGroup, IntPtr InClass);

		// Token: 0x06006E75 RID: 28277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroup_Internal(IntPtr @this, FName InGroup);

		// Token: 0x06006E76 RID: 28278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06006E77 RID: 28279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimGraphInstancesByTag_Internal(IntPtr @this, FName InTag, IntPtr OutLinkedInstances);

		// Token: 0x06006E78 RID: 28280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimGraphInstanceByTag_Internal(IntPtr @this, FName InTag);

		// Token: 0x06006E79 RID: 28281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetKuroCachedBoneTransform_Internal(IntPtr @this, FName Name);

		// Token: 0x06006E7A RID: 28282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionTimeElapsedFraction_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x06006E7B RID: 28283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionTimeElapsed_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x06006E7C RID: 28284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceTransitionCrossfadeDuration_Internal(IntPtr @this, int MachineIndex, int TransitionIndex);

		// Token: 0x06006E7D RID: 28285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceStateWeight_Internal(IntPtr @this, int MachineIndex, int StateIndex);

		// Token: 0x06006E7E RID: 28286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceMachineWeight_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x06006E7F RID: 28287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceCurrentStateElapsedTime_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x06006E80 RID: 28288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFromEndFraction_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x06006E81 RID: 28289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFromEnd_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x06006E82 RID: 28290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTimeFraction_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x06006E83 RID: 28291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerTime_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x06006E84 RID: 28292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstanceAssetPlayerLength_Internal(IntPtr @this, int AssetPlayerIndex);

		// Token: 0x06006E85 RID: 28293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurveValue_Internal(IntPtr @this, FName CurveName);

		// Token: 0x06006E86 RID: 28294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentStateName_Internal(IntPtr @this, int MachineIndex);

		// Token: 0x06006E87 RID: 28295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentActiveMontage_Internal(IntPtr @this);

		// Token: 0x06006E88 RID: 28296
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAnimsDebugText_Internal(IntPtr @this);

		// Token: 0x06006E89 RID: 28297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllCurveNames_Internal(IntPtr @this, IntPtr OutNames);

		// Token: 0x06006E8A RID: 28298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActiveCurveNames_Internal(IntPtr @this, EAnimCurveType CurveType, IntPtr OutNames);

		// Token: 0x06006E8B RID: 28299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceSetCurrentMontageBlendTime_Internal(IntPtr @this, float BlendTime, IntPtr Montage);

		// Token: 0x06006E8C RID: 28300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ConsumeExtractedRootMotion_Internal(IntPtr @this, float Alpha);

		// Token: 0x06006E8D RID: 28301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearStateOrdersSendPending_Internal(IntPtr @this);

		// Token: 0x06006E8E RID: 28302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearStateOrdersReceivePending_Internal(IntPtr @this);

		// Token: 0x06006E8F RID: 28303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMorphTargets_Internal(IntPtr @this);

		// Token: 0x06006E90 RID: 28304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMontage_Internal(IntPtr @this);

		// Token: 0x06006E91 RID: 28305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateDirection_Internal(IntPtr @this, in FVector Velocity, in FRotator BaseRotation);

		// Token: 0x06006E92 RID: 28306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintUpdateAnimation_Internal(IntPtr @this, float DeltaTimeX);

		// Token: 0x06006E93 RID: 28307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintPostEvaluateAnimation_Internal(IntPtr @this);

		// Token: 0x06006E94 RID: 28308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintLinkedAnimationLayersInitialized_Internal(IntPtr @this);

		// Token: 0x06006E95 RID: 28309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintInitializeAnimation_Internal(IntPtr @this);

		// Token: 0x06006E96 RID: 28310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintBeginPlay_Internal(IntPtr @this);

		// Token: 0x06006E97 RID: 28311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceUpdateSlotNameWhenMontageBlend_Internal(IntPtr @this, FName SlotName);

		// Token: 0x06006E98 RID: 28312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDeltaForDelayAnim_Internal(IntPtr @this, float Delta);

		// Token: 0x06006E99 RID: 28313 RVA: 0x0009E9EE File Offset: 0x0009CBEE
		static UAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimInstance");
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x0009E9FC File Offset: 0x0009CBFC
		protected UAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034EE RID: 13550
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimInstance";

		// Token: 0x040034EF RID: 13551
		private static IntPtr _ClassPtr;

		// Token: 0x040034F0 RID: 13552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034F1 RID: 13553
		internal static int __PropertyOffset_CurrentSkeleton;

		// Token: 0x040034F2 RID: 13554
		internal static int __PropertyOffset_RootMotionMode;

		// Token: 0x040034F3 RID: 13555
		internal static int __PropertyOffset_bUseMultiThreadedAnimationUpdate;

		// Token: 0x040034F4 RID: 13556
		internal static byte __PropertyMask_bUseMultiThreadedAnimationUpdate;

		// Token: 0x040034F5 RID: 13557
		internal static int __PropertyOffset_bResultWithUnSafeThreadFunction;

		// Token: 0x040034F6 RID: 13558
		internal static int __PropertyOffset_AnimOrigin;

		// Token: 0x040034F7 RID: 13559
		internal static int __PropertyOffset_bUsingCopyPoseFromMesh;

		// Token: 0x040034F8 RID: 13560
		internal static byte __PropertyMask_bUsingCopyPoseFromMesh;

		// Token: 0x040034F9 RID: 13561
		internal static int __PropertyOffset_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x040034FA RID: 13562
		internal static byte __PropertyMask_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x040034FB RID: 13563
		internal static int __PropertyOffset_bPropagateNotifiesToLinkedInstances;

		// Token: 0x040034FC RID: 13564
		internal static byte __PropertyMask_bPropagateNotifiesToLinkedInstances;

		// Token: 0x040034FD RID: 13565
		internal static int __PropertyOffset_RibbonAnims;

		// Token: 0x040034FE RID: 13566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UAnimSequence> _RibbonAnims;

		// Token: 0x040034FF RID: 13567
		internal static int __PropertyOffset_SoftRibbonAnims;

		// Token: 0x04003500 RID: 13568
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FName, TSoftObjectPtr<UAnimSequence>> _SoftRibbonAnims;

		// Token: 0x04003501 RID: 13569
		internal static int __PropertyOffset_bQueueMontageEvents;

		// Token: 0x04003502 RID: 13570
		internal static byte __PropertyMask_bQueueMontageEvents;

		// Token: 0x04003503 RID: 13571
		internal static int __PropertyOffset_bEnableAnimCurvesFilter;

		// Token: 0x04003504 RID: 13572
		internal static int __PropertyOffset_AnimCurvesToFilter;

		// Token: 0x04003505 RID: 13573
		private TArray<FName> _AnimCurvesToFilter;

		// Token: 0x04003506 RID: 13574
		internal static int __PropertyOffset_bShouldRestoreAnimCurvesToFilter;

		// Token: 0x04003507 RID: 13575
		internal static int __PropertyOffset_bEnableAnimCurvesFilterBackup;

		// Token: 0x04003508 RID: 13576
		internal static int __PropertyOffset_AnimCurvesToFilterBackup;

		// Token: 0x04003509 RID: 13577
		private TArray<FName> _AnimCurvesToFilterBackup;

		// Token: 0x0400350A RID: 13578
		internal static int __PropertyOffset_DebugDestructText;

		// Token: 0x0400350B RID: 13579
		internal static int __PropertyOffset_SoftAssetsLoaded;

		// Token: 0x0400350C RID: 13580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UAnimationAsset> _SoftAssetsLoaded;

		// Token: 0x0400350D RID: 13581
		internal static int __PropertyOffset_OnMontageBlendingOut;

		// Token: 0x0400350E RID: 13582
		private FOnMontageBlendingOutStartedMCDelegate _OnMontageBlendingOut;

		// Token: 0x0400350F RID: 13583
		internal static int __PropertyOffset_OnMontageStarted;

		// Token: 0x04003510 RID: 13584
		private FOnMontageStartedMCDelegate _OnMontageStarted;

		// Token: 0x04003511 RID: 13585
		internal static int __PropertyOffset_OnMontageEnded;

		// Token: 0x04003512 RID: 13586
		private FOnMontageEndedMCDelegate _OnMontageEnded;

		// Token: 0x04003513 RID: 13587
		internal static int __PropertyOffset_OnAllMontageInstancesEnded;

		// Token: 0x04003514 RID: 13588
		private FOnAllMontageInstancesEndedMCDelegate _OnAllMontageInstancesEnded;

		// Token: 0x04003515 RID: 13589
		internal static int __PropertyOffset_NotifyQueue;

		// Token: 0x04003516 RID: 13590
		private FAnimNotifyQueue _NotifyQueue;

		// Token: 0x04003517 RID: 13591
		internal static int __PropertyOffset_ActiveAnimNotifyState;

		// Token: 0x04003518 RID: 13592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _ActiveAnimNotifyState;

		// Token: 0x04003519 RID: 13593
		internal static int __PropertyOffset_bIsNetMode;

		// Token: 0x02002C83 RID: 11395
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040165BC RID: 91580
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
