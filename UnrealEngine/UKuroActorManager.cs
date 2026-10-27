using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAA RID: 7850
	[UnrealObjectPath("/Script/KuroUtility.KuroActorManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroActorManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCD7 RID: 122071 RVA: 0x002C0C47 File Offset: 0x002BEE47
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorManager._ClassPtr;
		}

		// Token: 0x0601DCD8 RID: 122072 RVA: 0x002C0C54 File Offset: 0x002BEE54
		public UKuroActorManager() : this(BuiltinUtils.AllocNativeUObject(UKuroActorManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCD9 RID: 122073 RVA: 0x002C0C7C File Offset: 0x002BEE7C
		[NullableContext(1)]
		public UKuroActorManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DCDA RID: 122074 RVA: 0x002C0CB0 File Offset: 0x002BEEB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UnregisterComponent(UActorComponent Componet)
		{
			UKuroActorManager.__UnregisterComponent_FunctionParams* ptr = stackalloc UKuroActorManager.__UnregisterComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__UnregisterComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__UnregisterComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Componet = ((Componet != null) ? Componet.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__UnregisterComponent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCDB RID: 122075 RVA: 0x002C0D08 File Offset: 0x002BEF08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__SpawnActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0601DCDC RID: 122076 RVA: 0x002C0DBC File Offset: 0x002BEFBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ResetUObjectByCDO(UObject Obj)
		{
			UKuroActorManager.__ResetUObjectByCDO_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetUObjectByCDO_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetUObjectByCDO_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetUObjectByCDO_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Obj = ((Obj != null) ? Obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetUObjectByCDO_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCDD RID: 122077 RVA: 0x002C0E14 File Offset: 0x002BF014
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ResetUberGraph(UObject Obj)
		{
			UKuroActorManager.__ResetUberGraph_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetUberGraph_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetUberGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetUberGraph_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Obj = ((Obj != null) ? Obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetUberGraph_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCDE RID: 122078 RVA: 0x002C0E6C File Offset: 0x002BF06C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ResetDelegates(AActor Actor)
		{
			UKuroActorManager.__ResetDelegates_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetDelegates_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetDelegates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetDelegates_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetDelegates_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCDF RID: 122079 RVA: 0x002C0EC4 File Offset: 0x002BF0C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ResetClassPropertyCache(UClassStackOnlyPtr Class)
		{
			UKuroActorManager.__ResetClassPropertyCache_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetClassPropertyCache_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__ResetClassPropertyCache_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetClassPropertyCache_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetClassPropertyCache_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCE0 RID: 122080 RVA: 0x002C0F0C File Offset: 0x002BF10C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ResetActorToDefault(AActor Actor)
		{
			UKuroActorManager.__ResetActorToDefault_FunctionParams* ptr = stackalloc UKuroActorManager.__ResetActorToDefault_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__ResetActorToDefault_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ResetActorToDefault_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ResetActorToDefault_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCE1 RID: 122081 RVA: 0x002C0F68 File Offset: 0x002BF168
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterActorSkipProperties(UClassStackOnlyPtr Class, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPropertyPair> Properties)
		{
			UKuroActorManager.__RegisterActorSkipProperties_FunctionParams* ptr = stackalloc UKuroActorManager.__RegisterActorSkipProperties_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroActorManager.__RegisterActorSkipProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__RegisterActorSkipProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			TArray<FPropertyPair> tarray = Properties;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Properties);
			}
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__RegisterActorSkipProperties_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FPropertyPair> tarray2 = Properties;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Properties);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroActorManager.__RegisterActorSkipProperties_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DCE2 RID: 122082 RVA: 0x002C0FE8 File Offset: 0x002BF1E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPooledActor(AActor Actor)
		{
			UKuroActorManager.__IsPooledActor_FunctionParams* ptr = stackalloc UKuroActorManager.__IsPooledActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__IsPooledActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__IsPooledActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__IsPooledActor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCE3 RID: 122083 RVA: 0x002C1044 File Offset: 0x002BF244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsActorPoolEnable()
		{
			UKuroActorManager.__IsActorPoolEnable_FunctionParams* ptr = stackalloc UKuroActorManager.__IsActorPoolEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroActorManager.__IsActorPoolEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__IsActorPoolEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__IsActorPoolEnable_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCE4 RID: 122084 RVA: 0x002C1089 File Offset: 0x002BF289
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void InitActorManager()
		{
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__InitActorManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DCE5 RID: 122085 RVA: 0x002C10A0 File Offset: 0x002BF2A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetResourceSizeBytes(AActor Actor, bool isExclusive = true)
		{
			UKuroActorManager.__GetResourceSizeBytes_FunctionParams* ptr = stackalloc UKuroActorManager.__GetResourceSizeBytes_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__GetResourceSizeBytes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetResourceSizeBytes_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->isExclusive = isExclusive;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetResourceSizeBytes_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCE6 RID: 122086 RVA: 0x002C1104 File Offset: 0x002BF304
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static ULevelSequence GetDummySequence()
		{
			UKuroActorManager.__GetDummySequence_FunctionParams* ptr = stackalloc UKuroActorManager.__GetDummySequence_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__GetDummySequence_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetDummySequence_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetDummySequence_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ptr->__Result);
		}

		// Token: 0x0601DCE7 RID: 122087 RVA: 0x002C1150 File Offset: 0x002BF350
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<string> GetAllAcquiredComponents([Nullable(2)] AActor Actor)
		{
			UKuroActorManager.__GetAllAcquiredComponents_FunctionParams* ptr = stackalloc UKuroActorManager.__GetAllAcquiredComponents_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroActorManager.__GetAllAcquiredComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroActorManager.__GetAllAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DCE8 RID: 122088 RVA: 0x002C11C4 File Offset: 0x002BF3C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DestroyActor(AActor Actor)
		{
			UKuroActorManager.__DestroyActor_FunctionParams* ptr = stackalloc UKuroActorManager.__DestroyActor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroActorManager.__DestroyActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__DestroyActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__DestroyActor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DCE9 RID: 122089 RVA: 0x002C121C File Offset: 0x002BF41C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__D_SpawnActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0601DCEA RID: 122090 RVA: 0x002C12D4 File Offset: 0x002BF4D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ClearAcquiredComponents(AActor Actor)
		{
			UKuroActorManager.__ClearAcquiredComponents_FunctionParams* ptr = stackalloc UKuroActorManager.__ClearAcquiredComponents_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__ClearAcquiredComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__ClearAcquiredComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__ClearAcquiredComponents_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCEB RID: 122091 RVA: 0x002C132F File Offset: 0x002BF52F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__Clear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DCEC RID: 122092 RVA: 0x002C1344 File Offset: 0x002BF544
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CalcUObjectMemory(UObject Object, bool bIsGetDepends = false)
		{
			UKuroActorManager.__CalcUObjectMemory_FunctionParams* ptr = stackalloc UKuroActorManager.__CalcUObjectMemory_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroActorManager.__CalcUObjectMemory_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroActorManager.__CalcUObjectMemory_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->bIsGetDepends = bIsGetDepends;
			UnrealReflectionUtils.CallUFunction(UKuroActorManager._ClassDefaultObjectPtr, UKuroActorManager.__CalcUObjectMemory_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DCED RID: 122093 RVA: 0x002C13A6 File Offset: 0x002BF5A6
		static UKuroActorManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorManager");
		}

		// Token: 0x0601DCEE RID: 122094 RVA: 0x002C13B4 File Offset: 0x002BF5B4
		protected UKuroActorManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401025A RID: 66138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorManager";

		// Token: 0x0401025B RID: 66139
		private static IntPtr _ClassPtr;

		// Token: 0x0401025C RID: 66140
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401025D RID: 66141
		private static IntPtr __UnregisterComponent_NativeFunctionPtr;

		// Token: 0x0401025E RID: 66142
		private static IntPtr __SpawnActor_NativeFunctionPtr;

		// Token: 0x0401025F RID: 66143
		private static IntPtr __ResetUObjectByCDO_NativeFunctionPtr;

		// Token: 0x04010260 RID: 66144
		private static IntPtr __ResetUberGraph_NativeFunctionPtr;

		// Token: 0x04010261 RID: 66145
		private static IntPtr __ResetDelegates_NativeFunctionPtr;

		// Token: 0x04010262 RID: 66146
		private static IntPtr __ResetClassPropertyCache_NativeFunctionPtr;

		// Token: 0x04010263 RID: 66147
		private static IntPtr __ResetActorToDefault_NativeFunctionPtr;

		// Token: 0x04010264 RID: 66148
		private static IntPtr __RegisterActorSkipProperties_NativeFunctionPtr;

		// Token: 0x04010265 RID: 66149
		private static IntPtr __IsPooledActor_NativeFunctionPtr;

		// Token: 0x04010266 RID: 66150
		private static IntPtr __IsActorPoolEnable_NativeFunctionPtr;

		// Token: 0x04010267 RID: 66151
		private static IntPtr __InitActorManager_NativeFunctionPtr;

		// Token: 0x04010268 RID: 66152
		private static IntPtr __GetResourceSizeBytes_NativeFunctionPtr;

		// Token: 0x04010269 RID: 66153
		private static IntPtr __GetDummySequence_NativeFunctionPtr;

		// Token: 0x0401026A RID: 66154
		private static IntPtr __GetAllAcquiredComponents_NativeFunctionPtr;

		// Token: 0x0401026B RID: 66155
		private static IntPtr __DestroyActor_NativeFunctionPtr;

		// Token: 0x0401026C RID: 66156
		private static IntPtr __D_SpawnActor_NativeFunctionPtr;

		// Token: 0x0401026D RID: 66157
		private static IntPtr __ClearAcquiredComponents_NativeFunctionPtr;

		// Token: 0x0401026E RID: 66158
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0401026F RID: 66159
		private static IntPtr __CalcUObjectMemory_NativeFunctionPtr;

		// Token: 0x020032EE RID: 13038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnregisterComponent_FunctionParams
		{
			// Token: 0x0401719F RID: 94623
			[FieldOffset(0)]
			public IntPtr Componet;
		}

		// Token: 0x020032EF RID: 13039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __SpawnActor_FunctionParams
		{
			// Token: 0x040171A0 RID: 94624
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040171A1 RID: 94625
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(8)]
			public TSubclassOf<AActor> ActorClass;

			// Token: 0x040171A2 RID: 94626
			[FieldOffset(16)]
			public FTransform SpawnTransform;

			// Token: 0x040171A3 RID: 94627
			[FieldOffset(64)]
			public ESpawnActorCollisionHandlingMethod CollisionHandlingOverride;

			// Token: 0x040171A4 RID: 94628
			[FieldOffset(72)]
			public IntPtr Owner;

			// Token: 0x040171A5 RID: 94629
			[FieldOffset(80)]
			public IntPtr Instigator;

			// Token: 0x040171A6 RID: 94630
			[FieldOffset(88)]
			public bool bAsPoolActor;

			// Token: 0x040171A7 RID: 94631
			[FieldOffset(96)]
			public IntPtr __Result;
		}

		// Token: 0x020032F0 RID: 13040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetUObjectByCDO_FunctionParams
		{
			// Token: 0x040171A8 RID: 94632
			[FieldOffset(0)]
			public IntPtr Obj;
		}

		// Token: 0x020032F1 RID: 13041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetUberGraph_FunctionParams
		{
			// Token: 0x040171A9 RID: 94633
			[FieldOffset(0)]
			public IntPtr Obj;
		}

		// Token: 0x020032F2 RID: 13042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetDelegates_FunctionParams
		{
			// Token: 0x040171AA RID: 94634
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x020032F3 RID: 13043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetClassPropertyCache_FunctionParams
		{
			// Token: 0x040171AB RID: 94635
			[FieldOffset(0)]
			public UClassStackOnlyPtr Class;
		}

		// Token: 0x020032F4 RID: 13044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResetActorToDefault_FunctionParams
		{
			// Token: 0x040171AC RID: 94636
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040171AD RID: 94637
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020032F5 RID: 13045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RegisterActorSkipProperties_FunctionParams
		{
			// Token: 0x040171AE RID: 94638
			[FieldOffset(0)]
			public UClassStackOnlyPtr Class;

			// Token: 0x040171AF RID: 94639
			[FieldOffset(8)]
			public byte Properties;
		}

		// Token: 0x020032F6 RID: 13046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IsPooledActor_FunctionParams
		{
			// Token: 0x040171B0 RID: 94640
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040171B1 RID: 94641
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020032F7 RID: 13047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActorPoolEnable_FunctionParams
		{
			// Token: 0x040171B2 RID: 94642
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020032F8 RID: 13048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetResourceSizeBytes_FunctionParams
		{
			// Token: 0x040171B3 RID: 94643
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040171B4 RID: 94644
			[FieldOffset(8)]
			public bool isExclusive;

			// Token: 0x040171B5 RID: 94645
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x020032F9 RID: 13049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDummySequence_FunctionParams
		{
			// Token: 0x040171B6 RID: 94646
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020032FA RID: 13050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllAcquiredComponents_FunctionParams
		{
			// Token: 0x040171B7 RID: 94647
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040171B8 RID: 94648
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x020032FB RID: 13051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyActor_FunctionParams
		{
			// Token: 0x040171B9 RID: 94649
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x020032FC RID: 13052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __D_SpawnActor_FunctionParams
		{
			// Token: 0x040171BA RID: 94650
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040171BB RID: 94651
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(8)]
			public TSubclassOf<AActor> ActorClass;

			// Token: 0x040171BC RID: 94652
			[FieldOffset(16)]
			public FTransformDouble SpawnTransform;

			// Token: 0x040171BD RID: 94653
			[FieldOffset(80)]
			public ESpawnActorCollisionHandlingMethod CollisionHandlingOverride;

			// Token: 0x040171BE RID: 94654
			[FieldOffset(88)]
			public IntPtr Owner;

			// Token: 0x040171BF RID: 94655
			[FieldOffset(96)]
			public IntPtr Instigator;

			// Token: 0x040171C0 RID: 94656
			[FieldOffset(104)]
			public bool bAsPoolActor;

			// Token: 0x040171C1 RID: 94657
			[FieldOffset(112)]
			public IntPtr __Result;
		}

		// Token: 0x020032FD RID: 13053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ClearAcquiredComponents_FunctionParams
		{
			// Token: 0x040171C2 RID: 94658
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040171C3 RID: 94659
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020032FE RID: 13054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CalcUObjectMemory_FunctionParams
		{
			// Token: 0x040171C4 RID: 94660
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x040171C5 RID: 94661
			[FieldOffset(8)]
			public bool bIsGetDepends;

			// Token: 0x040171C6 RID: 94662
			[FieldOffset(12)]
			public int __Result;
		}
	}
}
