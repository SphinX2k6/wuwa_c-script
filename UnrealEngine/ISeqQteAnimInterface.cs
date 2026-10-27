using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002710 RID: 10000
	[UnrealObjectPath("/Script/SequenceDialogue.SeqQteAnimInterface")]
	public interface ISeqQteAnimInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06025138 RID: 151864
		int InterfaceOffset();

		// Token: 0x06025139 RID: 151865 RVA: 0x0036E6B0 File Offset: 0x0036C8B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetStateAnimAlpha(float Alpha)
		{
			ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams* ptr = stackalloc ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqQteAnimInterface_ReflectionImplementationFields.__SetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Alpha = Alpha;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqQteAnimInterface_ReflectionImplementationFields.__SetStateAnimAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602513A RID: 151866 RVA: 0x0036E6F8 File Offset: 0x0036C8F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetStateAnimAlpha_Implementation(float Alpha)
		{
			ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams* ptr = stackalloc ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqQteAnimInterface.__SetStateAnimAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqQteAnimInterface_ReflectionImplementationFields.__SetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Alpha = Alpha;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqQteAnimInterface_ReflectionImplementationFields.__SetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602513B RID: 151867 RVA: 0x0036E740 File Offset: 0x0036C940
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float GetStateAnimAlpha()
		{
			ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams* ptr = stackalloc ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqQteAnimInterface_ReflectionImplementationFields.__GetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqQteAnimInterface_ReflectionImplementationFields.__GetStateAnimAlpha_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602513C RID: 151868 RVA: 0x0036E788 File Offset: 0x0036C988
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float GetStateAnimAlpha_Implementation()
		{
			ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams* ptr = stackalloc ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISeqQteAnimInterface.__GetStateAnimAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqQteAnimInterface_ReflectionImplementationFields.__GetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqQteAnimInterface_ReflectionImplementationFields.__GetStateAnimAlpha_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04013F88 RID: 81800
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.SeqQteAnimInterface";

		// Token: 0x020036B7 RID: 14007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetStateAnimAlpha_FunctionParams
		{
			// Token: 0x040177D2 RID: 96210
			[FieldOffset(0)]
			public float Alpha;
		}

		// Token: 0x020036B8 RID: 14008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetStateAnimAlpha_FunctionParams
		{
			// Token: 0x040177D3 RID: 96211
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
