using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023DE RID: 9182
	[UnrealObjectPath("/Script/MovieScene.MovieSceneCachePreAnimatedStateSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneCachePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060227AF RID: 141231 RVA: 0x0032FE63 File Offset: 0x0032E063
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCachePreAnimatedStateSystem._ClassPtr;
		}

		// Token: 0x060227B0 RID: 141232 RVA: 0x0032FE70 File Offset: 0x0032E070
		public UMovieSceneCachePreAnimatedStateSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCachePreAnimatedStateSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060227B1 RID: 141233 RVA: 0x0032FE98 File Offset: 0x0032E098
		[NullableContext(1)]
		public UMovieSceneCachePreAnimatedStateSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCachePreAnimatedStateSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060227B2 RID: 141234 RVA: 0x0032FECB File Offset: 0x0032E0CB
		static UMovieSceneCachePreAnimatedStateSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneCachePreAnimatedStateSystem");
		}

		// Token: 0x060227B3 RID: 141235 RVA: 0x0032FED9 File Offset: 0x0032E0D9
		protected UMovieSceneCachePreAnimatedStateSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126E0 RID: 75488
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneCachePreAnimatedStateSystem";

		// Token: 0x040126E1 RID: 75489
		private static IntPtr _ClassPtr;

		// Token: 0x040126E2 RID: 75490
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
