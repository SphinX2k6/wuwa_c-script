using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B0 RID: 1968
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorComponent")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UActorComponent : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006910 RID: 26896 RVA: 0x00096DFC File Offset: 0x00094FFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorComponent._ClassPtr;
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00096E08 File Offset: 0x00095008
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UActorComponent.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x00096E10 File Offset: 0x00095010
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x00096E49 File Offset: 0x00095049
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

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x00096E6C File Offset: 0x0009506C
		// (set) Token: 0x06006915 RID: 26901 RVA: 0x00096EA5 File Offset: 0x000950A5
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06006916 RID: 26902 RVA: 0x00096EB4 File Offset: 0x000950B4
		// (set) Token: 0x06006917 RID: 26903 RVA: 0x00096EED File Offset: 0x000950ED
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x00096EFB File Offset: 0x000950FB
		// (set) Token: 0x06006919 RID: 26905 RVA: 0x00096F0B File Offset: 0x0009510B
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

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x00096F1C File Offset: 0x0009511C
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x00096F35 File Offset: 0x00095135
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x00096F65 File Offset: 0x00095165
		// (set) Token: 0x0600691D RID: 26909 RVA: 0x00096F7E File Offset: 0x0009517E
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

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x00096FAE File Offset: 0x000951AE
		// (set) Token: 0x0600691F RID: 26911 RVA: 0x00096FC7 File Offset: 0x000951C7
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

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x00096FF7 File Offset: 0x000951F7
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x00097010 File Offset: 0x00095210
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

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x00097040 File Offset: 0x00095240
		// (set) Token: 0x06006923 RID: 26915 RVA: 0x00097059 File Offset: 0x00095259
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

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x00097089 File Offset: 0x00095289
		// (set) Token: 0x06006925 RID: 26917 RVA: 0x000970A2 File Offset: 0x000952A2
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

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x000970D2 File Offset: 0x000952D2
		// (set) Token: 0x06006927 RID: 26919 RVA: 0x000970EB File Offset: 0x000952EB
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

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x0009711B File Offset: 0x0009531B
		// (set) Token: 0x06006929 RID: 26921 RVA: 0x00097134 File Offset: 0x00095334
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

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x00097164 File Offset: 0x00095364
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x0009717D File Offset: 0x0009537D
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

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x000971AD File Offset: 0x000953AD
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x000971BD File Offset: 0x000953BD
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

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x000971D0 File Offset: 0x000953D0
		// (set) Token: 0x0600692F RID: 26927 RVA: 0x00097209 File Offset: 0x00095409
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

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x0009722C File Offset: 0x0009542C
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x00097265 File Offset: 0x00095465
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

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x00097288 File Offset: 0x00095488
		// (set) Token: 0x06006933 RID: 26931 RVA: 0x000972C1 File Offset: 0x000954C1
		public TArray<FSimpleMemberReference> UCSModifiedProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSimpleMemberReference> result;
				if ((result = this._UCSModifiedProperties) == null)
				{
					result = (this._UCSModifiedProperties = new TArray<FSimpleMemberReference>(base.NativePtr + (IntPtr)UActorComponent.__PropertyOffset_UCSModifiedProperties, this));
				}
				return result;
			}
			set
			{
				this.UCSModifiedProperties.CopyAssign(value);
			}
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x000972CF File Offset: 0x000954CF
		public void ToggleActive()
		{
			UActorComponent.__ToggleActive_Internal(base.NativePtr);
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x000972DC File Offset: 0x000954DC
		public void SetTickGroup(ETickingGroup NewTickGroup)
		{
			UActorComponent.__SetTickGroup_Internal(base.NativePtr, NewTickGroup);
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x000972EF File Offset: 0x000954EF
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			UActorComponent.__SetTickableWhenPaused_Internal(base.NativePtr, bTickableWhenPaused);
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x000972FD File Offset: 0x000954FD
		public void SetKuroOnlyTickOutside(bool OnlyTickOutside)
		{
			UActorComponent.__SetKuroOnlyTickOutside_Internal(base.NativePtr, OnlyTickOutside);
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x0009730B File Offset: 0x0009550B
		public void SetIsReplicated(bool ShouldReplicate)
		{
			UActorComponent.__SetIsReplicated_Internal(base.NativePtr, ShouldReplicate);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00097319 File Offset: 0x00095519
		public void SetComponentTickIntervalAndCooldown(float TickInterval)
		{
			UActorComponent.__SetComponentTickIntervalAndCooldown_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x00097327 File Offset: 0x00095527
		public void SetComponentTickInterval(float TickInterval)
		{
			UActorComponent.__SetComponentTickInterval_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00097335 File Offset: 0x00095535
		public void SetComponentTickEnabled(bool bEnabled)
		{
			UActorComponent.__SetComponentTickEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00097343 File Offset: 0x00095543
		public void SetAutoActivate(bool bNewAutoActivate)
		{
			UActorComponent.__SetAutoActivate_Internal(base.NativePtr, bNewAutoActivate);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00097351 File Offset: 0x00095551
		public void SetActive(bool bNewActive, bool bReset = false)
		{
			UActorComponent.__SetActive_Internal(base.NativePtr, bNewActive, bReset);
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00097360 File Offset: 0x00095560
		[NullableContext(2)]
		public void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			UActorComponent.__RemoveTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x0009737D File Offset: 0x0009557D
		[NullableContext(2)]
		public void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			UActorComponent.__RemoveTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x0009739A File Offset: 0x0009559A
		public virtual void ReceiveTick(float DeltaSeconds)
		{
			UActorComponent.__ReceiveTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x000973A8 File Offset: 0x000955A8
		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			UActorComponent.__ReceiveEndPlay_Internal(base.NativePtr, EndPlayReason);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x000973BB File Offset: 0x000955BB
		public virtual void ReceiveBeginPlay()
		{
			UActorComponent.__ReceiveBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x000973C8 File Offset: 0x000955C8
		public void OnRep_IsActive()
		{
			UActorComponent.__OnRep_IsActive_Internal(base.NativePtr);
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x000973D5 File Offset: 0x000955D5
		public void KuroTickComponentOutside(float DeltaSeconds)
		{
			UActorComponent.__KuroTickComponentOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x000973E3 File Offset: 0x000955E3
		public void KuroDestroyPhysicsState()
		{
			UActorComponent.__KuroDestroyPhysicsState_Internal(base.NativePtr);
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x000973F0 File Offset: 0x000955F0
		public void KuroCreatePhysicsState(bool bAllowDeferral = false)
		{
			UActorComponent.__KuroCreatePhysicsState_Internal(base.NativePtr, bAllowDeferral);
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x000973FE File Offset: 0x000955FE
		[NullableContext(2)]
		public void K2_DestroyComponent(UObject Object)
		{
			UActorComponent.__K2_DestroyComponent_Internal(base.NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x0009741B File Offset: 0x0009561B
		public bool IsComponentTickEnabled()
		{
			return UActorComponent.__IsComponentTickEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00097428 File Offset: 0x00095628
		public bool IsBeingDestroyed()
		{
			return UActorComponent.__IsBeingDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00097435 File Offset: 0x00095635
		public bool IsActive()
		{
			return UActorComponent.__IsActive_Internal(base.NativePtr);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00097442 File Offset: 0x00095642
		[NullableContext(2)]
		public AActor GetOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UActorComponent.__GetOwner_Internal(base.NativePtr));
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00097454 File Offset: 0x00095654
		public float GetComponentTickInterval()
		{
			return UActorComponent.__GetComponentTickInterval_Internal(base.NativePtr);
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00097461 File Offset: 0x00095661
		public void Deactivate()
		{
			UActorComponent.__Deactivate_Internal(base.NativePtr);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x0009746E File Offset: 0x0009566E
		public bool ComponentHasTag(FName Tag)
		{
			return UActorComponent.__ComponentHasTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x0009747C File Offset: 0x0009567C
		[NullableContext(2)]
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			UActorComponent.__AddTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00097499 File Offset: 0x00095699
		[NullableContext(2)]
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			UActorComponent.__AddTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x000974B6 File Offset: 0x000956B6
		public void Activate(bool bReset = false)
		{
			UActorComponent.__Activate_Internal(base.NativePtr, bReset);
		}

		// Token: 0x06006952 RID: 26962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleActive_Internal(IntPtr @this);

		// Token: 0x06006953 RID: 26963
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickGroup_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> NewTickGroup);

		// Token: 0x06006954 RID: 26964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickableWhenPaused_Internal(IntPtr @this, bool bTickableWhenPaused);

		// Token: 0x06006955 RID: 26965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOnlyTickOutside_Internal(IntPtr @this, bool OnlyTickOutside);

		// Token: 0x06006956 RID: 26966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReplicated_Internal(IntPtr @this, bool ShouldReplicate);

		// Token: 0x06006957 RID: 26967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickIntervalAndCooldown_Internal(IntPtr @this, float TickInterval);

		// Token: 0x06006958 RID: 26968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickInterval_Internal(IntPtr @this, float TickInterval);

		// Token: 0x06006959 RID: 26969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentTickEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x0600695A RID: 26970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoActivate_Internal(IntPtr @this, bool bNewAutoActivate);

		// Token: 0x0600695B RID: 26971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActive_Internal(IntPtr @this, bool bNewActive, bool bReset);

		// Token: 0x0600695C RID: 26972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600695D RID: 26973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600695E RID: 26974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0600695F RID: 26975
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x06006960 RID: 26976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBeginPlay_Internal(IntPtr @this);

		// Token: 0x06006961 RID: 26977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_IsActive_Internal(IntPtr @this);

		// Token: 0x06006962 RID: 26978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroTickComponentOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06006963 RID: 26979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroDestroyPhysicsState_Internal(IntPtr @this);

		// Token: 0x06006964 RID: 26980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroCreatePhysicsState_Internal(IntPtr @this, bool bAllowDeferral);

		// Token: 0x06006965 RID: 26981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyComponent_Internal(IntPtr @this, IntPtr Object);

		// Token: 0x06006966 RID: 26982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsComponentTickEnabled_Internal(IntPtr @this);

		// Token: 0x06006967 RID: 26983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBeingDestroyed_Internal(IntPtr @this);

		// Token: 0x06006968 RID: 26984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActive_Internal(IntPtr @this);

		// Token: 0x06006969 RID: 26985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwner_Internal(IntPtr @this);

		// Token: 0x0600696A RID: 26986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetComponentTickInterval_Internal(IntPtr @this);

		// Token: 0x0600696B RID: 26987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Deactivate_Internal(IntPtr @this);

		// Token: 0x0600696C RID: 26988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentHasTag_Internal(IntPtr @this, FName Tag);

		// Token: 0x0600696D RID: 26989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600696E RID: 26990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600696F RID: 26991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Activate_Internal(IntPtr @this, bool bReset);

		// Token: 0x06006970 RID: 26992 RVA: 0x000974C4 File Offset: 0x000956C4
		static UActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorComponent");
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x000974D4 File Offset: 0x000956D4
		protected UActorComponent() : this(BuiltinUtils.AllocNativeUObject(UActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x000974FC File Offset: 0x000956FC
		protected UActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040032B4 RID: 12980
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x040032B5 RID: 12981
		public new const string __ObjectPath = "/Script/Engine.ActorComponent";

		// Token: 0x040032B6 RID: 12982
		private static IntPtr _ClassPtr;

		// Token: 0x040032B7 RID: 12983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040032B8 RID: 12984
		internal static int __PropertyOffset_PrimaryComponentTick;

		// Token: 0x040032B9 RID: 12985
		[Nullable(2)]
		private FActorComponentTickFunction _PrimaryComponentTick;

		// Token: 0x040032BA RID: 12986
		internal static int __PropertyOffset_ComponentTags;

		// Token: 0x040032BB RID: 12987
		[Nullable(2)]
		private TArray<FName> _ComponentTags;

		// Token: 0x040032BC RID: 12988
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x040032BD RID: 12989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x040032BE RID: 12990
		internal static int __PropertyOffset_UCSSerializationIndex;

		// Token: 0x040032BF RID: 12991
		internal static int __PropertyOffset_bNetAddressable;

		// Token: 0x040032C0 RID: 12992
		internal static byte __PropertyMask_bNetAddressable;

		// Token: 0x040032C1 RID: 12993
		internal static int __PropertyOffset_bReplicates;

		// Token: 0x040032C2 RID: 12994
		internal static byte __PropertyMask_bReplicates;

		// Token: 0x040032C3 RID: 12995
		internal static int __PropertyOffset_bAutoActivate;

		// Token: 0x040032C4 RID: 12996
		internal static byte __PropertyMask_bAutoActivate;

		// Token: 0x040032C5 RID: 12997
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x040032C6 RID: 12998
		internal static byte __PropertyMask_bIsActive;

		// Token: 0x040032C7 RID: 12999
		internal static int __PropertyOffset_bEditableWhenInherited;

		// Token: 0x040032C8 RID: 13000
		internal static byte __PropertyMask_bEditableWhenInherited;

		// Token: 0x040032C9 RID: 13001
		internal static int __PropertyOffset_bCanEverAffectNavigation;

		// Token: 0x040032CA RID: 13002
		internal static byte __PropertyMask_bCanEverAffectNavigation;

		// Token: 0x040032CB RID: 13003
		internal static int __PropertyOffset_bIsEditorOnly;

		// Token: 0x040032CC RID: 13004
		internal static byte __PropertyMask_bIsEditorOnly;

		// Token: 0x040032CD RID: 13005
		internal static int __PropertyOffset_bEnableCreatePhysicsStateDebugLog;

		// Token: 0x040032CE RID: 13006
		internal static byte __PropertyMask_bEnableCreatePhysicsStateDebugLog;

		// Token: 0x040032CF RID: 13007
		internal static int __PropertyOffset_bEnableAutoPhysicsSplit;

		// Token: 0x040032D0 RID: 13008
		internal static byte __PropertyMask_bEnableAutoPhysicsSplit;

		// Token: 0x040032D1 RID: 13009
		internal static int __PropertyOffset_CreationMethod;

		// Token: 0x040032D2 RID: 13010
		internal static int __PropertyOffset_OnComponentActivated;

		// Token: 0x040032D3 RID: 13011
		[Nullable(2)]
		private FActorComponentActivatedSignature _OnComponentActivated;

		// Token: 0x040032D4 RID: 13012
		internal static int __PropertyOffset_OnComponentDeactivated;

		// Token: 0x040032D5 RID: 13013
		[Nullable(2)]
		private FActorComponentDeactivateSignature _OnComponentDeactivated;

		// Token: 0x040032D6 RID: 13014
		internal static int __PropertyOffset_UCSModifiedProperties;

		// Token: 0x040032D7 RID: 13015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSimpleMemberReference> _UCSModifiedProperties;

		// Token: 0x02002C67 RID: 11367
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04016595 RID: 91541
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02002C68 RID: 11368
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04016596 RID: 91542
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
