using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B9 RID: 1977
	[UnrealObjectPath("/Script/Puerts.PuertsBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPuertsBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABA0 RID: 43936 RVA: 0x000FD096 File Offset: 0x000FB296
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPuertsBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x000FD0A4 File Offset: 0x000FB2A4
		public UPuertsBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UPuertsBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x000FD0CC File Offset: 0x000FB2CC
		[NullableContext(1)]
		public UPuertsBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPuertsBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x000FD100 File Offset: 0x000FB300
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void StartShareJsEnv(FName ModuleName, UGameInstance GameInstance)
		{
			UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__StartShareJsEnv_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__StartShareJsEnv_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ModuleName = ModuleName;
			ptr->GameInstance = ((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__StartShareJsEnv_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x000FD15C File Offset: 0x000FB35C
		[SkipLocalsInit]
		public unsafe static void SetEnableBlueprintBind(bool value)
		{
			UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__SetEnableBlueprintBind_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__SetEnableBlueprintBind_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__SetEnableBlueprintBind_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x000FD1A1 File Offset: 0x000FB3A1
		[SkipLocalsInit]
		public static void PreStartShareJsEnv()
		{
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__PreStartShareJsEnv_NativeFunctionPtr, null);
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x000FD1B4 File Offset: 0x000FB3B4
		[SkipLocalsInit]
		public unsafe static void ExecuteModuleInSharedJsEnv(FName ModuleName)
		{
			UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams* ptr = stackalloc UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ModuleName = ModuleName;
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__ExecuteModuleInSharedJsEnv_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x000FD1F9 File Offset: 0x000FB3F9
		[SkipLocalsInit]
		public static void ClearJSCache()
		{
			UnrealReflectionUtils.CallUFunction(UPuertsBlueprintLibrary._ClassDefaultObjectPtr, UPuertsBlueprintLibrary.__ClearJSCache_NativeFunctionPtr, null);
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x000FD20C File Offset: 0x000FB40C
		static UPuertsBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Puerts.PuertsBlueprintLibrary");
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x000FD21A File Offset: 0x000FB41A
		protected UPuertsBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049B6 RID: 18870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Puerts.PuertsBlueprintLibrary";

		// Token: 0x040049B7 RID: 18871
		private static IntPtr _ClassPtr;

		// Token: 0x040049B8 RID: 18872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049B9 RID: 18873
		private static IntPtr __StartShareJsEnv_NativeFunctionPtr;

		// Token: 0x040049BA RID: 18874
		private static IntPtr __SetEnableBlueprintBind_NativeFunctionPtr;

		// Token: 0x040049BB RID: 18875
		private static IntPtr __PreStartShareJsEnv_NativeFunctionPtr;

		// Token: 0x040049BC RID: 18876
		private static IntPtr __ExecuteModuleInSharedJsEnv_NativeFunctionPtr;

		// Token: 0x040049BD RID: 18877
		private static IntPtr __ClearJSCache_NativeFunctionPtr;

		// Token: 0x02000F67 RID: 3943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __StartShareJsEnv_FunctionParams
		{
			// Token: 0x0400633E RID: 25406
			[FieldOffset(0)]
			public FName ModuleName;

			// Token: 0x0400633F RID: 25407
			[FieldOffset(16)]
			public IntPtr GameInstance;
		}

		// Token: 0x02000F68 RID: 3944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableBlueprintBind_FunctionParams
		{
			// Token: 0x04006340 RID: 25408
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x02000F69 RID: 3945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ExecuteModuleInSharedJsEnv_FunctionParams
		{
			// Token: 0x04006341 RID: 25409
			[FieldOffset(0)]
			public FName ModuleName;
		}
	}
}
