using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076D RID: 1901
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFloatTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneFloatTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4CD RID: 42189 RVA: 0x000F3749 File Offset: 0x000F1949
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFloatTrack._ClassPtr;
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x000F3758 File Offset: 0x000F1958
		public UMovieSceneFloatTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x000F3780 File Offset: 0x000F1980
		[NullableContext(1)]
		public UMovieSceneFloatTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x000F37B3 File Offset: 0x000F19B3
		static UMovieSceneFloatTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFloatTrack");
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x000F37C1 File Offset: 0x000F19C1
		protected UMovieSceneFloatTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004657 RID: 18007
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFloatTrack";

		// Token: 0x04004658 RID: 18008
		private static IntPtr _ClassPtr;

		// Token: 0x04004659 RID: 18009
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
