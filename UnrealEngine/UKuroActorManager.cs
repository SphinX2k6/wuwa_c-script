using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CB RID: 1483
	[UnrealObjectPath("/Script/KuroUtility.KuroActorManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroActorManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083C2 RID: 33730 RVA: 0x000C3201 File Offset: 0x000C1401
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorManager._ClassPtr;
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x000C3210 File Offset: 0x000C1410
		public UKuroActorManager() : this(BuiltinUtils.AllocNativeUObject(UKuroActorManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x000C3238 File Offset: 0x000C1438
		[NullableContext(1)]
		public UKuroActorManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x000C326C File Offset: 0x000C146C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UnregisterComponent(UActorComponent Componet)
		{
			UKuroActorManager.__UnregisterComponent_FunctionParams* ptr = stackalloc UKuroActorManager.__UnregisterComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__UnregisterComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__UnregisterComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Componet = ((Componet != null) ? Componet.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__UnregisterComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x000C32C0 File Offset: 0x000C14C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static AActor SpawnActor(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null, bool bAsPoolActor = false)
		{
			UKuroActorManager.__SpawnActor_FunctionParams* ptr = stackalloc UKuroActorManager.__SpawnActor_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(UKuroActorManager.__SpawnActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__SpawnActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->ActorClass = ActorClass;
			ptr->SpawnTransform = SpawnTransform;
			ptr->CollisionHandlingOverride = CollisionHandlingOverride;
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			ptr->Instigator = ((Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
			ptr->bAsPoolActor = bAsPoolActor;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__SpawnActor_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x000C3374 File Offset: 0x000C1574
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ResetUObjectByCDO(UObject Obj)
		{
			UKuroActorManager.__ResetUObjectByCDO_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetUObjectByCDO_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetUObjectByCDO_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetUObjectByCDO_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Obj = ((Obj != null) ? Obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetUObjectByCDO_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x000C33C8 File Offset: 0x000C15C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ResetUberGraph(UObject Obj)
		{
			UKuroActorManager.__ResetUberGraph_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetUberGraph_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetUberGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetUberGraph_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Obj = ((Obj != null) ? Obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetUberGraph_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x000C341C File Offset: 0x000C161C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ResetDelegates(AActor Actor)
		{
			UKuroActorManager.__ResetDelegates_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetDelegates_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetDelegates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetDelegates_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetDelegates_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x000C3470 File Offset: 0x000C1670
		[SkipLocalsInit]
		public unsafe static void ResetClassPropertyCache(UClassStackOnlyPtr Class)
		{
			UKuroActorManager.__ResetClassPropertyCache_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetClassPropertyCache_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetClassPropertyCache_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetClassPropertyCache_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetClassPropertyCache_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x000C34B8 File Offset: 0x000C16B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool ResetActorToDefault(AActor Actor)
		{
			UKuroActorManager.__ResetActorToDefault_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetActorToDefault_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__ResetActorToDefault_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetActorToDefault_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetActorToDefault_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x000C3514 File Offset: 0x000C1714
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool IsPooledActor(AActor Actor)
		{
			UKuroActorManager.__IsPooledActor_FunctionParams* ptr = stackalloc UKuroActorManager.__IsPooledActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__IsPooledActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__IsPooledActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__IsPooledActor_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x000C3570 File Offset: 0x000C1770
		[SkipLocalsInit]
		public unsafe static bool IsActorPoolEnable()
		{
			UKuroActorManager.__IsActorPoolEnable_FunctionParams* ptr = stackalloc UKuroActorManager.__IsActorPoolEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroActorManager.__IsActorPoolEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__IsActorPoolEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__IsActorPoolEnable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x000C35B4 File Offset: 0x000C17B4
		[SkipLocalsInit]
		public static void InitActorManager()
		{
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__InitActorManager_NativeFunctionPtr, null);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x000C35C8 File Offset: 0x000C17C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static int GetResourceSizeBytes(AActor Actor, bool isExclusive = true)
		{
			UKuroActorManager.__GetResourceSizeBytes_FunctionParams* ptr = stackalloc UKuroActorManager.__GetResourceSizeBytes_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__GetResourceSizeBytes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetResourceSizeBytes_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->isExclusive = isExclusive;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetResourceSizeBytes_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x000C362C File Offset: 0x000C182C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static ULevelSequence GetDummySequence()
		{
			UKuroActorManager.__GetDummySequence_FunctionParams* ptr = stackalloc UKuroActorManager.__GetDummySequence_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__GetDummySequence_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetDummySequence_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetDummySequence_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ptr->__Result);
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x000C3678 File Offset: 0x000C1878
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static TArray<string> GetAllAcquiredComponents([Nullable(2)] AActor Actor)
		{
			UKuroActorManager.__GetAllAcquiredComponents_FunctionParams* ptr = stackalloc UKuroActorManager.__GetAllAcquiredComponents_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroActorManager.__GetAllAcquiredComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x000C36EC File Offset: 0x000C18EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void DestroyActor(AActor Actor)
		{
			UKuroActorManager.__DestroyActor_FunctionParams* ptr = stackalloc UKuroActorManager.__DestroyActor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__DestroyActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__DestroyActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__DestroyActor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x000C3740 File Offset: 0x000C1940
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static AActor D_SpawnActor(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null, bool bAsPoolActor = false)
		{
			UKuroActorManager.__D_SpawnActor_FunctionParams* ptr = stackalloc UKuroActorManager.__D_SpawnActor_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UKuroActorManager.__D_SpawnActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__D_SpawnActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->ActorClass = ActorClass;
			ptr->SpawnTransform = SpawnTransform;
			ptr->CollisionHandlingOverride = CollisionHandlingOverride;
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			ptr->Instigator = ((Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
			ptr->bAsPoolActor = bAsPoolActor;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__D_SpawnActor_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x000C37F4 File Offset: 0x000C19F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool ClearAcquiredComponents(AActor Actor)
		{
			UKuroActorManager.__ClearAcquiredComponents_FunctionParams* ptr = stackalloc UKuroActorManager.__ClearAcquiredComponents_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__ClearAcquiredComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ClearAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ClearAcquiredComponents_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x000C384E File Offset: 0x000C1A4E
		[SkipLocalsInit]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x000C3864 File Offset: 0x000C1A64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static int CalcUObjectMemory(UObject Object, bool bIsGetDepends = false)
		{
			UKuroActorManager.__CalcUObjectMemory_FunctionParams* ptr = stackalloc UKuroActorManager.__CalcUObjectMemory_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__CalcUObjectMemory_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__CalcUObjectMemory_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->bIsGetDepends = bIsGetDepends;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__CalcUObjectMemory_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x000C38C5 File Offset: 0x000C1AC5
		static UKuroActorManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorManager");
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x000C38D3 File Offset: 0x000C1AD3
		protected UKuroActorManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003984 RID: 14724
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorManager";

		// Token: 0x04003985 RID: 14725
		private static IntPtr _ClassPtr;

		// Token: 0x04003986 RID: 14726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003987 RID: 14727
		private static IntPtr __UnregisterComponent_NativeFunctionPtr;

		// Token: 0x04003988 RID: 14728
		private static IntPtr __SpawnActor_NativeFunctionPtr;

		// Token: 0x04003989 RID: 14729
		private static IntPtr __ResetUObjectByCDO_NativeFunctionPtr;

		// Token: 0x0400398A RID: 14730
		private static IntPtr __ResetUberGraph_NativeFunctionPtr;

		// Token: 0x0400398B RID: 14731
		private static IntPtr __ResetDelegates_NativeFunctionPtr;

		// Token: 0x0400398C RID: 14732
		private static IntPtr __ResetClassPropertyCache_NativeFunctionPtr;

		// Token: 0x0400398D RID: 14733
		private static IntPtr __ResetActorToDefault_NativeFunctionPtr;

		// Token: 0x0400398E RID: 14734
		private static IntPtr __IsPooledActor_NativeFunctionPtr;

		// Token: 0x0400398F RID: 14735
		private static IntPtr __IsActorPoolEnable_NativeFunctionPtr;

		// Token: 0x04003990 RID: 14736
		private static IntPtr __InitActorManager_NativeFunctionPtr;

		// Token: 0x04003991 RID: 14737
		private static IntPtr __GetResourceSizeBytes_NativeFunctionPtr;

		// Token: 0x04003992 RID: 14738
		private static IntPtr __GetDummySequence_NativeFunctionPtr;

		// Token: 0x04003993 RID: 14739
		private static IntPtr __GetAllAcquiredComponents_NativeFunctionPtr;

		// Token: 0x04003994 RID: 14740
		private static IntPtr __DestroyActor_NativeFunctionPtr;

		// Token: 0x04003995 RID: 14741
		private static IntPtr __D_SpawnActor_NativeFunctionPtr;

		// Token: 0x04003996 RID: 14742
		private static IntPtr __ClearAcquiredComponents_NativeFunctionPtr;

		// Token: 0x04003997 RID: 14743
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x04003998 RID: 14744
		private static IntPtr __CalcUObjectMemory_NativeFunctionPtr;

		// Token: 0x02000D47 RID: 3399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnregisterComponent_FunctionParams
		{
			// Token: 0x04005FE5 RID: 24549
			[FieldOffset(0)]
			public IntPtr Componet;
		}

		// Token: 0x02000D48 RID: 3400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __SpawnActor_FunctionParams
		{
			// Token: 0x04005FE6 RID: 24550
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04005FE7 RID: 24551
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(8)]
			public TSubclassOf<AActor> ActorClass;

			// Token: 0x04005FE8 RID: 24552
			[FieldOffset(16)]
			public FTransform SpawnTransform;

			// Token: 0x04005FE9 RID: 24553
			[FieldOffset(64)]
			public ESpawnActorCollisionHandlingMethod CollisionHandlingOverride;

			// Token: 0x04005FEA RID: 24554
			[FieldOffset(72)]
			public IntPtr Owner;

			// Token: 0x04005FEB RID: 24555
			[FieldOffset(80)]
			public IntPtr Instigator;

			// Token: 0x04005FEC RID: 24556
			[FieldOffset(88)]
			public bool bAsPoolActor;

			// Token: 0x04005FED RID: 24557
			[FieldOffset(96)]
			public IntPtr __Result;
		}

		// Token: 0x02000D49 RID: 3401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetUObjectByCDO_FunctionParams
		{
			// Token: 0x04005FEE RID: 24558
			[FieldOffset(0)]
			public IntPtr Obj;
		}

		// Token: 0x02000D4A RID: 3402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetUberGraph_FunctionParams
		{
			// Token: 0x04005FEF RID: 24559
			[FieldOffset(0)]
			public IntPtr Obj;
		}

		// Token: 0x02000D4B RID: 3403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetDelegates_FunctionParams
		{
			// Token: 0x04005FF0 RID: 24560
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02000D4C RID: 3404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetClassPropertyCache_FunctionParams
		{
			// Token: 0x04005FF1 RID: 24561
			[FieldOffset(0)]
			public UClassStackOnlyPtr Class;
		}

		// Token: 0x02000D4D RID: 3405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResetActorToDefault_FunctionParams
		{
			// Token: 0x04005FF2 RID: 24562
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005FF3 RID: 24563
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000D4E RID: 3406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IsPooledActor_FunctionParams
		{
			// Token: 0x04005FF4 RID: 24564
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005FF5 RID: 24565
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000D4F RID: 3407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActorPoolEnable_FunctionParams
		{
			// Token: 0x04005FF6 RID: 24566
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D50 RID: 3408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetResourceSizeBytes_FunctionParams
		{
			// Token: 0x04005FF7 RID: 24567
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005FF8 RID: 24568
			[FieldOffset(8)]
			public bool isExclusive;

			// Token: 0x04005FF9 RID: 24569
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x02000D51 RID: 3409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDummySequence_FunctionParams
		{
			// Token: 0x04005FFA RID: 24570
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000D52 RID: 3410
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllAcquiredComponents_FunctionParams
		{
			// Token: 0x04005FFB RID: 24571
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005FFC RID: 24572
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000D53 RID: 3411
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyActor_FunctionParams
		{
			// Token: 0x04005FFD RID: 24573
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02000D54 RID: 3412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __D_SpawnActor_FunctionParams
		{
			// Token: 0x04005FFE RID: 24574
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04005FFF RID: 24575
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(8)]
			public TSubclassOf<AActor> ActorClass;

			// Token: 0x04006000 RID: 24576
			[FieldOffset(16)]
			public FTransformDouble SpawnTransform;

			// Token: 0x04006001 RID: 24577
			[FieldOffset(80)]
			public ESpawnActorCollisionHandlingMethod CollisionHandlingOverride;

			// Token: 0x04006002 RID: 24578
			[FieldOffset(88)]
			public IntPtr Owner;

			// Token: 0x04006003 RID: 24579
			[FieldOffset(96)]
			public IntPtr Instigator;

			// Token: 0x04006004 RID: 24580
			[FieldOffset(104)]
			public bool bAsPoolActor;

			// Token: 0x04006005 RID: 24581
			[FieldOffset(112)]
			public IntPtr __Result;
		}

		// Token: 0x02000D55 RID: 3413
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ClearAcquiredComponents_FunctionParams
		{
			// Token: 0x04006006 RID: 24582
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04006007 RID: 24583
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000D56 RID: 3414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CalcUObjectMemory_FunctionParams
		{
			// Token: 0x04006008 RID: 24584
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04006009 RID: 24585
			[FieldOffset(8)]
			public bool bIsGetDepends;

			// Token: 0x0400600A RID: 24586
			[FieldOffset(12)]
			public int __Result;
		}
	}
}
