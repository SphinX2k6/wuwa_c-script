using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002384 RID: 9092
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneInterrogatedPropertyInstantiatorSystem")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMovieSceneInterrogatedPropertyInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022475 RID: 140405 RVA: 0x0032B1CA File Offset: 0x003293CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneInterrogatedPropertyInstantiatorSystem._ClassPtr;
		}

		// Token: 0x06022476 RID: 140406 RVA: 0x0032B1D8 File Offset: 0x003293D8
		public UMovieSceneInterrogatedPropertyInstantiatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneInterrogatedPropertyInstantiatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022477 RID: 140407 RVA: 0x0032B200 File Offset: 0x00329400
		[NullableContext(1)]
		public UMovieSceneInterrogatedPropertyInstantiatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneInterrogatedPropertyInstantiatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022478 RID: 140408 RVA: 0x0032B233 File Offset: 0x00329433
		static UMovieSceneInterrogatedPropertyInstantiatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneInterrogatedPropertyInstantiatorSystem");
		}

		// Token: 0x06022479 RID: 140409 RVA: 0x0032B241 File Offset: 0x00329441
		protected UMovieSceneInterrogatedPropertyInstantiatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124CC RID: 74956
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneInterrogatedPropertyInstantiatorSystem";

		// Token: 0x040124CD RID: 74957
		private static IntPtr _ClassPtr;

		// Token: 0x040124CE RID: 74958
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
