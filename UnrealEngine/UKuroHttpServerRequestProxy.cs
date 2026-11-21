using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047D RID: 1149
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttpServerRequestProxy")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKuroHttpServerRequestProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CA1 RID: 27809 RVA: 0x0009EAFC File Offset: 0x0009CCFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttpServerRequestProxy._ClassPtr;
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x0009EB08 File Offset: 0x0009CD08
		public UKuroHttpServerRequestProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRequestProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x0009EB30 File Offset: 0x0009CD30
		[NullableContext(1)]
		public UKuroHttpServerRequestProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRequestProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x0009EB64 File Offset: 0x0009CD64
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Response(string Json, bool bSuccess = true)
		{
			UKuroHttpServerRequestProxy.__Response_FunctionParams* ptr = stackalloc UKuroHttpServerRequestProxy.__Response_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroHttpServerRequestProxy.__Response_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Json), Json);
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__Response_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string GetRequest()
		{
			UKuroHttpServerRequestProxy.__GetRequest_FunctionParams* ptr = stackalloc UKuroHttpServerRequestProxy.__GetRequest_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroHttpServerRequestProxy.__GetRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__GetRequest_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x0009EC24 File Offset: 0x0009CE24
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHttpServerRequestProxy.__GetHeader_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = OutHeader;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutHeader);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroHttpServerRequestProxy.__GetHeader_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x0009ECAF File Offset: 0x0009CEAF
		static UKuroHttpServerRequestProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttpServerRequestProxy");
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x0009ECBD File Offset: 0x0009CEBD
		protected UKuroHttpServerRequestProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E6C RID: 11884
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttpServerRequestProxy";

		// Token: 0x04002E6D RID: 11885
		private static IntPtr _ClassPtr;

		// Token: 0x04002E6E RID: 11886
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E6F RID: 11887
		private static IntPtr __Response_NativeFunctionPtr;

		// Token: 0x04002E70 RID: 11888
		private static IntPtr __GetRequest_NativeFunctionPtr;

		// Token: 0x04002E71 RID: 11889
		private static IntPtr __GetHeader_NativeFunctionPtr;

		// Token: 0x02000B8A RID: 2954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Response_FunctionParams
		{
			// Token: 0x04005CFC RID: 23804
			[FieldOffset(0)]
			public FString Json;

			// Token: 0x04005CFD RID: 23805
			[FieldOffset(16)]
			public bool bSuccess;
		}

		// Token: 0x02000B8B RID: 2955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRequest_FunctionParams
		{
			// Token: 0x04005CFE RID: 23806
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000B8C RID: 2956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetHeader_FunctionParams
		{
			// Token: 0x04005CFF RID: 23807
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04005D00 RID: 23808
			[FieldOffset(16)]
			public byte OutHeader;

			// Token: 0x04005D01 RID: 23809
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
