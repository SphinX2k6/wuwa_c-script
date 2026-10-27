using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F6 RID: 5110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask_SpawnActor")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UGameplayTask_SpawnActor : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A90 RID: 76432 RVA: 0x001B7520 File Offset: 0x001B5720
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask_SpawnActor._ClassPtr;
		}

		// Token: 0x06012A91 RID: 76433 RVA: 0x001B752C File Offset: 0x001B572C
		public UGameplayTask_SpawnActor() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_SpawnActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A92 RID: 76434 RVA: 0x001B7554 File Offset: 0x001B5754
		public UGameplayTask_SpawnActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_SpawnActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06012A93 RID: 76435 RVA: 0x001B7588 File Offset: 0x001B5788
		// (set) Token: 0x06012A94 RID: 76436 RVA: 0x001B75C1 File Offset: 0x001B57C1
		public FGameplayTaskSpawnActorDelegate Success
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTaskSpawnActorDelegate result;
				if ((result = this._Success) == null)
				{
					result = (this._Success = new FGameplayTaskSpawnActorDelegate(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_Success, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_Success, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06012A95 RID: 76437 RVA: 0x001B75E4 File Offset: 0x001B57E4
		// (set) Token: 0x06012A96 RID: 76438 RVA: 0x001B761D File Offset: 0x001B581D
		public FGameplayTaskSpawnActorDelegate DidNotSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTaskSpawnActorDelegate result;
				if ((result = this._DidNotSpawn) == null)
				{
					result = (this._DidNotSpawn = new FGameplayTaskSpawnActorDelegate(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_DidNotSpawn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_DidNotSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06012A97 RID: 76439 RVA: 0x001B763E File Offset: 0x001B583E
		// (set) Token: 0x06012A98 RID: 76440 RVA: 0x001B7652 File Offset: 0x001B5852
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ClassToSpawn
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_ClassToSpawn);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTask_SpawnActor.__PropertyOffset_ClassToSpawn) = value;
			}
		}

		// Token: 0x06012A99 RID: 76441 RVA: 0x001B7668 File Offset: 0x001B5868
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UGameplayTask_SpawnActor SpawnActor(IGameplayTaskOwnerInterface TaskOwner, FVector SpawnLocation, FRotator SpawnRotation, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, bool bSpawnOnlyOnAuthority = false)
		{
			UGameplayTask_SpawnActor.__SpawnActor_FunctionParams* ptr = stackalloc UGameplayTask_SpawnActor.__SpawnActor_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UGameplayTask_SpawnActor.__SpawnActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayTask_SpawnActor.__SpawnActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskOwner = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			ptr->SpawnLocation = SpawnLocation;
			ptr->SpawnRotation = SpawnRotation;
			ptr->Class = Class;
			ptr->bSpawnOnlyOnAuthority = bSpawnOnlyOnAuthority;
			UnrealReflectionUtils.CallUFunction(UGameplayTask_SpawnActor._ClassDefaultObjectPtr, UGameplayTask_SpawnActor.__SpawnActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayTask_SpawnActor>(ptr->__Result);
		}

		// Token: 0x06012A9A RID: 76442 RVA: 0x001B76E8 File Offset: 0x001B58E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void FinishSpawningActor(UObject WorldContextObject, AActor SpawnedActor)
		{
			UGameplayTask_SpawnActor.__FinishSpawningActor_FunctionParams* ptr = stackalloc UGameplayTask_SpawnActor.__FinishSpawningActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGameplayTask_SpawnActor.__FinishSpawningActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayTask_SpawnActor.__FinishSpawningActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->SpawnedActor = ((SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGameplayTask_SpawnActor.__FinishSpawningActor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x001B7754 File Offset: 0x001B5954
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BeginSpawningActor(UObject WorldContextObject, ref AActor SpawnedActor)
		{
			UGameplayTask_SpawnActor.__BeginSpawningActor_FunctionParams* ptr = stackalloc UGameplayTask_SpawnActor.__BeginSpawningActor_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGameplayTask_SpawnActor.__BeginSpawningActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayTask_SpawnActor.__BeginSpawningActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ref UGameplayTask_SpawnActor.__BeginSpawningActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = SpawnedActor;
			ptr2.SpawnedActor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGameplayTask_SpawnActor.__BeginSpawningActor_NativeFunctionPtr, (void*)ptr, 0);
			SpawnedActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->SpawnedActor);
			return ptr->__Result;
		}

		// Token: 0x06012A9C RID: 76444 RVA: 0x001B77D5 File Offset: 0x001B59D5
		static UGameplayTask_SpawnActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask_SpawnActor");
		}

		// Token: 0x06012A9D RID: 76445 RVA: 0x001B77E3 File Offset: 0x001B59E3
		protected UGameplayTask_SpawnActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F8D RID: 40845
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_SpawnActor";

		// Token: 0x04009F8E RID: 40846
		private static IntPtr _ClassPtr;

		// Token: 0x04009F8F RID: 40847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F90 RID: 40848
		internal static int __PropertyOffset_Success;

		// Token: 0x04009F91 RID: 40849
		[Nullable(2)]
		private FGameplayTaskSpawnActorDelegate _Success;

		// Token: 0x04009F92 RID: 40850
		internal static int __PropertyOffset_DidNotSpawn;

		// Token: 0x04009F93 RID: 40851
		[Nullable(2)]
		private FGameplayTaskSpawnActorDelegate _DidNotSpawn;

		// Token: 0x04009F94 RID: 40852
		internal static int __PropertyOffset_ClassToSpawn;

		// Token: 0x04009F95 RID: 40853
		private static IntPtr __SpawnActor_NativeFunctionPtr;

		// Token: 0x04009F96 RID: 40854
		private static IntPtr __FinishSpawningActor_NativeFunctionPtr;

		// Token: 0x04009F97 RID: 40855
		private static IntPtr __BeginSpawningActor_NativeFunctionPtr;

		// Token: 0x02002E75 RID: 11893
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SpawnActor_FunctionParams
		{
			// Token: 0x0401693C RID: 92476
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x0401693D RID: 92477
			[FieldOffset(16)]
			public FVector SpawnLocation;

			// Token: 0x0401693E RID: 92478
			[FieldOffset(28)]
			public FRotator SpawnRotation;

			// Token: 0x0401693F RID: 92479
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(40)]
			public TSubclassOf<AActor> Class;

			// Token: 0x04016940 RID: 92480
			[FieldOffset(48)]
			public bool bSpawnOnlyOnAuthority;

			// Token: 0x04016941 RID: 92481
			[FieldOffset(56)]
			public IntPtr __Result;
		}

		// Token: 0x02002E76 RID: 11894
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FinishSpawningActor_FunctionParams
		{
			// Token: 0x04016942 RID: 92482
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016943 RID: 92483
			[FieldOffset(8)]
			public IntPtr SpawnedActor;
		}

		// Token: 0x02002E77 RID: 11895
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BeginSpawningActor_FunctionParams
		{
			// Token: 0x04016944 RID: 92484
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016945 RID: 92485
			[FieldOffset(8)]
			public IntPtr SpawnedActor;

			// Token: 0x04016946 RID: 92486
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
