using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200235D RID: 9053
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneColorTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneColorTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022332 RID: 140082 RVA: 0x003292E4 File Offset: 0x003274E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneColorTrack._ClassPtr;
		}

		// Token: 0x06022333 RID: 140083 RVA: 0x003292F0 File Offset: 0x003274F0
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneColorTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022334 RID: 140084 RVA: 0x003292F8 File Offset: 0x003274F8
		public UMovieSceneColorTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneColorTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022335 RID: 140085 RVA: 0x00329320 File Offset: 0x00327520
		[NullableContext(1)]
		public UMovieSceneColorTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneColorTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700840E RID: 33806
		// (get) Token: 0x06022336 RID: 140086 RVA: 0x00329353 File Offset: 0x00327553
		// (set) Token: 0x06022337 RID: 140087 RVA: 0x00329363 File Offset: 0x00327563
		public unsafe bool bIsSlateColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneColorTrack.__PropertyOffset_bIsSlateColor_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneColorTrack.__PropertyOffset_bIsSlateColor_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022338 RID: 140088 RVA: 0x00329374 File Offset: 0x00327574
		static UMovieSceneColorTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneColorTrack");
		}

		// Token: 0x06022339 RID: 140089 RVA: 0x00329382 File Offset: 0x00327582
		protected UMovieSceneColorTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012416 RID: 74774
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012417 RID: 74775
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneColorTrack";

		// Token: 0x04012418 RID: 74776
		private static IntPtr _ClassPtr;

		// Token: 0x04012419 RID: 74777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401241A RID: 74778
		internal static int __PropertyOffset_bIsSlateColor_DEPRECATED;
	}
}
