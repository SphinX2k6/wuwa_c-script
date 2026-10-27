using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025CD RID: 9677
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNiagaraPreviewAxis : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F84 RID: 147332 RVA: 0x0035334B File Offset: 0x0035154B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis._ClassPtr;
		}

		// Token: 0x06023F85 RID: 147333 RVA: 0x00353358 File Offset: 0x00351558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int Num()
		{
			UNiagaraPreviewAxis.__Num_FunctionParams* ptr = stackalloc UNiagaraPreviewAxis.__Num_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UNiagaraPreviewAxis.__Num_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraPreviewAxis.__Num_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UNiagaraPreviewAxis.__Num_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06023F86 RID: 147334 RVA: 0x003533A0 File Offset: 0x003515A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int Num_Implementation()
		{
			UNiagaraPreviewAxis.__Num_FunctionParams* ptr = stackalloc UNiagaraPreviewAxis.__Num_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UNiagaraPreviewAxis.__Num_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraPreviewAxis.__Num_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UNiagaraPreviewAxis.__Num_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06023F87 RID: 147335 RVA: 0x003533E8 File Offset: 0x003515E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyToPreview([Nullable(2)] UNiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, ref string OutLabelText)
		{
			UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams* ptr = stackalloc UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PreviewComponent = ((PreviewComponent != null) ? PreviewComponent.NativePtr : IntPtr.Zero);
			ptr->PreviewIndex = PreviewIndex;
			ptr->bIsXAxis = bIsXAxis;
			FString.CopyFrom((void*)(&ptr->OutLabelText), OutLabelText);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr);
			OutLabelText = FString.ToString((void*)(&ptr->OutLabelText));
			UnrealReflectionUtils.DestroyStruct(UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023F88 RID: 147336 RVA: 0x0035347C File Offset: 0x0035167C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyToPreview_Implementation([Nullable(2)] UNiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, ref string OutLabelText)
		{
			UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams* ptr = stackalloc UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UNiagaraPreviewAxis.__ApplyToPreview_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PreviewComponent = ((PreviewComponent != null) ? PreviewComponent.NativePtr : IntPtr.Zero);
			ptr->PreviewIndex = PreviewIndex;
			ptr->bIsXAxis = bIsXAxis;
			FString.CopyFrom((void*)(&ptr->OutLabelText), OutLabelText);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr, 0);
			OutLabelText = FString.ToString((void*)(&ptr->OutLabelText));
			UnrealReflectionUtils.DestroyStruct(UNiagaraPreviewAxis.__ApplyToPreview_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023F89 RID: 147337 RVA: 0x0035350F File Offset: 0x0035170F
		static UNiagaraPreviewAxis()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis");
		}

		// Token: 0x06023F8A RID: 147338 RVA: 0x00353520 File Offset: 0x00351720
		protected UNiagaraPreviewAxis() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F8B RID: 147339 RVA: 0x00353548 File Offset: 0x00351748
		protected UNiagaraPreviewAxis(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401348D RID: 78989
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis";

		// Token: 0x0401348E RID: 78990
		private static IntPtr _ClassPtr;

		// Token: 0x0401348F RID: 78991
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013490 RID: 78992
		private static IntPtr __Num_NativeFunctionPtr;

		// Token: 0x04013491 RID: 78993
		private static IntPtr __ApplyToPreview_NativeFunctionPtr;

		// Token: 0x02003670 RID: 13936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Num_FunctionParams
		{
			// Token: 0x04017743 RID: 96067
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003671 RID: 13937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ApplyToPreview_FunctionParams
		{
			// Token: 0x04017744 RID: 96068
			[FieldOffset(0)]
			public IntPtr PreviewComponent;

			// Token: 0x04017745 RID: 96069
			[FieldOffset(8)]
			public int PreviewIndex;

			// Token: 0x04017746 RID: 96070
			[FieldOffset(12)]
			public bool bIsXAxis;

			// Token: 0x04017747 RID: 96071
			[FieldOffset(16)]
			public FString OutLabelText;
		}
	}
}
