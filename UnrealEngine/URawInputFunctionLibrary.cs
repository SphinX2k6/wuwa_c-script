using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BC RID: 1980
	[UnrealObjectPath("/Script/RawInput.RawInputFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class URawInputFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABAA RID: 43946 RVA: 0x000FD223 File Offset: 0x000FB423
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URawInputFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x000FD230 File Offset: 0x000FB430
		public URawInputFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(URawInputFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x000FD258 File Offset: 0x000FB458
		[NullableContext(1)]
		public URawInputFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URawInputFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x000FD28C File Offset: 0x000FB48C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static TArray<FRegisteredDeviceInfo> GetRegisteredDevices()
		{
			URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams* ptr = stackalloc URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(URawInputFunctionLibrary._ClassDefaultObjectPtr, URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr);
			TArray<FRegisteredDeviceInfo> result = new TArray<FRegisteredDeviceInfo>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x000FD2E9 File Offset: 0x000FB4E9
		static URawInputFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RawInput.RawInputFunctionLibrary");
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x000FD2F7 File Offset: 0x000FB4F7
		protected URawInputFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049C7 RID: 18887
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RawInput.RawInputFunctionLibrary";

		// Token: 0x040049C8 RID: 18888
		private static IntPtr _ClassPtr;

		// Token: 0x040049C9 RID: 18889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049CA RID: 18890
		private static IntPtr __GetRegisteredDevices_NativeFunctionPtr;

		// Token: 0x02000F6A RID: 3946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRegisteredDevices_FunctionParams
		{
			// Token: 0x04006342 RID: 25410
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
