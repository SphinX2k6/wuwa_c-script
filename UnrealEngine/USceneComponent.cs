using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000279 RID: 633
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class USceneComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060040FD RID: 16637 RVA: 0x0005D3F2 File Offset: 0x0005B5F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneComponent._ClassPtr;
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0005D400 File Offset: 0x0005B600
		public USceneComponent() : this(BuiltinUtils.AllocNativeUObject(USceneComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0005D428 File Offset: 0x0005B628
		[NullableContext(1)]
		public USceneComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x0005D45B File Offset: 0x0005B65B
		// (set) Token: 0x06004101 RID: 16641 RVA: 0x0005D46F File Offset: 0x0005B66F
		public unsafe USceneComponent AttachParent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USceneComponent.__PropertyOffset_AttachParent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneComponent.__PropertyOffset_AttachParent, value);
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x0005D484 File Offset: 0x0005B684
		// (set) Token: 0x06004103 RID: 16643 RVA: 0x0005D498 File Offset: 0x0005B698
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_AttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_AttachSocketName) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
		// (set) Token: 0x06004105 RID: 16645 RVA: 0x0005D4E9 File Offset: 0x0005B6E9
		[Nullable(1)]
		public TArray<USceneComponent> AttachChildren
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USceneComponent> result;
				if ((result = this._AttachChildren) == null)
				{
					result = (this._AttachChildren = new TArray<USceneComponent>(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_AttachChildren, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AttachChildren.CopyAssign(value);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x0005D4F8 File Offset: 0x0005B6F8
		// (set) Token: 0x06004107 RID: 16647 RVA: 0x0005D531 File Offset: 0x0005B731
		[Nullable(1)]
		public TArray<USceneComponent> ClientAttachedChildren
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USceneComponent> result;
				if ((result = this._ClientAttachedChildren) == null)
				{
					result = (this._ClientAttachedChildren = new TArray<USceneComponent>(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_ClientAttachedChildren, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClientAttachedChildren.CopyAssign(value);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x0005D53F File Offset: 0x0005B73F
		// (set) Token: 0x06004109 RID: 16649 RVA: 0x0005D553 File Offset: 0x0005B753
		public unsafe FBoxSphereBounds Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x0005D568 File Offset: 0x0005B768
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x0005D57C File Offset: 0x0005B77C
		public unsafe FVector RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeLocation) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x0005D591 File Offset: 0x0005B791
		// (set) Token: 0x0600410D RID: 16653 RVA: 0x0005D5A5 File Offset: 0x0005B7A5
		public unsafe FRotator RelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeRotation) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x0005D5BA File Offset: 0x0005B7BA
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x0005D5CE File Offset: 0x0005B7CE
		public unsafe FVector RelativeScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_RelativeScale3D) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x0005D5E3 File Offset: 0x0005B7E3
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x0005D5F7 File Offset: 0x0005B7F7
		public unsafe FVector ComponentVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_ComponentVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_ComponentVelocity) = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x0005D60C File Offset: 0x0005B80C
		// (set) Token: 0x06004113 RID: 16659 RVA: 0x0005D61C File Offset: 0x0005B81C
		public unsafe bool bKuroMoveDebugLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bKuroMoveDebugLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bKuroMoveDebugLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x0005D62D File Offset: 0x0005B82D
		// (set) Token: 0x06004115 RID: 16661 RVA: 0x0005D646 File Offset: 0x0005B846
		public unsafe bool bComponentToWorldUpdated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bComponentToWorldUpdated) & USceneComponent.__PropertyMask_bComponentToWorldUpdated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bComponentToWorldUpdated) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bComponentToWorldUpdated) & ~USceneComponent.__PropertyMask_bComponentToWorldUpdated) | (value ? USceneComponent.__PropertyMask_bComponentToWorldUpdated : 0));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x0005D676 File Offset: 0x0005B876
		// (set) Token: 0x06004117 RID: 16663 RVA: 0x0005D68F File Offset: 0x0005B88F
		public unsafe bool bAbsoluteLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteLocation) & USceneComponent.__PropertyMask_bAbsoluteLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteLocation) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteLocation) & ~USceneComponent.__PropertyMask_bAbsoluteLocation) | (value ? USceneComponent.__PropertyMask_bAbsoluteLocation : 0));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0005D6BF File Offset: 0x0005B8BF
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		public unsafe bool bAbsoluteRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteRotation) & USceneComponent.__PropertyMask_bAbsoluteRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteRotation) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteRotation) & ~USceneComponent.__PropertyMask_bAbsoluteRotation) | (value ? USceneComponent.__PropertyMask_bAbsoluteRotation : 0));
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x0005D708 File Offset: 0x0005B908
		// (set) Token: 0x0600411B RID: 16667 RVA: 0x0005D721 File Offset: 0x0005B921
		public unsafe bool bAbsoluteScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteScale) & USceneComponent.__PropertyMask_bAbsoluteScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteScale) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bAbsoluteScale) & ~USceneComponent.__PropertyMask_bAbsoluteScale) | (value ? USceneComponent.__PropertyMask_bAbsoluteScale : 0));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x0005D751 File Offset: 0x0005B951
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x0005D76A File Offset: 0x0005B96A
		public unsafe bool bVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bVisible) & USceneComponent.__PropertyMask_bVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bVisible) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bVisible) & ~USceneComponent.__PropertyMask_bVisible) | (value ? USceneComponent.__PropertyMask_bVisible : 0));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x0005D79A File Offset: 0x0005B99A
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x0005D7B3 File Offset: 0x0005B9B3
		public unsafe bool bShouldBeAttached
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldBeAttached) & USceneComponent.__PropertyMask_bShouldBeAttached) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldBeAttached) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldBeAttached) & ~USceneComponent.__PropertyMask_bShouldBeAttached) | (value ? USceneComponent.__PropertyMask_bShouldBeAttached : 0));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x0005D7E3 File Offset: 0x0005B9E3
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x0005D7FC File Offset: 0x0005B9FC
		public unsafe bool bShouldSnapLocationWhenAttached
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapLocationWhenAttached) & USceneComponent.__PropertyMask_bShouldSnapLocationWhenAttached) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapLocationWhenAttached) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapLocationWhenAttached) & ~USceneComponent.__PropertyMask_bShouldSnapLocationWhenAttached) | (value ? USceneComponent.__PropertyMask_bShouldSnapLocationWhenAttached : 0));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x0005D82C File Offset: 0x0005BA2C
		// (set) Token: 0x06004123 RID: 16675 RVA: 0x0005D845 File Offset: 0x0005BA45
		public unsafe bool bShouldSnapRotationWhenAttached
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapRotationWhenAttached) & USceneComponent.__PropertyMask_bShouldSnapRotationWhenAttached) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapRotationWhenAttached) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldSnapRotationWhenAttached) & ~USceneComponent.__PropertyMask_bShouldSnapRotationWhenAttached) | (value ? USceneComponent.__PropertyMask_bShouldSnapRotationWhenAttached : 0));
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x0005D875 File Offset: 0x0005BA75
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x0005D88E File Offset: 0x0005BA8E
		public unsafe bool bShouldUpdatePhysicsVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldUpdatePhysicsVolume) & USceneComponent.__PropertyMask_bShouldUpdatePhysicsVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldUpdatePhysicsVolume) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bShouldUpdatePhysicsVolume) & ~USceneComponent.__PropertyMask_bShouldUpdatePhysicsVolume) | (value ? USceneComponent.__PropertyMask_bShouldUpdatePhysicsVolume : 0));
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x0005D8BE File Offset: 0x0005BABE
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x0005D8D7 File Offset: 0x0005BAD7
		public unsafe bool bHiddenInGame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bHiddenInGame) & USceneComponent.__PropertyMask_bHiddenInGame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bHiddenInGame) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bHiddenInGame) & ~USceneComponent.__PropertyMask_bHiddenInGame) | (value ? USceneComponent.__PropertyMask_bHiddenInGame : 0));
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x0005D907 File Offset: 0x0005BB07
		// (set) Token: 0x06004129 RID: 16681 RVA: 0x0005D920 File Offset: 0x0005BB20
		public unsafe bool bBoundsChangeTriggersStreamingDataRebuild
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bBoundsChangeTriggersStreamingDataRebuild) & USceneComponent.__PropertyMask_bBoundsChangeTriggersStreamingDataRebuild) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bBoundsChangeTriggersStreamingDataRebuild) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bBoundsChangeTriggersStreamingDataRebuild) & ~USceneComponent.__PropertyMask_bBoundsChangeTriggersStreamingDataRebuild) | (value ? USceneComponent.__PropertyMask_bBoundsChangeTriggersStreamingDataRebuild : 0));
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x0005D950 File Offset: 0x0005BB50
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x0005D969 File Offset: 0x0005BB69
		public unsafe bool bUseAttachParentBound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bUseAttachParentBound) & USceneComponent.__PropertyMask_bUseAttachParentBound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bUseAttachParentBound) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bUseAttachParentBound) & ~USceneComponent.__PropertyMask_bUseAttachParentBound) | (value ? USceneComponent.__PropertyMask_bUseAttachParentBound : 0));
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0005D999 File Offset: 0x0005BB99
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x0005D9B2 File Offset: 0x0005BBB2
		public unsafe bool bKuroLocationDebugLog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bKuroLocationDebugLog) & USceneComponent.__PropertyMask_bKuroLocationDebugLog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bKuroLocationDebugLog) = ((*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_bKuroLocationDebugLog) & ~USceneComponent.__PropertyMask_bKuroLocationDebugLog) | (value ? USceneComponent.__PropertyMask_bKuroLocationDebugLog : 0));
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x0005D9E2 File Offset: 0x0005BBE2
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x0005D9F6 File Offset: 0x0005BBF6
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentMobility> Mobility
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_Mobility);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_Mobility) = value;
			}
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x0005DA0B File Offset: 0x0005BC0B
		public void ToggleVisibility(bool bPropagateToChildren = false)
		{
			USceneComponent.__ToggleVisibility_Internal(base.NativePtr, bPropagateToChildren);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x0005DA19 File Offset: 0x0005BC19
		public bool SnapTo(USceneComponent InParent, FName InSocketName = default(FName))
		{
			return USceneComponent.__SnapTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x0005DA37 File Offset: 0x0005BC37
		public void SetWorldScale3D(FVector NewScale)
		{
			USceneComponent.__SetWorldScale3D_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x0005DA45 File Offset: 0x0005BC45
		public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
		{
			USceneComponent.__SetVisibility_Internal(base.NativePtr, bNewVisibility, bPropagateToChildren);
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x0005DA54 File Offset: 0x0005BC54
		public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)
		{
			USceneComponent.__SetShouldUpdatePhysicsVolume_Internal(base.NativePtr, bInShouldUpdatePhysicsVolume);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x0005DA62 File Offset: 0x0005BC62
		public void SetRelativeScale3D(FVector NewScale3D)
		{
			USceneComponent.__SetRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x0005DA70 File Offset: 0x0005BC70
		public void SetMobility(EComponentMobility NewMobility)
		{
			USceneComponent.__SetMobility_Internal(base.NativePtr, NewMobility);
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x0005DA83 File Offset: 0x0005BC83
		public void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren = false)
		{
			USceneComponent.__SetHiddenInGame_Internal(base.NativePtr, NewHidden, bPropagateToChildren);
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0005DA92 File Offset: 0x0005BC92
		public void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
		{
			USceneComponent.__SetAbsolute_Internal(base.NativePtr, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x0005DAA2 File Offset: 0x0005BCA2
		public void ResetRelativeTransform()
		{
			USceneComponent.__ResetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x0005DAAF File Offset: 0x0005BCAF
		public void OnRep_Visibility(bool OldValue)
		{
			USceneComponent.__OnRep_Visibility_Internal(base.NativePtr, OldValue);
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0005DABD File Offset: 0x0005BCBD
		public void OnRep_Transform()
		{
			USceneComponent.__OnRep_Transform_Internal(base.NativePtr);
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x0005DACA File Offset: 0x0005BCCA
		public void OnRep_AttachSocketName()
		{
			USceneComponent.__OnRep_AttachSocketName_Internal(base.NativePtr);
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x0005DAD7 File Offset: 0x0005BCD7
		public void OnRep_AttachParent()
		{
			USceneComponent.__OnRep_AttachParent_Internal(base.NativePtr);
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
		public void OnRep_AttachChildren()
		{
			USceneComponent.__OnRep_AttachChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x0005DAF1 File Offset: 0x0005BCF1
		public void KuroRefreshCacheLocalTransform()
		{
			USceneComponent.__KuroRefreshCacheLocalTransform_Internal(base.NativePtr);
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x0005DB00 File Offset: 0x0005BD00
		public unsafe void K2_SetWorldTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__K2_SetWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x0005DB48 File Offset: 0x0005BD48
		public void K2_SetWorldRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldRotation_Internal(base.NativePtr, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x0005DB69 File Offset: 0x0005BD69
		public void K2_SetWorldLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x0005DB8C File Offset: 0x0005BD8C
		public void K2_SetWorldLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x0005DBB0 File Offset: 0x0005BDB0
		public unsafe void K2_SetRelativeTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__K2_SetRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
		public void K2_SetRelativeRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeRotation_Internal(base.NativePtr, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x0005DC19 File Offset: 0x0005BE19
		public void K2_SetRelativeLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x0005DC3C File Offset: 0x0005BE3C
		public void K2_SetRelativeLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x0005DC5D File Offset: 0x0005BE5D
		public FTransform K2_GetComponentToWorldWithUpdate()
		{
			return USceneComponent.__K2_GetComponentToWorldWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x0005DC6A File Offset: 0x0005BE6A
		public FTransform K2_GetComponentToWorld()
		{
			return USceneComponent.__K2_GetComponentToWorld_Internal(base.NativePtr);
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x0005DC77 File Offset: 0x0005BE77
		public FVector K2_GetComponentScale()
		{
			return USceneComponent.__K2_GetComponentScale_Internal(base.NativePtr);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x0005DC84 File Offset: 0x0005BE84
		public FRotator K2_GetComponentRotation()
		{
			return USceneComponent.__K2_GetComponentRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x0005DC91 File Offset: 0x0005BE91
		public FQuat K2_GetComponentQuaternion()
		{
			return USceneComponent.__K2_GetComponentQuaternion_Internal(base.NativePtr);
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x0005DC9E File Offset: 0x0005BE9E
		public FVector K2_GetComponentLocation()
		{
			return USceneComponent.__K2_GetComponentLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x0005DCAB File Offset: 0x0005BEAB
		public void K2_DetachFromComponent(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative, bool bCallModify = true)
		{
			USceneComponent.__K2_DetachFromComponent_Internal(base.NativePtr, LocationRule, RotationRule, ScaleRule, bCallModify);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x0005DCBD File Offset: 0x0005BEBD
		public bool K2_AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			return USceneComponent.__K2_AttachToComponent_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x0005DCE4 File Offset: 0x0005BEE4
		public bool K2_AttachTo(USceneComponent InParent, FName InSocketName = default(FName), EAttachLocation AttachType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			return USceneComponent.__K2_AttachTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName, AttachType, bWeldSimulatedBodies);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x0005DD0C File Offset: 0x0005BF0C
		public unsafe void K2_AddWorldTransformKeepScale(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddWorldTransformKeepScale_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x0005DD54 File Offset: 0x0005BF54
		public unsafe void K2_AddWorldTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x0005DD9C File Offset: 0x0005BF9C
		public void K2_AddWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddWorldRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x0005DDBD File Offset: 0x0005BFBD
		public void K2_AddWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x0005DDDE File Offset: 0x0005BFDE
		public void K2_AddRelativeRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddRelativeRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x0005DDFF File Offset: 0x0005BFFF
		public void K2_AddRelativeLocation(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddRelativeLocation_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x0005DE20 File Offset: 0x0005C020
		public unsafe void K2_AddLocalTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x0005DE68 File Offset: 0x0005C068
		public void K2_AddLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddLocalRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x0005DE89 File Offset: 0x0005C089
		public void K2_AddLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x0005DEAA File Offset: 0x0005C0AA
		public bool IsVisible()
		{
			return USceneComponent.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x0005DEB7 File Offset: 0x0005C0B7
		public bool IsSimulatingPhysics(FName BoneName = default(FName))
		{
			return USceneComponent.__IsSimulatingPhysics_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x0005DEC5 File Offset: 0x0005C0C5
		public bool IsAttachedTo(USceneComponent TestComp)
		{
			return USceneComponent.__IsAttachedTo_Internal(base.NativePtr, (TestComp != null) ? TestComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x0005DEE2 File Offset: 0x0005C0E2
		public bool IsAnySimulatingPhysics()
		{
			return USceneComponent.__IsAnySimulatingPhysics_Internal(base.NativePtr);
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x0005DEEF File Offset: 0x0005C0EF
		public FVector GetUpVector()
		{
			return USceneComponent.__GetUpVector_Internal(base.NativePtr);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x0005DEFC File Offset: 0x0005C0FC
		public FTransform GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			return USceneComponent.__GetSocketTransform_Internal(base.NativePtr, InSocketName, TransformSpace);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0005DF10 File Offset: 0x0005C110
		public FRotator GetSocketRotation(FName InSocketName)
		{
			return USceneComponent.__GetSocketRotation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x0005DF1E File Offset: 0x0005C11E
		public FQuat GetSocketQuaternion(FName InSocketName)
		{
			return USceneComponent.__GetSocketQuaternion_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x0005DF2C File Offset: 0x0005C12C
		public FVector GetSocketLocation(FName InSocketName)
		{
			return USceneComponent.__GetSocketLocation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x0005DF3A File Offset: 0x0005C13A
		public bool GetShouldUpdatePhysicsVolume()
		{
			return USceneComponent.__GetShouldUpdatePhysicsVolume_Internal(base.NativePtr);
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x0005DF47 File Offset: 0x0005C147
		public FVector GetRightVector()
		{
			return USceneComponent.__GetRightVector_Internal(base.NativePtr);
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0005DF54 File Offset: 0x0005C154
		public FTransform GetRelativeTransform()
		{
			return USceneComponent.__GetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x0005DF61 File Offset: 0x0005C161
		public void GetParentComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USceneComponent> Parents)
		{
			USceneComponent.__GetParentComponents_Internal(base.NativePtr, (Parents ?? new TArray<USceneComponent>()).NativePtr);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0005DF7E File Offset: 0x0005C17E
		public int GetNumChildrenComponents()
		{
			return USceneComponent.__GetNumChildrenComponents_Internal(base.NativePtr);
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0005DF8B File Offset: 0x0005C18B
		public FVector GetForwardVector()
		{
			return USceneComponent.__GetForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x0005DF98 File Offset: 0x0005C198
		public FVector GetComponentVelocity()
		{
			return USceneComponent.__GetComponentVelocity_Internal(base.NativePtr);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x0005DFA5 File Offset: 0x0005C1A5
		public void GetChildrenComponents(bool bIncludeAllDescendants, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USceneComponent> Children)
		{
			USceneComponent.__GetChildrenComponents_Internal(base.NativePtr, bIncludeAllDescendants, (Children ?? new TArray<USceneComponent>()).NativePtr);
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x0005DFC3 File Offset: 0x0005C1C3
		public USceneComponent GetChildComponent(int ChildIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(USceneComponent.__GetChildComponent_Internal(base.NativePtr, ChildIndex));
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x0005DFD6 File Offset: 0x0005C1D6
		public FName GetAttachSocketName()
		{
			return USceneComponent.__GetAttachSocketName_Internal(base.NativePtr);
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x0005DFE3 File Offset: 0x0005C1E3
		public USceneComponent GetAttachParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(USceneComponent.__GetAttachParent_Internal(base.NativePtr));
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x0005DFF5 File Offset: 0x0005C1F5
		[NullableContext(1)]
		public TArray<FName> GetAllSocketNames()
		{
			return new TArray<FName>(USceneComponent.__GetAllSocketNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x0005E008 File Offset: 0x0005C208
		public bool DoesSocketExist(FName InSocketName)
		{
			return USceneComponent.__DoesSocketExist_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x0005E016 File Offset: 0x0005C216
		public void DetachFromParent(bool bMaintainWorldPosition = false, bool bCallModify = true)
		{
			USceneComponent.__DetachFromParent_Internal(base.NativePtr, bMaintainWorldPosition, bCallModify);
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x0005E025 File Offset: 0x0005C225
		public void D_SetWorldScale3D(FVectorDouble NewScale)
		{
			USceneComponent.__D_SetWorldScale3D_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x0005E033 File Offset: 0x0005C233
		public void D_SetRelativeScale3D(FVectorDouble NewScale3D)
		{
			USceneComponent.__D_SetRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x0005E044 File Offset: 0x0005C244
		public unsafe void D_K2_SetWorldTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__D_K2_SetWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0005E08C File Offset: 0x0005C28C
		public void D_K2_SetWorldLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetWorldLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x0005E0AF File Offset: 0x0005C2AF
		public void D_K2_SetWorldLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetWorldLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x0005E0D0 File Offset: 0x0005C2D0
		public unsafe void D_K2_SetRelativeTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__D_K2_SetRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0005E118 File Offset: 0x0005C318
		public void D_K2_SetRelativeLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetRelativeLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x0005E13B File Offset: 0x0005C33B
		public void D_K2_SetRelativeLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetRelativeLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x0005E15C File Offset: 0x0005C35C
		public FTransformDouble D_K2_GetComponentToWorldWithUpdate()
		{
			return USceneComponent.__D_K2_GetComponentToWorldWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x0005E169 File Offset: 0x0005C369
		public FTransformDouble D_K2_GetComponentToWorld()
		{
			return USceneComponent.__D_K2_GetComponentToWorld_Internal(base.NativePtr);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0005E176 File Offset: 0x0005C376
		public FVectorDouble D_K2_GetComponentScale()
		{
			return USceneComponent.__D_K2_GetComponentScale_Internal(base.NativePtr);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0005E183 File Offset: 0x0005C383
		public FVectorDouble D_K2_GetComponentLocation()
		{
			return USceneComponent.__D_K2_GetComponentLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x0005E190 File Offset: 0x0005C390
		public FVectorDouble D_GetUpVector()
		{
			return USceneComponent.__D_GetUpVector_Internal(base.NativePtr);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x0005E19D File Offset: 0x0005C39D
		public FTransformDouble D_GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			return USceneComponent.__D_GetSocketTransform_Internal(base.NativePtr, InSocketName, TransformSpace);
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x0005E1B1 File Offset: 0x0005C3B1
		public FVectorDouble D_GetSocketLocation(FName InSocketName)
		{
			return USceneComponent.__D_GetSocketLocation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x0005E1BF File Offset: 0x0005C3BF
		public FVectorDouble D_GetRightVector()
		{
			return USceneComponent.__D_GetRightVector_Internal(base.NativePtr);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0005E1CC File Offset: 0x0005C3CC
		public FTransformDouble D_GetRelativeTransform()
		{
			return USceneComponent.__D_GetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x0005E1D9 File Offset: 0x0005C3D9
		public FVectorDouble D_GetForwardVector()
		{
			return USceneComponent.__D_GetForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x0005E1E6 File Offset: 0x0005C3E6
		public FVectorDouble D_GetComponentVelocity()
		{
			return USceneComponent.__D_GetComponentVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0005E1F3 File Offset: 0x0005C3F3
		public FBoxSphereBounds D_GetComponentBounds()
		{
			return USceneComponent.__D_GetComponentBounds_Internal(base.NativePtr);
		}

		// Token: 0x06004185 RID: 16773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleVisibility_Internal(IntPtr @this, bool bPropagateToChildren);

		// Token: 0x06004186 RID: 16774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SnapTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName);

		// Token: 0x06004187 RID: 16775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldScale3D_Internal(IntPtr @this, FVector NewScale);

		// Token: 0x06004188 RID: 16776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibility_Internal(IntPtr @this, bool bNewVisibility, bool bPropagateToChildren);

		// Token: 0x06004189 RID: 16777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldUpdatePhysicsVolume_Internal(IntPtr @this, bool bInShouldUpdatePhysicsVolume);

		// Token: 0x0600418A RID: 16778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRelativeScale3D_Internal(IntPtr @this, FVector NewScale3D);

		// Token: 0x0600418B RID: 16779
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobility_Internal(IntPtr @this, TEnumAsByte<EComponentMobility> NewMobility);

		// Token: 0x0600418C RID: 16780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHiddenInGame_Internal(IntPtr @this, bool NewHidden, bool bPropagateToChildren);

		// Token: 0x0600418D RID: 16781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAbsolute_Internal(IntPtr @this, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale);

		// Token: 0x0600418E RID: 16782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x0600418F RID: 16783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Visibility_Internal(IntPtr @this, bool OldValue);

		// Token: 0x06004190 RID: 16784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Transform_Internal(IntPtr @this);

		// Token: 0x06004191 RID: 16785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachSocketName_Internal(IntPtr @this);

		// Token: 0x06004192 RID: 16786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachParent_Internal(IntPtr @this);

		// Token: 0x06004193 RID: 16787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachChildren_Internal(IntPtr @this);

		// Token: 0x06004194 RID: 16788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroRefreshCacheLocalTransform_Internal(IntPtr @this);

		// Token: 0x06004195 RID: 16789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06004196 RID: 16790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06004197 RID: 16791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06004198 RID: 16792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06004199 RID: 16793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600419A RID: 16794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600419B RID: 16795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600419C RID: 16796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600419D RID: 16797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __K2_GetComponentToWorldWithUpdate_Internal(IntPtr @this);

		// Token: 0x0600419E RID: 16798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __K2_GetComponentToWorld_Internal(IntPtr @this);

		// Token: 0x0600419F RID: 16799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetComponentScale_Internal(IntPtr @this);

		// Token: 0x060041A0 RID: 16800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __K2_GetComponentRotation_Internal(IntPtr @this);

		// Token: 0x060041A1 RID: 16801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __K2_GetComponentQuaternion_Internal(IntPtr @this);

		// Token: 0x060041A2 RID: 16802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetComponentLocation_Internal(IntPtr @this);

		// Token: 0x060041A3 RID: 16803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DetachFromComponent_Internal(IntPtr @this, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify);

		// Token: 0x060041A4 RID: 16804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_AttachToComponent_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x060041A5 RID: 16805
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_AttachTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName, TEnumAsByte<EAttachLocation> AttachType, bool bWeldSimulatedBodies);

		// Token: 0x060041A6 RID: 16806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldTransformKeepScale_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041A7 RID: 16807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041A8 RID: 16808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041A9 RID: 16809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AA RID: 16810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddRelativeRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AB RID: 16811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddRelativeLocation_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AC RID: 16812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AD RID: 16813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AE RID: 16814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041AF RID: 16815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x060041B0 RID: 16816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulatingPhysics_Internal(IntPtr @this, FName BoneName);

		// Token: 0x060041B1 RID: 16817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAttachedTo_Internal(IntPtr @this, IntPtr TestComp);

		// Token: 0x060041B2 RID: 16818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnySimulatingPhysics_Internal(IntPtr @this);

		// Token: 0x060041B3 RID: 16819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVector_Internal(IntPtr @this);

		// Token: 0x060041B4 RID: 16820
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetSocketTransform_Internal(IntPtr @this, FName InSocketName, TEnumAsByte<ERelativeTransformSpace> TransformSpace);

		// Token: 0x060041B5 RID: 16821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetSocketRotation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060041B6 RID: 16822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetSocketQuaternion_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060041B7 RID: 16823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSocketLocation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060041B8 RID: 16824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetShouldUpdatePhysicsVolume_Internal(IntPtr @this);

		// Token: 0x060041B9 RID: 16825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVector_Internal(IntPtr @this);

		// Token: 0x060041BA RID: 16826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x060041BB RID: 16827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetParentComponents_Internal(IntPtr @this, IntPtr Parents);

		// Token: 0x060041BC RID: 16828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumChildrenComponents_Internal(IntPtr @this);

		// Token: 0x060041BD RID: 16829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetForwardVector_Internal(IntPtr @this);

		// Token: 0x060041BE RID: 16830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetComponentVelocity_Internal(IntPtr @this);

		// Token: 0x060041BF RID: 16831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetChildrenComponents_Internal(IntPtr @this, bool bIncludeAllDescendants, IntPtr Children);

		// Token: 0x060041C0 RID: 16832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetChildComponent_Internal(IntPtr @this, int ChildIndex);

		// Token: 0x060041C1 RID: 16833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAttachSocketName_Internal(IntPtr @this);

		// Token: 0x060041C2 RID: 16834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachParent_Internal(IntPtr @this);

		// Token: 0x060041C3 RID: 16835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllSocketNames_Internal(IntPtr @this);

		// Token: 0x060041C4 RID: 16836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesSocketExist_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060041C5 RID: 16837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachFromParent_Internal(IntPtr @this, bool bMaintainWorldPosition, bool bCallModify);

		// Token: 0x060041C6 RID: 16838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetWorldScale3D_Internal(IntPtr @this, FVectorDouble NewScale);

		// Token: 0x060041C7 RID: 16839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetRelativeScale3D_Internal(IntPtr @this, FVectorDouble NewScale3D);

		// Token: 0x060041C8 RID: 16840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041C9 RID: 16841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041CA RID: 16842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041CB RID: 16843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041CC RID: 16844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041CD RID: 16845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060041CE RID: 16846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_K2_GetComponentToWorldWithUpdate_Internal(IntPtr @this);

		// Token: 0x060041CF RID: 16847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_K2_GetComponentToWorld_Internal(IntPtr @this);

		// Token: 0x060041D0 RID: 16848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetComponentScale_Internal(IntPtr @this);

		// Token: 0x060041D1 RID: 16849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetComponentLocation_Internal(IntPtr @this);

		// Token: 0x060041D2 RID: 16850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVector_Internal(IntPtr @this);

		// Token: 0x060041D3 RID: 16851
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetSocketTransform_Internal(IntPtr @this, FName InSocketName, TEnumAsByte<ERelativeTransformSpace> TransformSpace);

		// Token: 0x060041D4 RID: 16852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetSocketLocation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060041D5 RID: 16853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVector_Internal(IntPtr @this);

		// Token: 0x060041D6 RID: 16854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x060041D7 RID: 16855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetForwardVector_Internal(IntPtr @this);

		// Token: 0x060041D8 RID: 16856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetComponentVelocity_Internal(IntPtr @this);

		// Token: 0x060041D9 RID: 16857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __D_GetComponentBounds_Internal(IntPtr @this);

		// Token: 0x060041DA RID: 16858 RVA: 0x0005E200 File Offset: 0x0005C400
		static USceneComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneComponent");
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x0005E20E File Offset: 0x0005C40E
		protected USceneComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001990 RID: 6544
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneComponent";

		// Token: 0x04001991 RID: 6545
		private static IntPtr _ClassPtr;

		// Token: 0x04001992 RID: 6546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001993 RID: 6547
		internal static int __PropertyOffset_AttachParent;

		// Token: 0x04001994 RID: 6548
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x04001995 RID: 6549
		internal static int __PropertyOffset_AttachChildren;

		// Token: 0x04001996 RID: 6550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _AttachChildren;

		// Token: 0x04001997 RID: 6551
		internal static int __PropertyOffset_ClientAttachedChildren;

		// Token: 0x04001998 RID: 6552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _ClientAttachedChildren;

		// Token: 0x04001999 RID: 6553
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0400199A RID: 6554
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x0400199B RID: 6555
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x0400199C RID: 6556
		internal static int __PropertyOffset_RelativeScale3D;

		// Token: 0x0400199D RID: 6557
		internal static int __PropertyOffset_ComponentVelocity;

		// Token: 0x0400199E RID: 6558
		internal static int __PropertyOffset_bKuroMoveDebugLog;

		// Token: 0x0400199F RID: 6559
		internal static int __PropertyOffset_bComponentToWorldUpdated;

		// Token: 0x040019A0 RID: 6560
		internal static byte __PropertyMask_bComponentToWorldUpdated;

		// Token: 0x040019A1 RID: 6561
		internal static int __PropertyOffset_bAbsoluteLocation;

		// Token: 0x040019A2 RID: 6562
		internal static byte __PropertyMask_bAbsoluteLocation;

		// Token: 0x040019A3 RID: 6563
		internal static int __PropertyOffset_bAbsoluteRotation;

		// Token: 0x040019A4 RID: 6564
		internal static byte __PropertyMask_bAbsoluteRotation;

		// Token: 0x040019A5 RID: 6565
		internal static int __PropertyOffset_bAbsoluteScale;

		// Token: 0x040019A6 RID: 6566
		internal static byte __PropertyMask_bAbsoluteScale;

		// Token: 0x040019A7 RID: 6567
		internal static int __PropertyOffset_bVisible;

		// Token: 0x040019A8 RID: 6568
		internal static byte __PropertyMask_bVisible;

		// Token: 0x040019A9 RID: 6569
		internal static int __PropertyOffset_bShouldBeAttached;

		// Token: 0x040019AA RID: 6570
		internal static byte __PropertyMask_bShouldBeAttached;

		// Token: 0x040019AB RID: 6571
		internal static int __PropertyOffset_bShouldSnapLocationWhenAttached;

		// Token: 0x040019AC RID: 6572
		internal static byte __PropertyMask_bShouldSnapLocationWhenAttached;

		// Token: 0x040019AD RID: 6573
		internal static int __PropertyOffset_bShouldSnapRotationWhenAttached;

		// Token: 0x040019AE RID: 6574
		internal static byte __PropertyMask_bShouldSnapRotationWhenAttached;

		// Token: 0x040019AF RID: 6575
		internal static int __PropertyOffset_bShouldUpdatePhysicsVolume;

		// Token: 0x040019B0 RID: 6576
		internal static byte __PropertyMask_bShouldUpdatePhysicsVolume;

		// Token: 0x040019B1 RID: 6577
		internal static int __PropertyOffset_bHiddenInGame;

		// Token: 0x040019B2 RID: 6578
		internal static byte __PropertyMask_bHiddenInGame;

		// Token: 0x040019B3 RID: 6579
		internal static int __PropertyOffset_bBoundsChangeTriggersStreamingDataRebuild;

		// Token: 0x040019B4 RID: 6580
		internal static byte __PropertyMask_bBoundsChangeTriggersStreamingDataRebuild;

		// Token: 0x040019B5 RID: 6581
		internal static int __PropertyOffset_bUseAttachParentBound;

		// Token: 0x040019B6 RID: 6582
		internal static byte __PropertyMask_bUseAttachParentBound;

		// Token: 0x040019B7 RID: 6583
		internal static int __PropertyOffset_bKuroLocationDebugLog;

		// Token: 0x040019B8 RID: 6584
		internal static byte __PropertyMask_bKuroLocationDebugLog;

		// Token: 0x040019B9 RID: 6585
		internal static int __PropertyOffset_Mobility;
	}
}
