using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E2 RID: 9186
	[UnrealObjectPath("/Script/MovieScene.MovieSceneCustomClockSource")]
	public interface IMovieSceneCustomClockSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060227E1 RID: 141281
		int InterfaceOffset();

		// Token: 0x060227E2 RID: 141282 RVA: 0x00330448 File Offset: 0x0032E648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnTick(float DeltaSeconds, float InPlayRate)
		{
			IMovieSceneCustomClockSource.__OnTick_FunctionParams* ptr = stackalloc IMovieSceneCustomClockSource.__OnTick_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IMovieSceneCustomClockSource.__OnTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->InPlayRate = InPlayRate;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060227E3 RID: 141283 RVA: 0x00330498 File Offset: 0x0032E698
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnStopPlaying(in FQualifiedFrameTime InStopTime)
		{
			IMovieSceneCustomClockSource.__OnStopPlaying_FunctionParams* ptr = stackalloc IMovieSceneCustomClockSource.__OnStopPlaying_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IMovieSceneCustomClockSource.__OnStopPlaying_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnStopPlaying_NativeFunctionPtr, (void*)ptr, 1);
			if (InStopTime != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), &ptr->InStopTime, InStopTime.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnStopPlaying_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060227E4 RID: 141284 RVA: 0x003304FC File Offset: 0x0032E6FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnStartPlaying(in FQualifiedFrameTime InStartTime)
		{
			IMovieSceneCustomClockSource.__OnStartPlaying_FunctionParams* ptr = stackalloc IMovieSceneCustomClockSource.__OnStartPlaying_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IMovieSceneCustomClockSource.__OnStartPlaying_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnStartPlaying_NativeFunctionPtr, (void*)ptr, 1);
			if (InStartTime != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), &ptr->InStartTime, InStartTime.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnStartPlaying_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060227E5 RID: 141285 RVA: 0x00330560 File Offset: 0x0032E760
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FFrameTime OnRequestCurrentTime([Nullable(2)] in FQualifiedFrameTime InCurrentTime, float InPlayRate)
		{
			IMovieSceneCustomClockSource.__OnRequestCurrentTime_FunctionParams* ptr = stackalloc IMovieSceneCustomClockSource.__OnRequestCurrentTime_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(IMovieSceneCustomClockSource.__OnRequestCurrentTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnRequestCurrentTime_NativeFunctionPtr, (void*)ptr, 1);
			if (InCurrentTime != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), &ptr->InCurrentTime, InCurrentTime.NativePtr, 1, false);
			}
			ptr->InPlayRate = InPlayRate;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IMovieSceneCustomClockSource_ReflectionImplementationFields.__OnRequestCurrentTime_NativeFunctionPtr, (void*)ptr, 0);
			return new FFrameTime(&ptr->__Result, true, true);
		}

		// Token: 0x04012704 RID: 75524
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneCustomClockSource";

		// Token: 0x0200364D RID: 13901
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnTick_FunctionParams
		{
			// Token: 0x04017717 RID: 96023
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04017718 RID: 96024
			[FieldOffset(4)]
			public float InPlayRate;
		}

		// Token: 0x0200364E RID: 13902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStopPlaying_FunctionParams
		{
			// Token: 0x04017719 RID: 96025
			[FieldOffset(0)]
			public byte InStopTime;
		}

		// Token: 0x0200364F RID: 13903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStartPlaying_FunctionParams
		{
			// Token: 0x0401771A RID: 96026
			[FieldOffset(0)]
			public byte InStartTime;
		}

		// Token: 0x02003650 RID: 13904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __OnRequestCurrentTime_FunctionParams
		{
			// Token: 0x0401771B RID: 96027
			[FieldOffset(0)]
			public byte InCurrentTime;

			// Token: 0x0401771C RID: 96028
			[FieldOffset(16)]
			public float InPlayRate;

			// Token: 0x0401771D RID: 96029
			[FieldOffset(20)]
			public byte __Result;
		}
	}
}
