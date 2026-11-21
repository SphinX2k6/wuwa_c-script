using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000164 RID: 356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorComponent")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UActorComponent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015D2 RID: 5586 RVA: 0x00021A5F File Offset: 0x0001FC5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorComponent._ClassPtr;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00021A6C File Offset: 0x0001FC6C
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00021AA5 File Offset: 0x0001FCA5
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get
			{
				base.FastCheckIsValid();
				FActorComponentTickFunction result;
				if ((result = this._PrimaryComponentTick) == null)
				{
					result = (this._PrimaryComponentTick = new FActorComponentTickFunction(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_PrimaryComponentTick, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorComponentTickFunction.StaticStruct(), base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_PrimaryComponentTick, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00021B01 File Offset: 0x0001FD01
		public TArray<FName> ComponentTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ComponentTags) == null)
				{
					result = (this._ComponentTags = new TArray<FName>(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_ComponentTags, this));
				}
				return result;
			}
			set
			{
				this.ComponentTags.CopyAssign(value);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00021B0F File Offset: 0x0001FD0F
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x00021B1F File Offset: 0x0001FD1F
		public unsafe int UCSSerializationIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_UCSSerializationIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_UCSSerializationIndex) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00021B30 File Offset: 0x0001FD30
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x00021B49 File Offset: 0x0001FD49
		public unsafe bool bNetAddressable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bNetAddressable) & UActorComponent.__PropertyMask_bNetAddressable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bNetAddressable) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bNetAddressable) & ~UActorComponent.__PropertyMask_bNetAddressable) | (value ? UActorComponent.__PropertyMask_bNetAddressable : 0));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00021B79 File Offset: 0x0001FD79
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x00021B92 File Offset: 0x0001FD92
		public unsafe bool bReplicates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bReplicates) & UActorComponent.__PropertyMask_bReplicates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bReplicates) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bReplicates) & ~UActorComponent.__PropertyMask_bReplicates) | (value ? UActorComponent.__PropertyMask_bReplicates : 0));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00021BC2 File Offset: 0x0001FDC2
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x00021BDB File Offset: 0x0001FDDB
		public unsafe bool bAutoActivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bAutoActivate) & UActorComponent.__PropertyMask_bAutoActivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bAutoActivate) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bAutoActivate) & ~UActorComponent.__PropertyMask_bAutoActivate) | (value ? UActorComponent.__PropertyMask_bAutoActivate : 0));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00021C0B File Offset: 0x0001FE0B
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x00021C24 File Offset: 0x0001FE24
		public unsafe bool bIsActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsActive) & UActorComponent.__PropertyMask_bIsActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsActive) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsActive) & ~UActorComponent.__PropertyMask_bIsActive) | (value ? UActorComponent.__PropertyMask_bIsActive : 0));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00021C54 File Offset: 0x0001FE54
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00021C6D File Offset: 0x0001FE6D
		public unsafe bool bEditableWhenInherited
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEditableWhenInherited) & UActorComponent.__PropertyMask_bEditableWhenInherited) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEditableWhenInherited) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEditableWhenInherited) & ~UActorComponent.__PropertyMask_bEditableWhenInherited) | (value ? UActorComponent.__PropertyMask_bEditableWhenInherited : 0));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00021C9D File Offset: 0x0001FE9D
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00021CB6 File Offset: 0x0001FEB6
		public unsafe bool bCanEverAffectNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bCanEverAffectNavigation) & UActorComponent.__PropertyMask_bCanEverAffectNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bCanEverAffectNavigation) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bCanEverAffectNavigation) & ~UActorComponent.__PropertyMask_bCanEverAffectNavigation) | (value ? UActorComponent.__PropertyMask_bCanEverAffectNavigation : 0));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00021CE6 File Offset: 0x0001FEE6
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00021CFF File Offset: 0x0001FEFF
		public unsafe bool bIsEditorOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsEditorOnly) & UActorComponent.__PropertyMask_bIsEditorOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsEditorOnly) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bIsEditorOnly) & ~UActorComponent.__PropertyMask_bIsEditorOnly) | (value ? UActorComponent.__PropertyMask_bIsEditorOnly : 0));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00021D2F File Offset: 0x0001FF2F
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x00021D48 File Offset: 0x0001FF48
		public unsafe bool bEnableCreatePhysicsStateDebugLog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableCreatePhysicsStateDebugLog) & UActorComponent.__PropertyMask_bEnableCreatePhysicsStateDebugLog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableCreatePhysicsStateDebugLog) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableCreatePhysicsStateDebugLog) & ~UActorComponent.__PropertyMask_bEnableCreatePhysicsStateDebugLog) | (value ? UActorComponent.__PropertyMask_bEnableCreatePhysicsStateDebugLog : 0));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00021D78 File Offset: 0x0001FF78
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00021D91 File Offset: 0x0001FF91
		public unsafe bool bEnableAutoPhysicsSplit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableAutoPhysicsSplit) & UActorComponent.__PropertyMask_bEnableAutoPhysicsSplit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableAutoPhysicsSplit) = ((*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_bEnableAutoPhysicsSplit) & ~UActorComponent.__PropertyMask_bEnableAutoPhysicsSplit) | (value ? UActorComponent.__PropertyMask_bEnableAutoPhysicsSplit : 0));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00021DC1 File Offset: 0x0001FFC1
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00021DD1 File Offset: 0x0001FFD1
		public unsafe EComponentCreationMethod CreationMethod
		{
			get
			{
				return (EComponentCreationMethod)(*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_CreationMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_CreationMethod) = (byte)value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00021E1D File Offset: 0x0002001D
		public FActorComponentActivatedSignature OnComponentActivated
		{
			get
			{
				base.FastCheckIsValid();
				FActorComponentActivatedSignature result;
				if ((result = this._OnComponentActivated) == null)
				{
					result = (this._OnComponentActivated = new FActorComponentActivatedSignature(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_OnComponentActivated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_OnComponentActivated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00021E40 File Offset: 0x00020040
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00021E79 File Offset: 0x00020079
		public FActorComponentDeactivateSignature OnComponentDeactivated
		{
			get
			{
				base.FastCheckIsValid();
				FActorComponentDeactivateSignature result;
				if ((result = this._OnComponentDeactivated) == null)
				{
					result = (this._OnComponentDeactivated = new FActorComponentDeactivateSignature(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_OnComponentDeactivated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_OnComponentDeactivated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00021E9A File Offset: 0x0002009A
		public void ToggleActive()
		{
			UActorComponent.__ToggleActive_Internal(base.NativePtr);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00021EA7 File Offset: 0x000200A7
		public void SetTickGroup(ETickingGroup NewTickGroup)
		{
			UActorComponent.__SetTickGroup_Internal(base.NativePtr, NewTickGroup);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00021EBA File Offset: 0x000200BA
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			UActorComponent.__SetTickableWhenPaused_Internal(base.NativePtr, bTickableWhenPaused);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00021EC8 File Offset: 0x000200C8
		public void SetKuroOnlyTickOutside(bool OnlyTickOutside)
		{
			UActorComponent.__SetKuroOnlyTickOutside_Internal(base.NativePtr, OnlyTickOutside);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00021ED6 File Offset: 0x000200D6
		public void SetIsReplicated(bool ShouldReplicate)
		{
			UActorComponent.__SetIsReplicated_Internal(base.NativePtr, ShouldReplicate);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00021EE4 File Offset: 0x000200E4
		public void SetComponentTickIntervalAndCooldown(float TickInterval)
		{
			UActorComponent.__SetComponentTickIntervalAndCooldown_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00021EF2 File Offset: 0x000200F2
		public void SetComponentTickInterval(float TickInterval)
		{
			UActorComponent.__SetComponentTickInterval_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00021F00 File Offset: 0x00020100
		public void SetComponentTickEnabled(bool bEnabled)
		{
			UActorComponent.__SetComponentTickEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00021F0E File Offset: 0x0002010E
		public void SetAutoActivate(bool bNewAutoActivate)
		{
			UActorComponent.__SetAutoActivate_Internal(base.NativePtr, bNewAutoActivate);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00021F1C File Offset: 0x0002011C
		public void SetActive(bool bNewActive, bool bReset = false)
		{
			UActorComponent.__SetActive_Internal(base.NativePtr, bNewActive, bReset);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00021F2B File Offset: 0x0002012B
		[NullableContext(2)]
		public void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			UActorComponent.__RemoveTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00021F48 File Offset: 0x00020148
		[NullableContext(2)]
		public void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			UActorComponent.__RemoveTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00021F65 File Offset: 0x00020165
		public virtual void ReceiveTick(float DeltaSeconds)
		{
			UActorComponent.__ReceiveTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00021F73 File Offset: 0x00020173
		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			UActorComponent.__ReceiveEndPlay_Internal(base.NativePtr, EndPlayReason);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00021F86 File Offset: 0x00020186
		public virtual void ReceiveBeginPlay()
		{
			UActorComponent.__ReceiveBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00021F93 File Offset: 0x00020193
		public void OnRep_IsActive()
		{
			UActorComponent.__OnRep_IsActive_Internal(base.NativePtr);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00021FA0 File Offset: 0x000201A0
		public void KuroTickComponentOutside(float DeltaSeconds)
		{
			UActorComponent.__KuroTickComponentOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00021FAE File Offset: 0x000201AE
		public void KuroDestroyPhysicsState()
		{
			UActorComponent.__KuroDestroyPhysicsState_Internal(base.NativePtr);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00021FBB File Offset: 0x000201BB
		public void KuroCreatePhysicsState(bool bAllowDeferral = false)
		{
			UActorComponent.__KuroCreatePhysicsState_Internal(base.NativePtr, bAllowDeferral);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00021FC9 File Offset: 0x000201C9
		[NullableContext(2)]
		public void K2_DestroyComponent(UObject Object)
		{
			UActorComponent.__K2_DestroyComponent_Internal(base.NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00021FE6 File Offset: 0x000201E6
		public bool IsComponentTickEnabled()
		{
			return UActorComponent.__IsComponentTickEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00021FF3 File Offset: 0x000201F3
		public bool IsBeingDestroyed()
		{
			return UActorComponent.__IsBeingDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00022000 File Offset: 0x00020200
		public bool IsActive()
		{
			return UActorComponent.__IsActive_Internal(base.NativePtr);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0002200D File Offset: 0x0002020D
		[NullableContext(2)]
		public AActor GetOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UActorComponent.__GetOwner_Internal(base.NativePtr));
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0002201F File Offset: 0x0002021F
		public float GetComponentTickInterval()
		{
			return UActorComponent.__GetComponentTickInterval_Internal(base.NativePtr);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0002202C File Offset: 0x0002022C
		public void Deactivate()
		{
			UActorComponent.__Deactivate_Internal(base.NativePtr);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00022039 File Offset: 0x00020239
		public bool ComponentHasTag(FName Tag)
		{
			return UActorComponent.__ComponentHasTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00022047 File Offset: 0x00020247
		[NullableContext(2)]
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			UActorComponent.__AddTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00022064 File Offset: 0x00020264
		[NullableContext(2)]
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			UActorComponent.__AddTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00022081 File Offset: 0x00020281
		public void Activate(bool bReset = false)
		{
			UActorComponent.__Activate_Internal(base.NativePtr, bReset);
		}

		// Token: 0x0600160F RID: 5647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleActive_Internal(IntPtr @this);

		// Token: 0x06001610 RID: 5648
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickGroup_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> NewTickGroup);

		// Token: 0x06001611 RID: 5649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickableWhenPaused_Internal(IntPtr @this, bool bTickableWhenPaused);

		// Token: 0x06001612 RID: 5650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOnlyTickOutside_Internal(IntPtr @this, bool OnlyTickOutside);

		// Token: 0x06001613 RID: 5651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReplicated_Internal(IntPtr @this, bool ShouldReplicate);

		// Token: 0x06001614 RID: 5652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickIntervalAndCooldown_Internal(IntPtr @this, float TickInterval);

		// Token: 0x06001615 RID: 5653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickInterval_Internal(IntPtr @this, float TickInterval);

		// Token: 0x06001616 RID: 5654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06001617 RID: 5655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoActivate_Internal(IntPtr @this, bool bNewAutoActivate);

		// Token: 0x06001618 RID: 5656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActive_Internal(IntPtr @this, bool bNewActive, bool bReset);

		// Token: 0x06001619 RID: 5657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600161A RID: 5658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600161B RID: 5659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0600161C RID: 5660
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x0600161D RID: 5661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBeginPlay_Internal(IntPtr @this);

		// Token: 0x0600161E RID: 5662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_IsActive_Internal(IntPtr @this);

		// Token: 0x0600161F RID: 5663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroTickComponentOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06001620 RID: 5664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroDestroyPhysicsState_Internal(IntPtr @this);

		// Token: 0x06001621 RID: 5665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroCreatePhysicsState_Internal(IntPtr @this, bool bAllowDeferral);

		// Token: 0x06001622 RID: 5666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyComponent_Internal(IntPtr @this, IntPtr Object);

		// Token: 0x06001623 RID: 5667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsComponentTickEnabled_Internal(IntPtr @this);

		// Token: 0x06001624 RID: 5668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBeingDestroyed_Internal(IntPtr @this);

		// Token: 0x06001625 RID: 5669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActive_Internal(IntPtr @this);

		// Token: 0x06001626 RID: 5670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwner_Internal(IntPtr @this);

		// Token: 0x06001627 RID: 5671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetComponentTickInterval_Internal(IntPtr @this);

		// Token: 0x06001628 RID: 5672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Deactivate_Internal(IntPtr @this);

		// Token: 0x06001629 RID: 5673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentHasTag_Internal(IntPtr @this, FName Tag);

		// Token: 0x0600162A RID: 5674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600162B RID: 5675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600162C RID: 5676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Activate_Internal(IntPtr @this, bool bReset);

		// Token: 0x0600162D RID: 5677 RVA: 0x0002208F File Offset: 0x0002028F
		static UActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorComponent");
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000220A0 File Offset: 0x000202A0
		protected UActorComponent() : this(BuiltinUtils.AllocNativeUObject(UActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000220C8 File Offset: 0x000202C8
		protected UActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040006EF RID: 1775
		public new const string __ObjectPath = "/Script/Engine.ActorComponent";

		// Token: 0x040006F0 RID: 1776
		private static IntPtr _ClassPtr;

		// Token: 0x040006F1 RID: 1777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040006F2 RID: 1778
		internal static int __PropertyOffset_PrimaryComponentTick;

		// Token: 0x040006F3 RID: 1779
		[Nullable(2)]
		private FActorComponentTickFunction _PrimaryComponentTick;

		// Token: 0x040006F4 RID: 1780
		internal static int __PropertyOffset_ComponentTags;

		// Token: 0x040006F5 RID: 1781
		[Nullable(2)]
		private TArray<FName> _ComponentTags;

		// Token: 0x040006F6 RID: 1782
		internal static int __PropertyOffset_UCSSerializationIndex;

		// Token: 0x040006F7 RID: 1783
		internal static int __PropertyOffset_bNetAddressable;

		// Token: 0x040006F8 RID: 1784
		internal static byte __PropertyMask_bNetAddressable;

		// Token: 0x040006F9 RID: 1785
		internal static int __PropertyOffset_bReplicates;

		// Token: 0x040006FA RID: 1786
		internal static byte __PropertyMask_bReplicates;

		// Token: 0x040006FB RID: 1787
		internal static int __PropertyOffset_bAutoActivate;

		// Token: 0x040006FC RID: 1788
		internal static byte __PropertyMask_bAutoActivate;

		// Token: 0x040006FD RID: 1789
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x040006FE RID: 1790
		internal static byte __PropertyMask_bIsActive;

		// Token: 0x040006FF RID: 1791
		internal static int __PropertyOffset_bEditableWhenInherited;

		// Token: 0x04000700 RID: 1792
		internal static byte __PropertyMask_bEditableWhenInherited;

		// Token: 0x04000701 RID: 1793
		internal static int __PropertyOffset_bCanEverAffectNavigation;

		// Token: 0x04000702 RID: 1794
		internal static byte __PropertyMask_bCanEverAffectNavigation;

		// Token: 0x04000703 RID: 1795
		internal static int __PropertyOffset_bIsEditorOnly;

		// Token: 0x04000704 RID: 1796
		internal static byte __PropertyMask_bIsEditorOnly;

		// Token: 0x04000705 RID: 1797
		internal static int __PropertyOffset_bEnableCreatePhysicsStateDebugLog;

		// Token: 0x04000706 RID: 1798
		internal static byte __PropertyMask_bEnableCreatePhysicsStateDebugLog;

		// Token: 0x04000707 RID: 1799
		internal static int __PropertyOffset_bEnableAutoPhysicsSplit;

		// Token: 0x04000708 RID: 1800
		internal static byte __PropertyMask_bEnableAutoPhysicsSplit;

		// Token: 0x04000709 RID: 1801
		internal static int __PropertyOffset_CreationMethod;

		// Token: 0x0400070A RID: 1802
		internal static int __PropertyOffset_OnComponentActivated;

		// Token: 0x0400070B RID: 1803
		[Nullable(2)]
		private FActorComponentActivatedSignature _OnComponentActivated;

		// Token: 0x0400070C RID: 1804
		internal static int __PropertyOffset_OnComponentDeactivated;

		// Token: 0x0400070D RID: 1805
		[Nullable(2)]
		private FActorComponentDeactivateSignature _OnComponentDeactivated;

		// Token: 0x0200094A RID: 2378
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0400586B RID: 22635
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200094B RID: 2379
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0400586C RID: 22636
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
