using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076B RID: 1899
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFadeTrack")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneFadeTrack : UMovieSceneFloatTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4C1 RID: 42177 RVA: 0x000F35EF File Offset: 0x000F17EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFadeTrack._ClassPtr;
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x000F35FC File Offset: 0x000F17FC
		public UMovieSceneFadeTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x000F3624 File Offset: 0x000F1824
		[NullableContext(1)]
		public UMovieSceneFadeTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x000F3657 File Offset: 0x000F1857
		static UMovieSceneFadeTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFadeTrack");
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x000F3665 File Offset: 0x000F1865
		protected UMovieSceneFadeTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400464F RID: 17999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFadeTrack";

		// Token: 0x04004650 RID: 18000
		private static IntPtr _ClassPtr;

		// Token: 0x04004651 RID: 18001
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
