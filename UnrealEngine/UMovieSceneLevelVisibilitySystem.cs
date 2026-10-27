using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002386 RID: 9094
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySystem")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UMovieSceneLevelVisibilitySystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject, IMovieScenePreAnimatedStateSystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602248C RID: 140428 RVA: 0x0032B385 File Offset: 0x00329585
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneLevelVisibilitySystem._ClassPtr;
		}

		// Token: 0x0602248D RID: 140429 RVA: 0x0032B391 File Offset: 0x00329591
		int IMovieScenePreAnimatedStateSystemInterface.InterfaceOffset()
		{
			return UMovieSceneLevelVisibilitySystem.__InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;
		}

		// Token: 0x0602248E RID: 140430 RVA: 0x0032B398 File Offset: 0x00329598
		public UMovieSceneLevelVisibilitySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilitySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602248F RID: 140431 RVA: 0x0032B3C0 File Offset: 0x003295C0
		[NullableContext(1)]
		public UMovieSceneLevelVisibilitySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilitySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022490 RID: 140432 RVA: 0x0032B3F3 File Offset: 0x003295F3
		static UMovieSceneLevelVisibilitySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneLevelVisibilitySystem");
		}

		// Token: 0x06022491 RID: 140433 RVA: 0x0032B401 File Offset: 0x00329601
		protected UMovieSceneLevelVisibilitySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124D6 RID: 74966
		internal static int __InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;

		// Token: 0x040124D7 RID: 74967
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneLevelVisibilitySystem";

		// Token: 0x040124D8 RID: 74968
		private static IntPtr _ClassPtr;

		// Token: 0x040124D9 RID: 74969
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
