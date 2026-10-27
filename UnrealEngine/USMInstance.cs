using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002888 RID: 10376
	[UnrealObjectPath("/Script/SMSystem.SMInstance")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class USMInstance : UObject, IUnrealUObject, IUnrealObject, ISMStateMachineInterface, IUnrealNativeInterface, IUnrealInterface, ISMInstanceInterface
	{
		// Token: 0x0602666D RID: 157293 RVA: 0x003A5CB1 File Offset: 0x003A3EB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMInstance._ClassPtr;
		}

		// Token: 0x0602666E RID: 157294 RVA: 0x003A5CBD File Offset: 0x003A3EBD
		int ISMStateMachineInterface.InterfaceOffset()
		{
			return USMInstance.__InterfaceOffset_ISMStateMachineInterface;
		}

		// Token: 0x0602666F RID: 157295 RVA: 0x003A5CC4 File Offset: 0x003A3EC4
		int ISMInstanceInterface.InterfaceOffset()
		{
			return USMInstance.__InterfaceOffset_ISMInstanceInterface;
		}

		// Token: 0x06026670 RID: 157296 RVA: 0x003A5CCC File Offset: 0x003A3ECC
		public USMInstance() : this(BuiltinUtils.AllocNativeUObject(USMInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026671 RID: 157297 RVA: 0x003A5CF4 File Offset: 0x003A3EF4
		[NullableContext(1)]
		public USMInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009416 RID: 37910
		// (get) Token: 0x06026672 RID: 157298 RVA: 0x003A5D28 File Offset: 0x003A3F28
		// (set) Token: 0x06026673 RID: 157299 RVA: 0x003A5D61 File Offset: 0x003A3F61
		[Nullable(1)]
		public TArray<FSMReferenceContainer> ReplicatedReferences
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSMReferenceContainer> result;
				if ((result = this._ReplicatedReferences) == null)
				{
					result = (this._ReplicatedReferences = new TArray<FSMReferenceContainer>(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_ReplicatedReferences, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ReplicatedReferences.CopyAssign(value);
			}
		}

		// Token: 0x17009417 RID: 37911
		// (get) Token: 0x06026674 RID: 157300 RVA: 0x003A5D6F File Offset: 0x003A3F6F
		// (set) Token: 0x06026675 RID: 157301 RVA: 0x003A5D83 File Offset: 0x003A3F83
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

		// Token: 0x17009418 RID: 37912
		// (get) Token: 0x06026676 RID: 157302 RVA: 0x003A5D98 File Offset: 0x003A3F98
		// (set) Token: 0x06026677 RID: 157303 RVA: 0x003A5DD1 File Offset: 0x003A3FD1
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

		// Token: 0x17009419 RID: 37913
		// (get) Token: 0x06026678 RID: 157304 RVA: 0x003A5DE0 File Offset: 0x003A3FE0
		// (set) Token: 0x06026679 RID: 157305 RVA: 0x003A5E19 File Offset: 0x003A4019
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

		// Token: 0x1700941A RID: 37914
		// (get) Token: 0x0602667A RID: 157306 RVA: 0x003A5E3C File Offset: 0x003A403C
		// (set) Token: 0x0602667B RID: 157307 RVA: 0x003A5E75 File Offset: 0x003A4075
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

		// Token: 0x1700941B RID: 37915
		// (get) Token: 0x0602667C RID: 157308 RVA: 0x003A5E98 File Offset: 0x003A4098
		// (set) Token: 0x0602667D RID: 157309 RVA: 0x003A5ED1 File Offset: 0x003A40D1
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

		// Token: 0x1700941C RID: 37916
		// (get) Token: 0x0602667E RID: 157310 RVA: 0x003A5EF4 File Offset: 0x003A40F4
		// (set) Token: 0x0602667F RID: 157311 RVA: 0x003A5F2D File Offset: 0x003A412D
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

		// Token: 0x1700941D RID: 37917
		// (get) Token: 0x06026680 RID: 157312 RVA: 0x003A5F50 File Offset: 0x003A4150
		// (set) Token: 0x06026681 RID: 157313 RVA: 0x003A5F89 File Offset: 0x003A4189
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

		// Token: 0x1700941E RID: 37918
		// (get) Token: 0x06026682 RID: 157314 RVA: 0x003A5FAC File Offset: 0x003A41AC
		// (set) Token: 0x06026683 RID: 157315 RVA: 0x003A5FE5 File Offset: 0x003A41E5
		[Nullable(1)]
		public FOnStateMachineTransitionTakenSignature OnStateMachineTransitionTakenEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineTransitionTakenSignature result;
				if ((result = this._OnStateMachineTransitionTakenEvent) == null)
				{
					result = (this._OnStateMachineTransitionTakenEvent = new FOnStateMachineTransitionTakenSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineTransitionTakenEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineTransitionTakenEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700941F RID: 37919
		// (get) Token: 0x06026684 RID: 157316 RVA: 0x003A6008 File Offset: 0x003A4208
		// (set) Token: 0x06026685 RID: 157317 RVA: 0x003A6041 File Offset: 0x003A4241
		[Nullable(1)]
		public FOnStateMachineStateChangedSignature OnStateMachineStateChangedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineStateChangedSignature result;
				if ((result = this._OnStateMachineStateChangedEvent) == null)
				{
					result = (this._OnStateMachineStateChangedEvent = new FOnStateMachineStateChangedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStateChangedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStateChangedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009420 RID: 37920
		// (get) Token: 0x06026686 RID: 157318 RVA: 0x003A6064 File Offset: 0x003A4264
		// (set) Token: 0x06026687 RID: 157319 RVA: 0x003A609D File Offset: 0x003A429D
		[Nullable(1)]
		public FOnStateMachineStateStartedSignature OnStateMachineStateStartedEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateMachineStateStartedSignature result;
				if ((result = this._OnStateMachineStateStartedEvent) == null)
				{
					result = (this._OnStateMachineStateStartedEvent = new FOnStateMachineStateStartedSignature(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStateStartedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_OnStateMachineStateStartedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009421 RID: 37921
		// (get) Token: 0x06026688 RID: 157320 RVA: 0x003A60BE File Offset: 0x003A42BE
		// (set) Token: 0x06026689 RID: 157321 RVA: 0x003A60D2 File Offset: 0x003A42D2
		[Nullable(2)]
		public unsafe USMStateMachineComponent ComponentOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMStateMachineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_ComponentOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMInstance.__PropertyOffset_ComponentOwner, value);
			}
		}

		// Token: 0x17009422 RID: 37922
		// (get) Token: 0x0602668A RID: 157322 RVA: 0x003A60E7 File Offset: 0x003A42E7
		// (set) Token: 0x0602668B RID: 157323 RVA: 0x003A6101 File Offset: 0x003A4301
		[Nullable(2)]
		public unsafe ISMStateMachineNetworkedInterface NetworkInterface
		{
			[NullableContext(2)]
			get
			{
				return (ISMStateMachineNetworkedInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_NetworkInterface));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_NetworkInterface) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17009423 RID: 37923
		// (get) Token: 0x0602668C RID: 157324 RVA: 0x003A6128 File Offset: 0x003A4328
		// (set) Token: 0x0602668D RID: 157325 RVA: 0x003A6161 File Offset: 0x003A4361
		[Nullable(1)]
		public FSMStateMachine RootStateMachine
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSMStateMachine result;
				if ((result = this._RootStateMachine) == null)
				{
					result = (this._RootStateMachine = new FSMStateMachine(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_RootStateMachine, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateMachine.StaticStruct(), base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_RootStateMachine, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009424 RID: 37924
		// (get) Token: 0x0602668E RID: 157326 RVA: 0x003A6182 File Offset: 0x003A4382
		// (set) Token: 0x0602668F RID: 157327 RVA: 0x003A6196 File Offset: 0x003A4396
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

		// Token: 0x17009425 RID: 37925
		// (get) Token: 0x06026690 RID: 157328 RVA: 0x003A61AB File Offset: 0x003A43AB
		// (set) Token: 0x06026691 RID: 157329 RVA: 0x003A61BF File Offset: 0x003A43BF
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

		// Token: 0x17009426 RID: 37926
		// (get) Token: 0x06026692 RID: 157330 RVA: 0x003A61D4 File Offset: 0x003A43D4
		// (set) Token: 0x06026693 RID: 157331 RVA: 0x003A61E8 File Offset: 0x003A43E8
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

		// Token: 0x17009427 RID: 37927
		// (get) Token: 0x06026694 RID: 157332 RVA: 0x003A61FD File Offset: 0x003A43FD
		// (set) Token: 0x06026695 RID: 157333 RVA: 0x003A6216 File Offset: 0x003A4416
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

		// Token: 0x17009428 RID: 37928
		// (get) Token: 0x06026696 RID: 157334 RVA: 0x003A6246 File Offset: 0x003A4446
		// (set) Token: 0x06026697 RID: 157335 RVA: 0x003A625F File Offset: 0x003A445F
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

		// Token: 0x17009429 RID: 37929
		// (get) Token: 0x06026698 RID: 157336 RVA: 0x003A628F File Offset: 0x003A448F
		// (set) Token: 0x06026699 RID: 157337 RVA: 0x003A62A8 File Offset: 0x003A44A8
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

		// Token: 0x1700942A RID: 37930
		// (get) Token: 0x0602669A RID: 157338 RVA: 0x003A62D8 File Offset: 0x003A44D8
		// (set) Token: 0x0602669B RID: 157339 RVA: 0x003A62F1 File Offset: 0x003A44F1
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

		// Token: 0x1700942B RID: 37931
		// (get) Token: 0x0602669C RID: 157340 RVA: 0x003A6321 File Offset: 0x003A4521
		// (set) Token: 0x0602669D RID: 157341 RVA: 0x003A633A File Offset: 0x003A453A
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

		// Token: 0x1700942C RID: 37932
		// (get) Token: 0x0602669E RID: 157342 RVA: 0x003A636A File Offset: 0x003A456A
		// (set) Token: 0x0602669F RID: 157343 RVA: 0x003A6383 File Offset: 0x003A4583
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

		// Token: 0x1700942D RID: 37933
		// (get) Token: 0x060266A0 RID: 157344 RVA: 0x003A63B3 File Offset: 0x003A45B3
		// (set) Token: 0x060266A1 RID: 157345 RVA: 0x003A63CC File Offset: 0x003A45CC
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

		// Token: 0x1700942E RID: 37934
		// (get) Token: 0x060266A2 RID: 157346 RVA: 0x003A63FC File Offset: 0x003A45FC
		// (set) Token: 0x060266A3 RID: 157347 RVA: 0x003A640C File Offset: 0x003A460C
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

		// Token: 0x1700942F RID: 37935
		// (get) Token: 0x060266A4 RID: 157348 RVA: 0x003A6420 File Offset: 0x003A4620
		// (set) Token: 0x060266A5 RID: 157349 RVA: 0x003A6459 File Offset: 0x003A4659
		[Nullable(1)]
		public TArray<FSMStateHistory> StateHistory
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSMStateHistory> result;
				if ((result = this._StateHistory) == null)
				{
					result = (this._StateHistory = new TArray<FSMStateHistory>(base.NativePtr + (IntPtr)USMInstance.__PropertyOffset_StateHistory, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StateHistory.CopyAssign(value);
			}
		}

		// Token: 0x17009430 RID: 37936
		// (get) Token: 0x060266A6 RID: 157350 RVA: 0x003A6467 File Offset: 0x003A4667
		// (set) Token: 0x060266A7 RID: 157351 RVA: 0x003A6477 File Offset: 0x003A4677
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

		// Token: 0x17009431 RID: 37937
		// (get) Token: 0x060266A8 RID: 157352 RVA: 0x003A6488 File Offset: 0x003A4688
		// (set) Token: 0x060266A9 RID: 157353 RVA: 0x003A64A1 File Offset: 0x003A46A1
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

		// Token: 0x17009432 RID: 37938
		// (get) Token: 0x060266AA RID: 157354 RVA: 0x003A64D1 File Offset: 0x003A46D1
		// (set) Token: 0x060266AB RID: 157355 RVA: 0x003A64EA File Offset: 0x003A46EA
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

		// Token: 0x17009433 RID: 37939
		// (get) Token: 0x060266AC RID: 157356 RVA: 0x003A651A File Offset: 0x003A471A
		// (set) Token: 0x060266AD RID: 157357 RVA: 0x003A6533 File Offset: 0x003A4733
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

		// Token: 0x17009434 RID: 37940
		// (get) Token: 0x060266AE RID: 157358 RVA: 0x003A6563 File Offset: 0x003A4763
		// (set) Token: 0x060266AF RID: 157359 RVA: 0x003A657C File Offset: 0x003A477C
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

		// Token: 0x17009435 RID: 37941
		// (get) Token: 0x060266B0 RID: 157360 RVA: 0x003A65AC File Offset: 0x003A47AC
		// (set) Token: 0x060266B1 RID: 157361 RVA: 0x003A65E5 File Offset: 0x003A47E5
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

		// Token: 0x17009436 RID: 37942
		// (get) Token: 0x060266B2 RID: 157362 RVA: 0x003A65F4 File Offset: 0x003A47F4
		// (set) Token: 0x060266B3 RID: 157363 RVA: 0x003A662D File Offset: 0x003A482D
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

		// Token: 0x060266B4 RID: 157364 RVA: 0x003A663C File Offset: 0x003A483C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Update(float DeltaSeconds = 0f)
		{
			USMInstance.__Update_FunctionParams* ptr = stackalloc USMInstance.__Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Update_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266B5 RID: 157365 RVA: 0x003A6684 File Offset: 0x003A4884
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void TryGetTransitionInfo(in FGuid Guid, ref FSMTransitionInfo TransitionInfo, ref bool bSuccess)
		{
			USMInstance.__TryGetTransitionInfo_FunctionParams* ptr = stackalloc USMInstance.__TryGetTransitionInfo_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(USMInstance.__TryGetTransitionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__TryGetTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			if (TransitionInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->TransitionInfo, TransitionInfo.NativePtr, 1, false);
			}
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__TryGetTransitionInfo_NativeFunctionPtr, (void*)ptr, 0);
			if (TransitionInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), TransitionInfo.NativePtr, &ptr->TransitionInfo, 1, false);
			}
			bSuccess = ptr->bSuccess;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__TryGetTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266B6 RID: 157366 RVA: 0x003A673C File Offset: 0x003A493C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void TryGetStateInfo(in FGuid Guid, ref FSMStateInfo StateInfo, ref bool bSuccess)
		{
			USMInstance.__TryGetStateInfo_FunctionParams* ptr = stackalloc USMInstance.__TryGetStateInfo_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(USMInstance.__TryGetStateInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__TryGetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			if (StateInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->StateInfo, StateInfo.NativePtr, 1, false);
			}
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__TryGetStateInfo_NativeFunctionPtr, (void*)ptr, 0);
			if (StateInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), StateInfo.NativePtr, &ptr->StateInfo, 1, false);
			}
			bSuccess = ptr->bSuccess;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__TryGetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266B7 RID: 157367 RVA: 0x003A67F4 File Offset: 0x003A49F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void TryGetNestedActiveState(ref FSMStateInfo FoundState, ref bool bSuccess)
		{
			USMInstance.__TryGetNestedActiveState_FunctionParams* ptr = stackalloc USMInstance.__TryGetNestedActiveState_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(USMInstance.__TryGetNestedActiveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__TryGetNestedActiveState_NativeFunctionPtr, (void*)ptr, 1);
			if (FoundState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->FoundState, FoundState.NativePtr, 1, false);
			}
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__TryGetNestedActiveState_NativeFunctionPtr, (void*)ptr, 0);
			if (FoundState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), FoundState.NativePtr, &ptr->FoundState, 1, false);
			}
			bSuccess = ptr->bSuccess;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__TryGetNestedActiveState_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266B8 RID: 157368 RVA: 0x003A68A0 File Offset: 0x003A4AA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Tick(float DeltaTime)
		{
			USMInstance.__Tick_FunctionParams* ptr = stackalloc USMInstance.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266B9 RID: 157369 RVA: 0x003A68E8 File Offset: 0x003A4AE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(float DeltaTime)
		{
			USMInstance.__Tick_FunctionParams* ptr = stackalloc USMInstance.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266BA RID: 157370 RVA: 0x003A6930 File Offset: 0x003A4B30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__TakeTransitionChain_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMTransitionInstance> tarray2 = InTransitionChain;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransitionChain);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMInstance.__TakeTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060266BB RID: 157371 RVA: 0x003A69B0 File Offset: 0x003A4BB0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SwitchActiveStateByQualifiedName(string InFullPath, bool bDeactivateOtherStates = true)
		{
			USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams* ptr = stackalloc USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__SwitchActiveStateByQualifiedName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InFullPath), InFullPath);
			ptr->bDeactivateOtherStates = bDeactivateOtherStates;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__SwitchActiveStateByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266BC RID: 157372 RVA: 0x003A6A18 File Offset: 0x003A4C18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SwitchActiveState(USMStateInstance_Base NewStateInstance, bool bDeactivateOtherStates = true)
		{
			USMInstance.__SwitchActiveState_FunctionParams* ptr = stackalloc USMInstance.__SwitchActiveState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__SwitchActiveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SwitchActiveState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewStateInstance = ((NewStateInstance != null) ? NewStateInstance.NativePtr : IntPtr.Zero);
			ptr->bDeactivateOtherStates = bDeactivateOtherStates;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SwitchActiveState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266BD RID: 157373 RVA: 0x003A6A75 File Offset: 0x003A4C75
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Stop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266BE RID: 157374 RVA: 0x003A6A8C File Offset: 0x003A4C8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StartWithNewContext(UObject Context)
		{
			USMInstance.__StartWithNewContext_FunctionParams* ptr = stackalloc USMInstance.__StartWithNewContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__StartWithNewContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__StartWithNewContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__StartWithNewContext_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266BF RID: 157375 RVA: 0x003A6AE2 File Offset: 0x003A4CE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Start()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Start_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266C0 RID: 157376 RVA: 0x003A6AF7 File Offset: 0x003A4CF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Shutdown()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Shutdown_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266C1 RID: 157377 RVA: 0x003A6B0C File Offset: 0x003A4D0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTickOnManualUpdate(bool Value)
		{
			USMInstance.__SetTickOnManualUpdate_FunctionParams* ptr = stackalloc USMInstance.__SetTickOnManualUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetTickOnManualUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C2 RID: 157378 RVA: 0x003A6B54 File Offset: 0x003A4D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTickInterval(float Value)
		{
			USMInstance.__SetTickInterval_FunctionParams* ptr = stackalloc USMInstance.__SetTickInterval_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__SetTickInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickInterval_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickInterval_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C3 RID: 157379 RVA: 0x003A6B9C File Offset: 0x003A4D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTickBeforeBeginPlay(bool Value)
		{
			USMInstance.__SetTickBeforeBeginPlay_FunctionParams* ptr = stackalloc USMInstance.__SetTickBeforeBeginPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetTickBeforeBeginPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetTickBeforeBeginPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetTickBeforeBeginPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C4 RID: 157380 RVA: 0x003A6BE4 File Offset: 0x003A4DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStopOnEndState(bool Value)
		{
			USMInstance.__SetStopOnEndState_FunctionParams* ptr = stackalloc USMInstance.__SetStopOnEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetStopOnEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStopOnEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStopOnEndState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C5 RID: 157381 RVA: 0x003A6C2C File Offset: 0x003A4E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStateMachineClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USMStateMachineInstance> NewStateMachineClass)
		{
			USMInstance.__SetStateMachineClass_FunctionParams* ptr = stackalloc USMInstance.__SetStateMachineClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__SetStateMachineClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStateMachineClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewStateMachineClass = NewStateMachineClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStateMachineClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C6 RID: 157382 RVA: 0x003A6C74 File Offset: 0x003A4E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStateHistoryMaxCount(int NewSize)
		{
			USMInstance.__SetStateHistoryMaxCount_FunctionParams* ptr = stackalloc USMInstance.__SetStateHistoryMaxCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__SetStateHistoryMaxCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewSize = NewSize;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C7 RID: 157383 RVA: 0x003A6CBC File Offset: 0x003A4EBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetGuidRedirectMap(in TMap<FGuid, FGuid> InGuidMap)
		{
			USMInstance.__SetGuidRedirectMap_FunctionParams* ptr = stackalloc USMInstance.__SetGuidRedirectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USMInstance.__SetGuidRedirectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FGuid, FGuid> tmap = InGuidMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InGuidMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FGuid, FGuid> tmap2 = InGuidMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InGuidMap);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__SetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266C8 RID: 157384 RVA: 0x003A6D38 File Offset: 0x003A4F38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetContext(UObject Context)
		{
			USMInstance.__SetContext_FunctionParams* ptr = stackalloc USMInstance.__SetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__SetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetContext_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266C9 RID: 157385 RVA: 0x003A6D90 File Offset: 0x003A4F90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanTickWhenPaused(bool Value)
		{
			USMInstance.__SetCanTickWhenPaused_FunctionParams* ptr = stackalloc USMInstance.__SetCanTickWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetCanTickWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetCanTickWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetCanTickWhenPaused_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266CA RID: 157386 RVA: 0x003A6DD8 File Offset: 0x003A4FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanEverTick(bool Value)
		{
			USMInstance.__SetCanEverTick_FunctionParams* ptr = stackalloc USMInstance.__SetCanEverTick_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetCanEverTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetCanEverTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetCanEverTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266CB RID: 157387 RVA: 0x003A6E20 File Offset: 0x003A5020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAutoManageTime(bool Value)
		{
			USMInstance.__SetAutoManageTime_FunctionParams* ptr = stackalloc USMInstance.__SetAutoManageTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__SetAutoManageTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__SetAutoManageTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__SetAutoManageTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266CC RID: 157388 RVA: 0x003A6E68 File Offset: 0x003A5068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RunUpdateAsReference(float DeltaSeconds)
		{
			USMInstance.__RunUpdateAsReference_FunctionParams* ptr = stackalloc USMInstance.__RunUpdateAsReference_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__RunUpdateAsReference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__RunUpdateAsReference_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__RunUpdateAsReference_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266CD RID: 157389 RVA: 0x003A6EAF File Offset: 0x003A50AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Restart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Restart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266CE RID: 157390 RVA: 0x003A6EC4 File Offset: 0x003A50C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReplicatedStop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedStop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266CF RID: 157391 RVA: 0x003A6ED9 File Offset: 0x003A50D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReplicatedStart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266D0 RID: 157392 RVA: 0x003A6EEE File Offset: 0x003A50EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReplicatedRestart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ReplicatedRestart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266D1 RID: 157393 RVA: 0x003A6F03 File Offset: 0x003A5103
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void REP_OnReplicatedReferencesLoaded()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__REP_OnReplicatedReferencesLoaded_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266D2 RID: 157394 RVA: 0x003A6F18 File Offset: 0x003A5118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void PreloadAllNodeInstances()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__PreloadAllNodeInstances_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266D3 RID: 157395 RVA: 0x003A6F30 File Offset: 0x003A5130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnStateMachineUpdate(float DeltaSeconds)
		{
			USMInstance.__OnStateMachineUpdate_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__OnStateMachineUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266D4 RID: 157396 RVA: 0x003A6F78 File Offset: 0x003A5178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnStateMachineUpdate_Implementation(float DeltaSeconds)
		{
			USMInstance.__OnStateMachineUpdate_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__OnStateMachineUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineUpdate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266D5 RID: 157397 RVA: 0x003A6FC0 File Offset: 0x003A51C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnStateMachineTransitionTaken(in FSMTransitionInfo Transition)
		{
			USMInstance.__OnStateMachineTransitionTaken_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineTransitionTaken_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(USMInstance.__OnStateMachineTransitionTaken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->Transition, Transition.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266D6 RID: 157398 RVA: 0x003A7038 File Offset: 0x003A5238
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnStateMachineTransitionTaken_Implementation(in FSMTransitionInfo Transition)
		{
			USMInstance.__OnStateMachineTransitionTaken_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineTransitionTaken_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(USMInstance.__OnStateMachineTransitionTaken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->Transition, Transition.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266D7 RID: 157399 RVA: 0x003A70B0 File Offset: 0x003A52B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnStateMachineStop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStop_NativeFunctionPtr, null);
		}

		// Token: 0x060266D8 RID: 157400 RVA: 0x003A70C4 File Offset: 0x003A52C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnStateMachineStop_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266D9 RID: 157401 RVA: 0x003A70DC File Offset: 0x003A52DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnStateMachineStateStarted(in FSMStateInfo State)
		{
			USMInstance.__OnStateMachineStateStarted_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineStateStarted_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(USMInstance.__OnStateMachineStateStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->State, State.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266DA RID: 157402 RVA: 0x003A7154 File Offset: 0x003A5354
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnStateMachineStateStarted_Implementation(in FSMStateInfo State)
		{
			USMInstance.__OnStateMachineStateStarted_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineStateStarted_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(USMInstance.__OnStateMachineStateStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->State, State.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266DB RID: 157403 RVA: 0x003A71CC File Offset: 0x003A53CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnStateMachineStateChanged(in FSMStateInfo ToState, in FSMStateInfo FromState)
		{
			USMInstance.__OnStateMachineStateChanged_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineStateChanged_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(USMInstance.__OnStateMachineStateChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
			if (ToState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->ToState, ToState.NativePtr, 1, false);
			}
			if (FromState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->FromState, FromState.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266DC RID: 157404 RVA: 0x003A7268 File Offset: 0x003A5468
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnStateMachineStateChanged_Implementation(in FSMStateInfo ToState, in FSMStateInfo FromState)
		{
			USMInstance.__OnStateMachineStateChanged_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineStateChanged_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(USMInstance.__OnStateMachineStateChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
			if (ToState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->ToState, ToState.NativePtr, 1, false);
			}
			if (FromState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->FromState, FromState.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266DD RID: 157405 RVA: 0x003A7304 File Offset: 0x003A5504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnStateMachineStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineStart_NativeFunctionPtr, null);
		}

		// Token: 0x060266DE RID: 157406 RVA: 0x003A7318 File Offset: 0x003A5518
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnStateMachineStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266DF RID: 157407 RVA: 0x003A7330 File Offset: 0x003A5530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnStateMachineInitialStateLoaded(in FGuid StateGuid)
		{
			USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateGuid = StateGuid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266E0 RID: 157408 RVA: 0x003A737C File Offset: 0x003A557C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnStateMachineInitialStateLoaded_Implementation(in FGuid StateGuid)
		{
			USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams* ptr = stackalloc USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__OnStateMachineInitialStateLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateGuid = StateGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialStateLoaded_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266E1 RID: 157409 RVA: 0x003A73C8 File Offset: 0x003A55C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnStateMachineInitialized()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x060266E2 RID: 157410 RVA: 0x003A73DC File Offset: 0x003A55DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnStateMachineInitialized_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnStateMachineInitialized_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266E3 RID: 157411 RVA: 0x003A73F1 File Offset: 0x003A55F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnPreStateMachineInitialized()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnPreStateMachineInitialized_NativeFunctionPtr, null);
		}

		// Token: 0x060266E4 RID: 157412 RVA: 0x003A7405 File Offset: 0x003A5605
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnPreStateMachineInitialized_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnPreStateMachineInitialized_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266E5 RID: 157413 RVA: 0x003A741A File Offset: 0x003A561A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnPostCompile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMInstance.__OnPostCompile_NativeFunctionPtr, null);
		}

		// Token: 0x060266E6 RID: 157414 RVA: 0x003A742E File Offset: 0x003A562E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnPostCompile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__OnPostCompile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266E7 RID: 157415 RVA: 0x003A7444 File Offset: 0x003A5644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void LoadFromState(in FGuid FromGuid, bool bAllParents = true, bool bNotify = true)
		{
			USMInstance.__LoadFromState_FunctionParams* ptr = stackalloc USMInstance.__LoadFromState_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__LoadFromState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__LoadFromState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FromGuid = FromGuid;
			ptr->bAllParents = bAllParents;
			ptr->bNotify = bNotify;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__LoadFromState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266E8 RID: 157416 RVA: 0x003A74A0 File Offset: 0x003A56A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__LoadFromMultipleStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = FromGuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FromGuids);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__LoadFromMultipleStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266E9 RID: 157417 RVA: 0x003A7520 File Offset: 0x003A5720
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void K2_TryGetNetworkInterface(ref ISMStateMachineNetworkedInterface Interface, ref bool bIsValid)
		{
			USMInstance.__K2_TryGetNetworkInterface_FunctionParams* ptr = stackalloc USMInstance.__K2_TryGetNetworkInterface_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__K2_TryGetNetworkInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__K2_TryGetNetworkInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref USMInstance.__K2_TryGetNetworkInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = Interface;
			ISMStateMachineNetworkedInterface ismstateMachineNetworkedInterface = Interface;
			ptr2.Interface = new FScriptInterface(@object, (ismstateMachineNetworkedInterface != null) ? ismstateMachineNetworkedInterface.InterfaceOffset() : 0);
			ptr->bIsValid = bIsValid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__K2_TryGetNetworkInterface_NativeFunctionPtr, (void*)ptr, 0);
			Interface = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->Interface.ObjectPointer) as ISMStateMachineNetworkedInterface);
			bIsValid = ptr->bIsValid;
		}

		// Token: 0x060266EA RID: 157418 RVA: 0x003A75A4 File Offset: 0x003A57A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsTickableWhenPaused()
		{
			USMInstance.__IsTickableWhenPaused_FunctionParams* ptr = stackalloc USMInstance.__IsTickableWhenPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsTickableWhenPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsTickableWhenPaused_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsTickableWhenPaused_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x003A75EC File Offset: 0x003A57EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsTickable()
		{
			USMInstance.__IsTickable_FunctionParams* ptr = stackalloc USMInstance.__IsTickable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsTickable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsTickable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsTickable_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x003A7634 File Offset: 0x003A5834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInitialized()
		{
			USMInstance.__IsInitialized_FunctionParams* ptr = stackalloc USMInstance.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266ED RID: 157421 RVA: 0x003A767C File Offset: 0x003A587C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInEndState()
		{
			USMInstance.__IsInEndState_FunctionParams* ptr = stackalloc USMInstance.__IsInEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsInEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266EE RID: 157422 RVA: 0x003A76C4 File Offset: 0x003A58C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsActive()
		{
			USMInstance.__IsActive_FunctionParams* ptr = stackalloc USMInstance.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266EF RID: 157423 RVA: 0x003A770C File Offset: 0x003A590C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_Update(float DeltaSeconds)
		{
			USMInstance.__Internal_Update_FunctionParams* ptr = stackalloc USMInstance.__Internal_Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__Internal_Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_Update_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266F0 RID: 157424 RVA: 0x003A7753 File Offset: 0x003A5953
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Internal_EventUpdate()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EventUpdate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266F1 RID: 157425 RVA: 0x003A7768 File Offset: 0x003A5968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_EventCleanup(in FGuid PathGuid)
		{
			USMInstance.__Internal_EventCleanup_FunctionParams* ptr = stackalloc USMInstance.__Internal_EventCleanup_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__Internal_EventCleanup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_EventCleanup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PathGuid = PathGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EventCleanup_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266F2 RID: 157426 RVA: 0x003A77B4 File Offset: 0x003A59B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Internal_EvaluateAndTakeTransitionChainByGuid(in FGuid PathGuid)
		{
			USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams* ptr = stackalloc USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PathGuid = PathGuid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266F3 RID: 157427 RVA: 0x003A7808 File Offset: 0x003A5A08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(UObject Context)
		{
			USMInstance.__Initialize_FunctionParams* ptr = stackalloc USMInstance.__Initialize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266F4 RID: 157428 RVA: 0x003A7860 File Offset: 0x003A5A60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool HasStarted()
		{
			USMInstance.__HasStarted_FunctionParams* ptr = stackalloc USMInstance.__HasStarted_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__HasStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__HasStarted_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__HasStarted_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266F5 RID: 157429 RVA: 0x003A78A8 File Offset: 0x003A5AA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMTransitionInstance GetTransitionInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetTransitionInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetTransitionInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetTransitionInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetTransitionInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetTransitionInstanceByGuid_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x060266F6 RID: 157430 RVA: 0x003A7900 File Offset: 0x003A5B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetTickInterval()
		{
			USMInstance.__GetTickInterval_FunctionParams* ptr = stackalloc USMInstance.__GetTickInterval_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__GetTickInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetTickInterval_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetTickInterval_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266F7 RID: 157431 RVA: 0x003A7948 File Offset: 0x003A5B48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetStopOnEndState()
		{
			USMInstance.__GetStopOnEndState_FunctionParams* ptr = stackalloc USMInstance.__GetStopOnEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__GetStopOnEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStopOnEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStopOnEndState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266F8 RID: 157432 RVA: 0x003A7990 File Offset: 0x003A5B90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USMStateMachineInstance> GetStateMachineClass()
		{
			USMInstance.__GetStateMachineClass_FunctionParams* ptr = stackalloc USMInstance.__GetStateMachineClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetStateMachineClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateMachineClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateMachineClass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266F9 RID: 157433 RVA: 0x003A79D8 File Offset: 0x003A5BD8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetStateInstanceByQualifiedName(string InFullPath)
		{
			USMInstance.__GetStateInstanceByQualifiedName_FunctionParams* ptr = stackalloc USMInstance.__GetStateInstanceByQualifiedName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetStateInstanceByQualifiedName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InFullPath), InFullPath);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr, 0);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetStateInstanceByQualifiedName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060266FA RID: 157434 RVA: 0x003A7A44 File Offset: 0x003A5C44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetStateInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetStateInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetStateInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetStateInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateInstanceByGuid_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x060266FB RID: 157435 RVA: 0x003A7A9C File Offset: 0x003A5C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetStateHistoryMaxCount()
		{
			USMInstance.__GetStateHistoryMaxCount_FunctionParams* ptr = stackalloc USMInstance.__GetStateHistoryMaxCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMInstance.__GetStateHistoryMaxCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateHistoryMaxCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266FC RID: 157436 RVA: 0x003A7AE4 File Offset: 0x003A5CE4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSMStateHistory> GetStateHistory()
		{
			USMInstance.__GetStateHistory_FunctionParams* ptr = stackalloc USMInstance.__GetStateHistory_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetStateHistory_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetStateHistory_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetStateHistory_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMStateHistory> result = new TArray<FSMStateHistory>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetStateHistory_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060266FD RID: 157437 RVA: 0x003A7B44 File Offset: 0x003A5D44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetSingleActiveStateInstance(bool bCheckNested = true)
		{
			USMInstance.__GetSingleActiveStateInstance_FunctionParams* ptr = stackalloc USMInstance.__GetSingleActiveStateInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetSingleActiveStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetSingleActiveStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetSingleActiveStateInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x060266FE RID: 157438 RVA: 0x003A7B98 File Offset: 0x003A5D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FGuid GetSingleActiveStateGuid(bool bCheckNested = true)
		{
			USMInstance.__GetSingleActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetSingleActiveStateGuid_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(USMInstance.__GetSingleActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetSingleActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetSingleActiveStateGuid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060266FF RID: 157439 RVA: 0x003A7BE8 File Offset: 0x003A5DE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateMachineInstance GetRootStateMachineNodeInstance()
		{
			USMInstance.__GetRootStateMachineNodeInstance_FunctionParams* ptr = stackalloc USMInstance.__GetRootStateMachineNodeInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetRootStateMachineNodeInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetRootStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetRootStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x06026700 RID: 157440 RVA: 0x003A7C34 File Offset: 0x003A5E34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateMachineInstance GetRootStateMachineInstance()
		{
			USMInstance.__GetRootStateMachineInstance_FunctionParams* ptr = stackalloc USMInstance.__GetRootStateMachineInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetRootStateMachineInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetRootStateMachineInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetRootStateMachineInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x06026701 RID: 157441 RVA: 0x003A7C80 File Offset: 0x003A5E80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetReferenceOwner()
		{
			USMInstance.__GetReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetReferenceOwner_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026702 RID: 157442 RVA: 0x003A7CCC File Offset: 0x003A5ECC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetReferencedInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetReferencedInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetReferencedInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetReferencedInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetReferencedInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetReferencedInstanceByGuid_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026703 RID: 157443 RVA: 0x003A7D24 File Offset: 0x003A5F24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetPrimaryReferenceOwner()
		{
			USMInstance.__GetPrimaryReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetPrimaryReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetPrimaryReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetPrimaryReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetPrimaryReferenceOwner_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026704 RID: 157444 RVA: 0x003A7D70 File Offset: 0x003A5F70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMNodeInstance GetNodeInstanceByGuid(in FGuid Guid)
		{
			USMInstance.__GetNodeInstanceByGuid_FunctionParams* ptr = stackalloc USMInstance.__GetNodeInstanceByGuid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetNodeInstanceByGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNodeInstanceByGuid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Guid = Guid;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNodeInstanceByGuid_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMNodeInstance>(ptr->__Result);
		}

		// Token: 0x06026705 RID: 157445 RVA: 0x003A7DC8 File Offset: 0x003A5FC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISMStateMachineNetworkedInterface GetNetworkInterface()
		{
			USMInstance.__GetNetworkInterface_FunctionParams* ptr = stackalloc USMInstance.__GetNetworkInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetNetworkInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNetworkInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNetworkInterface_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISMStateMachineNetworkedInterface;
		}

		// Token: 0x06026706 RID: 157446 RVA: 0x003A7E20 File Offset: 0x003A6020
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetNestedActiveStateName()
		{
			USMInstance.__GetNestedActiveStateName_FunctionParams* ptr = stackalloc USMInstance.__GetNestedActiveStateName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetNestedActiveStateName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetNestedActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026707 RID: 157447 RVA: 0x003A7E80 File Offset: 0x003A6080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FGuid GetNestedActiveStateGuid()
		{
			USMInstance.__GetNestedActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetNestedActiveStateGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetNestedActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetNestedActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetNestedActiveStateGuid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026708 RID: 157448 RVA: 0x003A7EC8 File Offset: 0x003A60C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetMasterReferenceOwner()
		{
			USMInstance.__GetMasterReferenceOwner_FunctionParams* ptr = stackalloc USMInstance.__GetMasterReferenceOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetMasterReferenceOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetMasterReferenceOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetMasterReferenceOwner_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026709 RID: 157449 RVA: 0x003A7F14 File Offset: 0x003A6114
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FGuid, FGuid> GetGuidRedirectMap()
		{
			USMInstance.__GetGuidRedirectMap_FunctionParams* ptr = stackalloc USMInstance.__GetGuidRedirectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USMInstance.__GetGuidRedirectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FGuid, FGuid> result = new TMap<FGuid, FGuid>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetGuidRedirectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602670A RID: 157450 RVA: 0x003A7F74 File Offset: 0x003A6174
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UObject GetContext()
		{
			USMInstance.__GetContext_FunctionParams* ptr = stackalloc USMInstance.__GetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0602670B RID: 157451 RVA: 0x003A7FC0 File Offset: 0x003A61C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateMachineComponent GetComponentOwner()
		{
			USMInstance.__GetComponentOwner_FunctionParams* ptr = stackalloc USMInstance.__GetComponentOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMInstance.__GetComponentOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetComponentOwner_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetComponentOwner_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineComponent>(ptr->__Result);
		}

		// Token: 0x0602670C RID: 157452 RVA: 0x003A800C File Offset: 0x003A620C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllTransitionInstances_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMTransitionInstance> tarray2 = TransitionInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TransitionInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllTransitionInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602670D RID: 157453 RVA: 0x003A8088 File Offset: 0x003A6288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateInstance_Base> tarray2 = StateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602670E RID: 157454 RVA: 0x003A8104 File Offset: 0x003A6304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllRootNodeInstance_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateMachineInstance> tarray2 = Nodes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Nodes);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllRootNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602670F RID: 157455 RVA: 0x003A8180 File Offset: 0x003A6380
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<USMInstance> GetAllReferencedInstances(bool bIncludeChildren = false)
		{
			USMInstance.__GetAllReferencedInstances_FunctionParams* ptr = stackalloc USMInstance.__GetAllReferencedInstances_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMInstance.__GetAllReferencedInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIncludeChildren = bIncludeChildren;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMInstance> result = new TArray<USMInstance>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllReferencedInstances_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026710 RID: 157456 RVA: 0x003A81E8 File Offset: 0x003A63E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FGuid> GetAllCurrentStateGuids()
		{
			USMInstance.__GetAllCurrentStateGuids_FunctionParams* ptr = stackalloc USMInstance.__GetAllCurrentStateGuids_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllCurrentStateGuids_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> result = new TArray<FGuid>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllCurrentStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026711 RID: 157457 RVA: 0x003A8248 File Offset: 0x003A6448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllActiveStateInstances_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateInstance_Base> tarray2 = ActiveStateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveStateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllActiveStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026712 RID: 157458 RVA: 0x003A82C4 File Offset: 0x003A64C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetAllActiveStateGuids(ref TArray<FGuid> ActiveGuids)
		{
			USMInstance.__GetAllActiveStateGuids_FunctionParams* ptr = stackalloc USMInstance.__GetAllActiveStateGuids_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetAllActiveStateGuids_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = ActiveGuids;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ActiveGuids);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = ActiveGuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveGuids);
			}
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetAllActiveStateGuids_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026713 RID: 157459 RVA: 0x003A8340 File Offset: 0x003A6540
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetActiveStateName()
		{
			USMInstance.__GetActiveStateName_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMInstance.__GetActiveStateName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026714 RID: 157460 RVA: 0x003A83A0 File Offset: 0x003A65A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetActiveStateInstance(bool bCheckNested = true)
		{
			USMInstance.__GetActiveStateInstance_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCheckNested = bCheckNested;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x06026715 RID: 157461 RVA: 0x003A83F4 File Offset: 0x003A65F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FGuid GetActiveStateGuid()
		{
			USMInstance.__GetActiveStateGuid_FunctionParams* ptr = stackalloc USMInstance.__GetActiveStateGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__GetActiveStateGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__GetActiveStateGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__GetActiveStateGuid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026716 RID: 157462 RVA: 0x003A843A File Offset: 0x003A663A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EvaluateTransitions()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateTransitions_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026717 RID: 157463 RVA: 0x003A8450 File Offset: 0x003A6650
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool EvaluateAndTakeTransitionChain(USMTransitionInstance InFirstTransitionInstance)
		{
			USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams* ptr = stackalloc USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMInstance.__EvaluateAndTakeTransitionChain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__EvaluateAndTakeTransitionChain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFirstTransitionInstance = ((InFirstTransitionInstance != null) ? InFirstTransitionInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateAndTakeTransitionChain_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026718 RID: 157464 RVA: 0x003A84AC File Offset: 0x003A66AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__EvaluateAndFindTransitionChain_NativeFunctionPtr, (void*)ptr, 0);
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

		// Token: 0x06026719 RID: 157465 RVA: 0x003A856E File Offset: 0x003A676E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearStateHistory()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ClearStateHistory_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602671A RID: 157466 RVA: 0x003A8583 File Offset: 0x003A6783
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearLoadedStates()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__ClearLoadedStates_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602671B RID: 157467 RVA: 0x003A8598 File Offset: 0x003A6798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool CanTickOnManualUpdate()
		{
			USMInstance.__CanTickOnManualUpdate_FunctionParams* ptr = stackalloc USMInstance.__CanTickOnManualUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanTickOnManualUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanTickOnManualUpdate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602671C RID: 157468 RVA: 0x003A85E0 File Offset: 0x003A67E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool CanEverTick()
		{
			USMInstance.__CanEverTick_FunctionParams* ptr = stackalloc USMInstance.__CanEverTick_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanEverTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanEverTick_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanEverTick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602671D RID: 157469 RVA: 0x003A8628 File Offset: 0x003A6828
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool CanAutoManageTime()
		{
			USMInstance.__CanAutoManageTime_FunctionParams* ptr = stackalloc USMInstance.__CanAutoManageTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__CanAutoManageTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__CanAutoManageTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__CanAutoManageTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602671E RID: 157470 RVA: 0x003A8670 File Offset: 0x003A6870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool AreInitialStatesSetFromLoad()
		{
			USMInstance.__AreInitialStatesSetFromLoad_FunctionParams* ptr = stackalloc USMInstance.__AreInitialStatesSetFromLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMInstance.__AreInitialStatesSetFromLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMInstance.__AreInitialStatesSetFromLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMInstance.__AreInitialStatesSetFromLoad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602671F RID: 157471 RVA: 0x003A86B6 File Offset: 0x003A68B6
		static USMInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMInstance");
		}

		// Token: 0x06026720 RID: 157472 RVA: 0x003A86C4 File Offset: 0x003A68C4
		protected USMInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150F2 RID: 86258
		internal static int __InterfaceOffset_ISMStateMachineInterface;

		// Token: 0x040150F3 RID: 86259
		internal static int __InterfaceOffset_ISMInstanceInterface;

		// Token: 0x040150F4 RID: 86260
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMInstance";

		// Token: 0x040150F5 RID: 86261
		private static IntPtr _ClassPtr;

		// Token: 0x040150F6 RID: 86262
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150F7 RID: 86263
		internal static int __PropertyOffset_ReplicatedReferences;

		// Token: 0x040150F8 RID: 86264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMReferenceContainer> _ReplicatedReferences;

		// Token: 0x040150F9 RID: 86265
		internal static int __PropertyOffset_RootStateMachineGuid;

		// Token: 0x040150FA RID: 86266
		internal static int __PropertyOffset_AllRootNodeInstances;

		// Token: 0x040150FB RID: 86267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateMachineInstance> _AllRootNodeInstances;

		// Token: 0x040150FC RID: 86268
		internal static int __PropertyOffset_OnPreStateMachineInitializedEvent;

		// Token: 0x040150FD RID: 86269
		[Nullable(2)]
		private FOnStateMachineInitializedSignature _OnPreStateMachineInitializedEvent;

		// Token: 0x040150FE RID: 86270
		internal static int __PropertyOffset_OnStateMachineInitializedEvent;

		// Token: 0x040150FF RID: 86271
		[Nullable(2)]
		private FOnStateMachineInitializedSignature _OnStateMachineInitializedEvent;

		// Token: 0x04015100 RID: 86272
		internal static int __PropertyOffset_OnStateMachineStartedEvent;

		// Token: 0x04015101 RID: 86273
		[Nullable(2)]
		private FOnStateMachineStartedSignature _OnStateMachineStartedEvent;

		// Token: 0x04015102 RID: 86274
		internal static int __PropertyOffset_OnStateMachineUpdatedEvent;

		// Token: 0x04015103 RID: 86275
		[Nullable(2)]
		private FOnStateMachineUpdatedSignature _OnStateMachineUpdatedEvent;

		// Token: 0x04015104 RID: 86276
		internal static int __PropertyOffset_OnStateMachineStoppedEvent;

		// Token: 0x04015105 RID: 86277
		[Nullable(2)]
		private FOnStateMachineStoppedSignature _OnStateMachineStoppedEvent;

		// Token: 0x04015106 RID: 86278
		internal static int __PropertyOffset_OnStateMachineTransitionTakenEvent;

		// Token: 0x04015107 RID: 86279
		[Nullable(2)]
		private FOnStateMachineTransitionTakenSignature _OnStateMachineTransitionTakenEvent;

		// Token: 0x04015108 RID: 86280
		internal static int __PropertyOffset_OnStateMachineStateChangedEvent;

		// Token: 0x04015109 RID: 86281
		[Nullable(2)]
		private FOnStateMachineStateChangedSignature _OnStateMachineStateChangedEvent;

		// Token: 0x0401510A RID: 86282
		internal static int __PropertyOffset_OnStateMachineStateStartedEvent;

		// Token: 0x0401510B RID: 86283
		[Nullable(2)]
		private FOnStateMachineStateStartedSignature _OnStateMachineStateStartedEvent;

		// Token: 0x0401510C RID: 86284
		internal static int __PropertyOffset_ComponentOwner;

		// Token: 0x0401510D RID: 86285
		internal static int __PropertyOffset_NetworkInterface;

		// Token: 0x0401510E RID: 86286
		internal static int __PropertyOffset_RootStateMachine;

		// Token: 0x0401510F RID: 86287
		[Nullable(2)]
		private FSMStateMachine _RootStateMachine;

		// Token: 0x04015110 RID: 86288
		internal static int __PropertyOffset_R_StateMachineContext;

		// Token: 0x04015111 RID: 86289
		internal static int __PropertyOffset_ReferenceOwner;

		// Token: 0x04015112 RID: 86290
		internal static int __PropertyOffset_StateMachineClass;

		// Token: 0x04015113 RID: 86291
		internal static int __PropertyOffset_bAutoManageTime;

		// Token: 0x04015114 RID: 86292
		internal static byte __PropertyMask_bAutoManageTime;

		// Token: 0x04015115 RID: 86293
		internal static int __PropertyOffset_bStopOnEndState;

		// Token: 0x04015116 RID: 86294
		internal static byte __PropertyMask_bStopOnEndState;

		// Token: 0x04015117 RID: 86295
		internal static int __PropertyOffset_bCanEverTick;

		// Token: 0x04015118 RID: 86296
		internal static byte __PropertyMask_bCanEverTick;

		// Token: 0x04015119 RID: 86297
		internal static int __PropertyOffset_bCanTickWhenPaused;

		// Token: 0x0401511A RID: 86298
		internal static byte __PropertyMask_bCanTickWhenPaused;

		// Token: 0x0401511B RID: 86299
		internal static int __PropertyOffset_bTickRegistered;

		// Token: 0x0401511C RID: 86300
		internal static byte __PropertyMask_bTickRegistered;

		// Token: 0x0401511D RID: 86301
		internal static int __PropertyOffset_bTickBeforeInitialize;

		// Token: 0x0401511E RID: 86302
		internal static byte __PropertyMask_bTickBeforeInitialize;

		// Token: 0x0401511F RID: 86303
		internal static int __PropertyOffset_bTickBeforeBeginPlay;

		// Token: 0x04015120 RID: 86304
		internal static byte __PropertyMask_bTickBeforeBeginPlay;

		// Token: 0x04015121 RID: 86305
		internal static int __PropertyOffset_TickInterval;

		// Token: 0x04015122 RID: 86306
		internal static int __PropertyOffset_StateHistory;

		// Token: 0x04015123 RID: 86307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMStateHistory> _StateHistory;

		// Token: 0x04015124 RID: 86308
		internal static int __PropertyOffset_StateHistoryMaxCount;

		// Token: 0x04015125 RID: 86309
		internal static int __PropertyOffset_bEnableLogging;

		// Token: 0x04015126 RID: 86310
		internal static byte __PropertyMask_bEnableLogging;

		// Token: 0x04015127 RID: 86311
		internal static int __PropertyOffset_bLogStateChange;

		// Token: 0x04015128 RID: 86312
		internal static byte __PropertyMask_bLogStateChange;

		// Token: 0x04015129 RID: 86313
		internal static int __PropertyOffset_bLogTransitionTaken;

		// Token: 0x0401512A RID: 86314
		internal static byte __PropertyMask_bLogTransitionTaken;

		// Token: 0x0401512B RID: 86315
		internal static int __PropertyOffset_bCanReplicateAsReference;

		// Token: 0x0401512C RID: 86316
		internal static byte __PropertyMask_bCanReplicateAsReference;

		// Token: 0x0401512D RID: 86317
		internal static int __PropertyOffset_PathGuidRedirectMap;

		// Token: 0x0401512E RID: 86318
		[Nullable(2)]
		private TMap<FGuid, FGuid> _PathGuidRedirectMap;

		// Token: 0x0401512F RID: 86319
		internal static int __PropertyOffset_ReferenceTemplates;

		// Token: 0x04015130 RID: 86320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceTemplates;

		// Token: 0x04015131 RID: 86321
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04015132 RID: 86322
		private static IntPtr __TryGetTransitionInfo_NativeFunctionPtr;

		// Token: 0x04015133 RID: 86323
		private static IntPtr __TryGetStateInfo_NativeFunctionPtr;

		// Token: 0x04015134 RID: 86324
		private static IntPtr __TryGetNestedActiveState_NativeFunctionPtr;

		// Token: 0x04015135 RID: 86325
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04015136 RID: 86326
		private static IntPtr __TakeTransitionChain_NativeFunctionPtr;

		// Token: 0x04015137 RID: 86327
		private static IntPtr __SwitchActiveStateByQualifiedName_NativeFunctionPtr;

		// Token: 0x04015138 RID: 86328
		private static IntPtr __SwitchActiveState_NativeFunctionPtr;

		// Token: 0x04015139 RID: 86329
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0401513A RID: 86330
		private static IntPtr __StartWithNewContext_NativeFunctionPtr;

		// Token: 0x0401513B RID: 86331
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0401513C RID: 86332
		private static IntPtr __Shutdown_NativeFunctionPtr;

		// Token: 0x0401513D RID: 86333
		private static IntPtr __SetTickOnManualUpdate_NativeFunctionPtr;

		// Token: 0x0401513E RID: 86334
		private static IntPtr __SetTickInterval_NativeFunctionPtr;

		// Token: 0x0401513F RID: 86335
		private static IntPtr __SetTickBeforeBeginPlay_NativeFunctionPtr;

		// Token: 0x04015140 RID: 86336
		private static IntPtr __SetStopOnEndState_NativeFunctionPtr;

		// Token: 0x04015141 RID: 86337
		private static IntPtr __SetStateMachineClass_NativeFunctionPtr;

		// Token: 0x04015142 RID: 86338
		private static IntPtr __SetStateHistoryMaxCount_NativeFunctionPtr;

		// Token: 0x04015143 RID: 86339
		private static IntPtr __SetGuidRedirectMap_NativeFunctionPtr;

		// Token: 0x04015144 RID: 86340
		private static IntPtr __SetContext_NativeFunctionPtr;

		// Token: 0x04015145 RID: 86341
		private static IntPtr __SetCanTickWhenPaused_NativeFunctionPtr;

		// Token: 0x04015146 RID: 86342
		private static IntPtr __SetCanEverTick_NativeFunctionPtr;

		// Token: 0x04015147 RID: 86343
		private static IntPtr __SetAutoManageTime_NativeFunctionPtr;

		// Token: 0x04015148 RID: 86344
		private static IntPtr __RunUpdateAsReference_NativeFunctionPtr;

		// Token: 0x04015149 RID: 86345
		private static IntPtr __Restart_NativeFunctionPtr;

		// Token: 0x0401514A RID: 86346
		private static IntPtr __ReplicatedStop_NativeFunctionPtr;

		// Token: 0x0401514B RID: 86347
		private static IntPtr __ReplicatedStart_NativeFunctionPtr;

		// Token: 0x0401514C RID: 86348
		private static IntPtr __ReplicatedRestart_NativeFunctionPtr;

		// Token: 0x0401514D RID: 86349
		private static IntPtr __REP_OnReplicatedReferencesLoaded_NativeFunctionPtr;

		// Token: 0x0401514E RID: 86350
		private static IntPtr __PreloadAllNodeInstances_NativeFunctionPtr;

		// Token: 0x0401514F RID: 86351
		private static IntPtr __OnStateMachineUpdate_NativeFunctionPtr;

		// Token: 0x04015150 RID: 86352
		private static IntPtr __OnStateMachineTransitionTaken_NativeFunctionPtr;

		// Token: 0x04015151 RID: 86353
		private static IntPtr __OnStateMachineStop_NativeFunctionPtr;

		// Token: 0x04015152 RID: 86354
		private static IntPtr __OnStateMachineStateStarted_NativeFunctionPtr;

		// Token: 0x04015153 RID: 86355
		private static IntPtr __OnStateMachineStateChanged_NativeFunctionPtr;

		// Token: 0x04015154 RID: 86356
		private static IntPtr __OnStateMachineStart_NativeFunctionPtr;

		// Token: 0x04015155 RID: 86357
		private static IntPtr __OnStateMachineInitialStateLoaded_NativeFunctionPtr;

		// Token: 0x04015156 RID: 86358
		private static IntPtr __OnStateMachineInitialized_NativeFunctionPtr;

		// Token: 0x04015157 RID: 86359
		private static IntPtr __OnPreStateMachineInitialized_NativeFunctionPtr;

		// Token: 0x04015158 RID: 86360
		private static IntPtr __OnPostCompile_NativeFunctionPtr;

		// Token: 0x04015159 RID: 86361
		private static IntPtr __LoadFromState_NativeFunctionPtr;

		// Token: 0x0401515A RID: 86362
		private static IntPtr __LoadFromMultipleStates_NativeFunctionPtr;

		// Token: 0x0401515B RID: 86363
		private static IntPtr __K2_TryGetNetworkInterface_NativeFunctionPtr;

		// Token: 0x0401515C RID: 86364
		private static IntPtr __IsTickableWhenPaused_NativeFunctionPtr;

		// Token: 0x0401515D RID: 86365
		private static IntPtr __IsTickable_NativeFunctionPtr;

		// Token: 0x0401515E RID: 86366
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x0401515F RID: 86367
		private static IntPtr __IsInEndState_NativeFunctionPtr;

		// Token: 0x04015160 RID: 86368
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x04015161 RID: 86369
		private static IntPtr __Internal_Update_NativeFunctionPtr;

		// Token: 0x04015162 RID: 86370
		private static IntPtr __Internal_EventUpdate_NativeFunctionPtr;

		// Token: 0x04015163 RID: 86371
		private static IntPtr __Internal_EventCleanup_NativeFunctionPtr;

		// Token: 0x04015164 RID: 86372
		private static IntPtr __Internal_EvaluateAndTakeTransitionChainByGuid_NativeFunctionPtr;

		// Token: 0x04015165 RID: 86373
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04015166 RID: 86374
		private static IntPtr __HasStarted_NativeFunctionPtr;

		// Token: 0x04015167 RID: 86375
		private static IntPtr __GetTransitionInstanceByGuid_NativeFunctionPtr;

		// Token: 0x04015168 RID: 86376
		private static IntPtr __GetTickInterval_NativeFunctionPtr;

		// Token: 0x04015169 RID: 86377
		private static IntPtr __GetStopOnEndState_NativeFunctionPtr;

		// Token: 0x0401516A RID: 86378
		private static IntPtr __GetStateMachineClass_NativeFunctionPtr;

		// Token: 0x0401516B RID: 86379
		private static IntPtr __GetStateInstanceByQualifiedName_NativeFunctionPtr;

		// Token: 0x0401516C RID: 86380
		private static IntPtr __GetStateInstanceByGuid_NativeFunctionPtr;

		// Token: 0x0401516D RID: 86381
		private static IntPtr __GetStateHistoryMaxCount_NativeFunctionPtr;

		// Token: 0x0401516E RID: 86382
		private static IntPtr __GetStateHistory_NativeFunctionPtr;

		// Token: 0x0401516F RID: 86383
		private static IntPtr __GetSingleActiveStateInstance_NativeFunctionPtr;

		// Token: 0x04015170 RID: 86384
		private static IntPtr __GetSingleActiveStateGuid_NativeFunctionPtr;

		// Token: 0x04015171 RID: 86385
		private static IntPtr __GetRootStateMachineNodeInstance_NativeFunctionPtr;

		// Token: 0x04015172 RID: 86386
		private static IntPtr __GetRootStateMachineInstance_NativeFunctionPtr;

		// Token: 0x04015173 RID: 86387
		private static IntPtr __GetReferenceOwner_NativeFunctionPtr;

		// Token: 0x04015174 RID: 86388
		private static IntPtr __GetReferencedInstanceByGuid_NativeFunctionPtr;

		// Token: 0x04015175 RID: 86389
		private static IntPtr __GetPrimaryReferenceOwner_NativeFunctionPtr;

		// Token: 0x04015176 RID: 86390
		private static IntPtr __GetNodeInstanceByGuid_NativeFunctionPtr;

		// Token: 0x04015177 RID: 86391
		private static IntPtr __GetNetworkInterface_NativeFunctionPtr;

		// Token: 0x04015178 RID: 86392
		private static IntPtr __GetNestedActiveStateName_NativeFunctionPtr;

		// Token: 0x04015179 RID: 86393
		private static IntPtr __GetNestedActiveStateGuid_NativeFunctionPtr;

		// Token: 0x0401517A RID: 86394
		private static IntPtr __GetMasterReferenceOwner_NativeFunctionPtr;

		// Token: 0x0401517B RID: 86395
		private static IntPtr __GetGuidRedirectMap_NativeFunctionPtr;

		// Token: 0x0401517C RID: 86396
		private static IntPtr __GetContext_NativeFunctionPtr;

		// Token: 0x0401517D RID: 86397
		private static IntPtr __GetComponentOwner_NativeFunctionPtr;

		// Token: 0x0401517E RID: 86398
		private static IntPtr __GetAllTransitionInstances_NativeFunctionPtr;

		// Token: 0x0401517F RID: 86399
		private static IntPtr __GetAllStateInstances_NativeFunctionPtr;

		// Token: 0x04015180 RID: 86400
		private static IntPtr __GetAllRootNodeInstance_NativeFunctionPtr;

		// Token: 0x04015181 RID: 86401
		private static IntPtr __GetAllReferencedInstances_NativeFunctionPtr;

		// Token: 0x04015182 RID: 86402
		private static IntPtr __GetAllCurrentStateGuids_NativeFunctionPtr;

		// Token: 0x04015183 RID: 86403
		private static IntPtr __GetAllActiveStateInstances_NativeFunctionPtr;

		// Token: 0x04015184 RID: 86404
		private static IntPtr __GetAllActiveStateGuids_NativeFunctionPtr;

		// Token: 0x04015185 RID: 86405
		private static IntPtr __GetActiveStateName_NativeFunctionPtr;

		// Token: 0x04015186 RID: 86406
		private static IntPtr __GetActiveStateInstance_NativeFunctionPtr;

		// Token: 0x04015187 RID: 86407
		private static IntPtr __GetActiveStateGuid_NativeFunctionPtr;

		// Token: 0x04015188 RID: 86408
		private static IntPtr __EvaluateTransitions_NativeFunctionPtr;

		// Token: 0x04015189 RID: 86409
		private static IntPtr __EvaluateAndTakeTransitionChain_NativeFunctionPtr;

		// Token: 0x0401518A RID: 86410
		private static IntPtr __EvaluateAndFindTransitionChain_NativeFunctionPtr;

		// Token: 0x0401518B RID: 86411
		private static IntPtr __ClearStateHistory_NativeFunctionPtr;

		// Token: 0x0401518C RID: 86412
		private static IntPtr __ClearLoadedStates_NativeFunctionPtr;

		// Token: 0x0401518D RID: 86413
		private static IntPtr __CanTickOnManualUpdate_NativeFunctionPtr;

		// Token: 0x0401518E RID: 86414
		private static IntPtr __CanEverTick_NativeFunctionPtr;

		// Token: 0x0401518F RID: 86415
		private static IntPtr __CanAutoManageTime_NativeFunctionPtr;

		// Token: 0x04015190 RID: 86416
		private static IntPtr __AreInitialStatesSetFromLoad_NativeFunctionPtr;

		// Token: 0x02003A82 RID: 14978
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04017BEF RID: 97263
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003A83 RID: 14979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __TryGetTransitionInfo_FunctionParams
		{
			// Token: 0x04017BF0 RID: 97264
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017BF1 RID: 97265
			[FieldOffset(16)]
			public byte TransitionInfo;

			// Token: 0x04017BF2 RID: 97266
			[FieldOffset(168)]
			public bool bSuccess;
		}

		// Token: 0x02003A84 RID: 14980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __TryGetStateInfo_FunctionParams
		{
			// Token: 0x04017BF3 RID: 97267
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017BF4 RID: 97268
			[FieldOffset(16)]
			public byte StateInfo;

			// Token: 0x04017BF5 RID: 97269
			[FieldOffset(144)]
			public bool bSuccess;
		}

		// Token: 0x02003A85 RID: 14981
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __TryGetNestedActiveState_FunctionParams
		{
			// Token: 0x04017BF6 RID: 97270
			[FieldOffset(0)]
			public byte FoundState;

			// Token: 0x04017BF7 RID: 97271
			[FieldOffset(128)]
			public bool bSuccess;
		}

		// Token: 0x02003A86 RID: 14982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04017BF8 RID: 97272
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003A87 RID: 14983
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TakeTransitionChain_FunctionParams
		{
			// Token: 0x04017BF9 RID: 97273
			[FieldOffset(0)]
			public byte InTransitionChain;

			// Token: 0x04017BFA RID: 97274
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003A88 RID: 14984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SwitchActiveStateByQualifiedName_FunctionParams
		{
			// Token: 0x04017BFB RID: 97275
			[FieldOffset(0)]
			public FString InFullPath;

			// Token: 0x04017BFC RID: 97276
			[FieldOffset(16)]
			public bool bDeactivateOtherStates;
		}

		// Token: 0x02003A89 RID: 14985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchActiveState_FunctionParams
		{
			// Token: 0x04017BFD RID: 97277
			[FieldOffset(0)]
			public IntPtr NewStateInstance;

			// Token: 0x04017BFE RID: 97278
			[FieldOffset(8)]
			public bool bDeactivateOtherStates;
		}

		// Token: 0x02003A8A RID: 14986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartWithNewContext_FunctionParams
		{
			// Token: 0x04017BFF RID: 97279
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02003A8B RID: 14987
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickOnManualUpdate_FunctionParams
		{
			// Token: 0x04017C00 RID: 97280
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A8C RID: 14988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetTickInterval_FunctionParams
		{
			// Token: 0x04017C01 RID: 97281
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02003A8D RID: 14989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickBeforeBeginPlay_FunctionParams
		{
			// Token: 0x04017C02 RID: 97282
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A8E RID: 14990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetStopOnEndState_FunctionParams
		{
			// Token: 0x04017C03 RID: 97283
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A8F RID: 14991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStateMachineClass_FunctionParams
		{
			// Token: 0x04017C04 RID: 97284
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMStateMachineInstance> NewStateMachineClass;
		}

		// Token: 0x02003A90 RID: 14992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetStateHistoryMaxCount_FunctionParams
		{
			// Token: 0x04017C05 RID: 97285
			[FieldOffset(0)]
			public int NewSize;
		}

		// Token: 0x02003A91 RID: 14993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetGuidRedirectMap_FunctionParams
		{
			// Token: 0x04017C06 RID: 97286
			[FieldOffset(0)]
			public byte InGuidMap;
		}

		// Token: 0x02003A92 RID: 14994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetContext_FunctionParams
		{
			// Token: 0x04017C07 RID: 97287
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02003A93 RID: 14995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanTickWhenPaused_FunctionParams
		{
			// Token: 0x04017C08 RID: 97288
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A94 RID: 14996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEverTick_FunctionParams
		{
			// Token: 0x04017C09 RID: 97289
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A95 RID: 14997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAutoManageTime_FunctionParams
		{
			// Token: 0x04017C0A RID: 97290
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02003A96 RID: 14998
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RunUpdateAsReference_FunctionParams
		{
			// Token: 0x04017C0B RID: 97291
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003A97 RID: 14999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnStateMachineUpdate_FunctionParams
		{
			// Token: 0x04017C0C RID: 97292
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003A98 RID: 15000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __OnStateMachineTransitionTaken_FunctionParams
		{
			// Token: 0x04017C0D RID: 97293
			[FieldOffset(0)]
			public byte Transition;
		}

		// Token: 0x02003A99 RID: 15001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __OnStateMachineStateStarted_FunctionParams
		{
			// Token: 0x04017C0E RID: 97294
			[FieldOffset(0)]
			public byte State;
		}

		// Token: 0x02003A9A RID: 15002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __OnStateMachineStateChanged_FunctionParams
		{
			// Token: 0x04017C0F RID: 97295
			[FieldOffset(0)]
			public byte ToState;

			// Token: 0x04017C10 RID: 97296
			[FieldOffset(128)]
			public byte FromState;
		}

		// Token: 0x02003A9B RID: 15003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStateMachineInitialStateLoaded_FunctionParams
		{
			// Token: 0x04017C11 RID: 97297
			[FieldOffset(0)]
			public FGuid StateGuid;
		}

		// Token: 0x02003A9C RID: 15004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LoadFromState_FunctionParams
		{
			// Token: 0x04017C12 RID: 97298
			[FieldOffset(0)]
			public FGuid FromGuid;

			// Token: 0x04017C13 RID: 97299
			[FieldOffset(16)]
			public bool bAllParents;

			// Token: 0x04017C14 RID: 97300
			[FieldOffset(17)]
			public bool bNotify;
		}

		// Token: 0x02003A9D RID: 15005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __LoadFromMultipleStates_FunctionParams
		{
			// Token: 0x04017C15 RID: 97301
			[FieldOffset(0)]
			public byte FromGuids;

			// Token: 0x04017C16 RID: 97302
			[FieldOffset(16)]
			public bool bNotify;
		}

		// Token: 0x02003A9E RID: 15006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_TryGetNetworkInterface_FunctionParams
		{
			// Token: 0x04017C17 RID: 97303
			[FieldOffset(0)]
			public FScriptInterface Interface;

			// Token: 0x04017C18 RID: 97304
			[FieldOffset(16)]
			public bool bIsValid;
		}

		// Token: 0x02003A9F RID: 15007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTickableWhenPaused_FunctionParams
		{
			// Token: 0x04017C19 RID: 97305
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA0 RID: 15008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTickable_FunctionParams
		{
			// Token: 0x04017C1A RID: 97306
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA1 RID: 15009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x04017C1B RID: 97307
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA2 RID: 15010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInEndState_FunctionParams
		{
			// Token: 0x04017C1C RID: 97308
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA3 RID: 15011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x04017C1D RID: 97309
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA4 RID: 15012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Internal_Update_FunctionParams
		{
			// Token: 0x04017C1E RID: 97310
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003AA5 RID: 15013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Internal_EventCleanup_FunctionParams
		{
			// Token: 0x04017C1F RID: 97311
			[FieldOffset(0)]
			public FGuid PathGuid;
		}

		// Token: 0x02003AA6 RID: 15014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __Internal_EvaluateAndTakeTransitionChainByGuid_FunctionParams
		{
			// Token: 0x04017C20 RID: 97312
			[FieldOffset(0)]
			public FGuid PathGuid;

			// Token: 0x04017C21 RID: 97313
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003AA7 RID: 15015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04017C22 RID: 97314
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02003AA8 RID: 15016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasStarted_FunctionParams
		{
			// Token: 0x04017C23 RID: 97315
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AA9 RID: 15017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetTransitionInstanceByGuid_FunctionParams
		{
			// Token: 0x04017C24 RID: 97316
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017C25 RID: 97317
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AAA RID: 15018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTickInterval_FunctionParams
		{
			// Token: 0x04017C26 RID: 97318
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02003AAB RID: 15019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetStopOnEndState_FunctionParams
		{
			// Token: 0x04017C27 RID: 97319
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AAC RID: 15020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStateMachineClass_FunctionParams
		{
			// Token: 0x04017C28 RID: 97320
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMStateMachineInstance> __Result;
		}

		// Token: 0x02003AAD RID: 15021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetStateInstanceByQualifiedName_FunctionParams
		{
			// Token: 0x04017C29 RID: 97321
			[FieldOffset(0)]
			public FString InFullPath;

			// Token: 0x04017C2A RID: 97322
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AAE RID: 15022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetStateInstanceByGuid_FunctionParams
		{
			// Token: 0x04017C2B RID: 97323
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017C2C RID: 97324
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AAF RID: 15023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetStateHistoryMaxCount_FunctionParams
		{
			// Token: 0x04017C2D RID: 97325
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003AB0 RID: 15024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStateHistory_FunctionParams
		{
			// Token: 0x04017C2E RID: 97326
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003AB1 RID: 15025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSingleActiveStateInstance_FunctionParams
		{
			// Token: 0x04017C2F RID: 97327
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x04017C30 RID: 97328
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB2 RID: 15026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetSingleActiveStateGuid_FunctionParams
		{
			// Token: 0x04017C31 RID: 97329
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x04017C32 RID: 97330
			[FieldOffset(4)]
			public FGuid __Result;
		}

		// Token: 0x02003AB3 RID: 15027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRootStateMachineNodeInstance_FunctionParams
		{
			// Token: 0x04017C33 RID: 97331
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB4 RID: 15028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRootStateMachineInstance_FunctionParams
		{
			// Token: 0x04017C34 RID: 97332
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB5 RID: 15029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetReferenceOwner_FunctionParams
		{
			// Token: 0x04017C35 RID: 97333
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB6 RID: 15030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetReferencedInstanceByGuid_FunctionParams
		{
			// Token: 0x04017C36 RID: 97334
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017C37 RID: 97335
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB7 RID: 15031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPrimaryReferenceOwner_FunctionParams
		{
			// Token: 0x04017C38 RID: 97336
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB8 RID: 15032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeInstanceByGuid_FunctionParams
		{
			// Token: 0x04017C39 RID: 97337
			[FieldOffset(0)]
			public FGuid Guid;

			// Token: 0x04017C3A RID: 97338
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AB9 RID: 15033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNetworkInterface_FunctionParams
		{
			// Token: 0x04017C3B RID: 97339
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02003ABA RID: 15034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNestedActiveStateName_FunctionParams
		{
			// Token: 0x04017C3C RID: 97340
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003ABB RID: 15035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNestedActiveStateGuid_FunctionParams
		{
			// Token: 0x04017C3D RID: 97341
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02003ABC RID: 15036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetMasterReferenceOwner_FunctionParams
		{
			// Token: 0x04017C3E RID: 97342
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003ABD RID: 15037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetGuidRedirectMap_FunctionParams
		{
			// Token: 0x04017C3F RID: 97343
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003ABE RID: 15038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetContext_FunctionParams
		{
			// Token: 0x04017C40 RID: 97344
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003ABF RID: 15039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetComponentOwner_FunctionParams
		{
			// Token: 0x04017C41 RID: 97345
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AC0 RID: 15040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllTransitionInstances_FunctionParams
		{
			// Token: 0x04017C42 RID: 97346
			[FieldOffset(0)]
			public byte TransitionInstances;
		}

		// Token: 0x02003AC1 RID: 15041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllStateInstances_FunctionParams
		{
			// Token: 0x04017C43 RID: 97347
			[FieldOffset(0)]
			public byte StateInstances;
		}

		// Token: 0x02003AC2 RID: 15042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllRootNodeInstance_FunctionParams
		{
			// Token: 0x04017C44 RID: 97348
			[FieldOffset(0)]
			public byte Nodes;
		}

		// Token: 0x02003AC3 RID: 15043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllReferencedInstances_FunctionParams
		{
			// Token: 0x04017C45 RID: 97349
			[FieldOffset(0)]
			public bool bIncludeChildren;

			// Token: 0x04017C46 RID: 97350
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02003AC4 RID: 15044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllCurrentStateGuids_FunctionParams
		{
			// Token: 0x04017C47 RID: 97351
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003AC5 RID: 15045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllActiveStateInstances_FunctionParams
		{
			// Token: 0x04017C48 RID: 97352
			[FieldOffset(0)]
			public byte ActiveStateInstances;
		}

		// Token: 0x02003AC6 RID: 15046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllActiveStateGuids_FunctionParams
		{
			// Token: 0x04017C49 RID: 97353
			[FieldOffset(0)]
			public byte ActiveGuids;
		}

		// Token: 0x02003AC7 RID: 15047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateName_FunctionParams
		{
			// Token: 0x04017C4A RID: 97354
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003AC8 RID: 15048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateInstance_FunctionParams
		{
			// Token: 0x04017C4B RID: 97355
			[FieldOffset(0)]
			public bool bCheckNested;

			// Token: 0x04017C4C RID: 97356
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003AC9 RID: 15049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStateGuid_FunctionParams
		{
			// Token: 0x04017C4D RID: 97357
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02003ACA RID: 15050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __EvaluateAndTakeTransitionChain_FunctionParams
		{
			// Token: 0x04017C4E RID: 97358
			[FieldOffset(0)]
			public IntPtr InFirstTransitionInstance;

			// Token: 0x04017C4F RID: 97359
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02003ACB RID: 15051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __EvaluateAndFindTransitionChain_FunctionParams
		{
			// Token: 0x04017C50 RID: 97360
			[FieldOffset(0)]
			public IntPtr InFirstTransitionInstance;

			// Token: 0x04017C51 RID: 97361
			[FieldOffset(8)]
			public byte OutTransitionChain;

			// Token: 0x04017C52 RID: 97362
			[FieldOffset(24)]
			public IntPtr OutDestinationState;

			// Token: 0x04017C53 RID: 97363
			[FieldOffset(32)]
			public bool bRequirePreviousStateActive;

			// Token: 0x04017C54 RID: 97364
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x02003ACC RID: 15052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanTickOnManualUpdate_FunctionParams
		{
			// Token: 0x04017C55 RID: 97365
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003ACD RID: 15053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanEverTick_FunctionParams
		{
			// Token: 0x04017C56 RID: 97366
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003ACE RID: 15054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanAutoManageTime_FunctionParams
		{
			// Token: 0x04017C57 RID: 97367
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003ACF RID: 15055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreInitialStatesSetFromLoad_FunctionParams
		{
			// Token: 0x04017C58 RID: 97368
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
