using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200233E RID: 9022
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneAudioTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneAudioTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060221E3 RID: 139747 RVA: 0x00327231 File Offset: 0x00325431
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAudioTrack._ClassPtr;
		}

		// Token: 0x060221E4 RID: 139748 RVA: 0x0032723D File Offset: 0x0032543D
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneAudioTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060221E5 RID: 139749 RVA: 0x00327244 File Offset: 0x00325444
		public UMovieSceneAudioTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221E6 RID: 139750 RVA: 0x0032726C File Offset: 0x0032546C
		[NullableContext(1)]
		public UMovieSceneAudioTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083CD RID: 33741
		// (get) Token: 0x060221E7 RID: 139751 RVA: 0x003272A0 File Offset: 0x003254A0
		// (set) Token: 0x060221E8 RID: 139752 RVA: 0x003272D9 File Offset: 0x003254D9
		[Nullable(1)]
		public TArray<UMovieSceneSection> AudioSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._AudioSections) == null)
				{
					result = (this._AudioSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneAudioTrack.__PropertyOffset_AudioSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AudioSections.CopyAssign(value);
			}
		}

		// Token: 0x060221E9 RID: 139753 RVA: 0x003272E7 File Offset: 0x003254E7
		static UMovieSceneAudioTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneAudioTrack");
		}

		// Token: 0x060221EA RID: 139754 RVA: 0x003272F5 File Offset: 0x003254F5
		protected UMovieSceneAudioTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401235A RID: 74586
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0401235B RID: 74587
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneAudioTrack";

		// Token: 0x0401235C RID: 74588
		private static IntPtr _ClassPtr;

		// Token: 0x0401235D RID: 74589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401235E RID: 74590
		internal static int __PropertyOffset_AudioSections;

		// Token: 0x0401235F RID: 74591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _AudioSections;
	}
}
