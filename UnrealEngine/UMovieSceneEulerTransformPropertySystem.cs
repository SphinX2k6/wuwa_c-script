using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002369 RID: 9065
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEulerTransformPropertySystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieSceneEulerTransformPropertySystem : UMovieScenePropertySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602238D RID: 140173 RVA: 0x00329B6B File Offset: 0x00327D6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEulerTransformPropertySystem._ClassPtr;
		}

		// Token: 0x0602238E RID: 140174 RVA: 0x00329B78 File Offset: 0x00327D78
		public UMovieSceneEulerTransformPropertySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEulerTransformPropertySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602238F RID: 140175 RVA: 0x00329BA0 File Offset: 0x00327DA0
		[NullableContext(1)]
		public UMovieSceneEulerTransformPropertySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEulerTransformPropertySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022390 RID: 140176 RVA: 0x00329BD3 File Offset: 0x00327DD3
		static UMovieSceneEulerTransformPropertySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEulerTransformPropertySystem");
		}

		// Token: 0x06022391 RID: 140177 RVA: 0x00329BE1 File Offset: 0x00327DE1
		protected UMovieSceneEulerTransformPropertySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012449 RID: 74825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEulerTransformPropertySystem";

		// Token: 0x0401244A RID: 74826
		private static IntPtr _ClassPtr;

		// Token: 0x0401244B RID: 74827
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
