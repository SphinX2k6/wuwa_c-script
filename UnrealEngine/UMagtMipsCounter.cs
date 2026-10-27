using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002274 RID: 8820
	[UnrealObjectPath("/Script/MagtModule.MagtMipsCounter")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UMagtMipsCounter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021865 RID: 137317 RVA: 0x00318574 File Offset: 0x00316774
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtMipsCounter._ClassPtr;
		}

		// Token: 0x06021866 RID: 137318 RVA: 0x00318580 File Offset: 0x00316780
		public UMagtMipsCounter() : this(BuiltinUtils.AllocNativeUObject(UMagtMipsCounter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021867 RID: 137319 RVA: 0x003185A8 File Offset: 0x003167A8
		[NullableContext(1)]
		public UMagtMipsCounter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtMipsCounter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700825D RID: 33373
		// (get) Token: 0x06021868 RID: 137320 RVA: 0x003185DC File Offset: 0x003167DC
		// (set) Token: 0x06021869 RID: 137321 RVA: 0x00318615 File Offset: 0x00316815
		[Nullable(1)]
		public TArray<FMagtCpuMipsData> CpuMipsData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMagtCpuMipsData> result;
				if ((result = this._CpuMipsData) == null)
				{
					result = (this._CpuMipsData = new TArray<FMagtCpuMipsData>(base.NativePtr + (IntPtr)UMagtMipsCounter.__PropertyOffset_CpuMipsData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CpuMipsData.CopyAssign(value);
			}
		}

		// Token: 0x0602186A RID: 137322 RVA: 0x00318624 File Offset: 0x00316824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StopAndUpdate()
		{
			UMagtMipsCounter.__StopAndUpdate_FunctionParams* ptr = stackalloc UMagtMipsCounter.__StopAndUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtMipsCounter.__StopAndUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__StopAndUpdate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__StopAndUpdate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602186B RID: 137323 RVA: 0x0031866C File Offset: 0x0031686C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StartCounting()
		{
			UMagtMipsCounter.__StartCounting_FunctionParams* ptr = stackalloc UMagtMipsCounter.__StartCounting_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtMipsCounter.__StartCounting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__StartCounting_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__StartCounting_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602186C RID: 137324 RVA: 0x003186B4 File Offset: 0x003168B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRunning()
		{
			UMagtMipsCounter.__IsRunning_FunctionParams* ptr = stackalloc UMagtMipsCounter.__IsRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtMipsCounter.__IsRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__IsRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__IsRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602186D RID: 137325 RVA: 0x003186FC File Offset: 0x003168FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInitialized()
		{
			UMagtMipsCounter.__IsInitialized_FunctionParams* ptr = stackalloc UMagtMipsCounter.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtMipsCounter.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__IsInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602186E RID: 137326 RVA: 0x00318744 File Offset: 0x00316944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Initialize(bool bExcludeKernelSpace = true)
		{
			UMagtMipsCounter.__Initialize_FunctionParams* ptr = stackalloc UMagtMipsCounter.__Initialize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bExcludeKernelSpace = bExcludeKernelSpace;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602186F RID: 137327 RVA: 0x00318794 File Offset: 0x00316994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetValidCpuCount()
		{
			UMagtMipsCounter.__GetValidCpuCount_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetValidCpuCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetValidCpuCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetValidCpuCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetValidCpuCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021870 RID: 137328 RVA: 0x003187DC File Offset: 0x003169DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetTotalMips()
		{
			UMagtMipsCounter.__GetTotalMips_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetTotalMips_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetTotalMips_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetTotalMips_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetTotalMips_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021871 RID: 137329 RVA: 0x00318824 File Offset: 0x00316A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetTotalMcps()
		{
			UMagtMipsCounter.__GetTotalMcps_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetTotalMcps_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetTotalMcps_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetTotalMcps_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetTotalMcps_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021872 RID: 137330 RVA: 0x0031886C File Offset: 0x00316A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe long GetTotalInstructions()
		{
			UMagtMipsCounter.__GetTotalInstructions_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetTotalInstructions_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__GetTotalInstructions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetTotalInstructions_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetTotalInstructions_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021873 RID: 137331 RVA: 0x003188B4 File Offset: 0x00316AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe long GetTotalCycles()
		{
			UMagtMipsCounter.__GetTotalCycles_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetTotalCycles_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__GetTotalCycles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetTotalCycles_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetTotalCycles_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021874 RID: 137332 RVA: 0x003188FC File Offset: 0x00316AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCpuMips(int CpuId)
		{
			UMagtMipsCounter.__GetCpuMips_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetCpuMips_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__GetCpuMips_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetCpuMips_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CpuId = CpuId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetCpuMips_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021875 RID: 137333 RVA: 0x0031894C File Offset: 0x00316B4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCpuMcps(int CpuId)
		{
			UMagtMipsCounter.__GetCpuMcps_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetCpuMcps_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__GetCpuMcps_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetCpuMcps_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CpuId = CpuId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetCpuMcps_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021876 RID: 137334 RVA: 0x0031899C File Offset: 0x00316B9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCpuCpi(int CpuId)
		{
			UMagtMipsCounter.__GetCpuCpi_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetCpuCpi_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtMipsCounter.__GetCpuCpi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetCpuCpi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CpuId = CpuId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetCpuCpi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021877 RID: 137335 RVA: 0x003189EC File Offset: 0x00316BEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetAverageMips()
		{
			UMagtMipsCounter.__GetAverageMips_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetAverageMips_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetAverageMips_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetAverageMips_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetAverageMips_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021878 RID: 137336 RVA: 0x00318A34 File Offset: 0x00316C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetAverageMcps()
		{
			UMagtMipsCounter.__GetAverageMcps_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetAverageMcps_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetAverageMcps_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetAverageMcps_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetAverageMcps_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021879 RID: 137337 RVA: 0x00318A7C File Offset: 0x00316C7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetAverageCpi()
		{
			UMagtMipsCounter.__GetAverageCpi_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetAverageCpi_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtMipsCounter.__GetAverageCpi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetAverageCpi_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetAverageCpi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602187A RID: 137338 RVA: 0x00318AC4 File Offset: 0x00316CC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FMagtCpuMipsData> GetAllCpuMipsData()
		{
			UMagtMipsCounter.__GetAllCpuMipsData_FunctionParams* ptr = stackalloc UMagtMipsCounter.__GetAllCpuMipsData_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMagtMipsCounter.__GetAllCpuMipsData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtMipsCounter.__GetAllCpuMipsData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__GetAllCpuMipsData_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FMagtCpuMipsData> result = new TArray<FMagtCpuMipsData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UMagtMipsCounter.__GetAllCpuMipsData_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602187B RID: 137339 RVA: 0x00318B23 File Offset: 0x00316D23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Cleanup()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtMipsCounter.__Cleanup_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602187C RID: 137340 RVA: 0x00318B38 File Offset: 0x00316D38
		static UMagtMipsCounter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtMipsCounter");
		}

		// Token: 0x0602187D RID: 137341 RVA: 0x00318B46 File Offset: 0x00316D46
		protected UMagtMipsCounter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E58 RID: 73304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtMipsCounter";

		// Token: 0x04011E59 RID: 73305
		private static IntPtr _ClassPtr;

		// Token: 0x04011E5A RID: 73306
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E5B RID: 73307
		internal static int __PropertyOffset_CpuMipsData;

		// Token: 0x04011E5C RID: 73308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMagtCpuMipsData> _CpuMipsData;

		// Token: 0x04011E5D RID: 73309
		private static IntPtr __StopAndUpdate_NativeFunctionPtr;

		// Token: 0x04011E5E RID: 73310
		private static IntPtr __StartCounting_NativeFunctionPtr;

		// Token: 0x04011E5F RID: 73311
		private static IntPtr __IsRunning_NativeFunctionPtr;

		// Token: 0x04011E60 RID: 73312
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x04011E61 RID: 73313
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04011E62 RID: 73314
		private static IntPtr __GetValidCpuCount_NativeFunctionPtr;

		// Token: 0x04011E63 RID: 73315
		private static IntPtr __GetTotalMips_NativeFunctionPtr;

		// Token: 0x04011E64 RID: 73316
		private static IntPtr __GetTotalMcps_NativeFunctionPtr;

		// Token: 0x04011E65 RID: 73317
		private static IntPtr __GetTotalInstructions_NativeFunctionPtr;

		// Token: 0x04011E66 RID: 73318
		private static IntPtr __GetTotalCycles_NativeFunctionPtr;

		// Token: 0x04011E67 RID: 73319
		private static IntPtr __GetCpuMips_NativeFunctionPtr;

		// Token: 0x04011E68 RID: 73320
		private static IntPtr __GetCpuMcps_NativeFunctionPtr;

		// Token: 0x04011E69 RID: 73321
		private static IntPtr __GetCpuCpi_NativeFunctionPtr;

		// Token: 0x04011E6A RID: 73322
		private static IntPtr __GetAverageMips_NativeFunctionPtr;

		// Token: 0x04011E6B RID: 73323
		private static IntPtr __GetAverageMcps_NativeFunctionPtr;

		// Token: 0x04011E6C RID: 73324
		private static IntPtr __GetAverageCpi_NativeFunctionPtr;

		// Token: 0x04011E6D RID: 73325
		private static IntPtr __GetAllCpuMipsData_NativeFunctionPtr;

		// Token: 0x04011E6E RID: 73326
		private static IntPtr __Cleanup_NativeFunctionPtr;

		// Token: 0x020035B5 RID: 13749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopAndUpdate_FunctionParams
		{
			// Token: 0x040175F6 RID: 95734
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B6 RID: 13750
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StartCounting_FunctionParams
		{
			// Token: 0x040175F7 RID: 95735
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B7 RID: 13751
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRunning_FunctionParams
		{
			// Token: 0x040175F8 RID: 95736
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B8 RID: 13752
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x040175F9 RID: 95737
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B9 RID: 13753
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x040175FA RID: 95738
			[FieldOffset(0)]
			public bool bExcludeKernelSpace;

			// Token: 0x040175FB RID: 95739
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x020035BA RID: 13754
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetValidCpuCount_FunctionParams
		{
			// Token: 0x040175FC RID: 95740
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035BB RID: 13755
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTotalMips_FunctionParams
		{
			// Token: 0x040175FD RID: 95741
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020035BC RID: 13756
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTotalMcps_FunctionParams
		{
			// Token: 0x040175FE RID: 95742
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020035BD RID: 13757
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTotalInstructions_FunctionParams
		{
			// Token: 0x040175FF RID: 95743
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x020035BE RID: 13758
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTotalCycles_FunctionParams
		{
			// Token: 0x04017600 RID: 95744
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x020035BF RID: 13759
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetCpuMips_FunctionParams
		{
			// Token: 0x04017601 RID: 95745
			[FieldOffset(0)]
			public int CpuId;

			// Token: 0x04017602 RID: 95746
			[FieldOffset(4)]
			public float __Result;
		}

		// Token: 0x020035C0 RID: 13760
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetCpuMcps_FunctionParams
		{
			// Token: 0x04017603 RID: 95747
			[FieldOffset(0)]
			public int CpuId;

			// Token: 0x04017604 RID: 95748
			[FieldOffset(4)]
			public float __Result;
		}

		// Token: 0x020035C1 RID: 13761
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetCpuCpi_FunctionParams
		{
			// Token: 0x04017605 RID: 95749
			[FieldOffset(0)]
			public int CpuId;

			// Token: 0x04017606 RID: 95750
			[FieldOffset(4)]
			public float __Result;
		}

		// Token: 0x020035C2 RID: 13762
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAverageMips_FunctionParams
		{
			// Token: 0x04017607 RID: 95751
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020035C3 RID: 13763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAverageMcps_FunctionParams
		{
			// Token: 0x04017608 RID: 95752
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020035C4 RID: 13764
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAverageCpi_FunctionParams
		{
			// Token: 0x04017609 RID: 95753
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020035C5 RID: 13765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllCpuMipsData_FunctionParams
		{
			// Token: 0x0401760A RID: 95754
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
