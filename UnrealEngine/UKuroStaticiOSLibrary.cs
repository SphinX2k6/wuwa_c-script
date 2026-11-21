using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E6 RID: 1510
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticiOSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticiOSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008548 RID: 34120 RVA: 0x000C5CE9 File Offset: 0x000C3EE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticiOSLibrary._ClassPtr;
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x000C5CF8 File Offset: 0x000C3EF8
		public UKuroStaticiOSLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticiOSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x000C5D20 File Offset: 0x000C3F20
		[NullableContext(1)]
		public UKuroStaticiOSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticiOSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x000C5D54 File Offset: 0x000C3F54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenAppWithUrl(string url, string failUrl)
		{
			UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams* ptr = stackalloc UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			FString.CopyFrom((void*)(&ptr->failUrl), failUrl);
			UnrealReflectionUtils.CallUFunction(UKuroStaticiOSLibrary._ClassDefaultObjectPtr, UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600854C RID: 34124 RVA: 0x000C5DC0 File Offset: 0x000C3FC0
		[SkipLocalsInit]
		public unsafe static bool GetDeviceJailbroken()
		{
			UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams* ptr = stackalloc UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticiOSLibrary.__GetDeviceJailbroken_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticiOSLibrary._ClassDefaultObjectPtr, UKuroStaticiOSLibrary.__GetDeviceJailbroken_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x000C5E04 File Offset: 0x000C4004
		static UKuroStaticiOSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticiOSLibrary");
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x000C5E12 File Offset: 0x000C4012
		protected UKuroStaticiOSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A2E RID: 14894
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticiOSLibrary";

		// Token: 0x04003A2F RID: 14895
		private static IntPtr _ClassPtr;

		// Token: 0x04003A30 RID: 14896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A31 RID: 14897
		private static IntPtr __OpenAppWithUrl_NativeFunctionPtr;

		// Token: 0x04003A32 RID: 14898
		private static IntPtr __GetDeviceJailbroken_NativeFunctionPtr;

		// Token: 0x02000D7A RID: 3450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OpenAppWithUrl_FunctionParams
		{
			// Token: 0x04006037 RID: 24631
			[FieldOffset(0)]
			public FString url;

			// Token: 0x04006038 RID: 24632
			[FieldOffset(16)]
			public FString failUrl;
		}

		// Token: 0x02000D7B RID: 3451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceJailbroken_FunctionParams
		{
			// Token: 0x04006039 RID: 24633
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
