using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C9 RID: 713
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UGameplayTask : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06004DCF RID: 19919 RVA: 0x0006CB91 File Offset: 0x0006AD91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask._ClassPtr;
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x0006CB9D File Offset: 0x0006AD9D
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayTask.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
		// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
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

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x0006CBCD File Offset: 0x0006ADCD
		// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x0006CBE1 File Offset: 0x0006ADE1
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

		// Token: 0x06004DD5 RID: 19925 RVA: 0x0006CBF6 File Offset: 0x0006ADF6
		public void ReadyForActivation()
		{
			UGameplayTask.__ReadyForActivation_Internal(base.NativePtr);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x0006CC03 File Offset: 0x0006AE03
		public void EndTask()
		{
			UGameplayTask.__EndTask_Internal(base.NativePtr);
		}

		// Token: 0x06004DD7 RID: 19927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReadyForActivation_Internal(IntPtr @this);

		// Token: 0x06004DD8 RID: 19928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTask_Internal(IntPtr @this);

		// Token: 0x06004DD9 RID: 19929 RVA: 0x0006CC10 File Offset: 0x0006AE10
		static UGameplayTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask");
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x0006CC20 File Offset: 0x0006AE20
		protected UGameplayTask() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x0006CC48 File Offset: 0x0006AE48
		protected UGameplayTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F0D RID: 7949
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04001F0E RID: 7950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask";

		// Token: 0x04001F0F RID: 7951
		private static IntPtr _ClassPtr;

		// Token: 0x04001F10 RID: 7952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F11 RID: 7953
		public static IntPtr __GenericGameplayTaskDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04001F12 RID: 7954
		internal static int __PropertyOffset_InstanceName;

		// Token: 0x04001F13 RID: 7955
		internal static int __PropertyOffset_ChildTask;
	}
}
