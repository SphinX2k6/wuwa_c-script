using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CA RID: 2250
	[UnrealObjectPath("/Script/Engine.BlueprintMapLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintMapLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007AD8 RID: 31448 RVA: 0x000AFB26 File Offset: 0x000ADD26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintMapLibrary._ClassPtr;
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x000AFB34 File Offset: 0x000ADD34
		public UBlueprintMapLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintMapLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x000AFB5C File Offset: 0x000ADD5C
		[NullableContext(1)]
		public UBlueprintMapLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintMapLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x000AFB90 File Offset: 0x000ADD90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetMapPropertyByName(UObject Object, FName PropertyName, in TMap<int, int> Value)
		{
			UBlueprintMapLibrary.__SetMapPropertyByName_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__SetMapPropertyByName_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(UBlueprintMapLibrary.__SetMapPropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__SetMapPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			TMap<int, int> tmap = Value;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Value);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__SetMapPropertyByName_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = Value;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Value);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__SetMapPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x000AFC28 File Offset: 0x000ADE28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Map_Values(in TMap<int, int> TargetMap, ref TArray<int> Values)
		{
			UBlueprintMapLibrary.__Map_Values_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Values_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Values_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Values_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			TArray<int> tarray = Values;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Values);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Values_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			TArray<int> tarray2 = Values;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Values);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Values_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Map_Remove(in TMap<int, int> TargetMap, in int Key)
		{
			UBlueprintMapLibrary.__Map_Remove_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Remove_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Remove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Remove_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			ptr->Key = Key;
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Remove_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Remove_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x000AFD50 File Offset: 0x000ADF50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Map_Length(in TMap<int, int> TargetMap)
		{
			UBlueprintMapLibrary.__Map_Length_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Length_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Length_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Length_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Length_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Length_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x000AFDD0 File Offset: 0x000ADFD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Map_Keys(in TMap<int, int> TargetMap, ref TArray<int> Keys)
		{
			UBlueprintMapLibrary.__Map_Keys_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Keys_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Keys_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Keys_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			TArray<int> tarray = Keys;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Keys);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Keys_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			TArray<int> tarray2 = Keys;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Keys);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Keys_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x000AFE70 File Offset: 0x000AE070
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Map_Find(in TMap<int, int> TargetMap, in int Key, ref int Value)
		{
			UBlueprintMapLibrary.__Map_Find_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Find_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Find_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Find_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			ptr->Key = Key;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Find_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			Value = ptr->Value;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Find_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x000AFF08 File Offset: 0x000AE108
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Map_Contains(in TMap<int, int> TargetMap, in int Key)
		{
			UBlueprintMapLibrary.__Map_Contains_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Contains_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Contains_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Contains_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			ptr->Key = Key;
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Contains_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Contains_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x000AFF90 File Offset: 0x000AE190
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Map_Clear(in TMap<int, int> TargetMap)
		{
			UBlueprintMapLibrary.__Map_Clear_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Clear_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Clear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Clear_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Clear_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Clear_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x000B0008 File Offset: 0x000AE208
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Map_Add(in TMap<int, int> TargetMap, in int Key, in int Value)
		{
			UBlueprintMapLibrary.__Map_Add_FunctionParams* ptr = stackalloc UBlueprintMapLibrary.__Map_Add_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintMapLibrary.__Map_Add_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintMapLibrary.__Map_Add_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = TargetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->TargetMap);
			}
			ptr->Key = Key;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(UBlueprintMapLibrary._ClassDefaultObjectPtr, UBlueprintMapLibrary.__Map_Add_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = TargetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->TargetMap);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintMapLibrary.__Map_Add_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x000B0090 File Offset: 0x000AE290
		static UBlueprintMapLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintMapLibrary");
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x000B009E File Offset: 0x000AE29E
		protected UBlueprintMapLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B12 RID: 15122
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintMapLibrary";

		// Token: 0x04003B13 RID: 15123
		private static IntPtr _ClassPtr;

		// Token: 0x04003B14 RID: 15124
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003B15 RID: 15125
		private static IntPtr __SetMapPropertyByName_NativeFunctionPtr;

		// Token: 0x04003B16 RID: 15126
		private static IntPtr __Map_Values_NativeFunctionPtr;

		// Token: 0x04003B17 RID: 15127
		private static IntPtr __Map_Remove_NativeFunctionPtr;

		// Token: 0x04003B18 RID: 15128
		private static IntPtr __Map_Length_NativeFunctionPtr;

		// Token: 0x04003B19 RID: 15129
		private static IntPtr __Map_Keys_NativeFunctionPtr;

		// Token: 0x04003B1A RID: 15130
		private static IntPtr __Map_Find_NativeFunctionPtr;

		// Token: 0x04003B1B RID: 15131
		private static IntPtr __Map_Contains_NativeFunctionPtr;

		// Token: 0x04003B1C RID: 15132
		private static IntPtr __Map_Clear_NativeFunctionPtr;

		// Token: 0x04003B1D RID: 15133
		private static IntPtr __Map_Add_NativeFunctionPtr;

		// Token: 0x02002C99 RID: 11417
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetMapPropertyByName_FunctionParams
		{
			// Token: 0x040165F4 RID: 91636
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x040165F5 RID: 91637
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x040165F6 RID: 91638
			[FieldOffset(24)]
			public byte Value;
		}

		// Token: 0x02002C9A RID: 11418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Map_Values_FunctionParams
		{
			// Token: 0x040165F7 RID: 91639
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x040165F8 RID: 91640
			[FieldOffset(80)]
			public byte Values;
		}

		// Token: 0x02002C9B RID: 11419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Map_Remove_FunctionParams
		{
			// Token: 0x040165F9 RID: 91641
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x040165FA RID: 91642
			[FieldOffset(80)]
			public int Key;

			// Token: 0x040165FB RID: 91643
			[FieldOffset(84)]
			public bool __Result;
		}

		// Token: 0x02002C9C RID: 11420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Map_Length_FunctionParams
		{
			// Token: 0x040165FC RID: 91644
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x040165FD RID: 91645
			[FieldOffset(80)]
			public int __Result;
		}

		// Token: 0x02002C9D RID: 11421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Map_Keys_FunctionParams
		{
			// Token: 0x040165FE RID: 91646
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x040165FF RID: 91647
			[FieldOffset(80)]
			public byte Keys;
		}

		// Token: 0x02002C9E RID: 11422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Map_Find_FunctionParams
		{
			// Token: 0x04016600 RID: 91648
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x04016601 RID: 91649
			[FieldOffset(80)]
			public int Key;

			// Token: 0x04016602 RID: 91650
			[FieldOffset(84)]
			public int Value;

			// Token: 0x04016603 RID: 91651
			[FieldOffset(88)]
			public bool __Result;
		}

		// Token: 0x02002C9F RID: 11423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Map_Contains_FunctionParams
		{
			// Token: 0x04016604 RID: 91652
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x04016605 RID: 91653
			[FieldOffset(80)]
			public int Key;

			// Token: 0x04016606 RID: 91654
			[FieldOffset(84)]
			public bool __Result;
		}

		// Token: 0x02002CA0 RID: 11424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Map_Clear_FunctionParams
		{
			// Token: 0x04016607 RID: 91655
			[FieldOffset(0)]
			public byte TargetMap;
		}

		// Token: 0x02002CA1 RID: 11425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Map_Add_FunctionParams
		{
			// Token: 0x04016608 RID: 91656
			[FieldOffset(0)]
			public byte TargetMap;

			// Token: 0x04016609 RID: 91657
			[FieldOffset(80)]
			public int Key;

			// Token: 0x0401660A RID: 91658
			[FieldOffset(84)]
			public int Value;
		}
	}
}
