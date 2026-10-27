using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023B3 RID: 9139
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneTransformOriginSystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UMovieSceneTransformOriginSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602267A RID: 140922 RVA: 0x0032E269 File Offset: 0x0032C469
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTransformOriginSystem._ClassPtr;
		}

		// Token: 0x0602267B RID: 140923 RVA: 0x0032E278 File Offset: 0x0032C478
		public UMovieSceneTransformOriginSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTransformOriginSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602267C RID: 140924 RVA: 0x0032E2A0 File Offset: 0x0032C4A0
		[NullableContext(1)]
		public UMovieSceneTransformOriginSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTransformOriginSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602267D RID: 140925 RVA: 0x0032E2D3 File Offset: 0x0032C4D3
		static UMovieSceneTransformOriginSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneTransformOriginSystem");
		}

		// Token: 0x0602267E RID: 140926 RVA: 0x0032E2E1 File Offset: 0x0032C4E1
		protected UMovieSceneTransformOriginSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125DF RID: 75231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneTransformOriginSystem";

		// Token: 0x040125E0 RID: 75232
		private static IntPtr _ClassPtr;

		// Token: 0x040125E1 RID: 75233
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
