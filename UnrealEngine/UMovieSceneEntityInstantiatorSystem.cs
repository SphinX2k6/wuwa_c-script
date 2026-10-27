using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023EA RID: 9194
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntityInstantiatorSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UMovieSceneEntityInstantiatorSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022849 RID: 141385 RVA: 0x00330FC6 File Offset: 0x0032F1C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEntityInstantiatorSystem._ClassPtr;
		}

		// Token: 0x0602284A RID: 141386 RVA: 0x00330FD2 File Offset: 0x0032F1D2
		static UMovieSceneEntityInstantiatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneEntityInstantiatorSystem");
		}

		// Token: 0x0602284B RID: 141387 RVA: 0x00330FE0 File Offset: 0x0032F1E0
		protected UMovieSceneEntityInstantiatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEntityInstantiatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602284C RID: 141388 RVA: 0x00331008 File Offset: 0x0032F208
		protected UMovieSceneEntityInstantiatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012739 RID: 75577
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEntityInstantiatorSystem";

		// Token: 0x0401273A RID: 75578
		private static IntPtr _ClassPtr;

		// Token: 0x0401273B RID: 75579
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
