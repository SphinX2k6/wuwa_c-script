using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E83 RID: 7811
	[UnrealObjectPath("/Script/KuroTDM.TDMStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTDMStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DBC9 RID: 121801 RVA: 0x002BEDAA File Offset: 0x002BCFAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTDMStaticLibrary._ClassPtr;
		}

		// Token: 0x0601DBCA RID: 121802 RVA: 0x002BEDB8 File Offset: 0x002BCFB8
		public UTDMStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UTDMStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DBCB RID: 121803 RVA: 0x002BEDE0 File Offset: 0x002BCFE0
		[NullableContext(1)]
		public UTDMStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTDMStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DBCC RID: 121804 RVA: 0x002BEE14 File Offset: 0x002BD014
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetRouterAddress(bool isTest, string address)
		{
			UTDMStaticLibrary.__SetRouterAddress_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__SetRouterAddress_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTDMStaticLibrary.__SetRouterAddress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isTest = isTest;
			FString.CopyFrom((void*)(&ptr->address), address);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DBCD RID: 121805 RVA: 0x002BEE78 File Offset: 0x002BD078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void RegisterLifeCycle()
		{
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__RegisterLifeCycle_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DBCE RID: 121806 RVA: 0x002BEE8C File Offset: 0x002BD08C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Initialize(string appId, string appChannel, string appKey)
		{
			UTDMStaticLibrary.__Initialize_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__Initialize_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UTDMStaticLibrary.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->appId), appId);
			FString.CopyFrom((void*)(&ptr->appChannel), appChannel);
			FString.CopyFrom((void*)(&ptr->appKey), appKey);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DBCF RID: 121807 RVA: 0x002BEF0C File Offset: 0x002BD10C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetDeviceInfo()
		{
			UTDMStaticLibrary.__GetDeviceInfo_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__GetDeviceInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTDMStaticLibrary.__GetDeviceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DBD0 RID: 121808 RVA: 0x002BEF68 File Offset: 0x002BD168
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int EnableDeviceInfoCollect(string model, bool state)
		{
			UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->model), model);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr, 0);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DBD1 RID: 121809 RVA: 0x002BEFD4 File Offset: 0x002BD1D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnableDeviceInfo(bool enable)
		{
			UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__EnableDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->enable = enable;
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__EnableDeviceInfo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DBD2 RID: 121810 RVA: 0x002BF01A File Offset: 0x002BD21A
		static UTDMStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroTDM.TDMStaticLibrary");
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x002BF028 File Offset: 0x002BD228
		protected UTDMStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010188 RID: 65928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroTDM.TDMStaticLibrary";

		// Token: 0x04010189 RID: 65929
		private static IntPtr _ClassPtr;

		// Token: 0x0401018A RID: 65930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401018B RID: 65931
		private static IntPtr __SetRouterAddress_NativeFunctionPtr;

		// Token: 0x0401018C RID: 65932
		private static IntPtr __RegisterLifeCycle_NativeFunctionPtr;

		// Token: 0x0401018D RID: 65933
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0401018E RID: 65934
		private static IntPtr __GetDeviceInfo_NativeFunctionPtr;

		// Token: 0x0401018F RID: 65935
		private static IntPtr __EnableDeviceInfoCollect_NativeFunctionPtr;

		// Token: 0x04010190 RID: 65936
		private static IntPtr __EnableDeviceInfo_NativeFunctionPtr;

		// Token: 0x020032D4 RID: 13012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetRouterAddress_FunctionParams
		{
			// Token: 0x0401717B RID: 94587
			[FieldOffset(0)]
			public bool isTest;

			// Token: 0x0401717C RID: 94588
			[FieldOffset(8)]
			public FString address;
		}

		// Token: 0x020032D5 RID: 13013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x0401717D RID: 94589
			[FieldOffset(0)]
			public FString appId;

			// Token: 0x0401717E RID: 94590
			[FieldOffset(16)]
			public FString appChannel;

			// Token: 0x0401717F RID: 94591
			[FieldOffset(32)]
			public FString appKey;

			// Token: 0x04017180 RID: 94592
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x020032D6 RID: 13014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDeviceInfo_FunctionParams
		{
			// Token: 0x04017181 RID: 94593
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020032D7 RID: 13015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EnableDeviceInfoCollect_FunctionParams
		{
			// Token: 0x04017182 RID: 94594
			[FieldOffset(0)]
			public FString model;

			// Token: 0x04017183 RID: 94595
			[FieldOffset(16)]
			public bool state;

			// Token: 0x04017184 RID: 94596
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x020032D8 RID: 13016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDeviceInfo_FunctionParams
		{
			// Token: 0x04017185 RID: 94597
			[FieldOffset(0)]
			public bool enable;
		}
	}
}
