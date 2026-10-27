using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D9 RID: 4313
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class USceneComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F681 RID: 63105 RVA: 0x0016D3C5 File Offset: 0x0016B5C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneComponent._ClassPtr;
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x0016D3D4 File Offset: 0x0016B5D4
		public USceneComponent() : this(BuiltinUtils.AllocNativeUObject(USceneComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x0016D3FC File Offset: 0x0016B5FC
		[NullableContext(1)]
		public USceneComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600F684 RID: 63108 RVA: 0x0016D42F File Offset: 0x0016B62F
		// (set) Token: 0x0600F685 RID: 63109 RVA: 0x0016D443 File Offset: 0x0016B643
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<APhysicsVolume> PhysicsVolume
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_PhysicsVolume);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_PhysicsVolume) = value;
			}
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600F686 RID: 63110 RVA: 0x0016D458 File Offset: 0x0016B658
		// (set) Token: 0x0600F687 RID: 63111 RVA: 0x0016D46C File Offset: 0x0016B66C
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

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600F688 RID: 63112 RVA: 0x0016D481 File Offset: 0x0016B681
		// (set) Token: 0x0600F689 RID: 63113 RVA: 0x0016D495 File Offset: 0x0016B695
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

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600F68A RID: 63114 RVA: 0x0016D4AC File Offset: 0x0016B6AC
		// (set) Token: 0x0600F68B RID: 63115 RVA: 0x0016D4E5 File Offset: 0x0016B6E5
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

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600F68C RID: 63116 RVA: 0x0016D4F4 File Offset: 0x0016B6F4
		// (set) Token: 0x0600F68D RID: 63117 RVA: 0x0016D52D File Offset: 0x0016B72D
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

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600F68E RID: 63118 RVA: 0x0016D53B File Offset: 0x0016B73B
		// (set) Token: 0x0600F68F RID: 63119 RVA: 0x0016D54F File Offset: 0x0016B74F
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

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600F690 RID: 63120 RVA: 0x0016D564 File Offset: 0x0016B764
		// (set) Token: 0x0600F691 RID: 63121 RVA: 0x0016D578 File Offset: 0x0016B778
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

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600F692 RID: 63122 RVA: 0x0016D58D File Offset: 0x0016B78D
		// (set) Token: 0x0600F693 RID: 63123 RVA: 0x0016D5A1 File Offset: 0x0016B7A1
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

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600F694 RID: 63124 RVA: 0x0016D5B6 File Offset: 0x0016B7B6
		// (set) Token: 0x0600F695 RID: 63125 RVA: 0x0016D5CA File Offset: 0x0016B7CA
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

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600F696 RID: 63126 RVA: 0x0016D5DF File Offset: 0x0016B7DF
		// (set) Token: 0x0600F697 RID: 63127 RVA: 0x0016D5F3 File Offset: 0x0016B7F3
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

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600F698 RID: 63128 RVA: 0x0016D608 File Offset: 0x0016B808
		// (set) Token: 0x0600F699 RID: 63129 RVA: 0x0016D618 File Offset: 0x0016B818
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

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600F69A RID: 63130 RVA: 0x0016D629 File Offset: 0x0016B829
		// (set) Token: 0x0600F69B RID: 63131 RVA: 0x0016D642 File Offset: 0x0016B842
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

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600F69C RID: 63132 RVA: 0x0016D672 File Offset: 0x0016B872
		// (set) Token: 0x0600F69D RID: 63133 RVA: 0x0016D68B File Offset: 0x0016B88B
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

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600F69E RID: 63134 RVA: 0x0016D6BB File Offset: 0x0016B8BB
		// (set) Token: 0x0600F69F RID: 63135 RVA: 0x0016D6D4 File Offset: 0x0016B8D4
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

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600F6A0 RID: 63136 RVA: 0x0016D704 File Offset: 0x0016B904
		// (set) Token: 0x0600F6A1 RID: 63137 RVA: 0x0016D71D File Offset: 0x0016B91D
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

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600F6A2 RID: 63138 RVA: 0x0016D74D File Offset: 0x0016B94D
		// (set) Token: 0x0600F6A3 RID: 63139 RVA: 0x0016D766 File Offset: 0x0016B966
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

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600F6A4 RID: 63140 RVA: 0x0016D796 File Offset: 0x0016B996
		// (set) Token: 0x0600F6A5 RID: 63141 RVA: 0x0016D7AF File Offset: 0x0016B9AF
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

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600F6A6 RID: 63142 RVA: 0x0016D7DF File Offset: 0x0016B9DF
		// (set) Token: 0x0600F6A7 RID: 63143 RVA: 0x0016D7F8 File Offset: 0x0016B9F8
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

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600F6A8 RID: 63144 RVA: 0x0016D828 File Offset: 0x0016BA28
		// (set) Token: 0x0600F6A9 RID: 63145 RVA: 0x0016D841 File Offset: 0x0016BA41
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

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600F6AA RID: 63146 RVA: 0x0016D871 File Offset: 0x0016BA71
		// (set) Token: 0x0600F6AB RID: 63147 RVA: 0x0016D88A File Offset: 0x0016BA8A
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

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600F6AC RID: 63148 RVA: 0x0016D8BA File Offset: 0x0016BABA
		// (set) Token: 0x0600F6AD RID: 63149 RVA: 0x0016D8D3 File Offset: 0x0016BAD3
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

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600F6AE RID: 63150 RVA: 0x0016D903 File Offset: 0x0016BB03
		// (set) Token: 0x0600F6AF RID: 63151 RVA: 0x0016D91C File Offset: 0x0016BB1C
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

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600F6B0 RID: 63152 RVA: 0x0016D94C File Offset: 0x0016BB4C
		// (set) Token: 0x0600F6B1 RID: 63153 RVA: 0x0016D965 File Offset: 0x0016BB65
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

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600F6B2 RID: 63154 RVA: 0x0016D995 File Offset: 0x0016BB95
		// (set) Token: 0x0600F6B3 RID: 63155 RVA: 0x0016D9AE File Offset: 0x0016BBAE
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

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600F6B4 RID: 63156 RVA: 0x0016D9DE File Offset: 0x0016BBDE
		// (set) Token: 0x0600F6B5 RID: 63157 RVA: 0x0016D9F2 File Offset: 0x0016BBF2
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

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600F6B6 RID: 63158 RVA: 0x0016DA07 File Offset: 0x0016BC07
		// (set) Token: 0x0600F6B7 RID: 63159 RVA: 0x0016DA1B File Offset: 0x0016BC1B
		[Nullable(0)]
		public unsafe TEnumAsByte<EDetailMode> DetailMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_DetailMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_DetailMode) = value;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600F6B8 RID: 63160 RVA: 0x0016DA30 File Offset: 0x0016BC30
		// (set) Token: 0x0600F6B9 RID: 63161 RVA: 0x0016DA69 File Offset: 0x0016BC69
		[Nullable(1)]
		public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPhysicsVolumeChanged result;
				if ((result = this._PhysicsVolumeChangedDelegate) == null)
				{
					result = (this._PhysicsVolumeChangedDelegate = new FPhysicsVolumeChanged(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_PhysicsVolumeChangedDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneComponent.__PropertyOffset_PhysicsVolumeChangedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x0016DA8A File Offset: 0x0016BC8A
		public void ToggleVisibility(bool bPropagateToChildren = false)
		{
			USceneComponent.__ToggleVisibility_Internal(base.NativePtr, bPropagateToChildren);
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x0016DA98 File Offset: 0x0016BC98
		public bool SnapTo(USceneComponent InParent, FName InSocketName = default(FName))
		{
			return USceneComponent.__SnapTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName);
		}

		// Token: 0x0600F6BC RID: 63164 RVA: 0x0016DAB6 File Offset: 0x0016BCB6
		public void SetWorldScale3D(FVector NewScale)
		{
			USceneComponent.__SetWorldScale3D_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x0600F6BD RID: 63165 RVA: 0x0016DAC4 File Offset: 0x0016BCC4
		public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
		{
			USceneComponent.__SetVisibility_Internal(base.NativePtr, bNewVisibility, bPropagateToChildren);
		}

		// Token: 0x0600F6BE RID: 63166 RVA: 0x0016DAD3 File Offset: 0x0016BCD3
		public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)
		{
			USceneComponent.__SetShouldUpdatePhysicsVolume_Internal(base.NativePtr, bInShouldUpdatePhysicsVolume);
		}

		// Token: 0x0600F6BF RID: 63167 RVA: 0x0016DAE1 File Offset: 0x0016BCE1
		public void SetRelativeScale3D(FVector NewScale3D)
		{
			USceneComponent.__SetRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x0016DAEF File Offset: 0x0016BCEF
		public void SetMobility(EComponentMobility NewMobility)
		{
			USceneComponent.__SetMobility_Internal(base.NativePtr, NewMobility);
		}

		// Token: 0x0600F6C1 RID: 63169 RVA: 0x0016DB02 File Offset: 0x0016BD02
		public void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren = false)
		{
			USceneComponent.__SetHiddenInGame_Internal(base.NativePtr, NewHidden, bPropagateToChildren);
		}

		// Token: 0x0600F6C2 RID: 63170 RVA: 0x0016DB11 File Offset: 0x0016BD11
		public void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
		{
			USceneComponent.__SetAbsolute_Internal(base.NativePtr, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);
		}

		// Token: 0x0600F6C3 RID: 63171 RVA: 0x0016DB21 File Offset: 0x0016BD21
		public void ResetRelativeTransform()
		{
			USceneComponent.__ResetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600F6C4 RID: 63172 RVA: 0x0016DB2E File Offset: 0x0016BD2E
		public void OnRep_Visibility(bool OldValue)
		{
			USceneComponent.__OnRep_Visibility_Internal(base.NativePtr, OldValue);
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x0016DB3C File Offset: 0x0016BD3C
		public void OnRep_Transform()
		{
			USceneComponent.__OnRep_Transform_Internal(base.NativePtr);
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x0016DB49 File Offset: 0x0016BD49
		public void OnRep_AttachSocketName()
		{
			USceneComponent.__OnRep_AttachSocketName_Internal(base.NativePtr);
		}

		// Token: 0x0600F6C7 RID: 63175 RVA: 0x0016DB56 File Offset: 0x0016BD56
		public void OnRep_AttachParent()
		{
			USceneComponent.__OnRep_AttachParent_Internal(base.NativePtr);
		}

		// Token: 0x0600F6C8 RID: 63176 RVA: 0x0016DB63 File Offset: 0x0016BD63
		public void OnRep_AttachChildren()
		{
			USceneComponent.__OnRep_AttachChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600F6C9 RID: 63177 RVA: 0x0016DB70 File Offset: 0x0016BD70
		public void KuroRefreshCacheLocalTransform()
		{
			USceneComponent.__KuroRefreshCacheLocalTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600F6CA RID: 63178 RVA: 0x0016DB80 File Offset: 0x0016BD80
		public unsafe void K2_SetWorldTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__K2_SetWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x0016DBC8 File Offset: 0x0016BDC8
		public void K2_SetWorldRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldRotation_Internal(base.NativePtr, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x0016DBE9 File Offset: 0x0016BDE9
		public void K2_SetWorldLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x0016DC0C File Offset: 0x0016BE0C
		public void K2_SetWorldLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetWorldLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x0016DC30 File Offset: 0x0016BE30
		public unsafe void K2_SetRelativeTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__K2_SetRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x0016DC78 File Offset: 0x0016BE78
		public void K2_SetRelativeRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeRotation_Internal(base.NativePtr, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x0016DC99 File Offset: 0x0016BE99
		public void K2_SetRelativeLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6D1 RID: 63185 RVA: 0x0016DCBC File Offset: 0x0016BEBC
		public void K2_SetRelativeLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_SetRelativeLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6D2 RID: 63186 RVA: 0x0016DCDD File Offset: 0x0016BEDD
		public FTransform K2_GetComponentToWorldWithUpdate()
		{
			return USceneComponent.__K2_GetComponentToWorldWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x0016DCEA File Offset: 0x0016BEEA
		public FTransform K2_GetComponentToWorld()
		{
			return USceneComponent.__K2_GetComponentToWorld_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D4 RID: 63188 RVA: 0x0016DCF7 File Offset: 0x0016BEF7
		public FVector K2_GetComponentScale()
		{
			return USceneComponent.__K2_GetComponentScale_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D5 RID: 63189 RVA: 0x0016DD04 File Offset: 0x0016BF04
		public FRotator K2_GetComponentRotation()
		{
			return USceneComponent.__K2_GetComponentRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D6 RID: 63190 RVA: 0x0016DD11 File Offset: 0x0016BF11
		public FQuat K2_GetComponentQuaternion()
		{
			return USceneComponent.__K2_GetComponentQuaternion_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x0016DD1E File Offset: 0x0016BF1E
		public FVector K2_GetComponentLocation()
		{
			return USceneComponent.__K2_GetComponentLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x0016DD2B File Offset: 0x0016BF2B
		public void K2_DetachFromComponent(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative, bool bCallModify = true)
		{
			USceneComponent.__K2_DetachFromComponent_Internal(base.NativePtr, LocationRule, RotationRule, ScaleRule, bCallModify);
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x0016DD3D File Offset: 0x0016BF3D
		public bool K2_AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			return USceneComponent.__K2_AttachToComponent_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x0016DD64 File Offset: 0x0016BF64
		public bool K2_AttachTo(USceneComponent InParent, FName InSocketName = default(FName), EAttachLocation AttachType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			return USceneComponent.__K2_AttachTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName, AttachType, bWeldSimulatedBodies);
		}

		// Token: 0x0600F6DB RID: 63195 RVA: 0x0016DD8C File Offset: 0x0016BF8C
		public unsafe void K2_AddWorldTransformKeepScale(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddWorldTransformKeepScale_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6DC RID: 63196 RVA: 0x0016DDD4 File Offset: 0x0016BFD4
		public unsafe void K2_AddWorldTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6DD RID: 63197 RVA: 0x0016DE1C File Offset: 0x0016C01C
		public void K2_AddWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddWorldRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6DE RID: 63198 RVA: 0x0016DE3D File Offset: 0x0016C03D
		public void K2_AddWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6DF RID: 63199 RVA: 0x0016DE5E File Offset: 0x0016C05E
		public void K2_AddRelativeRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddRelativeRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x0016DE7F File Offset: 0x0016C07F
		public void K2_AddRelativeLocation(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddRelativeLocation_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x0016DEA0 File Offset: 0x0016C0A0
		public unsafe void K2_AddLocalTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			USceneComponent.__K2_AddLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x0016DEE8 File Offset: 0x0016C0E8
		public void K2_AddLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddLocalRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x0016DF09 File Offset: 0x0016C109
		public void K2_AddLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__K2_AddLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x0016DF2A File Offset: 0x0016C12A
		public bool IsVisible()
		{
			return USceneComponent.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x0016DF37 File Offset: 0x0016C137
		public bool IsSimulatingPhysics(FName BoneName = default(FName))
		{
			return USceneComponent.__IsSimulatingPhysics_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x0016DF45 File Offset: 0x0016C145
		public bool IsAttachedTo(USceneComponent TestComp)
		{
			return USceneComponent.__IsAttachedTo_Internal(base.NativePtr, (TestComp != null) ? TestComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x0016DF62 File Offset: 0x0016C162
		public bool IsAnySimulatingPhysics()
		{
			return USceneComponent.__IsAnySimulatingPhysics_Internal(base.NativePtr);
		}

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x0016DF6F File Offset: 0x0016C16F
		public FVector GetUpVector()
		{
			return USceneComponent.__GetUpVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x0016DF7C File Offset: 0x0016C17C
		public FTransform GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			return USceneComponent.__GetSocketTransform_Internal(base.NativePtr, InSocketName, TransformSpace);
		}

		// Token: 0x0600F6EA RID: 63210 RVA: 0x0016DF90 File Offset: 0x0016C190
		public FRotator GetSocketRotation(FName InSocketName)
		{
			return USceneComponent.__GetSocketRotation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x0016DF9E File Offset: 0x0016C19E
		public FQuat GetSocketQuaternion(FName InSocketName)
		{
			return USceneComponent.__GetSocketQuaternion_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x0016DFAC File Offset: 0x0016C1AC
		public FVector GetSocketLocation(FName InSocketName)
		{
			return USceneComponent.__GetSocketLocation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x0016DFBA File Offset: 0x0016C1BA
		public bool GetShouldUpdatePhysicsVolume()
		{
			return USceneComponent.__GetShouldUpdatePhysicsVolume_Internal(base.NativePtr);
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x0016DFC7 File Offset: 0x0016C1C7
		public FVector GetRightVector()
		{
			return USceneComponent.__GetRightVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x0016DFD4 File Offset: 0x0016C1D4
		public FTransform GetRelativeTransform()
		{
			return USceneComponent.__GetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600F6F0 RID: 63216 RVA: 0x0016DFE1 File Offset: 0x0016C1E1
		public APhysicsVolume GetPhysicsVolume()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APhysicsVolume>(USceneComponent.__GetPhysicsVolume_Internal(base.NativePtr));
		}

		// Token: 0x0600F6F1 RID: 63217 RVA: 0x0016DFF3 File Offset: 0x0016C1F3
		public void GetParentComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USceneComponent> Parents)
		{
			USceneComponent.__GetParentComponents_Internal(base.NativePtr, (Parents ?? new TArray<USceneComponent>()).NativePtr);
		}

		// Token: 0x0600F6F2 RID: 63218 RVA: 0x0016E010 File Offset: 0x0016C210
		public int GetNumChildrenComponents()
		{
			return USceneComponent.__GetNumChildrenComponents_Internal(base.NativePtr);
		}

		// Token: 0x0600F6F3 RID: 63219 RVA: 0x0016E01D File Offset: 0x0016C21D
		public FVector GetForwardVector()
		{
			return USceneComponent.__GetForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F6F4 RID: 63220 RVA: 0x0016E02A File Offset: 0x0016C22A
		public FVector GetComponentVelocity()
		{
			return USceneComponent.__GetComponentVelocity_Internal(base.NativePtr);
		}

		// Token: 0x0600F6F5 RID: 63221 RVA: 0x0016E037 File Offset: 0x0016C237
		public void GetChildrenComponents(bool bIncludeAllDescendants, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USceneComponent> Children)
		{
			USceneComponent.__GetChildrenComponents_Internal(base.NativePtr, bIncludeAllDescendants, (Children ?? new TArray<USceneComponent>()).NativePtr);
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x0016E055 File Offset: 0x0016C255
		public USceneComponent GetChildComponent(int ChildIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(USceneComponent.__GetChildComponent_Internal(base.NativePtr, ChildIndex));
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x0016E068 File Offset: 0x0016C268
		public FName GetAttachSocketName()
		{
			return USceneComponent.__GetAttachSocketName_Internal(base.NativePtr);
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x0016E075 File Offset: 0x0016C275
		public USceneComponent GetAttachParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(USceneComponent.__GetAttachParent_Internal(base.NativePtr));
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x0016E087 File Offset: 0x0016C287
		[NullableContext(1)]
		public TArray<FName> GetAllSocketNames()
		{
			return new TArray<FName>(USceneComponent.__GetAllSocketNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x0016E09A File Offset: 0x0016C29A
		public bool DoesSocketExist(FName InSocketName)
		{
			return USceneComponent.__DoesSocketExist_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x0016E0A8 File Offset: 0x0016C2A8
		public void DetachFromParent(bool bMaintainWorldPosition = false, bool bCallModify = true)
		{
			USceneComponent.__DetachFromParent_Internal(base.NativePtr, bMaintainWorldPosition, bCallModify);
		}

		// Token: 0x0600F6FC RID: 63228 RVA: 0x0016E0B7 File Offset: 0x0016C2B7
		public void D_SetWorldScale3D(FVectorDouble NewScale)
		{
			USceneComponent.__D_SetWorldScale3D_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x0600F6FD RID: 63229 RVA: 0x0016E0C5 File Offset: 0x0016C2C5
		public void D_SetRelativeScale3D(FVectorDouble NewScale3D)
		{
			USceneComponent.__D_SetRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x0600F6FE RID: 63230 RVA: 0x0016E0D4 File Offset: 0x0016C2D4
		public unsafe void D_K2_SetWorldTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__D_K2_SetWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x0016E11C File Offset: 0x0016C31C
		public void D_K2_SetWorldLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetWorldLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F700 RID: 63232 RVA: 0x0016E13F File Offset: 0x0016C33F
		public void D_K2_SetWorldLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetWorldLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F701 RID: 63233 RVA: 0x0016E160 File Offset: 0x0016C360
		public unsafe void D_K2_SetRelativeTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			USceneComponent.__D_K2_SetRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F702 RID: 63234 RVA: 0x0016E1A8 File Offset: 0x0016C3A8
		public void D_K2_SetRelativeLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetRelativeLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F703 RID: 63235 RVA: 0x0016E1CB File Offset: 0x0016C3CB
		public void D_K2_SetRelativeLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			USceneComponent.__D_K2_SetRelativeLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600F704 RID: 63236 RVA: 0x0016E1EC File Offset: 0x0016C3EC
		public FTransformDouble D_K2_GetComponentToWorldWithUpdate()
		{
			return USceneComponent.__D_K2_GetComponentToWorldWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x0016E1F9 File Offset: 0x0016C3F9
		public FTransformDouble D_K2_GetComponentToWorld()
		{
			return USceneComponent.__D_K2_GetComponentToWorld_Internal(base.NativePtr);
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x0016E206 File Offset: 0x0016C406
		public FVectorDouble D_K2_GetComponentScale()
		{
			return USceneComponent.__D_K2_GetComponentScale_Internal(base.NativePtr);
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x0016E213 File Offset: 0x0016C413
		public FVectorDouble D_K2_GetComponentLocation()
		{
			return USceneComponent.__D_K2_GetComponentLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x0016E220 File Offset: 0x0016C420
		public FVectorDouble D_GetUpVector()
		{
			return USceneComponent.__D_GetUpVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x0016E22D File Offset: 0x0016C42D
		public FTransformDouble D_GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			return USceneComponent.__D_GetSocketTransform_Internal(base.NativePtr, InSocketName, TransformSpace);
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x0016E241 File Offset: 0x0016C441
		public FVectorDouble D_GetSocketLocation(FName InSocketName)
		{
			return USceneComponent.__D_GetSocketLocation_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600F70B RID: 63243 RVA: 0x0016E24F File Offset: 0x0016C44F
		public FVectorDouble D_GetRightVector()
		{
			return USceneComponent.__D_GetRightVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F70C RID: 63244 RVA: 0x0016E25C File Offset: 0x0016C45C
		public FTransformDouble D_GetRelativeTransform()
		{
			return USceneComponent.__D_GetRelativeTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x0016E269 File Offset: 0x0016C469
		public FVectorDouble D_GetForwardVector()
		{
			return USceneComponent.__D_GetForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x0016E276 File Offset: 0x0016C476
		public FVectorDouble D_GetComponentVelocity()
		{
			return USceneComponent.__D_GetComponentVelocity_Internal(base.NativePtr);
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x0016E283 File Offset: 0x0016C483
		public FBoxSphereBounds D_GetComponentBounds()
		{
			return USceneComponent.__D_GetComponentBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600F710 RID: 63248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleVisibility_Internal(IntPtr @this, bool bPropagateToChildren);

		// Token: 0x0600F711 RID: 63249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SnapTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName);

		// Token: 0x0600F712 RID: 63250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldScale3D_Internal(IntPtr @this, FVector NewScale);

		// Token: 0x0600F713 RID: 63251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibility_Internal(IntPtr @this, bool bNewVisibility, bool bPropagateToChildren);

		// Token: 0x0600F714 RID: 63252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldUpdatePhysicsVolume_Internal(IntPtr @this, bool bInShouldUpdatePhysicsVolume);

		// Token: 0x0600F715 RID: 63253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRelativeScale3D_Internal(IntPtr @this, FVector NewScale3D);

		// Token: 0x0600F716 RID: 63254
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobility_Internal(IntPtr @this, TEnumAsByte<EComponentMobility> NewMobility);

		// Token: 0x0600F717 RID: 63255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHiddenInGame_Internal(IntPtr @this, bool NewHidden, bool bPropagateToChildren);

		// Token: 0x0600F718 RID: 63256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAbsolute_Internal(IntPtr @this, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale);

		// Token: 0x0600F719 RID: 63257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x0600F71A RID: 63258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Visibility_Internal(IntPtr @this, bool OldValue);

		// Token: 0x0600F71B RID: 63259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Transform_Internal(IntPtr @this);

		// Token: 0x0600F71C RID: 63260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachSocketName_Internal(IntPtr @this);

		// Token: 0x0600F71D RID: 63261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachParent_Internal(IntPtr @this);

		// Token: 0x0600F71E RID: 63262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachChildren_Internal(IntPtr @this);

		// Token: 0x0600F71F RID: 63263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroRefreshCacheLocalTransform_Internal(IntPtr @this);

		// Token: 0x0600F720 RID: 63264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F721 RID: 63265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F722 RID: 63266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F723 RID: 63267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetWorldLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F724 RID: 63268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F725 RID: 63269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F726 RID: 63270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F727 RID: 63271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetRelativeLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F728 RID: 63272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __K2_GetComponentToWorldWithUpdate_Internal(IntPtr @this);

		// Token: 0x0600F729 RID: 63273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __K2_GetComponentToWorld_Internal(IntPtr @this);

		// Token: 0x0600F72A RID: 63274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetComponentScale_Internal(IntPtr @this);

		// Token: 0x0600F72B RID: 63275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __K2_GetComponentRotation_Internal(IntPtr @this);

		// Token: 0x0600F72C RID: 63276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __K2_GetComponentQuaternion_Internal(IntPtr @this);

		// Token: 0x0600F72D RID: 63277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetComponentLocation_Internal(IntPtr @this);

		// Token: 0x0600F72E RID: 63278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DetachFromComponent_Internal(IntPtr @this, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify);

		// Token: 0x0600F72F RID: 63279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_AttachToComponent_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x0600F730 RID: 63280
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_AttachTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName, TEnumAsByte<EAttachLocation> AttachType, bool bWeldSimulatedBodies);

		// Token: 0x0600F731 RID: 63281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldTransformKeepScale_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F732 RID: 63282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F733 RID: 63283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F734 RID: 63284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddWorldOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F735 RID: 63285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddRelativeRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F736 RID: 63286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddRelativeLocation_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F737 RID: 63287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F738 RID: 63288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F739 RID: 63289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddLocalOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F73A RID: 63290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x0600F73B RID: 63291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulatingPhysics_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600F73C RID: 63292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAttachedTo_Internal(IntPtr @this, IntPtr TestComp);

		// Token: 0x0600F73D RID: 63293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnySimulatingPhysics_Internal(IntPtr @this);

		// Token: 0x0600F73E RID: 63294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVector_Internal(IntPtr @this);

		// Token: 0x0600F73F RID: 63295
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetSocketTransform_Internal(IntPtr @this, FName InSocketName, TEnumAsByte<ERelativeTransformSpace> TransformSpace);

		// Token: 0x0600F740 RID: 63296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetSocketRotation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F741 RID: 63297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetSocketQuaternion_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F742 RID: 63298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSocketLocation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F743 RID: 63299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetShouldUpdatePhysicsVolume_Internal(IntPtr @this);

		// Token: 0x0600F744 RID: 63300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVector_Internal(IntPtr @this);

		// Token: 0x0600F745 RID: 63301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x0600F746 RID: 63302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPhysicsVolume_Internal(IntPtr @this);

		// Token: 0x0600F747 RID: 63303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetParentComponents_Internal(IntPtr @this, IntPtr Parents);

		// Token: 0x0600F748 RID: 63304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumChildrenComponents_Internal(IntPtr @this);

		// Token: 0x0600F749 RID: 63305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetForwardVector_Internal(IntPtr @this);

		// Token: 0x0600F74A RID: 63306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetComponentVelocity_Internal(IntPtr @this);

		// Token: 0x0600F74B RID: 63307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetChildrenComponents_Internal(IntPtr @this, bool bIncludeAllDescendants, IntPtr Children);

		// Token: 0x0600F74C RID: 63308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetChildComponent_Internal(IntPtr @this, int ChildIndex);

		// Token: 0x0600F74D RID: 63309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAttachSocketName_Internal(IntPtr @this);

		// Token: 0x0600F74E RID: 63310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachParent_Internal(IntPtr @this);

		// Token: 0x0600F74F RID: 63311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllSocketNames_Internal(IntPtr @this);

		// Token: 0x0600F750 RID: 63312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesSocketExist_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F751 RID: 63313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachFromParent_Internal(IntPtr @this, bool bMaintainWorldPosition, bool bCallModify);

		// Token: 0x0600F752 RID: 63314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetWorldScale3D_Internal(IntPtr @this, FVectorDouble NewScale);

		// Token: 0x0600F753 RID: 63315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetRelativeScale3D_Internal(IntPtr @this, FVectorDouble NewScale3D);

		// Token: 0x0600F754 RID: 63316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F755 RID: 63317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F756 RID: 63318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetWorldLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F757 RID: 63319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F758 RID: 63320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F759 RID: 63321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetRelativeLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600F75A RID: 63322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_K2_GetComponentToWorldWithUpdate_Internal(IntPtr @this);

		// Token: 0x0600F75B RID: 63323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_K2_GetComponentToWorld_Internal(IntPtr @this);

		// Token: 0x0600F75C RID: 63324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetComponentScale_Internal(IntPtr @this);

		// Token: 0x0600F75D RID: 63325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetComponentLocation_Internal(IntPtr @this);

		// Token: 0x0600F75E RID: 63326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVector_Internal(IntPtr @this);

		// Token: 0x0600F75F RID: 63327
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetSocketTransform_Internal(IntPtr @this, FName InSocketName, TEnumAsByte<ERelativeTransformSpace> TransformSpace);

		// Token: 0x0600F760 RID: 63328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetSocketLocation_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F761 RID: 63329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVector_Internal(IntPtr @this);

		// Token: 0x0600F762 RID: 63330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetRelativeTransform_Internal(IntPtr @this);

		// Token: 0x0600F763 RID: 63331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetForwardVector_Internal(IntPtr @this);

		// Token: 0x0600F764 RID: 63332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetComponentVelocity_Internal(IntPtr @this);

		// Token: 0x0600F765 RID: 63333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __D_GetComponentBounds_Internal(IntPtr @this);

		// Token: 0x0600F766 RID: 63334 RVA: 0x0016E290 File Offset: 0x0016C490
		static USceneComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneComponent");
		}

		// Token: 0x0600F767 RID: 63335 RVA: 0x0016E29E File Offset: 0x0016C49E
		protected USceneComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008587 RID: 34183
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneComponent";

		// Token: 0x04008588 RID: 34184
		private static IntPtr _ClassPtr;

		// Token: 0x04008589 RID: 34185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400858A RID: 34186
		internal static int __PropertyOffset_PhysicsVolume;

		// Token: 0x0400858B RID: 34187
		internal static int __PropertyOffset_AttachParent;

		// Token: 0x0400858C RID: 34188
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x0400858D RID: 34189
		internal static int __PropertyOffset_AttachChildren;

		// Token: 0x0400858E RID: 34190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _AttachChildren;

		// Token: 0x0400858F RID: 34191
		internal static int __PropertyOffset_ClientAttachedChildren;

		// Token: 0x04008590 RID: 34192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _ClientAttachedChildren;

		// Token: 0x04008591 RID: 34193
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04008592 RID: 34194
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x04008593 RID: 34195
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x04008594 RID: 34196
		internal static int __PropertyOffset_RelativeScale3D;

		// Token: 0x04008595 RID: 34197
		internal static int __PropertyOffset_ComponentVelocity;

		// Token: 0x04008596 RID: 34198
		internal static int __PropertyOffset_bKuroMoveDebugLog;

		// Token: 0x04008597 RID: 34199
		internal static int __PropertyOffset_bComponentToWorldUpdated;

		// Token: 0x04008598 RID: 34200
		internal static byte __PropertyMask_bComponentToWorldUpdated;

		// Token: 0x04008599 RID: 34201
		internal static int __PropertyOffset_bAbsoluteLocation;

		// Token: 0x0400859A RID: 34202
		internal static byte __PropertyMask_bAbsoluteLocation;

		// Token: 0x0400859B RID: 34203
		internal static int __PropertyOffset_bAbsoluteRotation;

		// Token: 0x0400859C RID: 34204
		internal static byte __PropertyMask_bAbsoluteRotation;

		// Token: 0x0400859D RID: 34205
		internal static int __PropertyOffset_bAbsoluteScale;

		// Token: 0x0400859E RID: 34206
		internal static byte __PropertyMask_bAbsoluteScale;

		// Token: 0x0400859F RID: 34207
		internal static int __PropertyOffset_bVisible;

		// Token: 0x040085A0 RID: 34208
		internal static byte __PropertyMask_bVisible;

		// Token: 0x040085A1 RID: 34209
		internal static int __PropertyOffset_bShouldBeAttached;

		// Token: 0x040085A2 RID: 34210
		internal static byte __PropertyMask_bShouldBeAttached;

		// Token: 0x040085A3 RID: 34211
		internal static int __PropertyOffset_bShouldSnapLocationWhenAttached;

		// Token: 0x040085A4 RID: 34212
		internal static byte __PropertyMask_bShouldSnapLocationWhenAttached;

		// Token: 0x040085A5 RID: 34213
		internal static int __PropertyOffset_bShouldSnapRotationWhenAttached;

		// Token: 0x040085A6 RID: 34214
		internal static byte __PropertyMask_bShouldSnapRotationWhenAttached;

		// Token: 0x040085A7 RID: 34215
		internal static int __PropertyOffset_bShouldUpdatePhysicsVolume;

		// Token: 0x040085A8 RID: 34216
		internal static byte __PropertyMask_bShouldUpdatePhysicsVolume;

		// Token: 0x040085A9 RID: 34217
		internal static int __PropertyOffset_bHiddenInGame;

		// Token: 0x040085AA RID: 34218
		internal static byte __PropertyMask_bHiddenInGame;

		// Token: 0x040085AB RID: 34219
		internal static int __PropertyOffset_bBoundsChangeTriggersStreamingDataRebuild;

		// Token: 0x040085AC RID: 34220
		internal static byte __PropertyMask_bBoundsChangeTriggersStreamingDataRebuild;

		// Token: 0x040085AD RID: 34221
		internal static int __PropertyOffset_bUseAttachParentBound;

		// Token: 0x040085AE RID: 34222
		internal static byte __PropertyMask_bUseAttachParentBound;

		// Token: 0x040085AF RID: 34223
		internal static int __PropertyOffset_bKuroLocationDebugLog;

		// Token: 0x040085B0 RID: 34224
		internal static byte __PropertyMask_bKuroLocationDebugLog;

		// Token: 0x040085B1 RID: 34225
		internal static int __PropertyOffset_Mobility;

		// Token: 0x040085B2 RID: 34226
		internal static int __PropertyOffset_DetailMode;

		// Token: 0x040085B3 RID: 34227
		internal static int __PropertyOffset_PhysicsVolumeChangedDelegate;

		// Token: 0x040085B4 RID: 34228
		private FPhysicsVolumeChanged _PhysicsVolumeChangedDelegate;
	}
}
