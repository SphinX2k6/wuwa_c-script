using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B2 RID: 1458
	[UnrealObjectPath("/Script/KuroTDM.TDMStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTDMStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008316 RID: 33558 RVA: 0x000C1CA6 File Offset: 0x000BFEA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTDMStaticLibrary._ClassPtr;
		}

		// Token: 0x06008317 RID: 33559 RVA: 0x000C1CB4 File Offset: 0x000BFEB4
		public UTDMStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UTDMStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x000C1CDC File Offset: 0x000BFEDC
		[NullableContext(1)]
		public UTDMStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTDMStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x000C1D10 File Offset: 0x000BFF10
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetRouterAddress(bool isTest, string address)
		{
			UTDMStaticLibrary.__SetRouterAddress_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__SetRouterAddress_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTDMStaticLibrary.__SetRouterAddress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isTest = isTest;
			FString.CopyFrom((void*)(&ptr->address), address);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__SetRouterAddress_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x000C1D73 File Offset: 0x000BFF73
		[SkipLocalsInit]
		public static void RegisterLifeCycle()
		{
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__RegisterLifeCycle_NativeFunctionPtr, null);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x000C1D88 File Offset: 0x000BFF88
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool Initialize(string appId, string appChannel, string appKey)
		{
			UTDMStaticLibrary.__Initialize_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__Initialize_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UTDMStaticLibrary.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->appId), appId);
			FString.CopyFrom((void*)(&ptr->appChannel), appChannel);
			FString.CopyFrom((void*)(&ptr->appKey), appKey);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x000C1E04 File Offset: 0x000C0004
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetDeviceInfo()
		{
			UTDMStaticLibrary.__GetDeviceInfo_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__GetDeviceInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTDMStaticLibrary.__GetDeviceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__GetDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x000C1E60 File Offset: 0x000C0060
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int EnableDeviceInfoCollect(string model, bool state)
		{
			UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTDMStaticLibrary.__EnableDeviceInfoCollect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->model), model);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTDMStaticLibrary.__EnableDeviceInfoCollect_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x000C1ECC File Offset: 0x000C00CC
		[SkipLocalsInit]
		public unsafe static void EnableDeviceInfo(bool enable)
		{
			UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams* ptr = stackalloc UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTDMStaticLibrary.__EnableDeviceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTDMStaticLibrary.__EnableDeviceInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->enable = enable;
			UnrealReflectionUtils.CallUFunction(UTDMStaticLibrary._ClassDefaultObjectPtr, UTDMStaticLibrary.__EnableDeviceInfo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x000C1F11 File Offset: 0x000C0111
		static UTDMStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroTDM.TDMStaticLibrary");
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x000C1F1F File Offset: 0x000C011F
		protected UTDMStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003901 RID: 14593
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroTDM.TDMStaticLibrary";

		// Token: 0x04003902 RID: 14594
		private static IntPtr _ClassPtr;

		// Token: 0x04003903 RID: 14595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003904 RID: 14596
		private static IntPtr __SetRouterAddress_NativeFunctionPtr;

		// Token: 0x04003905 RID: 14597
		private static IntPtr __RegisterLifeCycle_NativeFunctionPtr;

		// Token: 0x04003906 RID: 14598
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04003907 RID: 14599
		private static IntPtr __GetDeviceInfo_NativeFunctionPtr;

		// Token: 0x04003908 RID: 14600
		private static IntPtr __EnableDeviceInfoCollect_NativeFunctionPtr;

		// Token: 0x04003909 RID: 14601
		private static IntPtr __EnableDeviceInfo_NativeFunctionPtr;

		// Token: 0x02000D2F RID: 3375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetRouterAddress_FunctionParams
		{
			// Token: 0x04005FC3 RID: 24515
			[FieldOffset(0)]
			public bool isTest;

			// Token: 0x04005FC4 RID: 24516
			[FieldOffset(8)]
			public FString address;
		}

		// Token: 0x02000D30 RID: 3376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04005FC5 RID: 24517
			[FieldOffset(0)]
			public FString appId;

			// Token: 0x04005FC6 RID: 24518
			[FieldOffset(16)]
			public FString appChannel;

			// Token: 0x04005FC7 RID: 24519
			[FieldOffset(32)]
			public FString appKey;

			// Token: 0x04005FC8 RID: 24520
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02000D31 RID: 3377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDeviceInfo_FunctionParams
		{
			// Token: 0x04005FC9 RID: 24521
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D32 RID: 3378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EnableDeviceInfoCollect_FunctionParams
		{
			// Token: 0x04005FCA RID: 24522
			[FieldOffset(0)]
			public FString model;

			// Token: 0x04005FCB RID: 24523
			[FieldOffset(16)]
			public bool state;

			// Token: 0x04005FCC RID: 24524
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000D33 RID: 3379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDeviceInfo_FunctionParams
		{
			// Token: 0x04005FCD RID: 24525
			[FieldOffset(0)]
			public bool enable;
		}
	}
}
