using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000981 RID: 2433
	[UnrealObjectPath("/Script/Engine.CurveSourceInterface")]
	public interface ICurveSourceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060089A1 RID: 35233
		int InterfaceOffset();

		// Token: 0x060089A2 RID: 35234 RVA: 0x000C51D4 File Offset: 0x000C33D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float GetCurveValue(FName CurveName)
		{
			ICurveSourceInterface.__GetCurveValue_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveSourceInterface.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetCurveValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x000C5220 File Offset: 0x000C3420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float GetCurveValue_Implementation(FName CurveName)
		{
			ICurveSourceInterface.__GetCurveValue_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveSourceInterface.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x000C5270 File Offset: 0x000C3470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurves([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveSourceInterface.__GetCurves_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveSourceInterface.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x000C52E8 File Offset: 0x000C34E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurves_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			ICurveSourceInterface.__GetCurves_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ICurveSourceInterface.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x000C5364 File Offset: 0x000C3564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FName GetBindingName()
		{
			ICurveSourceInterface.__GetBindingName_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ICurveSourceInterface.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetBindingName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x000C53AC File Offset: 0x000C35AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FName GetBindingName_Implementation()
		{
			ICurveSourceInterface.__GetBindingName_FunctionParams* ptr = stackalloc ICurveSourceInterface.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ICurveSourceInterface.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ICurveSourceInterface_ReflectionImplementationFields.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ICurveSourceInterface_ReflectionImplementationFields.__GetBindingName_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400415E RID: 16734
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CurveSourceInterface";

		// Token: 0x02002CE6 RID: 11494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurveValue_FunctionParams
		{
			// Token: 0x04016697 RID: 91799
			[FieldOffset(0)]
			public FName CurveName;

			// Token: 0x04016698 RID: 91800
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x02002CE7 RID: 11495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurves_FunctionParams
		{
			// Token: 0x04016699 RID: 91801
			[FieldOffset(0)]
			public byte OutValues;
		}

		// Token: 0x02002CE8 RID: 11496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetBindingName_FunctionParams
		{
			// Token: 0x0401669A RID: 91802
			[FieldOffset(0)]
			public FName __Result;
		}
	}
}
