using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239A RID: 9114
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePostSpawnEventSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieScenePostSpawnEventSystem : UMovieSceneEventSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022562 RID: 140642 RVA: 0x0032C7A2 File Offset: 0x0032A9A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePostSpawnEventSystem._ClassPtr;
		}

		// Token: 0x06022563 RID: 140643 RVA: 0x0032C7B0 File Offset: 0x0032A9B0
		public UMovieScenePostSpawnEventSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePostSpawnEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022564 RID: 140644 RVA: 0x0032C7D8 File Offset: 0x0032A9D8
		[NullableContext(1)]
		public UMovieScenePostSpawnEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePostSpawnEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022565 RID: 140645 RVA: 0x0032C80B File Offset: 0x0032AA0B
		static UMovieScenePostSpawnEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePostSpawnEventSystem");
		}

		// Token: 0x06022566 RID: 140646 RVA: 0x0032C819 File Offset: 0x0032AA19
		protected UMovieScenePostSpawnEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012543 RID: 75075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePostSpawnEventSystem";

		// Token: 0x04012544 RID: 75076
		private static IntPtr _ClassPtr;

		// Token: 0x04012545 RID: 75077
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
