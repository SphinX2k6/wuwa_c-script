using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243F RID: 9279
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnSection")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UMovieSceneSpawnSection : UMovieSceneBoolSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022CAD RID: 142509 RVA: 0x00337172 File Offset: 0x00335372
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSpawnSection._ClassPtr;
		}

		// Token: 0x06022CAE RID: 142510 RVA: 0x0033717E File Offset: 0x0033537E
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneSpawnSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06022CAF RID: 142511 RVA: 0x00337188 File Offset: 0x00335388
		public UMovieSceneSpawnSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022CB0 RID: 142512 RVA: 0x003371B0 File Offset: 0x003353B0
		[NullableContext(1)]
		public UMovieSceneSpawnSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022CB1 RID: 142513 RVA: 0x003371E3 File Offset: 0x003353E3
		static UMovieSceneSpawnSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSpawnSection");
		}

		// Token: 0x06022CB2 RID: 142514 RVA: 0x003371F1 File Offset: 0x003353F1
		protected UMovieSceneSpawnSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012938 RID: 76088
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x04012939 RID: 76089
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnSection";

		// Token: 0x0401293A RID: 76090
		private static IntPtr _ClassPtr;

		// Token: 0x0401293B RID: 76091
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
