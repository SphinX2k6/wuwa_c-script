using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023AC RID: 9132
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSlomoTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneSlomoTrack : UMovieSceneFloatTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022641 RID: 140865 RVA: 0x0032DD4D File Offset: 0x0032BF4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSlomoTrack._ClassPtr;
		}

		// Token: 0x06022642 RID: 140866 RVA: 0x0032DD59 File Offset: 0x0032BF59
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneSlomoTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022643 RID: 140867 RVA: 0x0032DD60 File Offset: 0x0032BF60
		public UMovieSceneSlomoTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSlomoTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022644 RID: 140868 RVA: 0x0032DD88 File Offset: 0x0032BF88
		[NullableContext(1)]
		public UMovieSceneSlomoTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSlomoTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022645 RID: 140869 RVA: 0x0032DDBB File Offset: 0x0032BFBB
		static UMovieSceneSlomoTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSlomoTrack");
		}

		// Token: 0x06022646 RID: 140870 RVA: 0x0032DDC9 File Offset: 0x0032BFC9
		protected UMovieSceneSlomoTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125C2 RID: 75202
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040125C3 RID: 75203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSlomoTrack";

		// Token: 0x040125C4 RID: 75204
		private static IntPtr _ClassPtr;

		// Token: 0x040125C5 RID: 75205
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
