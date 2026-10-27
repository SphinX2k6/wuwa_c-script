using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200233A RID: 9018
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneActorReferenceTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneActorReferenceTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602219E RID: 139678 RVA: 0x00326BF9 File Offset: 0x00324DF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneActorReferenceTrack._ClassPtr;
		}

		// Token: 0x0602219F RID: 139679 RVA: 0x00326C05 File Offset: 0x00324E05
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneActorReferenceTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060221A0 RID: 139680 RVA: 0x00326C0C File Offset: 0x00324E0C
		public UMovieSceneActorReferenceTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneActorReferenceTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221A1 RID: 139681 RVA: 0x00326C34 File Offset: 0x00324E34
		[NullableContext(1)]
		public UMovieSceneActorReferenceTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneActorReferenceTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221A2 RID: 139682 RVA: 0x00326C67 File Offset: 0x00324E67
		static UMovieSceneActorReferenceTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneActorReferenceTrack");
		}

		// Token: 0x060221A3 RID: 139683 RVA: 0x00326C75 File Offset: 0x00324E75
		protected UMovieSceneActorReferenceTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012337 RID: 74551
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012338 RID: 74552
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneActorReferenceTrack";

		// Token: 0x04012339 RID: 74553
		private static IntPtr _ClassPtr;

		// Token: 0x0401233A RID: 74554
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
