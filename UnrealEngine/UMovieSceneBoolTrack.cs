using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002341 RID: 9025
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneBoolTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneBoolTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060221FA RID: 139770 RVA: 0x00327469 File Offset: 0x00325669
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBoolTrack._ClassPtr;
		}

		// Token: 0x060221FB RID: 139771 RVA: 0x00327475 File Offset: 0x00325675
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneBoolTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060221FC RID: 139772 RVA: 0x0032747C File Offset: 0x0032567C
		public UMovieSceneBoolTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221FD RID: 139773 RVA: 0x003274A4 File Offset: 0x003256A4
		[NullableContext(1)]
		public UMovieSceneBoolTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221FE RID: 139774 RVA: 0x003274D7 File Offset: 0x003256D7
		static UMovieSceneBoolTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneBoolTrack");
		}

		// Token: 0x060221FF RID: 139775 RVA: 0x003274E5 File Offset: 0x003256E5
		protected UMovieSceneBoolTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012367 RID: 74599
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012368 RID: 74600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneBoolTrack";

		// Token: 0x04012369 RID: 74601
		private static IntPtr _ClassPtr;

		// Token: 0x0401236A RID: 74602
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
