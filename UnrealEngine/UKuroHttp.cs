using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047B RID: 1147
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroHttp : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C8C RID: 27788 RVA: 0x0009E4EC File Offset: 0x0009C6EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttp._ClassPtr;
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x0009E4F8 File Offset: 0x0009C6F8
		public UKuroHttp() : this(BuiltinUtils.AllocNativeUObject(UKuroHttp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0009E520 File Offset: 0x0009C720
		[NullableContext(1)]
		public UKuroHttp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x0009E554 File Offset: 0x0009C754
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void PostRpt2(string Url, string ContentStr, string Content1Str, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt2_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt2_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroHttp.__PostRpt2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			FString.CopyFrom((void*)(&ptr->Content1Str), Content1Str);
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void PostRpt1(string ContentStr, string Content1Str, bool IsGlobal, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt1_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt1_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroHttp.__PostRpt1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			FString.CopyFrom((void*)(&ptr->Content1Str), Content1Str);
			ptr->IsGlobal = IsGlobal;
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x0009E680 File Offset: 0x0009C880
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void PostRpt(string ContentStr, bool IsGlobal, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroHttp.__PostRpt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			ptr->IsGlobal = IsGlobal;
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x0009E704 File Offset: 0x0009C904
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void PostAli([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<string, string> QueryParameter, FHttpResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostAli_FunctionParams* ptr = stackalloc UKuroHttp.__PostAli_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UKuroHttp.__PostAli_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostAli_NativeFunctionPtr, (void*)ptr, 1);
			TMap<string, string> tmap = QueryParameter;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->QueryParameter);
			}
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostAli_NativeFunctionPtr, (void*)ptr);
			TMap<string, string> tmap2 = QueryParameter;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->QueryParameter);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostAli_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x0009E7A0 File Offset: 0x0009C9A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void Post(string URL, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<string, string> HeaderParam, string Content, [Nullable(2)] FHttpResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__Post_FunctionParams* ptr = stackalloc UKuroHttp.__Post_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(UKuroHttp.__Post_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__Post_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->URL), URL);
			TMap<string, string> tmap = HeaderParam;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->HeaderParam);
			}
			FString.CopyFrom((void*)(&ptr->Content), Content);
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__Post_NativeFunctionPtr, (void*)ptr);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__Post_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x0009E858 File Offset: 0x0009CA58
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static TMap<string, string> GetDefaultHeader()
		{
			UKuroHttp.__GetDefaultHeader_FunctionParams* ptr = stackalloc UKuroHttp.__GetDefaultHeader_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroHttp.__GetDefaultHeader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr);
			TMap<string, string> result = new TMap<string, string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x0009E8B8 File Offset: 0x0009CAB8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void Get(string URL, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<string, string> HeaderParam, [Nullable(2)] FHttpResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__Get_FunctionParams* ptr = stackalloc UKuroHttp.__Get_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(UKuroHttp.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__Get_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->URL), URL);
			TMap<string, string> tmap = HeaderParam;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->HeaderParam);
			}
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__Get_NativeFunctionPtr, (void*)ptr);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__Get_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x0009E95F File Offset: 0x0009CB5F
		static UKuroHttp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttp");
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x0009E96D File Offset: 0x0009CB6D
		protected UKuroHttp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E5F RID: 11871
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttp";

		// Token: 0x04002E60 RID: 11872
		private static IntPtr _ClassPtr;

		// Token: 0x04002E61 RID: 11873
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E62 RID: 11874
		private static IntPtr __PostRpt2_NativeFunctionPtr;

		// Token: 0x04002E63 RID: 11875
		private static IntPtr __PostRpt1_NativeFunctionPtr;

		// Token: 0x04002E64 RID: 11876
		private static IntPtr __PostRpt_NativeFunctionPtr;

		// Token: 0x04002E65 RID: 11877
		private static IntPtr __PostAli_NativeFunctionPtr;

		// Token: 0x04002E66 RID: 11878
		private static IntPtr __Post_NativeFunctionPtr;

		// Token: 0x04002E67 RID: 11879
		private static IntPtr __GetDefaultHeader_NativeFunctionPtr;

		// Token: 0x04002E68 RID: 11880
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x02000B81 RID: 2945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __PostRpt2_FunctionParams
		{
			// Token: 0x04005CDE RID: 23774
			[FieldOffset(0)]
			public FString Url;

			// Token: 0x04005CDF RID: 23775
			[FieldOffset(16)]
			public FString ContentStr;

			// Token: 0x04005CE0 RID: 23776
			[FieldOffset(32)]
			public FString Content1Str;

			// Token: 0x04005CE1 RID: 23777
			[FieldOffset(48)]
			public byte Handle;

			// Token: 0x04005CE2 RID: 23778
			[FieldOffset(88)]
			public float InTimeoutSecs;
		}

		// Token: 0x02000B82 RID: 2946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __PostRpt1_FunctionParams
		{
			// Token: 0x04005CE3 RID: 23779
			[FieldOffset(0)]
			public FString ContentStr;

			// Token: 0x04005CE4 RID: 23780
			[FieldOffset(16)]
			public FString Content1Str;

			// Token: 0x04005CE5 RID: 23781
			[FieldOffset(32)]
			public bool IsGlobal;

			// Token: 0x04005CE6 RID: 23782
			[FieldOffset(40)]
			public byte Handle;

			// Token: 0x04005CE7 RID: 23783
			[FieldOffset(80)]
			public float InTimeoutSecs;
		}

		// Token: 0x02000B83 RID: 2947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __PostRpt_FunctionParams
		{
			// Token: 0x04005CE8 RID: 23784
			[FieldOffset(0)]
			public FString ContentStr;

			// Token: 0x04005CE9 RID: 23785
			[FieldOffset(16)]
			public bool IsGlobal;

			// Token: 0x04005CEA RID: 23786
			[FieldOffset(24)]
			public byte Handle;

			// Token: 0x04005CEB RID: 23787
			[FieldOffset(64)]
			public float InTimeoutSecs;
		}

		// Token: 0x02000B84 RID: 2948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __PostAli_FunctionParams
		{
			// Token: 0x04005CEC RID: 23788
			[FieldOffset(0)]
			public byte QueryParameter;

			// Token: 0x04005CED RID: 23789
			[FieldOffset(80)]
			public byte Handle;

			// Token: 0x04005CEE RID: 23790
			[FieldOffset(120)]
			public float InTimeoutSecs;
		}

		// Token: 0x02000B85 RID: 2949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __Post_FunctionParams
		{
			// Token: 0x04005CEF RID: 23791
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x04005CF0 RID: 23792
			[FieldOffset(16)]
			public byte HeaderParam;

			// Token: 0x04005CF1 RID: 23793
			[FieldOffset(96)]
			public FString Content;

			// Token: 0x04005CF2 RID: 23794
			[FieldOffset(112)]
			public byte Handle;

			// Token: 0x04005CF3 RID: 23795
			[FieldOffset(152)]
			public float InTimeoutSecs;
		}

		// Token: 0x02000B86 RID: 2950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetDefaultHeader_FunctionParams
		{
			// Token: 0x04005CF4 RID: 23796
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000B87 RID: 2951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x04005CF5 RID: 23797
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x04005CF6 RID: 23798
			[FieldOffset(16)]
			public byte HeaderParam;

			// Token: 0x04005CF7 RID: 23799
			[FieldOffset(96)]
			public byte Handle;

			// Token: 0x04005CF8 RID: 23800
			[FieldOffset(136)]
			public float InTimeoutSecs;
		}
	}
}
