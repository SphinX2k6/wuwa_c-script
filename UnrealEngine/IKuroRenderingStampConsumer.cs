using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DC RID: 1244
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingStampConsumer")]
	public interface IKuroRenderingStampConsumer : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060075B3 RID: 30131
		int InterfaceOffset();

		// Token: 0x060075B4 RID: 30132 RVA: 0x000ABF74 File Offset: 0x000AA174
		[SkipLocalsInit]
		unsafe void SetRenderTargetWorldRadius(float InRadius)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetWorldRadius_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldRadius_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRadius = InRadius;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldRadius_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x000ABFBC File Offset: 0x000AA1BC
		[SkipLocalsInit]
		unsafe void SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetWorldCenter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldCenter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InCenter = InCenter;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetWorldCenter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x000AC008 File Offset: 0x000AA208
		[SkipLocalsInit]
		unsafe void SetRenderTargetSize(int InSizeX, int InSizeY)
		{
			IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTargetSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSizeX = InSizeX;
			ptr->InSizeY = InSizeY;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTargetSize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x000AC058 File Offset: 0x000AA258
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void SetRenderTarget(UTextureRenderTarget2D InRenderTarget)
		{
			IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRenderTarget = ((InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetRenderTarget_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x000AC0B0 File Offset: 0x000AA2B0
		[SkipLocalsInit]
		unsafe void SetClearColor(in FLinearColor InClearColor)
		{
			IKuroRenderingStampConsumer.__SetClearColor_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetClearColor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetClearColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetClearColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InClearColor = InClearColor;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetClearColor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x000AC0FC File Offset: 0x000AA2FC
		[SkipLocalsInit]
		unsafe void SetAutoFadeEnabled(bool bEnabled, float Duration = 1f)
		{
			IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams* ptr = stackalloc IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroRenderingStampConsumer.__SetAutoFadeEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetAutoFadeEnabled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			ptr->Duration = Duration;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__SetAutoFadeEnabled_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x000AC149 File Offset: 0x000AA349
		[SkipLocalsInit]
		void InitializeWithCurrentValues()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__InitializeWithCurrentValues_NativeFunctionPtr, null);
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x000AC15D File Offset: 0x000AA35D
		[SkipLocalsInit]
		void DrawOnce()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__DrawOnce_NativeFunctionPtr, null);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x000AC171 File Offset: 0x000AA371
		[SkipLocalsInit]
		void ClearRT()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroRenderingStampConsumer_ReflectionImplementationFields.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x040031A8 RID: 12712
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingStampConsumer";

		// Token: 0x02000C19 RID: 3097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetRenderTargetWorldRadius_FunctionParams
		{
			// Token: 0x04005E5E RID: 24158
			[FieldOffset(0)]
			public float InRadius;
		}

		// Token: 0x02000C1A RID: 3098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetRenderTargetWorldCenter_FunctionParams
		{
			// Token: 0x04005E5F RID: 24159
			[FieldOffset(0)]
			public FVectorDouble InCenter;
		}

		// Token: 0x02000C1B RID: 3099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRenderTargetSize_FunctionParams
		{
			// Token: 0x04005E60 RID: 24160
			[FieldOffset(0)]
			public int InSizeX;

			// Token: 0x04005E61 RID: 24161
			[FieldOffset(4)]
			public int InSizeY;
		}

		// Token: 0x02000C1C RID: 3100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRenderTarget_FunctionParams
		{
			// Token: 0x04005E62 RID: 24162
			[FieldOffset(0)]
			public IntPtr InRenderTarget;
		}

		// Token: 0x02000C1D RID: 3101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClearColor_FunctionParams
		{
			// Token: 0x04005E63 RID: 24163
			[FieldOffset(0)]
			public FLinearColor InClearColor;
		}

		// Token: 0x02000C1E RID: 3102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetAutoFadeEnabled_FunctionParams
		{
			// Token: 0x04005E64 RID: 24164
			[FieldOffset(0)]
			public bool bEnabled;

			// Token: 0x04005E65 RID: 24165
			[FieldOffset(4)]
			public float Duration;
		}
	}
}
