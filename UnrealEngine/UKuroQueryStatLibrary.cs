using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E7F RID: 7807
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroQueryStatLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroQueryStatLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB87 RID: 121735 RVA: 0x002BE5F1 File Offset: 0x002BC7F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroQueryStatLibrary._ClassPtr;
		}

		// Token: 0x0601DB88 RID: 121736 RVA: 0x002BE600 File Offset: 0x002BC800
		public UKuroQueryStatLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroQueryStatLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB89 RID: 121737 RVA: 0x002BE628 File Offset: 0x002BC828
		[NullableContext(1)]
		public UKuroQueryStatLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroQueryStatLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DB8A RID: 121738 RVA: 0x002BE65C File Offset: 0x002BC85C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetTestSqliteAction(in FJsObject Action)
		{
			UKuroQueryStatLibrary.__SetTestSqliteAction_FunctionParams* ptr = stackalloc UKuroQueryStatLibrary.__SetTestSqliteAction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroQueryStatLibrary.__SetTestSqliteAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroQueryStatLibrary.__SetTestSqliteAction_NativeFunctionPtr, (void*)ptr, 1);
			if (Action != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FJsObject.StaticStruct(), &ptr->Action, Action.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__SetTestSqliteAction_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroQueryStatLibrary.__SetTestSqliteAction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DB8B RID: 121739 RVA: 0x002BE6D0 File Offset: 0x002BC8D0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetTestDataSavePath(string Path)
		{
			UKuroQueryStatLibrary.__SetTestDataSavePath_FunctionParams* ptr = stackalloc UKuroQueryStatLibrary.__SetTestDataSavePath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroQueryStatLibrary.__SetTestDataSavePath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroQueryStatLibrary.__SetTestDataSavePath_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__SetTestDataSavePath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroQueryStatLibrary.__SetTestDataSavePath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DB8C RID: 121740 RVA: 0x002BE730 File Offset: 0x002BC930
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCloseSaveQueryArgsFileAction(in FJsObject Action)
		{
			UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_FunctionParams* ptr = stackalloc UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_NativeFunctionPtr, (void*)ptr, 1);
			if (Action != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FJsObject.StaticStruct(), &ptr->Action, Action.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroQueryStatLibrary.__SetCloseSaveQueryArgsFileAction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DB8D RID: 121741 RVA: 0x002BE7A4 File Offset: 0x002BC9A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void InvokeTestSqliteAction()
		{
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__InvokeTestSqliteAction_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DB8E RID: 121742 RVA: 0x002BE7B8 File Offset: 0x002BC9B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void InvokeCloseSaveQueryArgsFileAction()
		{
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__InvokeCloseSaveQueryArgsFileAction_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DB8F RID: 121743 RVA: 0x002BE7CC File Offset: 0x002BC9CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void CloseTestDataFile()
		{
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__CloseTestDataFile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DB90 RID: 121744 RVA: 0x002BE7E0 File Offset: 0x002BC9E0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AppendString(string Content)
		{
			UKuroQueryStatLibrary.__AppendString_FunctionParams* ptr = stackalloc UKuroQueryStatLibrary.__AppendString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroQueryStatLibrary.__AppendString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroQueryStatLibrary.__AppendString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Content), Content);
			UnrealReflectionUtils.CallUFunction(UKuroQueryStatLibrary._ClassDefaultObjectPtr, UKuroQueryStatLibrary.__AppendString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroQueryStatLibrary.__AppendString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DB91 RID: 121745 RVA: 0x002BE83D File Offset: 0x002BCA3D
		static UKuroQueryStatLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroQueryStatLibrary");
		}

		// Token: 0x0601DB92 RID: 121746 RVA: 0x002BE84B File Offset: 0x002BCA4B
		protected UKuroQueryStatLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010173 RID: 65907
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroQueryStatLibrary";

		// Token: 0x04010174 RID: 65908
		private static IntPtr _ClassPtr;

		// Token: 0x04010175 RID: 65909
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010176 RID: 65910
		private static IntPtr __SetTestSqliteAction_NativeFunctionPtr;

		// Token: 0x04010177 RID: 65911
		private static IntPtr __SetTestDataSavePath_NativeFunctionPtr;

		// Token: 0x04010178 RID: 65912
		private static IntPtr __SetCloseSaveQueryArgsFileAction_NativeFunctionPtr;

		// Token: 0x04010179 RID: 65913
		private static IntPtr __InvokeTestSqliteAction_NativeFunctionPtr;

		// Token: 0x0401017A RID: 65914
		private static IntPtr __InvokeCloseSaveQueryArgsFileAction_NativeFunctionPtr;

		// Token: 0x0401017B RID: 65915
		private static IntPtr __CloseTestDataFile_NativeFunctionPtr;

		// Token: 0x0401017C RID: 65916
		private static IntPtr __AppendString_NativeFunctionPtr;

		// Token: 0x020032CE RID: 13006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetTestSqliteAction_FunctionParams
		{
			// Token: 0x04017175 RID: 94581
			[FieldOffset(0)]
			public byte Action;
		}

		// Token: 0x020032CF RID: 13007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTestDataSavePath_FunctionParams
		{
			// Token: 0x04017176 RID: 94582
			[FieldOffset(0)]
			public FString Path;
		}

		// Token: 0x020032D0 RID: 13008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetCloseSaveQueryArgsFileAction_FunctionParams
		{
			// Token: 0x04017177 RID: 94583
			[FieldOffset(0)]
			public byte Action;
		}

		// Token: 0x020032D1 RID: 13009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AppendString_FunctionParams
		{
			// Token: 0x04017178 RID: 94584
			[FieldOffset(0)]
			public FString Content;
		}
	}
}
