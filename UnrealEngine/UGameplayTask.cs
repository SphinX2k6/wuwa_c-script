using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F0 RID: 5104
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UGameplayTask : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012A4D RID: 76365 RVA: 0x001B6E64 File Offset: 0x001B5064
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask._ClassPtr;
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x001B6E70 File Offset: 0x001B5070
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayTask.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x06012A4F RID: 76367 RVA: 0x001B6E77 File Offset: 0x001B5077
		// (set) Token: 0x06012A50 RID: 76368 RVA: 0x001B6E8B File Offset: 0x001B508B
		public unsafe FName InstanceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTask.__PropertyOffset_InstanceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTask.__PropertyOffset_InstanceName) = value;
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x06012A51 RID: 76369 RVA: 0x001B6EA0 File Offset: 0x001B50A0
		// (set) Token: 0x06012A52 RID: 76370 RVA: 0x001B6EB0 File Offset: 0x001B50B0
		public unsafe ETaskResourceOverlapPolicy ResourceOverlapPolicy
		{
			get
			{
				return (ETaskResourceOverlapPolicy)(*(base.NativePtr + (IntPtr)UGameplayTask.__PropertyOffset_ResourceOverlapPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTask.__PropertyOffset_ResourceOverlapPolicy) = (byte)value;
			}
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x06012A53 RID: 76371 RVA: 0x001B6EC1 File Offset: 0x001B50C1
		// (set) Token: 0x06012A54 RID: 76372 RVA: 0x001B6ED5 File Offset: 0x001B50D5
		[Nullable(2)]
		public unsafe UGameplayTask ChildTask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayTask.__PropertyOffset_ChildTask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayTask.__PropertyOffset_ChildTask, value);
			}
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x001B6EEA File Offset: 0x001B50EA
		public void ReadyForActivation()
		{
			UGameplayTask.__ReadyForActivation_Internal(base.NativePtr);
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x001B6EF7 File Offset: 0x001B50F7
		public void EndTask()
		{
			UGameplayTask.__EndTask_Internal(base.NativePtr);
		}

		// Token: 0x06012A57 RID: 76375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReadyForActivation_Internal(IntPtr @this);

		// Token: 0x06012A58 RID: 76376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTask_Internal(IntPtr @this);

		// Token: 0x06012A59 RID: 76377 RVA: 0x001B6F04 File Offset: 0x001B5104
		static UGameplayTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask");
		}

		// Token: 0x06012A5A RID: 76378 RVA: 0x001B6F14 File Offset: 0x001B5114
		protected UGameplayTask() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A5B RID: 76379 RVA: 0x001B6F3C File Offset: 0x001B513C
		protected UGameplayTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F67 RID: 40807
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04009F68 RID: 40808
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask";

		// Token: 0x04009F69 RID: 40809
		private static IntPtr _ClassPtr;

		// Token: 0x04009F6A RID: 40810
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F6B RID: 40811
		public static IntPtr __GenericGameplayTaskDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04009F6C RID: 40812
		internal static int __PropertyOffset_InstanceName;

		// Token: 0x04009F6D RID: 40813
		internal static int __PropertyOffset_ResourceOverlapPolicy;

		// Token: 0x04009F6E RID: 40814
		internal static int __PropertyOffset_ChildTask;
	}
}
