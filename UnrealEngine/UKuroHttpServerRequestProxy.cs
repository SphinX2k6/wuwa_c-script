using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F7 RID: 6647
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttpServerRequestProxy")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKuroHttpServerRequestProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A24 RID: 100900 RVA: 0x002452F8 File Offset: 0x002434F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttpServerRequestProxy._ClassPtr;
		}

		// Token: 0x06018A25 RID: 100901 RVA: 0x00245304 File Offset: 0x00243504
		public UKuroHttpServerRequestProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRequestProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A26 RID: 100902 RVA: 0x0024532C File Offset: 0x0024352C
		[NullableContext(1)]
		public UKuroHttpServerRequestProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRequestProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018A27 RID: 100903 RVA: 0x00245360 File Offset: 0x00243560
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Response(string Json, bool bSuccess = true)
		{
			UKuroHttpServerRequestProxy.__Response_FunctionParams* ptr = stackalloc UKuroHttpServerRequestProxy.__Response_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroHttpServerRequestProxy.__Response_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Json), Json);
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A28 RID: 100904 RVA: 0x002453C8 File Offset: 0x002435C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetRequest()
		{
			UKuroHttpServerRequestProxy.__GetRequest_FunctionParams* ptr = stackalloc UKuroHttpServerRequestProxy.__GetRequest_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroHttpServerRequestProxy.__GetRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018A29 RID: 100905 RVA: 0x00245428 File Offset: 0x00243628
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetHeader(string Key, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutHeader)
		{
			UKuroHttpServerRequestProxy.__GetHeader_FunctionParams* ptr = stackalloc UKuroHttpServerRequestProxy.__GetHeader_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroHttpServerRequestProxy.__GetHeader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttpServerRequestProxy.__GetHeader_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			TArray<string> tarray = OutHeader;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutHeader);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__GetHeader_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutHeader;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutHeader);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__GetHeader_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06018A2A RID: 100906 RVA: 0x002454B4 File Offset: 0x002436B4
		static UKuroHttpServerRequestProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttpServerRequestProxy");
		}

		// Token: 0x06018A2B RID: 100907 RVA: 0x002454C2 File Offset: 0x002436C2
		protected UKuroHttpServerRequestProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D50A RID: 54538
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttpServerRequestProxy";

		// Token: 0x0400D50B RID: 54539
		private static IntPtr _ClassPtr;

		// Token: 0x0400D50C RID: 54540
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D50D RID: 54541
		private static IntPtr __Response_NativeFunctionPtr;

		// Token: 0x0400D50E RID: 54542
		private static IntPtr __GetRequest_NativeFunctionPtr;

		// Token: 0x0400D50F RID: 54543
		private static IntPtr __GetHeader_NativeFunctionPtr;

		// Token: 0x020030AA RID: 12458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Response_FunctionParams
		{
			// Token: 0x04016DEB RID: 93675
			[FieldOffset(0)]
			public FString Json;

			// Token: 0x04016DEC RID: 93676
			[FieldOffset(16)]
			public bool bSuccess;
		}

		// Token: 0x020030AB RID: 12459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRequest_FunctionParams
		{
			// Token: 0x04016DED RID: 93677
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020030AC RID: 12460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetHeader_FunctionParams
		{
			// Token: 0x04016DEE RID: 93678
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04016DEF RID: 93679
			[FieldOffset(16)]
			public byte OutHeader;

			// Token: 0x04016DF0 RID: 93680
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
