using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049C RID: 1180
	[UnrealObjectPath("/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroDataTableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006E12 RID: 28178 RVA: 0x000A1E0E File Offset: 0x000A000E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDataTableFunctionLibrary._ClassPtr;
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x000A1E1C File Offset: 0x000A001C
		public UKuroDataTableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroDataTableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x000A1E44 File Offset: 0x000A0044
		[NullableContext(1)]
		public UKuroDataTableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDataTableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x000A1E78 File Offset: 0x000A0078
		[SkipLocalsInit]
		public unsafe static void RemoveOnDataTableChangedDelegateById(int HandleId)
		{
			UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegateById_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveOnDataTableChangedDelegate(UDataTable Table, UObject Object)
		{
			UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__RemoveOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x000A1F2C File Offset: 0x000A012C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr);
			if (OutRow != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowBase.StaticStruct(), OutRow.NativePtr, &ptr->OutRow, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroDataTableFunctionLibrary.__GetDataTableRowFromName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x000A1FEC File Offset: 0x000A01EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static int AddOnDataTableChangedDelegate(UDataTable Table, UObject Object, in FOnDataTableChanged OnDataTableChanged)
		{
			UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams* ptr = stackalloc UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Table = ((Table != null) ? Table.NativePtr : IntPtr.Zero);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			IntPtr dest = &ptr->OnDataTableChanged;
			FOnDataTableChanged fonDataTableChanged = OnDataTableChanged;
			FScriptDelegate.NativeCopy(dest, (fonDataTableChanged != null) ? fonDataTableChanged.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroDataTableFunctionLibrary._ClassDefaultObjectPtr, UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroDataTableFunctionLibrary.__AddOnDataTableChangedDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x000A2088 File Offset: 0x000A0288
		static UKuroDataTableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary");
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x000A2096 File Offset: 0x000A0296
		protected UKuroDataTableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F23 RID: 12067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPuertsWrapper.KuroDataTableFunctionLibrary";

		// Token: 0x04002F24 RID: 12068
		private static IntPtr _ClassPtr;

		// Token: 0x04002F25 RID: 12069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F26 RID: 12070
		private static IntPtr __RemoveOnDataTableChangedDelegateById_NativeFunctionPtr;

		// Token: 0x04002F27 RID: 12071
		private static IntPtr __RemoveOnDataTableChangedDelegate_NativeFunctionPtr;

		// Token: 0x04002F28 RID: 12072
		private static IntPtr __GetDataTableRowFromName_NativeFunctionPtr;

		// Token: 0x04002F29 RID: 12073
		private static IntPtr __AddOnDataTableChangedDelegate_NativeFunctionPtr;

		// Token: 0x02000BD0 RID: 3024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveOnDataTableChangedDelegateById_FunctionParams
		{
			// Token: 0x04005D74 RID: 23924
			[FieldOffset(0)]
			public int HandleId;
		}

		// Token: 0x02000BD1 RID: 3025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveOnDataTableChangedDelegate_FunctionParams
		{
			// Token: 0x04005D75 RID: 23925
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04005D76 RID: 23926
			[FieldOffset(8)]
			public IntPtr Object;
		}

		// Token: 0x02000BD2 RID: 3026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetDataTableRowFromName_FunctionParams
		{
			// Token: 0x04005D77 RID: 23927
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04005D78 RID: 23928
			[FieldOffset(8)]
			public FString RowName;

			// Token: 0x04005D79 RID: 23929
			[FieldOffset(24)]
			public byte OutRow;

			// Token: 0x04005D7A RID: 23930
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02000BD3 RID: 3027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AddOnDataTableChangedDelegate_FunctionParams
		{
			// Token: 0x04005D7B RID: 23931
			[FieldOffset(0)]
			public IntPtr Table;

			// Token: 0x04005D7C RID: 23932
			[FieldOffset(8)]
			public IntPtr Object;

			// Token: 0x04005D7D RID: 23933
			[FieldOffset(16)]
			public byte OnDataTableChanged;

			// Token: 0x04005D7E RID: 23934
			[FieldOffset(56)]
			public int __Result;
		}
	}
}
