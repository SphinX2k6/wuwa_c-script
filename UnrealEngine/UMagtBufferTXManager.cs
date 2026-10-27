using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002270 RID: 8816
	[UnrealObjectPath("/Script/MagtModule.MagtBufferTXManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMagtBufferTXManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021828 RID: 137256 RVA: 0x00317F2B File Offset: 0x0031612B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtBufferTXManager._ClassPtr;
		}

		// Token: 0x06021829 RID: 137257 RVA: 0x00317F38 File Offset: 0x00316138
		public UMagtBufferTXManager() : this(BuiltinUtils.AllocNativeUObject(UMagtBufferTXManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602182A RID: 137258 RVA: 0x00317F60 File Offset: 0x00316160
		[NullableContext(1)]
		public UMagtBufferTXManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtBufferTXManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602182B RID: 137259 RVA: 0x00317F94 File Offset: 0x00316194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetBufferTxAvgWindow(int WindowMs)
		{
			UMagtBufferTXManager.__SetBufferTxAvgWindow_FunctionParams* ptr = stackalloc UMagtBufferTXManager.__SetBufferTxAvgWindow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtBufferTXManager.__SetBufferTxAvgWindow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtBufferTXManager.__SetBufferTxAvgWindow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WindowMs = WindowMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtBufferTXManager.__SetBufferTxAvgWindow_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602182C RID: 137260 RVA: 0x00317FE4 File Offset: 0x003161E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetLatestBufferTX()
		{
			UMagtBufferTXManager.__GetLatestBufferTX_FunctionParams* ptr = stackalloc UMagtBufferTXManager.__GetLatestBufferTX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtBufferTXManager.__GetLatestBufferTX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtBufferTXManager.__GetLatestBufferTX_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtBufferTXManager.__GetLatestBufferTX_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602182D RID: 137261 RVA: 0x0031802C File Offset: 0x0031622C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetBufferTxAvg()
		{
			UMagtBufferTXManager.__GetBufferTxAvg_FunctionParams* ptr = stackalloc UMagtBufferTXManager.__GetBufferTxAvg_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtBufferTXManager.__GetBufferTxAvg_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtBufferTXManager.__GetBufferTxAvg_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtBufferTXManager.__GetBufferTxAvg_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602182E RID: 137262 RVA: 0x00318072 File Offset: 0x00316272
		static UMagtBufferTXManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtBufferTXManager");
		}

		// Token: 0x0602182F RID: 137263 RVA: 0x00318080 File Offset: 0x00316280
		protected UMagtBufferTXManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E37 RID: 73271
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtBufferTXManager";

		// Token: 0x04011E38 RID: 73272
		private static IntPtr _ClassPtr;

		// Token: 0x04011E39 RID: 73273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E3A RID: 73274
		private static IntPtr __SetBufferTxAvgWindow_NativeFunctionPtr;

		// Token: 0x04011E3B RID: 73275
		private static IntPtr __GetLatestBufferTX_NativeFunctionPtr;

		// Token: 0x04011E3C RID: 73276
		private static IntPtr __GetBufferTxAvg_NativeFunctionPtr;

		// Token: 0x020035AF RID: 13743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetBufferTxAvgWindow_FunctionParams
		{
			// Token: 0x040175EF RID: 95727
			[FieldOffset(0)]
			public int WindowMs;

			// Token: 0x040175F0 RID: 95728
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035B0 RID: 13744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetLatestBufferTX_FunctionParams
		{
			// Token: 0x040175F1 RID: 95729
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035B1 RID: 13745
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetBufferTxAvg_FunctionParams
		{
			// Token: 0x040175F2 RID: 95730
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
