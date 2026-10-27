using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED2 RID: 7890
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticiOSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticiOSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEC1 RID: 122561 RVA: 0x002C43B2 File Offset: 0x002C25B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticiOSLibrary._ClassPtr;
		}

		// Token: 0x0601DEC2 RID: 122562 RVA: 0x002C43C0 File Offset: 0x002C25C0
		public UKuroStaticiOSLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticiOSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEC3 RID: 122563 RVA: 0x002C43E8 File Offset: 0x002C25E8
		[NullableContext(1)]
		public UKuroStaticiOSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticiOSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DEC4 RID: 122564 RVA: 0x002C441C File Offset: 0x002C261C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenAppWithUrl(string url, string failUrl)
		{
			UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams* ptr = stackalloc UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticiOSLibrary.__OpenAppWithUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			FString.CopyFrom((void*)(&ptr->failUrl), failUrl);
			UnrealReflectionUtils.CallUFunction(UKuroStaticiOSLibrary._ClassDefaultObjectPtr, UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticiOSLibrary.__OpenAppWithUrl_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DEC5 RID: 122565 RVA: 0x002C4488 File Offset: 0x002C2688
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetDeviceJailbroken()
		{
			UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams* ptr = stackalloc UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticiOSLibrary.__GetDeviceJailbroken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticiOSLibrary.__GetDeviceJailbroken_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticiOSLibrary._ClassDefaultObjectPtr, UKuroStaticiOSLibrary.__GetDeviceJailbroken_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DEC6 RID: 122566 RVA: 0x002C44CD File Offset: 0x002C26CD
		static UKuroStaticiOSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticiOSLibrary");
		}

		// Token: 0x0601DEC7 RID: 122567 RVA: 0x002C44DB File Offset: 0x002C26DB
		protected UKuroStaticiOSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401033D RID: 66365
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticiOSLibrary";

		// Token: 0x0401033E RID: 66366
		private static IntPtr _ClassPtr;

		// Token: 0x0401033F RID: 66367
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010340 RID: 66368
		private static IntPtr __OpenAppWithUrl_NativeFunctionPtr;

		// Token: 0x04010341 RID: 66369
		private static IntPtr __GetDeviceJailbroken_NativeFunctionPtr;

		// Token: 0x02003322 RID: 13090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OpenAppWithUrl_FunctionParams
		{
			// Token: 0x040171FE RID: 94718
			[FieldOffset(0)]
			public FString url;

			// Token: 0x040171FF RID: 94719
			[FieldOffset(16)]
			public FString failUrl;
		}

		// Token: 0x02003323 RID: 13091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDeviceJailbroken_FunctionParams
		{
			// Token: 0x04017200 RID: 94720
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
