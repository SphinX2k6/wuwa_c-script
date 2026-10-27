using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E4 RID: 9188
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEasingFunction")]
	public interface IMovieSceneEasingFunction : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060227EE RID: 141294
		int InterfaceOffset();

		// Token: 0x060227EF RID: 141295 RVA: 0x00330688 File Offset: 0x0032E888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float OnEvaluate(float Interp)
		{
			IMovieSceneEasingFunction.__OnEvaluate_FunctionParams* ptr = stackalloc IMovieSceneEasingFunction.__OnEvaluate_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IMovieSceneEasingFunction.__OnEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IMovieSceneEasingFunction_ReflectionImplementationFields.__OnEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Interp = Interp;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IMovieSceneEasingFunction_ReflectionImplementationFields.__OnEvaluate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0401270A RID: 75530
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEasingFunction";

		// Token: 0x02003651 RID: 13905
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnEvaluate_FunctionParams
		{
			// Token: 0x0401771E RID: 96030
			[FieldOffset(0)]
			public float Interp;

			// Token: 0x0401771F RID: 96031
			[FieldOffset(4)]
			public float __Result;
		}
	}
}
