using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F9 RID: 6393
	[UnrealObjectPath("/Script/KuroGameplay.KuroMp4PlayerPreviewable")]
	public interface IKuroMp4PlayerPreviewable : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06017B7F RID: 97151
		int InterfaceOffset();

		// Token: 0x06017B80 RID: 97152 RVA: 0x0022C13C File Offset: 0x0022A33C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void OnMp4StopRequested()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroMp4PlayerPreviewable_ReflectionImplementationFields.__OnMp4StopRequested_NativeFunctionPtr, null);
		}

		// Token: 0x06017B81 RID: 97153 RVA: 0x0022C150 File Offset: 0x0022A350
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnMp4PlayRequested(UMediaPlayer InPlayer, UMediaTexture InTexture)
		{
			IKuroMp4PlayerPreviewable.__OnMp4PlayRequested_FunctionParams* ptr = stackalloc IKuroMp4PlayerPreviewable.__OnMp4PlayRequested_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKuroMp4PlayerPreviewable.__OnMp4PlayRequested_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroMp4PlayerPreviewable_ReflectionImplementationFields.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPlayer = ((InPlayer != null) ? InPlayer.NativePtr : IntPtr.Zero);
			ptr->InTexture = ((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroMp4PlayerPreviewable_ReflectionImplementationFields.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400CE01 RID: 52737
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroMp4PlayerPreviewable";

		// Token: 0x02002FD9 RID: 12249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMp4PlayRequested_FunctionParams
		{
			// Token: 0x04016BC9 RID: 93129
			[FieldOffset(0)]
			public IntPtr InPlayer;

			// Token: 0x04016BCA RID: 93130
			[FieldOffset(8)]
			public IntPtr InTexture;
		}
	}
}
