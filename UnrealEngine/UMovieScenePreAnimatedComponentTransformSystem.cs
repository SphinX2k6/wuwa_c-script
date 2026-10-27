using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239B RID: 9115
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePreAnimatedComponentTransformSystem")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UMovieScenePreAnimatedComponentTransformSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject, IMovieScenePreAnimatedStateSystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022567 RID: 140647 RVA: 0x0032C822 File Offset: 0x0032AA22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePreAnimatedComponentTransformSystem._ClassPtr;
		}

		// Token: 0x06022568 RID: 140648 RVA: 0x0032C82E File Offset: 0x0032AA2E
		int IMovieScenePreAnimatedStateSystemInterface.InterfaceOffset()
		{
			return UMovieScenePreAnimatedComponentTransformSystem.__InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;
		}

		// Token: 0x06022569 RID: 140649 RVA: 0x0032C838 File Offset: 0x0032AA38
		public UMovieScenePreAnimatedComponentTransformSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePreAnimatedComponentTransformSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602256A RID: 140650 RVA: 0x0032C860 File Offset: 0x0032AA60
		[NullableContext(1)]
		public UMovieScenePreAnimatedComponentTransformSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePreAnimatedComponentTransformSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602256B RID: 140651 RVA: 0x0032C893 File Offset: 0x0032AA93
		static UMovieScenePreAnimatedComponentTransformSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePreAnimatedComponentTransformSystem");
		}

		// Token: 0x0602256C RID: 140652 RVA: 0x0032C8A1 File Offset: 0x0032AAA1
		protected UMovieScenePreAnimatedComponentTransformSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012546 RID: 75078
		internal static int __InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;

		// Token: 0x04012547 RID: 75079
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePreAnimatedComponentTransformSystem";

		// Token: 0x04012548 RID: 75080
		private static IntPtr _ClassPtr;

		// Token: 0x04012549 RID: 75081
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
