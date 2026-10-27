using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D5 RID: 9685
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewBase")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public abstract class ANiagaraPreviewBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FCA RID: 147402 RVA: 0x00353AAC File Offset: 0x00351CAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANiagaraPreviewBase._ClassPtr;
		}

		// Token: 0x06023FCB RID: 147403 RVA: 0x00353AB8 File Offset: 0x00351CB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSystem(UNiagaraSystem InSystem)
		{
			ANiagaraPreviewBase.__SetSystem_FunctionParams* ptr = stackalloc ANiagaraPreviewBase.__SetSystem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ANiagaraPreviewBase.__SetSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraPreviewBase.__SetSystem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSystem = ((InSystem != null) ? InSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANiagaraPreviewBase.__SetSystem_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023FCC RID: 147404 RVA: 0x00353B10 File Offset: 0x00351D10
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLabelText(in FText InXAxisText, in FText InYAxisText)
		{
			ANiagaraPreviewBase.__SetLabelText_FunctionParams* ptr = stackalloc ANiagaraPreviewBase.__SetLabelText_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ANiagaraPreviewBase.__SetLabelText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraPreviewBase.__SetLabelText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->InXAxisText), InXAxisText.NativePtr);
			FText.NativeMove((void*)(&ptr->InYAxisText), InYAxisText.NativePtr);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANiagaraPreviewBase.__SetLabelText_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ANiagaraPreviewBase.__SetLabelText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023FCD RID: 147405 RVA: 0x00353B86 File Offset: 0x00351D86
		static ANiagaraPreviewBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewBase");
		}

		// Token: 0x06023FCE RID: 147406 RVA: 0x00353B94 File Offset: 0x00351D94
		protected ANiagaraPreviewBase() : this(BuiltinUtils.AllocNativeUObject(ANiagaraPreviewBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FCF RID: 147407 RVA: 0x00353BBC File Offset: 0x00351DBC
		protected ANiagaraPreviewBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134B5 RID: 79029
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewBase";

		// Token: 0x040134B6 RID: 79030
		private static IntPtr _ClassPtr;

		// Token: 0x040134B7 RID: 79031
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134B8 RID: 79032
		private static IntPtr __SetSystem_NativeFunctionPtr;

		// Token: 0x040134B9 RID: 79033
		private static IntPtr __SetLabelText_NativeFunctionPtr;

		// Token: 0x02003672 RID: 13938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSystem_FunctionParams
		{
			// Token: 0x04017748 RID: 96072
			[FieldOffset(0)]
			public IntPtr InSystem;
		}

		// Token: 0x02003673 RID: 13939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetLabelText_FunctionParams
		{
			// Token: 0x04017749 RID: 96073
			[FieldOffset(0)]
			public byte InXAxisText;

			// Token: 0x0401774A RID: 96074
			[FieldOffset(24)]
			public byte InYAxisText;
		}
	}
}
