using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016A1 RID: 5793
	[UnrealObjectPath("/Script/KuroAudio.MovieSceneKuroAudioEventTrack")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMovieSceneKuroAudioEventTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06015017 RID: 86039 RVA: 0x001EDE5E File Offset: 0x001EC05E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroAudioEventTrack._ClassPtr;
		}

		// Token: 0x06015018 RID: 86040 RVA: 0x001EDE6A File Offset: 0x001EC06A
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneKuroAudioEventTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06015019 RID: 86041 RVA: 0x001EDE74 File Offset: 0x001EC074
		public UMovieSceneKuroAudioEventTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroAudioEventTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601501A RID: 86042 RVA: 0x001EDE9C File Offset: 0x001EC09C
		[NullableContext(1)]
		public UMovieSceneKuroAudioEventTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroAudioEventTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x0601501B RID: 86043 RVA: 0x001EDED0 File Offset: 0x001EC0D0
		// (set) Token: 0x0601501C RID: 86044 RVA: 0x001EDF09 File Offset: 0x001EC109
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0601501D RID: 86045 RVA: 0x001EDF17 File Offset: 0x001EC117
		static UMovieSceneKuroAudioEventTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.MovieSceneKuroAudioEventTrack");
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x001EDF25 File Offset: 0x001EC125
		protected UMovieSceneKuroAudioEventTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6FF RID: 46847
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400B700 RID: 46848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.MovieSceneKuroAudioEventTrack";

		// Token: 0x0400B701 RID: 46849
		private static IntPtr _ClassPtr;

		// Token: 0x0400B702 RID: 46850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B703 RID: 46851
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400B704 RID: 46852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
