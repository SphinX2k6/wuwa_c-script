using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F5 RID: 6645
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroHttp : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A0F RID: 100879 RVA: 0x00244CE8 File Offset: 0x00242EE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttp._ClassPtr;
		}

		// Token: 0x06018A10 RID: 100880 RVA: 0x00244CF4 File Offset: 0x00242EF4
		public UKuroHttp() : this(BuiltinUtils.AllocNativeUObject(UKuroHttp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A11 RID: 100881 RVA: 0x00244D1C File Offset: 0x00242F1C
		[NullableContext(1)]
		public UKuroHttp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018A12 RID: 100882 RVA: 0x00244D50 File Offset: 0x00242F50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PostRpt2(string Url, string ContentStr, string Content1Str, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt2_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt2_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroHttp.__PostRpt2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			FString.CopyFrom((void*)(&ptr->Content1Str), Content1Str);
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x00244DE8 File Offset: 0x00242FE8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PostRpt1(string ContentStr, string Content1Str, bool IsGlobal, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt1_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt1_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroHttp.__PostRpt1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			FString.CopyFrom((void*)(&ptr->Content1Str), Content1Str);
			ptr->IsGlobal = IsGlobal;
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x00244E7C File Offset: 0x0024307C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PostRpt(string ContentStr, bool IsGlobal, [Nullable(2)] FRptResponseHandle Handle, float InTimeoutSecs = 0f)
		{
			UKuroHttp.__PostRpt_FunctionParams* ptr = stackalloc UKuroHttp.__PostRpt_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroHttp.__PostRpt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ContentStr), ContentStr);
			ptr->IsGlobal = IsGlobal;
			FScriptDelegate.NativeCopy(&ptr->Handle, (Handle != null) ? Handle.NativePtr : ((IntPtr)0));
			ptr->InTimeoutSecs = InTimeoutSecs;
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostRpt_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A15 RID: 100885 RVA: 0x00244F00 File Offset: 0x00243100
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__PostAli_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> tmap2 = QueryParameter;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->QueryParameter);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__PostAli_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A16 RID: 100886 RVA: 0x00244F9C File Offset: 0x0024319C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__Post_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__Post_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A17 RID: 100887 RVA: 0x00245054 File Offset: 0x00243254
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TMap<string, string> GetDefaultHeader()
		{
			UKuroHttp.__GetDefaultHeader_FunctionParams* ptr = stackalloc UKuroHttp.__GetDefaultHeader_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroHttp.__GetDefaultHeader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> result = new TMap<string, string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__GetDefaultHeader_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018A18 RID: 100888 RVA: 0x002450B4 File Offset: 0x002432B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroHttp._ClassDefaultObjectPtr, UKuroHttp.__Get_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> tmap2 = HeaderParam;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->HeaderParam);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroHttp.__Get_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A19 RID: 100889 RVA: 0x0024515C File Offset: 0x0024335C
		static UKuroHttp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttp");
		}

		// Token: 0x06018A1A RID: 100890 RVA: 0x0024516A File Offset: 0x0024336A
		protected UKuroHttp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4FD RID: 54525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttp";

		// Token: 0x0400D4FE RID: 54526
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4FF RID: 54527
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D500 RID: 54528
		private static IntPtr __PostRpt2_NativeFunctionPtr;

		// Token: 0x0400D501 RID: 54529
		private static IntPtr __PostRpt1_NativeFunctionPtr;

		// Token: 0x0400D502 RID: 54530
		private static IntPtr __PostRpt_NativeFunctionPtr;

		// Token: 0x0400D503 RID: 54531
		private static IntPtr __PostAli_NativeFunctionPtr;

		// Token: 0x0400D504 RID: 54532
		private static IntPtr __Post_NativeFunctionPtr;

		// Token: 0x0400D505 RID: 54533
		private static IntPtr __GetDefaultHeader_NativeFunctionPtr;

		// Token: 0x0400D506 RID: 54534
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x020030A1 RID: 12449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __PostRpt2_FunctionParams
		{
			// Token: 0x04016DCD RID: 93645
			[FieldOffset(0)]
			public FString Url;

			// Token: 0x04016DCE RID: 93646
			[FieldOffset(16)]
			public FString ContentStr;

			// Token: 0x04016DCF RID: 93647
			[FieldOffset(32)]
			public FString Content1Str;

			// Token: 0x04016DD0 RID: 93648
			[FieldOffset(48)]
			public byte Handle;

			// Token: 0x04016DD1 RID: 93649
			[FieldOffset(88)]
			public float InTimeoutSecs;
		}

		// Token: 0x020030A2 RID: 12450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __PostRpt1_FunctionParams
		{
			// Token: 0x04016DD2 RID: 93650
			[FieldOffset(0)]
			public FString ContentStr;

			// Token: 0x04016DD3 RID: 93651
			[FieldOffset(16)]
			public FString Content1Str;

			// Token: 0x04016DD4 RID: 93652
			[FieldOffset(32)]
			public bool IsGlobal;

			// Token: 0x04016DD5 RID: 93653
			[FieldOffset(40)]
			public byte Handle;

			// Token: 0x04016DD6 RID: 93654
			[FieldOffset(80)]
			public float InTimeoutSecs;
		}

		// Token: 0x020030A3 RID: 12451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __PostRpt_FunctionParams
		{
			// Token: 0x04016DD7 RID: 93655
			[FieldOffset(0)]
			public FString ContentStr;

			// Token: 0x04016DD8 RID: 93656
			[FieldOffset(16)]
			public bool IsGlobal;

			// Token: 0x04016DD9 RID: 93657
			[FieldOffset(24)]
			public byte Handle;

			// Token: 0x04016DDA RID: 93658
			[FieldOffset(64)]
			public float InTimeoutSecs;
		}

		// Token: 0x020030A4 RID: 12452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __PostAli_FunctionParams
		{
			// Token: 0x04016DDB RID: 93659
			[FieldOffset(0)]
			public byte QueryParameter;

			// Token: 0x04016DDC RID: 93660
			[FieldOffset(80)]
			public byte Handle;

			// Token: 0x04016DDD RID: 93661
			[FieldOffset(120)]
			public float InTimeoutSecs;
		}

		// Token: 0x020030A5 RID: 12453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __Post_FunctionParams
		{
			// Token: 0x04016DDE RID: 93662
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x04016DDF RID: 93663
			[FieldOffset(16)]
			public byte HeaderParam;

			// Token: 0x04016DE0 RID: 93664
			[FieldOffset(96)]
			public FString Content;

			// Token: 0x04016DE1 RID: 93665
			[FieldOffset(112)]
			public byte Handle;

			// Token: 0x04016DE2 RID: 93666
			[FieldOffset(152)]
			public float InTimeoutSecs;
		}

		// Token: 0x020030A6 RID: 12454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetDefaultHeader_FunctionParams
		{
			// Token: 0x04016DE3 RID: 93667
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020030A7 RID: 12455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x04016DE4 RID: 93668
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x04016DE5 RID: 93669
			[FieldOffset(16)]
			public byte HeaderParam;

			// Token: 0x04016DE6 RID: 93670
			[FieldOffset(96)]
			public byte Handle;

			// Token: 0x04016DE7 RID: 93671
			[FieldOffset(136)]
			public float InTimeoutSecs;
		}
	}
}
