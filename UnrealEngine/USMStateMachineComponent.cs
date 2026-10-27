using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002897 RID: 10391
	[UnrealObjectPath("/Script/SMSystem.SMStateMachineComponent")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class USMStateMachineComponent : UActorComponent, IUnrealUObject, IUnrealObject, ISMStateMachineInterface, IUnrealNativeInterface, IUnrealInterface, ISMStateMachineNetworkedInterface
	{
		// Token: 0x0602681C RID: 157724 RVA: 0x003AA9A0 File Offset: 0x003A8BA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateMachineComponent._ClassPtr;
		}

		// Token: 0x0602681D RID: 157725 RVA: 0x003AA9AC File Offset: 0x003A8BAC
		int ISMStateMachineInterface.InterfaceOffset()
		{
			return USMStateMachineComponent.__InterfaceOffset_ISMStateMachineInterface;
		}

		// Token: 0x0602681E RID: 157726 RVA: 0x003AA9B3 File Offset: 0x003A8BB3
		int ISMStateMachineNetworkedInterface.InterfaceOffset()
		{
			return USMStateMachineComponent.__InterfaceOffset_ISMStateMachineNetworkedInterface;
		}

		// Token: 0x0602681F RID: 157727 RVA: 0x003AA9BC File Offset: 0x003A8BBC
		public USMStateMachineComponent() : this(BuiltinUtils.AllocNativeUObject(USMStateMachineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026820 RID: 157728 RVA: 0x003AA9E4 File Offset: 0x003A8BE4
		[NullableContext(1)]
		public USMStateMachineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMStateMachineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009476 RID: 38006
		// (get) Token: 0x06026821 RID: 157729 RVA: 0x003AAA18 File Offset: 0x003A8C18
		// (set) Token: 0x06026822 RID: 157730 RVA: 0x003AAA51 File Offset: 0x003A8C51
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
					result = (this._OnStateMachineInitializedEvent = new FOnStateMachineInitializedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineInitializedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineInitializedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009477 RID: 38007
		// (get) Token: 0x06026823 RID: 157731 RVA: 0x003AAA74 File Offset: 0x003A8C74
		// (set) Token: 0x06026824 RID: 157732 RVA: 0x003AAAAD File Offset: 0x003A8CAD
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
					result = (this._OnStateMachineStartedEvent = new FOnStateMachineStartedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStartedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStartedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009478 RID: 38008
		// (get) Token: 0x06026825 RID: 157733 RVA: 0x003AAAD0 File Offset: 0x003A8CD0
		// (set) Token: 0x06026826 RID: 157734 RVA: 0x003AAB09 File Offset: 0x003A8D09
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
					result = (this._OnStateMachineUpdatedEvent = new FOnStateMachineUpdatedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineUpdatedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineUpdatedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009479 RID: 38009
		// (get) Token: 0x06026827 RID: 157735 RVA: 0x003AAB2C File Offset: 0x003A8D2C
		// (set) Token: 0x06026828 RID: 157736 RVA: 0x003AAB65 File Offset: 0x003A8D65
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
					result = (this._OnStateMachineStoppedEvent = new FOnStateMachineStoppedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStoppedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStoppedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700947A RID: 38010
		// (get) Token: 0x06026829 RID: 157737 RVA: 0x003AAB88 File Offset: 0x003A8D88
		// (set) Token: 0x0602682A RID: 157738 RVA: 0x003AABC1 File Offset: 0x003A8DC1
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
					result = (this._OnStateMachineTransitionTakenEvent = new FOnStateMachineTransitionTakenSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineTransitionTakenEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineTransitionTakenEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700947B RID: 38011
		// (get) Token: 0x0602682B RID: 157739 RVA: 0x003AABE4 File Offset: 0x003A8DE4
		// (set) Token: 0x0602682C RID: 157740 RVA: 0x003AAC1D File Offset: 0x003A8E1D
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
					result = (this._OnStateMachineStateChangedEvent = new FOnStateMachineStateChangedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStateChangedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStateChangedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700947C RID: 38012
		// (get) Token: 0x0602682D RID: 157741 RVA: 0x003AAC40 File Offset: 0x003A8E40
		// (set) Token: 0x0602682E RID: 157742 RVA: 0x003AAC79 File Offset: 0x003A8E79
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
					result = (this._OnStateMachineStateStartedEvent = new FOnStateMachineStateStartedSignature(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStateStartedEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_OnStateMachineStateStartedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700947D RID: 38013
		// (get) Token: 0x0602682F RID: 157743 RVA: 0x003AAC9C File Offset: 0x003A8E9C
		// (set) Token: 0x06026830 RID: 157744 RVA: 0x003AACD5 File Offset: 0x003A8ED5
		[Nullable(1)]
		public TSet<UActorChannel> CurrentActorChannels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UActorChannel> result;
				if ((result = this._CurrentActorChannels) == null)
				{
					result = (this._CurrentActorChannels = new TSet<UActorChannel>(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_CurrentActorChannels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CurrentActorChannels.CopyAssign(value);
			}
		}

		// Token: 0x1700947E RID: 38014
		// (get) Token: 0x06026831 RID: 157745 RVA: 0x003AACE3 File Offset: 0x003A8EE3
		// (set) Token: 0x06026832 RID: 157746 RVA: 0x003AACFC File Offset: 0x003A8EFC
		public unsafe bool bAutomaticallyHandleNewConnections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAutomaticallyHandleNewConnections) & USMStateMachineComponent.__PropertyMask_bAutomaticallyHandleNewConnections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAutomaticallyHandleNewConnections) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAutomaticallyHandleNewConnections) & ~USMStateMachineComponent.__PropertyMask_bAutomaticallyHandleNewConnections) | (value ? USMStateMachineComponent.__PropertyMask_bAutomaticallyHandleNewConnections : 0));
			}
		}

		// Token: 0x1700947F RID: 38015
		// (get) Token: 0x06026833 RID: 157747 RVA: 0x003AAD2C File Offset: 0x003A8F2C
		// (set) Token: 0x06026834 RID: 157748 RVA: 0x003AAD40 File Offset: 0x003A8F40
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USMInstance> StateMachineClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_StateMachineClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_StateMachineClass) = value;
			}
		}

		// Token: 0x17009480 RID: 38016
		// (get) Token: 0x06026835 RID: 157749 RVA: 0x003AAD55 File Offset: 0x003A8F55
		// (set) Token: 0x06026836 RID: 157750 RVA: 0x003AAD6E File Offset: 0x003A8F6E
		public unsafe bool bInitializeOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bInitializeOnBeginPlay) & USMStateMachineComponent.__PropertyMask_bInitializeOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bInitializeOnBeginPlay) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bInitializeOnBeginPlay) & ~USMStateMachineComponent.__PropertyMask_bInitializeOnBeginPlay) | (value ? USMStateMachineComponent.__PropertyMask_bInitializeOnBeginPlay : 0));
			}
		}

		// Token: 0x17009481 RID: 38017
		// (get) Token: 0x06026837 RID: 157751 RVA: 0x003AAD9E File Offset: 0x003A8F9E
		// (set) Token: 0x06026838 RID: 157752 RVA: 0x003AADB7 File Offset: 0x003A8FB7
		public unsafe bool bStartOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) & USMStateMachineComponent.__PropertyMask_bStartOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) & ~USMStateMachineComponent.__PropertyMask_bStartOnBeginPlay) | (value ? USMStateMachineComponent.__PropertyMask_bStartOnBeginPlay : 0));
			}
		}

		// Token: 0x17009482 RID: 38018
		// (get) Token: 0x06026839 RID: 157753 RVA: 0x003AADE7 File Offset: 0x003A8FE7
		// (set) Token: 0x0602683A RID: 157754 RVA: 0x003AAE00 File Offset: 0x003A9000
		public unsafe bool bStopOnEndPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStopOnEndPlay) & USMStateMachineComponent.__PropertyMask_bStopOnEndPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStopOnEndPlay) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bStopOnEndPlay) & ~USMStateMachineComponent.__PropertyMask_bStopOnEndPlay) | (value ? USMStateMachineComponent.__PropertyMask_bStopOnEndPlay : 0));
			}
		}

		// Token: 0x17009483 RID: 38019
		// (get) Token: 0x0602683B RID: 157755 RVA: 0x003AAE30 File Offset: 0x003A9030
		// (set) Token: 0x0602683C RID: 157756 RVA: 0x003AAE49 File Offset: 0x003A9049
		public unsafe bool bLetInstanceManageTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bLetInstanceManageTick) & USMStateMachineComponent.__PropertyMask_bLetInstanceManageTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bLetInstanceManageTick) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bLetInstanceManageTick) & ~USMStateMachineComponent.__PropertyMask_bLetInstanceManageTick) | (value ? USMStateMachineComponent.__PropertyMask_bLetInstanceManageTick : 0));
			}
		}

		// Token: 0x17009484 RID: 38020
		// (get) Token: 0x0602683D RID: 157757 RVA: 0x003AAE79 File Offset: 0x003A9079
		// (set) Token: 0x0602683E RID: 157758 RVA: 0x003AAE92 File Offset: 0x003A9092
		public unsafe bool bReuseInstanceAfterShutdown
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReuseInstanceAfterShutdown) & USMStateMachineComponent.__PropertyMask_bReuseInstanceAfterShutdown) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReuseInstanceAfterShutdown) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReuseInstanceAfterShutdown) & ~USMStateMachineComponent.__PropertyMask_bReuseInstanceAfterShutdown) | (value ? USMStateMachineComponent.__PropertyMask_bReuseInstanceAfterShutdown : 0));
			}
		}

		// Token: 0x17009485 RID: 38021
		// (get) Token: 0x0602683F RID: 157759 RVA: 0x003AAEC2 File Offset: 0x003A90C2
		// (set) Token: 0x06026840 RID: 157760 RVA: 0x003AAED6 File Offset: 0x003A90D6
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> StateChangeAuthority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_StateChangeAuthority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_StateChangeAuthority) = value;
			}
		}

		// Token: 0x17009486 RID: 38022
		// (get) Token: 0x06026841 RID: 157761 RVA: 0x003AAEEB File Offset: 0x003A90EB
		// (set) Token: 0x06026842 RID: 157762 RVA: 0x003AAEFF File Offset: 0x003A90FF
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> NetworkTransitionConfiguration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTransitionConfiguration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTransitionConfiguration) = value;
			}
		}

		// Token: 0x17009487 RID: 38023
		// (get) Token: 0x06026843 RID: 157763 RVA: 0x003AAF14 File Offset: 0x003A9114
		// (set) Token: 0x06026844 RID: 157764 RVA: 0x003AAF28 File Offset: 0x003A9128
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> NetworkTickConfiguration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTickConfiguration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTickConfiguration) = value;
			}
		}

		// Token: 0x17009488 RID: 38024
		// (get) Token: 0x06026845 RID: 157765 RVA: 0x003AAF3D File Offset: 0x003A913D
		// (set) Token: 0x06026846 RID: 157766 RVA: 0x003AAF51 File Offset: 0x003A9151
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> NetworkStateExecution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkStateExecution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkStateExecution) = value;
			}
		}

		// Token: 0x17009489 RID: 38025
		// (get) Token: 0x06026847 RID: 157767 RVA: 0x003AAF66 File Offset: 0x003A9166
		// (set) Token: 0x06026848 RID: 157768 RVA: 0x003AAF7A File Offset: 0x003A917A
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> NetworkStateConfiguration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkStateConfiguration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkStateConfiguration) = value;
			}
		}

		// Token: 0x1700948A RID: 38026
		// (get) Token: 0x06026849 RID: 157769 RVA: 0x003AAF8F File Offset: 0x003A918F
		// (set) Token: 0x0602684A RID: 157770 RVA: 0x003AAFA8 File Offset: 0x003A91A8
		public unsafe bool bIncludeSimulatedProxies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bIncludeSimulatedProxies) & USMStateMachineComponent.__PropertyMask_bIncludeSimulatedProxies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bIncludeSimulatedProxies) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bIncludeSimulatedProxies) & ~USMStateMachineComponent.__PropertyMask_bIncludeSimulatedProxies) | (value ? USMStateMachineComponent.__PropertyMask_bIncludeSimulatedProxies : 0));
			}
		}

		// Token: 0x1700948B RID: 38027
		// (get) Token: 0x0602684B RID: 157771 RVA: 0x003AAFD8 File Offset: 0x003A91D8
		// (set) Token: 0x0602684C RID: 157772 RVA: 0x003AAFEC File Offset: 0x003A91EC
		public unsafe TEnumAsByte<ESMNetworkConfigurationType> NetworkTransitionEnteredConfiguration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTransitionEnteredConfiguration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_NetworkTransitionEnteredConfiguration) = value;
			}
		}

		// Token: 0x1700948C RID: 38028
		// (get) Token: 0x0602684D RID: 157773 RVA: 0x003AB001 File Offset: 0x003A9201
		// (set) Token: 0x0602684E RID: 157774 RVA: 0x003AB01A File Offset: 0x003A921A
		public unsafe bool bWaitForTransactionsFromServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bWaitForTransactionsFromServer) & USMStateMachineComponent.__PropertyMask_bWaitForTransactionsFromServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bWaitForTransactionsFromServer) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bWaitForTransactionsFromServer) & ~USMStateMachineComponent.__PropertyMask_bWaitForTransactionsFromServer) | (value ? USMStateMachineComponent.__PropertyMask_bWaitForTransactionsFromServer : 0));
			}
		}

		// Token: 0x1700948D RID: 38029
		// (get) Token: 0x0602684F RID: 157775 RVA: 0x003AB04A File Offset: 0x003A924A
		// (set) Token: 0x06026850 RID: 157776 RVA: 0x003AB063 File Offset: 0x003A9263
		public unsafe bool bTakeTransitionsFromServerOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bTakeTransitionsFromServerOnly) & USMStateMachineComponent.__PropertyMask_bTakeTransitionsFromServerOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bTakeTransitionsFromServerOnly) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bTakeTransitionsFromServerOnly) & ~USMStateMachineComponent.__PropertyMask_bTakeTransitionsFromServerOnly) | (value ? USMStateMachineComponent.__PropertyMask_bTakeTransitionsFromServerOnly : 0));
			}
		}

		// Token: 0x1700948E RID: 38030
		// (get) Token: 0x06026851 RID: 157777 RVA: 0x003AB093 File Offset: 0x003A9293
		// (set) Token: 0x06026852 RID: 157778 RVA: 0x003AB0AC File Offset: 0x003A92AC
		public unsafe bool bCalculateServerTimeForClients
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCalculateServerTimeForClients) & USMStateMachineComponent.__PropertyMask_bCalculateServerTimeForClients) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCalculateServerTimeForClients) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCalculateServerTimeForClients) & ~USMStateMachineComponent.__PropertyMask_bCalculateServerTimeForClients) | (value ? USMStateMachineComponent.__PropertyMask_bCalculateServerTimeForClients : 0));
			}
		}

		// Token: 0x1700948F RID: 38031
		// (get) Token: 0x06026853 RID: 157779 RVA: 0x003AB0DC File Offset: 0x003A92DC
		// (set) Token: 0x06026854 RID: 157780 RVA: 0x003AB0F5 File Offset: 0x003A92F5
		public unsafe bool bUseOwnerNetUpdateFrequency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bUseOwnerNetUpdateFrequency) & USMStateMachineComponent.__PropertyMask_bUseOwnerNetUpdateFrequency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bUseOwnerNetUpdateFrequency) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bUseOwnerNetUpdateFrequency) & ~USMStateMachineComponent.__PropertyMask_bUseOwnerNetUpdateFrequency) | (value ? USMStateMachineComponent.__PropertyMask_bUseOwnerNetUpdateFrequency : 0));
			}
		}

		// Token: 0x17009490 RID: 38032
		// (get) Token: 0x06026855 RID: 157781 RVA: 0x003AB125 File Offset: 0x003A9325
		// (set) Token: 0x06026856 RID: 157782 RVA: 0x003AB135 File Offset: 0x003A9335
		public unsafe float ServerNetUpdateFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_ServerNetUpdateFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_ServerNetUpdateFrequency) = value;
			}
		}

		// Token: 0x17009491 RID: 38033
		// (get) Token: 0x06026857 RID: 157783 RVA: 0x003AB146 File Offset: 0x003A9346
		// (set) Token: 0x06026858 RID: 157784 RVA: 0x003AB156 File Offset: 0x003A9356
		public unsafe float ClientNetUpdateFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_ClientNetUpdateFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_ClientNetUpdateFrequency) = value;
			}
		}

		// Token: 0x17009492 RID: 38034
		// (get) Token: 0x06026859 RID: 157785 RVA: 0x003AB167 File Offset: 0x003A9367
		// (set) Token: 0x0602685A RID: 157786 RVA: 0x003AB180 File Offset: 0x003A9380
		public unsafe bool bAlwaysMulticast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAlwaysMulticast) & USMStateMachineComponent.__PropertyMask_bAlwaysMulticast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAlwaysMulticast) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bAlwaysMulticast) & ~USMStateMachineComponent.__PropertyMask_bAlwaysMulticast) | (value ? USMStateMachineComponent.__PropertyMask_bAlwaysMulticast : 0));
			}
		}

		// Token: 0x17009493 RID: 38035
		// (get) Token: 0x0602685B RID: 157787 RVA: 0x003AB1B0 File Offset: 0x003A93B0
		// (set) Token: 0x0602685C RID: 157788 RVA: 0x003AB1C9 File Offset: 0x003A93C9
		public unsafe bool bDiscardTransitionsBeforeInitialize_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bDiscardTransitionsBeforeInitialize_DEPRECATED) & USMStateMachineComponent.__PropertyMask_bDiscardTransitionsBeforeInitialize_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bDiscardTransitionsBeforeInitialize_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bDiscardTransitionsBeforeInitialize_DEPRECATED) & ~USMStateMachineComponent.__PropertyMask_bDiscardTransitionsBeforeInitialize_DEPRECATED) | (value ? USMStateMachineComponent.__PropertyMask_bDiscardTransitionsBeforeInitialize_DEPRECATED : 0));
			}
		}

		// Token: 0x17009494 RID: 38036
		// (get) Token: 0x0602685D RID: 157789 RVA: 0x003AB1F9 File Offset: 0x003A93F9
		// (set) Token: 0x0602685E RID: 157790 RVA: 0x003AB212 File Offset: 0x003A9412
		public unsafe bool bReplicateStatesOnLoad_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReplicateStatesOnLoad_DEPRECATED) & USMStateMachineComponent.__PropertyMask_bReplicateStatesOnLoad_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReplicateStatesOnLoad_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bReplicateStatesOnLoad_DEPRECATED) & ~USMStateMachineComponent.__PropertyMask_bReplicateStatesOnLoad_DEPRECATED) | (value ? USMStateMachineComponent.__PropertyMask_bReplicateStatesOnLoad_DEPRECATED : 0));
			}
		}

		// Token: 0x17009495 RID: 38037
		// (get) Token: 0x0602685F RID: 157791 RVA: 0x003AB242 File Offset: 0x003A9442
		// (set) Token: 0x06026860 RID: 157792 RVA: 0x003AB252 File Offset: 0x003A9452
		public unsafe float TransitionResetTimeSeconds_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_TransitionResetTimeSeconds_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_TransitionResetTimeSeconds_DEPRECATED) = value;
			}
		}

		// Token: 0x17009496 RID: 38038
		// (get) Token: 0x06026861 RID: 157793 RVA: 0x003AB263 File Offset: 0x003A9463
		// (set) Token: 0x06026862 RID: 157794 RVA: 0x003AB273 File Offset: 0x003A9473
		public unsafe float MaxTimeToWaitForTransitionUpdate_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_MaxTimeToWaitForTransitionUpdate_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_MaxTimeToWaitForTransitionUpdate_DEPRECATED) = value;
			}
		}

		// Token: 0x17009497 RID: 38039
		// (get) Token: 0x06026863 RID: 157795 RVA: 0x003AB284 File Offset: 0x003A9484
		// (set) Token: 0x06026864 RID: 157796 RVA: 0x003AB298 File Offset: 0x003A9498
		[Nullable(2)]
		public unsafe USMStateMachineComponent ComponentToCopy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMStateMachineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_ComponentToCopy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_ComponentToCopy, value);
			}
		}

		// Token: 0x17009498 RID: 38040
		// (get) Token: 0x06026865 RID: 157797 RVA: 0x003AB2AD File Offset: 0x003A94AD
		// (set) Token: 0x06026866 RID: 157798 RVA: 0x003AB2C1 File Offset: 0x003A94C1
		[Nullable(2)]
		public unsafe USMInstance R_Instance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_R_Instance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_R_Instance, value);
			}
		}

		// Token: 0x17009499 RID: 38041
		// (get) Token: 0x06026867 RID: 157799 RVA: 0x003AB2D6 File Offset: 0x003A94D6
		// (set) Token: 0x06026868 RID: 157800 RVA: 0x003AB2EA File Offset: 0x003A94EA
		[Nullable(2)]
		public unsafe USMInstance InstanceTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_InstanceTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMStateMachineComponent.__PropertyOffset_InstanceTemplate, value);
			}
		}

		// Token: 0x1700949A RID: 38042
		// (get) Token: 0x06026869 RID: 157801 RVA: 0x003AB2FF File Offset: 0x003A94FF
		// (set) Token: 0x0602686A RID: 157802 RVA: 0x003AB318 File Offset: 0x003A9518
		public unsafe bool bOverrideTick_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTick_DEPRECATED) & USMStateMachineComponent.__PropertyMask_bOverrideTick_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTick_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTick_DEPRECATED) & ~USMStateMachineComponent.__PropertyMask_bOverrideTick_DEPRECATED) | (value ? USMStateMachineComponent.__PropertyMask_bOverrideTick_DEPRECATED : 0));
			}
		}

		// Token: 0x1700949B RID: 38043
		// (get) Token: 0x0602686B RID: 157803 RVA: 0x003AB348 File Offset: 0x003A9548
		// (set) Token: 0x0602686C RID: 157804 RVA: 0x003AB361 File Offset: 0x003A9561
		public unsafe bool bCanEverTick_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanEverTick_DEPRECATED) & USMStateMachineComponent.__PropertyMask_bCanEverTick_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanEverTick_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanEverTick_DEPRECATED) & ~USMStateMachineComponent.__PropertyMask_bCanEverTick_DEPRECATED) | (value ? USMStateMachineComponent.__PropertyMask_bCanEverTick_DEPRECATED : 0));
			}
		}

		// Token: 0x1700949C RID: 38044
		// (get) Token: 0x0602686D RID: 157805 RVA: 0x003AB391 File Offset: 0x003A9591
		// (set) Token: 0x0602686E RID: 157806 RVA: 0x003AB3AA File Offset: 0x003A95AA
		public unsafe bool bOverrideTickInterval_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTickInterval_DEPRECATED) & USMStateMachineComponent.__PropertyMask_bOverrideTickInterval_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTickInterval_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bOverrideTickInterval_DEPRECATED) & ~USMStateMachineComponent.__PropertyMask_bOverrideTickInterval_DEPRECATED) | (value ? USMStateMachineComponent.__PropertyMask_bOverrideTickInterval_DEPRECATED : 0));
			}
		}

		// Token: 0x1700949D RID: 38045
		// (get) Token: 0x0602686F RID: 157807 RVA: 0x003AB3DA File Offset: 0x003A95DA
		// (set) Token: 0x06026870 RID: 157808 RVA: 0x003AB3F3 File Offset: 0x003A95F3
		public unsafe bool bCanInstanceNetworkTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanInstanceNetworkTick) & USMStateMachineComponent.__PropertyMask_bCanInstanceNetworkTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanInstanceNetworkTick) = ((*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_bCanInstanceNetworkTick) & ~USMStateMachineComponent.__PropertyMask_bCanInstanceNetworkTick) | (value ? USMStateMachineComponent.__PropertyMask_bCanInstanceNetworkTick : 0));
			}
		}

		// Token: 0x1700949E RID: 38046
		// (get) Token: 0x06026871 RID: 157809 RVA: 0x003AB423 File Offset: 0x003A9623
		// (set) Token: 0x06026872 RID: 157810 RVA: 0x003AB433 File Offset: 0x003A9633
		public unsafe float TickInterval_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_TickInterval_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateMachineComponent.__PropertyOffset_TickInterval_DEPRECATED) = value;
			}
		}

		// Token: 0x06026873 RID: 157811 RVA: 0x003AB444 File Offset: 0x003A9644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Update(float DeltaSeconds)
		{
			USMStateMachineComponent.__Update_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMStateMachineComponent.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Update_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026874 RID: 157812 RVA: 0x003AB48B File Offset: 0x003A968B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Stop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026875 RID: 157813 RVA: 0x003AB4A0 File Offset: 0x003A96A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Start()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Start_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026876 RID: 157814 RVA: 0x003AB4B5 File Offset: 0x003A96B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Shutdown()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Shutdown_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026877 RID: 157815 RVA: 0x003AB4CC File Offset: 0x003A96CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanInstanceNetworkTick(bool bCanEverTick)
		{
			USMStateMachineComponent.__SetCanInstanceNetworkTick_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SetCanInstanceNetworkTick_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineComponent.__SetCanInstanceNetworkTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SetCanInstanceNetworkTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCanEverTick = bCanEverTick;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SetCanInstanceNetworkTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026878 RID: 157816 RVA: 0x003AB514 File Offset: 0x003A9714
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_Update(float DeltaTime)
		{
			USMStateMachineComponent.__SERVER_Update_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_Update_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_Update_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026879 RID: 157817 RVA: 0x003AB55C File Offset: 0x003A975C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_TakeTransitions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMTransitionTransaction> TransitionTransactions)
		{
			USMStateMachineComponent.__SERVER_TakeTransitions_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_TakeTransitions_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_TakeTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMTransitionTransaction> tarray = TransitionTransactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TransitionTransactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_TakeTransitions_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMTransitionTransaction> tarray2 = TransitionTransactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TransitionTransactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__SERVER_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602687A RID: 157818 RVA: 0x003AB5D8 File Offset: 0x003A97D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_Stop(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__SERVER_Stop_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_Stop_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_Stop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_Stop_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_Stop_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602687B RID: 157819 RVA: 0x003AB63C File Offset: 0x003A983C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_Start(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__SERVER_Start_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_Start_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_Start_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_Start_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602687C RID: 157820 RVA: 0x003AB6A0 File Offset: 0x003A98A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_Shutdown(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__SERVER_Shutdown_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_Shutdown_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_Shutdown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_Shutdown_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_Shutdown_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602687D RID: 157821 RVA: 0x003AB704 File Offset: 0x003A9904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void SERVER_RequestFullSync()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_RequestFullSync_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602687E RID: 157822 RVA: 0x003AB71C File Offset: 0x003A991C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_Initialize(in FSMInitializeTransaction Transaction)
		{
			USMStateMachineComponent.__SERVER_Initialize_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_Initialize_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_Initialize_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMInitializeTransaction.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602687F RID: 157823 RVA: 0x003AB780 File Offset: 0x003A9980
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_FullSync(in FSMFullSyncTransaction FullSyncTransaction)
		{
			USMStateMachineComponent.__SERVER_FullSync_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_FullSync_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_FullSync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_FullSync_NativeFunctionPtr, (void*)ptr, 1);
			if (FullSyncTransaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMFullSyncTransaction.StaticStruct(), &ptr->FullSyncTransaction, FullSyncTransaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_FullSync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__SERVER_FullSync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026880 RID: 157824 RVA: 0x003AB7F8 File Offset: 0x003A99F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SERVER_ActivateStates([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMActivateStateTransaction> StateTransactions)
		{
			USMStateMachineComponent.__SERVER_ActivateStates_FunctionParams* ptr = stackalloc USMStateMachineComponent.__SERVER_ActivateStates_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__SERVER_ActivateStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__SERVER_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMActivateStateTransaction> tarray = StateTransactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__SERVER_ActivateStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMActivateStateTransaction> tarray2 = StateTransactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__SERVER_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026881 RID: 157825 RVA: 0x003AB871 File Offset: 0x003A9A71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Restart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Restart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026882 RID: 157826 RVA: 0x003AB886 File Offset: 0x003A9A86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void REP_OnInstanceLoaded()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__REP_OnInstanceLoaded_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026883 RID: 157827 RVA: 0x003AB89B File Offset: 0x003A9A9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnPostInitialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMStateMachineComponent.__OnPostInitialize_NativeFunctionPtr, null);
		}

		// Token: 0x06026884 RID: 157828 RVA: 0x003AB8B0 File Offset: 0x003A9AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_TakeTransitions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMTransitionTransaction> Transactions)
		{
			USMStateMachineComponent.__MULTICAST_TakeTransitions_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_TakeTransitions_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_TakeTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMTransitionTransaction> tarray = Transactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Transactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_TakeTransitions_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMTransitionTransaction> tarray2 = Transactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__MULTICAST_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026885 RID: 157829 RVA: 0x003AB92C File Offset: 0x003A9B2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_Stop(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__MULTICAST_Stop_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_Stop_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_Stop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_Stop_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_Stop_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026886 RID: 157830 RVA: 0x003AB990 File Offset: 0x003A9B90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_Start(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__MULTICAST_Start_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_Start_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_Start_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_Start_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026887 RID: 157831 RVA: 0x003AB9F4 File Offset: 0x003A9BF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_Shutdown(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__MULTICAST_Shutdown_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_Shutdown_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_Shutdown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_Shutdown_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_Shutdown_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026888 RID: 157832 RVA: 0x003ABA58 File Offset: 0x003A9C58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_FullSync(in FSMFullSyncTransaction FullSyncTransaction)
		{
			USMStateMachineComponent.__MULTICAST_FullSync_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_FullSync_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_FullSync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_FullSync_NativeFunctionPtr, (void*)ptr, 1);
			if (FullSyncTransaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMFullSyncTransaction.StaticStruct(), &ptr->FullSyncTransaction, FullSyncTransaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_FullSync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__MULTICAST_FullSync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026889 RID: 157833 RVA: 0x003ABAD0 File Offset: 0x003A9CD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MULTICAST_ActivateStates([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMActivateStateTransaction> StateTransactions)
		{
			USMStateMachineComponent.__MULTICAST_ActivateStates_FunctionParams* ptr = stackalloc USMStateMachineComponent.__MULTICAST_ActivateStates_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__MULTICAST_ActivateStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__MULTICAST_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMActivateStateTransaction> tarray = StateTransactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__MULTICAST_ActivateStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMActivateStateTransaction> tarray2 = StateTransactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__MULTICAST_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602688A RID: 157834 RVA: 0x003ABB4C File Offset: 0x003A9D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsStateMachineActive()
		{
			USMStateMachineComponent.__IsStateMachineActive_FunctionParams* ptr = stackalloc USMStateMachineComponent.__IsStateMachineActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineComponent.__IsStateMachineActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__IsStateMachineActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__IsStateMachineActive_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602688B RID: 157835 RVA: 0x003ABB94 File Offset: 0x003A9D94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInitialized()
		{
			USMStateMachineComponent.__IsInitialized_FunctionParams* ptr = stackalloc USMStateMachineComponent.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineComponent.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__IsInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602688C RID: 157836 RVA: 0x003ABBDC File Offset: 0x003A9DDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineUpdated(USMInstance Instance, float DeltaSeconds)
		{
			USMStateMachineComponent.__Internal_OnStateMachineUpdated_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineUpdated_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineUpdated_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineUpdated_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineUpdated_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602688D RID: 157837 RVA: 0x003ABC3C File Offset: 0x003A9E3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineTransitionTaken(USMInstance Instance, FSMTransitionInfo Transition)
		{
			USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->Transition, Transition.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__Internal_OnStateMachineTransitionTaken_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602688E RID: 157838 RVA: 0x003ABCC8 File Offset: 0x003A9EC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineStopped(USMInstance Instance)
		{
			USMStateMachineComponent.__Internal_OnStateMachineStopped_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineStopped_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineStopped_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineStopped_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineStopped_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602688F RID: 157839 RVA: 0x003ABD20 File Offset: 0x003A9F20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineStateStarted(USMInstance Instance, FSMStateInfo State)
		{
			USMStateMachineComponent.__Internal_OnStateMachineStateStarted_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineStateStarted_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineStateStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->State, State.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__Internal_OnStateMachineStateStarted_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026890 RID: 157840 RVA: 0x003ABDAC File Offset: 0x003A9FAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineStateChanged(USMInstance Instance, FSMStateInfo ToState, FSMStateInfo FromState)
		{
			USMStateMachineComponent.__Internal_OnStateMachineStateChanged_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineStateChanged_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineStateChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (ToState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->ToState, ToState.NativePtr, 1, false);
			}
			if (FromState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->FromState, FromState.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__Internal_OnStateMachineStateChanged_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026891 RID: 157841 RVA: 0x003ABE5C File Offset: 0x003AA05C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnStateMachineStarted(USMInstance Instance)
		{
			USMStateMachineComponent.__Internal_OnStateMachineStarted_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnStateMachineStarted_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnStateMachineStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnStateMachineStarted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnStateMachineStarted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026892 RID: 157842 RVA: 0x003ABEB4 File Offset: 0x003AA0B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Internal_OnReplicatedInstanceInitialized(USMInstance Instance)
		{
			USMStateMachineComponent.__Internal_OnReplicatedInstanceInitialized_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Internal_OnReplicatedInstanceInitialized_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__Internal_OnReplicatedInstanceInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Internal_OnReplicatedInstanceInitialized_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Internal_OnReplicatedInstanceInitialized_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026893 RID: 157843 RVA: 0x003ABF0C File Offset: 0x003AA10C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(UObject Context = null)
		{
			USMStateMachineComponent.__Initialize_FunctionParams* ptr = stackalloc USMStateMachineComponent.__Initialize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026894 RID: 157844 RVA: 0x003ABF64 File Offset: 0x003AA164
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe AActor GetTopMostParentActor()
		{
			USMStateMachineComponent.__GetTopMostParentActor_FunctionParams* ptr = stackalloc USMStateMachineComponent.__GetTopMostParentActor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__GetTopMostParentActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__GetTopMostParentActor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__GetTopMostParentActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06026895 RID: 157845 RVA: 0x003ABFB0 File Offset: 0x003AA1B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetInstance()
		{
			USMStateMachineComponent.__GetInstance_FunctionParams* ptr = stackalloc USMStateMachineComponent.__GetInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__GetInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__GetInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__GetInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026896 RID: 157846 RVA: 0x003ABFFC File Offset: 0x003AA1FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual UObject GetContextForInitialization()
		{
			USMStateMachineComponent.__GetContextForInitialization_FunctionParams* ptr = stackalloc USMStateMachineComponent.__GetContextForInitialization_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__GetContextForInitialization_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__GetContextForInitialization_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, USMStateMachineComponent.__GetContextForInitialization_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x06026897 RID: 157847 RVA: 0x003AC048 File Offset: 0x003AA248
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual UObject GetContextForInitialization_Implementation()
		{
			USMStateMachineComponent.__GetContextForInitialization_FunctionParams* ptr = stackalloc USMStateMachineComponent.__GetContextForInitialization_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__GetContextForInitialization_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__GetContextForInitialization_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__GetContextForInitialization_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x06026898 RID: 157848 RVA: 0x003AC094 File Offset: 0x003AA294
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CopySettingsFromOtherComponent(USMStateMachineComponent OtherComponent)
		{
			USMStateMachineComponent.__CopySettingsFromOtherComponent_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CopySettingsFromOtherComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineComponent.__CopySettingsFromOtherComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CopySettingsFromOtherComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherComponent = ((OtherComponent != null) ? OtherComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CopySettingsFromOtherComponent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026899 RID: 157849 RVA: 0x003AC0EC File Offset: 0x003AA2EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_TakeTransitions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMTransitionTransaction> Transactions)
		{
			USMStateMachineComponent.__CLIENT_TakeTransitions_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_TakeTransitions_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_TakeTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMTransitionTransaction> tarray = Transactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Transactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_TakeTransitions_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMTransitionTransaction> tarray2 = Transactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__CLIENT_TakeTransitions_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602689A RID: 157850 RVA: 0x003AC168 File Offset: 0x003AA368
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_Stop(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__CLIENT_Stop_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_Stop_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_Stop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_Stop_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_Stop_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602689B RID: 157851 RVA: 0x003AC1CC File Offset: 0x003AA3CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_Start(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__CLIENT_Start_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_Start_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_Start_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_Start_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602689C RID: 157852 RVA: 0x003AC230 File Offset: 0x003AA430
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_Shutdown(in FSMTransaction_Base Transaction)
		{
			USMStateMachineComponent.__CLIENT_Shutdown_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_Shutdown_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_Shutdown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_Shutdown_NativeFunctionPtr, (void*)ptr, 1);
			if (Transaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransaction_Base.StaticStruct(), &ptr->Transaction, Transaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_Shutdown_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602689D RID: 157853 RVA: 0x003AC294 File Offset: 0x003AA494
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_FullSync(in FSMFullSyncTransaction FullSyncTransaction)
		{
			USMStateMachineComponent.__CLIENT_FullSync_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_FullSync_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_FullSync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_FullSync_NativeFunctionPtr, (void*)ptr, 1);
			if (FullSyncTransaction != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMFullSyncTransaction.StaticStruct(), &ptr->FullSyncTransaction, FullSyncTransaction.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_FullSync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__CLIENT_FullSync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602689E RID: 157854 RVA: 0x003AC30C File Offset: 0x003AA50C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CLIENT_ActivateStates([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSMActivateStateTransaction> StateTransactions)
		{
			USMStateMachineComponent.__CLIENT_ActivateStates_FunctionParams* ptr = stackalloc USMStateMachineComponent.__CLIENT_ActivateStates_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineComponent.__CLIENT_ActivateStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineComponent.__CLIENT_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSMActivateStateTransaction> tarray = StateTransactions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineComponent.__CLIENT_ActivateStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSMActivateStateTransaction> tarray2 = StateTransactions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateTransactions);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineComponent.__CLIENT_ActivateStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602689F RID: 157855 RVA: 0x003AC385 File Offset: 0x003AA585
		static USMStateMachineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateMachineComponent");
		}

		// Token: 0x060268A0 RID: 157856 RVA: 0x003AC393 File Offset: 0x003AA593
		protected USMStateMachineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401522F RID: 86575
		internal static int __InterfaceOffset_ISMStateMachineInterface;

		// Token: 0x04015230 RID: 86576
		internal static int __InterfaceOffset_ISMStateMachineNetworkedInterface;

		// Token: 0x04015231 RID: 86577
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateMachineComponent";

		// Token: 0x04015232 RID: 86578
		private static IntPtr _ClassPtr;

		// Token: 0x04015233 RID: 86579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015234 RID: 86580
		internal static int __PropertyOffset_OnStateMachineInitializedEvent;

		// Token: 0x04015235 RID: 86581
		[Nullable(2)]
		private FOnStateMachineInitializedSignature _OnStateMachineInitializedEvent;

		// Token: 0x04015236 RID: 86582
		internal static int __PropertyOffset_OnStateMachineStartedEvent;

		// Token: 0x04015237 RID: 86583
		[Nullable(2)]
		private FOnStateMachineStartedSignature _OnStateMachineStartedEvent;

		// Token: 0x04015238 RID: 86584
		internal static int __PropertyOffset_OnStateMachineUpdatedEvent;

		// Token: 0x04015239 RID: 86585
		[Nullable(2)]
		private FOnStateMachineUpdatedSignature _OnStateMachineUpdatedEvent;

		// Token: 0x0401523A RID: 86586
		internal static int __PropertyOffset_OnStateMachineStoppedEvent;

		// Token: 0x0401523B RID: 86587
		[Nullable(2)]
		private FOnStateMachineStoppedSignature _OnStateMachineStoppedEvent;

		// Token: 0x0401523C RID: 86588
		internal static int __PropertyOffset_OnStateMachineTransitionTakenEvent;

		// Token: 0x0401523D RID: 86589
		[Nullable(2)]
		private FOnStateMachineTransitionTakenSignature _OnStateMachineTransitionTakenEvent;

		// Token: 0x0401523E RID: 86590
		internal static int __PropertyOffset_OnStateMachineStateChangedEvent;

		// Token: 0x0401523F RID: 86591
		[Nullable(2)]
		private FOnStateMachineStateChangedSignature _OnStateMachineStateChangedEvent;

		// Token: 0x04015240 RID: 86592
		internal static int __PropertyOffset_OnStateMachineStateStartedEvent;

		// Token: 0x04015241 RID: 86593
		[Nullable(2)]
		private FOnStateMachineStateStartedSignature _OnStateMachineStateStartedEvent;

		// Token: 0x04015242 RID: 86594
		internal static int __PropertyOffset_CurrentActorChannels;

		// Token: 0x04015243 RID: 86595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorChannel> _CurrentActorChannels;

		// Token: 0x04015244 RID: 86596
		internal static int __PropertyOffset_bAutomaticallyHandleNewConnections;

		// Token: 0x04015245 RID: 86597
		internal static byte __PropertyMask_bAutomaticallyHandleNewConnections;

		// Token: 0x04015246 RID: 86598
		internal static int __PropertyOffset_StateMachineClass;

		// Token: 0x04015247 RID: 86599
		internal static int __PropertyOffset_bInitializeOnBeginPlay;

		// Token: 0x04015248 RID: 86600
		internal static byte __PropertyMask_bInitializeOnBeginPlay;

		// Token: 0x04015249 RID: 86601
		internal static int __PropertyOffset_bStartOnBeginPlay;

		// Token: 0x0401524A RID: 86602
		internal static byte __PropertyMask_bStartOnBeginPlay;

		// Token: 0x0401524B RID: 86603
		internal static int __PropertyOffset_bStopOnEndPlay;

		// Token: 0x0401524C RID: 86604
		internal static byte __PropertyMask_bStopOnEndPlay;

		// Token: 0x0401524D RID: 86605
		internal static int __PropertyOffset_bLetInstanceManageTick;

		// Token: 0x0401524E RID: 86606
		internal static byte __PropertyMask_bLetInstanceManageTick;

		// Token: 0x0401524F RID: 86607
		internal static int __PropertyOffset_bReuseInstanceAfterShutdown;

		// Token: 0x04015250 RID: 86608
		internal static byte __PropertyMask_bReuseInstanceAfterShutdown;

		// Token: 0x04015251 RID: 86609
		internal static int __PropertyOffset_StateChangeAuthority;

		// Token: 0x04015252 RID: 86610
		internal static int __PropertyOffset_NetworkTransitionConfiguration;

		// Token: 0x04015253 RID: 86611
		internal static int __PropertyOffset_NetworkTickConfiguration;

		// Token: 0x04015254 RID: 86612
		internal static int __PropertyOffset_NetworkStateExecution;

		// Token: 0x04015255 RID: 86613
		internal static int __PropertyOffset_NetworkStateConfiguration;

		// Token: 0x04015256 RID: 86614
		internal static int __PropertyOffset_bIncludeSimulatedProxies;

		// Token: 0x04015257 RID: 86615
		internal static byte __PropertyMask_bIncludeSimulatedProxies;

		// Token: 0x04015258 RID: 86616
		internal static int __PropertyOffset_NetworkTransitionEnteredConfiguration;

		// Token: 0x04015259 RID: 86617
		internal static int __PropertyOffset_bWaitForTransactionsFromServer;

		// Token: 0x0401525A RID: 86618
		internal static byte __PropertyMask_bWaitForTransactionsFromServer;

		// Token: 0x0401525B RID: 86619
		internal static int __PropertyOffset_bTakeTransitionsFromServerOnly;

		// Token: 0x0401525C RID: 86620
		internal static byte __PropertyMask_bTakeTransitionsFromServerOnly;

		// Token: 0x0401525D RID: 86621
		internal static int __PropertyOffset_bCalculateServerTimeForClients;

		// Token: 0x0401525E RID: 86622
		internal static byte __PropertyMask_bCalculateServerTimeForClients;

		// Token: 0x0401525F RID: 86623
		internal static int __PropertyOffset_bUseOwnerNetUpdateFrequency;

		// Token: 0x04015260 RID: 86624
		internal static byte __PropertyMask_bUseOwnerNetUpdateFrequency;

		// Token: 0x04015261 RID: 86625
		internal static int __PropertyOffset_ServerNetUpdateFrequency;

		// Token: 0x04015262 RID: 86626
		internal static int __PropertyOffset_ClientNetUpdateFrequency;

		// Token: 0x04015263 RID: 86627
		internal static int __PropertyOffset_bAlwaysMulticast;

		// Token: 0x04015264 RID: 86628
		internal static byte __PropertyMask_bAlwaysMulticast;

		// Token: 0x04015265 RID: 86629
		internal static int __PropertyOffset_bDiscardTransitionsBeforeInitialize_DEPRECATED;

		// Token: 0x04015266 RID: 86630
		internal static byte __PropertyMask_bDiscardTransitionsBeforeInitialize_DEPRECATED;

		// Token: 0x04015267 RID: 86631
		internal static int __PropertyOffset_bReplicateStatesOnLoad_DEPRECATED;

		// Token: 0x04015268 RID: 86632
		internal static byte __PropertyMask_bReplicateStatesOnLoad_DEPRECATED;

		// Token: 0x04015269 RID: 86633
		internal static int __PropertyOffset_TransitionResetTimeSeconds_DEPRECATED;

		// Token: 0x0401526A RID: 86634
		internal static int __PropertyOffset_MaxTimeToWaitForTransitionUpdate_DEPRECATED;

		// Token: 0x0401526B RID: 86635
		internal static int __PropertyOffset_ComponentToCopy;

		// Token: 0x0401526C RID: 86636
		internal static int __PropertyOffset_R_Instance;

		// Token: 0x0401526D RID: 86637
		internal static int __PropertyOffset_InstanceTemplate;

		// Token: 0x0401526E RID: 86638
		internal static int __PropertyOffset_bOverrideTick_DEPRECATED;

		// Token: 0x0401526F RID: 86639
		internal static byte __PropertyMask_bOverrideTick_DEPRECATED;

		// Token: 0x04015270 RID: 86640
		internal static int __PropertyOffset_bCanEverTick_DEPRECATED;

		// Token: 0x04015271 RID: 86641
		internal static byte __PropertyMask_bCanEverTick_DEPRECATED;

		// Token: 0x04015272 RID: 86642
		internal static int __PropertyOffset_bOverrideTickInterval_DEPRECATED;

		// Token: 0x04015273 RID: 86643
		internal static byte __PropertyMask_bOverrideTickInterval_DEPRECATED;

		// Token: 0x04015274 RID: 86644
		internal static int __PropertyOffset_bCanInstanceNetworkTick;

		// Token: 0x04015275 RID: 86645
		internal static byte __PropertyMask_bCanInstanceNetworkTick;

		// Token: 0x04015276 RID: 86646
		internal static int __PropertyOffset_TickInterval_DEPRECATED;

		// Token: 0x04015277 RID: 86647
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04015278 RID: 86648
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04015279 RID: 86649
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0401527A RID: 86650
		private static IntPtr __Shutdown_NativeFunctionPtr;

		// Token: 0x0401527B RID: 86651
		private static IntPtr __SetCanInstanceNetworkTick_NativeFunctionPtr;

		// Token: 0x0401527C RID: 86652
		private static IntPtr __SERVER_Update_NativeFunctionPtr;

		// Token: 0x0401527D RID: 86653
		private static IntPtr __SERVER_TakeTransitions_NativeFunctionPtr;

		// Token: 0x0401527E RID: 86654
		private static IntPtr __SERVER_Stop_NativeFunctionPtr;

		// Token: 0x0401527F RID: 86655
		private static IntPtr __SERVER_Start_NativeFunctionPtr;

		// Token: 0x04015280 RID: 86656
		private static IntPtr __SERVER_Shutdown_NativeFunctionPtr;

		// Token: 0x04015281 RID: 86657
		private static IntPtr __SERVER_RequestFullSync_NativeFunctionPtr;

		// Token: 0x04015282 RID: 86658
		private static IntPtr __SERVER_Initialize_NativeFunctionPtr;

		// Token: 0x04015283 RID: 86659
		private static IntPtr __SERVER_FullSync_NativeFunctionPtr;

		// Token: 0x04015284 RID: 86660
		private static IntPtr __SERVER_ActivateStates_NativeFunctionPtr;

		// Token: 0x04015285 RID: 86661
		private static IntPtr __Restart_NativeFunctionPtr;

		// Token: 0x04015286 RID: 86662
		private static IntPtr __REP_OnInstanceLoaded_NativeFunctionPtr;

		// Token: 0x04015287 RID: 86663
		private static IntPtr __OnPostInitialize_NativeFunctionPtr;

		// Token: 0x04015288 RID: 86664
		private static IntPtr __MULTICAST_TakeTransitions_NativeFunctionPtr;

		// Token: 0x04015289 RID: 86665
		private static IntPtr __MULTICAST_Stop_NativeFunctionPtr;

		// Token: 0x0401528A RID: 86666
		private static IntPtr __MULTICAST_Start_NativeFunctionPtr;

		// Token: 0x0401528B RID: 86667
		private static IntPtr __MULTICAST_Shutdown_NativeFunctionPtr;

		// Token: 0x0401528C RID: 86668
		private static IntPtr __MULTICAST_FullSync_NativeFunctionPtr;

		// Token: 0x0401528D RID: 86669
		private static IntPtr __MULTICAST_ActivateStates_NativeFunctionPtr;

		// Token: 0x0401528E RID: 86670
		private static IntPtr __IsStateMachineActive_NativeFunctionPtr;

		// Token: 0x0401528F RID: 86671
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x04015290 RID: 86672
		private static IntPtr __Internal_OnStateMachineUpdated_NativeFunctionPtr;

		// Token: 0x04015291 RID: 86673
		private static IntPtr __Internal_OnStateMachineTransitionTaken_NativeFunctionPtr;

		// Token: 0x04015292 RID: 86674
		private static IntPtr __Internal_OnStateMachineStopped_NativeFunctionPtr;

		// Token: 0x04015293 RID: 86675
		private static IntPtr __Internal_OnStateMachineStateStarted_NativeFunctionPtr;

		// Token: 0x04015294 RID: 86676
		private static IntPtr __Internal_OnStateMachineStateChanged_NativeFunctionPtr;

		// Token: 0x04015295 RID: 86677
		private static IntPtr __Internal_OnStateMachineStarted_NativeFunctionPtr;

		// Token: 0x04015296 RID: 86678
		private static IntPtr __Internal_OnReplicatedInstanceInitialized_NativeFunctionPtr;

		// Token: 0x04015297 RID: 86679
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04015298 RID: 86680
		private static IntPtr __GetTopMostParentActor_NativeFunctionPtr;

		// Token: 0x04015299 RID: 86681
		private static IntPtr __GetInstance_NativeFunctionPtr;

		// Token: 0x0401529A RID: 86682
		private static IntPtr __GetContextForInitialization_NativeFunctionPtr;

		// Token: 0x0401529B RID: 86683
		private static IntPtr __CopySettingsFromOtherComponent_NativeFunctionPtr;

		// Token: 0x0401529C RID: 86684
		private static IntPtr __CLIENT_TakeTransitions_NativeFunctionPtr;

		// Token: 0x0401529D RID: 86685
		private static IntPtr __CLIENT_Stop_NativeFunctionPtr;

		// Token: 0x0401529E RID: 86686
		private static IntPtr __CLIENT_Start_NativeFunctionPtr;

		// Token: 0x0401529F RID: 86687
		private static IntPtr __CLIENT_Shutdown_NativeFunctionPtr;

		// Token: 0x040152A0 RID: 86688
		private static IntPtr __CLIENT_FullSync_NativeFunctionPtr;

		// Token: 0x040152A1 RID: 86689
		private static IntPtr __CLIENT_ActivateStates_NativeFunctionPtr;

		// Token: 0x02003AF6 RID: 15094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04017C94 RID: 97428
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003AF7 RID: 15095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanInstanceNetworkTick_FunctionParams
		{
			// Token: 0x04017C95 RID: 97429
			[FieldOffset(0)]
			public bool bCanEverTick;
		}

		// Token: 0x02003AF8 RID: 15096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SERVER_Update_FunctionParams
		{
			// Token: 0x04017C96 RID: 97430
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003AF9 RID: 15097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SERVER_TakeTransitions_FunctionParams
		{
			// Token: 0x04017C97 RID: 97431
			[FieldOffset(0)]
			public byte TransitionTransactions;
		}

		// Token: 0x02003AFA RID: 15098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SERVER_Stop_FunctionParams
		{
			// Token: 0x04017C98 RID: 97432
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003AFB RID: 15099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SERVER_Start_FunctionParams
		{
			// Token: 0x04017C99 RID: 97433
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003AFC RID: 15100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SERVER_Shutdown_FunctionParams
		{
			// Token: 0x04017C9A RID: 97434
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003AFD RID: 15101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SERVER_Initialize_FunctionParams
		{
			// Token: 0x04017C9B RID: 97435
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003AFE RID: 15102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SERVER_FullSync_FunctionParams
		{
			// Token: 0x04017C9C RID: 97436
			[FieldOffset(0)]
			public byte FullSyncTransaction;
		}

		// Token: 0x02003AFF RID: 15103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SERVER_ActivateStates_FunctionParams
		{
			// Token: 0x04017C9D RID: 97437
			[FieldOffset(0)]
			public byte StateTransactions;
		}

		// Token: 0x02003B00 RID: 15104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MULTICAST_TakeTransitions_FunctionParams
		{
			// Token: 0x04017C9E RID: 97438
			[FieldOffset(0)]
			public byte Transactions;
		}

		// Token: 0x02003B01 RID: 15105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __MULTICAST_Stop_FunctionParams
		{
			// Token: 0x04017C9F RID: 97439
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B02 RID: 15106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __MULTICAST_Start_FunctionParams
		{
			// Token: 0x04017CA0 RID: 97440
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B03 RID: 15107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __MULTICAST_Shutdown_FunctionParams
		{
			// Token: 0x04017CA1 RID: 97441
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B04 RID: 15108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __MULTICAST_FullSync_FunctionParams
		{
			// Token: 0x04017CA2 RID: 97442
			[FieldOffset(0)]
			public byte FullSyncTransaction;
		}

		// Token: 0x02003B05 RID: 15109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MULTICAST_ActivateStates_FunctionParams
		{
			// Token: 0x04017CA3 RID: 97443
			[FieldOffset(0)]
			public byte StateTransactions;
		}

		// Token: 0x02003B06 RID: 15110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStateMachineActive_FunctionParams
		{
			// Token: 0x04017CA4 RID: 97444
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B07 RID: 15111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x04017CA5 RID: 97445
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B08 RID: 15112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Internal_OnStateMachineUpdated_FunctionParams
		{
			// Token: 0x04017CA6 RID: 97446
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017CA7 RID: 97447
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02003B09 RID: 15113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __Internal_OnStateMachineTransitionTaken_FunctionParams
		{
			// Token: 0x04017CA8 RID: 97448
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017CA9 RID: 97449
			[FieldOffset(8)]
			public byte Transition;
		}

		// Token: 0x02003B0A RID: 15114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Internal_OnStateMachineStopped_FunctionParams
		{
			// Token: 0x04017CAA RID: 97450
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003B0B RID: 15115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __Internal_OnStateMachineStateStarted_FunctionParams
		{
			// Token: 0x04017CAB RID: 97451
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017CAC RID: 97452
			[FieldOffset(8)]
			public byte State;
		}

		// Token: 0x02003B0C RID: 15116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected ref struct __Internal_OnStateMachineStateChanged_FunctionParams
		{
			// Token: 0x04017CAD RID: 97453
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017CAE RID: 97454
			[FieldOffset(8)]
			public byte ToState;

			// Token: 0x04017CAF RID: 97455
			[FieldOffset(136)]
			public byte FromState;
		}

		// Token: 0x02003B0D RID: 15117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Internal_OnStateMachineStarted_FunctionParams
		{
			// Token: 0x04017CB0 RID: 97456
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003B0E RID: 15118
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Internal_OnReplicatedInstanceInitialized_FunctionParams
		{
			// Token: 0x04017CB1 RID: 97457
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003B0F RID: 15119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04017CB2 RID: 97458
			[FieldOffset(0)]
			public IntPtr Context;
		}

		// Token: 0x02003B10 RID: 15120
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTopMostParentActor_FunctionParams
		{
			// Token: 0x04017CB3 RID: 97459
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B11 RID: 15121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetInstance_FunctionParams
		{
			// Token: 0x04017CB4 RID: 97460
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B12 RID: 15122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetContextForInitialization_FunctionParams
		{
			// Token: 0x04017CB5 RID: 97461
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B13 RID: 15123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CopySettingsFromOtherComponent_FunctionParams
		{
			// Token: 0x04017CB6 RID: 97462
			[FieldOffset(0)]
			public IntPtr OtherComponent;
		}

		// Token: 0x02003B14 RID: 15124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CLIENT_TakeTransitions_FunctionParams
		{
			// Token: 0x04017CB7 RID: 97463
			[FieldOffset(0)]
			public byte Transactions;
		}

		// Token: 0x02003B15 RID: 15125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __CLIENT_Stop_FunctionParams
		{
			// Token: 0x04017CB8 RID: 97464
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B16 RID: 15126
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __CLIENT_Start_FunctionParams
		{
			// Token: 0x04017CB9 RID: 97465
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B17 RID: 15127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __CLIENT_Shutdown_FunctionParams
		{
			// Token: 0x04017CBA RID: 97466
			[FieldOffset(0)]
			public byte Transaction;
		}

		// Token: 0x02003B18 RID: 15128
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CLIENT_FullSync_FunctionParams
		{
			// Token: 0x04017CBB RID: 97467
			[FieldOffset(0)]
			public byte FullSyncTransaction;
		}

		// Token: 0x02003B19 RID: 15129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CLIENT_ActivateStates_FunctionParams
		{
			// Token: 0x04017CBC RID: 97468
			[FieldOffset(0)]
			public byte StateTransactions;
		}
	}
}
