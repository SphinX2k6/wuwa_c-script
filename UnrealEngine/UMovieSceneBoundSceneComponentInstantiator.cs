using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023DB RID: 9179
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBoundSceneComponentInstantiator")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneBoundSceneComponentInstantiator : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022790 RID: 141200 RVA: 0x0032FB9D File Offset: 0x0032DD9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBoundSceneComponentInstantiator._ClassPtr;
		}

		// Token: 0x06022791 RID: 141201 RVA: 0x0032FBAC File Offset: 0x0032DDAC
		public UMovieSceneBoundSceneComponentInstantiator() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoundSceneComponentInstantiator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022792 RID: 141202 RVA: 0x0032FBD4 File Offset: 0x0032DDD4
		[NullableContext(1)]
		public UMovieSceneBoundSceneComponentInstantiator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoundSceneComponentInstantiator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022793 RID: 141203 RVA: 0x0032FC07 File Offset: 0x0032DE07
		static UMovieSceneBoundSceneComponentInstantiator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBoundSceneComponentInstantiator");
		}

		// Token: 0x06022794 RID: 141204 RVA: 0x0032FC15 File Offset: 0x0032DE15
		protected UMovieSceneBoundSceneComponentInstantiator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126CF RID: 75471
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBoundSceneComponentInstantiator";

		// Token: 0x040126D0 RID: 75472
		private static IntPtr _ClassPtr;

		// Token: 0x040126D1 RID: 75473
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
