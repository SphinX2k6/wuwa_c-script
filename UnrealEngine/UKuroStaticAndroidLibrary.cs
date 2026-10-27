using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED1 RID: 7889
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticAndroidLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticAndroidLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEB4 RID: 122548 RVA: 0x002C40B6 File Offset: 0x002C22B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticAndroidLibrary._ClassPtr;
		}

		// Token: 0x0601DEB5 RID: 122549 RVA: 0x002C40C4 File Offset: 0x002C22C4
		public UKuroStaticAndroidLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticAndroidLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEB6 RID: 122550 RVA: 0x002C40EC File Offset: 0x002C22EC
		[NullableContext(1)]
		public UKuroStaticAndroidLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticAndroidLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DEB7 RID: 122551 RVA: 0x002C4120 File Offset: 0x002C2320
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenAppWithUrl(string schema, string failSchema)
		{
			UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->schema), schema);
			FString.CopyFrom((void*)(&ptr->failSchema), failSchema);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DEB8 RID: 122552 RVA: 0x002C418C File Offset: 0x002C238C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsHarmonyOS()
		{
			UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__IsHarmonyOS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__IsHarmonyOS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DEB9 RID: 122553 RVA: 0x002C41D4 File Offset: 0x002C23D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetHarmonyOSVersion()
		{
			UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DEBA RID: 122554 RVA: 0x002C4230 File Offset: 0x002C2430
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetDeviceIsRooted()
		{
			UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetDeviceIsRooted_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetDeviceIsRooted_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DEBB RID: 122555 RVA: 0x002C4278 File Offset: 0x002C2478
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetDeviceIsEmulator()
		{
			UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DEBC RID: 122556 RVA: 0x002C42C0 File Offset: 0x002C24C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetCustomChannel()
		{
			UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DEBD RID: 122557 RVA: 0x002C431C File Offset: 0x002C251C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearAndroidScreenChangeDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__ClearAndroidScreenChangeDelegate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DEBE RID: 122558 RVA: 0x002C4330 File Offset: 0x002C2530
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddAndroidScreenChangeDelegate(in FAndroidScreenChangeHandler Handler)
		{
			UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Handler;
			FAndroidScreenChangeHandler fandroidScreenChangeHandler = Handler;
			FScriptDelegate.NativeCopy(dest, (fandroidScreenChangeHandler != null) ? fandroidScreenChangeHandler.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DEBF RID: 122559 RVA: 0x002C439B File Offset: 0x002C259B
		static UKuroStaticAndroidLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticAndroidLibrary");
		}

		// Token: 0x0601DEC0 RID: 122560 RVA: 0x002C43A9 File Offset: 0x002C25A9
		protected UKuroStaticAndroidLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010332 RID: 66354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticAndroidLibrary";

		// Token: 0x04010333 RID: 66355
		private static IntPtr _ClassPtr;

		// Token: 0x04010334 RID: 66356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010335 RID: 66357
		private static IntPtr __OpenAppWithUrl_NativeFunctionPtr;

		// Token: 0x04010336 RID: 66358
		private static IntPtr __IsHarmonyOS_NativeFunctionPtr;

		// Token: 0x04010337 RID: 66359
		private static IntPtr __GetHarmonyOSVersion_NativeFunctionPtr;

		// Token: 0x04010338 RID: 66360
		private static IntPtr __GetDeviceIsRooted_NativeFunctionPtr;

		// Token: 0x04010339 RID: 66361
		private static IntPtr __GetDeviceIsEmulator_NativeFunctionPtr;

		// Token: 0x0401033A RID: 66362
		private static IntPtr __GetCustomChannel_NativeFunctionPtr;

		// Token: 0x0401033B RID: 66363
		private static IntPtr __ClearAndroidScreenChangeDelegate_NativeFunctionPtr;

		// Token: 0x0401033C RID: 66364
		private static IntPtr __AddAndroidScreenChangeDelegate_NativeFunctionPtr;

		// Token: 0x0200331B RID: 13083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OpenAppWithUrl_FunctionParams
		{
			// Token: 0x040171F6 RID: 94710
			[FieldOffset(0)]
			public FString schema;

			// Token: 0x040171F7 RID: 94711
			[FieldOffset(16)]
			public FString failSchema;
		}

		// Token: 0x0200331C RID: 13084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsHarmonyOS_FunctionParams
		{
			// Token: 0x040171F8 RID: 94712
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200331D RID: 13085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetHarmonyOSVersion_FunctionParams
		{
			// Token: 0x040171F9 RID: 94713
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200331E RID: 13086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceIsRooted_FunctionParams
		{
			// Token: 0x040171FA RID: 94714
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200331F RID: 13087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceIsEmulator_FunctionParams
		{
			// Token: 0x040171FB RID: 94715
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003320 RID: 13088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCustomChannel_FunctionParams
		{
			// Token: 0x040171FC RID: 94716
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003321 RID: 13089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddAndroidScreenChangeDelegate_FunctionParams
		{
			// Token: 0x040171FD RID: 94717
			[FieldOffset(0)]
			public byte Handler;
		}
	}
}
