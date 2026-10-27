using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200097C RID: 2428
	[UnrealObjectPath("/Script/Engine.CurveFaceInterface")]
	public interface ICurveFaceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06008962 RID: 35170
		int InterfaceOffset();

		// Token: 0x06008963 RID: 35171 RVA: 0x000C4B34 File Offset: 0x000C2D34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurvesB([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveFaceInterface.__GetCurvesB_FunctionParams* ptr = stackalloc ICurveFaceInterface.__GetCurvesB_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveFaceInterface.__GetCurvesB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x000C4BAC File Offset: 0x000C2DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurvesB_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveFaceInterface.__GetCurvesB_FunctionParams* ptr = stackalloc ICurveFaceInterface.__GetCurvesB_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveFaceInterface.__GetCurvesB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesB_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x000C4C28 File Offset: 0x000C2E28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurvesA([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveFaceInterface.__GetCurvesA_FunctionParams* ptr = stackalloc ICurveFaceInterface.__GetCurvesA_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveFaceInterface.__GetCurvesA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x000C4CA0 File Offset: 0x000C2EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurvesA_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveFaceInterface.__GetCurvesA_FunctionParams* ptr = stackalloc ICurveFaceInterface.__GetCurvesA_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveFaceInterface.__GetCurvesA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveFaceInterface_ReflectionImplementationFields.__GetCurvesA_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x04004140 RID: 16704
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CurveFaceInterface";

		// Token: 0x02002CE4 RID: 11492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurvesB_FunctionParams
		{
			// Token: 0x04016695 RID: 91797
			[FieldOffset(0)]
			public byte OutValues;
		}

		// Token: 0x02002CE5 RID: 11493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurvesA_FunctionParams
		{
			// Token: 0x04016696 RID: 91798
			[FieldOffset(0)]
			public byte OutValues;
		}
	}
}
