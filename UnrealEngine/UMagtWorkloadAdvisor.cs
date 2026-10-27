using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200227B RID: 8827
	[UnrealObjectPath("/Script/MagtModule.MagtWorkloadAdvisor")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMagtWorkloadAdvisor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021905 RID: 137477 RVA: 0x0031A42C File Offset: 0x0031862C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtWorkloadAdvisor._ClassPtr;
		}

		// Token: 0x06021906 RID: 137478 RVA: 0x0031A438 File Offset: 0x00318638
		public UMagtWorkloadAdvisor() : this(BuiltinUtils.AllocNativeUObject(UMagtWorkloadAdvisor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021907 RID: 137479 RVA: 0x0031A460 File Offset: 0x00318660
		[NullableContext(1)]
		public UMagtWorkloadAdvisor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtWorkloadAdvisor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008274 RID: 33396
		// (get) Token: 0x06021908 RID: 137480 RVA: 0x0031A494 File Offset: 0x00318694
		// (set) Token: 0x06021909 RID: 137481 RVA: 0x0031A4CD File Offset: 0x003186CD
		[Nullable(1)]
		public FOnWorkloadAdviceChanged OnWorkloadAdviceChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnWorkloadAdviceChanged result;
				if ((result = this._OnWorkloadAdviceChanged) == null)
				{
					result = (this._OnWorkloadAdviceChanged = new FOnWorkloadAdviceChanged(base.NativePtr + (IntPtr)UMagtWorkloadAdvisor.__PropertyOffset_OnWorkloadAdviceChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtWorkloadAdvisor.__PropertyOffset_OnWorkloadAdviceChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0602190A RID: 137482 RVA: 0x0031A4F0 File Offset: 0x003186F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string WorkloadAdviceToString(EMagtWorkloadAdvice Advice)
		{
			UMagtWorkloadAdvisor.__WorkloadAdviceToString_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__WorkloadAdviceToString_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__WorkloadAdviceToString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__WorkloadAdviceToString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Advice = Advice;
			UnrealReflectionUtils.CallUFunction(UMagtWorkloadAdvisor._ClassDefaultObjectPtr, UMagtWorkloadAdvisor.__WorkloadAdviceToString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UMagtWorkloadAdvisor.__WorkloadAdviceToString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602190B RID: 137483 RVA: 0x0031A553 File Offset: 0x00318753
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopPollingAdvice()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtWorkloadAdvisor.__StopPollingAdvice_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602190C RID: 137484 RVA: 0x0031A568 File Offset: 0x00318768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StartPollingAdvice(float PollingIntervalSeconds = 1f)
		{
			UMagtWorkloadAdvisor.__StartPollingAdvice_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__StartPollingAdvice_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__StartPollingAdvice_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__StartPollingAdvice_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PollingIntervalSeconds = PollingIntervalSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtWorkloadAdvisor.__StartPollingAdvice_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602190D RID: 137485 RVA: 0x0031A5B0 File Offset: 0x003187B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ShouldUpgradeQuality(EMagtWorkloadAdvice Advice)
		{
			UMagtWorkloadAdvisor.__ShouldUpgradeQuality_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__ShouldUpgradeQuality_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__ShouldUpgradeQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__ShouldUpgradeQuality_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Advice = Advice;
			UnrealReflectionUtils.CallUFunction(UMagtWorkloadAdvisor._ClassDefaultObjectPtr, UMagtWorkloadAdvisor.__ShouldUpgradeQuality_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602190E RID: 137486 RVA: 0x0031A5FC File Offset: 0x003187FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ShouldDowngradeQuality(EMagtWorkloadAdvice Advice)
		{
			UMagtWorkloadAdvisor.__ShouldDowngradeQuality_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__ShouldDowngradeQuality_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__ShouldDowngradeQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__ShouldDowngradeQuality_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Advice = Advice;
			UnrealReflectionUtils.CallUFunction(UMagtWorkloadAdvisor._ClassDefaultObjectPtr, UMagtWorkloadAdvisor.__ShouldDowngradeQuality_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602190F RID: 137487 RVA: 0x0031A648 File Offset: 0x00318848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetWorkloadHint(int Hint)
		{
			UMagtWorkloadAdvisor.__SetWorkloadHint_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__SetWorkloadHint_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__SetWorkloadHint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__SetWorkloadHint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Hint = Hint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtWorkloadAdvisor.__SetWorkloadHint_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021910 RID: 137488 RVA: 0x0031A698 File Offset: 0x00318898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int QueryScenario()
		{
			UMagtWorkloadAdvisor.__QueryScenario_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__QueryScenario_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__QueryScenario_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__QueryScenario_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtWorkloadAdvisor.__QueryScenario_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021911 RID: 137489 RVA: 0x0031A6E0 File Offset: 0x003188E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsGPUBound(EMagtWorkloadAdvice Advice)
		{
			UMagtWorkloadAdvisor.__IsGPUBound_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__IsGPUBound_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__IsGPUBound_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__IsGPUBound_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Advice = Advice;
			UnrealReflectionUtils.CallUFunction(UMagtWorkloadAdvisor._ClassDefaultObjectPtr, UMagtWorkloadAdvisor.__IsGPUBound_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021912 RID: 137490 RVA: 0x0031A72C File Offset: 0x0031892C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsCPUBound(EMagtWorkloadAdvice Advice)
		{
			UMagtWorkloadAdvisor.__IsCPUBound_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__IsCPUBound_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__IsCPUBound_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__IsCPUBound_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Advice = Advice;
			UnrealReflectionUtils.CallUFunction(UMagtWorkloadAdvisor._ClassDefaultObjectPtr, UMagtWorkloadAdvisor.__IsCPUBound_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021913 RID: 137491 RVA: 0x0031A778 File Offset: 0x00318978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EMagtWorkloadAdvice GetWorkloadAdvice()
		{
			UMagtWorkloadAdvisor.__GetWorkloadAdvice_FunctionParams* ptr = stackalloc UMagtWorkloadAdvisor.__GetWorkloadAdvice_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtWorkloadAdvisor.__GetWorkloadAdvice_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtWorkloadAdvisor.__GetWorkloadAdvice_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtWorkloadAdvisor.__GetWorkloadAdvice_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021914 RID: 137492 RVA: 0x0031A7BE File Offset: 0x003189BE
		static UMagtWorkloadAdvisor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtWorkloadAdvisor");
		}

		// Token: 0x06021915 RID: 137493 RVA: 0x0031A7CC File Offset: 0x003189CC
		protected UMagtWorkloadAdvisor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011ECC RID: 73420
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtWorkloadAdvisor";

		// Token: 0x04011ECD RID: 73421
		private static IntPtr _ClassPtr;

		// Token: 0x04011ECE RID: 73422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011ECF RID: 73423
		internal static int __PropertyOffset_OnWorkloadAdviceChanged;

		// Token: 0x04011ED0 RID: 73424
		[Nullable(2)]
		private FOnWorkloadAdviceChanged _OnWorkloadAdviceChanged;

		// Token: 0x04011ED1 RID: 73425
		private static IntPtr __WorkloadAdviceToString_NativeFunctionPtr;

		// Token: 0x04011ED2 RID: 73426
		private static IntPtr __StopPollingAdvice_NativeFunctionPtr;

		// Token: 0x04011ED3 RID: 73427
		private static IntPtr __StartPollingAdvice_NativeFunctionPtr;

		// Token: 0x04011ED4 RID: 73428
		private static IntPtr __ShouldUpgradeQuality_NativeFunctionPtr;

		// Token: 0x04011ED5 RID: 73429
		private static IntPtr __ShouldDowngradeQuality_NativeFunctionPtr;

		// Token: 0x04011ED6 RID: 73430
		private static IntPtr __SetWorkloadHint_NativeFunctionPtr;

		// Token: 0x04011ED7 RID: 73431
		private static IntPtr __QueryScenario_NativeFunctionPtr;

		// Token: 0x04011ED8 RID: 73432
		private static IntPtr __IsGPUBound_NativeFunctionPtr;

		// Token: 0x04011ED9 RID: 73433
		private static IntPtr __IsCPUBound_NativeFunctionPtr;

		// Token: 0x04011EDA RID: 73434
		private static IntPtr __GetWorkloadAdvice_NativeFunctionPtr;

		// Token: 0x020035F9 RID: 13817
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __WorkloadAdviceToString_FunctionParams
		{
			// Token: 0x0401767A RID: 95866
			[FieldOffset(0)]
			public EMagtWorkloadAdvice Advice;

			// Token: 0x0401767B RID: 95867
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x020035FA RID: 13818
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __StartPollingAdvice_FunctionParams
		{
			// Token: 0x0401767C RID: 95868
			[FieldOffset(0)]
			public float PollingIntervalSeconds;
		}

		// Token: 0x020035FB RID: 13819
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __ShouldUpgradeQuality_FunctionParams
		{
			// Token: 0x0401767D RID: 95869
			[FieldOffset(0)]
			public EMagtWorkloadAdvice Advice;

			// Token: 0x0401767E RID: 95870
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020035FC RID: 13820
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __ShouldDowngradeQuality_FunctionParams
		{
			// Token: 0x0401767F RID: 95871
			[FieldOffset(0)]
			public EMagtWorkloadAdvice Advice;

			// Token: 0x04017680 RID: 95872
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020035FD RID: 13821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetWorkloadHint_FunctionParams
		{
			// Token: 0x04017681 RID: 95873
			[FieldOffset(0)]
			public int Hint;

			// Token: 0x04017682 RID: 95874
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035FE RID: 13822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __QueryScenario_FunctionParams
		{
			// Token: 0x04017683 RID: 95875
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035FF RID: 13823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsGPUBound_FunctionParams
		{
			// Token: 0x04017684 RID: 95876
			[FieldOffset(0)]
			public EMagtWorkloadAdvice Advice;

			// Token: 0x04017685 RID: 95877
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02003600 RID: 13824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsCPUBound_FunctionParams
		{
			// Token: 0x04017686 RID: 95878
			[FieldOffset(0)]
			public EMagtWorkloadAdvice Advice;

			// Token: 0x04017687 RID: 95879
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02003601 RID: 13825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetWorkloadAdvice_FunctionParams
		{
			// Token: 0x04017688 RID: 95880
			[FieldOffset(0)]
			public EMagtWorkloadAdvice __Result;
		}
	}
}
