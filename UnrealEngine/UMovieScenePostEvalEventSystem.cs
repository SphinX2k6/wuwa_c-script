using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002399 RID: 9113
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePostEvalEventSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieScenePostEvalEventSystem : UMovieSceneEventSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602255D RID: 140637 RVA: 0x0032C722 File Offset: 0x0032A922
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePostEvalEventSystem._ClassPtr;
		}

		// Token: 0x0602255E RID: 140638 RVA: 0x0032C730 File Offset: 0x0032A930
		public UMovieScenePostEvalEventSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePostEvalEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602255F RID: 140639 RVA: 0x0032C758 File Offset: 0x0032A958
		[NullableContext(1)]
		public UMovieScenePostEvalEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePostEvalEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022560 RID: 140640 RVA: 0x0032C78B File Offset: 0x0032A98B
		static UMovieScenePostEvalEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePostEvalEventSystem");
		}

		// Token: 0x06022561 RID: 140641 RVA: 0x0032C799 File Offset: 0x0032A999
		protected UMovieScenePostEvalEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012540 RID: 75072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePostEvalEventSystem";

		// Token: 0x04012541 RID: 75073
		private static IntPtr _ClassPtr;

		// Token: 0x04012542 RID: 75074
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
