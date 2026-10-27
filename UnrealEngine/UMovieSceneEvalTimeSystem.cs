using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023F4 RID: 9204
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvalTimeSystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieSceneEvalTimeSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022891 RID: 141457 RVA: 0x003314E1 File Offset: 0x0032F6E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEvalTimeSystem._ClassPtr;
		}

		// Token: 0x06022892 RID: 141458 RVA: 0x003314F0 File Offset: 0x0032F6F0
		public UMovieSceneEvalTimeSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEvalTimeSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022893 RID: 141459 RVA: 0x00331518 File Offset: 0x0032F718
		[NullableContext(1)]
		public UMovieSceneEvalTimeSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEvalTimeSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022894 RID: 141460 RVA: 0x0033154B File Offset: 0x0032F74B
		static UMovieSceneEvalTimeSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneEvalTimeSystem");
		}

		// Token: 0x06022895 RID: 141461 RVA: 0x00331559 File Offset: 0x0032F759
		protected UMovieSceneEvalTimeSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012757 RID: 75607
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEvalTimeSystem";

		// Token: 0x04012758 RID: 75608
		private static IntPtr _ClassPtr;

		// Token: 0x04012759 RID: 75609
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
