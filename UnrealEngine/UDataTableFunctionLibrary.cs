using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C5 RID: 453
	[UnrealObjectPath("/Script/Engine.DataTableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDataTableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002112 RID: 8466 RVA: 0x0003098B File Offset: 0x0002EB8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataTableFunctionLibrary._ClassPtr;
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00030998 File Offset: 0x0002EB98
		public UDataTableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UDataTableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000309C0 File Offset: 0x0002EBC0
		[NullableContext(1)]
		public UDataTableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataTableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000309F3 File Offset: 0x0002EBF3
		[NullableContext(2)]
		public static void GetDataTableRowNames(UDataTable Table, ref TArray<FName> OutRowNames)
		{
			UDataTableFunctionLibrary.__GetDataTableRowNames_Internal((Table != null) ? Table.NativePtr : IntPtr.Zero, (OutRowNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00030A1C File Offset: 0x0002EC1C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UDataTableFunctionLibrary._ClassDefaultObjectPtr, UDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr);
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), OutRow.NativePtr, &ptr->OutRow, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00030AD6 File Offset: 0x0002ECD6
		[NullableContext(1)]
		public static TArray<string> GetDataTableColumnAsString([Nullable(2)] UDataTable DataTable, FName PropertyName)
		{
			return new TArray<string>(UDataTableFunctionLibrary.__GetDataTableColumnAsString_Internal((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero, PropertyName), null);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00030AF4 File Offset: 0x0002ECF4
		[NullableContext(2)]
		public static bool DoesDataTableRowExist(UDataTable Table, FName RowName)
		{
			return UDataTableFunctionLibrary.__DoesDataTableRowExist_Internal((Table != null) ? Table.NativePtr : IntPtr.Zero, RowName);
		}

		// Token: 0x06002119 RID: 8473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDataTableRowNames_Internal(IntPtr Table, IntPtr OutRowNames);

		// Token: 0x0600211A RID: 8474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDataTableColumnAsString_Internal(IntPtr DataTable, FName PropertyName);

		// Token: 0x0600211B RID: 8475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesDataTableRowExist_Internal(IntPtr Table, FName RowName);

		// Token: 0x0600211C RID: 8476 RVA: 0x00030B0C File Offset: 0x0002ED0C
		static UDataTableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataTableFunctionLibrary");
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00030B1A File Offset: 0x0002ED1A
		protected UDataTableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B09 RID: 2825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataTableFunctionLibrary";

		// Token: 0x04000B0A RID: 2826
		private static IntPtr _ClassPtr;

		// Token: 0x04000B0B RID: 2827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B0C RID: 2828
		private static IntPtr __GetDataTableRowFromName_NativeFunctionPtr;

		// Token: 0x0200099F RID: 2463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetDataTableRowFromName_FunctionParams
		{
			// Token: 0x04005906 RID: 22790
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04005907 RID: 22791
			[FieldOffset(8)]
			public FName RowName;

			// Token: 0x04005908 RID: 22792
			[FieldOffset(24)]
			public byte OutRow;

			// Token: 0x04005909 RID: 22793
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
