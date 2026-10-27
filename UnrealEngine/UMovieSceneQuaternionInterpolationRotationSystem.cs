using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A3 RID: 9123
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneQuaternionInterpolationRotationSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneQuaternionInterpolationRotationSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225A3 RID: 140707 RVA: 0x0032CDD1 File Offset: 0x0032AFD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQuaternionInterpolationRotationSystem._ClassPtr;
		}

		// Token: 0x060225A4 RID: 140708 RVA: 0x0032CDE0 File Offset: 0x0032AFE0
		public UMovieSceneQuaternionInterpolationRotationSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQuaternionInterpolationRotationSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225A5 RID: 140709 RVA: 0x0032CE08 File Offset: 0x0032B008
		[NullableContext(1)]
		public UMovieSceneQuaternionInterpolationRotationSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQuaternionInterpolationRotationSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060225A6 RID: 140710 RVA: 0x0032CE3B File Offset: 0x0032B03B
		static UMovieSceneQuaternionInterpolationRotationSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneQuaternionInterpolationRotationSystem");
		}

		// Token: 0x060225A7 RID: 140711 RVA: 0x0032CE49 File Offset: 0x0032B049
		protected UMovieSceneQuaternionInterpolationRotationSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401256C RID: 75116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneQuaternionInterpolationRotationSystem";

		// Token: 0x0401256D RID: 75117
		private static IntPtr _ClassPtr;

		// Token: 0x0401256E RID: 75118
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
