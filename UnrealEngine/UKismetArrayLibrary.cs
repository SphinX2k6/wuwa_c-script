using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CCC RID: 3276
	[UnrealObjectPath("/Script/Engine.KismetArrayLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetArrayLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A58A RID: 42378 RVA: 0x000EB85E File Offset: 0x000E9A5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetArrayLibrary._ClassPtr;
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x000EB86C File Offset: 0x000E9A6C
		public UKismetArrayLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetArrayLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x000EB894 File Offset: 0x000E9A94
		[NullableContext(1)]
		public UKismetArrayLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetArrayLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x000EB8C8 File Offset: 0x000E9AC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetArrayPropertyByName(UObject Object, FName PropertyName, in TArray<int> Value)
		{
			UKismetArrayLibrary.__SetArrayPropertyByName_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__SetArrayPropertyByName_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKismetArrayLibrary.__SetArrayPropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__SetArrayPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			TArray<int> tarray = Value;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Value);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__SetArrayPropertyByName_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = Value;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Value);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__SetArrayPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x000EB95D File Offset: 0x000E9B5D
		public static void FilterArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> TargetArray, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> FilterClass, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> FilteredArray)
		{
			UKismetArrayLibrary.__FilterArray_Internal((TargetArray ?? new TArray<AActor>()).NativePtr, FilterClass._NativePtr, (FilteredArray ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x000EB98C File Offset: 0x000E9B8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Swap(in TArray<int> TargetArray, int FirstIndex, int SecondIndex)
		{
			UKismetArrayLibrary.__Array_Swap_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Swap_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Swap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Swap_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->FirstIndex = FirstIndex;
			ptr->SecondIndex = SecondIndex;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Swap_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Swap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x000EBA14 File Offset: 0x000E9C14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Shuffle(in TArray<int> TargetArray)
		{
			UKismetArrayLibrary.__Array_Shuffle_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Shuffle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Shuffle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Shuffle_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Shuffle_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Shuffle_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x000EBA8C File Offset: 0x000E9C8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Set(in TArray<int> TargetArray, int Index, in int Item, bool bSizeToFit)
		{
			UKismetArrayLibrary.__Array_Set_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Set_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Set_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->Index = Index;
			ptr->Item = Item;
			ptr->bSizeToFit = bSizeToFit;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Set_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x000EBB1C File Offset: 0x000E9D1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Reverse(in TArray<int> TargetArray)
		{
			UKismetArrayLibrary.__Array_Reverse_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Reverse_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Reverse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Reverse_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Reverse_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Reverse_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x000EBB94 File Offset: 0x000E9D94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Resize(in TArray<int> TargetArray, int Size)
		{
			UKismetArrayLibrary.__Array_Resize_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Resize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Resize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Resize_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->Size = Size;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Resize_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Resize_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x000EBC14 File Offset: 0x000E9E14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Array_RemoveItem(in TArray<int> TargetArray, in int Item)
		{
			UKismetArrayLibrary.__Array_RemoveItem_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_RemoveItem_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_RemoveItem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_RemoveItem_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->Item = Item;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_RemoveItem_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_RemoveItem_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x000EBC9C File Offset: 0x000E9E9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Remove(in TArray<int> TargetArray, int IndexToRemove)
		{
			UKismetArrayLibrary.__Array_Remove_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Remove_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Remove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Remove_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->IndexToRemove = IndexToRemove;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Remove_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Remove_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x000EBD1C File Offset: 0x000E9F1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_RandomFromStream(in TArray<int> TargetArray, ref FRandomStream RandomStream, ref int OutItem, ref int OutIndex)
		{
			UKismetArrayLibrary.__Array_RandomFromStream_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_RandomFromStream_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_RandomFromStream_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_RandomFromStream_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->RandomStream = RandomStream;
			ptr->OutItem = OutItem;
			ptr->OutIndex = OutIndex;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_RandomFromStream_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			RandomStream = ptr->RandomStream;
			OutItem = ptr->OutItem;
			OutIndex = ptr->OutIndex;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_RandomFromStream_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x000EBDCC File Offset: 0x000E9FCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Random(in TArray<int> TargetArray, ref int OutItem, ref int OutIndex)
		{
			UKismetArrayLibrary.__Array_Random_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Random_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Random_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Random_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->OutItem = OutItem;
			ptr->OutIndex = OutIndex;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Random_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			OutItem = ptr->OutItem;
			OutIndex = ptr->OutIndex;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Random_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x000EBE64 File Offset: 0x000EA064
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Array_Length(in TArray<int> TargetArray)
		{
			UKismetArrayLibrary.__Array_Length_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Length_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Length_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Length_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Length_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Length_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x000EBEE4 File Offset: 0x000EA0E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Array_LastIndex(in TArray<int> TargetArray)
		{
			UKismetArrayLibrary.__Array_LastIndex_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_LastIndex_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_LastIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_LastIndex_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_LastIndex_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_LastIndex_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x000EBF64 File Offset: 0x000EA164
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Array_IsValidIndex(in TArray<int> TargetArray, int IndexToTest)
		{
			UKismetArrayLibrary.__Array_IsValidIndex_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_IsValidIndex_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_IsValidIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_IsValidIndex_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->IndexToTest = IndexToTest;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_IsValidIndex_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_IsValidIndex_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x000EBFEC File Offset: 0x000EA1EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Insert(in TArray<int> TargetArray, in int NewItem, int Index)
		{
			UKismetArrayLibrary.__Array_Insert_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Insert_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Insert_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Insert_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->NewItem = NewItem;
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Insert_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Insert_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x000EC074 File Offset: 0x000EA274
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Array_Identical(in TArray<int> ArrayA, in TArray<int> ArrayB)
		{
			UKismetArrayLibrary.__Array_Identical_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Identical_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Identical_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Identical_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = ArrayA;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ArrayA);
			}
			TArray<int> tarray2 = ArrayB;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->ArrayB);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Identical_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray3 = ArrayA;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->ArrayA);
			}
			TArray<int> tarray4 = ArrayB;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->ArrayB);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Identical_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x000EC11C File Offset: 0x000EA31C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Get(in TArray<int> TargetArray, int Index, ref int Item)
		{
			UKismetArrayLibrary.__Array_Get_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Get_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Get_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->Index = Index;
			ptr->Item = Item;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Get_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			Item = ptr->Item;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Get_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x000EC1AC File Offset: 0x000EA3AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Array_Find(in TArray<int> TargetArray, in int ItemToFind)
		{
			UKismetArrayLibrary.__Array_Find_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Find_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Find_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Find_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->ItemToFind = ItemToFind;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Find_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Find_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x000EC234 File Offset: 0x000EA434
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Array_Contains(in TArray<int> TargetArray, in int ItemToFind)
		{
			UKismetArrayLibrary.__Array_Contains_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Contains_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Contains_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Contains_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->ItemToFind = ItemToFind;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Contains_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Contains_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x000EC2BC File Offset: 0x000EA4BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Clear(in TArray<int> TargetArray)
		{
			UKismetArrayLibrary.__Array_Clear_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Clear_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Clear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Clear_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Clear_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Clear_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x000EC334 File Offset: 0x000EA534
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Array_Append(in TArray<int> TargetArray, in TArray<int> SourceArray)
		{
			UKismetArrayLibrary.__Array_Append_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Append_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Append_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Append_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			TArray<int> tarray2 = SourceArray;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->SourceArray);
			}
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Append_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray3 = TargetArray;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->TargetArray);
			}
			TArray<int> tarray4 = SourceArray;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->SourceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Append_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x000EC3D4 File Offset: 0x000EA5D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Array_AddUnique(in TArray<int> TargetArray, in int NewItem)
		{
			UKismetArrayLibrary.__Array_AddUnique_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_AddUnique_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_AddUnique_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_AddUnique_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->NewItem = NewItem;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_AddUnique_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_AddUnique_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x000EC45C File Offset: 0x000EA65C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Array_Add(in TArray<int> TargetArray, in int NewItem)
		{
			UKismetArrayLibrary.__Array_Add_FunctionParams* ptr = stackalloc UKismetArrayLibrary.__Array_Add_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetArrayLibrary.__Array_Add_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetArrayLibrary.__Array_Add_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = TargetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetArray);
			}
			ptr->NewItem = NewItem;
			UnrealReflectionUtils.CallUFunction(UKismetArrayLibrary._ClassDefaultObjectPtr, UKismetArrayLibrary.__Array_Add_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetArray);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKismetArrayLibrary.__Array_Add_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600A5A4 RID: 42404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FilterArray_Internal(IntPtr TargetArray, IntPtr FilterClass, IntPtr FilteredArray);

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x000EC4E2 File Offset: 0x000EA6E2
		static UKismetArrayLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetArrayLibrary");
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x000EC4F0 File Offset: 0x000EA6F0
		protected UKismetArrayLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B11 RID: 23313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetArrayLibrary";

		// Token: 0x04005B12 RID: 23314
		private static IntPtr _ClassPtr;

		// Token: 0x04005B13 RID: 23315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005B14 RID: 23316
		private static IntPtr __SetArrayPropertyByName_NativeFunctionPtr;

		// Token: 0x04005B15 RID: 23317
		private static IntPtr __Array_Swap_NativeFunctionPtr;

		// Token: 0x04005B16 RID: 23318
		private static IntPtr __Array_Shuffle_NativeFunctionPtr;

		// Token: 0x04005B17 RID: 23319
		private static IntPtr __Array_Set_NativeFunctionPtr;

		// Token: 0x04005B18 RID: 23320
		private static IntPtr __Array_Reverse_NativeFunctionPtr;

		// Token: 0x04005B19 RID: 23321
		private static IntPtr __Array_Resize_NativeFunctionPtr;

		// Token: 0x04005B1A RID: 23322
		private static IntPtr __Array_RemoveItem_NativeFunctionPtr;

		// Token: 0x04005B1B RID: 23323
		private static IntPtr __Array_Remove_NativeFunctionPtr;

		// Token: 0x04005B1C RID: 23324
		private static IntPtr __Array_RandomFromStream_NativeFunctionPtr;

		// Token: 0x04005B1D RID: 23325
		private static IntPtr __Array_Random_NativeFunctionPtr;

		// Token: 0x04005B1E RID: 23326
		private static IntPtr __Array_Length_NativeFunctionPtr;

		// Token: 0x04005B1F RID: 23327
		private static IntPtr __Array_LastIndex_NativeFunctionPtr;

		// Token: 0x04005B20 RID: 23328
		private static IntPtr __Array_IsValidIndex_NativeFunctionPtr;

		// Token: 0x04005B21 RID: 23329
		private static IntPtr __Array_Insert_NativeFunctionPtr;

		// Token: 0x04005B22 RID: 23330
		private static IntPtr __Array_Identical_NativeFunctionPtr;

		// Token: 0x04005B23 RID: 23331
		private static IntPtr __Array_Get_NativeFunctionPtr;

		// Token: 0x04005B24 RID: 23332
		private static IntPtr __Array_Find_NativeFunctionPtr;

		// Token: 0x04005B25 RID: 23333
		private static IntPtr __Array_Contains_NativeFunctionPtr;

		// Token: 0x04005B26 RID: 23334
		private static IntPtr __Array_Clear_NativeFunctionPtr;

		// Token: 0x04005B27 RID: 23335
		private static IntPtr __Array_Append_NativeFunctionPtr;

		// Token: 0x04005B28 RID: 23336
		private static IntPtr __Array_AddUnique_NativeFunctionPtr;

		// Token: 0x04005B29 RID: 23337
		private static IntPtr __Array_Add_NativeFunctionPtr;

		// Token: 0x02002D1A RID: 11546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetArrayPropertyByName_FunctionParams
		{
			// Token: 0x040166E9 RID: 91881
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x040166EA RID: 91882
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x040166EB RID: 91883
			[FieldOffset(24)]
			public byte Value;
		}

		// Token: 0x02002D1B RID: 11547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Swap_FunctionParams
		{
			// Token: 0x040166EC RID: 91884
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166ED RID: 91885
			[FieldOffset(16)]
			public int FirstIndex;

			// Token: 0x040166EE RID: 91886
			[FieldOffset(20)]
			public int SecondIndex;
		}

		// Token: 0x02002D1C RID: 11548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Array_Shuffle_FunctionParams
		{
			// Token: 0x040166EF RID: 91887
			[FieldOffset(0)]
			public byte TargetArray;
		}

		// Token: 0x02002D1D RID: 11549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Array_Set_FunctionParams
		{
			// Token: 0x040166F0 RID: 91888
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166F1 RID: 91889
			[FieldOffset(16)]
			public int Index;

			// Token: 0x040166F2 RID: 91890
			[FieldOffset(20)]
			public int Item;

			// Token: 0x040166F3 RID: 91891
			[FieldOffset(24)]
			public bool bSizeToFit;
		}

		// Token: 0x02002D1E RID: 11550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Array_Reverse_FunctionParams
		{
			// Token: 0x040166F4 RID: 91892
			[FieldOffset(0)]
			public byte TargetArray;
		}

		// Token: 0x02002D1F RID: 11551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Resize_FunctionParams
		{
			// Token: 0x040166F5 RID: 91893
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166F6 RID: 91894
			[FieldOffset(16)]
			public int Size;
		}

		// Token: 0x02002D20 RID: 11552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_RemoveItem_FunctionParams
		{
			// Token: 0x040166F7 RID: 91895
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166F8 RID: 91896
			[FieldOffset(16)]
			public int Item;

			// Token: 0x040166F9 RID: 91897
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02002D21 RID: 11553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Remove_FunctionParams
		{
			// Token: 0x040166FA RID: 91898
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166FB RID: 91899
			[FieldOffset(16)]
			public int IndexToRemove;
		}

		// Token: 0x02002D22 RID: 11554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Array_RandomFromStream_FunctionParams
		{
			// Token: 0x040166FC RID: 91900
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x040166FD RID: 91901
			[FieldOffset(16)]
			public FRandomStream RandomStream;

			// Token: 0x040166FE RID: 91902
			[FieldOffset(24)]
			public int OutItem;

			// Token: 0x040166FF RID: 91903
			[FieldOffset(28)]
			public int OutIndex;
		}

		// Token: 0x02002D23 RID: 11555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Random_FunctionParams
		{
			// Token: 0x04016700 RID: 91904
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016701 RID: 91905
			[FieldOffset(16)]
			public int OutItem;

			// Token: 0x04016702 RID: 91906
			[FieldOffset(20)]
			public int OutIndex;
		}

		// Token: 0x02002D24 RID: 11556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Length_FunctionParams
		{
			// Token: 0x04016703 RID: 91907
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016704 RID: 91908
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02002D25 RID: 11557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_LastIndex_FunctionParams
		{
			// Token: 0x04016705 RID: 91909
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016706 RID: 91910
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02002D26 RID: 11558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_IsValidIndex_FunctionParams
		{
			// Token: 0x04016707 RID: 91911
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016708 RID: 91912
			[FieldOffset(16)]
			public int IndexToTest;

			// Token: 0x04016709 RID: 91913
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02002D27 RID: 11559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Insert_FunctionParams
		{
			// Token: 0x0401670A RID: 91914
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x0401670B RID: 91915
			[FieldOffset(16)]
			public int NewItem;

			// Token: 0x0401670C RID: 91916
			[FieldOffset(20)]
			public int Index;
		}

		// Token: 0x02002D28 RID: 11560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Array_Identical_FunctionParams
		{
			// Token: 0x0401670D RID: 91917
			[FieldOffset(0)]
			public byte ArrayA;

			// Token: 0x0401670E RID: 91918
			[FieldOffset(16)]
			public byte ArrayB;

			// Token: 0x0401670F RID: 91919
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02002D29 RID: 11561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Get_FunctionParams
		{
			// Token: 0x04016710 RID: 91920
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016711 RID: 91921
			[FieldOffset(16)]
			public int Index;

			// Token: 0x04016712 RID: 91922
			[FieldOffset(20)]
			public int Item;
		}

		// Token: 0x02002D2A RID: 11562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Find_FunctionParams
		{
			// Token: 0x04016713 RID: 91923
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016714 RID: 91924
			[FieldOffset(16)]
			public int ItemToFind;

			// Token: 0x04016715 RID: 91925
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02002D2B RID: 11563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Contains_FunctionParams
		{
			// Token: 0x04016716 RID: 91926
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016717 RID: 91927
			[FieldOffset(16)]
			public int ItemToFind;

			// Token: 0x04016718 RID: 91928
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02002D2C RID: 11564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Array_Clear_FunctionParams
		{
			// Token: 0x04016719 RID: 91929
			[FieldOffset(0)]
			public byte TargetArray;
		}

		// Token: 0x02002D2D RID: 11565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Array_Append_FunctionParams
		{
			// Token: 0x0401671A RID: 91930
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x0401671B RID: 91931
			[FieldOffset(16)]
			public byte SourceArray;
		}

		// Token: 0x02002D2E RID: 11566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_AddUnique_FunctionParams
		{
			// Token: 0x0401671C RID: 91932
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x0401671D RID: 91933
			[FieldOffset(16)]
			public int NewItem;

			// Token: 0x0401671E RID: 91934
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02002D2F RID: 11567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Array_Add_FunctionParams
		{
			// Token: 0x0401671F RID: 91935
			[FieldOffset(0)]
			public byte TargetArray;

			// Token: 0x04016720 RID: 91936
			[FieldOffset(16)]
			public int NewItem;

			// Token: 0x04016721 RID: 91937
			[FieldOffset(20)]
			public int __Result;
		}
	}
}
