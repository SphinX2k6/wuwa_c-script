using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E5 RID: 1509
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticAndroidLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticAndroidLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008537 RID: 34103 RVA: 0x000C58F2 File Offset: 0x000C3AF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticAndroidLibrary._ClassPtr;
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x000C5900 File Offset: 0x000C3B00
		public UKuroStaticAndroidLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticAndroidLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x000C5928 File Offset: 0x000C3B28
		[NullableContext(1)]
		public UKuroStaticAndroidLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticAndroidLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x000C595C File Offset: 0x000C3B5C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenAppWithUrl(string schema, string failSchema)
		{
			UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__OpenAppWithUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->schema), schema);
			FString.CopyFrom((void*)(&ptr->failSchema), failSchema);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x000C59C8 File Offset: 0x000C3BC8
		[SkipLocalsInit]
		public unsafe static bool IsScreenFolded()
		{
			UKuroStaticAndroidLibrary.__IsScreenFolded_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__IsScreenFolded_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__IsScreenFolded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__IsScreenFolded_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__IsScreenFolded_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		[SkipLocalsInit]
		public unsafe static bool IsHarmonyOS()
		{
			UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__IsHarmonyOS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__IsHarmonyOS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__IsHarmonyOS_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x000C5A50 File Offset: 0x000C3C50
		[SkipLocalsInit]
		public unsafe static bool IsFoldableScreen()
		{
			UKuroStaticAndroidLibrary.__IsFoldableScreen_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__IsFoldableScreen_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__IsFoldableScreen_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__IsFoldableScreen_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__IsFoldableScreen_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x000C5A94 File Offset: 0x000C3C94
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetHarmonyOSVersion()
		{
			UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__GetHarmonyOSVersion_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x000C5AF0 File Offset: 0x000C3CF0
		[SkipLocalsInit]
		public unsafe static bool GetDeviceIsRooted()
		{
			UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetDeviceIsRooted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetDeviceIsRooted_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetDeviceIsRooted_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x000C5B34 File Offset: 0x000C3D34
		[SkipLocalsInit]
		public unsafe static bool GetDeviceIsEmulator()
		{
			UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetDeviceIsEmulator_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x000C5B78 File Offset: 0x000C3D78
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetCustomChannel()
		{
			UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__GetCustomChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__GetCustomChannel_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x000C5BD3 File Offset: 0x000C3DD3
		[SkipLocalsInit]
		public static void ClearAndroidScreenChangeDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__ClearAndroidScreenChangeDelegate_NativeFunctionPtr, null);
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x000C5BE6 File Offset: 0x000C3DE6
		[SkipLocalsInit]
		public static void ClearAndroidFoldStateChangeDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__ClearAndroidFoldStateChangeDelegate_NativeFunctionPtr, null);
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x000C5BFC File Offset: 0x000C3DFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddAndroidScreenChangeDelegate(in FAndroidScreenChangeHandler Handler)
		{
			UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Handler;
			FAndroidScreenChangeHandler fandroidScreenChangeHandler = Handler;
			FScriptDelegate.NativeCopy(dest, (fandroidScreenChangeHandler != null) ? fandroidScreenChangeHandler.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__AddAndroidScreenChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x000C5C68 File Offset: 0x000C3E68
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddAndroidFoldStateChangeDelegate(in FAndroidFoldStateChangeHandler Handler)
		{
			UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_FunctionParams* ptr = stackalloc UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Handler;
			FAndroidFoldStateChangeHandler fandroidFoldStateChangeHandler = Handler;
			FScriptDelegate.NativeCopy(dest, (fandroidFoldStateChangeHandler != null) ? fandroidFoldStateChangeHandler.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticAndroidLibrary._ClassDefaultObjectPtr, UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticAndroidLibrary.__AddAndroidFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x000C5CD2 File Offset: 0x000C3ED2
		static UKuroStaticAndroidLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticAndroidLibrary");
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x000C5CE0 File Offset: 0x000C3EE0
		protected UKuroStaticAndroidLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A1F RID: 14879
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticAndroidLibrary";

		// Token: 0x04003A20 RID: 14880
		private static IntPtr _ClassPtr;

		// Token: 0x04003A21 RID: 14881
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A22 RID: 14882
		private static IntPtr __OpenAppWithUrl_NativeFunctionPtr;

		// Token: 0x04003A23 RID: 14883
		private static IntPtr __IsScreenFolded_NativeFunctionPtr;

		// Token: 0x04003A24 RID: 14884
		private static IntPtr __IsHarmonyOS_NativeFunctionPtr;

		// Token: 0x04003A25 RID: 14885
		private static IntPtr __IsFoldableScreen_NativeFunctionPtr;

		// Token: 0x04003A26 RID: 14886
		private static IntPtr __GetHarmonyOSVersion_NativeFunctionPtr;

		// Token: 0x04003A27 RID: 14887
		private static IntPtr __GetDeviceIsRooted_NativeFunctionPtr;

		// Token: 0x04003A28 RID: 14888
		private static IntPtr __GetDeviceIsEmulator_NativeFunctionPtr;

		// Token: 0x04003A29 RID: 14889
		private static IntPtr __GetCustomChannel_NativeFunctionPtr;

		// Token: 0x04003A2A RID: 14890
		private static IntPtr __ClearAndroidScreenChangeDelegate_NativeFunctionPtr;

		// Token: 0x04003A2B RID: 14891
		private static IntPtr __ClearAndroidFoldStateChangeDelegate_NativeFunctionPtr;

		// Token: 0x04003A2C RID: 14892
		private static IntPtr __AddAndroidScreenChangeDelegate_NativeFunctionPtr;

		// Token: 0x04003A2D RID: 14893
		private static IntPtr __AddAndroidFoldStateChangeDelegate_NativeFunctionPtr;

		// Token: 0x02000D70 RID: 3440
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OpenAppWithUrl_FunctionParams
		{
			// Token: 0x0400602C RID: 24620
			[FieldOffset(0)]
			public FString schema;

			// Token: 0x0400602D RID: 24621
			[FieldOffset(16)]
			public FString failSchema;
		}

		// Token: 0x02000D71 RID: 3441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsScreenFolded_FunctionParams
		{
			// Token: 0x0400602E RID: 24622
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D72 RID: 3442
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsHarmonyOS_FunctionParams
		{
			// Token: 0x0400602F RID: 24623
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D73 RID: 3443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsFoldableScreen_FunctionParams
		{
			// Token: 0x04006030 RID: 24624
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D74 RID: 3444
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetHarmonyOSVersion_FunctionParams
		{
			// Token: 0x04006031 RID: 24625
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D75 RID: 3445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceIsRooted_FunctionParams
		{
			// Token: 0x04006032 RID: 24626
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D76 RID: 3446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceIsEmulator_FunctionParams
		{
			// Token: 0x04006033 RID: 24627
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D77 RID: 3447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCustomChannel_FunctionParams
		{
			// Token: 0x04006034 RID: 24628
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D78 RID: 3448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddAndroidScreenChangeDelegate_FunctionParams
		{
			// Token: 0x04006035 RID: 24629
			[FieldOffset(0)]
			public byte Handler;
		}

		// Token: 0x02000D79 RID: 3449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddAndroidFoldStateChangeDelegate_FunctionParams
		{
			// Token: 0x04006036 RID: 24630
			[FieldOffset(0)]
			public byte Handler;
		}
	}
}
