using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002675 RID: 9845
	[UnrealObjectPath("/Script/Puerts.PuertsBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPuertsBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024937 RID: 149815 RVA: 0x003623F9 File Offset: 0x003605F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPuertsBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06024938 RID: 149816 RVA: 0x00362408 File Offset: 0x00360608
		public UPuertsBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UPuertsBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024939 RID: 149817 RVA: 0x00362430 File Offset: 0x00360630
		[NullableContext(1)]
		public UPuertsBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPuertsBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602493A RID: 149818 RVA: 0x00362464 File Offset: 0x00360664
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void StartShareJsEnv(FName ModuleName, UGameInstance GameInstance)
		{
			UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__StartShareJsEnv_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ModuleName = ModuleName;
			ptr->GameInstance = ((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__StartShareJsEnv_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602493B RID: 149819 RVA: 0x003624C0 File Offset: 0x003606C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetEnableBlueprintBind(bool value)
		{
			UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__SetEnableBlueprintBind_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__SetEnableBlueprintBind_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602493C RID: 149820 RVA: 0x00362506 File Offset: 0x00360706
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void PreStartShareJsEnv()
		{
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__PreStartShareJsEnv_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602493D RID: 149821 RVA: 0x0036251C File Offset: 0x0036071C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PreloadJS(UKuroPreloadJSCallback Callback)
		{
			UPuertsBlueprintLibrary.__PreloadJS_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__PreloadJS_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__PreloadJS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__PreloadJS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Callback = ((Callback != null) ? Callback.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__PreloadJS_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602493E RID: 149822 RVA: 0x00362574 File Offset: 0x00360774
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ExecuteModuleInSharedJsEnv(FName ModuleName)
		{
			UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ModuleName = ModuleName;
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602493F RID: 149823 RVA: 0x003625BA File Offset: 0x003607BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearJSCache()
		{
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__ClearJSCache_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024940 RID: 149824 RVA: 0x003625CE File Offset: 0x003607CE
		static UPuertsBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Puerts.PuertsBlueprintLibrary");
		}

		// Token: 0x06024941 RID: 149825 RVA: 0x003625DC File Offset: 0x003607DC
		protected UPuertsBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A72 RID: 80498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Puerts.PuertsBlueprintLibrary";

		// Token: 0x04013A73 RID: 80499
		private static IntPtr _ClassPtr;

		// Token: 0x04013A74 RID: 80500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A75 RID: 80501
		private static IntPtr __StartShareJsEnv_NativeFunctionPtr;

		// Token: 0x04013A76 RID: 80502
		private static IntPtr __SetEnableBlueprintBind_NativeFunctionPtr;

		// Token: 0x04013A77 RID: 80503
		private static IntPtr __PreStartShareJsEnv_NativeFunctionPtr;

		// Token: 0x04013A78 RID: 80504
		private static IntPtr __PreloadJS_NativeFunctionPtr;

		// Token: 0x04013A79 RID: 80505
		private static IntPtr __ExecuteModuleInSharedJsEnv_NativeFunctionPtr;

		// Token: 0x04013A7A RID: 80506
		private static IntPtr __ClearJSCache_NativeFunctionPtr;

		// Token: 0x02003689 RID: 13961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __StartShareJsEnv_FunctionParams
		{
			// Token: 0x04017776 RID: 96118
			[FieldOffset(0)]
			public FName ModuleName;

			// Token: 0x04017777 RID: 96119
			[FieldOffset(16)]
			public IntPtr GameInstance;
		}

		// Token: 0x0200368A RID: 13962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableBlueprintBind_FunctionParams
		{
			// Token: 0x04017778 RID: 96120
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x0200368B RID: 13963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __PreloadJS_FunctionParams
		{
			// Token: 0x04017779 RID: 96121
			[FieldOffset(0)]
			public IntPtr Callback;
		}

		// Token: 0x0200368C RID: 13964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ExecuteModuleInSharedJsEnv_FunctionParams
		{
			// Token: 0x0401777A RID: 96122
			[FieldOffset(0)]
			public FName ModuleName;
		}
	}
}
