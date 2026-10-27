using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002380 RID: 9088
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneHierarchicalEasingInstantiatorSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022457 RID: 140375 RVA: 0x0032AED6 File Offset: 0x003290D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneHierarchicalEasingInstantiatorSystem._ClassPtr;
		}

		// Token: 0x06022458 RID: 140376 RVA: 0x0032AEE4 File Offset: 0x003290E4
		public UMovieSceneHierarchicalEasingInstantiatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneHierarchicalEasingInstantiatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022459 RID: 140377 RVA: 0x0032AF0C File Offset: 0x0032910C
		[NullableContext(1)]
		public UMovieSceneHierarchicalEasingInstantiatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneHierarchicalEasingInstantiatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602245A RID: 140378 RVA: 0x0032AF3F File Offset: 0x0032913F
		static UMovieSceneHierarchicalEasingInstantiatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneHierarchicalEasingInstantiatorSystem");
		}

		// Token: 0x0602245B RID: 140379 RVA: 0x0032AF4D File Offset: 0x0032914D
		protected UMovieSceneHierarchicalEasingInstantiatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124BB RID: 74939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneHierarchicalEasingInstantiatorSystem";

		// Token: 0x040124BC RID: 74940
		private static IntPtr _ClassPtr;

		// Token: 0x040124BD RID: 74941
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
