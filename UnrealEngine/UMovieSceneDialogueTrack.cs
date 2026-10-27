using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026EF RID: 9967
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneDialogueTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024F75 RID: 151413 RVA: 0x0036AEDA File Offset: 0x003690DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueTrack._ClassPtr;
		}

		// Token: 0x06024F76 RID: 151414 RVA: 0x0036AEE6 File Offset: 0x003690E6
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneDialogueTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06024F77 RID: 151415 RVA: 0x0036AEF0 File Offset: 0x003690F0
		public UMovieSceneDialogueTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F78 RID: 151416 RVA: 0x0036AF18 File Offset: 0x00369118
		[NullableContext(1)]
		public UMovieSceneDialogueTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EBC RID: 36540
		// (get) Token: 0x06024F79 RID: 151417 RVA: 0x0036AF4C File Offset: 0x0036914C
		// (set) Token: 0x06024F7A RID: 151418 RVA: 0x0036AF85 File Offset: 0x00369185
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x17008EBD RID: 36541
		// (get) Token: 0x06024F7B RID: 151419 RVA: 0x0036AF93 File Offset: 0x00369193
		// (set) Token: 0x06024F7C RID: 151420 RVA: 0x0036AFA3 File Offset: 0x003691A3
		public unsafe ELanguageAudio LanguageType
		{
			get
			{
				return (ELanguageAudio)(*(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_LanguageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_LanguageType) = (byte)value;
			}
		}

		// Token: 0x06024F7D RID: 151421 RVA: 0x0036AFB4 File Offset: 0x003691B4
		static UMovieSceneDialogueTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueTrack");
		}

		// Token: 0x06024F7E RID: 151422 RVA: 0x0036AFC2 File Offset: 0x003691C2
		protected UMovieSceneDialogueTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EBC RID: 81596
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013EBD RID: 81597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueTrack";

		// Token: 0x04013EBE RID: 81598
		private static IntPtr _ClassPtr;

		// Token: 0x04013EBF RID: 81599
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EC0 RID: 81600
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013EC1 RID: 81601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x04013EC2 RID: 81602
		internal static int __PropertyOffset_LanguageType;
	}
}
