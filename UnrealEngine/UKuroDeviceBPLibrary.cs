using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001800 RID: 6144
	[UnrealObjectPath("/Script/KuroDevice.KuroDeviceBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroDeviceBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BF0 RID: 93168 RVA: 0x0021314B File Offset: 0x0021134B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDeviceBPLibrary._ClassPtr;
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x00213158 File Offset: 0x00211358
		public UKuroDeviceBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroDeviceBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x00213180 File Offset: 0x00211380
		[NullableContext(1)]
		public UKuroDeviceBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDeviceBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016BF3 RID: 93171 RVA: 0x002131B4 File Offset: 0x002113B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UDeviceHandle NewDeviceHandle(UObject Outer)
		{
			UKuroDeviceBPLibrary.__NewDeviceHandle_FunctionParams* ptr = stackalloc UKuroDeviceBPLibrary.__NewDeviceHandle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroDeviceBPLibrary.__NewDeviceHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDeviceBPLibrary.__NewDeviceHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Outer = ((Outer != null) ? Outer.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroDeviceBPLibrary._ClassDefaultObjectPtr, UKuroDeviceBPLibrary.__NewDeviceHandle_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDeviceHandle>(ptr->__Result);
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x00213214 File Offset: 0x00211414
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool FindAllDeviceVidAndPid([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> DevicePathList)
		{
			UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_FunctionParams* ptr = stackalloc UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = DevicePathList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->DevicePathList);
			}
			UnrealReflectionUtils.CallUFunction(UKuroDeviceBPLibrary._ClassDefaultObjectPtr, UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = DevicePathList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->DevicePathList);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroDeviceBPLibrary.__FindAllDeviceVidAndPid_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06016BF5 RID: 93173 RVA: 0x00213292 File Offset: 0x00211492
		static UKuroDeviceBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDevice.KuroDeviceBPLibrary");
		}

		// Token: 0x06016BF6 RID: 93174 RVA: 0x002132A0 File Offset: 0x002114A0
		protected UKuroDeviceBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C589 RID: 50569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDevice.KuroDeviceBPLibrary";

		// Token: 0x0400C58A RID: 50570
		private static IntPtr _ClassPtr;

		// Token: 0x0400C58B RID: 50571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C58C RID: 50572
		private static IntPtr __NewDeviceHandle_NativeFunctionPtr;

		// Token: 0x0400C58D RID: 50573
		private static IntPtr __FindAllDeviceVidAndPid_NativeFunctionPtr;

		// Token: 0x02002F4D RID: 12109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NewDeviceHandle_FunctionParams
		{
			// Token: 0x04016AF0 RID: 92912
			[FieldOffset(0)]
			public IntPtr Outer;

			// Token: 0x04016AF1 RID: 92913
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002F4E RID: 12110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FindAllDeviceVidAndPid_FunctionParams
		{
			// Token: 0x04016AF2 RID: 92914
			[FieldOffset(0)]
			public byte DevicePathList;

			// Token: 0x04016AF3 RID: 92915
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
