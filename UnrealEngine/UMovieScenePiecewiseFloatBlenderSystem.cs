using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002398 RID: 9112
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePiecewiseFloatBlenderSystem")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieScenePiecewiseFloatBlenderSystem : UMovieSceneBlenderSystem, IUnrealUObject, IUnrealObject, IMovieSceneFloatDecomposer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022557 RID: 140631 RVA: 0x0032C69A File Offset: 0x0032A89A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePiecewiseFloatBlenderSystem._ClassPtr;
		}

		// Token: 0x06022558 RID: 140632 RVA: 0x0032C6A6 File Offset: 0x0032A8A6
		int IMovieSceneFloatDecomposer.InterfaceOffset()
		{
			return UMovieScenePiecewiseFloatBlenderSystem.__InterfaceOffset_IMovieSceneFloatDecomposer;
		}

		// Token: 0x06022559 RID: 140633 RVA: 0x0032C6B0 File Offset: 0x0032A8B0
		public UMovieScenePiecewiseFloatBlenderSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePiecewiseFloatBlenderSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602255A RID: 140634 RVA: 0x0032C6D8 File Offset: 0x0032A8D8
		[NullableContext(1)]
		public UMovieScenePiecewiseFloatBlenderSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePiecewiseFloatBlenderSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602255B RID: 140635 RVA: 0x0032C70B File Offset: 0x0032A90B
		static UMovieScenePiecewiseFloatBlenderSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePiecewiseFloatBlenderSystem");
		}

		// Token: 0x0602255C RID: 140636 RVA: 0x0032C719 File Offset: 0x0032A919
		protected UMovieScenePiecewiseFloatBlenderSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401253C RID: 75068
		internal static int __InterfaceOffset_IMovieSceneFloatDecomposer;

		// Token: 0x0401253D RID: 75069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePiecewiseFloatBlenderSystem";

		// Token: 0x0401253E RID: 75070
		private static IntPtr _ClassPtr;

		// Token: 0x0401253F RID: 75071
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
