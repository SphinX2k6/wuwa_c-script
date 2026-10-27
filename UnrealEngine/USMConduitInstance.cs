using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002881 RID: 10369
	[UnrealObjectPath("/Script/SMSystem.SMConduitInstance")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class USMConduitInstance : USMStateInstance_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026615 RID: 157205 RVA: 0x003A5520 File Offset: 0x003A3720
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMConduitInstance._ClassPtr;
		}

		// Token: 0x06026616 RID: 157206 RVA: 0x003A552C File Offset: 0x003A372C
		public USMConduitInstance() : this(BuiltinUtils.AllocNativeUObject(USMConduitInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026617 RID: 157207 RVA: 0x003A5554 File Offset: 0x003A3754
		[NullableContext(1)]
		public USMConduitInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMConduitInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026618 RID: 157208 RVA: 0x003A5588 File Offset: 0x003A3788
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEvalWithTransitions(bool bValue)
		{
			USMConduitInstance.__SetEvalWithTransitions_FunctionParams* ptr = stackalloc USMConduitInstance.__SetEvalWithTransitions_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMConduitInstance.__SetEvalWithTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMConduitInstance.__SetEvalWithTransitions_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMConduitInstance.__SetEvalWithTransitions_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026619 RID: 157209 RVA: 0x003A55D0 File Offset: 0x003A37D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanEvaluate(bool bValue)
		{
			USMConduitInstance.__SetCanEvaluate_FunctionParams* ptr = stackalloc USMConduitInstance.__SetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMConduitInstance.__SetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMConduitInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMConduitInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602661A RID: 157210 RVA: 0x003A5618 File Offset: 0x003A3818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetEvalWithTransitions()
		{
			USMConduitInstance.__GetEvalWithTransitions_FunctionParams* ptr = stackalloc USMConduitInstance.__GetEvalWithTransitions_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMConduitInstance.__GetEvalWithTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMConduitInstance.__GetEvalWithTransitions_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMConduitInstance.__GetEvalWithTransitions_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602661B RID: 157211 RVA: 0x003A5660 File Offset: 0x003A3860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetCanEvaluate()
		{
			USMConduitInstance.__GetCanEvaluate_FunctionParams* ptr = stackalloc USMConduitInstance.__GetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMConduitInstance.__GetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMConduitInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMConduitInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602661C RID: 157212 RVA: 0x003A56A6 File Offset: 0x003A38A6
		static USMConduitInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMConduitInstance");
		}

		// Token: 0x0602661D RID: 157213 RVA: 0x003A56B4 File Offset: 0x003A38B4
		protected USMConduitInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150CC RID: 86220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMConduitInstance";

		// Token: 0x040150CD RID: 86221
		private static IntPtr _ClassPtr;

		// Token: 0x040150CE RID: 86222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150CF RID: 86223
		private static IntPtr __SetEvalWithTransitions_NativeFunctionPtr;

		// Token: 0x040150D0 RID: 86224
		private static IntPtr __SetCanEvaluate_NativeFunctionPtr;

		// Token: 0x040150D1 RID: 86225
		private static IntPtr __GetEvalWithTransitions_NativeFunctionPtr;

		// Token: 0x040150D2 RID: 86226
		private static IntPtr __GetCanEvaluate_NativeFunctionPtr;

		// Token: 0x02003A7E RID: 14974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEvalWithTransitions_FunctionParams
		{
			// Token: 0x04017BEB RID: 97259
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003A7F RID: 14975
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvaluate_FunctionParams
		{
			// Token: 0x04017BEC RID: 97260
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003A80 RID: 14976
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEvalWithTransitions_FunctionParams
		{
			// Token: 0x04017BED RID: 97261
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003A81 RID: 14977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvaluate_FunctionParams
		{
			// Token: 0x04017BEE RID: 97262
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
