using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002383 RID: 9091
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneIntegerTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneIntegerTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602246F RID: 140399 RVA: 0x0032B145 File Offset: 0x00329345
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneIntegerTrack._ClassPtr;
		}

		// Token: 0x06022470 RID: 140400 RVA: 0x0032B151 File Offset: 0x00329351
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneIntegerTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022471 RID: 140401 RVA: 0x0032B158 File Offset: 0x00329358
		public UMovieSceneIntegerTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneIntegerTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022472 RID: 140402 RVA: 0x0032B180 File Offset: 0x00329380
		[NullableContext(1)]
		public UMovieSceneIntegerTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneIntegerTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022473 RID: 140403 RVA: 0x0032B1B3 File Offset: 0x003293B3
		static UMovieSceneIntegerTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneIntegerTrack");
		}

		// Token: 0x06022474 RID: 140404 RVA: 0x0032B1C1 File Offset: 0x003293C1
		protected UMovieSceneIntegerTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124C8 RID: 74952
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040124C9 RID: 74953
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneIntegerTrack";

		// Token: 0x040124CA RID: 74954
		private static IntPtr _ClassPtr;

		// Token: 0x040124CB RID: 74955
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
