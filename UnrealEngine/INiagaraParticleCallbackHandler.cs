using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025C7 RID: 9671
	[UnrealObjectPath("/Script/Niagara.NiagaraParticleCallbackHandler")]
	public interface INiagaraParticleCallbackHandler : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06023F34 RID: 147252
		int InterfaceOffset();

		// Token: 0x06023F35 RID: 147253 RVA: 0x00352B78 File Offset: 0x00350D78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams* ptr = stackalloc INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023F36 RID: 147254 RVA: 0x00352C08 File Offset: 0x00350E08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams* ptr = stackalloc INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(INiagaraParticleCallbackHandler.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(INiagaraParticleCallbackHandler_ReflectionImplementationFields.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x04013465 RID: 78949
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraParticleCallbackHandler";

		// Token: 0x0200366F RID: 13935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x04017741 RID: 96065
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x04017742 RID: 96066
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}
	}
}
