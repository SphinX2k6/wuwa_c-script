using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002365 RID: 9061
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentTransformSystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieSceneComponentTransformSystem : UMovieScenePropertySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602236F RID: 140143 RVA: 0x00329876 File Offset: 0x00327A76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentTransformSystem._ClassPtr;
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x00329884 File Offset: 0x00327A84
		public UMovieSceneComponentTransformSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentTransformSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022371 RID: 140145 RVA: 0x003298AC File Offset: 0x00327AAC
		[NullableContext(1)]
		public UMovieSceneComponentTransformSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentTransformSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022372 RID: 140146 RVA: 0x003298DF File Offset: 0x00327ADF
		static UMovieSceneComponentTransformSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentTransformSystem");
		}

		// Token: 0x06022373 RID: 140147 RVA: 0x003298ED File Offset: 0x00327AED
		protected UMovieSceneComponentTransformSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012438 RID: 74808
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentTransformSystem";

		// Token: 0x04012439 RID: 74809
		private static IntPtr _ClassPtr;

		// Token: 0x0401243A RID: 74810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
