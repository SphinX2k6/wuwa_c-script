using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001251 RID: 4689
	[UnrealObjectPath("/Script/Engine.WorldPartitionBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060113F7 RID: 70647 RVA: 0x00194EDA File Offset: 0x001930DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionBlueprintLibrary._ClassPtr;
		}

		// Token: 0x060113F8 RID: 70648 RVA: 0x00194EE8 File Offset: 0x001930E8
		public UWorldPartitionBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060113F9 RID: 70649 RVA: 0x00194F10 File Offset: 0x00193110
		[NullableContext(1)]
		public UWorldPartitionBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x00194F44 File Offset: 0x00193144
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UnpinActors(in TArray<FGuid> InActorsToUnpin)
		{
			UWorldPartitionBlueprintLibrary.__UnpinActors_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__UnpinActors_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__UnpinActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__UnpinActors_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = InActorsToUnpin;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InActorsToUnpin);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__UnpinActors_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = InActorsToUnpin;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InActorsToUnpin);
			}
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__UnpinActors_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060113FB RID: 70651 RVA: 0x00194FBC File Offset: 0x001931BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UnloadActors(in TArray<FGuid> InActorsToUnload)
		{
			UWorldPartitionBlueprintLibrary.__UnloadActors_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__UnloadActors_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__UnloadActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__UnloadActors_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = InActorsToUnload;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InActorsToUnload);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__UnloadActors_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = InActorsToUnload;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InActorsToUnload);
			}
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__UnloadActors_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x00195034 File Offset: 0x00193234
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PinActors(in TArray<FGuid> InActorsToPin)
		{
			UWorldPartitionBlueprintLibrary.__PinActors_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__PinActors_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__PinActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__PinActors_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = InActorsToPin;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InActorsToPin);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__PinActors_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = InActorsToPin;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InActorsToPin);
			}
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__PinActors_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060113FD RID: 70653 RVA: 0x001950AC File Offset: 0x001932AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadActors(in TArray<FGuid> InActorsToLoad)
		{
			UWorldPartitionBlueprintLibrary.__LoadActors_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__LoadActors_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__LoadActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__LoadActors_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGuid> tarray = InActorsToLoad;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InActorsToLoad);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__LoadActors_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGuid> tarray2 = InActorsToLoad;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InActorsToLoad);
			}
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__LoadActors_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060113FE RID: 70654 RVA: 0x00195124 File Offset: 0x00193324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FBox GetRuntimeWorldBounds()
		{
			UWorldPartitionBlueprintLibrary.__GetRuntimeWorldBounds_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__GetRuntimeWorldBounds_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__GetRuntimeWorldBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__GetRuntimeWorldBounds_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__GetRuntimeWorldBounds_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060113FF RID: 70655 RVA: 0x0019516C File Offset: 0x0019336C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetIntersectingActorDescs(in FBox InBox, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FActorDesc> OutActorDescs)
		{
			UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBox = InBox;
			TArray<FActorDesc> tarray = OutActorDescs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutActorDescs);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FActorDesc> tarray2 = OutActorDescs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutActorDescs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__GetIntersectingActorDescs_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x001951F8 File Offset: 0x001933F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FBox GetEditorWorldBounds()
		{
			UWorldPartitionBlueprintLibrary.__GetEditorWorldBounds_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__GetEditorWorldBounds_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__GetEditorWorldBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__GetEditorWorldBounds_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__GetEditorWorldBounds_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06011401 RID: 70657 RVA: 0x00195240 File Offset: 0x00193440
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetActorDescsForActors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> InActors, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FActorDesc> OutActorDescs)
		{
			UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_NativeFunctionPtr, (void*)ptr, 1);
			TArray<AActor> tarray = InActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InActors);
			}
			TArray<FActorDesc> tarray2 = OutActorDescs;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->OutActorDescs);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_NativeFunctionPtr, (void*)ptr, 0);
			TArray<AActor> tarray3 = InActors;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->InActors);
			}
			TArray<FActorDesc> tarray4 = OutActorDescs;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->OutActorDescs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__GetActorDescsForActors_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06011402 RID: 70658 RVA: 0x001952E8 File Offset: 0x001934E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetActorDescs([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FActorDesc> OutActorDescs)
		{
			UWorldPartitionBlueprintLibrary.__GetActorDescs_FunctionParams* ptr = stackalloc UWorldPartitionBlueprintLibrary.__GetActorDescs_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UWorldPartitionBlueprintLibrary.__GetActorDescs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionBlueprintLibrary.__GetActorDescs_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FActorDesc> tarray = OutActorDescs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutActorDescs);
			}
			UnrealReflectionUtils.CallUFunction(UWorldPartitionBlueprintLibrary._ClassDefaultObjectPtr, UWorldPartitionBlueprintLibrary.__GetActorDescs_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FActorDesc> tarray2 = OutActorDescs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutActorDescs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UWorldPartitionBlueprintLibrary.__GetActorDescs_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06011403 RID: 70659 RVA: 0x00195366 File Offset: 0x00193566
		static UWorldPartitionBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionBlueprintLibrary");
		}

		// Token: 0x06011404 RID: 70660 RVA: 0x00195374 File Offset: 0x00193574
		protected UWorldPartitionBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400939D RID: 37789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionBlueprintLibrary";

		// Token: 0x0400939E RID: 37790
		private static IntPtr _ClassPtr;

		// Token: 0x0400939F RID: 37791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093A0 RID: 37792
		private static IntPtr __UnpinActors_NativeFunctionPtr;

		// Token: 0x040093A1 RID: 37793
		private static IntPtr __UnloadActors_NativeFunctionPtr;

		// Token: 0x040093A2 RID: 37794
		private static IntPtr __PinActors_NativeFunctionPtr;

		// Token: 0x040093A3 RID: 37795
		private static IntPtr __LoadActors_NativeFunctionPtr;

		// Token: 0x040093A4 RID: 37796
		private static IntPtr __GetRuntimeWorldBounds_NativeFunctionPtr;

		// Token: 0x040093A5 RID: 37797
		private static IntPtr __GetIntersectingActorDescs_NativeFunctionPtr;

		// Token: 0x040093A6 RID: 37798
		private static IntPtr __GetEditorWorldBounds_NativeFunctionPtr;

		// Token: 0x040093A7 RID: 37799
		private static IntPtr __GetActorDescsForActors_NativeFunctionPtr;

		// Token: 0x040093A8 RID: 37800
		private static IntPtr __GetActorDescs_NativeFunctionPtr;

		// Token: 0x02002E0D RID: 11789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnpinActors_FunctionParams
		{
			// Token: 0x0401688D RID: 92301
			[FieldOffset(0)]
			public byte InActorsToUnpin;
		}

		// Token: 0x02002E0E RID: 11790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnloadActors_FunctionParams
		{
			// Token: 0x0401688E RID: 92302
			[FieldOffset(0)]
			public byte InActorsToUnload;
		}

		// Token: 0x02002E0F RID: 11791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PinActors_FunctionParams
		{
			// Token: 0x0401688F RID: 92303
			[FieldOffset(0)]
			public byte InActorsToPin;
		}

		// Token: 0x02002E10 RID: 11792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LoadActors_FunctionParams
		{
			// Token: 0x04016890 RID: 92304
			[FieldOffset(0)]
			public byte InActorsToLoad;
		}

		// Token: 0x02002E11 RID: 11793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetRuntimeWorldBounds_FunctionParams
		{
			// Token: 0x04016891 RID: 92305
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x02002E12 RID: 11794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetIntersectingActorDescs_FunctionParams
		{
			// Token: 0x04016892 RID: 92306
			[FieldOffset(0)]
			public FBox InBox;

			// Token: 0x04016893 RID: 92307
			[FieldOffset(32)]
			public byte OutActorDescs;

			// Token: 0x04016894 RID: 92308
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02002E13 RID: 11795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetEditorWorldBounds_FunctionParams
		{
			// Token: 0x04016895 RID: 92309
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x02002E14 RID: 11796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetActorDescsForActors_FunctionParams
		{
			// Token: 0x04016896 RID: 92310
			[FieldOffset(0)]
			public byte InActors;

			// Token: 0x04016897 RID: 92311
			[FieldOffset(16)]
			public byte OutActorDescs;

			// Token: 0x04016898 RID: 92312
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02002E15 RID: 11797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetActorDescs_FunctionParams
		{
			// Token: 0x04016899 RID: 92313
			[FieldOffset(0)]
			public byte OutActorDescs;

			// Token: 0x0401689A RID: 92314
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
