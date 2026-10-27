using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023B2 RID: 9138
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneTransformOrigin")]
	public interface IMovieSceneTransformOrigin : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06022678 RID: 140920
		int InterfaceOffset();

		// Token: 0x06022679 RID: 140921 RVA: 0x0032E224 File Offset: 0x0032C424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FTransform BP_GetTransformOrigin()
		{
			IMovieSceneTransformOrigin.__BP_GetTransformOrigin_FunctionParams* ptr = stackalloc IMovieSceneTransformOrigin.__BP_GetTransformOrigin_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IMovieSceneTransformOrigin.__BP_GetTransformOrigin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneTransformOrigin_ReflectionImplementationFields.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IMovieSceneTransformOrigin_ReflectionImplementationFields.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x040125DE RID: 75230
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneTransformOrigin";

		// Token: 0x0200364C RID: 13900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __BP_GetTransformOrigin_FunctionParams
		{
			// Token: 0x04017716 RID: 96022
			[FieldOffset(0)]
			public FTransform __Result;
		}
	}
}
