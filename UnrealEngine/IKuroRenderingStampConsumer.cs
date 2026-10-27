using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA0 RID: 7072
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingStampConsumer")]
	public interface IKuroRenderingStampConsumer : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601B0C7 RID: 110791
		int InterfaceOffset();

		// Token: 0x0601B0C8 RID: 110792 RVA: 0x0027D8C4 File Offset: 0x0027BAC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void UpdateStampData(UKuroStampData InStampData)
		{
			IKuroRenderingStampConsumer.__UpdateStampData_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__UpdateStampData_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__UpdateStampData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__UpdateStampData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStampData = ((InStampData != null) ? InStampData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__UpdateStampData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0C9 RID: 110793 RVA: 0x0027D91C File Offset: 0x0027BB1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetRenderTargetWorldRadius(float InRadius)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldRadius_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRadius = InRadius;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldRadius_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CA RID: 110794 RVA: 0x0027D964 File Offset: 0x0027BB64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldCenter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InCenter = InCenter;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldCenter_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CB RID: 110795 RVA: 0x0027D9B0 File Offset: 0x0027BBB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetRenderTargetSize(int InSizeX, int InSizeY)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSizeX = InSizeX;
			ptr->InSizeY = InSizeY;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetSize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CC RID: 110796 RVA: 0x0027DA00 File Offset: 0x0027BC00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetRenderTarget(UTextureRenderTarget2D InRenderTarget)
		{
			IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRenderTarget = ((InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTarget_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CD RID: 110797 RVA: 0x0027DA58 File Offset: 0x0027BC58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetClearColor(in FLinearColor InClearColor)
		{
			IKuroRenderingStampConsumer.__SetClearColor_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetClearColor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetClearColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetClearColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InClearColor = InClearColor;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetClearColor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CE RID: 110798 RVA: 0x0027DAA4 File Offset: 0x0027BCA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetAutoFadeEnabled(bool bEnabled, float Duration = 1f)
		{
			IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetAutoFadeEnabled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			ptr->Duration = Duration;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetAutoFadeEnabled_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B0CF RID: 110799 RVA: 0x0027DAF2 File Offset: 0x0027BCF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void InitializeWithCurrentValues()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__InitializeWithCurrentValues_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B0D0 RID: 110800 RVA: 0x0027DB07 File Offset: 0x0027BD07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void DrawOnce()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__DrawOnce_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B0D1 RID: 110801 RVA: 0x0027DB1C File Offset: 0x0027BD1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void ClearRT()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__ClearRT_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0400E904 RID: 59652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingStampConsumer";

		// Token: 0x0200316B RID: 12651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateStampData_FunctionParams
		{
			// Token: 0x04016F98 RID: 94104
			[FieldOffset(0)]
			public IntPtr InStampData;
		}

		// Token: 0x0200316C RID: 12652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetRenderTargetWorldRadius_FunctionParams
		{
			// Token: 0x04016F99 RID: 94105
			[FieldOffset(0)]
			public float InRadius;
		}

		// Token: 0x0200316D RID: 12653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetRenderTargetWorldCenter_FunctionParams
		{
			// Token: 0x04016F9A RID: 94106
			[FieldOffset(0)]
			public FVectorDouble InCenter;
		}

		// Token: 0x0200316E RID: 12654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRenderTargetSize_FunctionParams
		{
			// Token: 0x04016F9B RID: 94107
			[FieldOffset(0)]
			public int InSizeX;

			// Token: 0x04016F9C RID: 94108
			[FieldOffset(4)]
			public int InSizeY;
		}

		// Token: 0x0200316F RID: 12655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRenderTarget_FunctionParams
		{
			// Token: 0x04016F9D RID: 94109
			[FieldOffset(0)]
			public IntPtr InRenderTarget;
		}

		// Token: 0x02003170 RID: 12656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClearColor_FunctionParams
		{
			// Token: 0x04016F9E RID: 94110
			[FieldOffset(0)]
			public FLinearColor InClearColor;
		}

		// Token: 0x02003171 RID: 12657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetAutoFadeEnabled_FunctionParams
		{
			// Token: 0x04016F9F RID: 94111
			[FieldOffset(0)]
			public bool bEnabled;

			// Token: 0x04016FA0 RID: 94112
			[FieldOffset(4)]
			public float Duration;
		}
	}
}
