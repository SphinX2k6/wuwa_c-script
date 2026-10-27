using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C0 RID: 5568
	[UnrealObjectPath("/Script/json2struct.json2structBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class Ujson2structBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014142 RID: 82242 RVA: 0x001D784F File Offset: 0x001D5A4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return Ujson2structBPLibrary._ClassPtr;
		}

		// Token: 0x06014143 RID: 82243 RVA: 0x001D785C File Offset: 0x001D5A5C
		public Ujson2structBPLibrary() : this(BuiltinUtils.AllocNativeUObject(Ujson2structBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014144 RID: 82244 RVA: 0x001D7884 File Offset: 0x001D5A84
		[NullableContext(1)]
		public Ujson2structBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Ujson2structBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014145 RID: 82245 RVA: 0x001D78B8 File Offset: 0x001D5AB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(0)]
		public unsafe static TEnumAsByte<EJson2structParseResult> WriteStructBP(UStruct inStruct, FJson2struct_filter filter, [Nullable(1)] ref string Json)
		{
			Ujson2structBPLibrary.__WriteStructBP_FunctionParams* ptr = stackalloc Ujson2structBPLibrary.__WriteStructBP_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(Ujson2structBPLibrary.__WriteStructBP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ujson2structBPLibrary.__WriteStructBP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inStruct = ((inStruct != null) ? inStruct.NativePtr : IntPtr.Zero);
			if (filter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FJson2struct_filter.StaticStruct(), &ptr->filter, filter.NativePtr, 1, false);
			}
			FString.CopyFrom((void*)(&ptr->Json), Json);
			UnrealReflectionUtils.CallUFunction(Ujson2structBPLibrary._ClassDefaultObjectPtr, Ujson2structBPLibrary.__WriteStructBP_NativeFunctionPtr, (void*)ptr, 0);
			Json = FString.ToString((void*)(&ptr->Json));
			TEnumAsByte<EJson2structParseResult> _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(Ujson2structBPLibrary.__WriteStructBP_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06014146 RID: 82246 RVA: 0x001D7964 File Offset: 0x001D5B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TEnumAsByte<EJson2structParseResult> json2structBP([Nullable(2)] ref UStruct Out, [Nullable(1)] string json = "{}")
		{
			Ujson2structBPLibrary.__json2structBP_FunctionParams* ptr = stackalloc Ujson2structBPLibrary.__json2structBP_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(Ujson2structBPLibrary.__json2structBP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ujson2structBPLibrary.__json2structBP_NativeFunctionPtr, (void*)ptr, 1);
			ref Ujson2structBPLibrary.__json2structBP_FunctionParams ptr2 = ref *ptr;
			UStruct ustruct = Out;
			ptr2.Out = ((ustruct != null) ? ustruct.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->json), json);
			UnrealReflectionUtils.CallUFunction(Ujson2structBPLibrary._ClassDefaultObjectPtr, Ujson2structBPLibrary.__json2structBP_NativeFunctionPtr, (void*)ptr, 0);
			Out = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStruct>(ptr->Out);
			TEnumAsByte<EJson2structParseResult> _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(Ujson2structBPLibrary.__json2structBP_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06014147 RID: 82247 RVA: 0x001D79EC File Offset: 0x001D5BEC
		static Ujson2structBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/json2struct.json2structBPLibrary");
		}

		// Token: 0x06014148 RID: 82248 RVA: 0x001D79FA File Offset: 0x001D5BFA
		protected Ujson2structBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AEB1 RID: 44721
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/json2struct.json2structBPLibrary";

		// Token: 0x0400AEB2 RID: 44722
		private static IntPtr _ClassPtr;

		// Token: 0x0400AEB3 RID: 44723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AEB4 RID: 44724
		private static IntPtr __WriteStructBP_NativeFunctionPtr;

		// Token: 0x0400AEB5 RID: 44725
		private static IntPtr __json2structBP_NativeFunctionPtr;

		// Token: 0x02002EC4 RID: 11972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __WriteStructBP_FunctionParams
		{
			// Token: 0x040169C1 RID: 92609
			[FieldOffset(0)]
			public IntPtr inStruct;

			// Token: 0x040169C2 RID: 92610
			[FieldOffset(8)]
			public byte filter;

			// Token: 0x040169C3 RID: 92611
			[FieldOffset(88)]
			public FString Json;

			// Token: 0x040169C4 RID: 92612
			[FieldOffset(104)]
			public TEnumAsByte<EJson2structParseResult> __Result;
		}

		// Token: 0x02002EC5 RID: 11973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __json2structBP_FunctionParams
		{
			// Token: 0x040169C5 RID: 92613
			[FieldOffset(0)]
			public IntPtr Out;

			// Token: 0x040169C6 RID: 92614
			[FieldOffset(8)]
			public FString json;

			// Token: 0x040169C7 RID: 92615
			[FieldOffset(24)]
			public TEnumAsByte<EJson2structParseResult> __Result;
		}
	}
}
