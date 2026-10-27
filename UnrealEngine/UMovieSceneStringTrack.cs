using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023B0 RID: 9136
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneStringTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneStringTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022668 RID: 140904 RVA: 0x0032E10D File Offset: 0x0032C30D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneStringTrack._ClassPtr;
		}

		// Token: 0x06022669 RID: 140905 RVA: 0x0032E119 File Offset: 0x0032C319
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneStringTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602266A RID: 140906 RVA: 0x0032E120 File Offset: 0x0032C320
		public UMovieSceneStringTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneStringTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602266B RID: 140907 RVA: 0x0032E148 File Offset: 0x0032C348
		[NullableContext(1)]
		public UMovieSceneStringTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneStringTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x0032E17B File Offset: 0x0032C37B
		static UMovieSceneStringTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneStringTrack");
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x0032E189 File Offset: 0x0032C389
		protected UMovieSceneStringTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125D7 RID: 75223
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040125D8 RID: 75224
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneStringTrack";

		// Token: 0x040125D9 RID: 75225
		private static IntPtr _ClassPtr;

		// Token: 0x040125DA RID: 75226
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
