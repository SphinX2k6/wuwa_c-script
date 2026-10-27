using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023B4 RID: 9140
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneTransformTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneTransformTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602267F RID: 140927 RVA: 0x0032E2EA File Offset: 0x0032C4EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTransformTrack._ClassPtr;
		}

		// Token: 0x06022680 RID: 140928 RVA: 0x0032E2F8 File Offset: 0x0032C4F8
		public UMovieSceneTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022681 RID: 140929 RVA: 0x0032E320 File Offset: 0x0032C520
		[NullableContext(1)]
		public UMovieSceneTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022682 RID: 140930 RVA: 0x0032E353 File Offset: 0x0032C553
		static UMovieSceneTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneTransformTrack");
		}

		// Token: 0x06022683 RID: 140931 RVA: 0x0032E361 File Offset: 0x0032C561
		protected UMovieSceneTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125E2 RID: 75234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneTransformTrack";

		// Token: 0x040125E3 RID: 75235
		private static IntPtr _ClassPtr;

		// Token: 0x040125E4 RID: 75236
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
