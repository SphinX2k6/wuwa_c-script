using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237C RID: 9084
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFloatPropertySystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieSceneFloatPropertySystem : UMovieScenePropertySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022440 RID: 140352 RVA: 0x0032AC72 File Offset: 0x00328E72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFloatPropertySystem._ClassPtr;
		}

		// Token: 0x06022441 RID: 140353 RVA: 0x0032AC80 File Offset: 0x00328E80
		public UMovieSceneFloatPropertySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatPropertySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022442 RID: 140354 RVA: 0x0032ACA8 File Offset: 0x00328EA8
		[NullableContext(1)]
		public UMovieSceneFloatPropertySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatPropertySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022443 RID: 140355 RVA: 0x0032ACDB File Offset: 0x00328EDB
		static UMovieSceneFloatPropertySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFloatPropertySystem");
		}

		// Token: 0x06022444 RID: 140356 RVA: 0x0032ACE9 File Offset: 0x00328EE9
		protected UMovieSceneFloatPropertySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124AC RID: 74924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFloatPropertySystem";

		// Token: 0x040124AD RID: 74925
		private static IntPtr _ClassPtr;

		// Token: 0x040124AE RID: 74926
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
