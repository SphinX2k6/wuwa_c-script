using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000761 RID: 1889
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneBoolTrack")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneBoolTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A46D RID: 42093 RVA: 0x000F2DC2 File Offset: 0x000F0FC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBoolTrack._ClassPtr;
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x000F2DD0 File Offset: 0x000F0FD0
		public UMovieSceneBoolTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x000F2DF8 File Offset: 0x000F0FF8
		[NullableContext(1)]
		public UMovieSceneBoolTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x000F2E2B File Offset: 0x000F102B
		static UMovieSceneBoolTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneBoolTrack");
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x000F2E39 File Offset: 0x000F1039
		protected UMovieSceneBoolTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400461F RID: 17951
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneBoolTrack";

		// Token: 0x04004620 RID: 17952
		private static IntPtr _ClassPtr;

		// Token: 0x04004621 RID: 17953
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
