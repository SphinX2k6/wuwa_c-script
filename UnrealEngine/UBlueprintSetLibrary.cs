using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CD RID: 2253
	[UnrealObjectPath("/Script/Engine.BlueprintSetLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintSetLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007BA2 RID: 31650 RVA: 0x000B0C1F File Offset: 0x000AEE1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintSetLibrary._ClassPtr;
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x000B0C2C File Offset: 0x000AEE2C
		public UBlueprintSetLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintSetLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x000B0C54 File Offset: 0x000AEE54
		[NullableContext(1)]
		public UBlueprintSetLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintSetLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x000B0C88 File Offset: 0x000AEE88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSetPropertyByName(UObject Object, FName PropertyName, in TSet<int> Value)
		{
			UBlueprintSetLibrary.__SetSetPropertyByName_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__SetSetPropertyByName_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(UBlueprintSetLibrary.__SetSetPropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__SetSetPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			TSet<int> tset = Value;
			if (tset != null)
			{
				tset.MoveTo(&ptr->Value);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__SetSetPropertyByName_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = Value;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->Value);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__SetSetPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x000B0D20 File Offset: 0x000AEF20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_Union(in TSet<int> A, in TSet<int> B, ref TSet<int> Result)
		{
			UBlueprintSetLibrary.__Set_Union_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Union_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Union_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Union_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = A;
			if (tset != null)
			{
				tset.MoveTo(&ptr->A);
			}
			TSet<int> tset2 = B;
			if (tset2 != null)
			{
				tset2.MoveTo(&ptr->B);
			}
			TSet<int> tset3 = Result;
			if (tset3 != null)
			{
				tset3.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Union_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset4 = A;
			if (tset4 != null)
			{
				tset4.MoveAssign(&ptr->A);
			}
			TSet<int> tset5 = B;
			if (tset5 != null)
			{
				tset5.MoveAssign(&ptr->B);
			}
			TSet<int> tset6 = Result;
			if (tset6 != null)
			{
				tset6.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Union_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x000B0DEC File Offset: 0x000AEFEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_ToArray(in TSet<int> A, ref TArray<int> Result)
		{
			UBlueprintSetLibrary.__Set_ToArray_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_ToArray_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_ToArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_ToArray_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = A;
			if (tset != null)
			{
				tset.MoveTo(&ptr->A);
			}
			TArray<int> tarray = Result;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_ToArray_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = A;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->A);
			}
			TArray<int> tarray2 = Result;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_ToArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x000B0E8C File Offset: 0x000AF08C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_RemoveItems(in TSet<int> TargetSet, in TArray<int> Items)
		{
			UBlueprintSetLibrary.__Set_RemoveItems_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_RemoveItems_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_RemoveItems_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_RemoveItems_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			TArray<int> tarray = Items;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Items);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_RemoveItems_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			TArray<int> tarray2 = Items;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Items);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_RemoveItems_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x000B0F2C File Offset: 0x000AF12C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Set_Remove(in TSet<int> TargetSet, in int Item)
		{
			UBlueprintSetLibrary.__Set_Remove_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Remove_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Remove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Remove_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			ptr->Item = Item;
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Remove_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Remove_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x000B0FB4 File Offset: 0x000AF1B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Set_Length(in TSet<int> TargetSet)
		{
			UBlueprintSetLibrary.__Set_Length_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Length_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Length_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Length_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Length_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Length_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x000B1034 File Offset: 0x000AF234
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_Intersection(in TSet<int> A, in TSet<int> B, ref TSet<int> Result)
		{
			UBlueprintSetLibrary.__Set_Intersection_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Intersection_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Intersection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Intersection_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = A;
			if (tset != null)
			{
				tset.MoveTo(&ptr->A);
			}
			TSet<int> tset2 = B;
			if (tset2 != null)
			{
				tset2.MoveTo(&ptr->B);
			}
			TSet<int> tset3 = Result;
			if (tset3 != null)
			{
				tset3.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Intersection_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset4 = A;
			if (tset4 != null)
			{
				tset4.MoveAssign(&ptr->A);
			}
			TSet<int> tset5 = B;
			if (tset5 != null)
			{
				tset5.MoveAssign(&ptr->B);
			}
			TSet<int> tset6 = Result;
			if (tset6 != null)
			{
				tset6.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Intersection_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x000B1100 File Offset: 0x000AF300
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_Difference(in TSet<int> A, in TSet<int> B, ref TSet<int> Result)
		{
			UBlueprintSetLibrary.__Set_Difference_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Difference_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Difference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Difference_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = A;
			if (tset != null)
			{
				tset.MoveTo(&ptr->A);
			}
			TSet<int> tset2 = B;
			if (tset2 != null)
			{
				tset2.MoveTo(&ptr->B);
			}
			TSet<int> tset3 = Result;
			if (tset3 != null)
			{
				tset3.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Difference_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset4 = A;
			if (tset4 != null)
			{
				tset4.MoveAssign(&ptr->A);
			}
			TSet<int> tset5 = B;
			if (tset5 != null)
			{
				tset5.MoveAssign(&ptr->B);
			}
			TSet<int> tset6 = Result;
			if (tset6 != null)
			{
				tset6.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Difference_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x000B11CC File Offset: 0x000AF3CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Set_Contains(in TSet<int> TargetSet, in int ItemToFind)
		{
			UBlueprintSetLibrary.__Set_Contains_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Contains_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Contains_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Contains_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			ptr->ItemToFind = ItemToFind;
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Contains_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Contains_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x000B1254 File Offset: 0x000AF454
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_Clear(in TSet<int> TargetSet)
		{
			UBlueprintSetLibrary.__Set_Clear_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Clear_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Clear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Clear_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Clear_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Clear_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x000B12CC File Offset: 0x000AF4CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_AddItems(in TSet<int> TargetSet, in TArray<int> NewItems)
		{
			UBlueprintSetLibrary.__Set_AddItems_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_AddItems_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_AddItems_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_AddItems_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			TArray<int> tarray = NewItems;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewItems);
			}
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_AddItems_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			TArray<int> tarray2 = NewItems;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewItems);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_AddItems_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x000B136C File Offset: 0x000AF56C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Set_Add(in TSet<int> TargetSet, in int NewItem)
		{
			UBlueprintSetLibrary.__Set_Add_FunctionParams* ptr = stackalloc UBlueprintSetLibrary.__Set_Add_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UBlueprintSetLibrary.__Set_Add_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBlueprintSetLibrary.__Set_Add_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = TargetSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->TargetSet);
			}
			ptr->NewItem = NewItem;
			UnrealReflectionUtils.CallUFunction(UBlueprintSetLibrary._ClassDefaultObjectPtr, UBlueprintSetLibrary.__Set_Add_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = TargetSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->TargetSet);
			}
			UnrealReflectionUtils.DestroyStruct(UBlueprintSetLibrary.__Set_Add_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x000B13EC File Offset: 0x000AF5EC
		static UBlueprintSetLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintSetLibrary");
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x000B13FA File Offset: 0x000AF5FA
		protected UBlueprintSetLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B24 RID: 15140
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintSetLibrary";

		// Token: 0x04003B25 RID: 15141
		private static IntPtr _ClassPtr;

		// Token: 0x04003B26 RID: 15142
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003B27 RID: 15143
		private static IntPtr __SetSetPropertyByName_NativeFunctionPtr;

		// Token: 0x04003B28 RID: 15144
		private static IntPtr __Set_Union_NativeFunctionPtr;

		// Token: 0x04003B29 RID: 15145
		private static IntPtr __Set_ToArray_NativeFunctionPtr;

		// Token: 0x04003B2A RID: 15146
		private static IntPtr __Set_RemoveItems_NativeFunctionPtr;

		// Token: 0x04003B2B RID: 15147
		private static IntPtr __Set_Remove_NativeFunctionPtr;

		// Token: 0x04003B2C RID: 15148
		private static IntPtr __Set_Length_NativeFunctionPtr;

		// Token: 0x04003B2D RID: 15149
		private static IntPtr __Set_Intersection_NativeFunctionPtr;

		// Token: 0x04003B2E RID: 15150
		private static IntPtr __Set_Difference_NativeFunctionPtr;

		// Token: 0x04003B2F RID: 15151
		private static IntPtr __Set_Contains_NativeFunctionPtr;

		// Token: 0x04003B30 RID: 15152
		private static IntPtr __Set_Clear_NativeFunctionPtr;

		// Token: 0x04003B31 RID: 15153
		private static IntPtr __Set_AddItems_NativeFunctionPtr;

		// Token: 0x04003B32 RID: 15154
		private static IntPtr __Set_Add_NativeFunctionPtr;

		// Token: 0x02002CA2 RID: 11426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetSetPropertyByName_FunctionParams
		{
			// Token: 0x0401660B RID: 91659
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x0401660C RID: 91660
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x0401660D RID: 91661
			[FieldOffset(24)]
			public byte Value;
		}

		// Token: 0x02002CA3 RID: 11427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __Set_Union_FunctionParams
		{
			// Token: 0x0401660E RID: 91662
			[FieldOffset(0)]
			public byte A;

			// Token: 0x0401660F RID: 91663
			[FieldOffset(80)]
			public byte B;

			// Token: 0x04016610 RID: 91664
			[FieldOffset(160)]
			public byte Result;
		}

		// Token: 0x02002CA4 RID: 11428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Set_ToArray_FunctionParams
		{
			// Token: 0x04016611 RID: 91665
			[FieldOffset(0)]
			public byte A;

			// Token: 0x04016612 RID: 91666
			[FieldOffset(80)]
			public byte Result;
		}

		// Token: 0x02002CA5 RID: 11429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Set_RemoveItems_FunctionParams
		{
			// Token: 0x04016613 RID: 91667
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016614 RID: 91668
			[FieldOffset(80)]
			public byte Items;
		}

		// Token: 0x02002CA6 RID: 11430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Set_Remove_FunctionParams
		{
			// Token: 0x04016615 RID: 91669
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016616 RID: 91670
			[FieldOffset(80)]
			public int Item;

			// Token: 0x04016617 RID: 91671
			[FieldOffset(84)]
			public bool __Result;
		}

		// Token: 0x02002CA7 RID: 11431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Set_Length_FunctionParams
		{
			// Token: 0x04016618 RID: 91672
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016619 RID: 91673
			[FieldOffset(80)]
			public int __Result;
		}

		// Token: 0x02002CA8 RID: 11432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __Set_Intersection_FunctionParams
		{
			// Token: 0x0401661A RID: 91674
			[FieldOffset(0)]
			public byte A;

			// Token: 0x0401661B RID: 91675
			[FieldOffset(80)]
			public byte B;

			// Token: 0x0401661C RID: 91676
			[FieldOffset(160)]
			public byte Result;
		}

		// Token: 0x02002CA9 RID: 11433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __Set_Difference_FunctionParams
		{
			// Token: 0x0401661D RID: 91677
			[FieldOffset(0)]
			public byte A;

			// Token: 0x0401661E RID: 91678
			[FieldOffset(80)]
			public byte B;

			// Token: 0x0401661F RID: 91679
			[FieldOffset(160)]
			public byte Result;
		}

		// Token: 0x02002CAA RID: 11434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Set_Contains_FunctionParams
		{
			// Token: 0x04016620 RID: 91680
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016621 RID: 91681
			[FieldOffset(80)]
			public int ItemToFind;

			// Token: 0x04016622 RID: 91682
			[FieldOffset(84)]
			public bool __Result;
		}

		// Token: 0x02002CAB RID: 11435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Set_Clear_FunctionParams
		{
			// Token: 0x04016623 RID: 91683
			[FieldOffset(0)]
			public byte TargetSet;
		}

		// Token: 0x02002CAC RID: 11436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Set_AddItems_FunctionParams
		{
			// Token: 0x04016624 RID: 91684
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016625 RID: 91685
			[FieldOffset(80)]
			public byte NewItems;
		}

		// Token: 0x02002CAD RID: 11437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Set_Add_FunctionParams
		{
			// Token: 0x04016626 RID: 91686
			[FieldOffset(0)]
			public byte TargetSet;

			// Token: 0x04016627 RID: 91687
			[FieldOffset(80)]
			public int NewItem;
		}
	}
}
