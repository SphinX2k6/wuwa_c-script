using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000374 RID: 884
	[UnrealObjectPath("/Script/KuroEditorRuntime.EditorRuntimeOperations")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UEditorRuntimeOperations : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060059BF RID: 22975 RVA: 0x0007E851 File Offset: 0x0007CA51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditorRuntimeOperations._ClassPtr;
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x0007E860 File Offset: 0x0007CA60
		public UEditorRuntimeOperations() : this(BuiltinUtils.AllocNativeUObject(UEditorRuntimeOperations.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x0007E888 File Offset: 0x0007CA88
		[NullableContext(1)]
		public UEditorRuntimeOperations(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditorRuntimeOperations.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x0007E8BC File Offset: 0x0007CABC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SendMessage(string Msg, string Ip, int Port)
		{
			UEditorRuntimeOperations.__SendMessage_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__SendMessage_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UEditorRuntimeOperations.__SendMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Msg), Msg);
			FString.CopyFrom((void*)(&ptr->Ip), Ip);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__SendMessage_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0007E934 File Offset: 0x0007CB34
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__SendHttpRequest_NativeFunctionPtr, (void*)ptr);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__SendHttpRequest_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x0007E9F8 File Offset: 0x0007CBF8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void ReadFileAsync(string FilePath, [Nullable(2)] FOnFileReadAsync OnFileRead)
		{
			UEditorRuntimeOperations.__ReadFileAsync_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__ReadFileAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UEditorRuntimeOperations.__ReadFileAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			FScriptDelegate.NativeCopy(&ptr->OnFileRead, (OnFileRead != null) ? OnFileRead.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__ReadFileAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x0007EA70 File Offset: 0x0007CC70
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__ReadBatchFilesAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditorRuntimeOperations.__ReadBatchFilesAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x0007EAF4 File Offset: 0x0007CCF4
		[SkipLocalsInit]
		public unsafe static bool IsUdpPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsUdpPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsUdpPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsUdpPortInUse_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x0007EB40 File Offset: 0x0007CD40
		[SkipLocalsInit]
		public unsafe static bool IsTcpPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsTcpPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsTcpPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsTcpPortInUse_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x0007EB8C File Offset: 0x0007CD8C
		[SkipLocalsInit]
		public unsafe static bool IsPortInUse(int Port)
		{
			UEditorRuntimeOperations.__IsPortInUse_FunctionParams* ptr = stackalloc UEditorRuntimeOperations.__IsPortInUse_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UEditorRuntimeOperations.__IsPortInUse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEditorRuntimeOperations.__IsPortInUse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Port = Port;
			UnrealReflectionUtils.CallUFunction(UEditorRuntimeOperations._ClassDefaultObjectPtr, UEditorRuntimeOperations.__IsPortInUse_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x0007EBD7 File Offset: 0x0007CDD7
		static UEditorRuntimeOperations()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroEditorRuntime.EditorRuntimeOperations");
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x0007EBE5 File Offset: 0x0007CDE5
		protected UEditorRuntimeOperations(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002537 RID: 9527
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroEditorRuntime.EditorRuntimeOperations";

		// Token: 0x04002538 RID: 9528
		private static IntPtr _ClassPtr;

		// Token: 0x04002539 RID: 9529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400253A RID: 9530
		private static IntPtr __SendMessage_NativeFunctionPtr;

		// Token: 0x0400253B RID: 9531
		private static IntPtr __SendHttpRequest_NativeFunctionPtr;

		// Token: 0x0400253C RID: 9532
		private static IntPtr __ReadFileAsync_NativeFunctionPtr;

		// Token: 0x0400253D RID: 9533
		private static IntPtr __ReadBatchFilesAsync_NativeFunctionPtr;

		// Token: 0x0400253E RID: 9534
		private static IntPtr __IsUdpPortInUse_NativeFunctionPtr;

		// Token: 0x0400253F RID: 9535
		private static IntPtr __IsTcpPortInUse_NativeFunctionPtr;

		// Token: 0x04002540 RID: 9536
		private static IntPtr __IsPortInUse_NativeFunctionPtr;

		// Token: 0x02000A7F RID: 2687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SendMessage_FunctionParams
		{
			// Token: 0x04005ABF RID: 23231
			[FieldOffset(0)]
			public FString Msg;

			// Token: 0x04005AC0 RID: 23232
			[FieldOffset(16)]
			public FString Ip;

			// Token: 0x04005AC1 RID: 23233
			[FieldOffset(32)]
			public int Port;

			// Token: 0x04005AC2 RID: 23234
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02000A80 RID: 2688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __SendHttpRequest_FunctionParams
		{
			// Token: 0x04005AC3 RID: 23235
			[FieldOffset(0)]
			public FString Method;

			// Token: 0x04005AC4 RID: 23236
			[FieldOffset(16)]
			public FString Url;

			// Token: 0x04005AC5 RID: 23237
			[FieldOffset(32)]
			public byte HeaderParam;

			// Token: 0x04005AC6 RID: 23238
			[FieldOffset(112)]
			public FString Content;

			// Token: 0x04005AC7 RID: 23239
			[FieldOffset(128)]
			public byte Handler;

			// Token: 0x04005AC8 RID: 23240
			[FieldOffset(168)]
			public float Timeout;
		}

		// Token: 0x02000A81 RID: 2689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ReadFileAsync_FunctionParams
		{
			// Token: 0x04005AC9 RID: 23241
			[FieldOffset(0)]
			public FString FilePath;

			// Token: 0x04005ACA RID: 23242
			[FieldOffset(16)]
			public byte OnFileRead;
		}

		// Token: 0x02000A82 RID: 2690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ReadBatchFilesAsync_FunctionParams
		{
			// Token: 0x04005ACB RID: 23243
			[FieldOffset(0)]
			public byte FilePaths;

			// Token: 0x04005ACC RID: 23244
			[FieldOffset(16)]
			public byte OnAllFilesRead;
		}

		// Token: 0x02000A83 RID: 2691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsUdpPortInUse_FunctionParams
		{
			// Token: 0x04005ACD RID: 23245
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04005ACE RID: 23246
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000A84 RID: 2692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsTcpPortInUse_FunctionParams
		{
			// Token: 0x04005ACF RID: 23247
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04005AD0 RID: 23248
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000A85 RID: 2693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IsPortInUse_FunctionParams
		{
			// Token: 0x04005AD1 RID: 23249
			[FieldOffset(0)]
			public int Port;

			// Token: 0x04005AD2 RID: 23250
			[FieldOffset(4)]
			public bool __Result;
		}
	}
}
