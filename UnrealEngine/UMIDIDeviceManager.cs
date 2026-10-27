using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022EC RID: 8940
	[UnrealObjectPath("/Script/MIDIDevice.MIDIDeviceManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMIDIDeviceManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E61 RID: 138849 RVA: 0x00321707 File Offset: 0x0031F907
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMIDIDeviceManager._ClassPtr;
		}

		// Token: 0x06021E62 RID: 138850 RVA: 0x00321714 File Offset: 0x0031F914
		public UMIDIDeviceManager() : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E63 RID: 138851 RVA: 0x0032173C File Offset: 0x0031F93C
		[NullableContext(1)]
		public UMIDIDeviceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021E64 RID: 138852 RVA: 0x00321770 File Offset: 0x0031F970
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetMIDIOutputDeviceIDByName(string DeviceName, ref int DeviceID)
		{
			UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DeviceName), DeviceName);
			ptr->DeviceID = DeviceID;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 0);
			DeviceID = ptr->DeviceID;
			UnrealReflectionUtils.DestroyStruct(UMIDIDeviceManager.__GetMIDIOutputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021E65 RID: 138853 RVA: 0x003217E0 File Offset: 0x0031F9E0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetMIDIInputDeviceIDByName(string DeviceName, ref int DeviceID)
		{
			UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DeviceName), DeviceName);
			ptr->DeviceID = DeviceID;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 0);
			DeviceID = ptr->DeviceID;
			UnrealReflectionUtils.DestroyStruct(UMIDIDeviceManager.__GetMIDIInputDeviceIDByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021E66 RID: 138854 RVA: 0x00321850 File Offset: 0x0031FA50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetDefaultIMIDIOutputDeviceID(ref int DeviceID)
		{
			UMIDIDeviceManager.__GetDefaultIMIDIOutputDeviceID_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__GetDefaultIMIDIOutputDeviceID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMIDIDeviceManager.__GetDefaultIMIDIOutputDeviceID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__GetDefaultIMIDIOutputDeviceID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeviceID = DeviceID;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__GetDefaultIMIDIOutputDeviceID_NativeFunctionPtr, (void*)ptr, 0);
			DeviceID = ptr->DeviceID;
		}

		// Token: 0x06021E67 RID: 138855 RVA: 0x003218A0 File Offset: 0x0031FAA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetDefaultIMIDIInputDeviceID(ref int DeviceID)
		{
			UMIDIDeviceManager.__GetDefaultIMIDIInputDeviceID_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__GetDefaultIMIDIInputDeviceID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMIDIDeviceManager.__GetDefaultIMIDIInputDeviceID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__GetDefaultIMIDIInputDeviceID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeviceID = DeviceID;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__GetDefaultIMIDIInputDeviceID_NativeFunctionPtr, (void*)ptr, 0);
			DeviceID = ptr->DeviceID;
		}

		// Token: 0x06021E68 RID: 138856 RVA: 0x003218F0 File Offset: 0x0031FAF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void FindMIDIDevices([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FFoundMIDIDevice> OutMIDIDevices)
		{
			UMIDIDeviceManager.__FindMIDIDevices_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__FindMIDIDevices_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMIDIDeviceManager.__FindMIDIDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__FindMIDIDevices_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FFoundMIDIDevice> tarray = OutMIDIDevices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutMIDIDevices);
			}
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__FindMIDIDevices_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FFoundMIDIDevice> tarray2 = OutMIDIDevices;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutMIDIDevices);
			}
			UnrealReflectionUtils.DestroyStruct(UMIDIDeviceManager.__FindMIDIDevices_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021E69 RID: 138857 RVA: 0x00321968 File Offset: 0x0031FB68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void FindAllMIDIDeviceInfo([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMIDIDeviceInfo> OutMIDIInputDevices, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMIDIDeviceInfo> OutMIDIOutputDevices)
		{
			UMIDIDeviceManager.__FindAllMIDIDeviceInfo_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__FindAllMIDIDeviceInfo_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMIDIDeviceManager.__FindAllMIDIDeviceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__FindAllMIDIDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FMIDIDeviceInfo> tarray = OutMIDIInputDevices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutMIDIInputDevices);
			}
			TArray<FMIDIDeviceInfo> tarray2 = OutMIDIOutputDevices;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->OutMIDIOutputDevices);
			}
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__FindAllMIDIDeviceInfo_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FMIDIDeviceInfo> tarray3 = OutMIDIInputDevices;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->OutMIDIInputDevices);
			}
			TArray<FMIDIDeviceInfo> tarray4 = OutMIDIOutputDevices;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->OutMIDIOutputDevices);
			}
			UnrealReflectionUtils.DestroyStruct(UMIDIDeviceManager.__FindAllMIDIDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021E6A RID: 138858 RVA: 0x00321A08 File Offset: 0x0031FC08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMIDIDeviceOutputController CreateMIDIDeviceOutputController(int DeviceID)
		{
			UMIDIDeviceManager.__CreateMIDIDeviceOutputController_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__CreateMIDIDeviceOutputController_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMIDIDeviceManager.__CreateMIDIDeviceOutputController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__CreateMIDIDeviceOutputController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeviceID = DeviceID;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__CreateMIDIDeviceOutputController_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceOutputController>(ptr->__Result);
		}

		// Token: 0x06021E6B RID: 138859 RVA: 0x00321A5C File Offset: 0x0031FC5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMIDIDeviceInputController CreateMIDIDeviceInputController(int DeviceID, int MIDIBufferSize = 1024)
		{
			UMIDIDeviceManager.__CreateMIDIDeviceInputController_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__CreateMIDIDeviceInputController_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMIDIDeviceManager.__CreateMIDIDeviceInputController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__CreateMIDIDeviceInputController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeviceID = DeviceID;
			ptr->MIDIBufferSize = MIDIBufferSize;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__CreateMIDIDeviceInputController_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceInputController>(ptr->__Result);
		}

		// Token: 0x06021E6C RID: 138860 RVA: 0x00321AB4 File Offset: 0x0031FCB4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMIDIDeviceController CreateMIDIDeviceController(int DeviceID, int MIDIBufferSize = 1024)
		{
			UMIDIDeviceManager.__CreateMIDIDeviceController_FunctionParams* ptr = stackalloc UMIDIDeviceManager.__CreateMIDIDeviceController_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMIDIDeviceManager.__CreateMIDIDeviceController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceManager.__CreateMIDIDeviceController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeviceID = DeviceID;
			ptr->MIDIBufferSize = MIDIBufferSize;
			UnrealReflectionUtils.CallUFunction(UMIDIDeviceManager._ClassDefaultObjectPtr, UMIDIDeviceManager.__CreateMIDIDeviceController_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMIDIDeviceController>(ptr->__Result);
		}

		// Token: 0x06021E6D RID: 138861 RVA: 0x00321B0C File Offset: 0x0031FD0C
		static UMIDIDeviceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MIDIDevice.MIDIDeviceManager");
		}

		// Token: 0x06021E6E RID: 138862 RVA: 0x00321B1A File Offset: 0x0031FD1A
		protected UMIDIDeviceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401216A RID: 74090
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MIDIDevice.MIDIDeviceManager";

		// Token: 0x0401216B RID: 74091
		private static IntPtr _ClassPtr;

		// Token: 0x0401216C RID: 74092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401216D RID: 74093
		private static IntPtr __GetMIDIOutputDeviceIDByName_NativeFunctionPtr;

		// Token: 0x0401216E RID: 74094
		private static IntPtr __GetMIDIInputDeviceIDByName_NativeFunctionPtr;

		// Token: 0x0401216F RID: 74095
		private static IntPtr __GetDefaultIMIDIOutputDeviceID_NativeFunctionPtr;

		// Token: 0x04012170 RID: 74096
		private static IntPtr __GetDefaultIMIDIInputDeviceID_NativeFunctionPtr;

		// Token: 0x04012171 RID: 74097
		private static IntPtr __FindMIDIDevices_NativeFunctionPtr;

		// Token: 0x04012172 RID: 74098
		private static IntPtr __FindAllMIDIDeviceInfo_NativeFunctionPtr;

		// Token: 0x04012173 RID: 74099
		private static IntPtr __CreateMIDIDeviceOutputController_NativeFunctionPtr;

		// Token: 0x04012174 RID: 74100
		private static IntPtr __CreateMIDIDeviceInputController_NativeFunctionPtr;

		// Token: 0x04012175 RID: 74101
		private static IntPtr __CreateMIDIDeviceController_NativeFunctionPtr;

		// Token: 0x0200361D RID: 13853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetMIDIOutputDeviceIDByName_FunctionParams
		{
			// Token: 0x040176AD RID: 95917
			[FieldOffset(0)]
			public FString DeviceName;

			// Token: 0x040176AE RID: 95918
			[FieldOffset(16)]
			public int DeviceID;
		}

		// Token: 0x0200361E RID: 13854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetMIDIInputDeviceIDByName_FunctionParams
		{
			// Token: 0x040176AF RID: 95919
			[FieldOffset(0)]
			public FString DeviceName;

			// Token: 0x040176B0 RID: 95920
			[FieldOffset(16)]
			public int DeviceID;
		}

		// Token: 0x0200361F RID: 13855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDefaultIMIDIOutputDeviceID_FunctionParams
		{
			// Token: 0x040176B1 RID: 95921
			[FieldOffset(0)]
			public int DeviceID;
		}

		// Token: 0x02003620 RID: 13856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDefaultIMIDIInputDeviceID_FunctionParams
		{
			// Token: 0x040176B2 RID: 95922
			[FieldOffset(0)]
			public int DeviceID;
		}

		// Token: 0x02003621 RID: 13857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FindMIDIDevices_FunctionParams
		{
			// Token: 0x040176B3 RID: 95923
			[FieldOffset(0)]
			public byte OutMIDIDevices;
		}

		// Token: 0x02003622 RID: 13858
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FindAllMIDIDeviceInfo_FunctionParams
		{
			// Token: 0x040176B4 RID: 95924
			[FieldOffset(0)]
			public byte OutMIDIInputDevices;

			// Token: 0x040176B5 RID: 95925
			[FieldOffset(16)]
			public byte OutMIDIOutputDevices;
		}

		// Token: 0x02003623 RID: 13859
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CreateMIDIDeviceOutputController_FunctionParams
		{
			// Token: 0x040176B6 RID: 95926
			[FieldOffset(0)]
			public int DeviceID;

			// Token: 0x040176B7 RID: 95927
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003624 RID: 13860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CreateMIDIDeviceInputController_FunctionParams
		{
			// Token: 0x040176B8 RID: 95928
			[FieldOffset(0)]
			public int DeviceID;

			// Token: 0x040176B9 RID: 95929
			[FieldOffset(4)]
			public int MIDIBufferSize;

			// Token: 0x040176BA RID: 95930
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003625 RID: 13861
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CreateMIDIDeviceController_FunctionParams
		{
			// Token: 0x040176BB RID: 95931
			[FieldOffset(0)]
			public int DeviceID;

			// Token: 0x040176BC RID: 95932
			[FieldOffset(4)]
			public int MIDIBufferSize;

			// Token: 0x040176BD RID: 95933
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
