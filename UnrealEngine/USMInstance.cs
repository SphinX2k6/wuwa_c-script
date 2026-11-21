using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000831 RID: 2097
	[UnrealObjectPath("/Script/SMSystem.SMInstance")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class USMInstance : UObject, IUnrealUObject, IUnrealObject, ISMInstanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B66A RID: 46698 RVA: 0x001225B5 File Offset: 0x001207B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMInstance._ClassPtr;
		}

		// Token: 0x0600B66B RID: 46699 RVA: 0x001225C1 File Offset: 0x001207C1
		int ISMInstanceInterface.InterfaceOffset()
		{
			return USMInstance.__InterfaceOffset_ISMInstanceInterface;
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x001225C8 File Offset: 0x001207C8
		public USMInstance() : this(BuiltinUtils.AllocNativeUObject(USMInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x001225F0 File Offset: 0x001207F0
		[NullableContext(1)]
		public USMInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600B66E RID: 46702 RVA: 0x00122623 File Offset: 0x00120823
		// (set) Token: 0x0600B66F RID: 46703 RVA: 0x00122637 File Offset: 0x00120837
		public unsafe FGuid RootStateMachineGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_RootStateMachineGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_RootStateMachineGuid) = value;
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600B670 RID: 46704 RVA: 0x0012264C File Offset: 0x0012084C
		// (set) Token: 0x0600B671 RID: 46705 RVA: 0x00122685 File Offset: 0x00120885
		[Nullable(1)]
		public TArray<USMStateMachineInstance> AllRootNodeInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USMStateMachineInstance> result;
				if ((result = this._AllRootNodeInstances) == null)
				{
					result = (this._AllRootNodeInstances = new TArray<USMStateMachineInstance>(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_AllRootNodeInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllRootNodeInstances.CopyAssign(value);
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600B672 RID: 46706 RVA: 0x00122694 File Offset: 0x00120894
		// (set) Token: 0x0600B673 RID: 46707 RVA: 0x001226CD File Offset: 0x001208CD
		[Nullable(1)]
		public FOnStateMachineInitializedSignature OnPreStateMachineInitializedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineInitializedSignature result;
				if ((result = this._OnPreStateMachineInitializedEvent) == null)
				{
					result = (this._OnPreStateMachineInitializedEvent = new FOnStateMachineInitializedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnPreStateMachineInitializedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnPreStateMachineInitializedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600B674 RID: 46708 RVA: 0x001226F0 File Offset: 0x001208F0
		// (set) Token: 0x0600B675 RID: 46709 RVA: 0x00122729 File Offset: 0x00120929
		[Nullable(1)]
		public FOnStateMachineInitializedSignature OnStateMachineInitializedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineInitializedSignature result;
				if ((result = this._OnStateMachineInitializedEvent) == null)
				{
					result = (this._OnStateMachineInitializedEvent = new FOnStateMachineInitializedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineInitializedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineInitializedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600B676 RID: 46710 RVA: 0x0012274C File Offset: 0x0012094C
		// (set) Token: 0x0600B677 RID: 46711 RVA: 0x00122785 File Offset: 0x00120985
		[Nullable(1)]
		public FOnStateMachineStartedSignature OnStateMachineStartedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineStartedSignature result;
				if ((result = this._OnStateMachineStartedEvent) == null)
				{
					result = (this._OnStateMachineStartedEvent = new FOnStateMachineStartedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStartedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStartedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600B678 RID: 46712 RVA: 0x001227A8 File Offset: 0x001209A8
		// (set) Token: 0x0600B679 RID: 46713 RVA: 0x001227E1 File Offset: 0x001209E1
		[Nullable(1)]
		public FOnStateMachineUpdatedSignature OnStateMachineUpdatedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineUpdatedSignature result;
				if ((result = this._OnStateMachineUpdatedEvent) == null)
				{
					result = (this._OnStateMachineUpdatedEvent = new FOnStateMachineUpdatedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineUpdatedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineUpdatedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x0600B67A RID: 46714 RVA: 0x00122804 File Offset: 0x00120A04
		// (set) Token: 0x0600B67B RID: 46715 RVA: 0x0012283D File Offset: 0x00120A3D
		[Nullable(1)]
		public FOnStateMachineStoppedSignature OnStateMachineStoppedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineStoppedSignature result;
				if ((result = this._OnStateMachineStoppedEvent) == null)
				{
					result = (this._OnStateMachineStoppedEvent = new FOnStateMachineStoppedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStoppedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStoppedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600B67C RID: 46716 RVA: 0x0012285E File Offset: 0x00120A5E
		// (set) Token: 0x0600B67D RID: 46717 RVA: 0x00122872 File Offset: 0x00120A72
		[Nullable(2)]
		public unsafe UObject R_StateMachineContext
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_R_StateMachineContext);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_R_StateMachineContext, value);
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600B67E RID: 46718 RVA: 0x00122887 File Offset: 0x00120A87
		// (set) Token: 0x0600B67F RID: 46719 RVA: 0x0012289B File Offset: 0x00120A9B
		[Nullable(2)]
		public unsafe USMInstance ReferenceOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_ReferenceOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_ReferenceOwner, value);
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600B680 RID: 46720 RVA: 0x001228B0 File Offset: 0x00120AB0
		// (set) Token: 0x0600B681 RID: 46721 RVA: 0x001228C4 File Offset: 0x00120AC4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USMStateMachineInstance> StateMachineClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_StateMachineClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_StateMachineClass) = value;
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600B682 RID: 46722 RVA: 0x001228D9 File Offset: 0x00120AD9
		// (set) Token: 0x0600B683 RID: 46723 RVA: 0x001228F2 File Offset: 0x00120AF2
		public unsafe bool bAutoManageTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bAutoManageTime) & USMInstance.__PropertyMask_bAutoManageTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bAutoManageTime) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bAutoManageTime) & ~USMInstance.__PropertyMask_bAutoManageTime) | (value ? USMInstance.__PropertyMask_bAutoManageTime : 0));
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600B684 RID: 46724 RVA: 0x00122922 File Offset: 0x00120B22
		// (set) Token: 0x0600B685 RID: 46725 RVA: 0x0012293B File Offset: 0x00120B3B
		public unsafe bool bStopOnEndState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bStopOnEndState) & USMInstance.__PropertyMask_bStopOnEndState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bStopOnEndState) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bStopOnEndState) & ~USMInstance.__PropertyMask_bStopOnEndState) | (value ? USMInstance.__PropertyMask_bStopOnEndState : 0));
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600B686 RID: 46726 RVA: 0x0012296B File Offset: 0x00120B6B
		// (set) Token: 0x0600B687 RID: 46727 RVA: 0x00122984 File Offset: 0x00120B84
		public unsafe bool bCanEverTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanEverTick) & USMInstance.__PropertyMask_bCanEverTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanEverTick) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanEverTick) & ~USMInstance.__PropertyMask_bCanEverTick) | (value ? USMInstance.__PropertyMask_bCanEverTick : 0));
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600B688 RID: 46728 RVA: 0x001229B4 File Offset: 0x00120BB4
		// (set) Token: 0x0600B689 RID: 46729 RVA: 0x001229CD File Offset: 0x00120BCD
		public unsafe bool bCanTickWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanTickWhenPaused) & USMInstance.__PropertyMask_bCanTickWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanTickWhenPaused) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanTickWhenPaused) & ~USMInstance.__PropertyMask_bCanTickWhenPaused) | (value ? USMInstance.__PropertyMask_bCanTickWhenPaused : 0));
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x001229FD File Offset: 0x00120BFD
		// (set) Token: 0x0600B68B RID: 46731 RVA: 0x00122A16 File Offset: 0x00120C16
		public unsafe bool bTickRegistered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickRegistered) & USMInstance.__PropertyMask_bTickRegistered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickRegistered) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickRegistered) & ~USMInstance.__PropertyMask_bTickRegistered) | (value ? USMInstance.__PropertyMask_bTickRegistered : 0));
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600B68C RID: 46732 RVA: 0x00122A46 File Offset: 0x00120C46
		// (set) Token: 0x0600B68D RID: 46733 RVA: 0x00122A5F File Offset: 0x00120C5F
		public unsafe bool bTickBeforeInitialize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeInitialize) & USMInstance.__PropertyMask_bTickBeforeInitialize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeInitialize) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeInitialize) & ~USMInstance.__PropertyMask_bTickBeforeInitialize) | (value ? USMInstance.__PropertyMask_bTickBeforeInitialize : 0));
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600B68E RID: 46734 RVA: 0x00122A8F File Offset: 0x00120C8F
		// (set) Token: 0x0600B68F RID: 46735 RVA: 0x00122AA8 File Offset: 0x00120CA8
		public unsafe bool bTickBeforeBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeBeginPlay) & USMInstance.__PropertyMask_bTickBeforeBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeBeginPlay) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bTickBeforeBeginPlay) & ~USMInstance.__PropertyMask_bTickBeforeBeginPlay) | (value ? USMInstance.__PropertyMask_bTickBeforeBeginPlay : 0));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600B690 RID: 46736 RVA: 0x00122AD8 File Offset: 0x00120CD8
		// (set) Token: 0x0600B691 RID: 46737 RVA: 0x00122AE8 File Offset: 0x00120CE8
		public unsafe float TickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_TickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_TickInterval) = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600B692 RID: 46738 RVA: 0x00122AF9 File Offset: 0x00120CF9
		// (set) Token: 0x0600B693 RID: 46739 RVA: 0x00122B09 File Offset: 0x00120D09
		public unsafe int StateHistoryMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_StateHistoryMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_StateHistoryMaxCount) = value;
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600B694 RID: 46740 RVA: 0x00122B1A File Offset: 0x00120D1A
		// (set) Token: 0x0600B695 RID: 46741 RVA: 0x00122B33 File Offset: 0x00120D33
		public unsafe bool bEnableLogging
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bEnableLogging) & USMInstance.__PropertyMask_bEnableLogging) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bEnableLogging) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bEnableLogging) & ~USMInstance.__PropertyMask_bEnableLogging) | (value ? USMInstance.__PropertyMask_bEnableLogging : 0));
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x00122B63 File Offset: 0x00120D63
		// (set) Token: 0x0600B697 RID: 46743 RVA: 0x00122B7C File Offset: 0x00120D7C
		public unsafe bool bLogStateChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogStateChange) & USMInstance.__PropertyMask_bLogStateChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogStateChange) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogStateChange) & ~USMInstance.__PropertyMask_bLogStateChange) | (value ? USMInstance.__PropertyMask_bLogStateChange : 0));
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600B698 RID: 46744 RVA: 0x00122BAC File Offset: 0x00120DAC
		// (set) Token: 0x0600B699 RID: 46745 RVA: 0x00122BC5 File Offset: 0x00120DC5
		public unsafe bool bLogTransitionTaken
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogTransitionTaken) & USMInstance.__PropertyMask_bLogTransitionTaken) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogTransitionTaken) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bLogTransitionTaken) & ~USMInstance.__PropertyMask_bLogTransitionTaken) | (value ? USMInstance.__PropertyMask_bLogTransitionTaken : 0));
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0600B69A RID: 46746 RVA: 0x00122BF5 File Offset: 0x00120DF5
		// (set) Token: 0x0600B69B RID: 46747 RVA: 0x00122C0E File Offset: 0x00120E0E
		public unsafe bool bCanReplicateAsReference
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanReplicateAsReference) & USMInstance.__PropertyMask_bCanReplicateAsReference) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanReplicateAsReference) = ((*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_bCanReplicateAsReference) & ~USMInstance.__PropertyMask_bCanReplicateAsReference) | (value ? USMInstance.__PropertyMask_bCanReplicateAsReference : 0));
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600B69C RID: 46748 RVA: 0x00122C40 File Offset: 0x00120E40
		// (set) Token: 0x0600B69D RID: 46749 RVA: 0x00122C79 File Offset: 0x00120E79
		[Nullable(1)]
		public TMap<FGuid, FGuid> PathGuidRedirectMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._PathGuidRedirectMap) == null)
				{
					result = (this._PathGuidRedirectMap = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_PathGuidRedirectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PathGuidRedirectMap.CopyAssign(value);
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x0600B69E RID: 46750 RVA: 0x00122C88 File Offset: 0x00120E88
		// (set) Token: 0x0600B69F RID: 46751 RVA: 0x00122CC1 File Offset: 0x00120EC1
		[Nullable(1)]
		public TArray<UObject> ReferenceTemplates
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferenceTemplates) == null)
				{
					result = (this._ReferenceTemplates = new TArray<UObject>(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_ReferenceTemplates, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ReferenceTemplates.CopyAssign(value);
			}
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x00122CD0 File Offset: 0x00120ED0
		[SkipLocalsInit]
		public unsafe void Update(float DeltaSeconds = 0f)
		{
			USMInstance.__Update_FunctionParams* ptr = stackalloc USMInstance.__Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Update_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00122D18 File Offset: 0x00120F18
		[SkipLocalsInit]
		public unsafe virtual void Tick(float DeltaTime)
		{
			USMInstance.__Tick_FunctionParams* ptr = stackalloc USMInstance.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00122D60 File Offset: 0x00120F60
		[SkipLocalsInit]
		protected unsafe virtual void Tick_Implementation(float DeltaTime)
		{
			USMInstance.__Tick_FunctionParams* ptr = stackalloc USMInstance.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00122DA8 File Offset: 0x00120FA8
		[SkipLocalsInit]
		public unsafe bool TakeTransitionChain([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USMTransitionInstance> InTransitionChain)
		{
			USMInstance.__TakeTransitionChain_FunctionParams* ptr = stackalloc USMInstance.__TakeTransitionChain_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__TakeTransitionChain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__TakeTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMTransitionInstance> tarray = InTransitionChain;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTransitionChain);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__TakeTransitionChain_NativeFunctionPtr, (void*)ptr);
			TArray<USMTransitionInstance> tarray2 = InTransitionChain;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransitionChain);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__TakeTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x00122E28 File Offset: 0x00121028
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void SwitchActiveStateByQualifiedName(string InFullPath, bool bDeactivateOtherStates = true)
		{
			USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams* ptr = stackalloc USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InFullPath), InFullPath);
			ptr->bDeactivateOtherStates = bDeactivateOtherStates;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x00122E8C File Offset: 0x0012108C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SwitchActiveState(USMStateInstance_Base NewStateInstance, bool bDeactivateOtherStates = true)
		{
			USMInstance.__SwitchActiveState_FunctionParams* ptr = stackalloc USMInstance.__SwitchActiveState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__SwitchActiveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SwitchActiveState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewStateInstance = ((NewStateInstance != null) ? NewStateInstance.NativePtr : IntPtr.Zero);
			ptr->bDeactivateOtherStates = bDeactivateOtherStates;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SwitchActiveState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x00122EE8 File Offset: 0x001210E8
		[SkipLocalsInit]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x00122EFC File Offset: 0x001210FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void StartWithNewContext(UObject Context)
		{
			USMInstance.__StartWithNewContext_FunctionParams* ptr = stackalloc USMInstance.__StartWithNewContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__StartWithNewContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__StartWithNewContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__StartWithNewContext_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00122F51 File Offset: 0x00121151
		[SkipLocalsInit]
		public void Start()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00122F65 File Offset: 0x00121165
		[SkipLocalsInit]
		public void Shutdown()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Shutdown_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x00122F7C File Offset: 0x0012117C
		[SkipLocalsInit]
		public unsafe void SetTickOnManualUpdate(bool Value)
		{
			USMInstance.__SetTickOnManualUpdate_FunctionParams* ptr = stackalloc USMInstance.__SetTickOnManualUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetTickOnManualUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickOnManualUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x00122FC4 File Offset: 0x001211C4
		[SkipLocalsInit]
		public unsafe void SetTickInterval(float Value)
		{
			USMInstance.__SetTickInterval_FunctionParams* ptr = stackalloc USMInstance.__SetTickInterval_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__SetTickInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickInterval_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickInterval_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x0012300C File Offset: 0x0012120C
		[SkipLocalsInit]
		public unsafe void SetTickBeforeBeginPlay(bool Value)
		{
			USMInstance.__SetTickBeforeBeginPlay_FunctionParams* ptr = stackalloc USMInstance.__SetTickBeforeBeginPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetTickBeforeBeginPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickBeforeBeginPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickBeforeBeginPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x00123054 File Offset: 0x00121254
		[SkipLocalsInit]
		public unsafe void SetStopOnEndState(bool Value)
		{
			USMInstance.__SetStopOnEndState_FunctionParams* ptr = stackalloc USMInstance.__SetStopOnEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetStopOnEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStopOnEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStopOnEndState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x0012309C File Offset: 0x0012129C
		[SkipLocalsInit]
		public unsafe void SetStateMachineClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USMStateMachineInstance> NewStateMachineClass)
		{
			USMInstance.__SetStateMachineClass_FunctionParams* ptr = stackalloc USMInstance.__SetStateMachineClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__SetStateMachineClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStateMachineClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewStateMachineClass = NewStateMachineClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStateMachineClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x001230E4 File Offset: 0x001212E4
		[SkipLocalsInit]
		public unsafe void SetStateHistoryMaxCount(int NewSize)
		{
			USMInstance.__SetStateHistoryMaxCount_FunctionParams* ptr = stackalloc USMInstance.__SetStateHistoryMaxCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__SetStateHistoryMaxCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewSize = NewSize;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x0012312C File Offset: 0x0012132C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetGuidRedirectMap(in TMap<FGuid, FGuid> InGuidMap)
		{
			USMInstance.__SetGuidRedirectMap_FunctionParams* ptr = stackalloc USMInstance.__SetGuidRedirectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USMInstance.__SetGuidRedirectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FGuid, FGuid> tmap = InGuidMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InGuidMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr);
			TMap<FGuid, FGuid> tmap2 = InGuidMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InGuidMap);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x001231A4 File Offset: 0x001213A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetContext(UObject Context)
		{
			USMInstance.__SetContext_FunctionParams* ptr = stackalloc USMInstance.__SetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__SetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetContext_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x001231FC File Offset: 0x001213FC
		[SkipLocalsInit]
		public unsafe void SetCanTickWhenPaused(bool Value)
		{
			USMInstance.__SetCanTickWhenPaused_FunctionParams* ptr = stackalloc USMInstance.__SetCanTickWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetCanTickWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetCanTickWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetCanTickWhenPaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x00123244 File Offset: 0x00121444
		[SkipLocalsInit]
		public unsafe void SetCanEverTick(bool Value)
		{
			USMInstance.__SetCanEverTick_FunctionParams* ptr = stackalloc USMInstance.__SetCanEverTick_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetCanEverTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetCanEverTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetCanEverTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x0012328C File Offset: 0x0012148C
		[SkipLocalsInit]
		public unsafe void SetAutoManageTime(bool Value)
		{
			USMInstance.__SetAutoManageTime_FunctionParams* ptr = stackalloc USMInstance.__SetAutoManageTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetAutoManageTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetAutoManageTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetAutoManageTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001232D4 File Offset: 0x001214D4
		[SkipLocalsInit]
		public unsafe void RunUpdateAsReference(float DeltaSeconds)
		{
			USMInstance.__RunUpdateAsReference_FunctionParams* ptr = stackalloc USMInstance.__RunUpdateAsReference_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__RunUpdateAsReference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__RunUpdateAsReference_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__RunUpdateAsReference_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x0012331A File Offset: 0x0012151A
		[SkipLocalsInit]
		public void Restart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Restart_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x0012332E File Offset: 0x0012152E
		[SkipLocalsInit]
		public void ReplicatedStop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedStop_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x00123342 File Offset: 0x00121542
		[SkipLocalsInit]
		public void ReplicatedStart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedStart_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00123356 File Offset: 0x00121556
		[SkipLocalsInit]
		public void ReplicatedRestart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedRestart_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x0012336A File Offset: 0x0012156A
		[SkipLocalsInit]
		public void REP_OnReplicatedReferencesLoaded()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__REP_OnReplicatedReferencesLoaded_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x0012337E File Offset: 0x0012157E
		[SkipLocalsInit]
		public void PreloadAllNodeInstances()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__PreloadAllNodeInstances_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x00123394 File Offset: 0x00121594
		[SkipLocalsInit]
		public unsafe virtual void OnStateMachineUpdate(float DeltaSeconds)
		{
			USMInstance.__OnStateMachineUpdate_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__OnStateMachineUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x001233DC File Offset: 0x001215DC
		[SkipLocalsInit]
		protected unsafe virtual void OnStateMachineUpdate_Implementation(float DeltaSeconds)
		{
			USMInstance.__OnStateMachineUpdate_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__OnStateMachineUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x00123422 File Offset: 0x00121622
		[SkipLocalsInit]
		public virtual void OnStateMachineStop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStop_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x00123436 File Offset: 0x00121636
		[SkipLocalsInit]
		protected virtual void OnStateMachineStop_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStop_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x0012344A File Offset: 0x0012164A
		[SkipLocalsInit]
		public virtual void OnStateMachineStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStart_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x0012345E File Offset: 0x0012165E
		[SkipLocalsInit]
		protected virtual void OnStateMachineStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStart_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x00123474 File Offset: 0x00121674
		[SkipLocalsInit]
		public unsafe virtual void OnStateMachineInitialStateLoaded(in FGuid StateGuid)
		{
			USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateGuid = StateGuid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x001234C0 File Offset: 0x001216C0
		[SkipLocalsInit]
		protected unsafe virtual void OnStateMachineInitialStateLoaded_Implementation(in FGuid StateGuid)
		{
			USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateGuid = StateGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x0012350B File Offset: 0x0012170B
		[SkipLocalsInit]
		public virtual void OnStateMachineInitialized()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x0012351F File Offset: 0x0012171F
		[SkipLocalsInit]
		protected virtual void OnStateMachineInitialized_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x00123533 File Offset: 0x00121733
		[SkipLocalsInit]
		public virtual void OnPreStateMachineInitialized()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnPreStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x00123547 File Offset: 0x00121747
		[SkipLocalsInit]
		protected virtual void OnPreStateMachineInitialized_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnPreStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x0012355B File Offset: 0x0012175B
		[SkipLocalsInit]
		public virtual void OnPostCompile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnPostCompile_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x0012356F File Offset: 0x0012176F
		[SkipLocalsInit]
		protected virtual void OnPostCompile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnPostCompile_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x00123584 File Offset: 0x00121784
		[SkipLocalsInit]
		public unsafe void LoadFromState(in FGuid FromGuid, bool bAllParents = true, bool bNotify = true)
		{
			USMInstance.__LoadFromState_FunctionParams* ptr = stackalloc USMInstance.__LoadFromState_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__LoadFromState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__LoadFromState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FromGuid = FromGuid;
			ptr->bAllParents = bAllParents;
			ptr->bNotify = bNotify;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__LoadFromState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x001235E0 File Offset: 0x001217E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void LoadFromMultipleStates(in TArray<FGuid> FromGuids, bool bNotify = true)
		{
			USMInstance.__LoadFromMultipleStates_FunctionParams* ptr = stackalloc USMInstance.__LoadFromMultipleStates_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__LoadFromMultipleStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__LoadFromMultipleStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = FromGuids;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FromGuids);
			}
			ptr->bNotify = bNotify;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__LoadFromMultipleStates_NativeFunctionPtr, (void*)ptr);
			TArray<FGuid> tarray2 = FromGuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FromGuids);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__LoadFromMultipleStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x00123660 File Offset: 0x00121860
		[SkipLocalsInit]
		public unsafe bool IsTickableWhenPaused()
		{
			USMInstance.__IsTickableWhenPaused_FunctionParams* ptr = stackalloc USMInstance.__IsTickableWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsTickableWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsTickableWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsTickableWhenPaused_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x001236A8 File Offset: 0x001218A8
		[SkipLocalsInit]
		public unsafe bool IsTickable()
		{
			USMInstance.__IsTickable_FunctionParams* ptr = stackalloc USMInstance.__IsTickable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsTickable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsTickable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsTickable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x001236F0 File Offset: 0x001218F0
		[SkipLocalsInit]
		public unsafe bool IsInitialized()
		{
			USMInstance.__IsInitialized_FunctionParams* ptr = stackalloc USMInstance.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsInitialized_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x00123738 File Offset: 0x00121938
		[SkipLocalsInit]
		public unsafe bool IsInEndState()
		{
			USMInstance.__IsInEndState_FunctionParams* ptr = stackalloc USMInstance.__IsInEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsInEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x00123780 File Offset: 0x00121980
		[SkipLocalsInit]
		public unsafe bool IsActive()
		{
			USMInstance.__IsActive_FunctionParams* ptr = stackalloc USMInstance.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsActive_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x001237C8 File Offset: 0x001219C8
		[SkipLocalsInit]
		public unsafe void Internal_Update(float DeltaSeconds)
		{
			USMInstance.__Internal_Update_FunctionParams* ptr = stackalloc USMInstance.__Internal_Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Internal_Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_Update_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6D2 RID: 46802 RVA: 0x0012380E File Offset: 0x00121A0E
		[SkipLocalsInit]
		public void Internal_EventUpdate()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EventUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00123824 File Offset: 0x00121A24
		[SkipLocalsInit]
		public unsafe void Internal_EventCleanup(in FGuid PathGuid)
		{
			USMInstance.__Internal_EventCleanup_FunctionParams* ptr = stackalloc USMInstance.__Internal_EventCleanup_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__Internal_EventCleanup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_EventCleanup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PathGuid = PathGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EventCleanup_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x00123870 File Offset: 0x00121A70
		[SkipLocalsInit]
		public unsafe bool Internal_EvaluateAndTakeTransitionChainByGuid(in FGuid PathGuid)
		{
			USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams* ptr = stackalloc USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PathGuid = PathGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001238C4 File Offset: 0x00121AC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Initialize(UObject Context)
		{
			USMInstance.__Initialize_FunctionParams* ptr = stackalloc USMInstance.__Initialize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Initialize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x0012391C File Offset: 0x00121B1C
		[SkipLocalsInit]
		public unsafe bool HasStarted()
		{
			USMInstance.__HasStarted_FunctionParams* ptr = stackalloc USMInstance.__HasStarted_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__HasStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__HasStarted_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__HasStarted_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x00123964 File Offset: 0x00121B64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMTransitionInstance GetTransitionInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetTransitionInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetTransitionInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetTransitionInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetTransitionInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetTransitionInstanceByGuid_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x001239BC File Offset: 0x00121BBC
		[SkipLocalsInit]
		public unsafe float GetTickInterval()
		{
			USMInstance.__GetTickInterval_FunctionParams* ptr = stackalloc USMInstance.__GetTickInterval_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__GetTickInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetTickInterval_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetTickInterval_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x00123A04 File Offset: 0x00121C04
		[SkipLocalsInit]
		public unsafe bool GetStopOnEndState()
		{
			USMInstance.__GetStopOnEndState_FunctionParams* ptr = stackalloc USMInstance.__GetStopOnEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__GetStopOnEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStopOnEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStopOnEndState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x00123A4C File Offset: 0x00121C4C
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USMStateMachineInstance> GetStateMachineClass()
		{
			USMInstance.__GetStateMachineClass_FunctionParams* ptr = stackalloc USMInstance.__GetStateMachineClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetStateMachineClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateMachineClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateMachineClass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x00123A94 File Offset: 0x00121C94
		[NullableContext(1)]
		[SkipLocalsInit]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetStateInstanceByQualifiedName(string InFullPath)
		{
			USMInstance.__GetStateInstanceByQualifiedName_FunctionParams* ptr = stackalloc USMInstance.__GetStateInstanceByQualifiedName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetStateInstanceByQualifiedName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InFullPath), InFullPath);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x00123AFC File Offset: 0x00121CFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetStateInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetStateInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetStateInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetStateInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateInstanceByGuid_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x00123B54 File Offset: 0x00121D54
		[SkipLocalsInit]
		public unsafe int GetStateHistoryMaxCount()
		{
			USMInstance.__GetStateHistoryMaxCount_FunctionParams* ptr = stackalloc USMInstance.__GetStateHistoryMaxCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__GetStateHistoryMaxCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x00123B9C File Offset: 0x00121D9C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetSingleActiveStateInstance(bool bCheckNested = true)
		{
			USMInstance.__GetSingleActiveStateInstance_FunctionParams* ptr = stackalloc USMInstance.__GetSingleActiveStateInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetSingleActiveStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetSingleActiveStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetSingleActiveStateInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x00123BF0 File Offset: 0x00121DF0
		[SkipLocalsInit]
		public unsafe FGuid GetSingleActiveStateGuid(bool bCheckNested = true)
		{
			USMInstance.__GetSingleActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetSingleActiveStateGuid_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__GetSingleActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetSingleActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetSingleActiveStateGuid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x00123C3C File Offset: 0x00121E3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateMachineInstance GetRootStateMachineNodeInstance()
		{
			USMInstance.__GetRootStateMachineNodeInstance_FunctionParams* ptr = stackalloc USMInstance.__GetRootStateMachineNodeInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetRootStateMachineNodeInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetRootStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetRootStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x00123C88 File Offset: 0x00121E88
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateMachineInstance GetRootStateMachineInstance()
		{
			USMInstance.__GetRootStateMachineInstance_FunctionParams* ptr = stackalloc USMInstance.__GetRootStateMachineInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetRootStateMachineInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetRootStateMachineInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetRootStateMachineInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00123CD4 File Offset: 0x00121ED4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetReferenceOwner()
		{
			USMInstance.__GetReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetReferenceOwner_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x00123D20 File Offset: 0x00121F20
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetReferencedInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetReferencedInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetReferencedInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetReferencedInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetReferencedInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetReferencedInstanceByGuid_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x00123D78 File Offset: 0x00121F78
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetPrimaryReferenceOwner()
		{
			USMInstance.__GetPrimaryReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetPrimaryReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetPrimaryReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetPrimaryReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetPrimaryReferenceOwner_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00123DC4 File Offset: 0x00121FC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMNodeInstance GetNodeInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetNodeInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetNodeInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetNodeInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNodeInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNodeInstanceByGuid_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMNodeInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x00123E1C File Offset: 0x0012201C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string GetNestedActiveStateName()
		{
			USMInstance.__GetNestedActiveStateName_FunctionParams* ptr = stackalloc USMInstance.__GetNestedActiveStateName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetNestedActiveStateName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x00123E78 File Offset: 0x00122078
		[SkipLocalsInit]
		public unsafe FGuid GetNestedActiveStateGuid()
		{
			USMInstance.__GetNestedActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetNestedActiveStateGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetNestedActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNestedActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNestedActiveStateGuid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x00123EC0 File Offset: 0x001220C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetMasterReferenceOwner()
		{
			USMInstance.__GetMasterReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetMasterReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetMasterReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetMasterReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetMasterReferenceOwner_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00123F0C File Offset: 0x0012210C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FGuid, FGuid> GetGuidRedirectMap()
		{
			USMInstance.__GetGuidRedirectMap_FunctionParams* ptr = stackalloc USMInstance.__GetGuidRedirectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USMInstance.__GetGuidRedirectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr);
			TMap<FGuid, FGuid> result = new TMap<FGuid, FGuid>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x00123F6C File Offset: 0x0012216C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UObject GetContext()
		{
			USMInstance.__GetContext_FunctionParams* ptr = stackalloc USMInstance.__GetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetContext_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00123FB8 File Offset: 0x001221B8
		[SkipLocalsInit]
		public unsafe void GetAllTransitionInstances([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMTransitionInstance> TransitionInstances)
		{
			USMInstance.__GetAllTransitionInstances_FunctionParams* ptr = stackalloc USMInstance.__GetAllTransitionInstances_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllTransitionInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllTransitionInstances_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMTransitionInstance> tarray = TransitionInstances;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TransitionInstances);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllTransitionInstances_NativeFunctionPtr, (void*)ptr);
			TArray<USMTransitionInstance> tarray2 = TransitionInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TransitionInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllTransitionInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x00124030 File Offset: 0x00122230
		[SkipLocalsInit]
		public unsafe void GetAllStateInstances([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateInstance_Base> StateInstances)
		{
			USMInstance.__GetAllStateInstances_FunctionParams* ptr = stackalloc USMInstance.__GetAllStateInstances_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllStateInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateInstance_Base> tarray = StateInstances;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StateInstances);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateInstance_Base> tarray2 = StateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x001240A8 File Offset: 0x001222A8
		[SkipLocalsInit]
		public unsafe void GetAllRootNodeInstance([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateMachineInstance> Nodes)
		{
			USMInstance.__GetAllRootNodeInstance_FunctionParams* ptr = stackalloc USMInstance.__GetAllRootNodeInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllRootNodeInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllRootNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateMachineInstance> tarray = Nodes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Nodes);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllRootNodeInstance_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateMachineInstance> tarray2 = Nodes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Nodes);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllRootNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x00124120 File Offset: 0x00122320
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<USMInstance> GetAllReferencedInstances(bool bIncludeChildren = false)
		{
			USMInstance.__GetAllReferencedInstances_FunctionParams* ptr = stackalloc USMInstance.__GetAllReferencedInstances_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetAllReferencedInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIncludeChildren = bIncludeChildren;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr);
			TArray<USMInstance> result = new TArray<USMInstance>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x00124188 File Offset: 0x00122388
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FGuid> GetAllCurrentStateGuids()
		{
			USMInstance.__GetAllCurrentStateGuids_FunctionParams* ptr = stackalloc USMInstance.__GetAllCurrentStateGuids_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllCurrentStateGuids_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr);
			TArray<FGuid> result = new TArray<FGuid>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x001241E8 File Offset: 0x001223E8
		[SkipLocalsInit]
		public unsafe void GetAllActiveStateInstances([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateInstance_Base> ActiveStateInstances)
		{
			USMInstance.__GetAllActiveStateInstances_FunctionParams* ptr = stackalloc USMInstance.__GetAllActiveStateInstances_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllActiveStateInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllActiveStateInstances_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateInstance_Base> tarray = ActiveStateInstances;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ActiveStateInstances);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllActiveStateInstances_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateInstance_Base> tarray2 = ActiveStateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveStateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllActiveStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x00124260 File Offset: 0x00122460
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void GetAllActiveStateGuids(ref TArray<FGuid> ActiveGuids)
		{
			USMInstance.__GetAllActiveStateGuids_FunctionParams* ptr = stackalloc USMInstance.__GetAllActiveStateGuids_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllActiveStateGuids_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = ActiveGuids;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ActiveGuids);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr);
			TArray<FGuid> tarray2 = ActiveGuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveGuids);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x001242D8 File Offset: 0x001224D8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string GetActiveStateName()
		{
			USMInstance.__GetActiveStateName_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x00124334 File Offset: 0x00122534
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetActiveStateInstance(bool bCheckNested = true)
		{
			USMInstance.__GetActiveStateInstance_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x00124388 File Offset: 0x00122588
		[SkipLocalsInit]
		public unsafe FGuid GetActiveStateGuid()
		{
			USMInstance.__GetActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateGuid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x001243CD File Offset: 0x001225CD
		[SkipLocalsInit]
		public void EvaluateTransitions()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateTransitions_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x001243E4 File Offset: 0x001225E4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool EvaluateAndTakeTransitionChain(USMTransitionInstance InFirstTransitionInstance)
		{
			USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams* ptr = stackalloc USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__EvaluateAndTakeTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFirstTransitionInstance = ((InFirstTransitionInstance != null) ? InFirstTransitionInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateAndTakeTransitionChain_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00124440 File Offset: 0x00122640
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool EvaluateAndFindTransitionChain(USMTransitionInstance InFirstTransitionInstance, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMTransitionInstance> OutTransitionChain, ref USMStateInstance_Base OutDestinationState, bool bRequirePreviousStateActive = true)
		{
			USMInstance.__EvaluateAndFindTransitionChain_FunctionParams* ptr = stackalloc USMInstance.__EvaluateAndFindTransitionChain_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(USMInstance.__EvaluateAndFindTransitionChain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__EvaluateAndFindTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFirstTransitionInstance = ((InFirstTransitionInstance != null) ? InFirstTransitionInstance.NativePtr : IntPtr.Zero);
			TArray<USMTransitionInstance> tarray = OutTransitionChain;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTransitionChain);
			}
			ref USMInstance.__EvaluateAndFindTransitionChain_FunctionParams ptr2 = ref *ptr;
			USMStateInstance_Base usmstateInstance_Base = OutDestinationState;
			ptr2.OutDestinationState = ((usmstateInstance_Base != null) ? usmstateInstance_Base.NativePtr : IntPtr.Zero);
			ptr->bRequirePreviousStateActive = bRequirePreviousStateActive;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateAndFindTransitionChain_NativeFunctionPtr, (void*)ptr);
			TArray<USMTransitionInstance> tarray2 = OutTransitionChain;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTransitionChain);
			}
			OutDestinationState = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->OutDestinationState);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__EvaluateAndFindTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x00124501 File Offset: 0x00122701
		[SkipLocalsInit]
		public void ClearStateHistory()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ClearStateHistory_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00124515 File Offset: 0x00122715
		[SkipLocalsInit]
		public void ClearLoadedStates()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ClearLoadedStates_NativeFunctionPtr, null);
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x0012452C File Offset: 0x0012272C
		[SkipLocalsInit]
		public unsafe bool CanTickOnManualUpdate()
		{
			USMInstance.__CanTickOnManualUpdate_FunctionParams* ptr = stackalloc USMInstance.__CanTickOnManualUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanTickOnManualUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanTickOnManualUpdate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x00124574 File Offset: 0x00122774
		[SkipLocalsInit]
		public unsafe bool CanEverTick()
		{
			USMInstance.__CanEverTick_FunctionParams* ptr = stackalloc USMInstance.__CanEverTick_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanEverTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanEverTick_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanEverTick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x001245BC File Offset: 0x001227BC
		[SkipLocalsInit]
		public unsafe bool CanAutoManageTime()
		{
			USMInstance.__CanAutoManageTime_FunctionParams* ptr = stackalloc USMInstance.__CanAutoManageTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanAutoManageTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanAutoManageTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanAutoManageTime_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x00124604 File Offset: 0x00122804
		[SkipLocalsInit]
		public unsafe bool AreInitialStatesSetFromLoad()
		{
			USMInstance.__AreInitialStatesSetFromLoad_FunctionParams* ptr = stackalloc USMInstance.__AreInitialStatesSetFromLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__AreInitialStatesSetFromLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__AreInitialStatesSetFromLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__AreInitialStatesSetFromLoad_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00124649 File Offset: 0x00122849
		static USMInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMInstance");
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00124657 File Offset: 0x00122857
		protected USMInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005274 RID: 21108
		internal static int __InterfaceOffset_ISMInstanceInterface;

		// Token: 0x04005275 RID: 21109
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMInstance";

		// Token: 0x04005276 RID: 21110
		private static IntPtr _ClassPtr;

		// Token: 0x04005277 RID: 21111
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005278 RID: 21112
		internal static int __PropertyOffset_RootStateMachineGuid;

		// Token: 0x04005279 RID: 21113
		internal static int __PropertyOffset_AllRootNodeInstances;

		// Token: 0x0400527A RID: 21114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateMachineInstance> _AllRootNodeInstances;

		// Token: 0x0400527B RID: 21115
		internal static int __PropertyOffset_OnPreStateMachineInitializedEvent;

		// Token: 0x0400527C RID: 21116
		[Nullable(2)]
		private FOnStateMachineInitializedSignature _OnPreStateMachineInitializedEvent;

		// Token: 0x0400527D RID: 21117
		internal static int __PropertyOffset_OnStateMachineInitializedEvent;

		// Token: 0x0400527E RID: 21118
		[Nullable(2)]
		private FOnStateMachineInitializedSignature _OnStateMachineInitializedEvent;

		// Token: 0x0400527F RID: 21119
		internal static int __PropertyOffset_OnStateMachineStartedEvent;

		// Token: 0x04005280 RID: 21120
		[Nullable(2)]
		private FOnStateMachineStartedSignature _OnStateMachineStartedEvent;

		// Token: 0x04005281 RID: 21121
		internal static int __PropertyOffset_OnStateMachineUpdatedEvent;

		// Token: 0x04005282 RID: 21122
		[Nullable(2)]
		private FOnStateMachineUpdatedSignature _OnStateMachineUpdatedEvent;

		// Token: 0x04005283 RID: 21123
		internal static int __PropertyOffset_OnStateMachineStoppedEvent;

		// Token: 0x04005284 RID: 21124
		[Nullable(2)]
		private FOnStateMachineStoppedSignature _OnStateMachineStoppedEvent;

		// Token: 0x04005285 RID: 21125
		internal static int __PropertyOffset_R_StateMachineContext;

		// Token: 0x04005286 RID: 21126
		internal static int __PropertyOffset_ReferenceOwner;

		// Token: 0x04005287 RID: 21127
		internal static int __PropertyOffset_StateMachineClass;

		// Token: 0x04005288 RID: 21128
		internal static int __PropertyOffset_bAutoManageTime;

		// Token: 0x04005289 RID: 21129
		internal static byte __PropertyMask_bAutoManageTime;

		// Token: 0x0400528A RID: 21130
		internal static int __PropertyOffset_bStopOnEndState;

		// Token: 0x0400528B RID: 21131
		internal static byte __PropertyMask_bStopOnEndState;

		// Token: 0x0400528C RID: 21132
		internal static int __PropertyOffset_bCanEverTick;

		// Token: 0x0400528D RID: 21133
		internal static byte __PropertyMask_bCanEverTick;

		// Token: 0x0400528E RID: 21134
		internal static int __PropertyOffset_bCanTickWhenPaused;

		// Token: 0x0400528F RID: 21135
		internal static byte __PropertyMask_bCanTickWhenPaused;

		// Token: 0x04005290 RID: 21136
		internal static int __PropertyOffset_bTickRegistered;

		// Token: 0x04005291 RID: 21137
		internal static byte __PropertyMask_bTickRegistered;

		// Token: 0x04005292 RID: 21138
		internal static int __PropertyOffset_bTickBeforeInitialize;

		// Token: 0x04005293 RID: 21139
		internal static byte __PropertyMask_bTickBeforeInitialize;

		// Token: 0x04005294 RID: 21140
		internal static int __PropertyOffset_bTickBeforeBeginPlay;

		// Token: 0x04005295 RID: 21141
		internal static byte __PropertyMask_bTickBeforeBeginPlay;

		// Token: 0x04005296 RID: 21142
		internal static int __PropertyOffset_TickInterval;

		// Token: 0x04005297 RID: 21143
		internal static int __PropertyOffset_StateHistoryMaxCount;

		// Token: 0x04005298 RID: 21144
		internal static int __PropertyOffset_bEnableLogging;

		// Token: 0x04005299 RID: 21145
		internal static byte __PropertyMask_bEnableLogging;

		// Token: 0x0400529A RID: 21146
		internal static int __PropertyOffset_bLogStateChange;

		// Token: 0x0400529B RID: 21147
		internal static byte __PropertyMask_bLogStateChange;

		// Token: 0x0400529C RID: 21148
		internal static int __PropertyOffset_bLogTransitionTaken;

		// Token: 0x0400529D RID: 21149
		internal static byte __PropertyMask_bLogTransitionTaken;

		// Token: 0x0400529E RID: 21150
		internal static int __PropertyOffset_bCanReplicateAsReference;

		// Token: 0x0400529F RID: 21151
		internal static byte __PropertyMask_bCanReplicateAsReference;

		// Token: 0x040052A0 RID: 21152
		internal static int __PropertyOffset_PathGuidRedirectMap;

		// Token: 0x040052A1 RID: 21153
		[Nullable(2)]
		private TMap<FGuid, FGuid> _PathGuidRedirectMap;

		// Token: 0x040052A2 RID: 21154
		internal static int __PropertyOffset_ReferenceTemplates;

		// Token: 0x040052A3 RID: 21155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceTemplates;

		// Token: 0x040052A4 RID: 21156
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x040052A5 RID: 21157
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x040052A6 RID: 21158
		private static IntPtr __TakeTransitionChain_NativeFunctionPtr;

		// Token: 0x040052A7 RID: 21159
		private static IntPtr __SwitchActiveStateByQualifiedName_NativeFunctionPtr;

		// Token: 0x040052A8 RID: 21160
		private static IntPtr __SwitchActiveState_NativeFunctionPtr;

		// Token: 0x040052A9 RID: 21161
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x040052AA RID: 21162
		private static IntPtr __StartWithNewContext_NativeFunctionPtr;

		// Token: 0x040052AB RID: 21163
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x040052AC RID: 21164
		private static IntPtr __Shutdown_NativeFunctionPtr;

		// Token: 0x040052AD RID: 21165
		private static IntPtr __SetTickOnManualUpdate_NativeFunctionPtr;

		// Token: 0x040052AE RID: 21166
		private static IntPtr __SetTickInterval_NativeFunctionPtr;

		// Token: 0x040052AF RID: 21167
		private static IntPtr __SetTickBeforeBeginPlay_NativeFunctionPtr;

		// Token: 0x040052B0 RID: 21168
		private static IntPtr __SetStopOnEndState_NativeFunctionPtr;

		// Token: 0x040052B1 RID: 21169
		private static IntPtr __SetStateMachineClass_NativeFunctionPtr;

		// Token: 0x040052B2 RID: 21170
		private static IntPtr __SetStateHistoryMaxCount_NativeFunctionPtr;

		// Token: 0x040052B3 RID: 21171
		private static IntPtr __SetGuidRedirectMap_NativeFunctionPtr;

		// Token: 0x040052B4 RID: 21172
		private static IntPtr __SetContext_NativeFunctionPtr;

		// Token: 0x040052B5 RID: 21173
		private static IntPtr __SetCanTickWhenPaused_NativeFunctionPtr;

		// Token: 0x040052B6 RID: 21174
		private static IntPtr __SetCanEverTick_NativeFunctionPtr;

		// Token: 0x040052B7 RID: 21175
		private static IntPtr __SetAutoManageTime_NativeFunctionPtr;

		// Token: 0x040052B8 RID: 21176
		private static IntPtr __RunUpdateAsReference_NativeFunctionPtr;

		// Token: 0x040052B9 RID: 21177
		private static IntPtr __Restart_NativeFunctionPtr;

		// Token: 0x040052BA RID: 21178
		private static IntPtr __ReplicatedStop_NativeFunctionPtr;

		// Token: 0x040052BB RID: 21179
		private static IntPtr __ReplicatedStart_NativeFunctionPtr;

		// Token: 0x040052BC RID: 21180
		private static IntPtr __ReplicatedRestart_NativeFunctionPtr;

		// Token: 0x040052BD RID: 21181
		private static IntPtr __REP_OnReplicatedReferencesLoaded_NativeFunctionPtr;

		// Token: 0x040052BE RID: 21182
		private static IntPtr __PreloadAllNodeInstances_NativeFunctionPtr;

		// Token: 0x040052BF RID: 21183
		private static IntPtr __OnStateMachineUpdate_NativeFunctionPtr;

		// Token: 0x040052C0 RID: 21184
		private static IntPtr __OnStateMachineStop_NativeFunctionPtr;

		// Token: 0x040052C1 RID: 21185
		private static IntPtr __OnStateMachineStart_NativeFunctionPtr;

		// Token: 0x040052C2 RID: 21186
		private static IntPtr __OnStateMachineInitialStateLoaded_NativeFunctionPtr;

		// Token: 0x040052C3 RID: 21187
		private static IntPtr __OnStateMachineInitialized_NativeFunctionPtr;

		// Token: 0x040052C4 RID: 21188
		private static IntPtr __OnPreStateMachineInitialized_NativeFunctionPtr;

		// Token: 0x040052C5 RID: 21189
		private static IntPtr __OnPostCompile_NativeFunctionPtr;

		// Token: 0x040052C6 RID: 21190
		private static IntPtr __LoadFromState_NativeFunctionPtr;

		// Token: 0x040052C7 RID: 21191
		private static IntPtr __LoadFromMultipleStates_NativeFunctionPtr;

		// Token: 0x040052C8 RID: 21192
		private static IntPtr __IsTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x040052C9 RID: 21193
		private static IntPtr __IsTickable_NativeFunctionPtr;

		// Token: 0x040052CA RID: 21194
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x040052CB RID: 21195
		private static IntPtr __IsInEndState_NativeFunctionPtr;

		// Token: 0x040052CC RID: 21196
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x040052CD RID: 21197
		private static IntPtr __Internal_Update_NativeFunctionPtr;

		// Token: 0x040052CE RID: 21198
		private static IntPtr __Internal_EventUpdate_NativeFunctionPtr;

		// Token: 0x040052CF RID: 21199
		private static IntPtr __Internal_EventCleanup_NativeFunctionPtr;

		// Token: 0x040052D0 RID: 21200
		private static IntPtr __Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr;

		// Token: 0x040052D1 RID: 21201
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040052D2 RID: 21202
		private static IntPtr __HasStarted_NativeFunctionPtr;

		// Token: 0x040052D3 RID: 21203
		private static IntPtr __GetTransitionInstanceByGuid_NativeFunctionPtr;

		// Token: 0x040052D4 RID: 21204
		private static IntPtr __GetTickInterval_NativeFunctionPtr;

		// Token: 0x040052D5 RID: 21205
		private static IntPtr __GetStopOnEndState_NativeFunctionPtr;

		// Token: 0x040052D6 RID: 21206
		private static IntPtr __GetStateMachineClass_NativeFunctionPtr;

		// Token: 0x040052D7 RID: 21207
		private static IntPtr __GetStateInstanceByQualifiedName_NativeFunctionPtr;

		// Token: 0x040052D8 RID: 21208
		private static IntPtr __GetStateInstanceByGuid_NativeFunctionPtr;

		// Token: 0x040052D9 RID: 21209
		private static IntPtr __GetStateHistoryMaxCount_NativeFunctionPtr;

		// Token: 0x040052DA RID: 21210
		private static IntPtr __GetSingleActiveStateInstance_NativeFunctionPtr;

		// Token: 0x040052DB RID: 21211
		private static IntPtr __GetSingleActiveStateGuid_NativeFunctionPtr;

		// Token: 0x040052DC RID: 21212
		private static IntPtr __GetRootStateMachineNodeInstance_NativeFunctionPtr;

		// Token: 0x040052DD RID: 21213
		private static IntPtr __GetRootStateMachineInstance_NativeFunctionPtr;

		// Token: 0x040052DE RID: 21214
		private static IntPtr __GetReferenceOwner_NativeFunctionPtr;

		// Token: 0x040052DF RID: 21215
		private static IntPtr __GetReferencedInstanceByGuid_NativeFunctionPtr;

		// Token: 0x040052E0 RID: 21216
		private static IntPtr __GetPrimaryReferenceOwner_NativeFunctionPtr;

		// Token: 0x040052E1 RID: 21217
		private static IntPtr __GetNodeInstanceByGuid_NativeFunctionPtr;

		// Token: 0x040052E2 RID: 21218
		private static IntPtr __GetNestedActiveStateName_NativeFunctionPtr;

		// Token: 0x040052E3 RID: 21219
		private static IntPtr __GetNestedActiveStateGuid_NativeFunctionPtr;

		// Token: 0x040052E4 RID: 21220
		private static IntPtr __GetMasterReferenceOwner_NativeFunctionPtr;

		// Token: 0x040052E5 RID: 21221
		private static IntPtr __GetGuidRedirectMap_NativeFunctionPtr;

		// Token: 0x040052E6 RID: 21222
		private static IntPtr __GetContext_NativeFunctionPtr;

		// Token: 0x040052E7 RID: 21223
		private static IntPtr __GetAllTransitionInstances_NativeFunctionPtr;

		// Token: 0x040052E8 RID: 21224
		private static IntPtr __GetAllStateInstances_NativeFunctionPtr;

		// Token: 0x040052E9 RID: 21225
		private static IntPtr __GetAllRootNodeInstance_NativeFunctionPtr;

		// Token: 0x040052EA RID: 21226
		private static IntPtr __GetAllReferencedInstances_NativeFunctionPtr;

		// Token: 0x040052EB RID: 21227
		private static IntPtr __GetAllCurrentStateGuids_NativeFunctionPtr;

		// Token: 0x040052EC RID: 21228
		private static IntPtr __GetAllActiveStateInstances_NativeFunctionPtr;

		// Token: 0x040052ED RID: 21229
		private static IntPtr __GetAllActiveStateGuids_NativeFunctionPtr;

		// Token: 0x040052EE RID: 21230
		private static IntPtr __GetActiveStateName_NativeFunctionPtr;

		// Token: 0x040052EF RID: 21231
		private static IntPtr __GetActiveStateInstance_NativeFunctionPtr;

		// Token: 0x040052F0 RID: 21232
		private static IntPtr __GetActiveStateGuid_NativeFunctionPtr;

		// Token: 0x040052F1 RID: 21233
		private static IntPtr __EvaluateTransitions_NativeFunctionPtr;

		// Token: 0x040052F2 RID: 21234
		private static IntPtr __EvaluateAndTakeTransitionChain_NativeFunctionPtr;

		// Token: 0x040052F3 RID: 21235
		private static IntPtr __EvaluateAndFindTransitionChain_NativeFunctionPtr;

		// Token: 0x040052F4 RID: 21236
		private static IntPtr __ClearStateHistory_NativeFunctionPtr;

		// Token: 0x040052F5 RID: 21237
		private static IntPtr __ClearLoadedStates_NativeFunctionPtr;

		// Token: 0x040052F6 RID: 21238
		private static IntPtr __CanTickOnManualUpdate_NativeFunctionPtr;

		// Token: 0x040052F7 RID: 21239
		private static IntPtr __CanEverTick_NativeFunctionPtr;

		// Token: 0x040052F8 RID: 21240
		private static IntPtr __CanAutoManageTime_NativeFunctionPtr;

		// Token: 0x040052F9 RID: 21241
		private static IntPtr __AreInitialStatesSetFromLoad_NativeFunctionPtr;

		// Token: 0x02001348 RID: 4936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04006788 RID: 26504
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02001349 RID: 4937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04006789 RID: 26505
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200134A RID: 4938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TakeTransitionChain_FunctionParams
		{
			// Token: 0x0400678A RID: 26506
			[FieldOffset(0)]
			public byte InTransitionChain;

			// Token: 0x0400678B RID: 26507
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200134B RID: 4939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SwitchActiveStateByQualifiedName_FunctionParams
		{
			// Token: 0x0400678C RID: 26508
			[FieldOffset(0)]
			public FString InFullPath;

			// Token: 0x0400678D RID: 26509
			[FieldOffset(16)]
			public bool bDeactivateOtherStates;
		}

		// Token: 0x0200134C RID: 4940
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchActiveState_FunctionParams
		{
			// Token: 0x0400678E RID: 26510
			[FieldOffset(0)]
			public IntPtr NewStateInstance;

			// Token: 0x0400678F RID: 26511
			[FieldOffset(8)]
			public bool bDeactivateOtherStates;
		}

		// Token: 0x0200134D RID: 4941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartWithNewContext_FunctionParams
		{
			// Token: 0x04006790 RID: 26512
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x0200134E RID: 4942
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickOnManualUpdate_FunctionParams
		{
			// Token: 0x04006791 RID: 26513
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x0200134F RID: 4943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetTickInterval_FunctionParams
		{
			// Token: 0x04006792 RID: 26514
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02001350 RID: 4944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickBeforeBeginPlay_FunctionParams
		{
			// Token: 0x04006793 RID: 26515
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02001351 RID: 4945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetStopOnEndState_FunctionParams
		{
			// Token: 0x04006794 RID: 26516
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02001352 RID: 4946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStateMachineClass_FunctionParams
		{
			// Token: 0x04006795 RID: 26517
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMStateMachineInstance> NewStateMachineClass;
		}

		// Token: 0x02001353 RID: 4947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetStateHistoryMaxCount_FunctionParams
		{
			// Token: 0x04006796 RID: 26518
			[FieldOffset(0)]
			public int NewSize;
		}

		// Token: 0x02001354 RID: 4948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetGuidRedirectMap_FunctionParams
		{
			// Token: 0x04006797 RID: 26519
			[FieldOffset(0)]
			public byte InGuidMap;
		}

		// Token: 0x02001355 RID: 4949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetContext_FunctionParams
		{
			// Token: 0x04006798 RID: 26520
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02001356 RID: 4950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanTickWhenPaused_FunctionParams
		{
			// Token: 0x04006799 RID: 26521
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02001357 RID: 4951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEverTick_FunctionParams
		{
			// Token: 0x0400679A RID: 26522
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02001358 RID: 4952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAutoManageTime_FunctionParams
		{
			// Token: 0x0400679B RID: 26523
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02001359 RID: 4953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RunUpdateAsReference_FunctionParams
		{
			// Token: 0x0400679C RID: 26524
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200135A RID: 4954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnStateMachineUpdate_FunctionParams
		{
			// Token: 0x0400679D RID: 26525
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200135B RID: 4955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStateMachineInitialStateLoaded_FunctionParams
		{
			// Token: 0x0400679E RID: 26526
			[FieldOffset(0)]
			public FGuid StateGuid;
		}

		// Token: 0x0200135C RID: 4956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LoadFromState_FunctionParams
		{
			// Token: 0x0400679F RID: 26527
			[FieldOffset(0)]
			public FGuid FromGuid;

			// Token: 0x040067A0 RID: 26528
			[FieldOffset(16)]
			public bool bAllParents;

			// Token: 0x040067A1 RID: 26529
			[FieldOffset(17)]
			public bool bNotify;
		}

		// Token: 0x0200135D RID: 4957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __LoadFromMultipleStates_FunctionParams
		{
			// Token: 0x040067A2 RID: 26530
			[FieldOffset(0)]
			public byte FromGuids;

			// Token: 0x040067A3 RID: 26531
			[FieldOffset(16)]
			public bool bNotify;
		}

		// Token: 0x0200135E RID: 4958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTickableWhenPaused_FunctionParams
		{
			// Token: 0x040067A4 RID: 26532
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200135F RID: 4959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTickable_FunctionParams
		{
			// Token: 0x040067A5 RID: 26533
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001360 RID: 4960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x040067A6 RID: 26534
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001361 RID: 4961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInEndState_FunctionParams
		{
			// Token: 0x040067A7 RID: 26535
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001362 RID: 4962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x040067A8 RID: 26536
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001363 RID: 4963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Internal_Update_FunctionParams
		{
			// Token: 0x040067A9 RID: 26537
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02001364 RID: 4964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Internal_EventCleanup_FunctionParams
		{
			// Token: 0x040067AA RID: 26538
			[FieldOffset(0)]
			public FGuid PathGuid;
		}

		// Token: 0x02001365 RID: 4965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams
		{
			// Token: 0x040067AB RID: 26539
			[FieldOffset(0)]
			public FGuid PathGuid;

			// Token: 0x040067AC RID: 26540
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02001366 RID: 4966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x040067AD RID: 26541
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02001367 RID: 4967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasStarted_FunctionParams
		{
			// Token: 0x040067AE RID: 26542
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001368 RID: 4968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetTransitionInstanceByGuid_FunctionParams
		{
			// Token: 0x040067AF RID: 26543
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x040067B0 RID: 26544
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02001369 RID: 4969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTickInterval_FunctionParams
		{
			// Token: 0x040067B1 RID: 26545
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200136A RID: 4970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetStopOnEndState_FunctionParams
		{
			// Token: 0x040067B2 RID: 26546
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200136B RID: 4971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStateMachineClass_FunctionParams
		{
			// Token: 0x040067B3 RID: 26547
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMStateMachineInstance> __Result;
		}

		// Token: 0x0200136C RID: 4972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetStateInstanceByQualifiedName_FunctionParams
		{
			// Token: 0x040067B4 RID: 26548
			[FieldOffset(0)]
			public FString InFullPath;

			// Token: 0x040067B5 RID: 26549
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x0200136D RID: 4973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetStateInstanceByGuid_FunctionParams
		{
			// Token: 0x040067B6 RID: 26550
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x040067B7 RID: 26551
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x0200136E RID: 4974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetStateHistoryMaxCount_FunctionParams
		{
			// Token: 0x040067B8 RID: 26552
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200136F RID: 4975
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSingleActiveStateInstance_FunctionParams
		{
			// Token: 0x040067B9 RID: 26553
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x040067BA RID: 26554
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02001370 RID: 4976
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetSingleActiveStateGuid_FunctionParams
		{
			// Token: 0x040067BB RID: 26555
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x040067BC RID: 26556
			[FieldOffset(4)]
			public FGuid __Result;
		}

		// Token: 0x02001371 RID: 4977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRootStateMachineNodeInstance_FunctionParams
		{
			// Token: 0x040067BD RID: 26557
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001372 RID: 4978
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRootStateMachineInstance_FunctionParams
		{
			// Token: 0x040067BE RID: 26558
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001373 RID: 4979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetReferenceOwner_FunctionParams
		{
			// Token: 0x040067BF RID: 26559
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001374 RID: 4980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetReferencedInstanceByGuid_FunctionParams
		{
			// Token: 0x040067C0 RID: 26560
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x040067C1 RID: 26561
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02001375 RID: 4981
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPrimaryReferenceOwner_FunctionParams
		{
			// Token: 0x040067C2 RID: 26562
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001376 RID: 4982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeInstanceByGuid_FunctionParams
		{
			// Token: 0x040067C3 RID: 26563
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x040067C4 RID: 26564
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02001377 RID: 4983
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNestedActiveStateName_FunctionParams
		{
			// Token: 0x040067C5 RID: 26565
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02001378 RID: 4984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNestedActiveStateGuid_FunctionParams
		{
			// Token: 0x040067C6 RID: 26566
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02001379 RID: 4985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetMasterReferenceOwner_FunctionParams
		{
			// Token: 0x040067C7 RID: 26567
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200137A RID: 4986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetGuidRedirectMap_FunctionParams
		{
			// Token: 0x040067C8 RID: 26568
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200137B RID: 4987
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetContext_FunctionParams
		{
			// Token: 0x040067C9 RID: 26569
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200137C RID: 4988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllTransitionInstances_FunctionParams
		{
			// Token: 0x040067CA RID: 26570
			[FieldOffset(0)]
			public byte TransitionInstances;
		}

		// Token: 0x0200137D RID: 4989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllStateInstances_FunctionParams
		{
			// Token: 0x040067CB RID: 26571
			[FieldOffset(0)]
			public byte StateInstances;
		}

		// Token: 0x0200137E RID: 4990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllRootNodeInstance_FunctionParams
		{
			// Token: 0x040067CC RID: 26572
			[FieldOffset(0)]
			public byte Nodes;
		}

		// Token: 0x0200137F RID: 4991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllReferencedInstances_FunctionParams
		{
			// Token: 0x040067CD RID: 26573
			[FieldOffset(0)]
			public bool bIncludeChildren;

			// Token: 0x040067CE RID: 26574
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02001380 RID: 4992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllCurrentStateGuids_FunctionParams
		{
			// Token: 0x040067CF RID: 26575
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001381 RID: 4993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllActiveStateInstances_FunctionParams
		{
			// Token: 0x040067D0 RID: 26576
			[FieldOffset(0)]
			public byte ActiveStateInstances;
		}

		// Token: 0x02001382 RID: 4994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllActiveStateGuids_FunctionParams
		{
			// Token: 0x040067D1 RID: 26577
			[FieldOffset(0)]
			public byte ActiveGuids;
		}

		// Token: 0x02001383 RID: 4995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateName_FunctionParams
		{
			// Token: 0x040067D2 RID: 26578
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02001384 RID: 4996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateInstance_FunctionParams
		{
			// Token: 0x040067D3 RID: 26579
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x040067D4 RID: 26580
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02001385 RID: 4997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateGuid_FunctionParams
		{
			// Token: 0x040067D5 RID: 26581
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02001386 RID: 4998
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __EvaluateAndTakeTransitionChain_FunctionParams
		{
			// Token: 0x040067D6 RID: 26582
			[FieldOffset(0)]
			public IntPtr InFirstTransitionInstance;

			// Token: 0x040067D7 RID: 26583
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02001387 RID: 4999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __EvaluateAndFindTransitionChain_FunctionParams
		{
			// Token: 0x040067D8 RID: 26584
			[FieldOffset(0)]
			public IntPtr InFirstTransitionInstance;

			// Token: 0x040067D9 RID: 26585
			[FieldOffset(8)]
			public byte OutTransitionChain;

			// Token: 0x040067DA RID: 26586
			[FieldOffset(24)]
			public IntPtr OutDestinationState;

			// Token: 0x040067DB RID: 26587
			[FieldOffset(32)]
			public bool bRequirePreviousStateActive;

			// Token: 0x040067DC RID: 26588
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x02001388 RID: 5000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanTickOnManualUpdate_FunctionParams
		{
			// Token: 0x040067DD RID: 26589
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02001389 RID: 5001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanEverTick_FunctionParams
		{
			// Token: 0x040067DE RID: 26590
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200138A RID: 5002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanAutoManageTime_FunctionParams
		{
			// Token: 0x040067DF RID: 26591
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200138B RID: 5003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreInitialStatesSetFromLoad_FunctionParams
		{
			// Token: 0x040067E0 RID: 26592
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
