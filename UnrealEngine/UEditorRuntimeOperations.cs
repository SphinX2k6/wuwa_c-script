using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200181F RID: 6175
	[UnrealObjectPath("/Script/KuroEditorRuntime.EditorRuntimeOperations")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UEditorRuntimeOperations : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016CF9 RID: 93433 RVA: 0x002148E6 File Offset: 0x00212AE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditorRuntimeOperations._ClassPtr;
		}

		// Token: 0x06016CFA RID: 93434 RVA: 0x002148F4 File Offset: 0x00212AF4
		public UEditorRuntimeOperations() : this(BuiltinUtils.AllocNativeUObject(UEditorRuntimeOperations.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016CFB RID: 93435 RVA: 0x0021491C File Offset: 0x00212B1C
		[NullableContext(1)]
		public UEditorRuntimeOperations(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditorRuntimeOperations.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x00214950 File Offset: 0x00212B50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SendMessage(string Msg, string Ip, int Port)
		{
			UEditorRuntimeOperations.__SendMessage_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__SendMessage_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UEditorRuntimeOperations.__SendMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Msg), Msg);
			FString.CopyFrom((void*)(&ptr->Ip), Ip);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06016CFD RID: 93437 RVA: 0x002149C8 File Offset: 0x00212BC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendHttpRequest(string Method, string Url, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<string, string> HeaderParam, string Content, [Nullable(2)] FHttpResponseRuntimeHandler Handler, float Timeout = 0f)
		{
			UEditorRuntimeOperations.__SendHttpRequest_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__SendHttpRequest_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(UEditorRuntimeOperations.__SendHttpRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__SendHttpRequest_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Method), Method);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			TMap<string, string> tmap = HeaderParam;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->HeaderParam);
			}
			FString.CopyFrom((void*)(&ptr->Content), Content);
			FScriptDelegate.NativeCopy(&ptr->Handler, (Handler != null) ? Handler.NativePtr : ((IntPtr)0));
			ptr->Timeout = Timeout;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__SendHttpRequest_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__SendHttpRequest_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016CFE RID: 93438 RVA: 0x00214A90 File Offset: 0x00212C90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReadFileAsync(string FilePath, [Nullable(2)] FOnFileReadAsync OnFileRead)
		{
			UEditorRuntimeOperations.__ReadFileAsync_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__ReadFileAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UEditorRuntimeOperations.__ReadFileAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			FScriptDelegate.NativeCopy(&ptr->OnFileRead, (OnFileRead != null) ? OnFileRead.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x00214B08 File Offset: 0x00212D08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReadBatchFilesAsync([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> FilePaths, FOnBatchFilesReadAsync OnAllFilesRead)
		{
			UEditorRuntimeOperations.__ReadBatchFilesAsync_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__ReadBatchFilesAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UEditorRuntimeOperations.__ReadBatchFilesAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__ReadBatchFilesAsync_NativeFunctionPtr, (void*)ptr, 1);
			if (FilePaths != null)
			{
				FilePaths.CopyTo(&ptr->FilePaths, default(UScriptStructStackOnlyPtr));
			}
			FScriptDelegate.NativeCopy(&ptr->OnAllFilesRead, (OnAllFilesRead != null) ? OnAllFilesRead.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__ReadBatchFilesAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__ReadBatchFilesAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016D00 RID: 93440 RVA: 0x00214B8C File Offset: 0x00212D8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsUdpPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsUdpPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsUdpPortInUse_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016D01 RID: 93441 RVA: 0x00214BD8 File Offset: 0x00212DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsTcpPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsTcpPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsTcpPortInUse_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016D02 RID: 93442 RVA: 0x00214C24 File Offset: 0x00212E24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsPortInUse_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016D03 RID: 93443 RVA: 0x00214C70 File Offset: 0x00212E70
		static UEditorRuntimeOperations()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroEditorRuntime.EditorRuntimeOperations");
		}

		// Token: 0x06016D04 RID: 93444 RVA: 0x00214C7E File Offset: 0x00212E7E
		protected UEditorRuntimeOperations(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C641 RID: 50753
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroEditorRuntime.EditorRuntimeOperations";

		// Token: 0x0400C642 RID: 50754
		private static IntPtr _ClassPtr;

		// Token: 0x0400C643 RID: 50755
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C644 RID: 50756
		private static IntPtr __SendMessage_NativeFunctionPtr;

		// Token: 0x0400C645 RID: 50757
		private static IntPtr __SendHttpRequest_NativeFunctionPtr;

		// Token: 0x0400C646 RID: 50758
		private static IntPtr __ReadFileAsync_NativeFunctionPtr;

		// Token: 0x0400C647 RID: 50759
		private static IntPtr __ReadBatchFilesAsync_NativeFunctionPtr;

		// Token: 0x0400C648 RID: 50760
		private static IntPtr __IsUdpPortInUse_NativeFunctionPtr;

		// Token: 0x0400C649 RID: 50761
		private static IntPtr __IsTcpPortInUse_NativeFunctionPtr;

		// Token: 0x0400C64A RID: 50762
		private static IntPtr __IsPortInUse_NativeFunctionPtr;

		// Token: 0x02002F56 RID: 12118
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SendMessage_FunctionParams
		{
			// Token: 0x04016AFD RID: 92925
			[FieldOffset(0)]
			public FString Msg;

			// Token: 0x04016AFE RID: 92926
			[FieldOffset(16)]
			public FString Ip;

			// Token: 0x04016AFF RID: 92927
			[FieldOffset(32)]
			public int Port;

			// Token: 0x04016B00 RID: 92928
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02002F57 RID: 12119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __SendHttpRequest_FunctionParams
		{
			// Token: 0x04016B01 RID: 92929
			[FieldOffset(0)]
			public FString Method;

			// Token: 0x04016B02 RID: 92930
			[FieldOffset(16)]
			public FString Url;

			// Token: 0x04016B03 RID: 92931
			[FieldOffset(32)]
			public byte HeaderParam;

			// Token: 0x04016B04 RID: 92932
			[FieldOffset(112)]
			public FString Content;

			// Token: 0x04016B05 RID: 92933
			[FieldOffset(128)]
			public byte Handler;

			// Token: 0x04016B06 RID: 92934
			[FieldOffset(168)]
			public float Timeout;
		}

		// Token: 0x02002F58 RID: 12120
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ReadFileAsync_FunctionParams
		{
			// Token: 0x04016B07 RID: 92935
			[FieldOffset(0)]
			public FString FilePath;

			// Token: 0x04016B08 RID: 92936
			[FieldOffset(16)]
			public byte OnFileRead;
		}

		// Token: 0x02002F59 RID: 12121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ReadBatchFilesAsync_FunctionParams
		{
			// Token: 0x04016B09 RID: 92937
			[FieldOffset(0)]
			public byte FilePaths;

			// Token: 0x04016B0A RID: 92938
			[FieldOffset(16)]
			public byte OnAllFilesRead;
		}

		// Token: 0x02002F5A RID: 12122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsUdpPortInUse_FunctionParams
		{
			// Token: 0x04016B0B RID: 92939
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04016B0C RID: 92940
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002F5B RID: 12123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsTcpPortInUse_FunctionParams
		{
			// Token: 0x04016B0D RID: 92941
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04016B0E RID: 92942
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002F5C RID: 12124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsPortInUse_FunctionParams
		{
			// Token: 0x04016B0F RID: 92943
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04016B10 RID: 92944
			[FieldOffset(4)]
			public bool __Result;
		}
	}
}
