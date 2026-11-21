using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075F RID: 1887
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieScene3DTransformTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A461 RID: 42081 RVA: 0x000F2C7A File Offset: 0x000F0E7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DTransformTrack._ClassPtr;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x000F2C88 File Offset: 0x000F0E88
		public UMovieScene3DTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x000F2CB0 File Offset: 0x000F0EB0
		[NullableContext(1)]
		public UMovieScene3DTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x000F2CE3 File Offset: 0x000F0EE3
		static UMovieScene3DTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DTransformTrack");
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x000F2CF1 File Offset: 0x000F0EF1
		protected UMovieScene3DTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004617 RID: 17943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformTrack";

		// Token: 0x04004618 RID: 17944
		private static IntPtr _ClassPtr;

		// Token: 0x04004619 RID: 17945
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
