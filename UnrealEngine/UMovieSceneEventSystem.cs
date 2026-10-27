using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002375 RID: 9077
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieSceneEventSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060223FA RID: 140282 RVA: 0x0032A54F File Offset: 0x0032874F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventSystem._ClassPtr;
		}

		// Token: 0x060223FB RID: 140283 RVA: 0x0032A55C File Offset: 0x0032875C
		public UMovieSceneEventSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223FC RID: 140284 RVA: 0x0032A584 File Offset: 0x00328784
		[NullableContext(1)]
		public UMovieSceneEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060223FD RID: 140285 RVA: 0x0032A5B7 File Offset: 0x003287B7
		static UMovieSceneEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventSystem");
		}

		// Token: 0x060223FE RID: 140286 RVA: 0x0032A5C5 File Offset: 0x003287C5
		protected UMovieSceneEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012480 RID: 74880
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSystem";

		// Token: 0x04012481 RID: 74881
		private static IntPtr _ClassPtr;

		// Token: 0x04012482 RID: 74882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
