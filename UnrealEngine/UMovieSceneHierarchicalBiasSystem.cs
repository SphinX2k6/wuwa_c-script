using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237F RID: 9087
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneHierarchicalBiasSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneHierarchicalBiasSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022452 RID: 140370 RVA: 0x0032AE56 File Offset: 0x00329056
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneHierarchicalBiasSystem._ClassPtr;
		}

		// Token: 0x06022453 RID: 140371 RVA: 0x0032AE64 File Offset: 0x00329064
		public UMovieSceneHierarchicalBiasSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneHierarchicalBiasSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022454 RID: 140372 RVA: 0x0032AE8C File Offset: 0x0032908C
		[NullableContext(1)]
		public UMovieSceneHierarchicalBiasSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneHierarchicalBiasSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022455 RID: 140373 RVA: 0x0032AEBF File Offset: 0x003290BF
		static UMovieSceneHierarchicalBiasSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneHierarchicalBiasSystem");
		}

		// Token: 0x06022456 RID: 140374 RVA: 0x0032AECD File Offset: 0x003290CD
		protected UMovieSceneHierarchicalBiasSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124B8 RID: 74936
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneHierarchicalBiasSystem";

		// Token: 0x040124B9 RID: 74937
		private static IntPtr _ClassPtr;

		// Token: 0x040124BA RID: 74938
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
