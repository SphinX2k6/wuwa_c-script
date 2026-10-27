using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200270F RID: 9999
	[UnrealObjectPath("/Script/SequenceDialogue.SeqAutoTransformInterface")]
	public interface ISeqAutoTransformInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06025133 RID: 151859
		int InterfaceOffset();

		// Token: 0x06025134 RID: 151860 RVA: 0x0036E5F6 File Offset: 0x0036C7F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EndAutoTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAutoTransformInterface_ReflectionImplementationFields.__EndAutoTransform_NativeFunctionPtr, null);
		}

		// Token: 0x06025135 RID: 151861 RVA: 0x0036E60A File Offset: 0x0036C80A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EndAutoTransform_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAutoTransformInterface_ReflectionImplementationFields.__EndAutoTransform_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025136 RID: 151862 RVA: 0x0036E620 File Offset: 0x0036C820
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BeginAutoTransform(float TimeLength)
		{
			ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams* ptr = stackalloc ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAutoTransformInterface_ReflectionImplementationFields.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAutoTransformInterface_ReflectionImplementationFields.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025137 RID: 151863 RVA: 0x0036E668 File Offset: 0x0036C868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BeginAutoTransform_Implementation(float TimeLength)
		{
			ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams* ptr = stackalloc ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqAutoTransformInterface.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAutoTransformInterface_ReflectionImplementationFields.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAutoTransformInterface_ReflectionImplementationFields.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x04013F87 RID: 81799
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.SeqAutoTransformInterface";

		// Token: 0x020036B6 RID: 14006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BeginAutoTransform_FunctionParams
		{
			// Token: 0x040177D1 RID: 96209
			[FieldOffset(0)]
			public float TimeLength;
		}
	}
}
