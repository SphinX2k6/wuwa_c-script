using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F5 RID: 5109
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask_ClaimResource")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGameplayTask_ClaimResource : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A87 RID: 76423 RVA: 0x001B7429 File Offset: 0x001B5629
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask_ClaimResource._ClassPtr;
		}

		// Token: 0x06012A88 RID: 76424 RVA: 0x001B7438 File Offset: 0x001B5638
		public UGameplayTask_ClaimResource() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_ClaimResource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A89 RID: 76425 RVA: 0x001B7460 File Offset: 0x001B5660
		[NullableContext(1)]
		public UGameplayTask_ClaimResource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_ClaimResource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012A8A RID: 76426 RVA: 0x001B7494 File Offset: 0x001B5694
		[NullableContext(2)]
		public static UGameplayTask_ClaimResource ClaimResources(IGameplayTaskOwnerInterface InTaskOwner, [Nullable(new byte[]
		{
			2,
			0,
			1
		})] TArray<TSubclassOf<UGameplayTaskResource>> ResourceClasses, byte Priority = 192, FName TaskInstanceName = default(FName))
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InTaskOwner, (InTaskOwner != null) ? InTaskOwner.InterfaceOffset() : 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayTask_ClaimResource>(UGameplayTask_ClaimResource.__ClaimResources_Internal(fscriptInterface, (ResourceClasses ?? new TArray<TSubclassOf<UGameplayTaskResource>>()).NativePtr, Priority, TaskInstanceName));
		}

		// Token: 0x06012A8B RID: 76427 RVA: 0x001B74D4 File Offset: 0x001B56D4
		[NullableContext(2)]
		public static UGameplayTask_ClaimResource ClaimResource(IGameplayTaskOwnerInterface InTaskOwner, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayTaskResource> ResourceClass, byte Priority = 192, FName TaskInstanceName = default(FName))
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InTaskOwner, (InTaskOwner != null) ? InTaskOwner.InterfaceOffset() : 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayTask_ClaimResource>(UGameplayTask_ClaimResource.__ClaimResource_Internal(fscriptInterface, ResourceClass._NativePtr, Priority, TaskInstanceName));
		}

		// Token: 0x06012A8C RID: 76428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ClaimResources_Internal(in FScriptInterface InTaskOwner, IntPtr ResourceClasses, byte Priority, FName TaskInstanceName);

		// Token: 0x06012A8D RID: 76429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ClaimResource_Internal(in FScriptInterface InTaskOwner, IntPtr ResourceClass, byte Priority, FName TaskInstanceName);

		// Token: 0x06012A8E RID: 76430 RVA: 0x001B7509 File Offset: 0x001B5709
		static UGameplayTask_ClaimResource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask_ClaimResource");
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x001B7517 File Offset: 0x001B5717
		protected UGameplayTask_ClaimResource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F8A RID: 40842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_ClaimResource";

		// Token: 0x04009F8B RID: 40843
		private static IntPtr _ClassPtr;

		// Token: 0x04009F8C RID: 40844
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
