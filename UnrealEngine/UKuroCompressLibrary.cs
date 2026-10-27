using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB3 RID: 7859
	[UnrealObjectPath("/Script/KuroUtility.KuroCompressLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCompressLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD44 RID: 122180 RVA: 0x002C2008 File Offset: 0x002C0208
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCompressLibrary._ClassPtr;
		}

		// Token: 0x0601DD45 RID: 122181 RVA: 0x002C2014 File Offset: 0x002C0214
		public UKuroCompressLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCompressLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD46 RID: 122182 RVA: 0x002C203C File Offset: 0x002C023C
		[NullableContext(1)]
		public UKuroCompressLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCompressLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD47 RID: 122183 RVA: 0x002C2070 File Offset: 0x002C0270
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CompressFilesOrFoldersAsync([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Paths, [Nullable(1)] string DestPath, in FOnCompressingProgress OnProgress, in FOnCompressComplete OnCompressComplete, in FOnCompressFail OnFail, bool bAutoIncludeFilesUnderFolder = false, long MaxSingleFileReadSize = 0L)
		{
			UKuroCompressLibrary.__CompressFilesOrFoldersAsync_FunctionParams* ptr = stackalloc UKuroCompressLibrary.__CompressFilesOrFoldersAsync_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(UKuroCompressLibrary.__CompressFilesOrFoldersAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCompressLibrary.__CompressFilesOrFoldersAsync_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = Paths;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Paths);
			}
			FString.CopyFrom((void*)(&ptr->DestPath), DestPath);
			IntPtr dest = &ptr->OnProgress;
			FOnCompressingProgress fonCompressingProgress = OnProgress;
			FScriptDelegate.NativeCopy(dest, (fonCompressingProgress != null) ? fonCompressingProgress.NativePtr : ((IntPtr)0));
			IntPtr dest2 = &ptr->OnCompressComplete;
			FOnCompressComplete fonCompressComplete = OnCompressComplete;
			FScriptDelegate.NativeCopy(dest2, (fonCompressComplete != null) ? fonCompressComplete.NativePtr : ((IntPtr)0));
			IntPtr dest3 = &ptr->OnFail;
			FOnCompressFail fonCompressFail = OnFail;
			FScriptDelegate.NativeCopy(dest3, (fonCompressFail != null) ? fonCompressFail.NativePtr : ((IntPtr)0));
			ptr->bAutoIncludeFilesUnderFolder = bAutoIncludeFilesUnderFolder;
			ptr->MaxSingleFileReadSize = MaxSingleFileReadSize;
			UnrealReflectionUtils.CallUFunction(UKuroCompressLibrary._ClassDefaultObjectPtr, UKuroCompressLibrary.__CompressFilesOrFoldersAsync_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = Paths;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Paths);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroCompressLibrary.__CompressFilesOrFoldersAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD48 RID: 122184 RVA: 0x002C215C File Offset: 0x002C035C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CompressFileOrFolder([Nullable(1)] string Path, [Nullable(1)] string DestPath, in FOnCompressingProgress OnProgress, in FOnCompressComplete OnCompressComplete, in FOnCompressFail OnFail, long MaxSingleFileReadSize = 0L)
		{
			UKuroCompressLibrary.__CompressFileOrFolder_FunctionParams* ptr = stackalloc UKuroCompressLibrary.__CompressFileOrFolder_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(UKuroCompressLibrary.__CompressFileOrFolder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCompressLibrary.__CompressFileOrFolder_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			FString.CopyFrom((void*)(&ptr->DestPath), DestPath);
			IntPtr dest = &ptr->OnProgress;
			FOnCompressingProgress fonCompressingProgress = OnProgress;
			FScriptDelegate.NativeCopy(dest, (fonCompressingProgress != null) ? fonCompressingProgress.NativePtr : ((IntPtr)0));
			IntPtr dest2 = &ptr->OnCompressComplete;
			FOnCompressComplete fonCompressComplete = OnCompressComplete;
			FScriptDelegate.NativeCopy(dest2, (fonCompressComplete != null) ? fonCompressComplete.NativePtr : ((IntPtr)0));
			IntPtr dest3 = &ptr->OnFail;
			FOnCompressFail fonCompressFail = OnFail;
			FScriptDelegate.NativeCopy(dest3, (fonCompressFail != null) ? fonCompressFail.NativePtr : ((IntPtr)0));
			ptr->MaxSingleFileReadSize = MaxSingleFileReadSize;
			UnrealReflectionUtils.CallUFunction(UKuroCompressLibrary._ClassDefaultObjectPtr, UKuroCompressLibrary.__CompressFileOrFolder_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroCompressLibrary.__CompressFileOrFolder_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD49 RID: 122185 RVA: 0x002C2223 File Offset: 0x002C0423
		static UKuroCompressLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCompressLibrary");
		}

		// Token: 0x0601DD4A RID: 122186 RVA: 0x002C2231 File Offset: 0x002C0431
		protected UKuroCompressLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102A7 RID: 66215
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCompressLibrary";

		// Token: 0x040102A8 RID: 66216
		private static IntPtr _ClassPtr;

		// Token: 0x040102A9 RID: 66217
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102AA RID: 66218
		private static IntPtr __CompressFilesOrFoldersAsync_NativeFunctionPtr;

		// Token: 0x040102AB RID: 66219
		private static IntPtr __CompressFileOrFolder_NativeFunctionPtr;

		// Token: 0x02003311 RID: 13073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __CompressFilesOrFoldersAsync_FunctionParams
		{
			// Token: 0x040171E0 RID: 94688
			[FieldOffset(0)]
			public byte Paths;

			// Token: 0x040171E1 RID: 94689
			[FieldOffset(16)]
			public FString DestPath;

			// Token: 0x040171E2 RID: 94690
			[FieldOffset(32)]
			public byte OnProgress;

			// Token: 0x040171E3 RID: 94691
			[FieldOffset(72)]
			public byte OnCompressComplete;

			// Token: 0x040171E4 RID: 94692
			[FieldOffset(112)]
			public byte OnFail;

			// Token: 0x040171E5 RID: 94693
			[FieldOffset(152)]
			public bool bAutoIncludeFilesUnderFolder;

			// Token: 0x040171E6 RID: 94694
			[FieldOffset(160)]
			public long MaxSingleFileReadSize;
		}

		// Token: 0x02003312 RID: 13074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __CompressFileOrFolder_FunctionParams
		{
			// Token: 0x040171E7 RID: 94695
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x040171E8 RID: 94696
			[FieldOffset(16)]
			public FString DestPath;

			// Token: 0x040171E9 RID: 94697
			[FieldOffset(32)]
			public byte OnProgress;

			// Token: 0x040171EA RID: 94698
			[FieldOffset(72)]
			public byte OnCompressComplete;

			// Token: 0x040171EB RID: 94699
			[FieldOffset(112)]
			public byte OnFail;

			// Token: 0x040171EC RID: 94700
			[FieldOffset(152)]
			public long MaxSingleFileReadSize;
		}
	}
}
