using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099F RID: 2463
	[UnrealObjectPath("/Script/Engine.DataTableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDataTableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B0D RID: 35597 RVA: 0x000C7347 File Offset: 0x000C5547
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataTableFunctionLibrary._ClassPtr;
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x000C7354 File Offset: 0x000C5554
		public UDataTableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UDataTableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x000C737C File Offset: 0x000C557C
		[NullableContext(1)]
		public UDataTableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataTableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x000C73AF File Offset: 0x000C55AF
		[NullableContext(2)]
		public static void GetDataTableRowNames(UDataTable Table, ref TArray<FName> OutRowNames)
		{
			UDataTableFunctionLibrary.__GetDataTableRowNames_Internal((Table != null) ? Table.NativePtr : IntPtr.Zero, (OutRowNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x000C73D8 File Offset: 0x000C55D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetDataTableRowFromName(UDataTable Table, FName RowName, ref FTableRowBase OutRow)
		{
			UDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams* ptr = stackalloc UDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			ptr->RowName = RowName;
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), &ptr->OutRow, OutRow.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UDataTableFunctionLibrary._ClassDefaultObjectPtr, UDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 0);
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), OutRow.NativePtr, &ptr->OutRow, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x000C7493 File Offset: 0x000C5693
		[NullableContext(1)]
		public static TArray<string> GetDataTableColumnAsString([Nullable(2)] UDataTable DataTable, FName PropertyName)
		{
			return new TArray<string>(UDataTableFunctionLibrary.__GetDataTableColumnAsString_Internal((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero, PropertyName), null);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x000C74B4 File Offset: 0x000C56B4
		[NullableContext(1)]
		public unsafe static void EvaluateCurveTableRow([Nullable(2)] UCurveTable CurveTable, FName RowName, float InXY, ref EEvaluateCurveTableResult OutResult, ref float OutXY, string ContextString)
		{
			TEnumAsByte<EEvaluateCurveTableResult> value = OutResult;
			FString fstring = FString.AllocTemp(ContextString);
			fixed (float* ptr = &OutXY)
			{
				void* ptr2 = (void*)ptr;
				UDataTableFunctionLibrary.__EvaluateCurveTableRow_Internal((CurveTable != null) ? CurveTable.NativePtr : IntPtr.Zero, RowName, InXY, ref value, ref OutXY, fstring);
				OutResult = value;
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x000C7508 File Offset: 0x000C5708
		[NullableContext(2)]
		public static bool DoesDataTableRowExist(UDataTable Table, FName RowName)
		{
			return UDataTableFunctionLibrary.__DoesDataTableRowExist_Internal((Table != null) ? Table.NativePtr : IntPtr.Zero, RowName);
		}

		// Token: 0x06008B15 RID: 35605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDataTableRowNames_Internal(IntPtr Table, IntPtr OutRowNames);

		// Token: 0x06008B16 RID: 35606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDataTableColumnAsString_Internal(IntPtr DataTable, FName PropertyName);

		// Token: 0x06008B17 RID: 35607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EvaluateCurveTableRow_Internal(IntPtr CurveTable, FName RowName, float InXY, ref TEnumAsByte<EEvaluateCurveTableResult> OutResult, ref float OutXY, in FString ContextString);

		// Token: 0x06008B18 RID: 35608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesDataTableRowExist_Internal(IntPtr Table, FName RowName);

		// Token: 0x06008B19 RID: 35609 RVA: 0x000C7520 File Offset: 0x000C5720
		static UDataTableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataTableFunctionLibrary");
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x000C752E File Offset: 0x000C572E
		protected UDataTableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400420E RID: 16910
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataTableFunctionLibrary";

		// Token: 0x0400420F RID: 16911
		private static IntPtr _ClassPtr;

		// Token: 0x04004210 RID: 16912
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004211 RID: 16913
		private static IntPtr __GetDataTableRowFromName_NativeFunctionPtr;

		// Token: 0x02002CF7 RID: 11511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetDataTableRowFromName_FunctionParams
		{
			// Token: 0x040166A9 RID: 91817
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x040166AA RID: 91818
			[FieldOffset(8)]
			public FName RowName;

			// Token: 0x040166AB RID: 91819
			[FieldOffset(24)]
			public byte OutRow;

			// Token: 0x040166AC RID: 91820
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
