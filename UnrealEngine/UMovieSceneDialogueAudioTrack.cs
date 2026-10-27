using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026E7 RID: 9959
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueAudioTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneDialogueAudioTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024EEB RID: 151275 RVA: 0x00369F25 File Offset: 0x00368125
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueAudioTrack._ClassPtr;
		}

		// Token: 0x06024EEC RID: 151276 RVA: 0x00369F31 File Offset: 0x00368131
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneDialogueAudioTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06024EED RID: 151277 RVA: 0x00369F38 File Offset: 0x00368138
		public UMovieSceneDialogueAudioTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueAudioTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EEE RID: 151278 RVA: 0x00369F60 File Offset: 0x00368160
		[NullableContext(1)]
		public UMovieSceneDialogueAudioTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueAudioTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E93 RID: 36499
		// (get) Token: 0x06024EEF RID: 151279 RVA: 0x00369F94 File Offset: 0x00368194
		// (set) Token: 0x06024EF0 RID: 151280 RVA: 0x00369FCD File Offset: 0x003681CD
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneDialogueAudioTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06024EF1 RID: 151281 RVA: 0x00369FDB File Offset: 0x003681DB
		static UMovieSceneDialogueAudioTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueAudioTrack");
		}

		// Token: 0x06024EF2 RID: 151282 RVA: 0x00369FE9 File Offset: 0x003681E9
		protected UMovieSceneDialogueAudioTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E65 RID: 81509
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013E66 RID: 81510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueAudioTrack";

		// Token: 0x04013E67 RID: 81511
		private static IntPtr _ClassPtr;

		// Token: 0x04013E68 RID: 81512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E69 RID: 81513
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013E6A RID: 81514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
