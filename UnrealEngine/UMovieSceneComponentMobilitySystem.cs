using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002362 RID: 9058
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentMobilitySystem")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UMovieSceneComponentMobilitySystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject, IMovieScenePreAnimatedStateSystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022357 RID: 140119 RVA: 0x00329613 File Offset: 0x00327813
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentMobilitySystem._ClassPtr;
		}

		// Token: 0x06022358 RID: 140120 RVA: 0x0032961F File Offset: 0x0032781F
		int IMovieScenePreAnimatedStateSystemInterface.InterfaceOffset()
		{
			return UMovieSceneComponentMobilitySystem.__InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;
		}

		// Token: 0x06022359 RID: 140121 RVA: 0x00329628 File Offset: 0x00327828
		public UMovieSceneComponentMobilitySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMobilitySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602235A RID: 140122 RVA: 0x00329650 File Offset: 0x00327850
		[NullableContext(1)]
		public UMovieSceneComponentMobilitySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMobilitySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602235B RID: 140123 RVA: 0x00329683 File Offset: 0x00327883
		static UMovieSceneComponentMobilitySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentMobilitySystem");
		}

		// Token: 0x0602235C RID: 140124 RVA: 0x00329691 File Offset: 0x00327891
		protected UMovieSceneComponentMobilitySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401242A RID: 74794
		internal static int __InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;

		// Token: 0x0401242B RID: 74795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentMobilitySystem";

		// Token: 0x0401242C RID: 74796
		private static IntPtr _ClassPtr;

		// Token: 0x0401242D RID: 74797
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
