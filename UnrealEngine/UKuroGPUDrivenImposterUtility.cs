using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200197D RID: 6525
	[UnrealObjectPath("/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUtility")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGPUDrivenImposterUtility : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060183D1 RID: 99281 RVA: 0x0023BF46 File Offset: 0x0023A146
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUDrivenImposterUtility._ClassPtr;
		}

		// Token: 0x060183D2 RID: 99282 RVA: 0x0023BF54 File Offset: 0x0023A154
		public UKuroGPUDrivenImposterUtility() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterUtility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060183D3 RID: 99283 RVA: 0x0023BF7C File Offset: 0x0023A17C
		[NullableContext(1)]
		public UKuroGPUDrivenImposterUtility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterUtility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060183D4 RID: 99284 RVA: 0x0023BFB0 File Offset: 0x0023A1B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void StartStableUploadBenchmark(UWorld World, int WarmupFrames = 120, int SampleFrames = 300)
		{
			UKuroGPUDrivenImposterUtility.__StartStableUploadBenchmark_FunctionParams* ptr = stackalloc UKuroGPUDrivenImposterUtility.__StartStableUploadBenchmark_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroGPUDrivenImposterUtility.__StartStableUploadBenchmark_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGPUDrivenImposterUtility.__StartStableUploadBenchmark_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			ptr->WarmupFrames = WarmupFrames;
			ptr->SampleFrames = SampleFrames;
			UnrealReflectionUtils.CallUFunction(UKuroGPUDrivenImposterUtility._ClassDefaultObjectPtr, UKuroGPUDrivenImposterUtility.__StartStableUploadBenchmark_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060183D5 RID: 99285 RVA: 0x0023C014 File Offset: 0x0023A214
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveAll(UWorld EditorWorld, bool bClear)
		{
			UKuroGPUDrivenImposterUtility.__RemoveAll_FunctionParams* ptr = stackalloc UKuroGPUDrivenImposterUtility.__RemoveAll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroGPUDrivenImposterUtility.__RemoveAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGPUDrivenImposterUtility.__RemoveAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EditorWorld = ((EditorWorld != null) ? EditorWorld.NativePtr : IntPtr.Zero);
			ptr->bClear = bClear;
			UnrealReflectionUtils.CallUFunction(UKuroGPUDrivenImposterUtility._ClassDefaultObjectPtr, UKuroGPUDrivenImposterUtility.__RemoveAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060183D6 RID: 99286 RVA: 0x0023C070 File Offset: 0x0023A270
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetStableUploadBenchmarkStatus([Nullable(2)] UWorld World)
		{
			UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_FunctionParams* ptr = stackalloc UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroGPUDrivenImposterUtility._ClassDefaultObjectPtr, UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroGPUDrivenImposterUtility.__GetStableUploadBenchmarkStatus_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060183D7 RID: 99287 RVA: 0x0023C0E4 File Offset: 0x0023A2E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GenerateAll(UWorld EditorWorld, bool bBake, bool bClear)
		{
			UKuroGPUDrivenImposterUtility.__GenerateAll_FunctionParams* ptr = stackalloc UKuroGPUDrivenImposterUtility.__GenerateAll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroGPUDrivenImposterUtility.__GenerateAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGPUDrivenImposterUtility.__GenerateAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EditorWorld = ((EditorWorld != null) ? EditorWorld.NativePtr : IntPtr.Zero);
			ptr->bBake = bBake;
			ptr->bClear = bClear;
			UnrealReflectionUtils.CallUFunction(UKuroGPUDrivenImposterUtility._ClassDefaultObjectPtr, UKuroGPUDrivenImposterUtility.__GenerateAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060183D8 RID: 99288 RVA: 0x0023C147 File Offset: 0x0023A347
		static UKuroGPUDrivenImposterUtility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUtility");
		}

		// Token: 0x060183D9 RID: 99289 RVA: 0x0023C155 File Offset: 0x0023A355
		protected UKuroGPUDrivenImposterUtility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D207 RID: 53767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUtility";

		// Token: 0x0400D208 RID: 53768
		private static IntPtr _ClassPtr;

		// Token: 0x0400D209 RID: 53769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D20A RID: 53770
		private static IntPtr __StartStableUploadBenchmark_NativeFunctionPtr;

		// Token: 0x0400D20B RID: 53771
		private static IntPtr __RemoveAll_NativeFunctionPtr;

		// Token: 0x0400D20C RID: 53772
		private static IntPtr __GetStableUploadBenchmarkStatus_NativeFunctionPtr;

		// Token: 0x0400D20D RID: 53773
		private static IntPtr __GenerateAll_NativeFunctionPtr;

		// Token: 0x02003074 RID: 12404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __StartStableUploadBenchmark_FunctionParams
		{
			// Token: 0x04016D46 RID: 93510
			[FieldOffset(0)]
			public IntPtr World;

			// Token: 0x04016D47 RID: 93511
			[FieldOffset(8)]
			public int WarmupFrames;

			// Token: 0x04016D48 RID: 93512
			[FieldOffset(12)]
			public int SampleFrames;
		}

		// Token: 0x02003075 RID: 12405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveAll_FunctionParams
		{
			// Token: 0x04016D49 RID: 93513
			[FieldOffset(0)]
			public IntPtr EditorWorld;

			// Token: 0x04016D4A RID: 93514
			[FieldOffset(8)]
			public bool bClear;
		}

		// Token: 0x02003076 RID: 12406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetStableUploadBenchmarkStatus_FunctionParams
		{
			// Token: 0x04016D4B RID: 93515
			[FieldOffset(0)]
			public IntPtr World;

			// Token: 0x04016D4C RID: 93516
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x02003077 RID: 12407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GenerateAll_FunctionParams
		{
			// Token: 0x04016D4D RID: 93517
			[FieldOffset(0)]
			public IntPtr EditorWorld;

			// Token: 0x04016D4E RID: 93518
			[FieldOffset(8)]
			public bool bBake;

			// Token: 0x04016D4F RID: 93519
			[FieldOffset(9)]
			public bool bClear;
		}
	}
}
