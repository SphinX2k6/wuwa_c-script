using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A3C RID: 6716
	[UnrealObjectPath("/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroDataTableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018DCD RID: 101837 RVA: 0x0024B974 File Offset: 0x00249B74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDataTableFunctionLibrary._ClassPtr;
		}

		// Token: 0x06018DCE RID: 101838 RVA: 0x0024B980 File Offset: 0x00249B80
		public UKuroDataTableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroDataTableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018DCF RID: 101839 RVA: 0x0024B9A8 File Offset: 0x00249BA8
		[NullableContext(1)]
		public UKuroDataTableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDataTableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018DD0 RID: 101840 RVA: 0x0024B9DC File Offset: 0x00249BDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveOnDataTableChangedDelegateById(int HandleId)
		{
			UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018DD1 RID: 101841 RVA: 0x0024BA24 File Offset: 0x00249C24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveOnDataTableChangedDelegate(UDataTable Table, UObject Object)
		{
			UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x0024BA90 File Offset: 0x00249C90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetDataTableRowFromName(UDataTable Table, [Nullable(1)] string RowName, ref FTableRowBase OutRow)
		{
			UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->RowName), RowName);
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), &ptr->OutRow, OutRow.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 0);
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), OutRow.NativePtr, &ptr->OutRow, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06018DD3 RID: 101843 RVA: 0x0024BB54 File Offset: 0x00249D54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int AddOnDataTableChangedDelegate(UDataTable Table, UObject Object, in FOnDataTableChanged OnDataTableChanged)
		{
			UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			IntPtr dest = &ptr->OnDataTableChanged;
			FOnDataTableChanged fonDataTableChanged = OnDataTableChanged;
			FScriptDelegate.NativeCopy(dest, (fonDataTableChanged != null) ? fonDataTableChanged.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 0);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06018DD4 RID: 101844 RVA: 0x0024BBF1 File Offset: 0x00249DF1
		static UKuroDataTableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary");
		}

		// Token: 0x06018DD5 RID: 101845 RVA: 0x0024BBFF File Offset: 0x00249DFF
		protected UKuroDataTableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6E3 RID: 55011
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary";

		// Token: 0x0400D6E4 RID: 55012
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6E5 RID: 55013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6E6 RID: 55014
		private static IntPtr __RemoveOnDataTableChangedDelegateById_NativeFunctionPtr;

		// Token: 0x0400D6E7 RID: 55015
		private static IntPtr __RemoveOnDataTableChangedDelegate_NativeFunctionPtr;

		// Token: 0x0400D6E8 RID: 55016
		private static IntPtr __GetDataTableRowFromName_NativeFunctionPtr;

		// Token: 0x0400D6E9 RID: 55017
		private static IntPtr __AddOnDataTableChangedDelegate_NativeFunctionPtr;

		// Token: 0x020030FB RID: 12539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveOnDataTableChangedDelegateById_FunctionParams
		{
			// Token: 0x04016E7A RID: 93818
			[FieldOffset(0)]
			public int HandleId;
		}

		// Token: 0x020030FC RID: 12540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveOnDataTableChangedDelegate_FunctionParams
		{
			// Token: 0x04016E7B RID: 93819
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04016E7C RID: 93820
			[FieldOffset(8)]
			public IntPtr Object;
		}

		// Token: 0x020030FD RID: 12541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetDataTableRowFromName_FunctionParams
		{
			// Token: 0x04016E7D RID: 93821
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04016E7E RID: 93822
			[FieldOffset(8)]
			public FString RowName;

			// Token: 0x04016E7F RID: 93823
			[FieldOffset(24)]
			public byte OutRow;

			// Token: 0x04016E80 RID: 93824
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x020030FE RID: 12542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AddOnDataTableChangedDelegate_FunctionParams
		{
			// Token: 0x04016E81 RID: 93825
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04016E82 RID: 93826
			[FieldOffset(8)]
			public IntPtr Object;

			// Token: 0x04016E83 RID: 93827
			[FieldOffset(16)]
			public byte OnDataTableChanged;

			// Token: 0x04016E84 RID: 93828
			[FieldOffset(56)]
			public int __Result;
		}
	}
}
