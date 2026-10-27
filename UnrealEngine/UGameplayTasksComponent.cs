using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F3 RID: 5107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTasksComponent")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UGameplayTasksComponent : UActorComponent, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012A67 RID: 76391 RVA: 0x001B701D File Offset: 0x001B521D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTasksComponent._ClassPtr;
		}

		// Token: 0x06012A68 RID: 76392 RVA: 0x001B7029 File Offset: 0x001B5229
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayTasksComponent.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x06012A69 RID: 76393 RVA: 0x001B7030 File Offset: 0x001B5230
		public UGameplayTasksComponent() : this(BuiltinUtils.AllocNativeUObject(UGameplayTasksComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A6A RID: 76394 RVA: 0x001B7058 File Offset: 0x001B5258
		public UGameplayTasksComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTasksComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06012A6B RID: 76395 RVA: 0x001B708B File Offset: 0x001B528B
		// (set) Token: 0x06012A6C RID: 76396 RVA: 0x001B70A4 File Offset: 0x001B52A4
		public unsafe bool bIsNetDirty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_bIsNetDirty) & UGameplayTasksComponent.__PropertyMask_bIsNetDirty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_bIsNetDirty) = ((*(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_bIsNetDirty) & ~UGameplayTasksComponent.__PropertyMask_bIsNetDirty) | (value ? UGameplayTasksComponent.__PropertyMask_bIsNetDirty : 0));
			}
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x06012A6D RID: 76397 RVA: 0x001B70D4 File Offset: 0x001B52D4
		// (set) Token: 0x06012A6E RID: 76398 RVA: 0x001B710D File Offset: 0x001B530D
		public TArray<UGameplayTask> SimulatedTasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayTask> result;
				if ((result = this._SimulatedTasks) == null)
				{
					result = (this._SimulatedTasks = new TArray<UGameplayTask>(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_SimulatedTasks, this));
				}
				return result;
			}
			set
			{
				this.SimulatedTasks.CopyAssign(value);
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x06012A6F RID: 76399 RVA: 0x001B711C File Offset: 0x001B531C
		// (set) Token: 0x06012A70 RID: 76400 RVA: 0x001B7155 File Offset: 0x001B5355
		public TArray<UGameplayTask> TaskPriorityQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayTask> result;
				if ((result = this._TaskPriorityQueue) == null)
				{
					result = (this._TaskPriorityQueue = new TArray<UGameplayTask>(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_TaskPriorityQueue, this));
				}
				return result;
			}
			set
			{
				this.TaskPriorityQueue.CopyAssign(value);
			}
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06012A71 RID: 76401 RVA: 0x001B7164 File Offset: 0x001B5364
		// (set) Token: 0x06012A72 RID: 76402 RVA: 0x001B719D File Offset: 0x001B539D
		public TArray<UGameplayTask> TickingTasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayTask> result;
				if ((result = this._TickingTasks) == null)
				{
					result = (this._TickingTasks = new TArray<UGameplayTask>(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_TickingTasks, this));
				}
				return result;
			}
			set
			{
				this.TickingTasks.CopyAssign(value);
			}
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06012A73 RID: 76403 RVA: 0x001B71AC File Offset: 0x001B53AC
		// (set) Token: 0x06012A74 RID: 76404 RVA: 0x001B71E5 File Offset: 0x001B53E5
		public TArray<UGameplayTask> KnownTasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayTask> result;
				if ((result = this._KnownTasks) == null)
				{
					result = (this._KnownTasks = new TArray<UGameplayTask>(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_KnownTasks, this));
				}
				return result;
			}
			set
			{
				this.KnownTasks.CopyAssign(value);
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06012A75 RID: 76405 RVA: 0x001B71F4 File Offset: 0x001B53F4
		// (set) Token: 0x06012A76 RID: 76406 RVA: 0x001B722D File Offset: 0x001B542D
		public FOnClaimedResourcesChangeSignature OnClaimedResourcesChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnClaimedResourcesChangeSignature result;
				if ((result = this._OnClaimedResourcesChange) == null)
				{
					result = (this._OnClaimedResourcesChange = new FOnClaimedResourcesChangeSignature(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_OnClaimedResourcesChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTasksComponent.__PropertyOffset_OnClaimedResourcesChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012A77 RID: 76407 RVA: 0x001B724E File Offset: 0x001B544E
		public void OnRep_SimulatedTasks()
		{
			UGameplayTasksComponent.__OnRep_SimulatedTasks_Internal(base.NativePtr);
		}

		// Token: 0x06012A78 RID: 76408 RVA: 0x001B725C File Offset: 0x001B545C
		[NullableContext(2)]
		public static EGameplayTaskRunResult K2_RunGameplayTask(IGameplayTaskOwnerInterface TaskOwner, UGameplayTask Task, byte Priority, [Nullable(new byte[]
		{
			2,
			0,
			1
		})] TArray<TSubclassOf<UGameplayTaskResource>> AdditionalRequiredResources, [Nullable(new byte[]
		{
			2,
			0,
			1
		})] TArray<TSubclassOf<UGameplayTaskResource>> AdditionalClaimedResources)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			return UGameplayTasksComponent.__K2_RunGameplayTask_Internal(fscriptInterface, (Task != null) ? Task.NativePtr : IntPtr.Zero, Priority, (AdditionalRequiredResources ?? new TArray<TSubclassOf<UGameplayTaskResource>>()).NativePtr, (AdditionalClaimedResources ?? new TArray<TSubclassOf<UGameplayTaskResource>>()).NativePtr);
		}

		// Token: 0x06012A79 RID: 76409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_SimulatedTasks_Internal(IntPtr @this);

		// Token: 0x06012A7A RID: 76410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EGameplayTaskRunResult __K2_RunGameplayTask_Internal(in FScriptInterface TaskOwner, IntPtr Task, byte Priority, IntPtr AdditionalRequiredResources, IntPtr AdditionalClaimedResources);

		// Token: 0x06012A7B RID: 76411 RVA: 0x001B72B4 File Offset: 0x001B54B4
		static UGameplayTasksComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTasksComponent");
		}

		// Token: 0x06012A7C RID: 76412 RVA: 0x001B72C2 File Offset: 0x001B54C2
		protected UGameplayTasksComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F77 RID: 40823
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04009F78 RID: 40824
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTasksComponent";

		// Token: 0x04009F79 RID: 40825
		private static IntPtr _ClassPtr;

		// Token: 0x04009F7A RID: 40826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F7B RID: 40827
		internal static int __PropertyOffset_bIsNetDirty;

		// Token: 0x04009F7C RID: 40828
		internal static byte __PropertyMask_bIsNetDirty;

		// Token: 0x04009F7D RID: 40829
		internal static int __PropertyOffset_SimulatedTasks;

		// Token: 0x04009F7E RID: 40830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _SimulatedTasks;

		// Token: 0x04009F7F RID: 40831
		internal static int __PropertyOffset_TaskPriorityQueue;

		// Token: 0x04009F80 RID: 40832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _TaskPriorityQueue;

		// Token: 0x04009F81 RID: 40833
		internal static int __PropertyOffset_TickingTasks;

		// Token: 0x04009F82 RID: 40834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _TickingTasks;

		// Token: 0x04009F83 RID: 40835
		internal static int __PropertyOffset_KnownTasks;

		// Token: 0x04009F84 RID: 40836
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _KnownTasks;

		// Token: 0x04009F85 RID: 40837
		internal static int __PropertyOffset_OnClaimedResourcesChange;

		// Token: 0x04009F86 RID: 40838
		[Nullable(2)]
		private FOnClaimedResourcesChangeSignature _OnClaimedResourcesChange;
	}
}
