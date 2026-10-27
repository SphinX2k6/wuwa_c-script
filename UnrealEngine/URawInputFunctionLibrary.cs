using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200267F RID: 9855
	[UnrealObjectPath("/Script/RawInput.RawInputFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class URawInputFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249A5 RID: 149925 RVA: 0x00362FAC File Offset: 0x003611AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URawInputFunctionLibrary._ClassPtr;
		}

		// Token: 0x060249A6 RID: 149926 RVA: 0x00362FB8 File Offset: 0x003611B8
		public URawInputFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(URawInputFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249A7 RID: 149927 RVA: 0x00362FE0 File Offset: 0x003611E0
		[NullableContext(1)]
		public URawInputFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URawInputFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060249A8 RID: 149928 RVA: 0x00363014 File Offset: 0x00361214
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<FRegisteredDeviceInfo> GetRegisteredDevices()
		{
			URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams* ptr = stackalloc URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(URawInputFunctionLibrary.__GetRegisteredDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(URawInputFunctionLibrary._ClassDefaultObjectPtr, URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FRegisteredDeviceInfo> result = new TArray<FRegisteredDeviceInfo>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(URawInputFunctionLibrary.__GetRegisteredDevices_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060249A9 RID: 149929 RVA: 0x00363072 File Offset: 0x00361272
		static URawInputFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RawInput.RawInputFunctionLibrary");
		}

		// Token: 0x060249AA RID: 149930 RVA: 0x00363080 File Offset: 0x00361280
		protected URawInputFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013AC6 RID: 80582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RawInput.RawInputFunctionLibrary";

		// Token: 0x04013AC7 RID: 80583
		private static IntPtr _ClassPtr;

		// Token: 0x04013AC8 RID: 80584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013AC9 RID: 80585
		private static IntPtr __GetRegisteredDevices_NativeFunctionPtr;

		// Token: 0x0200368D RID: 13965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRegisteredDevices_FunctionParams
		{
			// Token: 0x0401777B RID: 96123
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
