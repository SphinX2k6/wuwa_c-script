using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CB RID: 715
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTasksComponent")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UGameplayTasksComponent : UActorComponent, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06004DDD RID: 19933 RVA: 0x0006CC51 File Offset: 0x0006AE51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTasksComponent._ClassPtr;
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x0006CC5D File Offset: 0x0006AE5D
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayTasksComponent.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x0006CC64 File Offset: 0x0006AE64
		public UGameplayTasksComponent() : this(BuiltinUtils.AllocNativeUObject(UGameplayTasksComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x0006CC8C File Offset: 0x0006AE8C
		public UGameplayTasksComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTasksComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x0006CCBF File Offset: 0x0006AEBF
		// (set) Token: 0x06004DE2 RID: 19938 RVA: 0x0006CCD8 File Offset: 0x0006AED8
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

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x0006CD08 File Offset: 0x0006AF08
		// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x0006CD41 File Offset: 0x0006AF41
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

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x0006CD50 File Offset: 0x0006AF50
		// (set) Token: 0x06004DE6 RID: 19942 RVA: 0x0006CD89 File Offset: 0x0006AF89
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

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x0006CD98 File Offset: 0x0006AF98
		// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x0006CDD1 File Offset: 0x0006AFD1
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

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
		// (set) Token: 0x06004DEA RID: 19946 RVA: 0x0006CE19 File Offset: 0x0006B019
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

		// Token: 0x06004DEB RID: 19947 RVA: 0x0006CE27 File Offset: 0x0006B027
		public void OnRep_SimulatedTasks()
		{
			UGameplayTasksComponent.__OnRep_SimulatedTasks_Internal(base.NativePtr);
		}

		// Token: 0x06004DEC RID: 19948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_SimulatedTasks_Internal(IntPtr @this);

		// Token: 0x06004DED RID: 19949 RVA: 0x0006CE34 File Offset: 0x0006B034
		static UGameplayTasksComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTasksComponent");
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x0006CE42 File Offset: 0x0006B042
		protected UGameplayTasksComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F15 RID: 7957
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04001F16 RID: 7958
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTasksComponent";

		// Token: 0x04001F17 RID: 7959
		private static IntPtr _ClassPtr;

		// Token: 0x04001F18 RID: 7960
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F19 RID: 7961
		internal static int __PropertyOffset_bIsNetDirty;

		// Token: 0x04001F1A RID: 7962
		internal static byte __PropertyMask_bIsNetDirty;

		// Token: 0x04001F1B RID: 7963
		internal static int __PropertyOffset_SimulatedTasks;

		// Token: 0x04001F1C RID: 7964
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _SimulatedTasks;

		// Token: 0x04001F1D RID: 7965
		internal static int __PropertyOffset_TaskPriorityQueue;

		// Token: 0x04001F1E RID: 7966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _TaskPriorityQueue;

		// Token: 0x04001F1F RID: 7967
		internal static int __PropertyOffset_TickingTasks;

		// Token: 0x04001F20 RID: 7968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _TickingTasks;

		// Token: 0x04001F21 RID: 7969
		internal static int __PropertyOffset_KnownTasks;

		// Token: 0x04001F22 RID: 7970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _KnownTasks;
	}
}
